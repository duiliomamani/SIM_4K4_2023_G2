using SIM_4K4_2023_G2_TP4.Model;
using System;
using System.Collections.Generic;
using System.Data;
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
        public frmPrincipal formulario;
        public int maximo_simulacion = 100000;
        //private int cont_personas_llegada = 0;
        public string evento = "";
        public double reloj = 0;
        public double rnd_llegada = 0;
        public double proxima_llegada = 0;
        public double rnd_accion = 0;
        public string accion = "";
        public double rnd_tiempo_atencion = 0;
        public double tiempo_atencion = 0;
        public double rnd_tiempo_reparacion = 0;
        public double tiempo_reparacion = 0; 
        public int relojes_listos = 0;  
        public int relojes_por_reparar = 0;         
        public double ac_ocupacion_ayudante = 0;
        public double ac_ocupacion_relojero = 0;       
        //private string estado = "";
        public Queue<Cliente> clientes = new Queue<Cliente>();         
        public double prox_fin_uso_instalacion = 0;
        public Cliente prox_cliente_fin_uso_instalacion;
        public int cantidad_iteracciones = 0;
        public bool iteracciones_cumplidas = false;

        public Simulacion(frmPrincipal formulario)
        {
            this.formulario = formulario;
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
        }

        private void calcular_iteraciones()
        {
            // Entra al condicional si el reloj es mayor a la hora desde y todavia no se llegaron a las i+X iteracciones
            // Si no entra, significa que todavia no se llegó a la hora desde, o que ya se cumplio el i+X
            if (reloj >= formulario.txt_desde_hora && !iteracciones_cumplidas)
            {
                cantidad_iteracciones++;

                // Si las iteraciones llegaron a i+X, significa que cumplimos la cantidad de iteraciones y se actualiza dicha variable.
                if (cantidad_iteracciones == formulario.cantidad_iteracciones)
                {
                    iteracciones_cumplidas = true;
                }

            }
        }
    }
}
