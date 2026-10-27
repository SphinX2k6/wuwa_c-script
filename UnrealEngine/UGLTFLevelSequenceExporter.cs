using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200144A RID: 5194
	[UnrealObjectPath("/Script/GLTFExporter.GLTFLevelSequenceExporter")]
	[UnrealStructLayout(128, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 128)]
	public class UGLTFLevelSequenceExporter : UGLTFExporter, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601300E RID: 77838 RVA: 0x001BF032 File Offset: 0x001BD232
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UGLTFLevelSequenceExporter._ClassPtr;
		}

		// Token: 0x0601300F RID: 77839 RVA: 0x001BF040 File Offset: 0x001BD240
		public UGLTFLevelSequenceExporter() : this(BuiltinUtils.AllocNativeUObject(UGLTFLevelSequenceExporter.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06013010 RID: 77840 RVA: 0x001BF068 File Offset: 0x001BD268
		[NullableContext(1)]
		public UGLTFLevelSequenceExporter(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UGLTFLevelSequenceExporter.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06013011 RID: 77841 RVA: 0x001BF09B File Offset: 0x001BD29B
		static UGLTFLevelSequenceExporter()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/GLTFExporter.GLTFLevelSequenceExporter");
		}

		// Token: 0x06013012 RID: 77842 RVA: 0x001BF0A9 File Offset: 0x001BD2A9
		protected UGLTFLevelSequenceExporter(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400A29B RID: 41627
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/GLTFExporter.GLTFLevelSequenceExporter";

		// Token: 0x0400A29C RID: 41628
		private static IntPtr _ClassPtr;

		// Token: 0x0400A29D RID: 41629
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
