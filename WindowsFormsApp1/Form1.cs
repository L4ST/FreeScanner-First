using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Teste(object sender, EventArgs e)
        {


            abrirResults.ShowDialog();
            label1.Text = "mythed dont know c#";
            string caminhoResults = abrirResults.FileName;



            if (File.ReadAllText(caminhoResults).Contains("vape"))
            {
                MessageBox.Show("Vape found");
            }
            else
            {


                if (File.ReadAllText(caminhoResults).Contains("dinkio"))
                {
                    MessageBox.Show("kurium");
                    //Drek = cHV0
                }
                if (File.ReadAllText(caminhoResults).Contains("cHV0"))
                {
                    MessageBox.Show("Drek Found!");

                }
                if (File.ReadAllText(caminhoResults).Contains("KRTal"))
                {
                    MessageBox.Show("Vape Found!");

                }
                if (File.ReadAllText(caminhoResults).Contains("Reach.class"))
                {
                    MessageBox.Show("Java Edit Found!");

                }
                if (File.ReadAllText(caminhoResults).Contains("CheatEngine"))
                {
                    MessageBox.Show("Cheat Engine");

                }
                if (File.ReadAllText(caminhoResults).Contains("1)k9"))
                {
                    MessageBox.Show("Vape Found!");
                    //gorilla/Agent
                }
                if (File.ReadAllText(caminhoResults).Contains("gorilla/Agent"))
                {
                    MessageBox.Show("Gorilla Found!");
                    //Config.class
                }

                if (File.ReadAllText(caminhoResults).Contains("AutoClicker"))
                {
                    MessageBox.Show("Clicker Found!");

                }
                if (File.ReadAllText(caminhoResults).Contains("rnv!Y"))
                {
                    MessageBox.Show("BitClient Found!");

                }
                if (File.ReadAllText(caminhoResults).Contains("setTimerRate"))
                {
                    MessageBox.Show("Cyanide Found!");

                }
                if (File.ReadAllText(caminhoResults).Contains("xyz/gucci"))
                {
                    MessageBox.Show("Gucci Found!");

                }
                if (File.ReadAllText(caminhoResults).Contains("Xerxes"))
                {
                    MessageBox.Show("Xerxes Found!");

                }
                if (File.ReadAllText(caminhoResults).Contains("net/kohi/tcpnodelaymod/L"))
                {
                    MessageBox.Show("Vea Found!");
                    //net/kohi/tcpnodelaymod/L 
                }
                if (File.ReadAllText(caminhoResults).Contains("net/kohi/tcpnodelaymod/AuX"))
                {
                    MessageBox.Show("Vea Found!");

                }
                if (File.ReadAllText(caminhoResults).Contains("xZGJtaeSlTaN"))

                {
                    MessageBox.Show("Drip Found!");

                }
                if (File.ReadAllText(caminhoResults).Contains("com/sun/jna/z/b"))
                {
                    MessageBox.Show("Vape Found!");

                }
                if (File.ReadAllText(caminhoResults).Contains("142.44.246.31"))
                {
                    MessageBox.Show("Vape Found!");

                }
                if (File.ReadAllText(caminhoResults).Contains(@"5nh\8RPb$3"))
                {
                    MessageBox.Show("Bape Found!");

                }
                if (File.ReadAllText(caminhoResults).Contains("x]?F'"))
                {
                    MessageBox.Show("Fusk Found!");

                }
            }
            if (File.ReadAllText(caminhoResults).Contains("URLUpdate"))
            {
                MessageBox.Show("Java Edit found");
            }
            else
            {
                MessageBox.Show("OK!");
            }




        }
    }
}


        

        private void ClickJavaEdit(object sender, EventArgs e)
        {
            abrirResults.ShowDialog();
  
            string caminhoResults = abrirResults.FileName;



        if (File.ReadAllText(caminhoResults).Contains("bjb"))
        {
            MessageBox.Show("Java Edit found");
        }
        else
        {
            if (File.ReadAllText(caminhoResults).Contains("bje"))
            {
                MessageBox.Show("Java Edit found");
            }
            if (File.ReadAllText(caminhoResults).Contains("bjc"))
            {
                MessageBox.Show("Java Edit found");
            }

            if (File.ReadAllText(caminhoResults).Contains("Reach.class"))
            {
                MessageBox.Show("Java Edit found");
            }
            if (File.ReadAllText(caminhoResults).Contains("URLDecoder"))
            {
                MessageBox.Show("Java Edit found");
            }
            if (File.ReadAllText(caminhoResults).Contains("EventMod"))
            {
                MessageBox.Show("Java Edit found");
            }
            if (File.ReadAllText(caminhoResults).Contains("Latency.class"))
            {
                MessageBox.Show("Java Edit found");
            }
            if (File.ReadAllText(caminhoResults).Contains("4.0F"))
            {
                MessageBox.Show("Java Edit found");
            }
            if (File.ReadAllText(caminhoResults).Contains("3.9F"))
            {
                MessageBox.Show("Java Edit found");
            }
            if (File.ReadAllText(caminhoResults).Contains("clearstrings.class"))
            {
                MessageBox.Show("Java Edit found");
            }
            if (File.ReadAllText(caminhoResults).Contains("Switch"))
            {
                MessageBox.Show("Java Edit found");
            }
            if (File.ReadAllText(caminhoResults).Contains("(DD)F"))
            {
                MessageBox.Show("Java Edit found");
            }
            if (File.ReadAllText(caminhoResults).Contains("(FF)D"))
            {
                MessageBox.Show("Java Edit found");
            }

            else
            {
                MessageBox.Show("OK!");
            }





        }
            }
        
    

}