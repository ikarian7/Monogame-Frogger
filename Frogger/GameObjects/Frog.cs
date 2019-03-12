using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Frogger
{
    
    class Frog : GameObject
    {
        int posPlus = 40;

         bool leftPressed, lastFrameLeftPressed,
            rightPressed, lastFrameRightPressed,
            upPressed, lastFrameUpPressed,
            downPressed, lastFrameDownPressed;



        public Frog() : base("spr_frog")
        {

        }

        public override void Init()
        {
            base.Init();
            position.X = GameEnvironment.Screen.X/2 - this.texture.Width / 2;
            position.Y = GameEnvironment.Screen.Y - this.texture.Height;
        }

        public override void Update()
        {
            base.Update();

            lastFrameDownPressed = downPressed;
            lastFrameLeftPressed = leftPressed;
            lastFrameRightPressed = rightPressed;
            lastFrameUpPressed = upPressed;

            downPressed = GameEnvironment.KeyboardState.IsKeyDown(Keys.Down);
            upPressed = GameEnvironment.KeyboardState.IsKeyDown(Keys.Up);
            leftPressed = GameEnvironment.KeyboardState.IsKeyDown(Keys.Left);
            rightPressed = GameEnvironment.KeyboardState.IsKeyDown(Keys.Right);

            if (downPressed && !lastFrameDownPressed) position.Y += posPlus;
            if (leftPressed && !lastFrameLeftPressed) position.X -= posPlus;
            if (rightPressed && !lastFrameRightPressed) position.X += posPlus;
            if (upPressed && !lastFrameUpPressed) position.Y -= posPlus;

        }
    }
}
