using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000BDA RID: 3034
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(8, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 8)]
	[UnrealObjectPath("/Script/Engine.FloatRK4SpringInterpolator")]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 8)]
	public struct FFloatRK4SpringInterpolator : IEqualityOperators<FFloatRK4SpringInterpolator, FFloatRK4SpringInterpolator, bool>, IEquatable<FFloatRK4SpringInterpolator>, IUnrealScriptStruct
	{
		// Token: 0x0600952F RID: 38191 RVA: 0x000D4D93 File Offset: 0x000D2F93
		public FFloatRK4SpringInterpolator(float StiffnessConstant, float DampeningRatio)
		{
			this.StiffnessConstant = StiffnessConstant;
			this.DampeningRatio = DampeningRatio;
		}

		// Token: 0x06009530 RID: 38192 RVA: 0x000D4DA3 File Offset: 0x000D2FA3
		public static bool operator ==(FFloatRK4SpringInterpolator left, FFloatRK4SpringInterpolator right)
		{
			return left.StiffnessConstant == right.StiffnessConstant && left.DampeningRatio == right.DampeningRatio;
		}

		// Token: 0x06009531 RID: 38193 RVA: 0x000D4DC3 File Offset: 0x000D2FC3
		public static bool operator !=(FFloatRK4SpringInterpolator left, FFloatRK4SpringInterpolator right)
		{
			return !(left == right);
		}

		// Token: 0x06009532 RID: 38194 RVA: 0x000D4DCF File Offset: 0x000D2FCF
		public bool Equals(FFloatRK4SpringInterpolator other)
		{
			return this == other;
		}

		// Token: 0x06009533 RID: 38195 RVA: 0x000D4DE0 File Offset: 0x000D2FE0
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			if (obj is FFloatRK4SpringInterpolator)
			{
				FFloatRK4SpringInterpolator other = (FFloatRK4SpringInterpolator)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x06009534 RID: 38196 RVA: 0x000D4E05 File Offset: 0x000D3005
		public override int GetHashCode()
		{
			return HashCode.Combine<float, float>(this.StiffnessConstant, this.DampeningRatio);
		}

		// Token: 0x06009535 RID: 38197 RVA: 0x000D4E18 File Offset: 0x000D3018
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FFloatRK4SpringInterpolator._ScriptStructPtr != 0) ? FFloatRK4SpringInterpolator._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.FloatRK4SpringInterpolator", ref FFloatRK4SpringInterpolator._ScriptStructPtr);
		}

		// Token: 0x040053BB RID: 21435
		[FieldOffset(0)]
		public float StiffnessConstant;

		// Token: 0x040053BC RID: 21436
		[FieldOffset(4)]
		public float DampeningRatio;

		// Token: 0x040053BD RID: 21437
		public const string __ObjectPath = "/Script/Engine.FloatRK4SpringInterpolator";

		// Token: 0x040053BE RID: 21438
		private static IntPtr _ScriptStructPtr;
	}
}
