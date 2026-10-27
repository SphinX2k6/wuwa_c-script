using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000755 RID: 1877
	[UnrealObjectPath("/Script/CoreUObject.ObjectRedirector")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 56)]
	public class UObjectRedirector : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06006325 RID: 25381 RVA: 0x0008E541 File Offset: 0x0008C741
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UObjectRedirector._ClassPtr;
		}

		// Token: 0x06006326 RID: 25382 RVA: 0x0008E550 File Offset: 0x0008C750
		public UObjectRedirector() : this(BuiltinUtils.AllocNativeUObject(UObjectRedirector.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06006327 RID: 25383 RVA: 0x0008E578 File Offset: 0x0008C778
		[NullableContext(1)]
		public UObjectRedirector(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UObjectRedirector.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06006328 RID: 25384 RVA: 0x0008E5AB File Offset: 0x0008C7AB
		static UObjectRedirector()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/CoreUObject.ObjectRedirector");
		}

		// Token: 0x06006329 RID: 25385 RVA: 0x0008E5B9 File Offset: 0x0008C7B9
		protected UObjectRedirector(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04002F7E RID: 12158
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/CoreUObject.ObjectRedirector";

		// Token: 0x04002F7F RID: 12159
		private static IntPtr _ClassPtr;

		// Token: 0x04002F80 RID: 12160
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
