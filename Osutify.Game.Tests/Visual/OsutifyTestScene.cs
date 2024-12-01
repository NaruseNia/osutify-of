using osu.Framework.Testing;

namespace Osutify.Game.Tests.Visual
{
    public abstract partial class OsutifyTestScene : TestScene
    {
        protected override ITestSceneTestRunner CreateRunner() => new OsutifyTestSceneTestRunner();

        private partial class OsutifyTestSceneTestRunner : OsutifyGameBase, ITestSceneTestRunner
        {
            private TestSceneTestRunner.TestRunner runner;

            protected override void LoadAsyncComplete()
            {
                base.LoadAsyncComplete();
                Add(runner = new TestSceneTestRunner.TestRunner());
            }

            public void RunTestBlocking(TestScene test) => runner.RunTestBlocking(test);
        }
    }
}
