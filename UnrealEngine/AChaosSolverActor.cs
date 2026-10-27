using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000452 RID: 1106
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ChaosSolverEngine.ChaosSolverActor")]
	[UnrealStructLayout(1312, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1312)]
	public class AChaosSolverActor : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06003B9D RID: 15261 RVA: 0x00059D8A File Offset: 0x00057F8A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AChaosSolverActor._ClassPtr;
		}

		// Token: 0x06003B9E RID: 15262 RVA: 0x00059D98 File Offset: 0x00057F98
		public AChaosSolverActor() : this(BuiltinUtils.AllocNativeUObject(AChaosSolverActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06003B9F RID: 15263 RVA: 0x00059DC0 File Offset: 0x00057FC0
		public AChaosSolverActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AChaosSolverActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17000E60 RID: 3680
		// (get) Token: 0x06003BA0 RID: 15264 RVA: 0x00059DF4 File Offset: 0x00057FF4
		// (set) Token: 0x06003BA1 RID: 15265 RVA: 0x00059E2D File Offset: 0x0005802D
		public FChaosSolverConfiguration Properties
		{
			get
			{
				base.FastCheckIsValid();
				FChaosSolverConfiguration result;
				if ((result = this._Properties) == null)
				{
					result = (this._Properties = new FChaosSolverConfiguration(base.NativePtr + (IntPtr)AChaosSolverActor.__PropertyOffset_Properties, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FChaosSolverConfiguration.StaticStruct(), base.NativePtr + (IntPtr)AChaosSolverActor.__PropertyOffset_Properties, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000E61 RID: 3681
		// (get) Token: 0x06003BA2 RID: 15266 RVA: 0x00059E4E File Offset: 0x0005804E
		// (set) Token: 0x06003BA3 RID: 15267 RVA: 0x00059E5E File Offset: 0x0005805E
		public unsafe float TimeStepMultiplier_DEPRECATED
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AChaosSolverActor.__PropertyOffset_TimeStepMultiplier_DEPRECATED);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AChaosSolverActor.__PropertyOffset_TimeStepMultiplier_DEPRECATED) = value;
			}
		}

		// Token: 0x17000E62 RID: 3682
		// (get) Token: 0x06003BA4 RID: 15268 RVA: 0x00059E6F File Offset: 0x0005806F
		// (set) Token: 0x06003BA5 RID: 15269 RVA: 0x00059E7F File Offset: 0x0005807F
		public unsafe int CollisionIterations_DEPRECATED
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AChaosSolverActor.__PropertyOffset_CollisionIterations_DEPRECATED);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AChaosSolverActor.__PropertyOffset_CollisionIterations_DEPRECATED) = value;
			}
		}

		// Token: 0x17000E63 RID: 3683
		// (get) Token: 0x06003BA6 RID: 15270 RVA: 0x00059E90 File Offset: 0x00058090
		// (set) Token: 0x06003BA7 RID: 15271 RVA: 0x00059EA0 File Offset: 0x000580A0
		public unsafe int PushOutIterations_DEPRECATED
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AChaosSolverActor.__PropertyOffset_PushOutIterations_DEPRECATED);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AChaosSolverActor.__PropertyOffset_PushOutIterations_DEPRECATED) = value;
			}
		}

		// Token: 0x17000E64 RID: 3684
		// (get) Token: 0x06003BA8 RID: 15272 RVA: 0x00059EB1 File Offset: 0x000580B1
		// (set) Token: 0x06003BA9 RID: 15273 RVA: 0x00059EC1 File Offset: 0x000580C1
		public unsafe int PushOutPairIterations_DEPRECATED
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AChaosSolverActor.__PropertyOffset_PushOutPairIterations_DEPRECATED);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AChaosSolverActor.__PropertyOffset_PushOutPairIterations_DEPRECATED) = value;
			}
		}

		// Token: 0x17000E65 RID: 3685
		// (get) Token: 0x06003BAA RID: 15274 RVA: 0x00059ED2 File Offset: 0x000580D2
		// (set) Token: 0x06003BAB RID: 15275 RVA: 0x00059EE2 File Offset: 0x000580E2
		public unsafe float ClusterConnectionFactor_DEPRECATED
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AChaosSolverActor.__PropertyOffset_ClusterConnectionFactor_DEPRECATED);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AChaosSolverActor.__PropertyOffset_ClusterConnectionFactor_DEPRECATED) = value;
			}
		}

		// Token: 0x17000E66 RID: 3686
		// (get) Token: 0x06003BAC RID: 15276 RVA: 0x00059EF3 File Offset: 0x000580F3
		// (set) Token: 0x06003BAD RID: 15277 RVA: 0x00059F03 File Offset: 0x00058103
		public unsafe EClusterConnectionTypeEnum ClusterUnionConnectionType_DEPRECATED
		{
			get
			{
				return (EClusterConnectionTypeEnum)(*(base.NativePtr + (IntPtr)AChaosSolverActor.__PropertyOffset_ClusterUnionConnectionType_DEPRECATED));
			}
			set
			{
				*(base.NativePtr + (IntPtr)AChaosSolverActor.__PropertyOffset_ClusterUnionConnectionType_DEPRECATED) = (byte)value;
			}
		}

		// Token: 0x17000E67 RID: 3687
		// (get) Token: 0x06003BAE RID: 15278 RVA: 0x00059F14 File Offset: 0x00058114
		// (set) Token: 0x06003BAF RID: 15279 RVA: 0x00059F24 File Offset: 0x00058124
		public unsafe bool DoGenerateCollisionData_DEPRECATED
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AChaosSolverActor.__PropertyOffset_DoGenerateCollisionData_DEPRECATED) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AChaosSolverActor.__PropertyOffset_DoGenerateCollisionData_DEPRECATED) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000E68 RID: 3688
		// (get) Token: 0x06003BB0 RID: 15280 RVA: 0x00059F38 File Offset: 0x00058138
		// (set) Token: 0x06003BB1 RID: 15281 RVA: 0x00059F71 File Offset: 0x00058171
		public FSolverCollisionFilterSettings CollisionFilterSettings_DEPRECATED
		{
			get
			{
				base.FastCheckIsValid();
				FSolverCollisionFilterSettings result;
				if ((result = this._CollisionFilterSettings_DEPRECATED) == null)
				{
					result = (this._CollisionFilterSettings_DEPRECATED = new FSolverCollisionFilterSettings(base.NativePtr + (IntPtr)AChaosSolverActor.__PropertyOffset_CollisionFilterSettings_DEPRECATED, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSolverCollisionFilterSettings.StaticStruct(), base.NativePtr + (IntPtr)AChaosSolverActor.__PropertyOffset_CollisionFilterSettings_DEPRECATED, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000E69 RID: 3689
		// (get) Token: 0x06003BB2 RID: 15282 RVA: 0x00059F92 File Offset: 0x00058192
		// (set) Token: 0x06003BB3 RID: 15283 RVA: 0x00059FA2 File Offset: 0x000581A2
		public unsafe bool DoGenerateBreakingData_DEPRECATED
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AChaosSolverActor.__PropertyOffset_DoGenerateBreakingData_DEPRECATED) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AChaosSolverActor.__PropertyOffset_DoGenerateBreakingData_DEPRECATED) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000E6A RID: 3690
		// (get) Token: 0x06003BB4 RID: 15284 RVA: 0x00059FB4 File Offset: 0x000581B4
		// (set) Token: 0x06003BB5 RID: 15285 RVA: 0x00059FED File Offset: 0x000581ED
		public FSolverBreakingFilterSettings BreakingFilterSettings_DEPRECATED
		{
			get
			{
				base.FastCheckIsValid();
				FSolverBreakingFilterSettings result;
				if ((result = this._BreakingFilterSettings_DEPRECATED) == null)
				{
					result = (this._BreakingFilterSettings_DEPRECATED = new FSolverBreakingFilterSettings(base.NativePtr + (IntPtr)AChaosSolverActor.__PropertyOffset_BreakingFilterSettings_DEPRECATED, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSolverBreakingFilterSettings.StaticStruct(), base.NativePtr + (IntPtr)AChaosSolverActor.__PropertyOffset_BreakingFilterSettings_DEPRECATED, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000E6B RID: 3691
		// (get) Token: 0x06003BB6 RID: 15286 RVA: 0x0005A00E File Offset: 0x0005820E
		// (set) Token: 0x06003BB7 RID: 15287 RVA: 0x0005A01E File Offset: 0x0005821E
		public unsafe bool DoGenerateTrailingData_DEPRECATED
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AChaosSolverActor.__PropertyOffset_DoGenerateTrailingData_DEPRECATED) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AChaosSolverActor.__PropertyOffset_DoGenerateTrailingData_DEPRECATED) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000E6C RID: 3692
		// (get) Token: 0x06003BB8 RID: 15288 RVA: 0x0005A030 File Offset: 0x00058230
		// (set) Token: 0x06003BB9 RID: 15289 RVA: 0x0005A069 File Offset: 0x00058269
		public FSolverTrailingFilterSettings TrailingFilterSettings_DEPRECATED
		{
			get
			{
				base.FastCheckIsValid();
				FSolverTrailingFilterSettings result;
				if ((result = this._TrailingFilterSettings_DEPRECATED) == null)
				{
					result = (this._TrailingFilterSettings_DEPRECATED = new FSolverTrailingFilterSettings(base.NativePtr + (IntPtr)AChaosSolverActor.__PropertyOffset_TrailingFilterSettings_DEPRECATED, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSolverTrailingFilterSettings.StaticStruct(), base.NativePtr + (IntPtr)AChaosSolverActor.__PropertyOffset_TrailingFilterSettings_DEPRECATED, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000E6D RID: 3693
		// (get) Token: 0x06003BBA RID: 15290 RVA: 0x0005A08A File Offset: 0x0005828A
		// (set) Token: 0x06003BBB RID: 15291 RVA: 0x0005A09A File Offset: 0x0005829A
		public unsafe float MassScale_DEPRECATED
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AChaosSolverActor.__PropertyOffset_MassScale_DEPRECATED);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AChaosSolverActor.__PropertyOffset_MassScale_DEPRECATED) = value;
			}
		}

		// Token: 0x17000E6E RID: 3694
		// (get) Token: 0x06003BBC RID: 15292 RVA: 0x0005A0AB File Offset: 0x000582AB
		// (set) Token: 0x06003BBD RID: 15293 RVA: 0x0005A0BB File Offset: 0x000582BB
		public unsafe bool bGenerateContactGraph_DEPRECATED
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AChaosSolverActor.__PropertyOffset_bGenerateContactGraph_DEPRECATED) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AChaosSolverActor.__PropertyOffset_bGenerateContactGraph_DEPRECATED) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000E6F RID: 3695
		// (get) Token: 0x06003BBE RID: 15294 RVA: 0x0005A0CC File Offset: 0x000582CC
		// (set) Token: 0x06003BBF RID: 15295 RVA: 0x0005A0DC File Offset: 0x000582DC
		public unsafe bool bHasFloor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AChaosSolverActor.__PropertyOffset_bHasFloor) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AChaosSolverActor.__PropertyOffset_bHasFloor) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000E70 RID: 3696
		// (get) Token: 0x06003BC0 RID: 15296 RVA: 0x0005A0ED File Offset: 0x000582ED
		// (set) Token: 0x06003BC1 RID: 15297 RVA: 0x0005A0FD File Offset: 0x000582FD
		public unsafe float FloorHeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AChaosSolverActor.__PropertyOffset_FloorHeight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AChaosSolverActor.__PropertyOffset_FloorHeight) = value;
			}
		}

		// Token: 0x17000E71 RID: 3697
		// (get) Token: 0x06003BC2 RID: 15298 RVA: 0x0005A110 File Offset: 0x00058310
		// (set) Token: 0x06003BC3 RID: 15299 RVA: 0x0005A149 File Offset: 0x00058349
		public FChaosDebugSubstepControl ChaosDebugSubstepControl
		{
			get
			{
				base.FastCheckIsValid();
				FChaosDebugSubstepControl result;
				if ((result = this._ChaosDebugSubstepControl) == null)
				{
					result = (this._ChaosDebugSubstepControl = new FChaosDebugSubstepControl(base.NativePtr + (IntPtr)AChaosSolverActor.__PropertyOffset_ChaosDebugSubstepControl, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FChaosDebugSubstepControl.StaticStruct(), base.NativePtr + (IntPtr)AChaosSolverActor.__PropertyOffset_ChaosDebugSubstepControl, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000E72 RID: 3698
		// (get) Token: 0x06003BC4 RID: 15300 RVA: 0x0005A16A File Offset: 0x0005836A
		// (set) Token: 0x06003BC5 RID: 15301 RVA: 0x0005A17E File Offset: 0x0005837E
		[Nullable(2)]
		public unsafe UBillboardComponent SpriteComponent
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBillboardComponent>(base.NativePtr / (IntPtr)sizeof(void*) + AChaosSolverActor.__PropertyOffset_SpriteComponent);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AChaosSolverActor.__PropertyOffset_SpriteComponent, value);
			}
		}

		// Token: 0x17000E73 RID: 3699
		// (get) Token: 0x06003BC6 RID: 15302 RVA: 0x0005A193 File Offset: 0x00058393
		// (set) Token: 0x06003BC7 RID: 15303 RVA: 0x0005A1A7 File Offset: 0x000583A7
		[Nullable(2)]
		public unsafe UChaosGameplayEventDispatcher GameplayEventDispatcherComponent
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChaosGameplayEventDispatcher>(base.NativePtr / (IntPtr)sizeof(void*) + AChaosSolverActor.__PropertyOffset_GameplayEventDispatcherComponent);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AChaosSolverActor.__PropertyOffset_GameplayEventDispatcherComponent, value);
			}
		}

		// Token: 0x06003BC8 RID: 15304 RVA: 0x0005A1BC File Offset: 0x000583BC
		public void SetSolverActive(bool bActive)
		{
			AChaosSolverActor.__SetSolverActive_Internal(base.NativePtr, bActive);
		}

		// Token: 0x06003BC9 RID: 15305 RVA: 0x0005A1CA File Offset: 0x000583CA
		public void SetAsCurrentWorldSolver()
		{
			AChaosSolverActor.__SetAsCurrentWorldSolver_Internal(base.NativePtr);
		}

		// Token: 0x06003BCA RID: 15306
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSolverActive_Internal(IntPtr @this, bool bActive);

		// Token: 0x06003BCB RID: 15307
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAsCurrentWorldSolver_Internal(IntPtr @this);

		// Token: 0x06003BCC RID: 15308 RVA: 0x0005A1D7 File Offset: 0x000583D7
		static AChaosSolverActor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/ChaosSolverEngine.ChaosSolverActor");
		}

		// Token: 0x06003BCD RID: 15309 RVA: 0x0005A1E5 File Offset: 0x000583E5
		protected AChaosSolverActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04001B71 RID: 7025
		public new const string __ObjectPath = "/Script/ChaosSolverEngine.ChaosSolverActor";

		// Token: 0x04001B72 RID: 7026
		private static IntPtr _ClassPtr;

		// Token: 0x04001B73 RID: 7027
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04001B74 RID: 7028
		internal static int __PropertyOffset_Properties;

		// Token: 0x04001B75 RID: 7029
		[Nullable(2)]
		private FChaosSolverConfiguration _Properties;

		// Token: 0x04001B76 RID: 7030
		internal static int __PropertyOffset_TimeStepMultiplier_DEPRECATED;

		// Token: 0x04001B77 RID: 7031
		internal static int __PropertyOffset_CollisionIterations_DEPRECATED;

		// Token: 0x04001B78 RID: 7032
		internal static int __PropertyOffset_PushOutIterations_DEPRECATED;

		// Token: 0x04001B79 RID: 7033
		internal static int __PropertyOffset_PushOutPairIterations_DEPRECATED;

		// Token: 0x04001B7A RID: 7034
		internal static int __PropertyOffset_ClusterConnectionFactor_DEPRECATED;

		// Token: 0x04001B7B RID: 7035
		internal static int __PropertyOffset_ClusterUnionConnectionType_DEPRECATED;

		// Token: 0x04001B7C RID: 7036
		internal static int __PropertyOffset_DoGenerateCollisionData_DEPRECATED;

		// Token: 0x04001B7D RID: 7037
		internal static int __PropertyOffset_CollisionFilterSettings_DEPRECATED;

		// Token: 0x04001B7E RID: 7038
		[Nullable(2)]
		private FSolverCollisionFilterSettings _CollisionFilterSettings_DEPRECATED;

		// Token: 0x04001B7F RID: 7039
		internal static int __PropertyOffset_DoGenerateBreakingData_DEPRECATED;

		// Token: 0x04001B80 RID: 7040
		internal static int __PropertyOffset_BreakingFilterSettings_DEPRECATED;

		// Token: 0x04001B81 RID: 7041
		[Nullable(2)]
		private FSolverBreakingFilterSettings _BreakingFilterSettings_DEPRECATED;

		// Token: 0x04001B82 RID: 7042
		internal static int __PropertyOffset_DoGenerateTrailingData_DEPRECATED;

		// Token: 0x04001B83 RID: 7043
		internal static int __PropertyOffset_TrailingFilterSettings_DEPRECATED;

		// Token: 0x04001B84 RID: 7044
		[Nullable(2)]
		private FSolverTrailingFilterSettings _TrailingFilterSettings_DEPRECATED;

		// Token: 0x04001B85 RID: 7045
		internal static int __PropertyOffset_MassScale_DEPRECATED;

		// Token: 0x04001B86 RID: 7046
		internal static int __PropertyOffset_bGenerateContactGraph_DEPRECATED;

		// Token: 0x04001B87 RID: 7047
		internal static int __PropertyOffset_bHasFloor;

		// Token: 0x04001B88 RID: 7048
		internal static int __PropertyOffset_FloorHeight;

		// Token: 0x04001B89 RID: 7049
		internal static int __PropertyOffset_ChaosDebugSubstepControl;

		// Token: 0x04001B8A RID: 7050
		[Nullable(2)]
		private FChaosDebugSubstepControl _ChaosDebugSubstepControl;

		// Token: 0x04001B8B RID: 7051
		internal static int __PropertyOffset_SpriteComponent;

		// Token: 0x04001B8C RID: 7052
		internal static int __PropertyOffset_GameplayEventDispatcherComponent;
	}
}
