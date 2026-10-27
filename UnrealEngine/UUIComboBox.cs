using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002132 RID: 8498
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.UIComboBox")]
	[UnrealStructLayout(256, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 256)]
	public class UUIComboBox : UActorComponent, IUnrealUObject, IUnrealObject, ILGUIPointerSelectDeselectInterface, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x0601FFF9 RID: 131065 RVA: 0x002F9581 File Offset: 0x002F7781
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUIComboBox._ClassPtr;
		}

		// Token: 0x0601FFFA RID: 131066 RVA: 0x002F958D File Offset: 0x002F778D
		int ILGUIPointerSelectDeselectInterface.InterfaceOffset()
		{
			return UUIComboBox.__InterfaceOffset_ILGUIPointerSelectDeselectInterface;
		}

		// Token: 0x0601FFFB RID: 131067 RVA: 0x002F9594 File Offset: 0x002F7794
		public UUIComboBox() : this(BuiltinUtils.AllocNativeUObject(UUIComboBox.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601FFFC RID: 131068 RVA: 0x002F95BC File Offset: 0x002F77BC
		[NullableContext(1)]
		public UUIComboBox(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UUIComboBox.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007DBA RID: 32186
		// (get) Token: 0x0601FFFD RID: 131069 RVA: 0x002F95EF File Offset: 0x002F77EF
		// (set) Token: 0x0601FFFE RID: 131070 RVA: 0x002F9603 File Offset: 0x002F7803
		public unsafe AUIBaseActor _RootUIActor
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AUIBaseActor>(base.NativePtr / (IntPtr)sizeof(void*) + UUIComboBox.__PropertyOffset__RootUIActor);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UUIComboBox.__PropertyOffset__RootUIActor, value);
			}
		}

		// Token: 0x17007DBB RID: 32187
		// (get) Token: 0x0601FFFF RID: 131071 RVA: 0x002F9618 File Offset: 0x002F7818
		// (set) Token: 0x06020000 RID: 131072 RVA: 0x002F962C File Offset: 0x002F782C
		public unsafe AUIBaseActor _SrcItemActor
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AUIBaseActor>(base.NativePtr / (IntPtr)sizeof(void*) + UUIComboBox.__PropertyOffset__SrcItemActor);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UUIComboBox.__PropertyOffset__SrcItemActor, value);
			}
		}

		// Token: 0x06020001 RID: 131073 RVA: 0x002F9641 File Offset: 0x002F7841
		public static UUIComboBox CreateComboBoxFromArray([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<string> InItemNameArray, in FUIComboBoxSelectDynamicDelegate InCallback, AUIBaseActor InParentActor, int InSelectedItemIndex = -1, EComboBoxPosition InPosition = EComboBoxPosition.Top)
		{
			IntPtr nativePtr = (InItemNameArray ?? new TArray<string>()).NativePtr;
			FUIComboBoxSelectDynamicDelegate fuicomboBoxSelectDynamicDelegate = InCallback;
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UUIComboBox>(UUIComboBox.__CreateComboBoxFromArray_Internal(nativePtr, (fuicomboBoxSelectDynamicDelegate != null) ? fuicomboBoxSelectDynamicDelegate.NativePtr : ((IntPtr)0), (InParentActor != null) ? InParentActor.NativePtr : IntPtr.Zero, InSelectedItemIndex, InPosition));
		}

		// Token: 0x06020002 RID: 131074
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __CreateComboBoxFromArray_Internal(IntPtr InItemNameArray, IntPtr InCallback, IntPtr InParentActor, int InSelectedItemIndex, EComboBoxPosition InPosition);

		// Token: 0x06020003 RID: 131075 RVA: 0x002F967F File Offset: 0x002F787F
		static UUIComboBox()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UIComboBox");
		}

		// Token: 0x06020004 RID: 131076 RVA: 0x002F968D File Offset: 0x002F788D
		protected UUIComboBox(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040113A6 RID: 70566
		internal static int __InterfaceOffset_ILGUIPointerSelectDeselectInterface;

		// Token: 0x040113A7 RID: 70567
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.UIComboBox";

		// Token: 0x040113A8 RID: 70568
		private static IntPtr _ClassPtr;

		// Token: 0x040113A9 RID: 70569
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040113AA RID: 70570
		internal static int __PropertyOffset__RootUIActor;

		// Token: 0x040113AB RID: 70571
		internal static int __PropertyOffset__SrcItemActor;
	}
}
