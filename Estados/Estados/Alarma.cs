using System;
using System.Collections.Generic;
using System.Text;

namespace Estados
{
    public class Alarma
    {
        IEstadoAlarmaPuerta estado;

        public  Alarma(IEstadoAlarmaPuerta estado)
        {
            this.estado = estado;
        }

        public void setEstadoAlarma(IEstadoAlarmaPuerta estado)
        {
            this.estado = estado;
            
        }

        public string activar()
        {
            return estado.activar();
        }

        public string desactivar()
        {
            return estado.desactivar();
        }
    }
}
