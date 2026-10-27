using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002697 RID: 9879
	[UnrealObjectPath("/Script/Renderer.SparseVolumeTextureViewer")]
	[UnrealStructLayout(1056, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1056)]
	public class ASparseVolumeTextureViewer : AInfo, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06024ADD RID: 150237 RVA: 0x00364D0F File Offset: 0x00362F0F
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ASparseVolumeTextureViewer._ClassPtr;
		}

		// Token: 0x06024ADE RID: 150238 RVA: 0x00364D1C File Offset: 0x00362F1C
		public ASparseVolumeTextureViewer() : this(BuiltinUtils.AllocNativeUObject(ASparseVolumeTextureViewer.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06024ADF RID: 150239 RVA: 0x00364D44 File Offset: 0x00362F44
		[NullableContext(1)]
		public ASparseVolumeTextureViewer(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ASparseVolumeTextureViewer.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17008D79 RID: 36217
		// (get) Token: 0x06024AE0 RID: 150240 RVA: 0x00364D77 File Offset: 0x00362F77
		// (set) Token: 0x06024AE1 RID: 150241 RVA: 0x00364D8B File Offset: 0x00362F8B
		[Nullable(2)]
		public unsafe USparseVolumeTextureViewerComponent SparseVolumeTextureViewerComponent
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USparseVolumeTextureViewerComponent>(base.NativePtr / (IntPtr)sizeof(void*) + ASparseVolumeTextureViewer.__PropertyOffset_SparseVolumeTextureViewerComponent);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ASparseVolumeTextureViewer.__PropertyOffset_SparseVolumeTextureViewerComponent, value);
			}
		}

		// Token: 0x06024AE2 RID: 150242 RVA: 0x00364DA0 File Offset: 0x00362FA0
		static ASparseVolumeTextureViewer()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Renderer.SparseVolumeTextureViewer");
		}

		// Token: 0x06024AE3 RID: 150243 RVA: 0x00364DAE File Offset: 0x00362FAE
		protected ASparseVolumeTextureViewer(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04013B82 RID: 80770
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Renderer.SparseVolumeTextureViewer";

		// Token: 0x04013B83 RID: 80771
		private static IntPtr _ClassPtr;

		// Token: 0x04013B84 RID: 80772
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04013B85 RID: 80773
		internal static int __PropertyOffset_SparseVolumeTextureViewerComponent;
	}
}
