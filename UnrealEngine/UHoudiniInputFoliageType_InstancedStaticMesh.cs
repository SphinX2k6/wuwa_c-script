using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020014CE RID: 5326
	[UnrealObjectPath("/Script/HoudiniEngineRuntime.HoudiniInputFoliageType_InstancedStaticMesh")]
	[UnrealStructLayout(256, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 256)]
	public class UHoudiniInputFoliageType_InstancedStaticMesh : UHoudiniInputStaticMesh, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060134EC RID: 79084 RVA: 0x001C63B2 File Offset: 0x001C45B2
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UHoudiniInputFoliageType_InstancedStaticMesh._ClassPtr;
		}

		// Token: 0x060134ED RID: 79085 RVA: 0x001C63C0 File Offset: 0x001C45C0
		public UHoudiniInputFoliageType_InstancedStaticMesh() : this(BuiltinUtils.AllocNativeUObject(UHoudiniInputFoliageType_InstancedStaticMesh.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060134EE RID: 79086 RVA: 0x001C63E8 File Offset: 0x001C45E8
		[NullableContext(1)]
		public UHoudiniInputFoliageType_InstancedStaticMesh(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UHoudiniInputFoliageType_InstancedStaticMesh.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060134EF RID: 79087 RVA: 0x001C641B File Offset: 0x001C461B
		static UHoudiniInputFoliageType_InstancedStaticMesh()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/HoudiniEngineRuntime.HoudiniInputFoliageType_InstancedStaticMesh");
		}

		// Token: 0x060134F0 RID: 79088 RVA: 0x001C6429 File Offset: 0x001C4629
		protected UHoudiniInputFoliageType_InstancedStaticMesh(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400A6DC RID: 42716
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/HoudiniEngineRuntime.HoudiniInputFoliageType_InstancedStaticMesh";

		// Token: 0x0400A6DD RID: 42717
		private static IntPtr _ClassPtr;

		// Token: 0x0400A6DE RID: 42718
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
