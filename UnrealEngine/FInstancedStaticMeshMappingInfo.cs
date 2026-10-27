using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000C66 RID: 3174
	[UnrealObjectPath("/Script/Engine.InstancedStaticMeshMappingInfo")]
	[UnrealStructLayout(8, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 8)]
	public class FInstancedStaticMeshMappingInfo : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600A178 RID: 41336 RVA: 0x000E568B File Offset: 0x000E388B
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FInstancedStaticMeshMappingInfo._ScriptStructPtr != 0) ? FInstancedStaticMeshMappingInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.InstancedStaticMeshMappingInfo", ref FInstancedStaticMeshMappingInfo._ScriptStructPtr);
		}

		// Token: 0x0600A179 RID: 41337 RVA: 0x000E56AF File Offset: 0x000E38AF
		public FInstancedStaticMeshMappingInfo()
		{
		}

		// Token: 0x0600A17A RID: 41338 RVA: 0x000E56B7 File Offset: 0x000E38B7
		protected override IntPtr GetUStructPtr()
		{
			return FInstancedStaticMeshMappingInfo.StaticStruct();
		}

		// Token: 0x0600A17B RID: 41339 RVA: 0x000E56C3 File Offset: 0x000E38C3
		[NullableContext(2)]
		public FInstancedStaticMeshMappingInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600A17C RID: 41340 RVA: 0x000E56CD File Offset: 0x000E38CD
		public FInstancedStaticMeshMappingInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600A17D RID: 41341 RVA: 0x000E56D8 File Offset: 0x000E38D8
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FInstancedStaticMeshMappingInfo(Pointer, false, true);
		}

		// Token: 0x0600A17E RID: 41342 RVA: 0x000E56E2 File Offset: 0x000E38E2
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FInstancedStaticMeshMappingInfo(Pointer, MemoryOwner);
		}

		// Token: 0x040058B1 RID: 22705
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.InstancedStaticMeshMappingInfo";

		// Token: 0x040058B2 RID: 22706
		private static IntPtr _ScriptStructPtr;
	}
}
