using MVP;

namespace Tetris
{
    public sealed class TetrisStartSceneModel : Model, ITetrisStartSceneModel
    {
        public TetrisStartSceneModel() { }

        public override void Initialize() 
        {
            SceneDataPack?.SetSceneComplete();
        }
    }

    public interface ITetrisStartSceneModel { }
}
