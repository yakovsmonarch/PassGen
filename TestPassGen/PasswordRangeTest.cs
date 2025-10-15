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

        PasswordBase specialPass = new SpecialPassword();
        _ranges.Add(specialPass.ToString());


        
        _passwordBase = new NumbersPassword(symbolsPass, specialPass);
    }

    [Test]
    public void CheckSymblsTest()
    {
        string password = _passwordBase.Generate((uint)_ranges.Count);
        foreach (string rang in _ranges)
        {
            bool presence = false;
            foreach (char ch in password)
            {
                if (rang.Contains(ch))
                {
                    presence = true;
                    break;
                }
            }
            Assert.That(presence);
        }
        Assert.Pass();
    }
}
