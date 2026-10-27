using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000519 RID: 1305
	[UnrealObjectPath("/Script/ControlRig.RigControlModifiedContext")]
	[UnrealStructLayout(20, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 20)]
	public class FRigControlModifiedContext : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06004463 RID: 17507 RVA: 0x00065EFE File Offset: 0x000640FE
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigControlModifiedContext._ScriptStructPtr != 0) ? FRigControlModifiedContext._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigControlModifiedContext", ref FRigControlModifiedContext._ScriptStructPtr);
		}

		// Token: 0x06004464 RID: 17508 RVA: 0x00065F22 File Offset: 0x00064122
		public FRigControlModifiedContext()
		{
		}

		// Token: 0x06004465 RID: 17509 RVA: 0x00065F2A File Offset: 0x0006412A
		protected override IntPtr GetUStructPtr()
		{
			return FRigControlModifiedContext.StaticStruct();
		}

		// Token: 0x06004466 RID: 17510 RVA: 0x00065F36 File Offset: 0x00064136
		[NullableContext(2)]
		public FRigControlModifiedContext(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06004467 RID: 17511 RVA: 0x00065F40 File Offset: 0x00064140
		public FRigControlModifiedContext(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06004468 RID: 17512 RVA: 0x00065F4B File Offset: 0x0006414B
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigControlModifiedContext(Pointer, false, true);
		}

		// Token: 0x06004469 RID: 17513 RVA: 0x00065F55 File Offset: 0x00064155
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigControlModifiedContext(Pointer, MemoryOwner);
		}

		// Token: 0x04002158 RID: 8536
		[Nullable(1)]
		public const string __ObjectPath = "/Script/ControlRig.RigControlModifiedContext";

		// Token: 0x04002159 RID: 8537
		private static IntPtr _ScriptStructPtr;
	}
}
