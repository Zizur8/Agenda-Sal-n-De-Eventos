using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea3_2_ComposicionSencilla
{
    internal class Empresa<Evento> where Evento: new()
    {

		public Empresa()
		{
			_strDireccion = "";
			_strMedioDeContacto = "";
		}
		~Empresa()
		{
			_listEventos.Clear();
		}

		private string _strDireccion;

		public string Direccion
		{
			get { return _strDireccion; }
			set { _strDireccion = value; }
		}
		private string _strMedioDeContacto;

		public string MedioDeContacto
		{
			get { return _strMedioDeContacto; }
			set { _strMedioDeContacto = value; }
		}

		List<Evento> _listEventos = new List<Evento>();

		public void InsertarEvento(Evento newEvento)
		{
			_listEventos.Add(newEvento);
		}

		public void ModificarEvento(Evento newEvento, int intIndex)
		{
			_listEventos[intIndex] = newEvento;
		}
		public void EliminarEvento(int intIndex)
		{
            _listEventos.RemoveAt(intIndex);
        }

		public override string ToString()
		{
			return $"Dirección: {_strDireccion}  Contactanos: {_strMedioDeContacto}";
		}

		public IEnumerator<Evento> GetEnumerator()
		{
			return _listEventos.GetEnumerator();
		}

		public delegate string Operacion();

		public string CalcularMensaje(Operacion miOperacion)
		{
			return miOperacion();
		}




    }
}
