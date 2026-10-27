using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020015B5 RID: 5557
	[UnrealObjectPath("/Script/JsEnv.JSWidgetGeneratedClass")]
	[UnrealStructLayout(1608, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1608)]
	public class UJSWidgetGeneratedClass : UWidgetBlueprintGeneratedClass, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06014105 RID: 82181 RVA: 0x001D70D6 File Offset: 0x001D52D6
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UJSWidgetGeneratedClass._ClassPtr;
		}

		// Token: 0x06014106 RID: 82182 RVA: 0x001D70E4 File Offset: 0x001D52E4
		public UJSWidgetGeneratedClass() : this(BuiltinUtils.AllocNativeUObject(UJSWidgetGeneratedClass.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06014107 RID: 82183 RVA: 0x001D710C File Offset: 0x001D530C
		[NullableContext(1)]
		public UJSWidgetGeneratedClass(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UJSWidgetGeneratedClass.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06014108 RID: 82184 RVA: 0x001D713F File Offset: 0x001D533F
		static UJSWidgetGeneratedClass()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/JsEnv.JSWidgetGeneratedClass");
		}

		// Token: 0x06014109 RID: 82185 RVA: 0x001D714D File Offset: 0x001D534D
		protected UJSWidgetGeneratedClass(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400AE86 RID: 44678
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/JsEnv.JSWidgetGeneratedClass";

		// Token: 0x0400AE87 RID: 44679
		private static IntPtr _ClassPtr;

		// Token: 0x0400AE88 RID: 44680
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
