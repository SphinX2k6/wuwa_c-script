using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000740 RID: 1856
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LTween.LTweenActor")]
	[UnrealStructLayout(1128, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1128)]
	public class ALTweenActor : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600A1F3 RID: 41459 RVA: 0x000EF306 File Offset: 0x000ED506
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ALTweenActor._ClassPtr;
		}

		// Token: 0x0600A1F4 RID: 41460 RVA: 0x000EF314 File Offset: 0x000ED514
		public ALTweenActor() : this(BuiltinUtils.AllocNativeUObject(ALTweenActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600A1F5 RID: 41461 RVA: 0x000EF33C File Offset: 0x000ED53C
		public ALTweenActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ALTweenActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001E3F RID: 7743
		// (get) Token: 0x0600A1F6 RID: 41462 RVA: 0x000EF370 File Offset: 0x000ED570
		// (set) Token: 0x0600A1F7 RID: 41463 RVA: 0x000EF3A9 File Offset: 0x000ED5A9
		public TArray<ULTweener> tweenerList
		{
			get
			{
				base.FastCheckIsValid();
				TArray<ULTweener> result;
				if ((result = this._tweenerList) == null)
				{
					result = (this._tweenerList = new TArray<ULTweener>(base.NativePtr + (IntPtr)ALTweenActor.__PropertyOffset_tweenerList, this));
				}
				return result;
			}
			set
			{
				this.tweenerList.CopyAssign(value);
			}
		}

		// Token: 0x17001E40 RID: 7744
		// (get) Token: 0x0600A1F8 RID: 41464 RVA: 0x000EF3B8 File Offset: 0x000ED5B8
		// (set) Token: 0x0600A1F9 RID: 41465 RVA: 0x000EF3F1 File Offset: 0x000ED5F1
		public TArray<ULTweener> reserveTweenerList
		{
			get
			{
				base.FastCheckIsValid();
				TArray<ULTweener> result;
				if ((result = this._reserveTweenerList) == null)
				{
					result = (this._reserveTweenerList = new TArray<ULTweener>(base.NativePtr + (IntPtr)ALTweenActor.__PropertyOffset_reserveTweenerList, this));
				}
				return result;
			}
			set
			{
				this.reserveTweenerList.CopyAssign(value);
			}
		}

		// Token: 0x17001E41 RID: 7745
		// (get) Token: 0x0600A1FA RID: 41466 RVA: 0x000EF3FF File Offset: 0x000ED5FF
		// (set) Token: 0x0600A1FB RID: 41467 RVA: 0x000EF40F File Offset: 0x000ED60F
		public unsafe float GlobalPlayRate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ALTweenActor.__PropertyOffset_GlobalPlayRate);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ALTweenActor.__PropertyOffset_GlobalPlayRate) = value;
			}
		}

		// Token: 0x0600A1FC RID: 41468 RVA: 0x000EF420 File Offset: 0x000ED620
		public void SetGlobalPlayRate(float NewPlayRate)
		{
			ALTweenActor.__SetGlobalPlayRate_Internal(base.NativePtr, NewPlayRate);
		}

		// Token: 0x0600A1FD RID: 41469 RVA: 0x000EF42E File Offset: 0x000ED62E
		public void KillAllTweens(bool callComplete = false)
		{
			ALTweenActor.__KillAllTweens_Internal(base.NativePtr, callComplete);
		}

		// Token: 0x0600A1FE RID: 41470 RVA: 0x000EF43C File Offset: 0x000ED63C
		[NullableContext(2)]
		public static ALTweenActor GetLTweenInstance(UObject WorldContextObject)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ALTweenActor>(ALTweenActor.__GetLTweenInstance_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero));
		}

		// Token: 0x0600A1FF RID: 41471 RVA: 0x000EF458 File Offset: 0x000ED658
		public float GetGlobalPlayRate()
		{
			return ALTweenActor.__GetGlobalPlayRate_Internal(base.NativePtr);
		}

		// Token: 0x0600A200 RID: 41472 RVA: 0x000EF465 File Offset: 0x000ED665
		public void EnableTick()
		{
			ALTweenActor.__EnableTick_Internal(base.NativePtr);
		}

		// Token: 0x0600A201 RID: 41473 RVA: 0x000EF472 File Offset: 0x000ED672
		public void DisableTick()
		{
			ALTweenActor.__DisableTick_Internal(base.NativePtr);
		}

		// Token: 0x0600A202 RID: 41474 RVA: 0x000EF47F File Offset: 0x000ED67F
		public void CustomTick(float DeltaTime)
		{
			ALTweenActor.__CustomTick_Internal(base.NativePtr, DeltaTime);
		}

		// Token: 0x0600A203 RID: 41475
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetGlobalPlayRate_Internal(IntPtr @this, float NewPlayRate);

		// Token: 0x0600A204 RID: 41476
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __KillAllTweens_Internal(IntPtr @this, bool callComplete);

		// Token: 0x0600A205 RID: 41477
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetLTweenInstance_Internal(IntPtr WorldContextObject);

		// Token: 0x0600A206 RID: 41478
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetGlobalPlayRate_Internal(IntPtr @this);

		// Token: 0x0600A207 RID: 41479
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __EnableTick_Internal(IntPtr @this);

		// Token: 0x0600A208 RID: 41480
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __DisableTick_Internal(IntPtr @this);

		// Token: 0x0600A209 RID: 41481
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __CustomTick_Internal(IntPtr @this, float DeltaTime);

		// Token: 0x0600A20A RID: 41482 RVA: 0x000EF48D File Offset: 0x000ED68D
		static ALTweenActor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LTween.LTweenActor");
		}

		// Token: 0x0600A20B RID: 41483 RVA: 0x000EF49B File Offset: 0x000ED69B
		protected ALTweenActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400455E RID: 17758
		public new const string __ObjectPath = "/Script/LTween.LTweenActor";

		// Token: 0x0400455F RID: 17759
		private static IntPtr _ClassPtr;

		// Token: 0x04004560 RID: 17760
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04004561 RID: 17761
		internal static int __PropertyOffset_tweenerList;

		// Token: 0x04004562 RID: 17762
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<ULTweener> _tweenerList;

		// Token: 0x04004563 RID: 17763
		internal static int __PropertyOffset_reserveTweenerList;

		// Token: 0x04004564 RID: 17764
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<ULTweener> _reserveTweenerList;

		// Token: 0x04004565 RID: 17765
		internal static int __PropertyOffset_GlobalPlayRate;
	}
}
