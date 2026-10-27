using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020026CE RID: 9934
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(44, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 44)]
	[UnrealObjectPath("/Script/RigVM.RigVMStatistics")]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 44)]
	public struct FRigVMStatistics : IEqualityOperators<FRigVMStatistics, FRigVMStatistics, bool>, IEquatable<FRigVMStatistics>, IUnrealScriptStruct
	{
		// Token: 0x06024E23 RID: 151075 RVA: 0x00368E94 File Offset: 0x00367094
		public FRigVMStatistics(uint BytesForCDO, uint BytesPerInstance, FRigVMMemoryStatistics LiteralMemory, FRigVMMemoryStatistics WorkMemory, uint BytesForCaching, FRigVMByteCodeStatistics ByteCode)
		{
			this.BytesForCDO = BytesForCDO;
			this.BytesPerInstance = BytesPerInstance;
			this.LiteralMemory = LiteralMemory;
			this.WorkMemory = WorkMemory;
			this.BytesForCaching = BytesForCaching;
			this.ByteCode = ByteCode;
		}

		// Token: 0x06024E24 RID: 151076 RVA: 0x00368EC4 File Offset: 0x003670C4
		public static bool operator ==(FRigVMStatistics left, FRigVMStatistics right)
		{
			return left.BytesForCDO == right.BytesForCDO && left.BytesPerInstance == right.BytesPerInstance && left.LiteralMemory == right.LiteralMemory && left.WorkMemory == right.WorkMemory && left.BytesForCaching == right.BytesForCaching && left.ByteCode == right.ByteCode;
		}

		// Token: 0x06024E25 RID: 151077 RVA: 0x00368F34 File Offset: 0x00367134
		public static bool operator !=(FRigVMStatistics left, FRigVMStatistics right)
		{
			return !(left == right);
		}

		// Token: 0x06024E26 RID: 151078 RVA: 0x00368F40 File Offset: 0x00367140
		public bool Equals(FRigVMStatistics other)
		{
			return this == other;
		}

		// Token: 0x06024E27 RID: 151079 RVA: 0x00368F50 File Offset: 0x00367150
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			if (obj is FRigVMStatistics)
			{
				FRigVMStatistics other = (FRigVMStatistics)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x06024E28 RID: 151080 RVA: 0x00368F75 File Offset: 0x00367175
		public override int GetHashCode()
		{
			return HashCode.Combine<uint, uint, FRigVMMemoryStatistics, FRigVMMemoryStatistics, uint, FRigVMByteCodeStatistics>(this.BytesForCDO, this.BytesPerInstance, this.LiteralMemory, this.WorkMemory, this.BytesForCaching, this.ByteCode);
		}

		// Token: 0x06024E29 RID: 151081 RVA: 0x00368FA0 File Offset: 0x003671A0
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigVMStatistics._ScriptStructPtr != 0) ? FRigVMStatistics._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/RigVM.RigVMStatistics", ref FRigVMStatistics._ScriptStructPtr);
		}

		// Token: 0x04013DE6 RID: 81382
		[FieldOffset(0)]
		public uint BytesForCDO;

		// Token: 0x04013DE7 RID: 81383
		[FieldOffset(4)]
		public uint BytesPerInstance;

		// Token: 0x04013DE8 RID: 81384
		[FieldOffset(8)]
		public FRigVMMemoryStatistics LiteralMemory;

		// Token: 0x04013DE9 RID: 81385
		[FieldOffset(20)]
		public FRigVMMemoryStatistics WorkMemory;

		// Token: 0x04013DEA RID: 81386
		[FieldOffset(32)]
		public uint BytesForCaching;

		// Token: 0x04013DEB RID: 81387
		[FieldOffset(36)]
		public FRigVMByteCodeStatistics ByteCode;

		// Token: 0x04013DEC RID: 81388
		public const string __ObjectPath = "/Script/RigVM.RigVMStatistics";

		// Token: 0x04013DED RID: 81389
		private static IntPtr _ScriptStructPtr;
	}
}
