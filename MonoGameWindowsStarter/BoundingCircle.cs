using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonoGameWindowsStarter
{
    public struct BoundingCircle
    {

        public float X;

        public float Y;

        public float Radius;
        public Vector2 Center => new Vector2(X,Y);


    }
}
