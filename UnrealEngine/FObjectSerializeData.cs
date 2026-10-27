using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002654 RID: 9812
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(12, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 12)]
	[UnrealObjectPath("/Script/PrefabSystem.ObjectSerializeData")]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 12)]
	public struct FObjectSerializeData : IEqualityOperators<FObjectSerializeData, FObjectSerializeData, bool>, IEquatable<FObjectSerializeData>, IUnrealScriptStruct
	{
		// Token: 0x0602477C RID: 149372 RVA: 0x0035FACA File Offset: 0x0035DCCA
		public FObjectSerializeData(int FileID, uint ObjectFlags, int ClassIndex)
		{
			this.FileID = FileID;
			this.ObjectFlags = ObjectFlags;
			this.ClassIndex = ClassIndex;
		}

		// Token: 0x0602477D RID: 149373 RVA: 0x0035FAE1 File Offset: 0x0035DCE1
		public static bool operator ==(FObjectSerializeData left, FObjectSerializeData right)
		{
			return left.FileID == right.FileID && left.ObjectFlags == right.ObjectFlags && left.ClassIndex == right.ClassIndex;
		}

		// Token: 0x0602477E RID: 149374 RVA: 0x0035FB0F File Offset: 0x0035DD0F
		public static bool operator !=(FObjectSerializeData left, FObjectSerializeData right)
		{
			return !(left == right);
		}

		// Token: 0x0602477F RID: 149375 RVA: 0x0035FB1B File Offset: 0x0035DD1B
		public bool Equals(FObjectSerializeData other)
		{
			return this == other;
		}

		// Token: 0x06024780 RID: 149376 RVA: 0x0035FB2C File Offset: 0x0035DD2C
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			if (obj is FObjectSerializeData)
			{
				FObjectSerializeData other = (FObjectSerializeData)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x06024781 RID: 149377 RVA: 0x0035FB51 File Offset: 0x0035DD51
		public override int GetHashCode()
		{
			return HashCode.Combine<int, uint, int>(this.FileID, this.ObjectFlags, this.ClassIndex);
		}

		// Token: 0x06024782 RID: 149378 RVA: 0x0035FB6A File Offset: 0x0035DD6A
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FObjectSerializeData._ScriptStructPtr != 0) ? FObjectSerializeData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/PrefabSystem.ObjectSerializeData", ref FObjectSerializeData._ScriptStructPtr);
		}

		// Token: 0x04013972 RID: 80242
		[FieldOffset(0)]
		public int FileID;

		// Token: 0x04013973 RID: 80243
		[FieldOffset(4)]
		public uint ObjectFlags;

		// Token: 0x04013974 RID: 80244
		[FieldOffset(8)]
		public int ClassIndex;

		// Token: 0x04013975 RID: 80245
		public const string __ObjectPath = "/Script/PrefabSystem.ObjectSerializeData";

		// Token: 0x04013976 RID: 80246
		private static IntPtr _ScriptStructPtr;
	}
}
