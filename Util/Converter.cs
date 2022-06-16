﻿using QRCoder;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace AMQA.QrCode.Util;
public class Converter : IConverter
{
    public async Task<byte[]> ConvertImageToByte(string id)
    {
        string baseAddress = $"{id}";
        QRCodeGenerator qr = new();
        QRCodeData codeData = qr.CreateQrCode(baseAddress, QRCodeGenerator.ECCLevel.Q);
        PngByteQRCode qrCode = new(codeData);
        byte[] qrCodeAsBitmapByteArr = qrCode.GetGraphic(20);
        using var ms = new MemoryStream(qrCodeAsBitmapByteArr);
        return await Task.FromResult(ms.ToArray());
    }
}
