using PasswordGenerateLib;

PasswordBase passObj = new NumbersPassword();
passObj = new SymbolsPassword(passObj);
passObj = new SpecialPassword(passObj);

string password = passObj.Generate(100);

Console.WriteLine(password);