using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020015AF RID: 5551
	[UnrealObjectPath("/Script/JsEnv.ExtensionMethods")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UExtensionMethods : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060140A3 RID: 82083 RVA: 0x001D6966 File Offset: 0x001D4B66
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UExtensionMethods._ClassPtr;
		}

		// Token: 0x060140A4 RID: 82084 RVA: 0x001D6974 File Offset: 0x001D4B74
		public UExtensionMethods() : this(BuiltinUtils.AllocNativeUObject(UExtensionMethods.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060140A5 RID: 82085 RVA: 0x001D699C File Offset: 0x001D4B9C
		[NullableContext(1)]
		public UExtensionMethods(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UExtensionMethods.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060140A6 RID: 82086 RVA: 0x001D69CF File Offset: 0x001D4BCF
		static UExtensionMethods()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/JsEnv.ExtensionMethods");
		}

		// Token: 0x060140A7 RID: 82087 RVA: 0x001D69DD File Offset: 0x001D4BDD
		protected UExtensionMethods(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400AE53 RID: 44627
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/JsEnv.ExtensionMethods";

		// Token: 0x0400AE54 RID: 44628
		private static IntPtr _ClassPtr;

		// Token: 0x0400AE55 RID: 44629
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
