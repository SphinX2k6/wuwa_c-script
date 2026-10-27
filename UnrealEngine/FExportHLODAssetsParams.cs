using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000BC9 RID: 3017
	[UnrealObjectPath("/Script/Engine.ExportHLODAssetsParams")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FExportHLODAssetsParams : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06009454 RID: 37972 RVA: 0x000D3CF9 File Offset: 0x000D1EF9
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FExportHLODAssetsParams._ScriptStructPtr != 0) ? FExportHLODAssetsParams._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.ExportHLODAssetsParams", ref FExportHLODAssetsParams._ScriptStructPtr);
		}

		// Token: 0x06009455 RID: 37973 RVA: 0x000D3D1D File Offset: 0x000D1F1D
		public FExportHLODAssetsParams()
		{
		}

		// Token: 0x06009456 RID: 37974 RVA: 0x000D3D25 File Offset: 0x000D1F25
		[NullableContext(1)]
		public FExportHLODAssetsParams(EExportHLODMeshOrigin MeshOrigin, FDirectoryPath ExportRootPath)
		{
		}

		// Token: 0x06009457 RID: 37975 RVA: 0x000D3D2D File Offset: 0x000D1F2D
		protected override IntPtr GetUStructPtr()
		{
			return FExportHLODAssetsParams.StaticStruct();
		}

		// Token: 0x06009458 RID: 37976 RVA: 0x000D3D39 File Offset: 0x000D1F39
		[NullableContext(2)]
		public FExportHLODAssetsParams(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06009459 RID: 37977 RVA: 0x000D3D43 File Offset: 0x000D1F43
		public FExportHLODAssetsParams(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600945A RID: 37978 RVA: 0x000D3D4E File Offset: 0x000D1F4E
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FExportHLODAssetsParams(Pointer, false, true);
		}

		// Token: 0x0600945B RID: 37979 RVA: 0x000D3D58 File Offset: 0x000D1F58
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FExportHLODAssetsParams(Pointer, MemoryOwner);
		}

		// Token: 0x04005361 RID: 21345
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.ExportHLODAssetsParams";

		// Token: 0x04005362 RID: 21346
		private static IntPtr _ScriptStructPtr;
	}
}
