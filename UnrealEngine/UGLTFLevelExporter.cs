using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001449 RID: 5193
	[UnrealObjectPath("/Script/GLTFExporter.GLTFLevelExporter")]
	[UnrealStructLayout(128, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 128)]
	public class UGLTFLevelExporter : UGLTFExporter, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06013009 RID: 77833 RVA: 0x001BEFB1 File Offset: 0x001BD1B1
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UGLTFLevelExporter._ClassPtr;
		}

		// Token: 0x0601300A RID: 77834 RVA: 0x001BEFC0 File Offset: 0x001BD1C0
		public UGLTFLevelExporter() : this(BuiltinUtils.AllocNativeUObject(UGLTFLevelExporter.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601300B RID: 77835 RVA: 0x001BEFE8 File Offset: 0x001BD1E8
		[NullableContext(1)]
		public UGLTFLevelExporter(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UGLTFLevelExporter.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601300C RID: 77836 RVA: 0x001BF01B File Offset: 0x001BD21B
		static UGLTFLevelExporter()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/GLTFExporter.GLTFLevelExporter");
		}

		// Token: 0x0601300D RID: 77837 RVA: 0x001BF029 File Offset: 0x001BD229
		protected UGLTFLevelExporter(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400A298 RID: 41624
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/GLTFExporter.GLTFLevelExporter";

		// Token: 0x0400A299 RID: 41625
		private static IntPtr _ClassPtr;

		// Token: 0x0400A29A RID: 41626
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
