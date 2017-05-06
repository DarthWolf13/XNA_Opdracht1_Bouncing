using Microsoft.Xna.Framework;
using System;

namespace Opdracht1_Bouncing {
    internal class PlayState : GameObjectList {

        //private GameObjectList balls;
        Vector2 posRed, posPink, posPurple, redVelocity, pinkVelocity, purpleVelocity;
        Vector2 acceleration = new Vector2(100, 0);
        float gravity = 5f;
        float friction = 0.999f;
        Ball redBall, pinkBall, purpleBall;

        public PlayState() {
            ///////////
            // Example:
            // randomize the starting position and velocity
            /*var position = new Vector2(GameEnvironment.Random.Next(100, GameEnvironment.Screen.X - 100),
                GameEnvironment.Random.Next(100, GameEnvironment.Screen.Y - 100));
            var velocity = new Vector2(GameEnvironment.Random.Next(-150, 150),
                GameEnvironment.Random.Next(-150, 150));*/
            velocity = Vector2.Zero;

            //Startpositions
            posRed = new Vector2(100, BouncingGameWorld.Screen.Y/2);
            posPink = new Vector2(100, BouncingGameWorld.Screen.Y - 100);
            posPurple = new Vector2(BouncingGameWorld.Screen.X/2, 100);

            // step 2: Give them the correct velocity
            //start velocities
            redVelocity = velocity; 
            pinkVelocity = new Vector2(100, -100);
            purpleVelocity = new Vector2(0, 100);

            // Instantiate a new ball                     
            // step 1: Initialize three balls on the correct position
            //balls = new GameObjectList();
            redBall = new Ball("RedBallX", posRed, redVelocity, 30f);
            pinkBall = new Ball("PinkSoftColorBall", posPink, pinkVelocity, 30f);
            purpleBall = new Ball("PurpleSoftColorBall", posPurple, purpleVelocity, 30f);

            this.Add(redBall);
            this.Add(pinkBall);
            this.Add(purpleBall);

            /*Add(balls);
            // Add the instance of the ball to this GameObjectList
            this.balls.Add(new Ball("RedBallX", posRed, redVelocity, 30f));
            this.balls.Add(new Ball("PinkSoftColorBall", posPink, pinkVelocity, 30f));
            this.balls.Add(new Ball("PurpleSoftColorBall", posPurple, purpleVelocity, 30f));*/



            ///////////



            // step 10: randomize the position and starting velocity
        }

        public override void Update(GameTime gameTime) {
            base.Update(gameTime);

            redBall.Velocity += acceleration;
            pinkBall.Velocity = new Vector2(pinkBall.Velocity.X, pinkBall.Velocity.Y + gravity);
            purpleBall.Velocity = new Vector2(purpleBall.Velocity.X, (purpleBall.Velocity.Y + gravity) * friction);
        }
    }
}