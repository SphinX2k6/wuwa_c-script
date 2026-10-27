using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020015B3 RID: 5555
	[UnrealObjectPath("/Script/JsEnv.JSGeneratedFunction")]
	[UnrealStructLayout(272, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 272)]
	public class UJSGeneratedFunction : UFunction, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060140F9 RID: 82169 RVA: 0x001D6FF6 File Offset: 0x001D51F6
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UJSGeneratedFunction._ClassPtr;
		}

		// Token: 0x060140FA RID: 82170 RVA: 0x001D7004 File Offset: 0x001D5204
		public UJSGeneratedFunction() : this(BuiltinUtils.AllocNativeUObject(UJSGeneratedFunction.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060140FB RID: 82171 RVA: 0x001D702C File Offset: 0x001D522C
		[NullableContext(1)]
		public UJSGeneratedFunction(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UJSGeneratedFunction.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060140FC RID: 82172 RVA: 0x001D705F File Offset: 0x001D525F
		static UJSGeneratedFunction()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/JsEnv.JSGeneratedFunction");
		}

		// Token: 0x060140FD RID: 82173 RVA: 0x001D706D File Offset: 0x001D526D
		protected UJSGeneratedFunction(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400AE81 RID: 44673
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/JsEnv.JSGeneratedFunction";

		// Token: 0x0400AE82 RID: 44674
		private static IntPtr _ClassPtr;

		// Token: 0x0400AE83 RID: 44675
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
