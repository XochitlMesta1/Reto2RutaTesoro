namespace Reto2RutaTesoro
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
            dgvMap = new DataGridView();
            lblTotal = new Label();
            lblid = new Label();
            lblPista = new Label();
            lblUbi = new Label();
            lblPeligro = new Label();
            btnAgregar = new Button();
            btnModificar = new Button();
            lblLimpiar = new Button();
            btnEliminar = new Button();
            btnBuscar = new Button();
            txtBuscar = new TextBox();
            colorDialog1 = new ColorDialog();
            txtName = new TextBox();
            txtHint = new TextBox();
            numDanger = new NumericUpDown();
            numid = new NumericUpDown();
            lblResult = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvMap).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numDanger).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numid).BeginInit();
            SuspendLayout();
            // 
            // dgvMap
            // 
            dgvMap.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMap.Location = new Point(342, 117);
            dgvMap.Name = "dgvMap";
            dgvMap.RowHeadersWidth = 62;
            dgvMap.Size = new Size(493, 304);
            dgvMap.TabIndex = 0;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(420, 435);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(53, 25);
            lblTotal.TabIndex = 1;
            lblTotal.Text = "Total:";
            // 
            // lblid
            // 
            lblid.AutoSize = true;
            lblid.Location = new Point(41, 160);
            lblid.Name = "lblid";
            lblid.Size = new Size(30, 25);
            lblid.TabIndex = 2;
            lblid.Text = "ID";
            // 
            // lblPista
            // 
            lblPista.AutoSize = true;
            lblPista.Location = new Point(41, 237);
            lblPista.Name = "lblPista";
            lblPista.Size = new Size(49, 25);
            lblPista.TabIndex = 3;
            lblPista.Text = "Pista";
            // 
            // lblUbi
            // 
            lblUbi.AutoSize = true;
            lblUbi.Location = new Point(41, 201);
            lblUbi.Name = "lblUbi";
            lblUbi.Size = new Size(94, 25);
            lblUbi.TabIndex = 4;
            lblUbi.Text = "Ubicacion ";
            // 
            // lblPeligro
            // 
            lblPeligro.AutoSize = true;
            lblPeligro.Location = new Point(41, 272);
            lblPeligro.Name = "lblPeligro";
            lblPeligro.Size = new Size(71, 25);
            lblPeligro.TabIndex = 5;
            lblPeligro.Text = "Peligro ";
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(41, 336);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(112, 34);
            btnAgregar.TabIndex = 6;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(178, 336);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(112, 34);
            btnModificar.TabIndex = 7;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            // 
            // lblLimpiar
            // 
            lblLimpiar.Location = new Point(41, 376);
            lblLimpiar.Name = "lblLimpiar";
            lblLimpiar.Size = new Size(112, 34);
            lblLimpiar.TabIndex = 8;
            lblLimpiar.Text = "Limpiar";
            lblLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(178, 376);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(112, 34);
            btnEliminar.TabIndex = 9;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(388, 24);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(112, 34);
            btnBuscar.TabIndex = 10;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(72, 27);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(310, 31);
            txtBuscar.TabIndex = 11;
            // 
            // txtName
            // 
            txtName.Location = new Point(141, 201);
            txtName.Name = "txtName";
            txtName.Size = new Size(155, 31);
            txtName.TabIndex = 12;
            // 
            // txtHint
            // 
            txtHint.Location = new Point(141, 238);
            txtHint.Name = "txtHint";
            txtHint.Size = new Size(155, 31);
            txtHint.TabIndex = 13;
            // 
            // numDanger
            // 
            numDanger.Location = new Point(141, 275);
            numDanger.Name = "numDanger";
            numDanger.Size = new Size(155, 31);
            numDanger.TabIndex = 14;
            // 
            // numid
            // 
            numid.Location = new Point(141, 164);
            numid.Name = "numid";
            numid.Size = new Size(155, 31);
            numid.TabIndex = 15;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(105, 93);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(90, 25);
            lblResult.TabIndex = 16;
            lblResult.Text = "Resultado";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(903, 531);
            Controls.Add(lblResult);
            Controls.Add(numid);
            Controls.Add(numDanger);
            Controls.Add(txtHint);
            Controls.Add(txtName);
            Controls.Add(txtBuscar);
            Controls.Add(btnBuscar);
            Controls.Add(btnEliminar);
            Controls.Add(lblLimpiar);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregar);
            Controls.Add(lblPeligro);
            Controls.Add(lblUbi);
            Controls.Add(lblPista);
            Controls.Add(lblid);
            Controls.Add(lblTotal);
            Controls.Add(dgvMap);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvMap).EndInit();
            ((System.ComponentModel.ISupportInitialize)numDanger).EndInit();
            ((System.ComponentModel.ISupportInitialize)numid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvMap;
        private Label lblTotal;
        private Label lblid;
        private Label lblPista;
        private Label lblUbi;
        private Label lblPeligro;
        private Button btnAgregar;
        private Button btnModificar;
        private Button lblLimpiar;
        private Button btnEliminar;
        private Button btnBuscar;
        private TextBox txtBuscar;
        private ColorDialog colorDialog1;
        private TextBox txtName;
        private TextBox txtHint;
        private NumericUpDown numDanger;
        private NumericUpDown numid;
        private Label lblResult;
    }
}
