using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000551 RID: 1361
	[UnrealObjectPath("/Script/ControlRig.RigUnit_BinaryQuaternionOp")]
	[UnrealStructLayout(64, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 64)]
	public class FRigUnit_BinaryQuaternionOp : FRigUnit, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060047F3 RID: 18419 RVA: 0x0006AC2F File Offset: 0x00068E2F
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_BinaryQuaternionOp._ScriptStructPtr != 0) ? FRigUnit_BinaryQuaternionOp._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_BinaryQuaternionOp", ref FRigUnit_BinaryQuaternionOp._ScriptStructPtr);
		}

		// Token: 0x1700118A RID: 4490
		// (get) Token: 0x060047F4 RID: 18420 RVA: 0x0006AC53 File Offset: 0x00068E53
		// (set) Token: 0x060047F5 RID: 18421 RVA: 0x0006AC67 File Offset: 0x00068E67
		public unsafe FQuat Argument0
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_BinaryQuaternionOp.__PropertyOffset_Argument0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_BinaryQuaternionOp.__PropertyOffset_Argument0) = value;
			}
		}

		// Token: 0x1700118B RID: 4491
		// (get) Token: 0x060047F6 RID: 18422 RVA: 0x0006AC7C File Offset: 0x00068E7C
		// (set) Token: 0x060047F7 RID: 18423 RVA: 0x0006AC90 File Offset: 0x00068E90
		public unsafe FQuat Argument1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_BinaryQuaternionOp.__PropertyOffset_Argument1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_BinaryQuaternionOp.__PropertyOffset_Argument1) = value;
			}
		}

		// Token: 0x1700118C RID: 4492
		// (get) Token: 0x060047F8 RID: 18424 RVA: 0x0006ACA5 File Offset: 0x00068EA5
		// (set) Token: 0x060047F9 RID: 18425 RVA: 0x0006ACB9 File Offset: 0x00068EB9
		public unsafe FQuat Result
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_BinaryQuaternionOp.__PropertyOffset_Result);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_BinaryQuaternionOp.__PropertyOffset_Result) = value;
			}
		}

		// Token: 0x060047FA RID: 18426 RVA: 0x0006ACCE File Offset: 0x00068ECE
		public FRigUnit_BinaryQuaternionOp()
		{
		}

		// Token: 0x060047FB RID: 18427 RVA: 0x0006ACD6 File Offset: 0x00068ED6
		public FRigUnit_BinaryQuaternionOp(FQuat Argument0, FQuat Argument1, FQuat Result)
		{
			this.Argument0 = Argument0;
			this.Argument1 = Argument1;
			this.Result = Result;
		}

		// Token: 0x060047FC RID: 18428 RVA: 0x0006ACF3 File Offset: 0x00068EF3
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_BinaryQuaternionOp.StaticStruct();
		}

		// Token: 0x060047FD RID: 18429 RVA: 0x0006ACFF File Offset: 0x00068EFF
		[NullableContext(2)]
		public FRigUnit_BinaryQuaternionOp(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060047FE RID: 18430 RVA: 0x0006AD09 File Offset: 0x00068F09
		public FRigUnit_BinaryQuaternionOp(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060047FF RID: 18431 RVA: 0x0006AD14 File Offset: 0x00068F14
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_BinaryQuaternionOp(Pointer, false, true);
		}

		// Token: 0x06004800 RID: 18432 RVA: 0x0006AD1E File Offset: 0x00068F1E
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_BinaryQuaternionOp(Pointer, MemoryOwner);
		}

		// Token: 0x040022EF RID: 8943
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_BinaryQuaternionOp";

		// Token: 0x040022F0 RID: 8944
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040022F1 RID: 8945
		internal static int __PropertyOffset_Argument0;

		// Token: 0x040022F2 RID: 8946
		internal static int __PropertyOffset_Argument1;

		// Token: 0x040022F3 RID: 8947
		internal static int __PropertyOffset_Result;
	}
}
