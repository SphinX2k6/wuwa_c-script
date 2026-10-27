using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001443 RID: 5187
	[UnrealObjectPath("/Script/GLTFExporter.GLTFAnimSequenceExporter")]
	[UnrealStructLayout(128, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 128)]
	public class UGLTFAnimSequenceExporter : UGLTFExporter, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06012F53 RID: 77651 RVA: 0x001BDF38 File Offset: 0x001BC138
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UGLTFAnimSequenceExporter._ClassPtr;
		}

		// Token: 0x06012F54 RID: 77652 RVA: 0x001BDF44 File Offset: 0x001BC144
		public UGLTFAnimSequenceExporter() : this(BuiltinUtils.AllocNativeUObject(UGLTFAnimSequenceExporter.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06012F55 RID: 77653 RVA: 0x001BDF6C File Offset: 0x001BC16C
		[NullableContext(1)]
		public UGLTFAnimSequenceExporter(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UGLTFAnimSequenceExporter.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06012F56 RID: 77654 RVA: 0x001BDF9F File Offset: 0x001BC19F
		static UGLTFAnimSequenceExporter()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/GLTFExporter.GLTFAnimSequenceExporter");
		}

		// Token: 0x06012F57 RID: 77655 RVA: 0x001BDFAD File Offset: 0x001BC1AD
		protected UGLTFAnimSequenceExporter(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400A234 RID: 41524
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/GLTFExporter.GLTFAnimSequenceExporter";

		// Token: 0x0400A235 RID: 41525
		private static IntPtr _ClassPtr;

		// Token: 0x0400A236 RID: 41526
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
