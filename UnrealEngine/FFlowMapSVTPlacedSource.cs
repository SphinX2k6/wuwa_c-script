using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000BE0 RID: 3040
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.FlowMapSVTPlacedSource")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 80)]
	public class FFlowMapSVTPlacedSource : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06009592 RID: 38290 RVA: 0x000D54B8 File Offset: 0x000D36B8
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FFlowMapSVTPlacedSource._ScriptStructPtr != 0) ? FFlowMapSVTPlacedSource._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.FlowMapSVTPlacedSource", ref FFlowMapSVTPlacedSource._ScriptStructPtr);
		}

		// Token: 0x170023CC RID: 9164
		// (get) Token: 0x06009593 RID: 38291 RVA: 0x000D54DC File Offset: 0x000D36DC
		// (set) Token: 0x06009594 RID: 38292 RVA: 0x000D54FB File Offset: 0x000D36FB
		public TSoftObjectPtr<UTexture2D> SourceTexture
		{
			get
			{
				return new TSoftObjectPtr<UTexture2D>(base.NativePtr + (IntPtr)FFlowMapSVTPlacedSource.__PropertyOffset_SourceTexture, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)FFlowMapSVTPlacedSource.__PropertyOffset_SourceTexture, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x170023CD RID: 9165
		// (get) Token: 0x06009595 RID: 38293 RVA: 0x000D5520 File Offset: 0x000D3720
		// (set) Token: 0x06009596 RID: 38294 RVA: 0x000D5534 File Offset: 0x000D3734
		public unsafe FIntPoint LogicalTopLeft
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FFlowMapSVTPlacedSource.__PropertyOffset_LogicalTopLeft);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FFlowMapSVTPlacedSource.__PropertyOffset_LogicalTopLeft) = value;
			}
		}

		// Token: 0x170023CE RID: 9166
		// (get) Token: 0x06009597 RID: 38295 RVA: 0x000D5549 File Offset: 0x000D3749
		// (set) Token: 0x06009598 RID: 38296 RVA: 0x000D555D File Offset: 0x000D375D
		public unsafe FIntPoint LogicalSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FFlowMapSVTPlacedSource.__PropertyOffset_LogicalSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FFlowMapSVTPlacedSource.__PropertyOffset_LogicalSize) = value;
			}
		}

		// Token: 0x170023CF RID: 9167
		// (get) Token: 0x06009599 RID: 38297 RVA: 0x000D5572 File Offset: 0x000D3772
		// (set) Token: 0x0600959A RID: 38298 RVA: 0x000D5586 File Offset: 0x000D3786
		public unsafe FIntPoint SourceResolutionHint
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FFlowMapSVTPlacedSource.__PropertyOffset_SourceResolutionHint);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FFlowMapSVTPlacedSource.__PropertyOffset_SourceResolutionHint) = value;
			}
		}

		// Token: 0x170023D0 RID: 9168
		// (get) Token: 0x0600959B RID: 38299 RVA: 0x000D559B File Offset: 0x000D379B
		// (set) Token: 0x0600959C RID: 38300 RVA: 0x000D55AB File Offset: 0x000D37AB
		public unsafe int Priority
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FFlowMapSVTPlacedSource.__PropertyOffset_Priority);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FFlowMapSVTPlacedSource.__PropertyOffset_Priority) = value;
			}
		}

		// Token: 0x170023D1 RID: 9169
		// (get) Token: 0x0600959D RID: 38301 RVA: 0x000D55BC File Offset: 0x000D37BC
		// (set) Token: 0x0600959E RID: 38302 RVA: 0x000D55CC File Offset: 0x000D37CC
		public unsafe bool bEnabled
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FFlowMapSVTPlacedSource.__PropertyOffset_bEnabled) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FFlowMapSVTPlacedSource.__PropertyOffset_bEnabled) = (value ? 1 : 0);
			}
		}

		// Token: 0x0600959F RID: 38303 RVA: 0x000D55DD File Offset: 0x000D37DD
		public FFlowMapSVTPlacedSource()
		{
		}

		// Token: 0x060095A0 RID: 38304 RVA: 0x000D55E5 File Offset: 0x000D37E5
		public FFlowMapSVTPlacedSource(TSoftObjectPtr<UTexture2D> SourceTexture, FIntPoint LogicalTopLeft, FIntPoint LogicalSize, FIntPoint SourceResolutionHint, int Priority, bool bEnabled)
		{
			this.SourceTexture = SourceTexture;
			this.LogicalTopLeft = LogicalTopLeft;
			this.LogicalSize = LogicalSize;
			this.SourceResolutionHint = SourceResolutionHint;
			this.Priority = Priority;
			this.bEnabled = bEnabled;
		}

		// Token: 0x060095A1 RID: 38305 RVA: 0x000D561A File Offset: 0x000D381A
		protected override IntPtr GetUStructPtr()
		{
			return FFlowMapSVTPlacedSource.StaticStruct();
		}

		// Token: 0x060095A2 RID: 38306 RVA: 0x000D5626 File Offset: 0x000D3826
		[NullableContext(2)]
		public FFlowMapSVTPlacedSource(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060095A3 RID: 38307 RVA: 0x000D5630 File Offset: 0x000D3830
		public FFlowMapSVTPlacedSource(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060095A4 RID: 38308 RVA: 0x000D563B File Offset: 0x000D383B
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FFlowMapSVTPlacedSource(Pointer, false, true);
		}

		// Token: 0x060095A5 RID: 38309 RVA: 0x000D5645 File Offset: 0x000D3845
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FFlowMapSVTPlacedSource(Pointer, MemoryOwner);
		}

		// Token: 0x040053E3 RID: 21475
		public const string __ObjectPath = "/Script/Engine.FlowMapSVTPlacedSource";

		// Token: 0x040053E4 RID: 21476
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040053E5 RID: 21477
		internal static int __PropertyOffset_SourceTexture;

		// Token: 0x040053E6 RID: 21478
		internal static int __PropertyOffset_LogicalTopLeft;

		// Token: 0x040053E7 RID: 21479
		internal static int __PropertyOffset_LogicalSize;

		// Token: 0x040053E8 RID: 21480
		internal static int __PropertyOffset_SourceResolutionHint;

		// Token: 0x040053E9 RID: 21481
		internal static int __PropertyOffset_Priority;

		// Token: 0x040053EA RID: 21482
		internal static int __PropertyOffset_bEnabled;
	}
}
