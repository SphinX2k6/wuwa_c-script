using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001B73 RID: 7027
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroMediaAlignComponent")]
	[UnrealStructLayout(264, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 264)]
	public class UKuroMediaAlignComponent : UActorComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601A9B7 RID: 108983 RVA: 0x00273990 File Offset: 0x00271B90
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroMediaAlignComponent._ClassPtr;
		}

		// Token: 0x0601A9B8 RID: 108984 RVA: 0x0027399C File Offset: 0x00271B9C
		public UKuroMediaAlignComponent() : this(BuiltinUtils.AllocNativeUObject(UKuroMediaAlignComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601A9B9 RID: 108985 RVA: 0x002739C4 File Offset: 0x00271BC4
		[NullableContext(1)]
		public UKuroMediaAlignComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroMediaAlignComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006ADF RID: 27359
		// (get) Token: 0x0601A9BA RID: 108986 RVA: 0x002739F7 File Offset: 0x00271BF7
		// (set) Token: 0x0601A9BB RID: 108987 RVA: 0x00273A0B File Offset: 0x00271C0B
		public unsafe FName AlignKey
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroMediaAlignComponent.__PropertyOffset_AlignKey);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroMediaAlignComponent.__PropertyOffset_AlignKey) = value;
			}
		}

		// Token: 0x17006AE0 RID: 27360
		// (get) Token: 0x0601A9BC RID: 108988 RVA: 0x00273A20 File Offset: 0x00271C20
		// (set) Token: 0x0601A9BD RID: 108989 RVA: 0x00273A34 File Offset: 0x00271C34
		public unsafe UMediaSource MediaSource
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMediaSource>(base.NativePtr / (IntPtr)sizeof(void*) + UKuroMediaAlignComponent.__PropertyOffset_MediaSource);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKuroMediaAlignComponent.__PropertyOffset_MediaSource, value);
			}
		}

		// Token: 0x17006AE1 RID: 27361
		// (get) Token: 0x0601A9BE RID: 108990 RVA: 0x00273A49 File Offset: 0x00271C49
		// (set) Token: 0x0601A9BF RID: 108991 RVA: 0x00273A5D File Offset: 0x00271C5D
		public unsafe UMediaTexture MediaTexture
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMediaTexture>(base.NativePtr / (IntPtr)sizeof(void*) + UKuroMediaAlignComponent.__PropertyOffset_MediaTexture);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKuroMediaAlignComponent.__PropertyOffset_MediaTexture, value);
			}
		}

		// Token: 0x17006AE2 RID: 27362
		// (get) Token: 0x0601A9C0 RID: 108992 RVA: 0x00273A72 File Offset: 0x00271C72
		// (set) Token: 0x0601A9C1 RID: 108993 RVA: 0x00273A86 File Offset: 0x00271C86
		public unsafe UMediaSoundComponent MediaSoundComponent
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMediaSoundComponent>(base.NativePtr / (IntPtr)sizeof(void*) + UKuroMediaAlignComponent.__PropertyOffset_MediaSoundComponent);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKuroMediaAlignComponent.__PropertyOffset_MediaSoundComponent, value);
			}
		}

		// Token: 0x17006AE3 RID: 27363
		// (get) Token: 0x0601A9C2 RID: 108994 RVA: 0x00273A9B File Offset: 0x00271C9B
		// (set) Token: 0x0601A9C3 RID: 108995 RVA: 0x00273AAB File Offset: 0x00271CAB
		public unsafe int MaxQueuedVideoSamples
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroMediaAlignComponent.__PropertyOffset_MaxQueuedVideoSamples);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroMediaAlignComponent.__PropertyOffset_MaxQueuedVideoSamples) = value;
			}
		}

		// Token: 0x17006AE4 RID: 27364
		// (get) Token: 0x0601A9C4 RID: 108996 RVA: 0x00273ABC File Offset: 0x00271CBC
		// (set) Token: 0x0601A9C5 RID: 108997 RVA: 0x00273ACC File Offset: 0x00271CCC
		public unsafe int MaxQueuedAudioSamples
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroMediaAlignComponent.__PropertyOffset_MaxQueuedAudioSamples);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroMediaAlignComponent.__PropertyOffset_MaxQueuedAudioSamples) = value;
			}
		}

		// Token: 0x17006AE5 RID: 27365
		// (get) Token: 0x0601A9C6 RID: 108998 RVA: 0x00273ADD File Offset: 0x00271CDD
		// (set) Token: 0x0601A9C7 RID: 108999 RVA: 0x00273AED File Offset: 0x00271CED
		public unsafe EKuroMediaPrewarmMode PrewarmMode
		{
			get
			{
				return (EKuroMediaPrewarmMode)(*(base.NativePtr + (IntPtr)UKuroMediaAlignComponent.__PropertyOffset_PrewarmMode));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroMediaAlignComponent.__PropertyOffset_PrewarmMode) = (byte)value;
			}
		}

		// Token: 0x17006AE6 RID: 27366
		// (get) Token: 0x0601A9C8 RID: 109000 RVA: 0x00273AFE File Offset: 0x00271CFE
		// (set) Token: 0x0601A9C9 RID: 109001 RVA: 0x00273B12 File Offset: 0x00271D12
		public unsafe UMediaPlayer MediaPlayer
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMediaPlayer>(base.NativePtr / (IntPtr)sizeof(void*) + UKuroMediaAlignComponent.__PropertyOffset_MediaPlayer);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKuroMediaAlignComponent.__PropertyOffset_MediaPlayer, value);
			}
		}

		// Token: 0x0601A9CA RID: 109002 RVA: 0x00273B27 File Offset: 0x00271D27
		public void SetSource(UMediaSource NewSource)
		{
			UKuroMediaAlignComponent.__SetSource_Internal(base.NativePtr, (NewSource != null) ? NewSource.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601A9CB RID: 109003 RVA: 0x00273B44 File Offset: 0x00271D44
		public void SetMediaTexture(UMediaTexture Texture)
		{
			UKuroMediaAlignComponent.__SetMediaTexture_Internal(base.NativePtr, (Texture != null) ? Texture.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601A9CC RID: 109004 RVA: 0x00273B61 File Offset: 0x00271D61
		public void SetAlignKey(FName KeyName)
		{
			UKuroMediaAlignComponent.__SetAlignKey_Internal(base.NativePtr, KeyName);
		}

		// Token: 0x0601A9CD RID: 109005 RVA: 0x00273B6F File Offset: 0x00271D6F
		public void PrewarmMedia()
		{
			UKuroMediaAlignComponent.__PrewarmMedia_Internal(base.NativePtr);
		}

		// Token: 0x0601A9CE RID: 109006 RVA: 0x00273B7C File Offset: 0x00271D7C
		public void NotifySequenceTime(FTimespan InSequenceTime, bool bPlaying)
		{
			UKuroMediaAlignComponent.__NotifySequenceTime_Internal(base.NativePtr, (InSequenceTime ?? new FTimespan()).NativePtr, bPlaying);
		}

		// Token: 0x0601A9CF RID: 109007 RVA: 0x00273B99 File Offset: 0x00271D99
		public void NotifyPlaybackFinished()
		{
			UKuroMediaAlignComponent.__NotifyPlaybackFinished_Internal(base.NativePtr);
		}

		// Token: 0x0601A9D0 RID: 109008 RVA: 0x00273BA6 File Offset: 0x00271DA6
		public UMediaPlayer GetMediaPlayer()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UMediaPlayer>(UKuroMediaAlignComponent.__GetMediaPlayer_Internal(base.NativePtr));
		}

		// Token: 0x0601A9D1 RID: 109009 RVA: 0x00273BB8 File Offset: 0x00271DB8
		public void CloseSource()
		{
			UKuroMediaAlignComponent.__CloseSource_Internal(base.NativePtr);
		}

		// Token: 0x0601A9D2 RID: 109010 RVA: 0x00273BC5 File Offset: 0x00271DC5
		public void ClearSource()
		{
			UKuroMediaAlignComponent.__ClearSource_Internal(base.NativePtr);
		}

		// Token: 0x0601A9D3 RID: 109011
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSource_Internal(IntPtr @this, IntPtr NewSource);

		// Token: 0x0601A9D4 RID: 109012
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetMediaTexture_Internal(IntPtr @this, IntPtr Texture);

		// Token: 0x0601A9D5 RID: 109013
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAlignKey_Internal(IntPtr @this, FName KeyName);

		// Token: 0x0601A9D6 RID: 109014
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __PrewarmMedia_Internal(IntPtr @this);

		// Token: 0x0601A9D7 RID: 109015
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __NotifySequenceTime_Internal(IntPtr @this, IntPtr InSequenceTime, bool bPlaying);

		// Token: 0x0601A9D8 RID: 109016
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __NotifyPlaybackFinished_Internal(IntPtr @this);

		// Token: 0x0601A9D9 RID: 109017
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetMediaPlayer_Internal(IntPtr @this);

		// Token: 0x0601A9DA RID: 109018
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __CloseSource_Internal(IntPtr @this);

		// Token: 0x0601A9DB RID: 109019
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClearSource_Internal(IntPtr @this);

		// Token: 0x0601A9DC RID: 109020 RVA: 0x00273BD2 File Offset: 0x00271DD2
		static UKuroMediaAlignComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroMediaAlignComponent");
		}

		// Token: 0x0601A9DD RID: 109021 RVA: 0x00273BE0 File Offset: 0x00271DE0
		protected UKuroMediaAlignComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400E667 RID: 58983
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroMediaAlignComponent";

		// Token: 0x0400E668 RID: 58984
		private static IntPtr _ClassPtr;

		// Token: 0x0400E669 RID: 58985
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400E66A RID: 58986
		internal static int __PropertyOffset_AlignKey;

		// Token: 0x0400E66B RID: 58987
		internal static int __PropertyOffset_MediaSource;

		// Token: 0x0400E66C RID: 58988
		internal static int __PropertyOffset_MediaTexture;

		// Token: 0x0400E66D RID: 58989
		internal static int __PropertyOffset_MediaSoundComponent;

		// Token: 0x0400E66E RID: 58990
		internal static int __PropertyOffset_MaxQueuedVideoSamples;

		// Token: 0x0400E66F RID: 58991
		internal static int __PropertyOffset_MaxQueuedAudioSamples;

		// Token: 0x0400E670 RID: 58992
		internal static int __PropertyOffset_PrewarmMode;

		// Token: 0x0400E671 RID: 58993
		internal static int __PropertyOffset_MediaPlayer;
	}
}
