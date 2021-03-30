﻿using System;
using System.Collections.Generic;
using System.Text;

namespace RtspClientSharp.Codecs.Video
{
    class H265CodecInfo : VideoCodecInfo
    {
        public byte[] VpsBytes { get; set; } = Array.Empty<byte>();

        public byte[] SpsBytes { get; set; } = Array.Empty<byte>();

        public byte[] PpsBytes { get; set; } = Array.Empty<byte>();
    }
}