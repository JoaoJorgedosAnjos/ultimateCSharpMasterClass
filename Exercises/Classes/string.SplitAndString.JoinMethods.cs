namespace Exercises.Classes;

public class StringSplitAndStringJoinMethods
{
    public static class StringsTransformator
    {
        public static string TransformSeparators(
            string input,
            string originalSeparator,
            string targetSeparator)
        {
            //your code goes here
            string[] palavrasSeparadas = input.Split($"{originalSeparator}");
            string result = string.Join($"{targetSeparator}", palavrasSeparadas);

            return result;
        }
    }
}
