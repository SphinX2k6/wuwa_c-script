using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200183F RID: 6207
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroFauxPhysics.KuroFauxPhysicsComponentBase")]
	[UnrealStructLayout(736, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 736)]
	public abstract class UKuroFauxPhysicsComponentBase : USceneComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06016E1A RID: 93722 RVA: 0x002166D6 File Offset: 0x002148D6
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroFauxPhysicsComponentBase._ClassPtr;
		}

		// Token: 0x17005C54 RID: 23636
		// (get) Token: 0x06016E1B RID: 93723 RVA: 0x002166E2 File Offset: 0x002148E2
		// (set) Token: 0x06016E1C RID: 93724 RVA: 0x002166F2 File Offset: 0x002148F2
		public unsafe bool bStartDisabled
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroFauxPhysicsComponentBase.__PropertyOffset_bStartDisabled) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroFauxPhysicsComponentBase.__PropertyOffset_bStartDisabled) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005C55 RID: 23637
		// (get) Token: 0x06016E1D RID: 93725 RVA: 0x00216703 File Offset: 0x00214903
		// (set) Token: 0x06016E1E RID: 93726 RVA: 0x00216713 File Offset: 0x00214913
		public unsafe bool bIgnoreActorTimeDilation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroFauxPhysicsComponentBase.__PropertyOffset_bIgnoreActorTimeDilation) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroFauxPhysicsComponentBase.__PropertyOffset_bIgnoreActorTimeDilation) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005C56 RID: 23638
		// (get) Token: 0x06016E1F RID: 93727 RVA: 0x00216724 File Offset: 0x00214924
		// (set) Token: 0x06016E20 RID: 93728 RVA: 0x00216734 File Offset: 0x00214934
		public unsafe bool bStopVelocityWhenDisabled
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroFauxPhysicsComponentBase.__PropertyOffset_bStopVelocityWhenDisabled) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroFauxPhysicsComponentBase.__PropertyOffset_bStopVelocityWhenDisabled) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005C57 RID: 23639
		// (get) Token: 0x06016E21 RID: 93729 RVA: 0x00216745 File Offset: 0x00214945
		// (set) Token: 0x06016E22 RID: 93730 RVA: 0x00216755 File Offset: 0x00214955
		public unsafe float PreventSleepFrameAfterWake
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroFauxPhysicsComponentBase.__PropertyOffset_PreventSleepFrameAfterWake);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroFauxPhysicsComponentBase.__PropertyOffset_PreventSleepFrameAfterWake) = value;
			}
		}

		// Token: 0x17005C58 RID: 23640
		// (get) Token: 0x06016E23 RID: 93731 RVA: 0x00216766 File Offset: 0x00214966
		// (set) Token: 0x06016E24 RID: 93732 RVA: 0x00216776 File Offset: 0x00214976
		public unsafe float MaxStepTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroFauxPhysicsComponentBase.__PropertyOffset_MaxStepTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroFauxPhysicsComponentBase.__PropertyOffset_MaxStepTime) = value;
			}
		}

		// Token: 0x06016E25 RID: 93733 RVA: 0x00216787 File Offset: 0x00214987
		public void Wake()
		{
			UKuroFauxPhysicsComponentBase.__Wake_Internal(base.NativePtr);
		}

		// Token: 0x06016E26 RID: 93734 RVA: 0x00216794 File Offset: 0x00214994
		public void Sleep()
		{
			UKuroFauxPhysicsComponentBase.__Sleep_Internal(base.NativePtr);
		}

		// Token: 0x06016E27 RID: 93735 RVA: 0x002167A1 File Offset: 0x002149A1
		public void ResetPhysics()
		{
			UKuroFauxPhysicsComponentBase.__ResetPhysics_Internal(base.NativePtr);
		}

		// Token: 0x06016E28 RID: 93736 RVA: 0x002167AE File Offset: 0x002149AE
		public void ResetInternalState()
		{
			UKuroFauxPhysicsComponentBase.__ResetInternalState_Internal(base.NativePtr);
		}

		// Token: 0x06016E29 RID: 93737 RVA: 0x002167BB File Offset: 0x002149BB
		public void ResetForces()
		{
			UKuroFauxPhysicsComponentBase.__ResetForces_Internal(base.NativePtr);
		}

		// Token: 0x06016E2A RID: 93738 RVA: 0x002167C8 File Offset: 0x002149C8
		public void RemoveDisabler(in FKuroInstigator DisableInstigator)
		{
			UKuroFauxPhysicsComponentBase.__RemoveDisabler_Internal(base.NativePtr, (DisableInstigator ?? new FKuroInstigator()).NativePtr);
		}

		// Token: 0x06016E2B RID: 93739 RVA: 0x002167E5 File Offset: 0x002149E5
		public void RemoveComponentTickBlocker(in FKuroInstigator DisableInstigator)
		{
			UKuroFauxPhysicsComponentBase.__RemoveComponentTickBlocker_Internal(base.NativePtr, (DisableInstigator ?? new FKuroInstigator()).NativePtr);
		}

		// Token: 0x06016E2C RID: 93740 RVA: 0x00216802 File Offset: 0x00214A02
		public void RemoveAllDisablers()
		{
			UKuroFauxPhysicsComponentBase.__RemoveAllDisablers_Internal(base.NativePtr);
		}

		// Token: 0x06016E2D RID: 93741 RVA: 0x0021680F File Offset: 0x00214A0F
		public bool IsSleeping()
		{
			return UKuroFauxPhysicsComponentBase.__IsSleeping_Internal(base.NativePtr);
		}

		// Token: 0x06016E2E RID: 93742 RVA: 0x0021681C File Offset: 0x00214A1C
		public bool IsEnabled()
		{
			return UKuroFauxPhysicsComponentBase.__IsEnabled_Internal(base.NativePtr);
		}

		// Token: 0x06016E2F RID: 93743 RVA: 0x00216829 File Offset: 0x00214A29
		public bool HasFauxPhysicsControl()
		{
			return UKuroFauxPhysicsComponentBase.__HasFauxPhysicsControl_Internal(base.NativePtr);
		}

		// Token: 0x06016E30 RID: 93744 RVA: 0x00216836 File Offset: 0x00214A36
		public bool CanSleep()
		{
			return UKuroFauxPhysicsComponentBase.__CanSleep_Internal(base.NativePtr);
		}

		// Token: 0x06016E31 RID: 93745 RVA: 0x00216843 File Offset: 0x00214A43
		public void ApplyMovement(in FVector Origin, in FVector Movement)
		{
			UKuroFauxPhysicsComponentBase.__ApplyMovement_Internal(base.NativePtr, Origin, Movement);
		}

		// Token: 0x06016E32 RID: 93746 RVA: 0x00216852 File Offset: 0x00214A52
		public void ApplyImpulse(in FVector Origin, in FVector Impulse)
		{
			UKuroFauxPhysicsComponentBase.__ApplyImpulse_Internal(base.NativePtr, Origin, Impulse);
		}

		// Token: 0x06016E33 RID: 93747 RVA: 0x00216861 File Offset: 0x00214A61
		public void ApplyForce(in FVector Origin, in FVector Force)
		{
			UKuroFauxPhysicsComponentBase.__ApplyForce_Internal(base.NativePtr, Origin, Force);
		}

		// Token: 0x06016E34 RID: 93748 RVA: 0x00216870 File Offset: 0x00214A70
		public void AddDisabler(in FKuroInstigator DisableInstigator)
		{
			UKuroFauxPhysicsComponentBase.__AddDisabler_Internal(base.NativePtr, (DisableInstigator ?? new FKuroInstigator()).NativePtr);
		}

		// Token: 0x06016E35 RID: 93749 RVA: 0x0021688D File Offset: 0x00214A8D
		public void AddComponentTickBlocker(in FKuroInstigator DisableInstigator)
		{
			UKuroFauxPhysicsComponentBase.__AddComponentTickBlocker_Internal(base.NativePtr, (DisableInstigator ?? new FKuroInstigator()).NativePtr);
		}

		// Token: 0x06016E36 RID: 93750
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Wake_Internal(IntPtr @this);

		// Token: 0x06016E37 RID: 93751
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Sleep_Internal(IntPtr @this);

		// Token: 0x06016E38 RID: 93752
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ResetPhysics_Internal(IntPtr @this);

		// Token: 0x06016E39 RID: 93753
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ResetInternalState_Internal(IntPtr @this);

		// Token: 0x06016E3A RID: 93754
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ResetForces_Internal(IntPtr @this);

		// Token: 0x06016E3B RID: 93755
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RemoveDisabler_Internal(IntPtr @this, IntPtr DisableInstigator);

		// Token: 0x06016E3C RID: 93756
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RemoveComponentTickBlocker_Internal(IntPtr @this, IntPtr DisableInstigator);

		// Token: 0x06016E3D RID: 93757
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RemoveAllDisablers_Internal(IntPtr @this);

		// Token: 0x06016E3E RID: 93758
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsSleeping_Internal(IntPtr @this);

		// Token: 0x06016E3F RID: 93759
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsEnabled_Internal(IntPtr @this);

		// Token: 0x06016E40 RID: 93760
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __HasFauxPhysicsControl_Internal(IntPtr @this);

		// Token: 0x06016E41 RID: 93761
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __CanSleep_Internal(IntPtr @this);

		// Token: 0x06016E42 RID: 93762
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ApplyMovement_Internal(IntPtr @this, in FVector Origin, in FVector Movement);

		// Token: 0x06016E43 RID: 93763
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ApplyImpulse_Internal(IntPtr @this, in FVector Origin, in FVector Impulse);

		// Token: 0x06016E44 RID: 93764
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ApplyForce_Internal(IntPtr @this, in FVector Origin, in FVector Force);

		// Token: 0x06016E45 RID: 93765
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddDisabler_Internal(IntPtr @this, IntPtr DisableInstigator);

		// Token: 0x06016E46 RID: 93766
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddComponentTickBlocker_Internal(IntPtr @this, IntPtr DisableInstigator);

		// Token: 0x06016E47 RID: 93767 RVA: 0x002168AA File Offset: 0x00214AAA
		static UKuroFauxPhysicsComponentBase()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroFauxPhysics.KuroFauxPhysicsComponentBase");
		}

		// Token: 0x06016E48 RID: 93768 RVA: 0x002168B8 File Offset: 0x00214AB8
		protected UKuroFauxPhysicsComponentBase() : this(BuiltinUtils.AllocNativeUObject(UKuroFauxPhysicsComponentBase.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06016E49 RID: 93769 RVA: 0x002168E0 File Offset: 0x00214AE0
		protected UKuroFauxPhysicsComponentBase(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400C700 RID: 50944
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroFauxPhysics.KuroFauxPhysicsComponentBase";

		// Token: 0x0400C701 RID: 50945
		private static IntPtr _ClassPtr;

		// Token: 0x0400C702 RID: 50946
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400C703 RID: 50947
		internal static int __PropertyOffset_bStartDisabled;

		// Token: 0x0400C704 RID: 50948
		internal static int __PropertyOffset_bIgnoreActorTimeDilation;

		// Token: 0x0400C705 RID: 50949
		internal static int __PropertyOffset_bStopVelocityWhenDisabled;

		// Token: 0x0400C706 RID: 50950
		internal static int __PropertyOffset_PreventSleepFrameAfterWake;

		// Token: 0x0400C707 RID: 50951
		internal static int __PropertyOffset_MaxStepTime;
	}
}
