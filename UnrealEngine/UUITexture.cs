using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000734 RID: 1844
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.UITexture")]
	[UnrealStructLayout(2528, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2528)]
	public class UUITexture : UUITextureBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600A0AC RID: 41132 RVA: 0x000EDDEF File Offset: 0x000EBFEF
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUITexture._ClassPtr;
		}

		// Token: 0x0600A0AD RID: 41133 RVA: 0x000EDDFC File Offset: 0x000EBFFC
		public UUITexture() : this(BuiltinUtils.AllocNativeUObject(UUITexture.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600A0AE RID: 41134 RVA: 0x000EDE24 File Offset: 0x000EC024
		[NullableContext(1)]
		public UUITexture(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UUITexture.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001DE5 RID: 7653
		// (get) Token: 0x0600A0AF RID: 41135 RVA: 0x000EDE57 File Offset: 0x000EC057
		// (set) Token: 0x0600A0B0 RID: 41136 RVA: 0x000EDE67 File Offset: 0x000EC067
		public unsafe UITextureType type
		{
			get
			{
				return (UITextureType)(*(base.NativePtr + (IntPtr)UUITexture.__PropertyOffset_type));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUITexture.__PropertyOffset_type) = (byte)value;
			}
		}

		// Token: 0x17001DE6 RID: 7654
		// (get) Token: 0x0600A0B1 RID: 41137 RVA: 0x000EDE78 File Offset: 0x000EC078
		// (set) Token: 0x0600A0B2 RID: 41138 RVA: 0x000EDE8C File Offset: 0x000EC08C
		public unsafe FVector4 uvRect
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUITexture.__PropertyOffset_uvRect);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUITexture.__PropertyOffset_uvRect) = value;
			}
		}

		// Token: 0x17001DE7 RID: 7655
		// (get) Token: 0x0600A0B3 RID: 41139 RVA: 0x000EDEA1 File Offset: 0x000EC0A1
		// (set) Token: 0x0600A0B4 RID: 41140 RVA: 0x000EDEB1 File Offset: 0x000EC0B1
		public unsafe UISpriteFillMethod fillMethod
		{
			get
			{
				return (UISpriteFillMethod)(*(base.NativePtr + (IntPtr)UUITexture.__PropertyOffset_fillMethod));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUITexture.__PropertyOffset_fillMethod) = (byte)value;
			}
		}

		// Token: 0x17001DE8 RID: 7656
		// (get) Token: 0x0600A0B5 RID: 41141 RVA: 0x000EDEC2 File Offset: 0x000EC0C2
		// (set) Token: 0x0600A0B6 RID: 41142 RVA: 0x000EDED2 File Offset: 0x000EC0D2
		public unsafe byte fillOrigin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUITexture.__PropertyOffset_fillOrigin);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUITexture.__PropertyOffset_fillOrigin) = value;
			}
		}

		// Token: 0x17001DE9 RID: 7657
		// (get) Token: 0x0600A0B7 RID: 41143 RVA: 0x000EDEE3 File Offset: 0x000EC0E3
		// (set) Token: 0x0600A0B8 RID: 41144 RVA: 0x000EDEF3 File Offset: 0x000EC0F3
		public unsafe bool fillDirectionFlip
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUITexture.__PropertyOffset_fillDirectionFlip) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUITexture.__PropertyOffset_fillDirectionFlip) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001DEA RID: 7658
		// (get) Token: 0x0600A0B9 RID: 41145 RVA: 0x000EDF04 File Offset: 0x000EC104
		// (set) Token: 0x0600A0BA RID: 41146 RVA: 0x000EDF14 File Offset: 0x000EC114
		public unsafe float fillAmount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUITexture.__PropertyOffset_fillAmount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUITexture.__PropertyOffset_fillAmount) = value;
			}
		}

		// Token: 0x17001DEB RID: 7659
		// (get) Token: 0x0600A0BB RID: 41147 RVA: 0x000EDF25 File Offset: 0x000EC125
		// (set) Token: 0x0600A0BC RID: 41148 RVA: 0x000EDF35 File Offset: 0x000EC135
		public unsafe bool bTileAutoFit
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUITexture.__PropertyOffset_bTileAutoFit) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUITexture.__PropertyOffset_bTileAutoFit) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001DEC RID: 7660
		// (get) Token: 0x0600A0BD RID: 41149 RVA: 0x000EDF46 File Offset: 0x000EC146
		// (set) Token: 0x0600A0BE RID: 41150 RVA: 0x000EDF56 File Offset: 0x000EC156
		public unsafe float clampEdge
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUITexture.__PropertyOffset_clampEdge);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUITexture.__PropertyOffset_clampEdge) = value;
			}
		}

		// Token: 0x17001DED RID: 7661
		// (get) Token: 0x0600A0BF RID: 41151 RVA: 0x000EDF67 File Offset: 0x000EC167
		// (set) Token: 0x0600A0C0 RID: 41152 RVA: 0x000EDF77 File Offset: 0x000EC177
		public unsafe float tileX
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUITexture.__PropertyOffset_tileX);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUITexture.__PropertyOffset_tileX) = value;
			}
		}

		// Token: 0x17001DEE RID: 7662
		// (get) Token: 0x0600A0C1 RID: 41153 RVA: 0x000EDF88 File Offset: 0x000EC188
		// (set) Token: 0x0600A0C2 RID: 41154 RVA: 0x000EDF98 File Offset: 0x000EC198
		public unsafe float tileY
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUITexture.__PropertyOffset_tileY);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUITexture.__PropertyOffset_tileY) = value;
			}
		}

		// Token: 0x17001DEF RID: 7663
		// (get) Token: 0x0600A0C3 RID: 41155 RVA: 0x000EDFA9 File Offset: 0x000EC1A9
		// (set) Token: 0x0600A0C4 RID: 41156 RVA: 0x000EDFB9 File Offset: 0x000EC1B9
		public unsafe float offsetX
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUITexture.__PropertyOffset_offsetX);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUITexture.__PropertyOffset_offsetX) = value;
			}
		}

		// Token: 0x17001DF0 RID: 7664
		// (get) Token: 0x0600A0C5 RID: 41157 RVA: 0x000EDFCA File Offset: 0x000EC1CA
		// (set) Token: 0x0600A0C6 RID: 41158 RVA: 0x000EDFDA File Offset: 0x000EC1DA
		public unsafe float offsetY
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUITexture.__PropertyOffset_offsetY);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUITexture.__PropertyOffset_offsetY) = value;
			}
		}

		// Token: 0x17001DF1 RID: 7665
		// (get) Token: 0x0600A0C7 RID: 41159 RVA: 0x000EDFEB File Offset: 0x000EC1EB
		// (set) Token: 0x0600A0C8 RID: 41160 RVA: 0x000EDFFF File Offset: 0x000EC1FF
		public unsafe UMaterialInterface HistoryCustomMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + UUITexture.__PropertyOffset_HistoryCustomMaterial);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UUITexture.__PropertyOffset_HistoryCustomMaterial, value);
			}
		}

		// Token: 0x17001DF2 RID: 7666
		// (get) Token: 0x0600A0C9 RID: 41161 RVA: 0x000EE014 File Offset: 0x000EC214
		// (set) Token: 0x0600A0CA RID: 41162 RVA: 0x000EE024 File Offset: 0x000EC224
		public unsafe bool bIsFrameAnimate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUITexture.__PropertyOffset_bIsFrameAnimate) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUITexture.__PropertyOffset_bIsFrameAnimate) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001DF3 RID: 7667
		// (get) Token: 0x0600A0CB RID: 41163 RVA: 0x000EE035 File Offset: 0x000EC235
		// (set) Token: 0x0600A0CC RID: 41164 RVA: 0x000EE045 File Offset: 0x000EC245
		public unsafe bool bUseFrameSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUITexture.__PropertyOffset_bUseFrameSize) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUITexture.__PropertyOffset_bUseFrameSize) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001DF4 RID: 7668
		// (get) Token: 0x0600A0CD RID: 41165 RVA: 0x000EE056 File Offset: 0x000EC256
		// (set) Token: 0x0600A0CE RID: 41166 RVA: 0x000EE066 File Offset: 0x000EC266
		public unsafe int FrameAnimateRows
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUITexture.__PropertyOffset_FrameAnimateRows);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUITexture.__PropertyOffset_FrameAnimateRows) = value;
			}
		}

		// Token: 0x17001DF5 RID: 7669
		// (get) Token: 0x0600A0CF RID: 41167 RVA: 0x000EE077 File Offset: 0x000EC277
		// (set) Token: 0x0600A0D0 RID: 41168 RVA: 0x000EE087 File Offset: 0x000EC287
		public unsafe int FrameAnimateColumn
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUITexture.__PropertyOffset_FrameAnimateColumn);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUITexture.__PropertyOffset_FrameAnimateColumn) = value;
			}
		}

		// Token: 0x17001DF6 RID: 7670
		// (get) Token: 0x0600A0D1 RID: 41169 RVA: 0x000EE098 File Offset: 0x000EC298
		// (set) Token: 0x0600A0D2 RID: 41170 RVA: 0x000EE0A8 File Offset: 0x000EC2A8
		public unsafe float CurFrame
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUITexture.__PropertyOffset_CurFrame);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUITexture.__PropertyOffset_CurFrame) = value;
			}
		}

		// Token: 0x17001DF7 RID: 7671
		// (get) Token: 0x0600A0D3 RID: 41171 RVA: 0x000EE0B9 File Offset: 0x000EC2B9
		// (set) Token: 0x0600A0D4 RID: 41172 RVA: 0x000EE0CD File Offset: 0x000EC2CD
		public unsafe FVector2D FrameSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUITexture.__PropertyOffset_FrameSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUITexture.__PropertyOffset_FrameSize) = value;
			}
		}

		// Token: 0x17001DF8 RID: 7672
		// (get) Token: 0x0600A0D5 RID: 41173 RVA: 0x000EE0E2 File Offset: 0x000EC2E2
		// (set) Token: 0x0600A0D6 RID: 41174 RVA: 0x000EE0F6 File Offset: 0x000EC2F6
		public unsafe UTexture DynamicAtlasTexture
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture>(base.NativePtr / (IntPtr)sizeof(void*) + UUITexture.__PropertyOffset_DynamicAtlasTexture);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UUITexture.__PropertyOffset_DynamicAtlasTexture, value);
			}
		}

		// Token: 0x0600A0D7 RID: 41175 RVA: 0x000EE10C File Offset: 0x000EC30C
		public unsafe void SetUVRect(FVector4 newUVRect)
		{
			ref FVector4 ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			ptr = newUVRect;
			UUITexture.__SetUVRect_Internal(base.NativePtr, ptr);
		}

		// Token: 0x0600A0D8 RID: 41176 RVA: 0x000EE13C File Offset: 0x000EC33C
		public void SetTextureType(UITextureType newType)
		{
			UUITexture.__SetTextureType_Internal(base.NativePtr, newType);
		}

		// Token: 0x0600A0D9 RID: 41177 RVA: 0x000EE14A File Offset: 0x000EC34A
		public void SetFillOrigin(byte newValue)
		{
			UUITexture.__SetFillOrigin_Internal(base.NativePtr, newValue);
		}

		// Token: 0x0600A0DA RID: 41178 RVA: 0x000EE158 File Offset: 0x000EC358
		public void SetFillMethod(UISpriteFillMethod newValue)
		{
			UUITexture.__SetFillMethod_Internal(base.NativePtr, newValue);
		}

		// Token: 0x0600A0DB RID: 41179 RVA: 0x000EE166 File Offset: 0x000EC366
		public void SetFillDirectionFlip(bool newValue)
		{
			UUITexture.__SetFillDirectionFlip_Internal(base.NativePtr, newValue);
		}

		// Token: 0x0600A0DC RID: 41180 RVA: 0x000EE174 File Offset: 0x000EC374
		public void SetFillAmount(float newValue)
		{
			UUITexture.__SetFillAmount_Internal(base.NativePtr, newValue);
		}

		// Token: 0x0600A0DD RID: 41181 RVA: 0x000EE182 File Offset: 0x000EC382
		public void SetCurFrame(float newCurFrame)
		{
			UUITexture.__SetCurFrame_Internal(base.NativePtr, newCurFrame);
		}

		// Token: 0x0600A0DE RID: 41182 RVA: 0x000EE190 File Offset: 0x000EC390
		public FVector4 GetUVRect()
		{
			return UUITexture.__GetUVRect_Internal(base.NativePtr);
		}

		// Token: 0x0600A0DF RID: 41183 RVA: 0x000EE19D File Offset: 0x000EC39D
		public UITextureType GetTextureType()
		{
			return UUITexture.__GetTextureType_Internal(base.NativePtr);
		}

		// Token: 0x0600A0E0 RID: 41184 RVA: 0x000EE1AA File Offset: 0x000EC3AA
		public byte GetFillOrigin()
		{
			return UUITexture.__GetFillOrigin_Internal(base.NativePtr);
		}

		// Token: 0x0600A0E1 RID: 41185 RVA: 0x000EE1B7 File Offset: 0x000EC3B7
		public UISpriteFillMethod GetFillMethod()
		{
			return UUITexture.__GetFillMethod_Internal(base.NativePtr);
		}

		// Token: 0x0600A0E2 RID: 41186 RVA: 0x000EE1C4 File Offset: 0x000EC3C4
		public bool GetFillDirectionFlip()
		{
			return UUITexture.__GetFillDirectionFlip_Internal(base.NativePtr);
		}

		// Token: 0x0600A0E3 RID: 41187 RVA: 0x000EE1D1 File Offset: 0x000EC3D1
		public float GetFillAmount()
		{
			return UUITexture.__GetFillAmount_Internal(base.NativePtr);
		}

		// Token: 0x0600A0E4 RID: 41188
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetUVRect_Internal(IntPtr @this, in FVector4 newUVRect);

		// Token: 0x0600A0E5 RID: 41189
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetTextureType_Internal(IntPtr @this, UITextureType newType);

		// Token: 0x0600A0E6 RID: 41190
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetFillOrigin_Internal(IntPtr @this, byte newValue);

		// Token: 0x0600A0E7 RID: 41191
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetFillMethod_Internal(IntPtr @this, UISpriteFillMethod newValue);

		// Token: 0x0600A0E8 RID: 41192
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetFillDirectionFlip_Internal(IntPtr @this, bool newValue);

		// Token: 0x0600A0E9 RID: 41193
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetFillAmount_Internal(IntPtr @this, float newValue);

		// Token: 0x0600A0EA RID: 41194
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetCurFrame_Internal(IntPtr @this, float newCurFrame);

		// Token: 0x0600A0EB RID: 41195
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector4 __GetUVRect_Internal(IntPtr @this);

		// Token: 0x0600A0EC RID: 41196
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern UITextureType __GetTextureType_Internal(IntPtr @this);

		// Token: 0x0600A0ED RID: 41197
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern byte __GetFillOrigin_Internal(IntPtr @this);

		// Token: 0x0600A0EE RID: 41198
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern UISpriteFillMethod __GetFillMethod_Internal(IntPtr @this);

		// Token: 0x0600A0EF RID: 41199
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetFillDirectionFlip_Internal(IntPtr @this);

		// Token: 0x0600A0F0 RID: 41200
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetFillAmount_Internal(IntPtr @this);

		// Token: 0x0600A0F1 RID: 41201 RVA: 0x000EE1DE File Offset: 0x000EC3DE
		static UUITexture()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UITexture");
		}

		// Token: 0x0600A0F2 RID: 41202 RVA: 0x000EE1EC File Offset: 0x000EC3EC
		protected UUITexture(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040044D8 RID: 17624
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.UITexture";

		// Token: 0x040044D9 RID: 17625
		private static IntPtr _ClassPtr;

		// Token: 0x040044DA RID: 17626
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040044DB RID: 17627
		internal static int __PropertyOffset_type;

		// Token: 0x040044DC RID: 17628
		internal static int __PropertyOffset_uvRect;

		// Token: 0x040044DD RID: 17629
		internal static int __PropertyOffset_fillMethod;

		// Token: 0x040044DE RID: 17630
		internal static int __PropertyOffset_fillOrigin;

		// Token: 0x040044DF RID: 17631
		internal static int __PropertyOffset_fillDirectionFlip;

		// Token: 0x040044E0 RID: 17632
		internal static int __PropertyOffset_fillAmount;

		// Token: 0x040044E1 RID: 17633
		internal static int __PropertyOffset_bTileAutoFit;

		// Token: 0x040044E2 RID: 17634
		internal static int __PropertyOffset_clampEdge;

		// Token: 0x040044E3 RID: 17635
		internal static int __PropertyOffset_tileX;

		// Token: 0x040044E4 RID: 17636
		internal static int __PropertyOffset_tileY;

		// Token: 0x040044E5 RID: 17637
		internal static int __PropertyOffset_offsetX;

		// Token: 0x040044E6 RID: 17638
		internal static int __PropertyOffset_offsetY;

		// Token: 0x040044E7 RID: 17639
		internal static int __PropertyOffset_HistoryCustomMaterial;

		// Token: 0x040044E8 RID: 17640
		internal static int __PropertyOffset_bIsFrameAnimate;

		// Token: 0x040044E9 RID: 17641
		internal static int __PropertyOffset_bUseFrameSize;

		// Token: 0x040044EA RID: 17642
		internal static int __PropertyOffset_FrameAnimateRows;

		// Token: 0x040044EB RID: 17643
		internal static int __PropertyOffset_FrameAnimateColumn;

		// Token: 0x040044EC RID: 17644
		internal static int __PropertyOffset_CurFrame;

		// Token: 0x040044ED RID: 17645
		internal static int __PropertyOffset_FrameSize;

		// Token: 0x040044EE RID: 17646
		internal static int __PropertyOffset_DynamicAtlasTexture;
	}
}
