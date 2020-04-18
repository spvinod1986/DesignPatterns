using System.Collections.Generic;
using System.Linq;

namespace Iterator
{
    public class PhotoSizeIterator : IIterator<Photo>
    {
        private readonly List<Photo> _photos;
        private int index;
        public PhotoSizeIterator(List<Photo> photos)
        {
            _photos = photos;
        }
        public Photo Current()
        {
            return _photos.OrderByDescending(p => p.PhotoSizeInKb).ElementAt(index);
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