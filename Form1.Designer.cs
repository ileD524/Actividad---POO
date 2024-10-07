namespace WinFormsApp1
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
            button1 = new Button();
            comboBox1 = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            nupAnio = new NumericUpDown();
            nupPrecio = new NumericUpDown();
            txtNombre = new TextBox();
            txtModelo = new TextBox();
            label5 = new Label();
            listBox1 = new ListBox();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)nupAnio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nupPrecio).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(241, 26);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Agregar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(114, 26);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 1;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            comboBox1.KeyPress += comboBox1_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 30);
            label1.Name = "label1";
            label1.Size = new Size(96, 15);
            label1.TabIndex = 2;
            label1.Text = "Elija un vehículo:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 103);
            label2.Name = "label2";
            label2.Size = new Size(134, 15);
            label2.TabIndex = 3;
            label2.Text = "Nombre del Propietario:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(51, 186);
            label3.Name = "label3";
            label3.Size = new Size(95, 15);
            label3.TabIndex = 4;
            label3.Text = "Año del modelo:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(103, 240);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 5;
            label4.Text = "Precio:";
            // 
            // nupAnio
            // 
            nupAnio.Location = new Point(152, 184);
            nupAnio.Maximum = new decimal(new int[] { 2024, 0, 0, 0 });
            nupAnio.Minimum = new decimal(new int[] { 2000, 0, 0, 0 });
            nupAnio.Name = "nupAnio";
            nupAnio.Size = new Size(120, 23);
            nupAnio.TabIndex = 6;
            nupAnio.Value = new decimal(new int[] { 2000, 0, 0, 0 });
            // 
            // nupPrecio
            // 
            nupPrecio.DecimalPlaces = 2;
            nupPrecio.Increment = new decimal(new int[] { 2, 0, 0, 0 });
            nupPrecio.Location = new Point(152, 232);
            nupPrecio.Maximum = new decimal(new int[] { -1304428544, 434162106, 542, 0 });
            nupPrecio.Name = "nupPrecio";
            nupPrecio.Size = new Size(120, 23);
            nupPrecio.TabIndex = 7;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(152, 100);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(257, 23);
            txtNombre.TabIndex = 8;
            // 
            // txtModelo
            // 
            txtModelo.Location = new Point(152, 143);
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(257, 23);
            txtModelo.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(95, 146);
            label5.Name = "label5";
            label5.Size = new Size(51, 15);
            label5.TabIndex = 10;
            label5.Text = "Modelo:";
            // 
            // listBox1
            // 
            listBox1.AccessibleDescription = "false";
            listBox1.AccessibleName = "false";
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(428, 30);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(372, 184);
            listBox1.TabIndex = 11;
            // 
            // button2
            // 
            button2.Location = new Point(602, 220);
            button2.Name = "button2";
            button2.Size = new Size(75, 42);
            button2.TabIndex = 12;
            button2.Text = "Eliminar de la lista";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(812, 311);
            Controls.Add(button2);
            Controls.Add(listBox1);
            Controls.Add(label5);
            Controls.Add(txtModelo);
            Controls.Add(txtNombre);
            Controls.Add(nupPrecio);
            Controls.Add(nupAnio);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)nupAnio).EndInit();
            ((System.ComponentModel.ISupportInitialize)nupPrecio).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private ComboBox comboBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private NumericUpDown nupAnio;
        private NumericUpDown nupPrecio;
        private TextBox txtNombre;
        private TextBox txtModelo;
        private Label label5;
        private ListBox listBox1;
        private Button button2;
    }
}
