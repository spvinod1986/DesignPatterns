using System.Collections.Generic;
using System.Linq;

namespace Memento
{
    // This class saves the history of states in stack
    // Push and Pop as required
    public class PhotoEditorStateHistory
    {
        private Stack<PhotoEditorState> photoEditorStates = new Stack<PhotoEditorState>();

        public void Push(PhotoEditorState state)
        {
            photoEditorStates.Push(state);
        }

        public PhotoEditorState Pop()
        {
            if (photoEditorStates.Any())
                return photoEditorStates.Pop();

            return null;
        }
    }
}