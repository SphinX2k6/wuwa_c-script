using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002830 RID: 10288
	[UnrealObjectPath("/Script/SlateCore.SlateWidgetStyleAsset")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 56)]
	public class USlateWidgetStyleAsset : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060263AB RID: 156587 RVA: 0x003A05B6 File Offset: 0x0039E7B6
		public new static UClassStackOnlyPtr StaticClass()
		{
			return USlateWidgetStyleAsset._ClassPtr;
		}

		// Token: 0x060263AC RID: 156588 RVA: 0x003A05C4 File Offset: 0x0039E7C4
		public USlateWidgetStyleAsset() : this(BuiltinUtils.AllocNativeUObject(USlateWidgetStyleAsset.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060263AD RID: 156589 RVA: 0x003A05EC File Offset: 0x0039E7EC
		[NullableContext(1)]
		public USlateWidgetStyleAsset(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(USlateWidgetStyleAsset.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17009390 RID: 37776
		// (get) Token: 0x060263AE RID: 156590 RVA: 0x003A061F File Offset: 0x0039E81F
		// (set) Token: 0x060263AF RID: 156591 RVA: 0x003A0633 File Offset: 0x0039E833
		[Nullable(2)]
		public unsafe USlateWidgetStyleContainerBase CustomStyle
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USlateWidgetStyleContainerBase>(base.NativePtr / (IntPtr)sizeof(void*) + USlateWidgetStyleAsset.__PropertyOffset_CustomStyle);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + USlateWidgetStyleAsset.__PropertyOffset_CustomStyle, value);
			}
		}

		// Token: 0x060263B0 RID: 156592 RVA: 0x003A0648 File Offset: 0x0039E848
		static USlateWidgetStyleAsset()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/SlateCore.SlateWidgetStyleAsset");
		}

		// Token: 0x060263B1 RID: 156593 RVA: 0x003A0656 File Offset: 0x0039E856
		protected USlateWidgetStyleAsset(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04014EC6 RID: 85702
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/SlateCore.SlateWidgetStyleAsset";

		// Token: 0x04014EC7 RID: 85703
		private static IntPtr _ClassPtr;

		// Token: 0x04014EC8 RID: 85704
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04014EC9 RID: 85705
		internal static int __PropertyOffset_CustomStyle;
	}
}
