namespace LoggingWithChatApp
{
    public class UserController
    {
        public void GetTopOneUser()
        {
            int statusCode = 403;
            string statusMessage = "You are not authorized for this page";

            var ex = new Exception(string.Format("{0}-{1}", statusMessage, statusCode));
            ex.Data.Add(statusCode, statusMessage);

            throw ex;
        }
    }
}
