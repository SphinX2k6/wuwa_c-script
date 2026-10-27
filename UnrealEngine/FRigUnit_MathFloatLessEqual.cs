using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000604 RID: 1540
	[UnrealObjectPath("/Script/ControlRig.RigUnit_MathFloatLessEqual")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FRigUnit_MathFloatLessEqual : FRigUnit_MathFloatBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060052BA RID: 21178 RVA: 0x000791DF File Offset: 0x000773DF
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_MathFloatLessEqual._ScriptStructPtr != 0) ? FRigUnit_MathFloatLessEqual._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_MathFloatLessEqual", ref FRigUnit_MathFloatLessEqual._ScriptStructPtr);
		}

		// Token: 0x17001426 RID: 5158
		// (get) Token: 0x060052BB RID: 21179 RVA: 0x00079203 File Offset: 0x00077403
		// (set) Token: 0x060052BC RID: 21180 RVA: 0x00079213 File Offset: 0x00077413
		public unsafe float A
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathFloatLessEqual.__PropertyOffset_A);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathFloatLessEqual.__PropertyOffset_A) = value;
			}
		}

		// Token: 0x17001427 RID: 5159
		// (get) Token: 0x060052BD RID: 21181 RVA: 0x00079224 File Offset: 0x00077424
		// (set) Token: 0x060052BE RID: 21182 RVA: 0x00079234 File Offset: 0x00077434
		public unsafe float B
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathFloatLessEqual.__PropertyOffset_B);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathFloatLessEqual.__PropertyOffset_B) = value;
			}
		}

		// Token: 0x17001428 RID: 5160
		// (get) Token: 0x060052BF RID: 21183 RVA: 0x00079245 File Offset: 0x00077445
		// (set) Token: 0x060052C0 RID: 21184 RVA: 0x00079255 File Offset: 0x00077455
		public unsafe bool Result
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathFloatLessEqual.__PropertyOffset_Result) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathFloatLessEqual.__PropertyOffset_Result) = (value ? 1 : 0);
			}
		}

		// Token: 0x060052C1 RID: 21185 RVA: 0x00079266 File Offset: 0x00077466
		public FRigUnit_MathFloatLessEqual()
		{
		}

		// Token: 0x060052C2 RID: 21186 RVA: 0x0007926E File Offset: 0x0007746E
		public FRigUnit_MathFloatLessEqual(float A, float B, bool Result)
		{
			this.A = A;
			this.B = B;
			this.Result = Result;
		}

		// Token: 0x060052C3 RID: 21187 RVA: 0x0007928B File Offset: 0x0007748B
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_MathFloatLessEqual.StaticStruct();
		}

		// Token: 0x060052C4 RID: 21188 RVA: 0x00079297 File Offset: 0x00077497
		[NullableContext(2)]
		public FRigUnit_MathFloatLessEqual(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060052C5 RID: 21189 RVA: 0x000792A1 File Offset: 0x000774A1
		public FRigUnit_MathFloatLessEqual(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060052C6 RID: 21190 RVA: 0x000792AC File Offset: 0x000774AC
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_MathFloatLessEqual(Pointer, false, true);
		}

		// Token: 0x060052C7 RID: 21191 RVA: 0x000792B6 File Offset: 0x000774B6
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_MathFloatLessEqual(Pointer, MemoryOwner);
		}

		// Token: 0x04002796 RID: 10134
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_MathFloatLessEqual";

		// Token: 0x04002797 RID: 10135
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002798 RID: 10136
		internal static int __PropertyOffset_A;

		// Token: 0x04002799 RID: 10137
		internal static int __PropertyOffset_B;

		// Token: 0x0400279A RID: 10138
		internal static int __PropertyOffset_Result;
	}
}
