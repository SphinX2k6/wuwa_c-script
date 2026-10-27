using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002267 RID: 8807
	[UnrealObjectPath("/Script/MagtModule.MagtAdaptivePerformance")]
	[UnrealStructLayout(304, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 304)]
	public class UMagtAdaptivePerformance : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06021769 RID: 137065 RVA: 0x00316993 File Offset: 0x00314B93
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMagtAdaptivePerformance._ClassPtr;
		}

		// Token: 0x0602176A RID: 137066 RVA: 0x003169A0 File Offset: 0x00314BA0
		public UMagtAdaptivePerformance() : this(BuiltinUtils.AllocNativeUObject(UMagtAdaptivePerformance.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602176B RID: 137067 RVA: 0x003169C8 File Offset: 0x00314BC8
		[NullableContext(1)]
		public UMagtAdaptivePerformance(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMagtAdaptivePerformance.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700821F RID: 33311
		// (get) Token: 0x0602176C RID: 137068 RVA: 0x003169FC File Offset: 0x00314BFC
		// (set) Token: 0x0602176D RID: 137069 RVA: 0x00316A35 File Offset: 0x00314C35
		[Nullable(1)]
		public FMagtAPOnScenarioChanged OnScenarioChanged
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FMagtAPOnScenarioChanged result;
				if ((result = this._OnScenarioChanged) == null)
				{
					result = (this._OnScenarioChanged = new FMagtAPOnScenarioChanged(base.NativePtr + (IntPtr)UMagtAdaptivePerformance.__PropertyOffset_OnScenarioChanged, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UMagtAdaptivePerformance.__PropertyOffset_OnScenarioChanged, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17008220 RID: 33312
		// (get) Token: 0x0602176E RID: 137070 RVA: 0x00316A58 File Offset: 0x00314C58
		// (set) Token: 0x0602176F RID: 137071 RVA: 0x00316A91 File Offset: 0x00314C91
		[Nullable(1)]
		public FMagtAPOnAdviceChanged OnAdviceChanged
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FMagtAPOnAdviceChanged result;
				if ((result = this._OnAdviceChanged) == null)
				{
					result = (this._OnAdviceChanged = new FMagtAPOnAdviceChanged(base.NativePtr + (IntPtr)UMagtAdaptivePerformance.__PropertyOffset_OnAdviceChanged, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UMagtAdaptivePerformance.__PropertyOffset_OnAdviceChanged, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17008221 RID: 33313
		// (get) Token: 0x06021770 RID: 137072 RVA: 0x00316AB4 File Offset: 0x00314CB4
		// (set) Token: 0x06021771 RID: 137073 RVA: 0x00316AED File Offset: 0x00314CED
		[Nullable(1)]
		public FMagtAPOnQualityGroupChanged OnQualityGroupChanged
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FMagtAPOnQualityGroupChanged result;
				if ((result = this._OnQualityGroupChanged) == null)
				{
					result = (this._OnQualityGroupChanged = new FMagtAPOnQualityGroupChanged(base.NativePtr + (IntPtr)UMagtAdaptivePerformance.__PropertyOffset_OnQualityGroupChanged, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UMagtAdaptivePerformance.__PropertyOffset_OnQualityGroupChanged, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17008222 RID: 33314
		// (get) Token: 0x06021772 RID: 137074 RVA: 0x00316B0E File Offset: 0x00314D0E
		// (set) Token: 0x06021773 RID: 137075 RVA: 0x00316B22 File Offset: 0x00314D22
		[Nullable(2)]
		public unsafe UMagtAdaptivePerformanceSettings Settings
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMagtAdaptivePerformanceSettings>(base.NativePtr / (IntPtr)sizeof(void*) + UMagtAdaptivePerformance.__PropertyOffset_Settings);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UMagtAdaptivePerformance.__PropertyOffset_Settings, value);
			}
		}

		// Token: 0x17008223 RID: 33315
		// (get) Token: 0x06021774 RID: 137076 RVA: 0x00316B37 File Offset: 0x00314D37
		// (set) Token: 0x06021775 RID: 137077 RVA: 0x00316B4B File Offset: 0x00314D4B
		[Nullable(2)]
		public unsafe UMagtAdaptivePerformanceSettings DefaultSettings
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMagtAdaptivePerformanceSettings>(base.NativePtr / (IntPtr)sizeof(void*) + UMagtAdaptivePerformance.__PropertyOffset_DefaultSettings);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UMagtAdaptivePerformance.__PropertyOffset_DefaultSettings, value);
			}
		}

		// Token: 0x06021776 RID: 137078 RVA: 0x00316B60 File Offset: 0x00314D60
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void StopAdaptiveControl()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMagtAdaptivePerformance.__StopAdaptiveControl_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06021777 RID: 137079 RVA: 0x00316B75 File Offset: 0x00314D75
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Stop()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMagtAdaptivePerformance.__Stop_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06021778 RID: 137080 RVA: 0x00316B8A File Offset: 0x00314D8A
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void StartAdaptiveControl()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMagtAdaptivePerformance.__StartAdaptiveControl_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06021779 RID: 137081 RVA: 0x00316BA0 File Offset: 0x00314DA0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool Start()
		{
			UMagtAdaptivePerformance.__Start_FunctionParams* ptr = stackalloc UMagtAdaptivePerformance.__Start_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UMagtAdaptivePerformance.__Start_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMagtAdaptivePerformance.__Start_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMagtAdaptivePerformance.__Start_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0602177A RID: 137082 RVA: 0x00316BE8 File Offset: 0x00314DE8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool SetQualityGroupLevel(FName GroupName, int Level)
		{
			UMagtAdaptivePerformance.__SetQualityGroupLevel_FunctionParams* ptr = stackalloc UMagtAdaptivePerformance.__SetQualityGroupLevel_FunctionParams[(UIntPtr)35] + 15L / (long)sizeof(UMagtAdaptivePerformance.__SetQualityGroupLevel_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMagtAdaptivePerformance.__SetQualityGroupLevel_NativeFunctionPtr, (void*)ptr, 1);
			ptr->GroupName = GroupName;
			ptr->Level = Level;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMagtAdaptivePerformance.__SetQualityGroupLevel_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0602177B RID: 137083 RVA: 0x00316C3C File Offset: 0x00314E3C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void ResetToDefault()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMagtAdaptivePerformance.__ResetToDefault_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602177C RID: 137084 RVA: 0x00316C54 File Offset: 0x00314E54
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool IsRunning()
		{
			UMagtAdaptivePerformance.__IsRunning_FunctionParams* ptr = stackalloc UMagtAdaptivePerformance.__IsRunning_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UMagtAdaptivePerformance.__IsRunning_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMagtAdaptivePerformance.__IsRunning_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMagtAdaptivePerformance.__IsRunning_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0602177D RID: 137085 RVA: 0x00316C9C File Offset: 0x00314E9C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool IsInitialized()
		{
			UMagtAdaptivePerformance.__IsInitialized_FunctionParams* ptr = stackalloc UMagtAdaptivePerformance.__IsInitialized_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UMagtAdaptivePerformance.__IsInitialized_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMagtAdaptivePerformance.__IsInitialized_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMagtAdaptivePerformance.__IsInitialized_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0602177E RID: 137086 RVA: 0x00316CE4 File Offset: 0x00314EE4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool IsInCooldown()
		{
			UMagtAdaptivePerformance.__IsInCooldown_FunctionParams* ptr = stackalloc UMagtAdaptivePerformance.__IsInCooldown_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UMagtAdaptivePerformance.__IsInCooldown_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMagtAdaptivePerformance.__IsInCooldown_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMagtAdaptivePerformance.__IsInCooldown_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0602177F RID: 137087 RVA: 0x00316D2C File Offset: 0x00314F2C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool InitializeWithDefaults()
		{
			UMagtAdaptivePerformance.__InitializeWithDefaults_FunctionParams* ptr = stackalloc UMagtAdaptivePerformance.__InitializeWithDefaults_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UMagtAdaptivePerformance.__InitializeWithDefaults_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMagtAdaptivePerformance.__InitializeWithDefaults_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMagtAdaptivePerformance.__InitializeWithDefaults_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06021780 RID: 137088 RVA: 0x00316D74 File Offset: 0x00314F74
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool Initialize(UMagtAdaptivePerformanceSettings InSettings)
		{
			UMagtAdaptivePerformance.__Initialize_FunctionParams* ptr = stackalloc UMagtAdaptivePerformance.__Initialize_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UMagtAdaptivePerformance.__Initialize_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMagtAdaptivePerformance.__Initialize_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InSettings = ((InSettings != null) ? InSettings.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMagtAdaptivePerformance.__Initialize_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06021781 RID: 137089 RVA: 0x00316DD0 File Offset: 0x00314FD0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe float GetRemainingCooldownTime()
		{
			UMagtAdaptivePerformance.__GetRemainingCooldownTime_FunctionParams* ptr = stackalloc UMagtAdaptivePerformance.__GetRemainingCooldownTime_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UMagtAdaptivePerformance.__GetRemainingCooldownTime_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMagtAdaptivePerformance.__GetRemainingCooldownTime_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMagtAdaptivePerformance.__GetRemainingCooldownTime_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06021782 RID: 137090 RVA: 0x00316E18 File Offset: 0x00315018
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe int GetQualityGroupLevel(FName GroupName)
		{
			UMagtAdaptivePerformance.__GetQualityGroupLevel_FunctionParams* ptr = stackalloc UMagtAdaptivePerformance.__GetQualityGroupLevel_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UMagtAdaptivePerformance.__GetQualityGroupLevel_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMagtAdaptivePerformance.__GetQualityGroupLevel_NativeFunctionPtr, (void*)ptr, 1);
			ptr->GroupName = GroupName;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMagtAdaptivePerformance.__GetQualityGroupLevel_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06021783 RID: 137091 RVA: 0x00316E68 File Offset: 0x00315068
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe EMagtAPScenario GetCurrentScenario()
		{
			UMagtAdaptivePerformance.__GetCurrentScenario_FunctionParams* ptr = stackalloc UMagtAdaptivePerformance.__GetCurrentScenario_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UMagtAdaptivePerformance.__GetCurrentScenario_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMagtAdaptivePerformance.__GetCurrentScenario_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMagtAdaptivePerformance.__GetCurrentScenario_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06021784 RID: 137092 RVA: 0x00316EB0 File Offset: 0x003150B0
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe FMagtAPPerfReport GetCurrentPerfReport()
		{
			UMagtAdaptivePerformance.__GetCurrentPerfReport_FunctionParams* ptr = stackalloc UMagtAdaptivePerformance.__GetCurrentPerfReport_FunctionParams[(UIntPtr)79] + 15L / (long)sizeof(UMagtAdaptivePerformance.__GetCurrentPerfReport_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMagtAdaptivePerformance.__GetCurrentPerfReport_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMagtAdaptivePerformance.__GetCurrentPerfReport_NativeFunctionPtr, (void*)ptr, 0);
			return new FMagtAPPerfReport(&ptr->__Result, true, true);
		}

		// Token: 0x06021785 RID: 137093 RVA: 0x00316F00 File Offset: 0x00315100
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe EMagtAPWorkloadAdvice GetCurrentAdvice()
		{
			UMagtAdaptivePerformance.__GetCurrentAdvice_FunctionParams* ptr = stackalloc UMagtAdaptivePerformance.__GetCurrentAdvice_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UMagtAdaptivePerformance.__GetCurrentAdvice_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMagtAdaptivePerformance.__GetCurrentAdvice_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMagtAdaptivePerformance.__GetCurrentAdvice_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06021786 RID: 137094 RVA: 0x00316F48 File Offset: 0x00315148
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe TMap<FName, int> GetAllQualityGroupLevels()
		{
			UMagtAdaptivePerformance.__GetAllQualityGroupLevels_FunctionParams* ptr = stackalloc UMagtAdaptivePerformance.__GetAllQualityGroupLevels_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UMagtAdaptivePerformance.__GetAllQualityGroupLevels_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMagtAdaptivePerformance.__GetAllQualityGroupLevels_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMagtAdaptivePerformance.__GetAllQualityGroupLevels_NativeFunctionPtr, (void*)ptr, 0);
			TMap<FName, int> result = new TMap<FName, int>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UMagtAdaptivePerformance.__GetAllQualityGroupLevels_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x06021787 RID: 137095 RVA: 0x00316FA8 File Offset: 0x003151A8
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static UMagtAdaptivePerformance Get()
		{
			UMagtAdaptivePerformance.__Get_FunctionParams* ptr = stackalloc UMagtAdaptivePerformance.__Get_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UMagtAdaptivePerformance.__Get_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMagtAdaptivePerformance.__Get_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(UMagtAdaptivePerformance._ClassDefaultObjectPtr, UMagtAdaptivePerformance.__Get_NativeFunctionPtr, (void*)ptr, 0);
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UMagtAdaptivePerformance>(ptr->__Result);
		}

		// Token: 0x06021788 RID: 137096 RVA: 0x00316FF2 File Offset: 0x003151F2
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void ForceEvaluation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMagtAdaptivePerformance.__ForceEvaluation_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06021789 RID: 137097 RVA: 0x00317008 File Offset: 0x00315208
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void ApplyScenario(EMagtAPScenario Scenario)
		{
			UMagtAdaptivePerformance.__ApplyScenario_FunctionParams* ptr = stackalloc UMagtAdaptivePerformance.__ApplyScenario_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UMagtAdaptivePerformance.__ApplyScenario_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMagtAdaptivePerformance.__ApplyScenario_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Scenario = Scenario;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMagtAdaptivePerformance.__ApplyScenario_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602178A RID: 137098 RVA: 0x0031704F File Offset: 0x0031524F
		static UMagtAdaptivePerformance()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MagtModule.MagtAdaptivePerformance");
		}

		// Token: 0x0602178B RID: 137099 RVA: 0x0031705D File Offset: 0x0031525D
		protected UMagtAdaptivePerformance(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011DD3 RID: 73171
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/MagtModule.MagtAdaptivePerformance";

		// Token: 0x04011DD4 RID: 73172
		private static IntPtr _ClassPtr;

		// Token: 0x04011DD5 RID: 73173
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011DD6 RID: 73174
		internal static int __PropertyOffset_OnScenarioChanged;

		// Token: 0x04011DD7 RID: 73175
		[Nullable(2)]
		private FMagtAPOnScenarioChanged _OnScenarioChanged;

		// Token: 0x04011DD8 RID: 73176
		internal static int __PropertyOffset_OnAdviceChanged;

		// Token: 0x04011DD9 RID: 73177
		[Nullable(2)]
		private FMagtAPOnAdviceChanged _OnAdviceChanged;

		// Token: 0x04011DDA RID: 73178
		internal static int __PropertyOffset_OnQualityGroupChanged;

		// Token: 0x04011DDB RID: 73179
		[Nullable(2)]
		private FMagtAPOnQualityGroupChanged _OnQualityGroupChanged;

		// Token: 0x04011DDC RID: 73180
		internal static int __PropertyOffset_Settings;

		// Token: 0x04011DDD RID: 73181
		internal static int __PropertyOffset_DefaultSettings;

		// Token: 0x04011DDE RID: 73182
		private static IntPtr __StopAdaptiveControl_NativeFunctionPtr;

		// Token: 0x04011DDF RID: 73183
		private static IntPtr __Stop_NativeFunctionPtr;

		// Token: 0x04011DE0 RID: 73184
		private static IntPtr __StartAdaptiveControl_NativeFunctionPtr;

		// Token: 0x04011DE1 RID: 73185
		private static IntPtr __Start_NativeFunctionPtr;

		// Token: 0x04011DE2 RID: 73186
		private static IntPtr __SetQualityGroupLevel_NativeFunctionPtr;

		// Token: 0x04011DE3 RID: 73187
		private static IntPtr __ResetToDefault_NativeFunctionPtr;

		// Token: 0x04011DE4 RID: 73188
		private static IntPtr __IsRunning_NativeFunctionPtr;

		// Token: 0x04011DE5 RID: 73189
		private static IntPtr __IsInitialized_NativeFunctionPtr;

		// Token: 0x04011DE6 RID: 73190
		private static IntPtr __IsInCooldown_NativeFunctionPtr;

		// Token: 0x04011DE7 RID: 73191
		private static IntPtr __InitializeWithDefaults_NativeFunctionPtr;

		// Token: 0x04011DE8 RID: 73192
		private static IntPtr __Initialize_NativeFunctionPtr;

		// Token: 0x04011DE9 RID: 73193
		private static IntPtr __GetRemainingCooldownTime_NativeFunctionPtr;

		// Token: 0x04011DEA RID: 73194
		private static IntPtr __GetQualityGroupLevel_NativeFunctionPtr;

		// Token: 0x04011DEB RID: 73195
		private static IntPtr __GetCurrentScenario_NativeFunctionPtr;

		// Token: 0x04011DEC RID: 73196
		private static IntPtr __GetCurrentPerfReport_NativeFunctionPtr;

		// Token: 0x04011DED RID: 73197
		private static IntPtr __GetCurrentAdvice_NativeFunctionPtr;

		// Token: 0x04011DEE RID: 73198
		private static IntPtr __GetAllQualityGroupLevels_NativeFunctionPtr;

		// Token: 0x04011DEF RID: 73199
		private static IntPtr __Get_NativeFunctionPtr;

		// Token: 0x04011DF0 RID: 73200
		private static IntPtr __ForceEvaluation_NativeFunctionPtr;

		// Token: 0x04011DF1 RID: 73201
		private static IntPtr __ApplyScenario_NativeFunctionPtr;

		// Token: 0x02003597 RID: 13719
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __Start_FunctionParams
		{
			// Token: 0x040175CB RID: 95691
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x02003598 RID: 13720
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 20)]
		protected ref struct __SetQualityGroupLevel_FunctionParams
		{
			// Token: 0x040175CC RID: 95692
			[FieldOffset(0)]
			public FName GroupName;

			// Token: 0x040175CD RID: 95693
			[FieldOffset(12)]
			public int Level;

			// Token: 0x040175CE RID: 95694
			[FieldOffset(16)]
			public bool __Result;
		}

		// Token: 0x02003599 RID: 13721
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __IsRunning_FunctionParams
		{
			// Token: 0x040175CF RID: 95695
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x0200359A RID: 13722
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __IsInitialized_FunctionParams
		{
			// Token: 0x040175D0 RID: 95696
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x0200359B RID: 13723
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __IsInCooldown_FunctionParams
		{
			// Token: 0x040175D1 RID: 95697
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x0200359C RID: 13724
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __InitializeWithDefaults_FunctionParams
		{
			// Token: 0x040175D2 RID: 95698
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x0200359D RID: 13725
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __Initialize_FunctionParams
		{
			// Token: 0x040175D3 RID: 95699
			[FieldOffset(0)]
			public IntPtr InSettings;

			// Token: 0x040175D4 RID: 95700
			[FieldOffset(8)]
			public bool __Result;
		}

		// Token: 0x0200359E RID: 13726
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __GetRemainingCooldownTime_FunctionParams
		{
			// Token: 0x040175D5 RID: 95701
			[FieldOffset(0)]
			public float __Result;
		}

		// Token: 0x0200359F RID: 13727
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetQualityGroupLevel_FunctionParams
		{
			// Token: 0x040175D6 RID: 95702
			[FieldOffset(0)]
			public FName GroupName;

			// Token: 0x040175D7 RID: 95703
			[FieldOffset(12)]
			public int __Result;
		}

		// Token: 0x020035A0 RID: 13728
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __GetCurrentScenario_FunctionParams
		{
			// Token: 0x040175D8 RID: 95704
			[FieldOffset(0)]
			public EMagtAPScenario __Result;
		}

		// Token: 0x020035A1 RID: 13729
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 64)]
		protected ref struct __GetCurrentPerfReport_FunctionParams
		{
			// Token: 0x040175D9 RID: 95705
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x020035A2 RID: 13730
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __GetCurrentAdvice_FunctionParams
		{
			// Token: 0x040175DA RID: 95706
			[FieldOffset(0)]
			public EMagtAPWorkloadAdvice __Result;
		}

		// Token: 0x020035A3 RID: 13731
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __GetAllQualityGroupLevels_FunctionParams
		{
			// Token: 0x040175DB RID: 95707
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x020035A4 RID: 13732
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __Get_FunctionParams
		{
			// Token: 0x040175DC RID: 95708
			[FieldOffset(0)]
			public IntPtr __Result;
		}

		// Token: 0x020035A5 RID: 13733
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __ApplyScenario_FunctionParams
		{
			// Token: 0x040175DD RID: 95709
			[FieldOffset(0)]
			public EMagtAPScenario Scenario;
		}
	}
}
