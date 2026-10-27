using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001227 RID: 4647
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(8, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 8)]
	[UnrealObjectPath("/Script/Engine.VectorRK4SpringInterpolator")]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 8)]
	public struct FVectorRK4SpringInterpolator : IEqualityOperators<FVectorRK4SpringInterpolator, FVectorRK4SpringInterpolator, bool>, IEquatable<FVectorRK4SpringInterpolator>, IUnrealScriptStruct
	{
		// Token: 0x060111A1 RID: 70049 RVA: 0x00191848 File Offset: 0x0018FA48
		public FVectorRK4SpringInterpolator(float StiffnessConstant, float DampeningRatio)
		{
			this.StiffnessConstant = StiffnessConstant;
			this.DampeningRatio = DampeningRatio;
		}

		// Token: 0x060111A2 RID: 70050 RVA: 0x00191858 File Offset: 0x0018FA58
		public static bool operator ==(FVectorRK4SpringInterpolator left, FVectorRK4SpringInterpolator right)
		{
			return left.StiffnessConstant == right.StiffnessConstant && left.DampeningRatio == right.DampeningRatio;
		}

		// Token: 0x060111A3 RID: 70051 RVA: 0x00191878 File Offset: 0x0018FA78
		public static bool operator !=(FVectorRK4SpringInterpolator left, FVectorRK4SpringInterpolator right)
		{
			return !(left == right);
		}

		// Token: 0x060111A4 RID: 70052 RVA: 0x00191884 File Offset: 0x0018FA84
		public bool Equals(FVectorRK4SpringInterpolator other)
		{
			return this == other;
		}

		// Token: 0x060111A5 RID: 70053 RVA: 0x00191894 File Offset: 0x0018FA94
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			if (obj is FVectorRK4SpringInterpolator)
			{
				FVectorRK4SpringInterpolator other = (FVectorRK4SpringInterpolator)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x060111A6 RID: 70054 RVA: 0x001918B9 File Offset: 0x0018FAB9
		public override int GetHashCode()
		{
			return HashCode.Combine<float, float>(this.StiffnessConstant, this.DampeningRatio);
		}

		// Token: 0x060111A7 RID: 70055 RVA: 0x001918CC File Offset: 0x0018FACC
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FVectorRK4SpringInterpolator._ScriptStructPtr != 0) ? FVectorRK4SpringInterpolator._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.VectorRK4SpringInterpolator", ref FVectorRK4SpringInterpolator._ScriptStructPtr);
		}

		// Token: 0x0400927B RID: 37499
		[FieldOffset(0)]
		public float StiffnessConstant;

		// Token: 0x0400927C RID: 37500
		[FieldOffset(4)]
		public float DampeningRatio;

		// Token: 0x0400927D RID: 37501
		public const string __ObjectPath = "/Script/Engine.VectorRK4SpringInterpolator";

		// Token: 0x0400927E RID: 37502
		private static IntPtr _ScriptStructPtr;
	}
}
