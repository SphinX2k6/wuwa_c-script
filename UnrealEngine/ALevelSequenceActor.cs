using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001FB0 RID: 8112
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LevelSequence.LevelSequenceActor")]
	[UnrealStructLayout(1192, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1192)]
	public class ALevelSequenceActor : AActor, IUnrealUObject, IUnrealObject, IMovieScenePlaybackClient, IUnrealNativeInterface, IUnrealInterface, IMovieSceneBindingOwnerInterface
	{
		// Token: 0x0601EC84 RID: 126084 RVA: 0x002DC213 File Offset: 0x002DA413
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ALevelSequenceActor._ClassPtr;
		}

		// Token: 0x0601EC85 RID: 126085 RVA: 0x002DC21F File Offset: 0x002DA41F
		int IMovieScenePlaybackClient.InterfaceOffset()
		{
			return ALevelSequenceActor.__InterfaceOffset_IMovieScenePlaybackClient;
		}

		// Token: 0x0601EC86 RID: 126086 RVA: 0x002DC226 File Offset: 0x002DA426
		int IMovieSceneBindingOwnerInterface.InterfaceOffset()
		{
			return ALevelSequenceActor.__InterfaceOffset_IMovieSceneBindingOwnerInterface;
		}

		// Token: 0x0601EC87 RID: 126087 RVA: 0x002DC230 File Offset: 0x002DA430
		public ALevelSequenceActor() : this(BuiltinUtils.AllocNativeUObject(ALevelSequenceActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601EC88 RID: 126088 RVA: 0x002DC258 File Offset: 0x002DA458
		[NullableContext(1)]
		public ALevelSequenceActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ALevelSequenceActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007A9E RID: 31390
		// (get) Token: 0x0601EC89 RID: 126089 RVA: 0x002DC28C File Offset: 0x002DA48C
		// (set) Token: 0x0601EC8A RID: 126090 RVA: 0x002DC2C5 File Offset: 0x002DA4C5
		[Nullable(1)]
		public FMovieSceneSequencePlaybackSettings PlaybackSettings
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FMovieSceneSequencePlaybackSettings result;
				if ((result = this._PlaybackSettings) == null)
				{
					result = (this._PlaybackSettings = new FMovieSceneSequencePlaybackSettings(base.NativePtr + (IntPtr)ALevelSequenceActor.__PropertyOffset_PlaybackSettings, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMovieSceneSequencePlaybackSettings.StaticStruct(), base.NativePtr + (IntPtr)ALevelSequenceActor.__PropertyOffset_PlaybackSettings, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17007A9F RID: 31391
		// (get) Token: 0x0601EC8B RID: 126091 RVA: 0x002DC2E6 File Offset: 0x002DA4E6
		// (set) Token: 0x0601EC8C RID: 126092 RVA: 0x002DC2FA File Offset: 0x002DA4FA
		public unsafe ULevelSequencePlayer SequencePlayer
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ULevelSequencePlayer>(base.NativePtr / (IntPtr)sizeof(void*) + ALevelSequenceActor.__PropertyOffset_SequencePlayer);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ALevelSequenceActor.__PropertyOffset_SequencePlayer, value);
			}
		}

		// Token: 0x17007AA0 RID: 31392
		// (get) Token: 0x0601EC8D RID: 126093 RVA: 0x002DC310 File Offset: 0x002DA510
		// (set) Token: 0x0601EC8E RID: 126094 RVA: 0x002DC349 File Offset: 0x002DA549
		[Nullable(1)]
		public FSoftObjectPath LevelSequence
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FSoftObjectPath result;
				if ((result = this._LevelSequence) == null)
				{
					result = (this._LevelSequence = new FSoftObjectPath(base.NativePtr + (IntPtr)ALevelSequenceActor.__PropertyOffset_LevelSequence, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoftObjectPath.StaticStruct(), base.NativePtr + (IntPtr)ALevelSequenceActor.__PropertyOffset_LevelSequence, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17007AA1 RID: 31393
		// (get) Token: 0x0601EC8F RID: 126095 RVA: 0x002DC36C File Offset: 0x002DA56C
		// (set) Token: 0x0601EC90 RID: 126096 RVA: 0x002DC3A5 File Offset: 0x002DA5A5
		[Nullable(1)]
		public FLevelSequenceCameraSettings CameraSettings
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FLevelSequenceCameraSettings result;
				if ((result = this._CameraSettings) == null)
				{
					result = (this._CameraSettings = new FLevelSequenceCameraSettings(base.NativePtr + (IntPtr)ALevelSequenceActor.__PropertyOffset_CameraSettings, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FLevelSequenceCameraSettings.StaticStruct(), base.NativePtr + (IntPtr)ALevelSequenceActor.__PropertyOffset_CameraSettings, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17007AA2 RID: 31394
		// (get) Token: 0x0601EC91 RID: 126097 RVA: 0x002DC3C6 File Offset: 0x002DA5C6
		// (set) Token: 0x0601EC92 RID: 126098 RVA: 0x002DC3DA File Offset: 0x002DA5DA
		public unsafe ULevelSequenceBurnInOptions BurnInOptions
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ULevelSequenceBurnInOptions>(base.NativePtr / (IntPtr)sizeof(void*) + ALevelSequenceActor.__PropertyOffset_BurnInOptions);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ALevelSequenceActor.__PropertyOffset_BurnInOptions, value);
			}
		}

		// Token: 0x17007AA3 RID: 31395
		// (get) Token: 0x0601EC93 RID: 126099 RVA: 0x002DC3EF File Offset: 0x002DA5EF
		// (set) Token: 0x0601EC94 RID: 126100 RVA: 0x002DC403 File Offset: 0x002DA603
		public unsafe UMovieSceneBindingOverrides BindingOverrides
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMovieSceneBindingOverrides>(base.NativePtr / (IntPtr)sizeof(void*) + ALevelSequenceActor.__PropertyOffset_BindingOverrides);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ALevelSequenceActor.__PropertyOffset_BindingOverrides, value);
			}
		}

		// Token: 0x17007AA4 RID: 31396
		// (get) Token: 0x0601EC95 RID: 126101 RVA: 0x002DC418 File Offset: 0x002DA618
		// (set) Token: 0x0601EC96 RID: 126102 RVA: 0x002DC431 File Offset: 0x002DA631
		public unsafe bool bAutoPlay_DEPRECATED
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)ALevelSequenceActor.__PropertyOffset_bAutoPlay_DEPRECATED) & ALevelSequenceActor.__PropertyMask_bAutoPlay_DEPRECATED) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)ALevelSequenceActor.__PropertyOffset_bAutoPlay_DEPRECATED) = ((*(base.NativePtr + (IntPtr)ALevelSequenceActor.__PropertyOffset_bAutoPlay_DEPRECATED) & ~ALevelSequenceActor.__PropertyMask_bAutoPlay_DEPRECATED) | (value ? ALevelSequenceActor.__PropertyMask_bAutoPlay_DEPRECATED : 0));
			}
		}

		// Token: 0x17007AA5 RID: 31397
		// (get) Token: 0x0601EC97 RID: 126103 RVA: 0x002DC461 File Offset: 0x002DA661
		// (set) Token: 0x0601EC98 RID: 126104 RVA: 0x002DC47A File Offset: 0x002DA67A
		public unsafe bool bOverrideInstanceData
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)ALevelSequenceActor.__PropertyOffset_bOverrideInstanceData) & ALevelSequenceActor.__PropertyMask_bOverrideInstanceData) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)ALevelSequenceActor.__PropertyOffset_bOverrideInstanceData) = ((*(base.NativePtr + (IntPtr)ALevelSequenceActor.__PropertyOffset_bOverrideInstanceData) & ~ALevelSequenceActor.__PropertyMask_bOverrideInstanceData) | (value ? ALevelSequenceActor.__PropertyMask_bOverrideInstanceData : 0));
			}
		}

		// Token: 0x17007AA6 RID: 31398
		// (get) Token: 0x0601EC99 RID: 126105 RVA: 0x002DC4AA File Offset: 0x002DA6AA
		// (set) Token: 0x0601EC9A RID: 126106 RVA: 0x002DC4C3 File Offset: 0x002DA6C3
		public unsafe bool bReplicatePlayback
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)ALevelSequenceActor.__PropertyOffset_bReplicatePlayback) & ALevelSequenceActor.__PropertyMask_bReplicatePlayback) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)ALevelSequenceActor.__PropertyOffset_bReplicatePlayback) = ((*(base.NativePtr + (IntPtr)ALevelSequenceActor.__PropertyOffset_bReplicatePlayback) & ~ALevelSequenceActor.__PropertyMask_bReplicatePlayback) | (value ? ALevelSequenceActor.__PropertyMask_bReplicatePlayback : 0));
			}
		}

		// Token: 0x17007AA7 RID: 31399
		// (get) Token: 0x0601EC9B RID: 126107 RVA: 0x002DC4F3 File Offset: 0x002DA6F3
		// (set) Token: 0x0601EC9C RID: 126108 RVA: 0x002DC507 File Offset: 0x002DA707
		public unsafe UObject DefaultInstanceData
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UObject>(base.NativePtr / (IntPtr)sizeof(void*) + ALevelSequenceActor.__PropertyOffset_DefaultInstanceData);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ALevelSequenceActor.__PropertyOffset_DefaultInstanceData, value);
			}
		}

		// Token: 0x17007AA8 RID: 31400
		// (get) Token: 0x0601EC9D RID: 126109 RVA: 0x002DC51C File Offset: 0x002DA71C
		// (set) Token: 0x0601EC9E RID: 126110 RVA: 0x002DC530 File Offset: 0x002DA730
		public unsafe ULevelSequenceBurnIn BurnInInstance
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ULevelSequenceBurnIn>(base.NativePtr / (IntPtr)sizeof(void*) + ALevelSequenceActor.__PropertyOffset_BurnInInstance);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ALevelSequenceActor.__PropertyOffset_BurnInInstance, value);
			}
		}

		// Token: 0x17007AA9 RID: 31401
		// (get) Token: 0x0601EC9F RID: 126111 RVA: 0x002DC545 File Offset: 0x002DA745
		// (set) Token: 0x0601ECA0 RID: 126112 RVA: 0x002DC555 File Offset: 0x002DA755
		public unsafe bool bShowBurnin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ALevelSequenceActor.__PropertyOffset_bShowBurnin) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ALevelSequenceActor.__PropertyOffset_bShowBurnin) = (value ? 1 : 0);
			}
		}

		// Token: 0x0601ECA1 RID: 126113 RVA: 0x002DC566 File Offset: 0x002DA766
		public void ShowBurnin()
		{
			ALevelSequenceActor.__ShowBurnin_Internal(base.NativePtr);
		}

		// Token: 0x0601ECA2 RID: 126114 RVA: 0x002DC573 File Offset: 0x002DA773
		public void SetTickOptimize(bool Enable, bool InCheckBindingActorVisibility, bool InSeekTicks)
		{
			ALevelSequenceActor.__SetTickOptimize_Internal(base.NativePtr, Enable, InCheckBindingActorVisibility, InSeekTicks);
		}

		// Token: 0x0601ECA3 RID: 126115 RVA: 0x002DC583 File Offset: 0x002DA783
		public void SetShouldLatentDestroy(bool bInShouldLatentDestroy)
		{
			ALevelSequenceActor.__SetShouldLatentDestroy_Internal(base.NativePtr, bInShouldLatentDestroy);
		}

		// Token: 0x0601ECA4 RID: 126116 RVA: 0x002DC591 File Offset: 0x002DA791
		public void SetSequence(ULevelSequence InSequence)
		{
			ALevelSequenceActor.__SetSequence_Internal(base.NativePtr, (InSequence != null) ? InSequence.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601ECA5 RID: 126117 RVA: 0x002DC5AE File Offset: 0x002DA7AE
		public void SetReplicatePlayback(bool ReplicatePlayback)
		{
			ALevelSequenceActor.__SetReplicatePlayback_Internal(base.NativePtr, ReplicatePlayback);
		}

		// Token: 0x0601ECA6 RID: 126118 RVA: 0x002DC5BC File Offset: 0x002DA7BC
		public void SetBindingByTag(FName BindingTag, [Nullable(new byte[]
		{
			2,
			1
		})] in TArray<AActor> Actors, bool bAllowBindingsFromAsset = false, bool IncludeSubSequence = false)
		{
			ALevelSequenceActor.__SetBindingByTag_Internal(base.NativePtr, BindingTag, (Actors ?? new TArray<AActor>()).NativePtr, bAllowBindingsFromAsset, IncludeSubSequence);
		}

		// Token: 0x0601ECA7 RID: 126119 RVA: 0x002DC5DD File Offset: 0x002DA7DD
		public void SetBinding(FMovieSceneObjectBindingID Binding, [Nullable(new byte[]
		{
			2,
			1
		})] in TArray<AActor> Actors, bool bAllowBindingsFromAsset = false)
		{
			ALevelSequenceActor.__SetBinding_Internal(base.NativePtr, (Binding ?? new FMovieSceneObjectBindingID()).NativePtr, (Actors ?? new TArray<AActor>()).NativePtr, bAllowBindingsFromAsset);
		}

		// Token: 0x0601ECA8 RID: 126120 RVA: 0x002DC60A File Offset: 0x002DA80A
		public void ResetBindings()
		{
			ALevelSequenceActor.__ResetBindings_Internal(base.NativePtr);
		}

		// Token: 0x0601ECA9 RID: 126121 RVA: 0x002DC617 File Offset: 0x002DA817
		public void ResetBinding(FMovieSceneObjectBindingID Binding)
		{
			ALevelSequenceActor.__ResetBinding_Internal(base.NativePtr, (Binding ?? new FMovieSceneObjectBindingID()).NativePtr);
		}

		// Token: 0x0601ECAA RID: 126122 RVA: 0x002DC633 File Offset: 0x002DA833
		public void RemoveBindingByTag(FName Tag, AActor Actor, bool IncludeSubSequence = false)
		{
			ALevelSequenceActor.__RemoveBindingByTag_Internal(base.NativePtr, Tag, (Actor != null) ? Actor.NativePtr : IntPtr.Zero, IncludeSubSequence);
		}

		// Token: 0x0601ECAB RID: 126123 RVA: 0x002DC652 File Offset: 0x002DA852
		public void RemoveBinding(FMovieSceneObjectBindingID Binding, AActor Actor)
		{
			ALevelSequenceActor.__RemoveBinding_Internal(base.NativePtr, (Binding ?? new FMovieSceneObjectBindingID()).NativePtr, (Actor != null) ? Actor.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601ECAC RID: 126124 RVA: 0x002DC67E File Offset: 0x002DA87E
		public ULevelSequence LoadSequence()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ULevelSequence>(ALevelSequenceActor.__LoadSequence_Internal(base.NativePtr));
		}

		// Token: 0x0601ECAD RID: 126125 RVA: 0x002DC690 File Offset: 0x002DA890
		public void HideBurnin()
		{
			ALevelSequenceActor.__HideBurnin_Internal(base.NativePtr);
		}

		// Token: 0x0601ECAE RID: 126126 RVA: 0x002DC69D File Offset: 0x002DA89D
		public bool HasBindingByTag(FName BindingTag, bool IncludeSubSequence = false)
		{
			return ALevelSequenceActor.__HasBindingByTag_Internal(base.NativePtr, BindingTag, IncludeSubSequence);
		}

		// Token: 0x0601ECAF RID: 126127 RVA: 0x002DC6AC File Offset: 0x002DA8AC
		public ULevelSequencePlayer GetSequencePlayer()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ULevelSequencePlayer>(ALevelSequenceActor.__GetSequencePlayer_Internal(base.NativePtr));
		}

		// Token: 0x0601ECB0 RID: 126128 RVA: 0x002DC6BE File Offset: 0x002DA8BE
		public ULevelSequence GetSequence()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ULevelSequence>(ALevelSequenceActor.__GetSequence_Internal(base.NativePtr));
		}

		// Token: 0x0601ECB1 RID: 126129 RVA: 0x002DC6D0 File Offset: 0x002DA8D0
		[NullableContext(1)]
		public TArray<UObject> GetBindingByTagInTemplate(FName BindingTag, bool IncludeSubSequence)
		{
			return new TArray<UObject>(ALevelSequenceActor.__GetBindingByTagInTemplate_Internal(base.NativePtr, BindingTag, IncludeSubSequence), null);
		}

		// Token: 0x0601ECB2 RID: 126130 RVA: 0x002DC6E5 File Offset: 0x002DA8E5
		[NullableContext(1)]
		public TArray<UObject> GetBindingByTag(FName BindingTag, bool IncludeSubSequence = false)
		{
			return new TArray<UObject>(ALevelSequenceActor.__GetBindingByTag_Internal(base.NativePtr, BindingTag, IncludeSubSequence), null);
		}

		// Token: 0x0601ECB3 RID: 126131 RVA: 0x002DC6FA File Offset: 0x002DA8FA
		[NullableContext(1)]
		public TArray<FMovieSceneObjectBindingID> FindNamedBindings(FName Tag)
		{
			return new TArray<FMovieSceneObjectBindingID>(ALevelSequenceActor.__FindNamedBindings_Internal(base.NativePtr, Tag), null);
		}

		// Token: 0x0601ECB4 RID: 126132 RVA: 0x002DC70E File Offset: 0x002DA90E
		[NullableContext(1)]
		public FMovieSceneObjectBindingID FindNamedBinding(FName Tag)
		{
			return new FMovieSceneObjectBindingID(ALevelSequenceActor.__FindNamedBinding_Internal(base.NativePtr, Tag), null);
		}

		// Token: 0x0601ECB5 RID: 126133 RVA: 0x002DC722 File Offset: 0x002DA922
		public void AddBindingByTag(FName BindingTag, AActor Actor, bool bAllowBindingsFromAsset = false, bool IncludeSubSequence = false)
		{
			ALevelSequenceActor.__AddBindingByTag_Internal(base.NativePtr, BindingTag, (Actor != null) ? Actor.NativePtr : IntPtr.Zero, bAllowBindingsFromAsset, IncludeSubSequence);
		}

		// Token: 0x0601ECB6 RID: 126134 RVA: 0x002DC743 File Offset: 0x002DA943
		public void AddBinding(FMovieSceneObjectBindingID Binding, AActor Actor, bool bAllowBindingsFromAsset = false)
		{
			ALevelSequenceActor.__AddBinding_Internal(base.NativePtr, (Binding ?? new FMovieSceneObjectBindingID()).NativePtr, (Actor != null) ? Actor.NativePtr : IntPtr.Zero, bAllowBindingsFromAsset);
		}

		// Token: 0x0601ECB7 RID: 126135
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ShowBurnin_Internal(IntPtr @this);

		// Token: 0x0601ECB8 RID: 126136
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetTickOptimize_Internal(IntPtr @this, bool Enable, bool InCheckBindingActorVisibility, bool InSeekTicks);

		// Token: 0x0601ECB9 RID: 126137
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetShouldLatentDestroy_Internal(IntPtr @this, bool bInShouldLatentDestroy);

		// Token: 0x0601ECBA RID: 126138
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSequence_Internal(IntPtr @this, IntPtr InSequence);

		// Token: 0x0601ECBB RID: 126139
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetReplicatePlayback_Internal(IntPtr @this, bool ReplicatePlayback);

		// Token: 0x0601ECBC RID: 126140
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetBindingByTag_Internal(IntPtr @this, FName BindingTag, IntPtr Actors, bool bAllowBindingsFromAsset, bool IncludeSubSequence);

		// Token: 0x0601ECBD RID: 126141
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetBinding_Internal(IntPtr @this, IntPtr Binding, IntPtr Actors, bool bAllowBindingsFromAsset);

		// Token: 0x0601ECBE RID: 126142
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ResetBindings_Internal(IntPtr @this);

		// Token: 0x0601ECBF RID: 126143
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ResetBinding_Internal(IntPtr @this, IntPtr Binding);

		// Token: 0x0601ECC0 RID: 126144
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RemoveBindingByTag_Internal(IntPtr @this, FName Tag, IntPtr Actor, bool IncludeSubSequence);

		// Token: 0x0601ECC1 RID: 126145
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RemoveBinding_Internal(IntPtr @this, IntPtr Binding, IntPtr Actor);

		// Token: 0x0601ECC2 RID: 126146
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __LoadSequence_Internal(IntPtr @this);

		// Token: 0x0601ECC3 RID: 126147
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __HideBurnin_Internal(IntPtr @this);

		// Token: 0x0601ECC4 RID: 126148
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __HasBindingByTag_Internal(IntPtr @this, FName BindingTag, bool IncludeSubSequence);

		// Token: 0x0601ECC5 RID: 126149
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetSequencePlayer_Internal(IntPtr @this);

		// Token: 0x0601ECC6 RID: 126150
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetSequence_Internal(IntPtr @this);

		// Token: 0x0601ECC7 RID: 126151
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetBindingByTagInTemplate_Internal(IntPtr @this, FName BindingTag, bool IncludeSubSequence);

		// Token: 0x0601ECC8 RID: 126152
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetBindingByTag_Internal(IntPtr @this, FName BindingTag, bool IncludeSubSequence);

		// Token: 0x0601ECC9 RID: 126153
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __FindNamedBindings_Internal(IntPtr @this, FName Tag);

		// Token: 0x0601ECCA RID: 126154
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __FindNamedBinding_Internal(IntPtr @this, FName Tag);

		// Token: 0x0601ECCB RID: 126155
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddBindingByTag_Internal(IntPtr @this, FName BindingTag, IntPtr Actor, bool bAllowBindingsFromAsset, bool IncludeSubSequence);

		// Token: 0x0601ECCC RID: 126156
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddBinding_Internal(IntPtr @this, IntPtr Binding, IntPtr Actor, bool bAllowBindingsFromAsset);

		// Token: 0x0601ECCD RID: 126157 RVA: 0x002DC770 File Offset: 0x002DA970
		static ALevelSequenceActor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LevelSequence.LevelSequenceActor");
		}

		// Token: 0x0601ECCE RID: 126158 RVA: 0x002DC77E File Offset: 0x002DA97E
		protected ALevelSequenceActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010A46 RID: 68166
		internal static int __InterfaceOffset_IMovieScenePlaybackClient;

		// Token: 0x04010A47 RID: 68167
		internal static int __InterfaceOffset_IMovieSceneBindingOwnerInterface;

		// Token: 0x04010A48 RID: 68168
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LevelSequence.LevelSequenceActor";

		// Token: 0x04010A49 RID: 68169
		private static IntPtr _ClassPtr;

		// Token: 0x04010A4A RID: 68170
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010A4B RID: 68171
		public static IntPtr __OnLevelSequenceLoaded__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04010A4C RID: 68172
		internal static int __PropertyOffset_PlaybackSettings;

		// Token: 0x04010A4D RID: 68173
		private FMovieSceneSequencePlaybackSettings _PlaybackSettings;

		// Token: 0x04010A4E RID: 68174
		internal static int __PropertyOffset_SequencePlayer;

		// Token: 0x04010A4F RID: 68175
		internal static int __PropertyOffset_LevelSequence;

		// Token: 0x04010A50 RID: 68176
		private FSoftObjectPath _LevelSequence;

		// Token: 0x04010A51 RID: 68177
		internal static int __PropertyOffset_CameraSettings;

		// Token: 0x04010A52 RID: 68178
		private FLevelSequenceCameraSettings _CameraSettings;

		// Token: 0x04010A53 RID: 68179
		internal static int __PropertyOffset_BurnInOptions;

		// Token: 0x04010A54 RID: 68180
		internal static int __PropertyOffset_BindingOverrides;

		// Token: 0x04010A55 RID: 68181
		internal static int __PropertyOffset_bAutoPlay_DEPRECATED;

		// Token: 0x04010A56 RID: 68182
		internal static byte __PropertyMask_bAutoPlay_DEPRECATED;

		// Token: 0x04010A57 RID: 68183
		internal static int __PropertyOffset_bOverrideInstanceData;

		// Token: 0x04010A58 RID: 68184
		internal static byte __PropertyMask_bOverrideInstanceData;

		// Token: 0x04010A59 RID: 68185
		internal static int __PropertyOffset_bReplicatePlayback;

		// Token: 0x04010A5A RID: 68186
		internal static byte __PropertyMask_bReplicatePlayback;

		// Token: 0x04010A5B RID: 68187
		internal static int __PropertyOffset_DefaultInstanceData;

		// Token: 0x04010A5C RID: 68188
		internal static int __PropertyOffset_BurnInInstance;

		// Token: 0x04010A5D RID: 68189
		internal static int __PropertyOffset_bShowBurnin;
	}
}
