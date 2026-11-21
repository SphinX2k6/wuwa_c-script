using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000110 RID: 272
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(8, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 8)]
	[UnrealObjectPath("/Script/CoreUObject.FrameRate")]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 8)]
	public struct FFrameRate : IEqualityOperators<FFrameRate, FFrameRate, bool>, IEquatable<FFrameRate>, IUnrealScriptStruct
	{
		// Token: 0x06001152 RID: 4434 RVA: 0x0001B6FC File Offset: 0x000198FC
		public FFrameRate(int Numerator, int Denominator)
		{
			this.Numerator = Numerator;
			this.Denominator = Denominator;
		}

		// Token: 0x06001153 RID: 4435 RVA: 0x0001B70C File Offset: 0x0001990C
		public static bool operator ==(FFrameRate left, FFrameRate right)
		{
			return left.Numerator == right.Numerator && left.Denominator == right.Denominator;
		}

		// Token: 0x06001154 RID: 4436 RVA: 0x0001B72C File Offset: 0x0001992C
		public static bool operator !=(FFrameRate left, FFrameRate right)
		{
			return !(left == right);
		}

		// Token: 0x06001155 RID: 4437 RVA: 0x0001B738 File Offset: 0x00019938
		public bool Equals(FFrameRate other)
		{
			return this == other;
		}

		// Token: 0x06001156 RID: 4438 RVA: 0x0001B748 File Offset: 0x00019948
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			if (obj is FFrameRate)
			{
				FFrameRate other = (FFrameRate)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x06001157 RID: 4439 RVA: 0x0001B76D File Offset: 0x0001996D
		public override int GetHashCode()
		{
			return HashCode.Combine<int, int>(this.Numerator, this.Denominator);
		}

		// Token: 0x06001158 RID: 4440 RVA: 0x0001B780 File Offset: 0x00019980
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FFrameRate._ScriptStructPtr != 0) ? FFrameRate._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/CoreUObject.FrameRate", ref FFrameRate._ScriptStructPtr);
		}

		// Token: 0x040004F6 RID: 1270
		[FieldOffset(0)]
		public int Numerator;

		// Token: 0x040004F7 RID: 1271
		[FieldOffset(4)]
		public int Denominator;

		// Token: 0x040004F8 RID: 1272
		public const string __ObjectPath = "/Script/CoreUObject.FrameRate";

		// Token: 0x040004F9 RID: 1273
		private static IntPtr _ScriptStructPtr;
	}
}
