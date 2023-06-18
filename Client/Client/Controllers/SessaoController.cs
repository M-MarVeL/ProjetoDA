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

        static public void inserirDados(DateTime data, float preco) {
            using (var db = new dbContext()) {
                // List<Sessao> sessao = new List<Sessao>().Where(sessao =>);

                // db.Sessoes.Add(); Adicionar os dados da sessão

                // db.SaveChanges(); Para guardar na base de dados 
            }
        }

    }
}
