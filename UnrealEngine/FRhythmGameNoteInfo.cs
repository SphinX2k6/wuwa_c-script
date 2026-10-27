using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001C25 RID: 7205
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.RhythmGameNoteInfo")]
	[UnrealStructLayout(36, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 36)]
	public class FRhythmGameNoteInfo : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601BD5D RID: 114013 RVA: 0x0028F89D File Offset: 0x0028DA9D
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRhythmGameNoteInfo._ScriptStructPtr != 0) ? FRhythmGameNoteInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroRenderingRuntimeBPPlugin.RhythmGameNoteInfo", ref FRhythmGameNoteInfo._ScriptStructPtr);
		}

		// Token: 0x17007054 RID: 28756
		// (get) Token: 0x0601BD5E RID: 114014 RVA: 0x0028F8C1 File Offset: 0x0028DAC1
		// (set) Token: 0x0601BD5F RID: 114015 RVA: 0x0028F8D1 File Offset: 0x0028DAD1
		public unsafe float TimePoint
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRhythmGameNoteInfo.__PropertyOffset_TimePoint);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRhythmGameNoteInfo.__PropertyOffset_TimePoint) = value;
			}
		}

		// Token: 0x17007055 RID: 28757
		// (get) Token: 0x0601BD60 RID: 114016 RVA: 0x0028F8E2 File Offset: 0x0028DAE2
		// (set) Token: 0x0601BD61 RID: 114017 RVA: 0x0028F8F2 File Offset: 0x0028DAF2
		public unsafe int TrackId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRhythmGameNoteInfo.__PropertyOffset_TrackId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRhythmGameNoteInfo.__PropertyOffset_TrackId) = value;
			}
		}

		// Token: 0x17007056 RID: 28758
		// (get) Token: 0x0601BD62 RID: 114018 RVA: 0x0028F903 File Offset: 0x0028DB03
		// (set) Token: 0x0601BD63 RID: 114019 RVA: 0x0028F913 File Offset: 0x0028DB13
		public unsafe int TypeId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRhythmGameNoteInfo.__PropertyOffset_TypeId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRhythmGameNoteInfo.__PropertyOffset_TypeId) = value;
			}
		}

		// Token: 0x17007057 RID: 28759
		// (get) Token: 0x0601BD64 RID: 114020 RVA: 0x0028F924 File Offset: 0x0028DB24
		// (set) Token: 0x0601BD65 RID: 114021 RVA: 0x0028F934 File Offset: 0x0028DB34
		public unsafe float HoldTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRhythmGameNoteInfo.__PropertyOffset_HoldTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRhythmGameNoteInfo.__PropertyOffset_HoldTime) = value;
			}
		}

		// Token: 0x17007058 RID: 28760
		// (get) Token: 0x0601BD66 RID: 114022 RVA: 0x0028F945 File Offset: 0x0028DB45
		// (set) Token: 0x0601BD67 RID: 114023 RVA: 0x0028F955 File Offset: 0x0028DB55
		public unsafe int NoteFlag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRhythmGameNoteInfo.__PropertyOffset_NoteFlag);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRhythmGameNoteInfo.__PropertyOffset_NoteFlag) = value;
			}
		}

		// Token: 0x0601BD68 RID: 114024 RVA: 0x0028F966 File Offset: 0x0028DB66
		public FRhythmGameNoteInfo()
		{
		}

		// Token: 0x0601BD69 RID: 114025 RVA: 0x0028F96E File Offset: 0x0028DB6E
		public FRhythmGameNoteInfo(float TimePoint, int TrackId, int TypeId, float HoldTime, int NoteFlag)
		{
			this.TimePoint = TimePoint;
			this.TrackId = TrackId;
			this.TypeId = TypeId;
			this.HoldTime = HoldTime;
			this.NoteFlag = NoteFlag;
		}

		// Token: 0x0601BD6A RID: 114026 RVA: 0x0028F99B File Offset: 0x0028DB9B
		protected override IntPtr GetUStructPtr()
		{
			return FRhythmGameNoteInfo.StaticStruct();
		}

		// Token: 0x0601BD6B RID: 114027 RVA: 0x0028F9A7 File Offset: 0x0028DBA7
		[NullableContext(2)]
		public FRhythmGameNoteInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601BD6C RID: 114028 RVA: 0x0028F9B1 File Offset: 0x0028DBB1
		public FRhythmGameNoteInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601BD6D RID: 114029 RVA: 0x0028F9BC File Offset: 0x0028DBBC
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRhythmGameNoteInfo(Pointer, false, true);
		}

		// Token: 0x0601BD6E RID: 114030 RVA: 0x0028F9C6 File Offset: 0x0028DBC6
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRhythmGameNoteInfo(Pointer, MemoryOwner);
		}

		// Token: 0x0400EF56 RID: 61270
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.RhythmGameNoteInfo";

		// Token: 0x0400EF57 RID: 61271
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400EF58 RID: 61272
		internal static int __PropertyOffset_TimePoint;

		// Token: 0x0400EF59 RID: 61273
		internal static int __PropertyOffset_TrackId;

		// Token: 0x0400EF5A RID: 61274
		internal static int __PropertyOffset_TypeId;

		// Token: 0x0400EF5B RID: 61275
		internal static int __PropertyOffset_HoldTime;

		// Token: 0x0400EF5C RID: 61276
		internal static int __PropertyOffset_NoteFlag;
	}
}
