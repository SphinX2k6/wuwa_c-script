using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002106 RID: 8454
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.SequencerManager")]
	[UnrealStructLayout(432, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 432)]
	public class USequencerManager : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601FCFA RID: 130298 RVA: 0x002F4FE9 File Offset: 0x002F31E9
		public new static UClassStackOnlyPtr StaticClass()
		{
			return USequencerManager._ClassPtr;
		}

		// Token: 0x0601FCFB RID: 130299 RVA: 0x002F4FF8 File Offset: 0x002F31F8
		public USequencerManager() : this(BuiltinUtils.AllocNativeUObject(USequencerManager.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601FCFC RID: 130300 RVA: 0x002F5020 File Offset: 0x002F3220
		public USequencerManager(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(USequencerManager.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007D25 RID: 32037
		// (get) Token: 0x0601FCFD RID: 130301 RVA: 0x002F5054 File Offset: 0x002F3254
		// (set) Token: 0x0601FCFE RID: 130302 RVA: 0x002F508D File Offset: 0x002F328D
		public TArray<FLevelSequencerActor> AllLvlSequencerActors
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FLevelSequencerActor> result;
				if ((result = this._AllLvlSequencerActors) == null)
				{
					result = (this._AllLvlSequencerActors = new TArray<FLevelSequencerActor>(base.NativePtr + (IntPtr)USequencerManager.__PropertyOffset_AllLvlSequencerActors, this));
				}
				return result;
			}
			set
			{
				this.AllLvlSequencerActors.CopyAssign(value);
			}
		}

		// Token: 0x17007D26 RID: 32038
		// (get) Token: 0x0601FCFF RID: 130303 RVA: 0x002F509C File Offset: 0x002F329C
		// (set) Token: 0x0601FD00 RID: 130304 RVA: 0x002F50D5 File Offset: 0x002F32D5
		public TArray<USequencePlayContext> BatchPlayContexts
		{
			get
			{
				base.FastCheckIsValid();
				TArray<USequencePlayContext> result;
				if ((result = this._BatchPlayContexts) == null)
				{
					result = (this._BatchPlayContexts = new TArray<USequencePlayContext>(base.NativePtr + (IntPtr)USequencerManager.__PropertyOffset_BatchPlayContexts, this));
				}
				return result;
			}
			set
			{
				this.BatchPlayContexts.CopyAssign(value);
			}
		}

		// Token: 0x17007D27 RID: 32039
		// (get) Token: 0x0601FD01 RID: 130305 RVA: 0x002F50E3 File Offset: 0x002F32E3
		// (set) Token: 0x0601FD02 RID: 130306 RVA: 0x002F50F7 File Offset: 0x002F32F7
		[Nullable(2)]
		public unsafe USequencePlayContext TransientSyncParamContext
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USequencePlayContext>(base.NativePtr / (IntPtr)sizeof(void*) + USequencerManager.__PropertyOffset_TransientSyncParamContext);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + USequencerManager.__PropertyOffset_TransientSyncParamContext, value);
			}
		}

		// Token: 0x0601FD03 RID: 130307 RVA: 0x002F510C File Offset: 0x002F330C
		public void SetGlobalPlayRate(float NewPlayRate)
		{
			USequencerManager.__SetGlobalPlayRate_Internal(base.NativePtr, NewPlayRate);
		}

		// Token: 0x0601FD04 RID: 130308 RVA: 0x002F511A File Offset: 0x002F331A
		[NullableContext(2)]
		public static void LoadSequenceAssetAsync(UObject Context, in FSoftObjectPath Path, in FSequenceLoadedEvent OnLoad)
		{
			IntPtr context = (Context != null) ? Context.NativePtr : IntPtr.Zero;
			IntPtr nativePtr = (Path ?? new FSoftObjectPath()).NativePtr;
			FSequenceLoadedEvent fsequenceLoadedEvent = OnLoad;
			USequencerManager.__LoadSequenceAssetAsync_Internal(context, nativePtr, (fsequenceLoadedEvent != null) ? fsequenceLoadedEvent.NativePtr : ((IntPtr)0));
		}

		// Token: 0x0601FD05 RID: 130309 RVA: 0x002F5150 File Offset: 0x002F3350
		[NullableContext(2)]
		public static ESequenceLoadState GetSequenceLoadState(UObject Context, in FSoftObjectPath Path)
		{
			return USequencerManager.__GetSequenceLoadState_Internal((Context != null) ? Context.NativePtr : IntPtr.Zero, (Path ?? new FSoftObjectPath()).NativePtr);
		}

		// Token: 0x0601FD06 RID: 130310 RVA: 0x002F5177 File Offset: 0x002F3377
		public float GetGlobalPlayRate()
		{
			return USequencerManager.__GetGlobalPlayRate_Internal(base.NativePtr);
		}

		// Token: 0x0601FD07 RID: 130311 RVA: 0x002F5184 File Offset: 0x002F3384
		[NullableContext(2)]
		public static USequencePlayContext GetBatchPlayContext(UObject Context)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<USequencePlayContext>(USequencerManager.__GetBatchPlayContext_Internal((Context != null) ? Context.NativePtr : IntPtr.Zero));
		}

		// Token: 0x0601FD08 RID: 130312 RVA: 0x002F51A0 File Offset: 0x002F33A0
		[NullableContext(2)]
		public void ClearInvalidBind(ALevelSequenceActor SeqActor)
		{
			USequencerManager.__ClearInvalidBind_Internal(base.NativePtr, (SeqActor != null) ? SeqActor.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601FD09 RID: 130313 RVA: 0x002F51C0 File Offset: 0x002F33C0
		[NullableContext(2)]
		public static ALevelSequenceActor BatchPlaySequenceOnActors(UObject Context, in FSoftObjectPath SequencePath, [Nullable(new byte[]
		{
			2,
			1
		})] in TArray<AUIBaseActor> BatchRoots, in FMovieSceneSequencePlaybackSettings PlaySetting)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ALevelSequenceActor>(USequencerManager.__BatchPlaySequenceOnActors_Internal((Context != null) ? Context.NativePtr : IntPtr.Zero, (SequencePath ?? new FSoftObjectPath()).NativePtr, (BatchRoots ?? new TArray<AUIBaseActor>()).NativePtr, (PlaySetting ?? new FMovieSceneSequencePlaybackSettings()).NativePtr));
		}

		// Token: 0x0601FD0A RID: 130314
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetGlobalPlayRate_Internal(IntPtr @this, float NewPlayRate);

		// Token: 0x0601FD0B RID: 130315
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __LoadSequenceAssetAsync_Internal(IntPtr Context, IntPtr Path, IntPtr OnLoad);

		// Token: 0x0601FD0C RID: 130316
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern ESequenceLoadState __GetSequenceLoadState_Internal(IntPtr Context, IntPtr Path);

		// Token: 0x0601FD0D RID: 130317
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetGlobalPlayRate_Internal(IntPtr @this);

		// Token: 0x0601FD0E RID: 130318
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetBatchPlayContext_Internal(IntPtr Context);

		// Token: 0x0601FD0F RID: 130319
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClearInvalidBind_Internal(IntPtr @this, IntPtr SeqActor);

		// Token: 0x0601FD10 RID: 130320
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __BatchPlaySequenceOnActors_Internal(IntPtr Context, IntPtr SequencePath, IntPtr BatchRoots, IntPtr PlaySetting);

		// Token: 0x0601FD11 RID: 130321 RVA: 0x002F5217 File Offset: 0x002F3417
		static USequencerManager()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.SequencerManager");
		}

		// Token: 0x0601FD12 RID: 130322 RVA: 0x002F5225 File Offset: 0x002F3425
		protected USequencerManager(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401124F RID: 70223
		public new const string __ObjectPath = "/Script/LGUI.SequencerManager";

		// Token: 0x04011250 RID: 70224
		private static IntPtr _ClassPtr;

		// Token: 0x04011251 RID: 70225
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011252 RID: 70226
		internal static int __PropertyOffset_AllLvlSequencerActors;

		// Token: 0x04011253 RID: 70227
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FLevelSequencerActor> _AllLvlSequencerActors;

		// Token: 0x04011254 RID: 70228
		internal static int __PropertyOffset_BatchPlayContexts;

		// Token: 0x04011255 RID: 70229
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<USequencePlayContext> _BatchPlayContexts;

		// Token: 0x04011256 RID: 70230
		internal static int __PropertyOffset_TransientSyncParamContext;
	}
}
