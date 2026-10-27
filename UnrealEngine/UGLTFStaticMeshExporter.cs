using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001451 RID: 5201
	[UnrealObjectPath("/Script/GLTFExporter.GLTFStaticMeshExporter")]
	[UnrealStructLayout(128, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 128)]
	public class UGLTFStaticMeshExporter : UGLTFExporter, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06013053 RID: 77907 RVA: 0x001BF682 File Offset: 0x001BD882
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UGLTFStaticMeshExporter._ClassPtr;
		}

		// Token: 0x06013054 RID: 77908 RVA: 0x001BF690 File Offset: 0x001BD890
		public UGLTFStaticMeshExporter() : this(BuiltinUtils.AllocNativeUObject(UGLTFStaticMeshExporter.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06013055 RID: 77909 RVA: 0x001BF6B8 File Offset: 0x001BD8B8
		[NullableContext(1)]
		public UGLTFStaticMeshExporter(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UGLTFStaticMeshExporter.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06013056 RID: 77910 RVA: 0x001BF6EB File Offset: 0x001BD8EB
		static UGLTFStaticMeshExporter()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/GLTFExporter.GLTFStaticMeshExporter");
		}

		// Token: 0x06013057 RID: 77911 RVA: 0x001BF6F9 File Offset: 0x001BD8F9
		protected UGLTFStaticMeshExporter(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400A2C2 RID: 41666
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/GLTFExporter.GLTFStaticMeshExporter";

		// Token: 0x0400A2C3 RID: 41667
		private static IntPtr _ClassPtr;

		// Token: 0x0400A2C4 RID: 41668
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
