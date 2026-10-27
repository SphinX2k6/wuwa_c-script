using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000E42 RID: 3650
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.MaterialExpressionSingleLayerWaterMaterialOutput")]
	[UnrealStructLayout(864, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 864)]
	public class UMaterialExpressionSingleLayerWaterMaterialOutput : UMaterialExpressionCustomOutput, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600C3F4 RID: 50164 RVA: 0x0011B1EE File Offset: 0x001193EE
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionSingleLayerWaterMaterialOutput._ClassPtr;
		}

		// Token: 0x0600C3F5 RID: 50165 RVA: 0x0011B1FC File Offset: 0x001193FC
		public UMaterialExpressionSingleLayerWaterMaterialOutput() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionSingleLayerWaterMaterialOutput.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600C3F6 RID: 50166 RVA: 0x0011B224 File Offset: 0x00119424
		public UMaterialExpressionSingleLayerWaterMaterialOutput(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionSingleLayerWaterMaterialOutput.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002D78 RID: 11640
		// (get) Token: 0x0600C3F7 RID: 50167 RVA: 0x0011B258 File Offset: 0x00119458
		// (set) Token: 0x0600C3F8 RID: 50168 RVA: 0x0011B291 File Offset: 0x00119491
		public FExpressionInput ScatteringCoefficients
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._ScatteringCoefficients) == null)
				{
					result = (this._ScatteringCoefficients = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionSingleLayerWaterMaterialOutput.__PropertyOffset_ScatteringCoefficients, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionSingleLayerWaterMaterialOutput.__PropertyOffset_ScatteringCoefficients, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002D79 RID: 11641
		// (get) Token: 0x0600C3F9 RID: 50169 RVA: 0x0011B2B4 File Offset: 0x001194B4
		// (set) Token: 0x0600C3FA RID: 50170 RVA: 0x0011B2ED File Offset: 0x001194ED
		public FExpressionInput AbsorptionCoefficients
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._AbsorptionCoefficients) == null)
				{
					result = (this._AbsorptionCoefficients = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionSingleLayerWaterMaterialOutput.__PropertyOffset_AbsorptionCoefficients, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionSingleLayerWaterMaterialOutput.__PropertyOffset_AbsorptionCoefficients, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002D7A RID: 11642
		// (get) Token: 0x0600C3FB RID: 50171 RVA: 0x0011B310 File Offset: 0x00119510
		// (set) Token: 0x0600C3FC RID: 50172 RVA: 0x0011B349 File Offset: 0x00119549
		public FExpressionInput PhaseG
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._PhaseG) == null)
				{
					result = (this._PhaseG = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionSingleLayerWaterMaterialOutput.__PropertyOffset_PhaseG, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionSingleLayerWaterMaterialOutput.__PropertyOffset_PhaseG, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002D7B RID: 11643
		// (get) Token: 0x0600C3FD RID: 50173 RVA: 0x0011B36C File Offset: 0x0011956C
		// (set) Token: 0x0600C3FE RID: 50174 RVA: 0x0011B3A5 File Offset: 0x001195A5
		public FExpressionInput ColorScaleBehindWater
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._ColorScaleBehindWater) == null)
				{
					result = (this._ColorScaleBehindWater = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionSingleLayerWaterMaterialOutput.__PropertyOffset_ColorScaleBehindWater, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionSingleLayerWaterMaterialOutput.__PropertyOffset_ColorScaleBehindWater, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002D7C RID: 11644
		// (get) Token: 0x0600C3FF RID: 50175 RVA: 0x0011B3C8 File Offset: 0x001195C8
		// (set) Token: 0x0600C400 RID: 50176 RVA: 0x0011B401 File Offset: 0x00119601
		public FExpressionInput WaterColorTint
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._WaterColorTint) == null)
				{
					result = (this._WaterColorTint = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionSingleLayerWaterMaterialOutput.__PropertyOffset_WaterColorTint, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionSingleLayerWaterMaterialOutput.__PropertyOffset_WaterColorTint, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002D7D RID: 11645
		// (get) Token: 0x0600C401 RID: 50177 RVA: 0x0011B424 File Offset: 0x00119624
		// (set) Token: 0x0600C402 RID: 50178 RVA: 0x0011B45D File Offset: 0x0011965D
		public FExpressionInput SpecularLighting
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._SpecularLighting) == null)
				{
					result = (this._SpecularLighting = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionSingleLayerWaterMaterialOutput.__PropertyOffset_SpecularLighting, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionSingleLayerWaterMaterialOutput.__PropertyOffset_SpecularLighting, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002D7E RID: 11646
		// (get) Token: 0x0600C403 RID: 50179 RVA: 0x0011B480 File Offset: 0x00119680
		// (set) Token: 0x0600C404 RID: 50180 RVA: 0x0011B4B9 File Offset: 0x001196B9
		public FExpressionInput OverlayCoverage
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._OverlayCoverage) == null)
				{
					result = (this._OverlayCoverage = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionSingleLayerWaterMaterialOutput.__PropertyOffset_OverlayCoverage, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionSingleLayerWaterMaterialOutput.__PropertyOffset_OverlayCoverage, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002D7F RID: 11647
		// (get) Token: 0x0600C405 RID: 50181 RVA: 0x0011B4DC File Offset: 0x001196DC
		// (set) Token: 0x0600C406 RID: 50182 RVA: 0x0011B515 File Offset: 0x00119715
		public FExpressionInput CustomIBLColor
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._CustomIBLColor) == null)
				{
					result = (this._CustomIBLColor = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionSingleLayerWaterMaterialOutput.__PropertyOffset_CustomIBLColor, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionSingleLayerWaterMaterialOutput.__PropertyOffset_CustomIBLColor, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002D80 RID: 11648
		// (get) Token: 0x0600C407 RID: 50183 RVA: 0x0011B538 File Offset: 0x00119738
		// (set) Token: 0x0600C408 RID: 50184 RVA: 0x0011B571 File Offset: 0x00119771
		public FExpressionInput OverlayDirectLighting
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._OverlayDirectLighting) == null)
				{
					result = (this._OverlayDirectLighting = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionSingleLayerWaterMaterialOutput.__PropertyOffset_OverlayDirectLighting, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionSingleLayerWaterMaterialOutput.__PropertyOffset_OverlayDirectLighting, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002D81 RID: 11649
		// (get) Token: 0x0600C409 RID: 50185 RVA: 0x0011B594 File Offset: 0x00119794
		// (set) Token: 0x0600C40A RID: 50186 RVA: 0x0011B5CD File Offset: 0x001197CD
		public FExpressionInput OverlayIndirectLighting
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._OverlayIndirectLighting) == null)
				{
					result = (this._OverlayIndirectLighting = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionSingleLayerWaterMaterialOutput.__PropertyOffset_OverlayIndirectLighting, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionSingleLayerWaterMaterialOutput.__PropertyOffset_OverlayIndirectLighting, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002D82 RID: 11650
		// (get) Token: 0x0600C40B RID: 50187 RVA: 0x0011B5F0 File Offset: 0x001197F0
		// (set) Token: 0x0600C40C RID: 50188 RVA: 0x0011B629 File Offset: 0x00119829
		public FExpressionInput CustomReflectionColor
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._CustomReflectionColor) == null)
				{
					result = (this._CustomReflectionColor = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionSingleLayerWaterMaterialOutput.__PropertyOffset_CustomReflectionColor, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionSingleLayerWaterMaterialOutput.__PropertyOffset_CustomReflectionColor, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002D83 RID: 11651
		// (get) Token: 0x0600C40D RID: 50189 RVA: 0x0011B64C File Offset: 0x0011984C
		// (set) Token: 0x0600C40E RID: 50190 RVA: 0x0011B685 File Offset: 0x00119885
		public FExpressionInput BuiltinReflectionIntensity
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._BuiltinReflectionIntensity) == null)
				{
					result = (this._BuiltinReflectionIntensity = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionSingleLayerWaterMaterialOutput.__PropertyOffset_BuiltinReflectionIntensity, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionSingleLayerWaterMaterialOutput.__PropertyOffset_BuiltinReflectionIntensity, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0600C40F RID: 50191 RVA: 0x0011B6A6 File Offset: 0x001198A6
		static UMaterialExpressionSingleLayerWaterMaterialOutput()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionSingleLayerWaterMaterialOutput");
		}

		// Token: 0x0600C410 RID: 50192 RVA: 0x0011B6B4 File Offset: 0x001198B4
		protected UMaterialExpressionSingleLayerWaterMaterialOutput(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400688D RID: 26765
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionSingleLayerWaterMaterialOutput";

		// Token: 0x0400688E RID: 26766
		private static IntPtr _ClassPtr;

		// Token: 0x0400688F RID: 26767
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04006890 RID: 26768
		internal static int __PropertyOffset_ScatteringCoefficients;

		// Token: 0x04006891 RID: 26769
		[Nullable(2)]
		private FExpressionInput _ScatteringCoefficients;

		// Token: 0x04006892 RID: 26770
		internal static int __PropertyOffset_AbsorptionCoefficients;

		// Token: 0x04006893 RID: 26771
		[Nullable(2)]
		private FExpressionInput _AbsorptionCoefficients;

		// Token: 0x04006894 RID: 26772
		internal static int __PropertyOffset_PhaseG;

		// Token: 0x04006895 RID: 26773
		[Nullable(2)]
		private FExpressionInput _PhaseG;

		// Token: 0x04006896 RID: 26774
		internal static int __PropertyOffset_ColorScaleBehindWater;

		// Token: 0x04006897 RID: 26775
		[Nullable(2)]
		private FExpressionInput _ColorScaleBehindWater;

		// Token: 0x04006898 RID: 26776
		internal static int __PropertyOffset_WaterColorTint;

		// Token: 0x04006899 RID: 26777
		[Nullable(2)]
		private FExpressionInput _WaterColorTint;

		// Token: 0x0400689A RID: 26778
		internal static int __PropertyOffset_SpecularLighting;

		// Token: 0x0400689B RID: 26779
		[Nullable(2)]
		private FExpressionInput _SpecularLighting;

		// Token: 0x0400689C RID: 26780
		internal static int __PropertyOffset_OverlayCoverage;

		// Token: 0x0400689D RID: 26781
		[Nullable(2)]
		private FExpressionInput _OverlayCoverage;

		// Token: 0x0400689E RID: 26782
		internal static int __PropertyOffset_CustomIBLColor;

		// Token: 0x0400689F RID: 26783
		[Nullable(2)]
		private FExpressionInput _CustomIBLColor;

		// Token: 0x040068A0 RID: 26784
		internal static int __PropertyOffset_OverlayDirectLighting;

		// Token: 0x040068A1 RID: 26785
		[Nullable(2)]
		private FExpressionInput _OverlayDirectLighting;

		// Token: 0x040068A2 RID: 26786
		internal static int __PropertyOffset_OverlayIndirectLighting;

		// Token: 0x040068A3 RID: 26787
		[Nullable(2)]
		private FExpressionInput _OverlayIndirectLighting;

		// Token: 0x040068A4 RID: 26788
		internal static int __PropertyOffset_CustomReflectionColor;

		// Token: 0x040068A5 RID: 26789
		[Nullable(2)]
		private FExpressionInput _CustomReflectionColor;

		// Token: 0x040068A6 RID: 26790
		internal static int __PropertyOffset_BuiltinReflectionIntensity;

		// Token: 0x040068A7 RID: 26791
		[Nullable(2)]
		private FExpressionInput _BuiltinReflectionIntensity;
	}
}
