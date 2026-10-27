using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020006B1 RID: 1713
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ControlRig.RigUnit_SequenceExecution")]
	[UnrealStructLayout(528, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 528)]
	public class FRigUnit_SequenceExecution : FRigUnit, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06005B5D RID: 23389 RVA: 0x00083244 File Offset: 0x00081444
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_SequenceExecution._ScriptStructPtr != 0) ? FRigUnit_SequenceExecution._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_SequenceExecution", ref FRigUnit_SequenceExecution._ScriptStructPtr);
		}

		// Token: 0x170015C8 RID: 5576
		// (get) Token: 0x06005B5E RID: 23390 RVA: 0x00083268 File Offset: 0x00081468
		// (set) Token: 0x06005B5F RID: 23391 RVA: 0x000832AB File Offset: 0x000814AB
		public FControlRigExecuteContext ExecuteContext
		{
			get
			{
				base.FastCheckIsValid();
				FControlRigExecuteContext result;
				if ((result = this._ExecuteContext) == null)
				{
					result = (this._ExecuteContext = new FControlRigExecuteContext(base.NativePtr + (IntPtr)FRigUnit_SequenceExecution.__PropertyOffset_ExecuteContext, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FControlRigExecuteContext.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_SequenceExecution.__PropertyOffset_ExecuteContext, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170015C9 RID: 5577
		// (get) Token: 0x06005B60 RID: 23392 RVA: 0x000832CC File Offset: 0x000814CC
		// (set) Token: 0x06005B61 RID: 23393 RVA: 0x0008330F File Offset: 0x0008150F
		public FControlRigExecuteContext A
		{
			get
			{
				base.FastCheckIsValid();
				FControlRigExecuteContext result;
				if ((result = this._A) == null)
				{
					result = (this._A = new FControlRigExecuteContext(base.NativePtr + (IntPtr)FRigUnit_SequenceExecution.__PropertyOffset_A, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FControlRigExecuteContext.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_SequenceExecution.__PropertyOffset_A, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170015CA RID: 5578
		// (get) Token: 0x06005B62 RID: 23394 RVA: 0x00083330 File Offset: 0x00081530
		// (set) Token: 0x06005B63 RID: 23395 RVA: 0x00083373 File Offset: 0x00081573
		public FControlRigExecuteContext B
		{
			get
			{
				base.FastCheckIsValid();
				FControlRigExecuteContext result;
				if ((result = this._B) == null)
				{
					result = (this._B = new FControlRigExecuteContext(base.NativePtr + (IntPtr)FRigUnit_SequenceExecution.__PropertyOffset_B, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FControlRigExecuteContext.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_SequenceExecution.__PropertyOffset_B, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170015CB RID: 5579
		// (get) Token: 0x06005B64 RID: 23396 RVA: 0x00083394 File Offset: 0x00081594
		// (set) Token: 0x06005B65 RID: 23397 RVA: 0x000833D7 File Offset: 0x000815D7
		public FControlRigExecuteContext C
		{
			get
			{
				base.FastCheckIsValid();
				FControlRigExecuteContext result;
				if ((result = this._C) == null)
				{
					result = (this._C = new FControlRigExecuteContext(base.NativePtr + (IntPtr)FRigUnit_SequenceExecution.__PropertyOffset_C, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FControlRigExecuteContext.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_SequenceExecution.__PropertyOffset_C, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170015CC RID: 5580
		// (get) Token: 0x06005B66 RID: 23398 RVA: 0x000833F8 File Offset: 0x000815F8
		// (set) Token: 0x06005B67 RID: 23399 RVA: 0x0008343B File Offset: 0x0008163B
		public FControlRigExecuteContext D
		{
			get
			{
				base.FastCheckIsValid();
				FControlRigExecuteContext result;
				if ((result = this._D) == null)
				{
					result = (this._D = new FControlRigExecuteContext(base.NativePtr + (IntPtr)FRigUnit_SequenceExecution.__PropertyOffset_D, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FControlRigExecuteContext.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_SequenceExecution.__PropertyOffset_D, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06005B68 RID: 23400 RVA: 0x0008345C File Offset: 0x0008165C
		public FRigUnit_SequenceExecution()
		{
		}

		// Token: 0x06005B69 RID: 23401 RVA: 0x00083464 File Offset: 0x00081664
		public FRigUnit_SequenceExecution(FControlRigExecuteContext ExecuteContext, FControlRigExecuteContext A, FControlRigExecuteContext B, FControlRigExecuteContext C, FControlRigExecuteContext D)
		{
			this.ExecuteContext = ExecuteContext;
			this.A = A;
			this.B = B;
			this.C = C;
			this.D = D;
		}

		// Token: 0x06005B6A RID: 23402 RVA: 0x00083491 File Offset: 0x00081691
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_SequenceExecution.StaticStruct();
		}

		// Token: 0x06005B6B RID: 23403 RVA: 0x0008349D File Offset: 0x0008169D
		[NullableContext(2)]
		public FRigUnit_SequenceExecution(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06005B6C RID: 23404 RVA: 0x000834A7 File Offset: 0x000816A7
		public FRigUnit_SequenceExecution(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06005B6D RID: 23405 RVA: 0x000834B2 File Offset: 0x000816B2
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_SequenceExecution(Pointer, false, true);
		}

		// Token: 0x06005B6E RID: 23406 RVA: 0x000834BC File Offset: 0x000816BC
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_SequenceExecution(Pointer, MemoryOwner);
		}

		// Token: 0x04002AC5 RID: 10949
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_SequenceExecution";

		// Token: 0x04002AC6 RID: 10950
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002AC7 RID: 10951
		internal static int __PropertyOffset_ExecuteContext;

		// Token: 0x04002AC8 RID: 10952
		[Nullable(2)]
		private FControlRigExecuteContext _ExecuteContext;

		// Token: 0x04002AC9 RID: 10953
		internal static int __PropertyOffset_A;

		// Token: 0x04002ACA RID: 10954
		[Nullable(2)]
		private FControlRigExecuteContext _A;

		// Token: 0x04002ACB RID: 10955
		internal static int __PropertyOffset_B;

		// Token: 0x04002ACC RID: 10956
		[Nullable(2)]
		private FControlRigExecuteContext _B;

		// Token: 0x04002ACD RID: 10957
		internal static int __PropertyOffset_C;

		// Token: 0x04002ACE RID: 10958
		[Nullable(2)]
		private FControlRigExecuteContext _C;

		// Token: 0x04002ACF RID: 10959
		internal static int __PropertyOffset_D;

		// Token: 0x04002AD0 RID: 10960
		[Nullable(2)]
		private FControlRigExecuteContext _D;
	}
}
