using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EscalaDeServico
{
    public class Funcionario
    {
        public Dictionary<string, string> Dados;
        public string Id;
        public string Nome;
        public string Tipo; //ADM, SAUDE
        public string Turno; // MT, SN
        public List<int> FolgasDesejadas = new List<int>();
        public List<int> DiasAfastado = new List<int>();
        public List<MotivoAfastamento> Afastamentos = new List<MotivoAfastamento>();
        public List<Funcionario> Funcionariolst = new List<Funcionario>();
        

        public Funcionario(){
            
        }

        public void Load(){
            string[] fd;
            foreach (string fid in D.Ini.SectionKeys("funcionarios"))
            {
                Funcionario f = new Funcionario();
                Funcionariolst.Add(f);
                fd = D.Ini["funcionarios", fid].Split(';');
                f.Id = fid;
                f.Nome = fd[0];
                f.Tipo = fd[1];
                f.Turno = fd[2];

                if(D.Ini.SectionKeys("FolgasDesejadas").Contains(fid))
                    foreach (string s in D.Ini["FolgasDesejadas", fid].Split(';'))
                           f.FolgasDesejadas.Add(Convert.ToInt32(s));

                if (D.Ini.SectionKeys("MotivosDeAfastamento").Contains(fid))
                    foreach(string s in D.Ini["MotivosDeAfastamento", fid].Split('|')){
                        MotivoAfastamento m = new MotivoAfastamento(f);
                        f.Afastamentos.Add(m);
                        m.Cadastrar(s);
                    }

            }
         
        }

        public class MotivoAfastamento
        {
            string Motivo;
            List<int> Dias = new List<int>();
            Funcionario funcionario;

            public MotivoAfastamento(Funcionario f)
            {
                funcionario = f;
            }

            public void Cadastrar(string v)
            {
                string[] s = v.Split(';');
                Motivo = s[0];
                if (s.Length == 2)
                {
                    Dias.Add(Convert.ToInt32(s[1]));
                    funcionario.DiasAfastado.Add(Convert.ToInt32(s[1]));
                }
                else
                {
                    for (int i = Convert.ToInt32(s[1]); i <= Convert.ToInt32(s[2]); ++i)
                    {
                        Dias.Add(i);
                        funcionario.DiasAfastado.Add(i);
                    }
                }
            }

        }


    }
}
