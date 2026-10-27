using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020002A0 RID: 672
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/AlembicLibrary.EAbcConversionPreset")]
	public enum EAbcConversionPreset : byte
	{
		// Token: 0x04000E30 RID: 3632
		Maya,
		// Token: 0x04000E31 RID: 3633
		Max,
		// Token: 0x04000E32 RID: 3634
		Custom,
		// Token: 0x04000E33 RID: 3635
		EAbcConversionPreset_MAX
	}
}
