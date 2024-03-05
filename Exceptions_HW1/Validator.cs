namespace Exceptions_HW1;

public static class Validator
{
    public static bool Validate(string login, string password, string confirmPassword)
    {
        // Проверка login
        if (login.Length >= 20 || login.Contains(" "))
        {
            throw new WrongLoginException("Login must be less than 20 characters and should not contain spaces.");
        }

        // Проверка password
        if (password.Length >= 20 || password.Contains(" ") || !ContainsDigit(password) || password != confirmPassword)
        {
            throw new WrongPasswordException(
                "Password must be less than 20 characters, should not contain spaces, should contain at least one digit, and should match confirmPassword.");
        }

        return true;
    }

    private static bool ContainsDigit(string input)
    {
        foreach (char c in input)
        {
            if (char.IsDigit(c))
            {
                return true;
            }
        }

        return false;
    }
}