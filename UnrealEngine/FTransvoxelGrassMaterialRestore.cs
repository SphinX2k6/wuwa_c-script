using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020026A2 RID: 9890
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Renderer.TransvoxelGrassMaterialRestore")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FTransvoxelGrassMaterialRestore : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06024C87 RID: 150663 RVA: 0x00366E54 File Offset: 0x00365054
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FTransvoxelGrassMaterialRestore._ScriptStructPtr != 0) ? FTransvoxelGrassMaterialRestore._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Renderer.TransvoxelGrassMaterialRestore", ref FTransvoxelGrassMaterialRestore._ScriptStructPtr);
		}

		// Token: 0x17008E20 RID: 36384
		// (get) Token: 0x06024C88 RID: 150664 RVA: 0x00366E78 File Offset: 0x00365078
		// (set) Token: 0x06024C89 RID: 150665 RVA: 0x00366E8C File Offset: 0x0036508C
		public unsafe UMeshComponent Component
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + FTransvoxelGrassMaterialRestore.__PropertyOffset_Component);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FTransvoxelGrassMaterialRestore.__PropertyOffset_Component, value);
			}
		}

		// Token: 0x17008E21 RID: 36385
		// (get) Token: 0x06024C8A RID: 150666 RVA: 0x00366EA1 File Offset: 0x003650A1
		// (set) Token: 0x06024C8B RID: 150667 RVA: 0x00366EB5 File Offset: 0x003650B5
		public unsafe UMaterialInterface OriginalMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + FTransvoxelGrassMaterialRestore.__PropertyOffset_OriginalMaterial);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FTransvoxelGrassMaterialRestore.__PropertyOffset_OriginalMaterial, value);
			}
		}

		// Token: 0x06024C8C RID: 150668 RVA: 0x00366ECA File Offset: 0x003650CA
		public FTransvoxelGrassMaterialRestore()
		{
		}

		// Token: 0x06024C8D RID: 150669 RVA: 0x00366ED2 File Offset: 0x003650D2
		[NullableContext(1)]
		public FTransvoxelGrassMaterialRestore(UMeshComponent Component, UMaterialInterface OriginalMaterial)
		{
			this.Component = Component;
			this.OriginalMaterial = OriginalMaterial;
		}

		// Token: 0x06024C8E RID: 150670 RVA: 0x00366EE8 File Offset: 0x003650E8
		protected override IntPtr GetUStructPtr()
		{
			return FTransvoxelGrassMaterialRestore.StaticStruct();
		}

		// Token: 0x06024C8F RID: 150671 RVA: 0x00366EF4 File Offset: 0x003650F4
		public FTransvoxelGrassMaterialRestore(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06024C90 RID: 150672 RVA: 0x00366EFE File Offset: 0x003650FE
		public FTransvoxelGrassMaterialRestore(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06024C91 RID: 150673 RVA: 0x00366F09 File Offset: 0x00365109
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FTransvoxelGrassMaterialRestore(Pointer, false, true);
		}

		// Token: 0x06024C92 RID: 150674 RVA: 0x00366F13 File Offset: 0x00365113
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FTransvoxelGrassMaterialRestore(Pointer, MemoryOwner);
		}

		// Token: 0x04013C5B RID: 80987
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Renderer.TransvoxelGrassMaterialRestore";

		// Token: 0x04013C5C RID: 80988
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04013C5D RID: 80989
		internal static int __PropertyOffset_Component;

		// Token: 0x04013C5E RID: 80990
		internal static int __PropertyOffset_OriginalMaterial;
	}
}
