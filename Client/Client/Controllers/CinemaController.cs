using Client.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Controllers {
    class CinemaController {

        public static List<Cinema> getCinema() {
            using (var db = new dbContext()) {
                return db.Cinemas.ToList();
            }
        }

        public static void inserirCinema(string nome, string morada, string email) {
            using (var db = new dbContext()){
                Cinema cinema = new Cinema {
                    Nome = nome,
                    Morada = morada,
                    Email = email
                };

                db.Cinemas.Add(cinema);

                db.SaveChanges();

            }
        }

    }
}
