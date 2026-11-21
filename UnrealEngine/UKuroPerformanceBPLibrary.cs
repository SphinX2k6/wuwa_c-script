using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200049A RID: 1178
	[UnrealObjectPath("/Script/KuroPerformance.KuroPerformanceBPLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UKuroPerformanceBPLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06006DE4 RID: 28132 RVA: 0x000A108A File Offset: 0x0009F28A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroPerformanceBPLibrary._ClassPtr;
		}

		// Token: 0x06006DE5 RID: 28133 RVA: 0x000A1098 File Offset: 0x0009F298
		public UKuroPerformanceBPLibrary() : this(BuiltinUtils.AllocNativeUObject(UKuroPerformanceBPLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06006DE6 RID: 28134 RVA: 0x000A10C0 File Offset: 0x0009F2C0
		[NullableContext(1)]
		public UKuroPerformanceBPLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroPerformanceBPLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06006DE7 RID: 28135 RVA: 0x000A10F4 File Offset: 0x0009F2F4
		[SkipLocalsInit]
		public unsafe static bool UpdateGameConfigSceneTransition(bool Enable)
		{
			UKuroPerformanceBPLibrary.__UpdateGameConfigSceneTransition_FunctionParams* ptr = stackalloc UKuroPerformanceBPLibrary.__UpdateGameConfigSceneTransition_FunctionParams[(UIntPtr)17] + 15L / (long)sizeof(UKuroPerformanceBPLibrary.__UpdateGameConfigSceneTransition_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroPerformanceBPLibrary.__UpdateGameConfigSceneTransition_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Enable = Enable;
			UnrealReflectionUtils.CallUFunction(UKuroPerformanceBPLibrary._ClassDefaultObjectPtr, UKuroPerformanceBPLibrary.__UpdateGameConfigSceneTransition_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x06006DE8 RID: 28136 RVA: 0x000A1140 File Offset: 0x0009F340
		[SkipLocalsInit]
		public unsafe static bool UpdateGameConfigFPS(int FPS)
		{
			UKuroPerformanceBPLibrary.__UpdateGameConfigFPS_FunctionParams* ptr = stackalloc UKuroPerformanceBPLibrary.__UpdateGameConfigFPS_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UKuroPerformanceBPLibrary.__UpdateGameConfigFPS_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroPerformanceBPLibrary.__UpdateGameConfigFPS_NativeFunctionPtr, (void*)ptr, 1);
			ptr->FPS = FPS;
			UnrealReflectionUtils.CallUFunction(UKuroPerformanceBPLibrary._ClassDefaultObjectPtr, UKuroPerformanceBPLibrary.__UpdateGameConfigFPS_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x06006DE9 RID: 28137 RVA: 0x000A118C File Offset: 0x0009F38C
		[SkipLocalsInit]
		public unsafe static bool UnregisterCriticalThreads(int GameTid, int RenderTid, int RHITid)
		{
			UKuroPerformanceBPLibrary.__UnregisterCriticalThreads_FunctionParams* ptr = stackalloc UKuroPerformanceBPLibrary.__UnregisterCriticalThreads_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UKuroPerformanceBPLibrary.__UnregisterCriticalThreads_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroPerformanceBPLibrary.__UnregisterCriticalThreads_NativeFunctionPtr, (void*)ptr, 1);
			ptr->GameTid = GameTid;
			ptr->RenderTid = RenderTid;
			ptr->RHITid = RHITid;
			UnrealReflectionUtils.CallUFunction(UKuroPerformanceBPLibrary._ClassDefaultObjectPtr, UKuroPerformanceBPLibrary.__UnregisterCriticalThreads_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x06006DEA RID: 28138 RVA: 0x000A11E8 File Offset: 0x0009F3E8
		[SkipLocalsInit]
		public unsafe static int TickPerfReport()
		{
			UKuroPerformanceBPLibrary.__TickPerfReport_FunctionParams* ptr = stackalloc UKuroPerformanceBPLibrary.__TickPerfReport_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UKuroPerformanceBPLibrary.__TickPerfReport_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroPerformanceBPLibrary.__TickPerfReport_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(UKuroPerformanceBPLibrary._ClassDefaultObjectPtr, UKuroPerformanceBPLibrary.__TickPerfReport_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x06006DEB RID: 28139 RVA: 0x000A122C File Offset: 0x0009F42C
		[SkipLocalsInit]
		public unsafe static int TickPerformanceReport()
		{
			UKuroPerformanceBPLibrary.__TickPerformanceReport_FunctionParams* ptr = stackalloc UKuroPerformanceBPLibrary.__TickPerformanceReport_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UKuroPerformanceBPLibrary.__TickPerformanceReport_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroPerformanceBPLibrary.__TickPerformanceReport_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(UKuroPerformanceBPLibrary._ClassDefaultObjectPtr, UKuroPerformanceBPLibrary.__TickPerformanceReport_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x06006DEC RID: 28140 RVA: 0x000A1270 File Offset: 0x0009F470
		[SkipLocalsInit]
		public unsafe static int Tick()
		{
			UKuroPerformanceBPLibrary.__Tick_FunctionParams* ptr = stackalloc UKuroPerformanceBPLibrary.__Tick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UKuroPerformanceBPLibrary.__Tick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroPerformanceBPLibrary.__Tick_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(UKuroPerformanceBPLibrary._ClassDefaultObjectPtr, UKuroPerformanceBPLibrary.__Tick_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x06006DED RID: 28141 RVA: 0x000A12B4 File Offset: 0x0009F4B4
		[SkipLocalsInit]
		public unsafe static bool SyncRenderingFrameID(int FrameId)
		{
			UKuroPerformanceBPLibrary.__SyncRenderingFrameID_FunctionParams* ptr = stackalloc UKuroPerformanceBPLibrary.__SyncRenderingFrameID_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UKuroPerformanceBPLibrary.__SyncRenderingFrameID_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroPerformanceBPLibrary.__SyncRenderingFrameID_NativeFunctionPtr, (void*)ptr, 1);
			ptr->FrameId = FrameId;
			UnrealReflectionUtils.CallUFunction(UKuroPerformanceBPLibrary._ClassDefaultObjectPtr, UKuroPerformanceBPLibrary.__SyncRenderingFrameID_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x06006DEE RID: 28142 RVA: 0x000A1300 File Offset: 0x0009F500
		[SkipLocalsInit]
		public unsafe static bool StopService(int Service)
		{
			UKuroPerformanceBPLibrary.__StopService_FunctionParams* ptr = stackalloc UKuroPerformanceBPLibrary.__StopService_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UKuroPerformanceBPLibrary.__StopService_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroPerformanceBPLibrary.__StopService_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Service = Service;
			UnrealReflectionUtils.CallUFunction(UKuroPerformanceBPLibrary._ClassDefaultObjectPtr, UKuroPerformanceBPLibrary.__StopService_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x06006DEF RID: 28143 RVA: 0x000A134C File Offset: 0x0009F54C
		[SkipLocalsInit]
		public unsafe static bool StopPerformanceAdaptiveService(int EServiceFlags)
		{
			UKuroPerformanceBPLibrary.__StopPerformanceAdaptiveService_FunctionParams* ptr = stackalloc UKuroPerformanceBPLibrary.__StopPerformanceAdaptiveService_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UKuroPerformanceBPLibrary.__StopPerformanceAdaptiveService_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroPerformanceBPLibrary.__StopPerformanceAdaptiveService_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EServiceFlags = EServiceFlags;
			UnrealReflectionUtils.CallUFunction(UKuroPerformanceBPLibrary._ClassDefaultObjectPtr, UKuroPerformanceBPLibrary.__StopPerformanceAdaptiveService_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x06006DF0 RID: 28144 RVA: 0x000A1398 File Offset: 0x0009F598
		[SkipLocalsInit]
		public unsafe static bool StartService(int Service)
		{
			UKuroPerformanceBPLibrary.__StartService_FunctionParams* ptr = stackalloc UKuroPerformanceBPLibrary.__StartService_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UKuroPerformanceBPLibrary.__StartService_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroPerformanceBPLibrary.__StartService_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Service = Service;
			UnrealReflectionUtils.CallUFunction(UKuroPerformanceBPLibrary._ClassDefaultObjectPtr, UKuroPerformanceBPLibrary.__StartService_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x06006DF1 RID: 28145 RVA: 0x000A13E4 File Offset: 0x0009F5E4
		[SkipLocalsInit]
		public unsafe static bool StartPerformanceAdaptiveService(int EServiceFlags)
		{
			UKuroPerformanceBPLibrary.__StartPerformanceAdaptiveService_FunctionParams* ptr = stackalloc UKuroPerformanceBPLibrary.__StartPerformanceAdaptiveService_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UKuroPerformanceBPLibrary.__StartPerformanceAdaptiveService_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroPerformanceBPLibrary.__StartPerformanceAdaptiveService_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EServiceFlags = EServiceFlags;
			UnrealReflectionUtils.CallUFunction(UKuroPerformanceBPLibrary._ClassDefaultObjectPtr, UKuroPerformanceBPLibrary.__StartPerformanceAdaptiveService_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x06006DF2 RID: 28146 RVA: 0x000A1430 File Offset: 0x0009F630
		[SkipLocalsInit]
		public unsafe static bool SetTargetFPS(int FPS, int ThreadId = 0)
		{
			UKuroPerformanceBPLibrary.__SetTargetFPS_FunctionParams* ptr = stackalloc UKuroPerformanceBPLibrary.__SetTargetFPS_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(UKuroPerformanceBPLibrary.__SetTargetFPS_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroPerformanceBPLibrary.__SetTargetFPS_NativeFunctionPtr, (void*)ptr, 1);
			ptr->FPS = FPS;
			ptr->ThreadId = ThreadId;
			UnrealReflectionUtils.CallUFunction(UKuroPerformanceBPLibrary._ClassDefaultObjectPtr, UKuroPerformanceBPLibrary.__SetTargetFPS_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x06006DF3 RID: 28147 RVA: 0x000A1484 File Offset: 0x0009F684
		[SkipLocalsInit]
		public unsafe static void SetPerformanceAdaptiveStatus(bool bEnable)
		{
			UKuroPerformanceBPLibrary.__SetPerformanceAdaptiveStatus_FunctionParams* ptr = stackalloc UKuroPerformanceBPLibrary.__SetPerformanceAdaptiveStatus_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UKuroPerformanceBPLibrary.__SetPerformanceAdaptiveStatus_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroPerformanceBPLibrary.__SetPerformanceAdaptiveStatus_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bEnable = bEnable;
			UnrealReflectionUtils.CallUFunction(UKuroPerformanceBPLibrary._ClassDefaultObjectPtr, UKuroPerformanceBPLibrary.__SetPerformanceAdaptiveStatus_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06006DF4 RID: 28148 RVA: 0x000A14CC File Offset: 0x0009F6CC
		[SkipLocalsInit]
		public unsafe static bool SetForeground(bool bForeGround)
		{
			UKuroPerformanceBPLibrary.__SetForeground_FunctionParams* ptr = stackalloc UKuroPerformanceBPLibrary.__SetForeground_FunctionParams[(UIntPtr)17] + 15L / (long)sizeof(UKuroPerformanceBPLibrary.__SetForeground_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroPerformanceBPLibrary.__SetForeground_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bForeGround = bForeGround;
			UnrealReflectionUtils.CallUFunction(UKuroPerformanceBPLibrary._ClassDefaultObjectPtr, UKuroPerformanceBPLibrary.__SetForeground_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x06006DF5 RID: 28149 RVA: 0x000A1518 File Offset: 0x0009F718
		[SkipLocalsInit]
		public unsafe static bool RegisterCriticalThreads(int GameTid, int RenderTid, int RHITid)
		{
			UKuroPerformanceBPLibrary.__RegisterCriticalThreads_FunctionParams* ptr = stackalloc UKuroPerformanceBPLibrary.__RegisterCriticalThreads_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UKuroPerformanceBPLibrary.__RegisterCriticalThreads_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroPerformanceBPLibrary.__RegisterCriticalThreads_NativeFunctionPtr, (void*)ptr, 1);
			ptr->GameTid = GameTid;
			ptr->RenderTid = RenderTid;
			ptr->RHITid = RHITid;
			UnrealReflectionUtils.CallUFunction(UKuroPerformanceBPLibrary._ClassDefaultObjectPtr, UKuroPerformanceBPLibrary.__RegisterCriticalThreads_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x06006DF6 RID: 28150 RVA: 0x000A1574 File Offset: 0x0009F774
		[SkipLocalsInit]
		public unsafe static bool PredictWorkload(int CPULoadScale, int GPULoadScale)
		{
			UKuroPerformanceBPLibrary.__PredictWorkload_FunctionParams* ptr = stackalloc UKuroPerformanceBPLibrary.__PredictWorkload_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(UKuroPerformanceBPLibrary.__PredictWorkload_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroPerformanceBPLibrary.__PredictWorkload_NativeFunctionPtr, (void*)ptr, 1);
			ptr->CPULoadScale = CPULoadScale;
			ptr->GPULoadScale = GPULoadScale;
			UnrealReflectionUtils.CallUFunction(UKuroPerformanceBPLibrary._ClassDefaultObjectPtr, UKuroPerformanceBPLibrary.__PredictWorkload_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x06006DF7 RID: 28151 RVA: 0x000A15C8 File Offset: 0x0009F7C8
		[SkipLocalsInit]
		public unsafe static bool IsPredictGPUWorkloadSupported()
		{
			UKuroPerformanceBPLibrary.__IsPredictGPUWorkloadSupported_FunctionParams* ptr = stackalloc UKuroPerformanceBPLibrary.__IsPredictGPUWorkloadSupported_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UKuroPerformanceBPLibrary.__IsPredictGPUWorkloadSupported_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroPerformanceBPLibrary.__IsPredictGPUWorkloadSupported_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(UKuroPerformanceBPLibrary._ClassDefaultObjectPtr, UKuroPerformanceBPLibrary.__IsPredictGPUWorkloadSupported_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x06006DF8 RID: 28152 RVA: 0x000A160C File Offset: 0x0009F80C
		[SkipLocalsInit]
		public unsafe static bool IsPredictCPUWorkloadSupported()
		{
			UKuroPerformanceBPLibrary.__IsPredictCPUWorkloadSupported_FunctionParams* ptr = stackalloc UKuroPerformanceBPLibrary.__IsPredictCPUWorkloadSupported_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UKuroPerformanceBPLibrary.__IsPredictCPUWorkloadSupported_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroPerformanceBPLibrary.__IsPredictCPUWorkloadSupported_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(UKuroPerformanceBPLibrary._ClassDefaultObjectPtr, UKuroPerformanceBPLibrary.__IsPredictCPUWorkloadSupported_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x06006DF9 RID: 28153 RVA: 0x000A1650 File Offset: 0x0009F850
		[SkipLocalsInit]
		public unsafe static bool IsPerformanceAdaptiveRunning()
		{
			UKuroPerformanceBPLibrary.__IsPerformanceAdaptiveRunning_FunctionParams* ptr = stackalloc UKuroPerformanceBPLibrary.__IsPerformanceAdaptiveRunning_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UKuroPerformanceBPLibrary.__IsPerformanceAdaptiveRunning_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroPerformanceBPLibrary.__IsPerformanceAdaptiveRunning_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(UKuroPerformanceBPLibrary._ClassDefaultObjectPtr, UKuroPerformanceBPLibrary.__IsPerformanceAdaptiveRunning_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x06006DFA RID: 28154 RVA: 0x000A1694 File Offset: 0x0009F894
		[SkipLocalsInit]
		public unsafe static bool IsPerformanceAdaptiveInitialize()
		{
			UKuroPerformanceBPLibrary.__IsPerformanceAdaptiveInitialize_FunctionParams* ptr = stackalloc UKuroPerformanceBPLibrary.__IsPerformanceAdaptiveInitialize_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UKuroPerformanceBPLibrary.__IsPerformanceAdaptiveInitialize_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroPerformanceBPLibrary.__IsPerformanceAdaptiveInitialize_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(UKuroPerformanceBPLibrary._ClassDefaultObjectPtr, UKuroPerformanceBPLibrary.__IsPerformanceAdaptiveInitialize_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x06006DFB RID: 28155 RVA: 0x000A16D8 File Offset: 0x0009F8D8
		[SkipLocalsInit]
		public unsafe static bool InitGameConfigSceneTransition(bool Enable)
		{
			UKuroPerformanceBPLibrary.__InitGameConfigSceneTransition_FunctionParams* ptr = stackalloc UKuroPerformanceBPLibrary.__InitGameConfigSceneTransition_FunctionParams[(UIntPtr)17] + 15L / (long)sizeof(UKuroPerformanceBPLibrary.__InitGameConfigSceneTransition_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroPerformanceBPLibrary.__InitGameConfigSceneTransition_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Enable = Enable;
			UnrealReflectionUtils.CallUFunction(UKuroPerformanceBPLibrary._ClassDefaultObjectPtr, UKuroPerformanceBPLibrary.__InitGameConfigSceneTransition_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x06006DFC RID: 28156 RVA: 0x000A1724 File Offset: 0x0009F924
		[SkipLocalsInit]
		public unsafe static bool InitGameConfigFPS(int FPS)
		{
			UKuroPerformanceBPLibrary.__InitGameConfigFPS_FunctionParams* ptr = stackalloc UKuroPerformanceBPLibrary.__InitGameConfigFPS_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UKuroPerformanceBPLibrary.__InitGameConfigFPS_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroPerformanceBPLibrary.__InitGameConfigFPS_NativeFunctionPtr, (void*)ptr, 1);
			ptr->FPS = FPS;
			UnrealReflectionUtils.CallUFunction(UKuroPerformanceBPLibrary._ClassDefaultObjectPtr, UKuroPerformanceBPLibrary.__InitGameConfigFPS_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x06006DFD RID: 28157 RVA: 0x000A1770 File Offset: 0x0009F970
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe static void GetTickedPerformanceReportAndAdvice(in FGetTickedPerformanceReportAndAdviceDelegate ReportDelegate)
		{
			UKuroPerformanceBPLibrary.__GetTickedPerformanceReportAndAdvice_FunctionParams* ptr = stackalloc UKuroPerformanceBPLibrary.__GetTickedPerformanceReportAndAdvice_FunctionParams[(UIntPtr)55] + 15L / (long)sizeof(UKuroPerformanceBPLibrary.__GetTickedPerformanceReportAndAdvice_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroPerformanceBPLibrary.__GetTickedPerformanceReportAndAdvice_NativeFunctionPtr, (void*)ptr, 1);
			IntPtr dest = &ptr->ReportDelegate;
			FGetTickedPerformanceReportAndAdviceDelegate fgetTickedPerformanceReportAndAdviceDelegate = ReportDelegate;
			FScriptDelegate.NativeCopy(dest, (fgetTickedPerformanceReportAndAdviceDelegate != null) ? fgetTickedPerformanceReportAndAdviceDelegate.NativePtr : ((IntPtr)0));
			UnrealReflectionUtils.CallUFunction(UKuroPerformanceBPLibrary._ClassDefaultObjectPtr, UKuroPerformanceBPLibrary.__GetTickedPerformanceReportAndAdvice_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UKuroPerformanceBPLibrary.__GetTickedPerformanceReportAndAdvice_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06006DFE RID: 28158 RVA: 0x000A17DC File Offset: 0x0009F9DC
		[SkipLocalsInit]
		public unsafe static int GetRegisterRHIThreadId()
		{
			UKuroPerformanceBPLibrary.__GetRegisterRHIThreadId_FunctionParams* ptr = stackalloc UKuroPerformanceBPLibrary.__GetRegisterRHIThreadId_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UKuroPerformanceBPLibrary.__GetRegisterRHIThreadId_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroPerformanceBPLibrary.__GetRegisterRHIThreadId_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(UKuroPerformanceBPLibrary._ClassDefaultObjectPtr, UKuroPerformanceBPLibrary.__GetRegisterRHIThreadId_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x06006DFF RID: 28159 RVA: 0x000A1820 File Offset: 0x0009FA20
		[SkipLocalsInit]
		public unsafe static int GetRegisterRenderThreadId()
		{
			UKuroPerformanceBPLibrary.__GetRegisterRenderThreadId_FunctionParams* ptr = stackalloc UKuroPerformanceBPLibrary.__GetRegisterRenderThreadId_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UKuroPerformanceBPLibrary.__GetRegisterRenderThreadId_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroPerformanceBPLibrary.__GetRegisterRenderThreadId_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(UKuroPerformanceBPLibrary._ClassDefaultObjectPtr, UKuroPerformanceBPLibrary.__GetRegisterRenderThreadId_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x06006E00 RID: 28160 RVA: 0x000A1864 File Offset: 0x0009FA64
		[SkipLocalsInit]
		public unsafe static int GetRegisterGameThreadId()
		{
			UKuroPerformanceBPLibrary.__GetRegisterGameThreadId_FunctionParams* ptr = stackalloc UKuroPerformanceBPLibrary.__GetRegisterGameThreadId_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UKuroPerformanceBPLibrary.__GetRegisterGameThreadId_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroPerformanceBPLibrary.__GetRegisterGameThreadId_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(UKuroPerformanceBPLibrary._ClassDefaultObjectPtr, UKuroPerformanceBPLibrary.__GetRegisterGameThreadId_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x06006E01 RID: 28161 RVA: 0x000A18A8 File Offset: 0x0009FAA8
		[SkipLocalsInit]
		public unsafe static int GetMaxBoostDurationInSecondForGPU()
		{
			UKuroPerformanceBPLibrary.__GetMaxBoostDurationInSecondForGPU_FunctionParams* ptr = stackalloc UKuroPerformanceBPLibrary.__GetMaxBoostDurationInSecondForGPU_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UKuroPerformanceBPLibrary.__GetMaxBoostDurationInSecondForGPU_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroPerformanceBPLibrary.__GetMaxBoostDurationInSecondForGPU_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(UKuroPerformanceBPLibrary._ClassDefaultObjectPtr, UKuroPerformanceBPLibrary.__GetMaxBoostDurationInSecondForGPU_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x06006E02 RID: 28162 RVA: 0x000A18EC File Offset: 0x0009FAEC
		[SkipLocalsInit]
		public unsafe static int GetMaxBoostDurationInSecondForCPU()
		{
			UKuroPerformanceBPLibrary.__GetMaxBoostDurationInSecondForCPU_FunctionParams* ptr = stackalloc UKuroPerformanceBPLibrary.__GetMaxBoostDurationInSecondForCPU_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UKuroPerformanceBPLibrary.__GetMaxBoostDurationInSecondForCPU_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroPerformanceBPLibrary.__GetMaxBoostDurationInSecondForCPU_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(UKuroPerformanceBPLibrary._ClassDefaultObjectPtr, UKuroPerformanceBPLibrary.__GetMaxBoostDurationInSecondForCPU_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x06006E03 RID: 28163 RVA: 0x000A1930 File Offset: 0x0009FB30
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe static string GetInitReturnMessage()
		{
			UKuroPerformanceBPLibrary.__GetInitReturnMessage_FunctionParams* ptr = stackalloc UKuroPerformanceBPLibrary.__GetInitReturnMessage_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UKuroPerformanceBPLibrary.__GetInitReturnMessage_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroPerformanceBPLibrary.__GetInitReturnMessage_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(UKuroPerformanceBPLibrary._ClassDefaultObjectPtr, UKuroPerformanceBPLibrary.__GetInitReturnMessage_NativeFunctionPtr, (void*)ptr);
			string result = FString.ToString((void*)(&ptr->__Result));
			UnrealReflectionUtils.DestroyStruct(UKuroPerformanceBPLibrary.__GetInitReturnMessage_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x06006E04 RID: 28164 RVA: 0x000A198C File Offset: 0x0009FB8C
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe static void GetCurrentTemperatureData(in FGetCurrentTemperatureDataDelegate Delegate)
		{
			UKuroPerformanceBPLibrary.__GetCurrentTemperatureData_FunctionParams* ptr = stackalloc UKuroPerformanceBPLibrary.__GetCurrentTemperatureData_FunctionParams[(UIntPtr)55] + 15L / (long)sizeof(UKuroPerformanceBPLibrary.__GetCurrentTemperatureData_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroPerformanceBPLibrary.__GetCurrentTemperatureData_NativeFunctionPtr, (void*)ptr, 1);
			IntPtr dest = &ptr->Delegate;
			FGetCurrentTemperatureDataDelegate fgetCurrentTemperatureDataDelegate = Delegate;
			FScriptDelegate.NativeCopy(dest, (fgetCurrentTemperatureDataDelegate != null) ? fgetCurrentTemperatureDataDelegate.NativePtr : ((IntPtr)0));
			UnrealReflectionUtils.CallUFunction(UKuroPerformanceBPLibrary._ClassDefaultObjectPtr, UKuroPerformanceBPLibrary.__GetCurrentTemperatureData_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UKuroPerformanceBPLibrary.__GetCurrentTemperatureData_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06006E05 RID: 28165 RVA: 0x000A19F8 File Offset: 0x0009FBF8
		[SkipLocalsInit]
		public unsafe static int GetCurrentAndroidDeviceRequireAdaptiveModule()
		{
			UKuroPerformanceBPLibrary.__GetCurrentAndroidDeviceRequireAdaptiveModule_FunctionParams* ptr = stackalloc UKuroPerformanceBPLibrary.__GetCurrentAndroidDeviceRequireAdaptiveModule_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UKuroPerformanceBPLibrary.__GetCurrentAndroidDeviceRequireAdaptiveModule_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroPerformanceBPLibrary.__GetCurrentAndroidDeviceRequireAdaptiveModule_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(UKuroPerformanceBPLibrary._ClassDefaultObjectPtr, UKuroPerformanceBPLibrary.__GetCurrentAndroidDeviceRequireAdaptiveModule_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x06006E06 RID: 28166 RVA: 0x000A1A3C File Offset: 0x0009FC3C
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe static string GetCurrentActivePerformanceAdaptiveModuleName()
		{
			UKuroPerformanceBPLibrary.__GetCurrentActivePerformanceAdaptiveModuleName_FunctionParams* ptr = stackalloc UKuroPerformanceBPLibrary.__GetCurrentActivePerformanceAdaptiveModuleName_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UKuroPerformanceBPLibrary.__GetCurrentActivePerformanceAdaptiveModuleName_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroPerformanceBPLibrary.__GetCurrentActivePerformanceAdaptiveModuleName_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(UKuroPerformanceBPLibrary._ClassDefaultObjectPtr, UKuroPerformanceBPLibrary.__GetCurrentActivePerformanceAdaptiveModuleName_NativeFunctionPtr, (void*)ptr);
			string result = FString.ToString((void*)(&ptr->__Result));
			UnrealReflectionUtils.DestroyStruct(UKuroPerformanceBPLibrary.__GetCurrentActivePerformanceAdaptiveModuleName_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x06006E07 RID: 28167 RVA: 0x000A1A98 File Offset: 0x0009FC98
		[SkipLocalsInit]
		public unsafe static bool BoostGPU(int FrequencyPercentage, int BoostDurationInMilliSecond, bool bBoostMemory = false)
		{
			UKuroPerformanceBPLibrary.__BoostGPU_FunctionParams* ptr = stackalloc UKuroPerformanceBPLibrary.__BoostGPU_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(UKuroPerformanceBPLibrary.__BoostGPU_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroPerformanceBPLibrary.__BoostGPU_NativeFunctionPtr, (void*)ptr, 1);
			ptr->FrequencyPercentage = FrequencyPercentage;
			ptr->BoostDurationInMilliSecond = BoostDurationInMilliSecond;
			ptr->bBoostMemory = bBoostMemory;
			UnrealReflectionUtils.CallUFunction(UKuroPerformanceBPLibrary._ClassDefaultObjectPtr, UKuroPerformanceBPLibrary.__BoostGPU_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x06006E08 RID: 28168 RVA: 0x000A1AF4 File Offset: 0x0009FCF4
		[SkipLocalsInit]
		public unsafe static bool BoostCPU(int FrequencyPercentage, int BoostDurationInMilliSecond, bool bBoostMemory = false)
		{
			UKuroPerformanceBPLibrary.__BoostCPU_FunctionParams* ptr = stackalloc UKuroPerformanceBPLibrary.__BoostCPU_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(UKuroPerformanceBPLibrary.__BoostCPU_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroPerformanceBPLibrary.__BoostCPU_NativeFunctionPtr, (void*)ptr, 1);
			ptr->FrequencyPercentage = FrequencyPercentage;
			ptr->BoostDurationInMilliSecond = BoostDurationInMilliSecond;
			ptr->bBoostMemory = bBoostMemory;
			UnrealReflectionUtils.CallUFunction(UKuroPerformanceBPLibrary._ClassDefaultObjectPtr, UKuroPerformanceBPLibrary.__BoostCPU_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x06006E09 RID: 28169 RVA: 0x000A1B4D File Offset: 0x0009FD4D
		static UKuroPerformanceBPLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroPerformance.KuroPerformanceBPLibrary");
		}

		// Token: 0x06006E0A RID: 28170 RVA: 0x000A1B5B File Offset: 0x0009FD5B
		protected UKuroPerformanceBPLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04002EEE RID: 12014
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroPerformance.KuroPerformanceBPLibrary";

		// Token: 0x04002EEF RID: 12015
		private static IntPtr _ClassPtr;

		// Token: 0x04002EF0 RID: 12016
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04002EF1 RID: 12017
		private static IntPtr __UpdateGameConfigSceneTransition_NativeFunctionPtr;

		// Token: 0x04002EF2 RID: 12018
		private static IntPtr __UpdateGameConfigFPS_NativeFunctionPtr;

		// Token: 0x04002EF3 RID: 12019
		private static IntPtr __UnregisterCriticalThreads_NativeFunctionPtr;

		// Token: 0x04002EF4 RID: 12020
		private static IntPtr __TickPerfReport_NativeFunctionPtr;

		// Token: 0x04002EF5 RID: 12021
		private static IntPtr __TickPerformanceReport_NativeFunctionPtr;

		// Token: 0x04002EF6 RID: 12022
		private static IntPtr __Tick_NativeFunctionPtr;

		// Token: 0x04002EF7 RID: 12023
		private static IntPtr __SyncRenderingFrameID_NativeFunctionPtr;

		// Token: 0x04002EF8 RID: 12024
		private static IntPtr __StopService_NativeFunctionPtr;

		// Token: 0x04002EF9 RID: 12025
		private static IntPtr __StopPerformanceAdaptiveService_NativeFunctionPtr;

		// Token: 0x04002EFA RID: 12026
		private static IntPtr __StartService_NativeFunctionPtr;

		// Token: 0x04002EFB RID: 12027
		private static IntPtr __StartPerformanceAdaptiveService_NativeFunctionPtr;

		// Token: 0x04002EFC RID: 12028
		private static IntPtr __SetTargetFPS_NativeFunctionPtr;

		// Token: 0x04002EFD RID: 12029
		private static IntPtr __SetPerformanceAdaptiveStatus_NativeFunctionPtr;

		// Token: 0x04002EFE RID: 12030
		private static IntPtr __SetForeground_NativeFunctionPtr;

		// Token: 0x04002EFF RID: 12031
		private static IntPtr __RegisterCriticalThreads_NativeFunctionPtr;

		// Token: 0x04002F00 RID: 12032
		private static IntPtr __PredictWorkload_NativeFunctionPtr;

		// Token: 0x04002F01 RID: 12033
		private static IntPtr __IsPredictGPUWorkloadSupported_NativeFunctionPtr;

		// Token: 0x04002F02 RID: 12034
		private static IntPtr __IsPredictCPUWorkloadSupported_NativeFunctionPtr;

		// Token: 0x04002F03 RID: 12035
		private static IntPtr __IsPerformanceAdaptiveRunning_NativeFunctionPtr;

		// Token: 0x04002F04 RID: 12036
		private static IntPtr __IsPerformanceAdaptiveInitialize_NativeFunctionPtr;

		// Token: 0x04002F05 RID: 12037
		private static IntPtr __InitGameConfigSceneTransition_NativeFunctionPtr;

		// Token: 0x04002F06 RID: 12038
		private static IntPtr __InitGameConfigFPS_NativeFunctionPtr;

		// Token: 0x04002F07 RID: 12039
		private static IntPtr __GetTickedPerformanceReportAndAdvice_NativeFunctionPtr;

		// Token: 0x04002F08 RID: 12040
		private static IntPtr __GetRegisterRHIThreadId_NativeFunctionPtr;

		// Token: 0x04002F09 RID: 12041
		private static IntPtr __GetRegisterRenderThreadId_NativeFunctionPtr;

		// Token: 0x04002F0A RID: 12042
		private static IntPtr __GetRegisterGameThreadId_NativeFunctionPtr;

		// Token: 0x04002F0B RID: 12043
		private static IntPtr __GetMaxBoostDurationInSecondForGPU_NativeFunctionPtr;

		// Token: 0x04002F0C RID: 12044
		private static IntPtr __GetMaxBoostDurationInSecondForCPU_NativeFunctionPtr;

		// Token: 0x04002F0D RID: 12045
		private static IntPtr __GetInitReturnMessage_NativeFunctionPtr;

		// Token: 0x04002F0E RID: 12046
		private static IntPtr __GetCurrentTemperatureData_NativeFunctionPtr;

		// Token: 0x04002F0F RID: 12047
		private static IntPtr __GetCurrentAndroidDeviceRequireAdaptiveModule_NativeFunctionPtr;

		// Token: 0x04002F10 RID: 12048
		private static IntPtr __GetCurrentActivePerformanceAdaptiveModuleName_NativeFunctionPtr;

		// Token: 0x04002F11 RID: 12049
		private static IntPtr __BoostGPU_NativeFunctionPtr;

		// Token: 0x04002F12 RID: 12050
		private static IntPtr __BoostCPU_NativeFunctionPtr;

		// Token: 0x02000BAE RID: 2990
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 2)]
		protected ref struct __UpdateGameConfigSceneTransition_FunctionParams
		{
			// Token: 0x04005D38 RID: 23864
			[FieldOffset(0)]
			public bool Enable;

			// Token: 0x04005D39 RID: 23865
			[FieldOffset(1)]
			public bool __Result;
		}

		// Token: 0x02000BAF RID: 2991
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __UpdateGameConfigFPS_FunctionParams
		{
			// Token: 0x04005D3A RID: 23866
			[FieldOffset(0)]
			public int FPS;

			// Token: 0x04005D3B RID: 23867
			[FieldOffset(4)]
			public bool __Result;
		}

		// Token: 0x02000BB0 RID: 2992
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __UnregisterCriticalThreads_FunctionParams
		{
			// Token: 0x04005D3C RID: 23868
			[FieldOffset(0)]
			public int GameTid;

			// Token: 0x04005D3D RID: 23869
			[FieldOffset(4)]
			public int RenderTid;

			// Token: 0x04005D3E RID: 23870
			[FieldOffset(8)]
			public int RHITid;

			// Token: 0x04005D3F RID: 23871
			[FieldOffset(12)]
			public bool __Result;
		}

		// Token: 0x02000BB1 RID: 2993
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __TickPerfReport_FunctionParams
		{
			// Token: 0x04005D40 RID: 23872
			[FieldOffset(0)]
			public int __Result;
		}

		// Token: 0x02000BB2 RID: 2994
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __TickPerformanceReport_FunctionParams
		{
			// Token: 0x04005D41 RID: 23873
			[FieldOffset(0)]
			public int __Result;
		}

		// Token: 0x02000BB3 RID: 2995
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __Tick_FunctionParams
		{
			// Token: 0x04005D42 RID: 23874
			[FieldOffset(0)]
			public int __Result;
		}

		// Token: 0x02000BB4 RID: 2996
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __SyncRenderingFrameID_FunctionParams
		{
			// Token: 0x04005D43 RID: 23875
			[FieldOffset(0)]
			public int FrameId;

			// Token: 0x04005D44 RID: 23876
			[FieldOffset(4)]
			public bool __Result;
		}

		// Token: 0x02000BB5 RID: 2997
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __StopService_FunctionParams
		{
			// Token: 0x04005D45 RID: 23877
			[FieldOffset(0)]
			public int Service;

			// Token: 0x04005D46 RID: 23878
			[FieldOffset(4)]
			public bool __Result;
		}

		// Token: 0x02000BB6 RID: 2998
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __StopPerformanceAdaptiveService_FunctionParams
		{
			// Token: 0x04005D47 RID: 23879
			[FieldOffset(0)]
			public int EServiceFlags;

			// Token: 0x04005D48 RID: 23880
			[FieldOffset(4)]
			public bool __Result;
		}

		// Token: 0x02000BB7 RID: 2999
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __StartService_FunctionParams
		{
			// Token: 0x04005D49 RID: 23881
			[FieldOffset(0)]
			public int Service;

			// Token: 0x04005D4A RID: 23882
			[FieldOffset(4)]
			public bool __Result;
		}

		// Token: 0x02000BB8 RID: 3000
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __StartPerformanceAdaptiveService_FunctionParams
		{
			// Token: 0x04005D4B RID: 23883
			[FieldOffset(0)]
			public int EServiceFlags;

			// Token: 0x04005D4C RID: 23884
			[FieldOffset(4)]
			public bool __Result;
		}

		// Token: 0x02000BB9 RID: 3001
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __SetTargetFPS_FunctionParams
		{
			// Token: 0x04005D4D RID: 23885
			[FieldOffset(0)]
			public int FPS;

			// Token: 0x04005D4E RID: 23886
			[FieldOffset(4)]
			public int ThreadId;

			// Token: 0x04005D4F RID: 23887
			[FieldOffset(8)]
			public bool __Result;
		}

		// Token: 0x02000BBA RID: 3002
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __SetPerformanceAdaptiveStatus_FunctionParams
		{
			// Token: 0x04005D50 RID: 23888
			[FieldOffset(0)]
			public bool bEnable;
		}

		// Token: 0x02000BBB RID: 3003
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 2)]
		protected ref struct __SetForeground_FunctionParams
		{
			// Token: 0x04005D51 RID: 23889
			[FieldOffset(0)]
			public bool bForeGround;

			// Token: 0x04005D52 RID: 23890
			[FieldOffset(1)]
			public bool __Result;
		}

		// Token: 0x02000BBC RID: 3004
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __RegisterCriticalThreads_FunctionParams
		{
			// Token: 0x04005D53 RID: 23891
			[FieldOffset(0)]
			public int GameTid;

			// Token: 0x04005D54 RID: 23892
			[FieldOffset(4)]
			public int RenderTid;

			// Token: 0x04005D55 RID: 23893
			[FieldOffset(8)]
			public int RHITid;

			// Token: 0x04005D56 RID: 23894
			[FieldOffset(12)]
			public bool __Result;
		}

		// Token: 0x02000BBD RID: 3005
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __PredictWorkload_FunctionParams
		{
			// Token: 0x04005D57 RID: 23895
			[FieldOffset(0)]
			public int CPULoadScale;

			// Token: 0x04005D58 RID: 23896
			[FieldOffset(4)]
			public int GPULoadScale;

			// Token: 0x04005D59 RID: 23897
			[FieldOffset(8)]
			public bool __Result;
		}

		// Token: 0x02000BBE RID: 3006
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __IsPredictGPUWorkloadSupported_FunctionParams
		{
			// Token: 0x04005D5A RID: 23898
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x02000BBF RID: 3007
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __IsPredictCPUWorkloadSupported_FunctionParams
		{
			// Token: 0x04005D5B RID: 23899
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x02000BC0 RID: 3008
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __IsPerformanceAdaptiveRunning_FunctionParams
		{
			// Token: 0x04005D5C RID: 23900
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x02000BC1 RID: 3009
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __IsPerformanceAdaptiveInitialize_FunctionParams
		{
			// Token: 0x04005D5D RID: 23901
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x02000BC2 RID: 3010
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 2)]
		protected ref struct __InitGameConfigSceneTransition_FunctionParams
		{
			// Token: 0x04005D5E RID: 23902
			[FieldOffset(0)]
			public bool Enable;

			// Token: 0x04005D5F RID: 23903
			[FieldOffset(1)]
			public bool __Result;
		}

		// Token: 0x02000BC3 RID: 3011
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __InitGameConfigFPS_FunctionParams
		{
			// Token: 0x04005D60 RID: 23904
			[FieldOffset(0)]
			public int FPS;

			// Token: 0x04005D61 RID: 23905
			[FieldOffset(4)]
			public bool __Result;
		}

		// Token: 0x02000BC4 RID: 3012
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __GetTickedPerformanceReportAndAdvice_FunctionParams
		{
			// Token: 0x04005D62 RID: 23906
			[FieldOffset(0)]
			public byte ReportDelegate;
		}

		// Token: 0x02000BC5 RID: 3013
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __GetRegisterRHIThreadId_FunctionParams
		{
			// Token: 0x04005D63 RID: 23907
			[FieldOffset(0)]
			public int __Result;
		}

		// Token: 0x02000BC6 RID: 3014
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __GetRegisterRenderThreadId_FunctionParams
		{
			// Token: 0x04005D64 RID: 23908
			[FieldOffset(0)]
			public int __Result;
		}

		// Token: 0x02000BC7 RID: 3015
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __GetRegisterGameThreadId_FunctionParams
		{
			// Token: 0x04005D65 RID: 23909
			[FieldOffset(0)]
			public int __Result;
		}

		// Token: 0x02000BC8 RID: 3016
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __GetMaxBoostDurationInSecondForGPU_FunctionParams
		{
			// Token: 0x04005D66 RID: 23910
			[FieldOffset(0)]
			public int __Result;
		}

		// Token: 0x02000BC9 RID: 3017
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __GetMaxBoostDurationInSecondForCPU_FunctionParams
		{
			// Token: 0x04005D67 RID: 23911
			[FieldOffset(0)]
			public int __Result;
		}

		// Token: 0x02000BCA RID: 3018
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetInitReturnMessage_FunctionParams
		{
			// Token: 0x04005D68 RID: 23912
			[FieldOffset(0)]
			public FString __Result;
		}

		// Token: 0x02000BCB RID: 3019
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __GetCurrentTemperatureData_FunctionParams
		{
			// Token: 0x04005D69 RID: 23913
			[FieldOffset(0)]
			public byte Delegate;
		}

		// Token: 0x02000BCC RID: 3020
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __GetCurrentAndroidDeviceRequireAdaptiveModule_FunctionParams
		{
			// Token: 0x04005D6A RID: 23914
			[FieldOffset(0)]
			public int __Result;
		}

		// Token: 0x02000BCD RID: 3021
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetCurrentActivePerformanceAdaptiveModuleName_FunctionParams
		{
			// Token: 0x04005D6B RID: 23915
			[FieldOffset(0)]
			public FString __Result;
		}

		// Token: 0x02000BCE RID: 3022
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __BoostGPU_FunctionParams
		{
			// Token: 0x04005D6C RID: 23916
			[FieldOffset(0)]
			public int FrequencyPercentage;

			// Token: 0x04005D6D RID: 23917
			[FieldOffset(4)]
			public int BoostDurationInMilliSecond;

			// Token: 0x04005D6E RID: 23918
			[FieldOffset(8)]
			public bool bBoostMemory;

			// Token: 0x04005D6F RID: 23919
			[FieldOffset(9)]
			public bool __Result;
		}

		// Token: 0x02000BCF RID: 3023
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __BoostCPU_FunctionParams
		{
			// Token: 0x04005D70 RID: 23920
			[FieldOffset(0)]
			public int FrequencyPercentage;

			// Token: 0x04005D71 RID: 23921
			[FieldOffset(4)]
			public int BoostDurationInMilliSecond;

			// Token: 0x04005D72 RID: 23922
			[FieldOffset(8)]
			public bool bBoostMemory;

			// Token: 0x04005D73 RID: 23923
			[FieldOffset(9)]
			public bool __Result;
		}
	}
}
