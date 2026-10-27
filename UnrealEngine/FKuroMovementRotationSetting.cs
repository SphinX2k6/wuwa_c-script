using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000CFA RID: 3322
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(24, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 24)]
	[UnrealObjectPath("/Script/Engine.KuroMovementRotationSetting")]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 24)]
	public struct FKuroMovementRotationSetting : IEqualityOperators<FKuroMovementRotationSetting, FKuroMovementRotationSetting, bool>, IEquatable<FKuroMovementRotationSetting>, IUnrealScriptStruct
	{
		// Token: 0x0600B0E2 RID: 45282 RVA: 0x000FB340 File Offset: 0x000F9540
		public FKuroMovementRotationSetting(float MaxRotationSpeed, float MaxAngleOffset, float MinRotationSpeed, float MinAngleOffset, int CurveType, float CurveN)
		{
			this.MaxRotationSpeed = MaxRotationSpeed;
			this.MaxAngleOffset = MaxAngleOffset;
			this.MinRotationSpeed = MinRotationSpeed;
			this.MinAngleOffset = MinAngleOffset;
			this.CurveType = CurveType;
			this.CurveN = CurveN;
		}

		// Token: 0x0600B0E3 RID: 45283 RVA: 0x000FB370 File Offset: 0x000F9570
		public static bool operator ==(FKuroMovementRotationSetting left, FKuroMovementRotationSetting right)
		{
			return left.MaxRotationSpeed == right.MaxRotationSpeed && left.MaxAngleOffset == right.MaxAngleOffset && left.MinRotationSpeed == right.MinRotationSpeed && left.MinAngleOffset == right.MinAngleOffset && left.CurveType == right.CurveType && left.CurveN == right.CurveN;
		}

		// Token: 0x0600B0E4 RID: 45284 RVA: 0x000FB3D3 File Offset: 0x000F95D3
		public static bool operator !=(FKuroMovementRotationSetting left, FKuroMovementRotationSetting right)
		{
			return !(left == right);
		}

		// Token: 0x0600B0E5 RID: 45285 RVA: 0x000FB3DF File Offset: 0x000F95DF
		public bool Equals(FKuroMovementRotationSetting other)
		{
			return this == other;
		}

		// Token: 0x0600B0E6 RID: 45286 RVA: 0x000FB3F0 File Offset: 0x000F95F0
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

		// Token: 0x0600B0E7 RID: 45287 RVA: 0x000FB415 File Offset: 0x000F9615
		public override int GetHashCode()
		{
			return HashCode.Combine<float, float, float, float, int, float>(this.MaxRotationSpeed, this.MaxAngleOffset, this.MinRotationSpeed, this.MinAngleOffset, this.CurveType, this.CurveN);
		}

		// Token: 0x0600B0E8 RID: 45288 RVA: 0x000FB440 File Offset: 0x000F9640
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroMovementRotationSetting._ScriptStructPtr != 0) ? FKuroMovementRotationSetting._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.KuroMovementRotationSetting", ref FKuroMovementRotationSetting._ScriptStructPtr);
		}

		// Token: 0x04005CB2 RID: 23730
		[FieldOffset(0)]
		public readonly float MaxRotationSpeed;

		// Token: 0x04005CB3 RID: 23731
		[FieldOffset(4)]
		public readonly float MaxAngleOffset;

		// Token: 0x04005CB4 RID: 23732
		[FieldOffset(8)]
		public readonly float MinRotationSpeed;

		// Token: 0x04005CB5 RID: 23733
		[FieldOffset(12)]
		public readonly float MinAngleOffset;

		// Token: 0x04005CB6 RID: 23734
		[FieldOffset(16)]
		public readonly int CurveType;

		// Token: 0x04005CB7 RID: 23735
		[FieldOffset(20)]
		public readonly float CurveN;

		// Token: 0x04005CB8 RID: 23736
		public const string __ObjectPath = "/Script/Engine.KuroMovementRotationSetting";

		// Token: 0x04005CB9 RID: 23737
		private static IntPtr _ScriptStructPtr;
	}
}
