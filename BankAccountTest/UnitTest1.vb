Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports BankAcounts
<TestClass()> Public Class UnitTest1

    <TestMethod()> Public Sub TestContructors1()


        Dim AccounterHolder As String = "Ms I. N. Cognito"
        Dim AccounterNumber As String = "ABCD 890111 11167890"
        Dim InterestRate As Double = "4.3"
        Dim Balance As Double = 10343.82
        Dim country As String = "Isle of man"

        Dim Account1 As New BankAccounts.BankAccount(AccounterHolder, AccounterNumber, Balance, InterestRate, country)
        Dim Account2 As New BankAccounts.BankAccount(AccounterHolder, AccounterNumber, Balance, InterestRate)
        Dim account3 As New BankAccounts.BankAccount(AccounterHolder, AccounterNumber, Balance)

        Assert.IsNotNull(Account1)
        Assert.IsNotNull(Account2)
        Assert.IsNotNull(account3)
    End Sub

End Class
