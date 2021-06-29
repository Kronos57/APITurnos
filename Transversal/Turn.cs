using System;

namespace Transversal
{
    public class Turn
    {
        public int Id { get; set; }

        public int IdServicio { get; set; }

        public DateTime FechaTurno { get; set; }

        public TimeSpan HoraInicio { get; set; }

        public TimeSpan HoraFin { get; set; }

        public String Estado { get; set; }

        public Turn()
        {

        }

        public Turn(int Id, int idServicio, DateTime fechaTurno, TimeSpan horaInicio, TimeSpan horaFin, String estado)
        {
            this.Id = Id;
            this.IdServicio = idServicio;
            this.FechaTurno = fechaTurno;
            this.HoraInicio = horaInicio;
            this.HoraFin = horaFin;
            this.Estado = estado;
        }
    }
}
