using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020007EA RID: 2026
	[UnrealObjectPath("/Script/Engine.AnimationTransitionRule")]
	[UnrealStructLayout(20, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 20)]
	public class FAnimationTransitionRule : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06006C17 RID: 27671 RVA: 0x0009B770 File Offset: 0x00099970
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAnimationTransitionRule._ScriptStructPtr != 0) ? FAnimationTransitionRule._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.AnimationTransitionRule", ref FAnimationTransitionRule._ScriptStructPtr);
		}

		// Token: 0x17001979 RID: 6521
		// (get) Token: 0x06006C18 RID: 27672 RVA: 0x0009B794 File Offset: 0x00099994
		// (set) Token: 0x06006C19 RID: 27673 RVA: 0x0009B7A8 File Offset: 0x000999A8
		public unsafe FName RuleToExecute
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimationTransitionRule.__PropertyOffset_RuleToExecute);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimationTransitionRule.__PropertyOffset_RuleToExecute) = value;
			}
		}

		// Token: 0x1700197A RID: 6522
		// (get) Token: 0x06006C1A RID: 27674 RVA: 0x0009B7BD File Offset: 0x000999BD
		// (set) Token: 0x06006C1B RID: 27675 RVA: 0x0009B7CD File Offset: 0x000999CD
		public unsafe bool TransitionReturnVal
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimationTransitionRule.__PropertyOffset_TransitionReturnVal) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimationTransitionRule.__PropertyOffset_TransitionReturnVal) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700197B RID: 6523
		// (get) Token: 0x06006C1C RID: 27676 RVA: 0x0009B7DE File Offset: 0x000999DE
		// (set) Token: 0x06006C1D RID: 27677 RVA: 0x0009B7EE File Offset: 0x000999EE
		public unsafe int TransitionIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimationTransitionRule.__PropertyOffset_TransitionIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimationTransitionRule.__PropertyOffset_TransitionIndex) = value;
			}
		}

		// Token: 0x06006C1E RID: 27678 RVA: 0x0009B7FF File Offset: 0x000999FF
		public FAnimationTransitionRule()
		{
		}

		// Token: 0x06006C1F RID: 27679 RVA: 0x0009B807 File Offset: 0x00099A07
		public FAnimationTransitionRule(FName RuleToExecute, bool TransitionReturnVal, int TransitionIndex)
		{
			this.RuleToExecute = RuleToExecute;
			this.TransitionReturnVal = TransitionReturnVal;
			this.TransitionIndex = TransitionIndex;
		}

		// Token: 0x06006C20 RID: 27680 RVA: 0x0009B824 File Offset: 0x00099A24
		protected override IntPtr GetUStructPtr()
		{
			return FAnimationTransitionRule.StaticStruct();
		}

		// Token: 0x06006C21 RID: 27681 RVA: 0x0009B830 File Offset: 0x00099A30
		[NullableContext(2)]
		public FAnimationTransitionRule(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06006C22 RID: 27682 RVA: 0x0009B83A File Offset: 0x00099A3A
		public FAnimationTransitionRule(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06006C23 RID: 27683 RVA: 0x0009B845 File Offset: 0x00099A45
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAnimationTransitionRule(Pointer, false, true);
		}

		// Token: 0x06006C24 RID: 27684 RVA: 0x0009B84F File Offset: 0x00099A4F
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAnimationTransitionRule(Pointer, MemoryOwner);
		}

		// Token: 0x04003403 RID: 13315
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.AnimationTransitionRule";

		// Token: 0x04003404 RID: 13316
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04003405 RID: 13317
		internal static int __PropertyOffset_RuleToExecute;

		// Token: 0x04003406 RID: 13318
		internal static int __PropertyOffset_TransitionReturnVal;

		// Token: 0x04003407 RID: 13319
		internal static int __PropertyOffset_TransitionIndex;
	}
}
