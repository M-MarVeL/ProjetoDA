using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Client.Models;

namespace Client.Controllers {
    class BilheteController {

        public static List<Bilhete> GetBilhete(int sessaoId) {
            using (var db = new dbContext()) {
                return db.Bilhetes.Where(b => b.SessaoId == sessaoId).ToList();
            }
        }

        public static void inserirBilhete(int lugar, bool activo, int idFuncionario, int idCliente, int idSessao) {
            using (var db = new dbContext()) {
                Bilhete bilhete = new Bilhete() {
                    Lugar = lugar,
                    Estado = activo,
                    FuncionarioId = idFuncionario,
                    ClienteId = idCliente,
                    SessaoId = idSessao
                };

                db.Bilhetes.Add(bilhete);
                db.SaveChanges();
            
            }
        }

    }
}
