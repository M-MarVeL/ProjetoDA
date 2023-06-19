using Client.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Controllers {
    class SalaController {

        public static List<Sala> getAllSalas() {
            using (var db = new dbContext()) {
                return db.Salas.ToList();
            }
        }

        public static int getCurrentSala(string nome) {
            using (var db = new dbContext()) {
                return db.Salas.First(s => s.Nome == nome).Id;
            }
        }

        public static Sala getSalabyId(int id) {
            using (var db = new dbContext()) {
                return db.Salas.First(s => s.Id == id);
            }
        }

        public static string getNameSala(int id) {
            using (var db = new dbContext()) {
                return db.Salas.First(s => s.Id == id).Nome;
            }
        }

        public static void inserirSala(string nome, int colunas, int filas) {
            using (var db = new dbContext()) {

                Sala sala = new Sala{
                    Nome = nome,
                    Colunas = colunas,
                    Filas = filas,
                };

                db.Salas.Add(sala);
                db.SaveChanges();
            }
        }

        public static void alterarSala(int id, string nome, int colunas, int filas) {
            using (var db = new dbContext()) {

                var sala = db.Salas.First(f => f.Id == id);

                if (sala != null) {
                    sala.Nome = nome;
                    sala.Colunas = colunas;
                    sala.Filas = filas;
                }

                db.SaveChanges();
            }
        }

        public static void eliminarSala(int id) {
            using (var db = new dbContext()) {
                var sala = db.Salas.First(f => f.Id == id);

                db.Salas.Remove(sala);
                db.SaveChanges();
            }
        }

    }

}

