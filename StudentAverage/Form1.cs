namespace StudentAverage
{
    public partial class Form1 : Form
    {
        double[][,] estudiantes = new double[1][,];

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;

            double[] calificaciones = new double[6];

            calificaciones[0] = Convert.ToDouble(txtMateria1.Text);
            calificaciones[1] = Convert.ToDouble(txtMateria2.Text);
            calificaciones[2] = Convert.ToDouble(txtMateria3.Text);
            calificaciones[3] = Convert.ToDouble(txtMateria4.Text);
            calificaciones[4] = Convert.ToDouble(txtMateria5.Text);
            calificaciones[5] = Convert.ToDouble(txtMateria6.Text);

            // Cálculate average
            double suma = 0;
            foreach (double calificacion in calificaciones)
            {
                suma += calificacion;
            }
            double promedio = suma / calificaciones.Length;

            // Actualizar el arreglo bidimensional con el nombre del estudiante y su promedio
            if (estudiantes[0] == null)
            {
                estudiantes[0] = new double[1, 2];
                estudiantes[0][0, 0] = promedio; // Promedio
                estudiantes[0][0, 1] = 1; // Cantidad de estudiantes
            }
            else
            {
                int numEstudiantes = (int)estudiantes[0][0, 1];
                double[,] temp = new double[numEstudiantes + 1, 2];
                Array.Copy(estudiantes[0], temp, numEstudiantes * 2);
                temp[numEstudiantes, 0] = promedio; // Promedio
                temp[numEstudiantes, 1] = numEstudiantes + 1; // Cantidad de estudiantes
                estudiantes[0] = temp;
            }

            string carrera = txtCarrera.Text;
            if (estudiantes.Length == 1)
            {
                estudiantes[0] = new double[1, 3];
                estudiantes[0][0, 0] = promedio; // Promedio
                estudiantes[0][0, 1] = 1; // Cantidad de estudiantes
                estudiantes[0][0, 2] = carrera.GetHashCode(); // Código de la carrera
            }
            else
            {
                int numEstudiantes = (int)estudiantes[0][0, 1];
                double[,] temp = new double[numEstudiantes + 1, 3];
                Array.Copy(estudiantes[0], temp, numEstudiantes * 3);
                temp[numEstudiantes, 0] = promedio; // Promedio
                temp[numEstudiantes, 1] = numEstudiantes + 1; // Cantidad de estudiantes
                temp[numEstudiantes, 2] = carrera.GetHashCode(); // Código de la carrera
                estudiantes[0] = temp;
            }

            string resultados = "";
            for (int i = 0; i < estudiantes[0].GetLength(0); i++)
            {
                resultados += "Estudiante :" + nombre + (i + 1) + " " + ": Promedio - " + " "  + estudiantes[0][i, 0].ToString("0.00") + ", Carrera - " + carrera + "\n";
            }
            MessageBox.Show(resultados);

            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            txtNombre.Text = "";
            txtMateria1.Text = "";
            txtMateria2.Text = "";
            txtMateria3.Text = "";
            txtMateria4.Text = "";
            txtMateria5.Text = "";
            txtMateria6.Text = "";
            txtCarrera.Text = "";
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

    }
    }

