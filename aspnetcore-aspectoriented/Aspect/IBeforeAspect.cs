namespace aspnetcore_aspectoriented.Aspect
{
    public interface IBeforeAspect : IAspect
    {
        object OnBefore();
    }
}
