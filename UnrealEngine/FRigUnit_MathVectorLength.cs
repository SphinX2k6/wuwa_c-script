using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000677 RID: 1655
	[UnrealObjectPath("/Script/ControlRig.RigUnit_MathVectorLength")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FRigUnit_MathVectorLength : FRigUnit_MathVectorBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06005825 RID: 22565 RVA: 0x0007F1F3 File Offset: 0x0007D3F3
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_MathVectorLength._ScriptStructPtr != 0) ? FRigUnit_MathVectorLength._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_MathVectorLength", ref FRigUnit_MathVectorLength._ScriptStructPtr);
		}

		// Token: 0x17001513 RID: 5395
		// (get) Token: 0x06005826 RID: 22566 RVA: 0x0007F217 File Offset: 0x0007D417
		// (set) Token: 0x06005827 RID: 22567 RVA: 0x0007F22B File Offset: 0x0007D42B
		public unsafe FVector Value
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathVectorLength.__PropertyOffset_Value);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathVectorLength.__PropertyOffset_Value) = value;
			}
		}

		// Token: 0x17001514 RID: 5396
		// (get) Token: 0x06005828 RID: 22568 RVA: 0x0007F240 File Offset: 0x0007D440
		// (set) Token: 0x06005829 RID: 22569 RVA: 0x0007F250 File Offset: 0x0007D450
		public unsafe float Result
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathVectorLength.__PropertyOffset_Result);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathVectorLength.__PropertyOffset_Result) = value;
			}
		}

		// Token: 0x0600582A RID: 22570 RVA: 0x0007F261 File Offset: 0x0007D461
		public FRigUnit_MathVectorLength()
		{
		}

		// Token: 0x0600582B RID: 22571 RVA: 0x0007F269 File Offset: 0x0007D469
		public FRigUnit_MathVectorLength(FVector Value, float Result)
		{
			this.Value = Value;
			this.Result = Result;
		}

		// Token: 0x0600582C RID: 22572 RVA: 0x0007F27F File Offset: 0x0007D47F
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_MathVectorLength.StaticStruct();
		}

		// Token: 0x0600582D RID: 22573 RVA: 0x0007F28B File Offset: 0x0007D48B
		[NullableContext(2)]
		public FRigUnit_MathVectorLength(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600582E RID: 22574 RVA: 0x0007F295 File Offset: 0x0007D495
		public FRigUnit_MathVectorLength(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600582F RID: 22575 RVA: 0x0007F2A0 File Offset: 0x0007D4A0
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_MathVectorLength(Pointer, false, true);
		}

		// Token: 0x06005830 RID: 22576 RVA: 0x0007F2AA File Offset: 0x0007D4AA
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_MathVectorLength(Pointer, MemoryOwner);
		}

		// Token: 0x04002979 RID: 10617
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_MathVectorLength";

		// Token: 0x0400297A RID: 10618
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400297B RID: 10619
		internal static int __PropertyOffset_Value;

		// Token: 0x0400297C RID: 10620
		internal static int __PropertyOffset_Result;
	}
}
