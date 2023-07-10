using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace DependensInjection.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class BaseControoller : ControllerBase
    {
        private readonly EmailHelper emailHelper;

        public BaseControoller(EmailHelper emailHelper)
        {
            this.emailHelper = emailHelper;
        }
       


        [HttpGet]
        public IActionResult GetUserEmails(string username)
        {
            string[] userEmails = emailHelper.getUserEmails(username);
            return Ok(userEmails);
        }


        [HttpGet]
        public IActionResult CheckEmail(string email)
        {
            bool isValidEmail = emailHelper.CheckEnteredEmail(email);
            return Ok(isValidEmail);
        }
        [HttpGet]
        public IActionResult SendEmail(string recipient)
        {
            return Ok(emailHelper.SendEmail(recipient));
        }
        
       

    }
}
