using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020022AB RID: 8875
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/MediaCompositing.MovieSceneMediaSection")]
	[UnrealStructLayout(360, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 360)]
	public class UMovieSceneMediaSection : UMovieSceneSection, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06021BCA RID: 138186 RVA: 0x0031E16E File Offset: 0x0031C36E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieSceneMediaSection._ClassPtr;
		}

		// Token: 0x06021BCB RID: 138187 RVA: 0x0031E17C File Offset: 0x0031C37C
		public UMovieSceneMediaSection() : this(BuiltinUtils.AllocNativeUObject(UMovieSceneMediaSection.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06021BCC RID: 138188 RVA: 0x0031E1A4 File Offset: 0x0031C3A4
		[NullableContext(1)]
		public UMovieSceneMediaSection(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMovieSceneMediaSection.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170082DC RID: 33500
		// (get) Token: 0x06021BCD RID: 138189 RVA: 0x0031E1D7 File Offset: 0x0031C3D7
		// (set) Token: 0x06021BCE RID: 138190 RVA: 0x0031E1EB File Offset: 0x0031C3EB
		public unsafe UMediaSource MediaSource
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMediaSource>(base.NativePtr / (IntPtr)sizeof(void*) + UMovieSceneMediaSection.__PropertyOffset_MediaSource);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UMovieSceneMediaSection.__PropertyOffset_MediaSource, value);
			}
		}

		// Token: 0x170082DD RID: 33501
		// (get) Token: 0x06021BCF RID: 138191 RVA: 0x0031E200 File Offset: 0x0031C400
		// (set) Token: 0x06021BD0 RID: 138192 RVA: 0x0031E210 File Offset: 0x0031C410
		public unsafe bool bLooping
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMovieSceneMediaSection.__PropertyOffset_bLooping) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMovieSceneMediaSection.__PropertyOffset_bLooping) = (value ? 1 : 0);
			}
		}

		// Token: 0x170082DE RID: 33502
		// (get) Token: 0x06021BD1 RID: 138193 RVA: 0x0031E224 File Offset: 0x0031C424
		// (set) Token: 0x06021BD2 RID: 138194 RVA: 0x0031E25D File Offset: 0x0031C45D
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
					result = (this._StartFrameOffset = new FFrameNumber(base.NativePtr + (IntPtr)UMovieSceneMediaSection.__PropertyOffset_StartFrameOffset, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FFrameNumber.StaticStruct(), base.NativePtr + (IntPtr)UMovieSceneMediaSection.__PropertyOffset_StartFrameOffset, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170082DF RID: 33503
		// (get) Token: 0x06021BD3 RID: 138195 RVA: 0x0031E27E File Offset: 0x0031C47E
		// (set) Token: 0x06021BD4 RID: 138196 RVA: 0x0031E292 File Offset: 0x0031C492
		public unsafe UMediaTexture MediaTexture
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMediaTexture>(base.NativePtr / (IntPtr)sizeof(void*) + UMovieSceneMediaSection.__PropertyOffset_MediaTexture);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UMovieSceneMediaSection.__PropertyOffset_MediaTexture, value);
			}
		}

		// Token: 0x170082E0 RID: 33504
		// (get) Token: 0x06021BD5 RID: 138197 RVA: 0x0031E2A7 File Offset: 0x0031C4A7
		// (set) Token: 0x06021BD6 RID: 138198 RVA: 0x0031E2BB File Offset: 0x0031C4BB
		public unsafe UMediaSoundComponent MediaSoundComponent
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMediaSoundComponent>(base.NativePtr / (IntPtr)sizeof(void*) + UMovieSceneMediaSection.__PropertyOffset_MediaSoundComponent);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UMovieSceneMediaSection.__PropertyOffset_MediaSoundComponent, value);
			}
		}

		// Token: 0x170082E1 RID: 33505
		// (get) Token: 0x06021BD7 RID: 138199 RVA: 0x0031E2D0 File Offset: 0x0031C4D0
		// (set) Token: 0x06021BD8 RID: 138200 RVA: 0x0031E2E0 File Offset: 0x0031C4E0
		public unsafe bool bUseExternalMediaPlayer
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMovieSceneMediaSection.__PropertyOffset_bUseExternalMediaPlayer) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMovieSceneMediaSection.__PropertyOffset_bUseExternalMediaPlayer) = (value ? 1 : 0);
			}
		}

		// Token: 0x170082E2 RID: 33506
		// (get) Token: 0x06021BD9 RID: 138201 RVA: 0x0031E2F1 File Offset: 0x0031C4F1
		// (set) Token: 0x06021BDA RID: 138202 RVA: 0x0031E305 File Offset: 0x0031C505
		public unsafe UMediaPlayer ExternalMediaPlayer
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMediaPlayer>(base.NativePtr / (IntPtr)sizeof(void*) + UMovieSceneMediaSection.__PropertyOffset_ExternalMediaPlayer);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UMovieSceneMediaSection.__PropertyOffset_ExternalMediaPlayer, value);
			}
		}

		// Token: 0x06021BDB RID: 138203 RVA: 0x0031E31A File Offset: 0x0031C51A
		static UMovieSceneMediaSection()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MediaCompositing.MovieSceneMediaSection");
		}

		// Token: 0x06021BDC RID: 138204 RVA: 0x0031E328 File Offset: 0x0031C528
		protected UMovieSceneMediaSection(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011FFE RID: 73726
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/MediaCompositing.MovieSceneMediaSection";

		// Token: 0x04011FFF RID: 73727
		private static IntPtr _ClassPtr;

		// Token: 0x04012000 RID: 73728
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04012001 RID: 73729
		internal static int __PropertyOffset_MediaSource;

		// Token: 0x04012002 RID: 73730
		internal static int __PropertyOffset_bLooping;

		// Token: 0x04012003 RID: 73731
		internal static int __PropertyOffset_StartFrameOffset;

		// Token: 0x04012004 RID: 73732
		private FFrameNumber _StartFrameOffset;

		// Token: 0x04012005 RID: 73733
		internal static int __PropertyOffset_MediaTexture;

		// Token: 0x04012006 RID: 73734
		internal static int __PropertyOffset_MediaSoundComponent;

		// Token: 0x04012007 RID: 73735
		internal static int __PropertyOffset_bUseExternalMediaPlayer;

		// Token: 0x04012008 RID: 73736
		internal static int __PropertyOffset_ExternalMediaPlayer;
	}
}
