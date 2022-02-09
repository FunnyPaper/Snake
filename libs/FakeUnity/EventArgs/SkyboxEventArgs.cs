using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakeUnity.EventArgs
{
    public class SkyboxEventArgs : System.EventArgs
    {
        public Skybox.Skybox Skybox { get; }
        public SkyboxEventArgs(Skybox.Skybox skybox)
        {
            Skybox = skybox;
        }
    }
}
