using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000727 RID: 1831
	[UnrealObjectPath("/Script/LGUI.UISprite")]
	[UnrealStructLayout(2288, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2288)]
	public class UUISprite : UUISpriteBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06009F01 RID: 40705 RVA: 0x000EC31A File Offset: 0x000EA51A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUISprite._ClassPtr;
		}

		// Token: 0x06009F02 RID: 40706 RVA: 0x000EC328 File Offset: 0x000EA528
		public UUISprite() : this(BuiltinUtils.AllocNativeUObject(UUISprite.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06009F03 RID: 40707 RVA: 0x000EC350 File Offset: 0x000EA550
		[NullableContext(1)]
		public UUISprite(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UUISprite.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001D8A RID: 7562
		// (get) Token: 0x06009F04 RID: 40708 RVA: 0x000EC383 File Offset: 0x000EA583
		// (set) Token: 0x06009F05 RID: 40709 RVA: 0x000EC393 File Offset: 0x000EA593
		public unsafe UISpriteFillMethod fillMethod
		{
			get
			{
				return (UISpriteFillMethod)(*(base.NativePtr + (IntPtr)UUISprite.__PropertyOffset_fillMethod));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUISprite.__PropertyOffset_fillMethod) = (byte)value;
			}
		}

		// Token: 0x17001D8B RID: 7563
		// (get) Token: 0x06009F06 RID: 40710 RVA: 0x000EC3A4 File Offset: 0x000EA5A4
		// (set) Token: 0x06009F07 RID: 40711 RVA: 0x000EC3B4 File Offset: 0x000EA5B4
		public unsafe byte fillOrigin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUISprite.__PropertyOffset_fillOrigin);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUISprite.__PropertyOffset_fillOrigin) = value;
			}
		}

		// Token: 0x17001D8C RID: 7564
		// (get) Token: 0x06009F08 RID: 40712 RVA: 0x000EC3C5 File Offset: 0x000EA5C5
		// (set) Token: 0x06009F09 RID: 40713 RVA: 0x000EC3D5 File Offset: 0x000EA5D5
		public unsafe bool fillDirectionFlip
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUISprite.__PropertyOffset_fillDirectionFlip) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUISprite.__PropertyOffset_fillDirectionFlip) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001D8D RID: 7565
		// (get) Token: 0x06009F0A RID: 40714 RVA: 0x000EC3E6 File Offset: 0x000EA5E6
		// (set) Token: 0x06009F0B RID: 40715 RVA: 0x000EC3F6 File Offset: 0x000EA5F6
		public unsafe float fillAmount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUISprite.__PropertyOffset_fillAmount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUISprite.__PropertyOffset_fillAmount) = value;
			}
		}

		// Token: 0x17001D8E RID: 7566
		// (get) Token: 0x06009F0C RID: 40716 RVA: 0x000EC407 File Offset: 0x000EA607
		// (set) Token: 0x06009F0D RID: 40717 RVA: 0x000EC417 File Offset: 0x000EA617
		public unsafe bool hideHeadAtEndAndTailAtStart
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUISprite.__PropertyOffset_hideHeadAtEndAndTailAtStart) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUISprite.__PropertyOffset_hideHeadAtEndAndTailAtStart) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001D8F RID: 7567
		// (get) Token: 0x06009F0E RID: 40718 RVA: 0x000EC428 File Offset: 0x000EA628
		// (set) Token: 0x06009F0F RID: 40719 RVA: 0x000EC438 File Offset: 0x000EA638
		public unsafe bool bTileAutoFit
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUISprite.__PropertyOffset_bTileAutoFit) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUISprite.__PropertyOffset_bTileAutoFit) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001D90 RID: 7568
		// (get) Token: 0x06009F10 RID: 40720 RVA: 0x000EC449 File Offset: 0x000EA649
		// (set) Token: 0x06009F11 RID: 40721 RVA: 0x000EC459 File Offset: 0x000EA659
		public unsafe float clampEdge
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUISprite.__PropertyOffset_clampEdge);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUISprite.__PropertyOffset_clampEdge) = value;
			}
		}

		// Token: 0x17001D91 RID: 7569
		// (get) Token: 0x06009F12 RID: 40722 RVA: 0x000EC46A File Offset: 0x000EA66A
		// (set) Token: 0x06009F13 RID: 40723 RVA: 0x000EC47A File Offset: 0x000EA67A
		public unsafe float tileX
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUISprite.__PropertyOffset_tileX);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUISprite.__PropertyOffset_tileX) = value;
			}
		}

		// Token: 0x17001D92 RID: 7570
		// (get) Token: 0x06009F14 RID: 40724 RVA: 0x000EC48B File Offset: 0x000EA68B
		// (set) Token: 0x06009F15 RID: 40725 RVA: 0x000EC49B File Offset: 0x000EA69B
		public unsafe float tileY
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUISprite.__PropertyOffset_tileY);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUISprite.__PropertyOffset_tileY) = value;
			}
		}

		// Token: 0x17001D93 RID: 7571
		// (get) Token: 0x06009F16 RID: 40726 RVA: 0x000EC4AC File Offset: 0x000EA6AC
		// (set) Token: 0x06009F17 RID: 40727 RVA: 0x000EC4BC File Offset: 0x000EA6BC
		public unsafe float offsetX
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUISprite.__PropertyOffset_offsetX);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUISprite.__PropertyOffset_offsetX) = value;
			}
		}

		// Token: 0x17001D94 RID: 7572
		// (get) Token: 0x06009F18 RID: 40728 RVA: 0x000EC4CD File Offset: 0x000EA6CD
		// (set) Token: 0x06009F19 RID: 40729 RVA: 0x000EC4DD File Offset: 0x000EA6DD
		public unsafe float offsetY
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUISprite.__PropertyOffset_offsetY);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUISprite.__PropertyOffset_offsetY) = value;
			}
		}

		// Token: 0x17001D95 RID: 7573
		// (get) Token: 0x06009F1A RID: 40730 RVA: 0x000EC4EE File Offset: 0x000EA6EE
		// (set) Token: 0x06009F1B RID: 40731 RVA: 0x000EC502 File Offset: 0x000EA702
		[Nullable(2)]
		public unsafe UMaterialInterface HistoryCustomMaterial
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + UUISprite.__PropertyOffset_HistoryCustomMaterial);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UUISprite.__PropertyOffset_HistoryCustomMaterial, value);
			}
		}

		// Token: 0x06009F1C RID: 40732 RVA: 0x000EC517 File Offset: 0x000EA717
		public void SetTileY(float newValue)
		{
			UUISprite.__SetTileY_Internal(base.NativePtr, newValue);
		}

		// Token: 0x06009F1D RID: 40733 RVA: 0x000EC525 File Offset: 0x000EA725
		public void SetTileX(float newValue)
		{
			UUISprite.__SetTileX_Internal(base.NativePtr, newValue);
		}

		// Token: 0x06009F1E RID: 40734 RVA: 0x000EC533 File Offset: 0x000EA733
		public void SetTileOffset(in FLinearColor In)
		{
			UUISprite.__SetTileOffset_Internal(base.NativePtr, In);
		}

		// Token: 0x06009F1F RID: 40735 RVA: 0x000EC541 File Offset: 0x000EA741
		public void SetOffsetY(float newValue)
		{
			UUISprite.__SetOffsetY_Internal(base.NativePtr, newValue);
		}

		// Token: 0x06009F20 RID: 40736 RVA: 0x000EC54F File Offset: 0x000EA74F
		public void SetOffsetX(float newValue)
		{
			UUISprite.__SetOffsetX_Internal(base.NativePtr, newValue);
		}

		// Token: 0x06009F21 RID: 40737 RVA: 0x000EC55D File Offset: 0x000EA75D
		public void SetFillOrigin(byte newValue)
		{
			UUISprite.__SetFillOrigin_Internal(base.NativePtr, newValue);
		}

		// Token: 0x06009F22 RID: 40738 RVA: 0x000EC56B File Offset: 0x000EA76B
		public void SetFillMethod(UISpriteFillMethod newValue)
		{
			UUISprite.__SetFillMethod_Internal(base.NativePtr, newValue);
		}

		// Token: 0x06009F23 RID: 40739 RVA: 0x000EC579 File Offset: 0x000EA779
		public void SetFillDirectionFlip(bool newValue)
		{
			UUISprite.__SetFillDirectionFlip_Internal(base.NativePtr, newValue);
		}

		// Token: 0x06009F24 RID: 40740 RVA: 0x000EC587 File Offset: 0x000EA787
		public void SetFillAmount(float newValue)
		{
			UUISprite.__SetFillAmount_Internal(base.NativePtr, newValue);
		}

		// Token: 0x06009F25 RID: 40741 RVA: 0x000EC595 File Offset: 0x000EA795
		public byte GetFillOrigin()
		{
			return UUISprite.__GetFillOrigin_Internal(base.NativePtr);
		}

		// Token: 0x06009F26 RID: 40742 RVA: 0x000EC5A2 File Offset: 0x000EA7A2
		public UISpriteFillMethod GetFillMethod()
		{
			return UUISprite.__GetFillMethod_Internal(base.NativePtr);
		}

		// Token: 0x06009F27 RID: 40743 RVA: 0x000EC5AF File Offset: 0x000EA7AF
		public bool GetFillDirectionFlip()
		{
			return UUISprite.__GetFillDirectionFlip_Internal(base.NativePtr);
		}

		// Token: 0x06009F28 RID: 40744 RVA: 0x000EC5BC File Offset: 0x000EA7BC
		public float GetFillAmount()
		{
			return UUISprite.__GetFillAmount_Internal(base.NativePtr);
		}

		// Token: 0x06009F29 RID: 40745
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetTileY_Internal(IntPtr @this, float newValue);

		// Token: 0x06009F2A RID: 40746
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetTileX_Internal(IntPtr @this, float newValue);

		// Token: 0x06009F2B RID: 40747
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetTileOffset_Internal(IntPtr @this, in FLinearColor In);

		// Token: 0x06009F2C RID: 40748
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetOffsetY_Internal(IntPtr @this, float newValue);

		// Token: 0x06009F2D RID: 40749
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetOffsetX_Internal(IntPtr @this, float newValue);

		// Token: 0x06009F2E RID: 40750
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetFillOrigin_Internal(IntPtr @this, byte newValue);

		// Token: 0x06009F2F RID: 40751
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetFillMethod_Internal(IntPtr @this, UISpriteFillMethod newValue);

		// Token: 0x06009F30 RID: 40752
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetFillDirectionFlip_Internal(IntPtr @this, bool newValue);

		// Token: 0x06009F31 RID: 40753
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetFillAmount_Internal(IntPtr @this, float newValue);

		// Token: 0x06009F32 RID: 40754
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern byte __GetFillOrigin_Internal(IntPtr @this);

		// Token: 0x06009F33 RID: 40755
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern UISpriteFillMethod __GetFillMethod_Internal(IntPtr @this);

		// Token: 0x06009F34 RID: 40756
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetFillDirectionFlip_Internal(IntPtr @this);

		// Token: 0x06009F35 RID: 40757
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetFillAmount_Internal(IntPtr @this);

		// Token: 0x06009F36 RID: 40758 RVA: 0x000EC5C9 File Offset: 0x000EA7C9
		static UUISprite()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UISprite");
		}

		// Token: 0x06009F37 RID: 40759 RVA: 0x000EC5D7 File Offset: 0x000EA7D7
		protected UUISprite(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400443A RID: 17466
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.UISprite";

		// Token: 0x0400443B RID: 17467
		private static IntPtr _ClassPtr;

		// Token: 0x0400443C RID: 17468
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400443D RID: 17469
		internal static int __PropertyOffset_fillMethod;

		// Token: 0x0400443E RID: 17470
		internal static int __PropertyOffset_fillOrigin;

		// Token: 0x0400443F RID: 17471
		internal static int __PropertyOffset_fillDirectionFlip;

		// Token: 0x04004440 RID: 17472
		internal static int __PropertyOffset_fillAmount;

		// Token: 0x04004441 RID: 17473
		internal static int __PropertyOffset_hideHeadAtEndAndTailAtStart;

		// Token: 0x04004442 RID: 17474
		internal static int __PropertyOffset_bTileAutoFit;

		// Token: 0x04004443 RID: 17475
		internal static int __PropertyOffset_clampEdge;

		// Token: 0x04004444 RID: 17476
		internal static int __PropertyOffset_tileX;

		// Token: 0x04004445 RID: 17477
		internal static int __PropertyOffset_tileY;

		// Token: 0x04004446 RID: 17478
		internal static int __PropertyOffset_offsetX;

		// Token: 0x04004447 RID: 17479
		internal static int __PropertyOffset_offsetY;

		// Token: 0x04004448 RID: 17480
		internal static int __PropertyOffset_HistoryCustomMaterial;
	}
}
