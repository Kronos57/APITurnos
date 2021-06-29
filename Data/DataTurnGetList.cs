using DbConection;
using System;
using System.Collections.Generic;
using System.Linq;
using Transversal;
using Transversal.Strategy;

namespace Data
{
    public class DataTurnGetList : DataStrategy
    {
        public DataTurnGetList()
        {

        }

        protected override void Process()
        {
            List<TurnResponse> turnos = new List<TurnResponse>();

            using (TurnosEntities turnosEntities = new TurnosEntities())
            {
                List<turno> entityTurnos = turnosEntities.turnos.ToList();

                foreach (turno entityTurno in entityTurnos)
                {
                    String estado = string.Empty;

                    if (entityTurno.estado)
                    {
                        estado = "Asignado";
                    }
                    else
                    {
                        estado = "Disponible";
                    }

                    turnos.Add(new TurnResponse(entityTurno.fecha_turno.ToString("dd-MM-yyyy"), entityTurno.hora_inicio, entityTurno.hora_fin, estado));
                }
            }

            SetResult(turnos);
        }
    }
}
