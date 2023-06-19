using Client.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.Controllers {
    class ClienteController {

        public static List<Cliente> getAllClientes() {
            using (var db = new dbContext()) {
                return db.Clientes.ToList();
            }
        }

        public static int getClienteId(string nome) {
            using (var db = new dbContext()) {
                return db.Clientes.First(c => c.Nome == nome).Id;
            }
        }

        public static Cliente getAnonimo() {
            using (var db = new dbContext()) {
                return db.Clientes.First(c => c.Id == 1);
            }
        }

        public static int getAnonimoId() {
            using (var db = new dbContext()) {
                return db.Clientes.First(c => c.Nome == "Anonimo").Id;
            }
        }

        public static void inserirCliente(string nome, string morada, int nif) {
            using (var db = new dbContext()) {
                Cliente novoCliente = new Cliente{
                    Nome = nome,
                    Morada = morada,
                    NIF = nif,
                };

                db.Clientes.Add(novoCliente);

                db.SaveChanges();
            }
        }

        public static void alterarCliente(int id, string nome, string morada, int nif) {
            using (var db = new dbContext()) {
                var cliente = db.Clientes.First(f => f.Id == id);

                if (cliente != null) {
                    cliente.Nome = nome;
                    cliente.Morada = morada;
                    cliente.NIF = nif;
                }

                db.SaveChanges();
            }
        }

        public static void eliminarCliente(int id) {
            using (var db = new dbContext()) {
                var cliente = db.Clientes.First(f => f.Id == id);

                db.Clientes.Remove(cliente);
                db.SaveChanges();
            }
        }


    }
}
