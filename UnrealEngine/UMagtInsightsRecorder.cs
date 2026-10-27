using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200225E RID: 8798
	[UnrealObjectPath("/Script/MagtInsights.MagtInsightsRecorder")]
	[UnrealStructLayout(136, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 136)]
	public class UMagtInsightsRecorder : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060216D4 RID: 136916 RVA: 0x0031461E File Offset: 0x0031281E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMagtInsightsRecorder._ClassPtr;
		}

		// Token: 0x060216D5 RID: 136917 RVA: 0x0031462C File Offset: 0x0031282C
		public UMagtInsightsRecorder() : this(BuiltinUtils.AllocNativeUObject(UMagtInsightsRecorder.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060216D6 RID: 136918 RVA: 0x00314654 File Offset: 0x00312854
		[NullableContext(1)]
		public UMagtInsightsRecorder(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMagtInsightsRecorder.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060216D7 RID: 136919 RVA: 0x00314687 File Offset: 0x00312887
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void UseFullConfig()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMagtInsightsRecorder.__UseFullConfig_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060216D8 RID: 136920 RVA: 0x0031469C File Offset: 0x0031289C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void UseCommonConfig()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMagtInsightsRecorder.__UseCommonConfig_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060216D9 RID: 136921 RVA: 0x003146B1 File Offset: 0x003128B1
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void StopRecording()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMagtInsightsRecorder.__StopRecording_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060216DA RID: 136922 RVA: 0x003146C8 File Offset: 0x003128C8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool StartRecording(int SamplingIntervalMs = 500)
		{
			UMagtInsightsRecorder.__StartRecording_FunctionParams* ptr = stackalloc UMagtInsightsRecorder.__StartRecording_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UMagtInsightsRecorder.__StartRecording_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMagtInsightsRecorder.__StartRecording_NativeFunctionPtr, (void*)ptr, 1);
			ptr->SamplingIntervalMs = SamplingIntervalMs;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMagtInsightsRecorder.__StartRecording_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x060216DB RID: 136923 RVA: 0x00314718 File Offset: 0x00312918
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool SetSamplingInterval(int IntervalMs)
		{
			UMagtInsightsRecorder.__SetSamplingInterval_FunctionParams* ptr = stackalloc UMagtInsightsRecorder.__SetSamplingInterval_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UMagtInsightsRecorder.__SetSamplingInterval_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMagtInsightsRecorder.__SetSamplingInterval_NativeFunctionPtr, (void*)ptr, 1);
			ptr->IntervalMs = IntervalMs;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMagtInsightsRecorder.__SetSamplingInterval_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x060216DC RID: 136924 RVA: 0x00314768 File Offset: 0x00312968
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetRecordThermalStatus(bool bEnable)
		{
			UMagtInsightsRecorder.__SetRecordThermalStatus_FunctionParams* ptr = stackalloc UMagtInsightsRecorder.__SetRecordThermalStatus_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UMagtInsightsRecorder.__SetRecordThermalStatus_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMagtInsightsRecorder.__SetRecordThermalStatus_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bEnable = bEnable;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMagtInsightsRecorder.__SetRecordThermalStatus_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060216DD RID: 136925 RVA: 0x003147B0 File Offset: 0x003129B0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetRecordTempSkinDef3(bool bEnable)
		{
			UMagtInsightsRecorder.__SetRecordTempSkinDef3_FunctionParams* ptr = stackalloc UMagtInsightsRecorder.__SetRecordTempSkinDef3_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UMagtInsightsRecorder.__SetRecordTempSkinDef3_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMagtInsightsRecorder.__SetRecordTempSkinDef3_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bEnable = bEnable;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMagtInsightsRecorder.__SetRecordTempSkinDef3_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060216DE RID: 136926 RVA: 0x003147F8 File Offset: 0x003129F8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetRecordTempSkinDef2(bool bEnable)
		{
			UMagtInsightsRecorder.__SetRecordTempSkinDef2_FunctionParams* ptr = stackalloc UMagtInsightsRecorder.__SetRecordTempSkinDef2_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UMagtInsightsRecorder.__SetRecordTempSkinDef2_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMagtInsightsRecorder.__SetRecordTempSkinDef2_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bEnable = bEnable;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMagtInsightsRecorder.__SetRecordTempSkinDef2_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060216DF RID: 136927 RVA: 0x00314840 File Offset: 0x00312A40
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetRecordTempSkinDef(bool bEnable)
		{
			UMagtInsightsRecorder.__SetRecordTempSkinDef_FunctionParams* ptr = stackalloc UMagtInsightsRecorder.__SetRecordTempSkinDef_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UMagtInsightsRecorder.__SetRecordTempSkinDef_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMagtInsightsRecorder.__SetRecordTempSkinDef_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bEnable = bEnable;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMagtInsightsRecorder.__SetRecordTempSkinDef_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060216E0 RID: 136928 RVA: 0x00314888 File Offset: 0x00312A88
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetRecordTempSkin(bool bEnable)
		{
			UMagtInsightsRecorder.__SetRecordTempSkin_FunctionParams* ptr = stackalloc UMagtInsightsRecorder.__SetRecordTempSkin_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UMagtInsightsRecorder.__SetRecordTempSkin_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMagtInsightsRecorder.__SetRecordTempSkin_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bEnable = bEnable;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMagtInsightsRecorder.__SetRecordTempSkin_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060216E1 RID: 136929 RVA: 0x003148D0 File Offset: 0x00312AD0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetRecordTempGPU(bool bEnable)
		{
			UMagtInsightsRecorder.__SetRecordTempGPU_FunctionParams* ptr = stackalloc UMagtInsightsRecorder.__SetRecordTempGPU_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UMagtInsightsRecorder.__SetRecordTempGPU_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMagtInsightsRecorder.__SetRecordTempGPU_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bEnable = bEnable;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMagtInsightsRecorder.__SetRecordTempGPU_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060216E2 RID: 136930 RVA: 0x00314918 File Offset: 0x00312B18
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetRecordTempFPSThrottle(bool bEnable)
		{
			UMagtInsightsRecorder.__SetRecordTempFPSThrottle_FunctionParams* ptr = stackalloc UMagtInsightsRecorder.__SetRecordTempFPSThrottle_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UMagtInsightsRecorder.__SetRecordTempFPSThrottle_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMagtInsightsRecorder.__SetRecordTempFPSThrottle_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bEnable = bEnable;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMagtInsightsRecorder.__SetRecordTempFPSThrottle_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060216E3 RID: 136931 RVA: 0x00314960 File Offset: 0x00312B60
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetRecordTempCPU(bool bEnable)
		{
			UMagtInsightsRecorder.__SetRecordTempCPU_FunctionParams* ptr = stackalloc UMagtInsightsRecorder.__SetRecordTempCPU_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UMagtInsightsRecorder.__SetRecordTempCPU_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMagtInsightsRecorder.__SetRecordTempCPU_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bEnable = bEnable;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMagtInsightsRecorder.__SetRecordTempCPU_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060216E4 RID: 136932 RVA: 0x003149A8 File Offset: 0x00312BA8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetRecordTempBat(bool bEnable)
		{
			UMagtInsightsRecorder.__SetRecordTempBat_FunctionParams* ptr = stackalloc UMagtInsightsRecorder.__SetRecordTempBat_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UMagtInsightsRecorder.__SetRecordTempBat_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMagtInsightsRecorder.__SetRecordTempBat_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bEnable = bEnable;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMagtInsightsRecorder.__SetRecordTempBat_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060216E5 RID: 136933 RVA: 0x003149F0 File Offset: 0x00312BF0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetRecordTempAllData(bool bEnable)
		{
			UMagtInsightsRecorder.__SetRecordTempAllData_FunctionParams* ptr = stackalloc UMagtInsightsRecorder.__SetRecordTempAllData_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UMagtInsightsRecorder.__SetRecordTempAllData_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMagtInsightsRecorder.__SetRecordTempAllData_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bEnable = bEnable;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMagtInsightsRecorder.__SetRecordTempAllData_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060216E6 RID: 136934 RVA: 0x00314A38 File Offset: 0x00312C38
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetRecordTargetFPS(bool bEnable)
		{
			UMagtInsightsRecorder.__SetRecordTargetFPS_FunctionParams* ptr = stackalloc UMagtInsightsRecorder.__SetRecordTargetFPS_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UMagtInsightsRecorder.__SetRecordTargetFPS_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMagtInsightsRecorder.__SetRecordTargetFPS_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bEnable = bEnable;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMagtInsightsRecorder.__SetRecordTargetFPS_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060216E7 RID: 136935 RVA: 0x00314A80 File Offset: 0x00312C80
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetRecordStatAllData(bool bEnable)
		{
			UMagtInsightsRecorder.__SetRecordStatAllData_FunctionParams* ptr = stackalloc UMagtInsightsRecorder.__SetRecordStatAllData_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UMagtInsightsRecorder.__SetRecordStatAllData_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMagtInsightsRecorder.__SetRecordStatAllData_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bEnable = bEnable;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMagtInsightsRecorder.__SetRecordStatAllData_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060216E8 RID: 136936 RVA: 0x00314AC8 File Offset: 0x00312CC8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetRecordMemoryInfoTotalFree(bool bEnable)
		{
			UMagtInsightsRecorder.__SetRecordMemoryInfoTotalFree_FunctionParams* ptr = stackalloc UMagtInsightsRecorder.__SetRecordMemoryInfoTotalFree_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UMagtInsightsRecorder.__SetRecordMemoryInfoTotalFree_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMagtInsightsRecorder.__SetRecordMemoryInfoTotalFree_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bEnable = bEnable;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMagtInsightsRecorder.__SetRecordMemoryInfoTotalFree_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060216E9 RID: 136937 RVA: 0x00314B10 File Offset: 0x00312D10
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetRecordMemoryInfoAvailUsed(bool bEnable)
		{
			UMagtInsightsRecorder.__SetRecordMemoryInfoAvailUsed_FunctionParams* ptr = stackalloc UMagtInsightsRecorder.__SetRecordMemoryInfoAvailUsed_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UMagtInsightsRecorder.__SetRecordMemoryInfoAvailUsed_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMagtInsightsRecorder.__SetRecordMemoryInfoAvailUsed_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bEnable = bEnable;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMagtInsightsRecorder.__SetRecordMemoryInfoAvailUsed_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060216EA RID: 136938 RVA: 0x00314B58 File Offset: 0x00312D58
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetRecordHWPTValue(bool bEnable)
		{
			UMagtInsightsRecorder.__SetRecordHWPTValue_FunctionParams* ptr = stackalloc UMagtInsightsRecorder.__SetRecordHWPTValue_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UMagtInsightsRecorder.__SetRecordHWPTValue_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMagtInsightsRecorder.__SetRecordHWPTValue_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bEnable = bEnable;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMagtInsightsRecorder.__SetRecordHWPTValue_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060216EB RID: 136939 RVA: 0x00314BA0 File Offset: 0x00312DA0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetRecordHWPTDurationUS(bool bEnable)
		{
			UMagtInsightsRecorder.__SetRecordHWPTDurationUS_FunctionParams* ptr = stackalloc UMagtInsightsRecorder.__SetRecordHWPTDurationUS_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UMagtInsightsRecorder.__SetRecordHWPTDurationUS_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMagtInsightsRecorder.__SetRecordHWPTDurationUS_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bEnable = bEnable;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMagtInsightsRecorder.__SetRecordHWPTDurationUS_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060216EC RID: 136940 RVA: 0x00314BE8 File Offset: 0x00312DE8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetRecordHWPTDurationMS(bool bEnable)
		{
			UMagtInsightsRecorder.__SetRecordHWPTDurationMS_FunctionParams* ptr = stackalloc UMagtInsightsRecorder.__SetRecordHWPTDurationMS_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UMagtInsightsRecorder.__SetRecordHWPTDurationMS_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMagtInsightsRecorder.__SetRecordHWPTDurationMS_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bEnable = bEnable;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMagtInsightsRecorder.__SetRecordHWPTDurationMS_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060216ED RID: 136941 RVA: 0x00314C30 File Offset: 0x00312E30
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetRecordHWPTAllData(bool bEnable)
		{
			UMagtInsightsRecorder.__SetRecordHWPTAllData_FunctionParams* ptr = stackalloc UMagtInsightsRecorder.__SetRecordHWPTAllData_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UMagtInsightsRecorder.__SetRecordHWPTAllData_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMagtInsightsRecorder.__SetRecordHWPTAllData_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bEnable = bEnable;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMagtInsightsRecorder.__SetRecordHWPTAllData_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060216EE RID: 136942 RVA: 0x00314C78 File Offset: 0x00312E78
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetRecordGPUFreq(bool bEnable)
		{
			UMagtInsightsRecorder.__SetRecordGPUFreq_FunctionParams* ptr = stackalloc UMagtInsightsRecorder.__SetRecordGPUFreq_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UMagtInsightsRecorder.__SetRecordGPUFreq_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMagtInsightsRecorder.__SetRecordGPUFreq_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bEnable = bEnable;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMagtInsightsRecorder.__SetRecordGPUFreq_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060216EF RID: 136943 RVA: 0x00314CC0 File Offset: 0x00312EC0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetRecordGPUFrameTime(bool bEnable)
		{
			UMagtInsightsRecorder.__SetRecordGPUFrameTime_FunctionParams* ptr = stackalloc UMagtInsightsRecorder.__SetRecordGPUFrameTime_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UMagtInsightsRecorder.__SetRecordGPUFrameTime_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMagtInsightsRecorder.__SetRecordGPUFrameTime_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bEnable = bEnable;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMagtInsightsRecorder.__SetRecordGPUFrameTime_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060216F0 RID: 136944 RVA: 0x00314D08 File Offset: 0x00312F08
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetRecordGPUAvgURate(bool bEnable)
		{
			UMagtInsightsRecorder.__SetRecordGPUAvgURate_FunctionParams* ptr = stackalloc UMagtInsightsRecorder.__SetRecordGPUAvgURate_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UMagtInsightsRecorder.__SetRecordGPUAvgURate_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMagtInsightsRecorder.__SetRecordGPUAvgURate_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bEnable = bEnable;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMagtInsightsRecorder.__SetRecordGPUAvgURate_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060216F1 RID: 136945 RVA: 0x00314D50 File Offset: 0x00312F50
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetRecordGPUAllData(bool bEnable)
		{
			UMagtInsightsRecorder.__SetRecordGPUAllData_FunctionParams* ptr = stackalloc UMagtInsightsRecorder.__SetRecordGPUAllData_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UMagtInsightsRecorder.__SetRecordGPUAllData_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMagtInsightsRecorder.__SetRecordGPUAllData_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bEnable = bEnable;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMagtInsightsRecorder.__SetRecordGPUAllData_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060216F2 RID: 136946 RVA: 0x00314D98 File Offset: 0x00312F98
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetRecordFPSControlStatus(bool bEnable)
		{
			UMagtInsightsRecorder.__SetRecordFPSControlStatus_FunctionParams* ptr = stackalloc UMagtInsightsRecorder.__SetRecordFPSControlStatus_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UMagtInsightsRecorder.__SetRecordFPSControlStatus_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMagtInsightsRecorder.__SetRecordFPSControlStatus_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bEnable = bEnable;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMagtInsightsRecorder.__SetRecordFPSControlStatus_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060216F3 RID: 136947 RVA: 0x00314DE0 File Offset: 0x00312FE0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetRecordCriticalThreadDep(bool bEnable)
		{
			UMagtInsightsRecorder.__SetRecordCriticalThreadDep_FunctionParams* ptr = stackalloc UMagtInsightsRecorder.__SetRecordCriticalThreadDep_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UMagtInsightsRecorder.__SetRecordCriticalThreadDep_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMagtInsightsRecorder.__SetRecordCriticalThreadDep_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bEnable = bEnable;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMagtInsightsRecorder.__SetRecordCriticalThreadDep_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060216F4 RID: 136948 RVA: 0x00314E28 File Offset: 0x00313028
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetRecordCriticalThreadBG(bool bEnable)
		{
			UMagtInsightsRecorder.__SetRecordCriticalThreadBG_FunctionParams* ptr = stackalloc UMagtInsightsRecorder.__SetRecordCriticalThreadBG_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UMagtInsightsRecorder.__SetRecordCriticalThreadBG_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMagtInsightsRecorder.__SetRecordCriticalThreadBG_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bEnable = bEnable;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMagtInsightsRecorder.__SetRecordCriticalThreadBG_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060216F5 RID: 136949 RVA: 0x00314E70 File Offset: 0x00313070
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetRecordCPUMCoreNum(bool bEnable)
		{
			UMagtInsightsRecorder.__SetRecordCPUMCoreNum_FunctionParams* ptr = stackalloc UMagtInsightsRecorder.__SetRecordCPUMCoreNum_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UMagtInsightsRecorder.__SetRecordCPUMCoreNum_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMagtInsightsRecorder.__SetRecordCPUMCoreNum_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bEnable = bEnable;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMagtInsightsRecorder.__SetRecordCPUMCoreNum_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060216F6 RID: 136950 RVA: 0x00314EB8 File Offset: 0x003130B8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetRecordCPUMCoreLoad(bool bEnable)
		{
			UMagtInsightsRecorder.__SetRecordCPUMCoreLoad_FunctionParams* ptr = stackalloc UMagtInsightsRecorder.__SetRecordCPUMCoreLoad_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UMagtInsightsRecorder.__SetRecordCPUMCoreLoad_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMagtInsightsRecorder.__SetRecordCPUMCoreLoad_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bEnable = bEnable;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMagtInsightsRecorder.__SetRecordCPUMCoreLoad_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060216F7 RID: 136951 RVA: 0x00314F00 File Offset: 0x00313100
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetRecordCPUMCoreFreq(bool bEnable)
		{
			UMagtInsightsRecorder.__SetRecordCPUMCoreFreq_FunctionParams* ptr = stackalloc UMagtInsightsRecorder.__SetRecordCPUMCoreFreq_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UMagtInsightsRecorder.__SetRecordCPUMCoreFreq_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMagtInsightsRecorder.__SetRecordCPUMCoreFreq_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bEnable = bEnable;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMagtInsightsRecorder.__SetRecordCPUMCoreFreq_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060216F8 RID: 136952 RVA: 0x00314F48 File Offset: 0x00313148
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetRecordCPULCoreNum(bool bEnable)
		{
			UMagtInsightsRecorder.__SetRecordCPULCoreNum_FunctionParams* ptr = stackalloc UMagtInsightsRecorder.__SetRecordCPULCoreNum_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UMagtInsightsRecorder.__SetRecordCPULCoreNum_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMagtInsightsRecorder.__SetRecordCPULCoreNum_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bEnable = bEnable;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMagtInsightsRecorder.__SetRecordCPULCoreNum_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060216F9 RID: 136953 RVA: 0x00314F90 File Offset: 0x00313190
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetRecordCPULCoreLoad(bool bEnable)
		{
			UMagtInsightsRecorder.__SetRecordCPULCoreLoad_FunctionParams* ptr = stackalloc UMagtInsightsRecorder.__SetRecordCPULCoreLoad_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UMagtInsightsRecorder.__SetRecordCPULCoreLoad_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMagtInsightsRecorder.__SetRecordCPULCoreLoad_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bEnable = bEnable;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMagtInsightsRecorder.__SetRecordCPULCoreLoad_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060216FA RID: 136954 RVA: 0x00314FD8 File Offset: 0x003131D8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetRecordCPULCoreFreq(bool bEnable)
		{
			UMagtInsightsRecorder.__SetRecordCPULCoreFreq_FunctionParams* ptr = stackalloc UMagtInsightsRecorder.__SetRecordCPULCoreFreq_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UMagtInsightsRecorder.__SetRecordCPULCoreFreq_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMagtInsightsRecorder.__SetRecordCPULCoreFreq_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bEnable = bEnable;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMagtInsightsRecorder.__SetRecordCPULCoreFreq_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060216FB RID: 136955 RVA: 0x00315020 File Offset: 0x00313220
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetRecordCPUFrameTime(bool bEnable)
		{
			UMagtInsightsRecorder.__SetRecordCPUFrameTime_FunctionParams* ptr = stackalloc UMagtInsightsRecorder.__SetRecordCPUFrameTime_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UMagtInsightsRecorder.__SetRecordCPUFrameTime_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMagtInsightsRecorder.__SetRecordCPUFrameTime_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bEnable = bEnable;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMagtInsightsRecorder.__SetRecordCPUFrameTime_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060216FC RID: 136956 RVA: 0x00315068 File Offset: 0x00313268
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetRecordCPUBCoreNum(bool bEnable)
		{
			UMagtInsightsRecorder.__SetRecordCPUBCoreNum_FunctionParams* ptr = stackalloc UMagtInsightsRecorder.__SetRecordCPUBCoreNum_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UMagtInsightsRecorder.__SetRecordCPUBCoreNum_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMagtInsightsRecorder.__SetRecordCPUBCoreNum_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bEnable = bEnable;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMagtInsightsRecorder.__SetRecordCPUBCoreNum_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060216FD RID: 136957 RVA: 0x003150B0 File Offset: 0x003132B0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetRecordCPUBCoreLoad(bool bEnable)
		{
			UMagtInsightsRecorder.__SetRecordCPUBCoreLoad_FunctionParams* ptr = stackalloc UMagtInsightsRecorder.__SetRecordCPUBCoreLoad_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UMagtInsightsRecorder.__SetRecordCPUBCoreLoad_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMagtInsightsRecorder.__SetRecordCPUBCoreLoad_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bEnable = bEnable;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMagtInsightsRecorder.__SetRecordCPUBCoreLoad_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060216FE RID: 136958 RVA: 0x003150F8 File Offset: 0x003132F8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetRecordCPUBCoreFreq(bool bEnable)
		{
			UMagtInsightsRecorder.__SetRecordCPUBCoreFreq_FunctionParams* ptr = stackalloc UMagtInsightsRecorder.__SetRecordCPUBCoreFreq_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UMagtInsightsRecorder.__SetRecordCPUBCoreFreq_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMagtInsightsRecorder.__SetRecordCPUBCoreFreq_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bEnable = bEnable;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMagtInsightsRecorder.__SetRecordCPUBCoreFreq_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060216FF RID: 136959 RVA: 0x00315140 File Offset: 0x00313340
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetRecordCPUAllData(bool bEnable)
		{
			UMagtInsightsRecorder.__SetRecordCPUAllData_FunctionParams* ptr = stackalloc UMagtInsightsRecorder.__SetRecordCPUAllData_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UMagtInsightsRecorder.__SetRecordCPUAllData_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMagtInsightsRecorder.__SetRecordCPUAllData_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bEnable = bEnable;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMagtInsightsRecorder.__SetRecordCPUAllData_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06021700 RID: 136960 RVA: 0x00315188 File Offset: 0x00313388
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetRecordBATNowVoltage(bool bEnable)
		{
			UMagtInsightsRecorder.__SetRecordBATNowVoltage_FunctionParams* ptr = stackalloc UMagtInsightsRecorder.__SetRecordBATNowVoltage_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UMagtInsightsRecorder.__SetRecordBATNowVoltage_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMagtInsightsRecorder.__SetRecordBATNowVoltage_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bEnable = bEnable;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMagtInsightsRecorder.__SetRecordBATNowVoltage_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06021701 RID: 136961 RVA: 0x003151D0 File Offset: 0x003133D0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetRecordBATNowPower(bool bEnable)
		{
			UMagtInsightsRecorder.__SetRecordBATNowPower_FunctionParams* ptr = stackalloc UMagtInsightsRecorder.__SetRecordBATNowPower_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UMagtInsightsRecorder.__SetRecordBATNowPower_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMagtInsightsRecorder.__SetRecordBATNowPower_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bEnable = bEnable;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMagtInsightsRecorder.__SetRecordBATNowPower_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06021702 RID: 136962 RVA: 0x00315218 File Offset: 0x00313418
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetRecordBATNowLevel(bool bEnable)
		{
			UMagtInsightsRecorder.__SetRecordBATNowLevel_FunctionParams* ptr = stackalloc UMagtInsightsRecorder.__SetRecordBATNowLevel_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UMagtInsightsRecorder.__SetRecordBATNowLevel_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMagtInsightsRecorder.__SetRecordBATNowLevel_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bEnable = bEnable;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMagtInsightsRecorder.__SetRecordBATNowLevel_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06021703 RID: 136963 RVA: 0x00315260 File Offset: 0x00313460
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetRecordBATNowCurrent(bool bEnable)
		{
			UMagtInsightsRecorder.__SetRecordBATNowCurrent_FunctionParams* ptr = stackalloc UMagtInsightsRecorder.__SetRecordBATNowCurrent_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UMagtInsightsRecorder.__SetRecordBATNowCurrent_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMagtInsightsRecorder.__SetRecordBATNowCurrent_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bEnable = bEnable;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMagtInsightsRecorder.__SetRecordBATNowCurrent_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06021704 RID: 136964 RVA: 0x003152A8 File Offset: 0x003134A8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetRecordBATNowCharging(bool bEnable)
		{
			UMagtInsightsRecorder.__SetRecordBATNowCharging_FunctionParams* ptr = stackalloc UMagtInsightsRecorder.__SetRecordBATNowCharging_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UMagtInsightsRecorder.__SetRecordBATNowCharging_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMagtInsightsRecorder.__SetRecordBATNowCharging_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bEnable = bEnable;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMagtInsightsRecorder.__SetRecordBATNowCharging_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06021705 RID: 136965 RVA: 0x003152F0 File Offset: 0x003134F0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetRecordBATAvgPower(bool bEnable)
		{
			UMagtInsightsRecorder.__SetRecordBATAvgPower_FunctionParams* ptr = stackalloc UMagtInsightsRecorder.__SetRecordBATAvgPower_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UMagtInsightsRecorder.__SetRecordBATAvgPower_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMagtInsightsRecorder.__SetRecordBATAvgPower_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bEnable = bEnable;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMagtInsightsRecorder.__SetRecordBATAvgPower_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06021706 RID: 136966 RVA: 0x00315338 File Offset: 0x00313538
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetRecordBATAvgCurrent(bool bEnable)
		{
			UMagtInsightsRecorder.__SetRecordBATAvgCurrent_FunctionParams* ptr = stackalloc UMagtInsightsRecorder.__SetRecordBATAvgCurrent_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UMagtInsightsRecorder.__SetRecordBATAvgCurrent_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMagtInsightsRecorder.__SetRecordBATAvgCurrent_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bEnable = bEnable;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMagtInsightsRecorder.__SetRecordBATAvgCurrent_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06021707 RID: 136967 RVA: 0x00315380 File Offset: 0x00313580
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetRecordBATAllData(bool bEnable)
		{
			UMagtInsightsRecorder.__SetRecordBATAllData_FunctionParams* ptr = stackalloc UMagtInsightsRecorder.__SetRecordBATAllData_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UMagtInsightsRecorder.__SetRecordBATAllData_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMagtInsightsRecorder.__SetRecordBATAllData_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bEnable = bEnable;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMagtInsightsRecorder.__SetRecordBATAllData_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06021708 RID: 136968 RVA: 0x003153C8 File Offset: 0x003135C8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetRecordBATAdvicePower(bool bEnable)
		{
			UMagtInsightsRecorder.__SetRecordBATAdvicePower_FunctionParams* ptr = stackalloc UMagtInsightsRecorder.__SetRecordBATAdvicePower_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UMagtInsightsRecorder.__SetRecordBATAdvicePower_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMagtInsightsRecorder.__SetRecordBATAdvicePower_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bEnable = bEnable;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMagtInsightsRecorder.__SetRecordBATAdvicePower_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06021709 RID: 136969 RVA: 0x00315410 File Offset: 0x00313610
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetRecordBATAdviceCurrent(bool bEnable)
		{
			UMagtInsightsRecorder.__SetRecordBATAdviceCurrent_FunctionParams* ptr = stackalloc UMagtInsightsRecorder.__SetRecordBATAdviceCurrent_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UMagtInsightsRecorder.__SetRecordBATAdviceCurrent_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMagtInsightsRecorder.__SetRecordBATAdviceCurrent_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bEnable = bEnable;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMagtInsightsRecorder.__SetRecordBATAdviceCurrent_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602170A RID: 136970 RVA: 0x00315458 File Offset: 0x00313658
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetRecordAllTemperatureMetrics(bool bEnable)
		{
			UMagtInsightsRecorder.__SetRecordAllTemperatureMetrics_FunctionParams* ptr = stackalloc UMagtInsightsRecorder.__SetRecordAllTemperatureMetrics_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UMagtInsightsRecorder.__SetRecordAllTemperatureMetrics_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMagtInsightsRecorder.__SetRecordAllTemperatureMetrics_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bEnable = bEnable;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMagtInsightsRecorder.__SetRecordAllTemperatureMetrics_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602170B RID: 136971 RVA: 0x003154A0 File Offset: 0x003136A0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetRecordAllSystemMetrics(bool bEnable)
		{
			UMagtInsightsRecorder.__SetRecordAllSystemMetrics_FunctionParams* ptr = stackalloc UMagtInsightsRecorder.__SetRecordAllSystemMetrics_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UMagtInsightsRecorder.__SetRecordAllSystemMetrics_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMagtInsightsRecorder.__SetRecordAllSystemMetrics_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bEnable = bEnable;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMagtInsightsRecorder.__SetRecordAllSystemMetrics_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602170C RID: 136972 RVA: 0x003154E8 File Offset: 0x003136E8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetRecordAllPerfData(bool bEnable)
		{
			UMagtInsightsRecorder.__SetRecordAllPerfData_FunctionParams* ptr = stackalloc UMagtInsightsRecorder.__SetRecordAllPerfData_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UMagtInsightsRecorder.__SetRecordAllPerfData_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMagtInsightsRecorder.__SetRecordAllPerfData_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bEnable = bEnable;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMagtInsightsRecorder.__SetRecordAllPerfData_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602170D RID: 136973 RVA: 0x00315530 File Offset: 0x00313730
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetRecordAllGPUMetrics(bool bEnable)
		{
			UMagtInsightsRecorder.__SetRecordAllGPUMetrics_FunctionParams* ptr = stackalloc UMagtInsightsRecorder.__SetRecordAllGPUMetrics_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UMagtInsightsRecorder.__SetRecordAllGPUMetrics_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMagtInsightsRecorder.__SetRecordAllGPUMetrics_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bEnable = bEnable;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMagtInsightsRecorder.__SetRecordAllGPUMetrics_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602170E RID: 136974 RVA: 0x00315578 File Offset: 0x00313778
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetRecordAllGPUCounter(bool bEnable)
		{
			UMagtInsightsRecorder.__SetRecordAllGPUCounter_FunctionParams* ptr = stackalloc UMagtInsightsRecorder.__SetRecordAllGPUCounter_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UMagtInsightsRecorder.__SetRecordAllGPUCounter_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMagtInsightsRecorder.__SetRecordAllGPUCounter_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bEnable = bEnable;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMagtInsightsRecorder.__SetRecordAllGPUCounter_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602170F RID: 136975 RVA: 0x003155C0 File Offset: 0x003137C0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetRecordAllCPUMetrics(bool bEnable)
		{
			UMagtInsightsRecorder.__SetRecordAllCPUMetrics_FunctionParams* ptr = stackalloc UMagtInsightsRecorder.__SetRecordAllCPUMetrics_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UMagtInsightsRecorder.__SetRecordAllCPUMetrics_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMagtInsightsRecorder.__SetRecordAllCPUMetrics_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bEnable = bEnable;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMagtInsightsRecorder.__SetRecordAllCPUMetrics_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06021710 RID: 136976 RVA: 0x00315608 File Offset: 0x00313808
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetRecordAllBatteryMetrics(bool bEnable)
		{
			UMagtInsightsRecorder.__SetRecordAllBatteryMetrics_FunctionParams* ptr = stackalloc UMagtInsightsRecorder.__SetRecordAllBatteryMetrics_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UMagtInsightsRecorder.__SetRecordAllBatteryMetrics_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMagtInsightsRecorder.__SetRecordAllBatteryMetrics_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bEnable = bEnable;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMagtInsightsRecorder.__SetRecordAllBatteryMetrics_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06021711 RID: 136977 RVA: 0x00315650 File Offset: 0x00313850
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetRecordAllAdviceData(bool bEnable)
		{
			UMagtInsightsRecorder.__SetRecordAllAdviceData_FunctionParams* ptr = stackalloc UMagtInsightsRecorder.__SetRecordAllAdviceData_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UMagtInsightsRecorder.__SetRecordAllAdviceData_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMagtInsightsRecorder.__SetRecordAllAdviceData_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bEnable = bEnable;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMagtInsightsRecorder.__SetRecordAllAdviceData_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06021712 RID: 136978 RVA: 0x00315698 File Offset: 0x00313898
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetRecordAll(bool bEnable)
		{
			UMagtInsightsRecorder.__SetRecordAll_FunctionParams* ptr = stackalloc UMagtInsightsRecorder.__SetRecordAll_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UMagtInsightsRecorder.__SetRecordAll_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMagtInsightsRecorder.__SetRecordAll_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bEnable = bEnable;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMagtInsightsRecorder.__SetRecordAll_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06021713 RID: 136979 RVA: 0x003156E0 File Offset: 0x003138E0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetRecordAdviceWorkerCount(bool bEnable)
		{
			UMagtInsightsRecorder.__SetRecordAdviceWorkerCount_FunctionParams* ptr = stackalloc UMagtInsightsRecorder.__SetRecordAdviceWorkerCount_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UMagtInsightsRecorder.__SetRecordAdviceWorkerCount_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMagtInsightsRecorder.__SetRecordAdviceWorkerCount_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bEnable = bEnable;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMagtInsightsRecorder.__SetRecordAdviceWorkerCount_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06021714 RID: 136980 RVA: 0x00315728 File Offset: 0x00313928
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetRecordAdviceBatPower(bool bEnable)
		{
			UMagtInsightsRecorder.__SetRecordAdviceBatPower_FunctionParams* ptr = stackalloc UMagtInsightsRecorder.__SetRecordAdviceBatPower_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UMagtInsightsRecorder.__SetRecordAdviceBatPower_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMagtInsightsRecorder.__SetRecordAdviceBatPower_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bEnable = bEnable;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMagtInsightsRecorder.__SetRecordAdviceBatPower_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06021715 RID: 136981 RVA: 0x00315770 File Offset: 0x00313970
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetRecordAdviceBatCurrent(bool bEnable)
		{
			UMagtInsightsRecorder.__SetRecordAdviceBatCurrent_FunctionParams* ptr = stackalloc UMagtInsightsRecorder.__SetRecordAdviceBatCurrent_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UMagtInsightsRecorder.__SetRecordAdviceBatCurrent_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMagtInsightsRecorder.__SetRecordAdviceBatCurrent_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bEnable = bEnable;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMagtInsightsRecorder.__SetRecordAdviceBatCurrent_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06021716 RID: 136982 RVA: 0x003157B8 File Offset: 0x003139B8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetEnableAll(bool bEnable)
		{
			UMagtInsightsRecorder.__SetEnableAll_FunctionParams* ptr = stackalloc UMagtInsightsRecorder.__SetEnableAll_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UMagtInsightsRecorder.__SetEnableAll_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMagtInsightsRecorder.__SetEnableAll_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bEnable = bEnable;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMagtInsightsRecorder.__SetEnableAll_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06021717 RID: 136983 RVA: 0x003157FF File Offset: 0x003139FF
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void ResetStatistics()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMagtInsightsRecorder.__ResetStatistics_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06021718 RID: 136984 RVA: 0x00315814 File Offset: 0x00313A14
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool IsRecordingThermalStatus()
		{
			UMagtInsightsRecorder.__IsRecordingThermalStatus_FunctionParams* ptr = stackalloc UMagtInsightsRecorder.__IsRecordingThermalStatus_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UMagtInsightsRecorder.__IsRecordingThermalStatus_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMagtInsightsRecorder.__IsRecordingThermalStatus_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMagtInsightsRecorder.__IsRecordingThermalStatus_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06021719 RID: 136985 RVA: 0x0031585C File Offset: 0x00313A5C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool IsRecordingTempSkinDef3()
		{
			UMagtInsightsRecorder.__IsRecordingTempSkinDef3_FunctionParams* ptr = stackalloc UMagtInsightsRecorder.__IsRecordingTempSkinDef3_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UMagtInsightsRecorder.__IsRecordingTempSkinDef3_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMagtInsightsRecorder.__IsRecordingTempSkinDef3_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMagtInsightsRecorder.__IsRecordingTempSkinDef3_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0602171A RID: 136986 RVA: 0x003158A4 File Offset: 0x00313AA4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool IsRecordingTempSkinDef2()
		{
			UMagtInsightsRecorder.__IsRecordingTempSkinDef2_FunctionParams* ptr = stackalloc UMagtInsightsRecorder.__IsRecordingTempSkinDef2_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UMagtInsightsRecorder.__IsRecordingTempSkinDef2_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMagtInsightsRecorder.__IsRecordingTempSkinDef2_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMagtInsightsRecorder.__IsRecordingTempSkinDef2_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0602171B RID: 136987 RVA: 0x003158EC File Offset: 0x00313AEC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool IsRecordingTempSkinDef()
		{
			UMagtInsightsRecorder.__IsRecordingTempSkinDef_FunctionParams* ptr = stackalloc UMagtInsightsRecorder.__IsRecordingTempSkinDef_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UMagtInsightsRecorder.__IsRecordingTempSkinDef_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMagtInsightsRecorder.__IsRecordingTempSkinDef_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMagtInsightsRecorder.__IsRecordingTempSkinDef_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0602171C RID: 136988 RVA: 0x00315934 File Offset: 0x00313B34
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool IsRecordingTempSkin()
		{
			UMagtInsightsRecorder.__IsRecordingTempSkin_FunctionParams* ptr = stackalloc UMagtInsightsRecorder.__IsRecordingTempSkin_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UMagtInsightsRecorder.__IsRecordingTempSkin_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMagtInsightsRecorder.__IsRecordingTempSkin_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMagtInsightsRecorder.__IsRecordingTempSkin_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0602171D RID: 136989 RVA: 0x0031597C File Offset: 0x00313B7C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool IsRecordingTempGPU()
		{
			UMagtInsightsRecorder.__IsRecordingTempGPU_FunctionParams* ptr = stackalloc UMagtInsightsRecorder.__IsRecordingTempGPU_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UMagtInsightsRecorder.__IsRecordingTempGPU_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMagtInsightsRecorder.__IsRecordingTempGPU_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMagtInsightsRecorder.__IsRecordingTempGPU_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0602171E RID: 136990 RVA: 0x003159C4 File Offset: 0x00313BC4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool IsRecordingTempFPSThrottle()
		{
			UMagtInsightsRecorder.__IsRecordingTempFPSThrottle_FunctionParams* ptr = stackalloc UMagtInsightsRecorder.__IsRecordingTempFPSThrottle_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UMagtInsightsRecorder.__IsRecordingTempFPSThrottle_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMagtInsightsRecorder.__IsRecordingTempFPSThrottle_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMagtInsightsRecorder.__IsRecordingTempFPSThrottle_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0602171F RID: 136991 RVA: 0x00315A0C File Offset: 0x00313C0C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool IsRecordingTempCPU()
		{
			UMagtInsightsRecorder.__IsRecordingTempCPU_FunctionParams* ptr = stackalloc UMagtInsightsRecorder.__IsRecordingTempCPU_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UMagtInsightsRecorder.__IsRecordingTempCPU_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMagtInsightsRecorder.__IsRecordingTempCPU_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMagtInsightsRecorder.__IsRecordingTempCPU_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06021720 RID: 136992 RVA: 0x00315A54 File Offset: 0x00313C54
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool IsRecordingTempBat()
		{
			UMagtInsightsRecorder.__IsRecordingTempBat_FunctionParams* ptr = stackalloc UMagtInsightsRecorder.__IsRecordingTempBat_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UMagtInsightsRecorder.__IsRecordingTempBat_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMagtInsightsRecorder.__IsRecordingTempBat_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMagtInsightsRecorder.__IsRecordingTempBat_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06021721 RID: 136993 RVA: 0x00315A9C File Offset: 0x00313C9C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool IsRecordingTempAllData()
		{
			UMagtInsightsRecorder.__IsRecordingTempAllData_FunctionParams* ptr = stackalloc UMagtInsightsRecorder.__IsRecordingTempAllData_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UMagtInsightsRecorder.__IsRecordingTempAllData_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMagtInsightsRecorder.__IsRecordingTempAllData_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMagtInsightsRecorder.__IsRecordingTempAllData_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06021722 RID: 136994 RVA: 0x00315AE4 File Offset: 0x00313CE4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool IsRecordingTargetFPS()
		{
			UMagtInsightsRecorder.__IsRecordingTargetFPS_FunctionParams* ptr = stackalloc UMagtInsightsRecorder.__IsRecordingTargetFPS_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UMagtInsightsRecorder.__IsRecordingTargetFPS_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMagtInsightsRecorder.__IsRecordingTargetFPS_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMagtInsightsRecorder.__IsRecordingTargetFPS_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06021723 RID: 136995 RVA: 0x00315B2C File Offset: 0x00313D2C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool IsRecordingStatAllData()
		{
			UMagtInsightsRecorder.__IsRecordingStatAllData_FunctionParams* ptr = stackalloc UMagtInsightsRecorder.__IsRecordingStatAllData_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UMagtInsightsRecorder.__IsRecordingStatAllData_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMagtInsightsRecorder.__IsRecordingStatAllData_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMagtInsightsRecorder.__IsRecordingStatAllData_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06021724 RID: 136996 RVA: 0x00315B74 File Offset: 0x00313D74
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool IsRecordingMemoryInfoTotalFree()
		{
			UMagtInsightsRecorder.__IsRecordingMemoryInfoTotalFree_FunctionParams* ptr = stackalloc UMagtInsightsRecorder.__IsRecordingMemoryInfoTotalFree_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UMagtInsightsRecorder.__IsRecordingMemoryInfoTotalFree_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMagtInsightsRecorder.__IsRecordingMemoryInfoTotalFree_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMagtInsightsRecorder.__IsRecordingMemoryInfoTotalFree_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06021725 RID: 136997 RVA: 0x00315BBC File Offset: 0x00313DBC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool IsRecordingMemoryInfoAvailUsed()
		{
			UMagtInsightsRecorder.__IsRecordingMemoryInfoAvailUsed_FunctionParams* ptr = stackalloc UMagtInsightsRecorder.__IsRecordingMemoryInfoAvailUsed_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UMagtInsightsRecorder.__IsRecordingMemoryInfoAvailUsed_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMagtInsightsRecorder.__IsRecordingMemoryInfoAvailUsed_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMagtInsightsRecorder.__IsRecordingMemoryInfoAvailUsed_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06021726 RID: 136998 RVA: 0x00315C04 File Offset: 0x00313E04
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool IsRecordingHWPTValue()
		{
			UMagtInsightsRecorder.__IsRecordingHWPTValue_FunctionParams* ptr = stackalloc UMagtInsightsRecorder.__IsRecordingHWPTValue_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UMagtInsightsRecorder.__IsRecordingHWPTValue_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMagtInsightsRecorder.__IsRecordingHWPTValue_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMagtInsightsRecorder.__IsRecordingHWPTValue_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06021727 RID: 136999 RVA: 0x00315C4C File Offset: 0x00313E4C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool IsRecordingHWPTDurationUS()
		{
			UMagtInsightsRecorder.__IsRecordingHWPTDurationUS_FunctionParams* ptr = stackalloc UMagtInsightsRecorder.__IsRecordingHWPTDurationUS_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UMagtInsightsRecorder.__IsRecordingHWPTDurationUS_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMagtInsightsRecorder.__IsRecordingHWPTDurationUS_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMagtInsightsRecorder.__IsRecordingHWPTDurationUS_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06021728 RID: 137000 RVA: 0x00315C94 File Offset: 0x00313E94
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool IsRecordingHWPTDurationMS()
		{
			UMagtInsightsRecorder.__IsRecordingHWPTDurationMS_FunctionParams* ptr = stackalloc UMagtInsightsRecorder.__IsRecordingHWPTDurationMS_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UMagtInsightsRecorder.__IsRecordingHWPTDurationMS_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMagtInsightsRecorder.__IsRecordingHWPTDurationMS_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMagtInsightsRecorder.__IsRecordingHWPTDurationMS_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06021729 RID: 137001 RVA: 0x00315CDC File Offset: 0x00313EDC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool IsRecordingHWPTAllData()
		{
			UMagtInsightsRecorder.__IsRecordingHWPTAllData_FunctionParams* ptr = stackalloc UMagtInsightsRecorder.__IsRecordingHWPTAllData_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UMagtInsightsRecorder.__IsRecordingHWPTAllData_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMagtInsightsRecorder.__IsRecordingHWPTAllData_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMagtInsightsRecorder.__IsRecordingHWPTAllData_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0602172A RID: 137002 RVA: 0x00315D24 File Offset: 0x00313F24
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool IsRecordingGPUFreq()
		{
			UMagtInsightsRecorder.__IsRecordingGPUFreq_FunctionParams* ptr = stackalloc UMagtInsightsRecorder.__IsRecordingGPUFreq_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UMagtInsightsRecorder.__IsRecordingGPUFreq_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMagtInsightsRecorder.__IsRecordingGPUFreq_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMagtInsightsRecorder.__IsRecordingGPUFreq_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0602172B RID: 137003 RVA: 0x00315D6C File Offset: 0x00313F6C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool IsRecordingGPUFrameTime()
		{
			UMagtInsightsRecorder.__IsRecordingGPUFrameTime_FunctionParams* ptr = stackalloc UMagtInsightsRecorder.__IsRecordingGPUFrameTime_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UMagtInsightsRecorder.__IsRecordingGPUFrameTime_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMagtInsightsRecorder.__IsRecordingGPUFrameTime_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMagtInsightsRecorder.__IsRecordingGPUFrameTime_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0602172C RID: 137004 RVA: 0x00315DB4 File Offset: 0x00313FB4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool IsRecordingGPUAvgURate()
		{
			UMagtInsightsRecorder.__IsRecordingGPUAvgURate_FunctionParams* ptr = stackalloc UMagtInsightsRecorder.__IsRecordingGPUAvgURate_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UMagtInsightsRecorder.__IsRecordingGPUAvgURate_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMagtInsightsRecorder.__IsRecordingGPUAvgURate_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMagtInsightsRecorder.__IsRecordingGPUAvgURate_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0602172D RID: 137005 RVA: 0x00315DFC File Offset: 0x00313FFC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool IsRecordingGPUAllData()
		{
			UMagtInsightsRecorder.__IsRecordingGPUAllData_FunctionParams* ptr = stackalloc UMagtInsightsRecorder.__IsRecordingGPUAllData_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UMagtInsightsRecorder.__IsRecordingGPUAllData_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMagtInsightsRecorder.__IsRecordingGPUAllData_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMagtInsightsRecorder.__IsRecordingGPUAllData_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0602172E RID: 137006 RVA: 0x00315E44 File Offset: 0x00314044
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool IsRecordingFPSControlStatus()
		{
			UMagtInsightsRecorder.__IsRecordingFPSControlStatus_FunctionParams* ptr = stackalloc UMagtInsightsRecorder.__IsRecordingFPSControlStatus_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UMagtInsightsRecorder.__IsRecordingFPSControlStatus_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMagtInsightsRecorder.__IsRecordingFPSControlStatus_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMagtInsightsRecorder.__IsRecordingFPSControlStatus_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0602172F RID: 137007 RVA: 0x00315E8C File Offset: 0x0031408C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool IsRecordingCriticalThreadDep()
		{
			UMagtInsightsRecorder.__IsRecordingCriticalThreadDep_FunctionParams* ptr = stackalloc UMagtInsightsRecorder.__IsRecordingCriticalThreadDep_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UMagtInsightsRecorder.__IsRecordingCriticalThreadDep_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMagtInsightsRecorder.__IsRecordingCriticalThreadDep_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMagtInsightsRecorder.__IsRecordingCriticalThreadDep_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06021730 RID: 137008 RVA: 0x00315ED4 File Offset: 0x003140D4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool IsRecordingCriticalThreadBG()
		{
			UMagtInsightsRecorder.__IsRecordingCriticalThreadBG_FunctionParams* ptr = stackalloc UMagtInsightsRecorder.__IsRecordingCriticalThreadBG_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UMagtInsightsRecorder.__IsRecordingCriticalThreadBG_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMagtInsightsRecorder.__IsRecordingCriticalThreadBG_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMagtInsightsRecorder.__IsRecordingCriticalThreadBG_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06021731 RID: 137009 RVA: 0x00315F1C File Offset: 0x0031411C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool IsRecordingCPUMCoreNum()
		{
			UMagtInsightsRecorder.__IsRecordingCPUMCoreNum_FunctionParams* ptr = stackalloc UMagtInsightsRecorder.__IsRecordingCPUMCoreNum_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UMagtInsightsRecorder.__IsRecordingCPUMCoreNum_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMagtInsightsRecorder.__IsRecordingCPUMCoreNum_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMagtInsightsRecorder.__IsRecordingCPUMCoreNum_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06021732 RID: 137010 RVA: 0x00315F64 File Offset: 0x00314164
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool IsRecordingCPUMCoreLoad()
		{
			UMagtInsightsRecorder.__IsRecordingCPUMCoreLoad_FunctionParams* ptr = stackalloc UMagtInsightsRecorder.__IsRecordingCPUMCoreLoad_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UMagtInsightsRecorder.__IsRecordingCPUMCoreLoad_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMagtInsightsRecorder.__IsRecordingCPUMCoreLoad_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMagtInsightsRecorder.__IsRecordingCPUMCoreLoad_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06021733 RID: 137011 RVA: 0x00315FAC File Offset: 0x003141AC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool IsRecordingCPUMCoreFreq()
		{
			UMagtInsightsRecorder.__IsRecordingCPUMCoreFreq_FunctionParams* ptr = stackalloc UMagtInsightsRecorder.__IsRecordingCPUMCoreFreq_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UMagtInsightsRecorder.__IsRecordingCPUMCoreFreq_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMagtInsightsRecorder.__IsRecordingCPUMCoreFreq_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMagtInsightsRecorder.__IsRecordingCPUMCoreFreq_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06021734 RID: 137012 RVA: 0x00315FF4 File Offset: 0x003141F4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool IsRecordingCPULCoreNum()
		{
			UMagtInsightsRecorder.__IsRecordingCPULCoreNum_FunctionParams* ptr = stackalloc UMagtInsightsRecorder.__IsRecordingCPULCoreNum_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UMagtInsightsRecorder.__IsRecordingCPULCoreNum_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMagtInsightsRecorder.__IsRecordingCPULCoreNum_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMagtInsightsRecorder.__IsRecordingCPULCoreNum_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06021735 RID: 137013 RVA: 0x0031603C File Offset: 0x0031423C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool IsRecordingCPULCoreLoad()
		{
			UMagtInsightsRecorder.__IsRecordingCPULCoreLoad_FunctionParams* ptr = stackalloc UMagtInsightsRecorder.__IsRecordingCPULCoreLoad_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UMagtInsightsRecorder.__IsRecordingCPULCoreLoad_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMagtInsightsRecorder.__IsRecordingCPULCoreLoad_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMagtInsightsRecorder.__IsRecordingCPULCoreLoad_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06021736 RID: 137014 RVA: 0x00316084 File Offset: 0x00314284
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool IsRecordingCPULCoreFreq()
		{
			UMagtInsightsRecorder.__IsRecordingCPULCoreFreq_FunctionParams* ptr = stackalloc UMagtInsightsRecorder.__IsRecordingCPULCoreFreq_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UMagtInsightsRecorder.__IsRecordingCPULCoreFreq_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMagtInsightsRecorder.__IsRecordingCPULCoreFreq_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMagtInsightsRecorder.__IsRecordingCPULCoreFreq_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06021737 RID: 137015 RVA: 0x003160CC File Offset: 0x003142CC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool IsRecordingCPUFrameTime()
		{
			UMagtInsightsRecorder.__IsRecordingCPUFrameTime_FunctionParams* ptr = stackalloc UMagtInsightsRecorder.__IsRecordingCPUFrameTime_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UMagtInsightsRecorder.__IsRecordingCPUFrameTime_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMagtInsightsRecorder.__IsRecordingCPUFrameTime_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMagtInsightsRecorder.__IsRecordingCPUFrameTime_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06021738 RID: 137016 RVA: 0x00316114 File Offset: 0x00314314
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool IsRecordingCPUBCoreNum()
		{
			UMagtInsightsRecorder.__IsRecordingCPUBCoreNum_FunctionParams* ptr = stackalloc UMagtInsightsRecorder.__IsRecordingCPUBCoreNum_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UMagtInsightsRecorder.__IsRecordingCPUBCoreNum_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMagtInsightsRecorder.__IsRecordingCPUBCoreNum_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMagtInsightsRecorder.__IsRecordingCPUBCoreNum_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06021739 RID: 137017 RVA: 0x0031615C File Offset: 0x0031435C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool IsRecordingCPUBCoreLoad()
		{
			UMagtInsightsRecorder.__IsRecordingCPUBCoreLoad_FunctionParams* ptr = stackalloc UMagtInsightsRecorder.__IsRecordingCPUBCoreLoad_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UMagtInsightsRecorder.__IsRecordingCPUBCoreLoad_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMagtInsightsRecorder.__IsRecordingCPUBCoreLoad_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMagtInsightsRecorder.__IsRecordingCPUBCoreLoad_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0602173A RID: 137018 RVA: 0x003161A4 File Offset: 0x003143A4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool IsRecordingCPUBCoreFreq()
		{
			UMagtInsightsRecorder.__IsRecordingCPUBCoreFreq_FunctionParams* ptr = stackalloc UMagtInsightsRecorder.__IsRecordingCPUBCoreFreq_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UMagtInsightsRecorder.__IsRecordingCPUBCoreFreq_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMagtInsightsRecorder.__IsRecordingCPUBCoreFreq_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMagtInsightsRecorder.__IsRecordingCPUBCoreFreq_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0602173B RID: 137019 RVA: 0x003161EC File Offset: 0x003143EC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool IsRecordingCPUAllData()
		{
			UMagtInsightsRecorder.__IsRecordingCPUAllData_FunctionParams* ptr = stackalloc UMagtInsightsRecorder.__IsRecordingCPUAllData_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UMagtInsightsRecorder.__IsRecordingCPUAllData_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMagtInsightsRecorder.__IsRecordingCPUAllData_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMagtInsightsRecorder.__IsRecordingCPUAllData_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0602173C RID: 137020 RVA: 0x00316234 File Offset: 0x00314434
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool IsRecordingBATNowVoltage()
		{
			UMagtInsightsRecorder.__IsRecordingBATNowVoltage_FunctionParams* ptr = stackalloc UMagtInsightsRecorder.__IsRecordingBATNowVoltage_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UMagtInsightsRecorder.__IsRecordingBATNowVoltage_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMagtInsightsRecorder.__IsRecordingBATNowVoltage_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMagtInsightsRecorder.__IsRecordingBATNowVoltage_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0602173D RID: 137021 RVA: 0x0031627C File Offset: 0x0031447C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool IsRecordingBATNowPower()
		{
			UMagtInsightsRecorder.__IsRecordingBATNowPower_FunctionParams* ptr = stackalloc UMagtInsightsRecorder.__IsRecordingBATNowPower_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UMagtInsightsRecorder.__IsRecordingBATNowPower_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMagtInsightsRecorder.__IsRecordingBATNowPower_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMagtInsightsRecorder.__IsRecordingBATNowPower_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0602173E RID: 137022 RVA: 0x003162C4 File Offset: 0x003144C4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool IsRecordingBATNowLevel()
		{
			UMagtInsightsRecorder.__IsRecordingBATNowLevel_FunctionParams* ptr = stackalloc UMagtInsightsRecorder.__IsRecordingBATNowLevel_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UMagtInsightsRecorder.__IsRecordingBATNowLevel_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMagtInsightsRecorder.__IsRecordingBATNowLevel_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMagtInsightsRecorder.__IsRecordingBATNowLevel_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0602173F RID: 137023 RVA: 0x0031630C File Offset: 0x0031450C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool IsRecordingBATNowCurrent()
		{
			UMagtInsightsRecorder.__IsRecordingBATNowCurrent_FunctionParams* ptr = stackalloc UMagtInsightsRecorder.__IsRecordingBATNowCurrent_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UMagtInsightsRecorder.__IsRecordingBATNowCurrent_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMagtInsightsRecorder.__IsRecordingBATNowCurrent_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMagtInsightsRecorder.__IsRecordingBATNowCurrent_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06021740 RID: 137024 RVA: 0x00316354 File Offset: 0x00314554
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool IsRecordingBATNowCharging()
		{
			UMagtInsightsRecorder.__IsRecordingBATNowCharging_FunctionParams* ptr = stackalloc UMagtInsightsRecorder.__IsRecordingBATNowCharging_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UMagtInsightsRecorder.__IsRecordingBATNowCharging_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMagtInsightsRecorder.__IsRecordingBATNowCharging_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMagtInsightsRecorder.__IsRecordingBATNowCharging_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06021741 RID: 137025 RVA: 0x0031639C File Offset: 0x0031459C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool IsRecordingBATAvgPower()
		{
			UMagtInsightsRecorder.__IsRecordingBATAvgPower_FunctionParams* ptr = stackalloc UMagtInsightsRecorder.__IsRecordingBATAvgPower_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UMagtInsightsRecorder.__IsRecordingBATAvgPower_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMagtInsightsRecorder.__IsRecordingBATAvgPower_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMagtInsightsRecorder.__IsRecordingBATAvgPower_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06021742 RID: 137026 RVA: 0x003163E4 File Offset: 0x003145E4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool IsRecordingBATAvgCurrent()
		{
			UMagtInsightsRecorder.__IsRecordingBATAvgCurrent_FunctionParams* ptr = stackalloc UMagtInsightsRecorder.__IsRecordingBATAvgCurrent_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UMagtInsightsRecorder.__IsRecordingBATAvgCurrent_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMagtInsightsRecorder.__IsRecordingBATAvgCurrent_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMagtInsightsRecorder.__IsRecordingBATAvgCurrent_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06021743 RID: 137027 RVA: 0x0031642C File Offset: 0x0031462C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool IsRecordingBATAllData()
		{
			UMagtInsightsRecorder.__IsRecordingBATAllData_FunctionParams* ptr = stackalloc UMagtInsightsRecorder.__IsRecordingBATAllData_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UMagtInsightsRecorder.__IsRecordingBATAllData_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMagtInsightsRecorder.__IsRecordingBATAllData_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMagtInsightsRecorder.__IsRecordingBATAllData_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06021744 RID: 137028 RVA: 0x00316474 File Offset: 0x00314674
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool IsRecordingBATAdvicePower()
		{
			UMagtInsightsRecorder.__IsRecordingBATAdvicePower_FunctionParams* ptr = stackalloc UMagtInsightsRecorder.__IsRecordingBATAdvicePower_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UMagtInsightsRecorder.__IsRecordingBATAdvicePower_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMagtInsightsRecorder.__IsRecordingBATAdvicePower_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMagtInsightsRecorder.__IsRecordingBATAdvicePower_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06021745 RID: 137029 RVA: 0x003164BC File Offset: 0x003146BC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool IsRecordingBATAdviceCurrent()
		{
			UMagtInsightsRecorder.__IsRecordingBATAdviceCurrent_FunctionParams* ptr = stackalloc UMagtInsightsRecorder.__IsRecordingBATAdviceCurrent_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UMagtInsightsRecorder.__IsRecordingBATAdviceCurrent_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMagtInsightsRecorder.__IsRecordingBATAdviceCurrent_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMagtInsightsRecorder.__IsRecordingBATAdviceCurrent_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06021746 RID: 137030 RVA: 0x00316504 File Offset: 0x00314704
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool IsRecordingAllPerfData()
		{
			UMagtInsightsRecorder.__IsRecordingAllPerfData_FunctionParams* ptr = stackalloc UMagtInsightsRecorder.__IsRecordingAllPerfData_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UMagtInsightsRecorder.__IsRecordingAllPerfData_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMagtInsightsRecorder.__IsRecordingAllPerfData_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMagtInsightsRecorder.__IsRecordingAllPerfData_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06021747 RID: 137031 RVA: 0x0031654C File Offset: 0x0031474C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool IsRecordingAllGPUCounter()
		{
			UMagtInsightsRecorder.__IsRecordingAllGPUCounter_FunctionParams* ptr = stackalloc UMagtInsightsRecorder.__IsRecordingAllGPUCounter_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UMagtInsightsRecorder.__IsRecordingAllGPUCounter_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMagtInsightsRecorder.__IsRecordingAllGPUCounter_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMagtInsightsRecorder.__IsRecordingAllGPUCounter_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06021748 RID: 137032 RVA: 0x00316594 File Offset: 0x00314794
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool IsRecordingAllAdviceData()
		{
			UMagtInsightsRecorder.__IsRecordingAllAdviceData_FunctionParams* ptr = stackalloc UMagtInsightsRecorder.__IsRecordingAllAdviceData_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UMagtInsightsRecorder.__IsRecordingAllAdviceData_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMagtInsightsRecorder.__IsRecordingAllAdviceData_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMagtInsightsRecorder.__IsRecordingAllAdviceData_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06021749 RID: 137033 RVA: 0x003165DC File Offset: 0x003147DC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool IsRecordingAll()
		{
			UMagtInsightsRecorder.__IsRecordingAll_FunctionParams* ptr = stackalloc UMagtInsightsRecorder.__IsRecordingAll_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UMagtInsightsRecorder.__IsRecordingAll_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMagtInsightsRecorder.__IsRecordingAll_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMagtInsightsRecorder.__IsRecordingAll_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0602174A RID: 137034 RVA: 0x00316624 File Offset: 0x00314824
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool IsRecordingAdviceWorkerCount()
		{
			UMagtInsightsRecorder.__IsRecordingAdviceWorkerCount_FunctionParams* ptr = stackalloc UMagtInsightsRecorder.__IsRecordingAdviceWorkerCount_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UMagtInsightsRecorder.__IsRecordingAdviceWorkerCount_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMagtInsightsRecorder.__IsRecordingAdviceWorkerCount_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMagtInsightsRecorder.__IsRecordingAdviceWorkerCount_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0602174B RID: 137035 RVA: 0x0031666C File Offset: 0x0031486C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool IsRecordingAdviceBatPower()
		{
			UMagtInsightsRecorder.__IsRecordingAdviceBatPower_FunctionParams* ptr = stackalloc UMagtInsightsRecorder.__IsRecordingAdviceBatPower_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UMagtInsightsRecorder.__IsRecordingAdviceBatPower_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMagtInsightsRecorder.__IsRecordingAdviceBatPower_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMagtInsightsRecorder.__IsRecordingAdviceBatPower_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0602174C RID: 137036 RVA: 0x003166B4 File Offset: 0x003148B4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool IsRecordingAdviceBatCurrent()
		{
			UMagtInsightsRecorder.__IsRecordingAdviceBatCurrent_FunctionParams* ptr = stackalloc UMagtInsightsRecorder.__IsRecordingAdviceBatCurrent_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UMagtInsightsRecorder.__IsRecordingAdviceBatCurrent_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMagtInsightsRecorder.__IsRecordingAdviceBatCurrent_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMagtInsightsRecorder.__IsRecordingAdviceBatCurrent_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0602174D RID: 137037 RVA: 0x003166FC File Offset: 0x003148FC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool IsRecording()
		{
			UMagtInsightsRecorder.__IsRecording_FunctionParams* ptr = stackalloc UMagtInsightsRecorder.__IsRecording_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UMagtInsightsRecorder.__IsRecording_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMagtInsightsRecorder.__IsRecording_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMagtInsightsRecorder.__IsRecording_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0602174E RID: 137038 RVA: 0x00316744 File Offset: 0x00314944
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe int GetSampleCount()
		{
			UMagtInsightsRecorder.__GetSampleCount_FunctionParams* ptr = stackalloc UMagtInsightsRecorder.__GetSampleCount_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UMagtInsightsRecorder.__GetSampleCount_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMagtInsightsRecorder.__GetSampleCount_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMagtInsightsRecorder.__GetSampleCount_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0602174F RID: 137039 RVA: 0x0031678C File Offset: 0x0031498C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe int GetFailureCount()
		{
			UMagtInsightsRecorder.__GetFailureCount_FunctionParams* ptr = stackalloc UMagtInsightsRecorder.__GetFailureCount_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UMagtInsightsRecorder.__GetFailureCount_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMagtInsightsRecorder.__GetFailureCount_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMagtInsightsRecorder.__GetFailureCount_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06021750 RID: 137040 RVA: 0x003167D2 File Offset: 0x003149D2
		static UMagtInsightsRecorder()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MagtInsights.MagtInsightsRecorder");
		}

		// Token: 0x06021751 RID: 137041 RVA: 0x003167E0 File Offset: 0x003149E0
		protected UMagtInsightsRecorder(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011D04 RID: 72964
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/MagtInsights.MagtInsightsRecorder";

		// Token: 0x04011D05 RID: 72965
		private static IntPtr _ClassPtr;

		// Token: 0x04011D06 RID: 72966
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011D07 RID: 72967
		private static IntPtr __UseFullConfig_NativeFunctionPtr;

		// Token: 0x04011D08 RID: 72968
		private static IntPtr __UseCommonConfig_NativeFunctionPtr;

		// Token: 0x04011D09 RID: 72969
		private static IntPtr __StopRecording_NativeFunctionPtr;

		// Token: 0x04011D0A RID: 72970
		private static IntPtr __StartRecording_NativeFunctionPtr;

		// Token: 0x04011D0B RID: 72971
		private static IntPtr __SetSamplingInterval_NativeFunctionPtr;

		// Token: 0x04011D0C RID: 72972
		private static IntPtr __SetRecordThermalStatus_NativeFunctionPtr;

		// Token: 0x04011D0D RID: 72973
		private static IntPtr __SetRecordTempSkinDef3_NativeFunctionPtr;

		// Token: 0x04011D0E RID: 72974
		private static IntPtr __SetRecordTempSkinDef2_NativeFunctionPtr;

		// Token: 0x04011D0F RID: 72975
		private static IntPtr __SetRecordTempSkinDef_NativeFunctionPtr;

		// Token: 0x04011D10 RID: 72976
		private static IntPtr __SetRecordTempSkin_NativeFunctionPtr;

		// Token: 0x04011D11 RID: 72977
		private static IntPtr __SetRecordTempGPU_NativeFunctionPtr;

		// Token: 0x04011D12 RID: 72978
		private static IntPtr __SetRecordTempFPSThrottle_NativeFunctionPtr;

		// Token: 0x04011D13 RID: 72979
		private static IntPtr __SetRecordTempCPU_NativeFunctionPtr;

		// Token: 0x04011D14 RID: 72980
		private static IntPtr __SetRecordTempBat_NativeFunctionPtr;

		// Token: 0x04011D15 RID: 72981
		private static IntPtr __SetRecordTempAllData_NativeFunctionPtr;

		// Token: 0x04011D16 RID: 72982
		private static IntPtr __SetRecordTargetFPS_NativeFunctionPtr;

		// Token: 0x04011D17 RID: 72983
		private static IntPtr __SetRecordStatAllData_NativeFunctionPtr;

		// Token: 0x04011D18 RID: 72984
		private static IntPtr __SetRecordMemoryInfoTotalFree_NativeFunctionPtr;

		// Token: 0x04011D19 RID: 72985
		private static IntPtr __SetRecordMemoryInfoAvailUsed_NativeFunctionPtr;

		// Token: 0x04011D1A RID: 72986
		private static IntPtr __SetRecordHWPTValue_NativeFunctionPtr;

		// Token: 0x04011D1B RID: 72987
		private static IntPtr __SetRecordHWPTDurationUS_NativeFunctionPtr;

		// Token: 0x04011D1C RID: 72988
		private static IntPtr __SetRecordHWPTDurationMS_NativeFunctionPtr;

		// Token: 0x04011D1D RID: 72989
		private static IntPtr __SetRecordHWPTAllData_NativeFunctionPtr;

		// Token: 0x04011D1E RID: 72990
		private static IntPtr __SetRecordGPUFreq_NativeFunctionPtr;

		// Token: 0x04011D1F RID: 72991
		private static IntPtr __SetRecordGPUFrameTime_NativeFunctionPtr;

		// Token: 0x04011D20 RID: 72992
		private static IntPtr __SetRecordGPUAvgURate_NativeFunctionPtr;

		// Token: 0x04011D21 RID: 72993
		private static IntPtr __SetRecordGPUAllData_NativeFunctionPtr;

		// Token: 0x04011D22 RID: 72994
		private static IntPtr __SetRecordFPSControlStatus_NativeFunctionPtr;

		// Token: 0x04011D23 RID: 72995
		private static IntPtr __SetRecordCriticalThreadDep_NativeFunctionPtr;

		// Token: 0x04011D24 RID: 72996
		private static IntPtr __SetRecordCriticalThreadBG_NativeFunctionPtr;

		// Token: 0x04011D25 RID: 72997
		private static IntPtr __SetRecordCPUMCoreNum_NativeFunctionPtr;

		// Token: 0x04011D26 RID: 72998
		private static IntPtr __SetRecordCPUMCoreLoad_NativeFunctionPtr;

		// Token: 0x04011D27 RID: 72999
		private static IntPtr __SetRecordCPUMCoreFreq_NativeFunctionPtr;

		// Token: 0x04011D28 RID: 73000
		private static IntPtr __SetRecordCPULCoreNum_NativeFunctionPtr;

		// Token: 0x04011D29 RID: 73001
		private static IntPtr __SetRecordCPULCoreLoad_NativeFunctionPtr;

		// Token: 0x04011D2A RID: 73002
		private static IntPtr __SetRecordCPULCoreFreq_NativeFunctionPtr;

		// Token: 0x04011D2B RID: 73003
		private static IntPtr __SetRecordCPUFrameTime_NativeFunctionPtr;

		// Token: 0x04011D2C RID: 73004
		private static IntPtr __SetRecordCPUBCoreNum_NativeFunctionPtr;

		// Token: 0x04011D2D RID: 73005
		private static IntPtr __SetRecordCPUBCoreLoad_NativeFunctionPtr;

		// Token: 0x04011D2E RID: 73006
		private static IntPtr __SetRecordCPUBCoreFreq_NativeFunctionPtr;

		// Token: 0x04011D2F RID: 73007
		private static IntPtr __SetRecordCPUAllData_NativeFunctionPtr;

		// Token: 0x04011D30 RID: 73008
		private static IntPtr __SetRecordBATNowVoltage_NativeFunctionPtr;

		// Token: 0x04011D31 RID: 73009
		private static IntPtr __SetRecordBATNowPower_NativeFunctionPtr;

		// Token: 0x04011D32 RID: 73010
		private static IntPtr __SetRecordBATNowLevel_NativeFunctionPtr;

		// Token: 0x04011D33 RID: 73011
		private static IntPtr __SetRecordBATNowCurrent_NativeFunctionPtr;

		// Token: 0x04011D34 RID: 73012
		private static IntPtr __SetRecordBATNowCharging_NativeFunctionPtr;

		// Token: 0x04011D35 RID: 73013
		private static IntPtr __SetRecordBATAvgPower_NativeFunctionPtr;

		// Token: 0x04011D36 RID: 73014
		private static IntPtr __SetRecordBATAvgCurrent_NativeFunctionPtr;

		// Token: 0x04011D37 RID: 73015
		private static IntPtr __SetRecordBATAllData_NativeFunctionPtr;

		// Token: 0x04011D38 RID: 73016
		private static IntPtr __SetRecordBATAdvicePower_NativeFunctionPtr;

		// Token: 0x04011D39 RID: 73017
		private static IntPtr __SetRecordBATAdviceCurrent_NativeFunctionPtr;

		// Token: 0x04011D3A RID: 73018
		private static IntPtr __SetRecordAllTemperatureMetrics_NativeFunctionPtr;

		// Token: 0x04011D3B RID: 73019
		private static IntPtr __SetRecordAllSystemMetrics_NativeFunctionPtr;

		// Token: 0x04011D3C RID: 73020
		private static IntPtr __SetRecordAllPerfData_NativeFunctionPtr;

		// Token: 0x04011D3D RID: 73021
		private static IntPtr __SetRecordAllGPUMetrics_NativeFunctionPtr;

		// Token: 0x04011D3E RID: 73022
		private static IntPtr __SetRecordAllGPUCounter_NativeFunctionPtr;

		// Token: 0x04011D3F RID: 73023
		private static IntPtr __SetRecordAllCPUMetrics_NativeFunctionPtr;

		// Token: 0x04011D40 RID: 73024
		private static IntPtr __SetRecordAllBatteryMetrics_NativeFunctionPtr;

		// Token: 0x04011D41 RID: 73025
		private static IntPtr __SetRecordAllAdviceData_NativeFunctionPtr;

		// Token: 0x04011D42 RID: 73026
		private static IntPtr __SetRecordAll_NativeFunctionPtr;

		// Token: 0x04011D43 RID: 73027
		private static IntPtr __SetRecordAdviceWorkerCount_NativeFunctionPtr;

		// Token: 0x04011D44 RID: 73028
		private static IntPtr __SetRecordAdviceBatPower_NativeFunctionPtr;

		// Token: 0x04011D45 RID: 73029
		private static IntPtr __SetRecordAdviceBatCurrent_NativeFunctionPtr;

		// Token: 0x04011D46 RID: 73030
		private static IntPtr __SetEnableAll_NativeFunctionPtr;

		// Token: 0x04011D47 RID: 73031
		private static IntPtr __ResetStatistics_NativeFunctionPtr;

		// Token: 0x04011D48 RID: 73032
		private static IntPtr __IsRecordingThermalStatus_NativeFunctionPtr;

		// Token: 0x04011D49 RID: 73033
		private static IntPtr __IsRecordingTempSkinDef3_NativeFunctionPtr;

		// Token: 0x04011D4A RID: 73034
		private static IntPtr __IsRecordingTempSkinDef2_NativeFunctionPtr;

		// Token: 0x04011D4B RID: 73035
		private static IntPtr __IsRecordingTempSkinDef_NativeFunctionPtr;

		// Token: 0x04011D4C RID: 73036
		private static IntPtr __IsRecordingTempSkin_NativeFunctionPtr;

		// Token: 0x04011D4D RID: 73037
		private static IntPtr __IsRecordingTempGPU_NativeFunctionPtr;

		// Token: 0x04011D4E RID: 73038
		private static IntPtr __IsRecordingTempFPSThrottle_NativeFunctionPtr;

		// Token: 0x04011D4F RID: 73039
		private static IntPtr __IsRecordingTempCPU_NativeFunctionPtr;

		// Token: 0x04011D50 RID: 73040
		private static IntPtr __IsRecordingTempBat_NativeFunctionPtr;

		// Token: 0x04011D51 RID: 73041
		private static IntPtr __IsRecordingTempAllData_NativeFunctionPtr;

		// Token: 0x04011D52 RID: 73042
		private static IntPtr __IsRecordingTargetFPS_NativeFunctionPtr;

		// Token: 0x04011D53 RID: 73043
		private static IntPtr __IsRecordingStatAllData_NativeFunctionPtr;

		// Token: 0x04011D54 RID: 73044
		private static IntPtr __IsRecordingMemoryInfoTotalFree_NativeFunctionPtr;

		// Token: 0x04011D55 RID: 73045
		private static IntPtr __IsRecordingMemoryInfoAvailUsed_NativeFunctionPtr;

		// Token: 0x04011D56 RID: 73046
		private static IntPtr __IsRecordingHWPTValue_NativeFunctionPtr;

		// Token: 0x04011D57 RID: 73047
		private static IntPtr __IsRecordingHWPTDurationUS_NativeFunctionPtr;

		// Token: 0x04011D58 RID: 73048
		private static IntPtr __IsRecordingHWPTDurationMS_NativeFunctionPtr;

		// Token: 0x04011D59 RID: 73049
		private static IntPtr __IsRecordingHWPTAllData_NativeFunctionPtr;

		// Token: 0x04011D5A RID: 73050
		private static IntPtr __IsRecordingGPUFreq_NativeFunctionPtr;

		// Token: 0x04011D5B RID: 73051
		private static IntPtr __IsRecordingGPUFrameTime_NativeFunctionPtr;

		// Token: 0x04011D5C RID: 73052
		private static IntPtr __IsRecordingGPUAvgURate_NativeFunctionPtr;

		// Token: 0x04011D5D RID: 73053
		private static IntPtr __IsRecordingGPUAllData_NativeFunctionPtr;

		// Token: 0x04011D5E RID: 73054
		private static IntPtr __IsRecordingFPSControlStatus_NativeFunctionPtr;

		// Token: 0x04011D5F RID: 73055
		private static IntPtr __IsRecordingCriticalThreadDep_NativeFunctionPtr;

		// Token: 0x04011D60 RID: 73056
		private static IntPtr __IsRecordingCriticalThreadBG_NativeFunctionPtr;

		// Token: 0x04011D61 RID: 73057
		private static IntPtr __IsRecordingCPUMCoreNum_NativeFunctionPtr;

		// Token: 0x04011D62 RID: 73058
		private static IntPtr __IsRecordingCPUMCoreLoad_NativeFunctionPtr;

		// Token: 0x04011D63 RID: 73059
		private static IntPtr __IsRecordingCPUMCoreFreq_NativeFunctionPtr;

		// Token: 0x04011D64 RID: 73060
		private static IntPtr __IsRecordingCPULCoreNum_NativeFunctionPtr;

		// Token: 0x04011D65 RID: 73061
		private static IntPtr __IsRecordingCPULCoreLoad_NativeFunctionPtr;

		// Token: 0x04011D66 RID: 73062
		private static IntPtr __IsRecordingCPULCoreFreq_NativeFunctionPtr;

		// Token: 0x04011D67 RID: 73063
		private static IntPtr __IsRecordingCPUFrameTime_NativeFunctionPtr;

		// Token: 0x04011D68 RID: 73064
		private static IntPtr __IsRecordingCPUBCoreNum_NativeFunctionPtr;

		// Token: 0x04011D69 RID: 73065
		private static IntPtr __IsRecordingCPUBCoreLoad_NativeFunctionPtr;

		// Token: 0x04011D6A RID: 73066
		private static IntPtr __IsRecordingCPUBCoreFreq_NativeFunctionPtr;

		// Token: 0x04011D6B RID: 73067
		private static IntPtr __IsRecordingCPUAllData_NativeFunctionPtr;

		// Token: 0x04011D6C RID: 73068
		private static IntPtr __IsRecordingBATNowVoltage_NativeFunctionPtr;

		// Token: 0x04011D6D RID: 73069
		private static IntPtr __IsRecordingBATNowPower_NativeFunctionPtr;

		// Token: 0x04011D6E RID: 73070
		private static IntPtr __IsRecordingBATNowLevel_NativeFunctionPtr;

		// Token: 0x04011D6F RID: 73071
		private static IntPtr __IsRecordingBATNowCurrent_NativeFunctionPtr;

		// Token: 0x04011D70 RID: 73072
		private static IntPtr __IsRecordingBATNowCharging_NativeFunctionPtr;

		// Token: 0x04011D71 RID: 73073
		private static IntPtr __IsRecordingBATAvgPower_NativeFunctionPtr;

		// Token: 0x04011D72 RID: 73074
		private static IntPtr __IsRecordingBATAvgCurrent_NativeFunctionPtr;

		// Token: 0x04011D73 RID: 73075
		private static IntPtr __IsRecordingBATAllData_NativeFunctionPtr;

		// Token: 0x04011D74 RID: 73076
		private static IntPtr __IsRecordingBATAdvicePower_NativeFunctionPtr;

		// Token: 0x04011D75 RID: 73077
		private static IntPtr __IsRecordingBATAdviceCurrent_NativeFunctionPtr;

		// Token: 0x04011D76 RID: 73078
		private static IntPtr __IsRecordingAllPerfData_NativeFunctionPtr;

		// Token: 0x04011D77 RID: 73079
		private static IntPtr __IsRecordingAllGPUCounter_NativeFunctionPtr;

		// Token: 0x04011D78 RID: 73080
		private static IntPtr __IsRecordingAllAdviceData_NativeFunctionPtr;

		// Token: 0x04011D79 RID: 73081
		private static IntPtr __IsRecordingAll_NativeFunctionPtr;

		// Token: 0x04011D7A RID: 73082
		private static IntPtr __IsRecordingAdviceWorkerCount_NativeFunctionPtr;

		// Token: 0x04011D7B RID: 73083
		private static IntPtr __IsRecordingAdviceBatPower_NativeFunctionPtr;

		// Token: 0x04011D7C RID: 73084
		private static IntPtr __IsRecordingAdviceBatCurrent_NativeFunctionPtr;

		// Token: 0x04011D7D RID: 73085
		private static IntPtr __IsRecording_NativeFunctionPtr;

		// Token: 0x04011D7E RID: 73086
		private static IntPtr __GetSampleCount_NativeFunctionPtr;

		// Token: 0x04011D7F RID: 73087
		private static IntPtr __GetFailureCount_NativeFunctionPtr;

		// Token: 0x02003522 RID: 13602
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __StartRecording_FunctionParams
		{
			// Token: 0x04017554 RID: 95572
			[FieldOffset(0)]
			public int SamplingIntervalMs;

			// Token: 0x04017555 RID: 95573
			[FieldOffset(4)]
			public bool __Result;
		}

		// Token: 0x02003523 RID: 13603
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __SetSamplingInterval_FunctionParams
		{
			// Token: 0x04017556 RID: 95574
			[FieldOffset(0)]
			public int IntervalMs;

			// Token: 0x04017557 RID: 95575
			[FieldOffset(4)]
			public bool __Result;
		}

		// Token: 0x02003524 RID: 13604
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __SetRecordThermalStatus_FunctionParams
		{
			// Token: 0x04017558 RID: 95576
			[FieldOffset(0)]
			public bool bEnable;
		}

		// Token: 0x02003525 RID: 13605
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __SetRecordTempSkinDef3_FunctionParams
		{
			// Token: 0x04017559 RID: 95577
			[FieldOffset(0)]
			public bool bEnable;
		}

		// Token: 0x02003526 RID: 13606
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __SetRecordTempSkinDef2_FunctionParams
		{
			// Token: 0x0401755A RID: 95578
			[FieldOffset(0)]
			public bool bEnable;
		}

		// Token: 0x02003527 RID: 13607
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __SetRecordTempSkinDef_FunctionParams
		{
			// Token: 0x0401755B RID: 95579
			[FieldOffset(0)]
			public bool bEnable;
		}

		// Token: 0x02003528 RID: 13608
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __SetRecordTempSkin_FunctionParams
		{
			// Token: 0x0401755C RID: 95580
			[FieldOffset(0)]
			public bool bEnable;
		}

		// Token: 0x02003529 RID: 13609
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __SetRecordTempGPU_FunctionParams
		{
			// Token: 0x0401755D RID: 95581
			[FieldOffset(0)]
			public bool bEnable;
		}

		// Token: 0x0200352A RID: 13610
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __SetRecordTempFPSThrottle_FunctionParams
		{
			// Token: 0x0401755E RID: 95582
			[FieldOffset(0)]
			public bool bEnable;
		}

		// Token: 0x0200352B RID: 13611
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __SetRecordTempCPU_FunctionParams
		{
			// Token: 0x0401755F RID: 95583
			[FieldOffset(0)]
			public bool bEnable;
		}

		// Token: 0x0200352C RID: 13612
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __SetRecordTempBat_FunctionParams
		{
			// Token: 0x04017560 RID: 95584
			[FieldOffset(0)]
			public bool bEnable;
		}

		// Token: 0x0200352D RID: 13613
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __SetRecordTempAllData_FunctionParams
		{
			// Token: 0x04017561 RID: 95585
			[FieldOffset(0)]
			public bool bEnable;
		}

		// Token: 0x0200352E RID: 13614
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __SetRecordTargetFPS_FunctionParams
		{
			// Token: 0x04017562 RID: 95586
			[FieldOffset(0)]
			public bool bEnable;
		}

		// Token: 0x0200352F RID: 13615
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __SetRecordStatAllData_FunctionParams
		{
			// Token: 0x04017563 RID: 95587
			[FieldOffset(0)]
			public bool bEnable;
		}

		// Token: 0x02003530 RID: 13616
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __SetRecordMemoryInfoTotalFree_FunctionParams
		{
			// Token: 0x04017564 RID: 95588
			[FieldOffset(0)]
			public bool bEnable;
		}

		// Token: 0x02003531 RID: 13617
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __SetRecordMemoryInfoAvailUsed_FunctionParams
		{
			// Token: 0x04017565 RID: 95589
			[FieldOffset(0)]
			public bool bEnable;
		}

		// Token: 0x02003532 RID: 13618
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __SetRecordHWPTValue_FunctionParams
		{
			// Token: 0x04017566 RID: 95590
			[FieldOffset(0)]
			public bool bEnable;
		}

		// Token: 0x02003533 RID: 13619
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __SetRecordHWPTDurationUS_FunctionParams
		{
			// Token: 0x04017567 RID: 95591
			[FieldOffset(0)]
			public bool bEnable;
		}

		// Token: 0x02003534 RID: 13620
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __SetRecordHWPTDurationMS_FunctionParams
		{
			// Token: 0x04017568 RID: 95592
			[FieldOffset(0)]
			public bool bEnable;
		}

		// Token: 0x02003535 RID: 13621
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __SetRecordHWPTAllData_FunctionParams
		{
			// Token: 0x04017569 RID: 95593
			[FieldOffset(0)]
			public bool bEnable;
		}

		// Token: 0x02003536 RID: 13622
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __SetRecordGPUFreq_FunctionParams
		{
			// Token: 0x0401756A RID: 95594
			[FieldOffset(0)]
			public bool bEnable;
		}

		// Token: 0x02003537 RID: 13623
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __SetRecordGPUFrameTime_FunctionParams
		{
			// Token: 0x0401756B RID: 95595
			[FieldOffset(0)]
			public bool bEnable;
		}

		// Token: 0x02003538 RID: 13624
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __SetRecordGPUAvgURate_FunctionParams
		{
			// Token: 0x0401756C RID: 95596
			[FieldOffset(0)]
			public bool bEnable;
		}

		// Token: 0x02003539 RID: 13625
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __SetRecordGPUAllData_FunctionParams
		{
			// Token: 0x0401756D RID: 95597
			[FieldOffset(0)]
			public bool bEnable;
		}

		// Token: 0x0200353A RID: 13626
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __SetRecordFPSControlStatus_FunctionParams
		{
			// Token: 0x0401756E RID: 95598
			[FieldOffset(0)]
			public bool bEnable;
		}

		// Token: 0x0200353B RID: 13627
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __SetRecordCriticalThreadDep_FunctionParams
		{
			// Token: 0x0401756F RID: 95599
			[FieldOffset(0)]
			public bool bEnable;
		}

		// Token: 0x0200353C RID: 13628
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __SetRecordCriticalThreadBG_FunctionParams
		{
			// Token: 0x04017570 RID: 95600
			[FieldOffset(0)]
			public bool bEnable;
		}

		// Token: 0x0200353D RID: 13629
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __SetRecordCPUMCoreNum_FunctionParams
		{
			// Token: 0x04017571 RID: 95601
			[FieldOffset(0)]
			public bool bEnable;
		}

		// Token: 0x0200353E RID: 13630
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __SetRecordCPUMCoreLoad_FunctionParams
		{
			// Token: 0x04017572 RID: 95602
			[FieldOffset(0)]
			public bool bEnable;
		}

		// Token: 0x0200353F RID: 13631
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __SetRecordCPUMCoreFreq_FunctionParams
		{
			// Token: 0x04017573 RID: 95603
			[FieldOffset(0)]
			public bool bEnable;
		}

		// Token: 0x02003540 RID: 13632
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __SetRecordCPULCoreNum_FunctionParams
		{
			// Token: 0x04017574 RID: 95604
			[FieldOffset(0)]
			public bool bEnable;
		}

		// Token: 0x02003541 RID: 13633
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __SetRecordCPULCoreLoad_FunctionParams
		{
			// Token: 0x04017575 RID: 95605
			[FieldOffset(0)]
			public bool bEnable;
		}

		// Token: 0x02003542 RID: 13634
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __SetRecordCPULCoreFreq_FunctionParams
		{
			// Token: 0x04017576 RID: 95606
			[FieldOffset(0)]
			public bool bEnable;
		}

		// Token: 0x02003543 RID: 13635
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __SetRecordCPUFrameTime_FunctionParams
		{
			// Token: 0x04017577 RID: 95607
			[FieldOffset(0)]
			public bool bEnable;
		}

		// Token: 0x02003544 RID: 13636
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __SetRecordCPUBCoreNum_FunctionParams
		{
			// Token: 0x04017578 RID: 95608
			[FieldOffset(0)]
			public bool bEnable;
		}

		// Token: 0x02003545 RID: 13637
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __SetRecordCPUBCoreLoad_FunctionParams
		{
			// Token: 0x04017579 RID: 95609
			[FieldOffset(0)]
			public bool bEnable;
		}

		// Token: 0x02003546 RID: 13638
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __SetRecordCPUBCoreFreq_FunctionParams
		{
			// Token: 0x0401757A RID: 95610
			[FieldOffset(0)]
			public bool bEnable;
		}

		// Token: 0x02003547 RID: 13639
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __SetRecordCPUAllData_FunctionParams
		{
			// Token: 0x0401757B RID: 95611
			[FieldOffset(0)]
			public bool bEnable;
		}

		// Token: 0x02003548 RID: 13640
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __SetRecordBATNowVoltage_FunctionParams
		{
			// Token: 0x0401757C RID: 95612
			[FieldOffset(0)]
			public bool bEnable;
		}

		// Token: 0x02003549 RID: 13641
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __SetRecordBATNowPower_FunctionParams
		{
			// Token: 0x0401757D RID: 95613
			[FieldOffset(0)]
			public bool bEnable;
		}

		// Token: 0x0200354A RID: 13642
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __SetRecordBATNowLevel_FunctionParams
		{
			// Token: 0x0401757E RID: 95614
			[FieldOffset(0)]
			public bool bEnable;
		}

		// Token: 0x0200354B RID: 13643
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __SetRecordBATNowCurrent_FunctionParams
		{
			// Token: 0x0401757F RID: 95615
			[FieldOffset(0)]
			public bool bEnable;
		}

		// Token: 0x0200354C RID: 13644
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __SetRecordBATNowCharging_FunctionParams
		{
			// Token: 0x04017580 RID: 95616
			[FieldOffset(0)]
			public bool bEnable;
		}

		// Token: 0x0200354D RID: 13645
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __SetRecordBATAvgPower_FunctionParams
		{
			// Token: 0x04017581 RID: 95617
			[FieldOffset(0)]
			public bool bEnable;
		}

		// Token: 0x0200354E RID: 13646
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __SetRecordBATAvgCurrent_FunctionParams
		{
			// Token: 0x04017582 RID: 95618
			[FieldOffset(0)]
			public bool bEnable;
		}

		// Token: 0x0200354F RID: 13647
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __SetRecordBATAllData_FunctionParams
		{
			// Token: 0x04017583 RID: 95619
			[FieldOffset(0)]
			public bool bEnable;
		}

		// Token: 0x02003550 RID: 13648
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __SetRecordBATAdvicePower_FunctionParams
		{
			// Token: 0x04017584 RID: 95620
			[FieldOffset(0)]
			public bool bEnable;
		}

		// Token: 0x02003551 RID: 13649
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __SetRecordBATAdviceCurrent_FunctionParams
		{
			// Token: 0x04017585 RID: 95621
			[FieldOffset(0)]
			public bool bEnable;
		}

		// Token: 0x02003552 RID: 13650
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __SetRecordAllTemperatureMetrics_FunctionParams
		{
			// Token: 0x04017586 RID: 95622
			[FieldOffset(0)]
			public bool bEnable;
		}

		// Token: 0x02003553 RID: 13651
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __SetRecordAllSystemMetrics_FunctionParams
		{
			// Token: 0x04017587 RID: 95623
			[FieldOffset(0)]
			public bool bEnable;
		}

		// Token: 0x02003554 RID: 13652
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __SetRecordAllPerfData_FunctionParams
		{
			// Token: 0x04017588 RID: 95624
			[FieldOffset(0)]
			public bool bEnable;
		}

		// Token: 0x02003555 RID: 13653
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __SetRecordAllGPUMetrics_FunctionParams
		{
			// Token: 0x04017589 RID: 95625
			[FieldOffset(0)]
			public bool bEnable;
		}

		// Token: 0x02003556 RID: 13654
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __SetRecordAllGPUCounter_FunctionParams
		{
			// Token: 0x0401758A RID: 95626
			[FieldOffset(0)]
			public bool bEnable;
		}

		// Token: 0x02003557 RID: 13655
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __SetRecordAllCPUMetrics_FunctionParams
		{
			// Token: 0x0401758B RID: 95627
			[FieldOffset(0)]
			public bool bEnable;
		}

		// Token: 0x02003558 RID: 13656
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __SetRecordAllBatteryMetrics_FunctionParams
		{
			// Token: 0x0401758C RID: 95628
			[FieldOffset(0)]
			public bool bEnable;
		}

		// Token: 0x02003559 RID: 13657
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __SetRecordAllAdviceData_FunctionParams
		{
			// Token: 0x0401758D RID: 95629
			[FieldOffset(0)]
			public bool bEnable;
		}

		// Token: 0x0200355A RID: 13658
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __SetRecordAll_FunctionParams
		{
			// Token: 0x0401758E RID: 95630
			[FieldOffset(0)]
			public bool bEnable;
		}

		// Token: 0x0200355B RID: 13659
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __SetRecordAdviceWorkerCount_FunctionParams
		{
			// Token: 0x0401758F RID: 95631
			[FieldOffset(0)]
			public bool bEnable;
		}

		// Token: 0x0200355C RID: 13660
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __SetRecordAdviceBatPower_FunctionParams
		{
			// Token: 0x04017590 RID: 95632
			[FieldOffset(0)]
			public bool bEnable;
		}

		// Token: 0x0200355D RID: 13661
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __SetRecordAdviceBatCurrent_FunctionParams
		{
			// Token: 0x04017591 RID: 95633
			[FieldOffset(0)]
			public bool bEnable;
		}

		// Token: 0x0200355E RID: 13662
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __SetEnableAll_FunctionParams
		{
			// Token: 0x04017592 RID: 95634
			[FieldOffset(0)]
			public bool bEnable;
		}

		// Token: 0x0200355F RID: 13663
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __IsRecordingThermalStatus_FunctionParams
		{
			// Token: 0x04017593 RID: 95635
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x02003560 RID: 13664
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __IsRecordingTempSkinDef3_FunctionParams
		{
			// Token: 0x04017594 RID: 95636
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x02003561 RID: 13665
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __IsRecordingTempSkinDef2_FunctionParams
		{
			// Token: 0x04017595 RID: 95637
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x02003562 RID: 13666
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __IsRecordingTempSkinDef_FunctionParams
		{
			// Token: 0x04017596 RID: 95638
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x02003563 RID: 13667
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __IsRecordingTempSkin_FunctionParams
		{
			// Token: 0x04017597 RID: 95639
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x02003564 RID: 13668
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __IsRecordingTempGPU_FunctionParams
		{
			// Token: 0x04017598 RID: 95640
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x02003565 RID: 13669
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __IsRecordingTempFPSThrottle_FunctionParams
		{
			// Token: 0x04017599 RID: 95641
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x02003566 RID: 13670
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __IsRecordingTempCPU_FunctionParams
		{
			// Token: 0x0401759A RID: 95642
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x02003567 RID: 13671
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __IsRecordingTempBat_FunctionParams
		{
			// Token: 0x0401759B RID: 95643
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x02003568 RID: 13672
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __IsRecordingTempAllData_FunctionParams
		{
			// Token: 0x0401759C RID: 95644
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x02003569 RID: 13673
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __IsRecordingTargetFPS_FunctionParams
		{
			// Token: 0x0401759D RID: 95645
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x0200356A RID: 13674
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __IsRecordingStatAllData_FunctionParams
		{
			// Token: 0x0401759E RID: 95646
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x0200356B RID: 13675
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __IsRecordingMemoryInfoTotalFree_FunctionParams
		{
			// Token: 0x0401759F RID: 95647
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x0200356C RID: 13676
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __IsRecordingMemoryInfoAvailUsed_FunctionParams
		{
			// Token: 0x040175A0 RID: 95648
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x0200356D RID: 13677
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __IsRecordingHWPTValue_FunctionParams
		{
			// Token: 0x040175A1 RID: 95649
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x0200356E RID: 13678
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __IsRecordingHWPTDurationUS_FunctionParams
		{
			// Token: 0x040175A2 RID: 95650
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x0200356F RID: 13679
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __IsRecordingHWPTDurationMS_FunctionParams
		{
			// Token: 0x040175A3 RID: 95651
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x02003570 RID: 13680
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __IsRecordingHWPTAllData_FunctionParams
		{
			// Token: 0x040175A4 RID: 95652
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x02003571 RID: 13681
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __IsRecordingGPUFreq_FunctionParams
		{
			// Token: 0x040175A5 RID: 95653
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x02003572 RID: 13682
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __IsRecordingGPUFrameTime_FunctionParams
		{
			// Token: 0x040175A6 RID: 95654
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x02003573 RID: 13683
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __IsRecordingGPUAvgURate_FunctionParams
		{
			// Token: 0x040175A7 RID: 95655
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x02003574 RID: 13684
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __IsRecordingGPUAllData_FunctionParams
		{
			// Token: 0x040175A8 RID: 95656
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x02003575 RID: 13685
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __IsRecordingFPSControlStatus_FunctionParams
		{
			// Token: 0x040175A9 RID: 95657
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x02003576 RID: 13686
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __IsRecordingCriticalThreadDep_FunctionParams
		{
			// Token: 0x040175AA RID: 95658
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x02003577 RID: 13687
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __IsRecordingCriticalThreadBG_FunctionParams
		{
			// Token: 0x040175AB RID: 95659
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x02003578 RID: 13688
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __IsRecordingCPUMCoreNum_FunctionParams
		{
			// Token: 0x040175AC RID: 95660
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x02003579 RID: 13689
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __IsRecordingCPUMCoreLoad_FunctionParams
		{
			// Token: 0x040175AD RID: 95661
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x0200357A RID: 13690
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __IsRecordingCPUMCoreFreq_FunctionParams
		{
			// Token: 0x040175AE RID: 95662
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x0200357B RID: 13691
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __IsRecordingCPULCoreNum_FunctionParams
		{
			// Token: 0x040175AF RID: 95663
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x0200357C RID: 13692
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __IsRecordingCPULCoreLoad_FunctionParams
		{
			// Token: 0x040175B0 RID: 95664
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x0200357D RID: 13693
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __IsRecordingCPULCoreFreq_FunctionParams
		{
			// Token: 0x040175B1 RID: 95665
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x0200357E RID: 13694
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __IsRecordingCPUFrameTime_FunctionParams
		{
			// Token: 0x040175B2 RID: 95666
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x0200357F RID: 13695
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __IsRecordingCPUBCoreNum_FunctionParams
		{
			// Token: 0x040175B3 RID: 95667
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x02003580 RID: 13696
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __IsRecordingCPUBCoreLoad_FunctionParams
		{
			// Token: 0x040175B4 RID: 95668
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x02003581 RID: 13697
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __IsRecordingCPUBCoreFreq_FunctionParams
		{
			// Token: 0x040175B5 RID: 95669
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x02003582 RID: 13698
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __IsRecordingCPUAllData_FunctionParams
		{
			// Token: 0x040175B6 RID: 95670
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x02003583 RID: 13699
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __IsRecordingBATNowVoltage_FunctionParams
		{
			// Token: 0x040175B7 RID: 95671
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x02003584 RID: 13700
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __IsRecordingBATNowPower_FunctionParams
		{
			// Token: 0x040175B8 RID: 95672
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x02003585 RID: 13701
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __IsRecordingBATNowLevel_FunctionParams
		{
			// Token: 0x040175B9 RID: 95673
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x02003586 RID: 13702
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __IsRecordingBATNowCurrent_FunctionParams
		{
			// Token: 0x040175BA RID: 95674
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x02003587 RID: 13703
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __IsRecordingBATNowCharging_FunctionParams
		{
			// Token: 0x040175BB RID: 95675
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x02003588 RID: 13704
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __IsRecordingBATAvgPower_FunctionParams
		{
			// Token: 0x040175BC RID: 95676
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x02003589 RID: 13705
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __IsRecordingBATAvgCurrent_FunctionParams
		{
			// Token: 0x040175BD RID: 95677
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x0200358A RID: 13706
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __IsRecordingBATAllData_FunctionParams
		{
			// Token: 0x040175BE RID: 95678
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x0200358B RID: 13707
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __IsRecordingBATAdvicePower_FunctionParams
		{
			// Token: 0x040175BF RID: 95679
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x0200358C RID: 13708
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __IsRecordingBATAdviceCurrent_FunctionParams
		{
			// Token: 0x040175C0 RID: 95680
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x0200358D RID: 13709
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __IsRecordingAllPerfData_FunctionParams
		{
			// Token: 0x040175C1 RID: 95681
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x0200358E RID: 13710
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __IsRecordingAllGPUCounter_FunctionParams
		{
			// Token: 0x040175C2 RID: 95682
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x0200358F RID: 13711
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __IsRecordingAllAdviceData_FunctionParams
		{
			// Token: 0x040175C3 RID: 95683
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x02003590 RID: 13712
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __IsRecordingAll_FunctionParams
		{
			// Token: 0x040175C4 RID: 95684
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x02003591 RID: 13713
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __IsRecordingAdviceWorkerCount_FunctionParams
		{
			// Token: 0x040175C5 RID: 95685
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x02003592 RID: 13714
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __IsRecordingAdviceBatPower_FunctionParams
		{
			// Token: 0x040175C6 RID: 95686
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x02003593 RID: 13715
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __IsRecordingAdviceBatCurrent_FunctionParams
		{
			// Token: 0x040175C7 RID: 95687
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x02003594 RID: 13716
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __IsRecording_FunctionParams
		{
			// Token: 0x040175C8 RID: 95688
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x02003595 RID: 13717
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __GetSampleCount_FunctionParams
		{
			// Token: 0x040175C9 RID: 95689
			[FieldOffset(0)]
			public int __Result;
		}

		// Token: 0x02003596 RID: 13718
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __GetFailureCount_FunctionParams
		{
			// Token: 0x040175CA RID: 95690
			[FieldOffset(0)]
			public int __Result;
		}
	}
}
