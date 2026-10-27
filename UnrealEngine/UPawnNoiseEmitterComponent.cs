using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000FD1 RID: 4049
	[UnrealObjectPath("/Script/Engine.PawnNoiseEmitterComponent")]
	[UnrealStructLayout(240, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 240)]
	public class UPawnNoiseEmitterComponent : UActorComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600DABE RID: 55998 RVA: 0x001427FD File Offset: 0x001409FD
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UPawnNoiseEmitterComponent._ClassPtr;
		}

		// Token: 0x0600DABF RID: 55999 RVA: 0x0014280C File Offset: 0x00140A0C
		public UPawnNoiseEmitterComponent() : this(BuiltinUtils.AllocNativeUObject(UPawnNoiseEmitterComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600DAC0 RID: 56000 RVA: 0x00142834 File Offset: 0x00140A34
		[NullableContext(1)]
		public UPawnNoiseEmitterComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UPawnNoiseEmitterComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003399 RID: 13209
		// (get) Token: 0x0600DAC1 RID: 56001 RVA: 0x00142867 File Offset: 0x00140A67
		// (set) Token: 0x0600DAC2 RID: 56002 RVA: 0x00142880 File Offset: 0x00140A80
		public unsafe bool bAIPerceptionSystemCompatibilityMode
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UPawnNoiseEmitterComponent.__PropertyOffset_bAIPerceptionSystemCompatibilityMode) & UPawnNoiseEmitterComponent.__PropertyMask_bAIPerceptionSystemCompatibilityMode) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UPawnNoiseEmitterComponent.__PropertyOffset_bAIPerceptionSystemCompatibilityMode) = ((*(base.NativePtr + (IntPtr)UPawnNoiseEmitterComponent.__PropertyOffset_bAIPerceptionSystemCompatibilityMode) & ~UPawnNoiseEmitterComponent.__PropertyMask_bAIPerceptionSystemCompatibilityMode) | (value ? UPawnNoiseEmitterComponent.__PropertyMask_bAIPerceptionSystemCompatibilityMode : 0));
			}
		}

		// Token: 0x1700339A RID: 13210
		// (get) Token: 0x0600DAC3 RID: 56003 RVA: 0x001428B0 File Offset: 0x00140AB0
		// (set) Token: 0x0600DAC4 RID: 56004 RVA: 0x001428C4 File Offset: 0x00140AC4
		public unsafe FVector LastRemoteNoisePosition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPawnNoiseEmitterComponent.__PropertyOffset_LastRemoteNoisePosition);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPawnNoiseEmitterComponent.__PropertyOffset_LastRemoteNoisePosition) = value;
			}
		}

		// Token: 0x1700339B RID: 13211
		// (get) Token: 0x0600DAC5 RID: 56005 RVA: 0x001428D9 File Offset: 0x00140AD9
		// (set) Token: 0x0600DAC6 RID: 56006 RVA: 0x001428E9 File Offset: 0x00140AE9
		public unsafe float NoiseLifetime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPawnNoiseEmitterComponent.__PropertyOffset_NoiseLifetime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPawnNoiseEmitterComponent.__PropertyOffset_NoiseLifetime) = value;
			}
		}

		// Token: 0x1700339C RID: 13212
		// (get) Token: 0x0600DAC7 RID: 56007 RVA: 0x001428FA File Offset: 0x00140AFA
		// (set) Token: 0x0600DAC8 RID: 56008 RVA: 0x0014290A File Offset: 0x00140B0A
		public unsafe float LastRemoteNoiseVolume
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPawnNoiseEmitterComponent.__PropertyOffset_LastRemoteNoiseVolume);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPawnNoiseEmitterComponent.__PropertyOffset_LastRemoteNoiseVolume) = value;
			}
		}

		// Token: 0x1700339D RID: 13213
		// (get) Token: 0x0600DAC9 RID: 56009 RVA: 0x0014291B File Offset: 0x00140B1B
		// (set) Token: 0x0600DACA RID: 56010 RVA: 0x0014292B File Offset: 0x00140B2B
		public unsafe float LastRemoteNoiseTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPawnNoiseEmitterComponent.__PropertyOffset_LastRemoteNoiseTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPawnNoiseEmitterComponent.__PropertyOffset_LastRemoteNoiseTime) = value;
			}
		}

		// Token: 0x1700339E RID: 13214
		// (get) Token: 0x0600DACB RID: 56011 RVA: 0x0014293C File Offset: 0x00140B3C
		// (set) Token: 0x0600DACC RID: 56012 RVA: 0x0014294C File Offset: 0x00140B4C
		public unsafe float LastLocalNoiseVolume
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPawnNoiseEmitterComponent.__PropertyOffset_LastLocalNoiseVolume);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPawnNoiseEmitterComponent.__PropertyOffset_LastLocalNoiseVolume) = value;
			}
		}

		// Token: 0x1700339F RID: 13215
		// (get) Token: 0x0600DACD RID: 56013 RVA: 0x0014295D File Offset: 0x00140B5D
		// (set) Token: 0x0600DACE RID: 56014 RVA: 0x0014296D File Offset: 0x00140B6D
		public unsafe float LastLocalNoiseTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPawnNoiseEmitterComponent.__PropertyOffset_LastLocalNoiseTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPawnNoiseEmitterComponent.__PropertyOffset_LastLocalNoiseTime) = value;
			}
		}

		// Token: 0x0600DACF RID: 56015 RVA: 0x0014297E File Offset: 0x00140B7E
		[NullableContext(2)]
		public void MakeNoise(AActor NoiseMaker, float Loudness, in FVector NoiseLocation)
		{
			UPawnNoiseEmitterComponent.__MakeNoise_Internal(base.NativePtr, (NoiseMaker != null) ? NoiseMaker.NativePtr : IntPtr.Zero, Loudness, NoiseLocation);
		}

		// Token: 0x0600DAD0 RID: 56016
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __MakeNoise_Internal(IntPtr @this, IntPtr NoiseMaker, float Loudness, in FVector NoiseLocation);

		// Token: 0x0600DAD1 RID: 56017 RVA: 0x0014299D File Offset: 0x00140B9D
		static UPawnNoiseEmitterComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.PawnNoiseEmitterComponent");
		}

		// Token: 0x0600DAD2 RID: 56018 RVA: 0x001429AB File Offset: 0x00140BAB
		protected UPawnNoiseEmitterComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04007670 RID: 30320
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.PawnNoiseEmitterComponent";

		// Token: 0x04007671 RID: 30321
		private static IntPtr _ClassPtr;

		// Token: 0x04007672 RID: 30322
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04007673 RID: 30323
		internal static int __PropertyOffset_bAIPerceptionSystemCompatibilityMode;

		// Token: 0x04007674 RID: 30324
		internal static byte __PropertyMask_bAIPerceptionSystemCompatibilityMode;

		// Token: 0x04007675 RID: 30325
		internal static int __PropertyOffset_LastRemoteNoisePosition;

		// Token: 0x04007676 RID: 30326
		internal static int __PropertyOffset_NoiseLifetime;

		// Token: 0x04007677 RID: 30327
		internal static int __PropertyOffset_LastRemoteNoiseVolume;

		// Token: 0x04007678 RID: 30328
		internal static int __PropertyOffset_LastRemoteNoiseTime;

		// Token: 0x04007679 RID: 30329
		internal static int __PropertyOffset_LastLocalNoiseVolume;

		// Token: 0x0400767A RID: 30330
		internal static int __PropertyOffset_LastLocalNoiseTime;
	}
}
