using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hazybits.Twain.Core.Constants
{
    public enum TwCP : short
    {
        None        = 0,
        Packbits    = 1,
        Group31D    = 2,
        Group31DEOL = 3,
        Group32D    = 4,
        Group4      = 5,
        Jpeg        = 6,
        Lzw         = 7,
        Jbig        = 8,
        Png         = 9,
        Rle4        = 10,
        Rle8        = 11,
        Bitfields   = 12
    }
}
