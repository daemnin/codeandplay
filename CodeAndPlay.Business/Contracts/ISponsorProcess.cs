using CodeAndPlay.Commons.Entities;
using System.Collections.Generic;

namespace CodeAndPlay.Business.Contracts
{
    public interface ISponsorProcess
    {
        IEnumerable<Sponsor> Get();
    }
}
