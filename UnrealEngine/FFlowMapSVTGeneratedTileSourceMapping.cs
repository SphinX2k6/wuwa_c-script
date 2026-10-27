using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000BDE RID: 3038
	[UnrealObjectPath("/Script/Engine.FlowMapSVTGeneratedTileSourceMapping")]
	[UnrealStructLayout(48, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FFlowMapSVTGeneratedTileSourceMapping : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06009572 RID: 38258 RVA: 0x000D5274 File Offset: 0x000D3474
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FFlowMapSVTGeneratedTileSourceMapping._ScriptStructPtr != 0) ? FFlowMapSVTGeneratedTileSourceMapping._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.FlowMapSVTGeneratedTileSourceMapping", ref FFlowMapSVTGeneratedTileSourceMapping._ScriptStructPtr);
		}

		// Token: 0x170023C4 RID: 9156
		// (get) Token: 0x06009573 RID: 38259 RVA: 0x000D5298 File Offset: 0x000D3498
		// (set) Token: 0x06009574 RID: 38260 RVA: 0x000D52AC File Offset: 0x000D34AC
		public unsafe FIntPoint TileCoordinate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FFlowMapSVTGeneratedTileSourceMapping.__PropertyOffset_TileCoordinate);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FFlowMapSVTGeneratedTileSourceMapping.__PropertyOffset_TileCoordinate) = value;
			}
		}

		// Token: 0x170023C5 RID: 9157
		// (get) Token: 0x06009575 RID: 38261 RVA: 0x000D52C1 File Offset: 0x000D34C1
		// (set) Token: 0x06009576 RID: 38262 RVA: 0x000D52D1 File Offset: 0x000D34D1
		public unsafe int PlacedSourceIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FFlowMapSVTGeneratedTileSourceMapping.__PropertyOffset_PlacedSourceIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FFlowMapSVTGeneratedTileSourceMapping.__PropertyOffset_PlacedSourceIndex) = value;
			}
		}

		// Token: 0x170023C6 RID: 9158
		// (get) Token: 0x06009577 RID: 38263 RVA: 0x000D52E2 File Offset: 0x000D34E2
		// (set) Token: 0x06009578 RID: 38264 RVA: 0x000D52F6 File Offset: 0x000D34F6
		public unsafe FIntPoint TileLocalPixelMin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FFlowMapSVTGeneratedTileSourceMapping.__PropertyOffset_TileLocalPixelMin);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FFlowMapSVTGeneratedTileSourceMapping.__PropertyOffset_TileLocalPixelMin) = value;
			}
		}

		// Token: 0x170023C7 RID: 9159
		// (get) Token: 0x06009579 RID: 38265 RVA: 0x000D530B File Offset: 0x000D350B
		// (set) Token: 0x0600957A RID: 38266 RVA: 0x000D531F File Offset: 0x000D351F
		public unsafe FIntPoint TileCoverageSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FFlowMapSVTGeneratedTileSourceMapping.__PropertyOffset_TileCoverageSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FFlowMapSVTGeneratedTileSourceMapping.__PropertyOffset_TileCoverageSize) = value;
			}
		}

		// Token: 0x170023C8 RID: 9160
		// (get) Token: 0x0600957B RID: 38267 RVA: 0x000D5334 File Offset: 0x000D3534
		// (set) Token: 0x0600957C RID: 38268 RVA: 0x000D5348 File Offset: 0x000D3548
		public unsafe FIntPoint SourcePixelMin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FFlowMapSVTGeneratedTileSourceMapping.__PropertyOffset_SourcePixelMin);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FFlowMapSVTGeneratedTileSourceMapping.__PropertyOffset_SourcePixelMin) = value;
			}
		}

		// Token: 0x170023C9 RID: 9161
		// (get) Token: 0x0600957D RID: 38269 RVA: 0x000D535D File Offset: 0x000D355D
		// (set) Token: 0x0600957E RID: 38270 RVA: 0x000D5371 File Offset: 0x000D3571
		public unsafe FIntPoint SourcePixelSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FFlowMapSVTGeneratedTileSourceMapping.__PropertyOffset_SourcePixelSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FFlowMapSVTGeneratedTileSourceMapping.__PropertyOffset_SourcePixelSize) = value;
			}
		}

		// Token: 0x170023CA RID: 9162
		// (get) Token: 0x0600957F RID: 38271 RVA: 0x000D5386 File Offset: 0x000D3586
		// (set) Token: 0x06009580 RID: 38272 RVA: 0x000D5396 File Offset: 0x000D3596
		public unsafe int Priority
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FFlowMapSVTGeneratedTileSourceMapping.__PropertyOffset_Priority);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FFlowMapSVTGeneratedTileSourceMapping.__PropertyOffset_Priority) = value;
			}
		}

		// Token: 0x06009581 RID: 38273 RVA: 0x000D53A7 File Offset: 0x000D35A7
		public FFlowMapSVTGeneratedTileSourceMapping()
		{
		}

		// Token: 0x06009582 RID: 38274 RVA: 0x000D53AF File Offset: 0x000D35AF
		public FFlowMapSVTGeneratedTileSourceMapping(FIntPoint TileCoordinate, int PlacedSourceIndex, FIntPoint TileLocalPixelMin, FIntPoint TileCoverageSize, FIntPoint SourcePixelMin, FIntPoint SourcePixelSize, int Priority)
		{
			this.TileCoordinate = TileCoordinate;
			this.PlacedSourceIndex = PlacedSourceIndex;
			this.TileLocalPixelMin = TileLocalPixelMin;
			this.TileCoverageSize = TileCoverageSize;
			this.SourcePixelMin = SourcePixelMin;
			this.SourcePixelSize = SourcePixelSize;
			this.Priority = Priority;
		}

		// Token: 0x06009583 RID: 38275 RVA: 0x000D53EC File Offset: 0x000D35EC
		protected override IntPtr GetUStructPtr()
		{
			return FFlowMapSVTGeneratedTileSourceMapping.StaticStruct();
		}

		// Token: 0x06009584 RID: 38276 RVA: 0x000D53F8 File Offset: 0x000D35F8
		[NullableContext(2)]
		public FFlowMapSVTGeneratedTileSourceMapping(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06009585 RID: 38277 RVA: 0x000D5402 File Offset: 0x000D3602
		public FFlowMapSVTGeneratedTileSourceMapping(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06009586 RID: 38278 RVA: 0x000D540D File Offset: 0x000D360D
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FFlowMapSVTGeneratedTileSourceMapping(Pointer, false, true);
		}

		// Token: 0x06009587 RID: 38279 RVA: 0x000D5417 File Offset: 0x000D3617
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FFlowMapSVTGeneratedTileSourceMapping(Pointer, MemoryOwner);
		}

		// Token: 0x040053D7 RID: 21463
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.FlowMapSVTGeneratedTileSourceMapping";

		// Token: 0x040053D8 RID: 21464
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040053D9 RID: 21465
		internal static int __PropertyOffset_TileCoordinate;

		// Token: 0x040053DA RID: 21466
		internal static int __PropertyOffset_PlacedSourceIndex;

		// Token: 0x040053DB RID: 21467
		internal static int __PropertyOffset_TileLocalPixelMin;

		// Token: 0x040053DC RID: 21468
		internal static int __PropertyOffset_TileCoverageSize;

		// Token: 0x040053DD RID: 21469
		internal static int __PropertyOffset_SourcePixelMin;

		// Token: 0x040053DE RID: 21470
		internal static int __PropertyOffset_SourcePixelSize;

		// Token: 0x040053DF RID: 21471
		internal static int __PropertyOffset_Priority;
	}
}
