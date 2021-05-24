namespace DesignPatternsInCSharp.Iterator
{
    public interface IIterator<T>
    {
        bool HasNext();
        T GetCurrent();
        void Next();
    }
}
