using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200194A RID: 6474
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroGAS.AbilityTask_SpecifiedAnimInstancePlayMontageAndWait")]
	[UnrealStructLayout(320, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 320)]
	public class UAbilityTask_SpecifiedAnimInstancePlayMontageAndWait : UAbilityTask, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06017FD0 RID: 98256 RVA: 0x00233193 File Offset: 0x00231393
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAbilityTask_SpecifiedAnimInstancePlayMontageAndWait._ClassPtr;
		}

		// Token: 0x06017FD1 RID: 98257 RVA: 0x002331A0 File Offset: 0x002313A0
		public UAbilityTask_SpecifiedAnimInstancePlayMontageAndWait() : this(BuiltinUtils.AllocNativeUObject(UAbilityTask_SpecifiedAnimInstancePlayMontageAndWait.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06017FD2 RID: 98258 RVA: 0x002331C8 File Offset: 0x002313C8
		public UAbilityTask_SpecifiedAnimInstancePlayMontageAndWait(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAbilityTask_SpecifiedAnimInstancePlayMontageAndWait.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006010 RID: 24592
		// (get) Token: 0x06017FD3 RID: 98259 RVA: 0x002331FC File Offset: 0x002313FC
		// (set) Token: 0x06017FD4 RID: 98260 RVA: 0x00233235 File Offset: 0x00231435
		public FKuroMontageWaitSimpleDelegate OnCompleted
		{
			get
			{
				base.FastCheckIsValid();
				FKuroMontageWaitSimpleDelegate result;
				if ((result = this._OnCompleted) == null)
				{
					result = (this._OnCompleted = new FKuroMontageWaitSimpleDelegate(base.NativePtr + (IntPtr)UAbilityTask_SpecifiedAnimInstancePlayMontageAndWait.__PropertyOffset_OnCompleted, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UAbilityTask_SpecifiedAnimInstancePlayMontageAndWait.__PropertyOffset_OnCompleted, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17006011 RID: 24593
		// (get) Token: 0x06017FD5 RID: 98261 RVA: 0x00233258 File Offset: 0x00231458
		// (set) Token: 0x06017FD6 RID: 98262 RVA: 0x00233291 File Offset: 0x00231491
		public FKuroMontageWaitSimpleDelegate OnBlendOut
		{
			get
			{
				base.FastCheckIsValid();
				FKuroMontageWaitSimpleDelegate result;
				if ((result = this._OnBlendOut) == null)
				{
					result = (this._OnBlendOut = new FKuroMontageWaitSimpleDelegate(base.NativePtr + (IntPtr)UAbilityTask_SpecifiedAnimInstancePlayMontageAndWait.__PropertyOffset_OnBlendOut, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UAbilityTask_SpecifiedAnimInstancePlayMontageAndWait.__PropertyOffset_OnBlendOut, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17006012 RID: 24594
		// (get) Token: 0x06017FD7 RID: 98263 RVA: 0x002332B4 File Offset: 0x002314B4
		// (set) Token: 0x06017FD8 RID: 98264 RVA: 0x002332ED File Offset: 0x002314ED
		public FKuroMontageWaitSimpleDelegate OnInterrupted
		{
			get
			{
				base.FastCheckIsValid();
				FKuroMontageWaitSimpleDelegate result;
				if ((result = this._OnInterrupted) == null)
				{
					result = (this._OnInterrupted = new FKuroMontageWaitSimpleDelegate(base.NativePtr + (IntPtr)UAbilityTask_SpecifiedAnimInstancePlayMontageAndWait.__PropertyOffset_OnInterrupted, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UAbilityTask_SpecifiedAnimInstancePlayMontageAndWait.__PropertyOffset_OnInterrupted, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17006013 RID: 24595
		// (get) Token: 0x06017FD9 RID: 98265 RVA: 0x00233310 File Offset: 0x00231510
		// (set) Token: 0x06017FDA RID: 98266 RVA: 0x00233349 File Offset: 0x00231549
		public FKuroMontageWaitSimpleDelegate OnCancelled
		{
			get
			{
				base.FastCheckIsValid();
				FKuroMontageWaitSimpleDelegate result;
				if ((result = this._OnCancelled) == null)
				{
					result = (this._OnCancelled = new FKuroMontageWaitSimpleDelegate(base.NativePtr + (IntPtr)UAbilityTask_SpecifiedAnimInstancePlayMontageAndWait.__PropertyOffset_OnCancelled, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UAbilityTask_SpecifiedAnimInstancePlayMontageAndWait.__PropertyOffset_OnCancelled, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17006014 RID: 24596
		// (get) Token: 0x06017FDB RID: 98267 RVA: 0x0023336C File Offset: 0x0023156C
		// (set) Token: 0x06017FDC RID: 98268 RVA: 0x002333A5 File Offset: 0x002315A5
		public FKuroMontageWaitSimpleDelegate OnTick
		{
			get
			{
				base.FastCheckIsValid();
				FKuroMontageWaitSimpleDelegate result;
				if ((result = this._OnTick) == null)
				{
					result = (this._OnTick = new FKuroMontageWaitSimpleDelegate(base.NativePtr + (IntPtr)UAbilityTask_SpecifiedAnimInstancePlayMontageAndWait.__PropertyOffset_OnTick, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UAbilityTask_SpecifiedAnimInstancePlayMontageAndWait.__PropertyOffset_OnTick, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17006015 RID: 24597
		// (get) Token: 0x06017FDD RID: 98269 RVA: 0x002333C6 File Offset: 0x002315C6
		// (set) Token: 0x06017FDE RID: 98270 RVA: 0x002333DA File Offset: 0x002315DA
		[Nullable(2)]
		public unsafe UAnimMontage MontageToPlay
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAnimMontage>(base.NativePtr / (IntPtr)sizeof(void*) + UAbilityTask_SpecifiedAnimInstancePlayMontageAndWait.__PropertyOffset_MontageToPlay);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UAbilityTask_SpecifiedAnimInstancePlayMontageAndWait.__PropertyOffset_MontageToPlay, value);
			}
		}

		// Token: 0x17006016 RID: 24598
		// (get) Token: 0x06017FDF RID: 98271 RVA: 0x002333EF File Offset: 0x002315EF
		// (set) Token: 0x06017FE0 RID: 98272 RVA: 0x00233403 File Offset: 0x00231603
		public unsafe FName SkeletalMeshComponentTag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAbilityTask_SpecifiedAnimInstancePlayMontageAndWait.__PropertyOffset_SkeletalMeshComponentTag);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAbilityTask_SpecifiedAnimInstancePlayMontageAndWait.__PropertyOffset_SkeletalMeshComponentTag) = value;
			}
		}

		// Token: 0x17006017 RID: 24599
		// (get) Token: 0x06017FE1 RID: 98273 RVA: 0x00233418 File Offset: 0x00231618
		// (set) Token: 0x06017FE2 RID: 98274 RVA: 0x00233428 File Offset: 0x00231628
		public unsafe float Rate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAbilityTask_SpecifiedAnimInstancePlayMontageAndWait.__PropertyOffset_Rate);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAbilityTask_SpecifiedAnimInstancePlayMontageAndWait.__PropertyOffset_Rate) = value;
			}
		}

		// Token: 0x17006018 RID: 24600
		// (get) Token: 0x06017FE3 RID: 98275 RVA: 0x00233439 File Offset: 0x00231639
		// (set) Token: 0x06017FE4 RID: 98276 RVA: 0x0023344D File Offset: 0x0023164D
		public unsafe FName StartSection
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAbilityTask_SpecifiedAnimInstancePlayMontageAndWait.__PropertyOffset_StartSection);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAbilityTask_SpecifiedAnimInstancePlayMontageAndWait.__PropertyOffset_StartSection) = value;
			}
		}

		// Token: 0x17006019 RID: 24601
		// (get) Token: 0x06017FE5 RID: 98277 RVA: 0x00233462 File Offset: 0x00231662
		// (set) Token: 0x06017FE6 RID: 98278 RVA: 0x00233472 File Offset: 0x00231672
		public unsafe float AnimRootMotionTranslationScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAbilityTask_SpecifiedAnimInstancePlayMontageAndWait.__PropertyOffset_AnimRootMotionTranslationScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAbilityTask_SpecifiedAnimInstancePlayMontageAndWait.__PropertyOffset_AnimRootMotionTranslationScale) = value;
			}
		}

		// Token: 0x1700601A RID: 24602
		// (get) Token: 0x06017FE7 RID: 98279 RVA: 0x00233483 File Offset: 0x00231683
		// (set) Token: 0x06017FE8 RID: 98280 RVA: 0x00233493 File Offset: 0x00231693
		public unsafe float StartTimeSeconds
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAbilityTask_SpecifiedAnimInstancePlayMontageAndWait.__PropertyOffset_StartTimeSeconds);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAbilityTask_SpecifiedAnimInstancePlayMontageAndWait.__PropertyOffset_StartTimeSeconds) = value;
			}
		}

		// Token: 0x1700601B RID: 24603
		// (get) Token: 0x06017FE9 RID: 98281 RVA: 0x002334A4 File Offset: 0x002316A4
		// (set) Token: 0x06017FEA RID: 98282 RVA: 0x002334B4 File Offset: 0x002316B4
		public unsafe bool bStopWhenAbilityEnds
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAbilityTask_SpecifiedAnimInstancePlayMontageAndWait.__PropertyOffset_bStopWhenAbilityEnds) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAbilityTask_SpecifiedAnimInstancePlayMontageAndWait.__PropertyOffset_bStopWhenAbilityEnds) = (value ? 1 : 0);
			}
		}

		// Token: 0x06017FEB RID: 98283 RVA: 0x002334C5 File Offset: 0x002316C5
		public void TickTask(float DeltaTime)
		{
			UAbilityTask_SpecifiedAnimInstancePlayMontageAndWait.__TickTask_Internal(base.NativePtr, DeltaTime);
		}

		// Token: 0x06017FEC RID: 98284 RVA: 0x002334D3 File Offset: 0x002316D3
		public void OnMontageInterrupted()
		{
			UAbilityTask_SpecifiedAnimInstancePlayMontageAndWait.__OnMontageInterrupted_Internal(base.NativePtr);
		}

		// Token: 0x06017FED RID: 98285 RVA: 0x002334E0 File Offset: 0x002316E0
		[NullableContext(2)]
		public void OnMontageEnded(UAnimMontage Montage, bool bInterrupted)
		{
			UAbilityTask_SpecifiedAnimInstancePlayMontageAndWait.__OnMontageEnded_Internal(base.NativePtr, (Montage != null) ? Montage.NativePtr : IntPtr.Zero, bInterrupted);
		}

		// Token: 0x06017FEE RID: 98286 RVA: 0x002334FE File Offset: 0x002316FE
		[NullableContext(2)]
		public void OnMontageBlendingOut(UAnimMontage Montage, bool bInterrupted)
		{
			UAbilityTask_SpecifiedAnimInstancePlayMontageAndWait.__OnMontageBlendingOut_Internal(base.NativePtr, (Montage != null) ? Montage.NativePtr : IntPtr.Zero, bInterrupted);
		}

		// Token: 0x06017FEF RID: 98287 RVA: 0x0023351C File Offset: 0x0023171C
		[NullableContext(2)]
		public static UAbilityTask_SpecifiedAnimInstancePlayMontageAndWait CreatePlayMontageAndWaitProxy(UGameplayAbility OwningAbility, FName TaskInstanceName, UAnimMontage MontageToPlay, FName SkeletalMeshComponentTag = default(FName), float Rate = 1f, FName StartSection = default(FName), bool bStopWhenAbilityEnds = true, float AnimRootMotionTranslationScale = 1f, float StartTimeSeconds = 0f, bool NeedTick = false)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UAbilityTask_SpecifiedAnimInstancePlayMontageAndWait>(UAbilityTask_SpecifiedAnimInstancePlayMontageAndWait.__CreatePlayMontageAndWaitProxy_Internal((OwningAbility != null) ? OwningAbility.NativePtr : IntPtr.Zero, TaskInstanceName, (MontageToPlay != null) ? MontageToPlay.NativePtr : IntPtr.Zero, SkeletalMeshComponentTag, Rate, StartSection, bStopWhenAbilityEnds, AnimRootMotionTranslationScale, StartTimeSeconds, NeedTick));
		}

		// Token: 0x06017FF0 RID: 98288
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __TickTask_Internal(IntPtr @this, float DeltaTime);

		// Token: 0x06017FF1 RID: 98289
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnMontageInterrupted_Internal(IntPtr @this);

		// Token: 0x06017FF2 RID: 98290
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnMontageEnded_Internal(IntPtr @this, IntPtr Montage, bool bInterrupted);

		// Token: 0x06017FF3 RID: 98291
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnMontageBlendingOut_Internal(IntPtr @this, IntPtr Montage, bool bInterrupted);

		// Token: 0x06017FF4 RID: 98292
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __CreatePlayMontageAndWaitProxy_Internal(IntPtr OwningAbility, FName TaskInstanceName, IntPtr MontageToPlay, FName SkeletalMeshComponentTag, float Rate, FName StartSection, bool bStopWhenAbilityEnds, float AnimRootMotionTranslationScale, float StartTimeSeconds, bool NeedTick);

		// Token: 0x06017FF5 RID: 98293 RVA: 0x00233561 File Offset: 0x00231761
		static UAbilityTask_SpecifiedAnimInstancePlayMontageAndWait()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroGAS.AbilityTask_SpecifiedAnimInstancePlayMontageAndWait");
		}

		// Token: 0x06017FF6 RID: 98294 RVA: 0x0023356F File Offset: 0x0023176F
		protected UAbilityTask_SpecifiedAnimInstancePlayMontageAndWait(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400CF98 RID: 53144
		public new const string __ObjectPath = "/Script/KuroGAS.AbilityTask_SpecifiedAnimInstancePlayMontageAndWait";

		// Token: 0x0400CF99 RID: 53145
		private static IntPtr _ClassPtr;

		// Token: 0x0400CF9A RID: 53146
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400CF9B RID: 53147
		internal static int __PropertyOffset_OnCompleted;

		// Token: 0x0400CF9C RID: 53148
		[Nullable(2)]
		private FKuroMontageWaitSimpleDelegate _OnCompleted;

		// Token: 0x0400CF9D RID: 53149
		internal static int __PropertyOffset_OnBlendOut;

		// Token: 0x0400CF9E RID: 53150
		[Nullable(2)]
		private FKuroMontageWaitSimpleDelegate _OnBlendOut;

		// Token: 0x0400CF9F RID: 53151
		internal static int __PropertyOffset_OnInterrupted;

		// Token: 0x0400CFA0 RID: 53152
		[Nullable(2)]
		private FKuroMontageWaitSimpleDelegate _OnInterrupted;

		// Token: 0x0400CFA1 RID: 53153
		internal static int __PropertyOffset_OnCancelled;

		// Token: 0x0400CFA2 RID: 53154
		[Nullable(2)]
		private FKuroMontageWaitSimpleDelegate _OnCancelled;

		// Token: 0x0400CFA3 RID: 53155
		internal static int __PropertyOffset_OnTick;

		// Token: 0x0400CFA4 RID: 53156
		[Nullable(2)]
		private FKuroMontageWaitSimpleDelegate _OnTick;

		// Token: 0x0400CFA5 RID: 53157
		internal static int __PropertyOffset_MontageToPlay;

		// Token: 0x0400CFA6 RID: 53158
		internal static int __PropertyOffset_SkeletalMeshComponentTag;

		// Token: 0x0400CFA7 RID: 53159
		internal static int __PropertyOffset_Rate;

		// Token: 0x0400CFA8 RID: 53160
		internal static int __PropertyOffset_StartSection;

		// Token: 0x0400CFA9 RID: 53161
		internal static int __PropertyOffset_AnimRootMotionTranslationScale;

		// Token: 0x0400CFAA RID: 53162
		internal static int __PropertyOffset_StartTimeSeconds;

		// Token: 0x0400CFAB RID: 53163
		internal static int __PropertyOffset_bStopWhenAbilityEnds;
	}
}
