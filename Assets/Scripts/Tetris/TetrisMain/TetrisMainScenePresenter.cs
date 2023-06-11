using MVP;
using VContainer;

namespace Tetris
{
    public sealed class TetrisMainScenePresenter : Presenter<TetrisMainSceneModel, TetrisMainSceneView>
    {
        public TetrisMainScenePresenter(TetrisMainSceneModel model, TetrisMainSceneView view, IObjectResolver container) :
            base(model, view, container)
        {
        }

        protected override void Initialize()
        {
            Model.ShowField = View.ShowField;
        }
    }
}
