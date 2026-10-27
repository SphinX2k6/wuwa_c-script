using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001B2D RID: 6957
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroLandscapeInfo")]
	[UnrealStructLayout(88, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 88)]
	public class FKuroLandscapeInfo : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601A419 RID: 107545 RVA: 0x0026BE51 File Offset: 0x0026A051
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroLandscapeInfo._ScriptStructPtr != 0) ? FKuroLandscapeInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroRenderingRuntimeBPPlugin.KuroLandscapeInfo", ref FKuroLandscapeInfo._ScriptStructPtr);
		}

		// Token: 0x17006992 RID: 27026
		// (get) Token: 0x0601A41A RID: 107546 RVA: 0x0026BE75 File Offset: 0x0026A075
		// (set) Token: 0x0601A41B RID: 107547 RVA: 0x0026BE85 File Offset: 0x0026A085
		public unsafe int TotalTileNumber
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroLandscapeInfo.__PropertyOffset_TotalTileNumber);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroLandscapeInfo.__PropertyOffset_TotalTileNumber) = value;
			}
		}

		// Token: 0x17006993 RID: 27027
		// (get) Token: 0x0601A41C RID: 107548 RVA: 0x0026BE96 File Offset: 0x0026A096
		// (set) Token: 0x0601A41D RID: 107549 RVA: 0x0026BEA6 File Offset: 0x0026A0A6
		public unsafe int TotalComponentNumber
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroLandscapeInfo.__PropertyOffset_TotalComponentNumber);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroLandscapeInfo.__PropertyOffset_TotalComponentNumber) = value;
			}
		}

		// Token: 0x17006994 RID: 27028
		// (get) Token: 0x0601A41E RID: 107550 RVA: 0x0026BEB7 File Offset: 0x0026A0B7
		// (set) Token: 0x0601A41F RID: 107551 RVA: 0x0026BEC7 File Offset: 0x0026A0C7
		public unsafe int TotalSectionNumber
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroLandscapeInfo.__PropertyOffset_TotalSectionNumber);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroLandscapeInfo.__PropertyOffset_TotalSectionNumber) = value;
			}
		}

		// Token: 0x17006995 RID: 27029
		// (get) Token: 0x0601A420 RID: 107552 RVA: 0x0026BED8 File Offset: 0x0026A0D8
		// (set) Token: 0x0601A421 RID: 107553 RVA: 0x0026BEE8 File Offset: 0x0026A0E8
		public unsafe int TileRow
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroLandscapeInfo.__PropertyOffset_TileRow);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroLandscapeInfo.__PropertyOffset_TileRow) = value;
			}
		}

		// Token: 0x17006996 RID: 27030
		// (get) Token: 0x0601A422 RID: 107554 RVA: 0x0026BEF9 File Offset: 0x0026A0F9
		// (set) Token: 0x0601A423 RID: 107555 RVA: 0x0026BF09 File Offset: 0x0026A109
		public unsafe int TileCol
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroLandscapeInfo.__PropertyOffset_TileCol);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroLandscapeInfo.__PropertyOffset_TileCol) = value;
			}
		}

		// Token: 0x17006997 RID: 27031
		// (get) Token: 0x0601A424 RID: 107556 RVA: 0x0026BF1A File Offset: 0x0026A11A
		// (set) Token: 0x0601A425 RID: 107557 RVA: 0x0026BF2A File Offset: 0x0026A12A
		public unsafe int ComponentNumberPerTile
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroLandscapeInfo.__PropertyOffset_ComponentNumberPerTile);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroLandscapeInfo.__PropertyOffset_ComponentNumberPerTile) = value;
			}
		}

		// Token: 0x17006998 RID: 27032
		// (get) Token: 0x0601A426 RID: 107558 RVA: 0x0026BF3B File Offset: 0x0026A13B
		// (set) Token: 0x0601A427 RID: 107559 RVA: 0x0026BF4B File Offset: 0x0026A14B
		public unsafe int SectionNumberPerComponent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroLandscapeInfo.__PropertyOffset_SectionNumberPerComponent);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroLandscapeInfo.__PropertyOffset_SectionNumberPerComponent) = value;
			}
		}

		// Token: 0x17006999 RID: 27033
		// (get) Token: 0x0601A428 RID: 107560 RVA: 0x0026BF5C File Offset: 0x0026A15C
		// (set) Token: 0x0601A429 RID: 107561 RVA: 0x0026BF70 File Offset: 0x0026A170
		public unsafe FIntPoint PerSectionResolution
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroLandscapeInfo.__PropertyOffset_PerSectionResolution);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroLandscapeInfo.__PropertyOffset_PerSectionResolution) = value;
			}
		}

		// Token: 0x1700699A RID: 27034
		// (get) Token: 0x0601A42A RID: 107562 RVA: 0x0026BF85 File Offset: 0x0026A185
		// (set) Token: 0x0601A42B RID: 107563 RVA: 0x0026BF99 File Offset: 0x0026A199
		public unsafe FIntPoint PerComponentResolution
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroLandscapeInfo.__PropertyOffset_PerComponentResolution);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroLandscapeInfo.__PropertyOffset_PerComponentResolution) = value;
			}
		}

		// Token: 0x1700699B RID: 27035
		// (get) Token: 0x0601A42C RID: 107564 RVA: 0x0026BFAE File Offset: 0x0026A1AE
		// (set) Token: 0x0601A42D RID: 107565 RVA: 0x0026BFC2 File Offset: 0x0026A1C2
		public unsafe FIntPoint PerTileResolution
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroLandscapeInfo.__PropertyOffset_PerTileResolution);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroLandscapeInfo.__PropertyOffset_PerTileResolution) = value;
			}
		}

		// Token: 0x1700699C RID: 27036
		// (get) Token: 0x0601A42E RID: 107566 RVA: 0x0026BFD7 File Offset: 0x0026A1D7
		// (set) Token: 0x0601A42F RID: 107567 RVA: 0x0026BFEB File Offset: 0x0026A1EB
		public unsafe FIntPoint TotalResolution
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroLandscapeInfo.__PropertyOffset_TotalResolution);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroLandscapeInfo.__PropertyOffset_TotalResolution) = value;
			}
		}

		// Token: 0x1700699D RID: 27037
		// (get) Token: 0x0601A430 RID: 107568 RVA: 0x0026C000 File Offset: 0x0026A200
		// (set) Token: 0x0601A431 RID: 107569 RVA: 0x0026C014 File Offset: 0x0026A214
		public unsafe FBox Bounds
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroLandscapeInfo.__PropertyOffset_Bounds);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroLandscapeInfo.__PropertyOffset_Bounds) = value;
			}
		}

		// Token: 0x0601A432 RID: 107570 RVA: 0x0026C029 File Offset: 0x0026A229
		public FKuroLandscapeInfo()
		{
		}

		// Token: 0x0601A433 RID: 107571 RVA: 0x0026C034 File Offset: 0x0026A234
		public FKuroLandscapeInfo(int TotalTileNumber, int TotalComponentNumber, int TotalSectionNumber, int TileRow, int TileCol, int ComponentNumberPerTile, int SectionNumberPerComponent, FIntPoint PerSectionResolution, FIntPoint PerComponentResolution, FIntPoint PerTileResolution, FIntPoint TotalResolution, FBox Bounds)
		{
			this.TotalTileNumber = TotalTileNumber;
			this.TotalComponentNumber = TotalComponentNumber;
			this.TotalSectionNumber = TotalSectionNumber;
			this.TileRow = TileRow;
			this.TileCol = TileCol;
			this.ComponentNumberPerTile = ComponentNumberPerTile;
			this.SectionNumberPerComponent = SectionNumberPerComponent;
			this.PerSectionResolution = PerSectionResolution;
			this.PerComponentResolution = PerComponentResolution;
			this.PerTileResolution = PerTileResolution;
			this.TotalResolution = TotalResolution;
			this.Bounds = Bounds;
		}

		// Token: 0x0601A434 RID: 107572 RVA: 0x0026C0A4 File Offset: 0x0026A2A4
		protected override IntPtr GetUStructPtr()
		{
			return FKuroLandscapeInfo.StaticStruct();
		}

		// Token: 0x0601A435 RID: 107573 RVA: 0x0026C0B0 File Offset: 0x0026A2B0
		[NullableContext(2)]
		public FKuroLandscapeInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601A436 RID: 107574 RVA: 0x0026C0BA File Offset: 0x0026A2BA
		public FKuroLandscapeInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601A437 RID: 107575 RVA: 0x0026C0C5 File Offset: 0x0026A2C5
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroLandscapeInfo(Pointer, false, true);
		}

		// Token: 0x0601A438 RID: 107576 RVA: 0x0026C0CF File Offset: 0x0026A2CF
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroLandscapeInfo(Pointer, MemoryOwner);
		}

		// Token: 0x0400E3FE RID: 58366
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroLandscapeInfo";

		// Token: 0x0400E3FF RID: 58367
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400E400 RID: 58368
		internal static int __PropertyOffset_TotalTileNumber;

		// Token: 0x0400E401 RID: 58369
		internal static int __PropertyOffset_TotalComponentNumber;

		// Token: 0x0400E402 RID: 58370
		internal static int __PropertyOffset_TotalSectionNumber;

		// Token: 0x0400E403 RID: 58371
		internal static int __PropertyOffset_TileRow;

		// Token: 0x0400E404 RID: 58372
		internal static int __PropertyOffset_TileCol;

		// Token: 0x0400E405 RID: 58373
		internal static int __PropertyOffset_ComponentNumberPerTile;

		// Token: 0x0400E406 RID: 58374
		internal static int __PropertyOffset_SectionNumberPerComponent;

		// Token: 0x0400E407 RID: 58375
		internal static int __PropertyOffset_PerSectionResolution;

		// Token: 0x0400E408 RID: 58376
		internal static int __PropertyOffset_PerComponentResolution;

		// Token: 0x0400E409 RID: 58377
		internal static int __PropertyOffset_PerTileResolution;

		// Token: 0x0400E40A RID: 58378
		internal static int __PropertyOffset_TotalResolution;

		// Token: 0x0400E40B RID: 58379
		internal static int __PropertyOffset_Bounds;
	}
}
