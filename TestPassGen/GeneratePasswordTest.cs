using PasswordGenerateLib;

namespace TestPassGen;

public class GeneratePasswordTest
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void GenerateNumberPassTest([Random(0, 100, 5)] int numberRandom)
    {
        PasswordBase passwordBase = new NumbersPassword();
        string pass = passwordBase.Generate((uint)numberRandom);

        Assert.That(pass.Length == numberRandom);

        Assert.That(CheckSubSet(passwordBase.ToString().ToCharArray(), pass.ToCharArray()));

        Assert.Pass();
    }

    [Test]
    public void GenerateSymbolsPassTest([Random(0, 100, 5)] int numberRandom)
    {
        PasswordBase passwordBase = new SymbolsPassword();
        string pass = passwordBase.Generate((uint)numberRandom);

        Assert.That(pass.Length == numberRandom);

        bool isSubSet = CheckSubSet(passwordBase.ToString().ToCharArray(), pass.ToCharArray());
        Assert.That(isSubSet);

        Assert.Pass();
    }

    [Test]
    public void GenerateSpecialSymbolsPassTest([Random(0, 100, 5)] int numberRandom)
    {
        PasswordBase passwordBase = new SpecialPassword();
        string pass = passwordBase.Generate((uint)numberRandom);

        Assert.That(pass.Length == numberRandom);

        bool isSubSet = CheckSubSet(passwordBase.ToString().ToCharArray(), pass.ToCharArray());
        Assert.That(isSubSet);

        Assert.Pass();
    }

    private bool CheckSubSet(char[] superSet, char[] subSet)
    {
        var hashSuperSet = new HashSet<char>(superSet);
        bool result = subSet.All(item => hashSuperSet.Contains(item));

        return result;
    }
    
}
