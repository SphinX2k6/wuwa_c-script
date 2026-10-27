using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200203E RID: 8254
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/LGUI.LGUIDrawableEventParameterType")]
	public enum LGUIDrawableEventParameterType : byte
	{
		// Token: 0x04010E4B RID: 69195
		None,
		// Token: 0x04010E4C RID: 69196
		Empty,
		// Token: 0x04010E4D RID: 69197
		Bool,
		// Token: 0x04010E4E RID: 69198
		Float,
		// Token: 0x04010E4F RID: 69199
		Double,
		// Token: 0x04010E50 RID: 69200
		Int8,
		// Token: 0x04010E51 RID: 69201
		UInt8,
		// Token: 0x04010E52 RID: 69202
		Int16,
		// Token: 0x04010E53 RID: 69203
		UInt16,
		// Token: 0x04010E54 RID: 69204
		Int32,
		// Token: 0x04010E55 RID: 69205
		UInt32,
		// Token: 0x04010E56 RID: 69206
		Int64,
		// Token: 0x04010E57 RID: 69207
		UInt64,
		// Token: 0x04010E58 RID: 69208
		Vector2,
		// Token: 0x04010E59 RID: 69209
		Vector3,
		// Token: 0x04010E5A RID: 69210
		Vector4,
		// Token: 0x04010E5B RID: 69211
		Color,
		// Token: 0x04010E5C RID: 69212
		LinearColor,
		// Token: 0x04010E5D RID: 69213
		Quaternion,
		// Token: 0x04010E5E RID: 69214
		String,
		// Token: 0x04010E5F RID: 69215
		Object,
		// Token: 0x04010E60 RID: 69216
		Actor,
		// Token: 0x04010E61 RID: 69217
		PointerEvent,
		// Token: 0x04010E62 RID: 69218
		Class,
		// Token: 0x04010E63 RID: 69219
		Rotator,
		// Token: 0x04010E64 RID: 69220
		LGUIDrawableEventParameterType_MAX
	}
}
