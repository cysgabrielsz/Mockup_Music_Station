using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mockup_Music_Station
{
    public class TelaBase : UserControl
    {
        public int NivelAcesso { get; set; }
        public Action<TelaBase> SolicitarAbertura { get; set; }

    }
}
