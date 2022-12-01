using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConexionAMySQL_26_11_12
{
    public partial class Form1 : Form
    {
        private MySqlConnection mySqlConnection = new MySqlConnection();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtHost.Text))
            {
                MessageBox.Show("El host es campo requerido");
                return;
            }

            if (string.IsNullOrEmpty(txtUser.Text))
            {
                MessageBox.Show("El usuario es campo requerido");
                return;
            }

            if (string.IsNullOrEmpty(txtPwd.Text))
            {
                MessageBox.Show("El password es campo requerido");
                return;
            }

            try
            {
                mySqlConnection.ConnectionString = "server=" + txtHost.Text + ";"
                    + "user id=" + txtUser.Text + ";"
                    + "password=" + txtPwd.Text + ";";

                mySqlConnection.Open();
                MessageBox.Show("LA CONEXIÓN SE REALIZÓ EXITOSAMENTE");
            }
            catch(Exception ex) 
            {
                MessageBox.Show("ERROR AL CONECTAR: "+ex.Message);
            }
            finally
            {
                if (mySqlConnection.State == System.Data.ConnectionState.Open)
                    mySqlConnection.Close(); 
            }
        }
    }
}
