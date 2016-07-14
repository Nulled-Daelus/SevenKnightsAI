namespace SevenKnightsAI.Classes
{
    internal class Scene
    {
        public Scene(SceneType sceneType)
        {
            this.SceneType = sceneType;
        }

        public SceneType SceneType
        {
            get;
            private set;
        }
    }
}