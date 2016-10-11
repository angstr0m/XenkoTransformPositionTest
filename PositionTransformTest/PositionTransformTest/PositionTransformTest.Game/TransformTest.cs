namespace PositionTransformTest
{
    using SiliconStudio.Core.Mathematics;
    using SiliconStudio.Xenko.Engine;
    public class TransformTest : SyncScript
    {
        public override void Update()
        {
            // Local to World
            var worldPos = Vector3.TransformCoordinate(
                                this.Entity.Transform.Position,
                                this.Entity.Transform.WorldMatrix);

            // World to Local
            var localPos = Vector3.TransformCoordinate(
                                worldPos,
                                Matrix.Invert(this.Entity.Transform.WorldMatrix));

            this.Entity.Transform.Position = localPos;
        }
    }
}