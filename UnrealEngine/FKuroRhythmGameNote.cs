using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000502 RID: 1282
	[UnrealObjectPath("/Script/KuroRhythmGame.KuroRhythmGameNote")]
	[UnrealStructLayout(32, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FKuroRhythmGameNote : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600786B RID: 30827 RVA: 0x000B0708 File Offset: 0x000AE908
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroRhythmGameNote._ScriptStructPtr != 0) ? FKuroRhythmGameNote._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroRhythmGame.KuroRhythmGameNote", ref FKuroRhythmGameNote._ScriptStructPtr);
		}

		// Token: 0x1700175B RID: 5979
		// (get) Token: 0x0600786C RID: 30828 RVA: 0x000B072C File Offset: 0x000AE92C
		// (set) Token: 0x0600786D RID: 30829 RVA: 0x000B073C File Offset: 0x000AE93C
		public unsafe float Beat
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroRhythmGameNote.__PropertyOffset_Beat);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroRhythmGameNote.__PropertyOffset_Beat) = value;
			}
		}

		// Token: 0x1700175C RID: 5980
		// (get) Token: 0x0600786E RID: 30830 RVA: 0x000B074D File Offset: 0x000AE94D
		// (set) Token: 0x0600786F RID: 30831 RVA: 0x000B075D File Offset: 0x000AE95D
		public unsafe EKuroRhythmGameNoteType NoteType
		{
			get
			{
				return (EKuroRhythmGameNoteType)(*(base.NativePtr + (IntPtr)FKuroRhythmGameNote.__PropertyOffset_NoteType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroRhythmGameNote.__PropertyOffset_NoteType) = (byte)value;
			}
		}

		// Token: 0x1700175D RID: 5981
		// (get) Token: 0x06007870 RID: 30832 RVA: 0x000B076E File Offset: 0x000AE96E
		// (set) Token: 0x06007871 RID: 30833 RVA: 0x000B077E File Offset: 0x000AE97E
		public unsafe int TrackIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroRhythmGameNote.__PropertyOffset_TrackIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroRhythmGameNote.__PropertyOffset_TrackIndex) = value;
			}
		}

		// Token: 0x1700175E RID: 5982
		// (get) Token: 0x06007872 RID: 30834 RVA: 0x000B078F File Offset: 0x000AE98F
		// (set) Token: 0x06007873 RID: 30835 RVA: 0x000B079F File Offset: 0x000AE99F
		public unsafe float Duration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroRhythmGameNote.__PropertyOffset_Duration);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroRhythmGameNote.__PropertyOffset_Duration) = value;
			}
		}

		// Token: 0x1700175F RID: 5983
		// (get) Token: 0x06007874 RID: 30836 RVA: 0x000B07B0 File Offset: 0x000AE9B0
		// (set) Token: 0x06007875 RID: 30837 RVA: 0x000B07C0 File Offset: 0x000AE9C0
		public unsafe bool Critical
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroRhythmGameNote.__PropertyOffset_Critical) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroRhythmGameNote.__PropertyOffset_Critical) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001760 RID: 5984
		// (get) Token: 0x06007876 RID: 30838 RVA: 0x000B07D1 File Offset: 0x000AE9D1
		// (set) Token: 0x06007877 RID: 30839 RVA: 0x000B07E1 File Offset: 0x000AE9E1
		public unsafe bool bHit
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroRhythmGameNote.__PropertyOffset_bHit) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroRhythmGameNote.__PropertyOffset_bHit) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001761 RID: 5985
		// (get) Token: 0x06007878 RID: 30840 RVA: 0x000B07F2 File Offset: 0x000AE9F2
		// (set) Token: 0x06007879 RID: 30841 RVA: 0x000B0802 File Offset: 0x000AEA02
		public unsafe float EventValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroRhythmGameNote.__PropertyOffset_EventValue);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroRhythmGameNote.__PropertyOffset_EventValue) = value;
			}
		}

		// Token: 0x17001762 RID: 5986
		// (get) Token: 0x0600787A RID: 30842 RVA: 0x000B0813 File Offset: 0x000AEA13
		// (set) Token: 0x0600787B RID: 30843 RVA: 0x000B0823 File Offset: 0x000AEA23
		public unsafe float AbsoluteTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroRhythmGameNote.__PropertyOffset_AbsoluteTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroRhythmGameNote.__PropertyOffset_AbsoluteTime) = value;
			}
		}

		// Token: 0x17001763 RID: 5987
		// (get) Token: 0x0600787C RID: 30844 RVA: 0x000B0834 File Offset: 0x000AEA34
		// (set) Token: 0x0600787D RID: 30845 RVA: 0x000B0844 File Offset: 0x000AEA44
		public unsafe float AbsoluteEndTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroRhythmGameNote.__PropertyOffset_AbsoluteEndTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroRhythmGameNote.__PropertyOffset_AbsoluteEndTime) = value;
			}
		}

		// Token: 0x0600787E RID: 30846 RVA: 0x000B0855 File Offset: 0x000AEA55
		public FKuroRhythmGameNote()
		{
		}

		// Token: 0x0600787F RID: 30847 RVA: 0x000B085D File Offset: 0x000AEA5D
		protected override IntPtr GetUStructPtr()
		{
			return FKuroRhythmGameNote.StaticStruct();
		}

		// Token: 0x06007880 RID: 30848 RVA: 0x000B0869 File Offset: 0x000AEA69
		[NullableContext(2)]
		public FKuroRhythmGameNote(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06007881 RID: 30849 RVA: 0x000B0873 File Offset: 0x000AEA73
		public FKuroRhythmGameNote(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06007882 RID: 30850 RVA: 0x000B087E File Offset: 0x000AEA7E
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroRhythmGameNote(Pointer, false, true);
		}

		// Token: 0x06007883 RID: 30851 RVA: 0x000B0888 File Offset: 0x000AEA88
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroRhythmGameNote(Pointer, MemoryOwner);
		}

		// Token: 0x0400332B RID: 13099
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroRhythmGame.KuroRhythmGameNote";

		// Token: 0x0400332C RID: 13100
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400332D RID: 13101
		internal static int __PropertyOffset_Beat;

		// Token: 0x0400332E RID: 13102
		internal static int __PropertyOffset_NoteType;

		// Token: 0x0400332F RID: 13103
		internal static int __PropertyOffset_TrackIndex;

		// Token: 0x04003330 RID: 13104
		internal static int __PropertyOffset_Duration;

		// Token: 0x04003331 RID: 13105
		internal static int __PropertyOffset_Critical;

		// Token: 0x04003332 RID: 13106
		internal static int __PropertyOffset_bHit;

		// Token: 0x04003333 RID: 13107
		internal static int __PropertyOffset_EventValue;

		// Token: 0x04003334 RID: 13108
		internal static int __PropertyOffset_AbsoluteTime;

		// Token: 0x04003335 RID: 13109
		internal static int __PropertyOffset_AbsoluteEndTime;
	}
}
