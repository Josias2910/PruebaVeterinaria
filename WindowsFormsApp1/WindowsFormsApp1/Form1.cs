using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] nombres = new string[1000];
        int[] edades = new int[1000];
        int contador = 0;

        void Burbuja()
        {
            int aux = 0;
            string aux2 = " ";
            for (int i = 0; i < contador - 1; i++)
            {
                for (int j = i + 1;  j < contador; j++)
                {
                    if (edades[i] < edades[j])
                    {
                        aux = edades[i];
                        edades[i] = edades[j];
                        edades[j] = aux;

                        aux2 = nombres[i];
                        nombres[i] = nombres[j];
                        nombres[j] = aux2;
                    }
                }
            }
        }

        int busquedaSecuencial(int valor)
        {
            int i = 0;
            int pos = -1;
            while ((pos==-1) && (i < contador))
            {
                if (edades[i] == valor)
                {
                    pos = i;
                }
                i++;
            }
            return pos;
        }

        private void btnAgregarMascota_Click(object sender, EventArgs e)
        {
            Form2 vmodales2 = new Form2();

            if (vmodales2.ShowDialog() == DialogResult.OK)
            {
                string nombre = vmodales2.tbNombre.Text;
                int edad = Convert.ToInt32(vmodales2.tbEdad.Text);
                nombres[contador] = nombre;
                edades[contador] = edad;
                contador++;
            }
            vmodales2.Dispose();
        }
        private void btnVerLista_Click(object sender, EventArgs e)
        {
            Form3 vmodales3 = new Form3();
            for (int i = 0; i < contador; i++)
            {
                vmodales3.lbVerMascotas.Items.Add($"Nombre: {nombres[i]} Edad: {edades[i]}");
            }
            vmodales3.ShowDialog();
            vmodales3.Dispose();
        }

        private void btnVerListaOrdenada_Click(object sender, EventArgs e)
        {
            Form3 vmodales3 = new Form3();
            Burbuja();
            for (int i = 0; i < contador; i++)
            {
                vmodales3.lbVerMascotasOrdenadas.Items.Add($"Nombre: {nombres[i]} Edad: {edades[i]}");
            }
            vmodales3.ShowDialog();
            vmodales3.Dispose();
        }

        private void btnBuscarPerro_Click(object sender, EventArgs e)
        {
            int valor = Convert.ToInt32(tbBuscarEdad.Text);
            int pos = busquedaSecuencial(valor);
            if (pos != -1)
            {
                MessageBox.Show($"Mascota encontrada en la posicion {pos}");
            }
            else
            {
                MessageBox.Show("Mascota no encontrada");
            }
        }
    }
}
