using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020006DC RID: 1756
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.SequencerManager")]
	[UnrealStructLayout(432, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 432)]
	public class USequencerManager : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600953F RID: 38207 RVA: 0x000E157D File Offset: 0x000DF77D
		public new static UClassStackOnlyPtr StaticClass()
		{
			return USequencerManager._ClassPtr;
		}

		// Token: 0x06009540 RID: 38208 RVA: 0x000E158C File Offset: 0x000DF78C
		public USequencerManager() : this(BuiltinUtils.AllocNativeUObject(USequencerManager.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06009541 RID: 38209 RVA: 0x000E15B4 File Offset: 0x000DF7B4
		[NullableContext(1)]
		public USequencerManager(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(USequencerManager.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001BB0 RID: 7088
		// (get) Token: 0x06009542 RID: 38210 RVA: 0x000E15E8 File Offset: 0x000DF7E8
		// (set) Token: 0x06009543 RID: 38211 RVA: 0x000E1621 File Offset: 0x000DF821
		[Nullable(1)]
		public TArray<USequencePlayContext> BatchPlayContexts
		{
			[NullableContext(1)]
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
			[NullableContext(1)]
			set
			{
				this.BatchPlayContexts.CopyAssign(value);
			}
		}

		// Token: 0x17001BB1 RID: 7089
		// (get) Token: 0x06009544 RID: 38212 RVA: 0x000E162F File Offset: 0x000DF82F
		// (set) Token: 0x06009545 RID: 38213 RVA: 0x000E1643 File Offset: 0x000DF843
		public unsafe USequencePlayContext TransientSyncParamContext
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USequencePlayContext>(base.NativePtr / (IntPtr)sizeof(void*) + USequencerManager.__PropertyOffset_TransientSyncParamContext);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + USequencerManager.__PropertyOffset_TransientSyncParamContext, value);
			}
		}

		// Token: 0x06009546 RID: 38214 RVA: 0x000E1658 File Offset: 0x000DF858
		public void SetGlobalPlayRate(float NewPlayRate)
		{
			USequencerManager.__SetGlobalPlayRate_Internal(base.NativePtr, NewPlayRate);
		}

		// Token: 0x06009547 RID: 38215 RVA: 0x000E1666 File Offset: 0x000DF866
		public static void LoadSequenceAssetAsync(UObject Context, in FSoftObjectPath Path, in FSequenceLoadedEvent OnLoad)
		{
			IntPtr context = (Context != null) ? Context.NativePtr : IntPtr.Zero;
			IntPtr nativePtr = (Path ?? new FSoftObjectPath()).NativePtr;
			FSequenceLoadedEvent fsequenceLoadedEvent = OnLoad;
			USequencerManager.__LoadSequenceAssetAsync_Internal(context, nativePtr, (fsequenceLoadedEvent != null) ? fsequenceLoadedEvent.NativePtr : ((IntPtr)0));
		}

		// Token: 0x06009548 RID: 38216 RVA: 0x000E169C File Offset: 0x000DF89C
		public float GetGlobalPlayRate()
		{
			return USequencerManager.__GetGlobalPlayRate_Internal(base.NativePtr);
		}

		// Token: 0x06009549 RID: 38217 RVA: 0x000E16A9 File Offset: 0x000DF8A9
		public static USequencePlayContext GetBatchPlayContext(UObject Context)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<USequencePlayContext>(USequencerManager.__GetBatchPlayContext_Internal((Context != null) ? Context.NativePtr : IntPtr.Zero));
		}

		// Token: 0x0600954A RID: 38218 RVA: 0x000E16C5 File Offset: 0x000DF8C5
		public void ClearInvalidBind(ALevelSequenceActor SeqActor)
		{
			USequencerManager.__ClearInvalidBind_Internal(base.NativePtr, (SeqActor != null) ? SeqActor.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600954B RID: 38219 RVA: 0x000E16E4 File Offset: 0x000DF8E4
		public static ALevelSequenceActor BatchPlaySequenceOnActors(UObject Context, in FSoftObjectPath SequencePath, [Nullable(new byte[]
		{
			2,
			1
		})] in TArray<AUIBaseActor> BatchRoots, in FMovieSceneSequencePlaybackSettings PlaySetting)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ALevelSequenceActor>(USequencerManager.__BatchPlaySequenceOnActors_Internal((Context != null) ? Context.NativePtr : IntPtr.Zero, (SequencePath ?? new FSoftObjectPath()).NativePtr, (BatchRoots ?? new TArray<AUIBaseActor>()).NativePtr, (PlaySetting ?? new FMovieSceneSequencePlaybackSettings()).NativePtr));
		}

		// Token: 0x0600954C RID: 38220
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetGlobalPlayRate_Internal(IntPtr @this, float NewPlayRate);

		// Token: 0x0600954D RID: 38221
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __LoadSequenceAssetAsync_Internal(IntPtr Context, IntPtr Path, IntPtr OnLoad);

		// Token: 0x0600954E RID: 38222
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetGlobalPlayRate_Internal(IntPtr @this);

		// Token: 0x0600954F RID: 38223
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetBatchPlayContext_Internal(IntPtr Context);

		// Token: 0x06009550 RID: 38224
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClearInvalidBind_Internal(IntPtr @this, IntPtr SeqActor);

		// Token: 0x06009551 RID: 38225
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __BatchPlaySequenceOnActors_Internal(IntPtr Context, IntPtr SequencePath, IntPtr BatchRoots, IntPtr PlaySetting);

		// Token: 0x06009552 RID: 38226 RVA: 0x000E173B File Offset: 0x000DF93B
		static USequencerManager()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.SequencerManager");
		}

		// Token: 0x06009553 RID: 38227 RVA: 0x000E1749 File Offset: 0x000DF949
		protected USequencerManager(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040040ED RID: 16621
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.SequencerManager";

		// Token: 0x040040EE RID: 16622
		private static IntPtr _ClassPtr;

		// Token: 0x040040EF RID: 16623
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040040F0 RID: 16624
		internal static int __PropertyOffset_BatchPlayContexts;

		// Token: 0x040040F1 RID: 16625
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<USequencePlayContext> _BatchPlayContexts;

		// Token: 0x040040F2 RID: 16626
		internal static int __PropertyOffset_TransientSyncParamContext;
	}
}
