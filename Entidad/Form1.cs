using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Entidad
{
    
    public partial class Entidades : Form
        
       
    {

      
        private string _nombre;
        private string _apellidos;
        private int _edad;
        DateTime _fecha;

        public string Nombre
        {
            get
            {
                return _nombre;
            }
            set
            {
                _nombre = value;
            }
        }
        public string Apellidos
        {
            get
            {
                return _apellidos;
            }
            set
            {
                _apellidos = value;
            }
        }

        public int Edad
        {
            get
            {
                return _edad;
            }
            set
            {
                _edad = value;
                
            }
            
        }
        DateTime Fecha
        {
            get
            {
                return _fecha;
            }
            set
            {
                _fecha = value;
            }
        }
        
        public Entidades()
        {
            InitializeComponent();
        }
        // Arraylist creado para data grid
        ArrayList lista = new ArrayList();
       
        
       

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            


        }

        private void Entidades_Load(object sender, EventArgs e)
        {

        }

        private void BTIngresar_Click(object sender, EventArgs e)
        {
           
        }

      

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
          
          
                
                
                
          }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void TBFecha_TextChanged(object sender, EventArgs e)
        {

        }

        private void Titulo_Click(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {

            int edad = Convert.ToInt32(TBEdad.Text );
            DateTime fecha = Convert.ToDateTime(TBFecha.Text);  // Convertir la fecha a DateTime
            if (edad >= 18)
            {
                MessageBox.Show("Puede ingresar( mayor de edad)");
            }
            else
            {
                MessageBox.Show(" NO INGRESAR Es menor de edad");
            }
            



            // Crear un objeto de tipo Entidad
            string nombre = TBNombre.Text;
            string apellidos = TBApellido.Text;
            lista.Add(nombre);
            lista.Add(apellidos);
            lista.Add(fecha);
            lista.Add(edad);
            Datos.Rows.Add(lista.ToArray());

        
            

        lista.Clear();

        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Datos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void TBEdad_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DateTime fechanac = TBFecha.Value;
            int edad = System.DateTime.Now.Year - fechanac.Year;
            TBEdad.Text = edad.ToString();
        
            if (System.DateTime.Now.Year - fechanac.Year > 18)
                
            {
                MessageBox.Show("Es mayor de edad");
            }
            else
            
            {
                
                MessageBox.Show("Es menor de edad");
                errorProvider1.SetError(TBEdad, "No es mayor de edad");
            }

        }
    }
    }
