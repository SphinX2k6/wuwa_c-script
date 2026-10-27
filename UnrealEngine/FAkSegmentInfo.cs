using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200023E RID: 574
	[UnrealObjectPath("/Script/AkAudio.AkSegmentInfo")]
	[UnrealStructLayout(36, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 36)]
	public class FAkSegmentInfo : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600217A RID: 8570 RVA: 0x00031B5D File Offset: 0x0002FD5D
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAkSegmentInfo._ScriptStructPtr != 0) ? FAkSegmentInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AkAudio.AkSegmentInfo", ref FAkSegmentInfo._ScriptStructPtr);
		}

		// Token: 0x17000815 RID: 2069
		// (get) Token: 0x0600217B RID: 8571 RVA: 0x00031B81 File Offset: 0x0002FD81
		// (set) Token: 0x0600217C RID: 8572 RVA: 0x00031B91 File Offset: 0x0002FD91
		public unsafe int CurrentPosition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAkSegmentInfo.__PropertyOffset_CurrentPosition);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAkSegmentInfo.__PropertyOffset_CurrentPosition) = value;
			}
		}

		// Token: 0x17000816 RID: 2070
		// (get) Token: 0x0600217D RID: 8573 RVA: 0x00031BA2 File Offset: 0x0002FDA2
		// (set) Token: 0x0600217E RID: 8574 RVA: 0x00031BB2 File Offset: 0x0002FDB2
		public unsafe int PreEntryDuration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAkSegmentInfo.__PropertyOffset_PreEntryDuration);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAkSegmentInfo.__PropertyOffset_PreEntryDuration) = value;
			}
		}

		// Token: 0x17000817 RID: 2071
		// (get) Token: 0x0600217F RID: 8575 RVA: 0x00031BC3 File Offset: 0x0002FDC3
		// (set) Token: 0x06002180 RID: 8576 RVA: 0x00031BD3 File Offset: 0x0002FDD3
		public unsafe int ActiveDuration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAkSegmentInfo.__PropertyOffset_ActiveDuration);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAkSegmentInfo.__PropertyOffset_ActiveDuration) = value;
			}
		}

		// Token: 0x17000818 RID: 2072
		// (get) Token: 0x06002181 RID: 8577 RVA: 0x00031BE4 File Offset: 0x0002FDE4
		// (set) Token: 0x06002182 RID: 8578 RVA: 0x00031BF4 File Offset: 0x0002FDF4
		public unsafe int PostExitDuration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAkSegmentInfo.__PropertyOffset_PostExitDuration);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAkSegmentInfo.__PropertyOffset_PostExitDuration) = value;
			}
		}

		// Token: 0x17000819 RID: 2073
		// (get) Token: 0x06002183 RID: 8579 RVA: 0x00031C05 File Offset: 0x0002FE05
		// (set) Token: 0x06002184 RID: 8580 RVA: 0x00031C15 File Offset: 0x0002FE15
		public unsafe int RemainingLookAheadTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAkSegmentInfo.__PropertyOffset_RemainingLookAheadTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAkSegmentInfo.__PropertyOffset_RemainingLookAheadTime) = value;
			}
		}

		// Token: 0x1700081A RID: 2074
		// (get) Token: 0x06002185 RID: 8581 RVA: 0x00031C26 File Offset: 0x0002FE26
		// (set) Token: 0x06002186 RID: 8582 RVA: 0x00031C36 File Offset: 0x0002FE36
		public unsafe float BeatDuration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAkSegmentInfo.__PropertyOffset_BeatDuration);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAkSegmentInfo.__PropertyOffset_BeatDuration) = value;
			}
		}

		// Token: 0x1700081B RID: 2075
		// (get) Token: 0x06002187 RID: 8583 RVA: 0x00031C47 File Offset: 0x0002FE47
		// (set) Token: 0x06002188 RID: 8584 RVA: 0x00031C57 File Offset: 0x0002FE57
		public unsafe float BarDuration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAkSegmentInfo.__PropertyOffset_BarDuration);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAkSegmentInfo.__PropertyOffset_BarDuration) = value;
			}
		}

		// Token: 0x1700081C RID: 2076
		// (get) Token: 0x06002189 RID: 8585 RVA: 0x00031C68 File Offset: 0x0002FE68
		// (set) Token: 0x0600218A RID: 8586 RVA: 0x00031C78 File Offset: 0x0002FE78
		public unsafe float GridDuration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAkSegmentInfo.__PropertyOffset_GridDuration);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAkSegmentInfo.__PropertyOffset_GridDuration) = value;
			}
		}

		// Token: 0x1700081D RID: 2077
		// (get) Token: 0x0600218B RID: 8587 RVA: 0x00031C89 File Offset: 0x0002FE89
		// (set) Token: 0x0600218C RID: 8588 RVA: 0x00031C99 File Offset: 0x0002FE99
		public unsafe float GridOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAkSegmentInfo.__PropertyOffset_GridOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAkSegmentInfo.__PropertyOffset_GridOffset) = value;
			}
		}

		// Token: 0x0600218D RID: 8589 RVA: 0x00031CAA File Offset: 0x0002FEAA
		public FAkSegmentInfo()
		{
		}

		// Token: 0x0600218E RID: 8590 RVA: 0x00031CB4 File Offset: 0x0002FEB4
		public FAkSegmentInfo(int CurrentPosition, int PreEntryDuration, int ActiveDuration, int PostExitDuration, int RemainingLookAheadTime, float BeatDuration, float BarDuration, float GridDuration, float GridOffset)
		{
			this.CurrentPosition = CurrentPosition;
			this.PreEntryDuration = PreEntryDuration;
			this.ActiveDuration = ActiveDuration;
			this.PostExitDuration = PostExitDuration;
			this.RemainingLookAheadTime = RemainingLookAheadTime;
			this.BeatDuration = BeatDuration;
			this.BarDuration = BarDuration;
			this.GridDuration = GridDuration;
			this.GridOffset = GridOffset;
		}

		// Token: 0x0600218F RID: 8591 RVA: 0x00031D0C File Offset: 0x0002FF0C
		protected override IntPtr GetUStructPtr()
		{
			return FAkSegmentInfo.StaticStruct();
		}

		// Token: 0x06002190 RID: 8592 RVA: 0x00031D18 File Offset: 0x0002FF18
		[NullableContext(2)]
		public FAkSegmentInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06002191 RID: 8593 RVA: 0x00031D22 File Offset: 0x0002FF22
		public FAkSegmentInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06002192 RID: 8594 RVA: 0x00031D2D File Offset: 0x0002FF2D
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAkSegmentInfo(Pointer, false, true);
		}

		// Token: 0x06002193 RID: 8595 RVA: 0x00031D37 File Offset: 0x0002FF37
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAkSegmentInfo(Pointer, MemoryOwner);
		}

		// Token: 0x04000B5B RID: 2907
		[Nullable(1)]
		public const string __ObjectPath = "/Script/AkAudio.AkSegmentInfo";

		// Token: 0x04000B5C RID: 2908
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04000B5D RID: 2909
		internal static int __PropertyOffset_CurrentPosition;

		// Token: 0x04000B5E RID: 2910
		internal static int __PropertyOffset_PreEntryDuration;

		// Token: 0x04000B5F RID: 2911
		internal static int __PropertyOffset_ActiveDuration;

		// Token: 0x04000B60 RID: 2912
		internal static int __PropertyOffset_PostExitDuration;

		// Token: 0x04000B61 RID: 2913
		internal static int __PropertyOffset_RemainingLookAheadTime;

		// Token: 0x04000B62 RID: 2914
		internal static int __PropertyOffset_BeatDuration;

		// Token: 0x04000B63 RID: 2915
		internal static int __PropertyOffset_BarDuration;

		// Token: 0x04000B64 RID: 2916
		internal static int __PropertyOffset_GridDuration;

		// Token: 0x04000B65 RID: 2917
		internal static int __PropertyOffset_GridOffset;
	}
}
