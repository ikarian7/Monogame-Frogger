using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace Frogger
{
    class PlayingState : GameState
    {
        public PlayingState()
        {
            gameObjectList.Add(new GameObject("spr_background"));
            gameObjectList.Add(new Frog());
            gameObjectList.Add(new Car("spr_truck", new Vector2(70, 225), new Vector2(-2, 0)));
            gameObjectList.Add(new Car("spr_truck", new Vector2(220, 225), new Vector2(-2, 0)));
            gameObjectList.Add(new Car("spr_truck", new Vector2(370, 225), new Vector2(-2, 0)));

        }
    }
}
