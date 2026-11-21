using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200081A RID: 2074
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(16, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 16)]
	[UnrealObjectPath("/Script/SlateCore.Margin")]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 16)]
	public struct FMargin : IEqualityOperators<FMargin, FMargin, bool>, IEquatable<FMargin>, IUnrealScriptStruct
	{
		// Token: 0x0600B5B5 RID: 46517 RVA: 0x00121191 File Offset: 0x0011F391
		public FMargin(float Left, float Top, float Right, float Bottom)
		{
			this.Left = Left;
			this.Top = Top;
			this.Right = Right;
			this.Bottom = Bottom;
		}

		// Token: 0x0600B5B6 RID: 46518 RVA: 0x001211B0 File Offset: 0x0011F3B0
		public static bool operator ==(FMargin left, FMargin right)
		{
			return left.Left == right.Left && left.Top == right.Top && left.Right == right.Right && left.Bottom == right.Bottom;
		}

		// Token: 0x0600B5B7 RID: 46519 RVA: 0x001211EC File Offset: 0x0011F3EC
		public static bool operator !=(FMargin left, FMargin right)
		{
			return !(left == right);
		}

		// Token: 0x0600B5B8 RID: 46520 RVA: 0x001211F8 File Offset: 0x0011F3F8
		public bool Equals(FMargin other)
		{
			return this == other;
		}

		// Token: 0x0600B5B9 RID: 46521 RVA: 0x00121208 File Offset: 0x0011F408
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			if (obj is FMargin)
			{
				FMargin other = (FMargin)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x0600B5BA RID: 46522 RVA: 0x0012122D File Offset: 0x0011F42D
		public override int GetHashCode()
		{
			return HashCode.Combine<float, float, float, float>(this.Left, this.Top, this.Right, this.Bottom);
		}

		// Token: 0x0600B5BB RID: 46523 RVA: 0x0012124C File Offset: 0x0011F44C
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMargin._ScriptStructPtr != 0) ? FMargin._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/SlateCore.Margin", ref FMargin._ScriptStructPtr);
		}

		// Token: 0x04005213 RID: 21011
		[FieldOffset(0)]
		public float Left;

		// Token: 0x04005214 RID: 21012
		[FieldOffset(4)]
		public float Top;

		// Token: 0x04005215 RID: 21013
		[FieldOffset(8)]
		public float Right;

		// Token: 0x04005216 RID: 21014
		[FieldOffset(12)]
		public float Bottom;

		// Token: 0x04005217 RID: 21015
		public const string __ObjectPath = "/Script/SlateCore.Margin";

		// Token: 0x04005218 RID: 21016
		private static IntPtr _ScriptStructPtr;
	}
}
