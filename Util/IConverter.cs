using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AMQA.QrCode.Util;

public interface IConverter
{
    public Task<byte[]> ConvertImageToByte(string id);
}
