using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using sattec.Identity.Application.Users.Commands.Signup;
using sattec.Identity.Application.Users.Commands.Signin;
using sattec.Identity.Application.Users.Commands.ConfirmMobile;
using sattec.Identity.Application.Users.Commands.ForgetPassword;
using sattec.Identity.Application.Users.Commands.ResetPassword;
using sattec.Identity.Application.Common.Models;
using sattec.Identity.Application.Users.Commands.IdentityInformation;
using sattec.Identity.Application.Users.Commands.ContactInformation;
using sattec.Identity.Application.Users.Commands.InsuranceInformation;
using sattec.Identity.Application.Users.Commands.DocumentInformation;

namespace sattec.Identity.WebUI.Controllers;

public class UserController : ApiControllerBase
{
    [Route("Signup"),HttpPost]
    public async Task<ActionResult<SignupResponse>> Signup(SignupCommand command)
    {
        return await Mediator.Send(command);
    }
    [Route("Signin"),HttpPost]
    public async Task<ActionResult<SigninResponse>> Signin(SigninCommand command)
    {
        return await Mediator.Send(command);
    }
    [Route("ConfirmMobile"), HttpPost]
    public async Task<ActionResult<Result>> ConfirmMobile([FromBody] ConfirmMobileCommand command)
    {
        return await Mediator.Send(command);
    }
    [Route("ForgetPassword"), HttpPost]
    public async Task<ActionResult<ForgetPasswordResponse>> ForgetPassword(ForgetPasswordCommand command)
    {
        return await Mediator.Send(command);
    }
    [Route("ResetPassword"), HttpPost]
    public async Task<ActionResult<Result>> ResetPassword(ResetPasswordCommand command)
    {
        return await Mediator.Send(command);
    }
    [Route("IentityInformation"), HttpPost]
    public async Task<ActionResult<Result>> IdentityInformation(IdentityInformationCommand command)
    {
        return await Mediator.Send(command);
    }
    [Route("ContactInformation"), HttpPost]
    public async Task<ActionResult<Result>> ContactInformation(ContactInformationCommand command)
    {
        return await Mediator.Send(command);
    } 
    [Route("InsuranceInformation"), HttpPost]
    public async Task<ActionResult<Result>> InsuranceInformation(InsuranceInformationCommand command)
    {
        return await Mediator.Send(command);
    } 
    [Route("DocumentInfo"), HttpPost]
    public async Task<ActionResult<Result>> DocumentInfo(DocumentInfoCommand command)
    {
        return await Mediator.Send(command);
    }
}
