using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020002CE RID: 718
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AnimGraphRuntime.AnimNode_AnimDynamics")]
	[UnrealStructLayout(1264, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 1264)]
	public class FAnimNode_AnimDynamics : FAnimNode_SkeletalControlBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060027D4 RID: 10196 RVA: 0x0003BB64 File Offset: 0x00039D64
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAnimNode_AnimDynamics._ScriptStructPtr != 0) ? FAnimNode_AnimDynamics._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AnimGraphRuntime.AnimNode_AnimDynamics", ref FAnimNode_AnimDynamics._ScriptStructPtr);
		}

		// Token: 0x17000984 RID: 2436
		// (get) Token: 0x060027D5 RID: 10197 RVA: 0x0003BB88 File Offset: 0x00039D88
		// (set) Token: 0x060027D6 RID: 10198 RVA: 0x0003BB98 File Offset: 0x00039D98
		public unsafe float LinearDampingOverride
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_AnimDynamics.__PropertyOffset_LinearDampingOverride);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_AnimDynamics.__PropertyOffset_LinearDampingOverride) = value;
			}
		}

		// Token: 0x17000985 RID: 2437
		// (get) Token: 0x060027D7 RID: 10199 RVA: 0x0003BBA9 File Offset: 0x00039DA9
		// (set) Token: 0x060027D8 RID: 10200 RVA: 0x0003BBB9 File Offset: 0x00039DB9
		public unsafe float AngularDampingOverride
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_AnimDynamics.__PropertyOffset_AngularDampingOverride);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_AnimDynamics.__PropertyOffset_AngularDampingOverride) = value;
			}
		}

		// Token: 0x17000986 RID: 2438
		// (get) Token: 0x060027D9 RID: 10201 RVA: 0x0003BBCC File Offset: 0x00039DCC
		// (set) Token: 0x060027DA RID: 10202 RVA: 0x0003BC0F File Offset: 0x00039E0F
		public FBoneReference RelativeSpaceBone
		{
			get
			{
				base.FastCheckIsValid();
				FBoneReference result;
				if ((result = this._RelativeSpaceBone) == null)
				{
					result = (this._RelativeSpaceBone = new FBoneReference(base.NativePtr + (IntPtr)FAnimNode_AnimDynamics.__PropertyOffset_RelativeSpaceBone, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FBoneReference.StaticStruct(), base.NativePtr + (IntPtr)FAnimNode_AnimDynamics.__PropertyOffset_RelativeSpaceBone, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000987 RID: 2439
		// (get) Token: 0x060027DB RID: 10203 RVA: 0x0003BC30 File Offset: 0x00039E30
		// (set) Token: 0x060027DC RID: 10204 RVA: 0x0003BC73 File Offset: 0x00039E73
		public FBoneReference BoundBone
		{
			get
			{
				base.FastCheckIsValid();
				FBoneReference result;
				if ((result = this._BoundBone) == null)
				{
					result = (this._BoundBone = new FBoneReference(base.NativePtr + (IntPtr)FAnimNode_AnimDynamics.__PropertyOffset_BoundBone, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FBoneReference.StaticStruct(), base.NativePtr + (IntPtr)FAnimNode_AnimDynamics.__PropertyOffset_BoundBone, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000988 RID: 2440
		// (get) Token: 0x060027DD RID: 10205 RVA: 0x0003BC94 File Offset: 0x00039E94
		// (set) Token: 0x060027DE RID: 10206 RVA: 0x0003BCD7 File Offset: 0x00039ED7
		public FBoneReference ChainEnd
		{
			get
			{
				base.FastCheckIsValid();
				FBoneReference result;
				if ((result = this._ChainEnd) == null)
				{
					result = (this._ChainEnd = new FBoneReference(base.NativePtr + (IntPtr)FAnimNode_AnimDynamics.__PropertyOffset_ChainEnd, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FBoneReference.StaticStruct(), base.NativePtr + (IntPtr)FAnimNode_AnimDynamics.__PropertyOffset_ChainEnd, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000989 RID: 2441
		// (get) Token: 0x060027DF RID: 10207 RVA: 0x0003BCF8 File Offset: 0x00039EF8
		// (set) Token: 0x060027E0 RID: 10208 RVA: 0x0003BD0C File Offset: 0x00039F0C
		public unsafe FVector BoxExtents
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_AnimDynamics.__PropertyOffset_BoxExtents);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_AnimDynamics.__PropertyOffset_BoxExtents) = value;
			}
		}

		// Token: 0x1700098A RID: 2442
		// (get) Token: 0x060027E1 RID: 10209 RVA: 0x0003BD21 File Offset: 0x00039F21
		// (set) Token: 0x060027E2 RID: 10210 RVA: 0x0003BD35 File Offset: 0x00039F35
		public unsafe FVector LocalJointOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_AnimDynamics.__PropertyOffset_LocalJointOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_AnimDynamics.__PropertyOffset_LocalJointOffset) = value;
			}
		}

		// Token: 0x1700098B RID: 2443
		// (get) Token: 0x060027E3 RID: 10211 RVA: 0x0003BD4A File Offset: 0x00039F4A
		// (set) Token: 0x060027E4 RID: 10212 RVA: 0x0003BD5A File Offset: 0x00039F5A
		public unsafe float GravityScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_AnimDynamics.__PropertyOffset_GravityScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_AnimDynamics.__PropertyOffset_GravityScale) = value;
			}
		}

		// Token: 0x1700098C RID: 2444
		// (get) Token: 0x060027E5 RID: 10213 RVA: 0x0003BD6B File Offset: 0x00039F6B
		// (set) Token: 0x060027E6 RID: 10214 RVA: 0x0003BD7F File Offset: 0x00039F7F
		public unsafe FVector GravityOverride
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_AnimDynamics.__PropertyOffset_GravityOverride);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_AnimDynamics.__PropertyOffset_GravityOverride) = value;
			}
		}

		// Token: 0x1700098D RID: 2445
		// (get) Token: 0x060027E7 RID: 10215 RVA: 0x0003BD94 File Offset: 0x00039F94
		// (set) Token: 0x060027E8 RID: 10216 RVA: 0x0003BDA4 File Offset: 0x00039FA4
		public unsafe float LinearSpringConstant
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_AnimDynamics.__PropertyOffset_LinearSpringConstant);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_AnimDynamics.__PropertyOffset_LinearSpringConstant) = value;
			}
		}

		// Token: 0x1700098E RID: 2446
		// (get) Token: 0x060027E9 RID: 10217 RVA: 0x0003BDB5 File Offset: 0x00039FB5
		// (set) Token: 0x060027EA RID: 10218 RVA: 0x0003BDC5 File Offset: 0x00039FC5
		public unsafe float AngularSpringConstant
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_AnimDynamics.__PropertyOffset_AngularSpringConstant);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_AnimDynamics.__PropertyOffset_AngularSpringConstant) = value;
			}
		}

		// Token: 0x1700098F RID: 2447
		// (get) Token: 0x060027EB RID: 10219 RVA: 0x0003BDD6 File Offset: 0x00039FD6
		// (set) Token: 0x060027EC RID: 10220 RVA: 0x0003BDE6 File Offset: 0x00039FE6
		public unsafe float WindScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_AnimDynamics.__PropertyOffset_WindScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_AnimDynamics.__PropertyOffset_WindScale) = value;
			}
		}

		// Token: 0x17000990 RID: 2448
		// (get) Token: 0x060027ED RID: 10221 RVA: 0x0003BDF7 File Offset: 0x00039FF7
		// (set) Token: 0x060027EE RID: 10222 RVA: 0x0003BE0B File Offset: 0x0003A00B
		public unsafe FVector ComponentLinearAccScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_AnimDynamics.__PropertyOffset_ComponentLinearAccScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_AnimDynamics.__PropertyOffset_ComponentLinearAccScale) = value;
			}
		}

		// Token: 0x17000991 RID: 2449
		// (get) Token: 0x060027EF RID: 10223 RVA: 0x0003BE20 File Offset: 0x0003A020
		// (set) Token: 0x060027F0 RID: 10224 RVA: 0x0003BE34 File Offset: 0x0003A034
		public unsafe FVector ComponentLinearVelScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_AnimDynamics.__PropertyOffset_ComponentLinearVelScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_AnimDynamics.__PropertyOffset_ComponentLinearVelScale) = value;
			}
		}

		// Token: 0x17000992 RID: 2450
		// (get) Token: 0x060027F1 RID: 10225 RVA: 0x0003BE49 File Offset: 0x0003A049
		// (set) Token: 0x060027F2 RID: 10226 RVA: 0x0003BE5D File Offset: 0x0003A05D
		public unsafe FVector ComponentAppliedLinearAccClamp
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_AnimDynamics.__PropertyOffset_ComponentAppliedLinearAccClamp);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_AnimDynamics.__PropertyOffset_ComponentAppliedLinearAccClamp) = value;
			}
		}

		// Token: 0x17000993 RID: 2451
		// (get) Token: 0x060027F3 RID: 10227 RVA: 0x0003BE72 File Offset: 0x0003A072
		// (set) Token: 0x060027F4 RID: 10228 RVA: 0x0003BE82 File Offset: 0x0003A082
		public unsafe float AngularBiasOverride
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_AnimDynamics.__PropertyOffset_AngularBiasOverride);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_AnimDynamics.__PropertyOffset_AngularBiasOverride) = value;
			}
		}

		// Token: 0x17000994 RID: 2452
		// (get) Token: 0x060027F5 RID: 10229 RVA: 0x0003BE93 File Offset: 0x0003A093
		// (set) Token: 0x060027F6 RID: 10230 RVA: 0x0003BEA3 File Offset: 0x0003A0A3
		public unsafe int NumSolverIterationsPreUpdate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_AnimDynamics.__PropertyOffset_NumSolverIterationsPreUpdate);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_AnimDynamics.__PropertyOffset_NumSolverIterationsPreUpdate) = value;
			}
		}

		// Token: 0x17000995 RID: 2453
		// (get) Token: 0x060027F7 RID: 10231 RVA: 0x0003BEB4 File Offset: 0x0003A0B4
		// (set) Token: 0x060027F8 RID: 10232 RVA: 0x0003BEC4 File Offset: 0x0003A0C4
		public unsafe int NumSolverIterationsPostUpdate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_AnimDynamics.__PropertyOffset_NumSolverIterationsPostUpdate);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_AnimDynamics.__PropertyOffset_NumSolverIterationsPostUpdate) = value;
			}
		}

		// Token: 0x17000996 RID: 2454
		// (get) Token: 0x060027F9 RID: 10233 RVA: 0x0003BED8 File Offset: 0x0003A0D8
		// (set) Token: 0x060027FA RID: 10234 RVA: 0x0003BF1B File Offset: 0x0003A11B
		public FAnimPhysConstraintSetup ConstraintSetup
		{
			get
			{
				base.FastCheckIsValid();
				FAnimPhysConstraintSetup result;
				if ((result = this._ConstraintSetup) == null)
				{
					result = (this._ConstraintSetup = new FAnimPhysConstraintSetup(base.NativePtr + (IntPtr)FAnimNode_AnimDynamics.__PropertyOffset_ConstraintSetup, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FAnimPhysConstraintSetup.StaticStruct(), base.NativePtr + (IntPtr)FAnimNode_AnimDynamics.__PropertyOffset_ConstraintSetup, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000997 RID: 2455
		// (get) Token: 0x060027FB RID: 10235 RVA: 0x0003BF3C File Offset: 0x0003A13C
		// (set) Token: 0x060027FC RID: 10236 RVA: 0x0003BF7F File Offset: 0x0003A17F
		public TArray<FAnimPhysSphericalLimit> SphericalLimits
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FAnimPhysSphericalLimit> result;
				if ((result = this._SphericalLimits) == null)
				{
					result = (this._SphericalLimits = new TArray<FAnimPhysSphericalLimit>(base.NativePtr + (IntPtr)FAnimNode_AnimDynamics.__PropertyOffset_SphericalLimits, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.SphericalLimits.CopyAssign(value);
			}
		}

		// Token: 0x17000998 RID: 2456
		// (get) Token: 0x060027FD RID: 10237 RVA: 0x0003BF8D File Offset: 0x0003A18D
		// (set) Token: 0x060027FE RID: 10238 RVA: 0x0003BF9D File Offset: 0x0003A19D
		public unsafe float SphereCollisionRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_AnimDynamics.__PropertyOffset_SphereCollisionRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_AnimDynamics.__PropertyOffset_SphereCollisionRadius) = value;
			}
		}

		// Token: 0x17000999 RID: 2457
		// (get) Token: 0x060027FF RID: 10239 RVA: 0x0003BFAE File Offset: 0x0003A1AE
		// (set) Token: 0x06002800 RID: 10240 RVA: 0x0003BFC2 File Offset: 0x0003A1C2
		public unsafe FVector ExternalForce
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_AnimDynamics.__PropertyOffset_ExternalForce);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_AnimDynamics.__PropertyOffset_ExternalForce) = value;
			}
		}

		// Token: 0x1700099A RID: 2458
		// (get) Token: 0x06002801 RID: 10241 RVA: 0x0003BFD8 File Offset: 0x0003A1D8
		// (set) Token: 0x06002802 RID: 10242 RVA: 0x0003C01B File Offset: 0x0003A21B
		public TArray<FAnimPhysPlanarLimit> PlanarLimits
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FAnimPhysPlanarLimit> result;
				if ((result = this._PlanarLimits) == null)
				{
					result = (this._PlanarLimits = new TArray<FAnimPhysPlanarLimit>(base.NativePtr + (IntPtr)FAnimNode_AnimDynamics.__PropertyOffset_PlanarLimits, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.PlanarLimits.CopyAssign(value);
			}
		}

		// Token: 0x1700099B RID: 2459
		// (get) Token: 0x06002803 RID: 10243 RVA: 0x0003C029 File Offset: 0x0003A229
		// (set) Token: 0x06002804 RID: 10244 RVA: 0x0003C039 File Offset: 0x0003A239
		public unsafe AnimPhysCollisionType CollisionType
		{
			get
			{
				return (AnimPhysCollisionType)(*(base.NativePtr + (IntPtr)FAnimNode_AnimDynamics.__PropertyOffset_CollisionType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_AnimDynamics.__PropertyOffset_CollisionType) = (byte)value;
			}
		}

		// Token: 0x1700099C RID: 2460
		// (get) Token: 0x06002805 RID: 10245 RVA: 0x0003C04A File Offset: 0x0003A24A
		// (set) Token: 0x06002806 RID: 10246 RVA: 0x0003C05A File Offset: 0x0003A25A
		public unsafe AnimPhysSimSpaceType SimulationSpace
		{
			get
			{
				return (AnimPhysSimSpaceType)(*(base.NativePtr + (IntPtr)FAnimNode_AnimDynamics.__PropertyOffset_SimulationSpace));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_AnimDynamics.__PropertyOffset_SimulationSpace) = (byte)value;
			}
		}

		// Token: 0x1700099D RID: 2461
		// (get) Token: 0x06002807 RID: 10247 RVA: 0x0003C06B File Offset: 0x0003A26B
		// (set) Token: 0x06002808 RID: 10248 RVA: 0x0003C084 File Offset: 0x0003A284
		public unsafe bool bUseSphericalLimits
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FAnimNode_AnimDynamics.__PropertyOffset_bUseSphericalLimits) & FAnimNode_AnimDynamics.__PropertyMask_bUseSphericalLimits) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FAnimNode_AnimDynamics.__PropertyOffset_bUseSphericalLimits) = ((*(base.NativePtr + (IntPtr)FAnimNode_AnimDynamics.__PropertyOffset_bUseSphericalLimits) & ~FAnimNode_AnimDynamics.__PropertyMask_bUseSphericalLimits) | (value ? FAnimNode_AnimDynamics.__PropertyMask_bUseSphericalLimits : 0));
			}
		}

		// Token: 0x1700099E RID: 2462
		// (get) Token: 0x06002809 RID: 10249 RVA: 0x0003C0B4 File Offset: 0x0003A2B4
		// (set) Token: 0x0600280A RID: 10250 RVA: 0x0003C0CD File Offset: 0x0003A2CD
		public unsafe bool bUsePlanarLimit
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FAnimNode_AnimDynamics.__PropertyOffset_bUsePlanarLimit) & FAnimNode_AnimDynamics.__PropertyMask_bUsePlanarLimit) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FAnimNode_AnimDynamics.__PropertyOffset_bUsePlanarLimit) = ((*(base.NativePtr + (IntPtr)FAnimNode_AnimDynamics.__PropertyOffset_bUsePlanarLimit) & ~FAnimNode_AnimDynamics.__PropertyMask_bUsePlanarLimit) | (value ? FAnimNode_AnimDynamics.__PropertyMask_bUsePlanarLimit : 0));
			}
		}

		// Token: 0x1700099F RID: 2463
		// (get) Token: 0x0600280B RID: 10251 RVA: 0x0003C0FD File Offset: 0x0003A2FD
		// (set) Token: 0x0600280C RID: 10252 RVA: 0x0003C116 File Offset: 0x0003A316
		public unsafe bool bDoUpdate
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FAnimNode_AnimDynamics.__PropertyOffset_bDoUpdate) & FAnimNode_AnimDynamics.__PropertyMask_bDoUpdate) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FAnimNode_AnimDynamics.__PropertyOffset_bDoUpdate) = ((*(base.NativePtr + (IntPtr)FAnimNode_AnimDynamics.__PropertyOffset_bDoUpdate) & ~FAnimNode_AnimDynamics.__PropertyMask_bDoUpdate) | (value ? FAnimNode_AnimDynamics.__PropertyMask_bDoUpdate : 0));
			}
		}

		// Token: 0x170009A0 RID: 2464
		// (get) Token: 0x0600280D RID: 10253 RVA: 0x0003C146 File Offset: 0x0003A346
		// (set) Token: 0x0600280E RID: 10254 RVA: 0x0003C15F File Offset: 0x0003A35F
		public unsafe bool bDoEval
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FAnimNode_AnimDynamics.__PropertyOffset_bDoEval) & FAnimNode_AnimDynamics.__PropertyMask_bDoEval) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FAnimNode_AnimDynamics.__PropertyOffset_bDoEval) = ((*(base.NativePtr + (IntPtr)FAnimNode_AnimDynamics.__PropertyOffset_bDoEval) & ~FAnimNode_AnimDynamics.__PropertyMask_bDoEval) | (value ? FAnimNode_AnimDynamics.__PropertyMask_bDoEval : 0));
			}
		}

		// Token: 0x170009A1 RID: 2465
		// (get) Token: 0x0600280F RID: 10255 RVA: 0x0003C18F File Offset: 0x0003A38F
		// (set) Token: 0x06002810 RID: 10256 RVA: 0x0003C1A8 File Offset: 0x0003A3A8
		public unsafe bool bOverrideLinearDamping
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FAnimNode_AnimDynamics.__PropertyOffset_bOverrideLinearDamping) & FAnimNode_AnimDynamics.__PropertyMask_bOverrideLinearDamping) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FAnimNode_AnimDynamics.__PropertyOffset_bOverrideLinearDamping) = ((*(base.NativePtr + (IntPtr)FAnimNode_AnimDynamics.__PropertyOffset_bOverrideLinearDamping) & ~FAnimNode_AnimDynamics.__PropertyMask_bOverrideLinearDamping) | (value ? FAnimNode_AnimDynamics.__PropertyMask_bOverrideLinearDamping : 0));
			}
		}

		// Token: 0x170009A2 RID: 2466
		// (get) Token: 0x06002811 RID: 10257 RVA: 0x0003C1D8 File Offset: 0x0003A3D8
		// (set) Token: 0x06002812 RID: 10258 RVA: 0x0003C1F1 File Offset: 0x0003A3F1
		public unsafe bool bOverrideAngularBias
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FAnimNode_AnimDynamics.__PropertyOffset_bOverrideAngularBias) & FAnimNode_AnimDynamics.__PropertyMask_bOverrideAngularBias) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FAnimNode_AnimDynamics.__PropertyOffset_bOverrideAngularBias) = ((*(base.NativePtr + (IntPtr)FAnimNode_AnimDynamics.__PropertyOffset_bOverrideAngularBias) & ~FAnimNode_AnimDynamics.__PropertyMask_bOverrideAngularBias) | (value ? FAnimNode_AnimDynamics.__PropertyMask_bOverrideAngularBias : 0));
			}
		}

		// Token: 0x170009A3 RID: 2467
		// (get) Token: 0x06002813 RID: 10259 RVA: 0x0003C221 File Offset: 0x0003A421
		// (set) Token: 0x06002814 RID: 10260 RVA: 0x0003C23A File Offset: 0x0003A43A
		public unsafe bool bOverrideAngularDamping
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FAnimNode_AnimDynamics.__PropertyOffset_bOverrideAngularDamping) & FAnimNode_AnimDynamics.__PropertyMask_bOverrideAngularDamping) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FAnimNode_AnimDynamics.__PropertyOffset_bOverrideAngularDamping) = ((*(base.NativePtr + (IntPtr)FAnimNode_AnimDynamics.__PropertyOffset_bOverrideAngularDamping) & ~FAnimNode_AnimDynamics.__PropertyMask_bOverrideAngularDamping) | (value ? FAnimNode_AnimDynamics.__PropertyMask_bOverrideAngularDamping : 0));
			}
		}

		// Token: 0x170009A4 RID: 2468
		// (get) Token: 0x06002815 RID: 10261 RVA: 0x0003C26A File Offset: 0x0003A46A
		// (set) Token: 0x06002816 RID: 10262 RVA: 0x0003C283 File Offset: 0x0003A483
		public unsafe bool bEnableWind
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FAnimNode_AnimDynamics.__PropertyOffset_bEnableWind) & FAnimNode_AnimDynamics.__PropertyMask_bEnableWind) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FAnimNode_AnimDynamics.__PropertyOffset_bEnableWind) = ((*(base.NativePtr + (IntPtr)FAnimNode_AnimDynamics.__PropertyOffset_bEnableWind) & ~FAnimNode_AnimDynamics.__PropertyMask_bEnableWind) | (value ? FAnimNode_AnimDynamics.__PropertyMask_bEnableWind : 0));
			}
		}

		// Token: 0x170009A5 RID: 2469
		// (get) Token: 0x06002817 RID: 10263 RVA: 0x0003C2B3 File Offset: 0x0003A4B3
		// (set) Token: 0x06002818 RID: 10264 RVA: 0x0003C2CC File Offset: 0x0003A4CC
		public unsafe bool bUseGravityOverride
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FAnimNode_AnimDynamics.__PropertyOffset_bUseGravityOverride) & FAnimNode_AnimDynamics.__PropertyMask_bUseGravityOverride) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FAnimNode_AnimDynamics.__PropertyOffset_bUseGravityOverride) = ((*(base.NativePtr + (IntPtr)FAnimNode_AnimDynamics.__PropertyOffset_bUseGravityOverride) & ~FAnimNode_AnimDynamics.__PropertyMask_bUseGravityOverride) | (value ? FAnimNode_AnimDynamics.__PropertyMask_bUseGravityOverride : 0));
			}
		}

		// Token: 0x170009A6 RID: 2470
		// (get) Token: 0x06002819 RID: 10265 RVA: 0x0003C2FC File Offset: 0x0003A4FC
		// (set) Token: 0x0600281A RID: 10266 RVA: 0x0003C315 File Offset: 0x0003A515
		public unsafe bool bLinearSpring
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FAnimNode_AnimDynamics.__PropertyOffset_bLinearSpring) & FAnimNode_AnimDynamics.__PropertyMask_bLinearSpring) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FAnimNode_AnimDynamics.__PropertyOffset_bLinearSpring) = ((*(base.NativePtr + (IntPtr)FAnimNode_AnimDynamics.__PropertyOffset_bLinearSpring) & ~FAnimNode_AnimDynamics.__PropertyMask_bLinearSpring) | (value ? FAnimNode_AnimDynamics.__PropertyMask_bLinearSpring : 0));
			}
		}

		// Token: 0x170009A7 RID: 2471
		// (get) Token: 0x0600281B RID: 10267 RVA: 0x0003C345 File Offset: 0x0003A545
		// (set) Token: 0x0600281C RID: 10268 RVA: 0x0003C35E File Offset: 0x0003A55E
		public unsafe bool bAngularSpring
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FAnimNode_AnimDynamics.__PropertyOffset_bAngularSpring) & FAnimNode_AnimDynamics.__PropertyMask_bAngularSpring) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FAnimNode_AnimDynamics.__PropertyOffset_bAngularSpring) = ((*(base.NativePtr + (IntPtr)FAnimNode_AnimDynamics.__PropertyOffset_bAngularSpring) & ~FAnimNode_AnimDynamics.__PropertyMask_bAngularSpring) | (value ? FAnimNode_AnimDynamics.__PropertyMask_bAngularSpring : 0));
			}
		}

		// Token: 0x170009A8 RID: 2472
		// (get) Token: 0x0600281D RID: 10269 RVA: 0x0003C38E File Offset: 0x0003A58E
		// (set) Token: 0x0600281E RID: 10270 RVA: 0x0003C3A7 File Offset: 0x0003A5A7
		public unsafe bool bChain
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FAnimNode_AnimDynamics.__PropertyOffset_bChain) & FAnimNode_AnimDynamics.__PropertyMask_bChain) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FAnimNode_AnimDynamics.__PropertyOffset_bChain) = ((*(base.NativePtr + (IntPtr)FAnimNode_AnimDynamics.__PropertyOffset_bChain) & ~FAnimNode_AnimDynamics.__PropertyMask_bChain) | (value ? FAnimNode_AnimDynamics.__PropertyMask_bChain : 0));
			}
		}

		// Token: 0x170009A9 RID: 2473
		// (get) Token: 0x0600281F RID: 10271 RVA: 0x0003C3D8 File Offset: 0x0003A5D8
		// (set) Token: 0x06002820 RID: 10272 RVA: 0x0003C41B File Offset: 0x0003A61B
		public FRotationRetargetingInfo RetargetingSettings
		{
			get
			{
				base.FastCheckIsValid();
				FRotationRetargetingInfo result;
				if ((result = this._RetargetingSettings) == null)
				{
					result = (this._RetargetingSettings = new FRotationRetargetingInfo(base.NativePtr + (IntPtr)FAnimNode_AnimDynamics.__PropertyOffset_RetargetingSettings, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRotationRetargetingInfo.StaticStruct(), base.NativePtr + (IntPtr)FAnimNode_AnimDynamics.__PropertyOffset_RetargetingSettings, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06002821 RID: 10273 RVA: 0x0003C43C File Offset: 0x0003A63C
		public FAnimNode_AnimDynamics()
		{
		}

		// Token: 0x06002822 RID: 10274 RVA: 0x0003C444 File Offset: 0x0003A644
		public FAnimNode_AnimDynamics(float LinearDampingOverride, float AngularDampingOverride, FBoneReference RelativeSpaceBone, FBoneReference BoundBone, FBoneReference ChainEnd, FVector BoxExtents, FVector LocalJointOffset, float GravityScale, FVector GravityOverride, float LinearSpringConstant, float AngularSpringConstant, float WindScale, FVector ComponentLinearAccScale, FVector ComponentLinearVelScale, FVector ComponentAppliedLinearAccClamp, float AngularBiasOverride, int NumSolverIterationsPreUpdate, int NumSolverIterationsPostUpdate, FAnimPhysConstraintSetup ConstraintSetup, TArray<FAnimPhysSphericalLimit> SphericalLimits, float SphereCollisionRadius, FVector ExternalForce, TArray<FAnimPhysPlanarLimit> PlanarLimits, AnimPhysCollisionType CollisionType, AnimPhysSimSpaceType SimulationSpace, bool bUseSphericalLimits, bool bUsePlanarLimit, bool bDoUpdate, bool bDoEval, bool bOverrideLinearDamping, bool bOverrideAngularBias, bool bOverrideAngularDamping, bool bEnableWind, bool bUseGravityOverride, bool bLinearSpring, bool bAngularSpring, bool bChain, FRotationRetargetingInfo RetargetingSettings, FComponentSpacePoseLink ComponentPose, int LODThreshold, int KuroLODMask, float ActualAlpha, EAnimAlphaInputType AlphaInputType, bool bAlphaBoolEnabled, bool bParallelEvalEnabled, bool bEnableOnMobile, float Alpha, FInputScaleBias AlphaScaleBias, FInputAlphaBoolBlend AlphaBoolBlend, FName AlphaCurveName, FInputScaleBiasClamp AlphaScaleBiasClamp)
		{
			this.LinearDampingOverride = LinearDampingOverride;
			this.AngularDampingOverride = AngularDampingOverride;
			this.RelativeSpaceBone = RelativeSpaceBone;
			this.BoundBone = BoundBone;
			this.ChainEnd = ChainEnd;
			this.BoxExtents = BoxExtents;
			this.LocalJointOffset = LocalJointOffset;
			this.GravityScale = GravityScale;
			this.GravityOverride = GravityOverride;
			this.LinearSpringConstant = LinearSpringConstant;
			this.AngularSpringConstant = AngularSpringConstant;
			this.WindScale = WindScale;
			this.ComponentLinearAccScale = ComponentLinearAccScale;
			this.ComponentLinearVelScale = ComponentLinearVelScale;
			this.ComponentAppliedLinearAccClamp = ComponentAppliedLinearAccClamp;
			this.AngularBiasOverride = AngularBiasOverride;
			this.NumSolverIterationsPreUpdate = NumSolverIterationsPreUpdate;
			this.NumSolverIterationsPostUpdate = NumSolverIterationsPostUpdate;
			this.ConstraintSetup = ConstraintSetup;
			this.SphericalLimits = SphericalLimits;
			this.SphereCollisionRadius = SphereCollisionRadius;
			this.ExternalForce = ExternalForce;
			this.PlanarLimits = PlanarLimits;
			this.CollisionType = CollisionType;
			this.SimulationSpace = SimulationSpace;
			this.bUseSphericalLimits = bUseSphericalLimits;
			this.bUsePlanarLimit = bUsePlanarLimit;
			this.bDoUpdate = bDoUpdate;
			this.bDoEval = bDoEval;
			this.bOverrideLinearDamping = bOverrideLinearDamping;
			this.bOverrideAngularBias = bOverrideAngularBias;
			this.bOverrideAngularDamping = bOverrideAngularDamping;
			this.bEnableWind = bEnableWind;
			this.bUseGravityOverride = bUseGravityOverride;
			this.bLinearSpring = bLinearSpring;
			this.bAngularSpring = bAngularSpring;
			this.bChain = bChain;
			this.RetargetingSettings = RetargetingSettings;
			base.ComponentPose = ComponentPose;
			base.LODThreshold = LODThreshold;
			base.KuroLODMask = KuroLODMask;
			base.ActualAlpha = ActualAlpha;
			base.AlphaInputType = AlphaInputType;
			base.bAlphaBoolEnabled = bAlphaBoolEnabled;
			base.bParallelEvalEnabled = bParallelEvalEnabled;
			base.bEnableOnMobile = bEnableOnMobile;
			base.Alpha = Alpha;
			base.AlphaScaleBias = AlphaScaleBias;
			base.AlphaBoolBlend = AlphaBoolBlend;
			base.AlphaCurveName = AlphaCurveName;
			base.AlphaScaleBiasClamp = AlphaScaleBiasClamp;
		}

		// Token: 0x06002823 RID: 10275 RVA: 0x0003C5EC File Offset: 0x0003A7EC
		protected override IntPtr GetUStructPtr()
		{
			return FAnimNode_AnimDynamics.StaticStruct();
		}

		// Token: 0x06002824 RID: 10276 RVA: 0x0003C5F8 File Offset: 0x0003A7F8
		[NullableContext(2)]
		public FAnimNode_AnimDynamics(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06002825 RID: 10277 RVA: 0x0003C602 File Offset: 0x0003A802
		public FAnimNode_AnimDynamics(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06002826 RID: 10278 RVA: 0x0003C60D File Offset: 0x0003A80D
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAnimNode_AnimDynamics(Pointer, false, true);
		}

		// Token: 0x06002827 RID: 10279 RVA: 0x0003C617 File Offset: 0x0003A817
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAnimNode_AnimDynamics(Pointer, MemoryOwner);
		}

		// Token: 0x04000FB8 RID: 4024
		public new const string __ObjectPath = "/Script/AnimGraphRuntime.AnimNode_AnimDynamics";

		// Token: 0x04000FB9 RID: 4025
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04000FBA RID: 4026
		internal static int __PropertyOffset_LinearDampingOverride;

		// Token: 0x04000FBB RID: 4027
		internal static int __PropertyOffset_AngularDampingOverride;

		// Token: 0x04000FBC RID: 4028
		internal static int __PropertyOffset_RelativeSpaceBone;

		// Token: 0x04000FBD RID: 4029
		[Nullable(2)]
		private FBoneReference _RelativeSpaceBone;

		// Token: 0x04000FBE RID: 4030
		internal static int __PropertyOffset_BoundBone;

		// Token: 0x04000FBF RID: 4031
		[Nullable(2)]
		private FBoneReference _BoundBone;

		// Token: 0x04000FC0 RID: 4032
		internal static int __PropertyOffset_ChainEnd;

		// Token: 0x04000FC1 RID: 4033
		[Nullable(2)]
		private FBoneReference _ChainEnd;

		// Token: 0x04000FC2 RID: 4034
		internal static int __PropertyOffset_BoxExtents;

		// Token: 0x04000FC3 RID: 4035
		internal static int __PropertyOffset_LocalJointOffset;

		// Token: 0x04000FC4 RID: 4036
		internal static int __PropertyOffset_GravityScale;

		// Token: 0x04000FC5 RID: 4037
		internal static int __PropertyOffset_GravityOverride;

		// Token: 0x04000FC6 RID: 4038
		internal static int __PropertyOffset_LinearSpringConstant;

		// Token: 0x04000FC7 RID: 4039
		internal static int __PropertyOffset_AngularSpringConstant;

		// Token: 0x04000FC8 RID: 4040
		internal static int __PropertyOffset_WindScale;

		// Token: 0x04000FC9 RID: 4041
		internal static int __PropertyOffset_ComponentLinearAccScale;

		// Token: 0x04000FCA RID: 4042
		internal static int __PropertyOffset_ComponentLinearVelScale;

		// Token: 0x04000FCB RID: 4043
		internal static int __PropertyOffset_ComponentAppliedLinearAccClamp;

		// Token: 0x04000FCC RID: 4044
		internal static int __PropertyOffset_AngularBiasOverride;

		// Token: 0x04000FCD RID: 4045
		internal static int __PropertyOffset_NumSolverIterationsPreUpdate;

		// Token: 0x04000FCE RID: 4046
		internal static int __PropertyOffset_NumSolverIterationsPostUpdate;

		// Token: 0x04000FCF RID: 4047
		internal static int __PropertyOffset_ConstraintSetup;

		// Token: 0x04000FD0 RID: 4048
		[Nullable(2)]
		private FAnimPhysConstraintSetup _ConstraintSetup;

		// Token: 0x04000FD1 RID: 4049
		internal static int __PropertyOffset_SphericalLimits;

		// Token: 0x04000FD2 RID: 4050
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FAnimPhysSphericalLimit> _SphericalLimits;

		// Token: 0x04000FD3 RID: 4051
		internal static int __PropertyOffset_SphereCollisionRadius;

		// Token: 0x04000FD4 RID: 4052
		internal static int __PropertyOffset_ExternalForce;

		// Token: 0x04000FD5 RID: 4053
		internal static int __PropertyOffset_PlanarLimits;

		// Token: 0x04000FD6 RID: 4054
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FAnimPhysPlanarLimit> _PlanarLimits;

		// Token: 0x04000FD7 RID: 4055
		internal static int __PropertyOffset_CollisionType;

		// Token: 0x04000FD8 RID: 4056
		internal static int __PropertyOffset_SimulationSpace;

		// Token: 0x04000FD9 RID: 4057
		internal static int __PropertyOffset_bUseSphericalLimits;

		// Token: 0x04000FDA RID: 4058
		internal static byte __PropertyMask_bUseSphericalLimits;

		// Token: 0x04000FDB RID: 4059
		internal static int __PropertyOffset_bUsePlanarLimit;

		// Token: 0x04000FDC RID: 4060
		internal static byte __PropertyMask_bUsePlanarLimit;

		// Token: 0x04000FDD RID: 4061
		internal static int __PropertyOffset_bDoUpdate;

		// Token: 0x04000FDE RID: 4062
		internal static byte __PropertyMask_bDoUpdate;

		// Token: 0x04000FDF RID: 4063
		internal static int __PropertyOffset_bDoEval;

		// Token: 0x04000FE0 RID: 4064
		internal static byte __PropertyMask_bDoEval;

		// Token: 0x04000FE1 RID: 4065
		internal static int __PropertyOffset_bOverrideLinearDamping;

		// Token: 0x04000FE2 RID: 4066
		internal static byte __PropertyMask_bOverrideLinearDamping;

		// Token: 0x04000FE3 RID: 4067
		internal static int __PropertyOffset_bOverrideAngularBias;

		// Token: 0x04000FE4 RID: 4068
		internal static byte __PropertyMask_bOverrideAngularBias;

		// Token: 0x04000FE5 RID: 4069
		internal static int __PropertyOffset_bOverrideAngularDamping;

		// Token: 0x04000FE6 RID: 4070
		internal static byte __PropertyMask_bOverrideAngularDamping;

		// Token: 0x04000FE7 RID: 4071
		internal static int __PropertyOffset_bEnableWind;

		// Token: 0x04000FE8 RID: 4072
		internal static byte __PropertyMask_bEnableWind;

		// Token: 0x04000FE9 RID: 4073
		internal static int __PropertyOffset_bUseGravityOverride;

		// Token: 0x04000FEA RID: 4074
		internal static byte __PropertyMask_bUseGravityOverride;

		// Token: 0x04000FEB RID: 4075
		internal static int __PropertyOffset_bLinearSpring;

		// Token: 0x04000FEC RID: 4076
		internal static byte __PropertyMask_bLinearSpring;

		// Token: 0x04000FED RID: 4077
		internal static int __PropertyOffset_bAngularSpring;

		// Token: 0x04000FEE RID: 4078
		internal static byte __PropertyMask_bAngularSpring;

		// Token: 0x04000FEF RID: 4079
		internal static int __PropertyOffset_bChain;

		// Token: 0x04000FF0 RID: 4080
		internal static byte __PropertyMask_bChain;

		// Token: 0x04000FF1 RID: 4081
		internal static int __PropertyOffset_RetargetingSettings;

		// Token: 0x04000FF2 RID: 4082
		[Nullable(2)]
		private FRotationRetargetingInfo _RetargetingSettings;
	}
}
