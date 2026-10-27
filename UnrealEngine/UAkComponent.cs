using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020001FE RID: 510
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AkAudio.AkComponent")]
	[UnrealStructLayout(960, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 960)]
	public class UAkComponent : UAkGameObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06001E04 RID: 7684 RVA: 0x0002C901 File Offset: 0x0002AB01
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAkComponent._ClassPtr;
		}

		// Token: 0x06001E05 RID: 7685 RVA: 0x0002C910 File Offset: 0x0002AB10
		public UAkComponent() : this(BuiltinUtils.AllocNativeUObject(UAkComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06001E06 RID: 7686 RVA: 0x0002C938 File Offset: 0x0002AB38
		public UAkComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAkComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17000788 RID: 1928
		// (get) Token: 0x06001E07 RID: 7687 RVA: 0x0002C96B File Offset: 0x0002AB6B
		// (set) Token: 0x06001E08 RID: 7688 RVA: 0x0002C97B File Offset: 0x0002AB7B
		public unsafe bool StopWhenOwnerDestroyed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAkComponent.__PropertyOffset_StopWhenOwnerDestroyed) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAkComponent.__PropertyOffset_StopWhenOwnerDestroyed) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000789 RID: 1929
		// (get) Token: 0x06001E09 RID: 7689 RVA: 0x0002C98C File Offset: 0x0002AB8C
		// (set) Token: 0x06001E0A RID: 7690 RVA: 0x0002C99C File Offset: 0x0002AB9C
		public unsafe float AttenuationScalingFactor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAkComponent.__PropertyOffset_AttenuationScalingFactor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAkComponent.__PropertyOffset_AttenuationScalingFactor) = value;
			}
		}

		// Token: 0x1700078A RID: 1930
		// (get) Token: 0x06001E0B RID: 7691 RVA: 0x0002C9AD File Offset: 0x0002ABAD
		// (set) Token: 0x06001E0C RID: 7692 RVA: 0x0002C9BD File Offset: 0x0002ABBD
		public unsafe bool bUseReverbVolumes
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAkComponent.__PropertyOffset_bUseReverbVolumes) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAkComponent.__PropertyOffset_bUseReverbVolumes) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700078B RID: 1931
		// (get) Token: 0x06001E0D RID: 7693 RVA: 0x0002C9CE File Offset: 0x0002ABCE
		// (set) Token: 0x06001E0E RID: 7694 RVA: 0x0002C9DE File Offset: 0x0002ABDE
		public unsafe bool bEnableOcclusion
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAkComponent.__PropertyOffset_bEnableOcclusion) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAkComponent.__PropertyOffset_bEnableOcclusion) = (value ? 1 : 0);
			}
		}

		// Token: 0x06001E0F RID: 7695 RVA: 0x0002C9EF File Offset: 0x0002ABEF
		public void UseReverbVolumes(bool inUseReverbVolumes)
		{
			UAkComponent.__UseReverbVolumes_Internal(base.NativePtr, inUseReverbVolumes);
		}

		// Token: 0x06001E10 RID: 7696 RVA: 0x0002CA00 File Offset: 0x0002AC00
		public unsafe void SetSwitch([Nullable(2)] UAkSwitchValue SwitchValue, string SwitchGroup, string SwitchState)
		{
			FString fstring = FString.AllocTemp(SwitchGroup);
			FString fstring2 = FString.AllocTemp(SwitchState);
			UAkComponent.__SetSwitch_Internal(base.NativePtr, (SwitchValue != null) ? SwitchValue.NativePtr : IntPtr.Zero, fstring, fstring2);
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
		}

		// Token: 0x06001E11 RID: 7697 RVA: 0x0002CA4C File Offset: 0x0002AC4C
		public void SetStopWhenOwnerDestroyed(bool bStopWhenOwnerDestroyed)
		{
			UAkComponent.__SetStopWhenOwnerDestroyed_Internal(base.NativePtr, bStopWhenOwnerDestroyed);
		}

		// Token: 0x06001E12 RID: 7698 RVA: 0x0002CA5A File Offset: 0x0002AC5A
		public void SetOutputBusVolume(float BusVolume)
		{
			UAkComponent.__SetOutputBusVolume_Internal(base.NativePtr, BusVolume);
		}

		// Token: 0x06001E13 RID: 7699 RVA: 0x0002CA68 File Offset: 0x0002AC68
		[NullableContext(2)]
		public void SetLocationOffsets(in TArray<FVector> Offsets)
		{
			UAkComponent.__SetLocationOffsets_Internal(base.NativePtr, (Offsets ?? new TArray<FVector>()).NativePtr);
		}

		// Token: 0x06001E14 RID: 7700 RVA: 0x0002CA85 File Offset: 0x0002AC85
		public void SetListeners([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<UAkComponent> Listeners)
		{
			UAkComponent.__SetListeners_Internal(base.NativePtr, (Listeners ?? new TArray<UAkComponent>()).NativePtr);
		}

		// Token: 0x06001E15 RID: 7701 RVA: 0x0002CAA2 File Offset: 0x0002ACA2
		public void SetAttenuationScalingFactor(float Value)
		{
			UAkComponent.__SetAttenuationScalingFactor_Internal(base.NativePtr, Value);
		}

		// Token: 0x06001E16 RID: 7702 RVA: 0x0002CAB0 File Offset: 0x0002ACB0
		public unsafe void PostTrigger([Nullable(2)] UAkTrigger TriggerValue, string Trigger)
		{
			FString fstring = FString.AllocTemp(Trigger);
			UAkComponent.__PostTrigger_Internal(base.NativePtr, (TriggerValue != null) ? TriggerValue.NativePtr : IntPtr.Zero, fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06001E17 RID: 7703 RVA: 0x0002CAEA File Offset: 0x0002ACEA
		public float GetAttenuationRadius()
		{
			return UAkComponent.__GetAttenuationRadius_Internal(base.NativePtr);
		}

		// Token: 0x06001E18 RID: 7704
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UseReverbVolumes_Internal(IntPtr @this, bool inUseReverbVolumes);

		// Token: 0x06001E19 RID: 7705
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSwitch_Internal(IntPtr @this, IntPtr SwitchValue, in FString SwitchGroup, in FString SwitchState);

		// Token: 0x06001E1A RID: 7706
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetStopWhenOwnerDestroyed_Internal(IntPtr @this, bool bStopWhenOwnerDestroyed);

		// Token: 0x06001E1B RID: 7707
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetOutputBusVolume_Internal(IntPtr @this, float BusVolume);

		// Token: 0x06001E1C RID: 7708
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetLocationOffsets_Internal(IntPtr @this, IntPtr Offsets);

		// Token: 0x06001E1D RID: 7709
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetListeners_Internal(IntPtr @this, IntPtr Listeners);

		// Token: 0x06001E1E RID: 7710
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAttenuationScalingFactor_Internal(IntPtr @this, float Value);

		// Token: 0x06001E1F RID: 7711
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __PostTrigger_Internal(IntPtr @this, IntPtr TriggerValue, in FString Trigger);

		// Token: 0x06001E20 RID: 7712
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetAttenuationRadius_Internal(IntPtr @this);

		// Token: 0x06001E21 RID: 7713 RVA: 0x0002CAF7 File Offset: 0x0002ACF7
		static UAkComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AkAudio.AkComponent");
		}

		// Token: 0x06001E22 RID: 7714 RVA: 0x0002CB05 File Offset: 0x0002AD05
		protected UAkComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040009F2 RID: 2546
		public new const string __ObjectPath = "/Script/AkAudio.AkComponent";

		// Token: 0x040009F3 RID: 2547
		private static IntPtr _ClassPtr;

		// Token: 0x040009F4 RID: 2548
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040009F5 RID: 2549
		internal static int __PropertyOffset_StopWhenOwnerDestroyed;

		// Token: 0x040009F6 RID: 2550
		internal static int __PropertyOffset_AttenuationScalingFactor;

		// Token: 0x040009F7 RID: 2551
		internal static int __PropertyOffset_bUseReverbVolumes;

		// Token: 0x040009F8 RID: 2552
		internal static int __PropertyOffset_bEnableOcclusion;
	}
}
