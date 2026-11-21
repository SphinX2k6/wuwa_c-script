using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200077A RID: 1914
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/MovieScene.MovieSceneBinding")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 56)]
	public class FMovieSceneBinding : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600A57D RID: 42365 RVA: 0x000F4738 File Offset: 0x000F2938
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMovieSceneBinding._ScriptStructPtr != 0) ? FMovieSceneBinding._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MovieScene.MovieSceneBinding", ref FMovieSceneBinding._ScriptStructPtr);
		}

		// Token: 0x17001EB2 RID: 7858
		// (get) Token: 0x0600A57E RID: 42366 RVA: 0x000F475C File Offset: 0x000F295C
		// (set) Token: 0x0600A57F RID: 42367 RVA: 0x000F4770 File Offset: 0x000F2970
		public unsafe FGuid ObjectGuid
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMovieSceneBinding.__PropertyOffset_ObjectGuid);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneBinding.__PropertyOffset_ObjectGuid) = value;
			}
		}

		// Token: 0x17001EB3 RID: 7859
		// (get) Token: 0x0600A580 RID: 42368 RVA: 0x000F4785 File Offset: 0x000F2985
		// (set) Token: 0x0600A581 RID: 42369 RVA: 0x000F4799 File Offset: 0x000F2999
		public unsafe string BindingName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FMovieSceneBinding.__PropertyOffset_BindingName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FMovieSceneBinding.__PropertyOffset_BindingName)), value);
			}
		}

		// Token: 0x17001EB4 RID: 7860
		// (get) Token: 0x0600A582 RID: 42370 RVA: 0x000F47B0 File Offset: 0x000F29B0
		// (set) Token: 0x0600A583 RID: 42371 RVA: 0x000F47F3 File Offset: 0x000F29F3
		public TArray<UMovieSceneTrack> Tracks
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UMovieSceneTrack> result;
				if ((result = this._Tracks) == null)
				{
					result = (this._Tracks = new TArray<UMovieSceneTrack>(base.NativePtr + (IntPtr)FMovieSceneBinding.__PropertyOffset_Tracks, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Tracks.CopyAssign(value);
			}
		}

		// Token: 0x0600A584 RID: 42372 RVA: 0x000F4801 File Offset: 0x000F2A01
		public FMovieSceneBinding()
		{
		}

		// Token: 0x0600A585 RID: 42373 RVA: 0x000F4809 File Offset: 0x000F2A09
		protected override IntPtr GetUStructPtr()
		{
			return FMovieSceneBinding.StaticStruct();
		}

		// Token: 0x0600A586 RID: 42374 RVA: 0x000F4815 File Offset: 0x000F2A15
		[NullableContext(2)]
		public FMovieSceneBinding(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600A587 RID: 42375 RVA: 0x000F481F File Offset: 0x000F2A1F
		public FMovieSceneBinding(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600A588 RID: 42376 RVA: 0x000F482A File Offset: 0x000F2A2A
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMovieSceneBinding(Pointer, false, true);
		}

		// Token: 0x0600A589 RID: 42377 RVA: 0x000F4834 File Offset: 0x000F2A34
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMovieSceneBinding(Pointer, MemoryOwner);
		}

		// Token: 0x040046D3 RID: 18131
		public const string __ObjectPath = "/Script/MovieScene.MovieSceneBinding";

		// Token: 0x040046D4 RID: 18132
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040046D5 RID: 18133
		internal static int __PropertyOffset_ObjectGuid;

		// Token: 0x040046D6 RID: 18134
		internal static int __PropertyOffset_BindingName;

		// Token: 0x040046D7 RID: 18135
		internal static int __PropertyOffset_Tracks;

		// Token: 0x040046D8 RID: 18136
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMovieSceneTrack> _Tracks;
	}
}
