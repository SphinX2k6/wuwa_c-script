using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002762 RID: 10082
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Sharphereal.KooSharpRuntimeSettings")]
	[UnrealStructLayout(672, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 672)]
	public class UKooSharpRuntimeSettings : UDeveloperSettings, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06025B0D RID: 154381 RVA: 0x00391E63 File Offset: 0x00390063
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKooSharpRuntimeSettings._ClassPtr;
		}

		// Token: 0x06025B0E RID: 154382 RVA: 0x00391E70 File Offset: 0x00390070
		public UKooSharpRuntimeSettings() : this(BuiltinUtils.AllocNativeUObject(UKooSharpRuntimeSettings.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06025B0F RID: 154383 RVA: 0x00391E98 File Offset: 0x00390098
		public UKooSharpRuntimeSettings(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKooSharpRuntimeSettings.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17009116 RID: 37142
		// (get) Token: 0x06025B10 RID: 154384 RVA: 0x00391ECC File Offset: 0x003900CC
		// (set) Token: 0x06025B11 RID: 154385 RVA: 0x00391F05 File Offset: 0x00390105
		public TArray<EKooSharpBuildConfiguration> EnableDebugger
		{
			get
			{
				base.FastCheckIsValid();
				TArray<EKooSharpBuildConfiguration> result;
				if ((result = this._EnableDebugger) == null)
				{
					result = (this._EnableDebugger = new TArray<EKooSharpBuildConfiguration>(base.NativePtr + (IntPtr)UKooSharpRuntimeSettings.__PropertyOffset_EnableDebugger, this));
				}
				return result;
			}
			set
			{
				this.EnableDebugger.CopyAssign(value);
			}
		}

		// Token: 0x17009117 RID: 37143
		// (get) Token: 0x06025B12 RID: 154386 RVA: 0x00391F14 File Offset: 0x00390114
		// (set) Token: 0x06025B13 RID: 154387 RVA: 0x00391F4D File Offset: 0x0039014D
		public TArray<EKooSharpBuildConfiguration> WaitForDebugger
		{
			get
			{
				base.FastCheckIsValid();
				TArray<EKooSharpBuildConfiguration> result;
				if ((result = this._WaitForDebugger) == null)
				{
					result = (this._WaitForDebugger = new TArray<EKooSharpBuildConfiguration>(base.NativePtr + (IntPtr)UKooSharpRuntimeSettings.__PropertyOffset_WaitForDebugger, this));
				}
				return result;
			}
			set
			{
				this.WaitForDebugger.CopyAssign(value);
			}
		}

		// Token: 0x17009118 RID: 37144
		// (get) Token: 0x06025B14 RID: 154388 RVA: 0x00391F5B File Offset: 0x0039015B
		// (set) Token: 0x06025B15 RID: 154389 RVA: 0x00391F6B File Offset: 0x0039016B
		public unsafe ushort DebuggerPort
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKooSharpRuntimeSettings.__PropertyOffset_DebuggerPort);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKooSharpRuntimeSettings.__PropertyOffset_DebuggerPort) = (short)value;
			}
		}

		// Token: 0x17009119 RID: 37145
		// (get) Token: 0x06025B16 RID: 154390 RVA: 0x00391F7C File Offset: 0x0039017C
		// (set) Token: 0x06025B17 RID: 154391 RVA: 0x00391FB5 File Offset: 0x003901B5
		public FKooSharpMonoTraceLevelRuntimeSettings MonoTraceLevel
		{
			get
			{
				base.FastCheckIsValid();
				FKooSharpMonoTraceLevelRuntimeSettings result;
				if ((result = this._MonoTraceLevel) == null)
				{
					result = (this._MonoTraceLevel = new FKooSharpMonoTraceLevelRuntimeSettings(base.NativePtr + (IntPtr)UKooSharpRuntimeSettings.__PropertyOffset_MonoTraceLevel, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKooSharpMonoTraceLevelRuntimeSettings.StaticStruct(), base.NativePtr + (IntPtr)UKooSharpRuntimeSettings.__PropertyOffset_MonoTraceLevel, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700911A RID: 37146
		// (get) Token: 0x06025B18 RID: 154392 RVA: 0x00391FD8 File Offset: 0x003901D8
		// (set) Token: 0x06025B19 RID: 154393 RVA: 0x00392011 File Offset: 0x00390211
		public FKooSharpMonoTraceMaskRuntimeSettings MonoTraceMask
		{
			get
			{
				base.FastCheckIsValid();
				FKooSharpMonoTraceMaskRuntimeSettings result;
				if ((result = this._MonoTraceMask) == null)
				{
					result = (this._MonoTraceMask = new FKooSharpMonoTraceMaskRuntimeSettings(base.NativePtr + (IntPtr)UKooSharpRuntimeSettings.__PropertyOffset_MonoTraceMask, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKooSharpMonoTraceMaskRuntimeSettings.StaticStruct(), base.NativePtr + (IntPtr)UKooSharpRuntimeSettings.__PropertyOffset_MonoTraceMask, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700911B RID: 37147
		// (get) Token: 0x06025B1A RID: 154394 RVA: 0x00392032 File Offset: 0x00390232
		// (set) Token: 0x06025B1B RID: 154395 RVA: 0x00392042 File Offset: 0x00390242
		public unsafe int MonoDebuggerLogLevel
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKooSharpRuntimeSettings.__PropertyOffset_MonoDebuggerLogLevel);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKooSharpRuntimeSettings.__PropertyOffset_MonoDebuggerLogLevel) = value;
			}
		}

		// Token: 0x1700911C RID: 37148
		// (get) Token: 0x06025B1C RID: 154396 RVA: 0x00392053 File Offset: 0x00390253
		// (set) Token: 0x06025B1D RID: 154397 RVA: 0x00392067 File Offset: 0x00390267
		public unsafe string MonoDebuggerLogFile
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UKooSharpRuntimeSettings.__PropertyOffset_MonoDebuggerLogFile)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UKooSharpRuntimeSettings.__PropertyOffset_MonoDebuggerLogFile)), value);
			}
		}

		// Token: 0x1700911D RID: 37149
		// (get) Token: 0x06025B1E RID: 154398 RVA: 0x0039207C File Offset: 0x0039027C
		// (set) Token: 0x06025B1F RID: 154399 RVA: 0x00392090 File Offset: 0x00390290
		public unsafe string MonoGCDebugArgs
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UKooSharpRuntimeSettings.__PropertyOffset_MonoGCDebugArgs)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UKooSharpRuntimeSettings.__PropertyOffset_MonoGCDebugArgs)), value);
			}
		}

		// Token: 0x1700911E RID: 37150
		// (get) Token: 0x06025B20 RID: 154400 RVA: 0x003920A5 File Offset: 0x003902A5
		// (set) Token: 0x06025B21 RID: 154401 RVA: 0x003920B9 File Offset: 0x003902B9
		public unsafe string MonoGCParams
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UKooSharpRuntimeSettings.__PropertyOffset_MonoGCParams)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UKooSharpRuntimeSettings.__PropertyOffset_MonoGCParams)), value);
			}
		}

		// Token: 0x1700911F RID: 37151
		// (get) Token: 0x06025B22 RID: 154402 RVA: 0x003920CE File Offset: 0x003902CE
		// (set) Token: 0x06025B23 RID: 154403 RVA: 0x003920E2 File Offset: 0x003902E2
		public unsafe string MonoGCParamsLowMemory
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UKooSharpRuntimeSettings.__PropertyOffset_MonoGCParamsLowMemory)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UKooSharpRuntimeSettings.__PropertyOffset_MonoGCParamsLowMemory)), value);
			}
		}

		// Token: 0x17009120 RID: 37152
		// (get) Token: 0x06025B24 RID: 154404 RVA: 0x003920F8 File Offset: 0x003902F8
		// (set) Token: 0x06025B25 RID: 154405 RVA: 0x00392131 File Offset: 0x00390331
		public TArray<EKooSharpBuildConfiguration> EnableMonoStatForMemory
		{
			get
			{
				base.FastCheckIsValid();
				TArray<EKooSharpBuildConfiguration> result;
				if ((result = this._EnableMonoStatForMemory) == null)
				{
					result = (this._EnableMonoStatForMemory = new TArray<EKooSharpBuildConfiguration>(base.NativePtr + (IntPtr)UKooSharpRuntimeSettings.__PropertyOffset_EnableMonoStatForMemory, this));
				}
				return result;
			}
			set
			{
				this.EnableMonoStatForMemory.CopyAssign(value);
			}
		}

		// Token: 0x17009121 RID: 37153
		// (get) Token: 0x06025B26 RID: 154406 RVA: 0x00392140 File Offset: 0x00390340
		// (set) Token: 0x06025B27 RID: 154407 RVA: 0x00392179 File Offset: 0x00390379
		public TArray<EKooSharpBuildConfiguration> EnableMonoStatForJIT
		{
			get
			{
				base.FastCheckIsValid();
				TArray<EKooSharpBuildConfiguration> result;
				if ((result = this._EnableMonoStatForJIT) == null)
				{
					result = (this._EnableMonoStatForJIT = new TArray<EKooSharpBuildConfiguration>(base.NativePtr + (IntPtr)UKooSharpRuntimeSettings.__PropertyOffset_EnableMonoStatForJIT, this));
				}
				return result;
			}
			set
			{
				this.EnableMonoStatForJIT.CopyAssign(value);
			}
		}

		// Token: 0x17009122 RID: 37154
		// (get) Token: 0x06025B28 RID: 154408 RVA: 0x00392188 File Offset: 0x00390388
		// (set) Token: 0x06025B29 RID: 154409 RVA: 0x003921C1 File Offset: 0x003903C1
		public TArray<EKooSharpBuildConfiguration> EnableMonoStatForInvoke
		{
			get
			{
				base.FastCheckIsValid();
				TArray<EKooSharpBuildConfiguration> result;
				if ((result = this._EnableMonoStatForInvoke) == null)
				{
					result = (this._EnableMonoStatForInvoke = new TArray<EKooSharpBuildConfiguration>(base.NativePtr + (IntPtr)UKooSharpRuntimeSettings.__PropertyOffset_EnableMonoStatForInvoke, this));
				}
				return result;
			}
			set
			{
				this.EnableMonoStatForInvoke.CopyAssign(value);
			}
		}

		// Token: 0x17009123 RID: 37155
		// (get) Token: 0x06025B2A RID: 154410 RVA: 0x003921D0 File Offset: 0x003903D0
		// (set) Token: 0x06025B2B RID: 154411 RVA: 0x00392209 File Offset: 0x00390409
		public TArray<EKooSharpBuildConfiguration> EnableMonoStatForGC
		{
			get
			{
				base.FastCheckIsValid();
				TArray<EKooSharpBuildConfiguration> result;
				if ((result = this._EnableMonoStatForGC) == null)
				{
					result = (this._EnableMonoStatForGC = new TArray<EKooSharpBuildConfiguration>(base.NativePtr + (IntPtr)UKooSharpRuntimeSettings.__PropertyOffset_EnableMonoStatForGC, this));
				}
				return result;
			}
			set
			{
				this.EnableMonoStatForGC.CopyAssign(value);
			}
		}

		// Token: 0x17009124 RID: 37156
		// (get) Token: 0x06025B2C RID: 154412 RVA: 0x00392218 File Offset: 0x00390418
		// (set) Token: 0x06025B2D RID: 154413 RVA: 0x00392251 File Offset: 0x00390451
		public TArray<EKooSharpBuildConfiguration> EnableMonoStatForMethodTrace
		{
			get
			{
				base.FastCheckIsValid();
				TArray<EKooSharpBuildConfiguration> result;
				if ((result = this._EnableMonoStatForMethodTrace) == null)
				{
					result = (this._EnableMonoStatForMethodTrace = new TArray<EKooSharpBuildConfiguration>(base.NativePtr + (IntPtr)UKooSharpRuntimeSettings.__PropertyOffset_EnableMonoStatForMethodTrace, this));
				}
				return result;
			}
			set
			{
				this.EnableMonoStatForMethodTrace.CopyAssign(value);
			}
		}

		// Token: 0x17009125 RID: 37157
		// (get) Token: 0x06025B2E RID: 154414 RVA: 0x00392260 File Offset: 0x00390460
		// (set) Token: 0x06025B2F RID: 154415 RVA: 0x00392299 File Offset: 0x00390499
		public TArray<string> MonoMethodTraceSkipClasses
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._MonoMethodTraceSkipClasses) == null)
				{
					result = (this._MonoMethodTraceSkipClasses = new TArray<string>(base.NativePtr + (IntPtr)UKooSharpRuntimeSettings.__PropertyOffset_MonoMethodTraceSkipClasses, this));
				}
				return result;
			}
			set
			{
				this.MonoMethodTraceSkipClasses.CopyAssign(value);
			}
		}

		// Token: 0x17009126 RID: 37158
		// (get) Token: 0x06025B30 RID: 154416 RVA: 0x003922A8 File Offset: 0x003904A8
		// (set) Token: 0x06025B31 RID: 154417 RVA: 0x003922E1 File Offset: 0x003904E1
		public TArray<EKooSharpBuildConfiguration> EnableLogJitAddress
		{
			get
			{
				base.FastCheckIsValid();
				TArray<EKooSharpBuildConfiguration> result;
				if ((result = this._EnableLogJitAddress) == null)
				{
					result = (this._EnableLogJitAddress = new TArray<EKooSharpBuildConfiguration>(base.NativePtr + (IntPtr)UKooSharpRuntimeSettings.__PropertyOffset_EnableLogJitAddress, this));
				}
				return result;
			}
			set
			{
				this.EnableLogJitAddress.CopyAssign(value);
			}
		}

		// Token: 0x17009127 RID: 37159
		// (get) Token: 0x06025B32 RID: 154418 RVA: 0x003922F0 File Offset: 0x003904F0
		// (set) Token: 0x06025B33 RID: 154419 RVA: 0x00392329 File Offset: 0x00390529
		public TArray<string> ExtraMonoOptions
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._ExtraMonoOptions) == null)
				{
					result = (this._ExtraMonoOptions = new TArray<string>(base.NativePtr + (IntPtr)UKooSharpRuntimeSettings.__PropertyOffset_ExtraMonoOptions, this));
				}
				return result;
			}
			set
			{
				this.ExtraMonoOptions.CopyAssign(value);
			}
		}

		// Token: 0x17009128 RID: 37160
		// (get) Token: 0x06025B34 RID: 154420 RVA: 0x00392337 File Offset: 0x00390537
		// (set) Token: 0x06025B35 RID: 154421 RVA: 0x00392347 File Offset: 0x00390547
		public unsafe bool bEnableCSharpEnvironment
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKooSharpRuntimeSettings.__PropertyOffset_bEnableCSharpEnvironment) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKooSharpRuntimeSettings.__PropertyOffset_bEnableCSharpEnvironment) = (value ? 1 : 0);
			}
		}

		// Token: 0x17009129 RID: 37161
		// (get) Token: 0x06025B36 RID: 154422 RVA: 0x00392358 File Offset: 0x00390558
		// (set) Token: 0x06025B37 RID: 154423 RVA: 0x00392368 File Offset: 0x00390568
		public unsafe bool bUseMMapLoadDLL
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKooSharpRuntimeSettings.__PropertyOffset_bUseMMapLoadDLL) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKooSharpRuntimeSettings.__PropertyOffset_bUseMMapLoadDLL) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700912A RID: 37162
		// (get) Token: 0x06025B38 RID: 154424 RVA: 0x00392379 File Offset: 0x00390579
		// (set) Token: 0x06025B39 RID: 154425 RVA: 0x0039238D File Offset: 0x0039058D
		public unsafe string ScriptProjectName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UKooSharpRuntimeSettings.__PropertyOffset_ScriptProjectName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UKooSharpRuntimeSettings.__PropertyOffset_ScriptProjectName)), value);
			}
		}

		// Token: 0x1700912B RID: 37163
		// (get) Token: 0x06025B3A RID: 154426 RVA: 0x003923A2 File Offset: 0x003905A2
		// (set) Token: 0x06025B3B RID: 154427 RVA: 0x003923B6 File Offset: 0x003905B6
		public unsafe string ScriptAssembliesPath
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UKooSharpRuntimeSettings.__PropertyOffset_ScriptAssembliesPath)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UKooSharpRuntimeSettings.__PropertyOffset_ScriptAssembliesPath)), value);
			}
		}

		// Token: 0x1700912C RID: 37164
		// (get) Token: 0x06025B3C RID: 154428 RVA: 0x003923CB File Offset: 0x003905CB
		// (set) Token: 0x06025B3D RID: 154429 RVA: 0x003923DF File Offset: 0x003905DF
		public unsafe string ScriptAssembliesEditorPath
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UKooSharpRuntimeSettings.__PropertyOffset_ScriptAssembliesEditorPath)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UKooSharpRuntimeSettings.__PropertyOffset_ScriptAssembliesEditorPath)), value);
			}
		}

		// Token: 0x1700912D RID: 37165
		// (get) Token: 0x06025B3E RID: 154430 RVA: 0x003923F4 File Offset: 0x003905F4
		// (set) Token: 0x06025B3F RID: 154431 RVA: 0x00392408 File Offset: 0x00390608
		public unsafe string ScriptAssembliesNonShippingPath
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UKooSharpRuntimeSettings.__PropertyOffset_ScriptAssembliesNonShippingPath)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UKooSharpRuntimeSettings.__PropertyOffset_ScriptAssembliesNonShippingPath)), value);
			}
		}

		// Token: 0x1700912E RID: 37166
		// (get) Token: 0x06025B40 RID: 154432 RVA: 0x0039241D File Offset: 0x0039061D
		// (set) Token: 0x06025B41 RID: 154433 RVA: 0x00392431 File Offset: 0x00390631
		public unsafe string AOTAssembliesNonShippingPath
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UKooSharpRuntimeSettings.__PropertyOffset_AOTAssembliesNonShippingPath)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UKooSharpRuntimeSettings.__PropertyOffset_AOTAssembliesNonShippingPath)), value);
			}
		}

		// Token: 0x1700912F RID: 37167
		// (get) Token: 0x06025B42 RID: 154434 RVA: 0x00392446 File Offset: 0x00390646
		// (set) Token: 0x06025B43 RID: 154435 RVA: 0x00392456 File Offset: 0x00390656
		public unsafe EMonoAotMode MonoAOTMode
		{
			get
			{
				return (EMonoAotMode)(*(base.NativePtr + (IntPtr)UKooSharpRuntimeSettings.__PropertyOffset_MonoAOTMode));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKooSharpRuntimeSettings.__PropertyOffset_MonoAOTMode) = (byte)value;
			}
		}

		// Token: 0x17009130 RID: 37168
		// (get) Token: 0x06025B44 RID: 154436 RVA: 0x00392467 File Offset: 0x00390667
		// (set) Token: 0x06025B45 RID: 154437 RVA: 0x00392477 File Offset: 0x00390677
		public unsafe bool bDisableNonClientAOTRegistration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKooSharpRuntimeSettings.__PropertyOffset_bDisableNonClientAOTRegistration) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKooSharpRuntimeSettings.__PropertyOffset_bDisableNonClientAOTRegistration) = (value ? 1 : 0);
			}
		}

		// Token: 0x17009131 RID: 37169
		// (get) Token: 0x06025B46 RID: 154438 RVA: 0x00392488 File Offset: 0x00390688
		// (set) Token: 0x06025B47 RID: 154439 RVA: 0x00392498 File Offset: 0x00390698
		public unsafe bool bDisableClientAOTRegistration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKooSharpRuntimeSettings.__PropertyOffset_bDisableClientAOTRegistration) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKooSharpRuntimeSettings.__PropertyOffset_bDisableClientAOTRegistration) = (value ? 1 : 0);
			}
		}

		// Token: 0x17009132 RID: 37170
		// (get) Token: 0x06025B48 RID: 154440 RVA: 0x003924AC File Offset: 0x003906AC
		// (set) Token: 0x06025B49 RID: 154441 RVA: 0x003924E5 File Offset: 0x003906E5
		public TArray<string> EditorPreloadAssemblies
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._EditorPreloadAssemblies) == null)
				{
					result = (this._EditorPreloadAssemblies = new TArray<string>(base.NativePtr + (IntPtr)UKooSharpRuntimeSettings.__PropertyOffset_EditorPreloadAssemblies, this));
				}
				return result;
			}
			set
			{
				this.EditorPreloadAssemblies.CopyAssign(value);
			}
		}

		// Token: 0x17009133 RID: 37171
		// (get) Token: 0x06025B4A RID: 154442 RVA: 0x003924F4 File Offset: 0x003906F4
		// (set) Token: 0x06025B4B RID: 154443 RVA: 0x0039252D File Offset: 0x0039072D
		public TArray<string> RuntimeLoadAssemblies
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._RuntimeLoadAssemblies) == null)
				{
					result = (this._RuntimeLoadAssemblies = new TArray<string>(base.NativePtr + (IntPtr)UKooSharpRuntimeSettings.__PropertyOffset_RuntimeLoadAssemblies, this));
				}
				return result;
			}
			set
			{
				this.RuntimeLoadAssemblies.CopyAssign(value);
			}
		}

		// Token: 0x17009134 RID: 37172
		// (get) Token: 0x06025B4C RID: 154444 RVA: 0x0039253C File Offset: 0x0039073C
		// (set) Token: 0x06025B4D RID: 154445 RVA: 0x00392575 File Offset: 0x00390775
		public TArray<string> DeferredRuntimeLoadAssemblies
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._DeferredRuntimeLoadAssemblies) == null)
				{
					result = (this._DeferredRuntimeLoadAssemblies = new TArray<string>(base.NativePtr + (IntPtr)UKooSharpRuntimeSettings.__PropertyOffset_DeferredRuntimeLoadAssemblies, this));
				}
				return result;
			}
			set
			{
				this.DeferredRuntimeLoadAssemblies.CopyAssign(value);
			}
		}

		// Token: 0x17009135 RID: 37173
		// (get) Token: 0x06025B4E RID: 154446 RVA: 0x00392584 File Offset: 0x00390784
		// (set) Token: 0x06025B4F RID: 154447 RVA: 0x003925BD File Offset: 0x003907BD
		public TArray<FSharpGameAssemblyConfig> GameAssemblies
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FSharpGameAssemblyConfig> result;
				if ((result = this._GameAssemblies) == null)
				{
					result = (this._GameAssemblies = new TArray<FSharpGameAssemblyConfig>(base.NativePtr + (IntPtr)UKooSharpRuntimeSettings.__PropertyOffset_GameAssemblies, this));
				}
				return result;
			}
			set
			{
				this.GameAssemblies.CopyAssign(value);
			}
		}

		// Token: 0x17009136 RID: 37174
		// (get) Token: 0x06025B50 RID: 154448 RVA: 0x003925CC File Offset: 0x003907CC
		// (set) Token: 0x06025B51 RID: 154449 RVA: 0x00392605 File Offset: 0x00390805
		public TArray<string> ExtraEnvironment
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._ExtraEnvironment) == null)
				{
					result = (this._ExtraEnvironment = new TArray<string>(base.NativePtr + (IntPtr)UKooSharpRuntimeSettings.__PropertyOffset_ExtraEnvironment, this));
				}
				return result;
			}
			set
			{
				this.ExtraEnvironment.CopyAssign(value);
			}
		}

		// Token: 0x17009137 RID: 37175
		// (get) Token: 0x06025B52 RID: 154450 RVA: 0x00392614 File Offset: 0x00390814
		// (set) Token: 0x06025B53 RID: 154451 RVA: 0x0039264D File Offset: 0x0039084D
		public TArray<string> NoUseDangerousInternalCall
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._NoUseDangerousInternalCall) == null)
				{
					result = (this._NoUseDangerousInternalCall = new TArray<string>(base.NativePtr + (IntPtr)UKooSharpRuntimeSettings.__PropertyOffset_NoUseDangerousInternalCall, this));
				}
				return result;
			}
			set
			{
				this.NoUseDangerousInternalCall.CopyAssign(value);
			}
		}

		// Token: 0x06025B54 RID: 154452 RVA: 0x0039265B File Offset: 0x0039085B
		static UKooSharpRuntimeSettings()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Sharphereal.KooSharpRuntimeSettings");
		}

		// Token: 0x06025B55 RID: 154453 RVA: 0x00392669 File Offset: 0x00390869
		protected UKooSharpRuntimeSettings(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04014841 RID: 84033
		public new const string __ObjectPath = "/Script/Sharphereal.KooSharpRuntimeSettings";

		// Token: 0x04014842 RID: 84034
		private static IntPtr _ClassPtr;

		// Token: 0x04014843 RID: 84035
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04014844 RID: 84036
		internal static int __PropertyOffset_EnableDebugger;

		// Token: 0x04014845 RID: 84037
		[Nullable(2)]
		private TArray<EKooSharpBuildConfiguration> _EnableDebugger;

		// Token: 0x04014846 RID: 84038
		internal static int __PropertyOffset_WaitForDebugger;

		// Token: 0x04014847 RID: 84039
		[Nullable(2)]
		private TArray<EKooSharpBuildConfiguration> _WaitForDebugger;

		// Token: 0x04014848 RID: 84040
		internal static int __PropertyOffset_DebuggerPort;

		// Token: 0x04014849 RID: 84041
		internal static int __PropertyOffset_MonoTraceLevel;

		// Token: 0x0401484A RID: 84042
		[Nullable(2)]
		private FKooSharpMonoTraceLevelRuntimeSettings _MonoTraceLevel;

		// Token: 0x0401484B RID: 84043
		internal static int __PropertyOffset_MonoTraceMask;

		// Token: 0x0401484C RID: 84044
		[Nullable(2)]
		private FKooSharpMonoTraceMaskRuntimeSettings _MonoTraceMask;

		// Token: 0x0401484D RID: 84045
		internal static int __PropertyOffset_MonoDebuggerLogLevel;

		// Token: 0x0401484E RID: 84046
		internal static int __PropertyOffset_MonoDebuggerLogFile;

		// Token: 0x0401484F RID: 84047
		internal static int __PropertyOffset_MonoGCDebugArgs;

		// Token: 0x04014850 RID: 84048
		internal static int __PropertyOffset_MonoGCParams;

		// Token: 0x04014851 RID: 84049
		internal static int __PropertyOffset_MonoGCParamsLowMemory;

		// Token: 0x04014852 RID: 84050
		internal static int __PropertyOffset_EnableMonoStatForMemory;

		// Token: 0x04014853 RID: 84051
		[Nullable(2)]
		private TArray<EKooSharpBuildConfiguration> _EnableMonoStatForMemory;

		// Token: 0x04014854 RID: 84052
		internal static int __PropertyOffset_EnableMonoStatForJIT;

		// Token: 0x04014855 RID: 84053
		[Nullable(2)]
		private TArray<EKooSharpBuildConfiguration> _EnableMonoStatForJIT;

		// Token: 0x04014856 RID: 84054
		internal static int __PropertyOffset_EnableMonoStatForInvoke;

		// Token: 0x04014857 RID: 84055
		[Nullable(2)]
		private TArray<EKooSharpBuildConfiguration> _EnableMonoStatForInvoke;

		// Token: 0x04014858 RID: 84056
		internal static int __PropertyOffset_EnableMonoStatForGC;

		// Token: 0x04014859 RID: 84057
		[Nullable(2)]
		private TArray<EKooSharpBuildConfiguration> _EnableMonoStatForGC;

		// Token: 0x0401485A RID: 84058
		internal static int __PropertyOffset_EnableMonoStatForMethodTrace;

		// Token: 0x0401485B RID: 84059
		[Nullable(2)]
		private TArray<EKooSharpBuildConfiguration> _EnableMonoStatForMethodTrace;

		// Token: 0x0401485C RID: 84060
		internal static int __PropertyOffset_MonoMethodTraceSkipClasses;

		// Token: 0x0401485D RID: 84061
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _MonoMethodTraceSkipClasses;

		// Token: 0x0401485E RID: 84062
		internal static int __PropertyOffset_EnableLogJitAddress;

		// Token: 0x0401485F RID: 84063
		[Nullable(2)]
		private TArray<EKooSharpBuildConfiguration> _EnableLogJitAddress;

		// Token: 0x04014860 RID: 84064
		internal static int __PropertyOffset_ExtraMonoOptions;

		// Token: 0x04014861 RID: 84065
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _ExtraMonoOptions;

		// Token: 0x04014862 RID: 84066
		internal static int __PropertyOffset_bEnableCSharpEnvironment;

		// Token: 0x04014863 RID: 84067
		internal static int __PropertyOffset_bUseMMapLoadDLL;

		// Token: 0x04014864 RID: 84068
		internal static int __PropertyOffset_ScriptProjectName;

		// Token: 0x04014865 RID: 84069
		internal static int __PropertyOffset_ScriptAssembliesPath;

		// Token: 0x04014866 RID: 84070
		internal static int __PropertyOffset_ScriptAssembliesEditorPath;

		// Token: 0x04014867 RID: 84071
		internal static int __PropertyOffset_ScriptAssembliesNonShippingPath;

		// Token: 0x04014868 RID: 84072
		internal static int __PropertyOffset_AOTAssembliesNonShippingPath;

		// Token: 0x04014869 RID: 84073
		internal static int __PropertyOffset_MonoAOTMode;

		// Token: 0x0401486A RID: 84074
		internal static int __PropertyOffset_bDisableNonClientAOTRegistration;

		// Token: 0x0401486B RID: 84075
		internal static int __PropertyOffset_bDisableClientAOTRegistration;

		// Token: 0x0401486C RID: 84076
		internal static int __PropertyOffset_EditorPreloadAssemblies;

		// Token: 0x0401486D RID: 84077
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _EditorPreloadAssemblies;

		// Token: 0x0401486E RID: 84078
		internal static int __PropertyOffset_RuntimeLoadAssemblies;

		// Token: 0x0401486F RID: 84079
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _RuntimeLoadAssemblies;

		// Token: 0x04014870 RID: 84080
		internal static int __PropertyOffset_DeferredRuntimeLoadAssemblies;

		// Token: 0x04014871 RID: 84081
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _DeferredRuntimeLoadAssemblies;

		// Token: 0x04014872 RID: 84082
		internal static int __PropertyOffset_GameAssemblies;

		// Token: 0x04014873 RID: 84083
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FSharpGameAssemblyConfig> _GameAssemblies;

		// Token: 0x04014874 RID: 84084
		internal static int __PropertyOffset_ExtraEnvironment;

		// Token: 0x04014875 RID: 84085
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _ExtraEnvironment;

		// Token: 0x04014876 RID: 84086
		internal static int __PropertyOffset_NoUseDangerousInternalCall;

		// Token: 0x04014877 RID: 84087
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _NoUseDangerousInternalCall;
	}
}
