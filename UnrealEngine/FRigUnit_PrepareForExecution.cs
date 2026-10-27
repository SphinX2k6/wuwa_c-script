using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020006A7 RID: 1703
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ControlRig.RigUnit_PrepareForExecution")]
	[UnrealStructLayout(112, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 112)]
	public class FRigUnit_PrepareForExecution : FRigUnit, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06005AAD RID: 23213 RVA: 0x00082377 File Offset: 0x00080577
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_PrepareForExecution._ScriptStructPtr != 0) ? FRigUnit_PrepareForExecution._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_PrepareForExecution", ref FRigUnit_PrepareForExecution._ScriptStructPtr);
		}

		// Token: 0x17001598 RID: 5528
		// (get) Token: 0x06005AAE RID: 23214 RVA: 0x0008239C File Offset: 0x0008059C
		// (set) Token: 0x06005AAF RID: 23215 RVA: 0x000823DF File Offset: 0x000805DF
		public FControlRigExecuteContext ExecuteContext
		{
			get
			{
				base.FastCheckIsValid();
				FControlRigExecuteContext result;
				if ((result = this._ExecuteContext) == null)
				{
					result = (this._ExecuteContext = new FControlRigExecuteContext(base.NativePtr + (IntPtr)FRigUnit_PrepareForExecution.__PropertyOffset_ExecuteContext, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FControlRigExecuteContext.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_PrepareForExecution.__PropertyOffset_ExecuteContext, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06005AB0 RID: 23216 RVA: 0x00082400 File Offset: 0x00080600
		public FRigUnit_PrepareForExecution()
		{
		}

		// Token: 0x06005AB1 RID: 23217 RVA: 0x00082408 File Offset: 0x00080608
		public FRigUnit_PrepareForExecution(FControlRigExecuteContext ExecuteContext)
		{
			this.ExecuteContext = ExecuteContext;
		}

		// Token: 0x06005AB2 RID: 23218 RVA: 0x00082417 File Offset: 0x00080617
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_PrepareForExecution.StaticStruct();
		}

		// Token: 0x06005AB3 RID: 23219 RVA: 0x00082423 File Offset: 0x00080623
		[NullableContext(2)]
		public FRigUnit_PrepareForExecution(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06005AB4 RID: 23220 RVA: 0x0008242D File Offset: 0x0008062D
		public FRigUnit_PrepareForExecution(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06005AB5 RID: 23221 RVA: 0x00082438 File Offset: 0x00080638
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_PrepareForExecution(Pointer, false, true);
		}

		// Token: 0x06005AB6 RID: 23222 RVA: 0x00082442 File Offset: 0x00080642
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_PrepareForExecution(Pointer, MemoryOwner);
		}

		// Token: 0x04002A77 RID: 10871
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_PrepareForExecution";

		// Token: 0x04002A78 RID: 10872
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002A79 RID: 10873
		internal static int __PropertyOffset_ExecuteContext;

		// Token: 0x04002A7A RID: 10874
		[Nullable(2)]
		private FControlRigExecuteContext _ExecuteContext;
	}
}
