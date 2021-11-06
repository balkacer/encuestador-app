using Database.Classes;
using Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Services
{
    public class RespondentService
    {
        private static readonly EncuestadorAppContext _context = new();

        public async static Task<Res> AddNew(string name, int quizId)
        {
            try
            {
                var respondant = new Respondent()
                {
                    Name = name,
                    QuizId = quizId
                };

                await _context.Respondents.AddAsync(respondant);

                await _context.SaveChangesAsync();

                return new Res(respondant, "Encuestado agregado exitosamente", false);
            }
            catch (Exception)
            {
                return new Res(null, "¡Ha ocurrido un error agregando el encuestado!", true);
            }
        }
    }
}
