namespace aspnetcore_aspectoriented.Aspect
{
    public interface IAfterAspect : IAspect
    {
        object OnAfter(object value);
    }
}
