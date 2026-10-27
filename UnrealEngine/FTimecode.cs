using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200076B RID: 1899
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(20, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 20)]
	[UnrealObjectPath("/Script/CoreUObject.Timecode")]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 20)]
	public struct FTimecode : IEqualityOperators<FTimecode, FTimecode, bool>, IEquatable<FTimecode>, IUnrealScriptStruct
	{
		// Token: 0x060063BD RID: 25533 RVA: 0x0008F356 File Offset: 0x0008D556
		public FTimecode(int Hours, int Minutes, int Seconds, int Frames, bool bDropFrameFormat)
		{
			this.Hours = Hours;
			this.Minutes = Minutes;
			this.Seconds = Seconds;
			this.Frames = Frames;
			this.bDropFrameFormat = bDropFrameFormat;
		}

		// Token: 0x060063BE RID: 25534 RVA: 0x0008F380 File Offset: 0x0008D580
		public static bool operator ==(FTimecode left, FTimecode right)
		{
			return left.Hours == right.Hours && left.Minutes == right.Minutes && left.Seconds == right.Seconds && left.Frames == right.Frames && left.bDropFrameFormat == right.bDropFrameFormat;
		}

		// Token: 0x060063BF RID: 25535 RVA: 0x0008F3D5 File Offset: 0x0008D5D5
		public static bool operator !=(FTimecode left, FTimecode right)
		{
			return !(left == right);
		}

		// Token: 0x060063C0 RID: 25536 RVA: 0x0008F3E1 File Offset: 0x0008D5E1
		public bool Equals(FTimecode other)
		{
			return this == other;
		}

		// Token: 0x060063C1 RID: 25537 RVA: 0x0008F3F0 File Offset: 0x0008D5F0
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

		// Token: 0x060063C2 RID: 25538 RVA: 0x0008F415 File Offset: 0x0008D615
		public override int GetHashCode()
		{
			return HashCode.Combine<int, int, int, int, bool>(this.Hours, this.Minutes, this.Seconds, this.Frames, this.bDropFrameFormat);
		}

		// Token: 0x060063C3 RID: 25539 RVA: 0x0008F43A File Offset: 0x0008D63A
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FTimecode._ScriptStructPtr != 0) ? FTimecode._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/CoreUObject.Timecode", ref FTimecode._ScriptStructPtr);
		}

		// Token: 0x04002FD1 RID: 12241
		[FieldOffset(0)]
		public int Hours;

		// Token: 0x04002FD2 RID: 12242
		[FieldOffset(4)]
		public int Minutes;

		// Token: 0x04002FD3 RID: 12243
		[FieldOffset(8)]
		public int Seconds;

		// Token: 0x04002FD4 RID: 12244
		[FieldOffset(12)]
		public int Frames;

		// Token: 0x04002FD5 RID: 12245
		[FieldOffset(16)]
		public bool bDropFrameFormat;

		// Token: 0x04002FD6 RID: 12246
		public const string __ObjectPath = "/Script/CoreUObject.Timecode";

		// Token: 0x04002FD7 RID: 12247
		private static IntPtr _ScriptStructPtr;
	}
}
