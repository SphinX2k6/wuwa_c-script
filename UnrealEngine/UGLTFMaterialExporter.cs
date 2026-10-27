using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200144C RID: 5196
	[UnrealObjectPath("/Script/GLTFExporter.GLTFMaterialExporter")]
	[UnrealStructLayout(136, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 136)]
	public class UGLTFMaterialExporter : UGLTFExporter, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06013018 RID: 77848 RVA: 0x001BF132 File Offset: 0x001BD332
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UGLTFMaterialExporter._ClassPtr;
		}

		// Token: 0x06013019 RID: 77849 RVA: 0x001BF140 File Offset: 0x001BD340
		public UGLTFMaterialExporter() : this(BuiltinUtils.AllocNativeUObject(UGLTFMaterialExporter.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601301A RID: 77850 RVA: 0x001BF168 File Offset: 0x001BD368
		[NullableContext(1)]
		public UGLTFMaterialExporter(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UGLTFMaterialExporter.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170049F1 RID: 18929
		// (get) Token: 0x0601301B RID: 77851 RVA: 0x001BF19B File Offset: 0x001BD39B
		// (set) Token: 0x0601301C RID: 77852 RVA: 0x001BF1AF File Offset: 0x001BD3AF
		[Nullable(2)]
		public unsafe UStaticMesh DefaultPreviewMesh
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMesh>(base.NativePtr / (IntPtr)sizeof(void*) + UGLTFMaterialExporter.__PropertyOffset_DefaultPreviewMesh);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UGLTFMaterialExporter.__PropertyOffset_DefaultPreviewMesh, value);
			}
		}

		// Token: 0x0601301D RID: 77853 RVA: 0x001BF1C4 File Offset: 0x001BD3C4
		static UGLTFMaterialExporter()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/GLTFExporter.GLTFMaterialExporter");
		}

		// Token: 0x0601301E RID: 77854 RVA: 0x001BF1D2 File Offset: 0x001BD3D2
		protected UGLTFMaterialExporter(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400A2A1 RID: 41633
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/GLTFExporter.GLTFMaterialExporter";

		// Token: 0x0400A2A2 RID: 41634
		private static IntPtr _ClassPtr;

		// Token: 0x0400A2A3 RID: 41635
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400A2A4 RID: 41636
		internal static int __PropertyOffset_DefaultPreviewMesh;
	}
}
