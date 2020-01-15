using System;
using System.Collections.Generic;
using System.Text;

namespace Estados
{
    public interface IEstadoAlarmaPuerta
    {
        string activar();
        string desactivar();
    }
}
