using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200071B RID: 1819
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.UIRenderableMask")]
	[UnrealStructLayout(400, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 400)]
	public class UUIRenderableMask : ULGUIBehaviour, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06009C89 RID: 40073 RVA: 0x000E9B07 File Offset: 0x000E7D07
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUIRenderableMask._ClassPtr;
		}

		// Token: 0x06009C8A RID: 40074 RVA: 0x000E9B14 File Offset: 0x000E7D14
		public UUIRenderableMask() : this(BuiltinUtils.AllocNativeUObject(UUIRenderableMask.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06009C8B RID: 40075 RVA: 0x000E9B3C File Offset: 0x000E7D3C
		[NullableContext(1)]
		public UUIRenderableMask(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UUIRenderableMask.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001D02 RID: 7426
		// (get) Token: 0x06009C8C RID: 40076 RVA: 0x000E9B6F File Offset: 0x000E7D6F
		// (set) Token: 0x06009C8D RID: 40077 RVA: 0x000E9B83 File Offset: 0x000E7D83
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

		// Token: 0x17001D03 RID: 7427
		// (get) Token: 0x06009C8E RID: 40078 RVA: 0x000E9B98 File Offset: 0x000E7D98
		// (set) Token: 0x06009C8F RID: 40079 RVA: 0x000E9BAC File Offset: 0x000E7DAC
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

		// Token: 0x17001D04 RID: 7428
		// (get) Token: 0x06009C90 RID: 40080 RVA: 0x000E9BC1 File Offset: 0x000E7DC1
		// (set) Token: 0x06009C91 RID: 40081 RVA: 0x000E9BD5 File Offset: 0x000E7DD5
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

		// Token: 0x17001D05 RID: 7429
		// (get) Token: 0x06009C92 RID: 40082 RVA: 0x000E9BEA File Offset: 0x000E7DEA
		// (set) Token: 0x06009C93 RID: 40083 RVA: 0x000E9BFA File Offset: 0x000E7DFA
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

		// Token: 0x17001D06 RID: 7430
		// (get) Token: 0x06009C94 RID: 40084 RVA: 0x000E9C0B File Offset: 0x000E7E0B
		// (set) Token: 0x06009C95 RID: 40085 RVA: 0x000E9C1B File Offset: 0x000E7E1B
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

		// Token: 0x17001D07 RID: 7431
		// (get) Token: 0x06009C96 RID: 40086 RVA: 0x000E9C2C File Offset: 0x000E7E2C
		// (set) Token: 0x06009C97 RID: 40087 RVA: 0x000E9C3C File Offset: 0x000E7E3C
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

		// Token: 0x17001D08 RID: 7432
		// (get) Token: 0x06009C98 RID: 40088 RVA: 0x000E9C4D File Offset: 0x000E7E4D
		// (set) Token: 0x06009C99 RID: 40089 RVA: 0x000E9C5D File Offset: 0x000E7E5D
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

		// Token: 0x17001D09 RID: 7433
		// (get) Token: 0x06009C9A RID: 40090 RVA: 0x000E9C6E File Offset: 0x000E7E6E
		// (set) Token: 0x06009C9B RID: 40091 RVA: 0x000E9C7E File Offset: 0x000E7E7E
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

		// Token: 0x17001D0A RID: 7434
		// (get) Token: 0x06009C9C RID: 40092 RVA: 0x000E9C8F File Offset: 0x000E7E8F
		// (set) Token: 0x06009C9D RID: 40093 RVA: 0x000E9CA3 File Offset: 0x000E7EA3
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

		// Token: 0x17001D0B RID: 7435
		// (get) Token: 0x06009C9E RID: 40094 RVA: 0x000E9CB8 File Offset: 0x000E7EB8
		// (set) Token: 0x06009C9F RID: 40095 RVA: 0x000E9CC8 File Offset: 0x000E7EC8
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

		// Token: 0x17001D0C RID: 7436
		// (get) Token: 0x06009CA0 RID: 40096 RVA: 0x000E9CD9 File Offset: 0x000E7ED9
		// (set) Token: 0x06009CA1 RID: 40097 RVA: 0x000E9CE9 File Offset: 0x000E7EE9
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

		// Token: 0x06009CA2 RID: 40098 RVA: 0x000E9CFA File Offset: 0x000E7EFA
		public void SetClipTexture(UTexture NewClipTexture)
		{
			UUIRenderableMask.__SetClipTexture_Internal(base.NativePtr, (NewClipTexture != null) ? NewClipTexture.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06009CA3 RID: 40099 RVA: 0x000E9D17 File Offset: 0x000E7F17
		public UTexture GetClipTexture()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UTexture>(UUIRenderableMask.__GetClipTexture_Internal(base.NativePtr));
		}

		// Token: 0x06009CA4 RID: 40100
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetClipTexture_Internal(IntPtr @this, IntPtr NewClipTexture);

		// Token: 0x06009CA5 RID: 40101
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetClipTexture_Internal(IntPtr @this);

		// Token: 0x06009CA6 RID: 40102 RVA: 0x000E9D29 File Offset: 0x000E7F29
		static UUIRenderableMask()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UIRenderableMask");
		}

		// Token: 0x06009CA7 RID: 40103 RVA: 0x000E9D37 File Offset: 0x000E7F37
		protected UUIRenderableMask(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400437A RID: 17274
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.UIRenderableMask";

		// Token: 0x0400437B RID: 17275
		private static IntPtr _ClassPtr;

		// Token: 0x0400437C RID: 17276
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400437D RID: 17277
		internal static int __PropertyOffset_ClipFeatherNew;

		// Token: 0x0400437E RID: 17278
		internal static int __PropertyOffset_ClipRectOffset;

		// Token: 0x0400437F RID: 17279
		internal static int __PropertyOffset_ClipTexture;

		// Token: 0x04004380 RID: 17280
		internal static int __PropertyOffset_ClipTextureAlpha;

		// Token: 0x04004381 RID: 17281
		internal static int __PropertyOffset_bInheritRectClip;

		// Token: 0x04004382 RID: 17282
		internal static int __PropertyOffset_bInheritRectClipFull;

		// Token: 0x04004383 RID: 17283
		internal static int __PropertyOffset_bFlipClipArea;

		// Token: 0x04004384 RID: 17284
		internal static int __PropertyOffset_bEnableSliceBorder;

		// Token: 0x04004385 RID: 17285
		internal static int __PropertyOffset_SliceBorder;

		// Token: 0x04004386 RID: 17286
		internal static int __PropertyOffset_bScreenSpaceRectClip;

		// Token: 0x04004387 RID: 17287
		internal static int __PropertyOffset_bEnableRotationClip;
	}
}
