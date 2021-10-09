using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase_5_Botta
{
    public partial class FrmProductos : Form
    {
        List<Producto> lProducto = new List<Producto>();
        TipoProducto miTipo;
        enum TipoProducto
        { 
            Suelto,
            Pack
        }
        public FrmProductos()
        {
            InitializeComponent();
        }

        private void FrmProductos_Load(object sender, EventArgs e)
        {
            
        }

        private void rbtSuelto_CheckedChanged(object sender, EventArgs e)
        {
            lblMedida.Text = "Medida";
            miTipo = TipoProducto.Suelto;

        }

        private void rbtPack_CheckedChanged(object sender, EventArgs e)
        {
            lblMedida.Text = "Cantidad";
            miTipo = TipoProducto.Pack;
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            int cod;
            string nombre;
            double precio;
            cod = int.Parse(txtCodigo.Text);
            nombre = txtNombre.Text;
            precio = double.Parse(txtPrecio.Text);


           // if (rbtPack.Checked)
           if(miTipo==TipoProducto.Pack)
            {//PACK
                int cant;
                cant = int.Parse(txtMedida.Text);
                Pack p = new Pack(cod, nombre, precio, cant);

                lProducto.Add(p);

            }
            else 
            { //SUELTO
                double cant;
                cant = double.Parse(txtMedida.Text);
                Suelto s = new Suelto(cod, nombre, precio, cant);
                lProducto.Add(s);
            }
            lstProductos.Items.Clear();
            lstProductos.Items.AddRange(lProducto.ToArray());
        
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            double total = 0;
            //for (int i = 0; i < lProducto.Count; i++)
            //{
            //    total += lProducto[i].CalcularPrecio();
            //}

            foreach (Producto i in lProducto)
            {
                total += i.CalcularPrecio();
            }

            txtTotal.Text = total.ToString();
        }
    }
}
