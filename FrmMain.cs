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
    public partial class FrmMain : Form
    {

        

        public FrmMain()
        {
            InitializeComponent();
            D.dg = dg;
            D.Calendario.Montar();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            lblCargaHoraria.Text = D.Calendario.CargaHoraria.ToString();
            lblEmpresa.Text = D.Const["Empresa"];
            lblUnidade.Text = D.Const["Unidade"];
            lblEquipe.Text = D.Const["Equipe"];
            lblCargaHoraria.Text = "Carga horária: " + D.Calendario.CargaHoraria + "Hs";
            lblPeriodo.Text = "Período: " + D.Calendario.Mes + "/" + D.Calendario.Ano;
        }


    }
}
