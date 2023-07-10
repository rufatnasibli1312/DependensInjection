using System;

namespace DependensInjection
{
    public class EmailHelper
    {
        private readonly EmailEntity _emailEntity;

        public EmailHelper(EmailEntity emailEntity)
        {
            this._emailEntity = emailEntity;
        }


        public string SendEmail(string recipient) => $"Email sending this recipient:{recipient}";

        public bool CheckEnteredEmail(string email) => true;

        public string[] getUserEmails(string username) => new string[] { "rufet1312@gmail.com", "rufatnasibli1312@gmail.com" };

       
    }
       

    

}
