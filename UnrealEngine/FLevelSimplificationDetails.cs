using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000D37 RID: 3383
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.LevelSimplificationDetails")]
	[UnrealStructLayout(300, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 300)]
	public class FLevelSimplificationDetails : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600B50E RID: 46350 RVA: 0x00102406 File Offset: 0x00100606
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FLevelSimplificationDetails._ScriptStructPtr != 0) ? FLevelSimplificationDetails._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.LevelSimplificationDetails", ref FLevelSimplificationDetails._ScriptStructPtr);
		}

		// Token: 0x17002962 RID: 10594
		// (get) Token: 0x0600B50F RID: 46351 RVA: 0x0010242A File Offset: 0x0010062A
		// (set) Token: 0x0600B510 RID: 46352 RVA: 0x0010243A File Offset: 0x0010063A
		public unsafe bool bCreatePackagePerAsset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLevelSimplificationDetails.__PropertyOffset_bCreatePackagePerAsset) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLevelSimplificationDetails.__PropertyOffset_bCreatePackagePerAsset) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002963 RID: 10595
		// (get) Token: 0x0600B511 RID: 46353 RVA: 0x0010244B File Offset: 0x0010064B
		// (set) Token: 0x0600B512 RID: 46354 RVA: 0x0010245B File Offset: 0x0010065B
		public unsafe float DetailsPercentage
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLevelSimplificationDetails.__PropertyOffset_DetailsPercentage);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLevelSimplificationDetails.__PropertyOffset_DetailsPercentage) = value;
			}
		}

		// Token: 0x17002964 RID: 10596
		// (get) Token: 0x0600B513 RID: 46355 RVA: 0x0010246C File Offset: 0x0010066C
		// (set) Token: 0x0600B514 RID: 46356 RVA: 0x001024AF File Offset: 0x001006AF
		public FMaterialProxySettings StaticMeshMaterialSettings
		{
			get
			{
				base.FastCheckIsValid();
				FMaterialProxySettings result;
				if ((result = this._StaticMeshMaterialSettings) == null)
				{
					result = (this._StaticMeshMaterialSettings = new FMaterialProxySettings(base.NativePtr + (IntPtr)FLevelSimplificationDetails.__PropertyOffset_StaticMeshMaterialSettings, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMaterialProxySettings.StaticStruct(), base.NativePtr + (IntPtr)FLevelSimplificationDetails.__PropertyOffset_StaticMeshMaterialSettings, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002965 RID: 10597
		// (get) Token: 0x0600B515 RID: 46357 RVA: 0x001024D0 File Offset: 0x001006D0
		// (set) Token: 0x0600B516 RID: 46358 RVA: 0x001024E0 File Offset: 0x001006E0
		public unsafe bool bOverrideLandscapeExportLOD
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLevelSimplificationDetails.__PropertyOffset_bOverrideLandscapeExportLOD) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLevelSimplificationDetails.__PropertyOffset_bOverrideLandscapeExportLOD) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002966 RID: 10598
		// (get) Token: 0x0600B517 RID: 46359 RVA: 0x001024F1 File Offset: 0x001006F1
		// (set) Token: 0x0600B518 RID: 46360 RVA: 0x00102501 File Offset: 0x00100701
		public unsafe int LandscapeExportLOD
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLevelSimplificationDetails.__PropertyOffset_LandscapeExportLOD);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLevelSimplificationDetails.__PropertyOffset_LandscapeExportLOD) = value;
			}
		}

		// Token: 0x17002967 RID: 10599
		// (get) Token: 0x0600B519 RID: 46361 RVA: 0x00102514 File Offset: 0x00100714
		// (set) Token: 0x0600B51A RID: 46362 RVA: 0x00102557 File Offset: 0x00100757
		public FMaterialProxySettings LandscapeMaterialSettings
		{
			get
			{
				base.FastCheckIsValid();
				FMaterialProxySettings result;
				if ((result = this._LandscapeMaterialSettings) == null)
				{
					result = (this._LandscapeMaterialSettings = new FMaterialProxySettings(base.NativePtr + (IntPtr)FLevelSimplificationDetails.__PropertyOffset_LandscapeMaterialSettings, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMaterialProxySettings.StaticStruct(), base.NativePtr + (IntPtr)FLevelSimplificationDetails.__PropertyOffset_LandscapeMaterialSettings, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002968 RID: 10600
		// (get) Token: 0x0600B51B RID: 46363 RVA: 0x00102578 File Offset: 0x00100778
		// (set) Token: 0x0600B51C RID: 46364 RVA: 0x00102588 File Offset: 0x00100788
		public unsafe bool bBakeFoliageToLandscape
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLevelSimplificationDetails.__PropertyOffset_bBakeFoliageToLandscape) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLevelSimplificationDetails.__PropertyOffset_bBakeFoliageToLandscape) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002969 RID: 10601
		// (get) Token: 0x0600B51D RID: 46365 RVA: 0x00102599 File Offset: 0x00100799
		// (set) Token: 0x0600B51E RID: 46366 RVA: 0x001025A9 File Offset: 0x001007A9
		public unsafe bool bBakeGrassToLandscape
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLevelSimplificationDetails.__PropertyOffset_bBakeGrassToLandscape) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLevelSimplificationDetails.__PropertyOffset_bBakeGrassToLandscape) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700296A RID: 10602
		// (get) Token: 0x0600B51F RID: 46367 RVA: 0x001025BA File Offset: 0x001007BA
		// (set) Token: 0x0600B520 RID: 46368 RVA: 0x001025CA File Offset: 0x001007CA
		public unsafe bool bGenerateMeshNormalMap_DEPRECATED
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLevelSimplificationDetails.__PropertyOffset_bGenerateMeshNormalMap_DEPRECATED) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLevelSimplificationDetails.__PropertyOffset_bGenerateMeshNormalMap_DEPRECATED) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700296B RID: 10603
		// (get) Token: 0x0600B521 RID: 46369 RVA: 0x001025DB File Offset: 0x001007DB
		// (set) Token: 0x0600B522 RID: 46370 RVA: 0x001025EB File Offset: 0x001007EB
		public unsafe bool bGenerateMeshMetallicMap_DEPRECATED
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLevelSimplificationDetails.__PropertyOffset_bGenerateMeshMetallicMap_DEPRECATED) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLevelSimplificationDetails.__PropertyOffset_bGenerateMeshMetallicMap_DEPRECATED) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700296C RID: 10604
		// (get) Token: 0x0600B523 RID: 46371 RVA: 0x001025FC File Offset: 0x001007FC
		// (set) Token: 0x0600B524 RID: 46372 RVA: 0x0010260C File Offset: 0x0010080C
		public unsafe bool bGenerateMeshRoughnessMap_DEPRECATED
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLevelSimplificationDetails.__PropertyOffset_bGenerateMeshRoughnessMap_DEPRECATED) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLevelSimplificationDetails.__PropertyOffset_bGenerateMeshRoughnessMap_DEPRECATED) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700296D RID: 10605
		// (get) Token: 0x0600B525 RID: 46373 RVA: 0x0010261D File Offset: 0x0010081D
		// (set) Token: 0x0600B526 RID: 46374 RVA: 0x0010262D File Offset: 0x0010082D
		public unsafe bool bGenerateMeshSpecularMap_DEPRECATED
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLevelSimplificationDetails.__PropertyOffset_bGenerateMeshSpecularMap_DEPRECATED) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLevelSimplificationDetails.__PropertyOffset_bGenerateMeshSpecularMap_DEPRECATED) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700296E RID: 10606
		// (get) Token: 0x0600B527 RID: 46375 RVA: 0x0010263E File Offset: 0x0010083E
		// (set) Token: 0x0600B528 RID: 46376 RVA: 0x0010264E File Offset: 0x0010084E
		public unsafe bool bGenerateLandscapeNormalMap_DEPRECATED
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLevelSimplificationDetails.__PropertyOffset_bGenerateLandscapeNormalMap_DEPRECATED) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLevelSimplificationDetails.__PropertyOffset_bGenerateLandscapeNormalMap_DEPRECATED) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700296F RID: 10607
		// (get) Token: 0x0600B529 RID: 46377 RVA: 0x0010265F File Offset: 0x0010085F
		// (set) Token: 0x0600B52A RID: 46378 RVA: 0x0010266F File Offset: 0x0010086F
		public unsafe bool bGenerateLandscapeMetallicMap_DEPRECATED
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLevelSimplificationDetails.__PropertyOffset_bGenerateLandscapeMetallicMap_DEPRECATED) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLevelSimplificationDetails.__PropertyOffset_bGenerateLandscapeMetallicMap_DEPRECATED) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002970 RID: 10608
		// (get) Token: 0x0600B52B RID: 46379 RVA: 0x00102680 File Offset: 0x00100880
		// (set) Token: 0x0600B52C RID: 46380 RVA: 0x00102690 File Offset: 0x00100890
		public unsafe bool bGenerateLandscapeRoughnessMap_DEPRECATED
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLevelSimplificationDetails.__PropertyOffset_bGenerateLandscapeRoughnessMap_DEPRECATED) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLevelSimplificationDetails.__PropertyOffset_bGenerateLandscapeRoughnessMap_DEPRECATED) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002971 RID: 10609
		// (get) Token: 0x0600B52D RID: 46381 RVA: 0x001026A1 File Offset: 0x001008A1
		// (set) Token: 0x0600B52E RID: 46382 RVA: 0x001026B1 File Offset: 0x001008B1
		public unsafe bool bGenerateLandscapeSpecularMap_DEPRECATED
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLevelSimplificationDetails.__PropertyOffset_bGenerateLandscapeSpecularMap_DEPRECATED) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLevelSimplificationDetails.__PropertyOffset_bGenerateLandscapeSpecularMap_DEPRECATED) = (value ? 1 : 0);
			}
		}

		// Token: 0x0600B52F RID: 46383 RVA: 0x001026C2 File Offset: 0x001008C2
		public FLevelSimplificationDetails()
		{
		}

		// Token: 0x0600B530 RID: 46384 RVA: 0x001026CC File Offset: 0x001008CC
		public FLevelSimplificationDetails(bool bCreatePackagePerAsset, float DetailsPercentage, FMaterialProxySettings StaticMeshMaterialSettings, bool bOverrideLandscapeExportLOD, int LandscapeExportLOD, FMaterialProxySettings LandscapeMaterialSettings, bool bBakeFoliageToLandscape, bool bBakeGrassToLandscape, bool bGenerateMeshNormalMap_DEPRECATED, bool bGenerateMeshMetallicMap_DEPRECATED, bool bGenerateMeshRoughnessMap_DEPRECATED, bool bGenerateMeshSpecularMap_DEPRECATED, bool bGenerateLandscapeNormalMap_DEPRECATED, bool bGenerateLandscapeMetallicMap_DEPRECATED, bool bGenerateLandscapeRoughnessMap_DEPRECATED, bool bGenerateLandscapeSpecularMap_DEPRECATED)
		{
			this.bCreatePackagePerAsset = bCreatePackagePerAsset;
			this.DetailsPercentage = DetailsPercentage;
			this.StaticMeshMaterialSettings = StaticMeshMaterialSettings;
			this.bOverrideLandscapeExportLOD = bOverrideLandscapeExportLOD;
			this.LandscapeExportLOD = LandscapeExportLOD;
			this.LandscapeMaterialSettings = LandscapeMaterialSettings;
			this.bBakeFoliageToLandscape = bBakeFoliageToLandscape;
			this.bBakeGrassToLandscape = bBakeGrassToLandscape;
			this.bGenerateMeshNormalMap_DEPRECATED = bGenerateMeshNormalMap_DEPRECATED;
			this.bGenerateMeshMetallicMap_DEPRECATED = bGenerateMeshMetallicMap_DEPRECATED;
			this.bGenerateMeshRoughnessMap_DEPRECATED = bGenerateMeshRoughnessMap_DEPRECATED;
			this.bGenerateMeshSpecularMap_DEPRECATED = bGenerateMeshSpecularMap_DEPRECATED;
			this.bGenerateLandscapeNormalMap_DEPRECATED = bGenerateLandscapeNormalMap_DEPRECATED;
			this.bGenerateLandscapeMetallicMap_DEPRECATED = bGenerateLandscapeMetallicMap_DEPRECATED;
			this.bGenerateLandscapeRoughnessMap_DEPRECATED = bGenerateLandscapeRoughnessMap_DEPRECATED;
			this.bGenerateLandscapeSpecularMap_DEPRECATED = bGenerateLandscapeSpecularMap_DEPRECATED;
		}

		// Token: 0x0600B531 RID: 46385 RVA: 0x0010275C File Offset: 0x0010095C
		protected override IntPtr GetUStructPtr()
		{
			return FLevelSimplificationDetails.StaticStruct();
		}

		// Token: 0x0600B532 RID: 46386 RVA: 0x00102768 File Offset: 0x00100968
		[NullableContext(2)]
		public FLevelSimplificationDetails(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600B533 RID: 46387 RVA: 0x00102772 File Offset: 0x00100972
		public FLevelSimplificationDetails(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600B534 RID: 46388 RVA: 0x0010277D File Offset: 0x0010097D
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FLevelSimplificationDetails(Pointer, false, true);
		}

		// Token: 0x0600B535 RID: 46389 RVA: 0x00102787 File Offset: 0x00100987
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FLevelSimplificationDetails(Pointer, MemoryOwner);
		}

		// Token: 0x04005F2A RID: 24362
		public const string __ObjectPath = "/Script/Engine.LevelSimplificationDetails";

		// Token: 0x04005F2B RID: 24363
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04005F2C RID: 24364
		internal static int __PropertyOffset_bCreatePackagePerAsset;

		// Token: 0x04005F2D RID: 24365
		internal static int __PropertyOffset_DetailsPercentage;

		// Token: 0x04005F2E RID: 24366
		internal static int __PropertyOffset_StaticMeshMaterialSettings;

		// Token: 0x04005F2F RID: 24367
		[Nullable(2)]
		private FMaterialProxySettings _StaticMeshMaterialSettings;

		// Token: 0x04005F30 RID: 24368
		internal static int __PropertyOffset_bOverrideLandscapeExportLOD;

		// Token: 0x04005F31 RID: 24369
		internal static int __PropertyOffset_LandscapeExportLOD;

		// Token: 0x04005F32 RID: 24370
		internal static int __PropertyOffset_LandscapeMaterialSettings;

		// Token: 0x04005F33 RID: 24371
		[Nullable(2)]
		private FMaterialProxySettings _LandscapeMaterialSettings;

		// Token: 0x04005F34 RID: 24372
		internal static int __PropertyOffset_bBakeFoliageToLandscape;

		// Token: 0x04005F35 RID: 24373
		internal static int __PropertyOffset_bBakeGrassToLandscape;

		// Token: 0x04005F36 RID: 24374
		internal static int __PropertyOffset_bGenerateMeshNormalMap_DEPRECATED;

		// Token: 0x04005F37 RID: 24375
		internal static int __PropertyOffset_bGenerateMeshMetallicMap_DEPRECATED;

		// Token: 0x04005F38 RID: 24376
		internal static int __PropertyOffset_bGenerateMeshRoughnessMap_DEPRECATED;

		// Token: 0x04005F39 RID: 24377
		internal static int __PropertyOffset_bGenerateMeshSpecularMap_DEPRECATED;

		// Token: 0x04005F3A RID: 24378
		internal static int __PropertyOffset_bGenerateLandscapeNormalMap_DEPRECATED;

		// Token: 0x04005F3B RID: 24379
		internal static int __PropertyOffset_bGenerateLandscapeMetallicMap_DEPRECATED;

		// Token: 0x04005F3C RID: 24380
		internal static int __PropertyOffset_bGenerateLandscapeRoughnessMap_DEPRECATED;

		// Token: 0x04005F3D RID: 24381
		internal static int __PropertyOffset_bGenerateLandscapeSpecularMap_DEPRECATED;
	}
}
