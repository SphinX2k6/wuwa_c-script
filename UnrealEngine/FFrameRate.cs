using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200072A RID: 1834
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(8, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 8)]
	[UnrealObjectPath("/Script/CoreUObject.FrameRate")]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 8)]
	public struct FFrameRate : IEqualityOperators<FFrameRate, FFrameRate, bool>, IEquatable<FFrameRate>, IUnrealScriptStruct
	{
		// Token: 0x060061EE RID: 25070 RVA: 0x0008C696 File Offset: 0x0008A896
		public FFrameRate(int Numerator, int Denominator)
		{
			this.Numerator = Numerator;
			this.Denominator = Denominator;
		}

		// Token: 0x060061EF RID: 25071 RVA: 0x0008C6A6 File Offset: 0x0008A8A6
		public static bool operator ==(FFrameRate left, FFrameRate right)
		{
			return left.Numerator == right.Numerator && left.Denominator == right.Denominator;
		}

		// Token: 0x060061F0 RID: 25072 RVA: 0x0008C6C6 File Offset: 0x0008A8C6
		public static bool operator !=(FFrameRate left, FFrameRate right)
		{
			return !(left == right);
		}

		// Token: 0x060061F1 RID: 25073 RVA: 0x0008C6D2 File Offset: 0x0008A8D2
		public bool Equals(FFrameRate other)
		{
			return this == other;
		}

		// Token: 0x060061F2 RID: 25074 RVA: 0x0008C6E0 File Offset: 0x0008A8E0
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

		// Token: 0x060061F3 RID: 25075 RVA: 0x0008C705 File Offset: 0x0008A905
		public override int GetHashCode()
		{
			return HashCode.Combine<int, int>(this.Numerator, this.Denominator);
		}

		// Token: 0x060061F4 RID: 25076 RVA: 0x0008C718 File Offset: 0x0008A918
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FFrameRate._ScriptStructPtr != 0) ? FFrameRate._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/CoreUObject.FrameRate", ref FFrameRate._ScriptStructPtr);
		}

		// Token: 0x04002EC0 RID: 11968
		[FieldOffset(0)]
		public int Numerator;

		// Token: 0x04002EC1 RID: 11969
		[FieldOffset(4)]
		public int Denominator;

		// Token: 0x04002EC2 RID: 11970
		public const string __ObjectPath = "/Script/CoreUObject.FrameRate";

		// Token: 0x04002EC3 RID: 11971
		private static IntPtr _ScriptStructPtr;
	}
}
