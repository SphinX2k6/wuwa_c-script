using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002967 RID: 10599
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/UMG.ExpandableArea")]
	[UnrealStructLayout(1288, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1288)]
	public class UExpandableArea : UWidget, IUnrealUObject, IUnrealObject, INamedSlotInterface, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x0602735A RID: 160602 RVA: 0x003BC6E0 File Offset: 0x003BA8E0
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UExpandableArea._ClassPtr;
		}

		// Token: 0x0602735B RID: 160603 RVA: 0x003BC6EC File Offset: 0x003BA8EC
		int INamedSlotInterface.InterfaceOffset()
		{
			return UExpandableArea.__InterfaceOffset_INamedSlotInterface;
		}

		// Token: 0x0602735C RID: 160604 RVA: 0x003BC6F4 File Offset: 0x003BA8F4
		public UExpandableArea() : this(BuiltinUtils.AllocNativeUObject(UExpandableArea.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602735D RID: 160605 RVA: 0x003BC71C File Offset: 0x003BA91C
		public UExpandableArea(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UExpandableArea.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170096DE RID: 38622
		// (get) Token: 0x0602735E RID: 160606 RVA: 0x003BC750 File Offset: 0x003BA950
		// (set) Token: 0x0602735F RID: 160607 RVA: 0x003BC789 File Offset: 0x003BA989
		public FExpandableAreaStyle Style
		{
			get
			{
				base.FastCheckIsValid();
				FExpandableAreaStyle result;
				if ((result = this._Style) == null)
				{
					result = (this._Style = new FExpandableAreaStyle(base.NativePtr + (IntPtr)UExpandableArea.__PropertyOffset_Style, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpandableAreaStyle.StaticStruct(), base.NativePtr + (IntPtr)UExpandableArea.__PropertyOffset_Style, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170096DF RID: 38623
		// (get) Token: 0x06027360 RID: 160608 RVA: 0x003BC7AC File Offset: 0x003BA9AC
		// (set) Token: 0x06027361 RID: 160609 RVA: 0x003BC7E5 File Offset: 0x003BA9E5
		public FSlateBrush BorderBrush
		{
			get
			{
				base.FastCheckIsValid();
				FSlateBrush result;
				if ((result = this._BorderBrush) == null)
				{
					result = (this._BorderBrush = new FSlateBrush(base.NativePtr + (IntPtr)UExpandableArea.__PropertyOffset_BorderBrush, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSlateBrush.StaticStruct(), base.NativePtr + (IntPtr)UExpandableArea.__PropertyOffset_BorderBrush, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170096E0 RID: 38624
		// (get) Token: 0x06027362 RID: 160610 RVA: 0x003BC808 File Offset: 0x003BAA08
		// (set) Token: 0x06027363 RID: 160611 RVA: 0x003BC841 File Offset: 0x003BAA41
		public FSlateColor BorderColor
		{
			get
			{
				base.FastCheckIsValid();
				FSlateColor result;
				if ((result = this._BorderColor) == null)
				{
					result = (this._BorderColor = new FSlateColor(base.NativePtr + (IntPtr)UExpandableArea.__PropertyOffset_BorderColor, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSlateColor.StaticStruct(), base.NativePtr + (IntPtr)UExpandableArea.__PropertyOffset_BorderColor, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170096E1 RID: 38625
		// (get) Token: 0x06027364 RID: 160612 RVA: 0x003BC862 File Offset: 0x003BAA62
		// (set) Token: 0x06027365 RID: 160613 RVA: 0x003BC872 File Offset: 0x003BAA72
		public unsafe bool bIsExpanded
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UExpandableArea.__PropertyOffset_bIsExpanded) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UExpandableArea.__PropertyOffset_bIsExpanded) = (value ? 1 : 0);
			}
		}

		// Token: 0x170096E2 RID: 38626
		// (get) Token: 0x06027366 RID: 160614 RVA: 0x003BC883 File Offset: 0x003BAA83
		// (set) Token: 0x06027367 RID: 160615 RVA: 0x003BC893 File Offset: 0x003BAA93
		public unsafe float MaxHeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UExpandableArea.__PropertyOffset_MaxHeight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UExpandableArea.__PropertyOffset_MaxHeight) = value;
			}
		}

		// Token: 0x170096E3 RID: 38627
		// (get) Token: 0x06027368 RID: 160616 RVA: 0x003BC8A4 File Offset: 0x003BAAA4
		// (set) Token: 0x06027369 RID: 160617 RVA: 0x003BC8B8 File Offset: 0x003BAAB8
		public unsafe FMargin HeaderPadding
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UExpandableArea.__PropertyOffset_HeaderPadding);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UExpandableArea.__PropertyOffset_HeaderPadding) = value;
			}
		}

		// Token: 0x170096E4 RID: 38628
		// (get) Token: 0x0602736A RID: 160618 RVA: 0x003BC8CD File Offset: 0x003BAACD
		// (set) Token: 0x0602736B RID: 160619 RVA: 0x003BC8E1 File Offset: 0x003BAAE1
		public unsafe FMargin AreaPadding
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UExpandableArea.__PropertyOffset_AreaPadding);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UExpandableArea.__PropertyOffset_AreaPadding) = value;
			}
		}

		// Token: 0x170096E5 RID: 38629
		// (get) Token: 0x0602736C RID: 160620 RVA: 0x003BC8F8 File Offset: 0x003BAAF8
		// (set) Token: 0x0602736D RID: 160621 RVA: 0x003BC931 File Offset: 0x003BAB31
		public FOnExpandableAreaExpansionChanged OnExpansionChanged
		{
			get
			{
				base.FastCheckIsValid();
				FOnExpandableAreaExpansionChanged result;
				if ((result = this._OnExpansionChanged) == null)
				{
					result = (this._OnExpansionChanged = new FOnExpandableAreaExpansionChanged(base.NativePtr + (IntPtr)UExpandableArea.__PropertyOffset_OnExpansionChanged, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UExpandableArea.__PropertyOffset_OnExpansionChanged, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x170096E6 RID: 38630
		// (get) Token: 0x0602736E RID: 160622 RVA: 0x003BC952 File Offset: 0x003BAB52
		// (set) Token: 0x0602736F RID: 160623 RVA: 0x003BC966 File Offset: 0x003BAB66
		[Nullable(2)]
		public unsafe UWidget HeaderContent
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UWidget>(base.NativePtr / (IntPtr)sizeof(void*) + UExpandableArea.__PropertyOffset_HeaderContent);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UExpandableArea.__PropertyOffset_HeaderContent, value);
			}
		}

		// Token: 0x170096E7 RID: 38631
		// (get) Token: 0x06027370 RID: 160624 RVA: 0x003BC97B File Offset: 0x003BAB7B
		// (set) Token: 0x06027371 RID: 160625 RVA: 0x003BC98F File Offset: 0x003BAB8F
		[Nullable(2)]
		public unsafe UWidget BodyContent
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UWidget>(base.NativePtr / (IntPtr)sizeof(void*) + UExpandableArea.__PropertyOffset_BodyContent);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UExpandableArea.__PropertyOffset_BodyContent, value);
			}
		}

		// Token: 0x06027372 RID: 160626 RVA: 0x003BC9A4 File Offset: 0x003BABA4
		public void SetIsExpanded_Animated(bool IsExpanded)
		{
			UExpandableArea.__SetIsExpanded_Animated_Internal(base.NativePtr, IsExpanded);
		}

		// Token: 0x06027373 RID: 160627 RVA: 0x003BC9B2 File Offset: 0x003BABB2
		public void SetIsExpanded(bool IsExpanded)
		{
			UExpandableArea.__SetIsExpanded_Internal(base.NativePtr, IsExpanded);
		}

		// Token: 0x06027374 RID: 160628 RVA: 0x003BC9C0 File Offset: 0x003BABC0
		public bool GetIsExpanded()
		{
			return UExpandableArea.__GetIsExpanded_Internal(base.NativePtr);
		}

		// Token: 0x06027375 RID: 160629
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetIsExpanded_Animated_Internal(IntPtr @this, bool IsExpanded);

		// Token: 0x06027376 RID: 160630
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetIsExpanded_Internal(IntPtr @this, bool IsExpanded);

		// Token: 0x06027377 RID: 160631
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetIsExpanded_Internal(IntPtr @this);

		// Token: 0x06027378 RID: 160632 RVA: 0x003BC9CD File Offset: 0x003BABCD
		static UExpandableArea()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/UMG.ExpandableArea");
		}

		// Token: 0x06027379 RID: 160633 RVA: 0x003BC9DB File Offset: 0x003BABDB
		protected UExpandableArea(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040158D8 RID: 88280
		internal static int __InterfaceOffset_INamedSlotInterface;

		// Token: 0x040158D9 RID: 88281
		public new const string __ObjectPath = "/Script/UMG.ExpandableArea";

		// Token: 0x040158DA RID: 88282
		private static IntPtr _ClassPtr;

		// Token: 0x040158DB RID: 88283
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040158DC RID: 88284
		internal static int __PropertyOffset_Style;

		// Token: 0x040158DD RID: 88285
		[Nullable(2)]
		private FExpandableAreaStyle _Style;

		// Token: 0x040158DE RID: 88286
		internal static int __PropertyOffset_BorderBrush;

		// Token: 0x040158DF RID: 88287
		[Nullable(2)]
		private FSlateBrush _BorderBrush;

		// Token: 0x040158E0 RID: 88288
		internal static int __PropertyOffset_BorderColor;

		// Token: 0x040158E1 RID: 88289
		[Nullable(2)]
		private FSlateColor _BorderColor;

		// Token: 0x040158E2 RID: 88290
		internal static int __PropertyOffset_bIsExpanded;

		// Token: 0x040158E3 RID: 88291
		internal static int __PropertyOffset_MaxHeight;

		// Token: 0x040158E4 RID: 88292
		internal static int __PropertyOffset_HeaderPadding;

		// Token: 0x040158E5 RID: 88293
		internal static int __PropertyOffset_AreaPadding;

		// Token: 0x040158E6 RID: 88294
		internal static int __PropertyOffset_OnExpansionChanged;

		// Token: 0x040158E7 RID: 88295
		[Nullable(2)]
		private FOnExpandableAreaExpansionChanged _OnExpansionChanged;

		// Token: 0x040158E8 RID: 88296
		internal static int __PropertyOffset_HeaderContent;

		// Token: 0x040158E9 RID: 88297
		internal static int __PropertyOffset_BodyContent;
	}
}
