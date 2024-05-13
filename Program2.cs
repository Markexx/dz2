using dz2___2._zadatak;
class Program
{
    static void Main(string[] args)
    {
        LoginPageFactory factory = new ChromeLoginPageFactory();
        LoginPage page = factory.CreatePage();

        WebElement loginButton = page.loginButton();
        WebElement usernameInput = page.usernameInput();
        WebElement passwordInput = page.passwordInput();

        loginButton.Click();
        usernameInput.Click();
        passwordInput.Click();
    }
}
