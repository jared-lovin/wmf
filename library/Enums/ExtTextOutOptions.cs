﻿using System;

namespace Oxage.Wmf
{
	public enum ExtTextOutOptions
	{
		ETO_OPAQUE = 0x0002,
		ETO_CLIPPED = 0x0004,
		ETO_GLYPH_INDEX = 0x0010,
		ETO_RTLREADING = 0x0080,
		ETO_NUMERICSLOCAL = 0x0400,
		ETO_NUMERICSLATIN = 0x0800,
		ETO_IGNORELANGUAGE = 0x1000,
		ETO_PDY = 0x2000
	}
}
