using System;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                if (comboBox1.SelectedItem == null)
                {
                    MessageBox.Show("Por favor, seleccione un vehículo.");
                    return;
                }

                if (comboBox1.SelectedItem.ToString() == "AUTO")
                {
                    int num = 0;

                    Auto auto = new Auto()
                    {
                        Nombre = txtNombre.Text,
                        AnioMarca = (int)nupAnio.Value,
                        Precio = nupPrecio.Value,
                        Modelo = txtModelo.Text
                    };

                   
                    Verificar(ref num, auto.Nombre, auto.Modelo, auto.Precio);
                    if (num == 0)
                    {
                        listBox1.Items.Add(auto.Descripcion());
                        
                        txtNombre.Clear();
                        txtModelo.Clear();
                        nupAnio.ResetText();
                        nupPrecio.ResetText();

                    }
                    else
                    {
                        MessageBox.Show("Información incompleta. Por favor, complete los campos correctamente",
                                        "ERROR: -1",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                    }

                    txtNombre.Focus();

                }
                else if (comboBox1.SelectedItem.ToString() == "MOTO")
                {
                    int num = 0;

                    Moto moto = new Moto()
                    {
                        Nombre = txtNombre.Text,
                        AnioMarca = (int)nupAnio.Value,
                        Precio = nupPrecio.Value,
                        Modelo = txtModelo.Text
                    };


                    Verificar(ref num, moto.Nombre, moto.Modelo, moto.Precio);
                    if (num == 0)
                    {

                        listBox1.Items.Add(moto.Descripcion());

                        txtNombre.Clear();
                        txtModelo.Clear();
                        nupAnio.ResetText();
                        nupPrecio.ResetText();

                    }
                    else
                    {
                        MessageBox.Show("Información incompleta. Por favor, complete los campos correctamente",
                                        "ERROR: -1",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                    }
                    
                    txtNombre.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ha ocurrido un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Items.AddRange(new object[] { "AUTO", "MOTO" });
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void Verificar(ref int n, string nombre, string modelo, decimal precio)
        {
            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(modelo) || precio == 0)
            {
                n = -1;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                // Eliminamos el elemento seleccionado
                listBox1.Items.Remove(listBox1.SelectedItem);
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un vehículo para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}

