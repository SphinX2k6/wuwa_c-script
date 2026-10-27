using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000521 RID: 1313
	[UnrealObjectPath("/Script/ControlRig.RigEventContext")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FRigEventContext : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060044D7 RID: 17623 RVA: 0x00066782 File Offset: 0x00064982
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigEventContext._ScriptStructPtr != 0) ? FRigEventContext._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigEventContext", ref FRigEventContext._ScriptStructPtr);
		}

		// Token: 0x060044D8 RID: 17624 RVA: 0x000667A6 File Offset: 0x000649A6
		public FRigEventContext()
		{
		}

		// Token: 0x060044D9 RID: 17625 RVA: 0x000667AE File Offset: 0x000649AE
		protected override IntPtr GetUStructPtr()
		{
			return FRigEventContext.StaticStruct();
		}

		// Token: 0x060044DA RID: 17626 RVA: 0x000667BA File Offset: 0x000649BA
		[NullableContext(2)]
		public FRigEventContext(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060044DB RID: 17627 RVA: 0x000667C4 File Offset: 0x000649C4
		public FRigEventContext(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060044DC RID: 17628 RVA: 0x000667CF File Offset: 0x000649CF
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigEventContext(Pointer, false, true);
		}

		// Token: 0x060044DD RID: 17629 RVA: 0x000667D9 File Offset: 0x000649D9
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigEventContext(Pointer, MemoryOwner);
		}

		// Token: 0x04002187 RID: 8583
		[Nullable(1)]
		public const string __ObjectPath = "/Script/ControlRig.RigEventContext";

		// Token: 0x04002188 RID: 8584
		private static IntPtr _ScriptStructPtr;
	}
}
