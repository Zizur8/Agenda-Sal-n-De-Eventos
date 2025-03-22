namespace Tarea3_2_ComposicionSencilla
{
    public partial class Form1 : Form
    {
        Empresa<Evento> newEmpresa = new Empresa<Evento>();
        //delegate string Delegado(string strMensaje1, string strMensaje2);
        //Delegado miDelegado = (strMensaje1, strMensaje2) => strMensaje1;

        //System.Func<string, string, string> MostrarMensaje = (mensaje1, mensaje2) => mensaje1 + mensaje2;

        bool blnModificarEvento = false;
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            dtmFechaDelEvento.Format = DateTimePickerFormat.Short;
            dtgEventos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
 
            MessageBox.Show($"Mensaje: {newEmpresa.CalcularMensaje(() => "Hola" + "Mundo")}");

        }

        private void btnGuardarEmpresa_Click(object sender, EventArgs e)
        {
            newEmpresa.Direccion = txtDireccionDeEmpresa.Text;
            newEmpresa.MedioDeContacto = cboMedioDeContactoDeEmpresa.Text;
            MessageBox.Show("Datos capturados\n" + newEmpresa.ToString());
        }

        private void btnGuardarEvento_Click(object sender, EventArgs e)
        {
            bool blnErrorEnProceso = false;
            Evento newEvento = new Evento();

            try
            {
                newEvento.CantidadDeInvitados = int.Parse(txtCantidadDeInvitados.Text);
                newEvento.CostoDelEvento = double.Parse(txtCostoDelEvento.Text);
            }
            catch
            {
                blnErrorEnProceso = true;
                MessageBox.Show("Campo numerico invalido", "Captura invalida",MessageBoxButtons.OK,MessageBoxIcon.Exclamation,MessageBoxDefaultButton.Button1,MessageBoxOptions.DefaultDesktopOnly);
            }
            try
            {
                newEvento.TipoDeCliente = char.Parse(cboTipoDeCliente.Text);
            }
            catch
            {
                blnErrorEnProceso = true;
                throw new Exception("Se requiere escoger el Tipo de cliente");
                //MessageBox.Show("Invalido el campo \'Tipo de cliente\'", "Captura invalida", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            }

            newEvento.UsoDeAlberca = chkUsoDeAlberca.Checked;
            newEvento.FechaDelEvento = dtmFechaDelEvento.Value;
            
            foreach (object item in lstAnticipos.Items)
            {
                if (double.TryParse(item.ToString(), out double valor))
                {
                    newEvento.Anticipos.Add(valor);
                }
            }

            newEvento.NombreDelCliente = txtNombreDelCliente.Text;
            
            newEvento.DireccionDelCliente = txtDireccionDelCliente.Text;
            newEvento.TelefonoDelCliente = txtTelefonoDelCliente.Text;



            if(blnErrorEnProceso == false)
            {
                if (blnModificarEvento == true)
                {
                    ModificarEvento(newEvento);
                    blnModificarEvento = false;
                }
                else
                {
                    newEmpresa.InsertarEvento(newEvento);
                    MessageBox.Show("Evento Nuevo agregado\n" + newEvento.ToString());
                }

                LimpiarFormulario();
                ActualizarDataGridView();
            }
        }

        private void ActualizarDataGridView()
        {

            int intRow = 0;
            dtgEventos.Rows.Clear();


            foreach (Evento i in newEmpresa)
            {
                intRow = (dtgEventos.Rows.Count - 1 > 0) ? dtgEventos.Rows.Count - 1 : 0;
                dtgEventos.Rows.Add(1);

                dtgEventos.Rows[intRow].Cells[0].Value = i.CantidadDeInvitados;
                dtgEventos.Rows[intRow].Cells[1].Value = (i.UsoDeAlberca) ? "Si" : "No";
                dtgEventos.Rows[intRow].Cells[2].Value = i.FechaDelEvento.ToShortDateString();
                dtgEventos.Rows[intRow].Cells[3].Value = i.CostoDelEvento.ToString("C");
                dtgEventos.Rows[intRow].Cells[4].Value = i.CalcularMontoDeAnticipos().ToString("C");
                dtgEventos.Rows[intRow].Cells[5].Value = (i.CalcularPagoFaltante() <= 0) ? "Pago completo" : i.CalcularPagoFaltante().ToString("C");
                dtgEventos.Rows[intRow].Cells[6].Value = i.NombreDelCliente;
                dtgEventos.Rows[intRow].Cells[7].Value = i.TipoDeCliente;
                dtgEventos.Rows[intRow].Cells[8].Value = i.DireccionDelCliente;
                dtgEventos.Rows[intRow].Cells[9].Value = i.TelefonoDelCliente;

                if (i.CalcularPagoFaltante() <= 0)
                {
                    dtgEventos.Rows[intRow].DefaultCellStyle.BackColor = Color.LightGreen;
                }
                else
                {
                    dtgEventos.Rows[intRow].DefaultCellStyle.BackColor = Color.Yellow;
                }
                btnEliminarParte.Enabled = true;
            }

        }

        private void btnAgregarAnticipo_Click(object sender, EventArgs e)
        {
            lstAnticipos.Items.Add(txtCantidadDelAnticipo.Text);
            MessageBox.Show($"Nuevo anticipo Agregado\nCon un valor de: ${txtCantidadDelAnticipo.Text}");
            txtCantidadDelAnticipo.Text = "";
        }

        private void dtgEventos_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEliminarParte_Click(object sender, EventArgs e)
        {
            DialogResult Respuesta;
            Respuesta = MessageBox.Show("¿Estás seguro?", "El evento será eliminado", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (Respuesta == DialogResult.Yes)
            {
                newEmpresa.EliminarEvento(dtgEventos.SelectedRows[0].Index);
                ActualizarDataGridView();
                MessageBox.Show("Evento eliminado");
            }
            else
            {
                MessageBox.Show("Eliminación Cancelada");
            }

        }

        private void btnModificarEvento_Click(object sender, EventArgs e)
        {
            btnEliminarParte.Enabled = false;
            blnModificarEvento = true;
            Evento miEvento = new Evento();
            int intContador = 0;

            foreach (Evento i in newEmpresa)
            {
                if (intContador == dtgEventos.SelectedRows[0].Index)
                {
                    miEvento = i;
                }
                intContador++;
            }

            txtCantidadDeInvitados.Text = miEvento.CantidadDeInvitados.ToString();
            chkUsoDeAlberca.Checked = miEvento.UsoDeAlberca;
            dtmFechaDelEvento.Value = miEvento.FechaDelEvento;
            txtCostoDelEvento.Text = miEvento.CostoDelEvento.ToString();
            foreach (double dblAnticipo in miEvento.Anticipos)
            {
                lstAnticipos.Items.Add(dblAnticipo.ToString());
            }
            txtNombreDelCliente.Text = miEvento.NombreDelCliente;
            cboTipoDeCliente.Text = miEvento.TipoDeCliente.ToString();
            txtDireccionDelCliente.Text = miEvento.DireccionDelCliente;
            txtTelefonoDelCliente.Text = miEvento.TelefonoDelCliente;
        }

        private void LimpiarFormulario()
        {
            foreach (Control item in grpDatosDeEmpresa.Controls)
            {
                if (item is TextBox || item is ComboBox)
                {
                    item.ResetText();
                }
            }
            foreach (Control item in grpDatosDelEvento.Controls)
            {
                if (item is TextBox)
                {
                    item.ResetText();
                }

                foreach (Control item2 in grpDatosDelCliente.Controls)
                {
                    if (item2 is TextBox || item2 is ComboBox)
                    {
                        item2.ResetText();
                    }
                }


            }
            lstAnticipos.Items.Clear();
            chkUsoDeAlberca.Checked = false;
        }
        private void ModificarEvento(Evento newEvento)
        {
            DialogResult Respuesta;
            Respuesta = MessageBox.Show("¿Estás seguro?", "Se guardará la modificación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (Respuesta == DialogResult.Yes)
            {
                newEmpresa.ModificarEvento(newEvento, dtgEventos.SelectedRows[0].Index);

                MessageBox.Show("Modificación Realizada");

            }
            else
            {
                MessageBox.Show("Modificación Cancelada");

            }
        }
    }
}