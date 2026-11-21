using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200087D RID: 2173
	[UnrealObjectPath("/Script/XeSSBlueprint.XeSSBlueprintLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UXeSSBlueprintLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600BD56 RID: 48470 RVA: 0x0012E1E2 File Offset: 0x0012C3E2
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UXeSSBlueprintLibrary._ClassPtr;
		}

		// Token: 0x0600BD57 RID: 48471 RVA: 0x0012E1F0 File Offset: 0x0012C3F0
		public UXeSSBlueprintLibrary() : this(BuiltinUtils.AllocNativeUObject(UXeSSBlueprintLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600BD58 RID: 48472 RVA: 0x0012E218 File Offset: 0x0012C418
		[NullableContext(1)]
		public UXeSSBlueprintLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UXeSSBlueprintLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600BD59 RID: 48473
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool IsXeSSSupported();

		// Token: 0x0600BD5A RID: 48474 RVA: 0x0012E24B File Offset: 0x0012C44B
		static UXeSSBlueprintLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/XeSSBlueprint.XeSSBlueprintLibrary");
		}

		// Token: 0x0600BD5B RID: 48475 RVA: 0x0012E259 File Offset: 0x0012C459
		protected UXeSSBlueprintLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400557E RID: 21886
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/XeSSBlueprint.XeSSBlueprintLibrary";

		// Token: 0x0400557F RID: 21887
		private static IntPtr _ClassPtr;

		// Token: 0x04005580 RID: 21888
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
