using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WeddingAPI.Models;
using WeddingAPI.DAL;
using Mailjet.Client;
using Mailjet.Client.Resources;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using System.Net.Mail;
using System.Net;
using WeddingAPI.Content;

namespace WeddingAPI.Service
{
    public class Service
    {
        private static readonly string mailJetApiKey = "debc1c7aeaada13ff82995e2a656f3f5";
        private static readonly string mailJetApiSecret = "4568c6c92eefa085a99b7bec9fe96c67";
        private WeddingDB database = new WeddingDB();

        public async Task<string> RegisterGuest(RegisterGuestInput guest)
        {            
            string msg = "";

            if (guest.Code == "mybackdoor") //Create & Send email
            {
                msg = await CreateGuestAsync(guest);
            }
            else //Regular process
            {
                var guestEntry = database.Guest.FirstOrDefault(e => e.CODE == guest.Code && e.EMAIL == guest.Email.Trim());
                if (guestEntry == null)
                {
                    msg = "WRONG_EMAIL_CODE";
                }
                else
                {
                    guestEntry.NUM_ADULTS = guest.NumAdults;
                    guestEntry.NUM_KIDS = guest.NumKids;
                    guestEntry.MESSAGE = guest.Message;
                    guestEntry.TIMESTAMP = DateTime.UtcNow;

                    if ((guestEntry.NUM_ADULTS > 0 || guestEntry.NUM_KIDS > 0) && !string.IsNullOrWhiteSpace(guestEntry.MESSAGE))
                        guestEntry.REG_FLAG = true;

                    database.SaveChanges();
                    msg = "success";
                }
            }

            return msg;
        }

        public async Task<string> CreateGuestAsync(RegisterGuestInput input)
        {
            GuestEntry newEntry = new GuestEntry();
            string newEntryCode = CreateNewGuestCode();
            newEntry.CODE = newEntryCode;
            newEntry.EMAIL = input.Email;
            database.Guest.Add(newEntry);
            int n = database.SaveChanges();
            if (n > 0)
            {
                //Step To send Email
                //if (await SendMailJectMailAsync(input.Message, input.Email))
                if(SendEmailNativeClient(input.Message, input.Email, newEntryCode))
                    return "creation DONE";
                else
                    return "creation successful, Email sent error";
            }
            else
                //log error
                return "database insert error";
        }

        //private async Task<bool> SendMailJectMailAsync(string recipient, string address)
        //{
        //    string fromEmail = "vvctiger@hotmail.com";
        //    string fromName = "Jingyi Guo & Xiao Yang";
        //    string emailSubject = GetEmailSubject();
        //    string emailBody = GetEmailBody();

        //    MailjetClient mailjetClient = new MailjetClient(mailJetApiKey, mailJetApiSecret)
        //    {
        //        Version = ApiVersion.V3_1,
        //    };

        //    MailjetRequest request = new MailjetRequest
        //    {
        //        Resource = Send.Resource,
        //    }
        //    .Property(Send.Messages, new JArray {
        //        new JObject {
        //         {"From", new JObject {
        //          {"Email", fromEmail},
        //          {"Name", fromName}
        //          }},
        //         {"To", new JArray {
        //          new JObject {
        //           {"Email", address},
        //           {"Name", recipient}
        //           }
        //          }},
        //         {"Subject", emailSubject},
        //         //{"TextPart", "Dear passenger, welcome to Mailjet! May the delivery force be with you!"},
        //         {"HTMLPart", emailBody}
        //         }
        //        });
        //    MailjetResponse response = await mailjetClient.PostAsync(request);
        //    if (response.IsSuccessStatusCode)
        //    {
        //        //Console.WriteLine(string.Format("Total: {0}, Count: {1}\n", response.GetTotal(), response.GetCount()));
        //        //Console.WriteLine(response.GetData());
        //        return true;
        //    }
        //    else
        //    {
        //        //Console.WriteLine(string.Format("StatusCode: {0}\n", response.StatusCode));
        //        //Console.WriteLine(string.Format("ErrorInfo: {0}\n", response.GetErrorInfo()));
        //        //Console.WriteLine(response.GetData());
        //        //Console.WriteLine(string.Format("ErrorMessage: {0}\n", response.GetErrorMessage()));
        //        return false;
        //    }
        //}

        private string CreateNewGuestCode()
        {
            Guid uid = Guid.NewGuid();
            string code = uid.ToString().Replace("-", "");
            Random rnd = new Random();
            int idx = rnd.Next(code.Length - 6);
            return code.Substring(idx, 6).ToUpper();
        }

        private string GetEmailSubject()
        {
            return "We Invite You To Celebrate Our Marriage! 诚挚邀请您参加我们的婚礼！";
        }

        private string GetEmailBody(string recipient, string code)
        {
            string retVal = EmailTemplate.TemplateString.Replace("{DEAR_FRIEND}", recipient).Replace("{INV_CODE}", code);
            return retVal;
        }

        private bool SendEmailNativeClient(string recipient, string address, string code)
        {
            try
            {
                SmtpClient client = new SmtpClient("smtp.gmail.com");
                client.Port = 587;
                client.Credentials = new NetworkCredential("vvctiger@gmail.com", "uq0xml5e5p");
                client.EnableSsl = true;
                MailMessage message = new MailMessage("vvctiger@gmail.com", address);
                message.Subject = GetEmailSubject();
                message.Body = GetEmailBody(recipient, code);
                message.IsBodyHtml = true;                
                client.Send(message);
                return true;
            }
            catch(Exception ex)
            {
                //log?
                return false;
            }
        }
    }
}