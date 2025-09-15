using PasswordGenerateLib;

PasswordBase passGen = new NumbersPassword();
passGen = new SymbolsPassword(passGen);
passGen = new SpecialPassword(passGen);

Console.WriteLine(passGen.Generate(15));
