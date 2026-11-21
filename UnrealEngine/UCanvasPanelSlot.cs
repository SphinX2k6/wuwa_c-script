using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000855 RID: 2133
	[UnrealObjectPath("/Script/UMG.CanvasPanelSlot")]
	[UnrealStructLayout(232, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 232)]
	public class UCanvasPanelSlot : UPanelSlot, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600B9A8 RID: 47528 RVA: 0x001296C8 File Offset: 0x001278C8
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UCanvasPanelSlot._ClassPtr;
		}

		// Token: 0x0600B9A9 RID: 47529 RVA: 0x001296D4 File Offset: 0x001278D4
		public UCanvasPanelSlot() : this(BuiltinUtils.AllocNativeUObject(UCanvasPanelSlot.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600B9AA RID: 47530 RVA: 0x001296FC File Offset: 0x001278FC
		[NullableContext(1)]
		public UCanvasPanelSlot(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UCanvasPanelSlot.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002290 RID: 8848
		// (get) Token: 0x0600B9AB RID: 47531 RVA: 0x0012972F File Offset: 0x0012792F
		// (set) Token: 0x0600B9AC RID: 47532 RVA: 0x0012973F File Offset: 0x0012793F
		public unsafe bool bAutoSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UCanvasPanelSlot.__PropertyOffset_bAutoSize) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCanvasPanelSlot.__PropertyOffset_bAutoSize) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002291 RID: 8849
		// (get) Token: 0x0600B9AD RID: 47533 RVA: 0x00129750 File Offset: 0x00127950
		// (set) Token: 0x0600B9AE RID: 47534 RVA: 0x00129760 File Offset: 0x00127960
		public unsafe int ZOrder
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UCanvasPanelSlot.__PropertyOffset_ZOrder);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCanvasPanelSlot.__PropertyOffset_ZOrder) = value;
			}
		}

		// Token: 0x0600B9AF RID: 47535 RVA: 0x00129771 File Offset: 0x00127971
		public void SetZOrder(int InZOrder)
		{
			UCanvasPanelSlot.__SetZOrder_Internal(base.NativePtr, InZOrder);
		}

		// Token: 0x0600B9B0 RID: 47536 RVA: 0x0012977F File Offset: 0x0012797F
		public void SetSize(FVector2D InSize)
		{
			UCanvasPanelSlot.__SetSize_Internal(base.NativePtr, InSize);
		}

		// Token: 0x0600B9B1 RID: 47537 RVA: 0x0012978D File Offset: 0x0012798D
		public void SetPosition(FVector2D InPosition)
		{
			UCanvasPanelSlot.__SetPosition_Internal(base.NativePtr, InPosition);
		}

		// Token: 0x0600B9B2 RID: 47538 RVA: 0x0012979B File Offset: 0x0012799B
		public void SetOffsets(FMargin InOffset)
		{
			UCanvasPanelSlot.__SetOffsets_Internal(base.NativePtr, InOffset);
		}

		// Token: 0x0600B9B3 RID: 47539 RVA: 0x001297A9 File Offset: 0x001279A9
		public void SetMinimum(FVector2D InMinimumAnchors)
		{
			UCanvasPanelSlot.__SetMinimum_Internal(base.NativePtr, InMinimumAnchors);
		}

		// Token: 0x0600B9B4 RID: 47540 RVA: 0x001297B7 File Offset: 0x001279B7
		public void SetMaximum(FVector2D InMaximumAnchors)
		{
			UCanvasPanelSlot.__SetMaximum_Internal(base.NativePtr, InMaximumAnchors);
		}

		// Token: 0x0600B9B5 RID: 47541 RVA: 0x001297C5 File Offset: 0x001279C5
		public void SetAutoSize(bool InbAutoSize)
		{
			UCanvasPanelSlot.__SetAutoSize_Internal(base.NativePtr, InbAutoSize);
		}

		// Token: 0x0600B9B6 RID: 47542 RVA: 0x001297D3 File Offset: 0x001279D3
		[NullableContext(2)]
		public void SetAnchors(FAnchors InAnchors)
		{
			UCanvasPanelSlot.__SetAnchors_Internal(base.NativePtr, (InAnchors ?? new FAnchors()).NativePtr);
		}

		// Token: 0x0600B9B7 RID: 47543 RVA: 0x001297EF File Offset: 0x001279EF
		public void SetAlignment(FVector2D InAlignment)
		{
			UCanvasPanelSlot.__SetAlignment_Internal(base.NativePtr, InAlignment);
		}

		// Token: 0x0600B9B8 RID: 47544 RVA: 0x001297FD File Offset: 0x001279FD
		public int GetZOrder()
		{
			return UCanvasPanelSlot.__GetZOrder_Internal(base.NativePtr);
		}

		// Token: 0x0600B9B9 RID: 47545 RVA: 0x0012980A File Offset: 0x00127A0A
		public FVector2D GetSize()
		{
			return UCanvasPanelSlot.__GetSize_Internal(base.NativePtr);
		}

		// Token: 0x0600B9BA RID: 47546 RVA: 0x00129817 File Offset: 0x00127A17
		public FVector2D GetPosition()
		{
			return UCanvasPanelSlot.__GetPosition_Internal(base.NativePtr);
		}

		// Token: 0x0600B9BB RID: 47547 RVA: 0x00129824 File Offset: 0x00127A24
		public FMargin GetOffsets()
		{
			return UCanvasPanelSlot.__GetOffsets_Internal(base.NativePtr);
		}

		// Token: 0x0600B9BC RID: 47548 RVA: 0x00129831 File Offset: 0x00127A31
		public bool GetAutoSize()
		{
			return UCanvasPanelSlot.__GetAutoSize_Internal(base.NativePtr);
		}

		// Token: 0x0600B9BD RID: 47549 RVA: 0x0012983E File Offset: 0x00127A3E
		[NullableContext(1)]
		public FAnchors GetAnchors()
		{
			return new FAnchors(UCanvasPanelSlot.__GetAnchors_Internal(base.NativePtr), null);
		}

		// Token: 0x0600B9BE RID: 47550 RVA: 0x00129851 File Offset: 0x00127A51
		public FVector2D GetAlignment()
		{
			return UCanvasPanelSlot.__GetAlignment_Internal(base.NativePtr);
		}

		// Token: 0x0600B9BF RID: 47551
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetZOrder_Internal(IntPtr @this, int InZOrder);

		// Token: 0x0600B9C0 RID: 47552
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSize_Internal(IntPtr @this, FVector2D InSize);

		// Token: 0x0600B9C1 RID: 47553
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetPosition_Internal(IntPtr @this, FVector2D InPosition);

		// Token: 0x0600B9C2 RID: 47554
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetOffsets_Internal(IntPtr @this, FMargin InOffset);

		// Token: 0x0600B9C3 RID: 47555
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetMinimum_Internal(IntPtr @this, FVector2D InMinimumAnchors);

		// Token: 0x0600B9C4 RID: 47556
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetMaximum_Internal(IntPtr @this, FVector2D InMaximumAnchors);

		// Token: 0x0600B9C5 RID: 47557
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAutoSize_Internal(IntPtr @this, bool InbAutoSize);

		// Token: 0x0600B9C6 RID: 47558
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAnchors_Internal(IntPtr @this, IntPtr InAnchors);

		// Token: 0x0600B9C7 RID: 47559
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAlignment_Internal(IntPtr @this, FVector2D InAlignment);

		// Token: 0x0600B9C8 RID: 47560
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetZOrder_Internal(IntPtr @this);

		// Token: 0x0600B9C9 RID: 47561
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector2D __GetSize_Internal(IntPtr @this);

		// Token: 0x0600B9CA RID: 47562
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector2D __GetPosition_Internal(IntPtr @this);

		// Token: 0x0600B9CB RID: 47563
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FMargin __GetOffsets_Internal(IntPtr @this);

		// Token: 0x0600B9CC RID: 47564
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetAutoSize_Internal(IntPtr @this);

		// Token: 0x0600B9CD RID: 47565
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetAnchors_Internal(IntPtr @this);

		// Token: 0x0600B9CE RID: 47566
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector2D __GetAlignment_Internal(IntPtr @this);

		// Token: 0x0600B9CF RID: 47567 RVA: 0x0012985E File Offset: 0x00127A5E
		static UCanvasPanelSlot()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/UMG.CanvasPanelSlot");
		}

		// Token: 0x0600B9D0 RID: 47568 RVA: 0x0012986C File Offset: 0x00127A6C
		protected UCanvasPanelSlot(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400545A RID: 21594
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/UMG.CanvasPanelSlot";

		// Token: 0x0400545B RID: 21595
		private static IntPtr _ClassPtr;

		// Token: 0x0400545C RID: 21596
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400545D RID: 21597
		internal static int __PropertyOffset_bAutoSize;

		// Token: 0x0400545E RID: 21598
		internal static int __PropertyOffset_ZOrder;
	}
}
