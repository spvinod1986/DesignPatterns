namespace Memento
{
    public class PhotoEditorState
    {
        private readonly Photo _photo;
        public PhotoEditorState(Photo photo)
        {
            _photo = photo;
        }

        public Photo GetPhoto()
        {
            return _photo;
        }
    }
}