namespace WebApiApp.Controllers
{
    public static class GetConnectionStringClass
    {
        public static string GetConnectionString()
        {
            using (FileStream stream = File.OpenRead("ConnectionString.txt"))
            {
                byte[] array = new byte[stream.Length];
                stream.Read(array, 0, array.Length);
                return System.Text.Encoding.Default.GetString(array);
            }
        }
    }
}
