using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002647 RID: 9799
	[UnrealObjectPath("/Script/PhysicsCore.PhysicsSettingsCore")]
	[UnrealStructLayout(264, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 264)]
	public class UPhysicsSettingsCore : UDeveloperSettings, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602469E RID: 149150 RVA: 0x0035E885 File Offset: 0x0035CA85
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UPhysicsSettingsCore._ClassPtr;
		}

		// Token: 0x0602469F RID: 149151 RVA: 0x0035E894 File Offset: 0x0035CA94
		public UPhysicsSettingsCore() : this(BuiltinUtils.AllocNativeUObject(UPhysicsSettingsCore.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060246A0 RID: 149152 RVA: 0x0035E8BC File Offset: 0x0035CABC
		[NullableContext(1)]
		public UPhysicsSettingsCore(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UPhysicsSettingsCore.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17008C4B RID: 35915
		// (get) Token: 0x060246A1 RID: 149153 RVA: 0x0035E8EF File Offset: 0x0035CAEF
		// (set) Token: 0x060246A2 RID: 149154 RVA: 0x0035E8FF File Offset: 0x0035CAFF
		public unsafe float DefaultGravityZ
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPhysicsSettingsCore.__PropertyOffset_DefaultGravityZ);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPhysicsSettingsCore.__PropertyOffset_DefaultGravityZ) = value;
			}
		}

		// Token: 0x17008C4C RID: 35916
		// (get) Token: 0x060246A3 RID: 149155 RVA: 0x0035E910 File Offset: 0x0035CB10
		// (set) Token: 0x060246A4 RID: 149156 RVA: 0x0035E920 File Offset: 0x0035CB20
		public unsafe float DefaultTerminalVelocity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPhysicsSettingsCore.__PropertyOffset_DefaultTerminalVelocity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPhysicsSettingsCore.__PropertyOffset_DefaultTerminalVelocity) = value;
			}
		}

		// Token: 0x17008C4D RID: 35917
		// (get) Token: 0x060246A5 RID: 149157 RVA: 0x0035E931 File Offset: 0x0035CB31
		// (set) Token: 0x060246A6 RID: 149158 RVA: 0x0035E941 File Offset: 0x0035CB41
		public unsafe float DefaultFluidFriction
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPhysicsSettingsCore.__PropertyOffset_DefaultFluidFriction);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPhysicsSettingsCore.__PropertyOffset_DefaultFluidFriction) = value;
			}
		}

		// Token: 0x17008C4E RID: 35918
		// (get) Token: 0x060246A7 RID: 149159 RVA: 0x0035E952 File Offset: 0x0035CB52
		// (set) Token: 0x060246A8 RID: 149160 RVA: 0x0035E962 File Offset: 0x0035CB62
		public unsafe int SimulateScratchMemorySize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPhysicsSettingsCore.__PropertyOffset_SimulateScratchMemorySize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPhysicsSettingsCore.__PropertyOffset_SimulateScratchMemorySize) = value;
			}
		}

		// Token: 0x17008C4F RID: 35919
		// (get) Token: 0x060246A9 RID: 149161 RVA: 0x0035E973 File Offset: 0x0035CB73
		// (set) Token: 0x060246AA RID: 149162 RVA: 0x0035E983 File Offset: 0x0035CB83
		public unsafe int RagdollAggregateThreshold
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPhysicsSettingsCore.__PropertyOffset_RagdollAggregateThreshold);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPhysicsSettingsCore.__PropertyOffset_RagdollAggregateThreshold) = value;
			}
		}

		// Token: 0x17008C50 RID: 35920
		// (get) Token: 0x060246AB RID: 149163 RVA: 0x0035E994 File Offset: 0x0035CB94
		// (set) Token: 0x060246AC RID: 149164 RVA: 0x0035E9A4 File Offset: 0x0035CBA4
		public unsafe float TriangleMeshTriangleMinAreaThreshold
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPhysicsSettingsCore.__PropertyOffset_TriangleMeshTriangleMinAreaThreshold);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPhysicsSettingsCore.__PropertyOffset_TriangleMeshTriangleMinAreaThreshold) = value;
			}
		}

		// Token: 0x17008C51 RID: 35921
		// (get) Token: 0x060246AD RID: 149165 RVA: 0x0035E9B5 File Offset: 0x0035CBB5
		// (set) Token: 0x060246AE RID: 149166 RVA: 0x0035E9C5 File Offset: 0x0035CBC5
		public unsafe bool bEnableShapeSharing
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPhysicsSettingsCore.__PropertyOffset_bEnableShapeSharing) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPhysicsSettingsCore.__PropertyOffset_bEnableShapeSharing) = (value ? 1 : 0);
			}
		}

		// Token: 0x17008C52 RID: 35922
		// (get) Token: 0x060246AF RID: 149167 RVA: 0x0035E9D6 File Offset: 0x0035CBD6
		// (set) Token: 0x060246B0 RID: 149168 RVA: 0x0035E9E6 File Offset: 0x0035CBE6
		public unsafe bool bEnablePCM
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPhysicsSettingsCore.__PropertyOffset_bEnablePCM) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPhysicsSettingsCore.__PropertyOffset_bEnablePCM) = (value ? 1 : 0);
			}
		}

		// Token: 0x17008C53 RID: 35923
		// (get) Token: 0x060246B1 RID: 149169 RVA: 0x0035E9F7 File Offset: 0x0035CBF7
		// (set) Token: 0x060246B2 RID: 149170 RVA: 0x0035EA07 File Offset: 0x0035CC07
		public unsafe bool bEnableStabilization
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPhysicsSettingsCore.__PropertyOffset_bEnableStabilization) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPhysicsSettingsCore.__PropertyOffset_bEnableStabilization) = (value ? 1 : 0);
			}
		}

		// Token: 0x17008C54 RID: 35924
		// (get) Token: 0x060246B3 RID: 149171 RVA: 0x0035EA18 File Offset: 0x0035CC18
		// (set) Token: 0x060246B4 RID: 149172 RVA: 0x0035EA28 File Offset: 0x0035CC28
		public unsafe bool bWarnMissingLocks
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPhysicsSettingsCore.__PropertyOffset_bWarnMissingLocks) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPhysicsSettingsCore.__PropertyOffset_bWarnMissingLocks) = (value ? 1 : 0);
			}
		}

		// Token: 0x17008C55 RID: 35925
		// (get) Token: 0x060246B5 RID: 149173 RVA: 0x0035EA39 File Offset: 0x0035CC39
		// (set) Token: 0x060246B6 RID: 149174 RVA: 0x0035EA49 File Offset: 0x0035CC49
		public unsafe bool bEnable2DPhysics
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPhysicsSettingsCore.__PropertyOffset_bEnable2DPhysics) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPhysicsSettingsCore.__PropertyOffset_bEnable2DPhysics) = (value ? 1 : 0);
			}
		}

		// Token: 0x17008C56 RID: 35926
		// (get) Token: 0x060246B7 RID: 149175 RVA: 0x0035EA5A File Offset: 0x0035CC5A
		// (set) Token: 0x060246B8 RID: 149176 RVA: 0x0035EA6A File Offset: 0x0035CC6A
		public unsafe bool bDefaultHasComplexCollision_DEPRECATED
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPhysicsSettingsCore.__PropertyOffset_bDefaultHasComplexCollision_DEPRECATED) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPhysicsSettingsCore.__PropertyOffset_bDefaultHasComplexCollision_DEPRECATED) = (value ? 1 : 0);
			}
		}

		// Token: 0x17008C57 RID: 35927
		// (get) Token: 0x060246B9 RID: 149177 RVA: 0x0035EA7B File Offset: 0x0035CC7B
		// (set) Token: 0x060246BA RID: 149178 RVA: 0x0035EA8B File Offset: 0x0035CC8B
		public unsafe float BounceThresholdVelocity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPhysicsSettingsCore.__PropertyOffset_BounceThresholdVelocity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPhysicsSettingsCore.__PropertyOffset_BounceThresholdVelocity) = value;
			}
		}

		// Token: 0x17008C58 RID: 35928
		// (get) Token: 0x060246BB RID: 149179 RVA: 0x0035EA9C File Offset: 0x0035CC9C
		// (set) Token: 0x060246BC RID: 149180 RVA: 0x0035EAB0 File Offset: 0x0035CCB0
		public unsafe TEnumAsByte<EFrictionCombineMode> FrictionCombineMode
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPhysicsSettingsCore.__PropertyOffset_FrictionCombineMode);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPhysicsSettingsCore.__PropertyOffset_FrictionCombineMode) = value;
			}
		}

		// Token: 0x17008C59 RID: 35929
		// (get) Token: 0x060246BD RID: 149181 RVA: 0x0035EAC5 File Offset: 0x0035CCC5
		// (set) Token: 0x060246BE RID: 149182 RVA: 0x0035EAD9 File Offset: 0x0035CCD9
		public unsafe TEnumAsByte<EFrictionCombineMode> RestitutionCombineMode
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPhysicsSettingsCore.__PropertyOffset_RestitutionCombineMode);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPhysicsSettingsCore.__PropertyOffset_RestitutionCombineMode) = value;
			}
		}

		// Token: 0x17008C5A RID: 35930
		// (get) Token: 0x060246BF RID: 149183 RVA: 0x0035EAEE File Offset: 0x0035CCEE
		// (set) Token: 0x060246C0 RID: 149184 RVA: 0x0035EAFE File Offset: 0x0035CCFE
		public unsafe float MaxAngularVelocity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPhysicsSettingsCore.__PropertyOffset_MaxAngularVelocity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPhysicsSettingsCore.__PropertyOffset_MaxAngularVelocity) = value;
			}
		}

		// Token: 0x17008C5B RID: 35931
		// (get) Token: 0x060246C1 RID: 149185 RVA: 0x0035EB0F File Offset: 0x0035CD0F
		// (set) Token: 0x060246C2 RID: 149186 RVA: 0x0035EB1F File Offset: 0x0035CD1F
		public unsafe float MaxDepenetrationVelocity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPhysicsSettingsCore.__PropertyOffset_MaxDepenetrationVelocity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPhysicsSettingsCore.__PropertyOffset_MaxDepenetrationVelocity) = value;
			}
		}

		// Token: 0x17008C5C RID: 35932
		// (get) Token: 0x060246C3 RID: 149187 RVA: 0x0035EB30 File Offset: 0x0035CD30
		// (set) Token: 0x060246C4 RID: 149188 RVA: 0x0035EB40 File Offset: 0x0035CD40
		public unsafe float ContactOffsetMultiplier
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPhysicsSettingsCore.__PropertyOffset_ContactOffsetMultiplier);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPhysicsSettingsCore.__PropertyOffset_ContactOffsetMultiplier) = value;
			}
		}

		// Token: 0x17008C5D RID: 35933
		// (get) Token: 0x060246C5 RID: 149189 RVA: 0x0035EB51 File Offset: 0x0035CD51
		// (set) Token: 0x060246C6 RID: 149190 RVA: 0x0035EB61 File Offset: 0x0035CD61
		public unsafe float MinContactOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPhysicsSettingsCore.__PropertyOffset_MinContactOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPhysicsSettingsCore.__PropertyOffset_MinContactOffset) = value;
			}
		}

		// Token: 0x17008C5E RID: 35934
		// (get) Token: 0x060246C7 RID: 149191 RVA: 0x0035EB72 File Offset: 0x0035CD72
		// (set) Token: 0x060246C8 RID: 149192 RVA: 0x0035EB82 File Offset: 0x0035CD82
		public unsafe float MaxContactOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPhysicsSettingsCore.__PropertyOffset_MaxContactOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPhysicsSettingsCore.__PropertyOffset_MaxContactOffset) = value;
			}
		}

		// Token: 0x17008C5F RID: 35935
		// (get) Token: 0x060246C9 RID: 149193 RVA: 0x0035EB93 File Offset: 0x0035CD93
		// (set) Token: 0x060246CA RID: 149194 RVA: 0x0035EBA3 File Offset: 0x0035CDA3
		public unsafe bool bSimulateSkeletalMeshOnDedicatedServer
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPhysicsSettingsCore.__PropertyOffset_bSimulateSkeletalMeshOnDedicatedServer) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPhysicsSettingsCore.__PropertyOffset_bSimulateSkeletalMeshOnDedicatedServer) = (value ? 1 : 0);
			}
		}

		// Token: 0x17008C60 RID: 35936
		// (get) Token: 0x060246CB RID: 149195 RVA: 0x0035EBB4 File Offset: 0x0035CDB4
		// (set) Token: 0x060246CC RID: 149196 RVA: 0x0035EBC8 File Offset: 0x0035CDC8
		public unsafe TEnumAsByte<ECollisionTraceFlag> DefaultShapeComplexity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPhysicsSettingsCore.__PropertyOffset_DefaultShapeComplexity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPhysicsSettingsCore.__PropertyOffset_DefaultShapeComplexity) = value;
			}
		}

		// Token: 0x17008C61 RID: 35937
		// (get) Token: 0x060246CD RID: 149197 RVA: 0x0035EBE0 File Offset: 0x0035CDE0
		// (set) Token: 0x060246CE RID: 149198 RVA: 0x0035EC19 File Offset: 0x0035CE19
		[Nullable(1)]
		public FChaosSolverConfiguration SolverOptions
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FChaosSolverConfiguration result;
				if ((result = this._SolverOptions) == null)
				{
					result = (this._SolverOptions = new FChaosSolverConfiguration(base.NativePtr + (IntPtr)UPhysicsSettingsCore.__PropertyOffset_SolverOptions, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FChaosSolverConfiguration.StaticStruct(), base.NativePtr + (IntPtr)UPhysicsSettingsCore.__PropertyOffset_SolverOptions, value.NativePtr, 1, false);
			}
		}

		// Token: 0x060246CF RID: 149199 RVA: 0x0035EC3A File Offset: 0x0035CE3A
		static UPhysicsSettingsCore()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/PhysicsCore.PhysicsSettingsCore");
		}

		// Token: 0x060246D0 RID: 149200 RVA: 0x0035EC48 File Offset: 0x0035CE48
		protected UPhysicsSettingsCore(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040138F3 RID: 80115
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/PhysicsCore.PhysicsSettingsCore";

		// Token: 0x040138F4 RID: 80116
		private static IntPtr _ClassPtr;

		// Token: 0x040138F5 RID: 80117
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040138F6 RID: 80118
		internal static int __PropertyOffset_DefaultGravityZ;

		// Token: 0x040138F7 RID: 80119
		internal static int __PropertyOffset_DefaultTerminalVelocity;

		// Token: 0x040138F8 RID: 80120
		internal static int __PropertyOffset_DefaultFluidFriction;

		// Token: 0x040138F9 RID: 80121
		internal static int __PropertyOffset_SimulateScratchMemorySize;

		// Token: 0x040138FA RID: 80122
		internal static int __PropertyOffset_RagdollAggregateThreshold;

		// Token: 0x040138FB RID: 80123
		internal static int __PropertyOffset_TriangleMeshTriangleMinAreaThreshold;

		// Token: 0x040138FC RID: 80124
		internal static int __PropertyOffset_bEnableShapeSharing;

		// Token: 0x040138FD RID: 80125
		internal static int __PropertyOffset_bEnablePCM;

		// Token: 0x040138FE RID: 80126
		internal static int __PropertyOffset_bEnableStabilization;

		// Token: 0x040138FF RID: 80127
		internal static int __PropertyOffset_bWarnMissingLocks;

		// Token: 0x04013900 RID: 80128
		internal static int __PropertyOffset_bEnable2DPhysics;

		// Token: 0x04013901 RID: 80129
		internal static int __PropertyOffset_bDefaultHasComplexCollision_DEPRECATED;

		// Token: 0x04013902 RID: 80130
		internal static int __PropertyOffset_BounceThresholdVelocity;

		// Token: 0x04013903 RID: 80131
		internal static int __PropertyOffset_FrictionCombineMode;

		// Token: 0x04013904 RID: 80132
		internal static int __PropertyOffset_RestitutionCombineMode;

		// Token: 0x04013905 RID: 80133
		internal static int __PropertyOffset_MaxAngularVelocity;

		// Token: 0x04013906 RID: 80134
		internal static int __PropertyOffset_MaxDepenetrationVelocity;

		// Token: 0x04013907 RID: 80135
		internal static int __PropertyOffset_ContactOffsetMultiplier;

		// Token: 0x04013908 RID: 80136
		internal static int __PropertyOffset_MinContactOffset;

		// Token: 0x04013909 RID: 80137
		internal static int __PropertyOffset_MaxContactOffset;

		// Token: 0x0401390A RID: 80138
		internal static int __PropertyOffset_bSimulateSkeletalMeshOnDedicatedServer;

		// Token: 0x0401390B RID: 80139
		internal static int __PropertyOffset_DefaultShapeComplexity;

		// Token: 0x0401390C RID: 80140
		internal static int __PropertyOffset_SolverOptions;

		// Token: 0x0401390D RID: 80141
		[Nullable(2)]
		private FChaosSolverConfiguration _SolverOptions;
	}
}
