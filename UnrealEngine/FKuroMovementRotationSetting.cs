using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200022B RID: 555
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(24, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 24)]
	[UnrealObjectPath("/Script/Engine.KuroMovementRotationSetting")]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 24)]
	public struct FKuroMovementRotationSetting : IEqualityOperators<FKuroMovementRotationSetting, FKuroMovementRotationSetting, bool>, IEquatable<FKuroMovementRotationSetting>, IUnrealScriptStruct
	{
		// Token: 0x06002CD9 RID: 11481 RVA: 0x0003F5E6 File Offset: 0x0003D7E6
		public FKuroMovementRotationSetting(float MaxRotationSpeed, float MaxAngleOffset, float MinRotationSpeed, float MinAngleOffset, int CurveType, float CurveN)
		{
			this.MaxRotationSpeed = MaxRotationSpeed;
			this.MaxAngleOffset = MaxAngleOffset;
			this.MinRotationSpeed = MinRotationSpeed;
			this.MinAngleOffset = MinAngleOffset;
			this.CurveType = CurveType;
			this.CurveN = CurveN;
		}

		// Token: 0x06002CDA RID: 11482 RVA: 0x0003F618 File Offset: 0x0003D818
		public static bool operator ==(FKuroMovementRotationSetting left, FKuroMovementRotationSetting right)
		{
			return left.MaxRotationSpeed == right.MaxRotationSpeed && left.MaxAngleOffset == right.MaxAngleOffset && left.MinRotationSpeed == right.MinRotationSpeed && left.MinAngleOffset == right.MinAngleOffset && left.CurveType == right.CurveType && left.CurveN == right.CurveN;
		}

		// Token: 0x06002CDB RID: 11483 RVA: 0x0003F67B File Offset: 0x0003D87B
		public static bool operator !=(FKuroMovementRotationSetting left, FKuroMovementRotationSetting right)
		{
			return !(left == right);
		}

		// Token: 0x06002CDC RID: 11484 RVA: 0x0003F687 File Offset: 0x0003D887
		public bool Equals(FKuroMovementRotationSetting other)
		{
			return this == other;
		}

		// Token: 0x06002CDD RID: 11485 RVA: 0x0003F698 File Offset: 0x0003D898
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			if (obj is FKuroMovementRotationSetting)
			{
				FKuroMovementRotationSetting other = (FKuroMovementRotationSetting)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x06002CDE RID: 11486 RVA: 0x0003F6BD File Offset: 0x0003D8BD
		public override int GetHashCode()
		{
			return HashCode.Combine<float, float, float, float, int, float>(this.MaxRotationSpeed, this.MaxAngleOffset, this.MinRotationSpeed, this.MinAngleOffset, this.CurveType, this.CurveN);
		}

		// Token: 0x06002CDF RID: 11487 RVA: 0x0003F6E8 File Offset: 0x0003D8E8
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroMovementRotationSetting._ScriptStructPtr != 0) ? FKuroMovementRotationSetting._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.KuroMovementRotationSetting", ref FKuroMovementRotationSetting._ScriptStructPtr);
		}

		// Token: 0x04000E35 RID: 3637
		[FieldOffset(0)]
		public readonly float MaxRotationSpeed;

		// Token: 0x04000E36 RID: 3638
		[FieldOffset(4)]
		public readonly float MaxAngleOffset;

		// Token: 0x04000E37 RID: 3639
		[FieldOffset(8)]
		public readonly float MinRotationSpeed;

		// Token: 0x04000E38 RID: 3640
		[FieldOffset(12)]
		public readonly float MinAngleOffset;

		// Token: 0x04000E39 RID: 3641
		[FieldOffset(16)]
		public readonly int CurveType;

		// Token: 0x04000E3A RID: 3642
		[FieldOffset(20)]
		public readonly float CurveN;

		// Token: 0x04000E3B RID: 3643
		public const string __ObjectPath = "/Script/Engine.KuroMovementRotationSetting";

		// Token: 0x04000E3C RID: 3644
		private static IntPtr _ScriptStructPtr;
	}
}
