using VContainer;
using MVP;

namespace Tetris
{
    public sealed class TetrisStartSceneLifeTimeScope : MVPLifetimeScope<TetrisStartScenePresenter, TetrisStartSceneModel, TetrisStartSceneView>
    {
        protected override void Configure(IContainerBuilder builder)
        {
            base.Configure(builder);
        }
    }
}
