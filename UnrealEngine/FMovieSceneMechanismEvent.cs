using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200238B RID: 9099
	[UnrealObjectPath("/Script/MovieSceneTracks.MovieSceneMechanismEvent")]
	[UnrealStructLayout(40, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 40)]
	public class FMovieSceneMechanismEvent : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060224B2 RID: 140466 RVA: 0x0032B72A File Offset: 0x0032992A
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMovieSceneMechanismEvent._ScriptStructPtr != 0) ? FMovieSceneMechanismEvent._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MovieSceneTracks.MovieSceneMechanismEvent", ref FMovieSceneMechanismEvent._ScriptStructPtr);
		}

		// Token: 0x1700843B RID: 33851
		// (get) Token: 0x060224B3 RID: 140467 RVA: 0x0032B74E File Offset: 0x0032994E
		// (set) Token: 0x060224B4 RID: 140468 RVA: 0x0032B75E File Offset: 0x0032995E
		public unsafe bool bAnimNotifyState
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMovieSceneMechanismEvent.__PropertyOffset_bAnimNotifyState) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneMechanismEvent.__PropertyOffset_bAnimNotifyState) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700843C RID: 33852
		// (get) Token: 0x060224B5 RID: 140469 RVA: 0x0032B76F File Offset: 0x0032996F
		// (set) Token: 0x060224B6 RID: 140470 RVA: 0x0032B783 File Offset: 0x00329983
		public unsafe FName EventNotifyType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMovieSceneMechanismEvent.__PropertyOffset_EventNotifyType);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneMechanismEvent.__PropertyOffset_EventNotifyType) = value;
			}
		}

		// Token: 0x1700843D RID: 33853
		// (get) Token: 0x060224B7 RID: 140471 RVA: 0x0032B798 File Offset: 0x00329998
		// (set) Token: 0x060224B8 RID: 140472 RVA: 0x0032B7AC File Offset: 0x003299AC
		public unsafe FName EventNotifyStateType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMovieSceneMechanismEvent.__PropertyOffset_EventNotifyStateType);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneMechanismEvent.__PropertyOffset_EventNotifyStateType) = value;
			}
		}

		// Token: 0x1700843E RID: 33854
		// (get) Token: 0x060224B9 RID: 140473 RVA: 0x0032B7C1 File Offset: 0x003299C1
		// (set) Token: 0x060224BA RID: 140474 RVA: 0x0032B7D5 File Offset: 0x003299D5
		public unsafe FName EventName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMovieSceneMechanismEvent.__PropertyOffset_EventName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneMechanismEvent.__PropertyOffset_EventName) = value;
			}
		}

		// Token: 0x060224BB RID: 140475 RVA: 0x0032B7EA File Offset: 0x003299EA
		public FMovieSceneMechanismEvent()
		{
		}

		// Token: 0x060224BC RID: 140476 RVA: 0x0032B7F2 File Offset: 0x003299F2
		public FMovieSceneMechanismEvent(bool bAnimNotifyState, FName EventNotifyType, FName EventNotifyStateType, FName EventName)
		{
			this.bAnimNotifyState = bAnimNotifyState;
			this.EventNotifyType = EventNotifyType;
			this.EventNotifyStateType = EventNotifyStateType;
			this.EventName = EventName;
		}

		// Token: 0x060224BD RID: 140477 RVA: 0x0032B817 File Offset: 0x00329A17
		protected override IntPtr GetUStructPtr()
		{
			return FMovieSceneMechanismEvent.StaticStruct();
		}

		// Token: 0x060224BE RID: 140478 RVA: 0x0032B823 File Offset: 0x00329A23
		[NullableContext(2)]
		public FMovieSceneMechanismEvent(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060224BF RID: 140479 RVA: 0x0032B82D File Offset: 0x00329A2D
		public FMovieSceneMechanismEvent(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060224C0 RID: 140480 RVA: 0x0032B838 File Offset: 0x00329A38
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMovieSceneMechanismEvent(Pointer, false, true);
		}

		// Token: 0x060224C1 RID: 140481 RVA: 0x0032B842 File Offset: 0x00329A42
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMovieSceneMechanismEvent(Pointer, MemoryOwner);
		}

		// Token: 0x040124EC RID: 74988
		[Nullable(1)]
		public const string __ObjectPath = "/Script/MovieSceneTracks.MovieSceneMechanismEvent";

		// Token: 0x040124ED RID: 74989
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040124EE RID: 74990
		internal static int __PropertyOffset_bAnimNotifyState;

		// Token: 0x040124EF RID: 74991
		internal static int __PropertyOffset_EventNotifyType;

		// Token: 0x040124F0 RID: 74992
		internal static int __PropertyOffset_EventNotifyStateType;

		// Token: 0x040124F1 RID: 74993
		internal static int __PropertyOffset_EventName;
	}
}
