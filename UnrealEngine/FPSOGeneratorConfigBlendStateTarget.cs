using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200104A RID: 4170
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(7, 1, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 7)]
	[UnrealObjectPath("/Script/Engine.PSOGeneratorConfigBlendStateTarget")]
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 7)]
	public struct FPSOGeneratorConfigBlendStateTarget : IEqualityOperators<FPSOGeneratorConfigBlendStateTarget, FPSOGeneratorConfigBlendStateTarget, bool>, IEquatable<FPSOGeneratorConfigBlendStateTarget>, IUnrealScriptStruct
	{
		// Token: 0x0600ED40 RID: 60736 RVA: 0x0015FD68 File Offset: 0x0015DF68
		public FPSOGeneratorConfigBlendStateTarget(TEnumAsByte<EPSOGeneratorBlendOperation> ColorBlendOp, TEnumAsByte<EPSOGeneratorBlendFactor> ColorSrcBlend, TEnumAsByte<EPSOGeneratorBlendFactor> ColorDestBlend, TEnumAsByte<EPSOGeneratorBlendOperation> AlphaBlendOp, TEnumAsByte<EPSOGeneratorBlendFactor> AlphaSrcBlend, TEnumAsByte<EPSOGeneratorBlendFactor> AlphaDestBlend, TEnumAsByte<EPSOGeneratorColorWriteMask> ColorWriteMask)
		{
			this.ColorBlendOp = ColorBlendOp;
			this.ColorSrcBlend = ColorSrcBlend;
			this.ColorDestBlend = ColorDestBlend;
			this.AlphaBlendOp = AlphaBlendOp;
			this.AlphaSrcBlend = AlphaSrcBlend;
			this.AlphaDestBlend = AlphaDestBlend;
			this.ColorWriteMask = ColorWriteMask;
		}

		// Token: 0x0600ED41 RID: 60737 RVA: 0x0015FDA0 File Offset: 0x0015DFA0
		public static bool operator ==(FPSOGeneratorConfigBlendStateTarget left, FPSOGeneratorConfigBlendStateTarget right)
		{
			return left.ColorBlendOp == right.ColorBlendOp && left.ColorSrcBlend == right.ColorSrcBlend && left.ColorDestBlend == right.ColorDestBlend && left.AlphaBlendOp == right.AlphaBlendOp && left.AlphaSrcBlend == right.AlphaSrcBlend && left.AlphaDestBlend == right.AlphaDestBlend && left.ColorWriteMask == right.ColorWriteMask;
		}

		// Token: 0x0600ED42 RID: 60738 RVA: 0x0015FE32 File Offset: 0x0015E032
		public static bool operator !=(FPSOGeneratorConfigBlendStateTarget left, FPSOGeneratorConfigBlendStateTarget right)
		{
			return !(left == right);
		}

		// Token: 0x0600ED43 RID: 60739 RVA: 0x0015FE3E File Offset: 0x0015E03E
		public bool Equals(FPSOGeneratorConfigBlendStateTarget other)
		{
			return this == other;
		}

		// Token: 0x0600ED44 RID: 60740 RVA: 0x0015FE4C File Offset: 0x0015E04C
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			if (obj is FPSOGeneratorConfigBlendStateTarget)
			{
				FPSOGeneratorConfigBlendStateTarget other = (FPSOGeneratorConfigBlendStateTarget)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x0600ED45 RID: 60741 RVA: 0x0015FE71 File Offset: 0x0015E071
		public override int GetHashCode()
		{
			return HashCode.Combine<TEnumAsByte<EPSOGeneratorBlendOperation>, TEnumAsByte<EPSOGeneratorBlendFactor>, TEnumAsByte<EPSOGeneratorBlendFactor>, TEnumAsByte<EPSOGeneratorBlendOperation>, TEnumAsByte<EPSOGeneratorBlendFactor>, TEnumAsByte<EPSOGeneratorBlendFactor>, TEnumAsByte<EPSOGeneratorColorWriteMask>>(this.ColorBlendOp, this.ColorSrcBlend, this.ColorDestBlend, this.AlphaBlendOp, this.AlphaSrcBlend, this.AlphaDestBlend, this.ColorWriteMask);
		}

		// Token: 0x0600ED46 RID: 60742 RVA: 0x0015FEA2 File Offset: 0x0015E0A2
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FPSOGeneratorConfigBlendStateTarget._ScriptStructPtr != 0) ? FPSOGeneratorConfigBlendStateTarget._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.PSOGeneratorConfigBlendStateTarget", ref FPSOGeneratorConfigBlendStateTarget._ScriptStructPtr);
		}

		// Token: 0x04008069 RID: 32873
		[FieldOffset(0)]
		public TEnumAsByte<EPSOGeneratorBlendOperation> ColorBlendOp;

		// Token: 0x0400806A RID: 32874
		[FieldOffset(1)]
		public TEnumAsByte<EPSOGeneratorBlendFactor> ColorSrcBlend;

		// Token: 0x0400806B RID: 32875
		[FieldOffset(2)]
		public TEnumAsByte<EPSOGeneratorBlendFactor> ColorDestBlend;

		// Token: 0x0400806C RID: 32876
		[FieldOffset(3)]
		public TEnumAsByte<EPSOGeneratorBlendOperation> AlphaBlendOp;

		// Token: 0x0400806D RID: 32877
		[FieldOffset(4)]
		public TEnumAsByte<EPSOGeneratorBlendFactor> AlphaSrcBlend;

		// Token: 0x0400806E RID: 32878
		[FieldOffset(5)]
		public TEnumAsByte<EPSOGeneratorBlendFactor> AlphaDestBlend;

		// Token: 0x0400806F RID: 32879
		[FieldOffset(6)]
		public TEnumAsByte<EPSOGeneratorColorWriteMask> ColorWriteMask;

		// Token: 0x04008070 RID: 32880
		public const string __ObjectPath = "/Script/Engine.PSOGeneratorConfigBlendStateTarget";

		// Token: 0x04008071 RID: 32881
		private static IntPtr _ScriptStructPtr;
	}
}
