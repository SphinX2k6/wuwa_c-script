using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200070C RID: 1804
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.UIInturnAnimController")]
	[UnrealStructLayout(336, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 336)]
	public class UUIInturnAnimController : UActorComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060099D3 RID: 39379 RVA: 0x000E7309 File Offset: 0x000E5509
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUIInturnAnimController._ClassPtr;
		}

		// Token: 0x060099D4 RID: 39380 RVA: 0x000E7318 File Offset: 0x000E5518
		public UUIInturnAnimController() : this(BuiltinUtils.AllocNativeUObject(UUIInturnAnimController.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060099D5 RID: 39381 RVA: 0x000E7340 File Offset: 0x000E5540
		public UUIInturnAnimController(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UUIInturnAnimController.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001C96 RID: 7318
		// (get) Token: 0x060099D6 RID: 39382 RVA: 0x000E7374 File Offset: 0x000E5574
		// (set) Token: 0x060099D7 RID: 39383 RVA: 0x000E73AD File Offset: 0x000E55AD
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

		// Token: 0x17001C97 RID: 7319
		// (get) Token: 0x060099D8 RID: 39384 RVA: 0x000E73CE File Offset: 0x000E55CE
		// (set) Token: 0x060099D9 RID: 39385 RVA: 0x000E73E2 File Offset: 0x000E55E2
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

		// Token: 0x17001C98 RID: 7320
		// (get) Token: 0x060099DA RID: 39386 RVA: 0x000E73F7 File Offset: 0x000E55F7
		// (set) Token: 0x060099DB RID: 39387 RVA: 0x000E7407 File Offset: 0x000E5607
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

		// Token: 0x17001C99 RID: 7321
		// (get) Token: 0x060099DC RID: 39388 RVA: 0x000E7418 File Offset: 0x000E5618
		// (set) Token: 0x060099DD RID: 39389 RVA: 0x000E7428 File Offset: 0x000E5628
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

		// Token: 0x17001C9A RID: 7322
		// (get) Token: 0x060099DE RID: 39390 RVA: 0x000E7439 File Offset: 0x000E5639
		// (set) Token: 0x060099DF RID: 39391 RVA: 0x000E7449 File Offset: 0x000E5649
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

		// Token: 0x17001C9B RID: 7323
		// (get) Token: 0x060099E0 RID: 39392 RVA: 0x000E745A File Offset: 0x000E565A
		// (set) Token: 0x060099E1 RID: 39393 RVA: 0x000E746A File Offset: 0x000E566A
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

		// Token: 0x17001C9C RID: 7324
		// (get) Token: 0x060099E2 RID: 39394 RVA: 0x000E747B File Offset: 0x000E567B
		// (set) Token: 0x060099E3 RID: 39395 RVA: 0x000E748B File Offset: 0x000E568B
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

		// Token: 0x17001C9D RID: 7325
		// (get) Token: 0x060099E4 RID: 39396 RVA: 0x000E749C File Offset: 0x000E569C
		// (set) Token: 0x060099E5 RID: 39397 RVA: 0x000E74AC File Offset: 0x000E56AC
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

		// Token: 0x17001C9E RID: 7326
		// (get) Token: 0x060099E6 RID: 39398 RVA: 0x000E74BD File Offset: 0x000E56BD
		// (set) Token: 0x060099E7 RID: 39399 RVA: 0x000E74CD File Offset: 0x000E56CD
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

		// Token: 0x060099E8 RID: 39400 RVA: 0x000E74DE File Offset: 0x000E56DE
		public void Stop()
		{
			UUIInturnAnimController.__Stop_Internal(base.NativePtr);
		}

		// Token: 0x060099E9 RID: 39401 RVA: 0x000E74EB File Offset: 0x000E56EB
		public void SetItemDefaultAlphaZero(bool IsItemDefaultAlphaZero)
		{
			UUIInturnAnimController.__SetItemDefaultAlphaZero_Internal(base.NativePtr, IsItemDefaultAlphaZero);
		}

		// Token: 0x060099EA RID: 39402 RVA: 0x000E74FC File Offset: 0x000E56FC
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

		// Token: 0x060099EB RID: 39403 RVA: 0x000E7538 File Offset: 0x000E5738
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

		// Token: 0x060099EC RID: 39404 RVA: 0x000E7572 File Offset: 0x000E5772
		public void PlayInEditor()
		{
			UUIInturnAnimController.__PlayInEditor_Internal(base.NativePtr);
		}

		// Token: 0x060099ED RID: 39405 RVA: 0x000E7580 File Offset: 0x000E5780
		public unsafe void Play(string NewAnimName = "", int AssignNum = -1, bool bIsScrollViewItem = false)
		{
			FString fstring = FString.AllocTemp(NewAnimName);
			UUIInturnAnimController.__Play_Internal(base.NativePtr, fstring, AssignNum, bIsScrollViewItem);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x060099EE RID: 39406 RVA: 0x000E75AC File Offset: 0x000E57AC
		public void OnItemAnimFinish()
		{
			UUIInturnAnimController.__OnItemAnimFinish_Internal(base.NativePtr);
		}

		// Token: 0x060099EF RID: 39407 RVA: 0x000E75B9 File Offset: 0x000E57B9
		public bool IsPlaying()
		{
			return UUIInturnAnimController.__IsPlaying_Internal(base.NativePtr);
		}

		// Token: 0x060099F0 RID: 39408 RVA: 0x000E75C6 File Offset: 0x000E57C6
		public bool GetItemDefaultAlphaZero()
		{
			return UUIInturnAnimController.__GetItemDefaultAlphaZero_Internal(base.NativePtr);
		}

		// Token: 0x060099F1 RID: 39409
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Stop_Internal(IntPtr @this);

		// Token: 0x060099F2 RID: 39410
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetItemDefaultAlphaZero_Internal(IntPtr @this, bool IsItemDefaultAlphaZero);

		// Token: 0x060099F3 RID: 39411
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __PlayWithItems_Internal(IntPtr @this, IntPtr SpecChildren, in FString NewAnimName);

		// Token: 0x060099F4 RID: 39412
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __PlayWithActors_Internal(IntPtr @this, IntPtr SpecChildren, in FString NewAnimName);

		// Token: 0x060099F5 RID: 39413
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __PlayInEditor_Internal(IntPtr @this);

		// Token: 0x060099F6 RID: 39414
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Play_Internal(IntPtr @this, in FString NewAnimName, int AssignNum, bool bIsScrollViewItem);

		// Token: 0x060099F7 RID: 39415
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnItemAnimFinish_Internal(IntPtr @this);

		// Token: 0x060099F8 RID: 39416
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsPlaying_Internal(IntPtr @this);

		// Token: 0x060099F9 RID: 39417
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetItemDefaultAlphaZero_Internal(IntPtr @this);

		// Token: 0x060099FA RID: 39418 RVA: 0x000E75D3 File Offset: 0x000E57D3
		static UUIInturnAnimController()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UIInturnAnimController");
		}

		// Token: 0x060099FB RID: 39419 RVA: 0x000E75E1 File Offset: 0x000E57E1
		protected UUIInturnAnimController(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040042C3 RID: 17091
		public new const string __ObjectPath = "/Script/LGUI.UIInturnAnimController";

		// Token: 0x040042C4 RID: 17092
		private static IntPtr _ClassPtr;

		// Token: 0x040042C5 RID: 17093
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040042C6 RID: 17094
		internal static int __PropertyOffset_OnFinish;

		// Token: 0x040042C7 RID: 17095
		[Nullable(2)]
		private FInturnSequenceEvent _OnFinish;

		// Token: 0x040042C8 RID: 17096
		internal static int __PropertyOffset_AnimName;

		// Token: 0x040042C9 RID: 17097
		internal static int __PropertyOffset_StartTime;

		// Token: 0x040042CA RID: 17098
		internal static int __PropertyOffset_bPlayInSameTime;

		// Token: 0x040042CB RID: 17099
		internal static int __PropertyOffset_Interval;

		// Token: 0x040042CC RID: 17100
		internal static int __PropertyOffset_CustomAnimDuration;

		// Token: 0x040042CD RID: 17101
		internal static int __PropertyOffset_bItemDefaultActive;

		// Token: 0x040042CE RID: 17102
		internal static int __PropertyOffset_bItemDefaultAlphaZero;

		// Token: 0x040042CF RID: 17103
		internal static int __PropertyOffset_PlayFromIndex;
	}
}
