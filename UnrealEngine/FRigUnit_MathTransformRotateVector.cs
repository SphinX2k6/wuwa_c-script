using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200065E RID: 1630
	[UnrealObjectPath("/Script/ControlRig.RigUnit_MathTransformRotateVector")]
	[UnrealStructLayout(96, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 96)]
	public class FRigUnit_MathTransformRotateVector : FRigUnit_MathTransformBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060056E6 RID: 22246 RVA: 0x0007DC11 File Offset: 0x0007BE11
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_MathTransformRotateVector._ScriptStructPtr != 0) ? FRigUnit_MathTransformRotateVector._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_MathTransformRotateVector", ref FRigUnit_MathTransformRotateVector._ScriptStructPtr);
		}

		// Token: 0x170014D7 RID: 5335
		// (get) Token: 0x060056E7 RID: 22247 RVA: 0x0007DC35 File Offset: 0x0007BE35
		// (set) Token: 0x060056E8 RID: 22248 RVA: 0x0007DC49 File Offset: 0x0007BE49
		public unsafe FTransform Transform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathTransformRotateVector.__PropertyOffset_Transform);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathTransformRotateVector.__PropertyOffset_Transform) = value;
			}
		}

		// Token: 0x170014D8 RID: 5336
		// (get) Token: 0x060056E9 RID: 22249 RVA: 0x0007DC5E File Offset: 0x0007BE5E
		// (set) Token: 0x060056EA RID: 22250 RVA: 0x0007DC72 File Offset: 0x0007BE72
		public unsafe FVector Direction
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathTransformRotateVector.__PropertyOffset_Direction);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathTransformRotateVector.__PropertyOffset_Direction) = value;
			}
		}

		// Token: 0x170014D9 RID: 5337
		// (get) Token: 0x060056EB RID: 22251 RVA: 0x0007DC87 File Offset: 0x0007BE87
		// (set) Token: 0x060056EC RID: 22252 RVA: 0x0007DC9B File Offset: 0x0007BE9B
		public unsafe FVector Result
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathTransformRotateVector.__PropertyOffset_Result);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathTransformRotateVector.__PropertyOffset_Result) = value;
			}
		}

		// Token: 0x060056ED RID: 22253 RVA: 0x0007DCB0 File Offset: 0x0007BEB0
		public FRigUnit_MathTransformRotateVector()
		{
		}

		// Token: 0x060056EE RID: 22254 RVA: 0x0007DCB8 File Offset: 0x0007BEB8
		public FRigUnit_MathTransformRotateVector(FTransform Transform, FVector Direction, FVector Result)
		{
			this.Transform = Transform;
			this.Direction = Direction;
			this.Result = Result;
		}

		// Token: 0x060056EF RID: 22255 RVA: 0x0007DCD5 File Offset: 0x0007BED5
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_MathTransformRotateVector.StaticStruct();
		}

		// Token: 0x060056F0 RID: 22256 RVA: 0x0007DCE1 File Offset: 0x0007BEE1
		[NullableContext(2)]
		public FRigUnit_MathTransformRotateVector(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060056F1 RID: 22257 RVA: 0x0007DCEB File Offset: 0x0007BEEB
		public FRigUnit_MathTransformRotateVector(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060056F2 RID: 22258 RVA: 0x0007DCF6 File Offset: 0x0007BEF6
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_MathTransformRotateVector(Pointer, false, true);
		}

		// Token: 0x060056F3 RID: 22259 RVA: 0x0007DD00 File Offset: 0x0007BF00
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_MathTransformRotateVector(Pointer, MemoryOwner);
		}

		// Token: 0x04002909 RID: 10505
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_MathTransformRotateVector";

		// Token: 0x0400290A RID: 10506
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400290B RID: 10507
		internal static int __PropertyOffset_Transform;

		// Token: 0x0400290C RID: 10508
		internal static int __PropertyOffset_Direction;

		// Token: 0x0400290D RID: 10509
		internal static int __PropertyOffset_Result;
	}
}
