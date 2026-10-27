using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200148F RID: 5263
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/HoudiniEngineRuntime.EHoudiniParameterType")]
	public enum EHoudiniParameterType : byte
	{
		// Token: 0x0400A4A7 RID: 42151
		Invalid,
		// Token: 0x0400A4A8 RID: 42152
		Button,
		// Token: 0x0400A4A9 RID: 42153
		ButtonStrip,
		// Token: 0x0400A4AA RID: 42154
		Color,
		// Token: 0x0400A4AB RID: 42155
		ColorRamp,
		// Token: 0x0400A4AC RID: 42156
		File,
		// Token: 0x0400A4AD RID: 42157
		FileDir,
		// Token: 0x0400A4AE RID: 42158
		FileGeo,
		// Token: 0x0400A4AF RID: 42159
		FileImage,
		// Token: 0x0400A4B0 RID: 42160
		Float,
		// Token: 0x0400A4B1 RID: 42161
		FloatRamp,
		// Token: 0x0400A4B2 RID: 42162
		Folder,
		// Token: 0x0400A4B3 RID: 42163
		FolderList,
		// Token: 0x0400A4B4 RID: 42164
		Input,
		// Token: 0x0400A4B5 RID: 42165
		Int,
		// Token: 0x0400A4B6 RID: 42166
		IntChoice,
		// Token: 0x0400A4B7 RID: 42167
		Label,
		// Token: 0x0400A4B8 RID: 42168
		MultiParm,
		// Token: 0x0400A4B9 RID: 42169
		Separator,
		// Token: 0x0400A4BA RID: 42170
		String,
		// Token: 0x0400A4BB RID: 42171
		StringChoice,
		// Token: 0x0400A4BC RID: 42172
		StringAssetRef,
		// Token: 0x0400A4BD RID: 42173
		Toggle,
		// Token: 0x0400A4BE RID: 42174
		EHoudiniParameterType_MAX
	}
}
