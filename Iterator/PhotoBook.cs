using System;
using System.Collections.Generic;

namespace Iterator
{
    public class PhotoBook
    {
        private List<Photo> _photos = new List<Photo>();

        public void Push(Photo photo)
        {
            _photos.Add(photo);
        }
        public IIterator<Photo> GetIterator(bool iterateBySize)
        {
            if (iterateBySize)
                return new PhotoSizeIterator(_photos);
            else
                return new PhotoDateIterator(_photos);
        }
    }
}