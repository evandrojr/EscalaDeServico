using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ini;

namespace EscalaDeServico
{
    public class D
    {
        public D()
        {
            ApplicationDir = Environment.CurrentDirectory;
            Ini = new IniFile(ApplicationDir + "\\Dados.txt", IniFile.CaseSensitiviy.CaseInsensitive);
        }

        //            private void Form1_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        //{
			
        //    ini.IniWriteValue("Info","Name",name.Text);
        //    ini.IniWriteValue("Info","LastName",lname.Text);
        //}
        //private void Form1_Load(object sender, System.EventArgs e)
        //{
        //    IniFile ini = new IniFile("test.ini");
        //    name.Text= ini.IniReadValue("Info","Name");
        //    lname.Text = ini.IniReadValue("Info","LastName");
        //}
        

        public static IniFile Ini=null;
        public static Funcionario F;
        public static Db Db;
        public static string ApplicationDir;

    }
}
