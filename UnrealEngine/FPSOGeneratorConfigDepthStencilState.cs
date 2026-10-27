using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200104C RID: 4172
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(14, 1, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 14)]
	[UnrealObjectPath("/Script/Engine.PSOGeneratorConfigDepthStencilState")]
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 14)]
	public struct FPSOGeneratorConfigDepthStencilState : IEqualityOperators<FPSOGeneratorConfigDepthStencilState, FPSOGeneratorConfigDepthStencilState, bool>, IEquatable<FPSOGeneratorConfigDepthStencilState>, IUnrealScriptStruct
	{
		// Token: 0x0600ED55 RID: 60757 RVA: 0x00160040 File Offset: 0x0015E240
		public FPSOGeneratorConfigDepthStencilState(bool bEnableDepthWrite, TEnumAsByte<EPSOGeneratorCompareFunction> DepthTest, bool bEnableFrontFaceStencil, TEnumAsByte<EPSOGeneratorCompareFunction> FrontFaceStencilTest, TEnumAsByte<EPSOGeneratorStencilOp> FrontFaceStencilFailStencilOp, TEnumAsByte<EPSOGeneratorStencilOp> FrontFaceDepthFailStencilOp, TEnumAsByte<EPSOGeneratorStencilOp> FrontFacePassStencilOp, bool bEnableBackFaceStencil, TEnumAsByte<EPSOGeneratorCompareFunction> BackFaceStencilTest, TEnumAsByte<EPSOGeneratorStencilOp> BackFaceStencilFailStencilOp, TEnumAsByte<EPSOGeneratorStencilOp> BackFaceDepthFailStencilOp, TEnumAsByte<EPSOGeneratorStencilOp> BackFacePassStencilOp, byte StencilReadMask, byte StencilWriteMask)
		{
			this.bEnableDepthWrite = bEnableDepthWrite;
			this.DepthTest = DepthTest;
			this.bEnableFrontFaceStencil = bEnableFrontFaceStencil;
			this.FrontFaceStencilTest = FrontFaceStencilTest;
			this.FrontFaceStencilFailStencilOp = FrontFaceStencilFailStencilOp;
			this.FrontFaceDepthFailStencilOp = FrontFaceDepthFailStencilOp;
			this.FrontFacePassStencilOp = FrontFacePassStencilOp;
			this.bEnableBackFaceStencil = bEnableBackFaceStencil;
			this.BackFaceStencilTest = BackFaceStencilTest;
			this.BackFaceStencilFailStencilOp = BackFaceStencilFailStencilOp;
			this.BackFaceDepthFailStencilOp = BackFaceDepthFailStencilOp;
			this.BackFacePassStencilOp = BackFacePassStencilOp;
			this.StencilReadMask = StencilReadMask;
			this.StencilWriteMask = StencilWriteMask;
		}

		// Token: 0x0600ED56 RID: 60758 RVA: 0x001600BC File Offset: 0x0015E2BC
		public static bool operator ==(FPSOGeneratorConfigDepthStencilState left, FPSOGeneratorConfigDepthStencilState right)
		{
			return left.bEnableDepthWrite == right.bEnableDepthWrite && left.DepthTest == right.DepthTest && left.bEnableFrontFaceStencil == right.bEnableFrontFaceStencil && left.FrontFaceStencilTest == right.FrontFaceStencilTest && left.FrontFaceStencilFailStencilOp == right.FrontFaceStencilFailStencilOp && left.FrontFaceDepthFailStencilOp == right.FrontFaceDepthFailStencilOp && left.FrontFacePassStencilOp == right.FrontFacePassStencilOp && left.bEnableBackFaceStencil == right.bEnableBackFaceStencil && left.BackFaceStencilTest == right.BackFaceStencilTest && left.BackFaceStencilFailStencilOp == right.BackFaceStencilFailStencilOp && left.BackFaceDepthFailStencilOp == right.BackFaceDepthFailStencilOp && left.BackFacePassStencilOp == right.BackFacePassStencilOp && left.StencilReadMask == right.StencilReadMask && left.StencilWriteMask == right.StencilWriteMask;
		}

		// Token: 0x0600ED57 RID: 60759 RVA: 0x001601CE File Offset: 0x0015E3CE
		public static bool operator !=(FPSOGeneratorConfigDepthStencilState left, FPSOGeneratorConfigDepthStencilState right)
		{
			return !(left == right);
		}

		// Token: 0x0600ED58 RID: 60760 RVA: 0x001601DA File Offset: 0x0015E3DA
		public bool Equals(FPSOGeneratorConfigDepthStencilState other)
		{
			return this == other;
		}

		// Token: 0x0600ED59 RID: 60761 RVA: 0x001601E8 File Offset: 0x0015E3E8
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			if (obj is FPSOGeneratorConfigDepthStencilState)
			{
				FPSOGeneratorConfigDepthStencilState other = (FPSOGeneratorConfigDepthStencilState)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x0600ED5A RID: 60762 RVA: 0x00160210 File Offset: 0x0015E410
		public override int GetHashCode()
		{
			HashCode hashCode = default(HashCode);
			hashCode.Add<bool>(this.bEnableDepthWrite);
			hashCode.Add<TEnumAsByte<EPSOGeneratorCompareFunction>>(this.DepthTest);
			hashCode.Add<bool>(this.bEnableFrontFaceStencil);
			hashCode.Add<TEnumAsByte<EPSOGeneratorCompareFunction>>(this.FrontFaceStencilTest);
			hashCode.Add<TEnumAsByte<EPSOGeneratorStencilOp>>(this.FrontFaceStencilFailStencilOp);
			hashCode.Add<TEnumAsByte<EPSOGeneratorStencilOp>>(this.FrontFaceDepthFailStencilOp);
			hashCode.Add<TEnumAsByte<EPSOGeneratorStencilOp>>(this.FrontFacePassStencilOp);
			hashCode.Add<bool>(this.bEnableBackFaceStencil);
			hashCode.Add<TEnumAsByte<EPSOGeneratorCompareFunction>>(this.BackFaceStencilTest);
			hashCode.Add<TEnumAsByte<EPSOGeneratorStencilOp>>(this.BackFaceStencilFailStencilOp);
			hashCode.Add<TEnumAsByte<EPSOGeneratorStencilOp>>(this.BackFaceDepthFailStencilOp);
			hashCode.Add<TEnumAsByte<EPSOGeneratorStencilOp>>(this.BackFacePassStencilOp);
			hashCode.Add<byte>(this.StencilReadMask);
			hashCode.Add<byte>(this.StencilWriteMask);
			return hashCode.ToHashCode();
		}

		// Token: 0x0600ED5B RID: 60763 RVA: 0x001602E2 File Offset: 0x0015E4E2
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FPSOGeneratorConfigDepthStencilState._ScriptStructPtr != 0) ? FPSOGeneratorConfigDepthStencilState._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.PSOGeneratorConfigDepthStencilState", ref FPSOGeneratorConfigDepthStencilState._ScriptStructPtr);
		}

		// Token: 0x0400807A RID: 32890
		[FieldOffset(0)]
		public bool bEnableDepthWrite;

		// Token: 0x0400807B RID: 32891
		[FieldOffset(1)]
		public TEnumAsByte<EPSOGeneratorCompareFunction> DepthTest;

		// Token: 0x0400807C RID: 32892
		[FieldOffset(2)]
		public bool bEnableFrontFaceStencil;

		// Token: 0x0400807D RID: 32893
		[FieldOffset(3)]
		public TEnumAsByte<EPSOGeneratorCompareFunction> FrontFaceStencilTest;

		// Token: 0x0400807E RID: 32894
		[FieldOffset(4)]
		public TEnumAsByte<EPSOGeneratorStencilOp> FrontFaceStencilFailStencilOp;

		// Token: 0x0400807F RID: 32895
		[FieldOffset(5)]
		public TEnumAsByte<EPSOGeneratorStencilOp> FrontFaceDepthFailStencilOp;

		// Token: 0x04008080 RID: 32896
		[FieldOffset(6)]
		public TEnumAsByte<EPSOGeneratorStencilOp> FrontFacePassStencilOp;

		// Token: 0x04008081 RID: 32897
		[FieldOffset(7)]
		public bool bEnableBackFaceStencil;

		// Token: 0x04008082 RID: 32898
		[FieldOffset(8)]
		public TEnumAsByte<EPSOGeneratorCompareFunction> BackFaceStencilTest;

		// Token: 0x04008083 RID: 32899
		[FieldOffset(9)]
		public TEnumAsByte<EPSOGeneratorStencilOp> BackFaceStencilFailStencilOp;

		// Token: 0x04008084 RID: 32900
		[FieldOffset(10)]
		public TEnumAsByte<EPSOGeneratorStencilOp> BackFaceDepthFailStencilOp;

		// Token: 0x04008085 RID: 32901
		[FieldOffset(11)]
		public TEnumAsByte<EPSOGeneratorStencilOp> BackFacePassStencilOp;

		// Token: 0x04008086 RID: 32902
		[FieldOffset(12)]
		public byte StencilReadMask;

		// Token: 0x04008087 RID: 32903
		[FieldOffset(13)]
		public byte StencilWriteMask;

		// Token: 0x04008088 RID: 32904
		public const string __ObjectPath = "/Script/Engine.PSOGeneratorConfigDepthStencilState";

		// Token: 0x04008089 RID: 32905
		private static IntPtr _ScriptStructPtr;
	}
}
