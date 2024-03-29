﻿using Database.Classes;
using Database.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Services
{
    public class QuizService
    {
        private static readonly EncuestadorAppContext _context = new();

        public static async Task<Res> Create(string name, int userId, List<string> questions)
        {
            // validations
            if (questions.Count < 1)
            {
                return new Res(null, "¡La encuesta debe tener al menos 1 pregunta!", true);
            }

            try
            {
                var quiz = new Quiz()
                {
                    Name = name,
                    UserId = userId
                };

                var createdQuiz = await _context.Quizzes.AddAsync(quiz);

                await _context.SaveChangesAsync();

                var _questions = new List<QuizQuestion>();

                questions.ForEach((question) =>
                {
                    _questions.Add(new QuizQuestion()
                    {
                        Question = question,
                        QuizId = quiz.Id
                    });
                });

                await _context.QuizQuestions.AddRangeAsync(_questions);
                await _context.SaveChangesAsync();
            }
            catch (Exception)
            {
                return new Res(null, "¡Se ha producido un error creando la encuesta!", true);
            }

            return new Res(null, "Encuesta creada exitosamente", false);
        }

        // Get all quizzes from a user
        public static async Task<Res> GetAllByUserId(int userId)
        {
            try
            {
                var quizList = await _context.Quizzes.Include(x => x.Respondents).Where(x => x.UserId == userId).ToListAsync();
                if (quizList.Count < 1)
                    return new Res(null, "No hay encuestas para cargar, agregue algunas!", true);
                else
                    return new Res(quizList, "Se han cargado las encuestas", false);
            }
            catch (Exception)
            {
                return new Res(null, "¡Se ha producido un error cargando las encuestas!", true);
            }
        }

        public static async Task<Res> GetQuizById(int id)
        {
            try
            {
                var quiz = await _context.Quizzes.Include(x => x.QuizQuestions).Where(x => x.Id == id).FirstOrDefaultAsync().ConfigureAwait(false);
                if (quiz == null)
                    return new Res(null, "¡Esta encuesta no existe!", true);
                else
                    return new Res(quiz, "Se ha cargado la encuesta", false);
            }
            catch (Exception)
            {
                return new Res(null, "¡Se ha producido un error cargando las encuestas!", true);
            }
        }

        public static async Task<Res> Delete(int id)
        {
            try
            {
                var quiz = await _context.Quizzes
                    .Where(x => x.Id == id)
                    .Include(x => x.Respondents)
                    .Include(x => x.QuizQuestions)
                    .FirstOrDefaultAsync();

                _context.Quizzes.Attach(quiz);
                _context.Quizzes.Remove(quiz);

                await _context.SaveChangesAsync();

                return new Res(null, "Encuesta eliminada", false);
            }
            catch (Exception)
            {
                return new Res(null, "¡Se ha producido un error, proceso de eliminación abortado!", true);
            }
        }
    }
}
