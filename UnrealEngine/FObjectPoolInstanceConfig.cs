using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000752 RID: 1874
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(32, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 32)]
	[UnrealObjectPath("/Script/CoreUObject.ObjectPoolInstanceConfig")]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 32)]
	public struct FObjectPoolInstanceConfig : IEqualityOperators<FObjectPoolInstanceConfig, FObjectPoolInstanceConfig, bool>, IEquatable<FObjectPoolInstanceConfig>, IUnrealScriptStruct
	{
		// Token: 0x06006315 RID: 25365 RVA: 0x0008E382 File Offset: 0x0008C582
		public FObjectPoolInstanceConfig(FName PackageName, FName ClassName, uint PageBlockNum, uint ReservePageNum)
		{
			this.PackageName = PackageName;
			this.ClassName = ClassName;
			this.PageBlockNum = PageBlockNum;
			this.ReservePageNum = ReservePageNum;
		}

		// Token: 0x06006316 RID: 25366 RVA: 0x0008E3A4 File Offset: 0x0008C5A4
		public static bool operator ==(FObjectPoolInstanceConfig left, FObjectPoolInstanceConfig right)
		{
			return left.PackageName == right.PackageName && left.ClassName == right.ClassName && left.PageBlockNum == right.PageBlockNum && left.ReservePageNum == right.ReservePageNum;
		}

		// Token: 0x06006317 RID: 25367 RVA: 0x0008E3F5 File Offset: 0x0008C5F5
		public static bool operator !=(FObjectPoolInstanceConfig left, FObjectPoolInstanceConfig right)
		{
			return !(left == right);
		}

		// Token: 0x06006318 RID: 25368 RVA: 0x0008E401 File Offset: 0x0008C601
		public bool Equals(FObjectPoolInstanceConfig other)
		{
			return this == other;
		}

		// Token: 0x06006319 RID: 25369 RVA: 0x0008E410 File Offset: 0x0008C610
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			if (obj is FObjectPoolInstanceConfig)
			{
				FObjectPoolInstanceConfig other = (FObjectPoolInstanceConfig)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x0600631A RID: 25370 RVA: 0x0008E435 File Offset: 0x0008C635
		public override int GetHashCode()
		{
			return HashCode.Combine<FName, FName, uint, uint>(this.PackageName, this.ClassName, this.PageBlockNum, this.ReservePageNum);
		}

		// Token: 0x0600631B RID: 25371 RVA: 0x0008E454 File Offset: 0x0008C654
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FObjectPoolInstanceConfig._ScriptStructPtr != 0) ? FObjectPoolInstanceConfig._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/CoreUObject.ObjectPoolInstanceConfig", ref FObjectPoolInstanceConfig._ScriptStructPtr);
		}

		// Token: 0x04002F72 RID: 12146
		[FieldOffset(0)]
		public FName PackageName;

		// Token: 0x04002F73 RID: 12147
		[FieldOffset(12)]
		public FName ClassName;

		// Token: 0x04002F74 RID: 12148
		[FieldOffset(24)]
		public uint PageBlockNum;

		// Token: 0x04002F75 RID: 12149
		[FieldOffset(28)]
		public uint ReservePageNum;

		// Token: 0x04002F76 RID: 12150
		public const string __ObjectPath = "/Script/CoreUObject.ObjectPoolInstanceConfig";

		// Token: 0x04002F77 RID: 12151
		private static IntPtr _ScriptStructPtr;
	}
}
