using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020020D6 RID: 8406
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(24, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 24)]
	[UnrealObjectPath("/Script/LGUI.LGUIThaiCharConfig")]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 24)]
	public struct FLGUIThaiCharConfig : IEqualityOperators<FLGUIThaiCharConfig, FLGUIThaiCharConfig, bool>, IEquatable<FLGUIThaiCharConfig>, IUnrealScriptStruct
	{
		// Token: 0x0601FAA4 RID: 129700 RVA: 0x002F1795 File Offset: 0x002EF995
		public FLGUIThaiCharConfig(float DoubleAboveDiacriticFixYOffset, float DoubleAboveDiacriticFixXOffset, float DoubleAboveDiacriticFixWidthOffset, float DoubleAboveDiacriticFixHeightOffset, float DoubleAboveDiacriticThaiMaiHanAKatAndThaiMaiTriFixXOffset, float ThaiPaFaFixXOffset)
		{
			this.DoubleAboveDiacriticFixYOffset = DoubleAboveDiacriticFixYOffset;
			this.DoubleAboveDiacriticFixXOffset = DoubleAboveDiacriticFixXOffset;
			this.DoubleAboveDiacriticFixWidthOffset = DoubleAboveDiacriticFixWidthOffset;
			this.DoubleAboveDiacriticFixHeightOffset = DoubleAboveDiacriticFixHeightOffset;
			this.DoubleAboveDiacriticThaiMaiHanAKatAndThaiMaiTriFixXOffset = DoubleAboveDiacriticThaiMaiHanAKatAndThaiMaiTriFixXOffset;
			this.ThaiPaFaFixXOffset = ThaiPaFaFixXOffset;
		}

		// Token: 0x0601FAA5 RID: 129701 RVA: 0x002F17C4 File Offset: 0x002EF9C4
		public static bool operator ==(FLGUIThaiCharConfig left, FLGUIThaiCharConfig right)
		{
			return left.DoubleAboveDiacriticFixYOffset == right.DoubleAboveDiacriticFixYOffset && left.DoubleAboveDiacriticFixXOffset == right.DoubleAboveDiacriticFixXOffset && left.DoubleAboveDiacriticFixWidthOffset == right.DoubleAboveDiacriticFixWidthOffset && left.DoubleAboveDiacriticFixHeightOffset == right.DoubleAboveDiacriticFixHeightOffset && left.DoubleAboveDiacriticThaiMaiHanAKatAndThaiMaiTriFixXOffset == right.DoubleAboveDiacriticThaiMaiHanAKatAndThaiMaiTriFixXOffset && left.ThaiPaFaFixXOffset == right.ThaiPaFaFixXOffset;
		}

		// Token: 0x0601FAA6 RID: 129702 RVA: 0x002F1827 File Offset: 0x002EFA27
		public static bool operator !=(FLGUIThaiCharConfig left, FLGUIThaiCharConfig right)
		{
			return !(left == right);
		}

		// Token: 0x0601FAA7 RID: 129703 RVA: 0x002F1833 File Offset: 0x002EFA33
		public bool Equals(FLGUIThaiCharConfig other)
		{
			return this == other;
		}

		// Token: 0x0601FAA8 RID: 129704 RVA: 0x002F1844 File Offset: 0x002EFA44
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			if (obj is FLGUIThaiCharConfig)
			{
				FLGUIThaiCharConfig other = (FLGUIThaiCharConfig)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x0601FAA9 RID: 129705 RVA: 0x002F1869 File Offset: 0x002EFA69
		public override int GetHashCode()
		{
			return HashCode.Combine<float, float, float, float, float, float>(this.DoubleAboveDiacriticFixYOffset, this.DoubleAboveDiacriticFixXOffset, this.DoubleAboveDiacriticFixWidthOffset, this.DoubleAboveDiacriticFixHeightOffset, this.DoubleAboveDiacriticThaiMaiHanAKatAndThaiMaiTriFixXOffset, this.ThaiPaFaFixXOffset);
		}

		// Token: 0x0601FAAA RID: 129706 RVA: 0x002F1894 File Offset: 0x002EFA94
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FLGUIThaiCharConfig._ScriptStructPtr != 0) ? FLGUIThaiCharConfig._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/LGUI.LGUIThaiCharConfig", ref FLGUIThaiCharConfig._ScriptStructPtr);
		}

		// Token: 0x0401115C RID: 69980
		[FieldOffset(0)]
		public float DoubleAboveDiacriticFixYOffset;

		// Token: 0x0401115D RID: 69981
		[FieldOffset(4)]
		public float DoubleAboveDiacriticFixXOffset;

		// Token: 0x0401115E RID: 69982
		[FieldOffset(8)]
		public float DoubleAboveDiacriticFixWidthOffset;

		// Token: 0x0401115F RID: 69983
		[FieldOffset(12)]
		public float DoubleAboveDiacriticFixHeightOffset;

		// Token: 0x04011160 RID: 69984
		[FieldOffset(16)]
		public float DoubleAboveDiacriticThaiMaiHanAKatAndThaiMaiTriFixXOffset;

		// Token: 0x04011161 RID: 69985
		[FieldOffset(20)]
		public float ThaiPaFaFixXOffset;

		// Token: 0x04011162 RID: 69986
		public const string __ObjectPath = "/Script/LGUI.LGUIThaiCharConfig";

		// Token: 0x04011163 RID: 69987
		private static IntPtr _ScriptStructPtr;
	}
}
