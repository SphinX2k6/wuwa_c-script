using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000302 RID: 770
	[UnrealObjectPath("/Script/AnimGraphRuntime.AnimNode_StateResult")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 64)]
	public class FAnimNode_StateResult : FAnimNode_Root, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06002C57 RID: 11351 RVA: 0x00043C64 File Offset: 0x00041E64
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAnimNode_StateResult._ScriptStructPtr != 0) ? FAnimNode_StateResult._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AnimGraphRuntime.AnimNode_StateResult", ref FAnimNode_StateResult._ScriptStructPtr);
		}

		// Token: 0x06002C58 RID: 11352 RVA: 0x00043C88 File Offset: 0x00041E88
		public FAnimNode_StateResult()
		{
		}

		// Token: 0x06002C59 RID: 11353 RVA: 0x00043C90 File Offset: 0x00041E90
		[NullableContext(1)]
		public FAnimNode_StateResult(FPoseLink Result, FName Name, FName Group)
		{
			base.Result = Result;
			base.Name = Name;
			base.Group = Group;
		}

		// Token: 0x06002C5A RID: 11354 RVA: 0x00043CAD File Offset: 0x00041EAD
		protected override IntPtr GetUStructPtr()
		{
			return FAnimNode_StateResult.StaticStruct();
		}

		// Token: 0x06002C5B RID: 11355 RVA: 0x00043CB9 File Offset: 0x00041EB9
		[NullableContext(2)]
		public FAnimNode_StateResult(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06002C5C RID: 11356 RVA: 0x00043CC3 File Offset: 0x00041EC3
		public FAnimNode_StateResult(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06002C5D RID: 11357 RVA: 0x00043CCE File Offset: 0x00041ECE
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAnimNode_StateResult(Pointer, false, true);
		}

		// Token: 0x06002C5E RID: 11358 RVA: 0x00043CD8 File Offset: 0x00041ED8
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAnimNode_StateResult(Pointer, MemoryOwner);
		}

		// Token: 0x0400122B RID: 4651
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AnimGraphRuntime.AnimNode_StateResult";

		// Token: 0x0400122C RID: 4652
		private static IntPtr _ScriptStructPtr;
	}
}
