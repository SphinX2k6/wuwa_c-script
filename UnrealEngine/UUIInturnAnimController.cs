using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200217A RID: 8570
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.UIInturnAnimController")]
	[UnrealStructLayout(336, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 336)]
	public class UUIInturnAnimController : UActorComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06020621 RID: 132641 RVA: 0x00300E3D File Offset: 0x002FF03D
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUIInturnAnimController._ClassPtr;
		}

		// Token: 0x06020622 RID: 132642 RVA: 0x00300E4C File Offset: 0x002FF04C
		public UUIInturnAnimController() : this(BuiltinUtils.AllocNativeUObject(UUIInturnAnimController.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06020623 RID: 132643 RVA: 0x00300E74 File Offset: 0x002FF074
		public UUIInturnAnimController(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UUIInturnAnimController.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007EE4 RID: 32484
		// (get) Token: 0x06020624 RID: 132644 RVA: 0x00300EA8 File Offset: 0x002FF0A8
		// (set) Token: 0x06020625 RID: 132645 RVA: 0x00300EE1 File Offset: 0x002FF0E1
		public FInturnSequenceEvent OnFinish
		{
			get
			{
				base.FastCheckIsValid();
				FInturnSequenceEvent result;
				if ((result = this._OnFinish) == null)
				{
					result = (this._OnFinish = new FInturnSequenceEvent(base.NativePtr + (IntPtr)UUIInturnAnimController.__PropertyOffset_OnFinish, this));
				}
				return result;
			}
			set
			{
				FScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UUIInturnAnimController.__PropertyOffset_OnFinish, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17007EE5 RID: 32485
		// (get) Token: 0x06020626 RID: 132646 RVA: 0x00300F02 File Offset: 0x002FF102
		// (set) Token: 0x06020627 RID: 132647 RVA: 0x00300F16 File Offset: 0x002FF116
		public unsafe string AnimName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UUIInturnAnimController.__PropertyOffset_AnimName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UUIInturnAnimController.__PropertyOffset_AnimName)), value);
			}
		}

		// Token: 0x17007EE6 RID: 32486
		// (get) Token: 0x06020628 RID: 132648 RVA: 0x00300F2B File Offset: 0x002FF12B
		// (set) Token: 0x06020629 RID: 132649 RVA: 0x00300F3B File Offset: 0x002FF13B
		public unsafe float StartTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIInturnAnimController.__PropertyOffset_StartTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIInturnAnimController.__PropertyOffset_StartTime) = value;
			}
		}

		// Token: 0x17007EE7 RID: 32487
		// (get) Token: 0x0602062A RID: 132650 RVA: 0x00300F4C File Offset: 0x002FF14C
		// (set) Token: 0x0602062B RID: 132651 RVA: 0x00300F5C File Offset: 0x002FF15C
		public unsafe bool bPlayInSameTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIInturnAnimController.__PropertyOffset_bPlayInSameTime) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIInturnAnimController.__PropertyOffset_bPlayInSameTime) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007EE8 RID: 32488
		// (get) Token: 0x0602062C RID: 132652 RVA: 0x00300F6D File Offset: 0x002FF16D
		// (set) Token: 0x0602062D RID: 132653 RVA: 0x00300F7D File Offset: 0x002FF17D
		public unsafe float Interval
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIInturnAnimController.__PropertyOffset_Interval);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIInturnAnimController.__PropertyOffset_Interval) = value;
			}
		}

		// Token: 0x17007EE9 RID: 32489
		// (get) Token: 0x0602062E RID: 132654 RVA: 0x00300F8E File Offset: 0x002FF18E
		// (set) Token: 0x0602062F RID: 132655 RVA: 0x00300F9E File Offset: 0x002FF19E
		public unsafe float CustomAnimDuration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIInturnAnimController.__PropertyOffset_CustomAnimDuration);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIInturnAnimController.__PropertyOffset_CustomAnimDuration) = value;
			}
		}

		// Token: 0x17007EEA RID: 32490
		// (get) Token: 0x06020630 RID: 132656 RVA: 0x00300FAF File Offset: 0x002FF1AF
		// (set) Token: 0x06020631 RID: 132657 RVA: 0x00300FBF File Offset: 0x002FF1BF
		public unsafe bool bItemDefaultActive
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIInturnAnimController.__PropertyOffset_bItemDefaultActive) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIInturnAnimController.__PropertyOffset_bItemDefaultActive) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007EEB RID: 32491
		// (get) Token: 0x06020632 RID: 132658 RVA: 0x00300FD0 File Offset: 0x002FF1D0
		// (set) Token: 0x06020633 RID: 132659 RVA: 0x00300FE0 File Offset: 0x002FF1E0
		public unsafe bool bItemDefaultAlphaZero
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIInturnAnimController.__PropertyOffset_bItemDefaultAlphaZero) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIInturnAnimController.__PropertyOffset_bItemDefaultAlphaZero) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007EEC RID: 32492
		// (get) Token: 0x06020634 RID: 132660 RVA: 0x00300FF1 File Offset: 0x002FF1F1
		// (set) Token: 0x06020635 RID: 132661 RVA: 0x00301001 File Offset: 0x002FF201
		public unsafe int PlayFromIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIInturnAnimController.__PropertyOffset_PlayFromIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIInturnAnimController.__PropertyOffset_PlayFromIndex) = value;
			}
		}

		// Token: 0x06020636 RID: 132662 RVA: 0x00301012 File Offset: 0x002FF212
		public void Stop()
		{
			UUIInturnAnimController.__Stop_Internal(base.NativePtr);
		}

		// Token: 0x06020637 RID: 132663 RVA: 0x0030101F File Offset: 0x002FF21F
		public void SetItemDefaultAlphaZero(bool IsItemDefaultAlphaZero)
		{
			UUIInturnAnimController.__SetItemDefaultAlphaZero_Internal(base.NativePtr, IsItemDefaultAlphaZero);
		}

		// Token: 0x06020638 RID: 132664 RVA: 0x00301030 File Offset: 0x002FF230
		public unsafe void PlayWithItems([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<UUIItem> SpecChildren, string NewAnimName = "")
		{
			FString fstring = FString.AllocTemp(NewAnimName);
			UUIInturnAnimController.__PlayWithItems_Internal(base.NativePtr, (SpecChildren ?? new TArray<UUIItem>()).NativePtr, fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06020639 RID: 132665 RVA: 0x0030106C File Offset: 0x002FF26C
		public unsafe void PlayWithActors([Nullable(new byte[]
		{
			2,
			0,
			1
		})] in TArray<TWeakObjectPtr<AUIBaseActor>> SpecChildren, string NewAnimName)
		{
			FString fstring = FString.AllocTemp(NewAnimName);
			UUIInturnAnimController.__PlayWithActors_Internal(base.NativePtr, (SpecChildren ?? new TArray<TWeakObjectPtr<AUIBaseActor>>()).NativePtr, fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x0602063A RID: 132666 RVA: 0x003010A6 File Offset: 0x002FF2A6
		public void PlayInEditor()
		{
			UUIInturnAnimController.__PlayInEditor_Internal(base.NativePtr);
		}

		// Token: 0x0602063B RID: 132667 RVA: 0x003010B4 File Offset: 0x002FF2B4
		public unsafe void Play(string NewAnimName = "", int AssignNum = -1, bool bIsScrollViewItem = false)
		{
			FString fstring = FString.AllocTemp(NewAnimName);
			UUIInturnAnimController.__Play_Internal(base.NativePtr, fstring, AssignNum, bIsScrollViewItem);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x0602063C RID: 132668 RVA: 0x003010E0 File Offset: 0x002FF2E0
		public void OnItemAnimFinish()
		{
			UUIInturnAnimController.__OnItemAnimFinish_Internal(base.NativePtr);
		}

		// Token: 0x0602063D RID: 132669 RVA: 0x003010ED File Offset: 0x002FF2ED
		public bool IsPlaying()
		{
			return UUIInturnAnimController.__IsPlaying_Internal(base.NativePtr);
		}

		// Token: 0x0602063E RID: 132670 RVA: 0x003010FA File Offset: 0x002FF2FA
		public bool GetItemDefaultAlphaZero()
		{
			return UUIInturnAnimController.__GetItemDefaultAlphaZero_Internal(base.NativePtr);
		}

		// Token: 0x0602063F RID: 132671
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Stop_Internal(IntPtr @this);

		// Token: 0x06020640 RID: 132672
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetItemDefaultAlphaZero_Internal(IntPtr @this, bool IsItemDefaultAlphaZero);

		// Token: 0x06020641 RID: 132673
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __PlayWithItems_Internal(IntPtr @this, IntPtr SpecChildren, in FString NewAnimName);

		// Token: 0x06020642 RID: 132674
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __PlayWithActors_Internal(IntPtr @this, IntPtr SpecChildren, in FString NewAnimName);

		// Token: 0x06020643 RID: 132675
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __PlayInEditor_Internal(IntPtr @this);

		// Token: 0x06020644 RID: 132676
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Play_Internal(IntPtr @this, in FString NewAnimName, int AssignNum, bool bIsScrollViewItem);

		// Token: 0x06020645 RID: 132677
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnItemAnimFinish_Internal(IntPtr @this);

		// Token: 0x06020646 RID: 132678
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsPlaying_Internal(IntPtr @this);

		// Token: 0x06020647 RID: 132679
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetItemDefaultAlphaZero_Internal(IntPtr @this);

		// Token: 0x06020648 RID: 132680 RVA: 0x00301107 File Offset: 0x002FF307
		static UUIInturnAnimController()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UIInturnAnimController");
		}

		// Token: 0x06020649 RID: 132681 RVA: 0x00301115 File Offset: 0x002FF315
		protected UUIInturnAnimController(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011622 RID: 71202
		public new const string __ObjectPath = "/Script/LGUI.UIInturnAnimController";

		// Token: 0x04011623 RID: 71203
		private static IntPtr _ClassPtr;

		// Token: 0x04011624 RID: 71204
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011625 RID: 71205
		internal static int __PropertyOffset_OnFinish;

		// Token: 0x04011626 RID: 71206
		[Nullable(2)]
		private FInturnSequenceEvent _OnFinish;

		// Token: 0x04011627 RID: 71207
		internal static int __PropertyOffset_AnimName;

		// Token: 0x04011628 RID: 71208
		internal static int __PropertyOffset_StartTime;

		// Token: 0x04011629 RID: 71209
		internal static int __PropertyOffset_bPlayInSameTime;

		// Token: 0x0401162A RID: 71210
		internal static int __PropertyOffset_Interval;

		// Token: 0x0401162B RID: 71211
		internal static int __PropertyOffset_CustomAnimDuration;

		// Token: 0x0401162C RID: 71212
		internal static int __PropertyOffset_bItemDefaultActive;

		// Token: 0x0401162D RID: 71213
		internal static int __PropertyOffset_bItemDefaultAlphaZero;

		// Token: 0x0401162E RID: 71214
		internal static int __PropertyOffset_PlayFromIndex;
	}
}
