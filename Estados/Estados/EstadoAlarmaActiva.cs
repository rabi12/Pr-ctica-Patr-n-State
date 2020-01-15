using System;
using System.Collections.Generic;
using System.Text;

namespace Estados
{
    public class EstadoAlarmaActiva : IEstadoAlarmaPuerta
    {
        Alarma alarma;

        public string activar()
        {
            return "La alarma ya se encuentra activa";
        }

        public string desactivar()
        {
            EstadoAlarmaInactiva inactiva = new EstadoAlarmaInactiva();
            inactiva.setAlarma(alarma);
            alarma.setEstadoAlarma(inactiva);
            return "Alarma Inactiva";
        }

        public void setAlarma(Alarma alarma)
        {
            this.alarma = alarma;
        }
    }
}
