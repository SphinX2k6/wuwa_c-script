using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002A08 RID: 10760
	[UnrealObjectPath("/Script/UMG.WidgetTree")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 72)]
	public class UWidgetTree : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06028022 RID: 163874 RVA: 0x003CE7B6 File Offset: 0x003CC9B6
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UWidgetTree._ClassPtr;
		}

		// Token: 0x06028023 RID: 163875 RVA: 0x003CE7C4 File Offset: 0x003CC9C4
		public UWidgetTree() : this(BuiltinUtils.AllocNativeUObject(UWidgetTree.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06028024 RID: 163876 RVA: 0x003CE7EC File Offset: 0x003CC9EC
		[NullableContext(1)]
		public UWidgetTree(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UWidgetTree.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170098D3 RID: 39123
		// (get) Token: 0x06028025 RID: 163877 RVA: 0x003CE81F File Offset: 0x003CCA1F
		// (set) Token: 0x06028026 RID: 163878 RVA: 0x003CE833 File Offset: 0x003CCA33
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

		// Token: 0x06028027 RID: 163879 RVA: 0x003CE848 File Offset: 0x003CCA48
		static UWidgetTree()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/UMG.WidgetTree");
		}

		// Token: 0x06028028 RID: 163880 RVA: 0x003CE856 File Offset: 0x003CCA56
		protected UWidgetTree(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015D54 RID: 89428
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/UMG.WidgetTree";

		// Token: 0x04015D55 RID: 89429
		private static IntPtr _ClassPtr;

		// Token: 0x04015D56 RID: 89430
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04015D57 RID: 89431
		internal static int __PropertyOffset_RootWidget;
	}
}
