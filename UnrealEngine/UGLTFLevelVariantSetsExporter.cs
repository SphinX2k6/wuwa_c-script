using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200144B RID: 5195
	[UnrealObjectPath("/Script/GLTFExporter.GLTFLevelVariantSetsExporter")]
	[UnrealStructLayout(128, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 128)]
	public class UGLTFLevelVariantSetsExporter : UGLTFExporter, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06013013 RID: 77843 RVA: 0x001BF0B2 File Offset: 0x001BD2B2
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UGLTFLevelVariantSetsExporter._ClassPtr;
		}

		// Token: 0x06013014 RID: 77844 RVA: 0x001BF0C0 File Offset: 0x001BD2C0
		public UGLTFLevelVariantSetsExporter() : this(BuiltinUtils.AllocNativeUObject(UGLTFLevelVariantSetsExporter.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06013015 RID: 77845 RVA: 0x001BF0E8 File Offset: 0x001BD2E8
		[NullableContext(1)]
		public UGLTFLevelVariantSetsExporter(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UGLTFLevelVariantSetsExporter.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06013016 RID: 77846 RVA: 0x001BF11B File Offset: 0x001BD31B
		static UGLTFLevelVariantSetsExporter()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/GLTFExporter.GLTFLevelVariantSetsExporter");
		}

		// Token: 0x06013017 RID: 77847 RVA: 0x001BF129 File Offset: 0x001BD329
		protected UGLTFLevelVariantSetsExporter(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400A29E RID: 41630
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/GLTFExporter.GLTFLevelVariantSetsExporter";

		// Token: 0x0400A29F RID: 41631
		private static IntPtr _ClassPtr;

		// Token: 0x0400A2A0 RID: 41632
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
