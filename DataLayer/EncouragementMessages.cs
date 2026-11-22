using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public static class EncouragementMessages
    {
        public static int AddMessage(string message)
        {
            int ID=-1;

            using(SqlConnection connection=new SqlConnection(DatabaseAccess.ConnectionString))
            {
                string query = @"insert into EncouragementMessages (message,addedTime,editTime)
                values (@message,@addedTime,@editTime);
                select SCOPE_IDENTITY();
                ";

                using (SqlCommand command = new SqlCommand(query, connection))
                {

                    command.Parameters.AddWithValue("message", message);
                    command.Parameters.AddWithValue("addedTime", DateTime.Now);
                    command.Parameters.AddWithValue("editTime", DateTime.Now);


                    try
                    {
                        connection.Open();
                        var newID = command.ExecuteScalar();

                        int.TryParse(newID.ToString(),out ID);
                       
                    }
                    catch (Exception ex) {
                        throw new Exception("An error happens "+ ex.Message);
                    }

                }
            }

            return ID;
        }

        public static bool DeleteMessage(int ID)
        {
            bool isDeleted = false;

            using (SqlConnection connection = new SqlConnection(DatabaseAccess.ConnectionString))
            {
                string query = @"Delete from EncouragementMessages
                where ID=@ID
                ";

                using (SqlCommand command = new SqlCommand(query, connection))
                {

                    command.Parameters.AddWithValue("ID", ID);
                   

                    try
                    {
                        connection.Open();
                        isDeleted = command.ExecuteNonQuery() > 0;

                    }
                    catch (Exception ex)
                    {
                        throw new Exception("An error happens " + ex.Message);
                    }

                }
            }

            return isDeleted;
        }


        public static bool EditMessage(int ID, string message)
        {
            bool isEdited = false;

            using (SqlConnection connection = new SqlConnection(DatabaseAccess.ConnectionString))
            {
                string query = @"Update EncouragementMessages
                set
                    message=@message,
                    editTime=@editTime
                where ID=@ID
                ";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("ID", ID);
                    command.Parameters.AddWithValue("message", message);
                    command.Parameters.AddWithValue("editTime", DateTime.Now);


                    try
                    {
                        connection.Open();
                        isEdited = command.ExecuteNonQuery() > 0;

                    }
                    catch (Exception ex)
                    {
                        throw new Exception("An error happens " + ex.Message);
                    }

                }
            }

            return isEdited;
        }

        public static string GetRandomMessage()
        {
            string message;

            using (SqlConnection connection = new SqlConnection(DatabaseAccess.ConnectionString))
            {
                string query = @"select top(1) EM.message from EncouragementMessages as EM
                order by NEWID();
                ";

                using (SqlCommand command = new SqlCommand(query, connection))
                {

                    

                    try
                    {
                        connection.Open();
                         var randomMessage= command.ExecuteScalar();
                         
                        message=randomMessage.ToString();

                    }
                    catch (Exception ex)
                    {
                        throw new Exception("An error happens " + ex.Message);
                    }

                }

            }

                return message;
           
        }

        public static bool GetMessage(int ID,ref string message,ref DateTime addedTime,ref DateTime editedTime)
        {
           
            bool isFound=false;

            using (SqlConnection connection = new SqlConnection(DatabaseAccess.ConnectionString))
            {
                string query = @"select * from EncouragementMessages
                where ID=@ID;
                ";

                using (SqlCommand command = new SqlCommand(query, connection))
                {

                    command.Parameters.AddWithValue("ID", ID);

                    try
                    {
                        connection.Open();
                        var retMessage = command.ExecuteReader();

                        if (retMessage.Read())
                        {
                            isFound = true;
                            message = retMessage.GetValue(1).ToString();
                            addedTime = (DateTime)retMessage.GetValue(2);
                            editedTime = (DateTime)retMessage.GetValue(3);


                        }


                    }
                    catch (Exception ex)
                    {
                        throw new Exception("An error happens " + ex.Message);
                    }

                }

            }

                return isFound;
            

        }
        public static DataTable GetAllMessages()
        {
            
            DataTable dt=new DataTable();

            using (SqlConnection connection = new SqlConnection(DatabaseAccess.ConnectionString))
            {
                string query = @"select * from EncouragementMessages";
               

                using (SqlCommand command = new SqlCommand(query, connection))
                {



                    try
                    {
                        connection.Open();
                        var result = command.ExecuteReader();

                        if (result.HasRows)
                        {
                            dt.Load(result);
                        }

                    }
                    catch (Exception ex)
                    {
                        throw new Exception("An error happens " + ex.Message);
                    }

                }

            }

            return dt;

        }
    }
}
