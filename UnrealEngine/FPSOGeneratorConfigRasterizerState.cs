using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200104E RID: 4174
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(12, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 12)]
	[UnrealObjectPath("/Script/Engine.PSOGeneratorConfigRasterizerState")]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 12)]
	public struct FPSOGeneratorConfigRasterizerState : IEqualityOperators<FPSOGeneratorConfigRasterizerState, FPSOGeneratorConfigRasterizerState, bool>, IEquatable<FPSOGeneratorConfigRasterizerState>, IUnrealScriptStruct
	{
		// Token: 0x0600ED7C RID: 60796 RVA: 0x001606D8 File Offset: 0x0015E8D8
		public FPSOGeneratorConfigRasterizerState(float DepthBias, float SlopeScaleDepthBias, TEnumAsByte<EPSOGeneratorRasterizerFillMode> FillMode, TEnumAsByte<EPSOGeneratorRasterizerCullMode> CullMode, bool bAllowMSAA, bool bEnableLineAA)
		{
			this.DepthBias = DepthBias;
			this.SlopeScaleDepthBias = SlopeScaleDepthBias;
			this.FillMode = FillMode;
			this.CullMode = CullMode;
			this.bAllowMSAA = bAllowMSAA;
			this.bEnableLineAA = bEnableLineAA;
		}

		// Token: 0x0600ED7D RID: 60797 RVA: 0x00160708 File Offset: 0x0015E908
		public static bool operator ==(FPSOGeneratorConfigRasterizerState left, FPSOGeneratorConfigRasterizerState right)
		{
			return left.DepthBias == right.DepthBias && left.SlopeScaleDepthBias == right.SlopeScaleDepthBias && left.FillMode == right.FillMode && left.CullMode == right.CullMode && left.bAllowMSAA == right.bAllowMSAA && left.bEnableLineAA == right.bEnableLineAA;
		}

		// Token: 0x0600ED7E RID: 60798 RVA: 0x00160775 File Offset: 0x0015E975
		public static bool operator !=(FPSOGeneratorConfigRasterizerState left, FPSOGeneratorConfigRasterizerState right)
		{
			return !(left == right);
		}

		// Token: 0x0600ED7F RID: 60799 RVA: 0x00160781 File Offset: 0x0015E981
		public bool Equals(FPSOGeneratorConfigRasterizerState other)
		{
			return this == other;
		}

		// Token: 0x0600ED80 RID: 60800 RVA: 0x00160790 File Offset: 0x0015E990
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			if (obj is FPSOGeneratorConfigRasterizerState)
			{
				FPSOGeneratorConfigRasterizerState other = (FPSOGeneratorConfigRasterizerState)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x0600ED81 RID: 60801 RVA: 0x001607B5 File Offset: 0x0015E9B5
		public override int GetHashCode()
		{
			return HashCode.Combine<float, float, TEnumAsByte<EPSOGeneratorRasterizerFillMode>, TEnumAsByte<EPSOGeneratorRasterizerCullMode>, bool, bool>(this.DepthBias, this.SlopeScaleDepthBias, this.FillMode, this.CullMode, this.bAllowMSAA, this.bEnableLineAA);
		}

		// Token: 0x0600ED82 RID: 60802 RVA: 0x001607E0 File Offset: 0x0015E9E0
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FPSOGeneratorConfigRasterizerState._ScriptStructPtr != 0) ? FPSOGeneratorConfigRasterizerState._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.PSOGeneratorConfigRasterizerState", ref FPSOGeneratorConfigRasterizerState._ScriptStructPtr);
		}

		// Token: 0x0400809F RID: 32927
		[FieldOffset(0)]
		public float DepthBias;

		// Token: 0x040080A0 RID: 32928
		[FieldOffset(4)]
		public float SlopeScaleDepthBias;

		// Token: 0x040080A1 RID: 32929
		[FieldOffset(8)]
		public TEnumAsByte<EPSOGeneratorRasterizerFillMode> FillMode;

		// Token: 0x040080A2 RID: 32930
		[FieldOffset(9)]
		public TEnumAsByte<EPSOGeneratorRasterizerCullMode> CullMode;

		// Token: 0x040080A3 RID: 32931
		[FieldOffset(10)]
		public bool bAllowMSAA;

		// Token: 0x040080A4 RID: 32932
		[FieldOffset(11)]
		public bool bEnableLineAA;

		// Token: 0x040080A5 RID: 32933
		public const string __ObjectPath = "/Script/Engine.PSOGeneratorConfigRasterizerState";

		// Token: 0x040080A6 RID: 32934
		private static IntPtr _ScriptStructPtr;
	}
}
