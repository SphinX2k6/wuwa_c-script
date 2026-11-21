using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000641 RID: 1601
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LevelSequence.LevelSequenceActor")]
	[UnrealStructLayout(1192, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1192)]
	public class ALevelSequenceActor : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06008CD7 RID: 36055 RVA: 0x000D3EE7 File Offset: 0x000D20E7
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ALevelSequenceActor._ClassPtr;
		}

		// Token: 0x06008CD8 RID: 36056 RVA: 0x000D3EF4 File Offset: 0x000D20F4
		public ALevelSequenceActor() : this(BuiltinUtils.AllocNativeUObject(ALevelSequenceActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06008CD9 RID: 36057 RVA: 0x000D3F1C File Offset: 0x000D211C
		[NullableContext(1)]
		public ALevelSequenceActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ALevelSequenceActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001AB2 RID: 6834
		// (get) Token: 0x06008CDA RID: 36058 RVA: 0x000D3F50 File Offset: 0x000D2150
		// (set) Token: 0x06008CDB RID: 36059 RVA: 0x000D3F89 File Offset: 0x000D2189
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

		// Token: 0x17001AB3 RID: 6835
		// (get) Token: 0x06008CDC RID: 36060 RVA: 0x000D3FAA File Offset: 0x000D21AA
		// (set) Token: 0x06008CDD RID: 36061 RVA: 0x000D3FBE File Offset: 0x000D21BE
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

		// Token: 0x17001AB4 RID: 6836
		// (get) Token: 0x06008CDE RID: 36062 RVA: 0x000D3FD4 File Offset: 0x000D21D4
		// (set) Token: 0x06008CDF RID: 36063 RVA: 0x000D400D File Offset: 0x000D220D
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

		// Token: 0x17001AB5 RID: 6837
		// (get) Token: 0x06008CE0 RID: 36064 RVA: 0x000D402E File Offset: 0x000D222E
		// (set) Token: 0x06008CE1 RID: 36065 RVA: 0x000D4047 File Offset: 0x000D2247
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

		// Token: 0x17001AB6 RID: 6838
		// (get) Token: 0x06008CE2 RID: 36066 RVA: 0x000D4077 File Offset: 0x000D2277
		// (set) Token: 0x06008CE3 RID: 36067 RVA: 0x000D4090 File Offset: 0x000D2290
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

		// Token: 0x17001AB7 RID: 6839
		// (get) Token: 0x06008CE4 RID: 36068 RVA: 0x000D40C0 File Offset: 0x000D22C0
		// (set) Token: 0x06008CE5 RID: 36069 RVA: 0x000D40D9 File Offset: 0x000D22D9
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

		// Token: 0x17001AB8 RID: 6840
		// (get) Token: 0x06008CE6 RID: 36070 RVA: 0x000D4109 File Offset: 0x000D2309
		// (set) Token: 0x06008CE7 RID: 36071 RVA: 0x000D411D File Offset: 0x000D231D
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

		// Token: 0x17001AB9 RID: 6841
		// (get) Token: 0x06008CE8 RID: 36072 RVA: 0x000D4132 File Offset: 0x000D2332
		// (set) Token: 0x06008CE9 RID: 36073 RVA: 0x000D4142 File Offset: 0x000D2342
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

		// Token: 0x06008CEA RID: 36074 RVA: 0x000D4153 File Offset: 0x000D2353
		public void ShowBurnin()
		{
			ALevelSequenceActor.__ShowBurnin_Internal(base.NativePtr);
		}

		// Token: 0x06008CEB RID: 36075 RVA: 0x000D4160 File Offset: 0x000D2360
		public void SetTickOptimize(bool Enable, bool InCheckBindingActorVisibility, bool InSeekTicks)
		{
			ALevelSequenceActor.__SetTickOptimize_Internal(base.NativePtr, Enable, InCheckBindingActorVisibility, InSeekTicks);
		}

		// Token: 0x06008CEC RID: 36076 RVA: 0x000D4170 File Offset: 0x000D2370
		public void SetShouldLatentDestroy(bool bInShouldLatentDestroy)
		{
			ALevelSequenceActor.__SetShouldLatentDestroy_Internal(base.NativePtr, bInShouldLatentDestroy);
		}

		// Token: 0x06008CED RID: 36077 RVA: 0x000D417E File Offset: 0x000D237E
		public void SetSequence(ULevelSequence InSequence)
		{
			ALevelSequenceActor.__SetSequence_Internal(base.NativePtr, (InSequence != null) ? InSequence.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06008CEE RID: 36078 RVA: 0x000D419B File Offset: 0x000D239B
		public void SetReplicatePlayback(bool ReplicatePlayback)
		{
			ALevelSequenceActor.__SetReplicatePlayback_Internal(base.NativePtr, ReplicatePlayback);
		}

		// Token: 0x06008CEF RID: 36079 RVA: 0x000D41A9 File Offset: 0x000D23A9
		public void SetBindingByTag(FName BindingTag, [Nullable(new byte[]
		{
			2,
			1
		})] in TArray<AActor> Actors, bool bAllowBindingsFromAsset = false, bool IncludeSubSequence = false)
		{
			ALevelSequenceActor.__SetBindingByTag_Internal(base.NativePtr, BindingTag, (Actors ?? new TArray<AActor>()).NativePtr, bAllowBindingsFromAsset, IncludeSubSequence);
		}

		// Token: 0x06008CF0 RID: 36080 RVA: 0x000D41CA File Offset: 0x000D23CA
		public void SetBinding(FMovieSceneObjectBindingID Binding, [Nullable(new byte[]
		{
			2,
			1
		})] in TArray<AActor> Actors, bool bAllowBindingsFromAsset = false)
		{
			ALevelSequenceActor.__SetBinding_Internal(base.NativePtr, (Binding ?? new FMovieSceneObjectBindingID()).NativePtr, (Actors ?? new TArray<AActor>()).NativePtr, bAllowBindingsFromAsset);
		}

		// Token: 0x06008CF1 RID: 36081 RVA: 0x000D41F7 File Offset: 0x000D23F7
		public void ResetBindings()
		{
			ALevelSequenceActor.__ResetBindings_Internal(base.NativePtr);
		}

		// Token: 0x06008CF2 RID: 36082 RVA: 0x000D4204 File Offset: 0x000D2404
		public void ResetBinding(FMovieSceneObjectBindingID Binding)
		{
			ALevelSequenceActor.__ResetBinding_Internal(base.NativePtr, (Binding ?? new FMovieSceneObjectBindingID()).NativePtr);
		}

		// Token: 0x06008CF3 RID: 36083 RVA: 0x000D4220 File Offset: 0x000D2420
		public void RemoveBindingByTag(FName Tag, AActor Actor, bool IncludeSubSequence = false)
		{
			ALevelSequenceActor.__RemoveBindingByTag_Internal(base.NativePtr, Tag, (Actor != null) ? Actor.NativePtr : IntPtr.Zero, IncludeSubSequence);
		}

		// Token: 0x06008CF4 RID: 36084 RVA: 0x000D423F File Offset: 0x000D243F
		public void RemoveBinding(FMovieSceneObjectBindingID Binding, AActor Actor)
		{
			ALevelSequenceActor.__RemoveBinding_Internal(base.NativePtr, (Binding ?? new FMovieSceneObjectBindingID()).NativePtr, (Actor != null) ? Actor.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06008CF5 RID: 36085 RVA: 0x000D426B File Offset: 0x000D246B
		public ULevelSequence LoadSequence()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ULevelSequence>(ALevelSequenceActor.__LoadSequence_Internal(base.NativePtr));
		}

		// Token: 0x06008CF6 RID: 36086 RVA: 0x000D427D File Offset: 0x000D247D
		public void HideBurnin()
		{
			ALevelSequenceActor.__HideBurnin_Internal(base.NativePtr);
		}

		// Token: 0x06008CF7 RID: 36087 RVA: 0x000D428A File Offset: 0x000D248A
		public bool HasBindingByTag(FName BindingTag, bool IncludeSubSequence = false)
		{
			return ALevelSequenceActor.__HasBindingByTag_Internal(base.NativePtr, BindingTag, IncludeSubSequence);
		}

		// Token: 0x06008CF8 RID: 36088 RVA: 0x000D4299 File Offset: 0x000D2499
		public ULevelSequencePlayer GetSequencePlayer()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ULevelSequencePlayer>(ALevelSequenceActor.__GetSequencePlayer_Internal(base.NativePtr));
		}

		// Token: 0x06008CF9 RID: 36089 RVA: 0x000D42AB File Offset: 0x000D24AB
		public ULevelSequence GetSequence()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ULevelSequence>(ALevelSequenceActor.__GetSequence_Internal(base.NativePtr));
		}

		// Token: 0x06008CFA RID: 36090 RVA: 0x000D42BD File Offset: 0x000D24BD
		[NullableContext(1)]
		public TArray<UObject> GetBindingByTagInTemplate(FName BindingTag, bool IncludeSubSequence)
		{
			return new TArray<UObject>(ALevelSequenceActor.__GetBindingByTagInTemplate_Internal(base.NativePtr, BindingTag, IncludeSubSequence), null);
		}

		// Token: 0x06008CFB RID: 36091 RVA: 0x000D42D2 File Offset: 0x000D24D2
		[NullableContext(1)]
		public TArray<UObject> GetBindingByTag(FName BindingTag, bool IncludeSubSequence = false)
		{
			return new TArray<UObject>(ALevelSequenceActor.__GetBindingByTag_Internal(base.NativePtr, BindingTag, IncludeSubSequence), null);
		}

		// Token: 0x06008CFC RID: 36092 RVA: 0x000D42E7 File Offset: 0x000D24E7
		[NullableContext(1)]
		public TArray<FMovieSceneObjectBindingID> FindNamedBindings(FName Tag)
		{
			return new TArray<FMovieSceneObjectBindingID>(ALevelSequenceActor.__FindNamedBindings_Internal(base.NativePtr, Tag), null);
		}

		// Token: 0x06008CFD RID: 36093 RVA: 0x000D42FB File Offset: 0x000D24FB
		[NullableContext(1)]
		public FMovieSceneObjectBindingID FindNamedBinding(FName Tag)
		{
			return new FMovieSceneObjectBindingID(ALevelSequenceActor.__FindNamedBinding_Internal(base.NativePtr, Tag), null);
		}

		// Token: 0x06008CFE RID: 36094 RVA: 0x000D430F File Offset: 0x000D250F
		public void AddBindingByTag(FName BindingTag, AActor Actor, bool bAllowBindingsFromAsset = false, bool IncludeSubSequence = false)
		{
			ALevelSequenceActor.__AddBindingByTag_Internal(base.NativePtr, BindingTag, (Actor != null) ? Actor.NativePtr : IntPtr.Zero, bAllowBindingsFromAsset, IncludeSubSequence);
		}

		// Token: 0x06008CFF RID: 36095 RVA: 0x000D4330 File Offset: 0x000D2530
		public void AddBinding(FMovieSceneObjectBindingID Binding, AActor Actor, bool bAllowBindingsFromAsset = false)
		{
			ALevelSequenceActor.__AddBinding_Internal(base.NativePtr, (Binding ?? new FMovieSceneObjectBindingID()).NativePtr, (Actor != null) ? Actor.NativePtr : IntPtr.Zero, bAllowBindingsFromAsset);
		}

		// Token: 0x06008D00 RID: 36096
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ShowBurnin_Internal(IntPtr @this);

		// Token: 0x06008D01 RID: 36097
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetTickOptimize_Internal(IntPtr @this, bool Enable, bool InCheckBindingActorVisibility, bool InSeekTicks);

		// Token: 0x06008D02 RID: 36098
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetShouldLatentDestroy_Internal(IntPtr @this, bool bInShouldLatentDestroy);

		// Token: 0x06008D03 RID: 36099
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSequence_Internal(IntPtr @this, IntPtr InSequence);

		// Token: 0x06008D04 RID: 36100
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetReplicatePlayback_Internal(IntPtr @this, bool ReplicatePlayback);

		// Token: 0x06008D05 RID: 36101
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetBindingByTag_Internal(IntPtr @this, FName BindingTag, IntPtr Actors, bool bAllowBindingsFromAsset, bool IncludeSubSequence);

		// Token: 0x06008D06 RID: 36102
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetBinding_Internal(IntPtr @this, IntPtr Binding, IntPtr Actors, bool bAllowBindingsFromAsset);

		// Token: 0x06008D07 RID: 36103
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ResetBindings_Internal(IntPtr @this);

		// Token: 0x06008D08 RID: 36104
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ResetBinding_Internal(IntPtr @this, IntPtr Binding);

		// Token: 0x06008D09 RID: 36105
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RemoveBindingByTag_Internal(IntPtr @this, FName Tag, IntPtr Actor, bool IncludeSubSequence);

		// Token: 0x06008D0A RID: 36106
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RemoveBinding_Internal(IntPtr @this, IntPtr Binding, IntPtr Actor);

		// Token: 0x06008D0B RID: 36107
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __LoadSequence_Internal(IntPtr @this);

		// Token: 0x06008D0C RID: 36108
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __HideBurnin_Internal(IntPtr @this);

		// Token: 0x06008D0D RID: 36109
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __HasBindingByTag_Internal(IntPtr @this, FName BindingTag, bool IncludeSubSequence);

		// Token: 0x06008D0E RID: 36110
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetSequencePlayer_Internal(IntPtr @this);

		// Token: 0x06008D0F RID: 36111
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetSequence_Internal(IntPtr @this);

		// Token: 0x06008D10 RID: 36112
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetBindingByTagInTemplate_Internal(IntPtr @this, FName BindingTag, bool IncludeSubSequence);

		// Token: 0x06008D11 RID: 36113
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetBindingByTag_Internal(IntPtr @this, FName BindingTag, bool IncludeSubSequence);

		// Token: 0x06008D12 RID: 36114
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __FindNamedBindings_Internal(IntPtr @this, FName Tag);

		// Token: 0x06008D13 RID: 36115
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __FindNamedBinding_Internal(IntPtr @this, FName Tag);

		// Token: 0x06008D14 RID: 36116
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddBindingByTag_Internal(IntPtr @this, FName BindingTag, IntPtr Actor, bool bAllowBindingsFromAsset, bool IncludeSubSequence);

		// Token: 0x06008D15 RID: 36117
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddBinding_Internal(IntPtr @this, IntPtr Binding, IntPtr Actor, bool bAllowBindingsFromAsset);

		// Token: 0x06008D16 RID: 36118 RVA: 0x000D435D File Offset: 0x000D255D
		static ALevelSequenceActor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LevelSequence.LevelSequenceActor");
		}

		// Token: 0x06008D17 RID: 36119 RVA: 0x000D436B File Offset: 0x000D256B
		protected ALevelSequenceActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04003D5B RID: 15707
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LevelSequence.LevelSequenceActor";

		// Token: 0x04003D5C RID: 15708
		private static IntPtr _ClassPtr;

		// Token: 0x04003D5D RID: 15709
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04003D5E RID: 15710
		public static IntPtr __OnLevelSequenceLoaded__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04003D5F RID: 15711
		internal static int __PropertyOffset_PlaybackSettings;

		// Token: 0x04003D60 RID: 15712
		private FMovieSceneSequencePlaybackSettings _PlaybackSettings;

		// Token: 0x04003D61 RID: 15713
		internal static int __PropertyOffset_SequencePlayer;

		// Token: 0x04003D62 RID: 15714
		internal static int __PropertyOffset_LevelSequence;

		// Token: 0x04003D63 RID: 15715
		private FSoftObjectPath _LevelSequence;

		// Token: 0x04003D64 RID: 15716
		internal static int __PropertyOffset_bAutoPlay_DEPRECATED;

		// Token: 0x04003D65 RID: 15717
		internal static byte __PropertyMask_bAutoPlay_DEPRECATED;

		// Token: 0x04003D66 RID: 15718
		internal static int __PropertyOffset_bOverrideInstanceData;

		// Token: 0x04003D67 RID: 15719
		internal static byte __PropertyMask_bOverrideInstanceData;

		// Token: 0x04003D68 RID: 15720
		internal static int __PropertyOffset_bReplicatePlayback;

		// Token: 0x04003D69 RID: 15721
		internal static byte __PropertyMask_bReplicatePlayback;

		// Token: 0x04003D6A RID: 15722
		internal static int __PropertyOffset_DefaultInstanceData;

		// Token: 0x04003D6B RID: 15723
		internal static int __PropertyOffset_bShowBurnin;
	}
}
