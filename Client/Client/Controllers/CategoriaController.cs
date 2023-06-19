using Client.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Controllers {
    class CategoriaController {

        static public List<Categoria> getAllCategorias() {
            using (var db = new dbContext()) {
                return db.Categorias.ToList();
            }
        }
        static public List<Categoria> getActiveCategorias() {
            using (var db = new dbContext()) {
                return db.Categorias.Where(c => c.Activo == true).ToList();
            }
        }

        static public string getNomeCategoria(int id) {
            using (var db = new dbContext()) {
                return db.Categorias.First(c => c.Id == id).Nome;
            }
        }

        static public int getCategoriaId(string nomeCategoria) {
            using (var db = new dbContext()) {
                var categoria = db.Categorias.FirstOrDefault(c => c.Nome == nomeCategoria);

                return categoria.Id;
            }
        }
            static public bool verificarCategoria(string nome) {
            using (var db = new dbContext()) {
                var lista = db.Categorias.Where(c => c.Nome == nome).ToList();

                if(lista.Count() == 0) {
                    return true;
                }

                return false;                
            }
        }

       static public void inserirCategoria(string nome, bool activo) {
            using (var db = new dbContext()) {

              if(verificarCategoria(nome)) {
                   Categoria novaCategoria = new Categoria {
                        Nome = nome,
                        Activo = activo
                    };

                    db.Categorias.Add(novaCategoria);

                    db.SaveChanges();
               }
            }
        }

        static public void alterarCategoria(int id, string nome, bool activo) {
            using (var db = new dbContext()) {
                Categoria categoria = db.Categorias.First(c => c.Id == id);

                if(categoria != null) {
                    categoria.Nome = nome;
                    categoria.Activo = activo;

                    db.SaveChanges();
                }
            }
        }

        static public void eliminarCategoria(int id) {
            using (var db = new dbContext()) {
                Categoria categoria = db.Categorias.First(c => c.Id == id);

                if(categoria != null) {
                    db.Categorias.Remove(categoria);
                    db.SaveChanges();
                }
            }
        }

    }
}
