using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020008C1 RID: 2241
	[UnrealObjectPath("/Script/Engine.BlueprintFunctionLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public abstract class UBlueprintFunctionLibrary : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06007A62 RID: 31330 RVA: 0x000AF0AA File Offset: 0x000AD2AA
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UBlueprintFunctionLibrary._ClassPtr;
		}

		// Token: 0x06007A63 RID: 31331 RVA: 0x000AF0B6 File Offset: 0x000AD2B6
		static UBlueprintFunctionLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.BlueprintFunctionLibrary");
		}

		// Token: 0x06007A64 RID: 31332 RVA: 0x000AF0C4 File Offset: 0x000AD2C4
		protected UBlueprintFunctionLibrary() : this(BuiltinUtils.AllocNativeUObject(UBlueprintFunctionLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06007A65 RID: 31333 RVA: 0x000AF0EC File Offset: 0x000AD2EC
		protected UBlueprintFunctionLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04003AD7 RID: 15063
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.BlueprintFunctionLibrary";

		// Token: 0x04003AD8 RID: 15064
		private static IntPtr _ClassPtr;

		// Token: 0x04003AD9 RID: 15065
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
