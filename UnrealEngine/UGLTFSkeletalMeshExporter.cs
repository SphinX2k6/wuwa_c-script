using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001450 RID: 5200
	[UnrealObjectPath("/Script/GLTFExporter.GLTFSkeletalMeshExporter")]
	[UnrealStructLayout(128, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 128)]
	public class UGLTFSkeletalMeshExporter : UGLTFExporter, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601304E RID: 77902 RVA: 0x001BF603 File Offset: 0x001BD803
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UGLTFSkeletalMeshExporter._ClassPtr;
		}

		// Token: 0x0601304F RID: 77903 RVA: 0x001BF610 File Offset: 0x001BD810
		public UGLTFSkeletalMeshExporter() : this(BuiltinUtils.AllocNativeUObject(UGLTFSkeletalMeshExporter.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06013050 RID: 77904 RVA: 0x001BF638 File Offset: 0x001BD838
		[NullableContext(1)]
		public UGLTFSkeletalMeshExporter(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UGLTFSkeletalMeshExporter.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06013051 RID: 77905 RVA: 0x001BF66B File Offset: 0x001BD86B
		static UGLTFSkeletalMeshExporter()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/GLTFExporter.GLTFSkeletalMeshExporter");
		}

		// Token: 0x06013052 RID: 77906 RVA: 0x001BF679 File Offset: 0x001BD879
		protected UGLTFSkeletalMeshExporter(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400A2BF RID: 41663
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/GLTFExporter.GLTFSkeletalMeshExporter";

		// Token: 0x0400A2C0 RID: 41664
		private static IntPtr _ClassPtr;

		// Token: 0x0400A2C1 RID: 41665
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
