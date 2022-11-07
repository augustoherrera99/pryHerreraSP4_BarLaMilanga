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
            public int mozos;
            public int ventas;
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
                MessageBox.Show("¡Datos ingresados con éxito!", "Notificación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnMozoDelDia_Click(object sender, EventArgs e)
        {
            float Julio = 0;
            for (int columna = 0; columna <= Ventas.GetUpperBound(1); columna++)
            {
                Julio += Ventas[0, columna];
            }
            

            float Esteban = 0;
            for (int columna = 0; columna <= Ventas.GetUpperBound(1); columna++)
            {
                Esteban += Ventas[1, columna];
            }
            

            float Javier = 0;
            for (int columna = 0; columna <= Ventas.GetUpperBound(1); columna++)
            {
                Javier += Ventas[2, columna];
            }
            

            float Gonzalo = 0;
            for (int columna = 0; columna <= Ventas.GetUpperBound(1); columna++)
            {
                Gonzalo += Ventas[3, columna];
            }
           

            float Alberto = 0;
            for (int columna = 0; columna <= Ventas.GetUpperBound(1); columna++)
            {
                Alberto += Ventas[4, columna];
            }

            float[] Mozos = new float[5] {Julio, Esteban, Javier, Gonzalo, Alberto};


        }

        private void dgvGrillaVentas_KeyPress(object sender, KeyPressEventArgs e)
        {
   
        }

        private void dgvGrillaVentas_Validating(object sender, CancelEventArgs e)
        {
    
        }


    }
}
