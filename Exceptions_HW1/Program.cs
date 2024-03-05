namespace Exceptions_HW1;

class Program
{
    static void Main(string[] args)
    {
        string[][] data =
        [
            ["username", "password123", "password123"],
            ["user name", "password", "password"],
            ["username", "password123", "password1"]
        ];

        foreach (var dataRow in data)
        {
            try
            {
                string login = dataRow[0]; 
                string password = dataRow[1];
                string confirmPassword = dataRow[2];

                bool isValid = Validator.Validate(login, password, confirmPassword);
                Console.WriteLine("Validation Result: " + isValid);
            }
            catch (WrongLoginException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            catch (WrongPasswordException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}