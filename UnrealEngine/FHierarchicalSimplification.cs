using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000C1F RID: 3103
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.HierarchicalSimplification")]
	[UnrealStructLayout(380, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 380)]
	public class FHierarchicalSimplification : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06009D1A RID: 40218 RVA: 0x000DF5E8 File Offset: 0x000DD7E8
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FHierarchicalSimplification._ScriptStructPtr != 0) ? FHierarchicalSimplification._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.HierarchicalSimplification", ref FHierarchicalSimplification._ScriptStructPtr);
		}

		// Token: 0x17002582 RID: 9602
		// (get) Token: 0x06009D1B RID: 40219 RVA: 0x000DF60C File Offset: 0x000DD80C
		// (set) Token: 0x06009D1C RID: 40220 RVA: 0x000DF61C File Offset: 0x000DD81C
		public unsafe float TransitionScreenSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FHierarchicalSimplification.__PropertyOffset_TransitionScreenSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FHierarchicalSimplification.__PropertyOffset_TransitionScreenSize) = value;
			}
		}

		// Token: 0x17002583 RID: 9603
		// (get) Token: 0x06009D1D RID: 40221 RVA: 0x000DF62D File Offset: 0x000DD82D
		// (set) Token: 0x06009D1E RID: 40222 RVA: 0x000DF63D File Offset: 0x000DD83D
		public unsafe float OverrideDrawDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FHierarchicalSimplification.__PropertyOffset_OverrideDrawDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FHierarchicalSimplification.__PropertyOffset_OverrideDrawDistance) = value;
			}
		}

		// Token: 0x17002584 RID: 9604
		// (get) Token: 0x06009D1F RID: 40223 RVA: 0x000DF64E File Offset: 0x000DD84E
		// (set) Token: 0x06009D20 RID: 40224 RVA: 0x000DF667 File Offset: 0x000DD867
		public unsafe bool bUseOverrideDrawDistance
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FHierarchicalSimplification.__PropertyOffset_bUseOverrideDrawDistance) & FHierarchicalSimplification.__PropertyMask_bUseOverrideDrawDistance) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FHierarchicalSimplification.__PropertyOffset_bUseOverrideDrawDistance) = ((*(base.NativePtr + (IntPtr)FHierarchicalSimplification.__PropertyOffset_bUseOverrideDrawDistance) & ~FHierarchicalSimplification.__PropertyMask_bUseOverrideDrawDistance) | (value ? FHierarchicalSimplification.__PropertyMask_bUseOverrideDrawDistance : 0));
			}
		}

		// Token: 0x17002585 RID: 9605
		// (get) Token: 0x06009D21 RID: 40225 RVA: 0x000DF697 File Offset: 0x000DD897
		// (set) Token: 0x06009D22 RID: 40226 RVA: 0x000DF6B0 File Offset: 0x000DD8B0
		public unsafe bool bAllowSpecificExclusion
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FHierarchicalSimplification.__PropertyOffset_bAllowSpecificExclusion) & FHierarchicalSimplification.__PropertyMask_bAllowSpecificExclusion) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FHierarchicalSimplification.__PropertyOffset_bAllowSpecificExclusion) = ((*(base.NativePtr + (IntPtr)FHierarchicalSimplification.__PropertyOffset_bAllowSpecificExclusion) & ~FHierarchicalSimplification.__PropertyMask_bAllowSpecificExclusion) | (value ? FHierarchicalSimplification.__PropertyMask_bAllowSpecificExclusion : 0));
			}
		}

		// Token: 0x17002586 RID: 9606
		// (get) Token: 0x06009D23 RID: 40227 RVA: 0x000DF6E0 File Offset: 0x000DD8E0
		// (set) Token: 0x06009D24 RID: 40228 RVA: 0x000DF6F9 File Offset: 0x000DD8F9
		public unsafe bool bSimplifyMesh
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FHierarchicalSimplification.__PropertyOffset_bSimplifyMesh) & FHierarchicalSimplification.__PropertyMask_bSimplifyMesh) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FHierarchicalSimplification.__PropertyOffset_bSimplifyMesh) = ((*(base.NativePtr + (IntPtr)FHierarchicalSimplification.__PropertyOffset_bSimplifyMesh) & ~FHierarchicalSimplification.__PropertyMask_bSimplifyMesh) | (value ? FHierarchicalSimplification.__PropertyMask_bSimplifyMesh : 0));
			}
		}

		// Token: 0x17002587 RID: 9607
		// (get) Token: 0x06009D25 RID: 40229 RVA: 0x000DF729 File Offset: 0x000DD929
		// (set) Token: 0x06009D26 RID: 40230 RVA: 0x000DF742 File Offset: 0x000DD942
		public unsafe bool bOnlyGenerateClustersForVolumes
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FHierarchicalSimplification.__PropertyOffset_bOnlyGenerateClustersForVolumes) & FHierarchicalSimplification.__PropertyMask_bOnlyGenerateClustersForVolumes) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FHierarchicalSimplification.__PropertyOffset_bOnlyGenerateClustersForVolumes) = ((*(base.NativePtr + (IntPtr)FHierarchicalSimplification.__PropertyOffset_bOnlyGenerateClustersForVolumes) & ~FHierarchicalSimplification.__PropertyMask_bOnlyGenerateClustersForVolumes) | (value ? FHierarchicalSimplification.__PropertyMask_bOnlyGenerateClustersForVolumes : 0));
			}
		}

		// Token: 0x17002588 RID: 9608
		// (get) Token: 0x06009D27 RID: 40231 RVA: 0x000DF772 File Offset: 0x000DD972
		// (set) Token: 0x06009D28 RID: 40232 RVA: 0x000DF78B File Offset: 0x000DD98B
		public unsafe bool bReusePreviousLevelClusters
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FHierarchicalSimplification.__PropertyOffset_bReusePreviousLevelClusters) & FHierarchicalSimplification.__PropertyMask_bReusePreviousLevelClusters) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FHierarchicalSimplification.__PropertyOffset_bReusePreviousLevelClusters) = ((*(base.NativePtr + (IntPtr)FHierarchicalSimplification.__PropertyOffset_bReusePreviousLevelClusters) & ~FHierarchicalSimplification.__PropertyMask_bReusePreviousLevelClusters) | (value ? FHierarchicalSimplification.__PropertyMask_bReusePreviousLevelClusters : 0));
			}
		}

		// Token: 0x17002589 RID: 9609
		// (get) Token: 0x06009D29 RID: 40233 RVA: 0x000DF7BC File Offset: 0x000DD9BC
		// (set) Token: 0x06009D2A RID: 40234 RVA: 0x000DF7FF File Offset: 0x000DD9FF
		public FMeshProxySettings ProxySetting
		{
			get
			{
				base.FastCheckIsValid();
				FMeshProxySettings result;
				if ((result = this._ProxySetting) == null)
				{
					result = (this._ProxySetting = new FMeshProxySettings(base.NativePtr + (IntPtr)FHierarchicalSimplification.__PropertyOffset_ProxySetting, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMeshProxySettings.StaticStruct(), base.NativePtr + (IntPtr)FHierarchicalSimplification.__PropertyOffset_ProxySetting, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700258A RID: 9610
		// (get) Token: 0x06009D2B RID: 40235 RVA: 0x000DF820 File Offset: 0x000DDA20
		// (set) Token: 0x06009D2C RID: 40236 RVA: 0x000DF863 File Offset: 0x000DDA63
		public FMeshMergingSettings MergeSetting
		{
			get
			{
				base.FastCheckIsValid();
				FMeshMergingSettings result;
				if ((result = this._MergeSetting) == null)
				{
					result = (this._MergeSetting = new FMeshMergingSettings(base.NativePtr + (IntPtr)FHierarchicalSimplification.__PropertyOffset_MergeSetting, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMeshMergingSettings.StaticStruct(), base.NativePtr + (IntPtr)FHierarchicalSimplification.__PropertyOffset_MergeSetting, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700258B RID: 9611
		// (get) Token: 0x06009D2D RID: 40237 RVA: 0x000DF884 File Offset: 0x000DDA84
		// (set) Token: 0x06009D2E RID: 40238 RVA: 0x000DF894 File Offset: 0x000DDA94
		public unsafe float DesiredBoundRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FHierarchicalSimplification.__PropertyOffset_DesiredBoundRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FHierarchicalSimplification.__PropertyOffset_DesiredBoundRadius) = value;
			}
		}

		// Token: 0x1700258C RID: 9612
		// (get) Token: 0x06009D2F RID: 40239 RVA: 0x000DF8A5 File Offset: 0x000DDAA5
		// (set) Token: 0x06009D30 RID: 40240 RVA: 0x000DF8B5 File Offset: 0x000DDAB5
		public unsafe float DesiredFillingPercentage
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FHierarchicalSimplification.__PropertyOffset_DesiredFillingPercentage);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FHierarchicalSimplification.__PropertyOffset_DesiredFillingPercentage) = value;
			}
		}

		// Token: 0x1700258D RID: 9613
		// (get) Token: 0x06009D31 RID: 40241 RVA: 0x000DF8C6 File Offset: 0x000DDAC6
		// (set) Token: 0x06009D32 RID: 40242 RVA: 0x000DF8D6 File Offset: 0x000DDAD6
		public unsafe int MinNumberOfActorsToBuild
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FHierarchicalSimplification.__PropertyOffset_MinNumberOfActorsToBuild);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FHierarchicalSimplification.__PropertyOffset_MinNumberOfActorsToBuild) = value;
			}
		}

		// Token: 0x06009D33 RID: 40243 RVA: 0x000DF8E7 File Offset: 0x000DDAE7
		public FHierarchicalSimplification()
		{
		}

		// Token: 0x06009D34 RID: 40244 RVA: 0x000DF8F0 File Offset: 0x000DDAF0
		public FHierarchicalSimplification(float TransitionScreenSize, float OverrideDrawDistance, bool bUseOverrideDrawDistance, bool bAllowSpecificExclusion, bool bSimplifyMesh, bool bOnlyGenerateClustersForVolumes, bool bReusePreviousLevelClusters, FMeshProxySettings ProxySetting, FMeshMergingSettings MergeSetting, float DesiredBoundRadius, float DesiredFillingPercentage, int MinNumberOfActorsToBuild)
		{
			this.TransitionScreenSize = TransitionScreenSize;
			this.OverrideDrawDistance = OverrideDrawDistance;
			this.bUseOverrideDrawDistance = bUseOverrideDrawDistance;
			this.bAllowSpecificExclusion = bAllowSpecificExclusion;
			this.bSimplifyMesh = bSimplifyMesh;
			this.bOnlyGenerateClustersForVolumes = bOnlyGenerateClustersForVolumes;
			this.bReusePreviousLevelClusters = bReusePreviousLevelClusters;
			this.ProxySetting = ProxySetting;
			this.MergeSetting = MergeSetting;
			this.DesiredBoundRadius = DesiredBoundRadius;
			this.DesiredFillingPercentage = DesiredFillingPercentage;
			this.MinNumberOfActorsToBuild = MinNumberOfActorsToBuild;
		}

		// Token: 0x06009D35 RID: 40245 RVA: 0x000DF960 File Offset: 0x000DDB60
		protected override IntPtr GetUStructPtr()
		{
			return FHierarchicalSimplification.StaticStruct();
		}

		// Token: 0x06009D36 RID: 40246 RVA: 0x000DF96C File Offset: 0x000DDB6C
		[NullableContext(2)]
		public FHierarchicalSimplification(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06009D37 RID: 40247 RVA: 0x000DF976 File Offset: 0x000DDB76
		public FHierarchicalSimplification(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06009D38 RID: 40248 RVA: 0x000DF981 File Offset: 0x000DDB81
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FHierarchicalSimplification(Pointer, false, true);
		}

		// Token: 0x06009D39 RID: 40249 RVA: 0x000DF98B File Offset: 0x000DDB8B
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FHierarchicalSimplification(Pointer, MemoryOwner);
		}

		// Token: 0x040056B0 RID: 22192
		public const string __ObjectPath = "/Script/Engine.HierarchicalSimplification";

		// Token: 0x040056B1 RID: 22193
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040056B2 RID: 22194
		internal static int __PropertyOffset_TransitionScreenSize;

		// Token: 0x040056B3 RID: 22195
		internal static int __PropertyOffset_OverrideDrawDistance;

		// Token: 0x040056B4 RID: 22196
		internal static int __PropertyOffset_bUseOverrideDrawDistance;

		// Token: 0x040056B5 RID: 22197
		internal static byte __PropertyMask_bUseOverrideDrawDistance;

		// Token: 0x040056B6 RID: 22198
		internal static int __PropertyOffset_bAllowSpecificExclusion;

		// Token: 0x040056B7 RID: 22199
		internal static byte __PropertyMask_bAllowSpecificExclusion;

		// Token: 0x040056B8 RID: 22200
		internal static int __PropertyOffset_bSimplifyMesh;

		// Token: 0x040056B9 RID: 22201
		internal static byte __PropertyMask_bSimplifyMesh;

		// Token: 0x040056BA RID: 22202
		internal static int __PropertyOffset_bOnlyGenerateClustersForVolumes;

		// Token: 0x040056BB RID: 22203
		internal static byte __PropertyMask_bOnlyGenerateClustersForVolumes;

		// Token: 0x040056BC RID: 22204
		internal static int __PropertyOffset_bReusePreviousLevelClusters;

		// Token: 0x040056BD RID: 22205
		internal static byte __PropertyMask_bReusePreviousLevelClusters;

		// Token: 0x040056BE RID: 22206
		internal static int __PropertyOffset_ProxySetting;

		// Token: 0x040056BF RID: 22207
		[Nullable(2)]
		private FMeshProxySettings _ProxySetting;

		// Token: 0x040056C0 RID: 22208
		internal static int __PropertyOffset_MergeSetting;

		// Token: 0x040056C1 RID: 22209
		[Nullable(2)]
		private FMeshMergingSettings _MergeSetting;

		// Token: 0x040056C2 RID: 22210
		internal static int __PropertyOffset_DesiredBoundRadius;

		// Token: 0x040056C3 RID: 22211
		internal static int __PropertyOffset_DesiredFillingPercentage;

		// Token: 0x040056C4 RID: 22212
		internal static int __PropertyOffset_MinNumberOfActorsToBuild;
	}
}
