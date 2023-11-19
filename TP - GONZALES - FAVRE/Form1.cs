using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP___GONZALES___FAVRE
{
    public partial class Form1 : Form
    {
        //Para manejar la cantidad de elementos del arreglo
        const int max = 6; 
        //definimos la struct
        public struct REPUESTOS
        {
            public int numero_rep; 
            public string marca;
            public string origen;
            public string descripcion;
            public float precio; 
        }
        int i;
        int codigo = 0;
        float importe = 0; 

        //declaramos el arreglo de struct
        REPUESTOS[] repuestos; 
        public int pos;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            //Creamos el arreglo 

            repuestos = new REPUESTOS[max]; 
            pos = 0;

            //LLenamos combos
            cmbMarca.Items.Clear();
            cmbMarca.Items.Add("Peugueot");
            cmbMarca.Items.Add("Fiat");
            cmbMarca.Items.Add("Renault"); 
            cmbMarca.SelectedIndex = 0; 

            
            cmbOrigen.Items.Clear();
            cmbOrigen.Items.Add("Nacional");
            cmbOrigen.Items.Add("Importado"); 
            cmbOrigen.SelectedIndex = 0;

            cmbOpciones.Items.Clear();
            cmbOpciones.Items.Add("Todas");
            cmbOpciones.Items.Add("Peugueot");
            cmbOpciones.Items.Add("Fiat");
            cmbOpciones.Items.Add("Renault");
            cmbOpciones.SelectedIndex = 0;  

           
            //limpiar la grilla 
            dgvDatos.Rows.Clear();  
            

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {

            bool tieneRepetidos = false; 
            //convertimos los datos para que se puedan guardar 
            importe = float.Parse(txtNumRep.Text);
            codigo = int.Parse(txtNumRep.Text);

            //Verificar CANTIDAD de caracteres 
            if (txtNumRep.Text.Length > 6 && txtNumRep.Text.Length <= 0 )
            {
                MessageBox.Show("Controlar Numero");
                txtNumRep.Text = "";
            }
            if (txtDescrip.Text.Length > 50 || txtDescrip.Text.Length <= 0)
            {
                MessageBox.Show("Controlar Descripcion");
                txtDescrip.Text = "";
            }

         //Controla si esta repetido el codigo 
            for (int i = 0; i < pos; i++)
            {
                if (repuestos[i].numero_rep == codigo)
                {
                    tieneRepetidos = true;
                    break;
                }
            }
            if (tieneRepetidos)
            {
                MessageBox.Show("El número de repuesto ya existe.");
                // Maneja el hecho de que el número ya existe, por ejemplo, limpia los campos de entrada
                return;
            }

            //Suma nuevos repuestos al arreglo 
            if (pos < max)
            {
                repuestos[pos].numero_rep = codigo;
                repuestos[pos].marca = cmbMarca.Text.ToString();
                repuestos[pos].origen = cmbOrigen.Text.ToString();
                repuestos[pos].descripcion = txtDescrip.Text;
                repuestos[pos].precio = importe;
                pos++;
                txtNumRep.Text = "";
                txtPrecio.Text = "";
                txtDescrip.Text = "";
            }
            else
            {
                MessageBox.Show("Lista llena");
            }
        }

        private void txtNumRep_TextChanged(object sender, EventArgs e)
        {

        }
        //Ingresar solo numeros 
        private void txtNumRep_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= 48 && e.KeyChar<=57) && e.KeyChar != 8) 
            {
                MessageBox.Show("Ingrese solo numeros"); 
                e.Handled = true;
                return;            
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtNumRep.Text= "";
            txtDescrip.Text = "";
            txtPrecio.Text = "";
            dgvDatos.Rows.Clear();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            dgvDatos.Rows.Clear();

            //ciclo for para ir agrendando 

            for (i = 0; i < pos; i++)
            {
                // Imprimir todos
                if (cmbOpciones.SelectedIndex == 0 || 

                 //si seleccionamos "Marca, filtramos por nombre y nacionalidad
                   (cmbOpciones.SelectedIndex == 1 && repuestos[i].marca == "Peugueot" && radNacional.Checked && repuestos[i].origen == "Nacional")||
                   (cmbOpciones.SelectedIndex == 1 && repuestos[i].marca == "Peugueot" && radImport.Checked && repuestos[i].origen == "Importado")||

                   (cmbOpciones.SelectedIndex == 2 && repuestos[i].marca == "Fiat" && radNacional.Checked && repuestos[i].origen == "Nacional") ||
                   (cmbOpciones.SelectedIndex == 2 && repuestos[i].marca == "Fiat" && radImport.Checked && repuestos[i].origen == "Importado") ||


                   (cmbOpciones.SelectedIndex == 3 &&  radNacional.Checked && repuestos[i].origen == "Nacional") ||
                   (cmbOpciones.SelectedIndex == 3 && radImport.Checked && repuestos[i].origen == "Importado"))
                {
                    //recorremos el arreglo 
                    dgvDatos.Rows.Add(repuestos[i].numero_rep.ToString(),
                                      repuestos[i].marca,
                                      repuestos[i].origen,
                                      repuestos[i].descripcion,
                                      repuestos[i].precio.ToString());
                }


            }


             

        }

        private void cmbOpciones_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtDescrip_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
