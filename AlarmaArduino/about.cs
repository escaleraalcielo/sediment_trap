using System;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace AlarmaArduino
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void About_Load(object sender, System.EventArgs e)
        {
            var AssemblyNumber = Assembly.GetExecutingAssembly().GetName().Version.ToString();
            DateTime buildDate = new FileInfo(Assembly.GetExecutingAssembly().Location).LastWriteTime;
            label4.Text = "Compilación: " + AssemblyNumber;
            label2.Text = "Fecha de compilación: " + buildDate.ToShortDateString().ToString();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("mailto:fi.danielmartinez@gmail.com");
        }
    }
}