using DbConection;
using System.Collections.Generic;
using System.Linq;
using Transversal;
using Transversal.Strategy;

namespace Data.Turns
{
    public class DataGenerateTurns : DataStrategy
    {
        private GenerateTurnsParameters generateTurns;

        public DataGenerateTurns(GenerateTurnsParameters generateTurns)
        {
            this.generateTurns = generateTurns;
        }

        protected override void Process()
        {
            List<TurnResponse> turnos = new List<TurnResponse>();

            using (TurnosEntities turnosEntities = new TurnosEntities())
            {
                turnosEntities.spGenerarTurnos(generateTurns.FechaInicio, generateTurns.FechaFin, generateTurns.IdServicio);

               var entityTurnos = turnosEntities.spGenerarTurnos(generateTurns.FechaInicio, generateTurns.FechaFin, generateTurns.IdServicio).ToList();

                foreach (var entityTurno in entityTurnos)
                {
                    turnos.Add(new TurnResponse(entityTurno.fecha_turno.ToString("dd-MM-yyyy"), entityTurno.hora_inicio, entityTurno.hora_fin, entityTurno.Estado));
                }
            }

            SetResult(turnos);
        }
    }
}
