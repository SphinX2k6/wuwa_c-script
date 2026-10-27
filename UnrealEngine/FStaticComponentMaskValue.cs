using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200118C RID: 4492
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(4, 1, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 4)]
	[UnrealObjectPath("/Script/Engine.StaticComponentMaskValue")]
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 4)]
	public struct FStaticComponentMaskValue : IEqualityOperators<FStaticComponentMaskValue, FStaticComponentMaskValue, bool>, IEquatable<FStaticComponentMaskValue>, IUnrealScriptStruct
	{
		// Token: 0x06010813 RID: 67603 RVA: 0x00183BBC File Offset: 0x00181DBC
		public FStaticComponentMaskValue(bool R, bool G, bool B, bool A)
		{
			this.R = R;
			this.G = G;
			this.B = B;
			this.A = A;
		}

		// Token: 0x06010814 RID: 67604 RVA: 0x00183BDB File Offset: 0x00181DDB
		public static bool operator ==(FStaticComponentMaskValue left, FStaticComponentMaskValue right)
		{
			return left.R == right.R && left.G == right.G && left.B == right.B && left.A == right.A;
		}

		// Token: 0x06010815 RID: 67605 RVA: 0x00183C17 File Offset: 0x00181E17
		public static bool operator !=(FStaticComponentMaskValue left, FStaticComponentMaskValue right)
		{
			return !(left == right);
		}

		// Token: 0x06010816 RID: 67606 RVA: 0x00183C23 File Offset: 0x00181E23
		public bool Equals(FStaticComponentMaskValue other)
		{
			return this == other;
		}

		// Token: 0x06010817 RID: 67607 RVA: 0x00183C34 File Offset: 0x00181E34
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			if (obj is FStaticComponentMaskValue)
			{
				FStaticComponentMaskValue other = (FStaticComponentMaskValue)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x06010818 RID: 67608 RVA: 0x00183C59 File Offset: 0x00181E59
		public override int GetHashCode()
		{
			return HashCode.Combine<bool, bool, bool, bool>(this.R, this.G, this.B, this.A);
		}

		// Token: 0x06010819 RID: 67609 RVA: 0x00183C78 File Offset: 0x00181E78
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FStaticComponentMaskValue._ScriptStructPtr != 0) ? FStaticComponentMaskValue._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.StaticComponentMaskValue", ref FStaticComponentMaskValue._ScriptStructPtr);
		}

		// Token: 0x04008D3A RID: 36154
		[FieldOffset(0)]
		public bool R;

		// Token: 0x04008D3B RID: 36155
		[FieldOffset(1)]
		public bool G;

		// Token: 0x04008D3C RID: 36156
		[FieldOffset(2)]
		public bool B;

		// Token: 0x04008D3D RID: 36157
		[FieldOffset(3)]
		public bool A;

		// Token: 0x04008D3E RID: 36158
		public const string __ObjectPath = "/Script/Engine.StaticComponentMaskValue";

		// Token: 0x04008D3F RID: 36159
		private static IntPtr _ScriptStructPtr;
	}
}
