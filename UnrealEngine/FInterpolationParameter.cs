using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000C87 RID: 3207
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(8, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 8)]
	[UnrealObjectPath("/Script/Engine.InterpolationParameter")]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 8)]
	public struct FInterpolationParameter : IEqualityOperators<FInterpolationParameter, FInterpolationParameter, bool>, IEquatable<FInterpolationParameter>, IUnrealScriptStruct
	{
		// Token: 0x0600A2B9 RID: 41657 RVA: 0x000E70F4 File Offset: 0x000E52F4
		public FInterpolationParameter(float InterpolationTime, TEnumAsByte<EFilterInterpolationType> InterpolationType)
		{
			this.InterpolationTime = InterpolationTime;
			this.InterpolationType = InterpolationType;
		}

		// Token: 0x0600A2BA RID: 41658 RVA: 0x000E7104 File Offset: 0x000E5304
		public static bool operator ==(FInterpolationParameter left, FInterpolationParameter right)
		{
			return left.InterpolationTime == right.InterpolationTime && left.InterpolationType == right.InterpolationType;
		}

		// Token: 0x0600A2BB RID: 41659 RVA: 0x000E7127 File Offset: 0x000E5327
		public static bool operator !=(FInterpolationParameter left, FInterpolationParameter right)
		{
			return !(left == right);
		}

		// Token: 0x0600A2BC RID: 41660 RVA: 0x000E7133 File Offset: 0x000E5333
		public bool Equals(FInterpolationParameter other)
		{
			return this == other;
		}

		// Token: 0x0600A2BD RID: 41661 RVA: 0x000E7144 File Offset: 0x000E5344
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			if (obj is FInterpolationParameter)
			{
				FInterpolationParameter other = (FInterpolationParameter)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x0600A2BE RID: 41662 RVA: 0x000E7169 File Offset: 0x000E5369
		public override int GetHashCode()
		{
			return HashCode.Combine<float, TEnumAsByte<EFilterInterpolationType>>(this.InterpolationTime, this.InterpolationType);
		}

		// Token: 0x0600A2BF RID: 41663 RVA: 0x000E717C File Offset: 0x000E537C
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FInterpolationParameter._ScriptStructPtr != 0) ? FInterpolationParameter._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.InterpolationParameter", ref FInterpolationParameter._ScriptStructPtr);
		}

		// Token: 0x0400594B RID: 22859
		[FieldOffset(0)]
		public float InterpolationTime;

		// Token: 0x0400594C RID: 22860
		[FieldOffset(4)]
		public TEnumAsByte<EFilterInterpolationType> InterpolationType;

		// Token: 0x0400594D RID: 22861
		public const string __ObjectPath = "/Script/Engine.InterpolationParameter";

		// Token: 0x0400594E RID: 22862
		private static IntPtr _ScriptStructPtr;
	}
}
