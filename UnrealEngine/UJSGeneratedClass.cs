using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020015B2 RID: 5554
	[UnrealObjectPath("/Script/JsEnv.JSGeneratedClass")]
	[UnrealStructLayout(1544, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1544)]
	public class UJSGeneratedClass : UBlueprintGeneratedClass, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060140F4 RID: 82164 RVA: 0x001D6F76 File Offset: 0x001D5176
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UJSGeneratedClass._ClassPtr;
		}

		// Token: 0x060140F5 RID: 82165 RVA: 0x001D6F84 File Offset: 0x001D5184
		public UJSGeneratedClass() : this(BuiltinUtils.AllocNativeUObject(UJSGeneratedClass.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060140F6 RID: 82166 RVA: 0x001D6FAC File Offset: 0x001D51AC
		[NullableContext(1)]
		public UJSGeneratedClass(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UJSGeneratedClass.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060140F7 RID: 82167 RVA: 0x001D6FDF File Offset: 0x001D51DF
		static UJSGeneratedClass()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/JsEnv.JSGeneratedClass");
		}

		// Token: 0x060140F8 RID: 82168 RVA: 0x001D6FED File Offset: 0x001D51ED
		protected UJSGeneratedClass(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400AE7E RID: 44670
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/JsEnv.JSGeneratedClass";

		// Token: 0x0400AE7F RID: 44671
		private static IntPtr _ClassPtr;

		// Token: 0x0400AE80 RID: 44672
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
