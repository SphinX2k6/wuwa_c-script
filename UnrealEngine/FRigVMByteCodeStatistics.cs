using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020026BD RID: 9917
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(8, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 8)]
	[UnrealObjectPath("/Script/RigVM.RigVMByteCodeStatistics")]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 8)]
	public struct FRigVMByteCodeStatistics : IEqualityOperators<FRigVMByteCodeStatistics, FRigVMByteCodeStatistics, bool>, IEquatable<FRigVMByteCodeStatistics>, IUnrealScriptStruct
	{
		// Token: 0x06024D55 RID: 150869 RVA: 0x00367F36 File Offset: 0x00366136
		public FRigVMByteCodeStatistics(uint InstructionCount, uint DataBytes)
		{
			this.InstructionCount = InstructionCount;
			this.DataBytes = DataBytes;
		}

		// Token: 0x06024D56 RID: 150870 RVA: 0x00367F46 File Offset: 0x00366146
		public static bool operator ==(FRigVMByteCodeStatistics left, FRigVMByteCodeStatistics right)
		{
			return left.InstructionCount == right.InstructionCount && left.DataBytes == right.DataBytes;
		}

		// Token: 0x06024D57 RID: 150871 RVA: 0x00367F66 File Offset: 0x00366166
		public static bool operator !=(FRigVMByteCodeStatistics left, FRigVMByteCodeStatistics right)
		{
			return !(left == right);
		}

		// Token: 0x06024D58 RID: 150872 RVA: 0x00367F72 File Offset: 0x00366172
		public bool Equals(FRigVMByteCodeStatistics other)
		{
			return this == other;
		}

		// Token: 0x06024D59 RID: 150873 RVA: 0x00367F80 File Offset: 0x00366180
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			if (obj is FRigVMByteCodeStatistics)
			{
				FRigVMByteCodeStatistics other = (FRigVMByteCodeStatistics)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x06024D5A RID: 150874 RVA: 0x00367FA5 File Offset: 0x003661A5
		public override int GetHashCode()
		{
			return HashCode.Combine<uint, uint>(this.InstructionCount, this.DataBytes);
		}

		// Token: 0x06024D5B RID: 150875 RVA: 0x00367FB8 File Offset: 0x003661B8
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigVMByteCodeStatistics._ScriptStructPtr != 0) ? FRigVMByteCodeStatistics._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/RigVM.RigVMByteCodeStatistics", ref FRigVMByteCodeStatistics._ScriptStructPtr);
		}

		// Token: 0x04013D90 RID: 81296
		[FieldOffset(0)]
		public uint InstructionCount;

		// Token: 0x04013D91 RID: 81297
		[FieldOffset(4)]
		public uint DataBytes;

		// Token: 0x04013D92 RID: 81298
		public const string __ObjectPath = "/Script/RigVM.RigVMByteCodeStatistics";

		// Token: 0x04013D93 RID: 81299
		private static IntPtr _ScriptStructPtr;
	}
}
