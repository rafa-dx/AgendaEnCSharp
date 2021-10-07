using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Agenda
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Conexion.Conectar();
            MessageBox.Show("conexion exitosa");
            dataGridView1.DataSource = Llenar_grid();
        }
        public DataTable Llenar_grid()
        {
            Conexion.Conectar();
            DataTable dt = new DataTable();
            string consulta = "SELECT * FROM DATOS";
            SqlCommand cmd = new SqlCommand(consulta,Conexion.Conectar());

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;

        }

        private void B_Agregar_Click(object sender, EventArgs e)
        {
            Conexion.Conectar();
            string insertar = "INSERT INTO DATOS (NOMBRE,TELEFONO,CORREO)VALUES(@NOMBRE,@TELEFONO,@CORREO)";
            SqlCommand cmd1 = new SqlCommand(insertar,Conexion.Conectar());
            cmd1.Parameters.AddWithValue("@NOMBRE", Txb_name.Text);
            cmd1.Parameters.AddWithValue("@TELEFONO", Txb_telefono.Text);
            cmd1.Parameters.AddWithValue("@CORREO", Txb_correo.Text);

            cmd1.ExecuteNonQuery();

            MessageBox.Show("Datos agregados con exito");
            dataGridView1.DataSource = Llenar_grid();
            Txb_correo.Text = " ";
            Txb_name.Text = " ";
            Txb_telefono.Text = " ";

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try 
            {
                Txb_ID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                Txb_name.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                Txb_telefono.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                Txb_correo.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            }
            catch 
            {
                MessageBox.Show("Error de selección");
            }
        }

        private void B_Modificar_Click(object sender, EventArgs e)
        {
            Conexion.Conectar();
            string actualzar = "UPDATE DATOS SET NOMBRE=@NOMBRE, TELEFONO=@TELEFONO,CORREO=@CORREO WHERE ID=@ID";
            SqlCommand cmd2 = new SqlCommand(actualzar, Conexion.Conectar());
            cmd2.Parameters.AddWithValue("@ID", Txb_ID.Text);
            cmd2.Parameters.AddWithValue("@NOMBRE", Txb_name.Text);
            cmd2.Parameters.AddWithValue("@TELEFONO", Txb_telefono.Text);
            cmd2.Parameters.AddWithValue("@CORREO", Txb_correo.Text);

            cmd2.ExecuteNonQuery();

            MessageBox.Show("Datos Modificados con exito");
            dataGridView1.DataSource = Llenar_grid();
            Txb_correo.Text = " ";
            Txb_name.Text = " ";
            Txb_telefono.Text = " ";
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void B_nuevo_Click(object sender, EventArgs e)
        {
            Txb_correo.Text = " ";
            Txb_name.Text = " ";
            Txb_telefono.Text = " ";
        }

        private void B_eliminar_Click(object sender, EventArgs e)
        {

            Conexion.Conectar();
            string borrar = "DELETE FROM DATOS WHERE ID=@ID";
            SqlCommand cmd3 = new SqlCommand(borrar, Conexion.Conectar());
            cmd3.Parameters.AddWithValue("@ID", Txb_ID.Text);
       

            cmd3.ExecuteNonQuery();

            MessageBox.Show("Datos Borrados");
            dataGridView1.DataSource = Llenar_grid();
            Txb_ID.Clear();
            Txb_correo.Clear();
            Txb_name.Clear();
            Txb_telefono.Clear();


        }
    }
}
