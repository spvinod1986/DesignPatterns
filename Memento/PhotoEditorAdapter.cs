namespace Memento
{
    // An adapter which apps(for example - instagram) uses to connect to our PhotoEditor API
    public class PhotoEditorAdapter
    {
        private PhotoEditor _editor;
        private PhotoEditorStateHistory _history;

        // Instantiate editor and history with every photo
        public PhotoEditorAdapter(Photo photo)
        {
            _editor = new PhotoEditor(photo);
            _history = new PhotoEditorStateHistory();
        }

        // When the user tries to change/edit anything, save the current state of editor to support undo 
        public Photo ChangeFilter(Filter filter)
        {
            _history.Push(_editor.CreateState());
            _editor.ApplyFilter(filter);
            return _editor.GetCurrentPhoto();
        }

        // When the user tries to undo, pop the history and give back the saved state
        public Photo Undo()
        {
            _editor.Restore(_history.Pop());
            return _editor.GetCurrentPhoto();
        }
    }
}