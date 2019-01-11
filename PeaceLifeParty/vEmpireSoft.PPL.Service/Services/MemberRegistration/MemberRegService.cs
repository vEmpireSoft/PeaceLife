using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using vEmpireSoft.PPL.Data.DBContext;
using vEmpireSoft.PPL.Data.DomainModel;
using vEmpireSoft.PPL.Data.Repository;
using vEmpireSoft.PPL.Data.Repository.Interface;

namespace vEmpireSoft.PPL.Service.Services.MemberRegistration
{
    public class MemberRegService
    {
        public bool Add(MemberDto Entity)
        {
            using (IContext context = new Context(new PLPDBContext()))
            {
                Member memberDM = new Member();
                memberDM.FirstName = Entity.FirstName;
                memberDM.Surname = Entity.Surname;
                memberDM.Title = Entity.Title;
                memberDM.AddressLine1 = Entity.AddressLine1;
                memberDM.AddressLine2 = Entity.AddressLine2;
                memberDM.AddressLine3 = Entity.AddressLine3;
                memberDM.Suburb = Entity.Suburb;
                memberDM.State = Entity.State;
                memberDM.PostCode = Entity.PostCode;
                memberDM.HomePhoneNumber = Entity.HomePhoneNumber;
                memberDM.MobileNumber = Entity.MobileNumber;
                memberDM.Email = Entity.Email;
                memberDM.RegisteredDate = DateTime.Now;

                context.MemberRepo.Add(memberDM);
                context.Complete();

                if (IsSendEmailEnabled())
                    SendEmailAsync("youngmurukan@gmail.com", "Test");


                return true;
            }
        }


        public bool SendEmailAsync(string email, string msg, string subject = "")
        {
            // Initialization.  
            bool isSend = false;

            try
            {
                // Initialization.  
                var body = msg;
                var message = new MailMessage();

                // Settings.  
                message.To.Add(new MailAddress(email));
                //     message.To.Add(new MailAddress("vEmpireSoft@gmail.com"));
                message.From = new MailAddress(email);
                message.Subject = "Wel come to Peace Life Party!!";// !string.IsNullOrEmpty(subject) ? subject : EmailInfo.EMAIL_SUBJECT_DEFAUALT;
                message.Body = body;
                message.IsBodyHtml = true;

                using (var smtp = new SmtpClient())
                {
                    // Settings.  
                    var credential = new NetworkCredential("youngmurukan@gmail.com", "youngmurukan@81");
                    //{
                    //    UserName = EmailInfo.FROM_EMAIL_ACCOUNT,
                    //    Password = EmailInfo.FROM_EMAIL_PASSWORD
                    //};
                    smtp.UseDefaultCredentials = false;
                    // Settings.  
                    smtp.Credentials = credential;
                    smtp.Host = "smtp.gmail.com";
                    smtp.Port = 587;// Convert.ToInt32(EmailInfo.SMTP_PORT_GMAIL);
                    smtp.EnableSsl = true;

                    // Sending  
                    smtp.Send(message);

                    // Settings.  
                    isSend = true;
                }
            }
            catch (Exception ex)
            {
                // Info  
                throw ex;
            }

            // info.  
            return isSend;
        }

        public bool IsSendEmailEnabled()
        {
            string SendEmailEnabled = ConfigurationManager.AppSettings.Get("SendEmailEnabled");
            return Convert.ToBoolean(SendEmailEnabled);

        }


        public IList<MemberDto> GetAllMembers()
        {
            using (IContext context = new Context(new PLPDBContext()))
            {

                List<Member> list = context.MemberRepo.GetAll(0).ToList();
                List<MemberDto> memberDtos = new List<MemberDto>();
                list.ForEach(o =>
                {
                    memberDtos.Add(new MemberDto()
                    {
                        FirstName = o.FirstName,
                        Surname = o.Surname,
                        Title = o.Title,
                        AddressLine1 = o.AddressLine1,
                        AddressLine2 = o.AddressLine2,
                        AddressLine3 = o.AddressLine3,
                        Suburb = o.Suburb,
                        State = o.State,
                        PostCode = o.PostCode,
                        HomePhoneNumber = o.HomePhoneNumber,
                        MobileNumber = o.MobileNumber,
                        Email = o.Email,
                        RegisteredDate = DateTime.Now,
                        ID=o.MemberId

                    });

                });

                return memberDtos;
            }
        }
    }
}
