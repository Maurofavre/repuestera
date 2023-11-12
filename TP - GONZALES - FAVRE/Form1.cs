using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

        int codigo =0;
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

            radTodos.Checked = true;
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
            if (txtNumRep.Text.Length > 6)
            {
                MessageBox.Show("No se admiten mas de 6 caracteres");
                txtNumRep.Text = "";
            }
            if (txtDescrip.Text.Length > 50)
            {
                MessageBox.Show("No se admiten mas de 50 caracteres");
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
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            dgvDatos.Rows.Clear();


             
            int i;
            //imprimir todos ( todos adentro del mismo add 
            if (radTodos.Checked) {
              
                for ( i = 0; i < pos; i++)
                {
                    dgvDatos.Rows.Add(repuestos[i].numero_rep.ToString(),
                                      repuestos[i].marca,
                                      repuestos[i].origen,
                                      repuestos[i].descripcion,
                                      repuestos[i].precio.ToString()) ;
                }
            }
            if (radNacional.Checked)
            {
                for ( i = 0; i < pos; i++)
                {
                    if (repuestos[i].origen == "Nacional")
                    {
                        dgvDatos.Rows.Add(repuestos[i].numero_rep.ToString(),
                                          repuestos[i].marca.ToString(),
                                          repuestos[i].origen.ToString(),
                                          repuestos[i].descripcion.ToString(),
                                          repuestos[i].precio.ToString());
                    }
                }

            }
            if (radImport.Checked)
            {
                for (i = 0; i < pos; i++)
                {
                    if (repuestos[i].origen == "Importado")
                    {
                        dgvDatos.Rows.Add(repuestos[i].numero_rep.ToString(),
                                          repuestos[i].marca.ToString(),
                                          repuestos[i].origen.ToString(),
                                          repuestos[i].descripcion.ToString(),
                                          repuestos[i].precio.ToString());
                    }
                }

            }




        }







    }
}
