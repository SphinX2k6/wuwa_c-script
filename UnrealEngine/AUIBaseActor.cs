using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200212C RID: 8492
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.UIBaseActor")]
	[UnrealStructLayout(1664, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1664)]
	public abstract class AUIBaseActor : AActor, IUnrealUObject, IUnrealObject, ISequenceCustomGuidGetterInterface, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x0601FF29 RID: 130857 RVA: 0x002F82FF File Offset: 0x002F64FF
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AUIBaseActor._ClassPtr;
		}

		// Token: 0x0601FF2A RID: 130858 RVA: 0x002F830B File Offset: 0x002F650B
		int ISequenceCustomGuidGetterInterface.InterfaceOffset()
		{
			return AUIBaseActor.__InterfaceOffset_ISequenceCustomGuidGetterInterface;
		}

		// Token: 0x17007D90 RID: 32144
		// (get) Token: 0x0601FF2B RID: 130859 RVA: 0x002F8314 File Offset: 0x002F6514
		// (set) Token: 0x0601FF2C RID: 130860 RVA: 0x002F834D File Offset: 0x002F654D
		public TMap<FSoftObjectPath, ALevelSequenceActor> CurBindingSeqActors
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FSoftObjectPath, ALevelSequenceActor> result;
				if ((result = this._CurBindingSeqActors) == null)
				{
					result = (this._CurBindingSeqActors = new TMap<FSoftObjectPath, ALevelSequenceActor>(base.NativePtr + (IntPtr)AUIBaseActor.__PropertyOffset_CurBindingSeqActors, this));
				}
				return result;
			}
			set
			{
				this.CurBindingSeqActors.CopyAssign(value);
			}
		}

		// Token: 0x17007D91 RID: 32145
		// (get) Token: 0x0601FF2D RID: 130861 RVA: 0x002F835C File Offset: 0x002F655C
		// (set) Token: 0x0601FF2E RID: 130862 RVA: 0x002F8395 File Offset: 0x002F6595
		public FOnSequencePlayEvent OnSequencePlayEvent
		{
			get
			{
				base.FastCheckIsValid();
				FOnSequencePlayEvent result;
				if ((result = this._OnSequencePlayEvent) == null)
				{
					result = (this._OnSequencePlayEvent = new FOnSequencePlayEvent(base.NativePtr + (IntPtr)AUIBaseActor.__PropertyOffset_OnSequencePlayEvent, this));
				}
				return result;
			}
			set
			{
				FScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)AUIBaseActor.__PropertyOffset_OnSequencePlayEvent, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17007D92 RID: 32146
		// (get) Token: 0x0601FF2F RID: 130863 RVA: 0x002F83B8 File Offset: 0x002F65B8
		// (set) Token: 0x0601FF30 RID: 130864 RVA: 0x002F83F1 File Offset: 0x002F65F1
		public FUIBaseActorPreDestroyedSignature OnPreDestroyed
		{
			get
			{
				base.FastCheckIsValid();
				FUIBaseActorPreDestroyedSignature result;
				if ((result = this._OnPreDestroyed) == null)
				{
					result = (this._OnPreDestroyed = new FUIBaseActorPreDestroyedSignature(base.NativePtr + (IntPtr)AUIBaseActor.__PropertyOffset_OnPreDestroyed, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)AUIBaseActor.__PropertyOffset_OnPreDestroyed, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17007D93 RID: 32147
		// (get) Token: 0x0601FF31 RID: 130865 RVA: 0x002F8412 File Offset: 0x002F6612
		// (set) Token: 0x0601FF32 RID: 130866 RVA: 0x002F8426 File Offset: 0x002F6626
		public unsafe FGuid LGUIGuid
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AUIBaseActor.__PropertyOffset_LGUIGuid);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AUIBaseActor.__PropertyOffset_LGUIGuid) = value;
			}
		}

		// Token: 0x17007D94 RID: 32148
		// (get) Token: 0x0601FF33 RID: 130867 RVA: 0x002F843C File Offset: 0x002F663C
		// (set) Token: 0x0601FF34 RID: 130868 RVA: 0x002F8475 File Offset: 0x002F6675
		public TMap<FSoftObjectPath, USequencePlayContext> AllSequencePlayContexts
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FSoftObjectPath, USequencePlayContext> result;
				if ((result = this._AllSequencePlayContexts) == null)
				{
					result = (this._AllSequencePlayContexts = new TMap<FSoftObjectPath, USequencePlayContext>(base.NativePtr + (IntPtr)AUIBaseActor.__PropertyOffset_AllSequencePlayContexts, this));
				}
				return result;
			}
			set
			{
				this.AllSequencePlayContexts.CopyAssign(value);
			}
		}

		// Token: 0x17007D95 RID: 32149
		// (get) Token: 0x0601FF35 RID: 130869 RVA: 0x002F8484 File Offset: 0x002F6684
		// (set) Token: 0x0601FF36 RID: 130870 RVA: 0x002F84BD File Offset: 0x002F66BD
		public TMap<string, USequencePlayContext> PlayContextsByKey
		{
			get
			{
				base.FastCheckIsValid();
				TMap<string, USequencePlayContext> result;
				if ((result = this._PlayContextsByKey) == null)
				{
					result = (this._PlayContextsByKey = new TMap<string, USequencePlayContext>(base.NativePtr + (IntPtr)AUIBaseActor.__PropertyOffset_PlayContextsByKey, this));
				}
				return result;
			}
			set
			{
				this.PlayContextsByKey.CopyAssign(value);
			}
		}

		// Token: 0x0601FF37 RID: 130871 RVA: 0x002F84CC File Offset: 0x002F66CC
		public unsafe void StopSequenceByKey(string Name)
		{
			FString fstring = FString.AllocTemp(Name);
			AUIBaseActor.__StopSequenceByKey_Internal(base.NativePtr, fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x0601FF38 RID: 130872 RVA: 0x002F84F8 File Offset: 0x002F66F8
		public unsafe void SequencePlayReverseByKey(string Name)
		{
			FString fstring = FString.AllocTemp(Name);
			AUIBaseActor.__SequencePlayReverseByKey_Internal(base.NativePtr, fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x0601FF39 RID: 130873 RVA: 0x002F8524 File Offset: 0x002F6724
		public unsafe void SequenceJumpToSecondByKey(string Name, [Nullable(2)] in FFrameTime Time)
		{
			FString fstring = FString.AllocTemp(Name);
			AUIBaseActor.__SequenceJumpToSecondByKey_Internal(base.NativePtr, fstring, (Time ?? new FFrameTime()).NativePtr);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x0601FF3A RID: 130874 RVA: 0x002F855E File Offset: 0x002F675E
		[NullableContext(2)]
		public void SequenceJumpToEnd(in FSoftObjectPath SoftPath)
		{
			AUIBaseActor.__SequenceJumpToEnd_Internal(base.NativePtr, (SoftPath ?? new FSoftObjectPath()).NativePtr);
		}

		// Token: 0x0601FF3B RID: 130875 RVA: 0x002F857C File Offset: 0x002F677C
		public unsafe void ResumeSequenceByKey(string Name)
		{
			FString fstring = FString.AllocTemp(Name);
			AUIBaseActor.__ResumeSequenceByKey_Internal(base.NativePtr, fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x0601FF3C RID: 130876 RVA: 0x002F85A8 File Offset: 0x002F67A8
		public unsafe void ReplaySequenceByKey(string Name)
		{
			FString fstring = FString.AllocTemp(Name);
			AUIBaseActor.__ReplaySequenceByKey_Internal(base.NativePtr, fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x0601FF3D RID: 130877 RVA: 0x002F85D4 File Offset: 0x002F67D4
		public unsafe void PlayLevelSequenceByKey(string Name)
		{
			FString fstring = FString.AllocTemp(Name);
			AUIBaseActor.__PlayLevelSequenceByKey_Internal(base.NativePtr, fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x0601FF3E RID: 130878 RVA: 0x002F8600 File Offset: 0x002F6800
		public unsafe void PauseSequenceByKey(string Name)
		{
			FString fstring = FString.AllocTemp(Name);
			AUIBaseActor.__PauseSequenceByKey_Internal(base.NativePtr, fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x0601FF3F RID: 130879 RVA: 0x002F862C File Offset: 0x002F682C
		public unsafe void LoadSequenceAssetAsyncByKey(string Key, [Nullable(2)] in FSequenceLoadedEvent OnLoaded)
		{
			FString fstring = FString.AllocTemp(Key);
			IntPtr nativePtr = base.NativePtr;
			FSequenceLoadedEvent fsequenceLoadedEvent = OnLoaded;
			AUIBaseActor.__LoadSequenceAssetAsyncByKey_Internal(nativePtr, fstring, (fsequenceLoadedEvent != null) ? fsequenceLoadedEvent.NativePtr : ((IntPtr)0));
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x0601FF40 RID: 130880 RVA: 0x002F8665 File Offset: 0x002F6865
		[NullableContext(2)]
		public UUIItem GetUIItem()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UUIItem>(AUIBaseActor.__GetUIItem_Internal(base.NativePtr));
		}

		// Token: 0x0601FF41 RID: 130881 RVA: 0x002F8678 File Offset: 0x002F6878
		[return: Nullable(2)]
		public unsafe ALevelSequenceActor GetSequencePlayerByKey(string Name)
		{
			FString fstring = FString.AllocTemp(Name);
			ALevelSequenceActor orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<ALevelSequenceActor>(AUIBaseActor.__GetSequencePlayerByKey_Internal(base.NativePtr, fstring));
			FString.NativeDestruct(&fstring, 1);
			return orCreateUObjectByNativePointer;
		}

		// Token: 0x0601FF42 RID: 130882 RVA: 0x002F86A8 File Offset: 0x002F68A8
		[return: Nullable(2)]
		public unsafe USequencePlayContext GetSequencePlayContextOfKey(string Key)
		{
			FString fstring = FString.AllocTemp(Key);
			USequencePlayContext orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USequencePlayContext>(AUIBaseActor.__GetSequencePlayContextOfKey_Internal(base.NativePtr, fstring));
			FString.NativeDestruct(&fstring, 1);
			return orCreateUObjectByNativePointer;
		}

		// Token: 0x0601FF43 RID: 130883 RVA: 0x002F86D8 File Offset: 0x002F68D8
		public unsafe FSequenceInfo GetSeqInfoByKey(string Key)
		{
			FString fstring = FString.AllocTemp(Key);
			FSequenceInfo result = new FSequenceInfo(AUIBaseActor.__GetSeqInfoByKey_Internal(base.NativePtr, fstring), null);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x0601FF44 RID: 130884 RVA: 0x002F8708 File Offset: 0x002F6908
		public unsafe ESequenceLoadState GetLoadStateOfSequenceByKey(string Key)
		{
			FString fstring = FString.AllocTemp(Key);
			ESequenceLoadState result = AUIBaseActor.__GetLoadStateOfSequenceByKey_Internal(base.NativePtr, fstring);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x0601FF45 RID: 130885 RVA: 0x002F8734 File Offset: 0x002F6934
		public unsafe void ExecuteSequencePlayEvent(string sequenceName, string eventName)
		{
			FString fstring = FString.AllocTemp(sequenceName);
			FString fstring2 = FString.AllocTemp(eventName);
			AUIBaseActor.__ExecuteSequencePlayEvent_Internal(base.NativePtr, fstring, fstring2);
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
		}

		// Token: 0x0601FF46 RID: 130886 RVA: 0x002F8770 File Offset: 0x002F6970
		public void ClearAllSequence()
		{
			AUIBaseActor.__ClearAllSequence_Internal(base.NativePtr);
		}

		// Token: 0x0601FF47 RID: 130887 RVA: 0x002F877D File Offset: 0x002F697D
		public void CleanIdleAnimSeqActorCache()
		{
			AUIBaseActor.__CleanIdleAnimSeqActorCache_Internal(base.NativePtr);
		}

		// Token: 0x0601FF48 RID: 130888 RVA: 0x002F878A File Offset: 0x002F698A
		public void ActivateAllChildrenInteraction()
		{
			AUIBaseActor.__ActivateAllChildrenInteraction_Internal(base.NativePtr);
		}

		// Token: 0x0601FF49 RID: 130889
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __StopSequenceByKey_Internal(IntPtr @this, in FString Name);

		// Token: 0x0601FF4A RID: 130890
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SequencePlayReverseByKey_Internal(IntPtr @this, in FString Name);

		// Token: 0x0601FF4B RID: 130891
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SequenceJumpToSecondByKey_Internal(IntPtr @this, in FString Name, IntPtr Time);

		// Token: 0x0601FF4C RID: 130892
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SequenceJumpToEnd_Internal(IntPtr @this, IntPtr SoftPath);

		// Token: 0x0601FF4D RID: 130893
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ResumeSequenceByKey_Internal(IntPtr @this, in FString Name);

		// Token: 0x0601FF4E RID: 130894
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ReplaySequenceByKey_Internal(IntPtr @this, in FString Name);

		// Token: 0x0601FF4F RID: 130895
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __PlayLevelSequenceByKey_Internal(IntPtr @this, in FString Name);

		// Token: 0x0601FF50 RID: 130896
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __PauseSequenceByKey_Internal(IntPtr @this, in FString Name);

		// Token: 0x0601FF51 RID: 130897
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __LoadSequenceAssetAsyncByKey_Internal(IntPtr @this, in FString Key, IntPtr OnLoaded);

		// Token: 0x0601FF52 RID: 130898
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetUIItem_Internal(IntPtr @this);

		// Token: 0x0601FF53 RID: 130899
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetSequencePlayerByKey_Internal(IntPtr @this, in FString Name);

		// Token: 0x0601FF54 RID: 130900
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetSequencePlayContextOfKey_Internal(IntPtr @this, in FString Key);

		// Token: 0x0601FF55 RID: 130901
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetSeqInfoByKey_Internal(IntPtr @this, in FString Key);

		// Token: 0x0601FF56 RID: 130902
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern ESequenceLoadState __GetLoadStateOfSequenceByKey_Internal(IntPtr @this, in FString Key);

		// Token: 0x0601FF57 RID: 130903
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ExecuteSequencePlayEvent_Internal(IntPtr @this, in FString sequenceName, in FString eventName);

		// Token: 0x0601FF58 RID: 130904
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClearAllSequence_Internal(IntPtr @this);

		// Token: 0x0601FF59 RID: 130905
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __CleanIdleAnimSeqActorCache_Internal(IntPtr @this);

		// Token: 0x0601FF5A RID: 130906
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ActivateAllChildrenInteraction_Internal(IntPtr @this);

		// Token: 0x0601FF5B RID: 130907 RVA: 0x002F8797 File Offset: 0x002F6997
		static AUIBaseActor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UIBaseActor");
		}

		// Token: 0x0601FF5C RID: 130908 RVA: 0x002F87A8 File Offset: 0x002F69A8
		protected AUIBaseActor() : this(BuiltinUtils.AllocNativeUObject(AUIBaseActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601FF5D RID: 130909 RVA: 0x002F87D0 File Offset: 0x002F69D0
		protected AUIBaseActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011352 RID: 70482
		internal static int __InterfaceOffset_ISequenceCustomGuidGetterInterface;

		// Token: 0x04011353 RID: 70483
		public new const string __ObjectPath = "/Script/LGUI.UIBaseActor";

		// Token: 0x04011354 RID: 70484
		private static IntPtr _ClassPtr;

		// Token: 0x04011355 RID: 70485
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011356 RID: 70486
		internal static int __PropertyOffset_CurBindingSeqActors;

		// Token: 0x04011357 RID: 70487
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TMap<FSoftObjectPath, ALevelSequenceActor> _CurBindingSeqActors;

		// Token: 0x04011358 RID: 70488
		internal static int __PropertyOffset_OnSequencePlayEvent;

		// Token: 0x04011359 RID: 70489
		[Nullable(2)]
		private FOnSequencePlayEvent _OnSequencePlayEvent;

		// Token: 0x0401135A RID: 70490
		internal static int __PropertyOffset_OnPreDestroyed;

		// Token: 0x0401135B RID: 70491
		[Nullable(2)]
		private FUIBaseActorPreDestroyedSignature _OnPreDestroyed;

		// Token: 0x0401135C RID: 70492
		internal static int __PropertyOffset_LGUIGuid;

		// Token: 0x0401135D RID: 70493
		internal static int __PropertyOffset_AllSequencePlayContexts;

		// Token: 0x0401135E RID: 70494
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TMap<FSoftObjectPath, USequencePlayContext> _AllSequencePlayContexts;

		// Token: 0x0401135F RID: 70495
		internal static int __PropertyOffset_PlayContextsByKey;

		// Token: 0x04011360 RID: 70496
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TMap<string, USequencePlayContext> _PlayContextsByKey;
	}
}
