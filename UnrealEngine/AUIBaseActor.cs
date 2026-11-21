using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020006EA RID: 1770
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.UIBaseActor")]
	[UnrealStructLayout(1664, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1664)]
	public abstract class AUIBaseActor : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06009620 RID: 38432 RVA: 0x000E27C8 File Offset: 0x000E09C8
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AUIBaseActor._ClassPtr;
		}

		// Token: 0x17001BDA RID: 7130
		// (get) Token: 0x06009621 RID: 38433 RVA: 0x000E27D4 File Offset: 0x000E09D4
		// (set) Token: 0x06009622 RID: 38434 RVA: 0x000E280D File Offset: 0x000E0A0D
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

		// Token: 0x17001BDB RID: 7131
		// (get) Token: 0x06009623 RID: 38435 RVA: 0x000E281C File Offset: 0x000E0A1C
		// (set) Token: 0x06009624 RID: 38436 RVA: 0x000E2855 File Offset: 0x000E0A55
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

		// Token: 0x17001BDC RID: 7132
		// (get) Token: 0x06009625 RID: 38437 RVA: 0x000E2878 File Offset: 0x000E0A78
		// (set) Token: 0x06009626 RID: 38438 RVA: 0x000E28B1 File Offset: 0x000E0AB1
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

		// Token: 0x17001BDD RID: 7133
		// (get) Token: 0x06009627 RID: 38439 RVA: 0x000E28D2 File Offset: 0x000E0AD2
		// (set) Token: 0x06009628 RID: 38440 RVA: 0x000E28E6 File Offset: 0x000E0AE6
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

		// Token: 0x17001BDE RID: 7134
		// (get) Token: 0x06009629 RID: 38441 RVA: 0x000E28FC File Offset: 0x000E0AFC
		// (set) Token: 0x0600962A RID: 38442 RVA: 0x000E2935 File Offset: 0x000E0B35
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

		// Token: 0x17001BDF RID: 7135
		// (get) Token: 0x0600962B RID: 38443 RVA: 0x000E2944 File Offset: 0x000E0B44
		// (set) Token: 0x0600962C RID: 38444 RVA: 0x000E297D File Offset: 0x000E0B7D
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

		// Token: 0x0600962D RID: 38445 RVA: 0x000E298C File Offset: 0x000E0B8C
		public unsafe void StopSequenceByKey(string Name)
		{
			FString fstring = FString.AllocTemp(Name);
			AUIBaseActor.__StopSequenceByKey_Internal(base.NativePtr, fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x0600962E RID: 38446 RVA: 0x000E29B8 File Offset: 0x000E0BB8
		public unsafe void SequencePlayReverseByKey(string Name)
		{
			FString fstring = FString.AllocTemp(Name);
			AUIBaseActor.__SequencePlayReverseByKey_Internal(base.NativePtr, fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x0600962F RID: 38447 RVA: 0x000E29E4 File Offset: 0x000E0BE4
		public unsafe void SequenceJumpToSecondByKey(string Name, [Nullable(2)] in FFrameTime Time)
		{
			FString fstring = FString.AllocTemp(Name);
			AUIBaseActor.__SequenceJumpToSecondByKey_Internal(base.NativePtr, fstring, (Time ?? new FFrameTime()).NativePtr);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06009630 RID: 38448 RVA: 0x000E2A1E File Offset: 0x000E0C1E
		[NullableContext(2)]
		public void SequenceJumpToEnd(in FSoftObjectPath SoftPath)
		{
			AUIBaseActor.__SequenceJumpToEnd_Internal(base.NativePtr, (SoftPath ?? new FSoftObjectPath()).NativePtr);
		}

		// Token: 0x06009631 RID: 38449 RVA: 0x000E2A3C File Offset: 0x000E0C3C
		public unsafe void ResumeSequenceByKey(string Name)
		{
			FString fstring = FString.AllocTemp(Name);
			AUIBaseActor.__ResumeSequenceByKey_Internal(base.NativePtr, fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06009632 RID: 38450 RVA: 0x000E2A68 File Offset: 0x000E0C68
		public unsafe void ReplaySequenceByKey(string Name)
		{
			FString fstring = FString.AllocTemp(Name);
			AUIBaseActor.__ReplaySequenceByKey_Internal(base.NativePtr, fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06009633 RID: 38451 RVA: 0x000E2A94 File Offset: 0x000E0C94
		public unsafe void PlayLevelSequenceByKey(string Name)
		{
			FString fstring = FString.AllocTemp(Name);
			AUIBaseActor.__PlayLevelSequenceByKey_Internal(base.NativePtr, fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06009634 RID: 38452 RVA: 0x000E2AC0 File Offset: 0x000E0CC0
		public unsafe void PauseSequenceByKey(string Name)
		{
			FString fstring = FString.AllocTemp(Name);
			AUIBaseActor.__PauseSequenceByKey_Internal(base.NativePtr, fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06009635 RID: 38453 RVA: 0x000E2AEC File Offset: 0x000E0CEC
		public unsafe void LoadSequenceAssetAsyncByKey(string Key, [Nullable(2)] in FSequenceLoadedEvent OnLoaded)
		{
			FString fstring = FString.AllocTemp(Key);
			IntPtr nativePtr = base.NativePtr;
			FSequenceLoadedEvent fsequenceLoadedEvent = OnLoaded;
			AUIBaseActor.__LoadSequenceAssetAsyncByKey_Internal(nativePtr, fstring, (fsequenceLoadedEvent != null) ? fsequenceLoadedEvent.NativePtr : ((IntPtr)0));
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06009636 RID: 38454 RVA: 0x000E2B25 File Offset: 0x000E0D25
		[NullableContext(2)]
		public UUIItem GetUIItem()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UUIItem>(AUIBaseActor.__GetUIItem_Internal(base.NativePtr));
		}

		// Token: 0x06009637 RID: 38455 RVA: 0x000E2B38 File Offset: 0x000E0D38
		[return: Nullable(2)]
		public unsafe ALevelSequenceActor GetSequencePlayerByKey(string Name)
		{
			FString fstring = FString.AllocTemp(Name);
			ALevelSequenceActor orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<ALevelSequenceActor>(AUIBaseActor.__GetSequencePlayerByKey_Internal(base.NativePtr, fstring));
			FString.NativeDestruct(&fstring, 1);
			return orCreateUObjectByNativePointer;
		}

		// Token: 0x06009638 RID: 38456 RVA: 0x000E2B68 File Offset: 0x000E0D68
		[return: Nullable(2)]
		public unsafe USequencePlayContext GetSequencePlayContextOfKey(string Key)
		{
			FString fstring = FString.AllocTemp(Key);
			USequencePlayContext orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USequencePlayContext>(AUIBaseActor.__GetSequencePlayContextOfKey_Internal(base.NativePtr, fstring));
			FString.NativeDestruct(&fstring, 1);
			return orCreateUObjectByNativePointer;
		}

		// Token: 0x06009639 RID: 38457 RVA: 0x000E2B98 File Offset: 0x000E0D98
		public unsafe FSequenceInfo GetSeqInfoByKey(string Key)
		{
			FString fstring = FString.AllocTemp(Key);
			FSequenceInfo result = new FSequenceInfo(AUIBaseActor.__GetSeqInfoByKey_Internal(base.NativePtr, fstring), null);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x0600963A RID: 38458 RVA: 0x000E2BC8 File Offset: 0x000E0DC8
		public unsafe void ExecuteSequencePlayEvent(string sequenceName, string eventName)
		{
			FString fstring = FString.AllocTemp(sequenceName);
			FString fstring2 = FString.AllocTemp(eventName);
			AUIBaseActor.__ExecuteSequencePlayEvent_Internal(base.NativePtr, fstring, fstring2);
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
		}

		// Token: 0x0600963B RID: 38459 RVA: 0x000E2C04 File Offset: 0x000E0E04
		public void ClearAllSequence()
		{
			AUIBaseActor.__ClearAllSequence_Internal(base.NativePtr);
		}

		// Token: 0x0600963C RID: 38460 RVA: 0x000E2C11 File Offset: 0x000E0E11
		public void CleanIdleAnimSeqActorCache()
		{
			AUIBaseActor.__CleanIdleAnimSeqActorCache_Internal(base.NativePtr);
		}

		// Token: 0x0600963D RID: 38461 RVA: 0x000E2C1E File Offset: 0x000E0E1E
		public void ActivateAllChildrenInteraction()
		{
			AUIBaseActor.__ActivateAllChildrenInteraction_Internal(base.NativePtr);
		}

		// Token: 0x0600963E RID: 38462
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __StopSequenceByKey_Internal(IntPtr @this, in FString Name);

		// Token: 0x0600963F RID: 38463
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SequencePlayReverseByKey_Internal(IntPtr @this, in FString Name);

		// Token: 0x06009640 RID: 38464
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SequenceJumpToSecondByKey_Internal(IntPtr @this, in FString Name, IntPtr Time);

		// Token: 0x06009641 RID: 38465
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SequenceJumpToEnd_Internal(IntPtr @this, IntPtr SoftPath);

		// Token: 0x06009642 RID: 38466
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ResumeSequenceByKey_Internal(IntPtr @this, in FString Name);

		// Token: 0x06009643 RID: 38467
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ReplaySequenceByKey_Internal(IntPtr @this, in FString Name);

		// Token: 0x06009644 RID: 38468
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __PlayLevelSequenceByKey_Internal(IntPtr @this, in FString Name);

		// Token: 0x06009645 RID: 38469
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __PauseSequenceByKey_Internal(IntPtr @this, in FString Name);

		// Token: 0x06009646 RID: 38470
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __LoadSequenceAssetAsyncByKey_Internal(IntPtr @this, in FString Key, IntPtr OnLoaded);

		// Token: 0x06009647 RID: 38471
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetUIItem_Internal(IntPtr @this);

		// Token: 0x06009648 RID: 38472
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetSequencePlayerByKey_Internal(IntPtr @this, in FString Name);

		// Token: 0x06009649 RID: 38473
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetSequencePlayContextOfKey_Internal(IntPtr @this, in FString Key);

		// Token: 0x0600964A RID: 38474
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetSeqInfoByKey_Internal(IntPtr @this, in FString Key);

		// Token: 0x0600964B RID: 38475
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ExecuteSequencePlayEvent_Internal(IntPtr @this, in FString sequenceName, in FString eventName);

		// Token: 0x0600964C RID: 38476
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClearAllSequence_Internal(IntPtr @this);

		// Token: 0x0600964D RID: 38477
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __CleanIdleAnimSeqActorCache_Internal(IntPtr @this);

		// Token: 0x0600964E RID: 38478
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ActivateAllChildrenInteraction_Internal(IntPtr @this);

		// Token: 0x0600964F RID: 38479 RVA: 0x000E2C2B File Offset: 0x000E0E2B
		static AUIBaseActor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UIBaseActor");
		}

		// Token: 0x06009650 RID: 38480 RVA: 0x000E2C3C File Offset: 0x000E0E3C
		protected AUIBaseActor() : this(BuiltinUtils.AllocNativeUObject(AUIBaseActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06009651 RID: 38481 RVA: 0x000E2C64 File Offset: 0x000E0E64
		protected AUIBaseActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04004152 RID: 16722
		public new const string __ObjectPath = "/Script/LGUI.UIBaseActor";

		// Token: 0x04004153 RID: 16723
		private static IntPtr _ClassPtr;

		// Token: 0x04004154 RID: 16724
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04004155 RID: 16725
		internal static int __PropertyOffset_CurBindingSeqActors;

		// Token: 0x04004156 RID: 16726
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TMap<FSoftObjectPath, ALevelSequenceActor> _CurBindingSeqActors;

		// Token: 0x04004157 RID: 16727
		internal static int __PropertyOffset_OnSequencePlayEvent;

		// Token: 0x04004158 RID: 16728
		[Nullable(2)]
		private FOnSequencePlayEvent _OnSequencePlayEvent;

		// Token: 0x04004159 RID: 16729
		internal static int __PropertyOffset_OnPreDestroyed;

		// Token: 0x0400415A RID: 16730
		[Nullable(2)]
		private FUIBaseActorPreDestroyedSignature _OnPreDestroyed;

		// Token: 0x0400415B RID: 16731
		internal static int __PropertyOffset_LGUIGuid;

		// Token: 0x0400415C RID: 16732
		internal static int __PropertyOffset_AllSequencePlayContexts;

		// Token: 0x0400415D RID: 16733
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TMap<FSoftObjectPath, USequencePlayContext> _AllSequencePlayContexts;

		// Token: 0x0400415E RID: 16734
		internal static int __PropertyOffset_PlayContextsByKey;

		// Token: 0x0400415F RID: 16735
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TMap<string, USequencePlayContext> _PlayContextsByKey;
	}
}
