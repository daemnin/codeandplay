﻿using CodeAndPlay.Commons.Entities;
using System.Collections.Generic;

namespace CodeAndPlay.Business.Contracts
{
    public interface IOrganizerProcess
    {
        IEnumerable<Organizer> Get();
    }
}