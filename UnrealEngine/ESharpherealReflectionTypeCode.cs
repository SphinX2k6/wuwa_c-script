using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200080A RID: 2058
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Sharphereal.ESharpherealReflectionTypeCode")]
	public enum ESharpherealReflectionTypeCode : byte
	{
		// Token: 0x040051A2 RID: 20898
		Unsupported,
		// Token: 0x040051A3 RID: 20899
		T_Bool,
		// Token: 0x040051A4 RID: 20900
		T_Sbyte,
		// Token: 0x040051A5 RID: 20901
		T_Byte,
		// Token: 0x040051A6 RID: 20902
		T_Short,
		// Token: 0x040051A7 RID: 20903
		T_UShort,
		// Token: 0x040051A8 RID: 20904
		T_Int,
		// Token: 0x040051A9 RID: 20905
		T_UInt,
		// Token: 0x040051AA RID: 20906
		T_Long,
		// Token: 0x040051AB RID: 20907
		T_ULong,
		// Token: 0x040051AC RID: 20908
		T_Float,
		// Token: 0x040051AD RID: 20909
		T_Double,
		// Token: 0x040051AE RID: 20910
		T_Enum,
		// Token: 0x040051AF RID: 20911
		T_EnumAsByte,
		// Token: 0x040051B0 RID: 20912
		T_String,
		// Token: 0x040051B1 RID: 20913
		T_Name,
		// Token: 0x040051B2 RID: 20914
		T_Text,
		// Token: 0x040051B3 RID: 20915
		T_Struct,
		// Token: 0x040051B4 RID: 20916
		T_UObject,
		// Token: 0x040051B5 RID: 20917
		T_WeakObject,
		// Token: 0x040051B6 RID: 20918
		T_SoftObject,
		// Token: 0x040051B7 RID: 20919
		T_LazyObject,
		// Token: 0x040051B8 RID: 20920
		T_Class,
		// Token: 0x040051B9 RID: 20921
		T_SoftClass,
		// Token: 0x040051BA RID: 20922
		T_Interface,
		// Token: 0x040051BB RID: 20923
		T_Array,
		// Token: 0x040051BC RID: 20924
		T_Set,
		// Token: 0x040051BD RID: 20925
		T_Map,
		// Token: 0x040051BE RID: 20926
		T_Delegate,
		// Token: 0x040051BF RID: 20927
		T_MulticastInlineDelegate,
		// Token: 0x040051C0 RID: 20928
		T_MulticastSparseDelegate,
		// Token: 0x040051C1 RID: 20929
		ESharpherealReflectionTypeCode_MAX
	}
}
