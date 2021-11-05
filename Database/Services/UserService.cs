using Database.Classes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Services
{
    public class UserService
    {
        private static readonly EncuestadorAppContext _context = new();

        public static async Task<Res> GetById(int id)
        {
            // Get user by id
            var user = await _context.Users.FindAsync(id);

            if (user != null)
            {
                return new Res(user, "", false);
            }

            return new Res(null, "¡Usuario no encotrado!", true);
        }
    }
}
