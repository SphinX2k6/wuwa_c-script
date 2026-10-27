using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200275C RID: 10076
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Sharphereal.ESharpherealReflectionTypeCode")]
	public enum ESharpherealReflectionTypeCode : byte
	{
		// Token: 0x04014800 RID: 83968
		Unsupported,
		// Token: 0x04014801 RID: 83969
		T_Bool,
		// Token: 0x04014802 RID: 83970
		T_Sbyte,
		// Token: 0x04014803 RID: 83971
		T_Byte,
		// Token: 0x04014804 RID: 83972
		T_Short,
		// Token: 0x04014805 RID: 83973
		T_UShort,
		// Token: 0x04014806 RID: 83974
		T_Int,
		// Token: 0x04014807 RID: 83975
		T_UInt,
		// Token: 0x04014808 RID: 83976
		T_Long,
		// Token: 0x04014809 RID: 83977
		T_ULong,
		// Token: 0x0401480A RID: 83978
		T_Float,
		// Token: 0x0401480B RID: 83979
		T_Double,
		// Token: 0x0401480C RID: 83980
		T_Enum,
		// Token: 0x0401480D RID: 83981
		T_EnumAsByte,
		// Token: 0x0401480E RID: 83982
		T_String,
		// Token: 0x0401480F RID: 83983
		T_Name,
		// Token: 0x04014810 RID: 83984
		T_Text,
		// Token: 0x04014811 RID: 83985
		T_Struct,
		// Token: 0x04014812 RID: 83986
		T_UObject,
		// Token: 0x04014813 RID: 83987
		T_WeakObject,
		// Token: 0x04014814 RID: 83988
		T_SoftObject,
		// Token: 0x04014815 RID: 83989
		T_LazyObject,
		// Token: 0x04014816 RID: 83990
		T_Class,
		// Token: 0x04014817 RID: 83991
		T_SoftClass,
		// Token: 0x04014818 RID: 83992
		T_Interface,
		// Token: 0x04014819 RID: 83993
		T_Array,
		// Token: 0x0401481A RID: 83994
		T_Set,
		// Token: 0x0401481B RID: 83995
		T_Map,
		// Token: 0x0401481C RID: 83996
		T_Delegate,
		// Token: 0x0401481D RID: 83997
		T_MulticastInlineDelegate,
		// Token: 0x0401481E RID: 83998
		T_MulticastSparseDelegate,
		// Token: 0x0401481F RID: 83999
		ESharpherealReflectionTypeCode_MAX
	}
}
