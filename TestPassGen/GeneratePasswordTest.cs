using System.Numerics;
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

        Assert.That(BigInteger.TryParse(pass, out BigInteger numPass));

        
        Assert.Pass();
    }
}
