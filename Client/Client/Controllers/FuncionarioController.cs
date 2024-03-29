﻿using Client.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Controllers {
    class FuncionarioController {

        public static List<Funcionario> getFuncionarios() {
            using (var db = new dbContext()) {
                return db.Funcionarios.ToList();
            }
        }

        public static List<String> getAllFuncionarios() {
            using (var db = new dbContext()) {
                return db.Funcionarios.Select(e => e.Nome).ToList();
            }
        }

        public static int getIdByNome(string nome) {
            try {
                using (var db = new dbContext()) {
                    return db.Funcionarios.First(e => e.Nome == nome).Id;
                }
            } catch (Exception ex) {
                return 1;
            }
  
        }

        public static void inserirFuncionarios(string nome, string morada, float salario, string funcao) {
            using (var db = new dbContext()) {

                Funcionario funcionario = new Funcionario {
                    Nome = nome,
                    Morada = morada,
                    Salario = salario,
                    Funcao = funcao
                };

                db.Funcionarios.Add(funcionario);
                db.SaveChanges();
            }
        }

        public static void alterarFuncionario(int id, string nome, string morada, float salario, string funcao) {
            using (var db = new dbContext()) {

                var funcionario = db.Funcionarios.First(f => f.Id == id);

                if(funcionario != null) {
                    funcionario.Nome = nome;
                    funcionario.Morada = morada;
                    funcionario.Salario = salario;
                    funcionario.Funcao = funcao;
                }

                db.SaveChanges();
            }
        }

        public static void eliminarFuncionario(int id) {
            using (var db = new dbContext()) {
                var funcionario = db.Funcionarios.First(f => f.Id == id);

                db.Funcionarios.Remove(funcionario);
                db.SaveChanges();

            }
        }

    }
}
