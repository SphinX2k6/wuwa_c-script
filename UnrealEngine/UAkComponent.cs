using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020000BE RID: 190
	[UnrealObjectPath("/Script/AkAudio.AkComponent")]
	[UnrealStructLayout(960, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 960)]
	public class UAkComponent : UAkGameObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06000E16 RID: 3606 RVA: 0x0001610F File Offset: 0x0001430F
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAkComponent._ClassPtr;
		}

		// Token: 0x06000E17 RID: 3607 RVA: 0x0001611C File Offset: 0x0001431C
		public UAkComponent() : this(BuiltinUtils.AllocNativeUObject(UAkComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06000E18 RID: 3608 RVA: 0x00016144 File Offset: 0x00014344
		[NullableContext(1)]
		public UAkComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAkComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700012B RID: 299
		// (get) Token: 0x06000E19 RID: 3609 RVA: 0x00016177 File Offset: 0x00014377
		// (set) Token: 0x06000E1A RID: 3610 RVA: 0x00016187 File Offset: 0x00014387
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

		// Token: 0x1700012C RID: 300
		// (get) Token: 0x06000E1B RID: 3611 RVA: 0x00016198 File Offset: 0x00014398
		// (set) Token: 0x06000E1C RID: 3612 RVA: 0x000161A8 File Offset: 0x000143A8
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

		// Token: 0x1700012D RID: 301
		// (get) Token: 0x06000E1D RID: 3613 RVA: 0x000161B9 File Offset: 0x000143B9
		// (set) Token: 0x06000E1E RID: 3614 RVA: 0x000161C9 File Offset: 0x000143C9
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

		// Token: 0x1700012E RID: 302
		// (get) Token: 0x06000E1F RID: 3615 RVA: 0x000161DA File Offset: 0x000143DA
		// (set) Token: 0x06000E20 RID: 3616 RVA: 0x000161EA File Offset: 0x000143EA
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

		// Token: 0x06000E21 RID: 3617 RVA: 0x000161FB File Offset: 0x000143FB
		public void UseReverbVolumes(bool inUseReverbVolumes)
		{
			UAkComponent.__UseReverbVolumes_Internal(base.NativePtr, inUseReverbVolumes);
		}

		// Token: 0x06000E22 RID: 3618 RVA: 0x0001620C File Offset: 0x0001440C
		[NullableContext(1)]
		public unsafe void SetSwitch([Nullable(2)] UAkSwitchValue SwitchValue, string SwitchGroup, string SwitchState)
		{
			FString fstring = FString.AllocTemp(SwitchGroup);
			FString fstring2 = FString.AllocTemp(SwitchState);
			UAkComponent.__SetSwitch_Internal(base.NativePtr, (SwitchValue != null) ? SwitchValue.NativePtr : IntPtr.Zero, fstring, fstring2);
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
		}

		// Token: 0x06000E23 RID: 3619 RVA: 0x00016258 File Offset: 0x00014458
		public void SetStopWhenOwnerDestroyed(bool bStopWhenOwnerDestroyed)
		{
			UAkComponent.__SetStopWhenOwnerDestroyed_Internal(base.NativePtr, bStopWhenOwnerDestroyed);
		}

		// Token: 0x06000E24 RID: 3620 RVA: 0x00016266 File Offset: 0x00014466
		public void SetOutputBusVolume(float BusVolume)
		{
			UAkComponent.__SetOutputBusVolume_Internal(base.NativePtr, BusVolume);
		}

		// Token: 0x06000E25 RID: 3621 RVA: 0x00016274 File Offset: 0x00014474
		[NullableContext(2)]
		public void SetLocationOffsets(in TArray<FVector> Offsets)
		{
			UAkComponent.__SetLocationOffsets_Internal(base.NativePtr, (Offsets ?? new TArray<FVector>()).NativePtr);
		}

		// Token: 0x06000E26 RID: 3622 RVA: 0x00016291 File Offset: 0x00014491
		public void SetListeners([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<UAkComponent> Listeners)
		{
			UAkComponent.__SetListeners_Internal(base.NativePtr, (Listeners ?? new TArray<UAkComponent>()).NativePtr);
		}

		// Token: 0x06000E27 RID: 3623 RVA: 0x000162AE File Offset: 0x000144AE
		public void SetAttenuationScalingFactor(float Value)
		{
			UAkComponent.__SetAttenuationScalingFactor_Internal(base.NativePtr, Value);
		}

		// Token: 0x06000E28 RID: 3624 RVA: 0x000162BC File Offset: 0x000144BC
		public float GetAttenuationRadius()
		{
			return UAkComponent.__GetAttenuationRadius_Internal(base.NativePtr);
		}

		// Token: 0x06000E29 RID: 3625
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UseReverbVolumes_Internal(IntPtr @this, bool inUseReverbVolumes);

		// Token: 0x06000E2A RID: 3626
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSwitch_Internal(IntPtr @this, IntPtr SwitchValue, in FString SwitchGroup, in FString SwitchState);

		// Token: 0x06000E2B RID: 3627
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetStopWhenOwnerDestroyed_Internal(IntPtr @this, bool bStopWhenOwnerDestroyed);

		// Token: 0x06000E2C RID: 3628
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetOutputBusVolume_Internal(IntPtr @this, float BusVolume);

		// Token: 0x06000E2D RID: 3629
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetLocationOffsets_Internal(IntPtr @this, IntPtr Offsets);

		// Token: 0x06000E2E RID: 3630
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetListeners_Internal(IntPtr @this, IntPtr Listeners);

		// Token: 0x06000E2F RID: 3631
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAttenuationScalingFactor_Internal(IntPtr @this, float Value);

		// Token: 0x06000E30 RID: 3632
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetAttenuationRadius_Internal(IntPtr @this);

		// Token: 0x06000E31 RID: 3633 RVA: 0x000162C9 File Offset: 0x000144C9
		static UAkComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AkAudio.AkComponent");
		}

		// Token: 0x06000E32 RID: 3634 RVA: 0x000162D7 File Offset: 0x000144D7
		protected UAkComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040002B7 RID: 695
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AkAudio.AkComponent";

		// Token: 0x040002B8 RID: 696
		private static IntPtr _ClassPtr;

		// Token: 0x040002B9 RID: 697
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040002BA RID: 698
		internal static int __PropertyOffset_StopWhenOwnerDestroyed;

		// Token: 0x040002BB RID: 699
		internal static int __PropertyOffset_AttenuationScalingFactor;

		// Token: 0x040002BC RID: 700
		internal static int __PropertyOffset_bUseReverbVolumes;

		// Token: 0x040002BD RID: 701
		internal static int __PropertyOffset_bEnableOcclusion;
	}
}
