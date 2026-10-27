using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200106C RID: 4204
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.RBFDriver")]
	[UnrealStructLayout(320, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 320)]
	public class URBFDriver : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600EF25 RID: 61221 RVA: 0x00162AAC File Offset: 0x00160CAC
		public new static UClassStackOnlyPtr StaticClass()
		{
			return URBFDriver._ClassPtr;
		}

		// Token: 0x0600EF26 RID: 61222 RVA: 0x00162AB8 File Offset: 0x00160CB8
		public URBFDriver() : this(BuiltinUtils.AllocNativeUObject(URBFDriver.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600EF27 RID: 61223 RVA: 0x00162AE0 File Offset: 0x00160CE0
		public URBFDriver(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(URBFDriver.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170039DD RID: 14813
		// (get) Token: 0x0600EF28 RID: 61224 RVA: 0x00162B13 File Offset: 0x00160D13
		// (set) Token: 0x0600EF29 RID: 61225 RVA: 0x00162B27 File Offset: 0x00160D27
		public unsafe FName DriverName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URBFDriver.__PropertyOffset_DriverName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)URBFDriver.__PropertyOffset_DriverName) = value;
			}
		}

		// Token: 0x170039DE RID: 14814
		// (get) Token: 0x0600EF2A RID: 61226 RVA: 0x00162B3C File Offset: 0x00160D3C
		// (set) Token: 0x0600EF2B RID: 61227 RVA: 0x00162B50 File Offset: 0x00160D50
		public unsafe FName DriverBoneName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URBFDriver.__PropertyOffset_DriverBoneName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)URBFDriver.__PropertyOffset_DriverBoneName) = value;
			}
		}

		// Token: 0x170039DF RID: 14815
		// (get) Token: 0x0600EF2C RID: 61228 RVA: 0x00162B65 File Offset: 0x00160D65
		// (set) Token: 0x0600EF2D RID: 61229 RVA: 0x00162B79 File Offset: 0x00160D79
		public unsafe FName BaseBoneName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URBFDriver.__PropertyOffset_BaseBoneName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)URBFDriver.__PropertyOffset_BaseBoneName) = value;
			}
		}

		// Token: 0x170039E0 RID: 14816
		// (get) Token: 0x0600EF2E RID: 61230 RVA: 0x00162B8E File Offset: 0x00160D8E
		// (set) Token: 0x0600EF2F RID: 61231 RVA: 0x00162B9E File Offset: 0x00160D9E
		public unsafe ERBFDistanceType DistanceType
		{
			get
			{
				return (ERBFDistanceType)(*(base.NativePtr + (IntPtr)URBFDriver.__PropertyOffset_DistanceType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)URBFDriver.__PropertyOffset_DistanceType) = (int)value;
			}
		}

		// Token: 0x170039E1 RID: 14817
		// (get) Token: 0x0600EF30 RID: 61232 RVA: 0x00162BAF File Offset: 0x00160DAF
		// (set) Token: 0x0600EF31 RID: 61233 RVA: 0x00162BBF File Offset: 0x00160DBF
		public unsafe ERBFKernalType KernalType
		{
			get
			{
				return (ERBFKernalType)(*(base.NativePtr + (IntPtr)URBFDriver.__PropertyOffset_KernalType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)URBFDriver.__PropertyOffset_KernalType) = (int)value;
			}
		}

		// Token: 0x170039E2 RID: 14818
		// (get) Token: 0x0600EF32 RID: 61234 RVA: 0x00162BD0 File Offset: 0x00160DD0
		// (set) Token: 0x0600EF33 RID: 61235 RVA: 0x00162BE0 File Offset: 0x00160DE0
		public unsafe ERBFSolveInterpMode SolveInterpMode
		{
			get
			{
				return (ERBFSolveInterpMode)(*(base.NativePtr + (IntPtr)URBFDriver.__PropertyOffset_SolveInterpMode));
			}
			set
			{
				*(base.NativePtr + (IntPtr)URBFDriver.__PropertyOffset_SolveInterpMode) = (int)value;
			}
		}

		// Token: 0x170039E3 RID: 14819
		// (get) Token: 0x0600EF34 RID: 61236 RVA: 0x00162BF1 File Offset: 0x00160DF1
		// (set) Token: 0x0600EF35 RID: 61237 RVA: 0x00162C05 File Offset: 0x00160E05
		[Nullable(0)]
		public unsafe TEnumAsByte<ERichCurveInterpMode> BakingCurveInterpMode
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)URBFDriver.__PropertyOffset_BakingCurveInterpMode);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)URBFDriver.__PropertyOffset_BakingCurveInterpMode) = value;
			}
		}

		// Token: 0x170039E4 RID: 14820
		// (get) Token: 0x0600EF36 RID: 61238 RVA: 0x00162C1A File Offset: 0x00160E1A
		// (set) Token: 0x0600EF37 RID: 61239 RVA: 0x00162C2A File Offset: 0x00160E2A
		public unsafe int BakingCurvePrecisionFactor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URBFDriver.__PropertyOffset_BakingCurvePrecisionFactor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)URBFDriver.__PropertyOffset_BakingCurvePrecisionFactor) = value;
			}
		}

		// Token: 0x170039E5 RID: 14821
		// (get) Token: 0x0600EF38 RID: 61240 RVA: 0x00162C3C File Offset: 0x00160E3C
		// (set) Token: 0x0600EF39 RID: 61241 RVA: 0x00162C75 File Offset: 0x00160E75
		public FRBFWeightModifier WeightModifier
		{
			get
			{
				base.FastCheckIsValid();
				FRBFWeightModifier result;
				if ((result = this._WeightModifier) == null)
				{
					result = (this._WeightModifier = new FRBFWeightModifier(base.NativePtr + (IntPtr)URBFDriver.__PropertyOffset_WeightModifier, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRBFWeightModifier.StaticStruct(), base.NativePtr + (IntPtr)URBFDriver.__PropertyOffset_WeightModifier, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170039E6 RID: 14822
		// (get) Token: 0x0600EF3A RID: 61242 RVA: 0x00162C98 File Offset: 0x00160E98
		// (set) Token: 0x0600EF3B RID: 61243 RVA: 0x00162CD1 File Offset: 0x00160ED1
		public TArray<ERBFDriverAttribute> DriverAttributes
		{
			get
			{
				base.FastCheckIsValid();
				TArray<ERBFDriverAttribute> result;
				if ((result = this._DriverAttributes) == null)
				{
					result = (this._DriverAttributes = new TArray<ERBFDriverAttribute>(base.NativePtr + (IntPtr)URBFDriver.__PropertyOffset_DriverAttributes, this));
				}
				return result;
			}
			set
			{
				this.DriverAttributes.CopyAssign(value);
			}
		}

		// Token: 0x170039E7 RID: 14823
		// (get) Token: 0x0600EF3C RID: 61244 RVA: 0x00162CE0 File Offset: 0x00160EE0
		// (set) Token: 0x0600EF3D RID: 61245 RVA: 0x00162D19 File Offset: 0x00160F19
		public TArray<FName> DrivenMorphTargets
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._DrivenMorphTargets) == null)
				{
					result = (this._DrivenMorphTargets = new TArray<FName>(base.NativePtr + (IntPtr)URBFDriver.__PropertyOffset_DrivenMorphTargets, this));
				}
				return result;
			}
			set
			{
				this.DrivenMorphTargets.CopyAssign(value);
			}
		}

		// Token: 0x170039E8 RID: 14824
		// (get) Token: 0x0600EF3E RID: 61246 RVA: 0x00162D28 File Offset: 0x00160F28
		// (set) Token: 0x0600EF3F RID: 61247 RVA: 0x00162D61 File Offset: 0x00160F61
		public TArray<FRBFDriveSetting> DriveSettings
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FRBFDriveSetting> result;
				if ((result = this._DriveSettings) == null)
				{
					result = (this._DriveSettings = new TArray<FRBFDriveSetting>(base.NativePtr + (IntPtr)URBFDriver.__PropertyOffset_DriveSettings, this));
				}
				return result;
			}
			set
			{
				this.DriveSettings.CopyAssign(value);
			}
		}

		// Token: 0x0600EF40 RID: 61248 RVA: 0x00162D6F File Offset: 0x00160F6F
		static URBFDriver()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.RBFDriver");
		}

		// Token: 0x0600EF41 RID: 61249 RVA: 0x00162D7D File Offset: 0x00160F7D
		protected URBFDriver(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04008166 RID: 33126
		public new const string __ObjectPath = "/Script/Engine.RBFDriver";

		// Token: 0x04008167 RID: 33127
		private static IntPtr _ClassPtr;

		// Token: 0x04008168 RID: 33128
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04008169 RID: 33129
		internal static int __PropertyOffset_DriverName;

		// Token: 0x0400816A RID: 33130
		internal static int __PropertyOffset_DriverBoneName;

		// Token: 0x0400816B RID: 33131
		internal static int __PropertyOffset_BaseBoneName;

		// Token: 0x0400816C RID: 33132
		internal static int __PropertyOffset_DistanceType;

		// Token: 0x0400816D RID: 33133
		internal static int __PropertyOffset_KernalType;

		// Token: 0x0400816E RID: 33134
		internal static int __PropertyOffset_SolveInterpMode;

		// Token: 0x0400816F RID: 33135
		internal static int __PropertyOffset_BakingCurveInterpMode;

		// Token: 0x04008170 RID: 33136
		internal static int __PropertyOffset_BakingCurvePrecisionFactor;

		// Token: 0x04008171 RID: 33137
		internal static int __PropertyOffset_WeightModifier;

		// Token: 0x04008172 RID: 33138
		[Nullable(2)]
		private FRBFWeightModifier _WeightModifier;

		// Token: 0x04008173 RID: 33139
		internal static int __PropertyOffset_DriverAttributes;

		// Token: 0x04008174 RID: 33140
		[Nullable(2)]
		private TArray<ERBFDriverAttribute> _DriverAttributes;

		// Token: 0x04008175 RID: 33141
		internal static int __PropertyOffset_DrivenMorphTargets;

		// Token: 0x04008176 RID: 33142
		[Nullable(2)]
		private TArray<FName> _DrivenMorphTargets;

		// Token: 0x04008177 RID: 33143
		internal static int __PropertyOffset_DriveSettings;

		// Token: 0x04008178 RID: 33144
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FRBFDriveSetting> _DriveSettings;
	}
}
