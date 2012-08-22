using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace EscalaDeServico
{
    public class Calendario
    {
        public int Ano;
        public int Mes;
        
        public List<int> Feriados = new List<int>();
        public List<int> FinaisDeSemana = new List<int>();
        public List<int> DiasUteis = new List<int>();
        List<DataGridViewTextBoxColumn> Colst = new List<DataGridViewTextBoxColumn>();

        public void Load()
        {
            DateTime dt;
            Ano = Convert.ToInt32(D.Ini["Calendario", "Ano"]);
            Mes = Convert.ToInt32(D.Ini["Calendario", "Mes"]);

            if (D.Ini.SectionKeys("Calendario").Contains("Feriados"))
                foreach (string s in D.Ini["Calendario", "Feriados"].Split(';'))
                    Feriados.Add(Convert.ToInt32(s));
            for (int i = 1; i <= D.Calendario.DiasNoMes; ++i)
            {
                dt = new DateTime(D.Calendario.Ano, D.Calendario.Mes,i);
                if (dt.DayOfWeek == DayOfWeek.Saturday || dt.DayOfWeek == DayOfWeek.Sunday)
                {
                    FinaisDeSemana.Add(i);
                }
                else
                {
                    if (!Feriados.Contains(i))
                        DiasUteis.Add(i);
                }
            }
        }

        public int DiasNoMes
        {
            get{return DateTime.DaysInMonth(Ano,Mes);}
        }

        //public int FinaisDeSemana


        public int CargaHoraria
        {
            get{return DiasUteis.Count * 6;}
        }

        public void Montar() {

            //Dg.ColumnCount = D.Calendario.DiasNoMes + 6;
            DataGridViewCellStyle colunaAmarela = CreateStyle(Color.Yellow);
            DataGridViewCellStyle colunaLaranja = CreateStyle(Color.Orange);
            DataGridViewCellStyle colunaSalmao = CreateStyle(Color.LightSalmon);
            DataGridViewCellStyle colunaVermelha = CreateStyle(Color.Red);

            DateTime dt;

            AddColumn("N", "N");
            D.dg.RowCount = D.F.Funcionariolst.Count + 4;

            AddColumn("Nome", "Nome", 150);
            for (int i = 1; i <= D.Calendario.DiasNoMes; ++i)
            {
                AddColumn("D" + i, i.ToString());
            }
            AddColumn("DiferecaHoras", "Diferença", 60);
            for (int i = 1; i <= D.Calendario.DiasNoMes; ++i)
            {
                dt = new DateTime(D.Calendario.Ano, D.Calendario.Mes, i);
                D.dg[i + 1, 0].Value = dt.DayOfWeek.ToString();
                if (D.Calendario.Feriados.Contains(i))
                    D.dg.Columns[i + 1].DefaultCellStyle = colunaAmarela;

                if (D.Calendario.FinaisDeSemana.Contains(i))
                    D.dg.Columns[i + 1].DefaultCellStyle = colunaAmarela;
            }
            for (int i = 0; i < D.F.Funcionariolst.Count; ++i)
            {
                D.dg[0, 1 + i].Value = i + 1;
                D.dg[1, 1 + i].Value = D.F.Funcionariolst[i].Nome;

                foreach (int afastado in D.F.Funcionariolst[i].DiasAfastado)
                    D.dg[afastado + 1, 1 + i].Style.BackColor = Color.Red;
                foreach (int afastado in D.F.Funcionariolst[i].FolgasDesejadas)
                    D.dg[afastado + 1, 1 + i].Style.BackColor = Color.LightSalmon;

            }
            D.dg[1, D.dg.RowCount - 3].Value = "Total Matutino";
            D.dg[1, D.dg.RowCount - 2].Value = "Total Vespertino";
            D.dg[1, D.dg.RowCount - 1].Value = "Total Noturno";
        }



        private DataGridViewTextBoxColumn AddColumn(string name, string header, int width)
        {
            DataGridViewTextBoxColumn col = AddColumn(name, header);
            col.Width = width;
            return col;
        }
        private DataGridViewTextBoxColumn AddColumn(string name, string header)
        {
            DataGridViewTextBoxColumn col = new DataGridViewTextBoxColumn();
            Colst.Add(col);
            D.dg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { col });
            col.HeaderText = header;
            col.Name = name;
            col.Width = 35;
            col.SortMode = DataGridViewColumnSortMode.NotSortable;

            return col;
        }

        public DataGridViewCellStyle CreateStyle(Color cor)
        {
            // Set the column header style.
            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();
            columnHeaderStyle.BackColor = cor;
            return columnHeaderStyle;

            //columnHeaderStyle.Font =     new Font("Verdana", 10, FontStyle.Bold);
            //dataGridView.ColumnHeadersDefaultCellStyle =   columnHeaderStyle;

        }

    }
}
