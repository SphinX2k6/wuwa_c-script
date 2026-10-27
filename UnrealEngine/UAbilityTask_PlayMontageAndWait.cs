using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020012FD RID: 4861
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/GameplayAbilities.AbilityTask_PlayMontageAndWait")]
	[UnrealStructLayout(312, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 312)]
	public class UAbilityTask_PlayMontageAndWait : UAbilityTask, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06011ECA RID: 73418 RVA: 0x001A4B03 File Offset: 0x001A2D03
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAbilityTask_PlayMontageAndWait._ClassPtr;
		}

		// Token: 0x06011ECB RID: 73419 RVA: 0x001A4B10 File Offset: 0x001A2D10
		public UAbilityTask_PlayMontageAndWait() : this(BuiltinUtils.AllocNativeUObject(UAbilityTask_PlayMontageAndWait.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06011ECC RID: 73420 RVA: 0x001A4B38 File Offset: 0x001A2D38
		public UAbilityTask_PlayMontageAndWait(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAbilityTask_PlayMontageAndWait.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004612 RID: 17938
		// (get) Token: 0x06011ECD RID: 73421 RVA: 0x001A4B6C File Offset: 0x001A2D6C
		// (set) Token: 0x06011ECE RID: 73422 RVA: 0x001A4BA5 File Offset: 0x001A2DA5
		public FMontageWaitSimpleDelegate OnCompleted
		{
			get
			{
				base.FastCheckIsValid();
				FMontageWaitSimpleDelegate result;
				if ((result = this._OnCompleted) == null)
				{
					result = (this._OnCompleted = new FMontageWaitSimpleDelegate(base.NativePtr + (IntPtr)UAbilityTask_PlayMontageAndWait.__PropertyOffset_OnCompleted, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UAbilityTask_PlayMontageAndWait.__PropertyOffset_OnCompleted, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17004613 RID: 17939
		// (get) Token: 0x06011ECF RID: 73423 RVA: 0x001A4BC8 File Offset: 0x001A2DC8
		// (set) Token: 0x06011ED0 RID: 73424 RVA: 0x001A4C01 File Offset: 0x001A2E01
		public FMontageWaitSimpleDelegate OnBlendOut
		{
			get
			{
				base.FastCheckIsValid();
				FMontageWaitSimpleDelegate result;
				if ((result = this._OnBlendOut) == null)
				{
					result = (this._OnBlendOut = new FMontageWaitSimpleDelegate(base.NativePtr + (IntPtr)UAbilityTask_PlayMontageAndWait.__PropertyOffset_OnBlendOut, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UAbilityTask_PlayMontageAndWait.__PropertyOffset_OnBlendOut, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17004614 RID: 17940
		// (get) Token: 0x06011ED1 RID: 73425 RVA: 0x001A4C24 File Offset: 0x001A2E24
		// (set) Token: 0x06011ED2 RID: 73426 RVA: 0x001A4C5D File Offset: 0x001A2E5D
		public FMontageWaitSimpleDelegate OnInterrupted
		{
			get
			{
				base.FastCheckIsValid();
				FMontageWaitSimpleDelegate result;
				if ((result = this._OnInterrupted) == null)
				{
					result = (this._OnInterrupted = new FMontageWaitSimpleDelegate(base.NativePtr + (IntPtr)UAbilityTask_PlayMontageAndWait.__PropertyOffset_OnInterrupted, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UAbilityTask_PlayMontageAndWait.__PropertyOffset_OnInterrupted, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17004615 RID: 17941
		// (get) Token: 0x06011ED3 RID: 73427 RVA: 0x001A4C80 File Offset: 0x001A2E80
		// (set) Token: 0x06011ED4 RID: 73428 RVA: 0x001A4CB9 File Offset: 0x001A2EB9
		public FMontageWaitSimpleDelegate OnCancelled
		{
			get
			{
				base.FastCheckIsValid();
				FMontageWaitSimpleDelegate result;
				if ((result = this._OnCancelled) == null)
				{
					result = (this._OnCancelled = new FMontageWaitSimpleDelegate(base.NativePtr + (IntPtr)UAbilityTask_PlayMontageAndWait.__PropertyOffset_OnCancelled, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UAbilityTask_PlayMontageAndWait.__PropertyOffset_OnCancelled, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17004616 RID: 17942
		// (get) Token: 0x06011ED5 RID: 73429 RVA: 0x001A4CDC File Offset: 0x001A2EDC
		// (set) Token: 0x06011ED6 RID: 73430 RVA: 0x001A4D15 File Offset: 0x001A2F15
		public FMontageWaitSimpleDelegate OnTick
		{
			get
			{
				base.FastCheckIsValid();
				FMontageWaitSimpleDelegate result;
				if ((result = this._OnTick) == null)
				{
					result = (this._OnTick = new FMontageWaitSimpleDelegate(base.NativePtr + (IntPtr)UAbilityTask_PlayMontageAndWait.__PropertyOffset_OnTick, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UAbilityTask_PlayMontageAndWait.__PropertyOffset_OnTick, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17004617 RID: 17943
		// (get) Token: 0x06011ED7 RID: 73431 RVA: 0x001A4D36 File Offset: 0x001A2F36
		// (set) Token: 0x06011ED8 RID: 73432 RVA: 0x001A4D4A File Offset: 0x001A2F4A
		[Nullable(2)]
		public unsafe UAnimMontage MontageToPlay
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAnimMontage>(base.NativePtr / (IntPtr)sizeof(void*) + UAbilityTask_PlayMontageAndWait.__PropertyOffset_MontageToPlay);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UAbilityTask_PlayMontageAndWait.__PropertyOffset_MontageToPlay, value);
			}
		}

		// Token: 0x17004618 RID: 17944
		// (get) Token: 0x06011ED9 RID: 73433 RVA: 0x001A4D5F File Offset: 0x001A2F5F
		// (set) Token: 0x06011EDA RID: 73434 RVA: 0x001A4D6F File Offset: 0x001A2F6F
		public unsafe float Rate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAbilityTask_PlayMontageAndWait.__PropertyOffset_Rate);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAbilityTask_PlayMontageAndWait.__PropertyOffset_Rate) = value;
			}
		}

		// Token: 0x17004619 RID: 17945
		// (get) Token: 0x06011EDB RID: 73435 RVA: 0x001A4D80 File Offset: 0x001A2F80
		// (set) Token: 0x06011EDC RID: 73436 RVA: 0x001A4D94 File Offset: 0x001A2F94
		public unsafe FName StartSection
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAbilityTask_PlayMontageAndWait.__PropertyOffset_StartSection);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAbilityTask_PlayMontageAndWait.__PropertyOffset_StartSection) = value;
			}
		}

		// Token: 0x1700461A RID: 17946
		// (get) Token: 0x06011EDD RID: 73437 RVA: 0x001A4DA9 File Offset: 0x001A2FA9
		// (set) Token: 0x06011EDE RID: 73438 RVA: 0x001A4DB9 File Offset: 0x001A2FB9
		public unsafe float AnimRootMotionTranslationScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAbilityTask_PlayMontageAndWait.__PropertyOffset_AnimRootMotionTranslationScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAbilityTask_PlayMontageAndWait.__PropertyOffset_AnimRootMotionTranslationScale) = value;
			}
		}

		// Token: 0x1700461B RID: 17947
		// (get) Token: 0x06011EDF RID: 73439 RVA: 0x001A4DCA File Offset: 0x001A2FCA
		// (set) Token: 0x06011EE0 RID: 73440 RVA: 0x001A4DDA File Offset: 0x001A2FDA
		public unsafe float StartTimeSeconds
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAbilityTask_PlayMontageAndWait.__PropertyOffset_StartTimeSeconds);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAbilityTask_PlayMontageAndWait.__PropertyOffset_StartTimeSeconds) = value;
			}
		}

		// Token: 0x1700461C RID: 17948
		// (get) Token: 0x06011EE1 RID: 73441 RVA: 0x001A4DEB File Offset: 0x001A2FEB
		// (set) Token: 0x06011EE2 RID: 73442 RVA: 0x001A4DFB File Offset: 0x001A2FFB
		public unsafe bool bStopWhenAbilityEnds
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAbilityTask_PlayMontageAndWait.__PropertyOffset_bStopWhenAbilityEnds) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAbilityTask_PlayMontageAndWait.__PropertyOffset_bStopWhenAbilityEnds) = (value ? 1 : 0);
			}
		}

		// Token: 0x06011EE3 RID: 73443 RVA: 0x001A4E0C File Offset: 0x001A300C
		public void TickTask(float DeltaTime)
		{
			UAbilityTask_PlayMontageAndWait.__TickTask_Internal(base.NativePtr, DeltaTime);
		}

		// Token: 0x06011EE4 RID: 73444 RVA: 0x001A4E1A File Offset: 0x001A301A
		public void OnMontageInterrupted()
		{
			UAbilityTask_PlayMontageAndWait.__OnMontageInterrupted_Internal(base.NativePtr);
		}

		// Token: 0x06011EE5 RID: 73445 RVA: 0x001A4E27 File Offset: 0x001A3027
		[NullableContext(2)]
		public void OnMontageEnded(UAnimMontage Montage, bool bInterrupted)
		{
			UAbilityTask_PlayMontageAndWait.__OnMontageEnded_Internal(base.NativePtr, (Montage != null) ? Montage.NativePtr : IntPtr.Zero, bInterrupted);
		}

		// Token: 0x06011EE6 RID: 73446 RVA: 0x001A4E45 File Offset: 0x001A3045
		[NullableContext(2)]
		public void OnMontageBlendingOut(UAnimMontage Montage, bool bInterrupted)
		{
			UAbilityTask_PlayMontageAndWait.__OnMontageBlendingOut_Internal(base.NativePtr, (Montage != null) ? Montage.NativePtr : IntPtr.Zero, bInterrupted);
		}

		// Token: 0x06011EE7 RID: 73447 RVA: 0x001A4E64 File Offset: 0x001A3064
		[NullableContext(2)]
		public static UAbilityTask_PlayMontageAndWait CreatePlayMontageAndWaitProxy(UGameplayAbility OwningAbility, FName TaskInstanceName, UAnimMontage MontageToPlay, float Rate = 1f, FName StartSection = default(FName), bool bStopWhenAbilityEnds = true, float AnimRootMotionTranslationScale = 1f, float StartTimeSeconds = 0f, bool NeedTick = false)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UAbilityTask_PlayMontageAndWait>(UAbilityTask_PlayMontageAndWait.__CreatePlayMontageAndWaitProxy_Internal((OwningAbility != null) ? OwningAbility.NativePtr : IntPtr.Zero, TaskInstanceName, (MontageToPlay != null) ? MontageToPlay.NativePtr : IntPtr.Zero, Rate, StartSection, bStopWhenAbilityEnds, AnimRootMotionTranslationScale, StartTimeSeconds, NeedTick));
		}

		// Token: 0x06011EE8 RID: 73448
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __TickTask_Internal(IntPtr @this, float DeltaTime);

		// Token: 0x06011EE9 RID: 73449
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnMontageInterrupted_Internal(IntPtr @this);

		// Token: 0x06011EEA RID: 73450
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnMontageEnded_Internal(IntPtr @this, IntPtr Montage, bool bInterrupted);

		// Token: 0x06011EEB RID: 73451
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnMontageBlendingOut_Internal(IntPtr @this, IntPtr Montage, bool bInterrupted);

		// Token: 0x06011EEC RID: 73452
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __CreatePlayMontageAndWaitProxy_Internal(IntPtr OwningAbility, FName TaskInstanceName, IntPtr MontageToPlay, float Rate, FName StartSection, bool bStopWhenAbilityEnds, float AnimRootMotionTranslationScale, float StartTimeSeconds, bool NeedTick);

		// Token: 0x06011EED RID: 73453 RVA: 0x001A4EA7 File Offset: 0x001A30A7
		static UAbilityTask_PlayMontageAndWait()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/GameplayAbilities.AbilityTask_PlayMontageAndWait");
		}

		// Token: 0x06011EEE RID: 73454 RVA: 0x001A4EB5 File Offset: 0x001A30B5
		protected UAbilityTask_PlayMontageAndWait(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04009952 RID: 39250
		public new const string __ObjectPath = "/Script/GameplayAbilities.AbilityTask_PlayMontageAndWait";

		// Token: 0x04009953 RID: 39251
		private static IntPtr _ClassPtr;

		// Token: 0x04009954 RID: 39252
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04009955 RID: 39253
		internal static int __PropertyOffset_OnCompleted;

		// Token: 0x04009956 RID: 39254
		[Nullable(2)]
		private FMontageWaitSimpleDelegate _OnCompleted;

		// Token: 0x04009957 RID: 39255
		internal static int __PropertyOffset_OnBlendOut;

		// Token: 0x04009958 RID: 39256
		[Nullable(2)]
		private FMontageWaitSimpleDelegate _OnBlendOut;

		// Token: 0x04009959 RID: 39257
		internal static int __PropertyOffset_OnInterrupted;

		// Token: 0x0400995A RID: 39258
		[Nullable(2)]
		private FMontageWaitSimpleDelegate _OnInterrupted;

		// Token: 0x0400995B RID: 39259
		internal static int __PropertyOffset_OnCancelled;

		// Token: 0x0400995C RID: 39260
		[Nullable(2)]
		private FMontageWaitSimpleDelegate _OnCancelled;

		// Token: 0x0400995D RID: 39261
		internal static int __PropertyOffset_OnTick;

		// Token: 0x0400995E RID: 39262
		[Nullable(2)]
		private FMontageWaitSimpleDelegate _OnTick;

		// Token: 0x0400995F RID: 39263
		internal static int __PropertyOffset_MontageToPlay;

		// Token: 0x04009960 RID: 39264
		internal static int __PropertyOffset_Rate;

		// Token: 0x04009961 RID: 39265
		internal static int __PropertyOffset_StartSection;

		// Token: 0x04009962 RID: 39266
		internal static int __PropertyOffset_AnimRootMotionTranslationScale;

		// Token: 0x04009963 RID: 39267
		internal static int __PropertyOffset_StartTimeSeconds;

		// Token: 0x04009964 RID: 39268
		internal static int __PropertyOffset_bStopWhenAbilityEnds;
	}
}
