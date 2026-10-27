using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001866 RID: 6246
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroGameBudget.KuroGameBudgetAllocatorCSharpInterface")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UKuroGameBudgetAllocatorCSharpInterface : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06016F97 RID: 94103 RVA: 0x0021832F File Offset: 0x0021652F
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroGameBudgetAllocatorCSharpInterface._ClassPtr;
		}

		// Token: 0x06016F98 RID: 94104 RVA: 0x0021833C File Offset: 0x0021653C
		public UKuroGameBudgetAllocatorCSharpInterface() : this(BuiltinUtils.AllocNativeUObject(UKuroGameBudgetAllocatorCSharpInterface.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06016F99 RID: 94105 RVA: 0x00218364 File Offset: 0x00216564
		[NullableContext(1)]
		public UKuroGameBudgetAllocatorCSharpInterface(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroGameBudgetAllocatorCSharpInterface.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06016F9A RID: 94106 RVA: 0x00218398 File Offset: 0x00216598
		public unsafe static void UpdatePerformanceActor(in FName GroupName, uint Token, AActor Actor)
		{
			fixed (FName* ptr = &GroupName)
			{
				void* ptr2 = (void*)ptr;
				UKuroGameBudgetAllocatorCSharpInterface.__UpdatePerformanceActor_Internal(GroupName, Token, (Actor != null) ? Actor.NativePtr : IntPtr.Zero);
			}
		}

		// Token: 0x06016F9B RID: 94107
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void UpdateMinUpdateFIFOBudgetTime(float Time);

		// Token: 0x06016F9C RID: 94108 RVA: 0x002183C4 File Offset: 0x002165C4
		public unsafe static void UpdateActor(in FName GroupName, uint Token, AActor Actor)
		{
			fixed (FName* ptr = &GroupName)
			{
				void* ptr2 = (void*)ptr;
				UKuroGameBudgetAllocatorCSharpInterface.__UpdateActor_Internal(GroupName, Token, (Actor != null) ? Actor.NativePtr : IntPtr.Zero);
			}
		}

		// Token: 0x06016F9D RID: 94109
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void UnregisterFunction(uint Token);

		// Token: 0x06016F9E RID: 94110
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void TickOutside(float DeltaSeconds);

		// Token: 0x06016F9F RID: 94111
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetUseWasRecentlyPassVisibilityTest(in FName GroupTag, uint Token, bool InUseWasRecentlyPassVisibilityTest);

		// Token: 0x06016FA0 RID: 94112
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetUsePerformanceActorCalculateBounds(in FName GroupName, uint Token, bool UseBoundsCalculateDistance);

		// Token: 0x06016FA1 RID: 94113
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetUseBoundsCalculateDistance(in FName GroupName, uint Token, bool UseBoundsCalculateDistance);

		// Token: 0x06016FA2 RID: 94114
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetUpdateCompensateEnable(bool Enabled);

		// Token: 0x06016FA3 RID: 94115 RVA: 0x002183F0 File Offset: 0x002165F0
		public static void SetTickIntervalDetailScreenRadiusConfig(ref FGameBudgetAllocatorGroupConfig Config, EGameBudgetAllocatorGlobalMode GlobalMode, EGameBudgetAllocatorActorMode ActorModel, float TickReductionStartScreenRatio, float TickReductionIntervalScreenRatio)
		{
			UKuroGameBudgetAllocatorCSharpInterface.__SetTickIntervalDetailScreenRadiusConfig_Internal((Config ?? new FGameBudgetAllocatorGroupConfig()).NativePtr, GlobalMode, ActorModel, TickReductionStartScreenRatio, TickReductionIntervalScreenRatio);
		}

		// Token: 0x06016FA4 RID: 94116 RVA: 0x0021840C File Offset: 0x0021660C
		public static void SetTickIntervalDetailConfig(ref FGameBudgetAllocatorGroupConfig Config, EGameBudgetAllocatorGlobalMode GlobalMode, EGameBudgetAllocatorActorMode ActorModel, uint MaxTickInterval, uint TickReductionStartSize, uint TickReductionIntervalSize)
		{
			UKuroGameBudgetAllocatorCSharpInterface.__SetTickIntervalDetailConfig_Internal((Config ?? new FGameBudgetAllocatorGroupConfig()).NativePtr, GlobalMode, ActorModel, MaxTickInterval, TickReductionStartSize, TickReductionIntervalSize);
		}

		// Token: 0x06016FA5 RID: 94117
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetPauseFrame(ulong Frame);

		// Token: 0x06016FA6 RID: 94118
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetMaximumFrameRate(uint MaxFPS);

		// Token: 0x06016FA7 RID: 94119 RVA: 0x0021842C File Offset: 0x0021662C
		public unsafe static void SetGroupConfig(in FName GroupName, in FGameBudgetAllocatorGroupConfig GroupConfig)
		{
			fixed (FName* ptr = &GroupName)
			{
				void* ptr2 = (void*)ptr;
				UKuroGameBudgetAllocatorCSharpInterface.__SetGroupConfig_Internal(GroupName, (GroupConfig ?? new FGameBudgetAllocatorGroupConfig()).NativePtr);
			}
		}

		// Token: 0x06016FA8 RID: 94120
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetGlobalMode(EGameBudgetAllocatorGlobalMode GlobalMode);

		// Token: 0x06016FA9 RID: 94121
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetGlobalCavernMode(EActorCavernMode GlobalMode);

		// Token: 0x06016FAA RID: 94122
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetDisableAssistantCenterActor(bool InValue);

		// Token: 0x06016FAB RID: 94123 RVA: 0x00218457 File Offset: 0x00216657
		public static void SetDefaultTickIntervalDetailScreenRadiusConfig(ref FGameBudgetAllocatorGroupConfig Config, float TickReductionStartScreenRatio, float TickReductionIntervalScreenRatio)
		{
			UKuroGameBudgetAllocatorCSharpInterface.__SetDefaultTickIntervalDetailScreenRadiusConfig_Internal((Config ?? new FGameBudgetAllocatorGroupConfig()).NativePtr, TickReductionStartScreenRatio, TickReductionIntervalScreenRatio);
		}

		// Token: 0x06016FAC RID: 94124 RVA: 0x00218470 File Offset: 0x00216670
		public static void SetDefaultTickIntervalDetailConfig(ref FGameBudgetAllocatorGroupConfig Config, uint MaxTickInterval, uint TickReductionStartSize, uint TickReductionIntervalSize)
		{
			UKuroGameBudgetAllocatorCSharpInterface.__SetDefaultTickIntervalDetailConfig_Internal((Config ?? new FGameBudgetAllocatorGroupConfig()).NativePtr, MaxTickInterval, TickReductionStartSize, TickReductionIntervalSize);
		}

		// Token: 0x06016FAD RID: 94125
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetConstantTick(in FName GroupTag, uint Token, bool InConstantTick, bool InReduceWhenInvisible);

		// Token: 0x06016FAE RID: 94126
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetCenterActorLocationOffset(in FVectorDouble Offset);

		// Token: 0x06016FAF RID: 94127 RVA: 0x0021848A File Offset: 0x0021668A
		public static void SetCenterActor(AActor Actor)
		{
			UKuroGameBudgetAllocatorCSharpInterface.__SetCenterActor_Internal((Actor != null) ? Actor.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06016FB0 RID: 94128
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetBudgetTime(float Time);

		// Token: 0x06016FB1 RID: 94129
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetActorCavernMode(in FName GroupName, uint Token, EActorCavernMode NewActorCavernMode);

		// Token: 0x06016FB2 RID: 94130 RVA: 0x002184A1 File Offset: 0x002166A1
		public static void RemoveAssistantActor(AActor AssistantActor)
		{
			UKuroGameBudgetAllocatorCSharpInterface.__RemoveAssistantActor_Internal((AssistantActor != null) ? AssistantActor.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06016FB3 RID: 94131
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void RegisterOnceTaskDefaultGroup(in FName GroupID, int Priority, int MaxWaitFrame);

		// Token: 0x06016FB4 RID: 94132
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void RegisterOnceTaskCustomGroup(in FName GroupId, int Priority);

		// Token: 0x06016FB5 RID: 94133
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void MarkActorInFighting(in FName GroupName, uint Token, bool IsInFighting);

		// Token: 0x06016FB6 RID: 94134
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool IsEnvironmentValid();

		// Token: 0x06016FB7 RID: 94135 RVA: 0x002184B8 File Offset: 0x002166B8
		public static void InitializeEnvironment(UWorld World, bool OnlyCSharpEnvironment)
		{
			UKuroGameBudgetAllocatorCSharpInterface.__InitializeEnvironment_Internal((World != null) ? World.NativePtr : IntPtr.Zero, OnlyCSharpEnvironment);
		}

		// Token: 0x06016FB8 RID: 94136
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float GetLastFrameGameThreadConsumeTime();

		// Token: 0x06016FB9 RID: 94137 RVA: 0x002184D0 File Offset: 0x002166D0
		[NullableContext(1)]
		public static string GetGameBudgetDebugString(uint Token)
		{
			return FString.ToStringAndDeleteNativePtr(UKuroGameBudgetAllocatorCSharpInterface.__GetGameBudgetDebugString_Internal(Token));
		}

		// Token: 0x06016FBA RID: 94138
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void DestroyEnvironment();

		// Token: 0x06016FBB RID: 94139
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void ClearAssistantActors();

		// Token: 0x06016FBC RID: 94140
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void AfterTickOutside(float DeltaSeconds);

		// Token: 0x06016FBD RID: 94141 RVA: 0x002184DD File Offset: 0x002166DD
		public static void AddAssistantActor(AActor AssistantActor)
		{
			UKuroGameBudgetAllocatorCSharpInterface.__AddAssistantActor_Internal((AssistantActor != null) ? AssistantActor.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06016FBE RID: 94142
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UpdatePerformanceActor_Internal(in FName GroupName, uint Token, IntPtr Actor);

		// Token: 0x06016FBF RID: 94143
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UpdateActor_Internal(in FName GroupName, uint Token, IntPtr Actor);

		// Token: 0x06016FC0 RID: 94144
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetTickIntervalDetailScreenRadiusConfig_Internal(IntPtr Config, EGameBudgetAllocatorGlobalMode GlobalMode, EGameBudgetAllocatorActorMode ActorModel, float TickReductionStartScreenRatio, float TickReductionIntervalScreenRatio);

		// Token: 0x06016FC1 RID: 94145
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetTickIntervalDetailConfig_Internal(IntPtr Config, EGameBudgetAllocatorGlobalMode GlobalMode, EGameBudgetAllocatorActorMode ActorModel, uint MaxTickInterval, uint TickReductionStartSize, uint TickReductionIntervalSize);

		// Token: 0x06016FC2 RID: 94146
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetGroupConfig_Internal(in FName GroupName, IntPtr GroupConfig);

		// Token: 0x06016FC3 RID: 94147
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetDefaultTickIntervalDetailScreenRadiusConfig_Internal(IntPtr Config, float TickReductionStartScreenRatio, float TickReductionIntervalScreenRatio);

		// Token: 0x06016FC4 RID: 94148
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetDefaultTickIntervalDetailConfig_Internal(IntPtr Config, uint MaxTickInterval, uint TickReductionStartSize, uint TickReductionIntervalSize);

		// Token: 0x06016FC5 RID: 94149
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetCenterActor_Internal(IntPtr Actor);

		// Token: 0x06016FC6 RID: 94150
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RemoveAssistantActor_Internal(IntPtr AssistantActor);

		// Token: 0x06016FC7 RID: 94151
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __InitializeEnvironment_Internal(IntPtr World, bool OnlyCSharpEnvironment);

		// Token: 0x06016FC8 RID: 94152
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetGameBudgetDebugString_Internal(uint Token);

		// Token: 0x06016FC9 RID: 94153
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddAssistantActor_Internal(IntPtr AssistantActor);

		// Token: 0x06016FCA RID: 94154 RVA: 0x002184F4 File Offset: 0x002166F4
		static UKuroGameBudgetAllocatorCSharpInterface()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroGameBudget.KuroGameBudgetAllocatorCSharpInterface");
		}

		// Token: 0x06016FCB RID: 94155 RVA: 0x00218502 File Offset: 0x00216702
		protected UKuroGameBudgetAllocatorCSharpInterface(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400C7C0 RID: 51136
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroGameBudget.KuroGameBudgetAllocatorCSharpInterface";

		// Token: 0x0400C7C1 RID: 51137
		private static IntPtr _ClassPtr;

		// Token: 0x0400C7C2 RID: 51138
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
