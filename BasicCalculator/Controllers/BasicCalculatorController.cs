using BasicCalculator.Models;
using System.Web.Http;


namespace BasicCalculator.Controllers
{
    public class BasicCalculatorController : ApiController
    {
        [HttpPost]

        public IHttpActionResult Calculator(Operation model)
        {
           
               switch (model.OperationType)
            {
                case OperationType.Addition :
                    model.Result = model.NumberA + model.NumberB;
                    break;
                case OperationType.Substraction :
                    model.Result = model.NumberA - model.NumberB;
                    break;
                case OperationType.Multiplication :
                    model.Result = model.NumberA * model.NumberB;
                    break;
                case OperationType.Division:
                    model.Result = model.NumberA / model.NumberB;
                    break;
            }
            return Ok(model);
        }
    }
}
