using System;

namespace Transversal
{
    public class TurnResponse
    {
        public String FechaTurno { get; set; }

        public TimeSpan HoraInicio { get; set; }

        public TimeSpan HoraFin { get; set; }

        public String Estado { get; set; }

        public TurnResponse()
        {

        }

        public TurnResponse(String fechaTurno, TimeSpan horaInicio, TimeSpan horaFin, String estado)
        {
            this.FechaTurno = fechaTurno;
            this.HoraInicio = horaInicio;
            this.HoraFin = horaFin;
            this.Estado = estado;
        }
    }
}
