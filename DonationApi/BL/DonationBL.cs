using DonationApi.DAL;
using DonationApi.Models;
using System.Net.Mail;

namespace DonationApi.BL
{
    public class DonationBL:IDonationBL
    {
        IDonationDAL _donationDAL;

        DonationBL(IDonationDAL donationDAL)
        {
            this._donationDAL = donationDAL;
        }
        public void AddDonation( Donation donation)
        {
            if(int.Parse(donation.DonationAmount) > 10000)  {
                string _password = "miri123456";
                string _sender = "miri61376@gmail.com";
                SmtpClient client = new SmtpClient("smtp.gmail.com");
                client.Port = 587;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.UseDefaultCredentials = false;
                System.Net.NetworkCredential credentials = new System.Net.NetworkCredential(_sender, _password);
                client.EnableSsl = true;
                client.Credentials = credentials;
                System.Net.Mail.MailMessage message = new System.Net.Mail.MailMessage(_sender, "miri61376@gmail.com");
                message.Subject = "הודעה על תרומה בסכום גבוה" ;
                message.Body = donation.DonationAmount + "תרמת תרומה בסך  ";
                client.Send(message);
            }
            this._donationDAL.AddDonation(donation);
        }

    }
}
