using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020014AA RID: 5290
	[UnrealObjectPath("/Script/HoudiniEngineRuntime.HoudiniAssetParameter")]
	[UnrealStructLayout(136, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 136)]
	public class UHoudiniAssetParameter : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060132F4 RID: 78580 RVA: 0x001C37C6 File Offset: 0x001C19C6
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UHoudiniAssetParameter._ClassPtr;
		}

		// Token: 0x060132F5 RID: 78581 RVA: 0x001C37D4 File Offset: 0x001C19D4
		public UHoudiniAssetParameter() : this(BuiltinUtils.AllocNativeUObject(UHoudiniAssetParameter.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060132F6 RID: 78582 RVA: 0x001C37FC File Offset: 0x001C19FC
		[NullableContext(1)]
		public UHoudiniAssetParameter(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UHoudiniAssetParameter.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060132F7 RID: 78583 RVA: 0x001C382F File Offset: 0x001C1A2F
		static UHoudiniAssetParameter()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/HoudiniEngineRuntime.HoudiniAssetParameter");
		}

		// Token: 0x060132F8 RID: 78584 RVA: 0x001C383D File Offset: 0x001C1A3D
		protected UHoudiniAssetParameter(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400A5C5 RID: 42437
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/HoudiniEngineRuntime.HoudiniAssetParameter";

		// Token: 0x0400A5C6 RID: 42438
		private static IntPtr _ClassPtr;

		// Token: 0x0400A5C7 RID: 42439
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
