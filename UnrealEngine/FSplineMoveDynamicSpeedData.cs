using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200176D RID: 5997
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(16, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 16)]
	[UnrealObjectPath("/Script/KuroComponent.SplineMoveDynamicSpeedData")]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 16)]
	public struct FSplineMoveDynamicSpeedData : IEqualityOperators<FSplineMoveDynamicSpeedData, FSplineMoveDynamicSpeedData, bool>, IEquatable<FSplineMoveDynamicSpeedData>, IUnrealScriptStruct
	{
		// Token: 0x0601590D RID: 88333 RVA: 0x001FBAB6 File Offset: 0x001F9CB6
		public FSplineMoveDynamicSpeedData(float TargetSpeed, float Acceleration, float CurrentSpeed, float EndDis)
		{
			this.TargetSpeed = TargetSpeed;
			this.Acceleration = Acceleration;
			this.CurrentSpeed = CurrentSpeed;
			this.EndDis = EndDis;
		}

		// Token: 0x0601590E RID: 88334 RVA: 0x001FBAD5 File Offset: 0x001F9CD5
		public static bool operator ==(FSplineMoveDynamicSpeedData left, FSplineMoveDynamicSpeedData right)
		{
			return left.TargetSpeed == right.TargetSpeed && left.Acceleration == right.Acceleration && left.CurrentSpeed == right.CurrentSpeed && left.EndDis == right.EndDis;
		}

		// Token: 0x0601590F RID: 88335 RVA: 0x001FBB11 File Offset: 0x001F9D11
		public static bool operator !=(FSplineMoveDynamicSpeedData left, FSplineMoveDynamicSpeedData right)
		{
			return !(left == right);
		}

		// Token: 0x06015910 RID: 88336 RVA: 0x001FBB1D File Offset: 0x001F9D1D
		public bool Equals(FSplineMoveDynamicSpeedData other)
		{
			return this == other;
		}

		// Token: 0x06015911 RID: 88337 RVA: 0x001FBB2C File Offset: 0x001F9D2C
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			if (obj is FSplineMoveDynamicSpeedData)
			{
				FSplineMoveDynamicSpeedData other = (FSplineMoveDynamicSpeedData)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x06015912 RID: 88338 RVA: 0x001FBB51 File Offset: 0x001F9D51
		public override int GetHashCode()
		{
			return HashCode.Combine<float, float, float, float>(this.TargetSpeed, this.Acceleration, this.CurrentSpeed, this.EndDis);
		}

		// Token: 0x06015913 RID: 88339 RVA: 0x001FBB70 File Offset: 0x001F9D70
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSplineMoveDynamicSpeedData._ScriptStructPtr != 0) ? FSplineMoveDynamicSpeedData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroComponent.SplineMoveDynamicSpeedData", ref FSplineMoveDynamicSpeedData._ScriptStructPtr);
		}

		// Token: 0x0400BC45 RID: 48197
		[FieldOffset(0)]
		public float TargetSpeed;

		// Token: 0x0400BC46 RID: 48198
		[FieldOffset(4)]
		public float Acceleration;

		// Token: 0x0400BC47 RID: 48199
		[FieldOffset(8)]
		public float CurrentSpeed;

		// Token: 0x0400BC48 RID: 48200
		[FieldOffset(12)]
		public float EndDis;

		// Token: 0x0400BC49 RID: 48201
		public const string __ObjectPath = "/Script/KuroComponent.SplineMoveDynamicSpeedData";

		// Token: 0x0400BC4A RID: 48202
		private static IntPtr _ScriptStructPtr;
	}
}
