using System;
using System.Collections.Generic;
using System.Text;

namespace AvisosVarios
{
    class AvisosTrafico : IAvisos
    {
        public string getFecha()
        {
            return fecha;
        }

        public void mostrarAviso()
        {
            Console.WriteLine("Mensaje {0} ha sido enviado por el remitente {1} en la fecha {2}", mensaje, remitente, fecha);
        }

        public AvisosTrafico()
        {
            remitente = "DGT";
            mensaje = "Page 3 dias i se lleva un descuernto";
            fecha = "fecha";

        }

        public AvisosTrafico(string remitente, string mensaje, string fecha)
        {
            this.remitente = remitente;
            this.mensaje = mensaje;
            this.fecha = fecha;
        }


        private string remitente;
        private string mensaje;
        private string fecha;

        public void mostraraviso()
        {
            Console.WriteLine($"Mensaje {0} ha sido enviado por el remitente {1} en la fecha {2}", mensaje,remitente,fecha);
        }

    }



}
