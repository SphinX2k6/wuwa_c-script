using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020026C8 RID: 9928
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(12, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 12)]
	[UnrealObjectPath("/Script/RigVM.RigVMMemoryStatistics")]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 12)]
	public struct FRigVMMemoryStatistics : IEqualityOperators<FRigVMMemoryStatistics, FRigVMMemoryStatistics, bool>, IEquatable<FRigVMMemoryStatistics>, IUnrealScriptStruct
	{
		// Token: 0x06024DBD RID: 150973 RVA: 0x003686D4 File Offset: 0x003668D4
		public FRigVMMemoryStatistics(uint RegisterCount, uint DataBytes, uint TotalBytes)
		{
			this.RegisterCount = RegisterCount;
			this.DataBytes = DataBytes;
			this.TotalBytes = TotalBytes;
		}

		// Token: 0x06024DBE RID: 150974 RVA: 0x003686EB File Offset: 0x003668EB
		public static bool operator ==(FRigVMMemoryStatistics left, FRigVMMemoryStatistics right)
		{
			return left.RegisterCount == right.RegisterCount && left.DataBytes == right.DataBytes && left.TotalBytes == right.TotalBytes;
		}

		// Token: 0x06024DBF RID: 150975 RVA: 0x00368719 File Offset: 0x00366919
		public static bool operator !=(FRigVMMemoryStatistics left, FRigVMMemoryStatistics right)
		{
			return !(left == right);
		}

		// Token: 0x06024DC0 RID: 150976 RVA: 0x00368725 File Offset: 0x00366925
		public bool Equals(FRigVMMemoryStatistics other)
		{
			return this == other;
		}

		// Token: 0x06024DC1 RID: 150977 RVA: 0x00368734 File Offset: 0x00366934
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			if (obj is FRigVMMemoryStatistics)
			{
				FRigVMMemoryStatistics other = (FRigVMMemoryStatistics)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x06024DC2 RID: 150978 RVA: 0x00368759 File Offset: 0x00366959
		public override int GetHashCode()
		{
			return HashCode.Combine<uint, uint, uint>(this.RegisterCount, this.DataBytes, this.TotalBytes);
		}

		// Token: 0x06024DC3 RID: 150979 RVA: 0x00368772 File Offset: 0x00366972
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigVMMemoryStatistics._ScriptStructPtr != 0) ? FRigVMMemoryStatistics._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/RigVM.RigVMMemoryStatistics", ref FRigVMMemoryStatistics._ScriptStructPtr);
		}

		// Token: 0x04013DBA RID: 81338
		[FieldOffset(0)]
		public uint RegisterCount;

		// Token: 0x04013DBB RID: 81339
		[FieldOffset(4)]
		public uint DataBytes;

		// Token: 0x04013DBC RID: 81340
		[FieldOffset(8)]
		public uint TotalBytes;

		// Token: 0x04013DBD RID: 81341
		public const string __ObjectPath = "/Script/RigVM.RigVMMemoryStatistics";

		// Token: 0x04013DBE RID: 81342
		private static IntPtr _ScriptStructPtr;
	}
}
