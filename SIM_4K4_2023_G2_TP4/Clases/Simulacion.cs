﻿using SIM_4K4_2023_G2_TP4.Logic;
using SIM_4K4_2023_G2_TP4.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIM_4K4_2023_G2_TP4.Clases
{
    internal class Simulacion
    {
        //private static int NUMERO_GRANDE = 999999999;
        public DataTable dataTable;
        public Relojero relojero = new Relojero();
        public Ayudante ayudante = new Ayudante();
        public frmPrincipal _frm;
        public int maximo_simulacion = 100000;
        public int _i;
        public int _j;


        public Queue<Cliente> clientes = new Queue<Cliente>();
        public List<dynamic> _iteracion = new List<dynamic>();
        public double prox_fin_uso_instalacion = 0;
        public Cliente prox_cliente_fin_uso_instalacion;
        public int cantidad_iteracciones = 0;
        public bool iteracciones_cumplidas = false;

        public Simulacion(frmPrincipal frm)
        {
            _frm = frm;
            maximo_simulacion = (int.Parse(_frm.txt_tiempo_simular.Text)) <= maximo_simulacion ? int.Parse(_frm.txt_tiempo_simular.Text) : maximo_simulacion;
            _i = int.Parse(_frm.txt_desde_hora.Text);
            _j = int.Parse(_frm.txt_iteracciones.Text);

        }
        // Genera columnas del DataTable
        private void generar_dt()
        {
            dataTable = new DataTable();

            dataTable.Columns.Add("i");
            dataTable.Columns.Add("Evento");
            dataTable.Columns.Add("Reloj");
            dataTable.Columns.Add("RND llegada");
            dataTable.Columns.Add("Tiempo entre llegadas");
            dataTable.Columns.Add("Proxima llegada");
            dataTable.Columns.Add("RND Tipo Accion");
            dataTable.Columns.Add("Accion");
            dataTable.Columns.Add("RND Tiempo atencion");
            dataTable.Columns.Add("Tiempo atencion ayudante");
            dataTable.Columns.Add("Fin atencion ayudante");
            dataTable.Columns.Add("RND reparacion");
            dataTable.Columns.Add("Tiempo Reparacion");
            dataTable.Columns.Add("Fin Reparacion");
            dataTable.Columns.Add("Fin Ordenado");
            dataTable.Columns.Add("Estado Ayudante");
            dataTable.Columns.Add("Cola Ayudante");
            dataTable.Columns.Add("Relojes en espera retiro");
            dataTable.Columns.Add("Estado Relojero");
            dataTable.Columns.Add("Cola reparacion");
            //dataTable.Columns.Add("T Ocupación Ayudante");
            //dataTable.Columns.Add("%Ocup");
            //dataTable.Columns.Add("T Ocupación Relojero");
            //dataTable.Columns.Add("%Ocup");
            //dataTable.Columns.Add("No reparados");
            //dataTable.Columns.Add("Prop");
        }

        public void mostrarDatos()
        {
            generar_dt();

            var iteraciones = maximo_simulacion == _j ? maximo_simulacion : _i + _j;
            for (int i = _i; i < iteraciones; i++)
            {
                //Barra de progreso 
                _frm.progressBar.Value = (int)(100 / double.Parse((iteraciones).ToString()) * (i + 1));

                //_dyc.OcupAyudante = 0;
                //_dyc.PorOcupAyudante = 0;
                //_dyc.OcuRelojero = 0;
                //_dyc.PorOcuRelojero = 0;
                //_dyc.NoReparados = 0;
                //_dyc.Prob = 0;
                //_dyc.ColaClientes = new Queue<Cliente>();
                dataTable.Rows.Add(_iteracion[i].i,
                    _iteracion[i].Evento,
                    _iteracion[i].Reloj,
                    _iteracion[i].RNDLlegada ?? string.Empty,
                    _iteracion[i].TiempEntreLLegadas ?? string.Empty,
                    _iteracion[i].ProxLlegada ?? string.Empty,
                    _iteracion[i].RNDAccion ?? string.Empty,
                    _iteracion[i].Accion ?? string.Empty,
                    _iteracion[i].RNDTiempoAtencion ?? string.Empty,
                    _iteracion[i].TiempoAtencion ?? string.Empty,
                    _iteracion[i].FinAtencion ?? string.Empty,
                    _iteracion[i].RNDReparacion ?? string.Empty,
                    _iteracion[i].TiempoReparacion ?? string.Empty,
                    _iteracion[i].FinReparacion ?? string.Empty,
                    _iteracion[i].FinOrdenado ?? string.Empty,
                    _iteracion[i].EstadoAyudante ?? string.Empty,
                    _iteracion[i].ColaAyudante ?? string.Empty,
                    _iteracion[i].RelojesEnEspera ?? string.Empty,
                    _iteracion[i].EstadoRelojero ?? string.Empty,
                    _iteracion[i].ColaReparacion ?? string.Empty
                    );
            }

            dataTable.Rows.Add(_iteracion[maximo_simulacion - 1].i,
                    _iteracion[maximo_simulacion - 1].Evento,
                    _iteracion[maximo_simulacion - 1].Reloj,
                    _iteracion[maximo_simulacion - 1].RNDLlegada ?? string.Empty,
                    _iteracion[maximo_simulacion - 1].TiempEntreLLegadas ?? string.Empty,
                    _iteracion[maximo_simulacion - 1].ProxLlegada ?? string.Empty,
                    _iteracion[maximo_simulacion - 1].RNDAccion ?? string.Empty,
                    _iteracion[maximo_simulacion - 1].Accion ?? string.Empty,
                    _iteracion[maximo_simulacion - 1].RNDTiempoAtencion ?? string.Empty,
                    _iteracion[maximo_simulacion - 1].TiempoAtencion ?? string.Empty,
                    _iteracion[maximo_simulacion - 1].FinAtencion ?? string.Empty,
                    _iteracion[maximo_simulacion - 1].RNDReparacion ?? string.Empty,
                    _iteracion[maximo_simulacion - 1].TiempoReparacion ?? string.Empty,
                    _iteracion[maximo_simulacion - 1].FinReparacion ?? string.Empty,
                    _iteracion[maximo_simulacion - 1].FinOrdenado ?? string.Empty,
                    _iteracion[maximo_simulacion - 1].EstadoAyudante ?? string.Empty,
                    _iteracion[maximo_simulacion - 1].ColaAyudante ?? string.Empty,
                    _iteracion[maximo_simulacion - 1].RelojesEnEspera ?? string.Empty,
                    _iteracion[maximo_simulacion - 1].EstadoRelojero ?? string.Empty,
                    _iteracion[maximo_simulacion - 1].ColaReparacion ?? string.Empty
                    );

        }

        private (string Evento, double? Tiempo) obtenerProximoEvento(List<double?> _tiempos)
        {
            double? menorTiempo = _tiempos.Min();

            if (menorTiempo == _tiempos[0])
            {
                return (Eventos.Llegada, menorTiempo);
            }
            else if (menorTiempo == _tiempos[1])
            {
                return (Eventos.FinDeAtencion, menorTiempo);
            }
            else if (menorTiempo == _tiempos[2])
            {
                return (Eventos.FinDeReparacion, menorTiempo);
            }
            else if (menorTiempo == _tiempos[3])
            {
                return (Eventos.FinDeOrdenamiento, menorTiempo);
            }

            return (string.Empty, 0);
        }

        private void obtenerAccion(dynamic _actual)
        {
            List<(string accion, double prob)> list = new List<(string accion, double prob)>() {
                (AccionCliente.Comprar, double.Parse(_frm.txt_compra.Text)/100 ),
                (AccionCliente.Entregar, (double.Parse(_frm.txt_entrega.Text) + double.Parse(_frm.txt_compra.Text))/100 ),
                (AccionCliente.Retirar, (double.Parse(_frm.txt_retiro.Text) + double.Parse(_frm.txt_entrega.Text) + double.Parse(_frm.txt_compra.Text))/100)
            };

            _actual.RNDAccion = DoubleUtils.TruncateNumber(DoubleUtils.RandomNumber());

            if (_actual.RNDAccion == 0)
                _actual.RNDAccion = 0.01d;

            _actual.Accion = list.FirstOrDefault(x => _actual.RNDAccion < x.prob).accion;
        }
        private double calcularTempLlegada(double rnd)
        {
            return DoubleUtils.TruncateNumber(double.Parse(_frm.llegDesde.Text) + rnd * (double.Parse(_frm.llegHasta.Text) - double.Parse(_frm.llegDesde.Text)));
        }
        private double calcularFinAtencion(double rnd)
        {
            return DoubleUtils.TruncateNumber(double.Parse(_frm.atencDesde.Text) + rnd * (double.Parse(_frm.atencHasta.Text) - double.Parse(_frm.atencDesde.Text)));
        }
        private double calcularFinReparacion(double rnd)
        {
            return DoubleUtils.TruncateNumber(double.Parse(_frm.finRepDesde.Text) + rnd * (double.Parse(_frm.finRepHasta.Text) - double.Parse(_frm.finRepDesde.Text)));
        }

        private void simularReparacion(dynamic _actual)/*, dynamic _anterior)*/
        {
            double _rnd = DoubleUtils.TruncateNumber(DoubleUtils.RandomNumber());
            _actual.RNDReparacion = _rnd;
            _actual.TiempoReparacion = calcularFinReparacion(_rnd);
            _actual.FinReparacion = DoubleUtils.TruncateNumber(_actual.Reloj + _actual.TiempEntreLLegadas);
            _actual.FinOrdenado = DoubleUtils.TruncateNumber(_actual.FinReparacion + int.Parse(_frm.finOrdenamiento.Text));
            _actual.EstadoRelojero = EstadosRelojero.Reparando;
            _actual.ColaReparacion = _actual.ColaReparacion >= 0 ? _actual.ColaReparacion - 1 : 0;
        }
        private void simularComprar(dynamic _actual)/*, dynamic _anterior)*/
        {
            //_actual.ColaClientes = new Queue<Cliente>();


            //if (_anterior.ColaAyudante == 0)
            //{

            double _rnd = DoubleUtils.TruncateNumber(DoubleUtils.RandomNumber());
            _actual.RNDTiempoAtencion = _rnd;
            _actual.TiempoAtencion = calcularFinAtencion(_rnd);
            _actual.FinAtencion = DoubleUtils.TruncateNumber(_actual.Reloj + _actual.TiempoAtencion);
            _actual.EstadoAyudante = EstadosAyudante.Ocupado;
            //}

            //if (_anterior.Clientes.Count > 0)
            //{
            //    _actual.Clientes = new Queue<Cliente>(_anterior.ColaClientes);
            //    _actual.Clientes.Enqueue(new Cliente() { estado = EstadosCliente.EsperandoAtencion, hora_llegada = _actual.Reloj });
            //}
        }
        private void simularEntragaoRetiro(dynamic _actual)/*, dynamic _anterior)*/
        {
            _actual.RNDTiempoAtencion = null;
            _actual.TiempoAtencion = int.Parse(_frm.fin_retiro_entrega.Text);
            _actual.FinAtencion = DoubleUtils.TruncateNumber(_actual.Reloj + _actual.TiempoAtencion);
            _actual.EstadoAyudante = EstadosAyudante.Ocupado;

            if (_actual.Accion == AccionCliente.Retirar)
                _actual.RelojesEnEspera = _actual.RelojesEnEspera != 0 ? _actual.RelojesEnEspera - 1 : 0;
            else
                _actual.ColaReparacion = _actual.ColaReparacion + 1;
        }



        private void determinarAccion(dynamic _actual)
        {
            obtenerAccion(_actual);

            switch (_actual.Accion)
            {
                case AccionCliente.Comprar:
                    //simularComprar(_actual, _ant);
                    simularComprar(_actual);
                    break;
                case AccionCliente.Entregar or AccionCliente.Retirar:
                    //simularComprar(_actual, _ant);
                    simularEntragaoRetiro(_actual);
                    break;

            }
        }

        static ExpandoObject ShallowCopy(ExpandoObject original)
        {
            var clone = new ExpandoObject();

            var _original = (IDictionary<string, object>)original;
            var _clone = (IDictionary<string, object>)clone;

            foreach (var kvp in _original)
                _clone.Add(kvp);

            return clone;
        }


        public void simular()
        {
            _iteracion.Clear();

            double _rnd = DoubleUtils.TruncateNumber(DoubleUtils.RandomNumber());
            double _reloj = 0;
            double _tempLlegada = calcularTempLlegada(_rnd);
            double _proxLlegada = DoubleUtils.TruncateNumber(_reloj + _tempLlegada);


            dynamic _dyc = new ExpandoObject();
            _dyc.i = 0;
            _dyc.Evento = Eventos.Inicio;
            _dyc.Reloj = _reloj;
            _dyc.RNDLlegada = _rnd;
            _dyc.TiempEntreLLegadas = _tempLlegada;
            _dyc.ProxLlegada = _proxLlegada;
            _dyc.RNDAccion = null;
            _dyc.Accion = null;
            _dyc.RNDTiempoAtencion = null;
            _dyc.TiempoAtencion = null;
            _dyc.FinAtencion = null;
            _dyc.RNDReparacion = null;
            _dyc.TiempoReparacion = null;
            _dyc.FinReparacion = null;
            _dyc.FinOrdenado = null;
            _dyc.EstadoAyudante = EstadosAyudante.Libre;
            _dyc.ColaAyudante = 0;
            _dyc.RelojesEnEspera = 3;
            _dyc.EstadoRelojero = EstadosRelojero.Libre;
            _dyc.ColaReparacion = 0;
            _dyc.OcupAyudante = 0;
            _dyc.PorOcupAyudante = 0;
            _dyc.OcuRelojero = 0;
            _dyc.PorOcuRelojero = 0;
            _dyc.NoReparados = 0;
            _dyc.Prob = 0;
            _dyc.ColaClientes = new Queue<Cliente>();

            _iteracion.Add(_dyc);

            for (int i = 1; i < maximo_simulacion; i++)
            {
                var _ant = _iteracion[i - 1];

                dynamic _actual = ShallowCopy(_ant);

                _actual.i = i;

                var (Evento, Tiempo) = obtenerProximoEvento(new List<double?>() { _ant.ProxLlegada ?? null, _ant.FinAtencion ?? null, _ant.FinReparacion ?? null, _ant.FinOrdenado ?? null });

                _actual.Evento = Evento;
                _actual.Reloj = Tiempo;

                _actual.RNDLlegada = _ant.RNDLlegada;
                _actual.TiempEntreLLegadas = _ant.TiempEntreLLegadas;
                _actual.ProxLlegada = _ant.ProxLlegada;
                if (Evento == Eventos.Llegada)
                {
                    if (_ant.EstadoAyudante == EstadosAyudante.Libre && _ant.ColaAyudante == 0)
                        determinarAccion(_actual);
                    else
                        _actual.ColaAyudante++;

                    _actual.RNDLlegada = DoubleUtils.TruncateNumber(DoubleUtils.RandomNumber());
                    _actual.TiempEntreLLegadas = calcularTempLlegada(_actual.RNDLlegada);
                    _actual.ProxLlegada = DoubleUtils.TruncateNumber(_actual.Reloj + _actual.TiempEntreLLegadas);
                }

                if (Evento == Eventos.FinDeAtencion)
                {
                    if (_actual.ColaAyudante != 0)
                        determinarAccion(_actual);
                    else
                        _actual.EstadoAyudante = EstadosAyudante.Libre;

                    if (_ant.Accion == AccionCliente.Entregar && _ant.ColaReparacion != 0)
                        simularReparacion(_actual);

                    _actual.Accion = null;
                    _actual.RNDTiempoAtencion = null;
                    _actual.TiempoAtencion = null;
                    _actual.FinAtencion = null;
                }

                if (Evento == Eventos.FinDeReparacion)
                {
                    if (_ant.EstadoRelojero == EstadosRelojero.Reparando)
                        _actual.EstadoRelojero = EstadosRelojero.Ordenando;

                    _actual.RNDReparacion = null;
                    _actual.TiempoReparacion = null;
                    _actual.FinReparacion = null;
                }
                if (Evento == Eventos.FinDeOrdenamiento)
                {
                    if (_ant.ColaReparacion != 0)
                        simularReparacion(_actual);
                    else
                        _actual.EstadoRelojero = EstadosRelojero.Libre;

                    _actual.RelojesEnEspera = _actual.RelojesEnEspera + 1;

                    _actual.FinOrdenado = null;
                }

                _iteracion.Add(_actual);
            }
        }
    }
}