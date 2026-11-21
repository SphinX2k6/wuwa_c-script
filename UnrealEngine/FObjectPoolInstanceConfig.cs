using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000138 RID: 312
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(32, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 32)]
	[UnrealObjectPath("/Script/CoreUObject.ObjectPoolInstanceConfig")]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 32)]
	public struct FObjectPoolInstanceConfig : IEqualityOperators<FObjectPoolInstanceConfig, FObjectPoolInstanceConfig, bool>, IEquatable<FObjectPoolInstanceConfig>, IUnrealScriptStruct
	{
		// Token: 0x06001271 RID: 4721 RVA: 0x0001D302 File Offset: 0x0001B502
		public FObjectPoolInstanceConfig(FName PackageName, FName ClassName, uint PageBlockNum, uint ReservePageNum)
		{
			this.PackageName = PackageName;
			this.ClassName = ClassName;
			this.PageBlockNum = PageBlockNum;
			this.ReservePageNum = ReservePageNum;
		}

		// Token: 0x06001272 RID: 4722 RVA: 0x0001D324 File Offset: 0x0001B524
		public static bool operator ==(FObjectPoolInstanceConfig left, FObjectPoolInstanceConfig right)
		{
			return left.PackageName == right.PackageName && left.ClassName == right.ClassName && left.PageBlockNum == right.PageBlockNum && left.ReservePageNum == right.ReservePageNum;
		}

		// Token: 0x06001273 RID: 4723 RVA: 0x0001D375 File Offset: 0x0001B575
		public static bool operator !=(FObjectPoolInstanceConfig left, FObjectPoolInstanceConfig right)
		{
			return !(left == right);
		}

		// Token: 0x06001274 RID: 4724 RVA: 0x0001D381 File Offset: 0x0001B581
		public bool Equals(FObjectPoolInstanceConfig other)
		{
			return this == other;
		}

		// Token: 0x06001275 RID: 4725 RVA: 0x0001D390 File Offset: 0x0001B590
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

		// Token: 0x06001276 RID: 4726 RVA: 0x0001D3B5 File Offset: 0x0001B5B5
		public override int GetHashCode()
		{
			return HashCode.Combine<FName, FName, uint, uint>(this.PackageName, this.ClassName, this.PageBlockNum, this.ReservePageNum);
		}

		// Token: 0x06001277 RID: 4727 RVA: 0x0001D3D4 File Offset: 0x0001B5D4
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FObjectPoolInstanceConfig._ScriptStructPtr != 0) ? FObjectPoolInstanceConfig._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/CoreUObject.ObjectPoolInstanceConfig", ref FObjectPoolInstanceConfig._ScriptStructPtr);
		}

		// Token: 0x040005A8 RID: 1448
		[FieldOffset(0)]
		public FName PackageName;

		// Token: 0x040005A9 RID: 1449
		[FieldOffset(12)]
		public FName ClassName;

		// Token: 0x040005AA RID: 1450
		[FieldOffset(24)]
		public uint PageBlockNum;

		// Token: 0x040005AB RID: 1451
		[FieldOffset(28)]
		public uint ReservePageNum;

		// Token: 0x040005AC RID: 1452
		public const string __ObjectPath = "/Script/CoreUObject.ObjectPoolInstanceConfig";

		// Token: 0x040005AD RID: 1453
		private static IntPtr _ScriptStructPtr;
	}
}
