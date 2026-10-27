using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001A1F RID: 6687
	[UnrealObjectPath("/Script/KuroPerformance.KuroPerformanceBPLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UKuroPerformanceBPLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06018BC0 RID: 101312 RVA: 0x00248264 File Offset: 0x00246464
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroPerformanceBPLibrary._ClassPtr;
		}

		// Token: 0x06018BC1 RID: 101313 RVA: 0x00248270 File Offset: 0x00246470
		public UKuroPerformanceBPLibrary() : this(BuiltinUtils.AllocNativeUObject(UKuroPerformanceBPLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06018BC2 RID: 101314 RVA: 0x00248298 File Offset: 0x00246498
		[NullableContext(1)]
		public UKuroPerformanceBPLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroPerformanceBPLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06018BC3 RID: 101315 RVA: 0x002482CC File Offset: 0x002464CC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static bool UpdateGameConfigSceneTransition(bool Enable)
		{
			UKuroPerformanceBPLibrary.__UpdateGameConfigSceneTransition_FunctionParams* ptr = stackalloc UKuroPerformanceBPLibrary.__UpdateGameConfigSceneTransition_FunctionParams[(UIntPtr)17] + 15L / (long)sizeof(UKuroPerformanceBPLibrary.__UpdateGameConfigSceneTransition_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroPerformanceBPLibrary.__UpdateGameConfigSceneTransition_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Enable = Enable;
			UnrealReflectionUtils.CallUFunction(UKuroPerformanceBPLibrary._ClassDefaultObjectPtr, UKuroPerformanceBPLibrary.__UpdateGameConfigSceneTransition_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06018BC4 RID: 101316 RVA: 0x00248318 File Offset: 0x00246518
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static bool UpdateGameConfigFPS(int FPS)
		{
			UKuroPerformanceBPLibrary.__UpdateGameConfigFPS_FunctionParams* ptr = stackalloc UKuroPerformanceBPLibrary.__UpdateGameConfigFPS_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UKuroPerformanceBPLibrary.__UpdateGameConfigFPS_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroPerformanceBPLibrary.__UpdateGameConfigFPS_NativeFunctionPtr, (void*)ptr, 1);
			ptr->FPS = FPS;
			UnrealReflectionUtils.CallUFunction(UKuroPerformanceBPLibrary._ClassDefaultObjectPtr, UKuroPerformanceBPLibrary.__UpdateGameConfigFPS_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06018BC5 RID: 101317 RVA: 0x00248364 File Offset: 0x00246564
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static bool UpdateGameConfig(in FKuroGameConfig GameConfig)
		{
			UKuroPerformanceBPLibrary.__UpdateGameConfig_FunctionParams* ptr = stackalloc UKuroPerformanceBPLibrary.__UpdateGameConfig_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UKuroPerformanceBPLibrary.__UpdateGameConfig_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroPerformanceBPLibrary.__UpdateGameConfig_NativeFunctionPtr, (void*)ptr, 1);
			ptr->GameConfig = GameConfig;
			UnrealReflectionUtils.CallUFunction(UKuroPerformanceBPLibrary._ClassDefaultObjectPtr, UKuroPerformanceBPLibrary.__UpdateGameConfig_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06018BC6 RID: 101318 RVA: 0x002483B8 File Offset: 0x002465B8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static bool UnregisterCriticalThreads(int GameTid, int RenderTid, int RHITid)
		{
			UKuroPerformanceBPLibrary.__UnregisterCriticalThreads_FunctionParams* ptr = stackalloc UKuroPerformanceBPLibrary.__UnregisterCriticalThreads_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UKuroPerformanceBPLibrary.__UnregisterCriticalThreads_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroPerformanceBPLibrary.__UnregisterCriticalThreads_NativeFunctionPtr, (void*)ptr, 1);
			ptr->GameTid = GameTid;
			ptr->RenderTid = RenderTid;
			ptr->RHITid = RHITid;
			UnrealReflectionUtils.CallUFunction(UKuroPerformanceBPLibrary._ClassDefaultObjectPtr, UKuroPerformanceBPLibrary.__UnregisterCriticalThreads_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06018BC7 RID: 101319 RVA: 0x00248414 File Offset: 0x00246614
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static int TickPerfReport()
		{
			UKuroPerformanceBPLibrary.__TickPerfReport_FunctionParams* ptr = stackalloc UKuroPerformanceBPLibrary.__TickPerfReport_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UKuroPerformanceBPLibrary.__TickPerfReport_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroPerformanceBPLibrary.__TickPerfReport_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(UKuroPerformanceBPLibrary._ClassDefaultObjectPtr, UKuroPerformanceBPLibrary.__TickPerfReport_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06018BC8 RID: 101320 RVA: 0x0024845C File Offset: 0x0024665C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static int TickPerformanceReport()
		{
			UKuroPerformanceBPLibrary.__TickPerformanceReport_FunctionParams* ptr = stackalloc UKuroPerformanceBPLibrary.__TickPerformanceReport_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UKuroPerformanceBPLibrary.__TickPerformanceReport_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroPerformanceBPLibrary.__TickPerformanceReport_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(UKuroPerformanceBPLibrary._ClassDefaultObjectPtr, UKuroPerformanceBPLibrary.__TickPerformanceReport_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06018BC9 RID: 101321 RVA: 0x002484A4 File Offset: 0x002466A4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static int Tick()
		{
			UKuroPerformanceBPLibrary.__Tick_FunctionParams* ptr = stackalloc UKuroPerformanceBPLibrary.__Tick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UKuroPerformanceBPLibrary.__Tick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroPerformanceBPLibrary.__Tick_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(UKuroPerformanceBPLibrary._ClassDefaultObjectPtr, UKuroPerformanceBPLibrary.__Tick_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06018BCA RID: 101322 RVA: 0x002484EC File Offset: 0x002466EC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static bool SyncRenderingFrameID(int FrameId)
		{
			UKuroPerformanceBPLibrary.__SyncRenderingFrameID_FunctionParams* ptr = stackalloc UKuroPerformanceBPLibrary.__SyncRenderingFrameID_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UKuroPerformanceBPLibrary.__SyncRenderingFrameID_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroPerformanceBPLibrary.__SyncRenderingFrameID_NativeFunctionPtr, (void*)ptr, 1);
			ptr->FrameId = FrameId;
			UnrealReflectionUtils.CallUFunction(UKuroPerformanceBPLibrary._ClassDefaultObjectPtr, UKuroPerformanceBPLibrary.__SyncRenderingFrameID_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06018BCB RID: 101323 RVA: 0x00248538 File Offset: 0x00246738
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static bool StopService(int Service)
		{
			UKuroPerformanceBPLibrary.__StopService_FunctionParams* ptr = stackalloc UKuroPerformanceBPLibrary.__StopService_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UKuroPerformanceBPLibrary.__StopService_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroPerformanceBPLibrary.__StopService_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Service = Service;
			UnrealReflectionUtils.CallUFunction(UKuroPerformanceBPLibrary._ClassDefaultObjectPtr, UKuroPerformanceBPLibrary.__StopService_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06018BCC RID: 101324 RVA: 0x00248584 File Offset: 0x00246784
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static bool StopPerformanceAdaptiveService(int EServiceFlags)
		{
			UKuroPerformanceBPLibrary.__StopPerformanceAdaptiveService_FunctionParams* ptr = stackalloc UKuroPerformanceBPLibrary.__StopPerformanceAdaptiveService_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UKuroPerformanceBPLibrary.__StopPerformanceAdaptiveService_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroPerformanceBPLibrary.__StopPerformanceAdaptiveService_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EServiceFlags = EServiceFlags;
			UnrealReflectionUtils.CallUFunction(UKuroPerformanceBPLibrary._ClassDefaultObjectPtr, UKuroPerformanceBPLibrary.__StopPerformanceAdaptiveService_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06018BCD RID: 101325 RVA: 0x002485D0 File Offset: 0x002467D0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static bool StartService(int Service)
		{
			UKuroPerformanceBPLibrary.__StartService_FunctionParams* ptr = stackalloc UKuroPerformanceBPLibrary.__StartService_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UKuroPerformanceBPLibrary.__StartService_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroPerformanceBPLibrary.__StartService_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Service = Service;
			UnrealReflectionUtils.CallUFunction(UKuroPerformanceBPLibrary._ClassDefaultObjectPtr, UKuroPerformanceBPLibrary.__StartService_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06018BCE RID: 101326 RVA: 0x0024861C File Offset: 0x0024681C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static bool StartPerformanceAdaptiveService(int EServiceFlags)
		{
			UKuroPerformanceBPLibrary.__StartPerformanceAdaptiveService_FunctionParams* ptr = stackalloc UKuroPerformanceBPLibrary.__StartPerformanceAdaptiveService_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UKuroPerformanceBPLibrary.__StartPerformanceAdaptiveService_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroPerformanceBPLibrary.__StartPerformanceAdaptiveService_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EServiceFlags = EServiceFlags;
			UnrealReflectionUtils.CallUFunction(UKuroPerformanceBPLibrary._ClassDefaultObjectPtr, UKuroPerformanceBPLibrary.__StartPerformanceAdaptiveService_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06018BCF RID: 101327 RVA: 0x00248668 File Offset: 0x00246868
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static bool SetTargetFPS(int FPS, int ThreadId = 0)
		{
			UKuroPerformanceBPLibrary.__SetTargetFPS_FunctionParams* ptr = stackalloc UKuroPerformanceBPLibrary.__SetTargetFPS_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(UKuroPerformanceBPLibrary.__SetTargetFPS_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroPerformanceBPLibrary.__SetTargetFPS_NativeFunctionPtr, (void*)ptr, 1);
			ptr->FPS = FPS;
			ptr->ThreadId = ThreadId;
			UnrealReflectionUtils.CallUFunction(UKuroPerformanceBPLibrary._ClassDefaultObjectPtr, UKuroPerformanceBPLibrary.__SetTargetFPS_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06018BD0 RID: 101328 RVA: 0x002486BC File Offset: 0x002468BC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void SetPerformanceAdaptiveStatus(bool bEnable)
		{
			UKuroPerformanceBPLibrary.__SetPerformanceAdaptiveStatus_FunctionParams* ptr = stackalloc UKuroPerformanceBPLibrary.__SetPerformanceAdaptiveStatus_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UKuroPerformanceBPLibrary.__SetPerformanceAdaptiveStatus_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroPerformanceBPLibrary.__SetPerformanceAdaptiveStatus_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bEnable = bEnable;
			UnrealReflectionUtils.CallUFunction(UKuroPerformanceBPLibrary._ClassDefaultObjectPtr, UKuroPerformanceBPLibrary.__SetPerformanceAdaptiveStatus_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06018BD1 RID: 101329 RVA: 0x00248704 File Offset: 0x00246904
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static bool SetForeground(bool bForeGround)
		{
			UKuroPerformanceBPLibrary.__SetForeground_FunctionParams* ptr = stackalloc UKuroPerformanceBPLibrary.__SetForeground_FunctionParams[(UIntPtr)17] + 15L / (long)sizeof(UKuroPerformanceBPLibrary.__SetForeground_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroPerformanceBPLibrary.__SetForeground_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bForeGround = bForeGround;
			UnrealReflectionUtils.CallUFunction(UKuroPerformanceBPLibrary._ClassDefaultObjectPtr, UKuroPerformanceBPLibrary.__SetForeground_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06018BD2 RID: 101330 RVA: 0x00248750 File Offset: 0x00246950
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static bool RegisterCriticalThreads(int GameTid, int RenderTid, int RHITid)
		{
			UKuroPerformanceBPLibrary.__RegisterCriticalThreads_FunctionParams* ptr = stackalloc UKuroPerformanceBPLibrary.__RegisterCriticalThreads_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UKuroPerformanceBPLibrary.__RegisterCriticalThreads_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroPerformanceBPLibrary.__RegisterCriticalThreads_NativeFunctionPtr, (void*)ptr, 1);
			ptr->GameTid = GameTid;
			ptr->RenderTid = RenderTid;
			ptr->RHITid = RHITid;
			UnrealReflectionUtils.CallUFunction(UKuroPerformanceBPLibrary._ClassDefaultObjectPtr, UKuroPerformanceBPLibrary.__RegisterCriticalThreads_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06018BD3 RID: 101331 RVA: 0x002487AC File Offset: 0x002469AC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void QueryBoostGPU(ref FKuroBoostQueryResult BoostQueryResult)
		{
			UKuroPerformanceBPLibrary.__QueryBoostGPU_FunctionParams* ptr = stackalloc UKuroPerformanceBPLibrary.__QueryBoostGPU_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UKuroPerformanceBPLibrary.__QueryBoostGPU_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroPerformanceBPLibrary.__QueryBoostGPU_NativeFunctionPtr, (void*)ptr, 1);
			ptr->BoostQueryResult = BoostQueryResult;
			UnrealReflectionUtils.CallUFunction(UKuroPerformanceBPLibrary._ClassDefaultObjectPtr, UKuroPerformanceBPLibrary.__QueryBoostGPU_NativeFunctionPtr, (void*)ptr, 0);
			BoostQueryResult = ptr->BoostQueryResult;
		}

		// Token: 0x06018BD4 RID: 101332 RVA: 0x00248804 File Offset: 0x00246A04
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void QueryBoostCPU(ref FKuroBoostQueryResult BoostQueryResult)
		{
			UKuroPerformanceBPLibrary.__QueryBoostCPU_FunctionParams* ptr = stackalloc UKuroPerformanceBPLibrary.__QueryBoostCPU_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UKuroPerformanceBPLibrary.__QueryBoostCPU_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroPerformanceBPLibrary.__QueryBoostCPU_NativeFunctionPtr, (void*)ptr, 1);
			ptr->BoostQueryResult = BoostQueryResult;
			UnrealReflectionUtils.CallUFunction(UKuroPerformanceBPLibrary._ClassDefaultObjectPtr, UKuroPerformanceBPLibrary.__QueryBoostCPU_NativeFunctionPtr, (void*)ptr, 0);
			BoostQueryResult = ptr->BoostQueryResult;
		}

		// Token: 0x06018BD5 RID: 101333 RVA: 0x0024885C File Offset: 0x00246A5C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static bool PredictWorkload(int CPULoadScale, int GPULoadScale)
		{
			UKuroPerformanceBPLibrary.__PredictWorkload_FunctionParams* ptr = stackalloc UKuroPerformanceBPLibrary.__PredictWorkload_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(UKuroPerformanceBPLibrary.__PredictWorkload_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroPerformanceBPLibrary.__PredictWorkload_NativeFunctionPtr, (void*)ptr, 1);
			ptr->CPULoadScale = CPULoadScale;
			ptr->GPULoadScale = GPULoadScale;
			UnrealReflectionUtils.CallUFunction(UKuroPerformanceBPLibrary._ClassDefaultObjectPtr, UKuroPerformanceBPLibrary.__PredictWorkload_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06018BD6 RID: 101334 RVA: 0x002488B0 File Offset: 0x00246AB0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static bool IsPredictGPUWorkloadSupported()
		{
			UKuroPerformanceBPLibrary.__IsPredictGPUWorkloadSupported_FunctionParams* ptr = stackalloc UKuroPerformanceBPLibrary.__IsPredictGPUWorkloadSupported_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UKuroPerformanceBPLibrary.__IsPredictGPUWorkloadSupported_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroPerformanceBPLibrary.__IsPredictGPUWorkloadSupported_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(UKuroPerformanceBPLibrary._ClassDefaultObjectPtr, UKuroPerformanceBPLibrary.__IsPredictGPUWorkloadSupported_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06018BD7 RID: 101335 RVA: 0x002488F8 File Offset: 0x00246AF8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static bool IsPredictCPUWorkloadSupported()
		{
			UKuroPerformanceBPLibrary.__IsPredictCPUWorkloadSupported_FunctionParams* ptr = stackalloc UKuroPerformanceBPLibrary.__IsPredictCPUWorkloadSupported_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UKuroPerformanceBPLibrary.__IsPredictCPUWorkloadSupported_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroPerformanceBPLibrary.__IsPredictCPUWorkloadSupported_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(UKuroPerformanceBPLibrary._ClassDefaultObjectPtr, UKuroPerformanceBPLibrary.__IsPredictCPUWorkloadSupported_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06018BD8 RID: 101336 RVA: 0x00248940 File Offset: 0x00246B40
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static bool IsPerformanceAdaptiveRunning()
		{
			UKuroPerformanceBPLibrary.__IsPerformanceAdaptiveRunning_FunctionParams* ptr = stackalloc UKuroPerformanceBPLibrary.__IsPerformanceAdaptiveRunning_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UKuroPerformanceBPLibrary.__IsPerformanceAdaptiveRunning_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroPerformanceBPLibrary.__IsPerformanceAdaptiveRunning_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(UKuroPerformanceBPLibrary._ClassDefaultObjectPtr, UKuroPerformanceBPLibrary.__IsPerformanceAdaptiveRunning_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06018BD9 RID: 101337 RVA: 0x00248988 File Offset: 0x00246B88
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static bool IsPerformanceAdaptiveInitialize()
		{
			UKuroPerformanceBPLibrary.__IsPerformanceAdaptiveInitialize_FunctionParams* ptr = stackalloc UKuroPerformanceBPLibrary.__IsPerformanceAdaptiveInitialize_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UKuroPerformanceBPLibrary.__IsPerformanceAdaptiveInitialize_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroPerformanceBPLibrary.__IsPerformanceAdaptiveInitialize_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(UKuroPerformanceBPLibrary._ClassDefaultObjectPtr, UKuroPerformanceBPLibrary.__IsPerformanceAdaptiveInitialize_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06018BDA RID: 101338 RVA: 0x002489D0 File Offset: 0x00246BD0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static bool InitGameConfigSceneTransition(bool Enable)
		{
			UKuroPerformanceBPLibrary.__InitGameConfigSceneTransition_FunctionParams* ptr = stackalloc UKuroPerformanceBPLibrary.__InitGameConfigSceneTransition_FunctionParams[(UIntPtr)17] + 15L / (long)sizeof(UKuroPerformanceBPLibrary.__InitGameConfigSceneTransition_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroPerformanceBPLibrary.__InitGameConfigSceneTransition_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Enable = Enable;
			UnrealReflectionUtils.CallUFunction(UKuroPerformanceBPLibrary._ClassDefaultObjectPtr, UKuroPerformanceBPLibrary.__InitGameConfigSceneTransition_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06018BDB RID: 101339 RVA: 0x00248A1C File Offset: 0x00246C1C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static bool InitGameConfigFPS(int FPS)
		{
			UKuroPerformanceBPLibrary.__InitGameConfigFPS_FunctionParams* ptr = stackalloc UKuroPerformanceBPLibrary.__InitGameConfigFPS_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UKuroPerformanceBPLibrary.__InitGameConfigFPS_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroPerformanceBPLibrary.__InitGameConfigFPS_NativeFunctionPtr, (void*)ptr, 1);
			ptr->FPS = FPS;
			UnrealReflectionUtils.CallUFunction(UKuroPerformanceBPLibrary._ClassDefaultObjectPtr, UKuroPerformanceBPLibrary.__InitGameConfigFPS_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06018BDC RID: 101340 RVA: 0x00248A68 File Offset: 0x00246C68
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static bool InitGameConfig(in FKuroGameConfig GameConfig)
		{
			UKuroPerformanceBPLibrary.__InitGameConfig_FunctionParams* ptr = stackalloc UKuroPerformanceBPLibrary.__InitGameConfig_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UKuroPerformanceBPLibrary.__InitGameConfig_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroPerformanceBPLibrary.__InitGameConfig_NativeFunctionPtr, (void*)ptr, 1);
			ptr->GameConfig = GameConfig;
			UnrealReflectionUtils.CallUFunction(UKuroPerformanceBPLibrary._ClassDefaultObjectPtr, UKuroPerformanceBPLibrary.__InitGameConfig_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06018BDD RID: 101341 RVA: 0x00248ABC File Offset: 0x00246CBC
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void GetTickedPerformanceReportAndAdvice(in FGetTickedPerformanceReportAndAdviceDelegate ReportDelegate)
		{
			UKuroPerformanceBPLibrary.__GetTickedPerformanceReportAndAdvice_FunctionParams* ptr = stackalloc UKuroPerformanceBPLibrary.__GetTickedPerformanceReportAndAdvice_FunctionParams[(UIntPtr)55] + 15L / (long)sizeof(UKuroPerformanceBPLibrary.__GetTickedPerformanceReportAndAdvice_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroPerformanceBPLibrary.__GetTickedPerformanceReportAndAdvice_NativeFunctionPtr, (void*)ptr, 1);
			IntPtr dest = &ptr->ReportDelegate;
			FGetTickedPerformanceReportAndAdviceDelegate fgetTickedPerformanceReportAndAdviceDelegate = ReportDelegate;
			FScriptDelegate.NativeCopy(dest, (fgetTickedPerformanceReportAndAdviceDelegate != null) ? fgetTickedPerformanceReportAndAdviceDelegate.NativePtr : ((IntPtr)0));
			UnrealReflectionUtils.CallUFunction(UKuroPerformanceBPLibrary._ClassDefaultObjectPtr, UKuroPerformanceBPLibrary.__GetTickedPerformanceReportAndAdvice_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UKuroPerformanceBPLibrary.__GetTickedPerformanceReportAndAdvice_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06018BDE RID: 101342 RVA: 0x00248B28 File Offset: 0x00246D28
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static TEnumAsByte<EKuroBoostFlags> GetSupportedBoostFlag()
		{
			UKuroPerformanceBPLibrary.__GetSupportedBoostFlag_FunctionParams* ptr = stackalloc UKuroPerformanceBPLibrary.__GetSupportedBoostFlag_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UKuroPerformanceBPLibrary.__GetSupportedBoostFlag_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroPerformanceBPLibrary.__GetSupportedBoostFlag_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(UKuroPerformanceBPLibrary._ClassDefaultObjectPtr, UKuroPerformanceBPLibrary.__GetSupportedBoostFlag_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06018BDF RID: 101343 RVA: 0x00248B70 File Offset: 0x00246D70
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static int GetRegisterRHIThreadId()
		{
			UKuroPerformanceBPLibrary.__GetRegisterRHIThreadId_FunctionParams* ptr = stackalloc UKuroPerformanceBPLibrary.__GetRegisterRHIThreadId_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UKuroPerformanceBPLibrary.__GetRegisterRHIThreadId_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroPerformanceBPLibrary.__GetRegisterRHIThreadId_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(UKuroPerformanceBPLibrary._ClassDefaultObjectPtr, UKuroPerformanceBPLibrary.__GetRegisterRHIThreadId_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06018BE0 RID: 101344 RVA: 0x00248BB8 File Offset: 0x00246DB8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static int GetRegisterRenderThreadId()
		{
			UKuroPerformanceBPLibrary.__GetRegisterRenderThreadId_FunctionParams* ptr = stackalloc UKuroPerformanceBPLibrary.__GetRegisterRenderThreadId_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UKuroPerformanceBPLibrary.__GetRegisterRenderThreadId_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroPerformanceBPLibrary.__GetRegisterRenderThreadId_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(UKuroPerformanceBPLibrary._ClassDefaultObjectPtr, UKuroPerformanceBPLibrary.__GetRegisterRenderThreadId_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06018BE1 RID: 101345 RVA: 0x00248C00 File Offset: 0x00246E00
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static int GetRegisterGameThreadId()
		{
			UKuroPerformanceBPLibrary.__GetRegisterGameThreadId_FunctionParams* ptr = stackalloc UKuroPerformanceBPLibrary.__GetRegisterGameThreadId_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UKuroPerformanceBPLibrary.__GetRegisterGameThreadId_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroPerformanceBPLibrary.__GetRegisterGameThreadId_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(UKuroPerformanceBPLibrary._ClassDefaultObjectPtr, UKuroPerformanceBPLibrary.__GetRegisterGameThreadId_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06018BE2 RID: 101346 RVA: 0x00248C48 File Offset: 0x00246E48
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static TEnumAsByte<EKuroModuleStatus> GetPerformanceAdaptiveStatus()
		{
			UKuroPerformanceBPLibrary.__GetPerformanceAdaptiveStatus_FunctionParams* ptr = stackalloc UKuroPerformanceBPLibrary.__GetPerformanceAdaptiveStatus_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UKuroPerformanceBPLibrary.__GetPerformanceAdaptiveStatus_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroPerformanceBPLibrary.__GetPerformanceAdaptiveStatus_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(UKuroPerformanceBPLibrary._ClassDefaultObjectPtr, UKuroPerformanceBPLibrary.__GetPerformanceAdaptiveStatus_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06018BE3 RID: 101347 RVA: 0x00248C90 File Offset: 0x00246E90
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static int GetMaxBoostDurationInSecondForGPU()
		{
			UKuroPerformanceBPLibrary.__GetMaxBoostDurationInSecondForGPU_FunctionParams* ptr = stackalloc UKuroPerformanceBPLibrary.__GetMaxBoostDurationInSecondForGPU_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UKuroPerformanceBPLibrary.__GetMaxBoostDurationInSecondForGPU_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroPerformanceBPLibrary.__GetMaxBoostDurationInSecondForGPU_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(UKuroPerformanceBPLibrary._ClassDefaultObjectPtr, UKuroPerformanceBPLibrary.__GetMaxBoostDurationInSecondForGPU_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06018BE4 RID: 101348 RVA: 0x00248CD8 File Offset: 0x00246ED8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static int GetMaxBoostDurationInSecondForCPU()
		{
			UKuroPerformanceBPLibrary.__GetMaxBoostDurationInSecondForCPU_FunctionParams* ptr = stackalloc UKuroPerformanceBPLibrary.__GetMaxBoostDurationInSecondForCPU_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UKuroPerformanceBPLibrary.__GetMaxBoostDurationInSecondForCPU_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroPerformanceBPLibrary.__GetMaxBoostDurationInSecondForCPU_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(UKuroPerformanceBPLibrary._ClassDefaultObjectPtr, UKuroPerformanceBPLibrary.__GetMaxBoostDurationInSecondForCPU_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06018BE5 RID: 101349 RVA: 0x00248D20 File Offset: 0x00246F20
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static string GetInitReturnMessage()
		{
			UKuroPerformanceBPLibrary.__GetInitReturnMessage_FunctionParams* ptr = stackalloc UKuroPerformanceBPLibrary.__GetInitReturnMessage_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UKuroPerformanceBPLibrary.__GetInitReturnMessage_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroPerformanceBPLibrary.__GetInitReturnMessage_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(UKuroPerformanceBPLibrary._ClassDefaultObjectPtr, UKuroPerformanceBPLibrary.__GetInitReturnMessage_NativeFunctionPtr, (void*)ptr, 0);
			string result = FString.ToString((void*)(&ptr->__Result));
			UnrealReflectionUtils.DestroyStruct(UKuroPerformanceBPLibrary.__GetInitReturnMessage_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x06018BE6 RID: 101350 RVA: 0x00248D7C File Offset: 0x00246F7C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void GetCurrentTemperatureData(in FGetCurrentTemperatureDataDelegate Delegate)
		{
			UKuroPerformanceBPLibrary.__GetCurrentTemperatureData_FunctionParams* ptr = stackalloc UKuroPerformanceBPLibrary.__GetCurrentTemperatureData_FunctionParams[(UIntPtr)55] + 15L / (long)sizeof(UKuroPerformanceBPLibrary.__GetCurrentTemperatureData_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroPerformanceBPLibrary.__GetCurrentTemperatureData_NativeFunctionPtr, (void*)ptr, 1);
			IntPtr dest = &ptr->Delegate;
			FGetCurrentTemperatureDataDelegate fgetCurrentTemperatureDataDelegate = Delegate;
			FScriptDelegate.NativeCopy(dest, (fgetCurrentTemperatureDataDelegate != null) ? fgetCurrentTemperatureDataDelegate.NativePtr : ((IntPtr)0));
			UnrealReflectionUtils.CallUFunction(UKuroPerformanceBPLibrary._ClassDefaultObjectPtr, UKuroPerformanceBPLibrary.__GetCurrentTemperatureData_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UKuroPerformanceBPLibrary.__GetCurrentTemperatureData_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06018BE7 RID: 101351 RVA: 0x00248DE8 File Offset: 0x00246FE8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static int GetCurrentAndroidDeviceRequireAdaptiveModule()
		{
			UKuroPerformanceBPLibrary.__GetCurrentAndroidDeviceRequireAdaptiveModule_FunctionParams* ptr = stackalloc UKuroPerformanceBPLibrary.__GetCurrentAndroidDeviceRequireAdaptiveModule_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UKuroPerformanceBPLibrary.__GetCurrentAndroidDeviceRequireAdaptiveModule_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroPerformanceBPLibrary.__GetCurrentAndroidDeviceRequireAdaptiveModule_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(UKuroPerformanceBPLibrary._ClassDefaultObjectPtr, UKuroPerformanceBPLibrary.__GetCurrentAndroidDeviceRequireAdaptiveModule_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06018BE8 RID: 101352 RVA: 0x00248E30 File Offset: 0x00247030
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static string GetCurrentActivePerformanceAdaptiveModuleName()
		{
			UKuroPerformanceBPLibrary.__GetCurrentActivePerformanceAdaptiveModuleName_FunctionParams* ptr = stackalloc UKuroPerformanceBPLibrary.__GetCurrentActivePerformanceAdaptiveModuleName_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UKuroPerformanceBPLibrary.__GetCurrentActivePerformanceAdaptiveModuleName_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroPerformanceBPLibrary.__GetCurrentActivePerformanceAdaptiveModuleName_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(UKuroPerformanceBPLibrary._ClassDefaultObjectPtr, UKuroPerformanceBPLibrary.__GetCurrentActivePerformanceAdaptiveModuleName_NativeFunctionPtr, (void*)ptr, 0);
			string result = FString.ToString((void*)(&ptr->__Result));
			UnrealReflectionUtils.DestroyStruct(UKuroPerformanceBPLibrary.__GetCurrentActivePerformanceAdaptiveModuleName_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x06018BE9 RID: 101353 RVA: 0x00248E8C File Offset: 0x0024708C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static TEnumAsByte<EKuroBoostFlags> GetBoostFlags(bool bCPU, bool bWithMemory)
		{
			UKuroPerformanceBPLibrary.__GetBoostFlags_FunctionParams* ptr = stackalloc UKuroPerformanceBPLibrary.__GetBoostFlags_FunctionParams[(UIntPtr)18] + 15L / (long)sizeof(UKuroPerformanceBPLibrary.__GetBoostFlags_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroPerformanceBPLibrary.__GetBoostFlags_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bCPU = bCPU;
			ptr->bWithMemory = bWithMemory;
			UnrealReflectionUtils.CallUFunction(UKuroPerformanceBPLibrary._ClassDefaultObjectPtr, UKuroPerformanceBPLibrary.__GetBoostFlags_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06018BEA RID: 101354 RVA: 0x00248EE0 File Offset: 0x002470E0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static bool BoostGPU(int FrequencyPercentage, int BoostDurationInMilliSecond, bool bBoostMemory = false)
		{
			UKuroPerformanceBPLibrary.__BoostGPU_FunctionParams* ptr = stackalloc UKuroPerformanceBPLibrary.__BoostGPU_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(UKuroPerformanceBPLibrary.__BoostGPU_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroPerformanceBPLibrary.__BoostGPU_NativeFunctionPtr, (void*)ptr, 1);
			ptr->FrequencyPercentage = FrequencyPercentage;
			ptr->BoostDurationInMilliSecond = BoostDurationInMilliSecond;
			ptr->bBoostMemory = bBoostMemory;
			UnrealReflectionUtils.CallUFunction(UKuroPerformanceBPLibrary._ClassDefaultObjectPtr, UKuroPerformanceBPLibrary.__BoostGPU_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06018BEB RID: 101355 RVA: 0x00248F3C File Offset: 0x0024713C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static bool BoostCPU(int FrequencyPercentage, int BoostDurationInMilliSecond, bool bBoostMemory = false)
		{
			UKuroPerformanceBPLibrary.__BoostCPU_FunctionParams* ptr = stackalloc UKuroPerformanceBPLibrary.__BoostCPU_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(UKuroPerformanceBPLibrary.__BoostCPU_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroPerformanceBPLibrary.__BoostCPU_NativeFunctionPtr, (void*)ptr, 1);
			ptr->FrequencyPercentage = FrequencyPercentage;
			ptr->BoostDurationInMilliSecond = BoostDurationInMilliSecond;
			ptr->bBoostMemory = bBoostMemory;
			UnrealReflectionUtils.CallUFunction(UKuroPerformanceBPLibrary._ClassDefaultObjectPtr, UKuroPerformanceBPLibrary.__BoostCPU_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06018BEC RID: 101356 RVA: 0x00248F96 File Offset: 0x00247196
		static UKuroPerformanceBPLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroPerformance.KuroPerformanceBPLibrary");
		}

		// Token: 0x06018BED RID: 101357 RVA: 0x00248FA4 File Offset: 0x002471A4
		protected UKuroPerformanceBPLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400D5DA RID: 54746
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroPerformance.KuroPerformanceBPLibrary";

		// Token: 0x0400D5DB RID: 54747
		private static IntPtr _ClassPtr;

		// Token: 0x0400D5DC RID: 54748
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400D5DD RID: 54749
		private static IntPtr __UpdateGameConfigSceneTransition_NativeFunctionPtr;

		// Token: 0x0400D5DE RID: 54750
		private static IntPtr __UpdateGameConfigFPS_NativeFunctionPtr;

		// Token: 0x0400D5DF RID: 54751
		private static IntPtr __UpdateGameConfig_NativeFunctionPtr;

		// Token: 0x0400D5E0 RID: 54752
		private static IntPtr __UnregisterCriticalThreads_NativeFunctionPtr;

		// Token: 0x0400D5E1 RID: 54753
		private static IntPtr __TickPerfReport_NativeFunctionPtr;

		// Token: 0x0400D5E2 RID: 54754
		private static IntPtr __TickPerformanceReport_NativeFunctionPtr;

		// Token: 0x0400D5E3 RID: 54755
		private static IntPtr __Tick_NativeFunctionPtr;

		// Token: 0x0400D5E4 RID: 54756
		private static IntPtr __SyncRenderingFrameID_NativeFunctionPtr;

		// Token: 0x0400D5E5 RID: 54757
		private static IntPtr __StopService_NativeFunctionPtr;

		// Token: 0x0400D5E6 RID: 54758
		private static IntPtr __StopPerformanceAdaptiveService_NativeFunctionPtr;

		// Token: 0x0400D5E7 RID: 54759
		private static IntPtr __StartService_NativeFunctionPtr;

		// Token: 0x0400D5E8 RID: 54760
		private static IntPtr __StartPerformanceAdaptiveService_NativeFunctionPtr;

		// Token: 0x0400D5E9 RID: 54761
		private static IntPtr __SetTargetFPS_NativeFunctionPtr;

		// Token: 0x0400D5EA RID: 54762
		private static IntPtr __SetPerformanceAdaptiveStatus_NativeFunctionPtr;

		// Token: 0x0400D5EB RID: 54763
		private static IntPtr __SetForeground_NativeFunctionPtr;

		// Token: 0x0400D5EC RID: 54764
		private static IntPtr __RegisterCriticalThreads_NativeFunctionPtr;

		// Token: 0x0400D5ED RID: 54765
		private static IntPtr __QueryBoostGPU_NativeFunctionPtr;

		// Token: 0x0400D5EE RID: 54766
		private static IntPtr __QueryBoostCPU_NativeFunctionPtr;

		// Token: 0x0400D5EF RID: 54767
		private static IntPtr __PredictWorkload_NativeFunctionPtr;

		// Token: 0x0400D5F0 RID: 54768
		private static IntPtr __IsPredictGPUWorkloadSupported_NativeFunctionPtr;

		// Token: 0x0400D5F1 RID: 54769
		private static IntPtr __IsPredictCPUWorkloadSupported_NativeFunctionPtr;

		// Token: 0x0400D5F2 RID: 54770
		private static IntPtr __IsPerformanceAdaptiveRunning_NativeFunctionPtr;

		// Token: 0x0400D5F3 RID: 54771
		private static IntPtr __IsPerformanceAdaptiveInitialize_NativeFunctionPtr;

		// Token: 0x0400D5F4 RID: 54772
		private static IntPtr __InitGameConfigSceneTransition_NativeFunctionPtr;

		// Token: 0x0400D5F5 RID: 54773
		private static IntPtr __InitGameConfigFPS_NativeFunctionPtr;

		// Token: 0x0400D5F6 RID: 54774
		private static IntPtr __InitGameConfig_NativeFunctionPtr;

		// Token: 0x0400D5F7 RID: 54775
		private static IntPtr __GetTickedPerformanceReportAndAdvice_NativeFunctionPtr;

		// Token: 0x0400D5F8 RID: 54776
		private static IntPtr __GetSupportedBoostFlag_NativeFunctionPtr;

		// Token: 0x0400D5F9 RID: 54777
		private static IntPtr __GetRegisterRHIThreadId_NativeFunctionPtr;

		// Token: 0x0400D5FA RID: 54778
		private static IntPtr __GetRegisterRenderThreadId_NativeFunctionPtr;

		// Token: 0x0400D5FB RID: 54779
		private static IntPtr __GetRegisterGameThreadId_NativeFunctionPtr;

		// Token: 0x0400D5FC RID: 54780
		private static IntPtr __GetPerformanceAdaptiveStatus_NativeFunctionPtr;

		// Token: 0x0400D5FD RID: 54781
		private static IntPtr __GetMaxBoostDurationInSecondForGPU_NativeFunctionPtr;

		// Token: 0x0400D5FE RID: 54782
		private static IntPtr __GetMaxBoostDurationInSecondForCPU_NativeFunctionPtr;

		// Token: 0x0400D5FF RID: 54783
		private static IntPtr __GetInitReturnMessage_NativeFunctionPtr;

		// Token: 0x0400D600 RID: 54784
		private static IntPtr __GetCurrentTemperatureData_NativeFunctionPtr;

		// Token: 0x0400D601 RID: 54785
		private static IntPtr __GetCurrentAndroidDeviceRequireAdaptiveModule_NativeFunctionPtr;

		// Token: 0x0400D602 RID: 54786
		private static IntPtr __GetCurrentActivePerformanceAdaptiveModuleName_NativeFunctionPtr;

		// Token: 0x0400D603 RID: 54787
		private static IntPtr __GetBoostFlags_NativeFunctionPtr;

		// Token: 0x0400D604 RID: 54788
		private static IntPtr __BoostGPU_NativeFunctionPtr;

		// Token: 0x0400D605 RID: 54789
		private static IntPtr __BoostCPU_NativeFunctionPtr;

		// Token: 0x020030D1 RID: 12497
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 2)]
		protected ref struct __UpdateGameConfigSceneTransition_FunctionParams
		{
			// Token: 0x04016E32 RID: 93746
			[FieldOffset(0)]
			public bool Enable;

			// Token: 0x04016E33 RID: 93747
			[FieldOffset(1)]
			public bool __Result;
		}

		// Token: 0x020030D2 RID: 12498
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __UpdateGameConfigFPS_FunctionParams
		{
			// Token: 0x04016E34 RID: 93748
			[FieldOffset(0)]
			public int FPS;

			// Token: 0x04016E35 RID: 93749
			[FieldOffset(4)]
			public bool __Result;
		}

		// Token: 0x020030D3 RID: 12499
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __UpdateGameConfig_FunctionParams
		{
			// Token: 0x04016E36 RID: 93750
			[FieldOffset(0)]
			public FKuroGameConfig GameConfig;

			// Token: 0x04016E37 RID: 93751
			[FieldOffset(12)]
			public bool __Result;
		}

		// Token: 0x020030D4 RID: 12500
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __UnregisterCriticalThreads_FunctionParams
		{
			// Token: 0x04016E38 RID: 93752
			[FieldOffset(0)]
			public int GameTid;

			// Token: 0x04016E39 RID: 93753
			[FieldOffset(4)]
			public int RenderTid;

			// Token: 0x04016E3A RID: 93754
			[FieldOffset(8)]
			public int RHITid;

			// Token: 0x04016E3B RID: 93755
			[FieldOffset(12)]
			public bool __Result;
		}

		// Token: 0x020030D5 RID: 12501
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __TickPerfReport_FunctionParams
		{
			// Token: 0x04016E3C RID: 93756
			[FieldOffset(0)]
			public int __Result;
		}

		// Token: 0x020030D6 RID: 12502
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __TickPerformanceReport_FunctionParams
		{
			// Token: 0x04016E3D RID: 93757
			[FieldOffset(0)]
			public int __Result;
		}

		// Token: 0x020030D7 RID: 12503
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __Tick_FunctionParams
		{
			// Token: 0x04016E3E RID: 93758
			[FieldOffset(0)]
			public int __Result;
		}

		// Token: 0x020030D8 RID: 12504
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __SyncRenderingFrameID_FunctionParams
		{
			// Token: 0x04016E3F RID: 93759
			[FieldOffset(0)]
			public int FrameId;

			// Token: 0x04016E40 RID: 93760
			[FieldOffset(4)]
			public bool __Result;
		}

		// Token: 0x020030D9 RID: 12505
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __StopService_FunctionParams
		{
			// Token: 0x04016E41 RID: 93761
			[FieldOffset(0)]
			public int Service;

			// Token: 0x04016E42 RID: 93762
			[FieldOffset(4)]
			public bool __Result;
		}

		// Token: 0x020030DA RID: 12506
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __StopPerformanceAdaptiveService_FunctionParams
		{
			// Token: 0x04016E43 RID: 93763
			[FieldOffset(0)]
			public int EServiceFlags;

			// Token: 0x04016E44 RID: 93764
			[FieldOffset(4)]
			public bool __Result;
		}

		// Token: 0x020030DB RID: 12507
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __StartService_FunctionParams
		{
			// Token: 0x04016E45 RID: 93765
			[FieldOffset(0)]
			public int Service;

			// Token: 0x04016E46 RID: 93766
			[FieldOffset(4)]
			public bool __Result;
		}

		// Token: 0x020030DC RID: 12508
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __StartPerformanceAdaptiveService_FunctionParams
		{
			// Token: 0x04016E47 RID: 93767
			[FieldOffset(0)]
			public int EServiceFlags;

			// Token: 0x04016E48 RID: 93768
			[FieldOffset(4)]
			public bool __Result;
		}

		// Token: 0x020030DD RID: 12509
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __SetTargetFPS_FunctionParams
		{
			// Token: 0x04016E49 RID: 93769
			[FieldOffset(0)]
			public int FPS;

			// Token: 0x04016E4A RID: 93770
			[FieldOffset(4)]
			public int ThreadId;

			// Token: 0x04016E4B RID: 93771
			[FieldOffset(8)]
			public bool __Result;
		}

		// Token: 0x020030DE RID: 12510
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __SetPerformanceAdaptiveStatus_FunctionParams
		{
			// Token: 0x04016E4C RID: 93772
			[FieldOffset(0)]
			public bool bEnable;
		}

		// Token: 0x020030DF RID: 12511
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 2)]
		protected ref struct __SetForeground_FunctionParams
		{
			// Token: 0x04016E4D RID: 93773
			[FieldOffset(0)]
			public bool bForeGround;

			// Token: 0x04016E4E RID: 93774
			[FieldOffset(1)]
			public bool __Result;
		}

		// Token: 0x020030E0 RID: 12512
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __RegisterCriticalThreads_FunctionParams
		{
			// Token: 0x04016E4F RID: 93775
			[FieldOffset(0)]
			public int GameTid;

			// Token: 0x04016E50 RID: 93776
			[FieldOffset(4)]
			public int RenderTid;

			// Token: 0x04016E51 RID: 93777
			[FieldOffset(8)]
			public int RHITid;

			// Token: 0x04016E52 RID: 93778
			[FieldOffset(12)]
			public bool __Result;
		}

		// Token: 0x020030E1 RID: 12513
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __QueryBoostGPU_FunctionParams
		{
			// Token: 0x04016E53 RID: 93779
			[FieldOffset(0)]
			public FKuroBoostQueryResult BoostQueryResult;
		}

		// Token: 0x020030E2 RID: 12514
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __QueryBoostCPU_FunctionParams
		{
			// Token: 0x04016E54 RID: 93780
			[FieldOffset(0)]
			public FKuroBoostQueryResult BoostQueryResult;
		}

		// Token: 0x020030E3 RID: 12515
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __PredictWorkload_FunctionParams
		{
			// Token: 0x04016E55 RID: 93781
			[FieldOffset(0)]
			public int CPULoadScale;

			// Token: 0x04016E56 RID: 93782
			[FieldOffset(4)]
			public int GPULoadScale;

			// Token: 0x04016E57 RID: 93783
			[FieldOffset(8)]
			public bool __Result;
		}

		// Token: 0x020030E4 RID: 12516
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __IsPredictGPUWorkloadSupported_FunctionParams
		{
			// Token: 0x04016E58 RID: 93784
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x020030E5 RID: 12517
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __IsPredictCPUWorkloadSupported_FunctionParams
		{
			// Token: 0x04016E59 RID: 93785
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x020030E6 RID: 12518
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __IsPerformanceAdaptiveRunning_FunctionParams
		{
			// Token: 0x04016E5A RID: 93786
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x020030E7 RID: 12519
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __IsPerformanceAdaptiveInitialize_FunctionParams
		{
			// Token: 0x04016E5B RID: 93787
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x020030E8 RID: 12520
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 2)]
		protected ref struct __InitGameConfigSceneTransition_FunctionParams
		{
			// Token: 0x04016E5C RID: 93788
			[FieldOffset(0)]
			public bool Enable;

			// Token: 0x04016E5D RID: 93789
			[FieldOffset(1)]
			public bool __Result;
		}

		// Token: 0x020030E9 RID: 12521
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __InitGameConfigFPS_FunctionParams
		{
			// Token: 0x04016E5E RID: 93790
			[FieldOffset(0)]
			public int FPS;

			// Token: 0x04016E5F RID: 93791
			[FieldOffset(4)]
			public bool __Result;
		}

		// Token: 0x020030EA RID: 12522
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __InitGameConfig_FunctionParams
		{
			// Token: 0x04016E60 RID: 93792
			[FieldOffset(0)]
			public FKuroGameConfig GameConfig;

			// Token: 0x04016E61 RID: 93793
			[FieldOffset(12)]
			public bool __Result;
		}

		// Token: 0x020030EB RID: 12523
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __GetTickedPerformanceReportAndAdvice_FunctionParams
		{
			// Token: 0x04016E62 RID: 93794
			[FieldOffset(0)]
			public byte ReportDelegate;
		}

		// Token: 0x020030EC RID: 12524
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __GetSupportedBoostFlag_FunctionParams
		{
			// Token: 0x04016E63 RID: 93795
			[FieldOffset(0)]
			public TEnumAsByte<EKuroBoostFlags> __Result;
		}

		// Token: 0x020030ED RID: 12525
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __GetRegisterRHIThreadId_FunctionParams
		{
			// Token: 0x04016E64 RID: 93796
			[FieldOffset(0)]
			public int __Result;
		}

		// Token: 0x020030EE RID: 12526
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __GetRegisterRenderThreadId_FunctionParams
		{
			// Token: 0x04016E65 RID: 93797
			[FieldOffset(0)]
			public int __Result;
		}

		// Token: 0x020030EF RID: 12527
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __GetRegisterGameThreadId_FunctionParams
		{
			// Token: 0x04016E66 RID: 93798
			[FieldOffset(0)]
			public int __Result;
		}

		// Token: 0x020030F0 RID: 12528
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __GetPerformanceAdaptiveStatus_FunctionParams
		{
			// Token: 0x04016E67 RID: 93799
			[FieldOffset(0)]
			public TEnumAsByte<EKuroModuleStatus> __Result;
		}

		// Token: 0x020030F1 RID: 12529
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __GetMaxBoostDurationInSecondForGPU_FunctionParams
		{
			// Token: 0x04016E68 RID: 93800
			[FieldOffset(0)]
			public int __Result;
		}

		// Token: 0x020030F2 RID: 12530
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __GetMaxBoostDurationInSecondForCPU_FunctionParams
		{
			// Token: 0x04016E69 RID: 93801
			[FieldOffset(0)]
			public int __Result;
		}

		// Token: 0x020030F3 RID: 12531
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetInitReturnMessage_FunctionParams
		{
			// Token: 0x04016E6A RID: 93802
			[FieldOffset(0)]
			public FString __Result;
		}

		// Token: 0x020030F4 RID: 12532
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __GetCurrentTemperatureData_FunctionParams
		{
			// Token: 0x04016E6B RID: 93803
			[FieldOffset(0)]
			public byte Delegate;
		}

		// Token: 0x020030F5 RID: 12533
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __GetCurrentAndroidDeviceRequireAdaptiveModule_FunctionParams
		{
			// Token: 0x04016E6C RID: 93804
			[FieldOffset(0)]
			public int __Result;
		}

		// Token: 0x020030F6 RID: 12534
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetCurrentActivePerformanceAdaptiveModuleName_FunctionParams
		{
			// Token: 0x04016E6D RID: 93805
			[FieldOffset(0)]
			public FString __Result;
		}

		// Token: 0x020030F7 RID: 12535
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 3)]
		protected ref struct __GetBoostFlags_FunctionParams
		{
			// Token: 0x04016E6E RID: 93806
			[FieldOffset(0)]
			public bool bCPU;

			// Token: 0x04016E6F RID: 93807
			[FieldOffset(1)]
			public bool bWithMemory;

			// Token: 0x04016E70 RID: 93808
			[FieldOffset(2)]
			public TEnumAsByte<EKuroBoostFlags> __Result;
		}

		// Token: 0x020030F8 RID: 12536
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __BoostGPU_FunctionParams
		{
			// Token: 0x04016E71 RID: 93809
			[FieldOffset(0)]
			public int FrequencyPercentage;

			// Token: 0x04016E72 RID: 93810
			[FieldOffset(4)]
			public int BoostDurationInMilliSecond;

			// Token: 0x04016E73 RID: 93811
			[FieldOffset(8)]
			public bool bBoostMemory;

			// Token: 0x04016E74 RID: 93812
			[FieldOffset(9)]
			public bool __Result;
		}

		// Token: 0x020030F9 RID: 12537
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __BoostCPU_FunctionParams
		{
			// Token: 0x04016E75 RID: 93813
			[FieldOffset(0)]
			public int FrequencyPercentage;

			// Token: 0x04016E76 RID: 93814
			[FieldOffset(4)]
			public int BoostDurationInMilliSecond;

			// Token: 0x04016E77 RID: 93815
			[FieldOffset(8)]
			public bool bBoostMemory;

			// Token: 0x04016E78 RID: 93816
			[FieldOffset(9)]
			public bool __Result;
		}
	}
}
