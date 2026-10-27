using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000759 RID: 1881
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(4, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 4)]
	[UnrealObjectPath("/Script/CoreUObject.PackedRGB10A2N")]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 4)]
	public struct FPackedRGB10A2N : IEqualityOperators<FPackedRGB10A2N, FPackedRGB10A2N, bool>, IEquatable<FPackedRGB10A2N>, IUnrealScriptStruct
	{
		// Token: 0x0600633A RID: 25402 RVA: 0x0008E76C File Offset: 0x0008C96C
		public FPackedRGB10A2N(int Packed)
		{
			this.Packed = Packed;
		}

		// Token: 0x0600633B RID: 25403 RVA: 0x0008E775 File Offset: 0x0008C975
		public static bool operator ==(FPackedRGB10A2N left, FPackedRGB10A2N right)
		{
			return left.Packed == right.Packed;
		}

		// Token: 0x0600633C RID: 25404 RVA: 0x0008E785 File Offset: 0x0008C985
		public static bool operator !=(FPackedRGB10A2N left, FPackedRGB10A2N right)
		{
			return !(left == right);
		}

		// Token: 0x0600633D RID: 25405 RVA: 0x0008E791 File Offset: 0x0008C991
		public bool Equals(FPackedRGB10A2N other)
		{
			return this == other;
		}

		// Token: 0x0600633E RID: 25406 RVA: 0x0008E7A0 File Offset: 0x0008C9A0
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			if (obj is FPackedRGB10A2N)
			{
				FPackedRGB10A2N other = (FPackedRGB10A2N)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x0600633F RID: 25407 RVA: 0x0008E7C5 File Offset: 0x0008C9C5
		public override int GetHashCode()
		{
			return HashCode.Combine<int>(this.Packed);
		}

		// Token: 0x06006340 RID: 25408 RVA: 0x0008E7D2 File Offset: 0x0008C9D2
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FPackedRGB10A2N._ScriptStructPtr != 0) ? FPackedRGB10A2N._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/CoreUObject.PackedRGB10A2N", ref FPackedRGB10A2N._ScriptStructPtr);
		}

		// Token: 0x04002F8D RID: 12173
		[FieldOffset(0)]
		public int Packed;

		// Token: 0x04002F8E RID: 12174
		public const string __ObjectPath = "/Script/CoreUObject.PackedRGB10A2N";

		// Token: 0x04002F8F RID: 12175
		private static IntPtr _ScriptStructPtr;
	}
}
