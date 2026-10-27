using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200158B RID: 5515
	[UnrealObjectPath("/Script/InteractiveToolsFramework.MeshSurfacePointToolBuilder")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 56)]
	public class UMeshSurfacePointToolBuilder : UInteractiveToolBuilder, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06013E85 RID: 81541 RVA: 0x001D3BAB File Offset: 0x001D1DAB
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMeshSurfacePointToolBuilder._ClassPtr;
		}

		// Token: 0x06013E86 RID: 81542 RVA: 0x001D3BB8 File Offset: 0x001D1DB8
		public UMeshSurfacePointToolBuilder() : this(BuiltinUtils.AllocNativeUObject(UMeshSurfacePointToolBuilder.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06013E87 RID: 81543 RVA: 0x001D3BE0 File Offset: 0x001D1DE0
		[NullableContext(1)]
		public UMeshSurfacePointToolBuilder(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMeshSurfacePointToolBuilder.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06013E88 RID: 81544 RVA: 0x001D3C13 File Offset: 0x001D1E13
		static UMeshSurfacePointToolBuilder()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/InteractiveToolsFramework.MeshSurfacePointToolBuilder");
		}

		// Token: 0x06013E89 RID: 81545 RVA: 0x001D3C21 File Offset: 0x001D1E21
		protected UMeshSurfacePointToolBuilder(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400AC64 RID: 44132
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/InteractiveToolsFramework.MeshSurfacePointToolBuilder";

		// Token: 0x0400AC65 RID: 44133
		private static IntPtr _ClassPtr;

		// Token: 0x0400AC66 RID: 44134
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
