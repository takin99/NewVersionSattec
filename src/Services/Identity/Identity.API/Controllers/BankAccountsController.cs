using MediatR;
using Microsoft.AspNetCore.Mvc;
using sattec.Identity.Application.Common.Models;
using sattec.Identity.Application.Users.Commands.BankAccountInfromation.CreateBankAccount;
using sattec.Identity.Application.Users.Commands.BankAccountInfromation.UpdateBankAccount;
using sattec.Identity.WebUI.Controllers;

namespace Identity.API.Controllers
{
    public class BankAccountsController : ApiControllerBase
    {
        [Route("AddBankAccount"), HttpPost]
        public async Task<ActionResult<Result>> PostBankAccount(CreateBankAccountCommand command)
        {
            return await Mediator.Send(command);
        }
        [Route("BankAccount"), HttpPut]
        public async Task<ActionResult<Result>> PutBankAccount(UpdateBankAccountCommand command)
        {
            return await Mediator.Send(command);
        }
    }
}
