namespace aspnetcore_aspectoriented.Aspect
{
    public interface IAfterVoidAspect : IAspect
    {
        void OnAfter(object value);
    }
}
