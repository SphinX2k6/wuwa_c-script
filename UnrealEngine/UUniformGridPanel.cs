using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020029E8 RID: 10728
	[UnrealObjectPath("/Script/UMG.UniformGridPanel")]
	[UnrealStructLayout(720, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 720)]
	public class UUniformGridPanel : UPanelWidget, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06027BDF RID: 162783 RVA: 0x003C952B File Offset: 0x003C772B
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUniformGridPanel._ClassPtr;
		}

		// Token: 0x06027BE0 RID: 162784 RVA: 0x003C9538 File Offset: 0x003C7738
		public UUniformGridPanel() : this(BuiltinUtils.AllocNativeUObject(UUniformGridPanel.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06027BE1 RID: 162785 RVA: 0x003C9560 File Offset: 0x003C7760
		[NullableContext(1)]
		public UUniformGridPanel(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UUniformGridPanel.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17009840 RID: 38976
		// (get) Token: 0x06027BE2 RID: 162786 RVA: 0x003C9593 File Offset: 0x003C7793
		// (set) Token: 0x06027BE3 RID: 162787 RVA: 0x003C95A7 File Offset: 0x003C77A7
		public unsafe FMargin SlotPadding
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUniformGridPanel.__PropertyOffset_SlotPadding);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUniformGridPanel.__PropertyOffset_SlotPadding) = value;
			}
		}

		// Token: 0x17009841 RID: 38977
		// (get) Token: 0x06027BE4 RID: 162788 RVA: 0x003C95BC File Offset: 0x003C77BC
		// (set) Token: 0x06027BE5 RID: 162789 RVA: 0x003C95CC File Offset: 0x003C77CC
		public unsafe float MinDesiredSlotWidth
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUniformGridPanel.__PropertyOffset_MinDesiredSlotWidth);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUniformGridPanel.__PropertyOffset_MinDesiredSlotWidth) = value;
			}
		}

		// Token: 0x17009842 RID: 38978
		// (get) Token: 0x06027BE6 RID: 162790 RVA: 0x003C95DD File Offset: 0x003C77DD
		// (set) Token: 0x06027BE7 RID: 162791 RVA: 0x003C95ED File Offset: 0x003C77ED
		public unsafe float MinDesiredSlotHeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUniformGridPanel.__PropertyOffset_MinDesiredSlotHeight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUniformGridPanel.__PropertyOffset_MinDesiredSlotHeight) = value;
			}
		}

		// Token: 0x06027BE8 RID: 162792 RVA: 0x003C95FE File Offset: 0x003C77FE
		public void SetSlotPadding(FMargin InSlotPadding)
		{
			UUniformGridPanel.__SetSlotPadding_Internal(base.NativePtr, InSlotPadding);
		}

		// Token: 0x06027BE9 RID: 162793 RVA: 0x003C960C File Offset: 0x003C780C
		public void SetMinDesiredSlotWidth(float InMinDesiredSlotWidth)
		{
			UUniformGridPanel.__SetMinDesiredSlotWidth_Internal(base.NativePtr, InMinDesiredSlotWidth);
		}

		// Token: 0x06027BEA RID: 162794 RVA: 0x003C961A File Offset: 0x003C781A
		public void SetMinDesiredSlotHeight(float InMinDesiredSlotHeight)
		{
			UUniformGridPanel.__SetMinDesiredSlotHeight_Internal(base.NativePtr, InMinDesiredSlotHeight);
		}

		// Token: 0x06027BEB RID: 162795 RVA: 0x003C9628 File Offset: 0x003C7828
		[NullableContext(2)]
		public UUniformGridSlot AddChildToUniformGrid(UWidget Content, int InRow = 0, int InColumn = 0)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UUniformGridSlot>(UUniformGridPanel.__AddChildToUniformGrid_Internal(base.NativePtr, (Content != null) ? Content.NativePtr : IntPtr.Zero, InRow, InColumn));
		}

		// Token: 0x06027BEC RID: 162796
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSlotPadding_Internal(IntPtr @this, FMargin InSlotPadding);

		// Token: 0x06027BED RID: 162797
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetMinDesiredSlotWidth_Internal(IntPtr @this, float InMinDesiredSlotWidth);

		// Token: 0x06027BEE RID: 162798
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetMinDesiredSlotHeight_Internal(IntPtr @this, float InMinDesiredSlotHeight);

		// Token: 0x06027BEF RID: 162799
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __AddChildToUniformGrid_Internal(IntPtr @this, IntPtr Content, int InRow, int InColumn);

		// Token: 0x06027BF0 RID: 162800 RVA: 0x003C964C File Offset: 0x003C784C
		static UUniformGridPanel()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/UMG.UniformGridPanel");
		}

		// Token: 0x06027BF1 RID: 162801 RVA: 0x003C965A File Offset: 0x003C785A
		protected UUniformGridPanel(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015C24 RID: 89124
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/UMG.UniformGridPanel";

		// Token: 0x04015C25 RID: 89125
		private static IntPtr _ClassPtr;

		// Token: 0x04015C26 RID: 89126
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04015C27 RID: 89127
		internal static int __PropertyOffset_SlotPadding;

		// Token: 0x04015C28 RID: 89128
		internal static int __PropertyOffset_MinDesiredSlotWidth;

		// Token: 0x04015C29 RID: 89129
		internal static int __PropertyOffset_MinDesiredSlotHeight;
	}
}
