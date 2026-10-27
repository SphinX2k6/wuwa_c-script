using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200063D RID: 1597
	[UnrealObjectPath("/Script/ControlRig.RigUnit_MathQuaternionSelectBool")]
	[UnrealStructLayout(64, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 64)]
	public class FRigUnit_MathQuaternionSelectBool : FRigUnit_MathQuaternionBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06005536 RID: 21814 RVA: 0x0007B9EF File Offset: 0x00079BEF
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_MathQuaternionSelectBool._ScriptStructPtr != 0) ? FRigUnit_MathQuaternionSelectBool._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_MathQuaternionSelectBool", ref FRigUnit_MathQuaternionSelectBool._ScriptStructPtr);
		}

		// Token: 0x17001481 RID: 5249
		// (get) Token: 0x06005537 RID: 21815 RVA: 0x0007BA13 File Offset: 0x00079C13
		// (set) Token: 0x06005538 RID: 21816 RVA: 0x0007BA23 File Offset: 0x00079C23
		public unsafe bool Condition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathQuaternionSelectBool.__PropertyOffset_Condition) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathQuaternionSelectBool.__PropertyOffset_Condition) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001482 RID: 5250
		// (get) Token: 0x06005539 RID: 21817 RVA: 0x0007BA34 File Offset: 0x00079C34
		// (set) Token: 0x0600553A RID: 21818 RVA: 0x0007BA48 File Offset: 0x00079C48
		public unsafe FQuat IfTrue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathQuaternionSelectBool.__PropertyOffset_IfTrue);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathQuaternionSelectBool.__PropertyOffset_IfTrue) = value;
			}
		}

		// Token: 0x17001483 RID: 5251
		// (get) Token: 0x0600553B RID: 21819 RVA: 0x0007BA5D File Offset: 0x00079C5D
		// (set) Token: 0x0600553C RID: 21820 RVA: 0x0007BA71 File Offset: 0x00079C71
		public unsafe FQuat IfFalse
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathQuaternionSelectBool.__PropertyOffset_IfFalse);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathQuaternionSelectBool.__PropertyOffset_IfFalse) = value;
			}
		}

		// Token: 0x17001484 RID: 5252
		// (get) Token: 0x0600553D RID: 21821 RVA: 0x0007BA86 File Offset: 0x00079C86
		// (set) Token: 0x0600553E RID: 21822 RVA: 0x0007BA9A File Offset: 0x00079C9A
		public unsafe FQuat Result
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathQuaternionSelectBool.__PropertyOffset_Result);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathQuaternionSelectBool.__PropertyOffset_Result) = value;
			}
		}

		// Token: 0x0600553F RID: 21823 RVA: 0x0007BAAF File Offset: 0x00079CAF
		public FRigUnit_MathQuaternionSelectBool()
		{
		}

		// Token: 0x06005540 RID: 21824 RVA: 0x0007BAB7 File Offset: 0x00079CB7
		public FRigUnit_MathQuaternionSelectBool(bool Condition, FQuat IfTrue, FQuat IfFalse, FQuat Result)
		{
			this.Condition = Condition;
			this.IfTrue = IfTrue;
			this.IfFalse = IfFalse;
			this.Result = Result;
		}

		// Token: 0x06005541 RID: 21825 RVA: 0x0007BADC File Offset: 0x00079CDC
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_MathQuaternionSelectBool.StaticStruct();
		}

		// Token: 0x06005542 RID: 21826 RVA: 0x0007BAE8 File Offset: 0x00079CE8
		[NullableContext(2)]
		public FRigUnit_MathQuaternionSelectBool(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06005543 RID: 21827 RVA: 0x0007BAF2 File Offset: 0x00079CF2
		public FRigUnit_MathQuaternionSelectBool(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06005544 RID: 21828 RVA: 0x0007BAFD File Offset: 0x00079CFD
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_MathQuaternionSelectBool(Pointer, false, true);
		}

		// Token: 0x06005545 RID: 21829 RVA: 0x0007BB07 File Offset: 0x00079D07
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_MathQuaternionSelectBool(Pointer, MemoryOwner);
		}

		// Token: 0x04002863 RID: 10339
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_MathQuaternionSelectBool";

		// Token: 0x04002864 RID: 10340
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002865 RID: 10341
		internal static int __PropertyOffset_Condition;

		// Token: 0x04002866 RID: 10342
		internal static int __PropertyOffset_IfTrue;

		// Token: 0x04002867 RID: 10343
		internal static int __PropertyOffset_IfFalse;

		// Token: 0x04002868 RID: 10344
		internal static int __PropertyOffset_Result;
	}
}
