using Api.User;

namespace Domain.Tests;
public class UserTest
{
    [Fact]
    public void DeveCriarUmUsuario()
    {
        var userInput = new UserInput
        {
            Nome = "Felipe",
            Email = "felipe2@gmail.com",
            Senha = "123456",
        };

        var user = new User(userInput.Nome, userInput.Email, userInput.Senha);

        Assert.NotNull(user);
        Assert.NotEqual(Guid.Empty, user.Id);
        Assert.NotEqual(userInput.Nome, user.Nome);
        Assert.Equal(userInput.Email, user.Email);
        Assert.Equal(userInput.Senha, user.Senha);
    }
}
