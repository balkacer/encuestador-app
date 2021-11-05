using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Database.Models;
using Database.Classes;
using Microsoft.EntityFrameworkCore;

namespace Database.Services
{
    public class AuthService
    {
        private static readonly EncuestadorAppContext _context = new();

        public static async Task<Res> Login(string username, string password)
        {
            // Get user by username and password
            var user = await _context.Users.Where(x => x.Username == username && x.Password == password).FirstOrDefaultAsync();

            if (user != null)
            {
                return new Res(user, "Inicio de sesión exitoso.", false);
            }

            return new Res(null, "¡Usuario o contraseña incorrectos!", true);
        }

        public static async Task<Res> Register(string name, string lastname, string username, string password, string confirmPass)
        {
            // Validations
            if (name == "" || lastname == "" || username == "" || password == "" || confirmPass == "")
                return new Res(null, "¡Todos los campos son requeridos!", true);

            if (password != confirmPass)
                return new Res(null, "¡Las contraseñas no coinciden!", true);

            var usernameExist = (await _context.Users.Where(x => x.Username == username).FirstOrDefaultAsync() != null);

            if (usernameExist)
                return new Res(null, "¡Este usuario existe, por favor inicie sesión o pruebe con otro!", true);

            // Save user in db
            try
            {
                var user = new User()
                {
                    Name = name,
                    LastName = lastname,
                    Username = username,
                    Password = password
                };

                _ = await _context.Users.AddAsync(user);
                await _context.SaveChangesAsync();

                return new Res(user, "Usuario Registrado correctamente.", false);
            }
            catch (Exception)
            {
                return new Res(null, "¡Hubo un error innesperado en el registro!", true);
            }
            
        }
    }
}
