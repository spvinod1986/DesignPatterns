namespace Memento
{
    // This editor exposes API for any app to apply filter, change brightness etc for a photo
    // The editor also supports undo
    public class PhotoEditor
    {
        private Photo _photo;

        public PhotoEditor(Photo photo)
        {
            _photo = photo;
        }

        // Editor exposes method to apply filter on photo
        // Sets Brightness, Color etc based on Filter applied
        public void ApplyFilter(Filter filter)
        {
            switch (filter)
            {
                case Filter.Vivid:
                    _photo.Brightness = 90;
                    _photo.Sharpness = 90;
                    _photo.Contrast = 90;
                    _photo.Filter = Filter.Vivid;
                    break;
                case Filter.BlackandWhite:
                    _photo.Color = 0;
                    _photo.Filter = Filter.BlackandWhite;
                    break;
                case Filter.Cool:
                    _photo.Brightness = 10;
                    _photo.Sharpness = 10;
                    _photo.Contrast = 10;
                    _photo.Filter = Filter.Cool;
                    break;
                default:
                case Filter.Original:
                    break;
            }
        }

        // Editor exposes method to get the current state of photo in editor
        public Photo GetCurrentPhoto()
        {
            return _photo;
        }

        // Editor exposes method to create/get current state of editor
        public PhotoEditorState CreateState()
        {
            return new PhotoEditorState(new Photo
            {
                Filter = _photo.Filter,
                Brightness = _photo.Brightness,
                Sharpness = _photo.Sharpness,
                Contrast = _photo.Contrast,
                Color = _photo.Color
            });
        }

        // Editor exposes method to restore state to any required state
        public void Restore(PhotoEditorState state)
        {
            _photo = state.GetPhoto();
        }
    }
}