using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace CapaConexion
{
    public class Conexion
    {

        //Varibles de instancia
        private String nombreBaseDeDatos;
        private String nombreTabla;
        private String cadenaConexion;
        private String cadenaSQL;
        private Boolean esSelect;
        private SqlConnection dbConnection;
        private DataSet dbDataSet;
        private SqlDataAdapter dbDataAdapter;


        public String NombreBaseDeDatos
        {
            get { return nombreBaseDeDatos; }
            set { nombreBaseDeDatos = value; }
        }

        public String NombreTabla
        {
            get { return nombreTabla; }
            set { nombreTabla = value; }
        }

        public String CadenaConexion
        {
            get { return cadenaConexion; }
            set { cadenaConexion = value; }
        }

        public String CadenaSQL
        {
            get { return cadenaSQL; }
            set { cadenaSQL = value; }
        }

        public Boolean EsSelect
        {
            get { return esSelect; }
            set { esSelect = value; }
        }

        public SqlConnection DbConnection
        {
            get { return dbConnection; }
            set { dbConnection = value; }
        }

        public DataSet DbDataSet
        {
            get { return dbDataSet; }
            set { dbDataSet = value; }
        }

        public SqlDataAdapter DbDataAdapter
        {
            get { return dbDataAdapter; }
            set { dbDataAdapter = value; }
        }

        //abrir la conexion

        public void abrir()
        {
            try
            {
                this.DbConnection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir la conexion " + ex.Message, "mensaje Sistema");
            }

        } //Fin abrir

        //Cerra la conexion

        public void cerrar()
        {
            try
            {
                this.DbConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cerrar la conexion " + ex.Message, "mensaje Sistema");
            }

        } //Fin cerrar

        //Metodo mas importante

        public void conectar()
        {
            //Se validan las variables de   
            if (this.NombreBaseDeDatos.Length == 0)
            {
                MessageBox.Show("Falta nombre base de datos ", "mensaje Sistema");
                return;
            }


            if (this.NombreTabla.Length == 0)
            {
                MessageBox.Show("Falta nombre tabla ", "mensaje Sistema");
                return;
            }

            if (this.CadenaConexion.Length == 0)
            {
                MessageBox.Show("Falta cadena C ", "mensajeonexion Sistema");
                return;
            }
            if (this.CadenaSQL.Length == 0)
            {
                MessageBox.Show("Falta cadena SQL ", "mensaje Sistema");
                return;
            }

            //SE instancia la Conexion

            try
            {
                this.DbConnection = new SqlConnection(this.CadenaConexion);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de Conexion " + ex.Message, "mensaje Sistema");
                return;
            }

            //SE abre la conexion
            this.abrir();

            //Se instancia el DataAdapter

            if (this.EsSelect)
            {
                //SE instancia dataSet

                this.DbDataSet = new DataSet();
                try
                {
                    this.DbDataAdapter = new SqlDataAdapter(this.CadenaSQL, this.DbConnection);
                    this.DbDataAdapter.Fill(this.DbDataSet, this.NombreTabla);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar los datos " + ex.Message, "mensaje Sistema");
                    return;

                }
            }
            else
            {
                try
                {
                    SqlCommand variableSQL = new SqlCommand(this.CadenaSQL, this.DbConnection);
                    variableSQL.ExecuteNonQuery();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error en SQL " + ex.Message, "mensaje Sistema");
                    return;

                }
            } //Fin if



            this.cerrar();

        } //Fin conectar

        //public static void Main(String[] args)
        //{

        //    Conexion conec1 = new Conexion();
        //    conec1.NombreBaseDeDatos = "prueba";
        //    conec1.NombreTabla = "cliente";
        //    conec1.CadenaConexion = "Data Source=DESKTOP-H9FPTMU;Initial Catalog=Prueba;Integrated Security=True";
        //    conec1.CadenaSQL = "select * from cliente";
        //    conec1.EsSelect = true;
        //    conec1.conectar();

        //    foreach (System.Data.DataRow dr in conec1.dbDataSet.Tables[conec1.NombreTabla].Rows)
        //    {
        //        Console.WriteLine(dr["rut"] + " " + dr["nombre"]);
        //    }
        //    Console.ReadKey();
        //}
    }
}