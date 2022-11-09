using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryHerreraSP4_BarLaMilanga
{
    public partial class frmBarLaMilanga : Form
    {
        public frmBarLaMilanga()
        {
            InitializeComponent();
        }

        float[,] Ventas = new float[5, 4];
        public struct DATOS
        {
            public string mozo;
            public float ventasTotales;
        }
        
        private void frmBarLaMilanga_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 5; i++)
            {
              dgvGrillaVentas.Rows.Add();
            }
            dgvGrillaVentas.Rows[0].Cells[0].Value = "Julio";
            dgvGrillaVentas.Rows[1].Cells[0].Value = "Esteban";
            dgvGrillaVentas.Rows[2].Cells[0].Value = "Javier";
            dgvGrillaVentas.Rows[3].Cells[0].Value = "Gonzalo";
            dgvGrillaVentas.Rows[4].Cells[0].Value = "Alberto";
            dgvGrillaVentas.Columns[0].ReadOnly = true;
            dgvGrillaVentas.ClearSelection();
        }

        private void btnValidarDatos_Click(object sender, EventArgs e)
        {
            dgvGrillaVentas.ClearSelection();

            for (int i = 0; i < dgvGrillaVentas.RowCount; i++)
            {
                if (dgvGrillaVentas.Rows[i].Cells[1].Value == null || dgvGrillaVentas.Rows[i].Cells[2].Value == null || 
                    dgvGrillaVentas.Rows[i].Cells[3].Value == null || dgvGrillaVentas.Rows[i].Cells[4].Value == null)
                {
                    MessageBox.Show("Debe completar los datos de todas las ventas.",
                                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            int fallos = 0;

            for (int columna = 1; columna < dgvGrillaVentas.ColumnCount; columna++)
            {
                for (int fila = 0; fila < dgvGrillaVentas.RowCount; fila++)
                {
                    string valor = dgvGrillaVentas.Rows[fila].Cells[columna].Value.ToString();
                    bool a = float.TryParse(valor, out float result);

                    if (a == false)
                    {
                        fallos++;
                    }
                }
            }

            if (fallos > 0)
            {
                mrcConsultas.Enabled = false;
                MessageBox.Show("Ingrese únicamente valores númericos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                fallos = 0;
            }
            else
            {
                for (int columna = 1; columna < dgvGrillaVentas.ColumnCount; columna++)
                {
                    for (int fila = 0; fila < dgvGrillaVentas.RowCount; fila++)
                    {
                        string dato = dgvGrillaVentas.Rows[fila].Cells[columna].Value.ToString();
                        Ventas[fila, columna-1] = float.Parse(dato);
                    }
                }
                mrcConsultas.Enabled = true;
                btnTest.Enabled = false;
                dgvGrillaVentas.Enabled = false;
                MessageBox.Show("¡Validación exitosa! Se han cargado todos los datos.", "Notificación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnMozoDelDia_Click(object sender, EventArgs e)
        {
            DATOS[] MozoDelDia = new DATOS[5];
            float mayorVentas = float.MinValue;
            string mozoMayorVentas = "";

            for (int columna = 0; columna <= Ventas.GetUpperBound(1); columna++)
            {
                MozoDelDia[0].ventasTotales += Ventas[0, columna];
                MozoDelDia[0].mozo = dgvGrillaVentas.Rows[0].Cells[0].Value.ToString();
            }

            for (int columna = 0; columna <= Ventas.GetUpperBound(1); columna++)
            {
                MozoDelDia[1].ventasTotales += Ventas[1, columna];
                MozoDelDia[1].mozo = dgvGrillaVentas.Rows[1].Cells[0].Value.ToString();
            }
            
            for (int columna = 0; columna <= Ventas.GetUpperBound(1); columna++)
            {
                MozoDelDia[2].ventasTotales += Ventas[2, columna];
                MozoDelDia[2].mozo = dgvGrillaVentas.Rows[2].Cells[0].Value.ToString();
            }
            
            for (int columna = 0; columna <= Ventas.GetUpperBound(1); columna++)
            {
                MozoDelDia[3].ventasTotales += Ventas[3, columna];
                MozoDelDia[3].mozo = dgvGrillaVentas.Rows[3].Cells[0].Value.ToString();
            }
           
            for (int columna = 0; columna <= Ventas.GetUpperBound(1); columna++)
            {
                MozoDelDia[4].ventasTotales += Ventas[4, columna];
                MozoDelDia[4].mozo = dgvGrillaVentas.Rows[4].Cells[0].Value.ToString();
            }

            for (int i = 0; i <= MozoDelDia.GetUpperBound(0); i++)
            {

                if (MozoDelDia[i].ventasTotales > mayorVentas)
                {
                    mayorVentas = MozoDelDia[i].ventasTotales;
                    mozoMayorVentas = MozoDelDia[i].mozo;
                }
            }

            lstResultado.Items.Clear();
            lstResultado.Items.Add("MOZO DEL DÍA");
            lstResultado.Items.Add("");
            lstResultado.Items.Add("Nombre: " + mozoMayorVentas.ToString());
            lstResultado.Items.Add("Total recaudado: $" + mayorVentas);
        }
        private void btnTotales_Click(object sender, EventArgs e)
        {
            float ventasTotales = 0;

            foreach (var item in Ventas)
            {
                ventasTotales += item;
            }

            float Comidas = 0;
            for (int fila = 0; fila < Ventas.GetUpperBound(0); fila++)
            {
                Comidas += Ventas[fila, 0];
            }

            float BSA = 0;
            for (int fila = 0; fila < Ventas.GetUpperBound(0); fila++)
            {
                BSA += Ventas[fila, 1];
            }

            float BCA = 0;
            for (int fila = 0; fila < Ventas.GetUpperBound(0); fila++)
            {
                BCA += Ventas[fila, 2];
            }

            float Postres = 0;
            for (int fila = 0; fila < Ventas.GetUpperBound(0); fila++)
            {
                Postres += Ventas[fila, 3];
            }

            lstResultado.Items.Clear();
            lstResultado.Items.Add("TOTALES");
            lstResultado.Items.Add("");
            lstResultado.Items.Add("Total recaudado en el día: $" + ventasTotales.ToString());
            lstResultado.Items.Add("Total recaudado en Comidas: $" + Comidas.ToString());
            lstResultado.Items.Add("Total recaudado en Bebidas sin Alcohol: $" + BSA.ToString());
            lstResultado.Items.Add("Total recaudado en Bebidas con Alcohol: $" + BCA.ToString());
            lstResultado.Items.Add("Total recaudado en Postres: $" + Postres.ToString());
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            Random nroAleatorio = new Random();

            for (int columna = 1; columna < dgvGrillaVentas.ColumnCount; columna++)
            {
                for (int fila = 0; fila < dgvGrillaVentas.RowCount; fila++)
                {
                    dgvGrillaVentas.Rows[fila].Cells[columna].Value = nroAleatorio.Next(0, 20001);
                }
            }
        }

        private void btnLimpiarConsulta_Click(object sender, EventArgs e)
        {
            lstResultado.Items.Clear();
        }

        private void btnLimpiarGrilla_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro que quiere eliminar la totalidad de los datos ingresados en la grilla?", "¡Advertencia!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            switch (result)
            {
                case DialogResult.Yes:

                    dgvGrillaVentas.Rows.Clear();
                    lstResultado.Items.Clear();
                    mrcConsultas.Enabled = false;
                    btnTest.Enabled = true;
                    dgvGrillaVentas.Enabled = true;

                    for (int i = 1; i <= 5; i++)
                    {
                        dgvGrillaVentas.Rows.Add();
                    }
                    dgvGrillaVentas.Rows[0].Cells[0].Value = "Julio";
                    dgvGrillaVentas.Rows[1].Cells[0].Value = "Esteban";
                    dgvGrillaVentas.Rows[2].Cells[0].Value = "Javier";
                    dgvGrillaVentas.Rows[3].Cells[0].Value = "Gonzalo";
                    dgvGrillaVentas.Rows[4].Cells[0].Value = "Alberto";
                    dgvGrillaVentas.Columns[0].ReadOnly = true;
                    dgvGrillaVentas.ClearSelection();
                    break;

                case DialogResult.No:
                    break;
            }
            
        }

        private void dgvGrillaVentas_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void dgvGrillaVentas_Validating(object sender, CancelEventArgs e)
        {

        }
    }
}
