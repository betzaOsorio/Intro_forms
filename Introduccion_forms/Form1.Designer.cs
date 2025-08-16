namespace Introduccion_forms
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
            txtnombre = new TextBox();
            txtcarnet = new TextBox();
            txtCarrera = new TextBox();
            btnAgregar = new Button();
            btnLimpiar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lblEstudiantes = new Label();
            SuspendLayout();
            // 
            // txtnombre
            // 
            txtnombre.Location = new Point(138, 28);
            txtnombre.Name = "txtnombre";
            txtnombre.Size = new Size(100, 23);
            txtnombre.TabIndex = 0;
            // 
            // txtcarnet
            // 
            txtcarnet.Location = new Point(138, 72);
            txtcarnet.Name = "txtcarnet";
            txtcarnet.Size = new Size(100, 23);
            txtcarnet.TabIndex = 1;
            // 
            // txtCarrera
            // 
            txtCarrera.Location = new Point(138, 113);
            txtCarrera.Name = "txtCarrera";
            txtCarrera.Size = new Size(100, 23);
            txtCarrera.TabIndex = 2;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.Red;
            btnAgregar.FlatStyle = FlatStyle.Popup;
            btnAgregar.ForeColor = SystemColors.Control;
            btnAgregar.Location = new Point(315, 27);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 3;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = SystemColors.HotTrack;
            btnLimpiar.FlatStyle = FlatStyle.Popup;
            btnLimpiar.ForeColor = SystemColors.ControlLightLight;
            btnLimpiar.Location = new Point(315, 75);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 4;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(27, 31);
            label1.Name = "label1";
            label1.Size = new Size(105, 15);
            label1.TabIndex = 5;
            label1.Text = "Ingrese su nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(30, 75);
            label2.Name = "label2";
            label2.Size = new Size(96, 15);
            label2.TabIndex = 6;
            label2.Text = "Ingrese su carnet";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(32, 116);
            label3.Name = "label3";
            label3.Size = new Size(99, 15);
            label3.TabIndex = 7;
            label3.Text = "Ingrese su carrera";
            // 
            // lblEstudiantes
            // 
            lblEstudiantes.AutoSize = true;
            lblEstudiantes.Location = new Point(71, 173);
            lblEstudiantes.Name = "lblEstudiantes";
            lblEstudiantes.Size = new Size(0, 15);
            lblEstudiantes.TabIndex = 8;
            // 
            // Form1
            // 
            AcceptButton = btnAgregar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            CancelButton = btnLimpiar;
            ClientSize = new Size(436, 450);
            Controls.Add(lblEstudiantes);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnLimpiar);
            Controls.Add(btnAgregar);
            Controls.Add(txtCarrera);
            Controls.Add(txtcarnet);
            Controls.Add(txtnombre);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtnombre;
        private TextBox txtcarnet;
        private TextBox txtCarrera;
        private Button btnAgregar;
        private Button btnLimpiar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label lblEstudiantes;
    }
}
