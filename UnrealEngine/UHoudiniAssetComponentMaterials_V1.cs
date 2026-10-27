using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020014A5 RID: 5285
	[UnrealObjectPath("/Script/HoudiniEngineRuntime.HoudiniAssetComponentMaterials_V1")]
	[UnrealStructLayout(208, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 208)]
	public class UHoudiniAssetComponentMaterials_V1 : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060132BF RID: 78527 RVA: 0x001C320B File Offset: 0x001C140B
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UHoudiniAssetComponentMaterials_V1._ClassPtr;
		}

		// Token: 0x060132C0 RID: 78528 RVA: 0x001C3218 File Offset: 0x001C1418
		public UHoudiniAssetComponentMaterials_V1() : this(BuiltinUtils.AllocNativeUObject(UHoudiniAssetComponentMaterials_V1.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060132C1 RID: 78529 RVA: 0x001C3240 File Offset: 0x001C1440
		[NullableContext(1)]
		public UHoudiniAssetComponentMaterials_V1(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UHoudiniAssetComponentMaterials_V1.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060132C2 RID: 78530 RVA: 0x001C3273 File Offset: 0x001C1473
		static UHoudiniAssetComponentMaterials_V1()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/HoudiniEngineRuntime.HoudiniAssetComponentMaterials_V1");
		}

		// Token: 0x060132C3 RID: 78531 RVA: 0x001C3281 File Offset: 0x001C1481
		protected UHoudiniAssetComponentMaterials_V1(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400A5A1 RID: 42401
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/HoudiniEngineRuntime.HoudiniAssetComponentMaterials_V1";

		// Token: 0x0400A5A2 RID: 42402
		private static IntPtr _ClassPtr;

		// Token: 0x0400A5A3 RID: 42403
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
