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
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.BotaoTeste = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.abrirResults = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // BotaoTeste
            // 
            this.BotaoTeste.AccessibleName = "btnTeste";
            this.BotaoTeste.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotaoTeste.Location = new System.Drawing.Point(72, 99);
            this.BotaoTeste.Name = "BotaoTeste";
            this.BotaoTeste.Size = new System.Drawing.Size(156, 43);
            this.BotaoTeste.TabIndex = 0;
            this.BotaoTeste.Text = "Results - Client";
            this.BotaoTeste.UseVisualStyleBackColor = true;
            this.BotaoTeste.Click += new System.EventHandler(this.Teste);
            // 
            // label1
            // 
            this.label1.AccessibleName = "lbl1";
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(206, 314);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 1;
            // 
            // abrirResults
            // 
            this.abrirResults.FileName = "abrirParaVerificar";
            // 
            // button1
            // 
            this.button1.AccessibleName = "btnMods";
            this.button1.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(265, 99);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 43);
            this.button1.TabIndex = 2;
            this.button1.Text = "Mods Scanner";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ClickJavaEdit);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(183, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Free Scanner";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkRed;
            this.panel1.Location = new System.Drawing.Point(567, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 262);
            this.panel1.TabIndex = 4;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "abrirParaVerificar";
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.MediumOrchid;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(503, 192);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BotaoTeste);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Opacity = 0.9D;
            this.Text = "Free Scanner - L4ST";
            this.ResumeLayout(false);
            this.PerformLayout();

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

        #endregion

        private System.Windows.Forms.Button BotaoTeste;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog abrirResults;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

