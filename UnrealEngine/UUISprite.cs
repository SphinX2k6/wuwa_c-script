using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020021B9 RID: 8633
	[UnrealObjectPath("/Script/LGUI.UISprite")]
	[UnrealStructLayout(2288, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2288)]
	public class UUISprite : UUISpriteBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06020D96 RID: 134550 RVA: 0x003088CC File Offset: 0x00306ACC
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUISprite._ClassPtr;
		}

		// Token: 0x06020D97 RID: 134551 RVA: 0x003088D8 File Offset: 0x00306AD8
		public UUISprite() : this(BuiltinUtils.AllocNativeUObject(UUISprite.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06020D98 RID: 134552 RVA: 0x00308900 File Offset: 0x00306B00
		[NullableContext(1)]
		public UUISprite(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UUISprite.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17008052 RID: 32850
		// (get) Token: 0x06020D99 RID: 134553 RVA: 0x00308933 File Offset: 0x00306B33
		// (set) Token: 0x06020D9A RID: 134554 RVA: 0x00308943 File Offset: 0x00306B43
		public unsafe UISpriteType type
		{
			get
			{
				return (UISpriteType)(*(base.NativePtr + (IntPtr)UUISprite.__PropertyOffset_type));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUISprite.__PropertyOffset_type) = (byte)value;
			}
		}

		// Token: 0x17008053 RID: 32851
		// (get) Token: 0x06020D9B RID: 134555 RVA: 0x00308954 File Offset: 0x00306B54
		// (set) Token: 0x06020D9C RID: 134556 RVA: 0x00308964 File Offset: 0x00306B64
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

		// Token: 0x17008054 RID: 32852
		// (get) Token: 0x06020D9D RID: 134557 RVA: 0x00308975 File Offset: 0x00306B75
		// (set) Token: 0x06020D9E RID: 134558 RVA: 0x00308985 File Offset: 0x00306B85
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

		// Token: 0x17008055 RID: 32853
		// (get) Token: 0x06020D9F RID: 134559 RVA: 0x00308996 File Offset: 0x00306B96
		// (set) Token: 0x06020DA0 RID: 134560 RVA: 0x003089A6 File Offset: 0x00306BA6
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

		// Token: 0x17008056 RID: 32854
		// (get) Token: 0x06020DA1 RID: 134561 RVA: 0x003089B7 File Offset: 0x00306BB7
		// (set) Token: 0x06020DA2 RID: 134562 RVA: 0x003089C7 File Offset: 0x00306BC7
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

		// Token: 0x17008057 RID: 32855
		// (get) Token: 0x06020DA3 RID: 134563 RVA: 0x003089D8 File Offset: 0x00306BD8
		// (set) Token: 0x06020DA4 RID: 134564 RVA: 0x003089E8 File Offset: 0x00306BE8
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

		// Token: 0x17008058 RID: 32856
		// (get) Token: 0x06020DA5 RID: 134565 RVA: 0x003089F9 File Offset: 0x00306BF9
		// (set) Token: 0x06020DA6 RID: 134566 RVA: 0x00308A09 File Offset: 0x00306C09
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

		// Token: 0x17008059 RID: 32857
		// (get) Token: 0x06020DA7 RID: 134567 RVA: 0x00308A1A File Offset: 0x00306C1A
		// (set) Token: 0x06020DA8 RID: 134568 RVA: 0x00308A2A File Offset: 0x00306C2A
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

		// Token: 0x1700805A RID: 32858
		// (get) Token: 0x06020DA9 RID: 134569 RVA: 0x00308A3B File Offset: 0x00306C3B
		// (set) Token: 0x06020DAA RID: 134570 RVA: 0x00308A4B File Offset: 0x00306C4B
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

		// Token: 0x1700805B RID: 32859
		// (get) Token: 0x06020DAB RID: 134571 RVA: 0x00308A5C File Offset: 0x00306C5C
		// (set) Token: 0x06020DAC RID: 134572 RVA: 0x00308A6C File Offset: 0x00306C6C
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

		// Token: 0x1700805C RID: 32860
		// (get) Token: 0x06020DAD RID: 134573 RVA: 0x00308A7D File Offset: 0x00306C7D
		// (set) Token: 0x06020DAE RID: 134574 RVA: 0x00308A8D File Offset: 0x00306C8D
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

		// Token: 0x1700805D RID: 32861
		// (get) Token: 0x06020DAF RID: 134575 RVA: 0x00308A9E File Offset: 0x00306C9E
		// (set) Token: 0x06020DB0 RID: 134576 RVA: 0x00308AAE File Offset: 0x00306CAE
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

		// Token: 0x1700805E RID: 32862
		// (get) Token: 0x06020DB1 RID: 134577 RVA: 0x00308ABF File Offset: 0x00306CBF
		// (set) Token: 0x06020DB2 RID: 134578 RVA: 0x00308AD3 File Offset: 0x00306CD3
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

		// Token: 0x06020DB3 RID: 134579 RVA: 0x00308AE8 File Offset: 0x00306CE8
		public void SetTileY(float newValue)
		{
			UUISprite.__SetTileY_Internal(base.NativePtr, newValue);
		}

		// Token: 0x06020DB4 RID: 134580 RVA: 0x00308AF6 File Offset: 0x00306CF6
		public void SetTileX(float newValue)
		{
			UUISprite.__SetTileX_Internal(base.NativePtr, newValue);
		}

		// Token: 0x06020DB5 RID: 134581 RVA: 0x00308B04 File Offset: 0x00306D04
		public void SetTileOffset(in FLinearColor In)
		{
			UUISprite.__SetTileOffset_Internal(base.NativePtr, In);
		}

		// Token: 0x06020DB6 RID: 134582 RVA: 0x00308B12 File Offset: 0x00306D12
		public void SetSpriteType(UISpriteType newType)
		{
			UUISprite.__SetSpriteType_Internal(base.NativePtr, newType);
		}

		// Token: 0x06020DB7 RID: 134583 RVA: 0x00308B20 File Offset: 0x00306D20
		public void SetOffsetY(float newValue)
		{
			UUISprite.__SetOffsetY_Internal(base.NativePtr, newValue);
		}

		// Token: 0x06020DB8 RID: 134584 RVA: 0x00308B2E File Offset: 0x00306D2E
		public void SetOffsetX(float newValue)
		{
			UUISprite.__SetOffsetX_Internal(base.NativePtr, newValue);
		}

		// Token: 0x06020DB9 RID: 134585 RVA: 0x00308B3C File Offset: 0x00306D3C
		public void SetFillOrigin(byte newValue)
		{
			UUISprite.__SetFillOrigin_Internal(base.NativePtr, newValue);
		}

		// Token: 0x06020DBA RID: 134586 RVA: 0x00308B4A File Offset: 0x00306D4A
		public void SetFillMethod(UISpriteFillMethod newValue)
		{
			UUISprite.__SetFillMethod_Internal(base.NativePtr, newValue);
		}

		// Token: 0x06020DBB RID: 134587 RVA: 0x00308B58 File Offset: 0x00306D58
		public void SetFillDirectionFlip(bool newValue)
		{
			UUISprite.__SetFillDirectionFlip_Internal(base.NativePtr, newValue);
		}

		// Token: 0x06020DBC RID: 134588 RVA: 0x00308B66 File Offset: 0x00306D66
		public void SetFillAmount(float newValue)
		{
			UUISprite.__SetFillAmount_Internal(base.NativePtr, newValue);
		}

		// Token: 0x06020DBD RID: 134589 RVA: 0x00308B74 File Offset: 0x00306D74
		public UISpriteType GetSpriteType()
		{
			return UUISprite.__GetSpriteType_Internal(base.NativePtr);
		}

		// Token: 0x06020DBE RID: 134590 RVA: 0x00308B81 File Offset: 0x00306D81
		public byte GetFillOrigin()
		{
			return UUISprite.__GetFillOrigin_Internal(base.NativePtr);
		}

		// Token: 0x06020DBF RID: 134591 RVA: 0x00308B8E File Offset: 0x00306D8E
		public UISpriteFillMethod GetFillMethod()
		{
			return UUISprite.__GetFillMethod_Internal(base.NativePtr);
		}

		// Token: 0x06020DC0 RID: 134592 RVA: 0x00308B9B File Offset: 0x00306D9B
		public bool GetFillDirectionFlip()
		{
			return UUISprite.__GetFillDirectionFlip_Internal(base.NativePtr);
		}

		// Token: 0x06020DC1 RID: 134593 RVA: 0x00308BA8 File Offset: 0x00306DA8
		public float GetFillAmount()
		{
			return UUISprite.__GetFillAmount_Internal(base.NativePtr);
		}

		// Token: 0x06020DC2 RID: 134594
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetTileY_Internal(IntPtr @this, float newValue);

		// Token: 0x06020DC3 RID: 134595
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetTileX_Internal(IntPtr @this, float newValue);

		// Token: 0x06020DC4 RID: 134596
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetTileOffset_Internal(IntPtr @this, in FLinearColor In);

		// Token: 0x06020DC5 RID: 134597
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSpriteType_Internal(IntPtr @this, UISpriteType newType);

		// Token: 0x06020DC6 RID: 134598
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetOffsetY_Internal(IntPtr @this, float newValue);

		// Token: 0x06020DC7 RID: 134599
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetOffsetX_Internal(IntPtr @this, float newValue);

		// Token: 0x06020DC8 RID: 134600
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetFillOrigin_Internal(IntPtr @this, byte newValue);

		// Token: 0x06020DC9 RID: 134601
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetFillMethod_Internal(IntPtr @this, UISpriteFillMethod newValue);

		// Token: 0x06020DCA RID: 134602
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetFillDirectionFlip_Internal(IntPtr @this, bool newValue);

		// Token: 0x06020DCB RID: 134603
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetFillAmount_Internal(IntPtr @this, float newValue);

		// Token: 0x06020DCC RID: 134604
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern UISpriteType __GetSpriteType_Internal(IntPtr @this);

		// Token: 0x06020DCD RID: 134605
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern byte __GetFillOrigin_Internal(IntPtr @this);

		// Token: 0x06020DCE RID: 134606
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern UISpriteFillMethod __GetFillMethod_Internal(IntPtr @this);

		// Token: 0x06020DCF RID: 134607
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetFillDirectionFlip_Internal(IntPtr @this);

		// Token: 0x06020DD0 RID: 134608
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetFillAmount_Internal(IntPtr @this);

		// Token: 0x06020DD1 RID: 134609 RVA: 0x00308BB5 File Offset: 0x00306DB5
		static UUISprite()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UISprite");
		}

		// Token: 0x06020DD2 RID: 134610 RVA: 0x00308BC3 File Offset: 0x00306DC3
		protected UUISprite(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040118BE RID: 71870
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.UISprite";

		// Token: 0x040118BF RID: 71871
		private static IntPtr _ClassPtr;

		// Token: 0x040118C0 RID: 71872
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040118C1 RID: 71873
		internal static int __PropertyOffset_type;

		// Token: 0x040118C2 RID: 71874
		internal static int __PropertyOffset_fillMethod;

		// Token: 0x040118C3 RID: 71875
		internal static int __PropertyOffset_fillOrigin;

		// Token: 0x040118C4 RID: 71876
		internal static int __PropertyOffset_fillDirectionFlip;

		// Token: 0x040118C5 RID: 71877
		internal static int __PropertyOffset_fillAmount;

		// Token: 0x040118C6 RID: 71878
		internal static int __PropertyOffset_hideHeadAtEndAndTailAtStart;

		// Token: 0x040118C7 RID: 71879
		internal static int __PropertyOffset_bTileAutoFit;

		// Token: 0x040118C8 RID: 71880
		internal static int __PropertyOffset_clampEdge;

		// Token: 0x040118C9 RID: 71881
		internal static int __PropertyOffset_tileX;

		// Token: 0x040118CA RID: 71882
		internal static int __PropertyOffset_tileY;

		// Token: 0x040118CB RID: 71883
		internal static int __PropertyOffset_offsetX;

		// Token: 0x040118CC RID: 71884
		internal static int __PropertyOffset_offsetY;

		// Token: 0x040118CD RID: 71885
		internal static int __PropertyOffset_HistoryCustomMaterial;
	}
}
