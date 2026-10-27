using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000643 RID: 1603
	[UnrealObjectPath("/Script/ControlRig.RigUnit_MathQuaternionUnaryOp")]
	[UnrealStructLayout(48, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FRigUnit_MathQuaternionUnaryOp : FRigUnit_MathQuaternionBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600558E RID: 21902 RVA: 0x0007C002 File Offset: 0x0007A202
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_MathQuaternionUnaryOp._ScriptStructPtr != 0) ? FRigUnit_MathQuaternionUnaryOp._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_MathQuaternionUnaryOp", ref FRigUnit_MathQuaternionUnaryOp._ScriptStructPtr);
		}

		// Token: 0x17001495 RID: 5269
		// (get) Token: 0x0600558F RID: 21903 RVA: 0x0007C026 File Offset: 0x0007A226
		// (set) Token: 0x06005590 RID: 21904 RVA: 0x0007C03A File Offset: 0x0007A23A
		public unsafe FQuat Value
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathQuaternionUnaryOp.__PropertyOffset_Value);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathQuaternionUnaryOp.__PropertyOffset_Value) = value;
			}
		}

		// Token: 0x17001496 RID: 5270
		// (get) Token: 0x06005591 RID: 21905 RVA: 0x0007C04F File Offset: 0x0007A24F
		// (set) Token: 0x06005592 RID: 21906 RVA: 0x0007C063 File Offset: 0x0007A263
		public unsafe FQuat Result
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathQuaternionUnaryOp.__PropertyOffset_Result);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathQuaternionUnaryOp.__PropertyOffset_Result) = value;
			}
		}

		// Token: 0x06005593 RID: 21907 RVA: 0x0007C078 File Offset: 0x0007A278
		public FRigUnit_MathQuaternionUnaryOp()
		{
		}

		// Token: 0x06005594 RID: 21908 RVA: 0x0007C080 File Offset: 0x0007A280
		public FRigUnit_MathQuaternionUnaryOp(FQuat Value, FQuat Result)
		{
			this.Value = Value;
			this.Result = Result;
		}

		// Token: 0x06005595 RID: 21909 RVA: 0x0007C096 File Offset: 0x0007A296
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_MathQuaternionUnaryOp.StaticStruct();
		}

		// Token: 0x06005596 RID: 21910 RVA: 0x0007C0A2 File Offset: 0x0007A2A2
		[NullableContext(2)]
		public FRigUnit_MathQuaternionUnaryOp(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06005597 RID: 21911 RVA: 0x0007C0AC File Offset: 0x0007A2AC
		public FRigUnit_MathQuaternionUnaryOp(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06005598 RID: 21912 RVA: 0x0007C0B7 File Offset: 0x0007A2B7
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_MathQuaternionUnaryOp(Pointer, false, true);
		}

		// Token: 0x06005599 RID: 21913 RVA: 0x0007C0C1 File Offset: 0x0007A2C1
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_MathQuaternionUnaryOp(Pointer, MemoryOwner);
		}

		// Token: 0x04002883 RID: 10371
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_MathQuaternionUnaryOp";

		// Token: 0x04002884 RID: 10372
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002885 RID: 10373
		internal static int __PropertyOffset_Value;

		// Token: 0x04002886 RID: 10374
		internal static int __PropertyOffset_Result;
	}
}
