using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiCompilador_PSBII_VAMA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCompilar_Click(object sender, EventArgs e)
        {
            StreamReader archivoLenguajeOriginal = new StreamReader("C:\\Compilador2023\\LenguajeOriginal.txt");
            StreamWriter lenguajeTraducido = new StreamWriter("C:\\Compilador2023\\LenguajeTraducido.txt");

            string linea = archivoLenguajeOriginal.ReadLine();

            while(linea != null)
            {
                switch(linea)
                {
                    case "inicioclase":
                        lenguajeTraducido.WriteLine("Public Class");
                        break;

                    case "iniciofuncion":
                        lenguajeTraducido.WriteLine("Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load");
                        break;

                    case "finfuncion":
                        lenguajeTraducido.WriteLine("End Sub");
                        break;

                    case "finclase":
                        lenguajeTraducido.WriteLine("End Class");
                        break;

                }




                linea = archivoLenguajeOriginal.ReadLine();
            }

            archivoLenguajeOriginal.Close();
            lenguajeTraducido.Flush();
            lenguajeTraducido.Close();

            leerLenguajeTraducido();

        }

        private void leerLenguajeOriginal()
        {
            StreamReader fileLenguajeOriginal = new StreamReader("C:\\Compilador2023\\LenguajeOriginal.txt");

            string linea = fileLenguajeOriginal.ReadLine();

            this.lstLenguajeOriginal.Items.Clear();


            while (linea != null)
            {
                this.lstLenguajeOriginal.Items.Add(linea);
                linea = fileLenguajeOriginal.ReadLine();
            }

            fileLenguajeOriginal.Close();

        }

        private void leerLenguajeTraducido()
        {
            StreamReader fileLenguajeTraducido = new StreamReader("C:\\Compilador2023\\LenguajeTraducido.txt");

            string linea = fileLenguajeTraducido.ReadLine();

            this.lstLenguajeTraducido.Items.Clear();


            while (linea != null)
            {
                this.lstLenguajeTraducido.Items.Add(linea);
                linea = fileLenguajeTraducido.ReadLine();
            }

            fileLenguajeTraducido.Close();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            leerLenguajeOriginal();
        }

        private void prueba()
        {

        }
    }
}
