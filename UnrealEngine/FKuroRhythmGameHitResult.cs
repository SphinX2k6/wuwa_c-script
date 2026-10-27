using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001C51 RID: 7249
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(12, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 12)]
	[UnrealObjectPath("/Script/KuroRhythmGame.KuroRhythmGameHitResult")]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 12)]
	public struct FKuroRhythmGameHitResult : IEqualityOperators<FKuroRhythmGameHitResult, FKuroRhythmGameHitResult, bool>, IEquatable<FKuroRhythmGameHitResult>, IUnrealScriptStruct
	{
		// Token: 0x0601C187 RID: 115079 RVA: 0x00295A86 File Offset: 0x00293C86
		public FKuroRhythmGameHitResult(EKuroRhythmGameRating Rating, float TimingError, int Score)
		{
			this.Rating = Rating;
			this.TimingError = TimingError;
			this.Score = Score;
		}

		// Token: 0x0601C188 RID: 115080 RVA: 0x00295A9D File Offset: 0x00293C9D
		public static bool operator ==(FKuroRhythmGameHitResult left, FKuroRhythmGameHitResult right)
		{
			return left.Rating == right.Rating && left.TimingError == right.TimingError && left.Score == right.Score;
		}

		// Token: 0x0601C189 RID: 115081 RVA: 0x00295ACB File Offset: 0x00293CCB
		public static bool operator !=(FKuroRhythmGameHitResult left, FKuroRhythmGameHitResult right)
		{
			return !(left == right);
		}

		// Token: 0x0601C18A RID: 115082 RVA: 0x00295AD7 File Offset: 0x00293CD7
		public bool Equals(FKuroRhythmGameHitResult other)
		{
			return this == other;
		}

		// Token: 0x0601C18B RID: 115083 RVA: 0x00295AE8 File Offset: 0x00293CE8
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			if (obj is FKuroRhythmGameHitResult)
			{
				FKuroRhythmGameHitResult other = (FKuroRhythmGameHitResult)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x0601C18C RID: 115084 RVA: 0x00295B0D File Offset: 0x00293D0D
		public override int GetHashCode()
		{
			return HashCode.Combine<EKuroRhythmGameRating, float, int>(this.Rating, this.TimingError, this.Score);
		}

		// Token: 0x0601C18D RID: 115085 RVA: 0x00295B26 File Offset: 0x00293D26
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroRhythmGameHitResult._ScriptStructPtr != 0) ? FKuroRhythmGameHitResult._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroRhythmGame.KuroRhythmGameHitResult", ref FKuroRhythmGameHitResult._ScriptStructPtr);
		}

		// Token: 0x0400F1B8 RID: 61880
		[FieldOffset(0)]
		public EKuroRhythmGameRating Rating;

		// Token: 0x0400F1B9 RID: 61881
		[FieldOffset(4)]
		public float TimingError;

		// Token: 0x0400F1BA RID: 61882
		[FieldOffset(8)]
		public int Score;

		// Token: 0x0400F1BB RID: 61883
		public const string __ObjectPath = "/Script/KuroRhythmGame.KuroRhythmGameHitResult";

		// Token: 0x0400F1BC RID: 61884
		private static IntPtr _ScriptStructPtr;
	}
}
