using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000352 RID: 850
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(16, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 16)]
	[UnrealObjectPath("/Script/KuroComponent.SplineMoveDynamicSpeedData")]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 16)]
	public struct FSplineMoveDynamicSpeedData : IEqualityOperators<FSplineMoveDynamicSpeedData, FSplineMoveDynamicSpeedData, bool>, IEquatable<FSplineMoveDynamicSpeedData>, IUnrealScriptStruct
	{
		// Token: 0x060056EA RID: 22250 RVA: 0x0007A861 File Offset: 0x00078A61
		public FSplineMoveDynamicSpeedData(float TargetSpeed, float Acceleration, float CurrentSpeed, float EndDis)
		{
			this.TargetSpeed = TargetSpeed;
			this.Acceleration = Acceleration;
			this.CurrentSpeed = CurrentSpeed;
			this.EndDis = EndDis;
		}

		// Token: 0x060056EB RID: 22251 RVA: 0x0007A880 File Offset: 0x00078A80
		public static bool operator ==(FSplineMoveDynamicSpeedData left, FSplineMoveDynamicSpeedData right)
		{
			return left.TargetSpeed == right.TargetSpeed && left.Acceleration == right.Acceleration && left.CurrentSpeed == right.CurrentSpeed && left.EndDis == right.EndDis;
		}

		// Token: 0x060056EC RID: 22252 RVA: 0x0007A8BC File Offset: 0x00078ABC
		public static bool operator !=(FSplineMoveDynamicSpeedData left, FSplineMoveDynamicSpeedData right)
		{
			return !(left == right);
		}

		// Token: 0x060056ED RID: 22253 RVA: 0x0007A8C8 File Offset: 0x00078AC8
		public bool Equals(FSplineMoveDynamicSpeedData other)
		{
			return this == other;
		}

		// Token: 0x060056EE RID: 22254 RVA: 0x0007A8D8 File Offset: 0x00078AD8
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

		// Token: 0x060056EF RID: 22255 RVA: 0x0007A8FD File Offset: 0x00078AFD
		public override int GetHashCode()
		{
			return HashCode.Combine<float, float, float, float>(this.TargetSpeed, this.Acceleration, this.CurrentSpeed, this.EndDis);
		}

		// Token: 0x060056F0 RID: 22256 RVA: 0x0007A91C File Offset: 0x00078B1C
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSplineMoveDynamicSpeedData._ScriptStructPtr != 0) ? FSplineMoveDynamicSpeedData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroComponent.SplineMoveDynamicSpeedData", ref FSplineMoveDynamicSpeedData._ScriptStructPtr);
		}

		// Token: 0x040023C2 RID: 9154
		[FieldOffset(0)]
		public float TargetSpeed;

		// Token: 0x040023C3 RID: 9155
		[FieldOffset(4)]
		public float Acceleration;

		// Token: 0x040023C4 RID: 9156
		[FieldOffset(8)]
		public float CurrentSpeed;

		// Token: 0x040023C5 RID: 9157
		[FieldOffset(12)]
		public float EndDis;

		// Token: 0x040023C6 RID: 9158
		public const string __ObjectPath = "/Script/KuroComponent.SplineMoveDynamicSpeedData";

		// Token: 0x040023C7 RID: 9159
		private static IntPtr _ScriptStructPtr;
	}
}
