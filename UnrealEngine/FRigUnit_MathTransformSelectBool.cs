using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200065F RID: 1631
	[UnrealObjectPath("/Script/ControlRig.RigUnit_MathTransformSelectBool")]
	[UnrealStructLayout(160, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 160)]
	public class FRigUnit_MathTransformSelectBool : FRigUnit_MathTransformBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060056F4 RID: 22260 RVA: 0x0007DD09 File Offset: 0x0007BF09
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_MathTransformSelectBool._ScriptStructPtr != 0) ? FRigUnit_MathTransformSelectBool._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_MathTransformSelectBool", ref FRigUnit_MathTransformSelectBool._ScriptStructPtr);
		}

		// Token: 0x170014DA RID: 5338
		// (get) Token: 0x060056F5 RID: 22261 RVA: 0x0007DD2D File Offset: 0x0007BF2D
		// (set) Token: 0x060056F6 RID: 22262 RVA: 0x0007DD3D File Offset: 0x0007BF3D
		public unsafe bool Condition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathTransformSelectBool.__PropertyOffset_Condition) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathTransformSelectBool.__PropertyOffset_Condition) = (value ? 1 : 0);
			}
		}

		// Token: 0x170014DB RID: 5339
		// (get) Token: 0x060056F7 RID: 22263 RVA: 0x0007DD4E File Offset: 0x0007BF4E
		// (set) Token: 0x060056F8 RID: 22264 RVA: 0x0007DD62 File Offset: 0x0007BF62
		public unsafe FTransform IfTrue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathTransformSelectBool.__PropertyOffset_IfTrue);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathTransformSelectBool.__PropertyOffset_IfTrue) = value;
			}
		}

		// Token: 0x170014DC RID: 5340
		// (get) Token: 0x060056F9 RID: 22265 RVA: 0x0007DD77 File Offset: 0x0007BF77
		// (set) Token: 0x060056FA RID: 22266 RVA: 0x0007DD8B File Offset: 0x0007BF8B
		public unsafe FTransform IfFalse
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathTransformSelectBool.__PropertyOffset_IfFalse);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathTransformSelectBool.__PropertyOffset_IfFalse) = value;
			}
		}

		// Token: 0x170014DD RID: 5341
		// (get) Token: 0x060056FB RID: 22267 RVA: 0x0007DDA0 File Offset: 0x0007BFA0
		// (set) Token: 0x060056FC RID: 22268 RVA: 0x0007DDB4 File Offset: 0x0007BFB4
		public unsafe FTransform Result
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathTransformSelectBool.__PropertyOffset_Result);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathTransformSelectBool.__PropertyOffset_Result) = value;
			}
		}

		// Token: 0x060056FD RID: 22269 RVA: 0x0007DDC9 File Offset: 0x0007BFC9
		public FRigUnit_MathTransformSelectBool()
		{
		}

		// Token: 0x060056FE RID: 22270 RVA: 0x0007DDD1 File Offset: 0x0007BFD1
		public FRigUnit_MathTransformSelectBool(bool Condition, FTransform IfTrue, FTransform IfFalse, FTransform Result)
		{
			this.Condition = Condition;
			this.IfTrue = IfTrue;
			this.IfFalse = IfFalse;
			this.Result = Result;
		}

		// Token: 0x060056FF RID: 22271 RVA: 0x0007DDF6 File Offset: 0x0007BFF6
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_MathTransformSelectBool.StaticStruct();
		}

		// Token: 0x06005700 RID: 22272 RVA: 0x0007DE02 File Offset: 0x0007C002
		[NullableContext(2)]
		public FRigUnit_MathTransformSelectBool(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06005701 RID: 22273 RVA: 0x0007DE0C File Offset: 0x0007C00C
		public FRigUnit_MathTransformSelectBool(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06005702 RID: 22274 RVA: 0x0007DE17 File Offset: 0x0007C017
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_MathTransformSelectBool(Pointer, false, true);
		}

		// Token: 0x06005703 RID: 22275 RVA: 0x0007DE21 File Offset: 0x0007C021
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_MathTransformSelectBool(Pointer, MemoryOwner);
		}

		// Token: 0x0400290E RID: 10510
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_MathTransformSelectBool";

		// Token: 0x0400290F RID: 10511
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002910 RID: 10512
		internal static int __PropertyOffset_Condition;

		// Token: 0x04002911 RID: 10513
		internal static int __PropertyOffset_IfTrue;

		// Token: 0x04002912 RID: 10514
		internal static int __PropertyOffset_IfFalse;

		// Token: 0x04002913 RID: 10515
		internal static int __PropertyOffset_Result;
	}
}
