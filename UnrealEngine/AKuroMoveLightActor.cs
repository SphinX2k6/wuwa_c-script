using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001B77 RID: 7031
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroMoveLightActor")]
	[UnrealStructLayout(1520, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1520)]
	public class AKuroMoveLightActor : AKuroGameBudgetBlueprintActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601AA2B RID: 109099 RVA: 0x00274445 File Offset: 0x00272645
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AKuroMoveLightActor._ClassPtr;
		}

		// Token: 0x0601AA2C RID: 109100 RVA: 0x00274454 File Offset: 0x00272654
		public AKuroMoveLightActor() : this(BuiltinUtils.AllocNativeUObject(AKuroMoveLightActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601AA2D RID: 109101 RVA: 0x0027447C File Offset: 0x0027267C
		public AKuroMoveLightActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AKuroMoveLightActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006B03 RID: 27395
		// (get) Token: 0x0601AA2E RID: 109102 RVA: 0x002744AF File Offset: 0x002726AF
		// (set) Token: 0x0601AA2F RID: 109103 RVA: 0x002744BF File Offset: 0x002726BF
		public unsafe int PointComponentCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroMoveLightActor.__PropertyOffset_PointComponentCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroMoveLightActor.__PropertyOffset_PointComponentCount) = value;
			}
		}

		// Token: 0x17006B04 RID: 27396
		// (get) Token: 0x0601AA30 RID: 109104 RVA: 0x002744D0 File Offset: 0x002726D0
		// (set) Token: 0x0601AA31 RID: 109105 RVA: 0x002744E0 File Offset: 0x002726E0
		public unsafe bool bApplySplinePositionSample
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroMoveLightActor.__PropertyOffset_bApplySplinePositionSample) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroMoveLightActor.__PropertyOffset_bApplySplinePositionSample) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006B05 RID: 27397
		// (get) Token: 0x0601AA32 RID: 109106 RVA: 0x002744F4 File Offset: 0x002726F4
		// (set) Token: 0x0601AA33 RID: 109107 RVA: 0x0027452D File Offset: 0x0027272D
		public TArray<FPointLightData> PointLightDataArray
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FPointLightData> result;
				if ((result = this._PointLightDataArray) == null)
				{
					result = (this._PointLightDataArray = new TArray<FPointLightData>(base.NativePtr + (IntPtr)AKuroMoveLightActor.__PropertyOffset_PointLightDataArray, this));
				}
				return result;
			}
			set
			{
				this.PointLightDataArray.CopyAssign(value);
			}
		}

		// Token: 0x17006B06 RID: 27398
		// (get) Token: 0x0601AA34 RID: 109108 RVA: 0x0027453B File Offset: 0x0027273B
		// (set) Token: 0x0601AA35 RID: 109109 RVA: 0x0027454B File Offset: 0x0027274B
		public unsafe bool bUseGlobalTick
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroMoveLightActor.__PropertyOffset_bUseGlobalTick) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroMoveLightActor.__PropertyOffset_bUseGlobalTick) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006B07 RID: 27399
		// (get) Token: 0x0601AA36 RID: 109110 RVA: 0x0027455C File Offset: 0x0027275C
		// (set) Token: 0x0601AA37 RID: 109111 RVA: 0x0027456C File Offset: 0x0027276C
		public unsafe float GlobalTickFactor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroMoveLightActor.__PropertyOffset_GlobalTickFactor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroMoveLightActor.__PropertyOffset_GlobalTickFactor) = value;
			}
		}

		// Token: 0x17006B08 RID: 27400
		// (get) Token: 0x0601AA38 RID: 109112 RVA: 0x0027457D File Offset: 0x0027277D
		// (set) Token: 0x0601AA39 RID: 109113 RVA: 0x0027458D File Offset: 0x0027278D
		public unsafe ESplineShareMode SplineShareMode
		{
			get
			{
				return (ESplineShareMode)(*(base.NativePtr + (IntPtr)AKuroMoveLightActor.__PropertyOffset_SplineShareMode));
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroMoveLightActor.__PropertyOffset_SplineShareMode) = (byte)value;
			}
		}

		// Token: 0x17006B09 RID: 27401
		// (get) Token: 0x0601AA3A RID: 109114 RVA: 0x0027459E File Offset: 0x0027279E
		// (set) Token: 0x0601AA3B RID: 109115 RVA: 0x002745B2 File Offset: 0x002727B2
		[Nullable(2)]
		public unsafe USplineComponent ExternalSharedSpline
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USplineComponent>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroMoveLightActor.__PropertyOffset_ExternalSharedSpline);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroMoveLightActor.__PropertyOffset_ExternalSharedSpline, value);
			}
		}

		// Token: 0x17006B0A RID: 27402
		// (get) Token: 0x0601AA3C RID: 109116 RVA: 0x002745C7 File Offset: 0x002727C7
		// (set) Token: 0x0601AA3D RID: 109117 RVA: 0x002745DB File Offset: 0x002727DB
		[Nullable(2)]
		public unsafe USceneComponent RootScene
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroMoveLightActor.__PropertyOffset_RootScene);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroMoveLightActor.__PropertyOffset_RootScene, value);
			}
		}

		// Token: 0x17006B0B RID: 27403
		// (get) Token: 0x0601AA3E RID: 109118 RVA: 0x002745F0 File Offset: 0x002727F0
		// (set) Token: 0x0601AA3F RID: 109119 RVA: 0x00274629 File Offset: 0x00272829
		public TArray<UPointLightComponent> PointComponents
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UPointLightComponent> result;
				if ((result = this._PointComponents) == null)
				{
					result = (this._PointComponents = new TArray<UPointLightComponent>(base.NativePtr + (IntPtr)AKuroMoveLightActor.__PropertyOffset_PointComponents, this));
				}
				return result;
			}
			set
			{
				this.PointComponents.CopyAssign(value);
			}
		}

		// Token: 0x17006B0C RID: 27404
		// (get) Token: 0x0601AA40 RID: 109120 RVA: 0x00274638 File Offset: 0x00272838
		// (set) Token: 0x0601AA41 RID: 109121 RVA: 0x00274671 File Offset: 0x00272871
		public TArray<USplineComponent> SplineComponents
		{
			get
			{
				base.FastCheckIsValid();
				TArray<USplineComponent> result;
				if ((result = this._SplineComponents) == null)
				{
					result = (this._SplineComponents = new TArray<USplineComponent>(base.NativePtr + (IntPtr)AKuroMoveLightActor.__PropertyOffset_SplineComponents, this));
				}
				return result;
			}
			set
			{
				this.SplineComponents.CopyAssign(value);
			}
		}

		// Token: 0x0601AA42 RID: 109122 RVA: 0x0027467F File Offset: 0x0027287F
		public void UpdateLight()
		{
			AKuroMoveLightActor.__UpdateLight_Internal(base.NativePtr);
		}

		// Token: 0x0601AA43 RID: 109123 RVA: 0x0027468C File Offset: 0x0027288C
		public virtual void SampleSpline2PointPositionForIndex(int Index, float DeltaTime)
		{
			AKuroMoveLightActor.__SampleSpline2PointPositionForIndex_Internal(base.NativePtr, Index, DeltaTime);
		}

		// Token: 0x0601AA44 RID: 109124 RVA: 0x0027469B File Offset: 0x0027289B
		protected virtual void SampleSpline2PointPositionForIndex_Implementation(int Index, float DeltaTime)
		{
			AKuroMoveLightActor.__SampleSpline2PointPositionForIndex_Implementation_Internal(base.NativePtr, Index, DeltaTime);
		}

		// Token: 0x0601AA45 RID: 109125 RVA: 0x002746AA File Offset: 0x002728AA
		public virtual void InitSplineByCurveForIndex(int Index)
		{
			AKuroMoveLightActor.__InitSplineByCurveForIndex_Internal(base.NativePtr, Index);
		}

		// Token: 0x0601AA46 RID: 109126 RVA: 0x002746B8 File Offset: 0x002728B8
		protected virtual void InitSplineByCurveForIndex_Implementation(int Index)
		{
			AKuroMoveLightActor.__InitSplineByCurveForIndex_Implementation_Internal(base.NativePtr, Index);
		}

		// Token: 0x0601AA47 RID: 109127 RVA: 0x002746C6 File Offset: 0x002728C6
		public virtual void InitSplineByCurve()
		{
			AKuroMoveLightActor.__InitSplineByCurve_Internal(base.NativePtr);
		}

		// Token: 0x0601AA48 RID: 109128 RVA: 0x002746D3 File Offset: 0x002728D3
		protected virtual void InitSplineByCurve_Implementation()
		{
			AKuroMoveLightActor.__InitSplineByCurve_Implementation_Internal(base.NativePtr);
		}

		// Token: 0x0601AA49 RID: 109129 RVA: 0x002746E0 File Offset: 0x002728E0
		[NullableContext(2)]
		public USplineComponent GetSplineForIndex(int Index)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<USplineComponent>(AKuroMoveLightActor.__GetSplineForIndex_Internal(base.NativePtr, Index));
		}

		// Token: 0x0601AA4A RID: 109130 RVA: 0x002746F3 File Offset: 0x002728F3
		[NullableContext(2)]
		public virtual void ForeachPointLight(UPointLightComponent PointLightComponent)
		{
			AKuroMoveLightActor.__ForeachPointLight_Internal(base.NativePtr, (PointLightComponent != null) ? PointLightComponent.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601AA4B RID: 109131 RVA: 0x00274710 File Offset: 0x00272910
		[NullableContext(2)]
		protected virtual void ForeachPointLight_Implementation(UPointLightComponent PointLightComponent)
		{
			AKuroMoveLightActor.__ForeachPointLight_Implementation_Internal(base.NativePtr, (PointLightComponent != null) ? PointLightComponent.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601AA4C RID: 109132 RVA: 0x0027472D File Offset: 0x0027292D
		public void CreateOrUpdatePointComponents()
		{
			AKuroMoveLightActor.__CreateOrUpdatePointComponents_Internal(base.NativePtr);
		}

		// Token: 0x0601AA4D RID: 109133 RVA: 0x0027473A File Offset: 0x0027293A
		public void CalculateTickIntervalForIndex(int Index, in FVector CameraLocation)
		{
			AKuroMoveLightActor.__CalculateTickIntervalForIndex_Internal(base.NativePtr, Index, CameraLocation);
		}

		// Token: 0x0601AA4E RID: 109134 RVA: 0x00274749 File Offset: 0x00272949
		public virtual void CalculateIntensityForIndex(int Index, float DeltaTime)
		{
			AKuroMoveLightActor.__CalculateIntensityForIndex_Internal(base.NativePtr, Index, DeltaTime);
		}

		// Token: 0x0601AA4F RID: 109135 RVA: 0x00274758 File Offset: 0x00272958
		protected virtual void CalculateIntensityForIndex_Implementation(int Index, float DeltaTime)
		{
			AKuroMoveLightActor.__CalculateIntensityForIndex_Implementation_Internal(base.NativePtr, Index, DeltaTime);
		}

		// Token: 0x0601AA50 RID: 109136 RVA: 0x00274767 File Offset: 0x00272967
		public virtual void CalculateIntensity(float DeltaTime)
		{
			AKuroMoveLightActor.__CalculateIntensity_Internal(base.NativePtr, DeltaTime);
		}

		// Token: 0x0601AA51 RID: 109137 RVA: 0x00274775 File Offset: 0x00272975
		protected virtual void CalculateIntensity_Implementation(float DeltaTime)
		{
			AKuroMoveLightActor.__CalculateIntensity_Implementation_Internal(base.NativePtr, DeltaTime);
		}

		// Token: 0x0601AA52 RID: 109138 RVA: 0x00274783 File Offset: 0x00272983
		public virtual void ApplyIntensityForIndex(int Index)
		{
			AKuroMoveLightActor.__ApplyIntensityForIndex_Internal(base.NativePtr, Index);
		}

		// Token: 0x0601AA53 RID: 109139 RVA: 0x00274791 File Offset: 0x00272991
		protected virtual void ApplyIntensityForIndex_Implementation(int Index)
		{
			AKuroMoveLightActor.__ApplyIntensityForIndex_Implementation_Internal(base.NativePtr, Index);
		}

		// Token: 0x0601AA54 RID: 109140
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UpdateLight_Internal(IntPtr @this);

		// Token: 0x0601AA55 RID: 109141
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SampleSpline2PointPositionForIndex_Internal(IntPtr @this, int Index, float DeltaTime);

		// Token: 0x0601AA56 RID: 109142
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SampleSpline2PointPositionForIndex_Implementation_Internal(IntPtr @this, int Index, float DeltaTime);

		// Token: 0x0601AA57 RID: 109143
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __InitSplineByCurveForIndex_Internal(IntPtr @this, int Index);

		// Token: 0x0601AA58 RID: 109144
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __InitSplineByCurveForIndex_Implementation_Internal(IntPtr @this, int Index);

		// Token: 0x0601AA59 RID: 109145
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __InitSplineByCurve_Internal(IntPtr @this);

		// Token: 0x0601AA5A RID: 109146
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __InitSplineByCurve_Implementation_Internal(IntPtr @this);

		// Token: 0x0601AA5B RID: 109147
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetSplineForIndex_Internal(IntPtr @this, int Index);

		// Token: 0x0601AA5C RID: 109148
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ForeachPointLight_Internal(IntPtr @this, IntPtr PointLightComponent);

		// Token: 0x0601AA5D RID: 109149
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ForeachPointLight_Implementation_Internal(IntPtr @this, IntPtr PointLightComponent);

		// Token: 0x0601AA5E RID: 109150
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __CreateOrUpdatePointComponents_Internal(IntPtr @this);

		// Token: 0x0601AA5F RID: 109151
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __CalculateTickIntervalForIndex_Internal(IntPtr @this, int Index, in FVector CameraLocation);

		// Token: 0x0601AA60 RID: 109152
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __CalculateIntensityForIndex_Internal(IntPtr @this, int Index, float DeltaTime);

		// Token: 0x0601AA61 RID: 109153
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __CalculateIntensityForIndex_Implementation_Internal(IntPtr @this, int Index, float DeltaTime);

		// Token: 0x0601AA62 RID: 109154
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __CalculateIntensity_Internal(IntPtr @this, float DeltaTime);

		// Token: 0x0601AA63 RID: 109155
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __CalculateIntensity_Implementation_Internal(IntPtr @this, float DeltaTime);

		// Token: 0x0601AA64 RID: 109156
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ApplyIntensityForIndex_Internal(IntPtr @this, int Index);

		// Token: 0x0601AA65 RID: 109157
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ApplyIntensityForIndex_Implementation_Internal(IntPtr @this, int Index);

		// Token: 0x0601AA66 RID: 109158 RVA: 0x0027479F File Offset: 0x0027299F
		static AKuroMoveLightActor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroMoveLightActor");
		}

		// Token: 0x0601AA67 RID: 109159 RVA: 0x002747AD File Offset: 0x002729AD
		protected AKuroMoveLightActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400E6A3 RID: 59043
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroMoveLightActor";

		// Token: 0x0400E6A4 RID: 59044
		private static IntPtr _ClassPtr;

		// Token: 0x0400E6A5 RID: 59045
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400E6A6 RID: 59046
		internal static int __PropertyOffset_PointComponentCount;

		// Token: 0x0400E6A7 RID: 59047
		internal static int __PropertyOffset_bApplySplinePositionSample;

		// Token: 0x0400E6A8 RID: 59048
		internal static int __PropertyOffset_PointLightDataArray;

		// Token: 0x0400E6A9 RID: 59049
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FPointLightData> _PointLightDataArray;

		// Token: 0x0400E6AA RID: 59050
		internal static int __PropertyOffset_bUseGlobalTick;

		// Token: 0x0400E6AB RID: 59051
		internal static int __PropertyOffset_GlobalTickFactor;

		// Token: 0x0400E6AC RID: 59052
		internal static int __PropertyOffset_SplineShareMode;

		// Token: 0x0400E6AD RID: 59053
		internal static int __PropertyOffset_ExternalSharedSpline;

		// Token: 0x0400E6AE RID: 59054
		internal static int __PropertyOffset_RootScene;

		// Token: 0x0400E6AF RID: 59055
		internal static int __PropertyOffset_PointComponents;

		// Token: 0x0400E6B0 RID: 59056
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UPointLightComponent> _PointComponents;

		// Token: 0x0400E6B1 RID: 59057
		internal static int __PropertyOffset_SplineComponents;

		// Token: 0x0400E6B2 RID: 59058
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<USplineComponent> _SplineComponents;

		// Token: 0x0200315B RID: 12635
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __SampleSpline2PointPositionForIndex_FunctionParams
		{
			// Token: 0x04016F80 RID: 94080
			[FieldOffset(0)]
			public int Index;

			// Token: 0x04016F81 RID: 94081
			[FieldOffset(4)]
			public float DeltaTime;
		}

		// Token: 0x0200315C RID: 12636
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __InitSplineByCurveForIndex_FunctionParams
		{
			// Token: 0x04016F82 RID: 94082
			[FieldOffset(0)]
			public int Index;
		}

		// Token: 0x0200315D RID: 12637
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __ForeachPointLight_FunctionParams
		{
			// Token: 0x04016F83 RID: 94083
			[FieldOffset(0)]
			public IntPtr PointLightComponent;
		}

		// Token: 0x0200315E RID: 12638
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __CalculateIntensityForIndex_FunctionParams
		{
			// Token: 0x04016F84 RID: 94084
			[FieldOffset(0)]
			public int Index;

			// Token: 0x04016F85 RID: 94085
			[FieldOffset(4)]
			public float DeltaTime;
		}

		// Token: 0x0200315F RID: 12639
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __CalculateIntensity_FunctionParams
		{
			// Token: 0x04016F86 RID: 94086
			[FieldOffset(0)]
			public float DeltaTime;
		}

		// Token: 0x02003160 RID: 12640
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __ApplyIntensityForIndex_FunctionParams
		{
			// Token: 0x04016F87 RID: 94087
			[FieldOffset(0)]
			public int Index;
		}
	}
}
