using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002286 RID: 8838
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(8, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 8)]
	[UnrealObjectPath("/Script/MagtModule.QualityFeature")]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 8)]
	public struct FQualityFeature : IEqualityOperators<FQualityFeature, FQualityFeature, bool>, IEquatable<FQualityFeature>, IUnrealScriptStruct
	{
		// Token: 0x060219A4 RID: 137636 RVA: 0x0031B717 File Offset: 0x00319917
		public FQualityFeature(EQualityRenderBits Index, int Level)
		{
			this.Index = Index;
			this.Level = Level;
		}

		// Token: 0x060219A5 RID: 137637 RVA: 0x0031B727 File Offset: 0x00319927
		public static bool operator ==(FQualityFeature left, FQualityFeature right)
		{
			return left.Index == right.Index && left.Level == right.Level;
		}

		// Token: 0x060219A6 RID: 137638 RVA: 0x0031B747 File Offset: 0x00319947
		public static bool operator !=(FQualityFeature left, FQualityFeature right)
		{
			return !(left == right);
		}

		// Token: 0x060219A7 RID: 137639 RVA: 0x0031B753 File Offset: 0x00319953
		public bool Equals(FQualityFeature other)
		{
			return this == other;
		}

		// Token: 0x060219A8 RID: 137640 RVA: 0x0031B764 File Offset: 0x00319964
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			if (obj is FQualityFeature)
			{
				FQualityFeature other = (FQualityFeature)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x060219A9 RID: 137641 RVA: 0x0031B789 File Offset: 0x00319989
		public override int GetHashCode()
		{
			return HashCode.Combine<EQualityRenderBits, int>(this.Index, this.Level);
		}

		// Token: 0x060219AA RID: 137642 RVA: 0x0031B79C File Offset: 0x0031999C
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FQualityFeature._ScriptStructPtr != 0) ? FQualityFeature._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MagtModule.QualityFeature", ref FQualityFeature._ScriptStructPtr);
		}

		// Token: 0x04011F10 RID: 73488
		[FieldOffset(0)]
		public EQualityRenderBits Index;

		// Token: 0x04011F11 RID: 73489
		[FieldOffset(4)]
		public int Level;

		// Token: 0x04011F12 RID: 73490
		public const string __ObjectPath = "/Script/MagtModule.QualityFeature";

		// Token: 0x04011F13 RID: 73491
		private static IntPtr _ScriptStructPtr;
	}
}
