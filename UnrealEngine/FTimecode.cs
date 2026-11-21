using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000151 RID: 337
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(20, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 20)]
	[UnrealObjectPath("/Script/CoreUObject.Timecode")]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 20)]
	public struct FTimecode : IEqualityOperators<FTimecode, FTimecode, bool>, IEquatable<FTimecode>, IUnrealScriptStruct
	{
		// Token: 0x06001315 RID: 4885 RVA: 0x0001E24A File Offset: 0x0001C44A
		public FTimecode(int Hours, int Minutes, int Seconds, int Frames, bool bDropFrameFormat)
		{
			this.Hours = Hours;
			this.Minutes = Minutes;
			this.Seconds = Seconds;
			this.Frames = Frames;
			this.bDropFrameFormat = bDropFrameFormat;
		}

		// Token: 0x06001316 RID: 4886 RVA: 0x0001E274 File Offset: 0x0001C474
		public static bool operator ==(FTimecode left, FTimecode right)
		{
			return left.Hours == right.Hours && left.Minutes == right.Minutes && left.Seconds == right.Seconds && left.Frames == right.Frames && left.bDropFrameFormat == right.bDropFrameFormat;
		}

		// Token: 0x06001317 RID: 4887 RVA: 0x0001E2C9 File Offset: 0x0001C4C9
		public static bool operator !=(FTimecode left, FTimecode right)
		{
			return !(left == right);
		}

		// Token: 0x06001318 RID: 4888 RVA: 0x0001E2D5 File Offset: 0x0001C4D5
		public bool Equals(FTimecode other)
		{
			return this == other;
		}

		// Token: 0x06001319 RID: 4889 RVA: 0x0001E2E4 File Offset: 0x0001C4E4
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			if (obj is FTimecode)
			{
				FTimecode other = (FTimecode)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x0600131A RID: 4890 RVA: 0x0001E309 File Offset: 0x0001C509
		public override int GetHashCode()
		{
			return HashCode.Combine<int, int, int, int, bool>(this.Hours, this.Minutes, this.Seconds, this.Frames, this.bDropFrameFormat);
		}

		// Token: 0x0600131B RID: 4891 RVA: 0x0001E32E File Offset: 0x0001C52E
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FTimecode._ScriptStructPtr != 0) ? FTimecode._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/CoreUObject.Timecode", ref FTimecode._ScriptStructPtr);
		}

		// Token: 0x04000607 RID: 1543
		[FieldOffset(0)]
		public int Hours;

		// Token: 0x04000608 RID: 1544
		[FieldOffset(4)]
		public int Minutes;

		// Token: 0x04000609 RID: 1545
		[FieldOffset(8)]
		public int Seconds;

		// Token: 0x0400060A RID: 1546
		[FieldOffset(12)]
		public int Frames;

		// Token: 0x0400060B RID: 1547
		[FieldOffset(16)]
		public bool bDropFrameFormat;

		// Token: 0x0400060C RID: 1548
		public const string __ObjectPath = "/Script/CoreUObject.Timecode";

		// Token: 0x0400060D RID: 1549
		private static IntPtr _ScriptStructPtr;
	}
}
