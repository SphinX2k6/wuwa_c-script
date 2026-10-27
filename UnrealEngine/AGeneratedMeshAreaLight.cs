using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000C08 RID: 3080
	[UnrealObjectPath("/Script/Engine.GeneratedMeshAreaLight")]
	[UnrealStructLayout(1072, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1072)]
	public class AGeneratedMeshAreaLight : ASpotLight, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06009B36 RID: 39734 RVA: 0x000DC8F4 File Offset: 0x000DAAF4
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AGeneratedMeshAreaLight._ClassPtr;
		}

		// Token: 0x06009B37 RID: 39735 RVA: 0x000DC900 File Offset: 0x000DAB00
		public AGeneratedMeshAreaLight() : this(BuiltinUtils.AllocNativeUObject(AGeneratedMeshAreaLight.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06009B38 RID: 39736 RVA: 0x000DC928 File Offset: 0x000DAB28
		[NullableContext(1)]
		public AGeneratedMeshAreaLight(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AGeneratedMeshAreaLight.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06009B39 RID: 39737 RVA: 0x000DC95B File Offset: 0x000DAB5B
		static AGeneratedMeshAreaLight()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.GeneratedMeshAreaLight");
		}

		// Token: 0x06009B3A RID: 39738 RVA: 0x000DC969 File Offset: 0x000DAB69
		protected AGeneratedMeshAreaLight(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040055AF RID: 21935
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.GeneratedMeshAreaLight";

		// Token: 0x040055B0 RID: 21936
		private static IntPtr _ClassPtr;

		// Token: 0x040055B1 RID: 21937
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
