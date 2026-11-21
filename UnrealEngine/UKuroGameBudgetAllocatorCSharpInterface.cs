using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000399 RID: 921
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroGameBudget.KuroGameBudgetAllocatorCSharpInterface")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UKuroGameBudgetAllocatorCSharpInterface : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06005B44 RID: 23364 RVA: 0x00080DF7 File Offset: 0x0007EFF7
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroGameBudgetAllocatorCSharpInterface._ClassPtr;
		}

		// Token: 0x06005B45 RID: 23365 RVA: 0x00080E04 File Offset: 0x0007F004
		public UKuroGameBudgetAllocatorCSharpInterface() : this(BuiltinUtils.AllocNativeUObject(UKuroGameBudgetAllocatorCSharpInterface.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06005B46 RID: 23366 RVA: 0x00080E2C File Offset: 0x0007F02C
		[NullableContext(1)]
		public UKuroGameBudgetAllocatorCSharpInterface(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroGameBudgetAllocatorCSharpInterface.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06005B47 RID: 23367 RVA: 0x00080E60 File Offset: 0x0007F060
		public unsafe static void UpdatePerformanceActor(in FName GroupName, uint Token, AActor Actor)
		{
			fixed (FName* ptr = &GroupName)
			{
				void* ptr2 = (void*)ptr;
				UKuroGameBudgetAllocatorCSharpInterface.__UpdatePerformanceActor_Internal(GroupName, Token, (Actor != null) ? Actor.NativePtr : IntPtr.Zero);
			}
		}

		// Token: 0x06005B48 RID: 23368
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void UpdateMinUpdateFIFOBudgetTime(float Time);

		// Token: 0x06005B49 RID: 23369 RVA: 0x00080E8C File Offset: 0x0007F08C
		public unsafe static void UpdateActor(in FName GroupName, uint Token, AActor Actor)
		{
			fixed (FName* ptr = &GroupName)
			{
				void* ptr2 = (void*)ptr;
				UKuroGameBudgetAllocatorCSharpInterface.__UpdateActor_Internal(GroupName, Token, (Actor != null) ? Actor.NativePtr : IntPtr.Zero);
			}
		}

		// Token: 0x06005B4A RID: 23370
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void UnregisterFunction(uint Token);

		// Token: 0x06005B4B RID: 23371
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void TickOutside(float DeltaSeconds);

		// Token: 0x06005B4C RID: 23372
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetUseWasRecentlyPassVisibilityTest(in FName GroupTag, uint Token, bool InUseWasRecentlyPassVisibilityTest);

		// Token: 0x06005B4D RID: 23373
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetUsePerformanceActorCalculateBounds(in FName GroupName, uint Token, bool UseBoundsCalculateDistance);

		// Token: 0x06005B4E RID: 23374
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetUseBoundsCalculateDistance(in FName GroupName, uint Token, bool UseBoundsCalculateDistance);

		// Token: 0x06005B4F RID: 23375
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetUpdateCompensateEnable(bool Enabled);

		// Token: 0x06005B50 RID: 23376 RVA: 0x00080EB8 File Offset: 0x0007F0B8
		public static void SetTickIntervalDetailScreenRadiusConfig(ref FGameBudgetAllocatorGroupConfig Config, EGameBudgetAllocatorGlobalMode GlobalMode, EGameBudgetAllocatorActorMode ActorModel, float TickReductionStartScreenRatio, float TickReductionIntervalScreenRatio)
		{
			UKuroGameBudgetAllocatorCSharpInterface.__SetTickIntervalDetailScreenRadiusConfig_Internal((Config ?? new FGameBudgetAllocatorGroupConfig()).NativePtr, GlobalMode, ActorModel, TickReductionStartScreenRatio, TickReductionIntervalScreenRatio);
		}

		// Token: 0x06005B51 RID: 23377 RVA: 0x00080ED4 File Offset: 0x0007F0D4
		public static void SetTickIntervalDetailConfig(ref FGameBudgetAllocatorGroupConfig Config, EGameBudgetAllocatorGlobalMode GlobalMode, EGameBudgetAllocatorActorMode ActorModel, uint MaxTickInterval, uint TickReductionStartSize, uint TickReductionIntervalSize)
		{
			UKuroGameBudgetAllocatorCSharpInterface.__SetTickIntervalDetailConfig_Internal((Config ?? new FGameBudgetAllocatorGroupConfig()).NativePtr, GlobalMode, ActorModel, MaxTickInterval, TickReductionStartSize, TickReductionIntervalSize);
		}

		// Token: 0x06005B52 RID: 23378
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetPauseFrame(ulong Frame);

		// Token: 0x06005B53 RID: 23379
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetMaximumFrameRate(uint MaxFPS);

		// Token: 0x06005B54 RID: 23380 RVA: 0x00080EF4 File Offset: 0x0007F0F4
		public unsafe static void SetGroupConfig(in FName GroupName, in FGameBudgetAllocatorGroupConfig GroupConfig)
		{
			fixed (FName* ptr = &GroupName)
			{
				void* ptr2 = (void*)ptr;
				UKuroGameBudgetAllocatorCSharpInterface.__SetGroupConfig_Internal(GroupName, (GroupConfig ?? new FGameBudgetAllocatorGroupConfig()).NativePtr);
			}
		}

		// Token: 0x06005B55 RID: 23381
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetGlobalMode(EGameBudgetAllocatorGlobalMode GlobalMode);

		// Token: 0x06005B56 RID: 23382
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetGlobalCavernMode(EActorCavernMode GlobalMode);

		// Token: 0x06005B57 RID: 23383
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetDisableAssistantCenterActor(bool InValue);

		// Token: 0x06005B58 RID: 23384 RVA: 0x00080F1F File Offset: 0x0007F11F
		public static void SetDefaultTickIntervalDetailScreenRadiusConfig(ref FGameBudgetAllocatorGroupConfig Config, float TickReductionStartScreenRatio, float TickReductionIntervalScreenRatio)
		{
			UKuroGameBudgetAllocatorCSharpInterface.__SetDefaultTickIntervalDetailScreenRadiusConfig_Internal((Config ?? new FGameBudgetAllocatorGroupConfig()).NativePtr, TickReductionStartScreenRatio, TickReductionIntervalScreenRatio);
		}

		// Token: 0x06005B59 RID: 23385 RVA: 0x00080F38 File Offset: 0x0007F138
		public static void SetDefaultTickIntervalDetailConfig(ref FGameBudgetAllocatorGroupConfig Config, uint MaxTickInterval, uint TickReductionStartSize, uint TickReductionIntervalSize)
		{
			UKuroGameBudgetAllocatorCSharpInterface.__SetDefaultTickIntervalDetailConfig_Internal((Config ?? new FGameBudgetAllocatorGroupConfig()).NativePtr, MaxTickInterval, TickReductionStartSize, TickReductionIntervalSize);
		}

		// Token: 0x06005B5A RID: 23386
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetConstantTick(in FName GroupTag, uint Token, bool InConstantTick, bool InReduceWhenInvisible);

		// Token: 0x06005B5B RID: 23387
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetCenterActorLocationOffset(in FVectorDouble Offset);

		// Token: 0x06005B5C RID: 23388 RVA: 0x00080F52 File Offset: 0x0007F152
		public static void SetCenterActor(AActor Actor)
		{
			UKuroGameBudgetAllocatorCSharpInterface.__SetCenterActor_Internal((Actor != null) ? Actor.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06005B5D RID: 23389
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetBudgetTime(float Time);

		// Token: 0x06005B5E RID: 23390
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetActorCavernMode(in FName GroupName, uint Token, EActorCavernMode NewActorCavernMode);

		// Token: 0x06005B5F RID: 23391 RVA: 0x00080F69 File Offset: 0x0007F169
		public static void RemoveAssistantActor(AActor AssistantActor)
		{
			UKuroGameBudgetAllocatorCSharpInterface.__RemoveAssistantActor_Internal((AssistantActor != null) ? AssistantActor.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06005B60 RID: 23392
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void RegisterOnceTaskDefaultGroup(in FName GroupID, int Priority, int MaxWaitFrame);

		// Token: 0x06005B61 RID: 23393
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void RegisterOnceTaskCustomGroup(in FName GroupId, int Priority);

		// Token: 0x06005B62 RID: 23394
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void MarkActorInFighting(in FName GroupName, uint Token, bool IsInFighting);

		// Token: 0x06005B63 RID: 23395
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool IsEnvironmentValid();

		// Token: 0x06005B64 RID: 23396 RVA: 0x00080F80 File Offset: 0x0007F180
		public static void InitializeEnvironment(UWorld World, bool OnlyCSharpEnvironment)
		{
			UKuroGameBudgetAllocatorCSharpInterface.__InitializeEnvironment_Internal((World != null) ? World.NativePtr : IntPtr.Zero, OnlyCSharpEnvironment);
		}

		// Token: 0x06005B65 RID: 23397
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float GetLastFrameGameThreadConsumeTime();

		// Token: 0x06005B66 RID: 23398 RVA: 0x00080F98 File Offset: 0x0007F198
		[NullableContext(1)]
		public static string GetGameBudgetDebugString(uint Token)
		{
			return FString.ToStringAndDeleteNativePtr(UKuroGameBudgetAllocatorCSharpInterface.__GetGameBudgetDebugString_Internal(Token));
		}

		// Token: 0x06005B67 RID: 23399
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void DestroyEnvironment();

		// Token: 0x06005B68 RID: 23400
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void ClearAssistantActors();

		// Token: 0x06005B69 RID: 23401
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void AfterTickOutside(float DeltaSeconds);

		// Token: 0x06005B6A RID: 23402 RVA: 0x00080FA5 File Offset: 0x0007F1A5
		public static void AddAssistantActor(AActor AssistantActor)
		{
			UKuroGameBudgetAllocatorCSharpInterface.__AddAssistantActor_Internal((AssistantActor != null) ? AssistantActor.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06005B6B RID: 23403
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UpdatePerformanceActor_Internal(in FName GroupName, uint Token, IntPtr Actor);

		// Token: 0x06005B6C RID: 23404
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UpdateActor_Internal(in FName GroupName, uint Token, IntPtr Actor);

		// Token: 0x06005B6D RID: 23405
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetTickIntervalDetailScreenRadiusConfig_Internal(IntPtr Config, EGameBudgetAllocatorGlobalMode GlobalMode, EGameBudgetAllocatorActorMode ActorModel, float TickReductionStartScreenRatio, float TickReductionIntervalScreenRatio);

		// Token: 0x06005B6E RID: 23406
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetTickIntervalDetailConfig_Internal(IntPtr Config, EGameBudgetAllocatorGlobalMode GlobalMode, EGameBudgetAllocatorActorMode ActorModel, uint MaxTickInterval, uint TickReductionStartSize, uint TickReductionIntervalSize);

		// Token: 0x06005B6F RID: 23407
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetGroupConfig_Internal(in FName GroupName, IntPtr GroupConfig);

		// Token: 0x06005B70 RID: 23408
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetDefaultTickIntervalDetailScreenRadiusConfig_Internal(IntPtr Config, float TickReductionStartScreenRatio, float TickReductionIntervalScreenRatio);

		// Token: 0x06005B71 RID: 23409
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetDefaultTickIntervalDetailConfig_Internal(IntPtr Config, uint MaxTickInterval, uint TickReductionStartSize, uint TickReductionIntervalSize);

		// Token: 0x06005B72 RID: 23410
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetCenterActor_Internal(IntPtr Actor);

		// Token: 0x06005B73 RID: 23411
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RemoveAssistantActor_Internal(IntPtr AssistantActor);

		// Token: 0x06005B74 RID: 23412
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __InitializeEnvironment_Internal(IntPtr World, bool OnlyCSharpEnvironment);

		// Token: 0x06005B75 RID: 23413
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetGameBudgetDebugString_Internal(uint Token);

		// Token: 0x06005B76 RID: 23414
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddAssistantActor_Internal(IntPtr AssistantActor);

		// Token: 0x06005B77 RID: 23415 RVA: 0x00080FBC File Offset: 0x0007F1BC
		static UKuroGameBudgetAllocatorCSharpInterface()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroGameBudget.KuroGameBudgetAllocatorCSharpInterface");
		}

		// Token: 0x06005B78 RID: 23416 RVA: 0x00080FCA File Offset: 0x0007F1CA
		protected UKuroGameBudgetAllocatorCSharpInterface(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04002619 RID: 9753
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroGameBudget.KuroGameBudgetAllocatorCSharpInterface";

		// Token: 0x0400261A RID: 9754
		private static IntPtr _ClassPtr;

		// Token: 0x0400261B RID: 9755
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
