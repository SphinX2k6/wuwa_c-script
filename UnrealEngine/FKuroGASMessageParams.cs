using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020018D3 RID: 6355
	[UnrealObjectPath("/Script/KuroGameplay.KuroGASMessageParams")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FKuroGASMessageParams : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060178CC RID: 96460 RVA: 0x0022798C File Offset: 0x00225B8C
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroGASMessageParams._ScriptStructPtr != 0) ? FKuroGASMessageParams._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroGameplay.KuroGASMessageParams", ref FKuroGASMessageParams._ScriptStructPtr);
		}

		// Token: 0x060178CD RID: 96461 RVA: 0x002279B0 File Offset: 0x00225BB0
		public FKuroGASMessageParams()
		{
		}

		// Token: 0x060178CE RID: 96462 RVA: 0x002279B8 File Offset: 0x00225BB8
		protected override IntPtr GetUStructPtr()
		{
			return FKuroGASMessageParams.StaticStruct();
		}

		// Token: 0x060178CF RID: 96463 RVA: 0x002279C4 File Offset: 0x00225BC4
		[NullableContext(2)]
		public FKuroGASMessageParams(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060178D0 RID: 96464 RVA: 0x002279CE File Offset: 0x00225BCE
		public FKuroGASMessageParams(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060178D1 RID: 96465 RVA: 0x002279D9 File Offset: 0x00225BD9
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroGASMessageParams(Pointer, false, true);
		}

		// Token: 0x060178D2 RID: 96466 RVA: 0x002279E3 File Offset: 0x00225BE3
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroGASMessageParams(Pointer, MemoryOwner);
		}

		// Token: 0x0400CC92 RID: 52370
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroGameplay.KuroGASMessageParams";

		// Token: 0x0400CC93 RID: 52371
		private static IntPtr _ScriptStructPtr;
	}
}
