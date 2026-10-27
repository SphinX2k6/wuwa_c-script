using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200216E RID: 8558
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.UIFlyoutMenu")]
	[UnrealStructLayout(256, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 256)]
	public class UUIFlyoutMenu : UActorComponent, IUnrealUObject, IUnrealObject, ILGUIPointerSelectDeselectInterface, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x060204DD RID: 132317 RVA: 0x002FFA09 File Offset: 0x002FDC09
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUIFlyoutMenu._ClassPtr;
		}

		// Token: 0x060204DE RID: 132318 RVA: 0x002FFA15 File Offset: 0x002FDC15
		int ILGUIPointerSelectDeselectInterface.InterfaceOffset()
		{
			return UUIFlyoutMenu.__InterfaceOffset_ILGUIPointerSelectDeselectInterface;
		}

		// Token: 0x060204DF RID: 132319 RVA: 0x002FFA1C File Offset: 0x002FDC1C
		public UUIFlyoutMenu() : this(BuiltinUtils.AllocNativeUObject(UUIFlyoutMenu.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060204E0 RID: 132320 RVA: 0x002FFA44 File Offset: 0x002FDC44
		[NullableContext(1)]
		public UUIFlyoutMenu(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UUIFlyoutMenu.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007E9E RID: 32414
		// (get) Token: 0x060204E1 RID: 132321 RVA: 0x002FFA77 File Offset: 0x002FDC77
		// (set) Token: 0x060204E2 RID: 132322 RVA: 0x002FFA8B File Offset: 0x002FDC8B
		public unsafe AUIBaseActor _RootUIActor
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AUIBaseActor>(base.NativePtr / (IntPtr)sizeof(void*) + UUIFlyoutMenu.__PropertyOffset__RootUIActor);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UUIFlyoutMenu.__PropertyOffset__RootUIActor, value);
			}
		}

		// Token: 0x17007E9F RID: 32415
		// (get) Token: 0x060204E3 RID: 132323 RVA: 0x002FFAA0 File Offset: 0x002FDCA0
		// (set) Token: 0x060204E4 RID: 132324 RVA: 0x002FFAB4 File Offset: 0x002FDCB4
		public unsafe AUIBaseActor _SrcItemActor
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AUIBaseActor>(base.NativePtr / (IntPtr)sizeof(void*) + UUIFlyoutMenu.__PropertyOffset__SrcItemActor);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UUIFlyoutMenu.__PropertyOffset__SrcItemActor, value);
			}
		}

		// Token: 0x17007EA0 RID: 32416
		// (get) Token: 0x060204E5 RID: 132325 RVA: 0x002FFACC File Offset: 0x002FDCCC
		// (set) Token: 0x060204E6 RID: 132326 RVA: 0x002FFB05 File Offset: 0x002FDD05
		[Nullable(1)]
		public TArray<UUIFlyoutMenuItem> _CreatedItemArray
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<UUIFlyoutMenuItem> result;
				if ((result = this.__CreatedItemArray) == null)
				{
					result = (this.__CreatedItemArray = new TArray<UUIFlyoutMenuItem>(base.NativePtr + (IntPtr)UUIFlyoutMenu.__PropertyOffset__CreatedItemArray, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this._CreatedItemArray.CopyAssign(value);
			}
		}

		// Token: 0x060204E7 RID: 132327 RVA: 0x002FFB13 File Offset: 0x002FDD13
		public static UUIFlyoutMenu CreateFlyoutMenuFromArray([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<string> InItemNameArray, in FUIFlyoutMenuSelectDynamicDelegate InCallback, AUIBaseActor InParentActor, int InWidth = 200, EFlyoutMenuVerticalPosition InVerticalPosition = EFlyoutMenuVerticalPosition.Top, EFlyoutMenuHorizontalAlignment InHorizontalAlign = EFlyoutMenuHorizontalAlignment.Center)
		{
			IntPtr nativePtr = (InItemNameArray ?? new TArray<string>()).NativePtr;
			FUIFlyoutMenuSelectDynamicDelegate fuiflyoutMenuSelectDynamicDelegate = InCallback;
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UUIFlyoutMenu>(UUIFlyoutMenu.__CreateFlyoutMenuFromArray_Internal(nativePtr, (fuiflyoutMenuSelectDynamicDelegate != null) ? fuiflyoutMenuSelectDynamicDelegate.NativePtr : ((IntPtr)0), (InParentActor != null) ? InParentActor.NativePtr : IntPtr.Zero, InWidth, InVerticalPosition, InHorizontalAlign));
		}

		// Token: 0x060204E8 RID: 132328
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __CreateFlyoutMenuFromArray_Internal(IntPtr InItemNameArray, IntPtr InCallback, IntPtr InParentActor, int InWidth, EFlyoutMenuVerticalPosition InVerticalPosition, EFlyoutMenuHorizontalAlignment InHorizontalAlign);

		// Token: 0x060204E9 RID: 132329 RVA: 0x002FFB53 File Offset: 0x002FDD53
		static UUIFlyoutMenu()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UIFlyoutMenu");
		}

		// Token: 0x060204EA RID: 132330 RVA: 0x002FFB61 File Offset: 0x002FDD61
		protected UUIFlyoutMenu(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040115B4 RID: 71092
		internal static int __InterfaceOffset_ILGUIPointerSelectDeselectInterface;

		// Token: 0x040115B5 RID: 71093
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.UIFlyoutMenu";

		// Token: 0x040115B6 RID: 71094
		private static IntPtr _ClassPtr;

		// Token: 0x040115B7 RID: 71095
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040115B8 RID: 71096
		internal static int __PropertyOffset__RootUIActor;

		// Token: 0x040115B9 RID: 71097
		internal static int __PropertyOffset__SrcItemActor;

		// Token: 0x040115BA RID: 71098
		internal static int __PropertyOffset__CreatedItemArray;

		// Token: 0x040115BB RID: 71099
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UUIFlyoutMenuItem> __CreatedItemArray;
	}
}
