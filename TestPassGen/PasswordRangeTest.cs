using PasswordGenerateLib;

namespace TestPassGen;

public class PasswordRangeTest : BaseTest
{
    private PasswordBase _passwordBase;

    private List<string> _ranges = new List<string>();

    [SetUp]
    public void Setup()
    {
        PasswordBase numberPass = new NumbersPassword();
        _ranges.Add(numberPass.ToString());

        PasswordBase symbolsPass = new SymbolsPassword();
        _ranges.Add(symbolsPass.ToString());

        PasswordBase specialPass = new NumbersPassword();
        _ranges.Add(specialPass.ToString());


        
        _passwordBase = new NumbersPassword(symbolsPass, specialPass);
    }

    [Test]
    public void CheckSymblsTest()
    {
        string password = _passwordBase.Generate((uint)_ranges.Count);
        foreach (string item in _ranges)
        {
            bool result = CheckSubSet(item.ToCharArray(), password.ToCharArray());
            Assert.That(result);
        }
        Assert.Pass();
    }
}
