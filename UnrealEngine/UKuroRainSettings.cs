using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001B9B RID: 7067
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroRainSettings")]
	[UnrealStructLayout(800, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 800)]
	public class UKuroRainSettings : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601AE75 RID: 110197 RVA: 0x0027A86A File Offset: 0x00278A6A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroRainSettings._ClassPtr;
		}

		// Token: 0x0601AE76 RID: 110198 RVA: 0x0027A878 File Offset: 0x00278A78
		public UKuroRainSettings() : this(BuiltinUtils.AllocNativeUObject(UKuroRainSettings.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601AE77 RID: 110199 RVA: 0x0027A8A0 File Offset: 0x00278AA0
		public UKuroRainSettings(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroRainSettings.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006C57 RID: 27735
		// (get) Token: 0x0601AE78 RID: 110200 RVA: 0x0027A8D3 File Offset: 0x00278AD3
		// (set) Token: 0x0601AE79 RID: 110201 RVA: 0x0027A8E7 File Offset: 0x00278AE7
		public unsafe FVector RainBoxSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroRainSettings.__PropertyOffset_RainBoxSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroRainSettings.__PropertyOffset_RainBoxSize) = value;
			}
		}

		// Token: 0x17006C58 RID: 27736
		// (get) Token: 0x0601AE7A RID: 110202 RVA: 0x0027A8FC File Offset: 0x00278AFC
		// (set) Token: 0x0601AE7B RID: 110203 RVA: 0x0027A910 File Offset: 0x00278B10
		[Nullable(2)]
		public unsafe UStaticMesh RainMesh
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMesh>(base.NativePtr / (IntPtr)sizeof(void*) + UKuroRainSettings.__PropertyOffset_RainMesh);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKuroRainSettings.__PropertyOffset_RainMesh, value);
			}
		}

		// Token: 0x17006C59 RID: 27737
		// (get) Token: 0x0601AE7C RID: 110204 RVA: 0x0027A925 File Offset: 0x00278B25
		// (set) Token: 0x0601AE7D RID: 110205 RVA: 0x0027A939 File Offset: 0x00278B39
		public unsafe FIntVector BoxCountPositive
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroRainSettings.__PropertyOffset_BoxCountPositive);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroRainSettings.__PropertyOffset_BoxCountPositive) = value;
			}
		}

		// Token: 0x17006C5A RID: 27738
		// (get) Token: 0x0601AE7E RID: 110206 RVA: 0x0027A94E File Offset: 0x00278B4E
		// (set) Token: 0x0601AE7F RID: 110207 RVA: 0x0027A962 File Offset: 0x00278B62
		public unsafe FIntVector BoxCountNegative
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroRainSettings.__PropertyOffset_BoxCountNegative);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroRainSettings.__PropertyOffset_BoxCountNegative) = value;
			}
		}

		// Token: 0x17006C5B RID: 27739
		// (get) Token: 0x0601AE80 RID: 110208 RVA: 0x0027A977 File Offset: 0x00278B77
		// (set) Token: 0x0601AE81 RID: 110209 RVA: 0x0027A987 File Offset: 0x00278B87
		public unsafe float CameraOffsetSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroRainSettings.__PropertyOffset_CameraOffsetSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroRainSettings.__PropertyOffset_CameraOffsetSize) = value;
			}
		}

		// Token: 0x17006C5C RID: 27740
		// (get) Token: 0x0601AE82 RID: 110210 RVA: 0x0027A998 File Offset: 0x00278B98
		// (set) Token: 0x0601AE83 RID: 110211 RVA: 0x0027A9A8 File Offset: 0x00278BA8
		public unsafe float ScaleCameraOffsetY
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroRainSettings.__PropertyOffset_ScaleCameraOffsetY);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroRainSettings.__PropertyOffset_ScaleCameraOffsetY) = value;
			}
		}

		// Token: 0x17006C5D RID: 27741
		// (get) Token: 0x0601AE84 RID: 110212 RVA: 0x0027A9BC File Offset: 0x00278BBC
		// (set) Token: 0x0601AE85 RID: 110213 RVA: 0x0027A9F5 File Offset: 0x00278BF5
		public FKuroCurveFloat GravityWeightCurve
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._GravityWeightCurve) == null)
				{
					result = (this._GravityWeightCurve = new FKuroCurveFloat(base.NativePtr + (IntPtr)UKuroRainSettings.__PropertyOffset_GravityWeightCurve, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)UKuroRainSettings.__PropertyOffset_GravityWeightCurve, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006C5E RID: 27742
		// (get) Token: 0x0601AE86 RID: 110214 RVA: 0x0027AA18 File Offset: 0x00278C18
		// (set) Token: 0x0601AE87 RID: 110215 RVA: 0x0027AA51 File Offset: 0x00278C51
		public FKuroCurveFloat WindWeightCurve
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._WindWeightCurve) == null)
				{
					result = (this._WindWeightCurve = new FKuroCurveFloat(base.NativePtr + (IntPtr)UKuroRainSettings.__PropertyOffset_WindWeightCurve, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)UKuroRainSettings.__PropertyOffset_WindWeightCurve, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006C5F RID: 27743
		// (get) Token: 0x0601AE88 RID: 110216 RVA: 0x0027AA72 File Offset: 0x00278C72
		// (set) Token: 0x0601AE89 RID: 110217 RVA: 0x0027AA82 File Offset: 0x00278C82
		public unsafe bool RainDropSizeUseSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroRainSettings.__PropertyOffset_RainDropSizeUseSpeed) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroRainSettings.__PropertyOffset_RainDropSizeUseSpeed) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006C60 RID: 27744
		// (get) Token: 0x0601AE8A RID: 110218 RVA: 0x0027AA94 File Offset: 0x00278C94
		// (set) Token: 0x0601AE8B RID: 110219 RVA: 0x0027AACD File Offset: 0x00278CCD
		public FKuroCurveVector2D RaindropSizeCurve
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveVector2D result;
				if ((result = this._RaindropSizeCurve) == null)
				{
					result = (this._RaindropSizeCurve = new FKuroCurveVector2D(base.NativePtr + (IntPtr)UKuroRainSettings.__PropertyOffset_RaindropSizeCurve, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveVector2D.StaticStruct(), base.NativePtr + (IntPtr)UKuroRainSettings.__PropertyOffset_RaindropSizeCurve, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006C61 RID: 27745
		// (get) Token: 0x0601AE8C RID: 110220 RVA: 0x0027AAEE File Offset: 0x00278CEE
		// (set) Token: 0x0601AE8D RID: 110221 RVA: 0x0027AB02 File Offset: 0x00278D02
		[Nullable(2)]
		public unsafe UMaterialInterface Material
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + UKuroRainSettings.__PropertyOffset_Material);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKuroRainSettings.__PropertyOffset_Material, value);
			}
		}

		// Token: 0x17006C62 RID: 27746
		// (get) Token: 0x0601AE8E RID: 110222 RVA: 0x0027AB18 File Offset: 0x00278D18
		// (set) Token: 0x0601AE8F RID: 110223 RVA: 0x0027AB51 File Offset: 0x00278D51
		public TArray<FKuroRainMaterialFloatParameter> MaterialFloatParameters_Density
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FKuroRainMaterialFloatParameter> result;
				if ((result = this._MaterialFloatParameters_Density) == null)
				{
					result = (this._MaterialFloatParameters_Density = new TArray<FKuroRainMaterialFloatParameter>(base.NativePtr + (IntPtr)UKuroRainSettings.__PropertyOffset_MaterialFloatParameters_Density, this));
				}
				return result;
			}
			set
			{
				this.MaterialFloatParameters_Density.CopyAssign(value);
			}
		}

		// Token: 0x17006C63 RID: 27747
		// (get) Token: 0x0601AE90 RID: 110224 RVA: 0x0027AB60 File Offset: 0x00278D60
		// (set) Token: 0x0601AE91 RID: 110225 RVA: 0x0027AB99 File Offset: 0x00278D99
		public TArray<FKuroRainMaterialColorParameter> MaterialColorParameters_Density
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FKuroRainMaterialColorParameter> result;
				if ((result = this._MaterialColorParameters_Density) == null)
				{
					result = (this._MaterialColorParameters_Density = new TArray<FKuroRainMaterialColorParameter>(base.NativePtr + (IntPtr)UKuroRainSettings.__PropertyOffset_MaterialColorParameters_Density, this));
				}
				return result;
			}
			set
			{
				this.MaterialColorParameters_Density.CopyAssign(value);
			}
		}

		// Token: 0x17006C64 RID: 27748
		// (get) Token: 0x0601AE92 RID: 110226 RVA: 0x0027ABA8 File Offset: 0x00278DA8
		// (set) Token: 0x0601AE93 RID: 110227 RVA: 0x0027ABE1 File Offset: 0x00278DE1
		public TArray<FKuroRainMaterialFloatParameter> MaterialFloatParameters_Speed
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FKuroRainMaterialFloatParameter> result;
				if ((result = this._MaterialFloatParameters_Speed) == null)
				{
					result = (this._MaterialFloatParameters_Speed = new TArray<FKuroRainMaterialFloatParameter>(base.NativePtr + (IntPtr)UKuroRainSettings.__PropertyOffset_MaterialFloatParameters_Speed, this));
				}
				return result;
			}
			set
			{
				this.MaterialFloatParameters_Speed.CopyAssign(value);
			}
		}

		// Token: 0x17006C65 RID: 27749
		// (get) Token: 0x0601AE94 RID: 110228 RVA: 0x0027ABF0 File Offset: 0x00278DF0
		// (set) Token: 0x0601AE95 RID: 110229 RVA: 0x0027AC29 File Offset: 0x00278E29
		public TArray<FKuroRainMaterialColorParameter> MaterialColorParameters_Speed
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FKuroRainMaterialColorParameter> result;
				if ((result = this._MaterialColorParameters_Speed) == null)
				{
					result = (this._MaterialColorParameters_Speed = new TArray<FKuroRainMaterialColorParameter>(base.NativePtr + (IntPtr)UKuroRainSettings.__PropertyOffset_MaterialColorParameters_Speed, this));
				}
				return result;
			}
			set
			{
				this.MaterialColorParameters_Speed.CopyAssign(value);
			}
		}

		// Token: 0x17006C66 RID: 27750
		// (get) Token: 0x0601AE96 RID: 110230 RVA: 0x0027AC37 File Offset: 0x00278E37
		// (set) Token: 0x0601AE97 RID: 110231 RVA: 0x0027AC47 File Offset: 0x00278E47
		public unsafe int FramesIntervalUpdateParameters
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroRainSettings.__PropertyOffset_FramesIntervalUpdateParameters);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroRainSettings.__PropertyOffset_FramesIntervalUpdateParameters) = value;
			}
		}

		// Token: 0x17006C67 RID: 27751
		// (get) Token: 0x0601AE98 RID: 110232 RVA: 0x0027AC58 File Offset: 0x00278E58
		// (set) Token: 0x0601AE99 RID: 110233 RVA: 0x0027AC68 File Offset: 0x00278E68
		public unsafe int FramesIntervalFixRainBoxes
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroRainSettings.__PropertyOffset_FramesIntervalFixRainBoxes);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroRainSettings.__PropertyOffset_FramesIntervalFixRainBoxes) = value;
			}
		}

		// Token: 0x0601AE9A RID: 110234 RVA: 0x0027AC79 File Offset: 0x00278E79
		static UKuroRainSettings()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroRainSettings");
		}

		// Token: 0x0601AE9B RID: 110235 RVA: 0x0027AC87 File Offset: 0x00278E87
		protected UKuroRainSettings(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400E8D7 RID: 59607
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroRainSettings";

		// Token: 0x0400E8D8 RID: 59608
		private static IntPtr _ClassPtr;

		// Token: 0x0400E8D9 RID: 59609
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400E8DA RID: 59610
		internal static int __PropertyOffset_RainBoxSize;

		// Token: 0x0400E8DB RID: 59611
		internal static int __PropertyOffset_RainMesh;

		// Token: 0x0400E8DC RID: 59612
		internal static int __PropertyOffset_BoxCountPositive;

		// Token: 0x0400E8DD RID: 59613
		internal static int __PropertyOffset_BoxCountNegative;

		// Token: 0x0400E8DE RID: 59614
		internal static int __PropertyOffset_CameraOffsetSize;

		// Token: 0x0400E8DF RID: 59615
		internal static int __PropertyOffset_ScaleCameraOffsetY;

		// Token: 0x0400E8E0 RID: 59616
		internal static int __PropertyOffset_GravityWeightCurve;

		// Token: 0x0400E8E1 RID: 59617
		[Nullable(2)]
		private FKuroCurveFloat _GravityWeightCurve;

		// Token: 0x0400E8E2 RID: 59618
		internal static int __PropertyOffset_WindWeightCurve;

		// Token: 0x0400E8E3 RID: 59619
		[Nullable(2)]
		private FKuroCurveFloat _WindWeightCurve;

		// Token: 0x0400E8E4 RID: 59620
		internal static int __PropertyOffset_RainDropSizeUseSpeed;

		// Token: 0x0400E8E5 RID: 59621
		internal static int __PropertyOffset_RaindropSizeCurve;

		// Token: 0x0400E8E6 RID: 59622
		[Nullable(2)]
		private FKuroCurveVector2D _RaindropSizeCurve;

		// Token: 0x0400E8E7 RID: 59623
		internal static int __PropertyOffset_Material;

		// Token: 0x0400E8E8 RID: 59624
		internal static int __PropertyOffset_MaterialFloatParameters_Density;

		// Token: 0x0400E8E9 RID: 59625
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKuroRainMaterialFloatParameter> _MaterialFloatParameters_Density;

		// Token: 0x0400E8EA RID: 59626
		internal static int __PropertyOffset_MaterialColorParameters_Density;

		// Token: 0x0400E8EB RID: 59627
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKuroRainMaterialColorParameter> _MaterialColorParameters_Density;

		// Token: 0x0400E8EC RID: 59628
		internal static int __PropertyOffset_MaterialFloatParameters_Speed;

		// Token: 0x0400E8ED RID: 59629
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKuroRainMaterialFloatParameter> _MaterialFloatParameters_Speed;

		// Token: 0x0400E8EE RID: 59630
		internal static int __PropertyOffset_MaterialColorParameters_Speed;

		// Token: 0x0400E8EF RID: 59631
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKuroRainMaterialColorParameter> _MaterialColorParameters_Speed;

		// Token: 0x0400E8F0 RID: 59632
		internal static int __PropertyOffset_FramesIntervalUpdateParameters;

		// Token: 0x0400E8F1 RID: 59633
		internal static int __PropertyOffset_FramesIntervalFixRainBoxes;
	}
}
