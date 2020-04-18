using System.Collections.Generic;
using System.Linq;

namespace Iterator
{
    public class PhotoDateIterator : IIterator<Photo>
    {
        private readonly List<Photo> _photos;
        private int index;
        public PhotoDateIterator(List<Photo> photos)
        {
            _photos = photos;
        }
        public Photo Current()
        {
            return _photos.OrderByDescending(p => p.PhotoDateTimeStamp).ElementAt(index);
        }

        public bool HasNext()
        {
            return (index < _photos.Count);
        }

        public void Next()
        {
            index++;
        }
    }
}