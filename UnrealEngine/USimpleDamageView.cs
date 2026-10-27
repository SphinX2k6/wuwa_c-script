using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001887 RID: 6279
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroGameplayUI.SimpleDamageView")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 80)]
	public class USimpleDamageView : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601724C RID: 94796 RVA: 0x0021B892 File Offset: 0x00219A92
		public new static UClassStackOnlyPtr StaticClass()
		{
			return USimpleDamageView._ClassPtr;
		}

		// Token: 0x0601724D RID: 94797 RVA: 0x0021B8A0 File Offset: 0x00219AA0
		public USimpleDamageView() : this(BuiltinUtils.AllocNativeUObject(USimpleDamageView.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601724E RID: 94798 RVA: 0x0021B8C8 File Offset: 0x00219AC8
		[NullableContext(1)]
		public USimpleDamageView(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(USimpleDamageView.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005D23 RID: 23843
		// (get) Token: 0x0601724F RID: 94799 RVA: 0x0021B8FB File Offset: 0x00219AFB
		// (set) Token: 0x06017250 RID: 94800 RVA: 0x0021B90F File Offset: 0x00219B0F
		public unsafe AUIBaseActor RootActor
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AUIBaseActor>(base.NativePtr / (IntPtr)sizeof(void*) + USimpleDamageView.__PropertyOffset_RootActor);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + USimpleDamageView.__PropertyOffset_RootActor, value);
			}
		}

		// Token: 0x17005D24 RID: 23844
		// (get) Token: 0x06017251 RID: 94801 RVA: 0x0021B924 File Offset: 0x00219B24
		// (set) Token: 0x06017252 RID: 94802 RVA: 0x0021B938 File Offset: 0x00219B38
		public unsafe UUIItem RootItem
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UUIItem>(base.NativePtr / (IntPtr)sizeof(void*) + USimpleDamageView.__PropertyOffset_RootItem);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + USimpleDamageView.__PropertyOffset_RootItem, value);
			}
		}

		// Token: 0x17005D25 RID: 23845
		// (get) Token: 0x06017253 RID: 94803 RVA: 0x0021B94D File Offset: 0x00219B4D
		// (set) Token: 0x06017254 RID: 94804 RVA: 0x0021B961 File Offset: 0x00219B61
		public unsafe UUIItem CritItem
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UUIItem>(base.NativePtr / (IntPtr)sizeof(void*) + USimpleDamageView.__PropertyOffset_CritItem);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + USimpleDamageView.__PropertyOffset_CritItem, value);
			}
		}

		// Token: 0x17005D26 RID: 23846
		// (get) Token: 0x06017255 RID: 94805 RVA: 0x0021B976 File Offset: 0x00219B76
		// (set) Token: 0x06017256 RID: 94806 RVA: 0x0021B98A File Offset: 0x00219B8A
		public unsafe UUINiagara CritNiagara
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UUINiagara>(base.NativePtr / (IntPtr)sizeof(void*) + USimpleDamageView.__PropertyOffset_CritNiagara);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + USimpleDamageView.__PropertyOffset_CritNiagara, value);
			}
		}

		// Token: 0x06017257 RID: 94807 RVA: 0x0021B99F File Offset: 0x00219B9F
		static USimpleDamageView()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroGameplayUI.SimpleDamageView");
		}

		// Token: 0x06017258 RID: 94808 RVA: 0x0021B9AD File Offset: 0x00219BAD
		protected USimpleDamageView(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400C8D7 RID: 51415
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroGameplayUI.SimpleDamageView";

		// Token: 0x0400C8D8 RID: 51416
		private static IntPtr _ClassPtr;

		// Token: 0x0400C8D9 RID: 51417
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400C8DA RID: 51418
		internal static int __PropertyOffset_RootActor;

		// Token: 0x0400C8DB RID: 51419
		internal static int __PropertyOffset_RootItem;

		// Token: 0x0400C8DC RID: 51420
		internal static int __PropertyOffset_CritItem;

		// Token: 0x0400C8DD RID: 51421
		internal static int __PropertyOffset_CritNiagara;
	}
}
