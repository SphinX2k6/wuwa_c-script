using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200018B RID: 395
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.BillboardComponent")]
	[UnrealStructLayout(1680, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1680)]
	public class UBillboardComponent : UPrimitiveComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060019C5 RID: 6597 RVA: 0x00026B2D File Offset: 0x00024D2D
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UBillboardComponent._ClassPtr;
		}

		// Token: 0x060019C6 RID: 6598 RVA: 0x00026B3C File Offset: 0x00024D3C
		public UBillboardComponent() : this(BuiltinUtils.AllocNativeUObject(UBillboardComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060019C7 RID: 6599 RVA: 0x00026B64 File Offset: 0x00024D64
		[NullableContext(1)]
		public UBillboardComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UBillboardComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170002F4 RID: 756
		// (get) Token: 0x060019C8 RID: 6600 RVA: 0x00026B97 File Offset: 0x00024D97
		// (set) Token: 0x060019C9 RID: 6601 RVA: 0x00026BAB File Offset: 0x00024DAB
		public unsafe UTexture2D Sprite
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + UBillboardComponent.__PropertyOffset_Sprite);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UBillboardComponent.__PropertyOffset_Sprite, value);
			}
		}

		// Token: 0x170002F5 RID: 757
		// (get) Token: 0x060019CA RID: 6602 RVA: 0x00026BC0 File Offset: 0x00024DC0
		// (set) Token: 0x060019CB RID: 6603 RVA: 0x00026BD9 File Offset: 0x00024DD9
		public unsafe bool bIsScreenSizeScaled
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UBillboardComponent.__PropertyOffset_bIsScreenSizeScaled) & UBillboardComponent.__PropertyMask_bIsScreenSizeScaled) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UBillboardComponent.__PropertyOffset_bIsScreenSizeScaled) = ((*(base.NativePtr + (IntPtr)UBillboardComponent.__PropertyOffset_bIsScreenSizeScaled) & ~UBillboardComponent.__PropertyMask_bIsScreenSizeScaled) | (value ? UBillboardComponent.__PropertyMask_bIsScreenSizeScaled : 0));
			}
		}

		// Token: 0x170002F6 RID: 758
		// (get) Token: 0x060019CC RID: 6604 RVA: 0x00026C09 File Offset: 0x00024E09
		// (set) Token: 0x060019CD RID: 6605 RVA: 0x00026C19 File Offset: 0x00024E19
		public unsafe float ScreenSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UBillboardComponent.__PropertyOffset_ScreenSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UBillboardComponent.__PropertyOffset_ScreenSize) = value;
			}
		}

		// Token: 0x170002F7 RID: 759
		// (get) Token: 0x060019CE RID: 6606 RVA: 0x00026C2A File Offset: 0x00024E2A
		// (set) Token: 0x060019CF RID: 6607 RVA: 0x00026C3A File Offset: 0x00024E3A
		public unsafe float U
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UBillboardComponent.__PropertyOffset_U);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UBillboardComponent.__PropertyOffset_U) = value;
			}
		}

		// Token: 0x170002F8 RID: 760
		// (get) Token: 0x060019D0 RID: 6608 RVA: 0x00026C4B File Offset: 0x00024E4B
		// (set) Token: 0x060019D1 RID: 6609 RVA: 0x00026C5B File Offset: 0x00024E5B
		public unsafe float UL
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UBillboardComponent.__PropertyOffset_UL);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UBillboardComponent.__PropertyOffset_UL) = value;
			}
		}

		// Token: 0x170002F9 RID: 761
		// (get) Token: 0x060019D2 RID: 6610 RVA: 0x00026C6C File Offset: 0x00024E6C
		// (set) Token: 0x060019D3 RID: 6611 RVA: 0x00026C7C File Offset: 0x00024E7C
		public unsafe float V
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UBillboardComponent.__PropertyOffset_V);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UBillboardComponent.__PropertyOffset_V) = value;
			}
		}

		// Token: 0x170002FA RID: 762
		// (get) Token: 0x060019D4 RID: 6612 RVA: 0x00026C8D File Offset: 0x00024E8D
		// (set) Token: 0x060019D5 RID: 6613 RVA: 0x00026C9D File Offset: 0x00024E9D
		public unsafe float VL
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UBillboardComponent.__PropertyOffset_VL);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UBillboardComponent.__PropertyOffset_VL) = value;
			}
		}

		// Token: 0x060019D6 RID: 6614 RVA: 0x00026CAE File Offset: 0x00024EAE
		public void SetUV(int NewU, int NewUL, int NewV, int NewVL)
		{
			UBillboardComponent.__SetUV_Internal(base.NativePtr, NewU, NewUL, NewV, NewVL);
		}

		// Token: 0x060019D7 RID: 6615 RVA: 0x00026CC0 File Offset: 0x00024EC0
		public void SetSpriteAndUV(UTexture2D NewSprite, int NewU, int NewUL, int NewV, int NewVL)
		{
			UBillboardComponent.__SetSpriteAndUV_Internal(base.NativePtr, (NewSprite != null) ? NewSprite.NativePtr : IntPtr.Zero, NewU, NewUL, NewV, NewVL);
		}

		// Token: 0x060019D8 RID: 6616 RVA: 0x00026CE3 File Offset: 0x00024EE3
		public void SetSprite(UTexture2D NewSprite)
		{
			UBillboardComponent.__SetSprite_Internal(base.NativePtr, (NewSprite != null) ? NewSprite.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060019D9 RID: 6617
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetUV_Internal(IntPtr @this, int NewU, int NewUL, int NewV, int NewVL);

		// Token: 0x060019DA RID: 6618
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSpriteAndUV_Internal(IntPtr @this, IntPtr NewSprite, int NewU, int NewUL, int NewV, int NewVL);

		// Token: 0x060019DB RID: 6619
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSprite_Internal(IntPtr @this, IntPtr NewSprite);

		// Token: 0x060019DC RID: 6620 RVA: 0x00026D00 File Offset: 0x00024F00
		static UBillboardComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.BillboardComponent");
		}

		// Token: 0x060019DD RID: 6621 RVA: 0x00026D0E File Offset: 0x00024F0E
		protected UBillboardComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400083B RID: 2107
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.BillboardComponent";

		// Token: 0x0400083C RID: 2108
		private static IntPtr _ClassPtr;

		// Token: 0x0400083D RID: 2109
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400083E RID: 2110
		internal static int __PropertyOffset_Sprite;

		// Token: 0x0400083F RID: 2111
		internal static int __PropertyOffset_bIsScreenSizeScaled;

		// Token: 0x04000840 RID: 2112
		internal static byte __PropertyMask_bIsScreenSizeScaled;

		// Token: 0x04000841 RID: 2113
		internal static int __PropertyOffset_ScreenSize;

		// Token: 0x04000842 RID: 2114
		internal static int __PropertyOffset_U;

		// Token: 0x04000843 RID: 2115
		internal static int __PropertyOffset_UL;

		// Token: 0x04000844 RID: 2116
		internal static int __PropertyOffset_V;

		// Token: 0x04000845 RID: 2117
		internal static int __PropertyOffset_VL;
	}
}
