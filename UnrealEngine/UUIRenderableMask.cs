using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200219C RID: 8604
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.UIRenderableMask")]
	[UnrealStructLayout(400, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 400)]
	public class UUIRenderableMask : ULGUIBehaviour, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06020A09 RID: 133641 RVA: 0x00304A37 File Offset: 0x00302C37
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUIRenderableMask._ClassPtr;
		}

		// Token: 0x06020A0A RID: 133642 RVA: 0x00304A44 File Offset: 0x00302C44
		public UUIRenderableMask() : this(BuiltinUtils.AllocNativeUObject(UUIRenderableMask.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06020A0B RID: 133643 RVA: 0x00304A6C File Offset: 0x00302C6C
		[NullableContext(1)]
		public UUIRenderableMask(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UUIRenderableMask.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007F87 RID: 32647
		// (get) Token: 0x06020A0C RID: 133644 RVA: 0x00304A9F File Offset: 0x00302C9F
		// (set) Token: 0x06020A0D RID: 133645 RVA: 0x00304AAF File Offset: 0x00302CAF
		public unsafe ELGUICanvasClipType ClipType
		{
			get
			{
				return (ELGUICanvasClipType)(*(base.NativePtr + (IntPtr)UUIRenderableMask.__PropertyOffset_ClipType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIRenderableMask.__PropertyOffset_ClipType) = (byte)value;
			}
		}

		// Token: 0x17007F88 RID: 32648
		// (get) Token: 0x06020A0E RID: 133646 RVA: 0x00304AC0 File Offset: 0x00302CC0
		// (set) Token: 0x06020A0F RID: 133647 RVA: 0x00304AD4 File Offset: 0x00302CD4
		public unsafe FMargin ClipFeatherNew
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIRenderableMask.__PropertyOffset_ClipFeatherNew);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIRenderableMask.__PropertyOffset_ClipFeatherNew) = value;
			}
		}

		// Token: 0x17007F89 RID: 32649
		// (get) Token: 0x06020A10 RID: 133648 RVA: 0x00304AE9 File Offset: 0x00302CE9
		// (set) Token: 0x06020A11 RID: 133649 RVA: 0x00304AFD File Offset: 0x00302CFD
		public unsafe FMargin ClipRectOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIRenderableMask.__PropertyOffset_ClipRectOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIRenderableMask.__PropertyOffset_ClipRectOffset) = value;
			}
		}

		// Token: 0x17007F8A RID: 32650
		// (get) Token: 0x06020A12 RID: 133650 RVA: 0x00304B12 File Offset: 0x00302D12
		// (set) Token: 0x06020A13 RID: 133651 RVA: 0x00304B26 File Offset: 0x00302D26
		public unsafe UTexture ClipTexture
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture>(base.NativePtr / (IntPtr)sizeof(void*) + UUIRenderableMask.__PropertyOffset_ClipTexture);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UUIRenderableMask.__PropertyOffset_ClipTexture, value);
			}
		}

		// Token: 0x17007F8B RID: 32651
		// (get) Token: 0x06020A14 RID: 133652 RVA: 0x00304B3B File Offset: 0x00302D3B
		// (set) Token: 0x06020A15 RID: 133653 RVA: 0x00304B4B File Offset: 0x00302D4B
		public unsafe float ClipTextureAlpha
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIRenderableMask.__PropertyOffset_ClipTextureAlpha);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIRenderableMask.__PropertyOffset_ClipTextureAlpha) = value;
			}
		}

		// Token: 0x17007F8C RID: 32652
		// (get) Token: 0x06020A16 RID: 133654 RVA: 0x00304B5C File Offset: 0x00302D5C
		// (set) Token: 0x06020A17 RID: 133655 RVA: 0x00304B6C File Offset: 0x00302D6C
		public unsafe bool bInheritRectClip
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIRenderableMask.__PropertyOffset_bInheritRectClip) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIRenderableMask.__PropertyOffset_bInheritRectClip) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007F8D RID: 32653
		// (get) Token: 0x06020A18 RID: 133656 RVA: 0x00304B7D File Offset: 0x00302D7D
		// (set) Token: 0x06020A19 RID: 133657 RVA: 0x00304B8D File Offset: 0x00302D8D
		public unsafe bool bInheritRectClipFull
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIRenderableMask.__PropertyOffset_bInheritRectClipFull) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIRenderableMask.__PropertyOffset_bInheritRectClipFull) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007F8E RID: 32654
		// (get) Token: 0x06020A1A RID: 133658 RVA: 0x00304B9E File Offset: 0x00302D9E
		// (set) Token: 0x06020A1B RID: 133659 RVA: 0x00304BAE File Offset: 0x00302DAE
		public unsafe bool bFlipClipArea
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIRenderableMask.__PropertyOffset_bFlipClipArea) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIRenderableMask.__PropertyOffset_bFlipClipArea) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007F8F RID: 32655
		// (get) Token: 0x06020A1C RID: 133660 RVA: 0x00304BBF File Offset: 0x00302DBF
		// (set) Token: 0x06020A1D RID: 133661 RVA: 0x00304BCF File Offset: 0x00302DCF
		public unsafe bool bEnableSliceBorder
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIRenderableMask.__PropertyOffset_bEnableSliceBorder) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIRenderableMask.__PropertyOffset_bEnableSliceBorder) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007F90 RID: 32656
		// (get) Token: 0x06020A1E RID: 133662 RVA: 0x00304BE0 File Offset: 0x00302DE0
		// (set) Token: 0x06020A1F RID: 133663 RVA: 0x00304BF4 File Offset: 0x00302DF4
		public unsafe FVector4 SliceBorder
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIRenderableMask.__PropertyOffset_SliceBorder);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIRenderableMask.__PropertyOffset_SliceBorder) = value;
			}
		}

		// Token: 0x17007F91 RID: 32657
		// (get) Token: 0x06020A20 RID: 133664 RVA: 0x00304C09 File Offset: 0x00302E09
		// (set) Token: 0x06020A21 RID: 133665 RVA: 0x00304C19 File Offset: 0x00302E19
		public unsafe bool bScreenSpaceRectClip
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIRenderableMask.__PropertyOffset_bScreenSpaceRectClip) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIRenderableMask.__PropertyOffset_bScreenSpaceRectClip) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007F92 RID: 32658
		// (get) Token: 0x06020A22 RID: 133666 RVA: 0x00304C2A File Offset: 0x00302E2A
		// (set) Token: 0x06020A23 RID: 133667 RVA: 0x00304C3A File Offset: 0x00302E3A
		public unsafe bool bEnableRotationClip
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIRenderableMask.__PropertyOffset_bEnableRotationClip) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIRenderableMask.__PropertyOffset_bEnableRotationClip) = (value ? 1 : 0);
			}
		}

		// Token: 0x06020A24 RID: 133668 RVA: 0x00304C4B File Offset: 0x00302E4B
		public void SetClipTexture(UTexture NewClipTexture)
		{
			UUIRenderableMask.__SetClipTexture_Internal(base.NativePtr, (NewClipTexture != null) ? NewClipTexture.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06020A25 RID: 133669 RVA: 0x00304C68 File Offset: 0x00302E68
		public ELGUICanvasClipType GetClipType()
		{
			return UUIRenderableMask.__GetClipType_Internal(base.NativePtr);
		}

		// Token: 0x06020A26 RID: 133670 RVA: 0x00304C75 File Offset: 0x00302E75
		public UTexture GetClipTexture()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UTexture>(UUIRenderableMask.__GetClipTexture_Internal(base.NativePtr));
		}

		// Token: 0x06020A27 RID: 133671
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetClipTexture_Internal(IntPtr @this, IntPtr NewClipTexture);

		// Token: 0x06020A28 RID: 133672
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern ELGUICanvasClipType __GetClipType_Internal(IntPtr @this);

		// Token: 0x06020A29 RID: 133673
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetClipTexture_Internal(IntPtr @this);

		// Token: 0x06020A2A RID: 133674 RVA: 0x00304C87 File Offset: 0x00302E87
		static UUIRenderableMask()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UIRenderableMask");
		}

		// Token: 0x06020A2B RID: 133675 RVA: 0x00304C95 File Offset: 0x00302E95
		protected UUIRenderableMask(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401175E RID: 71518
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.UIRenderableMask";

		// Token: 0x0401175F RID: 71519
		private static IntPtr _ClassPtr;

		// Token: 0x04011760 RID: 71520
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011761 RID: 71521
		internal static int __PropertyOffset_ClipType;

		// Token: 0x04011762 RID: 71522
		internal static int __PropertyOffset_ClipFeatherNew;

		// Token: 0x04011763 RID: 71523
		internal static int __PropertyOffset_ClipRectOffset;

		// Token: 0x04011764 RID: 71524
		internal static int __PropertyOffset_ClipTexture;

		// Token: 0x04011765 RID: 71525
		internal static int __PropertyOffset_ClipTextureAlpha;

		// Token: 0x04011766 RID: 71526
		internal static int __PropertyOffset_bInheritRectClip;

		// Token: 0x04011767 RID: 71527
		internal static int __PropertyOffset_bInheritRectClipFull;

		// Token: 0x04011768 RID: 71528
		internal static int __PropertyOffset_bFlipClipArea;

		// Token: 0x04011769 RID: 71529
		internal static int __PropertyOffset_bEnableSliceBorder;

		// Token: 0x0401176A RID: 71530
		internal static int __PropertyOffset_SliceBorder;

		// Token: 0x0401176B RID: 71531
		internal static int __PropertyOffset_bScreenSpaceRectClip;

		// Token: 0x0401176C RID: 71532
		internal static int __PropertyOffset_bEnableRotationClip;
	}
}
