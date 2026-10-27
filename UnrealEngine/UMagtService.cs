using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002277 RID: 8823
	[UnrealObjectPath("/Script/MagtModule.MagtService")]
	[UnrealStructLayout(128, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 128)]
	public class UMagtService : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060218AB RID: 137387 RVA: 0x003191EC File Offset: 0x003173EC
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMagtService._ClassPtr;
		}

		// Token: 0x060218AC RID: 137388 RVA: 0x003191F8 File Offset: 0x003173F8
		public UMagtService() : this(BuiltinUtils.AllocNativeUObject(UMagtService.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060218AD RID: 137389 RVA: 0x00319220 File Offset: 0x00317420
		[NullableContext(1)]
		public UMagtService(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMagtService.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17008269 RID: 33385
		// (get) Token: 0x060218AE RID: 137390 RVA: 0x00319254 File Offset: 0x00317454
		// (set) Token: 0x060218AF RID: 137391 RVA: 0x0031928D File Offset: 0x0031748D
		[Nullable(1)]
		public FOnMagtServiceInitialized OnInitialized
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FOnMagtServiceInitialized result;
				if ((result = this._OnInitialized) == null)
				{
					result = (this._OnInitialized = new FOnMagtServiceInitialized(base.NativePtr + (IntPtr)UMagtService.__PropertyOffset_OnInitialized, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UMagtService.__PropertyOffset_OnInitialized, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x1700826A RID: 33386
		// (get) Token: 0x060218B0 RID: 137392 RVA: 0x003192B0 File Offset: 0x003174B0
		// (set) Token: 0x060218B1 RID: 137393 RVA: 0x003192E9 File Offset: 0x003174E9
		[Nullable(1)]
		public FOnMagtServiceStarted OnServiceStarted
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FOnMagtServiceStarted result;
				if ((result = this._OnServiceStarted) == null)
				{
					result = (this._OnServiceStarted = new FOnMagtServiceStarted(base.NativePtr + (IntPtr)UMagtService.__PropertyOffset_OnServiceStarted, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UMagtService.__PropertyOffset_OnServiceStarted, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x1700826B RID: 33387
		// (get) Token: 0x060218B2 RID: 137394 RVA: 0x0031930C File Offset: 0x0031750C
		// (set) Token: 0x060218B3 RID: 137395 RVA: 0x00319345 File Offset: 0x00317545
		[Nullable(1)]
		public FOnMagtServiceStopped OnServiceStopped
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FOnMagtServiceStopped result;
				if ((result = this._OnServiceStopped) == null)
				{
					result = (this._OnServiceStopped = new FOnMagtServiceStopped(base.NativePtr + (IntPtr)UMagtService.__PropertyOffset_OnServiceStopped, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UMagtService.__PropertyOffset_OnServiceStopped, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x060218B4 RID: 137396 RVA: 0x00319368 File Offset: 0x00317568
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool UpdateGameConfig(int ConfigID, int Value)
		{
			UMagtService.__UpdateGameConfig_FunctionParams* ptr = stackalloc UMagtService.__UpdateGameConfig_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(UMagtService.__UpdateGameConfig_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMagtService.__UpdateGameConfig_NativeFunctionPtr, (void*)ptr, 1);
			ptr->ConfigID = ConfigID;
			ptr->Value = Value;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMagtService.__UpdateGameConfig_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x060218B5 RID: 137397 RVA: 0x003193BC File Offset: 0x003175BC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SyncRenderingFrameId(int FrameID)
		{
			UMagtService.__SyncRenderingFrameId_FunctionParams* ptr = stackalloc UMagtService.__SyncRenderingFrameId_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UMagtService.__SyncRenderingFrameId_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMagtService.__SyncRenderingFrameId_NativeFunctionPtr, (void*)ptr, 1);
			ptr->FrameID = FrameID;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMagtService.__SyncRenderingFrameId_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060218B6 RID: 137398 RVA: 0x00319404 File Offset: 0x00317604
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool StopService()
		{
			UMagtService.__StopService_FunctionParams* ptr = stackalloc UMagtService.__StopService_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UMagtService.__StopService_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMagtService.__StopService_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMagtService.__StopService_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x060218B7 RID: 137399 RVA: 0x0031944C File Offset: 0x0031764C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool StartService(int ServiceFlags = 255)
		{
			UMagtService.__StartService_FunctionParams* ptr = stackalloc UMagtService.__StartService_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UMagtService.__StartService_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMagtService.__StartService_NativeFunctionPtr, (void*)ptr, 1);
			ptr->ServiceFlags = ServiceFlags;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMagtService.__StartService_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x060218B8 RID: 137400 RVA: 0x0031949C File Offset: 0x0031769C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool SetOption(int OptionID, int Value)
		{
			UMagtService.__SetOption_FunctionParams* ptr = stackalloc UMagtService.__SetOption_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(UMagtService.__SetOption_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMagtService.__SetOption_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OptionID = OptionID;
			ptr->Value = Value;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMagtService.__SetOption_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x060218B9 RID: 137401 RVA: 0x003194F0 File Offset: 0x003176F0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetForeground(bool bIsForeground)
		{
			UMagtService.__SetForeground_FunctionParams* ptr = stackalloc UMagtService.__SetForeground_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UMagtService.__SetForeground_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMagtService.__SetForeground_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bIsForeground = bIsForeground;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMagtService.__SetForeground_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060218BA RID: 137402 RVA: 0x00319538 File Offset: 0x00317738
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetDebugMode(bool bEnabled)
		{
			UMagtService.__SetDebugMode_FunctionParams* ptr = stackalloc UMagtService.__SetDebugMode_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UMagtService.__SetDebugMode_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMagtService.__SetDebugMode_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bEnabled = bEnabled;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMagtService.__SetDebugMode_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060218BB RID: 137403 RVA: 0x0031957F File Offset: 0x0031777F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Release()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMagtService.__Release_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060218BC RID: 137404 RVA: 0x00319594 File Offset: 0x00317794
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool IsServiceRunning()
		{
			UMagtService.__IsServiceRunning_FunctionParams* ptr = stackalloc UMagtService.__IsServiceRunning_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UMagtService.__IsServiceRunning_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMagtService.__IsServiceRunning_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMagtService.__IsServiceRunning_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x060218BD RID: 137405 RVA: 0x003195DC File Offset: 0x003177DC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool IsInitialized()
		{
			UMagtService.__IsInitialized_FunctionParams* ptr = stackalloc UMagtService.__IsInitialized_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UMagtService.__IsInitialized_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMagtService.__IsInitialized_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMagtService.__IsInitialized_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x060218BE RID: 137406 RVA: 0x00319624 File Offset: 0x00317824
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool InitializeWithSignature(string LicenseKey, string Signature, int APIVersion = 100, int GameCode = 0, int TargetFPS = 60, int RenderThreadID = 0)
		{
			UMagtService.__InitializeWithSignature_FunctionParams* ptr = stackalloc UMagtService.__InitializeWithSignature_FunctionParams[(UIntPtr)71] + 15L / (long)sizeof(UMagtService.__InitializeWithSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMagtService.__InitializeWithSignature_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->LicenseKey), LicenseKey);
			FString.CopyFrom((void*)(&ptr->Signature), Signature);
			ptr->APIVersion = APIVersion;
			ptr->GameCode = GameCode;
			ptr->TargetFPS = TargetFPS;
			ptr->RenderThreadID = RenderThreadID;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMagtService.__InitializeWithSignature_NativeFunctionPtr, (void*)ptr, 0);
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(UMagtService.__InitializeWithSignature_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x060218BF RID: 137407 RVA: 0x003196B4 File Offset: 0x003178B4
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool Initialize(string LicenseKey, int APIVersion = 100, int GameCode = 0, int TargetFPS = 60, int RenderThreadID = 0)
		{
			UMagtService.__Initialize_FunctionParams* ptr = stackalloc UMagtService.__Initialize_FunctionParams[(UIntPtr)55] + 15L / (long)sizeof(UMagtService.__Initialize_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMagtService.__Initialize_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->LicenseKey), LicenseKey);
			ptr->APIVersion = APIVersion;
			ptr->GameCode = GameCode;
			ptr->TargetFPS = TargetFPS;
			ptr->RenderThreadID = RenderThreadID;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMagtService.__Initialize_NativeFunctionPtr, (void*)ptr, 0);
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(UMagtService.__Initialize_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x060218C0 RID: 137408 RVA: 0x00319738 File Offset: 0x00317938
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool InitGameConfig(int ConfigID, int Value)
		{
			UMagtService.__InitGameConfig_FunctionParams* ptr = stackalloc UMagtService.__InitGameConfig_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(UMagtService.__InitGameConfig_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMagtService.__InitGameConfig_NativeFunctionPtr, (void*)ptr, 1);
			ptr->ConfigID = ConfigID;
			ptr->Value = Value;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMagtService.__InitGameConfig_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x060218C1 RID: 137409 RVA: 0x0031978C File Offset: 0x0031798C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe int GetThermalStatus()
		{
			UMagtService.__GetThermalStatus_FunctionParams* ptr = stackalloc UMagtService.__GetThermalStatus_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UMagtService.__GetThermalStatus_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMagtService.__GetThermalStatus_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMagtService.__GetThermalStatus_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x060218C2 RID: 137410 RVA: 0x003197D4 File Offset: 0x003179D4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe int GetTargetFPS()
		{
			UMagtService.__GetTargetFPS_FunctionParams* ptr = stackalloc UMagtService.__GetTargetFPS_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UMagtService.__GetTargetFPS_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMagtService.__GetTargetFPS_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMagtService.__GetTargetFPS_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x060218C3 RID: 137411 RVA: 0x0031981C File Offset: 0x00317A1C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool GetPerformanceReport(ref FMagtPerfReport OutReport)
		{
			UMagtService.__GetPerformanceReport_FunctionParams* ptr = stackalloc UMagtService.__GetPerformanceReport_FunctionParams[(UIntPtr)59] + 15L / (long)sizeof(UMagtService.__GetPerformanceReport_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMagtService.__GetPerformanceReport_NativeFunctionPtr, (void*)ptr, 1);
			if (OutReport != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FMagtPerfReport.StaticStruct(), &ptr->OutReport, OutReport.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMagtService.__GetPerformanceReport_NativeFunctionPtr, (void*)ptr, 0);
			if (OutReport != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FMagtPerfReport.StaticStruct(), OutReport.NativePtr, &ptr->OutReport, 1, false);
			}
			return ptr->__Result;
		}

		// Token: 0x060218C4 RID: 137412 RVA: 0x003198AC File Offset: 0x00317AAC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe int GetPCBTemperature()
		{
			UMagtService.__GetPCBTemperature_FunctionParams* ptr = stackalloc UMagtService.__GetPCBTemperature_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UMagtService.__GetPCBTemperature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMagtService.__GetPCBTemperature_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMagtService.__GetPCBTemperature_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x060218C5 RID: 137413 RVA: 0x003198F4 File Offset: 0x00317AF4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe int GetOption(int OptionID)
		{
			UMagtService.__GetOption_FunctionParams* ptr = stackalloc UMagtService.__GetOption_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UMagtService.__GetOption_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMagtService.__GetOption_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OptionID = OptionID;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMagtService.__GetOption_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x060218C6 RID: 137414 RVA: 0x00319944 File Offset: 0x00317B44
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe int GetInitializationResult()
		{
			UMagtService.__GetInitializationResult_FunctionParams* ptr = stackalloc UMagtService.__GetInitializationResult_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UMagtService.__GetInitializationResult_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMagtService.__GetInitializationResult_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMagtService.__GetInitializationResult_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x060218C7 RID: 137415 RVA: 0x0031998C File Offset: 0x00317B8C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe int GetGPUPerfIndex()
		{
			UMagtService.__GetGPUPerfIndex_FunctionParams* ptr = stackalloc UMagtService.__GetGPUPerfIndex_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UMagtService.__GetGPUPerfIndex_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMagtService.__GetGPUPerfIndex_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMagtService.__GetGPUPerfIndex_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x060218C8 RID: 137416 RVA: 0x003199D4 File Offset: 0x00317BD4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe int GetGPULoadIndex()
		{
			UMagtService.__GetGPULoadIndex_FunctionParams* ptr = stackalloc UMagtService.__GetGPULoadIndex_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UMagtService.__GetGPULoadIndex_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMagtService.__GetGPULoadIndex_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMagtService.__GetGPULoadIndex_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x060218C9 RID: 137417 RVA: 0x00319A1C File Offset: 0x00317C1C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe int GetGameCode()
		{
			UMagtService.__GetGameCode_FunctionParams* ptr = stackalloc UMagtService.__GetGameCode_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UMagtService.__GetGameCode_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMagtService.__GetGameCode_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMagtService.__GetGameCode_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x060218CA RID: 137418 RVA: 0x00319A64 File Offset: 0x00317C64
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe int GetCPUPerfIndex()
		{
			UMagtService.__GetCPUPerfIndex_FunctionParams* ptr = stackalloc UMagtService.__GetCPUPerfIndex_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UMagtService.__GetCPUPerfIndex_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMagtService.__GetCPUPerfIndex_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMagtService.__GetCPUPerfIndex_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x060218CB RID: 137419 RVA: 0x00319AAC File Offset: 0x00317CAC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe int GetCPULoadIndex()
		{
			UMagtService.__GetCPULoadIndex_FunctionParams* ptr = stackalloc UMagtService.__GetCPULoadIndex_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UMagtService.__GetCPULoadIndex_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMagtService.__GetCPULoadIndex_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMagtService.__GetCPULoadIndex_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x060218CC RID: 137420 RVA: 0x00319AF4 File Offset: 0x00317CF4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe int GetBatteryNowCurrent()
		{
			UMagtService.__GetBatteryNowCurrent_FunctionParams* ptr = stackalloc UMagtService.__GetBatteryNowCurrent_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UMagtService.__GetBatteryNowCurrent_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMagtService.__GetBatteryNowCurrent_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMagtService.__GetBatteryNowCurrent_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x060218CD RID: 137421 RVA: 0x00319B3C File Offset: 0x00317D3C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe int GetBatteryAvgCurrent()
		{
			UMagtService.__GetBatteryAvgCurrent_FunctionParams* ptr = stackalloc UMagtService.__GetBatteryAvgCurrent_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UMagtService.__GetBatteryAvgCurrent_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMagtService.__GetBatteryAvgCurrent_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMagtService.__GetBatteryAvgCurrent_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x060218CE RID: 137422 RVA: 0x00319B84 File Offset: 0x00317D84
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool GetAllPowerIndices(ref int OutPCBTemp, ref int OutBatNowCurrent, ref int OutBatAvgCurrent, ref int OutThermalStatus)
		{
			UMagtService.__GetAllPowerIndices_FunctionParams* ptr = stackalloc UMagtService.__GetAllPowerIndices_FunctionParams[(UIntPtr)35] + 15L / (long)sizeof(UMagtService.__GetAllPowerIndices_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMagtService.__GetAllPowerIndices_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OutPCBTemp = OutPCBTemp;
			ptr->OutBatNowCurrent = OutBatNowCurrent;
			ptr->OutBatAvgCurrent = OutBatAvgCurrent;
			ptr->OutThermalStatus = OutThermalStatus;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMagtService.__GetAllPowerIndices_NativeFunctionPtr, (void*)ptr, 0);
			OutPCBTemp = ptr->OutPCBTemp;
			OutBatNowCurrent = ptr->OutBatNowCurrent;
			OutBatAvgCurrent = ptr->OutBatAvgCurrent;
			OutThermalStatus = ptr->OutThermalStatus;
			return ptr->__Result;
		}

		// Token: 0x060218CF RID: 137423 RVA: 0x00319C0C File Offset: 0x00317E0C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool GetAllPerformanceIndices(ref int OutCPUPerfIndex, ref int OutCPULoadIndex, ref int OutGPUPerfIndex, ref int OutGPULoadIndex)
		{
			UMagtService.__GetAllPerformanceIndices_FunctionParams* ptr = stackalloc UMagtService.__GetAllPerformanceIndices_FunctionParams[(UIntPtr)35] + 15L / (long)sizeof(UMagtService.__GetAllPerformanceIndices_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMagtService.__GetAllPerformanceIndices_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OutCPUPerfIndex = OutCPUPerfIndex;
			ptr->OutCPULoadIndex = OutCPULoadIndex;
			ptr->OutGPUPerfIndex = OutGPUPerfIndex;
			ptr->OutGPULoadIndex = OutGPULoadIndex;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMagtService.__GetAllPerformanceIndices_NativeFunctionPtr, (void*)ptr, 0);
			OutCPUPerfIndex = ptr->OutCPUPerfIndex;
			OutCPULoadIndex = ptr->OutCPULoadIndex;
			OutGPUPerfIndex = ptr->OutGPUPerfIndex;
			OutGPULoadIndex = ptr->OutGPULoadIndex;
			return ptr->__Result;
		}

		// Token: 0x060218D0 RID: 137424 RVA: 0x00319C94 File Offset: 0x00317E94
		static UMagtService()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MagtModule.MagtService");
		}

		// Token: 0x060218D1 RID: 137425 RVA: 0x00319CA2 File Offset: 0x00317EA2
		protected UMagtService(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011E8A RID: 73354
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/MagtModule.MagtService";

		// Token: 0x04011E8B RID: 73355
		private static IntPtr _ClassPtr;

		// Token: 0x04011E8C RID: 73356
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011E8D RID: 73357
		internal static int __PropertyOffset_OnInitialized;

		// Token: 0x04011E8E RID: 73358
		[Nullable(2)]
		private FOnMagtServiceInitialized _OnInitialized;

		// Token: 0x04011E8F RID: 73359
		internal static int __PropertyOffset_OnServiceStarted;

		// Token: 0x04011E90 RID: 73360
		[Nullable(2)]
		private FOnMagtServiceStarted _OnServiceStarted;

		// Token: 0x04011E91 RID: 73361
		internal static int __PropertyOffset_OnServiceStopped;

		// Token: 0x04011E92 RID: 73362
		[Nullable(2)]
		private FOnMagtServiceStopped _OnServiceStopped;

		// Token: 0x04011E93 RID: 73363
		private static IntPtr __UpdateGameConfig_NativeFunctionPtr;

		// Token: 0x04011E94 RID: 73364
		private static IntPtr __SyncRenderingFrameId_NativeFunctionPtr;

		// Token: 0x04011E95 RID: 73365
		private static IntPtr __StopService_NativeFunctionPtr;

		// Token: 0x04011E96 RID: 73366
		private static IntPtr __StartService_NativeFunctionPtr;

		// Token: 0x04011E97 RID: 73367
		private static IntPtr __SetOption_NativeFunctionPtr;

		// Token: 0x04011E98 RID: 73368
		private static IntPtr __SetForeground_NativeFunctionPtr;

		// Token: 0x04011E99 RID: 73369
		private static IntPtr __SetDebugMode_NativeFunctionPtr;

		// Token: 0x04011E9A RID: 73370
		private static IntPtr __Release_NativeFunctionPtr;

		// Token: 0x04011E9B RID: 73371
		private static IntPtr __IsServiceRunning_NativeFunctionPtr;

		// Token: 0x04011E9C RID: 73372
		private static IntPtr __IsInitialized_NativeFunctionPtr;

		// Token: 0x04011E9D RID: 73373
		private static IntPtr __InitializeWithSignature_NativeFunctionPtr;

		// Token: 0x04011E9E RID: 73374
		private static IntPtr __Initialize_NativeFunctionPtr;

		// Token: 0x04011E9F RID: 73375
		private static IntPtr __InitGameConfig_NativeFunctionPtr;

		// Token: 0x04011EA0 RID: 73376
		private static IntPtr __GetThermalStatus_NativeFunctionPtr;

		// Token: 0x04011EA1 RID: 73377
		private static IntPtr __GetTargetFPS_NativeFunctionPtr;

		// Token: 0x04011EA2 RID: 73378
		private static IntPtr __GetPerformanceReport_NativeFunctionPtr;

		// Token: 0x04011EA3 RID: 73379
		private static IntPtr __GetPCBTemperature_NativeFunctionPtr;

		// Token: 0x04011EA4 RID: 73380
		private static IntPtr __GetOption_NativeFunctionPtr;

		// Token: 0x04011EA5 RID: 73381
		private static IntPtr __GetInitializationResult_NativeFunctionPtr;

		// Token: 0x04011EA6 RID: 73382
		private static IntPtr __GetGPUPerfIndex_NativeFunctionPtr;

		// Token: 0x04011EA7 RID: 73383
		private static IntPtr __GetGPULoadIndex_NativeFunctionPtr;

		// Token: 0x04011EA8 RID: 73384
		private static IntPtr __GetGameCode_NativeFunctionPtr;

		// Token: 0x04011EA9 RID: 73385
		private static IntPtr __GetCPUPerfIndex_NativeFunctionPtr;

		// Token: 0x04011EAA RID: 73386
		private static IntPtr __GetCPULoadIndex_NativeFunctionPtr;

		// Token: 0x04011EAB RID: 73387
		private static IntPtr __GetBatteryNowCurrent_NativeFunctionPtr;

		// Token: 0x04011EAC RID: 73388
		private static IntPtr __GetBatteryAvgCurrent_NativeFunctionPtr;

		// Token: 0x04011EAD RID: 73389
		private static IntPtr __GetAllPowerIndices_NativeFunctionPtr;

		// Token: 0x04011EAE RID: 73390
		private static IntPtr __GetAllPerformanceIndices_NativeFunctionPtr;

		// Token: 0x020035D0 RID: 13776
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __UpdateGameConfig_FunctionParams
		{
			// Token: 0x04017626 RID: 95782
			[FieldOffset(0)]
			public int ConfigID;

			// Token: 0x04017627 RID: 95783
			[FieldOffset(4)]
			public int Value;

			// Token: 0x04017628 RID: 95784
			[FieldOffset(8)]
			public bool __Result;
		}

		// Token: 0x020035D1 RID: 13777
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __SyncRenderingFrameId_FunctionParams
		{
			// Token: 0x04017629 RID: 95785
			[FieldOffset(0)]
			public int FrameID;
		}

		// Token: 0x020035D2 RID: 13778
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __StopService_FunctionParams
		{
			// Token: 0x0401762A RID: 95786
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x020035D3 RID: 13779
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __StartService_FunctionParams
		{
			// Token: 0x0401762B RID: 95787
			[FieldOffset(0)]
			public int ServiceFlags;

			// Token: 0x0401762C RID: 95788
			[FieldOffset(4)]
			public bool __Result;
		}

		// Token: 0x020035D4 RID: 13780
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __SetOption_FunctionParams
		{
			// Token: 0x0401762D RID: 95789
			[FieldOffset(0)]
			public int OptionID;

			// Token: 0x0401762E RID: 95790
			[FieldOffset(4)]
			public int Value;

			// Token: 0x0401762F RID: 95791
			[FieldOffset(8)]
			public bool __Result;
		}

		// Token: 0x020035D5 RID: 13781
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __SetForeground_FunctionParams
		{
			// Token: 0x04017630 RID: 95792
			[FieldOffset(0)]
			public bool bIsForeground;
		}

		// Token: 0x020035D6 RID: 13782
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __SetDebugMode_FunctionParams
		{
			// Token: 0x04017631 RID: 95793
			[FieldOffset(0)]
			public bool bEnabled;
		}

		// Token: 0x020035D7 RID: 13783
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __IsServiceRunning_FunctionParams
		{
			// Token: 0x04017632 RID: 95794
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x020035D8 RID: 13784
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __IsInitialized_FunctionParams
		{
			// Token: 0x04017633 RID: 95795
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x020035D9 RID: 13785
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 56)]
		protected ref struct __InitializeWithSignature_FunctionParams
		{
			// Token: 0x04017634 RID: 95796
			[FieldOffset(0)]
			public FString LicenseKey;

			// Token: 0x04017635 RID: 95797
			[FieldOffset(16)]
			public FString Signature;

			// Token: 0x04017636 RID: 95798
			[FieldOffset(32)]
			public int APIVersion;

			// Token: 0x04017637 RID: 95799
			[FieldOffset(36)]
			public int GameCode;

			// Token: 0x04017638 RID: 95800
			[FieldOffset(40)]
			public int TargetFPS;

			// Token: 0x04017639 RID: 95801
			[FieldOffset(44)]
			public int RenderThreadID;

			// Token: 0x0401763A RID: 95802
			[FieldOffset(48)]
			public bool __Result;
		}

		// Token: 0x020035DA RID: 13786
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __Initialize_FunctionParams
		{
			// Token: 0x0401763B RID: 95803
			[FieldOffset(0)]
			public FString LicenseKey;

			// Token: 0x0401763C RID: 95804
			[FieldOffset(16)]
			public int APIVersion;

			// Token: 0x0401763D RID: 95805
			[FieldOffset(20)]
			public int GameCode;

			// Token: 0x0401763E RID: 95806
			[FieldOffset(24)]
			public int TargetFPS;

			// Token: 0x0401763F RID: 95807
			[FieldOffset(28)]
			public int RenderThreadID;

			// Token: 0x04017640 RID: 95808
			[FieldOffset(32)]
			public bool __Result;
		}

		// Token: 0x020035DB RID: 13787
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __InitGameConfig_FunctionParams
		{
			// Token: 0x04017641 RID: 95809
			[FieldOffset(0)]
			public int ConfigID;

			// Token: 0x04017642 RID: 95810
			[FieldOffset(4)]
			public int Value;

			// Token: 0x04017643 RID: 95811
			[FieldOffset(8)]
			public bool __Result;
		}

		// Token: 0x020035DC RID: 13788
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __GetThermalStatus_FunctionParams
		{
			// Token: 0x04017644 RID: 95812
			[FieldOffset(0)]
			public int __Result;
		}

		// Token: 0x020035DD RID: 13789
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __GetTargetFPS_FunctionParams
		{
			// Token: 0x04017645 RID: 95813
			[FieldOffset(0)]
			public int __Result;
		}

		// Token: 0x020035DE RID: 13790
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 44)]
		protected ref struct __GetPerformanceReport_FunctionParams
		{
			// Token: 0x04017646 RID: 95814
			[FieldOffset(0)]
			public byte OutReport;

			// Token: 0x04017647 RID: 95815
			[FieldOffset(40)]
			public bool __Result;
		}

		// Token: 0x020035DF RID: 13791
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __GetPCBTemperature_FunctionParams
		{
			// Token: 0x04017648 RID: 95816
			[FieldOffset(0)]
			public int __Result;
		}

		// Token: 0x020035E0 RID: 13792
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __GetOption_FunctionParams
		{
			// Token: 0x04017649 RID: 95817
			[FieldOffset(0)]
			public int OptionID;

			// Token: 0x0401764A RID: 95818
			[FieldOffset(4)]
			public int __Result;
		}

		// Token: 0x020035E1 RID: 13793
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __GetInitializationResult_FunctionParams
		{
			// Token: 0x0401764B RID: 95819
			[FieldOffset(0)]
			public int __Result;
		}

		// Token: 0x020035E2 RID: 13794
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __GetGPUPerfIndex_FunctionParams
		{
			// Token: 0x0401764C RID: 95820
			[FieldOffset(0)]
			public int __Result;
		}

		// Token: 0x020035E3 RID: 13795
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __GetGPULoadIndex_FunctionParams
		{
			// Token: 0x0401764D RID: 95821
			[FieldOffset(0)]
			public int __Result;
		}

		// Token: 0x020035E4 RID: 13796
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __GetGameCode_FunctionParams
		{
			// Token: 0x0401764E RID: 95822
			[FieldOffset(0)]
			public int __Result;
		}

		// Token: 0x020035E5 RID: 13797
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __GetCPUPerfIndex_FunctionParams
		{
			// Token: 0x0401764F RID: 95823
			[FieldOffset(0)]
			public int __Result;
		}

		// Token: 0x020035E6 RID: 13798
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __GetCPULoadIndex_FunctionParams
		{
			// Token: 0x04017650 RID: 95824
			[FieldOffset(0)]
			public int __Result;
		}

		// Token: 0x020035E7 RID: 13799
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __GetBatteryNowCurrent_FunctionParams
		{
			// Token: 0x04017651 RID: 95825
			[FieldOffset(0)]
			public int __Result;
		}

		// Token: 0x020035E8 RID: 13800
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __GetBatteryAvgCurrent_FunctionParams
		{
			// Token: 0x04017652 RID: 95826
			[FieldOffset(0)]
			public int __Result;
		}

		// Token: 0x020035E9 RID: 13801
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 20)]
		protected ref struct __GetAllPowerIndices_FunctionParams
		{
			// Token: 0x04017653 RID: 95827
			[FieldOffset(0)]
			public int OutPCBTemp;

			// Token: 0x04017654 RID: 95828
			[FieldOffset(4)]
			public int OutBatNowCurrent;

			// Token: 0x04017655 RID: 95829
			[FieldOffset(8)]
			public int OutBatAvgCurrent;

			// Token: 0x04017656 RID: 95830
			[FieldOffset(12)]
			public int OutThermalStatus;

			// Token: 0x04017657 RID: 95831
			[FieldOffset(16)]
			public bool __Result;
		}

		// Token: 0x020035EA RID: 13802
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 20)]
		protected ref struct __GetAllPerformanceIndices_FunctionParams
		{
			// Token: 0x04017658 RID: 95832
			[FieldOffset(0)]
			public int OutCPUPerfIndex;

			// Token: 0x04017659 RID: 95833
			[FieldOffset(4)]
			public int OutCPULoadIndex;

			// Token: 0x0401765A RID: 95834
			[FieldOffset(8)]
			public int OutGPUPerfIndex;

			// Token: 0x0401765B RID: 95835
			[FieldOffset(12)]
			public int OutGPULoadIndex;

			// Token: 0x0401765C RID: 95836
			[FieldOffset(16)]
			public bool __Result;
		}
	}
}
