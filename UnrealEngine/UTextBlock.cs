using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000870 RID: 2160
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/UMG.TextBlock")]
	[UnrealStructLayout(1264, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1264)]
	public class UTextBlock : UTextLayoutWidget, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600BB65 RID: 47973 RVA: 0x0012C1A5 File Offset: 0x0012A3A5
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UTextBlock._ClassPtr;
		}

		// Token: 0x0600BB66 RID: 47974 RVA: 0x0012C1B4 File Offset: 0x0012A3B4
		public UTextBlock() : this(BuiltinUtils.AllocNativeUObject(UTextBlock.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600BB67 RID: 47975 RVA: 0x0012C1DC File Offset: 0x0012A3DC
		public UTextBlock(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UTextBlock.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170022B5 RID: 8885
		// (get) Token: 0x0600BB68 RID: 47976 RVA: 0x0012C210 File Offset: 0x0012A410
		// (set) Token: 0x0600BB69 RID: 47977 RVA: 0x0012C249 File Offset: 0x0012A449
		public unsafe FText Text
		{
			get
			{
				base.FastCheckIsValid();
				FText result;
				if ((result = this._Text) == null)
				{
					result = (this._Text = new FText(base.NativePtr + (IntPtr)UTextBlock.__PropertyOffset_Text, this));
				}
				return result;
			}
			set
			{
				FText.NativeCopy((void*)(base.NativePtr + (byte*)((IntPtr)UTextBlock.__PropertyOffset_Text)), value.NativePtr, 1);
			}
		}

		// Token: 0x170022B6 RID: 8886
		// (get) Token: 0x0600BB6A RID: 47978 RVA: 0x0012C264 File Offset: 0x0012A464
		// (set) Token: 0x0600BB6B RID: 47979 RVA: 0x0012C29D File Offset: 0x0012A49D
		public FGetText TextDelegate
		{
			get
			{
				base.FastCheckIsValid();
				FGetText result;
				if ((result = this._TextDelegate) == null)
				{
					result = (this._TextDelegate = new FGetText(base.NativePtr + (IntPtr)UTextBlock.__PropertyOffset_TextDelegate, this));
				}
				return result;
			}
			set
			{
				FScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UTextBlock.__PropertyOffset_TextDelegate, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x170022B7 RID: 8887
		// (get) Token: 0x0600BB6C RID: 47980 RVA: 0x0012C2C0 File Offset: 0x0012A4C0
		// (set) Token: 0x0600BB6D RID: 47981 RVA: 0x0012C2F9 File Offset: 0x0012A4F9
		public FSlateColor ColorAndOpacity
		{
			get
			{
				base.FastCheckIsValid();
				FSlateColor result;
				if ((result = this._ColorAndOpacity) == null)
				{
					result = (this._ColorAndOpacity = new FSlateColor(base.NativePtr + (IntPtr)UTextBlock.__PropertyOffset_ColorAndOpacity, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSlateColor.StaticStruct(), base.NativePtr + (IntPtr)UTextBlock.__PropertyOffset_ColorAndOpacity, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170022B8 RID: 8888
		// (get) Token: 0x0600BB6E RID: 47982 RVA: 0x0012C31C File Offset: 0x0012A51C
		// (set) Token: 0x0600BB6F RID: 47983 RVA: 0x0012C355 File Offset: 0x0012A555
		public FGetSlateColor ColorAndOpacityDelegate
		{
			get
			{
				base.FastCheckIsValid();
				FGetSlateColor result;
				if ((result = this._ColorAndOpacityDelegate) == null)
				{
					result = (this._ColorAndOpacityDelegate = new FGetSlateColor(base.NativePtr + (IntPtr)UTextBlock.__PropertyOffset_ColorAndOpacityDelegate, this));
				}
				return result;
			}
			set
			{
				FScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UTextBlock.__PropertyOffset_ColorAndOpacityDelegate, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x170022B9 RID: 8889
		// (get) Token: 0x0600BB70 RID: 47984 RVA: 0x0012C378 File Offset: 0x0012A578
		// (set) Token: 0x0600BB71 RID: 47985 RVA: 0x0012C3B1 File Offset: 0x0012A5B1
		public FSlateFontInfo Font
		{
			get
			{
				base.FastCheckIsValid();
				FSlateFontInfo result;
				if ((result = this._Font) == null)
				{
					result = (this._Font = new FSlateFontInfo(base.NativePtr + (IntPtr)UTextBlock.__PropertyOffset_Font, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSlateFontInfo.StaticStruct(), base.NativePtr + (IntPtr)UTextBlock.__PropertyOffset_Font, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170022BA RID: 8890
		// (get) Token: 0x0600BB72 RID: 47986 RVA: 0x0012C3D2 File Offset: 0x0012A5D2
		// (set) Token: 0x0600BB73 RID: 47987 RVA: 0x0012C3E6 File Offset: 0x0012A5E6
		public unsafe FVector2D ShadowOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTextBlock.__PropertyOffset_ShadowOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTextBlock.__PropertyOffset_ShadowOffset) = value;
			}
		}

		// Token: 0x170022BB RID: 8891
		// (get) Token: 0x0600BB74 RID: 47988 RVA: 0x0012C3FB File Offset: 0x0012A5FB
		// (set) Token: 0x0600BB75 RID: 47989 RVA: 0x0012C40F File Offset: 0x0012A60F
		public unsafe FLinearColor ShadowColorAndOpacity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTextBlock.__PropertyOffset_ShadowColorAndOpacity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTextBlock.__PropertyOffset_ShadowColorAndOpacity) = value;
			}
		}

		// Token: 0x170022BC RID: 8892
		// (get) Token: 0x0600BB76 RID: 47990 RVA: 0x0012C424 File Offset: 0x0012A624
		// (set) Token: 0x0600BB77 RID: 47991 RVA: 0x0012C45D File Offset: 0x0012A65D
		public FGetLinearColor ShadowColorAndOpacityDelegate
		{
			get
			{
				base.FastCheckIsValid();
				FGetLinearColor result;
				if ((result = this._ShadowColorAndOpacityDelegate) == null)
				{
					result = (this._ShadowColorAndOpacityDelegate = new FGetLinearColor(base.NativePtr + (IntPtr)UTextBlock.__PropertyOffset_ShadowColorAndOpacityDelegate, this));
				}
				return result;
			}
			set
			{
				FScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UTextBlock.__PropertyOffset_ShadowColorAndOpacityDelegate, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x170022BD RID: 8893
		// (get) Token: 0x0600BB78 RID: 47992 RVA: 0x0012C47E File Offset: 0x0012A67E
		// (set) Token: 0x0600BB79 RID: 47993 RVA: 0x0012C48E File Offset: 0x0012A68E
		public unsafe float MinDesiredWidth
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTextBlock.__PropertyOffset_MinDesiredWidth);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTextBlock.__PropertyOffset_MinDesiredWidth) = value;
			}
		}

		// Token: 0x170022BE RID: 8894
		// (get) Token: 0x0600BB7A RID: 47994 RVA: 0x0012C49F File Offset: 0x0012A69F
		// (set) Token: 0x0600BB7B RID: 47995 RVA: 0x0012C4AF File Offset: 0x0012A6AF
		public unsafe bool bWrapWithInvalidationPanel
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTextBlock.__PropertyOffset_bWrapWithInvalidationPanel) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTextBlock.__PropertyOffset_bWrapWithInvalidationPanel) = (value ? 1 : 0);
			}
		}

		// Token: 0x170022BF RID: 8895
		// (get) Token: 0x0600BB7C RID: 47996 RVA: 0x0012C4C0 File Offset: 0x0012A6C0
		// (set) Token: 0x0600BB7D RID: 47997 RVA: 0x0012C4D0 File Offset: 0x0012A6D0
		public unsafe bool bAutoWrapText_DEPRECATED
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTextBlock.__PropertyOffset_bAutoWrapText_DEPRECATED) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTextBlock.__PropertyOffset_bAutoWrapText_DEPRECATED) = (value ? 1 : 0);
			}
		}

		// Token: 0x170022C0 RID: 8896
		// (get) Token: 0x0600BB7E RID: 47998 RVA: 0x0012C4E1 File Offset: 0x0012A6E1
		// (set) Token: 0x0600BB7F RID: 47999 RVA: 0x0012C4F1 File Offset: 0x0012A6F1
		public unsafe bool bSimpleTextMode
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTextBlock.__PropertyOffset_bSimpleTextMode) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTextBlock.__PropertyOffset_bSimpleTextMode) = (value ? 1 : 0);
			}
		}

		// Token: 0x0600BB80 RID: 48000 RVA: 0x0012C502 File Offset: 0x0012A702
		public void SetText(FText InText)
		{
			UTextBlock.__SetText_Internal(base.NativePtr, (InText != null) ? InText.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600BB81 RID: 48001 RVA: 0x0012C51F File Offset: 0x0012A71F
		public void SetShadowOffset(FVector2D InShadowOffset)
		{
			UTextBlock.__SetShadowOffset_Internal(base.NativePtr, InShadowOffset);
		}

		// Token: 0x0600BB82 RID: 48002 RVA: 0x0012C52D File Offset: 0x0012A72D
		public void SetShadowColorAndOpacity(FLinearColor InShadowColorAndOpacity)
		{
			UTextBlock.__SetShadowColorAndOpacity_Internal(base.NativePtr, InShadowColorAndOpacity);
		}

		// Token: 0x0600BB83 RID: 48003 RVA: 0x0012C53B File Offset: 0x0012A73B
		public void SetOpacity(float InOpacity)
		{
			UTextBlock.__SetOpacity_Internal(base.NativePtr, InOpacity);
		}

		// Token: 0x0600BB84 RID: 48004 RVA: 0x0012C549 File Offset: 0x0012A749
		public void SetMinDesiredWidth(float InMinDesiredWidth)
		{
			UTextBlock.__SetMinDesiredWidth_Internal(base.NativePtr, InMinDesiredWidth);
		}

		// Token: 0x0600BB85 RID: 48005 RVA: 0x0012C557 File Offset: 0x0012A757
		[NullableContext(2)]
		public void SetFont(FSlateFontInfo InFontInfo)
		{
			UTextBlock.__SetFont_Internal(base.NativePtr, (InFontInfo ?? new FSlateFontInfo()).NativePtr);
		}

		// Token: 0x0600BB86 RID: 48006 RVA: 0x0012C573 File Offset: 0x0012A773
		[NullableContext(2)]
		public void SetColorAndOpacity(FSlateColor InColorAndOpacity)
		{
			UTextBlock.__SetColorAndOpacity_Internal(base.NativePtr, (InColorAndOpacity ?? new FSlateColor()).NativePtr);
		}

		// Token: 0x0600BB87 RID: 48007 RVA: 0x0012C58F File Offset: 0x0012A78F
		public void SetAutoWrapText(bool InAutoTextWrap)
		{
			UTextBlock.__SetAutoWrapText_Internal(base.NativePtr, InAutoTextWrap);
		}

		// Token: 0x0600BB88 RID: 48008 RVA: 0x0012C59D File Offset: 0x0012A79D
		public FText GetText()
		{
			return new FText(UTextBlock.__GetText_Internal(base.NativePtr), null);
		}

		// Token: 0x0600BB89 RID: 48009 RVA: 0x0012C5B0 File Offset: 0x0012A7B0
		[NullableContext(2)]
		public UMaterialInstanceDynamic GetDynamicOutlineMaterial()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UMaterialInstanceDynamic>(UTextBlock.__GetDynamicOutlineMaterial_Internal(base.NativePtr));
		}

		// Token: 0x0600BB8A RID: 48010 RVA: 0x0012C5C2 File Offset: 0x0012A7C2
		[NullableContext(2)]
		public UMaterialInstanceDynamic GetDynamicFontMaterial()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UMaterialInstanceDynamic>(UTextBlock.__GetDynamicFontMaterial_Internal(base.NativePtr));
		}

		// Token: 0x0600BB8B RID: 48011
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetText_Internal(IntPtr @this, IntPtr InText);

		// Token: 0x0600BB8C RID: 48012
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetShadowOffset_Internal(IntPtr @this, FVector2D InShadowOffset);

		// Token: 0x0600BB8D RID: 48013
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetShadowColorAndOpacity_Internal(IntPtr @this, FLinearColor InShadowColorAndOpacity);

		// Token: 0x0600BB8E RID: 48014
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetOpacity_Internal(IntPtr @this, float InOpacity);

		// Token: 0x0600BB8F RID: 48015
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetMinDesiredWidth_Internal(IntPtr @this, float InMinDesiredWidth);

		// Token: 0x0600BB90 RID: 48016
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetFont_Internal(IntPtr @this, IntPtr InFontInfo);

		// Token: 0x0600BB91 RID: 48017
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetColorAndOpacity_Internal(IntPtr @this, IntPtr InColorAndOpacity);

		// Token: 0x0600BB92 RID: 48018
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAutoWrapText_Internal(IntPtr @this, bool InAutoTextWrap);

		// Token: 0x0600BB93 RID: 48019
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetText_Internal(IntPtr @this);

		// Token: 0x0600BB94 RID: 48020
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetDynamicOutlineMaterial_Internal(IntPtr @this);

		// Token: 0x0600BB95 RID: 48021
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetDynamicFontMaterial_Internal(IntPtr @this);

		// Token: 0x0600BB96 RID: 48022 RVA: 0x0012C5D4 File Offset: 0x0012A7D4
		static UTextBlock()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/UMG.TextBlock");
		}

		// Token: 0x0600BB97 RID: 48023 RVA: 0x0012C5E2 File Offset: 0x0012A7E2
		protected UTextBlock(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040054DD RID: 21725
		public new const string __ObjectPath = "/Script/UMG.TextBlock";

		// Token: 0x040054DE RID: 21726
		private static IntPtr _ClassPtr;

		// Token: 0x040054DF RID: 21727
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040054E0 RID: 21728
		internal static int __PropertyOffset_Text;

		// Token: 0x040054E1 RID: 21729
		[Nullable(2)]
		private FText _Text;

		// Token: 0x040054E2 RID: 21730
		internal static int __PropertyOffset_TextDelegate;

		// Token: 0x040054E3 RID: 21731
		[Nullable(2)]
		private FGetText _TextDelegate;

		// Token: 0x040054E4 RID: 21732
		internal static int __PropertyOffset_ColorAndOpacity;

		// Token: 0x040054E5 RID: 21733
		[Nullable(2)]
		private FSlateColor _ColorAndOpacity;

		// Token: 0x040054E6 RID: 21734
		internal static int __PropertyOffset_ColorAndOpacityDelegate;

		// Token: 0x040054E7 RID: 21735
		[Nullable(2)]
		private FGetSlateColor _ColorAndOpacityDelegate;

		// Token: 0x040054E8 RID: 21736
		internal static int __PropertyOffset_Font;

		// Token: 0x040054E9 RID: 21737
		[Nullable(2)]
		private FSlateFontInfo _Font;

		// Token: 0x040054EA RID: 21738
		internal static int __PropertyOffset_ShadowOffset;

		// Token: 0x040054EB RID: 21739
		internal static int __PropertyOffset_ShadowColorAndOpacity;

		// Token: 0x040054EC RID: 21740
		internal static int __PropertyOffset_ShadowColorAndOpacityDelegate;

		// Token: 0x040054ED RID: 21741
		[Nullable(2)]
		private FGetLinearColor _ShadowColorAndOpacityDelegate;

		// Token: 0x040054EE RID: 21742
		internal static int __PropertyOffset_MinDesiredWidth;

		// Token: 0x040054EF RID: 21743
		internal static int __PropertyOffset_bWrapWithInvalidationPanel;

		// Token: 0x040054F0 RID: 21744
		internal static int __PropertyOffset_bAutoWrapText_DEPRECATED;

		// Token: 0x040054F1 RID: 21745
		internal static int __PropertyOffset_bSimpleTextMode;
	}
}
