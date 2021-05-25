namespace DesignPatternsInCSharp.Strategy
{
    public interface IFilter
    {
        void Apply(string filename);
    }
}