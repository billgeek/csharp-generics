namespace Test
{
    public interface ITestInterface {
        TReturn DoSomething<TSource, TReturn>(TSource mySourceData) where TReturn : class;
    }
}