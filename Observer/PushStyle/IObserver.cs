namespace DesignPatternsInCSharp.Observer.PushStyle
{
    public interface IObserver
    {
        void Update<T>(T val);
    }
}
