using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIM_4K4_2023_G2_TP4.Model
{
    internal class Cliente
    {
        public static string EN_ESPERA = "En espera";

        public static string SIENDO_ATENTIDO = "Siendo atendido";

        public string estado;
        public string hora_llegada;
    }
}
