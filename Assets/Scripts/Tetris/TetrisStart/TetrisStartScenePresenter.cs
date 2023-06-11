using MVP;
using VContainer;

namespace Tetris
{
    public sealed class TetrisStartScenePresenter : Presenter<TetrisStartSceneModel, TetrisStartSceneView>
    {
        public TetrisStartScenePresenter(TetrisStartSceneModel model, TetrisStartSceneView view, IObjectResolver container) :
            base(model, view, container)
        {
        }

        protected override void Initialize() { }
    }
}
