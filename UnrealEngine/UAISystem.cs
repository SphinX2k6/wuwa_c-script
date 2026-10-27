using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000114 RID: 276
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AIModule.AISystem")]
	[UnrealStructLayout(344, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 344)]
	public class UAISystem : UAISystemBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06001454 RID: 5204 RVA: 0x0001DF7F File Offset: 0x0001C17F
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAISystem._ClassPtr;
		}

		// Token: 0x06001455 RID: 5205 RVA: 0x0001DF8C File Offset: 0x0001C18C
		public UAISystem() : this(BuiltinUtils.AllocNativeUObject(UAISystem.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06001456 RID: 5206 RVA: 0x0001DFB4 File Offset: 0x0001C1B4
		[NullableContext(1)]
		public UAISystem(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAISystem.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17000572 RID: 1394
		// (get) Token: 0x06001457 RID: 5207 RVA: 0x0001DFE8 File Offset: 0x0001C1E8
		// (set) Token: 0x06001458 RID: 5208 RVA: 0x0001E021 File Offset: 0x0001C221
		[Nullable(1)]
		public FSoftClassPath PerceptionSystemClassName
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FSoftClassPath result;
				if ((result = this._PerceptionSystemClassName) == null)
				{
					result = (this._PerceptionSystemClassName = new FSoftClassPath(base.NativePtr + (IntPtr)UAISystem.__PropertyOffset_PerceptionSystemClassName, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoftClassPath.StaticStruct(), base.NativePtr + (IntPtr)UAISystem.__PropertyOffset_PerceptionSystemClassName, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000573 RID: 1395
		// (get) Token: 0x06001459 RID: 5209 RVA: 0x0001E044 File Offset: 0x0001C244
		// (set) Token: 0x0600145A RID: 5210 RVA: 0x0001E07D File Offset: 0x0001C27D
		[Nullable(1)]
		public FSoftClassPath HotSpotManagerClassName
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FSoftClassPath result;
				if ((result = this._HotSpotManagerClassName) == null)
				{
					result = (this._HotSpotManagerClassName = new FSoftClassPath(base.NativePtr + (IntPtr)UAISystem.__PropertyOffset_HotSpotManagerClassName, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoftClassPath.StaticStruct(), base.NativePtr + (IntPtr)UAISystem.__PropertyOffset_HotSpotManagerClassName, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000574 RID: 1396
		// (get) Token: 0x0600145B RID: 5211 RVA: 0x0001E09E File Offset: 0x0001C29E
		// (set) Token: 0x0600145C RID: 5212 RVA: 0x0001E0AE File Offset: 0x0001C2AE
		public unsafe float AcceptanceRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAISystem.__PropertyOffset_AcceptanceRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAISystem.__PropertyOffset_AcceptanceRadius) = value;
			}
		}

		// Token: 0x17000575 RID: 1397
		// (get) Token: 0x0600145D RID: 5213 RVA: 0x0001E0BF File Offset: 0x0001C2BF
		// (set) Token: 0x0600145E RID: 5214 RVA: 0x0001E0CF File Offset: 0x0001C2CF
		public unsafe float PathfollowingRegularPathPointAcceptanceRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAISystem.__PropertyOffset_PathfollowingRegularPathPointAcceptanceRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAISystem.__PropertyOffset_PathfollowingRegularPathPointAcceptanceRadius) = value;
			}
		}

		// Token: 0x17000576 RID: 1398
		// (get) Token: 0x0600145F RID: 5215 RVA: 0x0001E0E0 File Offset: 0x0001C2E0
		// (set) Token: 0x06001460 RID: 5216 RVA: 0x0001E0F0 File Offset: 0x0001C2F0
		public unsafe float PathfollowingNavLinkAcceptanceRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAISystem.__PropertyOffset_PathfollowingNavLinkAcceptanceRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAISystem.__PropertyOffset_PathfollowingNavLinkAcceptanceRadius) = value;
			}
		}

		// Token: 0x17000577 RID: 1399
		// (get) Token: 0x06001461 RID: 5217 RVA: 0x0001E101 File Offset: 0x0001C301
		// (set) Token: 0x06001462 RID: 5218 RVA: 0x0001E111 File Offset: 0x0001C311
		public unsafe bool bFinishMoveOnGoalOverlap
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAISystem.__PropertyOffset_bFinishMoveOnGoalOverlap) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAISystem.__PropertyOffset_bFinishMoveOnGoalOverlap) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000578 RID: 1400
		// (get) Token: 0x06001463 RID: 5219 RVA: 0x0001E122 File Offset: 0x0001C322
		// (set) Token: 0x06001464 RID: 5220 RVA: 0x0001E132 File Offset: 0x0001C332
		public unsafe bool bAcceptPartialPaths
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAISystem.__PropertyOffset_bAcceptPartialPaths) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAISystem.__PropertyOffset_bAcceptPartialPaths) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000579 RID: 1401
		// (get) Token: 0x06001465 RID: 5221 RVA: 0x0001E143 File Offset: 0x0001C343
		// (set) Token: 0x06001466 RID: 5222 RVA: 0x0001E153 File Offset: 0x0001C353
		public unsafe bool bAllowStrafing
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAISystem.__PropertyOffset_bAllowStrafing) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAISystem.__PropertyOffset_bAllowStrafing) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700057A RID: 1402
		// (get) Token: 0x06001467 RID: 5223 RVA: 0x0001E164 File Offset: 0x0001C364
		// (set) Token: 0x06001468 RID: 5224 RVA: 0x0001E174 File Offset: 0x0001C374
		public unsafe bool bEnableBTAITasks
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAISystem.__PropertyOffset_bEnableBTAITasks) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAISystem.__PropertyOffset_bEnableBTAITasks) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700057B RID: 1403
		// (get) Token: 0x06001469 RID: 5225 RVA: 0x0001E185 File Offset: 0x0001C385
		// (set) Token: 0x0600146A RID: 5226 RVA: 0x0001E195 File Offset: 0x0001C395
		public unsafe bool bAllowControllersAsEQSQuerier
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAISystem.__PropertyOffset_bAllowControllersAsEQSQuerier) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAISystem.__PropertyOffset_bAllowControllersAsEQSQuerier) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700057C RID: 1404
		// (get) Token: 0x0600146B RID: 5227 RVA: 0x0001E1A6 File Offset: 0x0001C3A6
		// (set) Token: 0x0600146C RID: 5228 RVA: 0x0001E1B6 File Offset: 0x0001C3B6
		public unsafe bool bEnableDebuggerPlugin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAISystem.__PropertyOffset_bEnableDebuggerPlugin) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAISystem.__PropertyOffset_bEnableDebuggerPlugin) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700057D RID: 1405
		// (get) Token: 0x0600146D RID: 5229 RVA: 0x0001E1C7 File Offset: 0x0001C3C7
		// (set) Token: 0x0600146E RID: 5230 RVA: 0x0001E1D7 File Offset: 0x0001C3D7
		public unsafe bool bForgetStaleActors
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAISystem.__PropertyOffset_bForgetStaleActors) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAISystem.__PropertyOffset_bForgetStaleActors) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700057E RID: 1406
		// (get) Token: 0x0600146F RID: 5231 RVA: 0x0001E1E8 File Offset: 0x0001C3E8
		// (set) Token: 0x06001470 RID: 5232 RVA: 0x0001E1F8 File Offset: 0x0001C3F8
		public unsafe bool bAddBlackboardSelfKey
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAISystem.__PropertyOffset_bAddBlackboardSelfKey) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAISystem.__PropertyOffset_bAddBlackboardSelfKey) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700057F RID: 1407
		// (get) Token: 0x06001471 RID: 5233 RVA: 0x0001E209 File Offset: 0x0001C409
		// (set) Token: 0x06001472 RID: 5234 RVA: 0x0001E21D File Offset: 0x0001C41D
		[Nullable(0)]
		public unsafe TEnumAsByte<ECollisionChannel> DefaultSightCollisionChannel
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)UAISystem.__PropertyOffset_DefaultSightCollisionChannel);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)UAISystem.__PropertyOffset_DefaultSightCollisionChannel) = value;
			}
		}

		// Token: 0x17000580 RID: 1408
		// (get) Token: 0x06001473 RID: 5235 RVA: 0x0001E232 File Offset: 0x0001C432
		// (set) Token: 0x06001474 RID: 5236 RVA: 0x0001E246 File Offset: 0x0001C446
		public unsafe UBehaviorTreeManager BehaviorTreeManager
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBehaviorTreeManager>(base.NativePtr / (IntPtr)sizeof(void*) + UAISystem.__PropertyOffset_BehaviorTreeManager);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UAISystem.__PropertyOffset_BehaviorTreeManager, value);
			}
		}

		// Token: 0x17000581 RID: 1409
		// (get) Token: 0x06001475 RID: 5237 RVA: 0x0001E25B File Offset: 0x0001C45B
		// (set) Token: 0x06001476 RID: 5238 RVA: 0x0001E26F File Offset: 0x0001C46F
		public unsafe UEnvQueryManager EnvironmentQueryManager
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UEnvQueryManager>(base.NativePtr / (IntPtr)sizeof(void*) + UAISystem.__PropertyOffset_EnvironmentQueryManager);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UAISystem.__PropertyOffset_EnvironmentQueryManager, value);
			}
		}

		// Token: 0x17000582 RID: 1410
		// (get) Token: 0x06001477 RID: 5239 RVA: 0x0001E284 File Offset: 0x0001C484
		// (set) Token: 0x06001478 RID: 5240 RVA: 0x0001E298 File Offset: 0x0001C498
		public unsafe UAIPerceptionSystem PerceptionSystem
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAIPerceptionSystem>(base.NativePtr / (IntPtr)sizeof(void*) + UAISystem.__PropertyOffset_PerceptionSystem);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UAISystem.__PropertyOffset_PerceptionSystem, value);
			}
		}

		// Token: 0x17000583 RID: 1411
		// (get) Token: 0x06001479 RID: 5241 RVA: 0x0001E2B0 File Offset: 0x0001C4B0
		// (set) Token: 0x0600147A RID: 5242 RVA: 0x0001E2E9 File Offset: 0x0001C4E9
		[Nullable(1)]
		public TArray<UAIAsyncTaskBlueprintProxy> AllProxyObjects
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<UAIAsyncTaskBlueprintProxy> result;
				if ((result = this._AllProxyObjects) == null)
				{
					result = (this._AllProxyObjects = new TArray<UAIAsyncTaskBlueprintProxy>(base.NativePtr + (IntPtr)UAISystem.__PropertyOffset_AllProxyObjects, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.AllProxyObjects.CopyAssign(value);
			}
		}

		// Token: 0x17000584 RID: 1412
		// (get) Token: 0x0600147B RID: 5243 RVA: 0x0001E2F7 File Offset: 0x0001C4F7
		// (set) Token: 0x0600147C RID: 5244 RVA: 0x0001E30B File Offset: 0x0001C50B
		public unsafe UAIHotSpotManager HotSpotManager
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAIHotSpotManager>(base.NativePtr / (IntPtr)sizeof(void*) + UAISystem.__PropertyOffset_HotSpotManager);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UAISystem.__PropertyOffset_HotSpotManager, value);
			}
		}

		// Token: 0x17000585 RID: 1413
		// (get) Token: 0x0600147D RID: 5245 RVA: 0x0001E320 File Offset: 0x0001C520
		// (set) Token: 0x0600147E RID: 5246 RVA: 0x0001E334 File Offset: 0x0001C534
		public unsafe UNavLocalGridManager NavLocalGrids
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNavLocalGridManager>(base.NativePtr / (IntPtr)sizeof(void*) + UAISystem.__PropertyOffset_NavLocalGrids);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UAISystem.__PropertyOffset_NavLocalGrids, value);
			}
		}

		// Token: 0x0600147F RID: 5247 RVA: 0x0001E349 File Offset: 0x0001C549
		public void AILoggingVerbose()
		{
			UAISystem.__AILoggingVerbose_Internal(base.NativePtr);
		}

		// Token: 0x06001480 RID: 5248 RVA: 0x0001E356 File Offset: 0x0001C556
		public void AIIgnorePlayers()
		{
			UAISystem.__AIIgnorePlayers_Internal(base.NativePtr);
		}

		// Token: 0x06001481 RID: 5249
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AILoggingVerbose_Internal(IntPtr @this);

		// Token: 0x06001482 RID: 5250
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AIIgnorePlayers_Internal(IntPtr @this);

		// Token: 0x06001483 RID: 5251 RVA: 0x0001E363 File Offset: 0x0001C563
		static UAISystem()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AIModule.AISystem");
		}

		// Token: 0x06001484 RID: 5252 RVA: 0x0001E371 File Offset: 0x0001C571
		protected UAISystem(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400040A RID: 1034
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AIModule.AISystem";

		// Token: 0x0400040B RID: 1035
		private static IntPtr _ClassPtr;

		// Token: 0x0400040C RID: 1036
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400040D RID: 1037
		internal static int __PropertyOffset_PerceptionSystemClassName;

		// Token: 0x0400040E RID: 1038
		private FSoftClassPath _PerceptionSystemClassName;

		// Token: 0x0400040F RID: 1039
		internal static int __PropertyOffset_HotSpotManagerClassName;

		// Token: 0x04000410 RID: 1040
		private FSoftClassPath _HotSpotManagerClassName;

		// Token: 0x04000411 RID: 1041
		internal static int __PropertyOffset_AcceptanceRadius;

		// Token: 0x04000412 RID: 1042
		internal static int __PropertyOffset_PathfollowingRegularPathPointAcceptanceRadius;

		// Token: 0x04000413 RID: 1043
		internal static int __PropertyOffset_PathfollowingNavLinkAcceptanceRadius;

		// Token: 0x04000414 RID: 1044
		internal static int __PropertyOffset_bFinishMoveOnGoalOverlap;

		// Token: 0x04000415 RID: 1045
		internal static int __PropertyOffset_bAcceptPartialPaths;

		// Token: 0x04000416 RID: 1046
		internal static int __PropertyOffset_bAllowStrafing;

		// Token: 0x04000417 RID: 1047
		internal static int __PropertyOffset_bEnableBTAITasks;

		// Token: 0x04000418 RID: 1048
		internal static int __PropertyOffset_bAllowControllersAsEQSQuerier;

		// Token: 0x04000419 RID: 1049
		internal static int __PropertyOffset_bEnableDebuggerPlugin;

		// Token: 0x0400041A RID: 1050
		internal static int __PropertyOffset_bForgetStaleActors;

		// Token: 0x0400041B RID: 1051
		internal static int __PropertyOffset_bAddBlackboardSelfKey;

		// Token: 0x0400041C RID: 1052
		internal static int __PropertyOffset_DefaultSightCollisionChannel;

		// Token: 0x0400041D RID: 1053
		internal static int __PropertyOffset_BehaviorTreeManager;

		// Token: 0x0400041E RID: 1054
		internal static int __PropertyOffset_EnvironmentQueryManager;

		// Token: 0x0400041F RID: 1055
		internal static int __PropertyOffset_PerceptionSystem;

		// Token: 0x04000420 RID: 1056
		internal static int __PropertyOffset_AllProxyObjects;

		// Token: 0x04000421 RID: 1057
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UAIAsyncTaskBlueprintProxy> _AllProxyObjects;

		// Token: 0x04000422 RID: 1058
		internal static int __PropertyOffset_HotSpotManager;

		// Token: 0x04000423 RID: 1059
		internal static int __PropertyOffset_NavLocalGrids;
	}
}
