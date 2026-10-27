using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000D0F RID: 3343
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.KuroStaticMeshFolderCheckConfig")]
	[UnrealStructLayout(96, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 96)]
	public class FKuroStaticMeshFolderCheckConfig : FKuroBaseFolderCheckConfig, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600B2BD RID: 45757 RVA: 0x000FE81A File Offset: 0x000FCA1A
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroStaticMeshFolderCheckConfig._ScriptStructPtr != 0) ? FKuroStaticMeshFolderCheckConfig._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.KuroStaticMeshFolderCheckConfig", ref FKuroStaticMeshFolderCheckConfig._ScriptStructPtr);
		}

		// Token: 0x170028B9 RID: 10425
		// (get) Token: 0x0600B2BE RID: 45758 RVA: 0x000FE840 File Offset: 0x000FCA40
		// (set) Token: 0x0600B2BF RID: 45759 RVA: 0x000FE883 File Offset: 0x000FCA83
		public TArray<string> MaterialInstance
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._MaterialInstance) == null)
				{
					result = (this._MaterialInstance = new TArray<string>(base.NativePtr + (IntPtr)FKuroStaticMeshFolderCheckConfig.__PropertyOffset_MaterialInstance, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.MaterialInstance.CopyAssign(value);
			}
		}

		// Token: 0x170028BA RID: 10426
		// (get) Token: 0x0600B2C0 RID: 45760 RVA: 0x000FE891 File Offset: 0x000FCA91
		// (set) Token: 0x0600B2C1 RID: 45761 RVA: 0x000FE8A1 File Offset: 0x000FCAA1
		public unsafe float ScreenSizeCullRatio
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroStaticMeshFolderCheckConfig.__PropertyOffset_ScreenSizeCullRatio);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroStaticMeshFolderCheckConfig.__PropertyOffset_ScreenSizeCullRatio) = value;
			}
		}

		// Token: 0x170028BB RID: 10427
		// (get) Token: 0x0600B2C2 RID: 45762 RVA: 0x000FE8B2 File Offset: 0x000FCAB2
		// (set) Token: 0x0600B2C3 RID: 45763 RVA: 0x000FE8C2 File Offset: 0x000FCAC2
		public unsafe float MaxScreenSizeCullRatio
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroStaticMeshFolderCheckConfig.__PropertyOffset_MaxScreenSizeCullRatio);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroStaticMeshFolderCheckConfig.__PropertyOffset_MaxScreenSizeCullRatio) = value;
			}
		}

		// Token: 0x170028BC RID: 10428
		// (get) Token: 0x0600B2C4 RID: 45764 RVA: 0x000FE8D4 File Offset: 0x000FCAD4
		// (set) Token: 0x0600B2C5 RID: 45765 RVA: 0x000FE917 File Offset: 0x000FCB17
		public TArray<int> TriangleLimit
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._TriangleLimit) == null)
				{
					result = (this._TriangleLimit = new TArray<int>(base.NativePtr + (IntPtr)FKuroStaticMeshFolderCheckConfig.__PropertyOffset_TriangleLimit, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.TriangleLimit.CopyAssign(value);
			}
		}

		// Token: 0x170028BD RID: 10429
		// (get) Token: 0x0600B2C6 RID: 45766 RVA: 0x000FE925 File Offset: 0x000FCB25
		// (set) Token: 0x0600B2C7 RID: 45767 RVA: 0x000FE939 File Offset: 0x000FCB39
		public unsafe string CollisionPreset
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FKuroStaticMeshFolderCheckConfig.__PropertyOffset_CollisionPreset)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FKuroStaticMeshFolderCheckConfig.__PropertyOffset_CollisionPreset)), value);
			}
		}

		// Token: 0x170028BE RID: 10430
		// (get) Token: 0x0600B2C8 RID: 45768 RVA: 0x000FE94E File Offset: 0x000FCB4E
		// (set) Token: 0x0600B2C9 RID: 45769 RVA: 0x000FE95E File Offset: 0x000FCB5E
		public unsafe int VisibleInRayTracing
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroStaticMeshFolderCheckConfig.__PropertyOffset_VisibleInRayTracing);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroStaticMeshFolderCheckConfig.__PropertyOffset_VisibleInRayTracing) = value;
			}
		}

		// Token: 0x170028BF RID: 10431
		// (get) Token: 0x0600B2CA RID: 45770 RVA: 0x000FE96F File Offset: 0x000FCB6F
		// (set) Token: 0x0600B2CB RID: 45771 RVA: 0x000FE97F File Offset: 0x000FCB7F
		public unsafe int bCastRasterShadowsInRaytracing
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroStaticMeshFolderCheckConfig.__PropertyOffset_bCastRasterShadowsInRaytracing);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroStaticMeshFolderCheckConfig.__PropertyOffset_bCastRasterShadowsInRaytracing) = value;
			}
		}

		// Token: 0x170028C0 RID: 10432
		// (get) Token: 0x0600B2CC RID: 45772 RVA: 0x000FE990 File Offset: 0x000FCB90
		// (set) Token: 0x0600B2CD RID: 45773 RVA: 0x000FE9A9 File Offset: 0x000FCBA9
		public unsafe bool bGuaranteedConfig
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroStaticMeshFolderCheckConfig.__PropertyOffset_bGuaranteedConfig) & FKuroStaticMeshFolderCheckConfig.__PropertyMask_bGuaranteedConfig) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroStaticMeshFolderCheckConfig.__PropertyOffset_bGuaranteedConfig) = ((*(base.NativePtr + (IntPtr)FKuroStaticMeshFolderCheckConfig.__PropertyOffset_bGuaranteedConfig) & ~FKuroStaticMeshFolderCheckConfig.__PropertyMask_bGuaranteedConfig) | (value ? FKuroStaticMeshFolderCheckConfig.__PropertyMask_bGuaranteedConfig : 0));
			}
		}

		// Token: 0x170028C1 RID: 10433
		// (get) Token: 0x0600B2CE RID: 45774 RVA: 0x000FE9D9 File Offset: 0x000FCBD9
		// (set) Token: 0x0600B2CF RID: 45775 RVA: 0x000FE9F2 File Offset: 0x000FCBF2
		public unsafe bool bDetailCheck
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroStaticMeshFolderCheckConfig.__PropertyOffset_bDetailCheck) & FKuroStaticMeshFolderCheckConfig.__PropertyMask_bDetailCheck) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroStaticMeshFolderCheckConfig.__PropertyOffset_bDetailCheck) = ((*(base.NativePtr + (IntPtr)FKuroStaticMeshFolderCheckConfig.__PropertyOffset_bDetailCheck) & ~FKuroStaticMeshFolderCheckConfig.__PropertyMask_bDetailCheck) | (value ? FKuroStaticMeshFolderCheckConfig.__PropertyMask_bDetailCheck : 0));
			}
		}

		// Token: 0x170028C2 RID: 10434
		// (get) Token: 0x0600B2D0 RID: 45776 RVA: 0x000FEA22 File Offset: 0x000FCC22
		// (set) Token: 0x0600B2D1 RID: 45777 RVA: 0x000FEA3B File Offset: 0x000FCC3B
		public unsafe bool IsBuildAdjacencyBuffer
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroStaticMeshFolderCheckConfig.__PropertyOffset_IsBuildAdjacencyBuffer) & FKuroStaticMeshFolderCheckConfig.__PropertyMask_IsBuildAdjacencyBuffer) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroStaticMeshFolderCheckConfig.__PropertyOffset_IsBuildAdjacencyBuffer) = ((*(base.NativePtr + (IntPtr)FKuroStaticMeshFolderCheckConfig.__PropertyOffset_IsBuildAdjacencyBuffer) & ~FKuroStaticMeshFolderCheckConfig.__PropertyMask_IsBuildAdjacencyBuffer) | (value ? FKuroStaticMeshFolderCheckConfig.__PropertyMask_IsBuildAdjacencyBuffer : 0));
			}
		}

		// Token: 0x170028C3 RID: 10435
		// (get) Token: 0x0600B2D2 RID: 45778 RVA: 0x000FEA6B File Offset: 0x000FCC6B
		// (set) Token: 0x0600B2D3 RID: 45779 RVA: 0x000FEA84 File Offset: 0x000FCC84
		public unsafe bool IsBuildReveresedIndexBuffer
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroStaticMeshFolderCheckConfig.__PropertyOffset_IsBuildReveresedIndexBuffer) & FKuroStaticMeshFolderCheckConfig.__PropertyMask_IsBuildReveresedIndexBuffer) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroStaticMeshFolderCheckConfig.__PropertyOffset_IsBuildReveresedIndexBuffer) = ((*(base.NativePtr + (IntPtr)FKuroStaticMeshFolderCheckConfig.__PropertyOffset_IsBuildReveresedIndexBuffer) & ~FKuroStaticMeshFolderCheckConfig.__PropertyMask_IsBuildReveresedIndexBuffer) | (value ? FKuroStaticMeshFolderCheckConfig.__PropertyMask_IsBuildReveresedIndexBuffer : 0));
			}
		}

		// Token: 0x170028C4 RID: 10436
		// (get) Token: 0x0600B2D4 RID: 45780 RVA: 0x000FEAB4 File Offset: 0x000FCCB4
		// (set) Token: 0x0600B2D5 RID: 45781 RVA: 0x000FEACD File Offset: 0x000FCCCD
		public unsafe bool IsGenerateLightmapUVs
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroStaticMeshFolderCheckConfig.__PropertyOffset_IsGenerateLightmapUVs) & FKuroStaticMeshFolderCheckConfig.__PropertyMask_IsGenerateLightmapUVs) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroStaticMeshFolderCheckConfig.__PropertyOffset_IsGenerateLightmapUVs) = ((*(base.NativePtr + (IntPtr)FKuroStaticMeshFolderCheckConfig.__PropertyOffset_IsGenerateLightmapUVs) & ~FKuroStaticMeshFolderCheckConfig.__PropertyMask_IsGenerateLightmapUVs) | (value ? FKuroStaticMeshFolderCheckConfig.__PropertyMask_IsGenerateLightmapUVs : 0));
			}
		}

		// Token: 0x170028C5 RID: 10437
		// (get) Token: 0x0600B2D6 RID: 45782 RVA: 0x000FEAFD File Offset: 0x000FCCFD
		// (set) Token: 0x0600B2D7 RID: 45783 RVA: 0x000FEB16 File Offset: 0x000FCD16
		public unsafe bool IsUseFullPrecisionUVs
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroStaticMeshFolderCheckConfig.__PropertyOffset_IsUseFullPrecisionUVs) & FKuroStaticMeshFolderCheckConfig.__PropertyMask_IsUseFullPrecisionUVs) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroStaticMeshFolderCheckConfig.__PropertyOffset_IsUseFullPrecisionUVs) = ((*(base.NativePtr + (IntPtr)FKuroStaticMeshFolderCheckConfig.__PropertyOffset_IsUseFullPrecisionUVs) & ~FKuroStaticMeshFolderCheckConfig.__PropertyMask_IsUseFullPrecisionUVs) | (value ? FKuroStaticMeshFolderCheckConfig.__PropertyMask_IsUseFullPrecisionUVs : 0));
			}
		}

		// Token: 0x170028C6 RID: 10438
		// (get) Token: 0x0600B2D8 RID: 45784 RVA: 0x000FEB46 File Offset: 0x000FCD46
		// (set) Token: 0x0600B2D9 RID: 45785 RVA: 0x000FEB5F File Offset: 0x000FCD5F
		public unsafe bool bCheckTriangle
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroStaticMeshFolderCheckConfig.__PropertyOffset_bCheckTriangle) & FKuroStaticMeshFolderCheckConfig.__PropertyMask_bCheckTriangle) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroStaticMeshFolderCheckConfig.__PropertyOffset_bCheckTriangle) = ((*(base.NativePtr + (IntPtr)FKuroStaticMeshFolderCheckConfig.__PropertyOffset_bCheckTriangle) & ~FKuroStaticMeshFolderCheckConfig.__PropertyMask_bCheckTriangle) | (value ? FKuroStaticMeshFolderCheckConfig.__PropertyMask_bCheckTriangle : 0));
			}
		}

		// Token: 0x170028C7 RID: 10439
		// (get) Token: 0x0600B2DA RID: 45786 RVA: 0x000FEB8F File Offset: 0x000FCD8F
		// (set) Token: 0x0600B2DB RID: 45787 RVA: 0x000FEBA8 File Offset: 0x000FCDA8
		public unsafe bool bCheckCollisionPreset
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroStaticMeshFolderCheckConfig.__PropertyOffset_bCheckCollisionPreset) & FKuroStaticMeshFolderCheckConfig.__PropertyMask_bCheckCollisionPreset) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroStaticMeshFolderCheckConfig.__PropertyOffset_bCheckCollisionPreset) = ((*(base.NativePtr + (IntPtr)FKuroStaticMeshFolderCheckConfig.__PropertyOffset_bCheckCollisionPreset) & ~FKuroStaticMeshFolderCheckConfig.__PropertyMask_bCheckCollisionPreset) | (value ? FKuroStaticMeshFolderCheckConfig.__PropertyMask_bCheckCollisionPreset : 0));
			}
		}

		// Token: 0x170028C8 RID: 10440
		// (get) Token: 0x0600B2DC RID: 45788 RVA: 0x000FEBD8 File Offset: 0x000FCDD8
		// (set) Token: 0x0600B2DD RID: 45789 RVA: 0x000FEBF1 File Offset: 0x000FCDF1
		public unsafe bool AutoCheckForceModify
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroStaticMeshFolderCheckConfig.__PropertyOffset_AutoCheckForceModify) & FKuroStaticMeshFolderCheckConfig.__PropertyMask_AutoCheckForceModify) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroStaticMeshFolderCheckConfig.__PropertyOffset_AutoCheckForceModify) = ((*(base.NativePtr + (IntPtr)FKuroStaticMeshFolderCheckConfig.__PropertyOffset_AutoCheckForceModify) & ~FKuroStaticMeshFolderCheckConfig.__PropertyMask_AutoCheckForceModify) | (value ? FKuroStaticMeshFolderCheckConfig.__PropertyMask_AutoCheckForceModify : 0));
			}
		}

		// Token: 0x170028C9 RID: 10441
		// (get) Token: 0x0600B2DE RID: 45790 RVA: 0x000FEC21 File Offset: 0x000FCE21
		// (set) Token: 0x0600B2DF RID: 45791 RVA: 0x000FEC3A File Offset: 0x000FCE3A
		public unsafe bool IsCheckScreenSizeCullRatio
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroStaticMeshFolderCheckConfig.__PropertyOffset_IsCheckScreenSizeCullRatio) & FKuroStaticMeshFolderCheckConfig.__PropertyMask_IsCheckScreenSizeCullRatio) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroStaticMeshFolderCheckConfig.__PropertyOffset_IsCheckScreenSizeCullRatio) = ((*(base.NativePtr + (IntPtr)FKuroStaticMeshFolderCheckConfig.__PropertyOffset_IsCheckScreenSizeCullRatio) & ~FKuroStaticMeshFolderCheckConfig.__PropertyMask_IsCheckScreenSizeCullRatio) | (value ? FKuroStaticMeshFolderCheckConfig.__PropertyMask_IsCheckScreenSizeCullRatio : 0));
			}
		}

		// Token: 0x170028CA RID: 10442
		// (get) Token: 0x0600B2E0 RID: 45792 RVA: 0x000FEC6A File Offset: 0x000FCE6A
		// (set) Token: 0x0600B2E1 RID: 45793 RVA: 0x000FEC83 File Offset: 0x000FCE83
		public unsafe bool bOpenVertexCompress
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroStaticMeshFolderCheckConfig.__PropertyOffset_bOpenVertexCompress) & FKuroStaticMeshFolderCheckConfig.__PropertyMask_bOpenVertexCompress) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroStaticMeshFolderCheckConfig.__PropertyOffset_bOpenVertexCompress) = ((*(base.NativePtr + (IntPtr)FKuroStaticMeshFolderCheckConfig.__PropertyOffset_bOpenVertexCompress) & ~FKuroStaticMeshFolderCheckConfig.__PropertyMask_bOpenVertexCompress) | (value ? FKuroStaticMeshFolderCheckConfig.__PropertyMask_bOpenVertexCompress : 0));
			}
		}

		// Token: 0x170028CB RID: 10443
		// (get) Token: 0x0600B2E2 RID: 45794 RVA: 0x000FECB3 File Offset: 0x000FCEB3
		// (set) Token: 0x0600B2E3 RID: 45795 RVA: 0x000FECCC File Offset: 0x000FCECC
		public unsafe bool isProxyMeshTriangle
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroStaticMeshFolderCheckConfig.__PropertyOffset_isProxyMeshTriangle) & FKuroStaticMeshFolderCheckConfig.__PropertyMask_isProxyMeshTriangle) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroStaticMeshFolderCheckConfig.__PropertyOffset_isProxyMeshTriangle) = ((*(base.NativePtr + (IntPtr)FKuroStaticMeshFolderCheckConfig.__PropertyOffset_isProxyMeshTriangle) & ~FKuroStaticMeshFolderCheckConfig.__PropertyMask_isProxyMeshTriangle) | (value ? FKuroStaticMeshFolderCheckConfig.__PropertyMask_isProxyMeshTriangle : 0));
			}
		}

		// Token: 0x0600B2E4 RID: 45796 RVA: 0x000FECFC File Offset: 0x000FCEFC
		public FKuroStaticMeshFolderCheckConfig()
		{
		}

		// Token: 0x0600B2E5 RID: 45797 RVA: 0x000FED04 File Offset: 0x000FCF04
		public FKuroStaticMeshFolderCheckConfig(TArray<string> MaterialInstance, float ScreenSizeCullRatio, float MaxScreenSizeCullRatio, TArray<int> TriangleLimit, string CollisionPreset, int VisibleInRayTracing, int bCastRasterShadowsInRaytracing, bool bGuaranteedConfig, bool bDetailCheck, bool IsBuildAdjacencyBuffer, bool IsBuildReveresedIndexBuffer, bool IsGenerateLightmapUVs, bool IsUseFullPrecisionUVs, bool bCheckTriangle, bool bCheckCollisionPreset, bool AutoCheckForceModify, bool IsCheckScreenSizeCullRatio, bool bOpenVertexCompress, bool isProxyMeshTriangle, string Regex, int MatchingPriority)
		{
			this.MaterialInstance = MaterialInstance;
			this.ScreenSizeCullRatio = ScreenSizeCullRatio;
			this.MaxScreenSizeCullRatio = MaxScreenSizeCullRatio;
			this.TriangleLimit = TriangleLimit;
			this.CollisionPreset = CollisionPreset;
			this.VisibleInRayTracing = VisibleInRayTracing;
			this.bCastRasterShadowsInRaytracing = bCastRasterShadowsInRaytracing;
			this.bGuaranteedConfig = bGuaranteedConfig;
			this.bDetailCheck = bDetailCheck;
			this.IsBuildAdjacencyBuffer = IsBuildAdjacencyBuffer;
			this.IsBuildReveresedIndexBuffer = IsBuildReveresedIndexBuffer;
			this.IsGenerateLightmapUVs = IsGenerateLightmapUVs;
			this.IsUseFullPrecisionUVs = IsUseFullPrecisionUVs;
			this.bCheckTriangle = bCheckTriangle;
			this.bCheckCollisionPreset = bCheckCollisionPreset;
			this.AutoCheckForceModify = AutoCheckForceModify;
			this.IsCheckScreenSizeCullRatio = IsCheckScreenSizeCullRatio;
			this.bOpenVertexCompress = bOpenVertexCompress;
			this.isProxyMeshTriangle = isProxyMeshTriangle;
			base.Regex = Regex;
			base.MatchingPriority = MatchingPriority;
		}

		// Token: 0x0600B2E6 RID: 45798 RVA: 0x000FEDBC File Offset: 0x000FCFBC
		protected override IntPtr GetUStructPtr()
		{
			return FKuroStaticMeshFolderCheckConfig.StaticStruct();
		}

		// Token: 0x0600B2E7 RID: 45799 RVA: 0x000FEDC8 File Offset: 0x000FCFC8
		[NullableContext(2)]
		public FKuroStaticMeshFolderCheckConfig(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600B2E8 RID: 45800 RVA: 0x000FEDD2 File Offset: 0x000FCFD2
		public FKuroStaticMeshFolderCheckConfig(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600B2E9 RID: 45801 RVA: 0x000FEDDD File Offset: 0x000FCFDD
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroStaticMeshFolderCheckConfig(Pointer, false, true);
		}

		// Token: 0x0600B2EA RID: 45802 RVA: 0x000FEDE7 File Offset: 0x000FCFE7
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroStaticMeshFolderCheckConfig(Pointer, MemoryOwner);
		}

		// Token: 0x04005DD0 RID: 24016
		public new const string __ObjectPath = "/Script/Engine.KuroStaticMeshFolderCheckConfig";

		// Token: 0x04005DD1 RID: 24017
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04005DD2 RID: 24018
		internal static int __PropertyOffset_MaterialInstance;

		// Token: 0x04005DD3 RID: 24019
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _MaterialInstance;

		// Token: 0x04005DD4 RID: 24020
		internal static int __PropertyOffset_ScreenSizeCullRatio;

		// Token: 0x04005DD5 RID: 24021
		internal static int __PropertyOffset_MaxScreenSizeCullRatio;

		// Token: 0x04005DD6 RID: 24022
		internal static int __PropertyOffset_TriangleLimit;

		// Token: 0x04005DD7 RID: 24023
		[Nullable(2)]
		private TArray<int> _TriangleLimit;

		// Token: 0x04005DD8 RID: 24024
		internal static int __PropertyOffset_CollisionPreset;

		// Token: 0x04005DD9 RID: 24025
		internal static int __PropertyOffset_VisibleInRayTracing;

		// Token: 0x04005DDA RID: 24026
		internal static int __PropertyOffset_bCastRasterShadowsInRaytracing;

		// Token: 0x04005DDB RID: 24027
		internal static int __PropertyOffset_bGuaranteedConfig;

		// Token: 0x04005DDC RID: 24028
		internal static byte __PropertyMask_bGuaranteedConfig;

		// Token: 0x04005DDD RID: 24029
		internal static int __PropertyOffset_bDetailCheck;

		// Token: 0x04005DDE RID: 24030
		internal static byte __PropertyMask_bDetailCheck;

		// Token: 0x04005DDF RID: 24031
		internal static int __PropertyOffset_IsBuildAdjacencyBuffer;

		// Token: 0x04005DE0 RID: 24032
		internal static byte __PropertyMask_IsBuildAdjacencyBuffer;

		// Token: 0x04005DE1 RID: 24033
		internal static int __PropertyOffset_IsBuildReveresedIndexBuffer;

		// Token: 0x04005DE2 RID: 24034
		internal static byte __PropertyMask_IsBuildReveresedIndexBuffer;

		// Token: 0x04005DE3 RID: 24035
		internal static int __PropertyOffset_IsGenerateLightmapUVs;

		// Token: 0x04005DE4 RID: 24036
		internal static byte __PropertyMask_IsGenerateLightmapUVs;

		// Token: 0x04005DE5 RID: 24037
		internal static int __PropertyOffset_IsUseFullPrecisionUVs;

		// Token: 0x04005DE6 RID: 24038
		internal static byte __PropertyMask_IsUseFullPrecisionUVs;

		// Token: 0x04005DE7 RID: 24039
		internal static int __PropertyOffset_bCheckTriangle;

		// Token: 0x04005DE8 RID: 24040
		internal static byte __PropertyMask_bCheckTriangle;

		// Token: 0x04005DE9 RID: 24041
		internal static int __PropertyOffset_bCheckCollisionPreset;

		// Token: 0x04005DEA RID: 24042
		internal static byte __PropertyMask_bCheckCollisionPreset;

		// Token: 0x04005DEB RID: 24043
		internal static int __PropertyOffset_AutoCheckForceModify;

		// Token: 0x04005DEC RID: 24044
		internal static byte __PropertyMask_AutoCheckForceModify;

		// Token: 0x04005DED RID: 24045
		internal static int __PropertyOffset_IsCheckScreenSizeCullRatio;

		// Token: 0x04005DEE RID: 24046
		internal static byte __PropertyMask_IsCheckScreenSizeCullRatio;

		// Token: 0x04005DEF RID: 24047
		internal static int __PropertyOffset_bOpenVertexCompress;

		// Token: 0x04005DF0 RID: 24048
		internal static byte __PropertyMask_bOpenVertexCompress;

		// Token: 0x04005DF1 RID: 24049
		internal static int __PropertyOffset_isProxyMeshTriangle;

		// Token: 0x04005DF2 RID: 24050
		internal static byte __PropertyMask_isProxyMeshTriangle;
	}
}
