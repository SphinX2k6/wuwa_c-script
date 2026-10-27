using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000C1D RID: 3101
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.HierarchicalInstancedStaticMeshComponent")]
	[UnrealStructLayout(3216, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 3216)]
	public class UHierarchicalInstancedStaticMeshComponent : UInstancedStaticMeshComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06009CD2 RID: 40146 RVA: 0x000DEE91 File Offset: 0x000DD091
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UHierarchicalInstancedStaticMeshComponent._ClassPtr;
		}

		// Token: 0x06009CD3 RID: 40147 RVA: 0x000DEEA0 File Offset: 0x000DD0A0
		public UHierarchicalInstancedStaticMeshComponent() : this(BuiltinUtils.AllocNativeUObject(UHierarchicalInstancedStaticMeshComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06009CD4 RID: 40148 RVA: 0x000DEEC8 File Offset: 0x000DD0C8
		public UHierarchicalInstancedStaticMeshComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UHierarchicalInstancedStaticMeshComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002566 RID: 9574
		// (get) Token: 0x06009CD5 RID: 40149 RVA: 0x000DEEFC File Offset: 0x000DD0FC
		// (set) Token: 0x06009CD6 RID: 40150 RVA: 0x000DEF35 File Offset: 0x000DD135
		public TArray<int> SortedInstances
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._SortedInstances) == null)
				{
					result = (this._SortedInstances = new TArray<int>(base.NativePtr + (IntPtr)UHierarchicalInstancedStaticMeshComponent.__PropertyOffset_SortedInstances, this));
				}
				return result;
			}
			set
			{
				this.SortedInstances.CopyAssign(value);
			}
		}

		// Token: 0x17002567 RID: 9575
		// (get) Token: 0x06009CD7 RID: 40151 RVA: 0x000DEF44 File Offset: 0x000DD144
		// (set) Token: 0x06009CD8 RID: 40152 RVA: 0x000DEF7D File Offset: 0x000DD17D
		public TArray<int> SortedInstancesLOD
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._SortedInstancesLOD) == null)
				{
					result = (this._SortedInstancesLOD = new TArray<int>(base.NativePtr + (IntPtr)UHierarchicalInstancedStaticMeshComponent.__PropertyOffset_SortedInstancesLOD, this));
				}
				return result;
			}
			set
			{
				this.SortedInstancesLOD.CopyAssign(value);
			}
		}

		// Token: 0x17002568 RID: 9576
		// (get) Token: 0x06009CD9 RID: 40153 RVA: 0x000DEF8B File Offset: 0x000DD18B
		// (set) Token: 0x06009CDA RID: 40154 RVA: 0x000DEF9B File Offset: 0x000DD19B
		public unsafe int NumBuiltInstances
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHierarchicalInstancedStaticMeshComponent.__PropertyOffset_NumBuiltInstances);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHierarchicalInstancedStaticMeshComponent.__PropertyOffset_NumBuiltInstances) = value;
			}
		}

		// Token: 0x17002569 RID: 9577
		// (get) Token: 0x06009CDB RID: 40155 RVA: 0x000DEFAC File Offset: 0x000DD1AC
		// (set) Token: 0x06009CDC RID: 40156 RVA: 0x000DEFBC File Offset: 0x000DD1BC
		public unsafe int NumBuiltInstancesLOD
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHierarchicalInstancedStaticMeshComponent.__PropertyOffset_NumBuiltInstancesLOD);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHierarchicalInstancedStaticMeshComponent.__PropertyOffset_NumBuiltInstancesLOD) = value;
			}
		}

		// Token: 0x1700256A RID: 9578
		// (get) Token: 0x06009CDD RID: 40157 RVA: 0x000DEFCD File Offset: 0x000DD1CD
		// (set) Token: 0x06009CDE RID: 40158 RVA: 0x000DEFE1 File Offset: 0x000DD1E1
		public unsafe FBox BuiltInstanceBounds
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHierarchicalInstancedStaticMeshComponent.__PropertyOffset_BuiltInstanceBounds);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHierarchicalInstancedStaticMeshComponent.__PropertyOffset_BuiltInstanceBounds) = value;
			}
		}

		// Token: 0x1700256B RID: 9579
		// (get) Token: 0x06009CDF RID: 40159 RVA: 0x000DEFF6 File Offset: 0x000DD1F6
		// (set) Token: 0x06009CE0 RID: 40160 RVA: 0x000DF00A File Offset: 0x000DD20A
		public unsafe FBox UnbuiltInstanceBounds
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHierarchicalInstancedStaticMeshComponent.__PropertyOffset_UnbuiltInstanceBounds);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHierarchicalInstancedStaticMeshComponent.__PropertyOffset_UnbuiltInstanceBounds) = value;
			}
		}

		// Token: 0x1700256C RID: 9580
		// (get) Token: 0x06009CE1 RID: 40161 RVA: 0x000DF020 File Offset: 0x000DD220
		// (set) Token: 0x06009CE2 RID: 40162 RVA: 0x000DF059 File Offset: 0x000DD259
		public TArray<FBox> UnbuiltInstanceBoundsList
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FBox> result;
				if ((result = this._UnbuiltInstanceBoundsList) == null)
				{
					result = (this._UnbuiltInstanceBoundsList = new TArray<FBox>(base.NativePtr + (IntPtr)UHierarchicalInstancedStaticMeshComponent.__PropertyOffset_UnbuiltInstanceBoundsList, this));
				}
				return result;
			}
			set
			{
				this.UnbuiltInstanceBoundsList.CopyAssign(value);
			}
		}

		// Token: 0x1700256D RID: 9581
		// (get) Token: 0x06009CE3 RID: 40163 RVA: 0x000DF067 File Offset: 0x000DD267
		// (set) Token: 0x06009CE4 RID: 40164 RVA: 0x000DF077 File Offset: 0x000DD277
		public unsafe int BuiltBranchingFactor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHierarchicalInstancedStaticMeshComponent.__PropertyOffset_BuiltBranchingFactor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHierarchicalInstancedStaticMeshComponent.__PropertyOffset_BuiltBranchingFactor) = value;
			}
		}

		// Token: 0x1700256E RID: 9582
		// (get) Token: 0x06009CE5 RID: 40165 RVA: 0x000DF088 File Offset: 0x000DD288
		// (set) Token: 0x06009CE6 RID: 40166 RVA: 0x000DF098 File Offset: 0x000DD298
		public unsafe int BuiltMinSplitVertices
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHierarchicalInstancedStaticMeshComponent.__PropertyOffset_BuiltMinSplitVertices);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHierarchicalInstancedStaticMeshComponent.__PropertyOffset_BuiltMinSplitVertices) = value;
			}
		}

		// Token: 0x1700256F RID: 9583
		// (get) Token: 0x06009CE7 RID: 40167 RVA: 0x000DF0A9 File Offset: 0x000DD2A9
		// (set) Token: 0x06009CE8 RID: 40168 RVA: 0x000DF0C2 File Offset: 0x000DD2C2
		public unsafe bool bEnableDensityScaling
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UHierarchicalInstancedStaticMeshComponent.__PropertyOffset_bEnableDensityScaling) & UHierarchicalInstancedStaticMeshComponent.__PropertyMask_bEnableDensityScaling) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UHierarchicalInstancedStaticMeshComponent.__PropertyOffset_bEnableDensityScaling) = ((*(base.NativePtr + (IntPtr)UHierarchicalInstancedStaticMeshComponent.__PropertyOffset_bEnableDensityScaling) & ~UHierarchicalInstancedStaticMeshComponent.__PropertyMask_bEnableDensityScaling) | (value ? UHierarchicalInstancedStaticMeshComponent.__PropertyMask_bEnableDensityScaling : 0));
			}
		}

		// Token: 0x17002570 RID: 9584
		// (get) Token: 0x06009CE9 RID: 40169 RVA: 0x000DF0F2 File Offset: 0x000DD2F2
		// (set) Token: 0x06009CEA RID: 40170 RVA: 0x000DF10B File Offset: 0x000DD30B
		public unsafe bool bEnableDensityScalingLOD
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UHierarchicalInstancedStaticMeshComponent.__PropertyOffset_bEnableDensityScalingLOD) & UHierarchicalInstancedStaticMeshComponent.__PropertyMask_bEnableDensityScalingLOD) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UHierarchicalInstancedStaticMeshComponent.__PropertyOffset_bEnableDensityScalingLOD) = ((*(base.NativePtr + (IntPtr)UHierarchicalInstancedStaticMeshComponent.__PropertyOffset_bEnableDensityScalingLOD) & ~UHierarchicalInstancedStaticMeshComponent.__PropertyMask_bEnableDensityScalingLOD) | (value ? UHierarchicalInstancedStaticMeshComponent.__PropertyMask_bEnableDensityScalingLOD : 0));
			}
		}

		// Token: 0x17002571 RID: 9585
		// (get) Token: 0x06009CEB RID: 40171 RVA: 0x000DF13C File Offset: 0x000DD33C
		// (set) Token: 0x06009CEC RID: 40172 RVA: 0x000DF175 File Offset: 0x000DD375
		public FPerPlatformFloat FoliageDensityLowLOD
		{
			get
			{
				base.FastCheckIsValid();
				FPerPlatformFloat result;
				if ((result = this._FoliageDensityLowLOD) == null)
				{
					result = (this._FoliageDensityLowLOD = new FPerPlatformFloat(base.NativePtr + (IntPtr)UHierarchicalInstancedStaticMeshComponent.__PropertyOffset_FoliageDensityLowLOD, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FPerPlatformFloat.StaticStruct(), base.NativePtr + (IntPtr)UHierarchicalInstancedStaticMeshComponent.__PropertyOffset_FoliageDensityLowLOD, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002572 RID: 9586
		// (get) Token: 0x06009CED RID: 40173 RVA: 0x000DF198 File Offset: 0x000DD398
		// (set) Token: 0x06009CEE RID: 40174 RVA: 0x000DF1D1 File Offset: 0x000DD3D1
		public FPerPlatformFloat FoliageDensityMiddleLOD
		{
			get
			{
				base.FastCheckIsValid();
				FPerPlatformFloat result;
				if ((result = this._FoliageDensityMiddleLOD) == null)
				{
					result = (this._FoliageDensityMiddleLOD = new FPerPlatformFloat(base.NativePtr + (IntPtr)UHierarchicalInstancedStaticMeshComponent.__PropertyOffset_FoliageDensityMiddleLOD, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FPerPlatformFloat.StaticStruct(), base.NativePtr + (IntPtr)UHierarchicalInstancedStaticMeshComponent.__PropertyOffset_FoliageDensityMiddleLOD, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002573 RID: 9587
		// (get) Token: 0x06009CEF RID: 40175 RVA: 0x000DF1F4 File Offset: 0x000DD3F4
		// (set) Token: 0x06009CF0 RID: 40176 RVA: 0x000DF22D File Offset: 0x000DD42D
		public FPerPlatformFloat FoliageDensityHighLOD
		{
			get
			{
				base.FastCheckIsValid();
				FPerPlatformFloat result;
				if ((result = this._FoliageDensityHighLOD) == null)
				{
					result = (this._FoliageDensityHighLOD = new FPerPlatformFloat(base.NativePtr + (IntPtr)UHierarchicalInstancedStaticMeshComponent.__PropertyOffset_FoliageDensityHighLOD, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FPerPlatformFloat.StaticStruct(), base.NativePtr + (IntPtr)UHierarchicalInstancedStaticMeshComponent.__PropertyOffset_FoliageDensityHighLOD, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002574 RID: 9588
		// (get) Token: 0x06009CF1 RID: 40177 RVA: 0x000DF250 File Offset: 0x000DD450
		// (set) Token: 0x06009CF2 RID: 40178 RVA: 0x000DF289 File Offset: 0x000DD489
		public FPerPlatformFloat FoliageDensityScaleLODDistanceLow
		{
			get
			{
				base.FastCheckIsValid();
				FPerPlatformFloat result;
				if ((result = this._FoliageDensityScaleLODDistanceLow) == null)
				{
					result = (this._FoliageDensityScaleLODDistanceLow = new FPerPlatformFloat(base.NativePtr + (IntPtr)UHierarchicalInstancedStaticMeshComponent.__PropertyOffset_FoliageDensityScaleLODDistanceLow, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FPerPlatformFloat.StaticStruct(), base.NativePtr + (IntPtr)UHierarchicalInstancedStaticMeshComponent.__PropertyOffset_FoliageDensityScaleLODDistanceLow, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002575 RID: 9589
		// (get) Token: 0x06009CF3 RID: 40179 RVA: 0x000DF2AC File Offset: 0x000DD4AC
		// (set) Token: 0x06009CF4 RID: 40180 RVA: 0x000DF2E5 File Offset: 0x000DD4E5
		public FPerPlatformFloat FoliageDensityScaleLODDistanceMiddle
		{
			get
			{
				base.FastCheckIsValid();
				FPerPlatformFloat result;
				if ((result = this._FoliageDensityScaleLODDistanceMiddle) == null)
				{
					result = (this._FoliageDensityScaleLODDistanceMiddle = new FPerPlatformFloat(base.NativePtr + (IntPtr)UHierarchicalInstancedStaticMeshComponent.__PropertyOffset_FoliageDensityScaleLODDistanceMiddle, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FPerPlatformFloat.StaticStruct(), base.NativePtr + (IntPtr)UHierarchicalInstancedStaticMeshComponent.__PropertyOffset_FoliageDensityScaleLODDistanceMiddle, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002576 RID: 9590
		// (get) Token: 0x06009CF5 RID: 40181 RVA: 0x000DF308 File Offset: 0x000DD508
		// (set) Token: 0x06009CF6 RID: 40182 RVA: 0x000DF341 File Offset: 0x000DD541
		public FPerPlatformFloat FoliageDensityScaleLODDistanceHigh
		{
			get
			{
				base.FastCheckIsValid();
				FPerPlatformFloat result;
				if ((result = this._FoliageDensityScaleLODDistanceHigh) == null)
				{
					result = (this._FoliageDensityScaleLODDistanceHigh = new FPerPlatformFloat(base.NativePtr + (IntPtr)UHierarchicalInstancedStaticMeshComponent.__PropertyOffset_FoliageDensityScaleLODDistanceHigh, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FPerPlatformFloat.StaticStruct(), base.NativePtr + (IntPtr)UHierarchicalInstancedStaticMeshComponent.__PropertyOffset_FoliageDensityScaleLODDistanceHigh, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002577 RID: 9591
		// (get) Token: 0x06009CF7 RID: 40183 RVA: 0x000DF362 File Offset: 0x000DD562
		// (set) Token: 0x06009CF8 RID: 40184 RVA: 0x000DF372 File Offset: 0x000DD572
		public unsafe int OcclusionLayerNumNodes
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHierarchicalInstancedStaticMeshComponent.__PropertyOffset_OcclusionLayerNumNodes);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHierarchicalInstancedStaticMeshComponent.__PropertyOffset_OcclusionLayerNumNodes) = value;
			}
		}

		// Token: 0x17002578 RID: 9592
		// (get) Token: 0x06009CF9 RID: 40185 RVA: 0x000DF383 File Offset: 0x000DD583
		// (set) Token: 0x06009CFA RID: 40186 RVA: 0x000DF397 File Offset: 0x000DD597
		public unsafe FBoxSphereBounds CacheMeshExtendedBounds
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHierarchicalInstancedStaticMeshComponent.__PropertyOffset_CacheMeshExtendedBounds);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHierarchicalInstancedStaticMeshComponent.__PropertyOffset_CacheMeshExtendedBounds) = value;
			}
		}

		// Token: 0x17002579 RID: 9593
		// (get) Token: 0x06009CFB RID: 40187 RVA: 0x000DF3AC File Offset: 0x000DD5AC
		// (set) Token: 0x06009CFC RID: 40188 RVA: 0x000DF3BC File Offset: 0x000DD5BC
		public unsafe bool bDisableCollision
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHierarchicalInstancedStaticMeshComponent.__PropertyOffset_bDisableCollision) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHierarchicalInstancedStaticMeshComponent.__PropertyOffset_bDisableCollision) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700257A RID: 9594
		// (get) Token: 0x06009CFD RID: 40189 RVA: 0x000DF3CD File Offset: 0x000DD5CD
		// (set) Token: 0x06009CFE RID: 40190 RVA: 0x000DF3DD File Offset: 0x000DD5DD
		public unsafe int InstanceCountToRender
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHierarchicalInstancedStaticMeshComponent.__PropertyOffset_InstanceCountToRender);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHierarchicalInstancedStaticMeshComponent.__PropertyOffset_InstanceCountToRender) = value;
			}
		}

		// Token: 0x1700257B RID: 9595
		// (get) Token: 0x06009CFF RID: 40191 RVA: 0x000DF3EE File Offset: 0x000DD5EE
		// (set) Token: 0x06009D00 RID: 40192 RVA: 0x000DF3FE File Offset: 0x000DD5FE
		public unsafe bool bUseKuroFoliageSplitFactor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHierarchicalInstancedStaticMeshComponent.__PropertyOffset_bUseKuroFoliageSplitFactor) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHierarchicalInstancedStaticMeshComponent.__PropertyOffset_bUseKuroFoliageSplitFactor) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700257C RID: 9596
		// (get) Token: 0x06009D01 RID: 40193 RVA: 0x000DF40F File Offset: 0x000DD60F
		// (set) Token: 0x06009D02 RID: 40194 RVA: 0x000DF41F File Offset: 0x000DD61F
		public unsafe bool bUseKuroMinVertsToSplitNode
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHierarchicalInstancedStaticMeshComponent.__PropertyOffset_bUseKuroMinVertsToSplitNode) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHierarchicalInstancedStaticMeshComponent.__PropertyOffset_bUseKuroMinVertsToSplitNode) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700257D RID: 9597
		// (get) Token: 0x06009D03 RID: 40195 RVA: 0x000DF430 File Offset: 0x000DD630
		// (set) Token: 0x06009D04 RID: 40196 RVA: 0x000DF440 File Offset: 0x000DD640
		public unsafe int KuroFoliageSplitFactor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHierarchicalInstancedStaticMeshComponent.__PropertyOffset_KuroFoliageSplitFactor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHierarchicalInstancedStaticMeshComponent.__PropertyOffset_KuroFoliageSplitFactor) = value;
			}
		}

		// Token: 0x1700257E RID: 9598
		// (get) Token: 0x06009D05 RID: 40197 RVA: 0x000DF451 File Offset: 0x000DD651
		// (set) Token: 0x06009D06 RID: 40198 RVA: 0x000DF461 File Offset: 0x000DD661
		public unsafe int KuroMinVertsToSplitNde
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHierarchicalInstancedStaticMeshComponent.__PropertyOffset_KuroMinVertsToSplitNde);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHierarchicalInstancedStaticMeshComponent.__PropertyOffset_KuroMinVertsToSplitNde) = value;
			}
		}

		// Token: 0x1700257F RID: 9599
		// (get) Token: 0x06009D07 RID: 40199 RVA: 0x000DF472 File Offset: 0x000DD672
		// (set) Token: 0x06009D08 RID: 40200 RVA: 0x000DF482 File Offset: 0x000DD682
		public unsafe int KuroFoliageForceShadowLOD
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHierarchicalInstancedStaticMeshComponent.__PropertyOffset_KuroFoliageForceShadowLOD);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHierarchicalInstancedStaticMeshComponent.__PropertyOffset_KuroFoliageForceShadowLOD) = value;
			}
		}

		// Token: 0x06009D09 RID: 40201 RVA: 0x000DF493 File Offset: 0x000DD693
		public void SetKuroFoliageSplitParam(bool bUseFoliageSPlitFactor, int foliageSplitFactor, bool bUseMinVertsSplitNode, int minVertsSplitNode)
		{
			UHierarchicalInstancedStaticMeshComponent.__SetKuroFoliageSplitParam_Internal(base.NativePtr, bUseFoliageSPlitFactor, foliageSplitFactor, bUseMinVertsSplitNode, minVertsSplitNode);
		}

		// Token: 0x06009D0A RID: 40202 RVA: 0x000DF4A5 File Offset: 0x000DD6A5
		public void SetKuroFoliageForceShadowLOD(int FoliageForceShadowLOD)
		{
			UHierarchicalInstancedStaticMeshComponent.__SetKuroFoliageForceShadowLOD_Internal(base.NativePtr, FoliageForceShadowLOD);
		}

		// Token: 0x06009D0B RID: 40203 RVA: 0x000DF4B3 File Offset: 0x000DD6B3
		[NullableContext(2)]
		public bool RemoveInstances(in TArray<int> InstancesToRemove)
		{
			return UHierarchicalInstancedStaticMeshComponent.__RemoveInstances_Internal(base.NativePtr, (InstancesToRemove ?? new TArray<int>()).NativePtr);
		}

		// Token: 0x06009D0C RID: 40204
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetKuroFoliageSplitParam_Internal(IntPtr @this, bool bUseFoliageSPlitFactor, int foliageSplitFactor, bool bUseMinVertsSplitNode, int minVertsSplitNode);

		// Token: 0x06009D0D RID: 40205
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetKuroFoliageForceShadowLOD_Internal(IntPtr @this, int FoliageForceShadowLOD);

		// Token: 0x06009D0E RID: 40206
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __RemoveInstances_Internal(IntPtr @this, IntPtr InstancesToRemove);

		// Token: 0x06009D0F RID: 40207 RVA: 0x000DF4D0 File Offset: 0x000DD6D0
		static UHierarchicalInstancedStaticMeshComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.HierarchicalInstancedStaticMeshComponent");
		}

		// Token: 0x06009D10 RID: 40208 RVA: 0x000DF4DE File Offset: 0x000DD6DE
		protected UHierarchicalInstancedStaticMeshComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04005682 RID: 22146
		public new const string __ObjectPath = "/Script/Engine.HierarchicalInstancedStaticMeshComponent";

		// Token: 0x04005683 RID: 22147
		private static IntPtr _ClassPtr;

		// Token: 0x04005684 RID: 22148
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04005685 RID: 22149
		internal static int __PropertyOffset_SortedInstances;

		// Token: 0x04005686 RID: 22150
		[Nullable(2)]
		private TArray<int> _SortedInstances;

		// Token: 0x04005687 RID: 22151
		internal static int __PropertyOffset_SortedInstancesLOD;

		// Token: 0x04005688 RID: 22152
		[Nullable(2)]
		private TArray<int> _SortedInstancesLOD;

		// Token: 0x04005689 RID: 22153
		internal static int __PropertyOffset_NumBuiltInstances;

		// Token: 0x0400568A RID: 22154
		internal static int __PropertyOffset_NumBuiltInstancesLOD;

		// Token: 0x0400568B RID: 22155
		internal static int __PropertyOffset_BuiltInstanceBounds;

		// Token: 0x0400568C RID: 22156
		internal static int __PropertyOffset_UnbuiltInstanceBounds;

		// Token: 0x0400568D RID: 22157
		internal static int __PropertyOffset_UnbuiltInstanceBoundsList;

		// Token: 0x0400568E RID: 22158
		[Nullable(2)]
		private TArray<FBox> _UnbuiltInstanceBoundsList;

		// Token: 0x0400568F RID: 22159
		internal static int __PropertyOffset_BuiltBranchingFactor;

		// Token: 0x04005690 RID: 22160
		internal static int __PropertyOffset_BuiltMinSplitVertices;

		// Token: 0x04005691 RID: 22161
		internal static int __PropertyOffset_bEnableDensityScaling;

		// Token: 0x04005692 RID: 22162
		internal static byte __PropertyMask_bEnableDensityScaling;

		// Token: 0x04005693 RID: 22163
		internal static int __PropertyOffset_bEnableDensityScalingLOD;

		// Token: 0x04005694 RID: 22164
		internal static byte __PropertyMask_bEnableDensityScalingLOD;

		// Token: 0x04005695 RID: 22165
		internal static int __PropertyOffset_FoliageDensityLowLOD;

		// Token: 0x04005696 RID: 22166
		[Nullable(2)]
		private FPerPlatformFloat _FoliageDensityLowLOD;

		// Token: 0x04005697 RID: 22167
		internal static int __PropertyOffset_FoliageDensityMiddleLOD;

		// Token: 0x04005698 RID: 22168
		[Nullable(2)]
		private FPerPlatformFloat _FoliageDensityMiddleLOD;

		// Token: 0x04005699 RID: 22169
		internal static int __PropertyOffset_FoliageDensityHighLOD;

		// Token: 0x0400569A RID: 22170
		[Nullable(2)]
		private FPerPlatformFloat _FoliageDensityHighLOD;

		// Token: 0x0400569B RID: 22171
		internal static int __PropertyOffset_FoliageDensityScaleLODDistanceLow;

		// Token: 0x0400569C RID: 22172
		[Nullable(2)]
		private FPerPlatformFloat _FoliageDensityScaleLODDistanceLow;

		// Token: 0x0400569D RID: 22173
		internal static int __PropertyOffset_FoliageDensityScaleLODDistanceMiddle;

		// Token: 0x0400569E RID: 22174
		[Nullable(2)]
		private FPerPlatformFloat _FoliageDensityScaleLODDistanceMiddle;

		// Token: 0x0400569F RID: 22175
		internal static int __PropertyOffset_FoliageDensityScaleLODDistanceHigh;

		// Token: 0x040056A0 RID: 22176
		[Nullable(2)]
		private FPerPlatformFloat _FoliageDensityScaleLODDistanceHigh;

		// Token: 0x040056A1 RID: 22177
		internal static int __PropertyOffset_OcclusionLayerNumNodes;

		// Token: 0x040056A2 RID: 22178
		internal static int __PropertyOffset_CacheMeshExtendedBounds;

		// Token: 0x040056A3 RID: 22179
		internal static int __PropertyOffset_bDisableCollision;

		// Token: 0x040056A4 RID: 22180
		internal static int __PropertyOffset_InstanceCountToRender;

		// Token: 0x040056A5 RID: 22181
		internal static int __PropertyOffset_bUseKuroFoliageSplitFactor;

		// Token: 0x040056A6 RID: 22182
		internal static int __PropertyOffset_bUseKuroMinVertsToSplitNode;

		// Token: 0x040056A7 RID: 22183
		internal static int __PropertyOffset_KuroFoliageSplitFactor;

		// Token: 0x040056A8 RID: 22184
		internal static int __PropertyOffset_KuroMinVertsToSplitNde;

		// Token: 0x040056A9 RID: 22185
		internal static int __PropertyOffset_KuroFoliageForceShadowLOD;
	}
}
