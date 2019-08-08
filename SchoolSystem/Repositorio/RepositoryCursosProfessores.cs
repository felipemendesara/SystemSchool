using Dapper;
using SchoolSystem.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace SchoolSystem.Repositorio
{
    public class RepositoryCursosProfessores
    {
        static string strConexao = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

        public static IEnumerable<Professor> ListaProfessores()
        {
            using (var conexaoBD = new SqlConnection(strConexao))
            {
                try
                {

                    var professores = conexaoBD.Query<Professor>
                    (
                        "SELECT * FROM PROFESSORS"
                    );
                    return professores;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw;
                }

            }
        }

        public static IEnumerable<Materia> ListaMaterias()
        {
            using (var conexaoBD = new SqlConnection(strConexao))
            {
                try
                {


                    var materias = conexaoBD.Query<Materia>
                    (
                        "SELECT * FROM MATERIAS"
                    );
                    return materias;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw;
                }
            }
        }

        public static IEnumerable<MateriaProfessor> ListaMateriaProfessor()
        {
            using (var conexaoBD = new SqlConnection(strConexao))
            {
                try
                {


                    var materiasProfessor = conexaoBD.Query<MateriaProfessor>
                    (
                        @"SELECT IdMateriasProfessores,NomeMateria,NomeProfessor FROM MateriasProfessores matprof
                inner join Materias mat
                ON matprof.FkMateria = mat.IdMateria
                inner join Professors prof
                ON matprof.FkProfessor = prof.IdProfessor"
                    );
                    return materiasProfessor;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw;
                }
            }
        }

        public static void VinculaValores(int idProfessor, int idMaterias)
        {
            try
            {


                using (var conexaoBD = new SqlConnection(strConexao))
                {
                    var materias = new MateriaProfessor() { FkProfessor = idProfessor, FkMateria = idMaterias };

                    conexaoBD.Execute(@"insert MateriasProfessores(FkProfessor, FkMateria)
                                    values (@FkProfessor, @FkMateria)", materias);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

    }
}