using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000BDF RID: 3039
	[UnrealObjectPath("/Script/Engine.FlowMapSVTMip0ActiveTile")]
	[UnrealStructLayout(8, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 8)]
	public class FFlowMapSVTMip0ActiveTile : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06009588 RID: 38280 RVA: 0x000D5420 File Offset: 0x000D3620
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FFlowMapSVTMip0ActiveTile._ScriptStructPtr != 0) ? FFlowMapSVTMip0ActiveTile._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.FlowMapSVTMip0ActiveTile", ref FFlowMapSVTMip0ActiveTile._ScriptStructPtr);
		}

		// Token: 0x170023CB RID: 9163
		// (get) Token: 0x06009589 RID: 38281 RVA: 0x000D5444 File Offset: 0x000D3644
		// (set) Token: 0x0600958A RID: 38282 RVA: 0x000D5458 File Offset: 0x000D3658
		public unsafe FIntPoint TileCoordinate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FFlowMapSVTMip0ActiveTile.__PropertyOffset_TileCoordinate);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FFlowMapSVTMip0ActiveTile.__PropertyOffset_TileCoordinate) = value;
			}
		}

		// Token: 0x0600958B RID: 38283 RVA: 0x000D546D File Offset: 0x000D366D
		public FFlowMapSVTMip0ActiveTile()
		{
		}

		// Token: 0x0600958C RID: 38284 RVA: 0x000D5475 File Offset: 0x000D3675
		public FFlowMapSVTMip0ActiveTile(FIntPoint TileCoordinate)
		{
			this.TileCoordinate = TileCoordinate;
		}

		// Token: 0x0600958D RID: 38285 RVA: 0x000D5484 File Offset: 0x000D3684
		protected override IntPtr GetUStructPtr()
		{
			return FFlowMapSVTMip0ActiveTile.StaticStruct();
		}

		// Token: 0x0600958E RID: 38286 RVA: 0x000D5490 File Offset: 0x000D3690
		[NullableContext(2)]
		public FFlowMapSVTMip0ActiveTile(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600958F RID: 38287 RVA: 0x000D549A File Offset: 0x000D369A
		public FFlowMapSVTMip0ActiveTile(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06009590 RID: 38288 RVA: 0x000D54A5 File Offset: 0x000D36A5
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FFlowMapSVTMip0ActiveTile(Pointer, false, true);
		}

		// Token: 0x06009591 RID: 38289 RVA: 0x000D54AF File Offset: 0x000D36AF
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FFlowMapSVTMip0ActiveTile(Pointer, MemoryOwner);
		}

		// Token: 0x040053E0 RID: 21472
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.FlowMapSVTMip0ActiveTile";

		// Token: 0x040053E1 RID: 21473
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040053E2 RID: 21474
		internal static int __PropertyOffset_TileCoordinate;
	}
}
