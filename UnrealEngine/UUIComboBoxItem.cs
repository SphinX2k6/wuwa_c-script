using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002133 RID: 8499
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.UIComboBoxItem")]
	[UnrealStructLayout(248, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 248)]
	public class UUIComboBoxItem : UActorComponent, IUnrealUObject, IUnrealObject, ILGUIPointerClickInterface, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x06020005 RID: 131077 RVA: 0x002F9696 File Offset: 0x002F7896
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUIComboBoxItem._ClassPtr;
		}

		// Token: 0x06020006 RID: 131078 RVA: 0x002F96A2 File Offset: 0x002F78A2
		int ILGUIPointerClickInterface.InterfaceOffset()
		{
			return UUIComboBoxItem.__InterfaceOffset_ILGUIPointerClickInterface;
		}

		// Token: 0x06020007 RID: 131079 RVA: 0x002F96AC File Offset: 0x002F78AC
		public UUIComboBoxItem() : this(BuiltinUtils.AllocNativeUObject(UUIComboBoxItem.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06020008 RID: 131080 RVA: 0x002F96D4 File Offset: 0x002F78D4
		[NullableContext(1)]
		public UUIComboBoxItem(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UUIComboBoxItem.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007DBC RID: 32188
		// (get) Token: 0x06020009 RID: 131081 RVA: 0x002F9707 File Offset: 0x002F7907
		// (set) Token: 0x0602000A RID: 131082 RVA: 0x002F971B File Offset: 0x002F791B
		public unsafe AUIBaseActor _RootUIActor
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AUIBaseActor>(base.NativePtr / (IntPtr)sizeof(void*) + UUIComboBoxItem.__PropertyOffset__RootUIActor);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UUIComboBoxItem.__PropertyOffset__RootUIActor, value);
			}
		}

		// Token: 0x17007DBD RID: 32189
		// (get) Token: 0x0602000B RID: 131083 RVA: 0x002F9730 File Offset: 0x002F7930
		// (set) Token: 0x0602000C RID: 131084 RVA: 0x002F9744 File Offset: 0x002F7944
		public unsafe AUITextActor _TextActor
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AUITextActor>(base.NativePtr / (IntPtr)sizeof(void*) + UUIComboBoxItem.__PropertyOffset__TextActor);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UUIComboBoxItem.__PropertyOffset__TextActor, value);
			}
		}

		// Token: 0x17007DBE RID: 32190
		// (get) Token: 0x0602000D RID: 131085 RVA: 0x002F9759 File Offset: 0x002F7959
		// (set) Token: 0x0602000E RID: 131086 RVA: 0x002F976D File Offset: 0x002F796D
		public unsafe AUISpriteActor _HighlightSpriteActor
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AUISpriteActor>(base.NativePtr / (IntPtr)sizeof(void*) + UUIComboBoxItem.__PropertyOffset__HighlightSpriteActor);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UUIComboBoxItem.__PropertyOffset__HighlightSpriteActor, value);
			}
		}

		// Token: 0x0602000F RID: 131087 RVA: 0x002F9782 File Offset: 0x002F7982
		static UUIComboBoxItem()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UIComboBoxItem");
		}

		// Token: 0x06020010 RID: 131088 RVA: 0x002F9790 File Offset: 0x002F7990
		protected UUIComboBoxItem(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040113AC RID: 70572
		internal static int __InterfaceOffset_ILGUIPointerClickInterface;

		// Token: 0x040113AD RID: 70573
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.UIComboBoxItem";

		// Token: 0x040113AE RID: 70574
		private static IntPtr _ClassPtr;

		// Token: 0x040113AF RID: 70575
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040113B0 RID: 70576
		internal static int __PropertyOffset__RootUIActor;

		// Token: 0x040113B1 RID: 70577
		internal static int __PropertyOffset__TextActor;

		// Token: 0x040113B2 RID: 70578
		internal static int __PropertyOffset__HighlightSpriteActor;
	}
}
