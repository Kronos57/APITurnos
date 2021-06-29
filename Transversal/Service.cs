using System;

namespace Transversal
{
    public class Service
    {
        public int Id { get; set; }

        public int IdComercio { get; set; }

        public string NombreServicio { get; set; }

        public TimeSpan HoraApertura { get; set; }

        public TimeSpan HoraCierre { get; set; }

        public Int16 DuracionServicio { get; set; }

        public Service()
        {

        }

        public Service(int id, int idComercio, string nombreServicio, TimeSpan horaApertura, TimeSpan horaCierre, Int16 duracionServicio)
        {
            this.Id = id;
            this.IdComercio = idComercio;
            this.NombreServicio = nombreServicio;
            this.HoraApertura = horaApertura;
            this.HoraCierre = horaCierre;
            this.DuracionServicio = duracionServicio;
        }

        public Service(int id, string nombreServicio)
        {
            this.Id = id;
            this.NombreServicio = nombreServicio;
        }
    }
}
