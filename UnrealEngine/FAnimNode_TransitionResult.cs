using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000823 RID: 2083
	[UnrealObjectPath("/Script/Engine.AnimNode_TransitionResult")]
	[UnrealStructLayout(40, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 40)]
	public class FAnimNode_TransitionResult : FAnimNode_Base, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06007010 RID: 28688 RVA: 0x000A0C96 File Offset: 0x0009EE96
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAnimNode_TransitionResult._ScriptStructPtr != 0) ? FAnimNode_TransitionResult._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.AnimNode_TransitionResult", ref FAnimNode_TransitionResult._ScriptStructPtr);
		}

		// Token: 0x17001A5E RID: 6750
		// (get) Token: 0x06007011 RID: 28689 RVA: 0x000A0CBA File Offset: 0x0009EEBA
		// (set) Token: 0x06007012 RID: 28690 RVA: 0x000A0CCA File Offset: 0x0009EECA
		public unsafe bool bCanEnterTransition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_TransitionResult.__PropertyOffset_bCanEnterTransition) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_TransitionResult.__PropertyOffset_bCanEnterTransition) = (value ? 1 : 0);
			}
		}

		// Token: 0x06007013 RID: 28691 RVA: 0x000A0CDB File Offset: 0x0009EEDB
		public FAnimNode_TransitionResult()
		{
		}

		// Token: 0x06007014 RID: 28692 RVA: 0x000A0CE3 File Offset: 0x0009EEE3
		public FAnimNode_TransitionResult(bool bCanEnterTransition)
		{
			this.bCanEnterTransition = bCanEnterTransition;
		}

		// Token: 0x06007015 RID: 28693 RVA: 0x000A0CF2 File Offset: 0x0009EEF2
		protected override IntPtr GetUStructPtr()
		{
			return FAnimNode_TransitionResult.StaticStruct();
		}

		// Token: 0x06007016 RID: 28694 RVA: 0x000A0CFE File Offset: 0x0009EEFE
		[NullableContext(2)]
		public FAnimNode_TransitionResult(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06007017 RID: 28695 RVA: 0x000A0D08 File Offset: 0x0009EF08
		public FAnimNode_TransitionResult(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06007018 RID: 28696 RVA: 0x000A0D13 File Offset: 0x0009EF13
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAnimNode_TransitionResult(Pointer, false, true);
		}

		// Token: 0x06007019 RID: 28697 RVA: 0x000A0D1D File Offset: 0x0009EF1D
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAnimNode_TransitionResult(Pointer, MemoryOwner);
		}

		// Token: 0x040035D4 RID: 13780
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.AnimNode_TransitionResult";

		// Token: 0x040035D5 RID: 13781
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040035D6 RID: 13782
		internal static int __PropertyOffset_bCanEnterTransition;
	}
}
