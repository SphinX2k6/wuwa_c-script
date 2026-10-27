using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001009 RID: 4105
	[UnrealObjectPath("/Script/Engine.PlatformStaticMeshConfig")]
	[UnrealStructLayout(216, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 216)]
	public class UPlatformStaticMeshConfig : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600DE36 RID: 56886 RVA: 0x00147A37 File Offset: 0x00145C37
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UPlatformStaticMeshConfig._ClassPtr;
		}

		// Token: 0x0600DE37 RID: 56887 RVA: 0x00147A44 File Offset: 0x00145C44
		public UPlatformStaticMeshConfig() : this(BuiltinUtils.AllocNativeUObject(UPlatformStaticMeshConfig.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600DE38 RID: 56888 RVA: 0x00147A6C File Offset: 0x00145C6C
		[NullableContext(1)]
		public UPlatformStaticMeshConfig(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UPlatformStaticMeshConfig.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600DE39 RID: 56889 RVA: 0x00147A9F File Offset: 0x00145C9F
		static UPlatformStaticMeshConfig()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.PlatformStaticMeshConfig");
		}

		// Token: 0x0600DE3A RID: 56890 RVA: 0x00147AAD File Offset: 0x00145CAD
		protected UPlatformStaticMeshConfig(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400780E RID: 30734
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.PlatformStaticMeshConfig";

		// Token: 0x0400780F RID: 30735
		private static IntPtr _ClassPtr;

		// Token: 0x04007810 RID: 30736
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
