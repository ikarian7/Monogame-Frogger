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
            

        }

        public override void Init()
        {
            base.Init();
            
        }

        public override void Update()
        {
            base.Update();
            position.X =+ velocity.X;

        }
    }
}
