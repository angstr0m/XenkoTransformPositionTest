namespace PositionTransformTest
{
    using SiliconStudio.Core.Mathematics;
    using SiliconStudio.Xenko.Engine;
    public class TransformTestAlternate : SyncScript
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
                                this.Entity.Transform.LocalMatrix);

            this.Entity.Transform.Position = localPos;
        }
    }
}