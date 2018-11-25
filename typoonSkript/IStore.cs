using System;
using System.Linq;
using System.Collections;
using System;
using System.Collections.Generic;
using Moq;
namespace Domain
{
    public interface IStore
    {
        void Save(int result);
    }
}