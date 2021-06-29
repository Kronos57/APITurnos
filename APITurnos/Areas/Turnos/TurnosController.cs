using Data;
using Data.Turns;
using System.Web.Http;
using Transversal;
using Transversal.Strategy;

namespace APITurnos.Areas.Turnos
{
    public class TurnosController : ApiController
    {
        /// <summary>
        /// Genera los turnos correspondientes a partir de un rango de fechas y un Id Servicio, que conforman el objeto GenerateTurnsParameters.
        /// </summary>
        /// <param name="generateTurns"></param>
        /// <returns></returns>
        [HttpPost]
        public IHttpActionResult GenerateTurns(GenerateTurnsParameters generateTurnsParameters)
        {
            DataGenerateTurns dataGenerateTurns = new DataGenerateTurns(generateTurnsParameters);

            if (dataGenerateTurns.Execute() == StateStrategy.Success)
            {
                return Ok(dataGenerateTurns.Result);
            }
            else
            {
                return InternalServerError(dataGenerateTurns.GetException());
            }
        }

        /// <summary>
        /// Obtiene el listado de todos los turnos existentes.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IHttpActionResult GetTurnos()
        {
            DataTurnGetList dataTurnGetList = new DataTurnGetList();

            if (dataTurnGetList.Execute() == StateStrategy.Success)
            {
                return Ok(dataTurnGetList.Result);
            }
            else
            {
                return InternalServerError(dataTurnGetList.GetException());
            }
        }
    }
}
