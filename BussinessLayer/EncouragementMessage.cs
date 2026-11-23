using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
namespace BussinessLayer
{
    public class EncouragementMessage
    {
        public int ID { get; private set; }
        public string message { get; set; }

        public DateTime addedTime { get; private set; }

        public DateTime editTime { get; private set; }
        public static int AddMessage(string message)
        {
            return EncouragementMessages.AddMessage(message);
        }
        private static EncouragementMessage ConvertRowToObj(DataRow row)
        {
            var obj = new EncouragementMessage();
            obj.ID= (int)row["ID"];
            obj.message = row["message"].ToString();
            obj.addedTime = (DateTime)row["addedTime"];
            obj.editTime = (DateTime)row["editTime"];


            return obj;

        }
        public static List<EncouragementMessage> GetAllMessages()
        {
            var ret= new List<EncouragementMessage>();
            var dataTable=EncouragementMessages.GetAllMessages();

            foreach (var item in dataTable.Rows)
            {
                ret.Add(ConvertRowToObj((DataRow)item));
            }

            return ret;
        }
        public static bool DeleteMessage(int ID)
        {
            return EncouragementMessages.DeleteMessage(ID);
        }
        public bool DeleteMessage()
        {
            return EncouragementMessages.DeleteMessage(ID);
        }

        private static bool IsRightToLeft(string text)
        {
            foreach (char c in text)
            {
                if (char.IsLetter(c))
                {
                    return c >= '\u0590' && c <= '\u08FF';
                }
            }

            return false;
        }
       
        
        public static string GetRandomMessage()
        {
            return  EncouragementMessages.GetRandomMessage();
        }
        public static bool EditMessage(int ID,string EditedMessage)
        {
            return EncouragementMessages.EditMessage(ID, EditedMessage);
        }
        public bool EditMessage(string EditedMessage)
        {
            return EncouragementMessages.EditMessage(ID,EditedMessage);
        }
        public static EncouragementMessage GetMessage(int ID)
        {

            string message="";
            DateTime addedTime=DateTime.Now, editedTime=DateTime.Now;

            

            if (EncouragementMessages.GetMessage(ID,ref message,ref addedTime,ref editedTime))
            {
                return new EncouragementMessage() { ID = ID, message = message, addedTime = addedTime, editTime = editedTime };
            }
            else
            {
                return  new EncouragementMessage() { ID = -1 };
            }



        }

    }
}
