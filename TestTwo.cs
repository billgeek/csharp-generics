namespace Test
{
    public class TestTwo : ITestInterface {
        public TReturn DoSomething<TSource, TReturn>(TSource mySourceData) where TReturn : class {
            var sourceValue = mySourceData as string;
            return sourceValue.ToCharArray() as TReturn;
        }
    }
}