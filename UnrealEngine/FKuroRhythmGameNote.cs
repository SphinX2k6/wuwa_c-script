using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001C54 RID: 7252
	[UnrealObjectPath("/Script/KuroRhythmGame.KuroRhythmGameNote")]
	[UnrealStructLayout(32, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FKuroRhythmGameNote : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601C21B RID: 115227 RVA: 0x0029731E File Offset: 0x0029551E
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroRhythmGameNote._ScriptStructPtr != 0) ? FKuroRhythmGameNote._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroRhythmGame.KuroRhythmGameNote", ref FKuroRhythmGameNote._ScriptStructPtr);
		}

		// Token: 0x170071CD RID: 29133
		// (get) Token: 0x0601C21C RID: 115228 RVA: 0x00297342 File Offset: 0x00295542
		// (set) Token: 0x0601C21D RID: 115229 RVA: 0x00297352 File Offset: 0x00295552
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

		// Token: 0x170071CE RID: 29134
		// (get) Token: 0x0601C21E RID: 115230 RVA: 0x00297363 File Offset: 0x00295563
		// (set) Token: 0x0601C21F RID: 115231 RVA: 0x00297373 File Offset: 0x00295573
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

		// Token: 0x170071CF RID: 29135
		// (get) Token: 0x0601C220 RID: 115232 RVA: 0x00297384 File Offset: 0x00295584
		// (set) Token: 0x0601C221 RID: 115233 RVA: 0x00297394 File Offset: 0x00295594
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

		// Token: 0x170071D0 RID: 29136
		// (get) Token: 0x0601C222 RID: 115234 RVA: 0x002973A5 File Offset: 0x002955A5
		// (set) Token: 0x0601C223 RID: 115235 RVA: 0x002973B5 File Offset: 0x002955B5
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

		// Token: 0x170071D1 RID: 29137
		// (get) Token: 0x0601C224 RID: 115236 RVA: 0x002973C6 File Offset: 0x002955C6
		// (set) Token: 0x0601C225 RID: 115237 RVA: 0x002973D6 File Offset: 0x002955D6
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

		// Token: 0x170071D2 RID: 29138
		// (get) Token: 0x0601C226 RID: 115238 RVA: 0x002973E7 File Offset: 0x002955E7
		// (set) Token: 0x0601C227 RID: 115239 RVA: 0x002973F7 File Offset: 0x002955F7
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

		// Token: 0x170071D3 RID: 29139
		// (get) Token: 0x0601C228 RID: 115240 RVA: 0x00297408 File Offset: 0x00295608
		// (set) Token: 0x0601C229 RID: 115241 RVA: 0x00297418 File Offset: 0x00295618
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

		// Token: 0x170071D4 RID: 29140
		// (get) Token: 0x0601C22A RID: 115242 RVA: 0x00297429 File Offset: 0x00295629
		// (set) Token: 0x0601C22B RID: 115243 RVA: 0x00297439 File Offset: 0x00295639
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

		// Token: 0x170071D5 RID: 29141
		// (get) Token: 0x0601C22C RID: 115244 RVA: 0x0029744A File Offset: 0x0029564A
		// (set) Token: 0x0601C22D RID: 115245 RVA: 0x0029745A File Offset: 0x0029565A
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

		// Token: 0x0601C22E RID: 115246 RVA: 0x0029746B File Offset: 0x0029566B
		public FKuroRhythmGameNote()
		{
		}

		// Token: 0x0601C22F RID: 115247 RVA: 0x00297474 File Offset: 0x00295674
		public FKuroRhythmGameNote(float Beat, EKuroRhythmGameNoteType NoteType, int TrackIndex, float Duration, bool Critical, bool bHit, float EventValue, float AbsoluteTime, float AbsoluteEndTime)
		{
			this.Beat = Beat;
			this.NoteType = NoteType;
			this.TrackIndex = TrackIndex;
			this.Duration = Duration;
			this.Critical = Critical;
			this.bHit = bHit;
			this.EventValue = EventValue;
			this.AbsoluteTime = AbsoluteTime;
			this.AbsoluteEndTime = AbsoluteEndTime;
		}

		// Token: 0x0601C230 RID: 115248 RVA: 0x002974CC File Offset: 0x002956CC
		protected override IntPtr GetUStructPtr()
		{
			return FKuroRhythmGameNote.StaticStruct();
		}

		// Token: 0x0601C231 RID: 115249 RVA: 0x002974D8 File Offset: 0x002956D8
		[NullableContext(2)]
		public FKuroRhythmGameNote(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601C232 RID: 115250 RVA: 0x002974E2 File Offset: 0x002956E2
		public FKuroRhythmGameNote(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601C233 RID: 115251 RVA: 0x002974ED File Offset: 0x002956ED
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroRhythmGameNote(Pointer, false, true);
		}

		// Token: 0x0601C234 RID: 115252 RVA: 0x002974F7 File Offset: 0x002956F7
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroRhythmGameNote(Pointer, MemoryOwner);
		}

		// Token: 0x0400F230 RID: 62000
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroRhythmGame.KuroRhythmGameNote";

		// Token: 0x0400F231 RID: 62001
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400F232 RID: 62002
		internal static int __PropertyOffset_Beat;

		// Token: 0x0400F233 RID: 62003
		internal static int __PropertyOffset_NoteType;

		// Token: 0x0400F234 RID: 62004
		internal static int __PropertyOffset_TrackIndex;

		// Token: 0x0400F235 RID: 62005
		internal static int __PropertyOffset_Duration;

		// Token: 0x0400F236 RID: 62006
		internal static int __PropertyOffset_Critical;

		// Token: 0x0400F237 RID: 62007
		internal static int __PropertyOffset_bHit;

		// Token: 0x0400F238 RID: 62008
		internal static int __PropertyOffset_EventValue;

		// Token: 0x0400F239 RID: 62009
		internal static int __PropertyOffset_AbsoluteTime;

		// Token: 0x0400F23A RID: 62010
		internal static int __PropertyOffset_AbsoluteEndTime;
	}
}
