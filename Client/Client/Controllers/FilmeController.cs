using Client.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Controllers {
    class FilmeController {

        static public List<Filme> getAllFilmes() {
            using (var db = new dbContext()) {
                return db.Filmes.ToList();
            }
        }

        static public List<Filme> getActiveFilmes() {
            using (var db = new dbContext()) {
               return db.Filmes.Where(f => f.Activo == true).ToList();
            }
        }

        static public int getCurrentFilme(string nome) {
            using (var db = new dbContext()) {
                return db.Filmes.First(f => f.Nome == nome).Id;
            }
        }

        static public string getNameFilme(int id) {
            using (var db = new dbContext()) {
                return db.Filmes.First(f => f.Id == id).Nome;
            }
        }

        static public void inserirFilme(string nome, int duracao, bool activo, string categoria) {
            using (var db = new dbContext()) {

                //if (verificarCategoria(nome)) {
                Filme novoFilme = new Filme {
                    Nome = nome,
                    Duracao = duracao,
                    CategoriaId = CategoriaController.getCategoriaId(categoria),
                    Activo = activo,
                };

                    db.Filmes.Add(novoFilme);

                    db.SaveChanges();
               // }
            }
        }

        static public void alterarFilme(int id, string nome, int duracao, bool activo, string categoria) {
            using (var db = new dbContext()) {
                Filme filmes = db.Filmes.First(c => c.Id == id);

                var categoriaAlterada = CategoriaController.getCategoriaId(categoria);

                if (filmes != null) {
                    filmes.Nome = nome;
                    filmes.Duracao = duracao;
                    filmes.Activo = activo;
                    filmes.CategoriaId = categoriaAlterada;

                    db.SaveChanges();
                }
            }
        }

        static public void eliminarFilme(int id) {
            using (var db = new dbContext()) {
                Filme filme = db.Filmes.First(c => c.Id == id);

                if (filme != null) {
                    db.Filmes.Remove(filme);
                    db.SaveChanges();
                }
            }
        }


    }
}
