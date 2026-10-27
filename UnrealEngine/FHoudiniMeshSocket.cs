using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020014E1 RID: 5345
	[UnrealObjectPath("/Script/HoudiniEngineRuntime.HoudiniMeshSocket")]
	[UnrealStructLayout(96, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 96)]
	public class FHoudiniMeshSocket : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060135AA RID: 79274 RVA: 0x001C75B2 File Offset: 0x001C57B2
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FHoudiniMeshSocket._ScriptStructPtr != 0) ? FHoudiniMeshSocket._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/HoudiniEngineRuntime.HoudiniMeshSocket", ref FHoudiniMeshSocket._ScriptStructPtr);
		}

		// Token: 0x060135AB RID: 79275 RVA: 0x001C75D6 File Offset: 0x001C57D6
		public FHoudiniMeshSocket()
		{
		}

		// Token: 0x060135AC RID: 79276 RVA: 0x001C75DE File Offset: 0x001C57DE
		protected override IntPtr GetUStructPtr()
		{
			return FHoudiniMeshSocket.StaticStruct();
		}

		// Token: 0x060135AD RID: 79277 RVA: 0x001C75EA File Offset: 0x001C57EA
		[NullableContext(2)]
		public FHoudiniMeshSocket(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060135AE RID: 79278 RVA: 0x001C75F4 File Offset: 0x001C57F4
		public FHoudiniMeshSocket(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060135AF RID: 79279 RVA: 0x001C75FF File Offset: 0x001C57FF
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FHoudiniMeshSocket(Pointer, false, true);
		}

		// Token: 0x060135B0 RID: 79280 RVA: 0x001C7609 File Offset: 0x001C5809
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FHoudiniMeshSocket(Pointer, MemoryOwner);
		}

		// Token: 0x0400A74B RID: 42827
		[Nullable(1)]
		public const string __ObjectPath = "/Script/HoudiniEngineRuntime.HoudiniMeshSocket";

		// Token: 0x0400A74C RID: 42828
		private static IntPtr _ScriptStructPtr;
	}
}
