namespace WebAPI.Services.Lab05
{
    public class SomeClass
    {
        public string Print (string tekst)
        {
            try
            {
                return tekst.Length.ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw new InvalidDepartmentException("Custom exception");
            }
        }
    }
}
