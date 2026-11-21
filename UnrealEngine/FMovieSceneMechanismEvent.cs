using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200076E RID: 1902
	[UnrealObjectPath("/Script/MovieSceneTracks.MovieSceneMechanismEvent")]
	[UnrealStructLayout(40, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 40)]
	public class FMovieSceneMechanismEvent : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600A4D2 RID: 42194 RVA: 0x000F37CA File Offset: 0x000F19CA
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMovieSceneMechanismEvent._ScriptStructPtr != 0) ? FMovieSceneMechanismEvent._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MovieSceneTracks.MovieSceneMechanismEvent", ref FMovieSceneMechanismEvent._ScriptStructPtr);
		}

		// Token: 0x17001E75 RID: 7797
		// (get) Token: 0x0600A4D3 RID: 42195 RVA: 0x000F37EE File Offset: 0x000F19EE
		// (set) Token: 0x0600A4D4 RID: 42196 RVA: 0x000F37FE File Offset: 0x000F19FE
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

		// Token: 0x17001E76 RID: 7798
		// (get) Token: 0x0600A4D5 RID: 42197 RVA: 0x000F380F File Offset: 0x000F1A0F
		// (set) Token: 0x0600A4D6 RID: 42198 RVA: 0x000F3823 File Offset: 0x000F1A23
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

		// Token: 0x17001E77 RID: 7799
		// (get) Token: 0x0600A4D7 RID: 42199 RVA: 0x000F3838 File Offset: 0x000F1A38
		// (set) Token: 0x0600A4D8 RID: 42200 RVA: 0x000F384C File Offset: 0x000F1A4C
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

		// Token: 0x17001E78 RID: 7800
		// (get) Token: 0x0600A4D9 RID: 42201 RVA: 0x000F3861 File Offset: 0x000F1A61
		// (set) Token: 0x0600A4DA RID: 42202 RVA: 0x000F3875 File Offset: 0x000F1A75
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

		// Token: 0x0600A4DB RID: 42203 RVA: 0x000F388A File Offset: 0x000F1A8A
		public FMovieSceneMechanismEvent()
		{
		}

		// Token: 0x0600A4DC RID: 42204 RVA: 0x000F3892 File Offset: 0x000F1A92
		protected override IntPtr GetUStructPtr()
		{
			return FMovieSceneMechanismEvent.StaticStruct();
		}

		// Token: 0x0600A4DD RID: 42205 RVA: 0x000F389E File Offset: 0x000F1A9E
		[NullableContext(2)]
		public FMovieSceneMechanismEvent(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600A4DE RID: 42206 RVA: 0x000F38A8 File Offset: 0x000F1AA8
		public FMovieSceneMechanismEvent(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600A4DF RID: 42207 RVA: 0x000F38B3 File Offset: 0x000F1AB3
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMovieSceneMechanismEvent(Pointer, false, true);
		}

		// Token: 0x0600A4E0 RID: 42208 RVA: 0x000F38BD File Offset: 0x000F1ABD
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMovieSceneMechanismEvent(Pointer, MemoryOwner);
		}

		// Token: 0x0400465A RID: 18010
		[Nullable(1)]
		public const string __ObjectPath = "/Script/MovieSceneTracks.MovieSceneMechanismEvent";

		// Token: 0x0400465B RID: 18011
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400465C RID: 18012
		internal static int __PropertyOffset_bAnimNotifyState;

		// Token: 0x0400465D RID: 18013
		internal static int __PropertyOffset_EventNotifyType;

		// Token: 0x0400465E RID: 18014
		internal static int __PropertyOffset_EventNotifyStateType;

		// Token: 0x0400465F RID: 18015
		internal static int __PropertyOffset_EventName;
	}
}
