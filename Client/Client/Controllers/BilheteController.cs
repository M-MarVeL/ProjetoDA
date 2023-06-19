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

    }
}
