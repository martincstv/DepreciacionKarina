namespace Depreciacion
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBox_Activo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker_Adquisicion = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown_Valor = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker_Depreciacion = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_Limpiar = new System.Windows.Forms.Button();
            this.button_Calcular = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView_Datos = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_ValorResidual = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Valor)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Datos)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox_Activo
            // 
            this.comboBox_Activo.FormattingEnabled = true;
            this.comboBox_Activo.Location = new System.Drawing.Point(33, 202);
            this.comboBox_Activo.Name = "comboBox_Activo";
            this.comboBox_Activo.Size = new System.Drawing.Size(200, 24);
            this.comboBox_Activo.TabIndex = 0;
            this.comboBox_Activo.SelectedIndexChanged += new System.EventHandler(this.comboBox_Activo_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Activo";
            // 
            // dateTimePicker_Adquisicion
            // 
            this.dateTimePicker_Adquisicion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_Adquisicion.Location = new System.Drawing.Point(33, 59);
            this.dateTimePicker_Adquisicion.Name = "dateTimePicker_Adquisicion";
            this.dateTimePicker_Adquisicion.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker_Adquisicion.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "F. Adquisicion";
            // 
            // numericUpDown_Valor
            // 
            this.numericUpDown_Valor.Location = new System.Drawing.Point(33, 103);
            this.numericUpDown_Valor.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDown_Valor.Name = "numericUpDown_Valor";
            this.numericUpDown_Valor.Size = new System.Drawing.Size(200, 22);
            this.numericUpDown_Valor.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Valor de adquisicion";
            // 
            // dateTimePicker_Depreciacion
            // 
            this.dateTimePicker_Depreciacion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_Depreciacion.Location = new System.Drawing.Point(33, 147);
            this.dateTimePicker_Depreciacion.Name = "dateTimePicker_Depreciacion";
            this.dateTimePicker_Depreciacion.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker_Depreciacion.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Limite Depreciacion";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_Limpiar);
            this.groupBox1.Controls.Add(this.button_Calcular);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBox_Activo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dateTimePicker_Adquisicion);
            this.groupBox1.Controls.Add(this.dateTimePicker_Depreciacion);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.numericUpDown_Valor);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(306, 502);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // button_Limpiar
            // 
            this.button_Limpiar.Location = new System.Drawing.Point(33, 266);
            this.button_Limpiar.Name = "button_Limpiar";
            this.button_Limpiar.Size = new System.Drawing.Size(75, 23);
            this.button_Limpiar.TabIndex = 10;
            this.button_Limpiar.Text = "Limpiar";
            this.button_Limpiar.UseVisualStyleBackColor = true;
            this.button_Limpiar.Click += new System.EventHandler(this.button_Limpiar_Click);
            // 
            // button_Calcular
            // 
            this.button_Calcular.Location = new System.Drawing.Point(158, 266);
            this.button_Calcular.Name = "button_Calcular";
            this.button_Calcular.Size = new System.Drawing.Size(75, 23);
            this.button_Calcular.TabIndex = 10;
            this.button_Calcular.Text = "Calcular";
            this.button_Calcular.UseVisualStyleBackColor = true;
            this.button_Calcular.Click += new System.EventHandler(this.button_Calcular_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox_ValorResidual);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.dataGridView_Datos);
            this.groupBox2.Location = new System.Drawing.Point(324, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(738, 492);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // dataGridView_Datos
            // 
            this.dataGridView_Datos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Datos.Location = new System.Drawing.Point(6, 21);
            this.dataGridView_Datos.Name = "dataGridView_Datos";
            this.dataGridView_Datos.RowHeadersWidth = 51;
            this.dataGridView_Datos.RowTemplate.Height = 24;
            this.dataGridView_Datos.Size = new System.Drawing.Size(726, 428);
            this.dataGridView_Datos.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(430, 458);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Valor Residual";
            // 
            // textBox_ValorResidual
            // 
            this.textBox_ValorResidual.Location = new System.Drawing.Point(532, 455);
            this.textBox_ValorResidual.Name = "textBox_ValorResidual";
            this.textBox_ValorResidual.ReadOnly = true;
            this.textBox_ValorResidual.Size = new System.Drawing.Size(200, 22);
            this.textBox_ValorResidual.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 526);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "System";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Valor)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Datos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_Activo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Adquisicion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown_Valor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Depreciacion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView_Datos;
        private System.Windows.Forms.Button button_Limpiar;
        private System.Windows.Forms.Button button_Calcular;
        private System.Windows.Forms.TextBox textBox_ValorResidual;
        private System.Windows.Forms.Label label5;
    }
}

