using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001BEB RID: 7147
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroWorldRainComponentPhysicsConfig")]
	[UnrealStructLayout(1184, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1184)]
	public class UKuroWorldRainComponentPhysicsConfig : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601B7FD RID: 112637 RVA: 0x00287D32 File Offset: 0x00285F32
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroWorldRainComponentPhysicsConfig._ClassPtr;
		}

		// Token: 0x0601B7FE RID: 112638 RVA: 0x00287D40 File Offset: 0x00285F40
		public UKuroWorldRainComponentPhysicsConfig() : this(BuiltinUtils.AllocNativeUObject(UKuroWorldRainComponentPhysicsConfig.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601B7FF RID: 112639 RVA: 0x00287D68 File Offset: 0x00285F68
		public UKuroWorldRainComponentPhysicsConfig(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroWorldRainComponentPhysicsConfig.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006EA7 RID: 28327
		// (get) Token: 0x0601B800 RID: 112640 RVA: 0x00287D9C File Offset: 0x00285F9C
		// (set) Token: 0x0601B801 RID: 112641 RVA: 0x00287DD5 File Offset: 0x00285FD5
		public FKuroCurveFloat SpawnScaleCurve
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._SpawnScaleCurve) == null)
				{
					result = (this._SpawnScaleCurve = new FKuroCurveFloat(base.NativePtr + (IntPtr)UKuroWorldRainComponentPhysicsConfig.__PropertyOffset_SpawnScaleCurve, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)UKuroWorldRainComponentPhysicsConfig.__PropertyOffset_SpawnScaleCurve, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006EA8 RID: 28328
		// (get) Token: 0x0601B802 RID: 112642 RVA: 0x00287DF6 File Offset: 0x00285FF6
		// (set) Token: 0x0601B803 RID: 112643 RVA: 0x00287E06 File Offset: 0x00286006
		public unsafe float BaseWindSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroWorldRainComponentPhysicsConfig.__PropertyOffset_BaseWindSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroWorldRainComponentPhysicsConfig.__PropertyOffset_BaseWindSize) = value;
			}
		}

		// Token: 0x17006EA9 RID: 28329
		// (get) Token: 0x0601B804 RID: 112644 RVA: 0x00287E18 File Offset: 0x00286018
		// (set) Token: 0x0601B805 RID: 112645 RVA: 0x00287E51 File Offset: 0x00286051
		public FKuroCurveFloat WindCurve
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._WindCurve) == null)
				{
					result = (this._WindCurve = new FKuroCurveFloat(base.NativePtr + (IntPtr)UKuroWorldRainComponentPhysicsConfig.__PropertyOffset_WindCurve, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)UKuroWorldRainComponentPhysicsConfig.__PropertyOffset_WindCurve, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006EAA RID: 28330
		// (get) Token: 0x0601B806 RID: 112646 RVA: 0x00287E72 File Offset: 0x00286072
		// (set) Token: 0x0601B807 RID: 112647 RVA: 0x00287E86 File Offset: 0x00286086
		public unsafe FVector BaseGravitySize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroWorldRainComponentPhysicsConfig.__PropertyOffset_BaseGravitySize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroWorldRainComponentPhysicsConfig.__PropertyOffset_BaseGravitySize) = value;
			}
		}

		// Token: 0x17006EAB RID: 28331
		// (get) Token: 0x0601B808 RID: 112648 RVA: 0x00287E9C File Offset: 0x0028609C
		// (set) Token: 0x0601B809 RID: 112649 RVA: 0x00287ED5 File Offset: 0x002860D5
		public FKuroCurveFloat GravityCurve
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._GravityCurve) == null)
				{
					result = (this._GravityCurve = new FKuroCurveFloat(base.NativePtr + (IntPtr)UKuroWorldRainComponentPhysicsConfig.__PropertyOffset_GravityCurve, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)UKuroWorldRainComponentPhysicsConfig.__PropertyOffset_GravityCurve, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006EAC RID: 28332
		// (get) Token: 0x0601B80A RID: 112650 RVA: 0x00287EF6 File Offset: 0x002860F6
		// (set) Token: 0x0601B80B RID: 112651 RVA: 0x00287F06 File Offset: 0x00286106
		public unsafe float BaseDragSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroWorldRainComponentPhysicsConfig.__PropertyOffset_BaseDragSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroWorldRainComponentPhysicsConfig.__PropertyOffset_BaseDragSize) = value;
			}
		}

		// Token: 0x17006EAD RID: 28333
		// (get) Token: 0x0601B80C RID: 112652 RVA: 0x00287F18 File Offset: 0x00286118
		// (set) Token: 0x0601B80D RID: 112653 RVA: 0x00287F51 File Offset: 0x00286151
		public FKuroCurveFloat DragCurve
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._DragCurve) == null)
				{
					result = (this._DragCurve = new FKuroCurveFloat(base.NativePtr + (IntPtr)UKuroWorldRainComponentPhysicsConfig.__PropertyOffset_DragCurve, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)UKuroWorldRainComponentPhysicsConfig.__PropertyOffset_DragCurve, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006EAE RID: 28334
		// (get) Token: 0x0601B80E RID: 112654 RVA: 0x00287F72 File Offset: 0x00286172
		// (set) Token: 0x0601B80F RID: 112655 RVA: 0x00287F86 File Offset: 0x00286186
		[Nullable(2)]
		public unsafe UVectorFieldStatic VectorField
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UVectorFieldStatic>(base.NativePtr / (IntPtr)sizeof(void*) + UKuroWorldRainComponentPhysicsConfig.__PropertyOffset_VectorField);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKuroWorldRainComponentPhysicsConfig.__PropertyOffset_VectorField, value);
			}
		}

		// Token: 0x17006EAF RID: 28335
		// (get) Token: 0x0601B810 RID: 112656 RVA: 0x00287F9B File Offset: 0x0028619B
		// (set) Token: 0x0601B811 RID: 112657 RVA: 0x00287FAB File Offset: 0x002861AB
		public unsafe float VectorFieldBaseSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroWorldRainComponentPhysicsConfig.__PropertyOffset_VectorFieldBaseSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroWorldRainComponentPhysicsConfig.__PropertyOffset_VectorFieldBaseSize) = value;
			}
		}

		// Token: 0x17006EB0 RID: 28336
		// (get) Token: 0x0601B812 RID: 112658 RVA: 0x00287FBC File Offset: 0x002861BC
		// (set) Token: 0x0601B813 RID: 112659 RVA: 0x00287FF5 File Offset: 0x002861F5
		public FKuroCurveFloat VectorFieldCurve
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._VectorFieldCurve) == null)
				{
					result = (this._VectorFieldCurve = new FKuroCurveFloat(base.NativePtr + (IntPtr)UKuroWorldRainComponentPhysicsConfig.__PropertyOffset_VectorFieldCurve, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)UKuroWorldRainComponentPhysicsConfig.__PropertyOffset_VectorFieldCurve, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006EB1 RID: 28337
		// (get) Token: 0x0601B814 RID: 112660 RVA: 0x00288016 File Offset: 0x00286216
		// (set) Token: 0x0601B815 RID: 112661 RVA: 0x0028802A File Offset: 0x0028622A
		public unsafe FVector VectorFieldScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroWorldRainComponentPhysicsConfig.__PropertyOffset_VectorFieldScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroWorldRainComponentPhysicsConfig.__PropertyOffset_VectorFieldScale) = value;
			}
		}

		// Token: 0x17006EB2 RID: 28338
		// (get) Token: 0x0601B816 RID: 112662 RVA: 0x0028803F File Offset: 0x0028623F
		// (set) Token: 0x0601B817 RID: 112663 RVA: 0x00288053 File Offset: 0x00286253
		public unsafe FVector VectorFieldMoveDirection
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroWorldRainComponentPhysicsConfig.__PropertyOffset_VectorFieldMoveDirection);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroWorldRainComponentPhysicsConfig.__PropertyOffset_VectorFieldMoveDirection) = value;
			}
		}

		// Token: 0x17006EB3 RID: 28339
		// (get) Token: 0x0601B818 RID: 112664 RVA: 0x00288068 File Offset: 0x00286268
		// (set) Token: 0x0601B819 RID: 112665 RVA: 0x002880A1 File Offset: 0x002862A1
		public FKuroCurveFloat VectorFieldMoveSpeedCurve
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._VectorFieldMoveSpeedCurve) == null)
				{
					result = (this._VectorFieldMoveSpeedCurve = new FKuroCurveFloat(base.NativePtr + (IntPtr)UKuroWorldRainComponentPhysicsConfig.__PropertyOffset_VectorFieldMoveSpeedCurve, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)UKuroWorldRainComponentPhysicsConfig.__PropertyOffset_VectorFieldMoveSpeedCurve, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006EB4 RID: 28340
		// (get) Token: 0x0601B81A RID: 112666 RVA: 0x002880C2 File Offset: 0x002862C2
		// (set) Token: 0x0601B81B RID: 112667 RVA: 0x002880D6 File Offset: 0x002862D6
		public unsafe FVector CycleBoxHalfSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroWorldRainComponentPhysicsConfig.__PropertyOffset_CycleBoxHalfSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroWorldRainComponentPhysicsConfig.__PropertyOffset_CycleBoxHalfSize) = value;
			}
		}

		// Token: 0x17006EB5 RID: 28341
		// (get) Token: 0x0601B81C RID: 112668 RVA: 0x002880EB File Offset: 0x002862EB
		// (set) Token: 0x0601B81D RID: 112669 RVA: 0x002880FB File Offset: 0x002862FB
		public unsafe float CycleBoxZBias
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroWorldRainComponentPhysicsConfig.__PropertyOffset_CycleBoxZBias);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroWorldRainComponentPhysicsConfig.__PropertyOffset_CycleBoxZBias) = value;
			}
		}

		// Token: 0x17006EB6 RID: 28342
		// (get) Token: 0x0601B81E RID: 112670 RVA: 0x0028810C File Offset: 0x0028630C
		// (set) Token: 0x0601B81F RID: 112671 RVA: 0x00288145 File Offset: 0x00286345
		public FKuroCurveFloat TimeDilationCurve
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._TimeDilationCurve) == null)
				{
					result = (this._TimeDilationCurve = new FKuroCurveFloat(base.NativePtr + (IntPtr)UKuroWorldRainComponentPhysicsConfig.__PropertyOffset_TimeDilationCurve, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)UKuroWorldRainComponentPhysicsConfig.__PropertyOffset_TimeDilationCurve, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006EB7 RID: 28343
		// (get) Token: 0x0601B820 RID: 112672 RVA: 0x00288166 File Offset: 0x00286366
		// (set) Token: 0x0601B821 RID: 112673 RVA: 0x00288176 File Offset: 0x00286376
		public unsafe float LifeTimeDilationOnDeath
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroWorldRainComponentPhysicsConfig.__PropertyOffset_LifeTimeDilationOnDeath);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroWorldRainComponentPhysicsConfig.__PropertyOffset_LifeTimeDilationOnDeath) = value;
			}
		}

		// Token: 0x0601B822 RID: 112674 RVA: 0x00288187 File Offset: 0x00286387
		static UKuroWorldRainComponentPhysicsConfig()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroWorldRainComponentPhysicsConfig");
		}

		// Token: 0x0601B823 RID: 112675 RVA: 0x00288195 File Offset: 0x00286395
		protected UKuroWorldRainComponentPhysicsConfig(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400ECB2 RID: 60594
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroWorldRainComponentPhysicsConfig";

		// Token: 0x0400ECB3 RID: 60595
		private static IntPtr _ClassPtr;

		// Token: 0x0400ECB4 RID: 60596
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400ECB5 RID: 60597
		internal static int __PropertyOffset_SpawnScaleCurve;

		// Token: 0x0400ECB6 RID: 60598
		[Nullable(2)]
		private FKuroCurveFloat _SpawnScaleCurve;

		// Token: 0x0400ECB7 RID: 60599
		internal static int __PropertyOffset_BaseWindSize;

		// Token: 0x0400ECB8 RID: 60600
		internal static int __PropertyOffset_WindCurve;

		// Token: 0x0400ECB9 RID: 60601
		[Nullable(2)]
		private FKuroCurveFloat _WindCurve;

		// Token: 0x0400ECBA RID: 60602
		internal static int __PropertyOffset_BaseGravitySize;

		// Token: 0x0400ECBB RID: 60603
		internal static int __PropertyOffset_GravityCurve;

		// Token: 0x0400ECBC RID: 60604
		[Nullable(2)]
		private FKuroCurveFloat _GravityCurve;

		// Token: 0x0400ECBD RID: 60605
		internal static int __PropertyOffset_BaseDragSize;

		// Token: 0x0400ECBE RID: 60606
		internal static int __PropertyOffset_DragCurve;

		// Token: 0x0400ECBF RID: 60607
		[Nullable(2)]
		private FKuroCurveFloat _DragCurve;

		// Token: 0x0400ECC0 RID: 60608
		internal static int __PropertyOffset_VectorField;

		// Token: 0x0400ECC1 RID: 60609
		internal static int __PropertyOffset_VectorFieldBaseSize;

		// Token: 0x0400ECC2 RID: 60610
		internal static int __PropertyOffset_VectorFieldCurve;

		// Token: 0x0400ECC3 RID: 60611
		[Nullable(2)]
		private FKuroCurveFloat _VectorFieldCurve;

		// Token: 0x0400ECC4 RID: 60612
		internal static int __PropertyOffset_VectorFieldScale;

		// Token: 0x0400ECC5 RID: 60613
		internal static int __PropertyOffset_VectorFieldMoveDirection;

		// Token: 0x0400ECC6 RID: 60614
		internal static int __PropertyOffset_VectorFieldMoveSpeedCurve;

		// Token: 0x0400ECC7 RID: 60615
		[Nullable(2)]
		private FKuroCurveFloat _VectorFieldMoveSpeedCurve;

		// Token: 0x0400ECC8 RID: 60616
		internal static int __PropertyOffset_CycleBoxHalfSize;

		// Token: 0x0400ECC9 RID: 60617
		internal static int __PropertyOffset_CycleBoxZBias;

		// Token: 0x0400ECCA RID: 60618
		internal static int __PropertyOffset_TimeDilationCurve;

		// Token: 0x0400ECCB RID: 60619
		[Nullable(2)]
		private FKuroCurveFloat _TimeDilationCurve;

		// Token: 0x0400ECCC RID: 60620
		internal static int __PropertyOffset_LifeTimeDilationOnDeath;
	}
}
