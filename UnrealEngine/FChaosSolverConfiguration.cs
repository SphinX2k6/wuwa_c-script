using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000457 RID: 1111
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Chaos.ChaosSolverConfiguration")]
	[UnrealStructLayout(104, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 104)]
	public class FChaosSolverConfiguration : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06003BE6 RID: 15334 RVA: 0x0005A4D8 File Offset: 0x000586D8
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FChaosSolverConfiguration._ScriptStructPtr != 0) ? FChaosSolverConfiguration._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Chaos.ChaosSolverConfiguration", ref FChaosSolverConfiguration._ScriptStructPtr);
		}

		// Token: 0x17000E75 RID: 3701
		// (get) Token: 0x06003BE7 RID: 15335 RVA: 0x0005A4FC File Offset: 0x000586FC
		// (set) Token: 0x06003BE8 RID: 15336 RVA: 0x0005A50C File Offset: 0x0005870C
		public unsafe int Iterations
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FChaosSolverConfiguration.__PropertyOffset_Iterations);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FChaosSolverConfiguration.__PropertyOffset_Iterations) = value;
			}
		}

		// Token: 0x17000E76 RID: 3702
		// (get) Token: 0x06003BE9 RID: 15337 RVA: 0x0005A51D File Offset: 0x0005871D
		// (set) Token: 0x06003BEA RID: 15338 RVA: 0x0005A52D File Offset: 0x0005872D
		public unsafe int CollisionPairIterations
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FChaosSolverConfiguration.__PropertyOffset_CollisionPairIterations);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FChaosSolverConfiguration.__PropertyOffset_CollisionPairIterations) = value;
			}
		}

		// Token: 0x17000E77 RID: 3703
		// (get) Token: 0x06003BEB RID: 15339 RVA: 0x0005A53E File Offset: 0x0005873E
		// (set) Token: 0x06003BEC RID: 15340 RVA: 0x0005A54E File Offset: 0x0005874E
		public unsafe int PushOutIterations
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FChaosSolverConfiguration.__PropertyOffset_PushOutIterations);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FChaosSolverConfiguration.__PropertyOffset_PushOutIterations) = value;
			}
		}

		// Token: 0x17000E78 RID: 3704
		// (get) Token: 0x06003BED RID: 15341 RVA: 0x0005A55F File Offset: 0x0005875F
		// (set) Token: 0x06003BEE RID: 15342 RVA: 0x0005A56F File Offset: 0x0005876F
		public unsafe int CollisionPushOutPairIterations
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FChaosSolverConfiguration.__PropertyOffset_CollisionPushOutPairIterations);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FChaosSolverConfiguration.__PropertyOffset_CollisionPushOutPairIterations) = value;
			}
		}

		// Token: 0x17000E79 RID: 3705
		// (get) Token: 0x06003BEF RID: 15343 RVA: 0x0005A580 File Offset: 0x00058780
		// (set) Token: 0x06003BF0 RID: 15344 RVA: 0x0005A590 File Offset: 0x00058790
		public unsafe float CollisionMarginFraction
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FChaosSolverConfiguration.__PropertyOffset_CollisionMarginFraction);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FChaosSolverConfiguration.__PropertyOffset_CollisionMarginFraction) = value;
			}
		}

		// Token: 0x17000E7A RID: 3706
		// (get) Token: 0x06003BF1 RID: 15345 RVA: 0x0005A5A1 File Offset: 0x000587A1
		// (set) Token: 0x06003BF2 RID: 15346 RVA: 0x0005A5B1 File Offset: 0x000587B1
		public unsafe float CollisionMarginMax
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FChaosSolverConfiguration.__PropertyOffset_CollisionMarginMax);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FChaosSolverConfiguration.__PropertyOffset_CollisionMarginMax) = value;
			}
		}

		// Token: 0x17000E7B RID: 3707
		// (get) Token: 0x06003BF3 RID: 15347 RVA: 0x0005A5C2 File Offset: 0x000587C2
		// (set) Token: 0x06003BF4 RID: 15348 RVA: 0x0005A5D2 File Offset: 0x000587D2
		public unsafe float CollisionCullDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FChaosSolverConfiguration.__PropertyOffset_CollisionCullDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FChaosSolverConfiguration.__PropertyOffset_CollisionCullDistance) = value;
			}
		}

		// Token: 0x17000E7C RID: 3708
		// (get) Token: 0x06003BF5 RID: 15349 RVA: 0x0005A5E3 File Offset: 0x000587E3
		// (set) Token: 0x06003BF6 RID: 15350 RVA: 0x0005A5F3 File Offset: 0x000587F3
		public unsafe int JointPairIterations
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FChaosSolverConfiguration.__PropertyOffset_JointPairIterations);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FChaosSolverConfiguration.__PropertyOffset_JointPairIterations) = value;
			}
		}

		// Token: 0x17000E7D RID: 3709
		// (get) Token: 0x06003BF7 RID: 15351 RVA: 0x0005A604 File Offset: 0x00058804
		// (set) Token: 0x06003BF8 RID: 15352 RVA: 0x0005A614 File Offset: 0x00058814
		public unsafe int JointPushOutPairIterations
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FChaosSolverConfiguration.__PropertyOffset_JointPushOutPairIterations);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FChaosSolverConfiguration.__PropertyOffset_JointPushOutPairIterations) = value;
			}
		}

		// Token: 0x17000E7E RID: 3710
		// (get) Token: 0x06003BF9 RID: 15353 RVA: 0x0005A625 File Offset: 0x00058825
		// (set) Token: 0x06003BFA RID: 15354 RVA: 0x0005A635 File Offset: 0x00058835
		public unsafe float ClusterConnectionFactor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FChaosSolverConfiguration.__PropertyOffset_ClusterConnectionFactor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FChaosSolverConfiguration.__PropertyOffset_ClusterConnectionFactor) = value;
			}
		}

		// Token: 0x17000E7F RID: 3711
		// (get) Token: 0x06003BFB RID: 15355 RVA: 0x0005A646 File Offset: 0x00058846
		// (set) Token: 0x06003BFC RID: 15356 RVA: 0x0005A656 File Offset: 0x00058856
		public unsafe EClusterUnionMethod ClusterUnionConnectionType
		{
			get
			{
				return (EClusterUnionMethod)(*(base.NativePtr + (IntPtr)FChaosSolverConfiguration.__PropertyOffset_ClusterUnionConnectionType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FChaosSolverConfiguration.__PropertyOffset_ClusterUnionConnectionType) = (byte)value;
			}
		}

		// Token: 0x17000E80 RID: 3712
		// (get) Token: 0x06003BFD RID: 15357 RVA: 0x0005A667 File Offset: 0x00058867
		// (set) Token: 0x06003BFE RID: 15358 RVA: 0x0005A677 File Offset: 0x00058877
		public unsafe bool bGenerateCollisionData
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FChaosSolverConfiguration.__PropertyOffset_bGenerateCollisionData) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FChaosSolverConfiguration.__PropertyOffset_bGenerateCollisionData) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000E81 RID: 3713
		// (get) Token: 0x06003BFF RID: 15359 RVA: 0x0005A688 File Offset: 0x00058888
		// (set) Token: 0x06003C00 RID: 15360 RVA: 0x0005A6CB File Offset: 0x000588CB
		public FSolverCollisionFilterSettings CollisionFilterSettings
		{
			get
			{
				base.FastCheckIsValid();
				FSolverCollisionFilterSettings result;
				if ((result = this._CollisionFilterSettings) == null)
				{
					result = (this._CollisionFilterSettings = new FSolverCollisionFilterSettings(base.NativePtr + (IntPtr)FChaosSolverConfiguration.__PropertyOffset_CollisionFilterSettings, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSolverCollisionFilterSettings.StaticStruct(), base.NativePtr + (IntPtr)FChaosSolverConfiguration.__PropertyOffset_CollisionFilterSettings, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000E82 RID: 3714
		// (get) Token: 0x06003C01 RID: 15361 RVA: 0x0005A6EC File Offset: 0x000588EC
		// (set) Token: 0x06003C02 RID: 15362 RVA: 0x0005A6FC File Offset: 0x000588FC
		public unsafe bool bGenerateBreakData
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FChaosSolverConfiguration.__PropertyOffset_bGenerateBreakData) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FChaosSolverConfiguration.__PropertyOffset_bGenerateBreakData) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000E83 RID: 3715
		// (get) Token: 0x06003C03 RID: 15363 RVA: 0x0005A710 File Offset: 0x00058910
		// (set) Token: 0x06003C04 RID: 15364 RVA: 0x0005A753 File Offset: 0x00058953
		public FSolverBreakingFilterSettings BreakingFilterSettings
		{
			get
			{
				base.FastCheckIsValid();
				FSolverBreakingFilterSettings result;
				if ((result = this._BreakingFilterSettings) == null)
				{
					result = (this._BreakingFilterSettings = new FSolverBreakingFilterSettings(base.NativePtr + (IntPtr)FChaosSolverConfiguration.__PropertyOffset_BreakingFilterSettings, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSolverBreakingFilterSettings.StaticStruct(), base.NativePtr + (IntPtr)FChaosSolverConfiguration.__PropertyOffset_BreakingFilterSettings, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000E84 RID: 3716
		// (get) Token: 0x06003C05 RID: 15365 RVA: 0x0005A774 File Offset: 0x00058974
		// (set) Token: 0x06003C06 RID: 15366 RVA: 0x0005A784 File Offset: 0x00058984
		public unsafe bool bGenerateTrailingData
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FChaosSolverConfiguration.__PropertyOffset_bGenerateTrailingData) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FChaosSolverConfiguration.__PropertyOffset_bGenerateTrailingData) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000E85 RID: 3717
		// (get) Token: 0x06003C07 RID: 15367 RVA: 0x0005A798 File Offset: 0x00058998
		// (set) Token: 0x06003C08 RID: 15368 RVA: 0x0005A7DB File Offset: 0x000589DB
		public FSolverTrailingFilterSettings TrailingFilterSettings
		{
			get
			{
				base.FastCheckIsValid();
				FSolverTrailingFilterSettings result;
				if ((result = this._TrailingFilterSettings) == null)
				{
					result = (this._TrailingFilterSettings = new FSolverTrailingFilterSettings(base.NativePtr + (IntPtr)FChaosSolverConfiguration.__PropertyOffset_TrailingFilterSettings, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSolverTrailingFilterSettings.StaticStruct(), base.NativePtr + (IntPtr)FChaosSolverConfiguration.__PropertyOffset_TrailingFilterSettings, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000E86 RID: 3718
		// (get) Token: 0x06003C09 RID: 15369 RVA: 0x0005A7FC File Offset: 0x000589FC
		// (set) Token: 0x06003C0A RID: 15370 RVA: 0x0005A80C File Offset: 0x00058A0C
		public unsafe bool bGenerateContactGraph
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FChaosSolverConfiguration.__PropertyOffset_bGenerateContactGraph) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FChaosSolverConfiguration.__PropertyOffset_bGenerateContactGraph) = (value ? 1 : 0);
			}
		}

		// Token: 0x06003C0B RID: 15371 RVA: 0x0005A81D File Offset: 0x00058A1D
		public FChaosSolverConfiguration()
		{
		}

		// Token: 0x06003C0C RID: 15372 RVA: 0x0005A828 File Offset: 0x00058A28
		public FChaosSolverConfiguration(int Iterations, int CollisionPairIterations, int PushOutIterations, int CollisionPushOutPairIterations, float CollisionMarginFraction, float CollisionMarginMax, float CollisionCullDistance, int JointPairIterations, int JointPushOutPairIterations, float ClusterConnectionFactor, EClusterUnionMethod ClusterUnionConnectionType, bool bGenerateCollisionData, FSolverCollisionFilterSettings CollisionFilterSettings, bool bGenerateBreakData, FSolverBreakingFilterSettings BreakingFilterSettings, bool bGenerateTrailingData, FSolverTrailingFilterSettings TrailingFilterSettings, bool bGenerateContactGraph)
		{
			this.Iterations = Iterations;
			this.CollisionPairIterations = CollisionPairIterations;
			this.PushOutIterations = PushOutIterations;
			this.CollisionPushOutPairIterations = CollisionPushOutPairIterations;
			this.CollisionMarginFraction = CollisionMarginFraction;
			this.CollisionMarginMax = CollisionMarginMax;
			this.CollisionCullDistance = CollisionCullDistance;
			this.JointPairIterations = JointPairIterations;
			this.JointPushOutPairIterations = JointPushOutPairIterations;
			this.ClusterConnectionFactor = ClusterConnectionFactor;
			this.ClusterUnionConnectionType = ClusterUnionConnectionType;
			this.bGenerateCollisionData = bGenerateCollisionData;
			this.CollisionFilterSettings = CollisionFilterSettings;
			this.bGenerateBreakData = bGenerateBreakData;
			this.BreakingFilterSettings = BreakingFilterSettings;
			this.bGenerateTrailingData = bGenerateTrailingData;
			this.TrailingFilterSettings = TrailingFilterSettings;
			this.bGenerateContactGraph = bGenerateContactGraph;
		}

		// Token: 0x06003C0D RID: 15373 RVA: 0x0005A8C8 File Offset: 0x00058AC8
		protected override IntPtr GetUStructPtr()
		{
			return FChaosSolverConfiguration.StaticStruct();
		}

		// Token: 0x06003C0E RID: 15374 RVA: 0x0005A8D4 File Offset: 0x00058AD4
		[NullableContext(2)]
		public FChaosSolverConfiguration(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06003C0F RID: 15375 RVA: 0x0005A8DE File Offset: 0x00058ADE
		public FChaosSolverConfiguration(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06003C10 RID: 15376 RVA: 0x0005A8E9 File Offset: 0x00058AE9
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FChaosSolverConfiguration(Pointer, false, true);
		}

		// Token: 0x06003C11 RID: 15377 RVA: 0x0005A8F3 File Offset: 0x00058AF3
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FChaosSolverConfiguration(Pointer, MemoryOwner);
		}

		// Token: 0x04001BA0 RID: 7072
		public const string __ObjectPath = "/Script/Chaos.ChaosSolverConfiguration";

		// Token: 0x04001BA1 RID: 7073
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04001BA2 RID: 7074
		internal static int __PropertyOffset_Iterations;

		// Token: 0x04001BA3 RID: 7075
		internal static int __PropertyOffset_CollisionPairIterations;

		// Token: 0x04001BA4 RID: 7076
		internal static int __PropertyOffset_PushOutIterations;

		// Token: 0x04001BA5 RID: 7077
		internal static int __PropertyOffset_CollisionPushOutPairIterations;

		// Token: 0x04001BA6 RID: 7078
		internal static int __PropertyOffset_CollisionMarginFraction;

		// Token: 0x04001BA7 RID: 7079
		internal static int __PropertyOffset_CollisionMarginMax;

		// Token: 0x04001BA8 RID: 7080
		internal static int __PropertyOffset_CollisionCullDistance;

		// Token: 0x04001BA9 RID: 7081
		internal static int __PropertyOffset_JointPairIterations;

		// Token: 0x04001BAA RID: 7082
		internal static int __PropertyOffset_JointPushOutPairIterations;

		// Token: 0x04001BAB RID: 7083
		internal static int __PropertyOffset_ClusterConnectionFactor;

		// Token: 0x04001BAC RID: 7084
		internal static int __PropertyOffset_ClusterUnionConnectionType;

		// Token: 0x04001BAD RID: 7085
		internal static int __PropertyOffset_bGenerateCollisionData;

		// Token: 0x04001BAE RID: 7086
		internal static int __PropertyOffset_CollisionFilterSettings;

		// Token: 0x04001BAF RID: 7087
		[Nullable(2)]
		private FSolverCollisionFilterSettings _CollisionFilterSettings;

		// Token: 0x04001BB0 RID: 7088
		internal static int __PropertyOffset_bGenerateBreakData;

		// Token: 0x04001BB1 RID: 7089
		internal static int __PropertyOffset_BreakingFilterSettings;

		// Token: 0x04001BB2 RID: 7090
		[Nullable(2)]
		private FSolverBreakingFilterSettings _BreakingFilterSettings;

		// Token: 0x04001BB3 RID: 7091
		internal static int __PropertyOffset_bGenerateTrailingData;

		// Token: 0x04001BB4 RID: 7092
		internal static int __PropertyOffset_TrailingFilterSettings;

		// Token: 0x04001BB5 RID: 7093
		[Nullable(2)]
		private FSolverTrailingFilterSettings _TrailingFilterSettings;

		// Token: 0x04001BB6 RID: 7094
		internal static int __PropertyOffset_bGenerateContactGraph;
	}
}
