using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Singleton.Dependency_Injection
{
    public class Release : IDisposable
    {
        private readonly Action release;

        public Release(Action releaseAction)
        {
            release = releaseAction;
        }

        public void Dispose()
        {
            release();
        }
    }
}