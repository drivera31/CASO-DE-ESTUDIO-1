namespace CASO_DE_ESTUDIO_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void buttonmostrarresumen_Click(object sender, EventArgs e)
        {
            //===========================================
            // 1-         VALIDAR EL NOMBRE
            //===========================================
            if (string.IsNullOrWhiteSpace(txtnombre.Text))
            {
                MessageBox.Show(
                    "Por favor, escribe tu nombre.",
                    "Validacion",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtnombre.Focus();
            }
            //===========================================
            //2.-  OBTENER LAS ACTIVIDADES SELECCIONADAS
            //===========================================
            List<string> actividades = new List<string>();
            if (chkdeportes.Checked)
            {
                actividades.Add("Deportes");
            }
            if (chkmusica.Checked)
            {
                actividades.Add("Música");
            }
            if (chkarte.Checked)
            {
                actividades.Add("Arte");
            }
            if (chklectura.Checked)
            {
                actividades.Add("Lectura");
            }
            if (chkprogramacion.Checked)
            {
                actividades.Add("Porgramación");
            }

            //==============================================
            //3.-COMPROBAR AL MENOS UNA ACTIVIDAD
            //==============================================
            if (actividades.Count == 0)
            {
                MessageBox.Show(
                    "Por favor, selecciona al menos una actividad.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {

        }

        private void txtresumen_TextChanged(object sender, EventArgs e)
        {

        }

        private void chkprogramacion_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkarte_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
