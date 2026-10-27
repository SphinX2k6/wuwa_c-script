using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001B15 RID: 6933
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroGPUParticleComponent")]
	[UnrealStructLayout(2256, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2256)]
	public class UKuroGPUParticleComponent : UStaticMeshComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601A141 RID: 106817 RVA: 0x00267E24 File Offset: 0x00266024
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroGPUParticleComponent._ClassPtr;
		}

		// Token: 0x0601A142 RID: 106818 RVA: 0x00267E30 File Offset: 0x00266030
		public UKuroGPUParticleComponent() : this(BuiltinUtils.AllocNativeUObject(UKuroGPUParticleComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601A143 RID: 106819 RVA: 0x00267E58 File Offset: 0x00266058
		public UKuroGPUParticleComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroGPUParticleComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170068AD RID: 26797
		// (get) Token: 0x0601A144 RID: 106820 RVA: 0x00267E8B File Offset: 0x0026608B
		// (set) Token: 0x0601A145 RID: 106821 RVA: 0x00267E9F File Offset: 0x0026609F
		[Nullable(2)]
		public unsafe UKuroGPUParticleDA GPUParticleDataAsset
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroGPUParticleDA>(base.NativePtr / (IntPtr)sizeof(void*) + UKuroGPUParticleComponent.__PropertyOffset_GPUParticleDataAsset);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKuroGPUParticleComponent.__PropertyOffset_GPUParticleDataAsset, value);
			}
		}

		// Token: 0x170068AE RID: 26798
		// (get) Token: 0x0601A146 RID: 106822 RVA: 0x00267EB4 File Offset: 0x002660B4
		// (set) Token: 0x0601A147 RID: 106823 RVA: 0x00267EC4 File Offset: 0x002660C4
		public unsafe bool ClickReplay
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroGPUParticleComponent.__PropertyOffset_ClickReplay) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroGPUParticleComponent.__PropertyOffset_ClickReplay) = (value ? 1 : 0);
			}
		}

		// Token: 0x170068AF RID: 26799
		// (get) Token: 0x0601A148 RID: 106824 RVA: 0x00267ED5 File Offset: 0x002660D5
		// (set) Token: 0x0601A149 RID: 106825 RVA: 0x00267EE5 File Offset: 0x002660E5
		public unsafe bool StopAtFinalFrame
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroGPUParticleComponent.__PropertyOffset_StopAtFinalFrame) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroGPUParticleComponent.__PropertyOffset_StopAtFinalFrame) = (value ? 1 : 0);
			}
		}

		// Token: 0x170068B0 RID: 26800
		// (get) Token: 0x0601A14A RID: 106826 RVA: 0x00267EF6 File Offset: 0x002660F6
		// (set) Token: 0x0601A14B RID: 106827 RVA: 0x00267F06 File Offset: 0x00266106
		public unsafe bool AutoUpdate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroGPUParticleComponent.__PropertyOffset_AutoUpdate) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroGPUParticleComponent.__PropertyOffset_AutoUpdate) = (value ? 1 : 0);
			}
		}

		// Token: 0x170068B1 RID: 26801
		// (get) Token: 0x0601A14C RID: 106828 RVA: 0x00267F17 File Offset: 0x00266117
		// (set) Token: 0x0601A14D RID: 106829 RVA: 0x00267F27 File Offset: 0x00266127
		public unsafe int SimulateFramerate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroGPUParticleComponent.__PropertyOffset_SimulateFramerate);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroGPUParticleComponent.__PropertyOffset_SimulateFramerate) = value;
			}
		}

		// Token: 0x170068B2 RID: 26802
		// (get) Token: 0x0601A14E RID: 106830 RVA: 0x00267F38 File Offset: 0x00266138
		// (set) Token: 0x0601A14F RID: 106831 RVA: 0x00267F48 File Offset: 0x00266148
		public unsafe bool Loop
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroGPUParticleComponent.__PropertyOffset_Loop) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroGPUParticleComponent.__PropertyOffset_Loop) = (value ? 1 : 0);
			}
		}

		// Token: 0x170068B3 RID: 26803
		// (get) Token: 0x0601A150 RID: 106832 RVA: 0x00267F59 File Offset: 0x00266159
		// (set) Token: 0x0601A151 RID: 106833 RVA: 0x00267F69 File Offset: 0x00266169
		public unsafe bool Reverse
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroGPUParticleComponent.__PropertyOffset_Reverse) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroGPUParticleComponent.__PropertyOffset_Reverse) = (value ? 1 : 0);
			}
		}

		// Token: 0x170068B4 RID: 26804
		// (get) Token: 0x0601A152 RID: 106834 RVA: 0x00267F7A File Offset: 0x0026617A
		// (set) Token: 0x0601A153 RID: 106835 RVA: 0x00267F8A File Offset: 0x0026618A
		public unsafe float LoopIntervalTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroGPUParticleComponent.__PropertyOffset_LoopIntervalTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroGPUParticleComponent.__PropertyOffset_LoopIntervalTime) = value;
			}
		}

		// Token: 0x170068B5 RID: 26805
		// (get) Token: 0x0601A154 RID: 106836 RVA: 0x00267F9B File Offset: 0x0026619B
		// (set) Token: 0x0601A155 RID: 106837 RVA: 0x00267FAB File Offset: 0x002661AB
		public unsafe int SkipFrameCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroGPUParticleComponent.__PropertyOffset_SkipFrameCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroGPUParticleComponent.__PropertyOffset_SkipFrameCount) = value;
			}
		}

		// Token: 0x170068B6 RID: 26806
		// (get) Token: 0x0601A156 RID: 106838 RVA: 0x00267FBC File Offset: 0x002661BC
		// (set) Token: 0x0601A157 RID: 106839 RVA: 0x00267FCC File Offset: 0x002661CC
		public unsafe float StartWaitTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroGPUParticleComponent.__PropertyOffset_StartWaitTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroGPUParticleComponent.__PropertyOffset_StartWaitTime) = value;
			}
		}

		// Token: 0x170068B7 RID: 26807
		// (get) Token: 0x0601A158 RID: 106840 RVA: 0x00267FDD File Offset: 0x002661DD
		// (set) Token: 0x0601A159 RID: 106841 RVA: 0x00267FED File Offset: 0x002661ED
		public unsafe bool UseCustomTimeScaleCurve
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroGPUParticleComponent.__PropertyOffset_UseCustomTimeScaleCurve) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroGPUParticleComponent.__PropertyOffset_UseCustomTimeScaleCurve) = (value ? 1 : 0);
			}
		}

		// Token: 0x170068B8 RID: 26808
		// (get) Token: 0x0601A15A RID: 106842 RVA: 0x00267FFE File Offset: 0x002661FE
		// (set) Token: 0x0601A15B RID: 106843 RVA: 0x0026800E File Offset: 0x0026620E
		public unsafe bool EnablePingPong
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroGPUParticleComponent.__PropertyOffset_EnablePingPong) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroGPUParticleComponent.__PropertyOffset_EnablePingPong) = (value ? 1 : 0);
			}
		}

		// Token: 0x170068B9 RID: 26809
		// (get) Token: 0x0601A15C RID: 106844 RVA: 0x0026801F File Offset: 0x0026621F
		// (set) Token: 0x0601A15D RID: 106845 RVA: 0x0026802F File Offset: 0x0026622F
		public unsafe int PingPongTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroGPUParticleComponent.__PropertyOffset_PingPongTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroGPUParticleComponent.__PropertyOffset_PingPongTime) = value;
			}
		}

		// Token: 0x170068BA RID: 26810
		// (get) Token: 0x0601A15E RID: 106846 RVA: 0x00268040 File Offset: 0x00266240
		// (set) Token: 0x0601A15F RID: 106847 RVA: 0x00268079 File Offset: 0x00266279
		public FKuroCurveFloat CustomTimeScaleCurve
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._CustomTimeScaleCurve) == null)
				{
					result = (this._CustomTimeScaleCurve = new FKuroCurveFloat(base.NativePtr + (IntPtr)UKuroGPUParticleComponent.__PropertyOffset_CustomTimeScaleCurve, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)UKuroGPUParticleComponent.__PropertyOffset_CustomTimeScaleCurve, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0601A160 RID: 106848 RVA: 0x0026809A File Offset: 0x0026629A
		public void SetupParticle(float DeltaTime)
		{
			UKuroGPUParticleComponent.__SetupParticle_Internal(base.NativePtr, DeltaTime);
		}

		// Token: 0x0601A161 RID: 106849 RVA: 0x002680A8 File Offset: 0x002662A8
		[NullableContext(2)]
		public void SetGPUData(UKuroGPUParticleDA TargetData)
		{
			UKuroGPUParticleComponent.__SetGPUData_Internal(base.NativePtr, (TargetData != null) ? TargetData.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601A162 RID: 106850 RVA: 0x002680C5 File Offset: 0x002662C5
		public void ResetParticle()
		{
			UKuroGPUParticleComponent.__ResetParticle_Internal(base.NativePtr);
		}

		// Token: 0x0601A163 RID: 106851 RVA: 0x002680D2 File Offset: 0x002662D2
		public void DoTick(float DeltaTime)
		{
			UKuroGPUParticleComponent.__DoTick_Internal(base.NativePtr, DeltaTime);
		}

		// Token: 0x0601A164 RID: 106852
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetupParticle_Internal(IntPtr @this, float DeltaTime);

		// Token: 0x0601A165 RID: 106853
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetGPUData_Internal(IntPtr @this, IntPtr TargetData);

		// Token: 0x0601A166 RID: 106854
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ResetParticle_Internal(IntPtr @this);

		// Token: 0x0601A167 RID: 106855
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __DoTick_Internal(IntPtr @this, float DeltaTime);

		// Token: 0x0601A168 RID: 106856 RVA: 0x002680E0 File Offset: 0x002662E0
		static UKuroGPUParticleComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroGPUParticleComponent");
		}

		// Token: 0x0601A169 RID: 106857 RVA: 0x002680EE File Offset: 0x002662EE
		protected UKuroGPUParticleComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400E295 RID: 58005
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroGPUParticleComponent";

		// Token: 0x0400E296 RID: 58006
		private static IntPtr _ClassPtr;

		// Token: 0x0400E297 RID: 58007
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400E298 RID: 58008
		internal static int __PropertyOffset_GPUParticleDataAsset;

		// Token: 0x0400E299 RID: 58009
		internal static int __PropertyOffset_ClickReplay;

		// Token: 0x0400E29A RID: 58010
		internal static int __PropertyOffset_StopAtFinalFrame;

		// Token: 0x0400E29B RID: 58011
		internal static int __PropertyOffset_AutoUpdate;

		// Token: 0x0400E29C RID: 58012
		internal static int __PropertyOffset_SimulateFramerate;

		// Token: 0x0400E29D RID: 58013
		internal static int __PropertyOffset_Loop;

		// Token: 0x0400E29E RID: 58014
		internal static int __PropertyOffset_Reverse;

		// Token: 0x0400E29F RID: 58015
		internal static int __PropertyOffset_LoopIntervalTime;

		// Token: 0x0400E2A0 RID: 58016
		internal static int __PropertyOffset_SkipFrameCount;

		// Token: 0x0400E2A1 RID: 58017
		internal static int __PropertyOffset_StartWaitTime;

		// Token: 0x0400E2A2 RID: 58018
		internal static int __PropertyOffset_UseCustomTimeScaleCurve;

		// Token: 0x0400E2A3 RID: 58019
		internal static int __PropertyOffset_EnablePingPong;

		// Token: 0x0400E2A4 RID: 58020
		internal static int __PropertyOffset_PingPongTime;

		// Token: 0x0400E2A5 RID: 58021
		internal static int __PropertyOffset_CustomTimeScaleCurve;

		// Token: 0x0400E2A6 RID: 58022
		[Nullable(2)]
		private FKuroCurveFloat _CustomTimeScaleCurve;
	}
}
