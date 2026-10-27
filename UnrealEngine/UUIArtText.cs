using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002121 RID: 8481
	[UnrealObjectPath("/Script/LGUI.UIArtText")]
	[UnrealStructLayout(2384, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2384)]
	public class UUIArtText : UUIBatchGeometryRenderable, IUnrealUObject, IUnrealObject, ILGUITextAnimationTarget, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x0601FE6E RID: 130670 RVA: 0x002F750B File Offset: 0x002F570B
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUIArtText._ClassPtr;
		}

		// Token: 0x0601FE6F RID: 130671 RVA: 0x002F7517 File Offset: 0x002F5717
		int ILGUITextAnimationTarget.InterfaceOffset()
		{
			return UUIArtText.__InterfaceOffset_ILGUITextAnimationTarget;
		}

		// Token: 0x0601FE70 RID: 130672 RVA: 0x002F7520 File Offset: 0x002F5720
		public UUIArtText() : this(BuiltinUtils.AllocNativeUObject(UUIArtText.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601FE71 RID: 130673 RVA: 0x002F7548 File Offset: 0x002F5748
		[NullableContext(1)]
		public UUIArtText(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UUIArtText.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007D71 RID: 32113
		// (get) Token: 0x0601FE72 RID: 130674 RVA: 0x002F757B File Offset: 0x002F577B
		// (set) Token: 0x0601FE73 RID: 130675 RVA: 0x002F758F File Offset: 0x002F578F
		[Nullable(2)]
		public unsafe ULGUIArtTextData ArtTextData
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ULGUIArtTextData>(base.NativePtr / (IntPtr)sizeof(void*) + UUIArtText.__PropertyOffset_ArtTextData);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UUIArtText.__PropertyOffset_ArtTextData, value);
			}
		}

		// Token: 0x17007D72 RID: 32114
		// (get) Token: 0x0601FE74 RID: 130676 RVA: 0x002F75A4 File Offset: 0x002F57A4
		// (set) Token: 0x0601FE75 RID: 130677 RVA: 0x002F75B8 File Offset: 0x002F57B8
		[Nullable(1)]
		public unsafe string Text
		{
			[NullableContext(1)]
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UUIArtText.__PropertyOffset_Text)));
			}
			[NullableContext(1)]
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UUIArtText.__PropertyOffset_Text)), value);
			}
		}

		// Token: 0x17007D73 RID: 32115
		// (get) Token: 0x0601FE76 RID: 130678 RVA: 0x002F75CD File Offset: 0x002F57CD
		// (set) Token: 0x0601FE77 RID: 130679 RVA: 0x002F75DD File Offset: 0x002F57DD
		public unsafe float Size
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIArtText.__PropertyOffset_Size);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIArtText.__PropertyOffset_Size) = value;
			}
		}

		// Token: 0x17007D74 RID: 32116
		// (get) Token: 0x0601FE78 RID: 130680 RVA: 0x002F75EE File Offset: 0x002F57EE
		// (set) Token: 0x0601FE79 RID: 130681 RVA: 0x002F7602 File Offset: 0x002F5802
		public unsafe FVector2D Space
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIArtText.__PropertyOffset_Space);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIArtText.__PropertyOffset_Space) = value;
			}
		}

		// Token: 0x17007D75 RID: 32117
		// (get) Token: 0x0601FE7A RID: 130682 RVA: 0x002F7617 File Offset: 0x002F5817
		// (set) Token: 0x0601FE7B RID: 130683 RVA: 0x002F7627 File Offset: 0x002F5827
		public unsafe UIArtTextHorizontalAlign HorizontalAlign
		{
			get
			{
				return (UIArtTextHorizontalAlign)(*(base.NativePtr + (IntPtr)UUIArtText.__PropertyOffset_HorizontalAlign));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIArtText.__PropertyOffset_HorizontalAlign) = (byte)value;
			}
		}

		// Token: 0x17007D76 RID: 32118
		// (get) Token: 0x0601FE7C RID: 130684 RVA: 0x002F7638 File Offset: 0x002F5838
		// (set) Token: 0x0601FE7D RID: 130685 RVA: 0x002F7648 File Offset: 0x002F5848
		public unsafe bool IsWidthControlledByText
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIArtText.__PropertyOffset_IsWidthControlledByText) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIArtText.__PropertyOffset_IsWidthControlledByText) = (value ? 1 : 0);
			}
		}

		// Token: 0x0601FE7E RID: 130686 RVA: 0x002F765C File Offset: 0x002F585C
		[NullableContext(1)]
		public unsafe void SetText(string NewText)
		{
			FString fstring = FString.AllocTemp(NewText);
			UUIArtText.__SetText_Internal(base.NativePtr, fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x0601FE7F RID: 130687 RVA: 0x002F7686 File Offset: 0x002F5886
		public void SetSpace(FVector2D NewSpace)
		{
			UUIArtText.__SetSpace_Internal(base.NativePtr, NewSpace);
		}

		// Token: 0x0601FE80 RID: 130688 RVA: 0x002F7694 File Offset: 0x002F5894
		public void SetSize(float NewSize)
		{
			UUIArtText.__SetSize_Internal(base.NativePtr, NewSize);
		}

		// Token: 0x0601FE81 RID: 130689 RVA: 0x002F76A2 File Offset: 0x002F58A2
		public void SetIsWidthControlledByText(bool NewValue)
		{
			UUIArtText.__SetIsWidthControlledByText_Internal(base.NativePtr, NewValue);
		}

		// Token: 0x0601FE82 RID: 130690 RVA: 0x002F76B0 File Offset: 0x002F58B0
		public void SetHorizontalAlign(UIArtTextHorizontalAlign NewHorizontalAlign)
		{
			UUIArtText.__SetHorizontalAlign_Internal(base.NativePtr, NewHorizontalAlign);
		}

		// Token: 0x0601FE83 RID: 130691 RVA: 0x002F76BE File Offset: 0x002F58BE
		[NullableContext(2)]
		public void SetArtTextData(ULGUIArtTextData NewArtTextData)
		{
			UUIArtText.__SetArtTextData_Internal(base.NativePtr, (NewArtTextData != null) ? NewArtTextData.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601FE84 RID: 130692 RVA: 0x002F76DB File Offset: 0x002F58DB
		[NullableContext(1)]
		public string GetText()
		{
			return FString.ToStringAndDeleteNativePtr(UUIArtText.__GetText_Internal(base.NativePtr));
		}

		// Token: 0x0601FE85 RID: 130693 RVA: 0x002F76ED File Offset: 0x002F58ED
		public FVector2D GetSpace()
		{
			return UUIArtText.__GetSpace_Internal(base.NativePtr);
		}

		// Token: 0x0601FE86 RID: 130694 RVA: 0x002F76FA File Offset: 0x002F58FA
		public float GetSize()
		{
			return UUIArtText.__GetSize_Internal(base.NativePtr);
		}

		// Token: 0x0601FE87 RID: 130695 RVA: 0x002F7707 File Offset: 0x002F5907
		public float GetIsWidthControlledByText()
		{
			return UUIArtText.__GetIsWidthControlledByText_Internal(base.NativePtr);
		}

		// Token: 0x0601FE88 RID: 130696 RVA: 0x002F7714 File Offset: 0x002F5914
		public UIArtTextHorizontalAlign GetHorizontalAlign()
		{
			return UUIArtText.__GetHorizontalAlign_Internal(base.NativePtr);
		}

		// Token: 0x0601FE89 RID: 130697 RVA: 0x002F7721 File Offset: 0x002F5921
		[NullableContext(2)]
		public ULGUIArtTextData GetArtTextData()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ULGUIArtTextData>(UUIArtText.__GetArtTextData_Internal(base.NativePtr));
		}

		// Token: 0x0601FE8A RID: 130698 RVA: 0x002F7733 File Offset: 0x002F5933
		public bool CheckTextValid()
		{
			return UUIArtText.__CheckTextValid_Internal(base.NativePtr);
		}

		// Token: 0x0601FE8B RID: 130699
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetText_Internal(IntPtr @this, in FString NewText);

		// Token: 0x0601FE8C RID: 130700
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSpace_Internal(IntPtr @this, FVector2D NewSpace);

		// Token: 0x0601FE8D RID: 130701
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSize_Internal(IntPtr @this, float NewSize);

		// Token: 0x0601FE8E RID: 130702
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetIsWidthControlledByText_Internal(IntPtr @this, bool NewValue);

		// Token: 0x0601FE8F RID: 130703
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetHorizontalAlign_Internal(IntPtr @this, UIArtTextHorizontalAlign NewHorizontalAlign);

		// Token: 0x0601FE90 RID: 130704
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetArtTextData_Internal(IntPtr @this, IntPtr NewArtTextData);

		// Token: 0x0601FE91 RID: 130705
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetText_Internal(IntPtr @this);

		// Token: 0x0601FE92 RID: 130706
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector2D __GetSpace_Internal(IntPtr @this);

		// Token: 0x0601FE93 RID: 130707
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetSize_Internal(IntPtr @this);

		// Token: 0x0601FE94 RID: 130708
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetIsWidthControlledByText_Internal(IntPtr @this);

		// Token: 0x0601FE95 RID: 130709
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern UIArtTextHorizontalAlign __GetHorizontalAlign_Internal(IntPtr @this);

		// Token: 0x0601FE96 RID: 130710
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetArtTextData_Internal(IntPtr @this);

		// Token: 0x0601FE97 RID: 130711
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __CheckTextValid_Internal(IntPtr @this);

		// Token: 0x0601FE98 RID: 130712 RVA: 0x002F7740 File Offset: 0x002F5940
		static UUIArtText()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UIArtText");
		}

		// Token: 0x0601FE99 RID: 130713 RVA: 0x002F774E File Offset: 0x002F594E
		protected UUIArtText(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011309 RID: 70409
		internal static int __InterfaceOffset_ILGUITextAnimationTarget;

		// Token: 0x0401130A RID: 70410
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.UIArtText";

		// Token: 0x0401130B RID: 70411
		private static IntPtr _ClassPtr;

		// Token: 0x0401130C RID: 70412
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401130D RID: 70413
		internal static int __PropertyOffset_ArtTextData;

		// Token: 0x0401130E RID: 70414
		internal static int __PropertyOffset_Text;

		// Token: 0x0401130F RID: 70415
		internal static int __PropertyOffset_Size;

		// Token: 0x04011310 RID: 70416
		internal static int __PropertyOffset_Space;

		// Token: 0x04011311 RID: 70417
		internal static int __PropertyOffset_HorizontalAlign;

		// Token: 0x04011312 RID: 70418
		internal static int __PropertyOffset_IsWidthControlledByText;
	}
}
