using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001E5C RID: 7772
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(12, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 12)]
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_TransferAddAttr")]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 12)]
	public struct FKSC_TransferAddAttr : IEqualityOperators<FKSC_TransferAddAttr, FKSC_TransferAddAttr, bool>, IEquatable<FKSC_TransferAddAttr>, IUnrealScriptStruct
	{
		// Token: 0x0601D974 RID: 121204 RVA: 0x002BB061 File Offset: 0x002B9261
		public FKSC_TransferAddAttr(EKSC_AttrType FromAttr, int Threshold, float Amplify)
		{
			this.FromAttr = FromAttr;
			this.Threshold = Threshold;
			this.Amplify = Amplify;
		}

		// Token: 0x0601D975 RID: 121205 RVA: 0x002BB078 File Offset: 0x002B9278
		public static bool operator ==(FKSC_TransferAddAttr left, FKSC_TransferAddAttr right)
		{
			return left.FromAttr == right.FromAttr && left.Threshold == right.Threshold && left.Amplify == right.Amplify;
		}

		// Token: 0x0601D976 RID: 121206 RVA: 0x002BB0A6 File Offset: 0x002B92A6
		public static bool operator !=(FKSC_TransferAddAttr left, FKSC_TransferAddAttr right)
		{
			return !(left == right);
		}

		// Token: 0x0601D977 RID: 121207 RVA: 0x002BB0B2 File Offset: 0x002B92B2
		public bool Equals(FKSC_TransferAddAttr other)
		{
			return this == other;
		}

		// Token: 0x0601D978 RID: 121208 RVA: 0x002BB0C0 File Offset: 0x002B92C0
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			if (obj is FKSC_TransferAddAttr)
			{
				FKSC_TransferAddAttr other = (FKSC_TransferAddAttr)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x0601D979 RID: 121209 RVA: 0x002BB0E5 File Offset: 0x002B92E5
		public override int GetHashCode()
		{
			return HashCode.Combine<EKSC_AttrType, int, float>(this.FromAttr, this.Threshold, this.Amplify);
		}

		// Token: 0x0601D97A RID: 121210 RVA: 0x002BB0FE File Offset: 0x002B92FE
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKSC_TransferAddAttr._ScriptStructPtr != 0) ? FKSC_TransferAddAttr._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroSimpleCombat.KSC_TransferAddAttr", ref FKSC_TransferAddAttr._ScriptStructPtr);
		}

		// Token: 0x040100A6 RID: 65702
		[FieldOffset(0)]
		public EKSC_AttrType FromAttr;

		// Token: 0x040100A7 RID: 65703
		[FieldOffset(4)]
		public int Threshold;

		// Token: 0x040100A8 RID: 65704
		[FieldOffset(8)]
		public float Amplify;

		// Token: 0x040100A9 RID: 65705
		public const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_TransferAddAttr";

		// Token: 0x040100AA RID: 65706
		private static IntPtr _ScriptStructPtr;
	}
}
