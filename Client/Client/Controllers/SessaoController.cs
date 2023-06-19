using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Client.Models;

namespace Client.Controllers {
    class SessaoController {
        static public List<Sessao> getPrincipalSessao() {

            using (var db = new dbContext()) {
                return db.Sessoes.ToList();
            }
        }

        static public void inserirDados(DateTime data, string sala, string filme, float preco) {
            using (var db = new dbContext()) {
                Sessao sessao = new Sessao() {
                    DataHora = data,
                    salaId = SalaController.getCurrentSala(sala),
                    filmeId = FilmeController.getCurrentFilme(filme),
                    Preco = preco
                };

                db.Sessoes.Add(sessao);

                db.SaveChanges();
            }
        }

        static public void alterarDados(int id, DateTime data, string sala, string filme, float preco) {
            using (var db = new dbContext()) {
                var sessao = db.Sessoes.First(s => s.Id == id);

                if(sessao != null) {
                    sessao.DataHora = data;
                    sessao.salaId = SalaController.getCurrentSala(sala);
                    sessao.filmeId = FilmeController.getCurrentFilme(filme);
                    sessao.Preco = preco;
                }

                db.SaveChanges();

            }
        }

        static public void eliminarDados(int id) {
            using (var db = new dbContext()) {
                var sessao = db.Sessoes.First(s => s.Id == id);

                if(sessao != null) {
                    db.Sessoes.Remove(sessao);

                    db.SaveChanges();
                }
            }
        }

    }
}
