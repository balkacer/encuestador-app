using Database.Classes;
using Database.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Services
{
    public class ResponseService
    {
        private static readonly EncuestadorAppContext _context = new();

        public static async Task<Res> CreateResponses(int respondentId, (int questionId, string res)[] responses)
        {
            try
            {
                List<QuestionResponse> responsesList = new();

                foreach (var (questionId, res) in responses)
                {
                    responsesList.Add(new QuestionResponse()
                    {
                        RespondentId = respondentId,
                        QuizQuestionId = questionId,
                        Response = res
                    });
                }

                await _context.QuestionResponses.AddRangeAsync(responsesList);
                await _context.SaveChangesAsync();

                return new Res(null, "¡Se han agregado las respuestas exitosamente!", false);
            }
            catch (Exception)
            {
                return new Res(null, "¡Ha ocurrido un error!\nNo se han podido agregar las respuestas.", true);
            }            
        }

        public static async Task<Res> GetResponseByRespondentId(int respondentId)
        {
            try
            {
                var responses = await _context.QuestionResponses
                    .Include(x => x.QuizQuestion )
                    .Where(x => x.RespondentId == respondentId)
                    .ToListAsync();

                if (responses.Count < 1)
                    return new Res(null, "No hay respuestas que cargar", true);

                return new Res(responses, "Se han cargado las respuestas", false);
            }
            catch (Exception)
            {
                return new Res(null, "¡Ha ocurrido un error!\nNo se han podidido cargar las respuestas.", true);
            }
        }
    }
}
