using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001BF2 RID: 7154
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroYangYangBirds")]
	[UnrealStructLayout(1232, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1232)]
	public class AKuroYangYangBirds : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601B8B1 RID: 112817 RVA: 0x00288EA3 File Offset: 0x002870A3
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AKuroYangYangBirds._ClassPtr;
		}

		// Token: 0x0601B8B2 RID: 112818 RVA: 0x00288EB0 File Offset: 0x002870B0
		public AKuroYangYangBirds() : this(BuiltinUtils.AllocNativeUObject(AKuroYangYangBirds.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601B8B3 RID: 112819 RVA: 0x00288ED8 File Offset: 0x002870D8
		public AKuroYangYangBirds(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AKuroYangYangBirds.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006EEB RID: 28395
		// (get) Token: 0x0601B8B4 RID: 112820 RVA: 0x00288F0B File Offset: 0x0028710B
		// (set) Token: 0x0601B8B5 RID: 112821 RVA: 0x00288F1F File Offset: 0x0028711F
		[Nullable(2)]
		public unsafe USceneComponent SceneRoot
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroYangYangBirds.__PropertyOffset_SceneRoot);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroYangYangBirds.__PropertyOffset_SceneRoot, value);
			}
		}

		// Token: 0x17006EEC RID: 28396
		// (get) Token: 0x0601B8B6 RID: 112822 RVA: 0x00288F34 File Offset: 0x00287134
		// (set) Token: 0x0601B8B7 RID: 112823 RVA: 0x00288F48 File Offset: 0x00287148
		[Nullable(2)]
		public unsafe UNiagaraComponent NiagaraComponent
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraComponent>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroYangYangBirds.__PropertyOffset_NiagaraComponent);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroYangYangBirds.__PropertyOffset_NiagaraComponent, value);
			}
		}

		// Token: 0x17006EED RID: 28397
		// (get) Token: 0x0601B8B8 RID: 112824 RVA: 0x00288F5D File Offset: 0x0028715D
		// (set) Token: 0x0601B8B9 RID: 112825 RVA: 0x00288F6D File Offset: 0x0028716D
		public unsafe EYangYangBirdsTendency Tendency
		{
			get
			{
				return (EYangYangBirdsTendency)(*(base.NativePtr + (IntPtr)AKuroYangYangBirds.__PropertyOffset_Tendency));
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroYangYangBirds.__PropertyOffset_Tendency) = (byte)value;
			}
		}

		// Token: 0x17006EEE RID: 28398
		// (get) Token: 0x0601B8BA RID: 112826 RVA: 0x00288F80 File Offset: 0x00287180
		// (set) Token: 0x0601B8BB RID: 112827 RVA: 0x00288FB9 File Offset: 0x002871B9
		public FKuroYangYangBirdsInterestPoint InterestPointAir
		{
			get
			{
				base.FastCheckIsValid();
				FKuroYangYangBirdsInterestPoint result;
				if ((result = this._InterestPointAir) == null)
				{
					result = (this._InterestPointAir = new FKuroYangYangBirdsInterestPoint(base.NativePtr + (IntPtr)AKuroYangYangBirds.__PropertyOffset_InterestPointAir, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroYangYangBirdsInterestPoint.StaticStruct(), base.NativePtr + (IntPtr)AKuroYangYangBirds.__PropertyOffset_InterestPointAir, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006EEF RID: 28399
		// (get) Token: 0x0601B8BC RID: 112828 RVA: 0x00288FDC File Offset: 0x002871DC
		// (set) Token: 0x0601B8BD RID: 112829 RVA: 0x00289015 File Offset: 0x00287215
		public FKuroYangYangBirdsInterestPoint InterestPointGround
		{
			get
			{
				base.FastCheckIsValid();
				FKuroYangYangBirdsInterestPoint result;
				if ((result = this._InterestPointGround) == null)
				{
					result = (this._InterestPointGround = new FKuroYangYangBirdsInterestPoint(base.NativePtr + (IntPtr)AKuroYangYangBirds.__PropertyOffset_InterestPointGround, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroYangYangBirdsInterestPoint.StaticStruct(), base.NativePtr + (IntPtr)AKuroYangYangBirds.__PropertyOffset_InterestPointGround, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006EF0 RID: 28400
		// (get) Token: 0x0601B8BE RID: 112830 RVA: 0x00289038 File Offset: 0x00287238
		// (set) Token: 0x0601B8BF RID: 112831 RVA: 0x00289071 File Offset: 0x00287271
		public FKuroYangYangBirdsFrightenPoint FrightenPoint
		{
			get
			{
				base.FastCheckIsValid();
				FKuroYangYangBirdsFrightenPoint result;
				if ((result = this._FrightenPoint) == null)
				{
					result = (this._FrightenPoint = new FKuroYangYangBirdsFrightenPoint(base.NativePtr + (IntPtr)AKuroYangYangBirds.__PropertyOffset_FrightenPoint, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroYangYangBirdsFrightenPoint.StaticStruct(), base.NativePtr + (IntPtr)AKuroYangYangBirds.__PropertyOffset_FrightenPoint, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006EF1 RID: 28401
		// (get) Token: 0x0601B8C0 RID: 112832 RVA: 0x00289092 File Offset: 0x00287292
		// (set) Token: 0x0601B8C1 RID: 112833 RVA: 0x002890A2 File Offset: 0x002872A2
		public unsafe float GroundTraceHeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroYangYangBirds.__PropertyOffset_GroundTraceHeight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroYangYangBirds.__PropertyOffset_GroundTraceHeight) = value;
			}
		}

		// Token: 0x17006EF2 RID: 28402
		// (get) Token: 0x0601B8C2 RID: 112834 RVA: 0x002890B3 File Offset: 0x002872B3
		// (set) Token: 0x0601B8C3 RID: 112835 RVA: 0x002890C3 File Offset: 0x002872C3
		public unsafe float GroundTraceLower
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroYangYangBirds.__PropertyOffset_GroundTraceLower);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroYangYangBirds.__PropertyOffset_GroundTraceLower) = value;
			}
		}

		// Token: 0x17006EF3 RID: 28403
		// (get) Token: 0x0601B8C4 RID: 112836 RVA: 0x002890D4 File Offset: 0x002872D4
		// (set) Token: 0x0601B8C5 RID: 112837 RVA: 0x002890E4 File Offset: 0x002872E4
		public unsafe float GroundTraceHeightTolerance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroYangYangBirds.__PropertyOffset_GroundTraceHeightTolerance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroYangYangBirds.__PropertyOffset_GroundTraceHeightTolerance) = value;
			}
		}

		// Token: 0x17006EF4 RID: 28404
		// (get) Token: 0x0601B8C6 RID: 112838 RVA: 0x002890F5 File Offset: 0x002872F5
		// (set) Token: 0x0601B8C7 RID: 112839 RVA: 0x00289105 File Offset: 0x00287305
		public unsafe float GroundTraceNormalZTolerance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroYangYangBirds.__PropertyOffset_GroundTraceNormalZTolerance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroYangYangBirds.__PropertyOffset_GroundTraceNormalZTolerance) = value;
			}
		}

		// Token: 0x17006EF5 RID: 28405
		// (get) Token: 0x0601B8C8 RID: 112840 RVA: 0x00289116 File Offset: 0x00287316
		// (set) Token: 0x0601B8C9 RID: 112841 RVA: 0x00289126 File Offset: 0x00287326
		public unsafe float AirInterestOffsetZ
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroYangYangBirds.__PropertyOffset_AirInterestOffsetZ);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroYangYangBirds.__PropertyOffset_AirInterestOffsetZ) = value;
			}
		}

		// Token: 0x17006EF6 RID: 28406
		// (get) Token: 0x0601B8CA RID: 112842 RVA: 0x00289137 File Offset: 0x00287337
		// (set) Token: 0x0601B8CB RID: 112843 RVA: 0x00289147 File Offset: 0x00287347
		public unsafe float AirSampleRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroYangYangBirds.__PropertyOffset_AirSampleRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroYangYangBirds.__PropertyOffset_AirSampleRadius) = value;
			}
		}

		// Token: 0x17006EF7 RID: 28407
		// (get) Token: 0x0601B8CC RID: 112844 RVA: 0x00289158 File Offset: 0x00287358
		// (set) Token: 0x0601B8CD RID: 112845 RVA: 0x00289168 File Offset: 0x00287368
		public unsafe float AirInterestRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroYangYangBirds.__PropertyOffset_AirInterestRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroYangYangBirds.__PropertyOffset_AirInterestRadius) = value;
			}
		}

		// Token: 0x17006EF8 RID: 28408
		// (get) Token: 0x0601B8CE RID: 112846 RVA: 0x00289179 File Offset: 0x00287379
		// (set) Token: 0x0601B8CF RID: 112847 RVA: 0x00289189 File Offset: 0x00287389
		public unsafe float AirRetryCooldown
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroYangYangBirds.__PropertyOffset_AirRetryCooldown);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroYangYangBirds.__PropertyOffset_AirRetryCooldown) = value;
			}
		}

		// Token: 0x17006EF9 RID: 28409
		// (get) Token: 0x0601B8D0 RID: 112848 RVA: 0x0028919A File Offset: 0x0028739A
		// (set) Token: 0x0601B8D1 RID: 112849 RVA: 0x002891AA File Offset: 0x002873AA
		public unsafe int AirMaxAttempts
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroYangYangBirds.__PropertyOffset_AirMaxAttempts);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroYangYangBirds.__PropertyOffset_AirMaxAttempts) = value;
			}
		}

		// Token: 0x17006EFA RID: 28410
		// (get) Token: 0x0601B8D2 RID: 112850 RVA: 0x002891BB File Offset: 0x002873BB
		// (set) Token: 0x0601B8D3 RID: 112851 RVA: 0x002891CB File Offset: 0x002873CB
		public unsafe float GroundInterestRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroYangYangBirds.__PropertyOffset_GroundInterestRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroYangYangBirds.__PropertyOffset_GroundInterestRadius) = value;
			}
		}

		// Token: 0x17006EFB RID: 28411
		// (get) Token: 0x0601B8D4 RID: 112852 RVA: 0x002891DC File Offset: 0x002873DC
		// (set) Token: 0x0601B8D5 RID: 112853 RVA: 0x002891EC File Offset: 0x002873EC
		public unsafe float GroundSampleRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroYangYangBirds.__PropertyOffset_GroundSampleRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroYangYangBirds.__PropertyOffset_GroundSampleRadius) = value;
			}
		}

		// Token: 0x17006EFC RID: 28412
		// (get) Token: 0x0601B8D6 RID: 112854 RVA: 0x002891FD File Offset: 0x002873FD
		// (set) Token: 0x0601B8D7 RID: 112855 RVA: 0x0028920D File Offset: 0x0028740D
		public unsafe float GroundRetryCooldown
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroYangYangBirds.__PropertyOffset_GroundRetryCooldown);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroYangYangBirds.__PropertyOffset_GroundRetryCooldown) = value;
			}
		}

		// Token: 0x17006EFD RID: 28413
		// (get) Token: 0x0601B8D8 RID: 112856 RVA: 0x0028921E File Offset: 0x0028741E
		// (set) Token: 0x0601B8D9 RID: 112857 RVA: 0x0028922E File Offset: 0x0028742E
		public unsafe int GroundMaxAttempts
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroYangYangBirds.__PropertyOffset_GroundMaxAttempts);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroYangYangBirds.__PropertyOffset_GroundMaxAttempts) = value;
			}
		}

		// Token: 0x17006EFE RID: 28414
		// (get) Token: 0x0601B8DA RID: 112858 RVA: 0x0028923F File Offset: 0x0028743F
		// (set) Token: 0x0601B8DB RID: 112859 RVA: 0x0028924F File Offset: 0x0028744F
		public unsafe bool NiagaraParametersPendingUpdate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroYangYangBirds.__PropertyOffset_NiagaraParametersPendingUpdate) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroYangYangBirds.__PropertyOffset_NiagaraParametersPendingUpdate) = (value ? 1 : 0);
			}
		}

		// Token: 0x0601B8DC RID: 112860 RVA: 0x00289260 File Offset: 0x00287460
		public virtual void UpdateInterestPointGround()
		{
			AKuroYangYangBirds.__UpdateInterestPointGround_Internal(base.NativePtr);
		}

		// Token: 0x0601B8DD RID: 112861 RVA: 0x0028926D File Offset: 0x0028746D
		public virtual void UpdateInterestPointAir()
		{
			AKuroYangYangBirds.__UpdateInterestPointAir_Internal(base.NativePtr);
		}

		// Token: 0x0601B8DE RID: 112862 RVA: 0x0028927A File Offset: 0x0028747A
		public virtual bool ShouldTakeOff()
		{
			return AKuroYangYangBirds.__ShouldTakeOff_Internal(base.NativePtr);
		}

		// Token: 0x0601B8DF RID: 112863 RVA: 0x00289287 File Offset: 0x00287487
		protected virtual bool ShouldTakeOff_Implementation()
		{
			return AKuroYangYangBirds.__ShouldTakeOff_Implementation_Internal(base.NativePtr);
		}

		// Token: 0x0601B8E0 RID: 112864 RVA: 0x00289294 File Offset: 0x00287494
		public virtual bool ShouldLand()
		{
			return AKuroYangYangBirds.__ShouldLand_Internal(base.NativePtr);
		}

		// Token: 0x0601B8E1 RID: 112865 RVA: 0x002892A1 File Offset: 0x002874A1
		protected virtual bool ShouldLand_Implementation()
		{
			return AKuroYangYangBirds.__ShouldLand_Implementation_Internal(base.NativePtr);
		}

		// Token: 0x0601B8E2 RID: 112866 RVA: 0x002892AE File Offset: 0x002874AE
		public virtual bool ShouldDisappear()
		{
			return AKuroYangYangBirds.__ShouldDisappear_Internal(base.NativePtr);
		}

		// Token: 0x0601B8E3 RID: 112867 RVA: 0x002892BB File Offset: 0x002874BB
		protected virtual bool ShouldDisappear_Implementation()
		{
			return AKuroYangYangBirds.__ShouldDisappear_Implementation_Internal(base.NativePtr);
		}

		// Token: 0x0601B8E4 RID: 112868 RVA: 0x002892C8 File Offset: 0x002874C8
		public virtual bool ShouldAppear()
		{
			return AKuroYangYangBirds.__ShouldAppear_Internal(base.NativePtr);
		}

		// Token: 0x0601B8E5 RID: 112869 RVA: 0x002892D5 File Offset: 0x002874D5
		protected virtual bool ShouldAppear_Implementation()
		{
			return AKuroYangYangBirds.__ShouldAppear_Implementation_Internal(base.NativePtr);
		}

		// Token: 0x0601B8E6 RID: 112870 RVA: 0x002892E2 File Offset: 0x002874E2
		public void ResetState()
		{
			AKuroYangYangBirds.__ResetState_Internal(base.NativePtr);
		}

		// Token: 0x0601B8E7 RID: 112871 RVA: 0x002892EF File Offset: 0x002874EF
		public virtual void ReceiveUpdateNiagaraParameters()
		{
			AKuroYangYangBirds.__ReceiveUpdateNiagaraParameters_Internal(base.NativePtr);
		}

		// Token: 0x0601B8E8 RID: 112872 RVA: 0x002892FC File Offset: 0x002874FC
		public virtual void ReceiveResetState()
		{
			AKuroYangYangBirds.__ReceiveResetState_Internal(base.NativePtr);
		}

		// Token: 0x0601B8E9 RID: 112873 RVA: 0x00289309 File Offset: 0x00287509
		public virtual void ReceiveBirdsTakeOff()
		{
			AKuroYangYangBirds.__ReceiveBirdsTakeOff_Internal(base.NativePtr);
		}

		// Token: 0x0601B8EA RID: 112874 RVA: 0x00289316 File Offset: 0x00287516
		public virtual void ReceiveBirdsLand()
		{
			AKuroYangYangBirds.__ReceiveBirdsLand_Internal(base.NativePtr);
		}

		// Token: 0x0601B8EB RID: 112875 RVA: 0x00289323 File Offset: 0x00287523
		public virtual void ReceiveBirdsFail(EYangYangBirdsTendency FailedTendency)
		{
			AKuroYangYangBirds.__ReceiveBirdsFail_Internal(base.NativePtr, FailedTendency);
		}

		// Token: 0x0601B8EC RID: 112876 RVA: 0x00289331 File Offset: 0x00287531
		public virtual void ReceiveBirdsDisappear()
		{
			AKuroYangYangBirds.__ReceiveBirdsDisappear_Internal(base.NativePtr);
		}

		// Token: 0x0601B8ED RID: 112877 RVA: 0x0028933E File Offset: 0x0028753E
		public virtual void ReceiveBirdsAppear()
		{
			AKuroYangYangBirds.__ReceiveBirdsAppear_Internal(base.NativePtr);
		}

		// Token: 0x0601B8EE RID: 112878
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UpdateInterestPointGround_Internal(IntPtr @this);

		// Token: 0x0601B8EF RID: 112879
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UpdateInterestPointAir_Internal(IntPtr @this);

		// Token: 0x0601B8F0 RID: 112880
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __ShouldTakeOff_Internal(IntPtr @this);

		// Token: 0x0601B8F1 RID: 112881
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __ShouldTakeOff_Implementation_Internal(IntPtr @this);

		// Token: 0x0601B8F2 RID: 112882
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __ShouldLand_Internal(IntPtr @this);

		// Token: 0x0601B8F3 RID: 112883
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __ShouldLand_Implementation_Internal(IntPtr @this);

		// Token: 0x0601B8F4 RID: 112884
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __ShouldDisappear_Internal(IntPtr @this);

		// Token: 0x0601B8F5 RID: 112885
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __ShouldDisappear_Implementation_Internal(IntPtr @this);

		// Token: 0x0601B8F6 RID: 112886
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __ShouldAppear_Internal(IntPtr @this);

		// Token: 0x0601B8F7 RID: 112887
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __ShouldAppear_Implementation_Internal(IntPtr @this);

		// Token: 0x0601B8F8 RID: 112888
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ResetState_Internal(IntPtr @this);

		// Token: 0x0601B8F9 RID: 112889
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ReceiveUpdateNiagaraParameters_Internal(IntPtr @this);

		// Token: 0x0601B8FA RID: 112890
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ReceiveResetState_Internal(IntPtr @this);

		// Token: 0x0601B8FB RID: 112891
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ReceiveBirdsTakeOff_Internal(IntPtr @this);

		// Token: 0x0601B8FC RID: 112892
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ReceiveBirdsLand_Internal(IntPtr @this);

		// Token: 0x0601B8FD RID: 112893
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ReceiveBirdsFail_Internal(IntPtr @this, EYangYangBirdsTendency FailedTendency);

		// Token: 0x0601B8FE RID: 112894
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ReceiveBirdsDisappear_Internal(IntPtr @this);

		// Token: 0x0601B8FF RID: 112895
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ReceiveBirdsAppear_Internal(IntPtr @this);

		// Token: 0x0601B900 RID: 112896 RVA: 0x0028934B File Offset: 0x0028754B
		static AKuroYangYangBirds()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroYangYangBirds");
		}

		// Token: 0x0601B901 RID: 112897 RVA: 0x00289359 File Offset: 0x00287559
		protected AKuroYangYangBirds(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400ED1D RID: 60701
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroYangYangBirds";

		// Token: 0x0400ED1E RID: 60702
		private static IntPtr _ClassPtr;

		// Token: 0x0400ED1F RID: 60703
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400ED20 RID: 60704
		internal static int __PropertyOffset_SceneRoot;

		// Token: 0x0400ED21 RID: 60705
		internal static int __PropertyOffset_NiagaraComponent;

		// Token: 0x0400ED22 RID: 60706
		internal static int __PropertyOffset_Tendency;

		// Token: 0x0400ED23 RID: 60707
		internal static int __PropertyOffset_InterestPointAir;

		// Token: 0x0400ED24 RID: 60708
		[Nullable(2)]
		private FKuroYangYangBirdsInterestPoint _InterestPointAir;

		// Token: 0x0400ED25 RID: 60709
		internal static int __PropertyOffset_InterestPointGround;

		// Token: 0x0400ED26 RID: 60710
		[Nullable(2)]
		private FKuroYangYangBirdsInterestPoint _InterestPointGround;

		// Token: 0x0400ED27 RID: 60711
		internal static int __PropertyOffset_FrightenPoint;

		// Token: 0x0400ED28 RID: 60712
		[Nullable(2)]
		private FKuroYangYangBirdsFrightenPoint _FrightenPoint;

		// Token: 0x0400ED29 RID: 60713
		internal static int __PropertyOffset_GroundTraceHeight;

		// Token: 0x0400ED2A RID: 60714
		internal static int __PropertyOffset_GroundTraceLower;

		// Token: 0x0400ED2B RID: 60715
		internal static int __PropertyOffset_GroundTraceHeightTolerance;

		// Token: 0x0400ED2C RID: 60716
		internal static int __PropertyOffset_GroundTraceNormalZTolerance;

		// Token: 0x0400ED2D RID: 60717
		internal static int __PropertyOffset_AirInterestOffsetZ;

		// Token: 0x0400ED2E RID: 60718
		internal static int __PropertyOffset_AirSampleRadius;

		// Token: 0x0400ED2F RID: 60719
		internal static int __PropertyOffset_AirInterestRadius;

		// Token: 0x0400ED30 RID: 60720
		internal static int __PropertyOffset_AirRetryCooldown;

		// Token: 0x0400ED31 RID: 60721
		internal static int __PropertyOffset_AirMaxAttempts;

		// Token: 0x0400ED32 RID: 60722
		internal static int __PropertyOffset_GroundInterestRadius;

		// Token: 0x0400ED33 RID: 60723
		internal static int __PropertyOffset_GroundSampleRadius;

		// Token: 0x0400ED34 RID: 60724
		internal static int __PropertyOffset_GroundRetryCooldown;

		// Token: 0x0400ED35 RID: 60725
		internal static int __PropertyOffset_GroundMaxAttempts;

		// Token: 0x0400ED36 RID: 60726
		internal static int __PropertyOffset_NiagaraParametersPendingUpdate;

		// Token: 0x0200318B RID: 12683
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __ShouldTakeOff_FunctionParams
		{
			// Token: 0x04016FC9 RID: 94153
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x0200318C RID: 12684
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __ShouldLand_FunctionParams
		{
			// Token: 0x04016FCA RID: 94154
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x0200318D RID: 12685
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __ShouldDisappear_FunctionParams
		{
			// Token: 0x04016FCB RID: 94155
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x0200318E RID: 12686
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __ShouldAppear_FunctionParams
		{
			// Token: 0x04016FCC RID: 94156
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x0200318F RID: 12687
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __ReceiveBirdsFail_FunctionParams
		{
			// Token: 0x04016FCD RID: 94157
			[FieldOffset(0)]
			public EYangYangBirdsTendency FailedTendency;
		}
	}
}
