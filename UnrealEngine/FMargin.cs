using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002821 RID: 10273
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(16, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 16)]
	[UnrealObjectPath("/Script/SlateCore.Margin")]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 16)]
	public struct FMargin : IEqualityOperators<FMargin, FMargin, bool>, IEquatable<FMargin>, IUnrealScriptStruct
	{
		// Token: 0x060262DB RID: 156379 RVA: 0x0039EF87 File Offset: 0x0039D187
		public FMargin(float Left, float Top, float Right, float Bottom)
		{
			this.Left = Left;
			this.Top = Top;
			this.Right = Right;
			this.Bottom = Bottom;
		}

		// Token: 0x060262DC RID: 156380 RVA: 0x0039EFA6 File Offset: 0x0039D1A6
		public static bool operator ==(FMargin left, FMargin right)
		{
			return left.Left == right.Left && left.Top == right.Top && left.Right == right.Right && left.Bottom == right.Bottom;
		}

		// Token: 0x060262DD RID: 156381 RVA: 0x0039EFE2 File Offset: 0x0039D1E2
		public static bool operator !=(FMargin left, FMargin right)
		{
			return !(left == right);
		}

		// Token: 0x060262DE RID: 156382 RVA: 0x0039EFEE File Offset: 0x0039D1EE
		public bool Equals(FMargin other)
		{
			return this == other;
		}

		// Token: 0x060262DF RID: 156383 RVA: 0x0039EFFC File Offset: 0x0039D1FC
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

		// Token: 0x060262E0 RID: 156384 RVA: 0x0039F021 File Offset: 0x0039D221
		public override int GetHashCode()
		{
			return HashCode.Combine<float, float, float, float>(this.Left, this.Top, this.Right, this.Bottom);
		}

		// Token: 0x060262E1 RID: 156385 RVA: 0x0039F040 File Offset: 0x0039D240
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMargin._ScriptStructPtr != 0) ? FMargin._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/SlateCore.Margin", ref FMargin._ScriptStructPtr);
		}

		// Token: 0x04014E56 RID: 85590
		[FieldOffset(0)]
		public float Left;

		// Token: 0x04014E57 RID: 85591
		[FieldOffset(4)]
		public float Top;

		// Token: 0x04014E58 RID: 85592
		[FieldOffset(8)]
		public float Right;

		// Token: 0x04014E59 RID: 85593
		[FieldOffset(12)]
		public float Bottom;

		// Token: 0x04014E5A RID: 85594
		public const string __ObjectPath = "/Script/SlateCore.Margin";

		// Token: 0x04014E5B RID: 85595
		private static IntPtr _ScriptStructPtr;
	}
}
