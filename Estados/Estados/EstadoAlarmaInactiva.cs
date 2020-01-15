using System;
using System.Collections.Generic;
using System.Text;

namespace Estados
{
    class EstadoAlarmaInactiva : IEstadoAlarmaPuerta
    {
        Alarma alarma;

        public string activar()
        {
            EstadoAlarmaActiva activa = new EstadoAlarmaActiva();
            activa.setAlarma(alarma);
            this.alarma.setEstadoAlarma(activa);
            return "Alarma Activa";
        }

        public string desactivar()
        {
            return "La alarma ya se encuentra inactiva";
        }

        public void setAlarma(Alarma alarma)
        {
            this.alarma = alarma;
        }
    }
}
