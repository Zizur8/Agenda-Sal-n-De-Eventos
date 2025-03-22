namespace Tarea3_2_ComposicionSencilla
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
            grpDatosDeEmpresa = new GroupBox();
            btnGuardarEmpresa = new Button();
            cboMedioDeContactoDeEmpresa = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            txtDireccionDeEmpresa = new TextBox();
            grpDatosDelEvento = new GroupBox();
            grpAnticipos = new GroupBox();
            txtCantidadDelAnticipo = new TextBox();
            btnAgregarAnticipo = new Button();
            label11 = new Label();
            lstAnticipos = new ListBox();
            btnGuardarEvento = new Button();
            grpDatosDelCliente = new GroupBox();
            txtTelefonoDelCliente = new TextBox();
            txtDireccionDelCliente = new TextBox();
            txtNombreDelCliente = new TextBox();
            label10 = new Label();
            cboTipoDeCliente = new ComboBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            txtCostoDelEvento = new TextBox();
            label4 = new Label();
            txtCantidadDeInvitados = new TextBox();
            dtmFechaDelEvento = new DateTimePicker();
            label5 = new Label();
            chkUsoDeAlberca = new CheckBox();
            label6 = new Label();
            btnEliminarParte = new Button();
            dtgEventos = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column10 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            btnModificarEvento = new Button();
            label12 = new Label();
            grpDatosDeEmpresa.SuspendLayout();
            grpDatosDelEvento.SuspendLayout();
            grpAnticipos.SuspendLayout();
            grpDatosDelCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgEventos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bell MT", 25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 16);
            label1.Name = "label1";
            label1.Size = new Size(302, 39);
            label1.TabIndex = 0;
            label1.Text = "Salón Puerta grande";
            // 
            // grpDatosDeEmpresa
            // 
            grpDatosDeEmpresa.Controls.Add(btnGuardarEmpresa);
            grpDatosDeEmpresa.Controls.Add(cboMedioDeContactoDeEmpresa);
            grpDatosDeEmpresa.Controls.Add(label3);
            grpDatosDeEmpresa.Controls.Add(label2);
            grpDatosDeEmpresa.Controls.Add(txtDireccionDeEmpresa);
            grpDatosDeEmpresa.Location = new Point(12, 63);
            grpDatosDeEmpresa.Name = "grpDatosDeEmpresa";
            grpDatosDeEmpresa.Size = new Size(344, 143);
            grpDatosDeEmpresa.TabIndex = 1;
            grpDatosDeEmpresa.TabStop = false;
            grpDatosDeEmpresa.Text = "Datos de la empresa";
            // 
            // btnGuardarEmpresa
            // 
            btnGuardarEmpresa.Location = new Point(245, 109);
            btnGuardarEmpresa.Name = "btnGuardarEmpresa";
            btnGuardarEmpresa.Size = new Size(75, 23);
            btnGuardarEmpresa.TabIndex = 2;
            btnGuardarEmpresa.Text = "Guardar";
            btnGuardarEmpresa.UseVisualStyleBackColor = true;
            btnGuardarEmpresa.Click += btnGuardarEmpresa_Click;
            // 
            // cboMedioDeContactoDeEmpresa
            // 
            cboMedioDeContactoDeEmpresa.FormattingEnabled = true;
            cboMedioDeContactoDeEmpresa.ImeMode = ImeMode.NoControl;
            cboMedioDeContactoDeEmpresa.Items.AddRange(new object[] { "867 205 4448", "867 125 3697", "infosalonchispitas@gmail.com" });
            cboMedioDeContactoDeEmpresa.Location = new Point(137, 73);
            cboMedioDeContactoDeEmpresa.Name = "cboMedioDeContactoDeEmpresa";
            cboMedioDeContactoDeEmpresa.Size = new Size(140, 23);
            cboMedioDeContactoDeEmpresa.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 76);
            label3.Name = "label3";
            label3.Size = new Size(113, 15);
            label3.TabIndex = 2;
            label3.Text = "Medio De Contacto:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 38);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 1;
            label2.Text = "Dirección:";
            // 
            // txtDireccionDeEmpresa
            // 
            txtDireccionDeEmpresa.Location = new Point(84, 35);
            txtDireccionDeEmpresa.Name = "txtDireccionDeEmpresa";
            txtDireccionDeEmpresa.Size = new Size(193, 23);
            txtDireccionDeEmpresa.TabIndex = 0;
            // 
            // grpDatosDelEvento
            // 
            grpDatosDelEvento.Controls.Add(grpAnticipos);
            grpDatosDelEvento.Controls.Add(btnGuardarEvento);
            grpDatosDelEvento.Controls.Add(grpDatosDelCliente);
            grpDatosDelEvento.Controls.Add(txtCostoDelEvento);
            grpDatosDelEvento.Controls.Add(label4);
            grpDatosDelEvento.Controls.Add(txtCantidadDeInvitados);
            grpDatosDelEvento.Controls.Add(dtmFechaDelEvento);
            grpDatosDelEvento.Controls.Add(label5);
            grpDatosDelEvento.Controls.Add(chkUsoDeAlberca);
            grpDatosDelEvento.Controls.Add(label6);
            grpDatosDelEvento.Location = new Point(12, 212);
            grpDatosDelEvento.Name = "grpDatosDelEvento";
            grpDatosDelEvento.Size = new Size(344, 508);
            grpDatosDelEvento.TabIndex = 2;
            grpDatosDelEvento.TabStop = false;
            grpDatosDelEvento.Text = "Datos del evento";
            // 
            // grpAnticipos
            // 
            grpAnticipos.Controls.Add(txtCantidadDelAnticipo);
            grpAnticipos.Controls.Add(btnAgregarAnticipo);
            grpAnticipos.Controls.Add(label11);
            grpAnticipos.Controls.Add(lstAnticipos);
            grpAnticipos.Location = new Point(18, 164);
            grpAnticipos.Name = "grpAnticipos";
            grpAnticipos.Size = new Size(302, 90);
            grpAnticipos.TabIndex = 17;
            grpAnticipos.TabStop = false;
            grpAnticipos.Text = "Anticipos";
            // 
            // txtCantidadDelAnticipo
            // 
            txtCantidadDelAnticipo.Location = new Point(88, 27);
            txtCantidadDelAnticipo.Name = "txtCantidadDelAnticipo";
            txtCantidadDelAnticipo.Size = new Size(59, 23);
            txtCantidadDelAnticipo.TabIndex = 13;
            // 
            // btnAgregarAnticipo
            // 
            btnAgregarAnticipo.Location = new Point(153, 27);
            btnAgregarAnticipo.Name = "btnAgregarAnticipo";
            btnAgregarAnticipo.Size = new Size(62, 23);
            btnAgregarAnticipo.TabIndex = 16;
            btnAgregarAnticipo.Text = "Agregar";
            btnAgregarAnticipo.UseVisualStyleBackColor = true;
            btnAgregarAnticipo.Click += btnAgregarAnticipo_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(21, 30);
            label11.Name = "label11";
            label11.Size = new Size(67, 15);
            label11.TabIndex = 15;
            label11.Text = "Cantidad: $";
            // 
            // lstAnticipos
            // 
            lstAnticipos.FormattingEnabled = true;
            lstAnticipos.ItemHeight = 15;
            lstAnticipos.Location = new Point(222, 27);
            lstAnticipos.Name = "lstAnticipos";
            lstAnticipos.Size = new Size(71, 49);
            lstAnticipos.TabIndex = 12;
            // 
            // btnGuardarEvento
            // 
            btnGuardarEvento.Location = new Point(249, 470);
            btnGuardarEvento.Name = "btnGuardarEvento";
            btnGuardarEvento.Size = new Size(75, 23);
            btnGuardarEvento.TabIndex = 11;
            btnGuardarEvento.Text = "Guardar";
            btnGuardarEvento.UseVisualStyleBackColor = true;
            btnGuardarEvento.Click += btnGuardarEvento_Click;
            // 
            // grpDatosDelCliente
            // 
            grpDatosDelCliente.Controls.Add(txtTelefonoDelCliente);
            grpDatosDelCliente.Controls.Add(txtDireccionDelCliente);
            grpDatosDelCliente.Controls.Add(txtNombreDelCliente);
            grpDatosDelCliente.Controls.Add(label10);
            grpDatosDelCliente.Controls.Add(cboTipoDeCliente);
            grpDatosDelCliente.Controls.Add(label9);
            grpDatosDelCliente.Controls.Add(label8);
            grpDatosDelCliente.Controls.Add(label7);
            grpDatosDelCliente.Location = new Point(18, 260);
            grpDatosDelCliente.Name = "grpDatosDelCliente";
            grpDatosDelCliente.Size = new Size(302, 199);
            grpDatosDelCliente.TabIndex = 8;
            grpDatosDelCliente.TabStop = false;
            grpDatosDelCliente.Text = "Datos del cliente";
            // 
            // txtTelefonoDelCliente
            // 
            txtTelefonoDelCliente.Location = new Point(87, 144);
            txtTelefonoDelCliente.Name = "txtTelefonoDelCliente";
            txtTelefonoDelCliente.Size = new Size(187, 23);
            txtTelefonoDelCliente.TabIndex = 10;
            // 
            // txtDireccionDelCliente
            // 
            txtDireccionDelCliente.Location = new Point(87, 106);
            txtDireccionDelCliente.Name = "txtDireccionDelCliente";
            txtDireccionDelCliente.Size = new Size(187, 23);
            txtDireccionDelCliente.TabIndex = 9;
            // 
            // txtNombreDelCliente
            // 
            txtNombreDelCliente.Location = new Point(83, 32);
            txtNombreDelCliente.Name = "txtNombreDelCliente";
            txtNombreDelCliente.Size = new Size(191, 23);
            txtNombreDelCliente.TabIndex = 7;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(21, 146);
            label10.Name = "label10";
            label10.Size = new Size(55, 15);
            label10.TabIndex = 3;
            label10.Text = "Telefono:";
            // 
            // cboTipoDeCliente
            // 
            cboTipoDeCliente.FormattingEnabled = true;
            cboTipoDeCliente.Items.AddRange(new object[] { "N", "R", "P" });
            cboTipoDeCliente.Location = new Point(118, 66);
            cboTipoDeCliente.Name = "cboTipoDeCliente";
            cboTipoDeCliente.Size = new Size(57, 23);
            cboTipoDeCliente.TabIndex = 8;
            cboTipoDeCliente.Tag = "";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(21, 108);
            label9.Name = "label9";
            label9.Size = new Size(60, 15);
            label9.TabIndex = 2;
            label9.Text = "Dirección:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(21, 69);
            label8.Name = "label8";
            label8.Size = new Size(87, 15);
            label8.TabIndex = 1;
            label8.Text = "Tipo de cliente:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(21, 34);
            label7.Name = "label7";
            label7.Size = new Size(54, 15);
            label7.TabIndex = 0;
            label7.Text = "Nombre:";
            // 
            // txtCostoDelEvento
            // 
            txtCostoDelEvento.Location = new Point(76, 135);
            txtCostoDelEvento.Name = "txtCostoDelEvento";
            txtCostoDelEvento.Size = new Size(124, 23);
            txtCostoDelEvento.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 35);
            label4.Name = "label4";
            label4.Size = new Size(125, 15);
            label4.TabIndex = 0;
            label4.Text = "Cantidad de invitados:";
            // 
            // txtCantidadDeInvitados
            // 
            txtCantidadDeInvitados.Location = new Point(153, 32);
            txtCantidadDeInvitados.Name = "txtCantidadDeInvitados";
            txtCantidadDeInvitados.Size = new Size(124, 23);
            txtCantidadDeInvitados.TabIndex = 3;
            // 
            // dtmFechaDelEvento
            // 
            dtmFechaDelEvento.CustomFormat = "";
            dtmFechaDelEvento.Location = new Point(124, 97);
            dtmFechaDelEvento.Name = "dtmFechaDelEvento";
            dtmFechaDelEvento.Size = new Size(153, 23);
            dtmFechaDelEvento.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(18, 100);
            label5.Name = "label5";
            label5.Size = new Size(99, 15);
            label5.TabIndex = 4;
            label5.Text = "Fecha del evento:";
            // 
            // chkUsoDeAlberca
            // 
            chkUsoDeAlberca.AutoSize = true;
            chkUsoDeAlberca.Location = new Point(18, 66);
            chkUsoDeAlberca.Name = "chkUsoDeAlberca";
            chkUsoDeAlberca.RightToLeft = RightToLeft.Yes;
            chkUsoDeAlberca.Size = new Size(103, 19);
            chkUsoDeAlberca.TabIndex = 4;
            chkUsoDeAlberca.Text = "Uso de alberca";
            chkUsoDeAlberca.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(18, 138);
            label6.Name = "label6";
            label6.Size = new Size(50, 15);
            label6.TabIndex = 6;
            label6.Text = "Costo: $";
            // 
            // btnEliminarParte
            // 
            btnEliminarParte.Location = new Point(378, 648);
            btnEliminarParte.Name = "btnEliminarParte";
            btnEliminarParte.Size = new Size(75, 41);
            btnEliminarParte.TabIndex = 18;
            btnEliminarParte.Text = "Eliminar Evento";
            btnEliminarParte.UseVisualStyleBackColor = true;
            btnEliminarParte.Click += btnEliminarParte_Click;
            // 
            // dtgEventos
            // 
            dtgEventos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgEventos.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column10, Column6, Column7, Column8, Column9 });
            dtgEventos.Location = new Point(378, 72);
            dtgEventos.MultiSelect = false;
            dtgEventos.Name = "dtgEventos";
            dtgEventos.ReadOnly = true;
            dtgEventos.RowTemplate.Height = 25;
            dtgEventos.Size = new Size(833, 561);
            dtgEventos.TabIndex = 3;
            dtgEventos.CellClick += dtgEventos_CellClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "Invitados";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.HeaderText = "Alberca";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.HeaderText = "Fecha";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.HeaderText = "Costo";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Column5
            // 
            Column5.HeaderText = "Monto de anticipos";
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            // 
            // Column10
            // 
            Column10.HeaderText = "Pago faltante";
            Column10.Name = "Column10";
            Column10.ReadOnly = true;
            // 
            // Column6
            // 
            Column6.HeaderText = "Cliente";
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            // 
            // Column7
            // 
            Column7.HeaderText = "Tipo de cliente";
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            // 
            // Column8
            // 
            Column8.HeaderText = "C.Dirección";
            Column8.Name = "Column8";
            Column8.ReadOnly = true;
            // 
            // Column9
            // 
            Column9.HeaderText = "C.Telefono";
            Column9.Name = "Column9";
            Column9.ReadOnly = true;
            // 
            // btnModificarEvento
            // 
            btnModificarEvento.Location = new Point(472, 648);
            btnModificarEvento.Name = "btnModificarEvento";
            btnModificarEvento.Size = new Size(75, 41);
            btnModificarEvento.TabIndex = 19;
            btnModificarEvento.Text = "Modificar Evento";
            btnModificarEvento.UseVisualStyleBackColor = true;
            btnModificarEvento.Click += btnModificarEvento_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(788, 16);
            label12.Name = "label12";
            label12.Size = new Size(109, 37);
            label12.TabIndex = 20;
            label12.Text = "Eventos";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1221, 732);
            Controls.Add(label12);
            Controls.Add(btnModificarEvento);
            Controls.Add(btnEliminarParte);
            Controls.Add(dtgEventos);
            Controls.Add(grpDatosDelEvento);
            Controls.Add(grpDatosDeEmpresa);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Administrador de eventos";
            grpDatosDeEmpresa.ResumeLayout(false);
            grpDatosDeEmpresa.PerformLayout();
            grpDatosDelEvento.ResumeLayout(false);
            grpDatosDelEvento.PerformLayout();
            grpAnticipos.ResumeLayout(false);
            grpAnticipos.PerformLayout();
            grpDatosDelCliente.ResumeLayout(false);
            grpDatosDelCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgEventos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox grpDatosDeEmpresa;
        private Label label2;
        private TextBox txtDireccionDeEmpresa;
        private Label label3;
        private ComboBox cboMedioDeContactoDeEmpresa;
        private GroupBox grpDatosDelEvento;
        private Label label4;
        private CheckBox chkUsoDeAlberca;
        private DateTimePicker dtmFechaDelEvento;
        private TextBox txtCostoDelEvento;
        private Label label6;
        private TextBox txtCantidadDeInvitados;
        private Label label5;
        private GroupBox grpDatosDelCliente;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private TextBox txtTelefonoDelCliente;
        private TextBox txtDireccionDelCliente;
        private ComboBox cboTipoDeCliente;
        private TextBox txtNombreDelCliente;
        private Button btnGuardarEmpresa;
        private Button btnGuardarEvento;
        private TextBox txtCantidadDelAnticipo;
        private ListBox lstAnticipos;
        private Button btnAgregarAnticipo;
        private Label label11;
        private GroupBox grpAnticipos;
        private DataGridView dtgEventos;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column10;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private Button btnEliminarParte;
        private Button btnModificarEvento;
        private Label label12;
    }
}