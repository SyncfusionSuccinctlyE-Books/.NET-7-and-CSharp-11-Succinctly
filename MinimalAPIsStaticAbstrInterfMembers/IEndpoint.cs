namespace MinimalAPIsStaticAbstrInterfMembers;
public interface IEndpoint
{
    static abstract string Pattern { get; }
    static abstract HttpMethod Method { get; }
    static abstract Delegate Handler { get; }
}
