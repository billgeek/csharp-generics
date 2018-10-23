namespace Test
{
    public class TestClass : ITestInterface {
        public TReturn DoSomething<TSource, TReturn>(TSource mySourceData) where TReturn : class {
            return $"Hello there, {mySourceData}" as TReturn;
        }
    }
}