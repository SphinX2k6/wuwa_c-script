using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002268 RID: 8808
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/MagtModule.MagtAdaptivePerformanceSettings")]
	[UnrealStructLayout(208, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 208)]
	public class UMagtAdaptivePerformanceSettings : UDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602178C RID: 137100 RVA: 0x00317066 File Offset: 0x00315266
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMagtAdaptivePerformanceSettings._ClassPtr;
		}

		// Token: 0x0602178D RID: 137101 RVA: 0x00317074 File Offset: 0x00315274
		public UMagtAdaptivePerformanceSettings() : this(BuiltinUtils.AllocNativeUObject(UMagtAdaptivePerformanceSettings.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602178E RID: 137102 RVA: 0x0031709C File Offset: 0x0031529C
		public UMagtAdaptivePerformanceSettings(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMagtAdaptivePerformanceSettings.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17008224 RID: 33316
		// (get) Token: 0x0602178F RID: 137103 RVA: 0x003170D0 File Offset: 0x003152D0
		// (set) Token: 0x06021790 RID: 137104 RVA: 0x00317109 File Offset: 0x00315309
		public TArray<FMagtAPQualityGroup> QualityGroups
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FMagtAPQualityGroup> result;
				if ((result = this._QualityGroups) == null)
				{
					result = (this._QualityGroups = new TArray<FMagtAPQualityGroup>(base.NativePtr + (IntPtr)UMagtAdaptivePerformanceSettings.__PropertyOffset_QualityGroups, this));
				}
				return result;
			}
			set
			{
				this.QualityGroups.CopyAssign(value);
			}
		}

		// Token: 0x17008225 RID: 33317
		// (get) Token: 0x06021791 RID: 137105 RVA: 0x00317117 File Offset: 0x00315317
		// (set) Token: 0x06021792 RID: 137106 RVA: 0x00317127 File Offset: 0x00315327
		public unsafe float FastEvaluationInterval
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMagtAdaptivePerformanceSettings.__PropertyOffset_FastEvaluationInterval);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMagtAdaptivePerformanceSettings.__PropertyOffset_FastEvaluationInterval) = value;
			}
		}

		// Token: 0x17008226 RID: 33318
		// (get) Token: 0x06021793 RID: 137107 RVA: 0x00317138 File Offset: 0x00315338
		// (set) Token: 0x06021794 RID: 137108 RVA: 0x00317148 File Offset: 0x00315348
		public unsafe float PowerUpdateInterval
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMagtAdaptivePerformanceSettings.__PropertyOffset_PowerUpdateInterval);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMagtAdaptivePerformanceSettings.__PropertyOffset_PowerUpdateInterval) = value;
			}
		}

		// Token: 0x17008227 RID: 33319
		// (get) Token: 0x06021795 RID: 137109 RVA: 0x00317159 File Offset: 0x00315359
		// (set) Token: 0x06021796 RID: 137110 RVA: 0x00317169 File Offset: 0x00315369
		public unsafe float PowerJudgeInterval
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMagtAdaptivePerformanceSettings.__PropertyOffset_PowerJudgeInterval);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMagtAdaptivePerformanceSettings.__PropertyOffset_PowerJudgeInterval) = value;
			}
		}

		// Token: 0x17008228 RID: 33320
		// (get) Token: 0x06021797 RID: 137111 RVA: 0x0031717A File Offset: 0x0031537A
		// (set) Token: 0x06021798 RID: 137112 RVA: 0x0031718A File Offset: 0x0031538A
		public unsafe int PowerHistorySize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMagtAdaptivePerformanceSettings.__PropertyOffset_PowerHistorySize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMagtAdaptivePerformanceSettings.__PropertyOffset_PowerHistorySize) = value;
			}
		}

		// Token: 0x17008229 RID: 33321
		// (get) Token: 0x06021799 RID: 137113 RVA: 0x0031719B File Offset: 0x0031539B
		// (set) Token: 0x0602179A RID: 137114 RVA: 0x003171AB File Offset: 0x003153AB
		public unsafe float CooldownTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMagtAdaptivePerformanceSettings.__PropertyOffset_CooldownTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMagtAdaptivePerformanceSettings.__PropertyOffset_CooldownTime) = value;
			}
		}

		// Token: 0x1700822A RID: 33322
		// (get) Token: 0x0602179B RID: 137115 RVA: 0x003171BC File Offset: 0x003153BC
		// (set) Token: 0x0602179C RID: 137116 RVA: 0x003171CC File Offset: 0x003153CC
		public unsafe bool bOnlyAdjustDifferences
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMagtAdaptivePerformanceSettings.__PropertyOffset_bOnlyAdjustDifferences) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMagtAdaptivePerformanceSettings.__PropertyOffset_bOnlyAdjustDifferences) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700822B RID: 33323
		// (get) Token: 0x0602179D RID: 137117 RVA: 0x003171E0 File Offset: 0x003153E0
		// (set) Token: 0x0602179E RID: 137118 RVA: 0x00317219 File Offset: 0x00315419
		public TMap<int, FMagtAPPowerThreshold> PowerThresholds
		{
			get
			{
				base.FastCheckIsValid();
				TMap<int, FMagtAPPowerThreshold> result;
				if ((result = this._PowerThresholds) == null)
				{
					result = (this._PowerThresholds = new TMap<int, FMagtAPPowerThreshold>(base.NativePtr + (IntPtr)UMagtAdaptivePerformanceSettings.__PropertyOffset_PowerThresholds, this));
				}
				return result;
			}
			set
			{
				this.PowerThresholds.CopyAssign(value);
			}
		}

		// Token: 0x1700822C RID: 33324
		// (get) Token: 0x0602179F RID: 137119 RVA: 0x00317227 File Offset: 0x00315427
		// (set) Token: 0x060217A0 RID: 137120 RVA: 0x00317237 File Offset: 0x00315437
		public unsafe int CPUHighLoadingStatusThreshold
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMagtAdaptivePerformanceSettings.__PropertyOffset_CPUHighLoadingStatusThreshold);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMagtAdaptivePerformanceSettings.__PropertyOffset_CPUHighLoadingStatusThreshold) = value;
			}
		}

		// Token: 0x1700822D RID: 33325
		// (get) Token: 0x060217A1 RID: 137121 RVA: 0x00317248 File Offset: 0x00315448
		// (set) Token: 0x060217A2 RID: 137122 RVA: 0x00317258 File Offset: 0x00315458
		public unsafe int CPUHighLoadingLoadThreshold
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMagtAdaptivePerformanceSettings.__PropertyOffset_CPUHighLoadingLoadThreshold);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMagtAdaptivePerformanceSettings.__PropertyOffset_CPUHighLoadingLoadThreshold) = value;
			}
		}

		// Token: 0x1700822E RID: 33326
		// (get) Token: 0x060217A3 RID: 137123 RVA: 0x00317269 File Offset: 0x00315469
		// (set) Token: 0x060217A4 RID: 137124 RVA: 0x00317279 File Offset: 0x00315479
		public unsafe int GPUHighLoadingStatusThreshold
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMagtAdaptivePerformanceSettings.__PropertyOffset_GPUHighLoadingStatusThreshold);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMagtAdaptivePerformanceSettings.__PropertyOffset_GPUHighLoadingStatusThreshold) = value;
			}
		}

		// Token: 0x1700822F RID: 33327
		// (get) Token: 0x060217A5 RID: 137125 RVA: 0x0031728A File Offset: 0x0031548A
		// (set) Token: 0x060217A6 RID: 137126 RVA: 0x0031729A File Offset: 0x0031549A
		public unsafe int GPUHighLoadingLoadThreshold
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMagtAdaptivePerformanceSettings.__PropertyOffset_GPUHighLoadingLoadThreshold);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMagtAdaptivePerformanceSettings.__PropertyOffset_GPUHighLoadingLoadThreshold) = value;
			}
		}

		// Token: 0x17008230 RID: 33328
		// (get) Token: 0x060217A7 RID: 137127 RVA: 0x003172AB File Offset: 0x003154AB
		// (set) Token: 0x060217A8 RID: 137128 RVA: 0x003172BB File Offset: 0x003154BB
		public unsafe bool bEnableOnScreenDebug
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMagtAdaptivePerformanceSettings.__PropertyOffset_bEnableOnScreenDebug) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMagtAdaptivePerformanceSettings.__PropertyOffset_bEnableOnScreenDebug) = (value ? 1 : 0);
			}
		}

		// Token: 0x17008231 RID: 33329
		// (get) Token: 0x060217A9 RID: 137129 RVA: 0x003172CC File Offset: 0x003154CC
		// (set) Token: 0x060217AA RID: 137130 RVA: 0x003172DC File Offset: 0x003154DC
		public unsafe bool bEnableVerboseLogging
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMagtAdaptivePerformanceSettings.__PropertyOffset_bEnableVerboseLogging) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMagtAdaptivePerformanceSettings.__PropertyOffset_bEnableVerboseLogging) = (value ? 1 : 0);
			}
		}

		// Token: 0x060217AB RID: 137131 RVA: 0x003172F0 File Offset: 0x003154F0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool ValidateSettings([Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<string> OutErrors)
		{
			UMagtAdaptivePerformanceSettings.__ValidateSettings_FunctionParams* ptr = stackalloc UMagtAdaptivePerformanceSettings.__ValidateSettings_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(UMagtAdaptivePerformanceSettings.__ValidateSettings_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMagtAdaptivePerformanceSettings.__ValidateSettings_NativeFunctionPtr, (void*)ptr, 1);
			TArray<string> tarray = OutErrors;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->OutErrors);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMagtAdaptivePerformanceSettings.__ValidateSettings_NativeFunctionPtr, (void*)ptr, 0);
			TArray<string> tarray2 = OutErrors;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->OutErrors);
			}
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(UMagtAdaptivePerformanceSettings.__ValidateSettings_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x060217AC RID: 137132 RVA: 0x00317370 File Offset: 0x00315570
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe FMagtAPPowerThreshold GetPowerThreshold(int ThermalStatus)
		{
			UMagtAdaptivePerformanceSettings.__GetPowerThreshold_FunctionParams* ptr = stackalloc UMagtAdaptivePerformanceSettings.__GetPowerThreshold_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(UMagtAdaptivePerformanceSettings.__GetPowerThreshold_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMagtAdaptivePerformanceSettings.__GetPowerThreshold_NativeFunctionPtr, (void*)ptr, 1);
			ptr->ThermalStatus = ThermalStatus;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMagtAdaptivePerformanceSettings.__GetPowerThreshold_NativeFunctionPtr, (void*)ptr, 0);
			return new FMagtAPPowerThreshold(&ptr->__Result, true, true);
		}

		// Token: 0x060217AD RID: 137133 RVA: 0x003173C8 File Offset: 0x003155C8
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool FindQualityGroupByName(FName GroupName, ref FMagtAPQualityGroup OutGroup)
		{
			UMagtAdaptivePerformanceSettings.__FindQualityGroupByName_FunctionParams* ptr = stackalloc UMagtAdaptivePerformanceSettings.__FindQualityGroupByName_FunctionParams[(UIntPtr)183] + 15L / (long)sizeof(UMagtAdaptivePerformanceSettings.__FindQualityGroupByName_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMagtAdaptivePerformanceSettings.__FindQualityGroupByName_NativeFunctionPtr, (void*)ptr, 1);
			ptr->GroupName = GroupName;
			if (OutGroup != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FMagtAPQualityGroup.StaticStruct(), &ptr->OutGroup, OutGroup.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMagtAdaptivePerformanceSettings.__FindQualityGroupByName_NativeFunctionPtr, (void*)ptr, 0);
			if (OutGroup != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FMagtAPQualityGroup.StaticStruct(), OutGroup.NativePtr, &ptr->OutGroup, 1, false);
			}
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(UMagtAdaptivePerformanceSettings.__FindQualityGroupByName_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x060217AE RID: 137134 RVA: 0x00317471 File Offset: 0x00315671
		static UMagtAdaptivePerformanceSettings()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MagtModule.MagtAdaptivePerformanceSettings");
		}

		// Token: 0x060217AF RID: 137135 RVA: 0x0031747F File Offset: 0x0031567F
		protected UMagtAdaptivePerformanceSettings(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011DF2 RID: 73202
		public new const string __ObjectPath = "/Script/MagtModule.MagtAdaptivePerformanceSettings";

		// Token: 0x04011DF3 RID: 73203
		private static IntPtr _ClassPtr;

		// Token: 0x04011DF4 RID: 73204
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011DF5 RID: 73205
		internal static int __PropertyOffset_QualityGroups;

		// Token: 0x04011DF6 RID: 73206
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FMagtAPQualityGroup> _QualityGroups;

		// Token: 0x04011DF7 RID: 73207
		internal static int __PropertyOffset_FastEvaluationInterval;

		// Token: 0x04011DF8 RID: 73208
		internal static int __PropertyOffset_PowerUpdateInterval;

		// Token: 0x04011DF9 RID: 73209
		internal static int __PropertyOffset_PowerJudgeInterval;

		// Token: 0x04011DFA RID: 73210
		internal static int __PropertyOffset_PowerHistorySize;

		// Token: 0x04011DFB RID: 73211
		internal static int __PropertyOffset_CooldownTime;

		// Token: 0x04011DFC RID: 73212
		internal static int __PropertyOffset_bOnlyAdjustDifferences;

		// Token: 0x04011DFD RID: 73213
		internal static int __PropertyOffset_PowerThresholds;

		// Token: 0x04011DFE RID: 73214
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<int, FMagtAPPowerThreshold> _PowerThresholds;

		// Token: 0x04011DFF RID: 73215
		internal static int __PropertyOffset_CPUHighLoadingStatusThreshold;

		// Token: 0x04011E00 RID: 73216
		internal static int __PropertyOffset_CPUHighLoadingLoadThreshold;

		// Token: 0x04011E01 RID: 73217
		internal static int __PropertyOffset_GPUHighLoadingStatusThreshold;

		// Token: 0x04011E02 RID: 73218
		internal static int __PropertyOffset_GPUHighLoadingLoadThreshold;

		// Token: 0x04011E03 RID: 73219
		internal static int __PropertyOffset_bEnableOnScreenDebug;

		// Token: 0x04011E04 RID: 73220
		internal static int __PropertyOffset_bEnableVerboseLogging;

		// Token: 0x04011E05 RID: 73221
		private static IntPtr __ValidateSettings_NativeFunctionPtr;

		// Token: 0x04011E06 RID: 73222
		private static IntPtr __GetPowerThreshold_NativeFunctionPtr;

		// Token: 0x04011E07 RID: 73223
		private static IntPtr __FindQualityGroupByName_NativeFunctionPtr;

		// Token: 0x020035A6 RID: 13734
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __ValidateSettings_FunctionParams
		{
			// Token: 0x040175DE RID: 95710
			[FieldOffset(0)]
			public byte OutErrors;

			// Token: 0x040175DF RID: 95711
			[FieldOffset(16)]
			public bool __Result;
		}

		// Token: 0x020035A7 RID: 13735
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __GetPowerThreshold_FunctionParams
		{
			// Token: 0x040175E0 RID: 95712
			[FieldOffset(0)]
			public int ThermalStatus;

			// Token: 0x040175E1 RID: 95713
			[FieldOffset(4)]
			public byte __Result;
		}

		// Token: 0x020035A8 RID: 13736
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 168)]
		protected ref struct __FindQualityGroupByName_FunctionParams
		{
			// Token: 0x040175E2 RID: 95714
			[FieldOffset(0)]
			public FName GroupName;

			// Token: 0x040175E3 RID: 95715
			[FieldOffset(16)]
			public byte OutGroup;

			// Token: 0x040175E4 RID: 95716
			[FieldOffset(160)]
			public bool __Result;
		}
	}
}
