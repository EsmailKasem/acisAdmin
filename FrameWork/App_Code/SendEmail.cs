using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Mail;
using System.Windows.Forms;
using System.Net;
using System.Data;
using System.ComponentModel;



namespace FrameWork
{
    public class SendEmail
    {
        #region
        public string MyEmail = "sendemailtest502@gmail.com";
        public string PassWord = "147369852";
        #endregion
//gfjghfjhgfhjgfjhgfhgjfghfju
        public bool SendEmailNow(string ReceiverName, string EmailAddress, string EmailSubject, string EmailSincerely, bool IsArabic, params  EmailGrid[] EmailContent)
        {
            string EmailDirection = IsArabic ? "DIR='RTL'" : "DIR='LTR'";
            string SincerelyDirection = IsArabic ? "DIR='LTR'" : "DIR='RTL'";

            string _SincerelyCaption = IsArabic ? "تحياتي" : "Sincerely ,";
            string _GreedCaption = IsArabic ? "عزيزي" : "Dear ";
            try
            {
                MailMessage message = new MailMessage() { IsBodyHtml = true };
                SmtpClient smtp = new SmtpClient();
                message.From = new MailAddress(EmailAddress);
                message.To.Add(new MailAddress(EmailAddress));
                message.Subject = EmailSubject;


                string EmailBody = "";
                EmailBody += string.Format(@"<html><head></head><body {0} >", EmailDirection);
                EmailBody += @"<p style=""margin-top: 0in; margin-right: 0in; margin-bottom: 5.0pt; margin-left: 0in; line-height: 150%; font-size: 11.0pt; font-family:; width: 1111px; height: 28px;"">";
                EmailBody += string.Format("{1} {0} ", ReceiverName , _GreedCaption);
                EmailBody += @"</p>";

                foreach (EmailGrid CurrentContent in EmailContent)
                    EmailBody += CurrentContent.ToString();

                EmailBody += string.Format ( @"<p {0} style="" margin-top: 0in; margin-right: 0in; margin-bottom: 5.0pt; margin-left: 0in; line-height: 150%; font-size: 11.0pt; font-family:; width: 1111px; height: 127px;"">" , EmailDirection );
                EmailBody += string.Format(@"{0} <br />", _SincerelyCaption);
                EmailBody += EmailSincerely;
                EmailBody +=  @"</p>";
                EmailBody += @"";
                EmailBody += @"</body></html>";


                message.Body = EmailBody;
                smtp.Port = 587;
                smtp.Host = "smtp.gmail.com";
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential(MyEmail, PassWord);
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Send(message);

                return true;
            }
            catch
            {
                return false;
            }
        }

    }
public void Test(){}
    public class EmailGrid
    {
        public string GridHeader { get; set; }
        public bool IsInCenter { get; set; }
        public DataTable ContentGrid { get; set; }
        public string TextBeforGrid { get; set; }
        public string TextAfterGird { get; set; }

        public string BuildTableHtml()
        {

            StringBuilder HTML_TABLE_CODE = new StringBuilder();

            if (!string.IsNullOrEmpty(TextBeforGrid))
            {
                HTML_TABLE_CODE.Append(@"<p style="" margin-top: 0in; margin-right: 0in; margin-bottom: 5.0pt; margin-left: 0in; line-height: 150%; font-size: 11.0pt; font-family:; width: 1111px; height: 127px;"">");
                HTML_TABLE_CODE.Append(TextBeforGrid);
                HTML_TABLE_CODE.Append(@"</p>");
            }


            // Table Open
            HTML_TABLE_CODE.Append(IsInCenter ? "<center>" : "");
            HTML_TABLE_CODE.Append(@"<center><table style='font-family: verdana,arial,sans-serif; font-size: 11px; color: #333333;border-width: 1px; border-color: #666666; border-collapse: collapse;'>");

            // build table title
            if (!string.IsNullOrEmpty(GridHeader))
            {
                HTML_TABLE_CODE.Append(@"<tr>");
                HTML_TABLE_CODE.Append(String.Format(@"<td style='border-width: 1px; padding: 8px; border-style: solid; border-color: #666666; background-color: #dedede;' colspan={0} align=center>", ContentGrid.Columns.Count));
                HTML_TABLE_CODE.Append(GridHeader);
                HTML_TABLE_CODE.Append(@"</td>");
                HTML_TABLE_CODE.Append(@"</tr>");
            }


            // HEADER 
            HTML_TABLE_CODE.Append(@"<tr>");
            foreach (DataColumn Clm in ContentGrid.Columns)
            {
                HTML_TABLE_CODE.Append(@"<td style='border-width: 1px; padding: 8px; border-style: solid; border-color: #666666; background-color: #dedede;' >");
                HTML_TABLE_CODE.Append(Clm.Caption);
                HTML_TABLE_CODE.Append(@"</td>");
            }
            HTML_TABLE_CODE.Append(@"</tr>");

            foreach (DataRow Rw in ContentGrid.Rows)
            {
                HTML_TABLE_CODE.Append(@"<tr>");
                for (int i = 0; i < ContentGrid.Columns.Count; i++)
                {
                    HTML_TABLE_CODE.Append(@"<td style='border-width: 1px; padding: 8px; border-style: solid; border-color: #666666; background-color: #ffffff;' align=center>");
                    HTML_TABLE_CODE.Append(Rw[i].ToString());
                    HTML_TABLE_CODE.Append(@"</td>");
                }
                HTML_TABLE_CODE.Append(@"</tr>");
            }
            HTML_TABLE_CODE.Append(@"  </table></center>");
            HTML_TABLE_CODE.Append(IsInCenter ? "</center>" : "");

            if (!string.IsNullOrEmpty(TextAfterGird))
            {
                HTML_TABLE_CODE.Append(@"<p style="" margin-top: 0in; margin-right: 0in; margin-bottom: 5.0pt; margin-left: 0in; line-height: 150%; font-size: 11.0pt; font-family:; width: 1111px; height: 127px;"">");
                HTML_TABLE_CODE.Append(TextAfterGird);
                HTML_TABLE_CODE.Append(@"</p>");
            }

            return HTML_TABLE_CODE.ToString();
        }
        public string BuildTableHtml(DataTable _ContentGrid, string _GridHeader, bool _IsInCenter, string _TextBeforGrid, string _TextAfterGird)
        {
            IsInCenter = _IsInCenter;
            ContentGrid = _ContentGrid;
            GridHeader = _GridHeader;
            TextAfterGird = _TextAfterGird;
            TextBeforGrid = _TextBeforGrid;

            return BuildTableHtml();
        }
        public string BuildTableHtml<T>(IList<T> _ContentGrid, string _GridHeader, bool _IsInCenter, string _TextBeforGrid, string _TextAfterGird)
        {
            PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(typeof(T));
            DataTable table = new DataTable();
            foreach (PropertyDescriptor prop in properties)
                table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
            foreach (T item in _ContentGrid)
            {
                DataRow row = table.NewRow();
                foreach (PropertyDescriptor prop in properties)
                    row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
                table.Rows.Add(row);
            }

            ContentGrid = table;

            return BuildTableHtml();
        }

        public override string ToString()
        {
            return BuildTableHtml();
        }
    }

}
