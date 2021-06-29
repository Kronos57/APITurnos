using DbConection;
using System.Collections.Generic;
using System.Linq;
using Transversal;
using Transversal.Strategy;

namespace Data
{
    public class DataServiceGetList : DataStrategy
    {
        public DataServiceGetList()
        {

        }

        protected override void Process()
        {
            List<Service> services = new List<Service>();

            using (TurnosEntities turnosEntities = new TurnosEntities())
            {
                List<servicio> entityServicios = turnosEntities.servicios.ToList();

                foreach (servicio entityServicio in entityServicios)
                {
                    services.Add(new Service(entityServicio.id_servicio
                        , entityServicio.id_comercio, entityServicio.nom_servicio, entityServicio.hora_apertura
                        , entityServicio.hora_cierre, entityServicio.duracion));
                }
            }

            SetResult(services);
        }
    }
}
