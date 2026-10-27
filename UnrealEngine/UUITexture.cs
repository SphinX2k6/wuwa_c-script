using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020021D3 RID: 8659
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.UITexture")]
	[UnrealStructLayout(2528, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2528)]
	public class UUITexture : UUITextureBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06020FC7 RID: 135111 RVA: 0x0030AD87 File Offset: 0x00308F87
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUITexture._ClassPtr;
		}

		// Token: 0x06020FC8 RID: 135112 RVA: 0x0030AD94 File Offset: 0x00308F94
		public UUITexture() : this(BuiltinUtils.AllocNativeUObject(UUITexture.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06020FC9 RID: 135113 RVA: 0x0030ADBC File Offset: 0x00308FBC
		[NullableContext(1)]
		public UUITexture(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UUITexture.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170080C6 RID: 32966
		// (get) Token: 0x06020FCA RID: 135114 RVA: 0x0030ADEF File Offset: 0x00308FEF
		// (set) Token: 0x06020FCB RID: 135115 RVA: 0x0030ADFF File Offset: 0x00308FFF
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

		// Token: 0x170080C7 RID: 32967
		// (get) Token: 0x06020FCC RID: 135116 RVA: 0x0030AE10 File Offset: 0x00309010
		// (set) Token: 0x06020FCD RID: 135117 RVA: 0x0030AE49 File Offset: 0x00309049
		[Nullable(1)]
		public FLGUISpriteInfo spriteData
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FLGUISpriteInfo result;
				if ((result = this._spriteData) == null)
				{
					result = (this._spriteData = new FLGUISpriteInfo(base.NativePtr + (IntPtr)UUITexture.__PropertyOffset_spriteData, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FLGUISpriteInfo.StaticStruct(), base.NativePtr + (IntPtr)UUITexture.__PropertyOffset_spriteData, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170080C8 RID: 32968
		// (get) Token: 0x06020FCE RID: 135118 RVA: 0x0030AE6A File Offset: 0x0030906A
		// (set) Token: 0x06020FCF RID: 135119 RVA: 0x0030AE7E File Offset: 0x0030907E
		public unsafe ULGUITextureData textureData
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ULGUITextureData>(base.NativePtr / (IntPtr)sizeof(void*) + UUITexture.__PropertyOffset_textureData);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UUITexture.__PropertyOffset_textureData, value);
			}
		}

		// Token: 0x170080C9 RID: 32969
		// (get) Token: 0x06020FD0 RID: 135120 RVA: 0x0030AE93 File Offset: 0x00309093
		// (set) Token: 0x06020FD1 RID: 135121 RVA: 0x0030AEA7 File Offset: 0x003090A7
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

		// Token: 0x170080CA RID: 32970
		// (get) Token: 0x06020FD2 RID: 135122 RVA: 0x0030AEBC File Offset: 0x003090BC
		// (set) Token: 0x06020FD3 RID: 135123 RVA: 0x0030AECC File Offset: 0x003090CC
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

		// Token: 0x170080CB RID: 32971
		// (get) Token: 0x06020FD4 RID: 135124 RVA: 0x0030AEDD File Offset: 0x003090DD
		// (set) Token: 0x06020FD5 RID: 135125 RVA: 0x0030AEED File Offset: 0x003090ED
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

		// Token: 0x170080CC RID: 32972
		// (get) Token: 0x06020FD6 RID: 135126 RVA: 0x0030AEFE File Offset: 0x003090FE
		// (set) Token: 0x06020FD7 RID: 135127 RVA: 0x0030AF0E File Offset: 0x0030910E
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

		// Token: 0x170080CD RID: 32973
		// (get) Token: 0x06020FD8 RID: 135128 RVA: 0x0030AF1F File Offset: 0x0030911F
		// (set) Token: 0x06020FD9 RID: 135129 RVA: 0x0030AF2F File Offset: 0x0030912F
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

		// Token: 0x170080CE RID: 32974
		// (get) Token: 0x06020FDA RID: 135130 RVA: 0x0030AF40 File Offset: 0x00309140
		// (set) Token: 0x06020FDB RID: 135131 RVA: 0x0030AF50 File Offset: 0x00309150
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

		// Token: 0x170080CF RID: 32975
		// (get) Token: 0x06020FDC RID: 135132 RVA: 0x0030AF61 File Offset: 0x00309161
		// (set) Token: 0x06020FDD RID: 135133 RVA: 0x0030AF71 File Offset: 0x00309171
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

		// Token: 0x170080D0 RID: 32976
		// (get) Token: 0x06020FDE RID: 135134 RVA: 0x0030AF82 File Offset: 0x00309182
		// (set) Token: 0x06020FDF RID: 135135 RVA: 0x0030AF92 File Offset: 0x00309192
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

		// Token: 0x170080D1 RID: 32977
		// (get) Token: 0x06020FE0 RID: 135136 RVA: 0x0030AFA3 File Offset: 0x003091A3
		// (set) Token: 0x06020FE1 RID: 135137 RVA: 0x0030AFB3 File Offset: 0x003091B3
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

		// Token: 0x170080D2 RID: 32978
		// (get) Token: 0x06020FE2 RID: 135138 RVA: 0x0030AFC4 File Offset: 0x003091C4
		// (set) Token: 0x06020FE3 RID: 135139 RVA: 0x0030AFD4 File Offset: 0x003091D4
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

		// Token: 0x170080D3 RID: 32979
		// (get) Token: 0x06020FE4 RID: 135140 RVA: 0x0030AFE5 File Offset: 0x003091E5
		// (set) Token: 0x06020FE5 RID: 135141 RVA: 0x0030AFF5 File Offset: 0x003091F5
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

		// Token: 0x170080D4 RID: 32980
		// (get) Token: 0x06020FE6 RID: 135142 RVA: 0x0030B006 File Offset: 0x00309206
		// (set) Token: 0x06020FE7 RID: 135143 RVA: 0x0030B01A File Offset: 0x0030921A
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

		// Token: 0x170080D5 RID: 32981
		// (get) Token: 0x06020FE8 RID: 135144 RVA: 0x0030B02F File Offset: 0x0030922F
		// (set) Token: 0x06020FE9 RID: 135145 RVA: 0x0030B03F File Offset: 0x0030923F
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

		// Token: 0x170080D6 RID: 32982
		// (get) Token: 0x06020FEA RID: 135146 RVA: 0x0030B050 File Offset: 0x00309250
		// (set) Token: 0x06020FEB RID: 135147 RVA: 0x0030B060 File Offset: 0x00309260
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

		// Token: 0x170080D7 RID: 32983
		// (get) Token: 0x06020FEC RID: 135148 RVA: 0x0030B071 File Offset: 0x00309271
		// (set) Token: 0x06020FED RID: 135149 RVA: 0x0030B081 File Offset: 0x00309281
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

		// Token: 0x170080D8 RID: 32984
		// (get) Token: 0x06020FEE RID: 135150 RVA: 0x0030B092 File Offset: 0x00309292
		// (set) Token: 0x06020FEF RID: 135151 RVA: 0x0030B0A2 File Offset: 0x003092A2
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

		// Token: 0x170080D9 RID: 32985
		// (get) Token: 0x06020FF0 RID: 135152 RVA: 0x0030B0B3 File Offset: 0x003092B3
		// (set) Token: 0x06020FF1 RID: 135153 RVA: 0x0030B0C3 File Offset: 0x003092C3
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

		// Token: 0x170080DA RID: 32986
		// (get) Token: 0x06020FF2 RID: 135154 RVA: 0x0030B0D4 File Offset: 0x003092D4
		// (set) Token: 0x06020FF3 RID: 135155 RVA: 0x0030B0E8 File Offset: 0x003092E8
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

		// Token: 0x170080DB RID: 32987
		// (get) Token: 0x06020FF4 RID: 135156 RVA: 0x0030B0FD File Offset: 0x003092FD
		// (set) Token: 0x06020FF5 RID: 135157 RVA: 0x0030B111 File Offset: 0x00309311
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

		// Token: 0x06020FF6 RID: 135158 RVA: 0x0030B128 File Offset: 0x00309328
		public unsafe void SetUVRect(FVector4 newUVRect)
		{
			ref FVector4 ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			ptr = newUVRect;
			UUITexture.__SetUVRect_Internal(base.NativePtr, ptr);
		}

		// Token: 0x06020FF7 RID: 135159 RVA: 0x0030B158 File Offset: 0x00309358
		public void SetTextureType(UITextureType newType)
		{
			UUITexture.__SetTextureType_Internal(base.NativePtr, newType);
		}

		// Token: 0x06020FF8 RID: 135160 RVA: 0x0030B166 File Offset: 0x00309366
		public void SetTextureData(ULGUITextureData NewTextureData)
		{
			UUITexture.__SetTextureData_Internal(base.NativePtr, (NewTextureData != null) ? NewTextureData.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06020FF9 RID: 135161 RVA: 0x0030B183 File Offset: 0x00309383
		public void SetSpriteData(FLGUISpriteInfo newSpriteData)
		{
			UUITexture.__SetSpriteData_Internal(base.NativePtr, (newSpriteData ?? new FLGUISpriteInfo()).NativePtr);
		}

		// Token: 0x06020FFA RID: 135162 RVA: 0x0030B19F File Offset: 0x0030939F
		public void SetFillOrigin(byte newValue)
		{
			UUITexture.__SetFillOrigin_Internal(base.NativePtr, newValue);
		}

		// Token: 0x06020FFB RID: 135163 RVA: 0x0030B1AD File Offset: 0x003093AD
		public void SetFillMethod(UISpriteFillMethod newValue)
		{
			UUITexture.__SetFillMethod_Internal(base.NativePtr, newValue);
		}

		// Token: 0x06020FFC RID: 135164 RVA: 0x0030B1BB File Offset: 0x003093BB
		public void SetFillDirectionFlip(bool newValue)
		{
			UUITexture.__SetFillDirectionFlip_Internal(base.NativePtr, newValue);
		}

		// Token: 0x06020FFD RID: 135165 RVA: 0x0030B1C9 File Offset: 0x003093C9
		public void SetFillAmount(float newValue)
		{
			UUITexture.__SetFillAmount_Internal(base.NativePtr, newValue);
		}

		// Token: 0x06020FFE RID: 135166 RVA: 0x0030B1D7 File Offset: 0x003093D7
		public void SetCurFrame(float newCurFrame)
		{
			UUITexture.__SetCurFrame_Internal(base.NativePtr, newCurFrame);
		}

		// Token: 0x06020FFF RID: 135167 RVA: 0x0030B1E5 File Offset: 0x003093E5
		public FVector4 GetUVRect()
		{
			return UUITexture.__GetUVRect_Internal(base.NativePtr);
		}

		// Token: 0x06021000 RID: 135168 RVA: 0x0030B1F2 File Offset: 0x003093F2
		public UITextureType GetTextureType()
		{
			return UUITexture.__GetTextureType_Internal(base.NativePtr);
		}

		// Token: 0x06021001 RID: 135169 RVA: 0x0030B1FF File Offset: 0x003093FF
		public ULGUITextureData GetTextureData()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ULGUITextureData>(UUITexture.__GetTextureData_Internal(base.NativePtr));
		}

		// Token: 0x06021002 RID: 135170 RVA: 0x0030B211 File Offset: 0x00309411
		[NullableContext(1)]
		public FLGUISpriteInfo GetSpriteData()
		{
			return new FLGUISpriteInfo(UUITexture.__GetSpriteData_Internal(base.NativePtr), null);
		}

		// Token: 0x06021003 RID: 135171 RVA: 0x0030B224 File Offset: 0x00309424
		public byte GetFillOrigin()
		{
			return UUITexture.__GetFillOrigin_Internal(base.NativePtr);
		}

		// Token: 0x06021004 RID: 135172 RVA: 0x0030B231 File Offset: 0x00309431
		public UISpriteFillMethod GetFillMethod()
		{
			return UUITexture.__GetFillMethod_Internal(base.NativePtr);
		}

		// Token: 0x06021005 RID: 135173 RVA: 0x0030B23E File Offset: 0x0030943E
		public bool GetFillDirectionFlip()
		{
			return UUITexture.__GetFillDirectionFlip_Internal(base.NativePtr);
		}

		// Token: 0x06021006 RID: 135174 RVA: 0x0030B24B File Offset: 0x0030944B
		public float GetFillAmount()
		{
			return UUITexture.__GetFillAmount_Internal(base.NativePtr);
		}

		// Token: 0x06021007 RID: 135175
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetUVRect_Internal(IntPtr @this, in FVector4 newUVRect);

		// Token: 0x06021008 RID: 135176
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetTextureType_Internal(IntPtr @this, UITextureType newType);

		// Token: 0x06021009 RID: 135177
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetTextureData_Internal(IntPtr @this, IntPtr NewTextureData);

		// Token: 0x0602100A RID: 135178
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSpriteData_Internal(IntPtr @this, IntPtr newSpriteData);

		// Token: 0x0602100B RID: 135179
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetFillOrigin_Internal(IntPtr @this, byte newValue);

		// Token: 0x0602100C RID: 135180
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetFillMethod_Internal(IntPtr @this, UISpriteFillMethod newValue);

		// Token: 0x0602100D RID: 135181
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetFillDirectionFlip_Internal(IntPtr @this, bool newValue);

		// Token: 0x0602100E RID: 135182
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetFillAmount_Internal(IntPtr @this, float newValue);

		// Token: 0x0602100F RID: 135183
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetCurFrame_Internal(IntPtr @this, float newCurFrame);

		// Token: 0x06021010 RID: 135184
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector4 __GetUVRect_Internal(IntPtr @this);

		// Token: 0x06021011 RID: 135185
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern UITextureType __GetTextureType_Internal(IntPtr @this);

		// Token: 0x06021012 RID: 135186
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetTextureData_Internal(IntPtr @this);

		// Token: 0x06021013 RID: 135187
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetSpriteData_Internal(IntPtr @this);

		// Token: 0x06021014 RID: 135188
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern byte __GetFillOrigin_Internal(IntPtr @this);

		// Token: 0x06021015 RID: 135189
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern UISpriteFillMethod __GetFillMethod_Internal(IntPtr @this);

		// Token: 0x06021016 RID: 135190
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetFillDirectionFlip_Internal(IntPtr @this);

		// Token: 0x06021017 RID: 135191
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetFillAmount_Internal(IntPtr @this);

		// Token: 0x06021018 RID: 135192 RVA: 0x0030B258 File Offset: 0x00309458
		static UUITexture()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UITexture");
		}

		// Token: 0x06021019 RID: 135193 RVA: 0x0030B266 File Offset: 0x00309466
		protected UUITexture(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040119BC RID: 72124
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.UITexture";

		// Token: 0x040119BD RID: 72125
		private static IntPtr _ClassPtr;

		// Token: 0x040119BE RID: 72126
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040119BF RID: 72127
		internal static int __PropertyOffset_type;

		// Token: 0x040119C0 RID: 72128
		internal static int __PropertyOffset_spriteData;

		// Token: 0x040119C1 RID: 72129
		private FLGUISpriteInfo _spriteData;

		// Token: 0x040119C2 RID: 72130
		internal static int __PropertyOffset_textureData;

		// Token: 0x040119C3 RID: 72131
		internal static int __PropertyOffset_uvRect;

		// Token: 0x040119C4 RID: 72132
		internal static int __PropertyOffset_fillMethod;

		// Token: 0x040119C5 RID: 72133
		internal static int __PropertyOffset_fillOrigin;

		// Token: 0x040119C6 RID: 72134
		internal static int __PropertyOffset_fillDirectionFlip;

		// Token: 0x040119C7 RID: 72135
		internal static int __PropertyOffset_fillAmount;

		// Token: 0x040119C8 RID: 72136
		internal static int __PropertyOffset_bTileAutoFit;

		// Token: 0x040119C9 RID: 72137
		internal static int __PropertyOffset_clampEdge;

		// Token: 0x040119CA RID: 72138
		internal static int __PropertyOffset_tileX;

		// Token: 0x040119CB RID: 72139
		internal static int __PropertyOffset_tileY;

		// Token: 0x040119CC RID: 72140
		internal static int __PropertyOffset_offsetX;

		// Token: 0x040119CD RID: 72141
		internal static int __PropertyOffset_offsetY;

		// Token: 0x040119CE RID: 72142
		internal static int __PropertyOffset_HistoryCustomMaterial;

		// Token: 0x040119CF RID: 72143
		internal static int __PropertyOffset_bIsFrameAnimate;

		// Token: 0x040119D0 RID: 72144
		internal static int __PropertyOffset_bUseFrameSize;

		// Token: 0x040119D1 RID: 72145
		internal static int __PropertyOffset_FrameAnimateRows;

		// Token: 0x040119D2 RID: 72146
		internal static int __PropertyOffset_FrameAnimateColumn;

		// Token: 0x040119D3 RID: 72147
		internal static int __PropertyOffset_CurFrame;

		// Token: 0x040119D4 RID: 72148
		internal static int __PropertyOffset_FrameSize;

		// Token: 0x040119D5 RID: 72149
		internal static int __PropertyOffset_DynamicAtlasTexture;
	}
}
