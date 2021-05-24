using System.Collections.Generic;

namespace DesignPatternsInCSharp.Iterator
{
    public class BrowseHistory
    {
        private readonly List<string> urls = new();

        public void Push(string url)
        {
            urls.Add(url);
        }

        public IIterator<string> CreateIterator()
        {
            return new ListIterator(this);
        }

        public class ListIterator : IIterator<string>
        {
            private readonly BrowseHistory browseHistory;
            private int index;

            public ListIterator(BrowseHistory browseHistory)
            {
                this.browseHistory = browseHistory;
            }

            public string GetCurrent()
            {
                return browseHistory.urls[index];
            }

            public bool HasNext()
            {
                return index < browseHistory.urls.Count;
            }

            public void Next()
            {
                index++;
            }
        }

    }
}
