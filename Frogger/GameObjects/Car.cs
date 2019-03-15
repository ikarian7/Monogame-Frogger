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

    class Car : GameObject
    {
        public Car(String assetName, Vector2 position, Vector2 velocity) : base(assetName)
        {
            this.position = position;
            this.velocity = velocity;


        }

        public override void Init()
        {
            base.Init();
            
        }

        public override void Update()
        {
            base.Update();
            position.X += velocity.X;
            if (position.X > GameEnvironment.Screen.X && velocity.X > 0){
                position.X = -10 - texture.Width;
            }
            else if (position.X + texture.Width < 0 && velocity.X < 0) {
                position.X = 10 + GameEnvironment.Screen.X;
            }

        }
    }
}
