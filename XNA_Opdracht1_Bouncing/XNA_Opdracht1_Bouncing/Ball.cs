using Microsoft.Xna.Framework;

namespace Opdracht1_Bouncing {
    internal class Ball : SpriteGameObject {
        private float radius;

        // step 4: Declare variable for the acceleration
        // step 6: Declare variable for the gravity
        // step 8: Declare variable for inelastic behaviour

        public Ball(string assetName, Vector2 position, Vector2 velocity, float radius)
            : base(assetName, 0, "ball") {
            this.position = position;
            this.velocity = velocity;
            origin = new Vector2(Width / 2f, Height / 2f);
            this.radius = radius;
            scale = radius * 2 / Width;
        }

        public override void Update(GameTime gameTime) {
            // step 3: Implement Ball bouncing behaviour
            if (this.position.X + radius >= BouncingGameWorld.Screen.X || this.position.X - radius <= 0)
            {
                this.velocity.X *= -1;
            }
            if (this.position.Y + radius >= BouncingGameWorld.Screen.Y || this.position.Y - radius <= 0)
            {
                this.velocity.Y *= -1;
            }
            // step 5: Implement acceleration behaviour
            // step 7: Implement gravity behaviour
            // step 9: Implement inelastic behaviour

            base.Update(gameTime);
        }
    }
}