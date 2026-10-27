using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020022AC RID: 8876
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/MediaCompositing.MovieSceneMediaSectionParams")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FMovieSceneMediaSectionParams : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06021BDD RID: 138205 RVA: 0x0031E331 File Offset: 0x0031C531
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMovieSceneMediaSectionParams._ScriptStructPtr != 0) ? FMovieSceneMediaSectionParams._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MediaCompositing.MovieSceneMediaSectionParams", ref FMovieSceneMediaSectionParams._ScriptStructPtr);
		}

		// Token: 0x170082E3 RID: 33507
		// (get) Token: 0x06021BDE RID: 138206 RVA: 0x0031E355 File Offset: 0x0031C555
		// (set) Token: 0x06021BDF RID: 138207 RVA: 0x0031E369 File Offset: 0x0031C569
		public unsafe UMediaSoundComponent MediaSoundComponent
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMediaSoundComponent>(base.NativePtr / (IntPtr)sizeof(void*) + FMovieSceneMediaSectionParams.__PropertyOffset_MediaSoundComponent);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FMovieSceneMediaSectionParams.__PropertyOffset_MediaSoundComponent, value);
			}
		}

		// Token: 0x170082E4 RID: 33508
		// (get) Token: 0x06021BE0 RID: 138208 RVA: 0x0031E37E File Offset: 0x0031C57E
		// (set) Token: 0x06021BE1 RID: 138209 RVA: 0x0031E392 File Offset: 0x0031C592
		public unsafe UMediaSource MediaSource
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMediaSource>(base.NativePtr / (IntPtr)sizeof(void*) + FMovieSceneMediaSectionParams.__PropertyOffset_MediaSource);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FMovieSceneMediaSectionParams.__PropertyOffset_MediaSource, value);
			}
		}

		// Token: 0x170082E5 RID: 33509
		// (get) Token: 0x06021BE2 RID: 138210 RVA: 0x0031E3A7 File Offset: 0x0031C5A7
		// (set) Token: 0x06021BE3 RID: 138211 RVA: 0x0031E3BB File Offset: 0x0031C5BB
		public unsafe UMediaTexture MediaTexture
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMediaTexture>(base.NativePtr / (IntPtr)sizeof(void*) + FMovieSceneMediaSectionParams.__PropertyOffset_MediaTexture);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FMovieSceneMediaSectionParams.__PropertyOffset_MediaTexture, value);
			}
		}

		// Token: 0x170082E6 RID: 33510
		// (get) Token: 0x06021BE4 RID: 138212 RVA: 0x0031E3D0 File Offset: 0x0031C5D0
		// (set) Token: 0x06021BE5 RID: 138213 RVA: 0x0031E3E4 File Offset: 0x0031C5E4
		public unsafe UMediaPlayer MediaPlayer
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMediaPlayer>(base.NativePtr / (IntPtr)sizeof(void*) + FMovieSceneMediaSectionParams.__PropertyOffset_MediaPlayer);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FMovieSceneMediaSectionParams.__PropertyOffset_MediaPlayer, value);
			}
		}

		// Token: 0x170082E7 RID: 33511
		// (get) Token: 0x06021BE6 RID: 138214 RVA: 0x0031E3FC File Offset: 0x0031C5FC
		// (set) Token: 0x06021BE7 RID: 138215 RVA: 0x0031E43F File Offset: 0x0031C63F
		[Nullable(1)]
		public FFrameNumber SectionStartFrame
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FFrameNumber result;
				if ((result = this._SectionStartFrame) == null)
				{
					result = (this._SectionStartFrame = new FFrameNumber(base.NativePtr + (IntPtr)FMovieSceneMediaSectionParams.__PropertyOffset_SectionStartFrame, base.MemoryOwner ?? this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FFrameNumber.StaticStruct(), base.NativePtr + (IntPtr)FMovieSceneMediaSectionParams.__PropertyOffset_SectionStartFrame, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170082E8 RID: 33512
		// (get) Token: 0x06021BE8 RID: 138216 RVA: 0x0031E460 File Offset: 0x0031C660
		// (set) Token: 0x06021BE9 RID: 138217 RVA: 0x0031E4A3 File Offset: 0x0031C6A3
		[Nullable(1)]
		public FFrameNumber SectionEndFrame
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FFrameNumber result;
				if ((result = this._SectionEndFrame) == null)
				{
					result = (this._SectionEndFrame = new FFrameNumber(base.NativePtr + (IntPtr)FMovieSceneMediaSectionParams.__PropertyOffset_SectionEndFrame, base.MemoryOwner ?? this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FFrameNumber.StaticStruct(), base.NativePtr + (IntPtr)FMovieSceneMediaSectionParams.__PropertyOffset_SectionEndFrame, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170082E9 RID: 33513
		// (get) Token: 0x06021BEA RID: 138218 RVA: 0x0031E4C4 File Offset: 0x0031C6C4
		// (set) Token: 0x06021BEB RID: 138219 RVA: 0x0031E4D4 File Offset: 0x0031C6D4
		public unsafe bool bLooping
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMovieSceneMediaSectionParams.__PropertyOffset_bLooping) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneMediaSectionParams.__PropertyOffset_bLooping) = (value ? 1 : 0);
			}
		}

		// Token: 0x170082EA RID: 33514
		// (get) Token: 0x06021BEC RID: 138220 RVA: 0x0031E4E8 File Offset: 0x0031C6E8
		// (set) Token: 0x06021BED RID: 138221 RVA: 0x0031E52B File Offset: 0x0031C72B
		[Nullable(1)]
		public FFrameNumber StartFrameOffset
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FFrameNumber result;
				if ((result = this._StartFrameOffset) == null)
				{
					result = (this._StartFrameOffset = new FFrameNumber(base.NativePtr + (IntPtr)FMovieSceneMediaSectionParams.__PropertyOffset_StartFrameOffset, base.MemoryOwner ?? this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FFrameNumber.StaticStruct(), base.NativePtr + (IntPtr)FMovieSceneMediaSectionParams.__PropertyOffset_StartFrameOffset, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06021BEE RID: 138222 RVA: 0x0031E54C File Offset: 0x0031C74C
		public FMovieSceneMediaSectionParams()
		{
		}

		// Token: 0x06021BEF RID: 138223 RVA: 0x0031E554 File Offset: 0x0031C754
		[NullableContext(1)]
		public FMovieSceneMediaSectionParams(UMediaSoundComponent MediaSoundComponent, UMediaSource MediaSource, UMediaTexture MediaTexture, UMediaPlayer MediaPlayer, FFrameNumber SectionStartFrame, FFrameNumber SectionEndFrame, bool bLooping, FFrameNumber StartFrameOffset)
		{
			this.MediaSoundComponent = MediaSoundComponent;
			this.MediaSource = MediaSource;
			this.MediaTexture = MediaTexture;
			this.MediaPlayer = MediaPlayer;
			this.SectionStartFrame = SectionStartFrame;
			this.SectionEndFrame = SectionEndFrame;
			this.bLooping = bLooping;
			this.StartFrameOffset = StartFrameOffset;
		}

		// Token: 0x06021BF0 RID: 138224 RVA: 0x0031E5A4 File Offset: 0x0031C7A4
		protected override IntPtr GetUStructPtr()
		{
			return FMovieSceneMediaSectionParams.StaticStruct();
		}

		// Token: 0x06021BF1 RID: 138225 RVA: 0x0031E5B0 File Offset: 0x0031C7B0
		public FMovieSceneMediaSectionParams(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06021BF2 RID: 138226 RVA: 0x0031E5BA File Offset: 0x0031C7BA
		public FMovieSceneMediaSectionParams(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06021BF3 RID: 138227 RVA: 0x0031E5C5 File Offset: 0x0031C7C5
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMovieSceneMediaSectionParams(Pointer, false, true);
		}

		// Token: 0x06021BF4 RID: 138228 RVA: 0x0031E5CF File Offset: 0x0031C7CF
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMovieSceneMediaSectionParams(Pointer, MemoryOwner);
		}

		// Token: 0x04012009 RID: 73737
		[Nullable(1)]
		public const string __ObjectPath = "/Script/MediaCompositing.MovieSceneMediaSectionParams";

		// Token: 0x0401200A RID: 73738
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401200B RID: 73739
		internal static int __PropertyOffset_MediaSoundComponent;

		// Token: 0x0401200C RID: 73740
		internal static int __PropertyOffset_MediaSource;

		// Token: 0x0401200D RID: 73741
		internal static int __PropertyOffset_MediaTexture;

		// Token: 0x0401200E RID: 73742
		internal static int __PropertyOffset_MediaPlayer;

		// Token: 0x0401200F RID: 73743
		internal static int __PropertyOffset_SectionStartFrame;

		// Token: 0x04012010 RID: 73744
		private FFrameNumber _SectionStartFrame;

		// Token: 0x04012011 RID: 73745
		internal static int __PropertyOffset_SectionEndFrame;

		// Token: 0x04012012 RID: 73746
		private FFrameNumber _SectionEndFrame;

		// Token: 0x04012013 RID: 73747
		internal static int __PropertyOffset_bLooping;

		// Token: 0x04012014 RID: 73748
		internal static int __PropertyOffset_StartFrameOffset;

		// Token: 0x04012015 RID: 73749
		private FFrameNumber _StartFrameOffset;
	}
}
