using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001C36 RID: 7222
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.VolumeCloudGodRaySetting")]
	[UnrealStructLayout(44, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 44)]
	public class FVolumeCloudGodRaySetting : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601BFD0 RID: 114640 RVA: 0x00292EB0 File Offset: 0x002910B0
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FVolumeCloudGodRaySetting._ScriptStructPtr != 0) ? FVolumeCloudGodRaySetting._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroRenderingRuntimeBPPlugin.VolumeCloudGodRaySetting", ref FVolumeCloudGodRaySetting._ScriptStructPtr);
		}

		// Token: 0x1700710D RID: 28941
		// (get) Token: 0x0601BFD1 RID: 114641 RVA: 0x00292ED4 File Offset: 0x002910D4
		// (set) Token: 0x0601BFD2 RID: 114642 RVA: 0x00292EED File Offset: 0x002910ED
		public unsafe bool bOverride_bEnableMieGodRayVolume
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FVolumeCloudGodRaySetting.__PropertyOffset_bOverride_bEnableMieGodRayVolume) & FVolumeCloudGodRaySetting.__PropertyMask_bOverride_bEnableMieGodRayVolume) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FVolumeCloudGodRaySetting.__PropertyOffset_bOverride_bEnableMieGodRayVolume) = ((*(base.NativePtr + (IntPtr)FVolumeCloudGodRaySetting.__PropertyOffset_bOverride_bEnableMieGodRayVolume) & ~FVolumeCloudGodRaySetting.__PropertyMask_bOverride_bEnableMieGodRayVolume) | (value ? FVolumeCloudGodRaySetting.__PropertyMask_bOverride_bEnableMieGodRayVolume : 0));
			}
		}

		// Token: 0x1700710E RID: 28942
		// (get) Token: 0x0601BFD3 RID: 114643 RVA: 0x00292F1D File Offset: 0x0029111D
		// (set) Token: 0x0601BFD4 RID: 114644 RVA: 0x00292F36 File Offset: 0x00291136
		public unsafe bool bOverride_MieGodRayScatteringScale
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FVolumeCloudGodRaySetting.__PropertyOffset_bOverride_MieGodRayScatteringScale) & FVolumeCloudGodRaySetting.__PropertyMask_bOverride_MieGodRayScatteringScale) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FVolumeCloudGodRaySetting.__PropertyOffset_bOverride_MieGodRayScatteringScale) = ((*(base.NativePtr + (IntPtr)FVolumeCloudGodRaySetting.__PropertyOffset_bOverride_MieGodRayScatteringScale) & ~FVolumeCloudGodRaySetting.__PropertyMask_bOverride_MieGodRayScatteringScale) | (value ? FVolumeCloudGodRaySetting.__PropertyMask_bOverride_MieGodRayScatteringScale : 0));
			}
		}

		// Token: 0x1700710F RID: 28943
		// (get) Token: 0x0601BFD5 RID: 114645 RVA: 0x00292F66 File Offset: 0x00291166
		// (set) Token: 0x0601BFD6 RID: 114646 RVA: 0x00292F7F File Offset: 0x0029117F
		public unsafe bool bOverride_MieGodRayScattering
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FVolumeCloudGodRaySetting.__PropertyOffset_bOverride_MieGodRayScattering) & FVolumeCloudGodRaySetting.__PropertyMask_bOverride_MieGodRayScattering) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FVolumeCloudGodRaySetting.__PropertyOffset_bOverride_MieGodRayScattering) = ((*(base.NativePtr + (IntPtr)FVolumeCloudGodRaySetting.__PropertyOffset_bOverride_MieGodRayScattering) & ~FVolumeCloudGodRaySetting.__PropertyMask_bOverride_MieGodRayScattering) | (value ? FVolumeCloudGodRaySetting.__PropertyMask_bOverride_MieGodRayScattering : 0));
			}
		}

		// Token: 0x17007110 RID: 28944
		// (get) Token: 0x0601BFD7 RID: 114647 RVA: 0x00292FAF File Offset: 0x002911AF
		// (set) Token: 0x0601BFD8 RID: 114648 RVA: 0x00292FC8 File Offset: 0x002911C8
		public unsafe bool bOverride_MieGodRayAnisotropy
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FVolumeCloudGodRaySetting.__PropertyOffset_bOverride_MieGodRayAnisotropy) & FVolumeCloudGodRaySetting.__PropertyMask_bOverride_MieGodRayAnisotropy) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FVolumeCloudGodRaySetting.__PropertyOffset_bOverride_MieGodRayAnisotropy) = ((*(base.NativePtr + (IntPtr)FVolumeCloudGodRaySetting.__PropertyOffset_bOverride_MieGodRayAnisotropy) & ~FVolumeCloudGodRaySetting.__PropertyMask_bOverride_MieGodRayAnisotropy) | (value ? FVolumeCloudGodRaySetting.__PropertyMask_bOverride_MieGodRayAnisotropy : 0));
			}
		}

		// Token: 0x17007111 RID: 28945
		// (get) Token: 0x0601BFD9 RID: 114649 RVA: 0x00292FF8 File Offset: 0x002911F8
		// (set) Token: 0x0601BFDA RID: 114650 RVA: 0x00293011 File Offset: 0x00291211
		public unsafe bool bOverride_MieGodRayViewDistanceScale
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FVolumeCloudGodRaySetting.__PropertyOffset_bOverride_MieGodRayViewDistanceScale) & FVolumeCloudGodRaySetting.__PropertyMask_bOverride_MieGodRayViewDistanceScale) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FVolumeCloudGodRaySetting.__PropertyOffset_bOverride_MieGodRayViewDistanceScale) = ((*(base.NativePtr + (IntPtr)FVolumeCloudGodRaySetting.__PropertyOffset_bOverride_MieGodRayViewDistanceScale) & ~FVolumeCloudGodRaySetting.__PropertyMask_bOverride_MieGodRayViewDistanceScale) | (value ? FVolumeCloudGodRaySetting.__PropertyMask_bOverride_MieGodRayViewDistanceScale : 0));
			}
		}

		// Token: 0x17007112 RID: 28946
		// (get) Token: 0x0601BFDB RID: 114651 RVA: 0x00293041 File Offset: 0x00291241
		// (set) Token: 0x0601BFDC RID: 114652 RVA: 0x0029305A File Offset: 0x0029125A
		public unsafe bool bOverride_MieGodRayStartDepth
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FVolumeCloudGodRaySetting.__PropertyOffset_bOverride_MieGodRayStartDepth) & FVolumeCloudGodRaySetting.__PropertyMask_bOverride_MieGodRayStartDepth) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FVolumeCloudGodRaySetting.__PropertyOffset_bOverride_MieGodRayStartDepth) = ((*(base.NativePtr + (IntPtr)FVolumeCloudGodRaySetting.__PropertyOffset_bOverride_MieGodRayStartDepth) & ~FVolumeCloudGodRaySetting.__PropertyMask_bOverride_MieGodRayStartDepth) | (value ? FVolumeCloudGodRaySetting.__PropertyMask_bOverride_MieGodRayStartDepth : 0));
			}
		}

		// Token: 0x17007113 RID: 28947
		// (get) Token: 0x0601BFDD RID: 114653 RVA: 0x0029308A File Offset: 0x0029128A
		// (set) Token: 0x0601BFDE RID: 114654 RVA: 0x002930A3 File Offset: 0x002912A3
		public unsafe bool bOverride_MieGodRaySunHaloPower
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FVolumeCloudGodRaySetting.__PropertyOffset_bOverride_MieGodRaySunHaloPower) & FVolumeCloudGodRaySetting.__PropertyMask_bOverride_MieGodRaySunHaloPower) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FVolumeCloudGodRaySetting.__PropertyOffset_bOverride_MieGodRaySunHaloPower) = ((*(base.NativePtr + (IntPtr)FVolumeCloudGodRaySetting.__PropertyOffset_bOverride_MieGodRaySunHaloPower) & ~FVolumeCloudGodRaySetting.__PropertyMask_bOverride_MieGodRaySunHaloPower) | (value ? FVolumeCloudGodRaySetting.__PropertyMask_bOverride_MieGodRaySunHaloPower : 0));
			}
		}

		// Token: 0x17007114 RID: 28948
		// (get) Token: 0x0601BFDF RID: 114655 RVA: 0x002930D3 File Offset: 0x002912D3
		// (set) Token: 0x0601BFE0 RID: 114656 RVA: 0x002930EC File Offset: 0x002912EC
		public unsafe bool bOverride_MieGodRayLuminanceScale
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FVolumeCloudGodRaySetting.__PropertyOffset_bOverride_MieGodRayLuminanceScale) & FVolumeCloudGodRaySetting.__PropertyMask_bOverride_MieGodRayLuminanceScale) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FVolumeCloudGodRaySetting.__PropertyOffset_bOverride_MieGodRayLuminanceScale) = ((*(base.NativePtr + (IntPtr)FVolumeCloudGodRaySetting.__PropertyOffset_bOverride_MieGodRayLuminanceScale) & ~FVolumeCloudGodRaySetting.__PropertyMask_bOverride_MieGodRayLuminanceScale) | (value ? FVolumeCloudGodRaySetting.__PropertyMask_bOverride_MieGodRayLuminanceScale : 0));
			}
		}

		// Token: 0x17007115 RID: 28949
		// (get) Token: 0x0601BFE1 RID: 114657 RVA: 0x0029311C File Offset: 0x0029131C
		// (set) Token: 0x0601BFE2 RID: 114658 RVA: 0x0029312C File Offset: 0x0029132C
		public unsafe bool bEnableMieGodRayVolume
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FVolumeCloudGodRaySetting.__PropertyOffset_bEnableMieGodRayVolume) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FVolumeCloudGodRaySetting.__PropertyOffset_bEnableMieGodRayVolume) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007116 RID: 28950
		// (get) Token: 0x0601BFE3 RID: 114659 RVA: 0x0029313D File Offset: 0x0029133D
		// (set) Token: 0x0601BFE4 RID: 114660 RVA: 0x0029314D File Offset: 0x0029134D
		public unsafe float MieGodRayScatteringScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FVolumeCloudGodRaySetting.__PropertyOffset_MieGodRayScatteringScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FVolumeCloudGodRaySetting.__PropertyOffset_MieGodRayScatteringScale) = value;
			}
		}

		// Token: 0x17007117 RID: 28951
		// (get) Token: 0x0601BFE5 RID: 114661 RVA: 0x0029315E File Offset: 0x0029135E
		// (set) Token: 0x0601BFE6 RID: 114662 RVA: 0x00293172 File Offset: 0x00291372
		public unsafe FLinearColor MieGodRayScattering
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FVolumeCloudGodRaySetting.__PropertyOffset_MieGodRayScattering);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FVolumeCloudGodRaySetting.__PropertyOffset_MieGodRayScattering) = value;
			}
		}

		// Token: 0x17007118 RID: 28952
		// (get) Token: 0x0601BFE7 RID: 114663 RVA: 0x00293187 File Offset: 0x00291387
		// (set) Token: 0x0601BFE8 RID: 114664 RVA: 0x00293197 File Offset: 0x00291397
		public unsafe float MieGodRayAnisotropy
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FVolumeCloudGodRaySetting.__PropertyOffset_MieGodRayAnisotropy);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FVolumeCloudGodRaySetting.__PropertyOffset_MieGodRayAnisotropy) = value;
			}
		}

		// Token: 0x17007119 RID: 28953
		// (get) Token: 0x0601BFE9 RID: 114665 RVA: 0x002931A8 File Offset: 0x002913A8
		// (set) Token: 0x0601BFEA RID: 114666 RVA: 0x002931B8 File Offset: 0x002913B8
		public unsafe float MieGodRayViewDistanceScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FVolumeCloudGodRaySetting.__PropertyOffset_MieGodRayViewDistanceScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FVolumeCloudGodRaySetting.__PropertyOffset_MieGodRayViewDistanceScale) = value;
			}
		}

		// Token: 0x1700711A RID: 28954
		// (get) Token: 0x0601BFEB RID: 114667 RVA: 0x002931C9 File Offset: 0x002913C9
		// (set) Token: 0x0601BFEC RID: 114668 RVA: 0x002931D9 File Offset: 0x002913D9
		public unsafe float MieGodRayStartDepth
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FVolumeCloudGodRaySetting.__PropertyOffset_MieGodRayStartDepth);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FVolumeCloudGodRaySetting.__PropertyOffset_MieGodRayStartDepth) = value;
			}
		}

		// Token: 0x1700711B RID: 28955
		// (get) Token: 0x0601BFED RID: 114669 RVA: 0x002931EA File Offset: 0x002913EA
		// (set) Token: 0x0601BFEE RID: 114670 RVA: 0x002931FA File Offset: 0x002913FA
		public unsafe float MieGodRaySunHaloPower
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FVolumeCloudGodRaySetting.__PropertyOffset_MieGodRaySunHaloPower);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FVolumeCloudGodRaySetting.__PropertyOffset_MieGodRaySunHaloPower) = value;
			}
		}

		// Token: 0x1700711C RID: 28956
		// (get) Token: 0x0601BFEF RID: 114671 RVA: 0x0029320B File Offset: 0x0029140B
		// (set) Token: 0x0601BFF0 RID: 114672 RVA: 0x0029321B File Offset: 0x0029141B
		public unsafe float MieGodRayLuminanceScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FVolumeCloudGodRaySetting.__PropertyOffset_MieGodRayLuminanceScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FVolumeCloudGodRaySetting.__PropertyOffset_MieGodRayLuminanceScale) = value;
			}
		}

		// Token: 0x0601BFF1 RID: 114673 RVA: 0x0029322C File Offset: 0x0029142C
		public FVolumeCloudGodRaySetting()
		{
		}

		// Token: 0x0601BFF2 RID: 114674 RVA: 0x00293234 File Offset: 0x00291434
		public FVolumeCloudGodRaySetting(bool bOverride_bEnableMieGodRayVolume, bool bOverride_MieGodRayScatteringScale, bool bOverride_MieGodRayScattering, bool bOverride_MieGodRayAnisotropy, bool bOverride_MieGodRayViewDistanceScale, bool bOverride_MieGodRayStartDepth, bool bOverride_MieGodRaySunHaloPower, bool bOverride_MieGodRayLuminanceScale, bool bEnableMieGodRayVolume, float MieGodRayScatteringScale, FLinearColor MieGodRayScattering, float MieGodRayAnisotropy, float MieGodRayViewDistanceScale, float MieGodRayStartDepth, float MieGodRaySunHaloPower, float MieGodRayLuminanceScale)
		{
			this.bOverride_bEnableMieGodRayVolume = bOverride_bEnableMieGodRayVolume;
			this.bOverride_MieGodRayScatteringScale = bOverride_MieGodRayScatteringScale;
			this.bOverride_MieGodRayScattering = bOverride_MieGodRayScattering;
			this.bOverride_MieGodRayAnisotropy = bOverride_MieGodRayAnisotropy;
			this.bOverride_MieGodRayViewDistanceScale = bOverride_MieGodRayViewDistanceScale;
			this.bOverride_MieGodRayStartDepth = bOverride_MieGodRayStartDepth;
			this.bOverride_MieGodRaySunHaloPower = bOverride_MieGodRaySunHaloPower;
			this.bOverride_MieGodRayLuminanceScale = bOverride_MieGodRayLuminanceScale;
			this.bEnableMieGodRayVolume = bEnableMieGodRayVolume;
			this.MieGodRayScatteringScale = MieGodRayScatteringScale;
			this.MieGodRayScattering = MieGodRayScattering;
			this.MieGodRayAnisotropy = MieGodRayAnisotropy;
			this.MieGodRayViewDistanceScale = MieGodRayViewDistanceScale;
			this.MieGodRayStartDepth = MieGodRayStartDepth;
			this.MieGodRaySunHaloPower = MieGodRaySunHaloPower;
			this.MieGodRayLuminanceScale = MieGodRayLuminanceScale;
		}

		// Token: 0x0601BFF3 RID: 114675 RVA: 0x002932C4 File Offset: 0x002914C4
		protected override IntPtr GetUStructPtr()
		{
			return FVolumeCloudGodRaySetting.StaticStruct();
		}

		// Token: 0x0601BFF4 RID: 114676 RVA: 0x002932D0 File Offset: 0x002914D0
		[NullableContext(2)]
		public FVolumeCloudGodRaySetting(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601BFF5 RID: 114677 RVA: 0x002932DA File Offset: 0x002914DA
		public FVolumeCloudGodRaySetting(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601BFF6 RID: 114678 RVA: 0x002932E5 File Offset: 0x002914E5
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FVolumeCloudGodRaySetting(Pointer, false, true);
		}

		// Token: 0x0601BFF7 RID: 114679 RVA: 0x002932EF File Offset: 0x002914EF
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FVolumeCloudGodRaySetting(Pointer, MemoryOwner);
		}

		// Token: 0x0400F074 RID: 61556
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.VolumeCloudGodRaySetting";

		// Token: 0x0400F075 RID: 61557
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400F076 RID: 61558
		internal static int __PropertyOffset_bOverride_bEnableMieGodRayVolume;

		// Token: 0x0400F077 RID: 61559
		internal static byte __PropertyMask_bOverride_bEnableMieGodRayVolume;

		// Token: 0x0400F078 RID: 61560
		internal static int __PropertyOffset_bOverride_MieGodRayScatteringScale;

		// Token: 0x0400F079 RID: 61561
		internal static byte __PropertyMask_bOverride_MieGodRayScatteringScale;

		// Token: 0x0400F07A RID: 61562
		internal static int __PropertyOffset_bOverride_MieGodRayScattering;

		// Token: 0x0400F07B RID: 61563
		internal static byte __PropertyMask_bOverride_MieGodRayScattering;

		// Token: 0x0400F07C RID: 61564
		internal static int __PropertyOffset_bOverride_MieGodRayAnisotropy;

		// Token: 0x0400F07D RID: 61565
		internal static byte __PropertyMask_bOverride_MieGodRayAnisotropy;

		// Token: 0x0400F07E RID: 61566
		internal static int __PropertyOffset_bOverride_MieGodRayViewDistanceScale;

		// Token: 0x0400F07F RID: 61567
		internal static byte __PropertyMask_bOverride_MieGodRayViewDistanceScale;

		// Token: 0x0400F080 RID: 61568
		internal static int __PropertyOffset_bOverride_MieGodRayStartDepth;

		// Token: 0x0400F081 RID: 61569
		internal static byte __PropertyMask_bOverride_MieGodRayStartDepth;

		// Token: 0x0400F082 RID: 61570
		internal static int __PropertyOffset_bOverride_MieGodRaySunHaloPower;

		// Token: 0x0400F083 RID: 61571
		internal static byte __PropertyMask_bOverride_MieGodRaySunHaloPower;

		// Token: 0x0400F084 RID: 61572
		internal static int __PropertyOffset_bOverride_MieGodRayLuminanceScale;

		// Token: 0x0400F085 RID: 61573
		internal static byte __PropertyMask_bOverride_MieGodRayLuminanceScale;

		// Token: 0x0400F086 RID: 61574
		internal static int __PropertyOffset_bEnableMieGodRayVolume;

		// Token: 0x0400F087 RID: 61575
		internal static int __PropertyOffset_MieGodRayScatteringScale;

		// Token: 0x0400F088 RID: 61576
		internal static int __PropertyOffset_MieGodRayScattering;

		// Token: 0x0400F089 RID: 61577
		internal static int __PropertyOffset_MieGodRayAnisotropy;

		// Token: 0x0400F08A RID: 61578
		internal static int __PropertyOffset_MieGodRayViewDistanceScale;

		// Token: 0x0400F08B RID: 61579
		internal static int __PropertyOffset_MieGodRayStartDepth;

		// Token: 0x0400F08C RID: 61580
		internal static int __PropertyOffset_MieGodRaySunHaloPower;

		// Token: 0x0400F08D RID: 61581
		internal static int __PropertyOffset_MieGodRayLuminanceScale;
	}
}
