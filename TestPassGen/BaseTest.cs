namespace TestPassGen;

public abstract class BaseTest
{
    protected bool CheckSubSet(char[] superSet, char[] subSet)
    {
        var hashSuperSet = new HashSet<char>(superSet);
        bool result = subSet.All(item => hashSuperSet.Contains(item));

        return result;
    }
}
