using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020015B0 RID: 5552
	[UnrealObjectPath("/Script/JsEnv.JSAnimGeneratedClass")]
	[UnrealStructLayout(2880, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2880)]
	public class UJSAnimGeneratedClass : UAnimBlueprintGeneratedClass, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060140A8 RID: 82088 RVA: 0x001D69E6 File Offset: 0x001D4BE6
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UJSAnimGeneratedClass._ClassPtr;
		}

		// Token: 0x060140A9 RID: 82089 RVA: 0x001D69F4 File Offset: 0x001D4BF4
		public UJSAnimGeneratedClass() : this(BuiltinUtils.AllocNativeUObject(UJSAnimGeneratedClass.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060140AA RID: 82090 RVA: 0x001D6A1C File Offset: 0x001D4C1C
		[NullableContext(1)]
		public UJSAnimGeneratedClass(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UJSAnimGeneratedClass.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060140AB RID: 82091 RVA: 0x001D6A4F File Offset: 0x001D4C4F
		static UJSAnimGeneratedClass()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/JsEnv.JSAnimGeneratedClass");
		}

		// Token: 0x060140AC RID: 82092 RVA: 0x001D6A5D File Offset: 0x001D4C5D
		protected UJSAnimGeneratedClass(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400AE56 RID: 44630
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/JsEnv.JSAnimGeneratedClass";

		// Token: 0x0400AE57 RID: 44631
		private static IntPtr _ClassPtr;

		// Token: 0x0400AE58 RID: 44632
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
