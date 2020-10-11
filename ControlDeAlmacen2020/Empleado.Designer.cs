namespace ControlDeAlmacen2020
{
    partial class Empleado
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Empleado));
            this.txtBuscarE = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtClaveE = new System.Windows.Forms.TextBox();
            this.btnGuardarCE = new System.Windows.Forms.Button();
            this.dgvEmpleados = new System.Windows.Forms.DataGridView();
            this.txtNombreE = new System.Windows.Forms.TextBox();
            this.cbAreaE = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtApE = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtAmE = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.btnActualizarE = new System.Windows.Forms.Button();
            this.btnEliminarE = new System.Windows.Forms.Button();
            this.btnCancelarE = new System.Windows.Forms.Button();
            this.btnAgreagrE = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBuscarE
            // 
            this.txtBuscarE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBuscarE.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBuscarE.Location = new System.Drawing.Point(994, 28);
            this.txtBuscarE.Multiline = true;
            this.txtBuscarE.Name = "txtBuscarE";
            this.txtBuscarE.Size = new System.Drawing.Size(172, 22);
            this.txtBuscarE.TabIndex = 46;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(909, 25);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 25);
            this.label11.TabIndex = 45;
            this.label11.Text = "Buscar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(54, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 31);
            this.label3.TabIndex = 44;
            this.label3.Text = "EMPLEADOS";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(57, 232);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(290, 17);
            this.label21.TabIndex = 43;
            this.label21.Text = "Los campos marcados con * son obligatorios";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(56, 104);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(63, 20);
            this.label14.TabIndex = 42;
            this.label14.Text = "Clave*";
            // 
            // txtClaveE
            // 
            this.txtClaveE.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtClaveE.Location = new System.Drawing.Point(60, 127);
            this.txtClaveE.Name = "txtClaveE";
            this.txtClaveE.Size = new System.Drawing.Size(136, 22);
            this.txtClaveE.TabIndex = 30;
            // 
            // btnGuardarCE
            // 
            this.btnGuardarCE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardarCE.Location = new System.Drawing.Point(994, 431);
            this.btnGuardarCE.Name = "btnGuardarCE";
            this.btnGuardarCE.Size = new System.Drawing.Size(144, 23);
            this.btnGuardarCE.TabIndex = 41;
            this.btnGuardarCE.Text = "Guardar Cambios";
            this.btnGuardarCE.UseVisualStyleBackColor = true;
            // 
            // dgvEmpleados
            // 
            this.dgvEmpleados.AllowUserToAddRows = false;
            this.dgvEmpleados.AllowUserToDeleteRows = false;
            this.dgvEmpleados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleados.Location = new System.Drawing.Point(60, 267);
            this.dgvEmpleados.Name = "dgvEmpleados";
            this.dgvEmpleados.ReadOnly = true;
            this.dgvEmpleados.RowHeadersWidth = 51;
            this.dgvEmpleados.RowTemplate.Height = 24;
            this.dgvEmpleados.Size = new System.Drawing.Size(928, 226);
            this.dgvEmpleados.TabIndex = 29;
            // 
            // txtNombreE
            // 
            this.txtNombreE.Location = new System.Drawing.Point(229, 127);
            this.txtNombreE.Name = "txtNombreE";
            this.txtNombreE.Size = new System.Drawing.Size(136, 22);
            this.txtNombreE.TabIndex = 32;
            // 
            // cbAreaE
            // 
            this.cbAreaE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAreaE.FormattingEnabled = true;
            this.cbAreaE.Items.AddRange(new object[] {
            "Infraestructura hidráulica",
            "Presupuesto y Contabilidad",
            "Sistemas",
            "Cultura del Agua",
            "Inspección y Ejecución",
            "Caja"});
            this.cbAreaE.Location = new System.Drawing.Point(60, 186);
            this.cbAreaE.Name = "cbAreaE";
            this.cbAreaE.Size = new System.Drawing.Size(136, 24);
            this.cbAreaE.TabIndex = 36;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(224, 104);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(105, 20);
            this.label18.TabIndex = 27;
            this.label18.Text = "Nombre(s)*";
            // 
            // txtApE
            // 
            this.txtApE.Location = new System.Drawing.Point(408, 127);
            this.txtApE.Name = "txtApE";
            this.txtApE.Size = new System.Drawing.Size(136, 22);
            this.txtApE.TabIndex = 33;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(403, 104);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(106, 20);
            this.label17.TabIndex = 28;
            this.label17.Text = "Apellido P.*";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(56, 163);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(55, 20);
            this.label15.TabIndex = 34;
            this.label15.Text = "Área*";
            // 
            // txtAmE
            // 
            this.txtAmE.Location = new System.Drawing.Point(587, 127);
            this.txtAmE.Name = "txtAmE";
            this.txtAmE.Size = new System.Drawing.Size(136, 22);
            this.txtAmE.TabIndex = 35;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(583, 104);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(109, 20);
            this.label16.TabIndex = 31;
            this.label16.Text = "Apellido M.*";
            // 
            // btnActualizarE
            // 
            this.btnActualizarE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActualizarE.Image = ((System.Drawing.Image)(resources.GetObject("btnActualizarE.Image")));
            this.btnActualizarE.Location = new System.Drawing.Point(1008, 378);
            this.btnActualizarE.Name = "btnActualizarE";
            this.btnActualizarE.Size = new System.Drawing.Size(69, 31);
            this.btnActualizarE.TabIndex = 40;
            this.btnActualizarE.UseVisualStyleBackColor = true;
            // 
            // btnEliminarE
            // 
            this.btnEliminarE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminarE.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminarE.Image")));
            this.btnEliminarE.Location = new System.Drawing.Point(1008, 341);
            this.btnEliminarE.Name = "btnEliminarE";
            this.btnEliminarE.Size = new System.Drawing.Size(69, 31);
            this.btnEliminarE.TabIndex = 39;
            this.btnEliminarE.UseVisualStyleBackColor = true;
            // 
            // btnCancelarE
            // 
            this.btnCancelarE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelarE.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelarE.Image")));
            this.btnCancelarE.Location = new System.Drawing.Point(1008, 304);
            this.btnCancelarE.Name = "btnCancelarE";
            this.btnCancelarE.Size = new System.Drawing.Size(69, 31);
            this.btnCancelarE.TabIndex = 38;
            this.btnCancelarE.UseVisualStyleBackColor = true;
            // 
            // btnAgreagrE
            // 
            this.btnAgreagrE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgreagrE.Image = ((System.Drawing.Image)(resources.GetObject("btnAgreagrE.Image")));
            this.btnAgreagrE.Location = new System.Drawing.Point(1008, 267);
            this.btnAgreagrE.Name = "btnAgreagrE";
            this.btnAgreagrE.Size = new System.Drawing.Size(69, 31);
            this.btnAgreagrE.TabIndex = 37;
            this.btnAgreagrE.UseVisualStyleBackColor = true;
            // 
            // EmpleadoVista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1220, 519);
            this.Controls.Add(this.txtBuscarE);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtClaveE);
            this.Controls.Add(this.btnGuardarCE);
            this.Controls.Add(this.dgvEmpleados);
            this.Controls.Add(this.btnActualizarE);
            this.Controls.Add(this.btnEliminarE);
            this.Controls.Add(this.txtNombreE);
            this.Controls.Add(this.cbAreaE);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.btnCancelarE);
            this.Controls.Add(this.txtApE);
            this.Controls.Add(this.btnAgreagrE);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtAmE);
            this.Controls.Add(this.label16);
            this.Name = "EmpleadoVista";
            this.Text = "EmpleadoVista";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBuscarE;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtClaveE;
        private System.Windows.Forms.Button btnGuardarCE;
        private System.Windows.Forms.DataGridView dgvEmpleados;
        private System.Windows.Forms.Button btnActualizarE;
        private System.Windows.Forms.Button btnEliminarE;
        private System.Windows.Forms.TextBox txtNombreE;
        private System.Windows.Forms.ComboBox cbAreaE;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btnCancelarE;
        private System.Windows.Forms.TextBox txtApE;
        private System.Windows.Forms.Button btnAgreagrE;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtAmE;
        private System.Windows.Forms.Label label16;
    }
}