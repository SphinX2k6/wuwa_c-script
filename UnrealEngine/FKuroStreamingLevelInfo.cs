using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001BC9 RID: 7113
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroStreamingLevelInfo")]
	[UnrealStructLayout(48, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FKuroStreamingLevelInfo : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601B4A6 RID: 111782 RVA: 0x0028367B File Offset: 0x0028187B
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroStreamingLevelInfo._ScriptStructPtr != 0) ? FKuroStreamingLevelInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroRenderingRuntimeBPPlugin.KuroStreamingLevelInfo", ref FKuroStreamingLevelInfo._ScriptStructPtr);
		}

		// Token: 0x17006D9F RID: 28063
		// (get) Token: 0x0601B4A7 RID: 111783 RVA: 0x0028369F File Offset: 0x0028189F
		// (set) Token: 0x0601B4A8 RID: 111784 RVA: 0x002836B3 File Offset: 0x002818B3
		public unsafe FName PackageName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroStreamingLevelInfo.__PropertyOffset_PackageName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroStreamingLevelInfo.__PropertyOffset_PackageName) = value;
			}
		}

		// Token: 0x17006DA0 RID: 28064
		// (get) Token: 0x0601B4A9 RID: 111785 RVA: 0x002836C8 File Offset: 0x002818C8
		// (set) Token: 0x0601B4AA RID: 111786 RVA: 0x002836DC File Offset: 0x002818DC
		public unsafe FName LayerName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroStreamingLevelInfo.__PropertyOffset_LayerName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroStreamingLevelInfo.__PropertyOffset_LayerName) = value;
			}
		}

		// Token: 0x17006DA1 RID: 28065
		// (get) Token: 0x0601B4AB RID: 111787 RVA: 0x002836F1 File Offset: 0x002818F1
		// (set) Token: 0x0601B4AC RID: 111788 RVA: 0x00283701 File Offset: 0x00281901
		public unsafe bool bEnableDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroStreamingLevelInfo.__PropertyOffset_bEnableDistance) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroStreamingLevelInfo.__PropertyOffset_bEnableDistance) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006DA2 RID: 28066
		// (get) Token: 0x0601B4AD RID: 111789 RVA: 0x00283712 File Offset: 0x00281912
		// (set) Token: 0x0601B4AE RID: 111790 RVA: 0x00283722 File Offset: 0x00281922
		public unsafe int ShowDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroStreamingLevelInfo.__PropertyOffset_ShowDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroStreamingLevelInfo.__PropertyOffset_ShowDistance) = value;
			}
		}

		// Token: 0x17006DA3 RID: 28067
		// (get) Token: 0x0601B4AF RID: 111791 RVA: 0x00283733 File Offset: 0x00281933
		// (set) Token: 0x0601B4B0 RID: 111792 RVA: 0x00283743 File Offset: 0x00281943
		public unsafe bool bTileBaseOnLandscape
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroStreamingLevelInfo.__PropertyOffset_bTileBaseOnLandscape) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroStreamingLevelInfo.__PropertyOffset_bTileBaseOnLandscape) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006DA4 RID: 28068
		// (get) Token: 0x0601B4B1 RID: 111793 RVA: 0x00283754 File Offset: 0x00281954
		// (set) Token: 0x0601B4B2 RID: 111794 RVA: 0x00283764 File Offset: 0x00281964
		public unsafe bool bIsTile
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroStreamingLevelInfo.__PropertyOffset_bIsTile) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroStreamingLevelInfo.__PropertyOffset_bIsTile) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006DA5 RID: 28069
		// (get) Token: 0x0601B4B3 RID: 111795 RVA: 0x00283775 File Offset: 0x00281975
		// (set) Token: 0x0601B4B4 RID: 111796 RVA: 0x00283789 File Offset: 0x00281989
		public unsafe FIntPoint TileXY
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroStreamingLevelInfo.__PropertyOffset_TileXY);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroStreamingLevelInfo.__PropertyOffset_TileXY) = value;
			}
		}

		// Token: 0x17006DA6 RID: 28070
		// (get) Token: 0x0601B4B5 RID: 111797 RVA: 0x0028379E File Offset: 0x0028199E
		// (set) Token: 0x0601B4B6 RID: 111798 RVA: 0x002837AE File Offset: 0x002819AE
		public unsafe bool bUseHLOD
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroStreamingLevelInfo.__PropertyOffset_bUseHLOD) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroStreamingLevelInfo.__PropertyOffset_bUseHLOD) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006DA7 RID: 28071
		// (get) Token: 0x0601B4B7 RID: 111799 RVA: 0x002837BF File Offset: 0x002819BF
		// (set) Token: 0x0601B4B8 RID: 111800 RVA: 0x002837CF File Offset: 0x002819CF
		public unsafe bool bBakeShadow
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroStreamingLevelInfo.__PropertyOffset_bBakeShadow) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroStreamingLevelInfo.__PropertyOffset_bBakeShadow) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006DA8 RID: 28072
		// (get) Token: 0x0601B4B9 RID: 111801 RVA: 0x002837E0 File Offset: 0x002819E0
		// (set) Token: 0x0601B4BA RID: 111802 RVA: 0x002837F0 File Offset: 0x002819F0
		public unsafe bool bDynamicShadow
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroStreamingLevelInfo.__PropertyOffset_bDynamicShadow) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroStreamingLevelInfo.__PropertyOffset_bDynamicShadow) = (value ? 1 : 0);
			}
		}

		// Token: 0x0601B4BB RID: 111803 RVA: 0x00283801 File Offset: 0x00281A01
		public FKuroStreamingLevelInfo()
		{
		}

		// Token: 0x0601B4BC RID: 111804 RVA: 0x0028380C File Offset: 0x00281A0C
		public FKuroStreamingLevelInfo(FName PackageName, FName LayerName, bool bEnableDistance, int ShowDistance, bool bTileBaseOnLandscape, bool bIsTile, FIntPoint TileXY, bool bUseHLOD, bool bBakeShadow, bool bDynamicShadow)
		{
			this.PackageName = PackageName;
			this.LayerName = LayerName;
			this.bEnableDistance = bEnableDistance;
			this.ShowDistance = ShowDistance;
			this.bTileBaseOnLandscape = bTileBaseOnLandscape;
			this.bIsTile = bIsTile;
			this.TileXY = TileXY;
			this.bUseHLOD = bUseHLOD;
			this.bBakeShadow = bBakeShadow;
			this.bDynamicShadow = bDynamicShadow;
		}

		// Token: 0x0601B4BD RID: 111805 RVA: 0x0028386C File Offset: 0x00281A6C
		protected override IntPtr GetUStructPtr()
		{
			return FKuroStreamingLevelInfo.StaticStruct();
		}

		// Token: 0x0601B4BE RID: 111806 RVA: 0x00283878 File Offset: 0x00281A78
		[NullableContext(2)]
		public FKuroStreamingLevelInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601B4BF RID: 111807 RVA: 0x00283882 File Offset: 0x00281A82
		public FKuroStreamingLevelInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601B4C0 RID: 111808 RVA: 0x0028388D File Offset: 0x00281A8D
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroStreamingLevelInfo(Pointer, false, true);
		}

		// Token: 0x0601B4C1 RID: 111809 RVA: 0x00283897 File Offset: 0x00281A97
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroStreamingLevelInfo(Pointer, MemoryOwner);
		}

		// Token: 0x0400EB26 RID: 60198
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroStreamingLevelInfo";

		// Token: 0x0400EB27 RID: 60199
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400EB28 RID: 60200
		internal static int __PropertyOffset_PackageName;

		// Token: 0x0400EB29 RID: 60201
		internal static int __PropertyOffset_LayerName;

		// Token: 0x0400EB2A RID: 60202
		internal static int __PropertyOffset_bEnableDistance;

		// Token: 0x0400EB2B RID: 60203
		internal static int __PropertyOffset_ShowDistance;

		// Token: 0x0400EB2C RID: 60204
		internal static int __PropertyOffset_bTileBaseOnLandscape;

		// Token: 0x0400EB2D RID: 60205
		internal static int __PropertyOffset_bIsTile;

		// Token: 0x0400EB2E RID: 60206
		internal static int __PropertyOffset_TileXY;

		// Token: 0x0400EB2F RID: 60207
		internal static int __PropertyOffset_bUseHLOD;

		// Token: 0x0400EB30 RID: 60208
		internal static int __PropertyOffset_bBakeShadow;

		// Token: 0x0400EB31 RID: 60209
		internal static int __PropertyOffset_bDynamicShadow;
	}
}
