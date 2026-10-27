using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001A1D RID: 6685
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(16, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 16)]
	[UnrealObjectPath("/Script/KuroPerformance.KuroBoostQueryResult")]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 16)]
	public struct FKuroBoostQueryResult : IEqualityOperators<FKuroBoostQueryResult, FKuroBoostQueryResult, bool>, IEquatable<FKuroBoostQueryResult>, IUnrealScriptStruct
	{
		// Token: 0x06018BB2 RID: 101298 RVA: 0x0024805A File Offset: 0x0024625A
		public FKuroBoostQueryResult(int mode, int target, int percentage, int durationLeftInMillisecond)
		{
			this.mode = mode;
			this.target = target;
			this.percentage = percentage;
			this.durationLeftInMillisecond = durationLeftInMillisecond;
		}

		// Token: 0x06018BB3 RID: 101299 RVA: 0x00248079 File Offset: 0x00246279
		public static bool operator ==(FKuroBoostQueryResult left, FKuroBoostQueryResult right)
		{
			return left.mode == right.mode && left.target == right.target && left.percentage == right.percentage && left.durationLeftInMillisecond == right.durationLeftInMillisecond;
		}

		// Token: 0x06018BB4 RID: 101300 RVA: 0x002480B5 File Offset: 0x002462B5
		public static bool operator !=(FKuroBoostQueryResult left, FKuroBoostQueryResult right)
		{
			return !(left == right);
		}

		// Token: 0x06018BB5 RID: 101301 RVA: 0x002480C1 File Offset: 0x002462C1
		public bool Equals(FKuroBoostQueryResult other)
		{
			return this == other;
		}

		// Token: 0x06018BB6 RID: 101302 RVA: 0x002480D0 File Offset: 0x002462D0
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			if (obj is FKuroBoostQueryResult)
			{
				FKuroBoostQueryResult other = (FKuroBoostQueryResult)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x06018BB7 RID: 101303 RVA: 0x002480F5 File Offset: 0x002462F5
		public override int GetHashCode()
		{
			return HashCode.Combine<int, int, int, int>(this.mode, this.target, this.percentage, this.durationLeftInMillisecond);
		}

		// Token: 0x06018BB8 RID: 101304 RVA: 0x00248114 File Offset: 0x00246314
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroBoostQueryResult._ScriptStructPtr != 0) ? FKuroBoostQueryResult._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroPerformance.KuroBoostQueryResult", ref FKuroBoostQueryResult._ScriptStructPtr);
		}

		// Token: 0x0400D5CC RID: 54732
		[FieldOffset(0)]
		public readonly int mode;

		// Token: 0x0400D5CD RID: 54733
		[FieldOffset(4)]
		public readonly int target;

		// Token: 0x0400D5CE RID: 54734
		[FieldOffset(8)]
		public readonly int percentage;

		// Token: 0x0400D5CF RID: 54735
		[FieldOffset(12)]
		public readonly int durationLeftInMillisecond;

		// Token: 0x0400D5D0 RID: 54736
		public const string __ObjectPath = "/Script/KuroPerformance.KuroBoostQueryResult";

		// Token: 0x0400D5D1 RID: 54737
		private static IntPtr _ScriptStructPtr;
	}
}
