using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200180F RID: 6159
	[UnrealObjectPath("/Script/KuroDynamicMeshBatch.PendingRemoval")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FPendingRemoval : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06016C9D RID: 93341 RVA: 0x002140FF File Offset: 0x002122FF
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FPendingRemoval._ScriptStructPtr != 0) ? FPendingRemoval._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroDynamicMeshBatch.PendingRemoval", ref FPendingRemoval._ScriptStructPtr);
		}

		// Token: 0x06016C9E RID: 93342 RVA: 0x00214123 File Offset: 0x00212323
		public FPendingRemoval()
		{
		}

		// Token: 0x06016C9F RID: 93343 RVA: 0x0021412B File Offset: 0x0021232B
		protected override IntPtr GetUStructPtr()
		{
			return FPendingRemoval.StaticStruct();
		}

		// Token: 0x06016CA0 RID: 93344 RVA: 0x00214137 File Offset: 0x00212337
		[NullableContext(2)]
		public FPendingRemoval(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06016CA1 RID: 93345 RVA: 0x00214141 File Offset: 0x00212341
		public FPendingRemoval(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06016CA2 RID: 93346 RVA: 0x0021414C File Offset: 0x0021234C
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FPendingRemoval(Pointer, false, true);
		}

		// Token: 0x06016CA3 RID: 93347 RVA: 0x00214156 File Offset: 0x00212356
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FPendingRemoval(Pointer, MemoryOwner);
		}

		// Token: 0x0400C5D2 RID: 50642
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroDynamicMeshBatch.PendingRemoval";

		// Token: 0x0400C5D3 RID: 50643
		private static IntPtr _ScriptStructPtr;
	}
}
