using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000879 RID: 2169
	[UnrealObjectPath("/Script/UMG.WidgetTree")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 72)]
	public class UWidgetTree : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600BD3E RID: 48446 RVA: 0x0012DFE0 File Offset: 0x0012C1E0
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UWidgetTree._ClassPtr;
		}

		// Token: 0x0600BD3F RID: 48447 RVA: 0x0012DFEC File Offset: 0x0012C1EC
		public UWidgetTree() : this(BuiltinUtils.AllocNativeUObject(UWidgetTree.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600BD40 RID: 48448 RVA: 0x0012E014 File Offset: 0x0012C214
		[NullableContext(1)]
		public UWidgetTree(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UWidgetTree.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002302 RID: 8962
		// (get) Token: 0x0600BD41 RID: 48449 RVA: 0x0012E047 File Offset: 0x0012C247
		// (set) Token: 0x0600BD42 RID: 48450 RVA: 0x0012E05B File Offset: 0x0012C25B
		[Nullable(2)]
		public unsafe UWidget RootWidget
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UWidget>(base.NativePtr / (IntPtr)sizeof(void*) + UWidgetTree.__PropertyOffset_RootWidget);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UWidgetTree.__PropertyOffset_RootWidget, value);
			}
		}

		// Token: 0x0600BD43 RID: 48451 RVA: 0x0012E070 File Offset: 0x0012C270
		static UWidgetTree()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/UMG.WidgetTree");
		}

		// Token: 0x0600BD44 RID: 48452 RVA: 0x0012E07E File Offset: 0x0012C27E
		protected UWidgetTree(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400556F RID: 21871
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/UMG.WidgetTree";

		// Token: 0x04005570 RID: 21872
		private static IntPtr _ClassPtr;

		// Token: 0x04005571 RID: 21873
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04005572 RID: 21874
		internal static int __PropertyOffset_RootWidget;
	}
}
