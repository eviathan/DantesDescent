using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DantesDescent.Core.Interfaces
{
    public interface IRenderer<TRenderingContext>
    {
        event Action<IRenderingContext> Start;

        event Action<IRenderingContext> Update;
    }
}