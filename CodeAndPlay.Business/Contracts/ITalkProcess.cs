using CodeAndPlay.Commons.Entities;
using System.Collections.Generic;

namespace CodeAndPlay.Business.Contracts
{
    public interface ITalkProcess
    {
        IEnumerable<Talk> Get();
    }
}
