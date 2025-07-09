using Banking.Domain;

namespace Banking.Tests.Account;

public class Demo
{
    [Fact]
    public void SomeDemo() 
    {
        var barbsAccount = new BankAccount();
        //BankAccount barbsAccount = new();

        var stansAccount = new BankAccount();

        Assert.Equal(barbsAccount.GetBalance(), stansAccount.GetBalance());

        stansAccount.Deposit(420.69M);

        Assert.NotEqual(barbsAccount.GetBalance(), stansAccount.GetBalance());
    }

    [Fact]
    public void SomeOtherDemo()
    {
        var myBirthday = new DateTime(1969, 4, 20);
        var barbsBirthday = new DateTime(1974, 4, 10);

        int myPay = 10;
    }
}
