using SiliconStudio.Xenko.Engine;

namespace PositionTransformTest
{
    class PositionTransformTestApp
    {
        static void Main(string[] args)
        {
            using (var game = new Game())
            {
                game.Run();
            }
        }
    }
}
