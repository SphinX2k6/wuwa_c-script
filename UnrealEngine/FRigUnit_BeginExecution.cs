using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200054F RID: 1359
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ControlRig.RigUnit_BeginExecution")]
	[UnrealStructLayout(112, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 112)]
	public class FRigUnit_BeginExecution : FRigUnit, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060047DB RID: 18395 RVA: 0x0006AA7C File Offset: 0x00068C7C
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_BeginExecution._ScriptStructPtr != 0) ? FRigUnit_BeginExecution._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_BeginExecution", ref FRigUnit_BeginExecution._ScriptStructPtr);
		}

		// Token: 0x17001186 RID: 4486
		// (get) Token: 0x060047DC RID: 18396 RVA: 0x0006AAA0 File Offset: 0x00068CA0
		// (set) Token: 0x060047DD RID: 18397 RVA: 0x0006AAE3 File Offset: 0x00068CE3
		public FControlRigExecuteContext ExecuteContext
		{
			get
			{
				base.FastCheckIsValid();
				FControlRigExecuteContext result;
				if ((result = this._ExecuteContext) == null)
				{
					result = (this._ExecuteContext = new FControlRigExecuteContext(base.NativePtr + (IntPtr)FRigUnit_BeginExecution.__PropertyOffset_ExecuteContext, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FControlRigExecuteContext.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_BeginExecution.__PropertyOffset_ExecuteContext, value.NativePtr, 1, false);
			}
		}

		// Token: 0x060047DE RID: 18398 RVA: 0x0006AB04 File Offset: 0x00068D04
		public FRigUnit_BeginExecution()
		{
		}

		// Token: 0x060047DF RID: 18399 RVA: 0x0006AB0C File Offset: 0x00068D0C
		public FRigUnit_BeginExecution(FControlRigExecuteContext ExecuteContext)
		{
			this.ExecuteContext = ExecuteContext;
		}

		// Token: 0x060047E0 RID: 18400 RVA: 0x0006AB1B File Offset: 0x00068D1B
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_BeginExecution.StaticStruct();
		}

		// Token: 0x060047E1 RID: 18401 RVA: 0x0006AB27 File Offset: 0x00068D27
		[NullableContext(2)]
		public FRigUnit_BeginExecution(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060047E2 RID: 18402 RVA: 0x0006AB31 File Offset: 0x00068D31
		public FRigUnit_BeginExecution(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060047E3 RID: 18403 RVA: 0x0006AB3C File Offset: 0x00068D3C
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_BeginExecution(Pointer, false, true);
		}

		// Token: 0x060047E4 RID: 18404 RVA: 0x0006AB46 File Offset: 0x00068D46
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_BeginExecution(Pointer, MemoryOwner);
		}

		// Token: 0x040022E6 RID: 8934
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_BeginExecution";

		// Token: 0x040022E7 RID: 8935
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040022E8 RID: 8936
		internal static int __PropertyOffset_ExecuteContext;

		// Token: 0x040022E9 RID: 8937
		[Nullable(2)]
		private FControlRigExecuteContext _ExecuteContext;
	}
}
