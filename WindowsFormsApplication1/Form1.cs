using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        ////Pour Access----  using System.Data.OleDb;
        //OleDbConnection AccesConnection = new OleDbConnection();
        //OleDbDataAdapter AccesAdapter = new OleDbDataAdapter();
        //String AccesChaineConnection = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=|DataDirectory|\\BDAcces.mdb;Persist Security Info=True";

        ////Pour SQL Server----using System.Data.SqlClient;
        //SqlConnection SQLserverConnection = new SqlConnection();
        //SqlDataAdapter SQLserverAdapter = new SqlDataAdapter();
        //String SQLserverChaineConnection = "Data Source=.\\SQLEXPRESS;Initial Catalog=BdSQLserver;Integrated Security=True";

        ////Pour MySQL-----using MySql.Data.MySqlClient;
        //MySqlConnection MySQLConnection = new MySqlConnection();
        //MySqlDataAdapter MySQLAdapter = new MySqlDataAdapter();
        //String MySQLChaineConnection = "server=localhost; user id=root;password= ;database=BdMySQL";

        ////Pour Oracle---------using System.Data.OracleClient;
        //OracleConnection OracleConnection = new OracleConnection();
        //OracleDataAdapter OracleAdapter = new OracleDataAdapter();
        //String OracleChaineConnection = "Data Source=BdOracle;User Id=hr;Password=hr";//;DBA Privilege=SYSDBA



        static string chaine = @"Data Source=DESKTOP-IOMF4D2\MSSQLSERVER02 ;Initial Catalog=VENTES2;Integrated Security=True";
        //"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\App_Data\VotreBD.mdf;Integrated Security=True;User Instance=True"
        //"Server=.\SQLEXPRESS; DataBase=VotreBD;USER ID=sa; PASSWORD="
        static SqlConnection cnx = new SqlConnection(chaine);
        static SqlCommand cmd = new SqlCommand();
        static SqlDataAdapter adapter = new SqlDataAdapter(cmd);

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }


        private void btnInsert_Click(object sender, EventArgs e)
        {
            cnx.Open();
            cmd.Connection = cnx;
            /*cmd.CommandText = "insert into Dossier(ID_DOSSIER, NOM_DOSSIER) values('" + txtId_dossier.Text + "','" + txtNom_dossier.Text + "') ";*/
            cmd.CommandText = "insert into ETUDIANT(id, prenom,nom ) values(7090,'ilyas','grid')";
            cmd.ExecuteNonQuery();
            cnx.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            cnx.Open();
            cmd.Connection = cnx;
            cmd.CommandText = "update ETUDIANT set NOM='" + txtNom_dossier.Text + "' where id='" + txtId_dossier.Text + "' ";
            cmd.ExecuteNonQuery();
            cnx.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            cnx.Open();
            cmd.Connection = cnx;
            cmd.CommandText = "delete from ETUDIANT where ID='" + txtId_dossier.Text + "' ";
            cmd.ExecuteNonQuery();
            cnx.Close();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            cnx.Open();
            cmd.CommandText = "select * from ETUDIANT";
            cmd.Connection = cnx;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            cnx.Close();
        }
    }
}
