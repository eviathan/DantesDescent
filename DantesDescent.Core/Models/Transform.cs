using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Threading.Tasks;

namespace DantesDescent.Core.Models
{
    public class Transform
    {
        public Vector2 Position { get; set; } = Vector2.Zero;
        public float Rotation { get; set; }
        public Vector2 Scale { get; set; } = Vector2.One;
    }
}