using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200293C RID: 10556
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/UMG.Border")]
	[UnrealStructLayout(1232, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1232)]
	public class UBorder : UContentWidget, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060270B4 RID: 159924 RVA: 0x003B8C8F File Offset: 0x003B6E8F
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UBorder._ClassPtr;
		}

		// Token: 0x060270B5 RID: 159925 RVA: 0x003B8C9C File Offset: 0x003B6E9C
		public UBorder() : this(BuiltinUtils.AllocNativeUObject(UBorder.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060270B6 RID: 159926 RVA: 0x003B8CC4 File Offset: 0x003B6EC4
		public UBorder(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UBorder.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700963A RID: 38458
		// (get) Token: 0x060270B7 RID: 159927 RVA: 0x003B8CF7 File Offset: 0x003B6EF7
		// (set) Token: 0x060270B8 RID: 159928 RVA: 0x003B8D0B File Offset: 0x003B6F0B
		[Nullable(0)]
		public unsafe TEnumAsByte<EHorizontalAlignment> HorizontalAlignment
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)UBorder.__PropertyOffset_HorizontalAlignment);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)UBorder.__PropertyOffset_HorizontalAlignment) = value;
			}
		}

		// Token: 0x1700963B RID: 38459
		// (get) Token: 0x060270B9 RID: 159929 RVA: 0x003B8D20 File Offset: 0x003B6F20
		// (set) Token: 0x060270BA RID: 159930 RVA: 0x003B8D34 File Offset: 0x003B6F34
		[Nullable(0)]
		public unsafe TEnumAsByte<EVerticalAlignment> VerticalAlignment
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)UBorder.__PropertyOffset_VerticalAlignment);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)UBorder.__PropertyOffset_VerticalAlignment) = value;
			}
		}

		// Token: 0x1700963C RID: 38460
		// (get) Token: 0x060270BB RID: 159931 RVA: 0x003B8D49 File Offset: 0x003B6F49
		// (set) Token: 0x060270BC RID: 159932 RVA: 0x003B8D62 File Offset: 0x003B6F62
		public unsafe bool bShowEffectWhenDisabled
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UBorder.__PropertyOffset_bShowEffectWhenDisabled) & UBorder.__PropertyMask_bShowEffectWhenDisabled) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UBorder.__PropertyOffset_bShowEffectWhenDisabled) = ((*(base.NativePtr + (IntPtr)UBorder.__PropertyOffset_bShowEffectWhenDisabled) & ~UBorder.__PropertyMask_bShowEffectWhenDisabled) | (value ? UBorder.__PropertyMask_bShowEffectWhenDisabled : 0));
			}
		}

		// Token: 0x1700963D RID: 38461
		// (get) Token: 0x060270BD RID: 159933 RVA: 0x003B8D92 File Offset: 0x003B6F92
		// (set) Token: 0x060270BE RID: 159934 RVA: 0x003B8DA6 File Offset: 0x003B6FA6
		public unsafe FLinearColor ContentColorAndOpacity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UBorder.__PropertyOffset_ContentColorAndOpacity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UBorder.__PropertyOffset_ContentColorAndOpacity) = value;
			}
		}

		// Token: 0x1700963E RID: 38462
		// (get) Token: 0x060270BF RID: 159935 RVA: 0x003B8DBC File Offset: 0x003B6FBC
		// (set) Token: 0x060270C0 RID: 159936 RVA: 0x003B8DF5 File Offset: 0x003B6FF5
		public FGetLinearColor ContentColorAndOpacityDelegate
		{
			get
			{
				base.FastCheckIsValid();
				FGetLinearColor result;
				if ((result = this._ContentColorAndOpacityDelegate) == null)
				{
					result = (this._ContentColorAndOpacityDelegate = new FGetLinearColor(base.NativePtr + (IntPtr)UBorder.__PropertyOffset_ContentColorAndOpacityDelegate, this));
				}
				return result;
			}
			set
			{
				FScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UBorder.__PropertyOffset_ContentColorAndOpacityDelegate, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x1700963F RID: 38463
		// (get) Token: 0x060270C1 RID: 159937 RVA: 0x003B8E16 File Offset: 0x003B7016
		// (set) Token: 0x060270C2 RID: 159938 RVA: 0x003B8E2A File Offset: 0x003B702A
		public unsafe FMargin Padding
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UBorder.__PropertyOffset_Padding);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UBorder.__PropertyOffset_Padding) = value;
			}
		}

		// Token: 0x17009640 RID: 38464
		// (get) Token: 0x060270C3 RID: 159939 RVA: 0x003B8E40 File Offset: 0x003B7040
		// (set) Token: 0x060270C4 RID: 159940 RVA: 0x003B8E79 File Offset: 0x003B7079
		public FSlateBrush Background
		{
			get
			{
				base.FastCheckIsValid();
				FSlateBrush result;
				if ((result = this._Background) == null)
				{
					result = (this._Background = new FSlateBrush(base.NativePtr + (IntPtr)UBorder.__PropertyOffset_Background, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSlateBrush.StaticStruct(), base.NativePtr + (IntPtr)UBorder.__PropertyOffset_Background, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17009641 RID: 38465
		// (get) Token: 0x060270C5 RID: 159941 RVA: 0x003B8E9C File Offset: 0x003B709C
		// (set) Token: 0x060270C6 RID: 159942 RVA: 0x003B8ED5 File Offset: 0x003B70D5
		public FGetSlateBrush BackgroundDelegate
		{
			get
			{
				base.FastCheckIsValid();
				FGetSlateBrush result;
				if ((result = this._BackgroundDelegate) == null)
				{
					result = (this._BackgroundDelegate = new FGetSlateBrush(base.NativePtr + (IntPtr)UBorder.__PropertyOffset_BackgroundDelegate, this));
				}
				return result;
			}
			set
			{
				FScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UBorder.__PropertyOffset_BackgroundDelegate, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17009642 RID: 38466
		// (get) Token: 0x060270C7 RID: 159943 RVA: 0x003B8EF6 File Offset: 0x003B70F6
		// (set) Token: 0x060270C8 RID: 159944 RVA: 0x003B8F0A File Offset: 0x003B710A
		public unsafe FLinearColor BrushColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UBorder.__PropertyOffset_BrushColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UBorder.__PropertyOffset_BrushColor) = value;
			}
		}

		// Token: 0x17009643 RID: 38467
		// (get) Token: 0x060270C9 RID: 159945 RVA: 0x003B8F20 File Offset: 0x003B7120
		// (set) Token: 0x060270CA RID: 159946 RVA: 0x003B8F59 File Offset: 0x003B7159
		public FGetLinearColor BrushColorDelegate
		{
			get
			{
				base.FastCheckIsValid();
				FGetLinearColor result;
				if ((result = this._BrushColorDelegate) == null)
				{
					result = (this._BrushColorDelegate = new FGetLinearColor(base.NativePtr + (IntPtr)UBorder.__PropertyOffset_BrushColorDelegate, this));
				}
				return result;
			}
			set
			{
				FScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UBorder.__PropertyOffset_BrushColorDelegate, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17009644 RID: 38468
		// (get) Token: 0x060270CB RID: 159947 RVA: 0x003B8F7A File Offset: 0x003B717A
		// (set) Token: 0x060270CC RID: 159948 RVA: 0x003B8F8E File Offset: 0x003B718E
		public unsafe FVector2D DesiredSizeScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UBorder.__PropertyOffset_DesiredSizeScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UBorder.__PropertyOffset_DesiredSizeScale) = value;
			}
		}

		// Token: 0x17009645 RID: 38469
		// (get) Token: 0x060270CD RID: 159949 RVA: 0x003B8FA3 File Offset: 0x003B71A3
		// (set) Token: 0x060270CE RID: 159950 RVA: 0x003B8FB3 File Offset: 0x003B71B3
		public unsafe bool bFlipForRightToLeftFlowDirection
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UBorder.__PropertyOffset_bFlipForRightToLeftFlowDirection) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UBorder.__PropertyOffset_bFlipForRightToLeftFlowDirection) = (value ? 1 : 0);
			}
		}

		// Token: 0x17009646 RID: 38470
		// (get) Token: 0x060270CF RID: 159951 RVA: 0x003B8FC4 File Offset: 0x003B71C4
		// (set) Token: 0x060270D0 RID: 159952 RVA: 0x003B8FFD File Offset: 0x003B71FD
		public FOnPointerEvent OnMouseButtonDownEvent
		{
			get
			{
				base.FastCheckIsValid();
				FOnPointerEvent result;
				if ((result = this._OnMouseButtonDownEvent) == null)
				{
					result = (this._OnMouseButtonDownEvent = new FOnPointerEvent(base.NativePtr + (IntPtr)UBorder.__PropertyOffset_OnMouseButtonDownEvent, this));
				}
				return result;
			}
			set
			{
				FScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UBorder.__PropertyOffset_OnMouseButtonDownEvent, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17009647 RID: 38471
		// (get) Token: 0x060270D1 RID: 159953 RVA: 0x003B9020 File Offset: 0x003B7220
		// (set) Token: 0x060270D2 RID: 159954 RVA: 0x003B9059 File Offset: 0x003B7259
		public FOnPointerEvent OnMouseButtonUpEvent
		{
			get
			{
				base.FastCheckIsValid();
				FOnPointerEvent result;
				if ((result = this._OnMouseButtonUpEvent) == null)
				{
					result = (this._OnMouseButtonUpEvent = new FOnPointerEvent(base.NativePtr + (IntPtr)UBorder.__PropertyOffset_OnMouseButtonUpEvent, this));
				}
				return result;
			}
			set
			{
				FScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UBorder.__PropertyOffset_OnMouseButtonUpEvent, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17009648 RID: 38472
		// (get) Token: 0x060270D3 RID: 159955 RVA: 0x003B907C File Offset: 0x003B727C
		// (set) Token: 0x060270D4 RID: 159956 RVA: 0x003B90B5 File Offset: 0x003B72B5
		public FOnPointerEvent OnMouseMoveEvent
		{
			get
			{
				base.FastCheckIsValid();
				FOnPointerEvent result;
				if ((result = this._OnMouseMoveEvent) == null)
				{
					result = (this._OnMouseMoveEvent = new FOnPointerEvent(base.NativePtr + (IntPtr)UBorder.__PropertyOffset_OnMouseMoveEvent, this));
				}
				return result;
			}
			set
			{
				FScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UBorder.__PropertyOffset_OnMouseMoveEvent, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17009649 RID: 38473
		// (get) Token: 0x060270D5 RID: 159957 RVA: 0x003B90D8 File Offset: 0x003B72D8
		// (set) Token: 0x060270D6 RID: 159958 RVA: 0x003B9111 File Offset: 0x003B7311
		public FOnPointerEvent OnMouseDoubleClickEvent
		{
			get
			{
				base.FastCheckIsValid();
				FOnPointerEvent result;
				if ((result = this._OnMouseDoubleClickEvent) == null)
				{
					result = (this._OnMouseDoubleClickEvent = new FOnPointerEvent(base.NativePtr + (IntPtr)UBorder.__PropertyOffset_OnMouseDoubleClickEvent, this));
				}
				return result;
			}
			set
			{
				FScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UBorder.__PropertyOffset_OnMouseDoubleClickEvent, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x060270D7 RID: 159959 RVA: 0x003B9132 File Offset: 0x003B7332
		public void SetVerticalAlignment(EVerticalAlignment InVerticalAlignment)
		{
			UBorder.__SetVerticalAlignment_Internal(base.NativePtr, InVerticalAlignment);
		}

		// Token: 0x060270D8 RID: 159960 RVA: 0x003B9145 File Offset: 0x003B7345
		public void SetPadding(FMargin InPadding)
		{
			UBorder.__SetPadding_Internal(base.NativePtr, InPadding);
		}

		// Token: 0x060270D9 RID: 159961 RVA: 0x003B9153 File Offset: 0x003B7353
		public void SetHorizontalAlignment(EHorizontalAlignment InHorizontalAlignment)
		{
			UBorder.__SetHorizontalAlignment_Internal(base.NativePtr, InHorizontalAlignment);
		}

		// Token: 0x060270DA RID: 159962 RVA: 0x003B9166 File Offset: 0x003B7366
		public void SetDesiredSizeScale(FVector2D InScale)
		{
			UBorder.__SetDesiredSizeScale_Internal(base.NativePtr, InScale);
		}

		// Token: 0x060270DB RID: 159963 RVA: 0x003B9174 File Offset: 0x003B7374
		public void SetContentColorAndOpacity(FLinearColor InContentColorAndOpacity)
		{
			UBorder.__SetContentColorAndOpacity_Internal(base.NativePtr, InContentColorAndOpacity);
		}

		// Token: 0x060270DC RID: 159964 RVA: 0x003B9182 File Offset: 0x003B7382
		[NullableContext(2)]
		public void SetBrushFromTexture(UTexture2D Texture)
		{
			UBorder.__SetBrushFromTexture_Internal(base.NativePtr, (Texture != null) ? Texture.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060270DD RID: 159965 RVA: 0x003B919F File Offset: 0x003B739F
		[NullableContext(2)]
		public void SetBrushFromMaterial(UMaterialInterface Material)
		{
			UBorder.__SetBrushFromMaterial_Internal(base.NativePtr, (Material != null) ? Material.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060270DE RID: 159966 RVA: 0x003B91BC File Offset: 0x003B73BC
		[NullableContext(2)]
		public void SetBrushFromAsset(USlateBrushAsset Asset)
		{
			UBorder.__SetBrushFromAsset_Internal(base.NativePtr, (Asset != null) ? Asset.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060270DF RID: 159967 RVA: 0x003B91D9 File Offset: 0x003B73D9
		public void SetBrushColor(FLinearColor InBrushColor)
		{
			UBorder.__SetBrushColor_Internal(base.NativePtr, InBrushColor);
		}

		// Token: 0x060270E0 RID: 159968 RVA: 0x003B91E7 File Offset: 0x003B73E7
		[NullableContext(2)]
		public void SetBrush(in FSlateBrush InBrush)
		{
			UBorder.__SetBrush_Internal(base.NativePtr, (InBrush ?? new FSlateBrush()).NativePtr);
		}

		// Token: 0x060270E1 RID: 159969 RVA: 0x003B9204 File Offset: 0x003B7404
		[NullableContext(2)]
		public UMaterialInstanceDynamic GetDynamicMaterial()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UMaterialInstanceDynamic>(UBorder.__GetDynamicMaterial_Internal(base.NativePtr));
		}

		// Token: 0x060270E2 RID: 159970
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetVerticalAlignment_Internal(IntPtr @this, TEnumAsByte<EVerticalAlignment> InVerticalAlignment);

		// Token: 0x060270E3 RID: 159971
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetPadding_Internal(IntPtr @this, FMargin InPadding);

		// Token: 0x060270E4 RID: 159972
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetHorizontalAlignment_Internal(IntPtr @this, TEnumAsByte<EHorizontalAlignment> InHorizontalAlignment);

		// Token: 0x060270E5 RID: 159973
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetDesiredSizeScale_Internal(IntPtr @this, FVector2D InScale);

		// Token: 0x060270E6 RID: 159974
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetContentColorAndOpacity_Internal(IntPtr @this, FLinearColor InContentColorAndOpacity);

		// Token: 0x060270E7 RID: 159975
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetBrushFromTexture_Internal(IntPtr @this, IntPtr Texture);

		// Token: 0x060270E8 RID: 159976
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetBrushFromMaterial_Internal(IntPtr @this, IntPtr Material);

		// Token: 0x060270E9 RID: 159977
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetBrushFromAsset_Internal(IntPtr @this, IntPtr Asset);

		// Token: 0x060270EA RID: 159978
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetBrushColor_Internal(IntPtr @this, FLinearColor InBrushColor);

		// Token: 0x060270EB RID: 159979
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetBrush_Internal(IntPtr @this, IntPtr InBrush);

		// Token: 0x060270EC RID: 159980
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetDynamicMaterial_Internal(IntPtr @this);

		// Token: 0x060270ED RID: 159981 RVA: 0x003B9216 File Offset: 0x003B7416
		static UBorder()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/UMG.Border");
		}

		// Token: 0x060270EE RID: 159982 RVA: 0x003B9224 File Offset: 0x003B7424
		protected UBorder(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015743 RID: 87875
		public new const string __ObjectPath = "/Script/UMG.Border";

		// Token: 0x04015744 RID: 87876
		private static IntPtr _ClassPtr;

		// Token: 0x04015745 RID: 87877
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04015746 RID: 87878
		internal static int __PropertyOffset_HorizontalAlignment;

		// Token: 0x04015747 RID: 87879
		internal static int __PropertyOffset_VerticalAlignment;

		// Token: 0x04015748 RID: 87880
		internal static int __PropertyOffset_bShowEffectWhenDisabled;

		// Token: 0x04015749 RID: 87881
		internal static byte __PropertyMask_bShowEffectWhenDisabled;

		// Token: 0x0401574A RID: 87882
		internal static int __PropertyOffset_ContentColorAndOpacity;

		// Token: 0x0401574B RID: 87883
		internal static int __PropertyOffset_ContentColorAndOpacityDelegate;

		// Token: 0x0401574C RID: 87884
		[Nullable(2)]
		private FGetLinearColor _ContentColorAndOpacityDelegate;

		// Token: 0x0401574D RID: 87885
		internal static int __PropertyOffset_Padding;

		// Token: 0x0401574E RID: 87886
		internal static int __PropertyOffset_Background;

		// Token: 0x0401574F RID: 87887
		[Nullable(2)]
		private FSlateBrush _Background;

		// Token: 0x04015750 RID: 87888
		internal static int __PropertyOffset_BackgroundDelegate;

		// Token: 0x04015751 RID: 87889
		[Nullable(2)]
		private FGetSlateBrush _BackgroundDelegate;

		// Token: 0x04015752 RID: 87890
		internal static int __PropertyOffset_BrushColor;

		// Token: 0x04015753 RID: 87891
		internal static int __PropertyOffset_BrushColorDelegate;

		// Token: 0x04015754 RID: 87892
		[Nullable(2)]
		private FGetLinearColor _BrushColorDelegate;

		// Token: 0x04015755 RID: 87893
		internal static int __PropertyOffset_DesiredSizeScale;

		// Token: 0x04015756 RID: 87894
		internal static int __PropertyOffset_bFlipForRightToLeftFlowDirection;

		// Token: 0x04015757 RID: 87895
		internal static int __PropertyOffset_OnMouseButtonDownEvent;

		// Token: 0x04015758 RID: 87896
		[Nullable(2)]
		private FOnPointerEvent _OnMouseButtonDownEvent;

		// Token: 0x04015759 RID: 87897
		internal static int __PropertyOffset_OnMouseButtonUpEvent;

		// Token: 0x0401575A RID: 87898
		[Nullable(2)]
		private FOnPointerEvent _OnMouseButtonUpEvent;

		// Token: 0x0401575B RID: 87899
		internal static int __PropertyOffset_OnMouseMoveEvent;

		// Token: 0x0401575C RID: 87900
		[Nullable(2)]
		private FOnPointerEvent _OnMouseMoveEvent;

		// Token: 0x0401575D RID: 87901
		internal static int __PropertyOffset_OnMouseDoubleClickEvent;

		// Token: 0x0401575E RID: 87902
		[Nullable(2)]
		private FOnPointerEvent _OnMouseDoubleClickEvent;
	}
}
