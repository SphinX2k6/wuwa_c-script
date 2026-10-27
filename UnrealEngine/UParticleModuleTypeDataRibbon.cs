using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000FB1 RID: 4017
	[UnrealObjectPath("/Script/Engine.ParticleModuleTypeDataRibbon")]
	[UnrealStructLayout(104, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 104)]
	public class UParticleModuleTypeDataRibbon : UParticleModuleTypeDataBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600D840 RID: 55360 RVA: 0x0013F058 File Offset: 0x0013D258
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UParticleModuleTypeDataRibbon._ClassPtr;
		}

		// Token: 0x0600D841 RID: 55361 RVA: 0x0013F064 File Offset: 0x0013D264
		public UParticleModuleTypeDataRibbon() : this(BuiltinUtils.AllocNativeUObject(UParticleModuleTypeDataRibbon.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600D842 RID: 55362 RVA: 0x0013F08C File Offset: 0x0013D28C
		[NullableContext(1)]
		public UParticleModuleTypeDataRibbon(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UParticleModuleTypeDataRibbon.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170032EF RID: 13039
		// (get) Token: 0x0600D843 RID: 55363 RVA: 0x0013F0BF File Offset: 0x0013D2BF
		// (set) Token: 0x0600D844 RID: 55364 RVA: 0x0013F0CF File Offset: 0x0013D2CF
		public unsafe int MaxTessellationBetweenParticles
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UParticleModuleTypeDataRibbon.__PropertyOffset_MaxTessellationBetweenParticles);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UParticleModuleTypeDataRibbon.__PropertyOffset_MaxTessellationBetweenParticles) = value;
			}
		}

		// Token: 0x170032F0 RID: 13040
		// (get) Token: 0x0600D845 RID: 55365 RVA: 0x0013F0E0 File Offset: 0x0013D2E0
		// (set) Token: 0x0600D846 RID: 55366 RVA: 0x0013F0F0 File Offset: 0x0013D2F0
		public unsafe int SheetsPerTrail
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UParticleModuleTypeDataRibbon.__PropertyOffset_SheetsPerTrail);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UParticleModuleTypeDataRibbon.__PropertyOffset_SheetsPerTrail) = value;
			}
		}

		// Token: 0x170032F1 RID: 13041
		// (get) Token: 0x0600D847 RID: 55367 RVA: 0x0013F101 File Offset: 0x0013D301
		// (set) Token: 0x0600D848 RID: 55368 RVA: 0x0013F111 File Offset: 0x0013D311
		public unsafe int MaxTrailCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UParticleModuleTypeDataRibbon.__PropertyOffset_MaxTrailCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UParticleModuleTypeDataRibbon.__PropertyOffset_MaxTrailCount) = value;
			}
		}

		// Token: 0x170032F2 RID: 13042
		// (get) Token: 0x0600D849 RID: 55369 RVA: 0x0013F122 File Offset: 0x0013D322
		// (set) Token: 0x0600D84A RID: 55370 RVA: 0x0013F132 File Offset: 0x0013D332
		public unsafe int MaxParticleInTrailCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UParticleModuleTypeDataRibbon.__PropertyOffset_MaxParticleInTrailCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UParticleModuleTypeDataRibbon.__PropertyOffset_MaxParticleInTrailCount) = value;
			}
		}

		// Token: 0x170032F3 RID: 13043
		// (get) Token: 0x0600D84B RID: 55371 RVA: 0x0013F143 File Offset: 0x0013D343
		// (set) Token: 0x0600D84C RID: 55372 RVA: 0x0013F15C File Offset: 0x0013D35C
		public unsafe bool bDeadTrailsOnDeactivate
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UParticleModuleTypeDataRibbon.__PropertyOffset_bDeadTrailsOnDeactivate) & UParticleModuleTypeDataRibbon.__PropertyMask_bDeadTrailsOnDeactivate) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UParticleModuleTypeDataRibbon.__PropertyOffset_bDeadTrailsOnDeactivate) = ((*(base.NativePtr + (IntPtr)UParticleModuleTypeDataRibbon.__PropertyOffset_bDeadTrailsOnDeactivate) & ~UParticleModuleTypeDataRibbon.__PropertyMask_bDeadTrailsOnDeactivate) | (value ? UParticleModuleTypeDataRibbon.__PropertyMask_bDeadTrailsOnDeactivate : 0));
			}
		}

		// Token: 0x170032F4 RID: 13044
		// (get) Token: 0x0600D84D RID: 55373 RVA: 0x0013F18C File Offset: 0x0013D38C
		// (set) Token: 0x0600D84E RID: 55374 RVA: 0x0013F1A5 File Offset: 0x0013D3A5
		public unsafe bool bDeadTrailsOnSourceLoss
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UParticleModuleTypeDataRibbon.__PropertyOffset_bDeadTrailsOnSourceLoss) & UParticleModuleTypeDataRibbon.__PropertyMask_bDeadTrailsOnSourceLoss) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UParticleModuleTypeDataRibbon.__PropertyOffset_bDeadTrailsOnSourceLoss) = ((*(base.NativePtr + (IntPtr)UParticleModuleTypeDataRibbon.__PropertyOffset_bDeadTrailsOnSourceLoss) & ~UParticleModuleTypeDataRibbon.__PropertyMask_bDeadTrailsOnSourceLoss) | (value ? UParticleModuleTypeDataRibbon.__PropertyMask_bDeadTrailsOnSourceLoss : 0));
			}
		}

		// Token: 0x170032F5 RID: 13045
		// (get) Token: 0x0600D84F RID: 55375 RVA: 0x0013F1D5 File Offset: 0x0013D3D5
		// (set) Token: 0x0600D850 RID: 55376 RVA: 0x0013F1EE File Offset: 0x0013D3EE
		public unsafe bool bClipSourceSegement
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UParticleModuleTypeDataRibbon.__PropertyOffset_bClipSourceSegement) & UParticleModuleTypeDataRibbon.__PropertyMask_bClipSourceSegement) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UParticleModuleTypeDataRibbon.__PropertyOffset_bClipSourceSegement) = ((*(base.NativePtr + (IntPtr)UParticleModuleTypeDataRibbon.__PropertyOffset_bClipSourceSegement) & ~UParticleModuleTypeDataRibbon.__PropertyMask_bClipSourceSegement) | (value ? UParticleModuleTypeDataRibbon.__PropertyMask_bClipSourceSegement : 0));
			}
		}

		// Token: 0x170032F6 RID: 13046
		// (get) Token: 0x0600D851 RID: 55377 RVA: 0x0013F21E File Offset: 0x0013D41E
		// (set) Token: 0x0600D852 RID: 55378 RVA: 0x0013F237 File Offset: 0x0013D437
		public unsafe bool bEnablePreviousTangentRecalculation
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UParticleModuleTypeDataRibbon.__PropertyOffset_bEnablePreviousTangentRecalculation) & UParticleModuleTypeDataRibbon.__PropertyMask_bEnablePreviousTangentRecalculation) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UParticleModuleTypeDataRibbon.__PropertyOffset_bEnablePreviousTangentRecalculation) = ((*(base.NativePtr + (IntPtr)UParticleModuleTypeDataRibbon.__PropertyOffset_bEnablePreviousTangentRecalculation) & ~UParticleModuleTypeDataRibbon.__PropertyMask_bEnablePreviousTangentRecalculation) | (value ? UParticleModuleTypeDataRibbon.__PropertyMask_bEnablePreviousTangentRecalculation : 0));
			}
		}

		// Token: 0x170032F7 RID: 13047
		// (get) Token: 0x0600D853 RID: 55379 RVA: 0x0013F267 File Offset: 0x0013D467
		// (set) Token: 0x0600D854 RID: 55380 RVA: 0x0013F280 File Offset: 0x0013D480
		public unsafe bool bTangentRecalculationEveryFrame
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UParticleModuleTypeDataRibbon.__PropertyOffset_bTangentRecalculationEveryFrame) & UParticleModuleTypeDataRibbon.__PropertyMask_bTangentRecalculationEveryFrame) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UParticleModuleTypeDataRibbon.__PropertyOffset_bTangentRecalculationEveryFrame) = ((*(base.NativePtr + (IntPtr)UParticleModuleTypeDataRibbon.__PropertyOffset_bTangentRecalculationEveryFrame) & ~UParticleModuleTypeDataRibbon.__PropertyMask_bTangentRecalculationEveryFrame) | (value ? UParticleModuleTypeDataRibbon.__PropertyMask_bTangentRecalculationEveryFrame : 0));
			}
		}

		// Token: 0x170032F8 RID: 13048
		// (get) Token: 0x0600D855 RID: 55381 RVA: 0x0013F2B0 File Offset: 0x0013D4B0
		// (set) Token: 0x0600D856 RID: 55382 RVA: 0x0013F2C9 File Offset: 0x0013D4C9
		public unsafe bool bSpawnInitialParticle
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UParticleModuleTypeDataRibbon.__PropertyOffset_bSpawnInitialParticle) & UParticleModuleTypeDataRibbon.__PropertyMask_bSpawnInitialParticle) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UParticleModuleTypeDataRibbon.__PropertyOffset_bSpawnInitialParticle) = ((*(base.NativePtr + (IntPtr)UParticleModuleTypeDataRibbon.__PropertyOffset_bSpawnInitialParticle) & ~UParticleModuleTypeDataRibbon.__PropertyMask_bSpawnInitialParticle) | (value ? UParticleModuleTypeDataRibbon.__PropertyMask_bSpawnInitialParticle : 0));
			}
		}

		// Token: 0x170032F9 RID: 13049
		// (get) Token: 0x0600D857 RID: 55383 RVA: 0x0013F2F9 File Offset: 0x0013D4F9
		// (set) Token: 0x0600D858 RID: 55384 RVA: 0x0013F30D File Offset: 0x0013D50D
		public unsafe TEnumAsByte<ETrailsRenderAxisOption> RenderAxis
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UParticleModuleTypeDataRibbon.__PropertyOffset_RenderAxis);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UParticleModuleTypeDataRibbon.__PropertyOffset_RenderAxis) = value;
			}
		}

		// Token: 0x170032FA RID: 13050
		// (get) Token: 0x0600D859 RID: 55385 RVA: 0x0013F322 File Offset: 0x0013D522
		// (set) Token: 0x0600D85A RID: 55386 RVA: 0x0013F332 File Offset: 0x0013D532
		public unsafe float TangentSpawningScalar
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UParticleModuleTypeDataRibbon.__PropertyOffset_TangentSpawningScalar);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UParticleModuleTypeDataRibbon.__PropertyOffset_TangentSpawningScalar) = value;
			}
		}

		// Token: 0x170032FB RID: 13051
		// (get) Token: 0x0600D85B RID: 55387 RVA: 0x0013F343 File Offset: 0x0013D543
		// (set) Token: 0x0600D85C RID: 55388 RVA: 0x0013F35C File Offset: 0x0013D55C
		public unsafe bool bRenderGeometry
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UParticleModuleTypeDataRibbon.__PropertyOffset_bRenderGeometry) & UParticleModuleTypeDataRibbon.__PropertyMask_bRenderGeometry) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UParticleModuleTypeDataRibbon.__PropertyOffset_bRenderGeometry) = ((*(base.NativePtr + (IntPtr)UParticleModuleTypeDataRibbon.__PropertyOffset_bRenderGeometry) & ~UParticleModuleTypeDataRibbon.__PropertyMask_bRenderGeometry) | (value ? UParticleModuleTypeDataRibbon.__PropertyMask_bRenderGeometry : 0));
			}
		}

		// Token: 0x170032FC RID: 13052
		// (get) Token: 0x0600D85D RID: 55389 RVA: 0x0013F38C File Offset: 0x0013D58C
		// (set) Token: 0x0600D85E RID: 55390 RVA: 0x0013F3A5 File Offset: 0x0013D5A5
		public unsafe bool bRenderSpawnPoints
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UParticleModuleTypeDataRibbon.__PropertyOffset_bRenderSpawnPoints) & UParticleModuleTypeDataRibbon.__PropertyMask_bRenderSpawnPoints) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UParticleModuleTypeDataRibbon.__PropertyOffset_bRenderSpawnPoints) = ((*(base.NativePtr + (IntPtr)UParticleModuleTypeDataRibbon.__PropertyOffset_bRenderSpawnPoints) & ~UParticleModuleTypeDataRibbon.__PropertyMask_bRenderSpawnPoints) | (value ? UParticleModuleTypeDataRibbon.__PropertyMask_bRenderSpawnPoints : 0));
			}
		}

		// Token: 0x170032FD RID: 13053
		// (get) Token: 0x0600D85F RID: 55391 RVA: 0x0013F3D5 File Offset: 0x0013D5D5
		// (set) Token: 0x0600D860 RID: 55392 RVA: 0x0013F3EE File Offset: 0x0013D5EE
		public unsafe bool bRenderTangents
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UParticleModuleTypeDataRibbon.__PropertyOffset_bRenderTangents) & UParticleModuleTypeDataRibbon.__PropertyMask_bRenderTangents) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UParticleModuleTypeDataRibbon.__PropertyOffset_bRenderTangents) = ((*(base.NativePtr + (IntPtr)UParticleModuleTypeDataRibbon.__PropertyOffset_bRenderTangents) & ~UParticleModuleTypeDataRibbon.__PropertyMask_bRenderTangents) | (value ? UParticleModuleTypeDataRibbon.__PropertyMask_bRenderTangents : 0));
			}
		}

		// Token: 0x170032FE RID: 13054
		// (get) Token: 0x0600D861 RID: 55393 RVA: 0x0013F41E File Offset: 0x0013D61E
		// (set) Token: 0x0600D862 RID: 55394 RVA: 0x0013F437 File Offset: 0x0013D637
		public unsafe bool bRenderTessellation
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UParticleModuleTypeDataRibbon.__PropertyOffset_bRenderTessellation) & UParticleModuleTypeDataRibbon.__PropertyMask_bRenderTessellation) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UParticleModuleTypeDataRibbon.__PropertyOffset_bRenderTessellation) = ((*(base.NativePtr + (IntPtr)UParticleModuleTypeDataRibbon.__PropertyOffset_bRenderTessellation) & ~UParticleModuleTypeDataRibbon.__PropertyMask_bRenderTessellation) | (value ? UParticleModuleTypeDataRibbon.__PropertyMask_bRenderTessellation : 0));
			}
		}

		// Token: 0x170032FF RID: 13055
		// (get) Token: 0x0600D863 RID: 55395 RVA: 0x0013F467 File Offset: 0x0013D667
		// (set) Token: 0x0600D864 RID: 55396 RVA: 0x0013F477 File Offset: 0x0013D677
		public unsafe float TilingDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UParticleModuleTypeDataRibbon.__PropertyOffset_TilingDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UParticleModuleTypeDataRibbon.__PropertyOffset_TilingDistance) = value;
			}
		}

		// Token: 0x17003300 RID: 13056
		// (get) Token: 0x0600D865 RID: 55397 RVA: 0x0013F488 File Offset: 0x0013D688
		// (set) Token: 0x0600D866 RID: 55398 RVA: 0x0013F498 File Offset: 0x0013D698
		public unsafe float DistanceTessellationStepSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UParticleModuleTypeDataRibbon.__PropertyOffset_DistanceTessellationStepSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UParticleModuleTypeDataRibbon.__PropertyOffset_DistanceTessellationStepSize) = value;
			}
		}

		// Token: 0x17003301 RID: 13057
		// (get) Token: 0x0600D867 RID: 55399 RVA: 0x0013F4A9 File Offset: 0x0013D6A9
		// (set) Token: 0x0600D868 RID: 55400 RVA: 0x0013F4C2 File Offset: 0x0013D6C2
		public unsafe bool bEnableTangentDiffInterpScale
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UParticleModuleTypeDataRibbon.__PropertyOffset_bEnableTangentDiffInterpScale) & UParticleModuleTypeDataRibbon.__PropertyMask_bEnableTangentDiffInterpScale) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UParticleModuleTypeDataRibbon.__PropertyOffset_bEnableTangentDiffInterpScale) = ((*(base.NativePtr + (IntPtr)UParticleModuleTypeDataRibbon.__PropertyOffset_bEnableTangentDiffInterpScale) & ~UParticleModuleTypeDataRibbon.__PropertyMask_bEnableTangentDiffInterpScale) | (value ? UParticleModuleTypeDataRibbon.__PropertyMask_bEnableTangentDiffInterpScale : 0));
			}
		}

		// Token: 0x17003302 RID: 13058
		// (get) Token: 0x0600D869 RID: 55401 RVA: 0x0013F4F2 File Offset: 0x0013D6F2
		// (set) Token: 0x0600D86A RID: 55402 RVA: 0x0013F502 File Offset: 0x0013D702
		public unsafe float TangentTessellationScalar
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UParticleModuleTypeDataRibbon.__PropertyOffset_TangentTessellationScalar);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UParticleModuleTypeDataRibbon.__PropertyOffset_TangentTessellationScalar) = value;
			}
		}

		// Token: 0x0600D86B RID: 55403 RVA: 0x0013F513 File Offset: 0x0013D713
		static UParticleModuleTypeDataRibbon()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.ParticleModuleTypeDataRibbon");
		}

		// Token: 0x0600D86C RID: 55404 RVA: 0x0013F521 File Offset: 0x0013D721
		protected UParticleModuleTypeDataRibbon(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04007526 RID: 29990
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.ParticleModuleTypeDataRibbon";

		// Token: 0x04007527 RID: 29991
		private static IntPtr _ClassPtr;

		// Token: 0x04007528 RID: 29992
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04007529 RID: 29993
		internal static int __PropertyOffset_MaxTessellationBetweenParticles;

		// Token: 0x0400752A RID: 29994
		internal static int __PropertyOffset_SheetsPerTrail;

		// Token: 0x0400752B RID: 29995
		internal static int __PropertyOffset_MaxTrailCount;

		// Token: 0x0400752C RID: 29996
		internal static int __PropertyOffset_MaxParticleInTrailCount;

		// Token: 0x0400752D RID: 29997
		internal static int __PropertyOffset_bDeadTrailsOnDeactivate;

		// Token: 0x0400752E RID: 29998
		internal static byte __PropertyMask_bDeadTrailsOnDeactivate;

		// Token: 0x0400752F RID: 29999
		internal static int __PropertyOffset_bDeadTrailsOnSourceLoss;

		// Token: 0x04007530 RID: 30000
		internal static byte __PropertyMask_bDeadTrailsOnSourceLoss;

		// Token: 0x04007531 RID: 30001
		internal static int __PropertyOffset_bClipSourceSegement;

		// Token: 0x04007532 RID: 30002
		internal static byte __PropertyMask_bClipSourceSegement;

		// Token: 0x04007533 RID: 30003
		internal static int __PropertyOffset_bEnablePreviousTangentRecalculation;

		// Token: 0x04007534 RID: 30004
		internal static byte __PropertyMask_bEnablePreviousTangentRecalculation;

		// Token: 0x04007535 RID: 30005
		internal static int __PropertyOffset_bTangentRecalculationEveryFrame;

		// Token: 0x04007536 RID: 30006
		internal static byte __PropertyMask_bTangentRecalculationEveryFrame;

		// Token: 0x04007537 RID: 30007
		internal static int __PropertyOffset_bSpawnInitialParticle;

		// Token: 0x04007538 RID: 30008
		internal static byte __PropertyMask_bSpawnInitialParticle;

		// Token: 0x04007539 RID: 30009
		internal static int __PropertyOffset_RenderAxis;

		// Token: 0x0400753A RID: 30010
		internal static int __PropertyOffset_TangentSpawningScalar;

		// Token: 0x0400753B RID: 30011
		internal static int __PropertyOffset_bRenderGeometry;

		// Token: 0x0400753C RID: 30012
		internal static byte __PropertyMask_bRenderGeometry;

		// Token: 0x0400753D RID: 30013
		internal static int __PropertyOffset_bRenderSpawnPoints;

		// Token: 0x0400753E RID: 30014
		internal static byte __PropertyMask_bRenderSpawnPoints;

		// Token: 0x0400753F RID: 30015
		internal static int __PropertyOffset_bRenderTangents;

		// Token: 0x04007540 RID: 30016
		internal static byte __PropertyMask_bRenderTangents;

		// Token: 0x04007541 RID: 30017
		internal static int __PropertyOffset_bRenderTessellation;

		// Token: 0x04007542 RID: 30018
		internal static byte __PropertyMask_bRenderTessellation;

		// Token: 0x04007543 RID: 30019
		internal static int __PropertyOffset_TilingDistance;

		// Token: 0x04007544 RID: 30020
		internal static int __PropertyOffset_DistanceTessellationStepSize;

		// Token: 0x04007545 RID: 30021
		internal static int __PropertyOffset_bEnableTangentDiffInterpScale;

		// Token: 0x04007546 RID: 30022
		internal static byte __PropertyMask_bEnableTangentDiffInterpScale;

		// Token: 0x04007547 RID: 30023
		internal static int __PropertyOffset_TangentTessellationScalar;
	}
}
