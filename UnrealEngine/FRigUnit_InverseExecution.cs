using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020005CA RID: 1482
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ControlRig.RigUnit_InverseExecution")]
	[UnrealStructLayout(112, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 112)]
	public class FRigUnit_InverseExecution : FRigUnit, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06005019 RID: 20505 RVA: 0x00076518 File Offset: 0x00074718
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_InverseExecution._ScriptStructPtr != 0) ? FRigUnit_InverseExecution._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_InverseExecution", ref FRigUnit_InverseExecution._ScriptStructPtr);
		}

		// Token: 0x170013BB RID: 5051
		// (get) Token: 0x0600501A RID: 20506 RVA: 0x0007653C File Offset: 0x0007473C
		// (set) Token: 0x0600501B RID: 20507 RVA: 0x0007657F File Offset: 0x0007477F
		public FControlRigExecuteContext ExecuteContext
		{
			get
			{
				base.FastCheckIsValid();
				FControlRigExecuteContext result;
				if ((result = this._ExecuteContext) == null)
				{
					result = (this._ExecuteContext = new FControlRigExecuteContext(base.NativePtr + (IntPtr)FRigUnit_InverseExecution.__PropertyOffset_ExecuteContext, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FControlRigExecuteContext.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_InverseExecution.__PropertyOffset_ExecuteContext, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0600501C RID: 20508 RVA: 0x000765A0 File Offset: 0x000747A0
		public FRigUnit_InverseExecution()
		{
		}

		// Token: 0x0600501D RID: 20509 RVA: 0x000765A8 File Offset: 0x000747A8
		public FRigUnit_InverseExecution(FControlRigExecuteContext ExecuteContext)
		{
			this.ExecuteContext = ExecuteContext;
		}

		// Token: 0x0600501E RID: 20510 RVA: 0x000765B7 File Offset: 0x000747B7
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_InverseExecution.StaticStruct();
		}

		// Token: 0x0600501F RID: 20511 RVA: 0x000765C3 File Offset: 0x000747C3
		[NullableContext(2)]
		public FRigUnit_InverseExecution(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06005020 RID: 20512 RVA: 0x000765CD File Offset: 0x000747CD
		public FRigUnit_InverseExecution(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06005021 RID: 20513 RVA: 0x000765D8 File Offset: 0x000747D8
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_InverseExecution(Pointer, false, true);
		}

		// Token: 0x06005022 RID: 20514 RVA: 0x000765E2 File Offset: 0x000747E2
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_InverseExecution(Pointer, MemoryOwner);
		}

		// Token: 0x040026AC RID: 9900
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_InverseExecution";

		// Token: 0x040026AD RID: 9901
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040026AE RID: 9902
		internal static int __PropertyOffset_ExecuteContext;

		// Token: 0x040026AF RID: 9903
		[Nullable(2)]
		private FControlRigExecuteContext _ExecuteContext;
	}
}
