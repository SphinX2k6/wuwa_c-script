using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000112 RID: 274
	[UnrealObjectPath("/Script/CoreUObject.Function")]
	[UnrealStructLayout(240, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 240)]
	public class UFunction : UStruct, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06001164 RID: 4452 RVA: 0x0001B889 File Offset: 0x00019A89
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UFunction._ClassPtr;
		}

		// Token: 0x06001165 RID: 4453 RVA: 0x0001B898 File Offset: 0x00019A98
		public UFunction() : this(BuiltinUtils.AllocNativeUObject(UFunction.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06001166 RID: 4454 RVA: 0x0001B8C0 File Offset: 0x00019AC0
		[NullableContext(1)]
		public UFunction(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UFunction.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06001167 RID: 4455 RVA: 0x0001B8F3 File Offset: 0x00019AF3
		static UFunction()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/CoreUObject.Function");
		}

		// Token: 0x06001168 RID: 4456 RVA: 0x0001B901 File Offset: 0x00019B01
		protected UFunction(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040004FF RID: 1279
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/CoreUObject.Function";

		// Token: 0x04000500 RID: 1280
		private static IntPtr _ClassPtr;

		// Token: 0x04000501 RID: 1281
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
