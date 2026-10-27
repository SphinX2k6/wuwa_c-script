using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200158A RID: 5514
	[UnrealObjectPath("/Script/InteractiveToolsFramework.MeshSurfacePointTool")]
	[UnrealStructLayout(232, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 232)]
	public class UMeshSurfacePointTool : USingleSelectionTool, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06013E7E RID: 81534 RVA: 0x001D3B02 File Offset: 0x001D1D02
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMeshSurfacePointTool._ClassPtr;
		}

		// Token: 0x06013E7F RID: 81535 RVA: 0x001D3B10 File Offset: 0x001D1D10
		public UMeshSurfacePointTool() : this(BuiltinUtils.AllocNativeUObject(UMeshSurfacePointTool.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06013E80 RID: 81536 RVA: 0x001D3B38 File Offset: 0x001D1D38
		[NullableContext(1)]
		public UMeshSurfacePointTool(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMeshSurfacePointTool.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004DED RID: 19949
		// (get) Token: 0x06013E81 RID: 81537 RVA: 0x001D3B6B File Offset: 0x001D1D6B
		// (set) Token: 0x06013E82 RID: 81538 RVA: 0x001D3B7F File Offset: 0x001D1D7F
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TWeakObjectPtr<UWorld> TargetWorld
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)UMeshSurfacePointTool.__PropertyOffset_TargetWorld);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UMeshSurfacePointTool.__PropertyOffset_TargetWorld) = value;
			}
		}

		// Token: 0x06013E83 RID: 81539 RVA: 0x001D3B94 File Offset: 0x001D1D94
		static UMeshSurfacePointTool()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/InteractiveToolsFramework.MeshSurfacePointTool");
		}

		// Token: 0x06013E84 RID: 81540 RVA: 0x001D3BA2 File Offset: 0x001D1DA2
		protected UMeshSurfacePointTool(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400AC60 RID: 44128
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/InteractiveToolsFramework.MeshSurfacePointTool";

		// Token: 0x0400AC61 RID: 44129
		private static IntPtr _ClassPtr;

		// Token: 0x0400AC62 RID: 44130
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400AC63 RID: 44131
		internal static int __PropertyOffset_TargetWorld;
	}
}
