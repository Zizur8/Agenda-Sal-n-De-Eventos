using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.ComponentModel.Com2Interop;

namespace Tarea3_2_ComposicionSencilla
{
    internal class Evento
    {
        public Evento()
        {
            _intCantidadDeInvitados = 0;
            _strNombreDelCliente = "";
            _chrTipoDeCliente = ' ';
            _blnUsoDeAlberca = true;
			_dtmFechaDelEvento = DateTime.Now;
			_listAnticipos = new List<double>();
            _strDireccionDelCliente = "";
            _intTelefonoDelCliente = "";
            _dblCostoDelEvento = 0;
        }
        private int _intCantidadDeInvitados;

		public int CantidadDeInvitados
		{
			get { return _intCantidadDeInvitados; }
			set { _intCantidadDeInvitados = value; }
		}

		private string _strNombreDelCliente;

		public string NombreDelCliente
		{
			get { return _strNombreDelCliente; }
			set { _strNombreDelCliente = value; }
		}
		private char _chrTipoDeCliente;

		public char TipoDeCliente
		{
			get { return _chrTipoDeCliente; }
			set { _chrTipoDeCliente = value; }
		}
		private bool _blnUsoDeAlberca;

		public bool UsoDeAlberca
		{
			get { return _blnUsoDeAlberca; }
			set { _blnUsoDeAlberca = value; }
		}
		private DateTime _dtmFechaDelEvento;

		public DateTime FechaDelEvento
		{
			get { return _dtmFechaDelEvento; }
			set { _dtmFechaDelEvento = value; }
		}
		private List<double> _listAnticipos;

		public List<double> Anticipos
		{
			get { return _listAnticipos; }
			set { _listAnticipos = value; }
		}

		private string _strDireccionDelCliente;

		public string DireccionDelCliente
		{
			get { return _strDireccionDelCliente; }
			set { _strDireccionDelCliente = value; }
		}
		private string _intTelefonoDelCliente;

		public string TelefonoDelCliente
		{
			get { return _intTelefonoDelCliente; }
			set { _intTelefonoDelCliente = value; }
		}
		private double _dblCostoDelEvento;

		public double CostoDelEvento
		{
			get { return _dblCostoDelEvento; }
			set { _dblCostoDelEvento = value; }
		}

		public override string ToString()
		{
			return $"Invitados: {_intCantidadDeInvitados}\nCliente: {_strNombreDelCliente}\nTipo de cliente: {_chrTipoDeCliente}\nUso de alberca: {(UsoDeAlberca ? "Si" : "No")}\nFecha del evento: {_dtmFechaDelEvento.ToShortDateString()}\nMonto de los anticipos: ${CalcularMontoDeAnticipos()}\nDirección del cliente: {_strDireccionDelCliente}\nTelefono del cliente: {_intTelefonoDelCliente}\nCosto del evento: ${_dblCostoDelEvento}";
		}

		public double CalcularPagoFaltante()
		{
			double dblPagoFaltante = 0;
			foreach (double dblAnticipo in _listAnticipos) 
			{
				dblPagoFaltante += dblAnticipo;
			}
			return _dblCostoDelEvento - dblPagoFaltante;
		}
        public double CalcularMontoDeAnticipos()
        {
            double dblSumaDeAnticipos = 0;
            foreach (double dblAnticipo in _listAnticipos)
            {
                dblSumaDeAnticipos += dblAnticipo;
            }
            return dblSumaDeAnticipos;
        }
    }
}
