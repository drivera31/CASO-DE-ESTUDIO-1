namespace CASO_DE_ESTUDIO_1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtnombre = new TextBox();
            groupBox1 = new GroupBox();
            chkdeportes = new CheckBox();
            chkmusica = new CheckBox();
            chkarte = new CheckBox();
            chkprogramacion = new CheckBox();
            chklectura = new CheckBox();
            groupBox2 = new GroupBox();
            RBPRESENCIAL = new RadioButton();
            RBHIBRIDA = new RadioButton();
            RBENLINEA = new RadioButton();
            btnmostarresumen = new Button();
            btnlimpiar = new Button();
            label2 = new Label();
            txtresumen = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(25, 63);
            label1.Name = "label1";
            label1.Size = new Size(157, 14);
            label1.TabIndex = 0;
            label1.Text = "Nombre del estudiante:";
            // 
            // txtnombre
            // 
            txtnombre.Location = new Point(200, 59);
            txtnombre.Name = "txtnombre";
            txtnombre.Size = new Size(299, 23);
            txtnombre.TabIndex = 1;
            txtnombre.TextChanged += textBox1_TextChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(chkdeportes);
            groupBox1.Controls.Add(chkmusica);
            groupBox1.Controls.Add(chkarte);
            groupBox1.Controls.Add(chkprogramacion);
            groupBox1.Controls.Add(chklectura);
            groupBox1.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(70, 184);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(274, 261);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "ACTIVIDADES FAVORITAS";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // chkdeportes
            // 
            chkdeportes.AutoSize = true;
            chkdeportes.Location = new Point(22, 37);
            chkdeportes.Name = "chkdeportes";
            chkdeportes.Size = new Size(81, 20);
            chkdeportes.TabIndex = 0;
            chkdeportes.Text = "Deportes";
            chkdeportes.UseVisualStyleBackColor = true;
            chkdeportes.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // chkmusica
            // 
            chkmusica.AutoSize = true;
            chkmusica.Location = new Point(22, 82);
            chkmusica.Name = "chkmusica";
            chkmusica.Size = new Size(70, 20);
            chkmusica.TabIndex = 1;
            chkmusica.Text = "Música";
            chkmusica.UseVisualStyleBackColor = true;
            chkmusica.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // chkarte
            // 
            chkarte.AutoSize = true;
            chkarte.Location = new Point(22, 129);
            chkarte.Name = "chkarte";
            chkarte.Size = new Size(52, 20);
            chkarte.TabIndex = 2;
            chkarte.Text = "Arte";
            chkarte.UseVisualStyleBackColor = true;
            chkarte.CheckedChanged += chkarte_CheckedChanged;
            // 
            // chkprogramacion
            // 
            chkprogramacion.AutoSize = true;
            chkprogramacion.Location = new Point(22, 173);
            chkprogramacion.Name = "chkprogramacion";
            chkprogramacion.Size = new Size(113, 20);
            chkprogramacion.TabIndex = 3;
            chkprogramacion.Text = "Programación";
            chkprogramacion.UseVisualStyleBackColor = true;
            chkprogramacion.CheckedChanged += chkprogramacion_CheckedChanged;
            // 
            // chklectura
            // 
            chklectura.AutoSize = true;
            chklectura.Location = new Point(22, 220);
            chklectura.Name = "chklectura";
            chklectura.Size = new Size(72, 20);
            chklectura.TabIndex = 4;
            chklectura.Text = "Lectura";
            chklectura.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(RBPRESENCIAL);
            groupBox2.Controls.Add(RBHIBRIDA);
            groupBox2.Controls.Add(RBENLINEA);
            groupBox2.Font = new Font("Segoe UI Emoji", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(445, 184);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(268, 261);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Modalidad preferida";
            // 
            // RBPRESENCIAL
            // 
            RBPRESENCIAL.AutoSize = true;
            RBPRESENCIAL.Location = new Point(26, 82);
            RBPRESENCIAL.Name = "RBPRESENCIAL";
            RBPRESENCIAL.Size = new Size(94, 21);
            RBPRESENCIAL.TabIndex = 4;
            RBPRESENCIAL.TabStop = true;
            RBPRESENCIAL.Text = "Presencial";
            RBPRESENCIAL.UseVisualStyleBackColor = true;
            // 
            // RBHIBRIDA
            // 
            RBHIBRIDA.AutoSize = true;
            RBHIBRIDA.Location = new Point(26, 129);
            RBHIBRIDA.Name = "RBHIBRIDA";
            RBHIBRIDA.Size = new Size(76, 21);
            RBHIBRIDA.TabIndex = 5;
            RBHIBRIDA.TabStop = true;
            RBHIBRIDA.Text = "Hibrida";
            RBHIBRIDA.UseVisualStyleBackColor = true;
            // 
            // RBENLINEA
            // 
            RBENLINEA.AutoSize = true;
            RBENLINEA.Location = new Point(26, 173);
            RBENLINEA.Name = "RBENLINEA";
            RBENLINEA.Size = new Size(82, 21);
            RBENLINEA.TabIndex = 6;
            RBENLINEA.TabStop = true;
            RBENLINEA.Text = "En Linea";
            RBENLINEA.UseVisualStyleBackColor = true;
            // 
            // btnmostarresumen
            // 
            btnmostarresumen.Location = new Point(445, 532);
            btnmostarresumen.Name = "btnmostarresumen";
            btnmostarresumen.Size = new Size(161, 23);
            btnmostarresumen.TabIndex = 7;
            btnmostarresumen.Text = "Mostrar resumen";
            btnmostarresumen.UseVisualStyleBackColor = true;
            btnmostarresumen.Click += buttonmostrarresumen_Click;
            // 
            // btnlimpiar
            // 
            btnlimpiar.Location = new Point(664, 532);
            btnlimpiar.Name = "btnlimpiar";
            btnlimpiar.Size = new Size(75, 23);
            btnlimpiar.TabIndex = 8;
            btnlimpiar.Text = "LIMPIAR";
            btnlimpiar.UseVisualStyleBackColor = true;
            btnlimpiar.Click += btnlimpiar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(70, 634);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 9;
            label2.Text = "RESUMEN";
            // 
            // txtresumen
            // 
            txtresumen.Location = new Point(46, 665);
            txtresumen.Multiline = true;
            txtresumen.Name = "txtresumen";
            txtresumen.Size = new Size(723, 224);
            txtresumen.TabIndex = 10;
            txtresumen.TextChanged += txtresumen_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(822, 941);
            Controls.Add(txtresumen);
            Controls.Add(label2);
            Controls.Add(btnmostarresumen);
            Controls.Add(btnlimpiar);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(txtnombre);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Preferencia de Actividades";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtnombre;
        private GroupBox groupBox1;
        private CheckBox chkdeportes;
        private CheckBox chkmusica;
        private CheckBox chkarte;
        private CheckBox chkprogramacion;
        private CheckBox chklectura;
        private GroupBox groupBox2;
        private RadioButton RBPRESENCIAL;
        private RadioButton RBHIBRIDA;
        private RadioButton RBENLINEA;
        private Button btnmostarresumen;
        private Button btnlimpiar;
        private Label label2;
        private TextBox txtresumen;
    }
}
