using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200068C RID: 1676
	[UnrealObjectPath("/Script/ControlRig.RigUnit_MathVectorUnaryOp")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FRigUnit_MathVectorUnaryOp : FRigUnit_MathVectorBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06005919 RID: 22809 RVA: 0x0008022D File Offset: 0x0007E42D
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_MathVectorUnaryOp._ScriptStructPtr != 0) ? FRigUnit_MathVectorUnaryOp._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_MathVectorUnaryOp", ref FRigUnit_MathVectorUnaryOp._ScriptStructPtr);
		}

		// Token: 0x17001539 RID: 5433
		// (get) Token: 0x0600591A RID: 22810 RVA: 0x00080251 File Offset: 0x0007E451
		// (set) Token: 0x0600591B RID: 22811 RVA: 0x00080265 File Offset: 0x0007E465
		public unsafe FVector Value
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathVectorUnaryOp.__PropertyOffset_Value);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathVectorUnaryOp.__PropertyOffset_Value) = value;
			}
		}

		// Token: 0x1700153A RID: 5434
		// (get) Token: 0x0600591C RID: 22812 RVA: 0x0008027A File Offset: 0x0007E47A
		// (set) Token: 0x0600591D RID: 22813 RVA: 0x0008028E File Offset: 0x0007E48E
		public unsafe FVector Result
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathVectorUnaryOp.__PropertyOffset_Result);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathVectorUnaryOp.__PropertyOffset_Result) = value;
			}
		}

		// Token: 0x0600591E RID: 22814 RVA: 0x000802A3 File Offset: 0x0007E4A3
		public FRigUnit_MathVectorUnaryOp()
		{
		}

		// Token: 0x0600591F RID: 22815 RVA: 0x000802AB File Offset: 0x0007E4AB
		public FRigUnit_MathVectorUnaryOp(FVector Value, FVector Result)
		{
			this.Value = Value;
			this.Result = Result;
		}

		// Token: 0x06005920 RID: 22816 RVA: 0x000802C1 File Offset: 0x0007E4C1
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_MathVectorUnaryOp.StaticStruct();
		}

		// Token: 0x06005921 RID: 22817 RVA: 0x000802CD File Offset: 0x0007E4CD
		[NullableContext(2)]
		public FRigUnit_MathVectorUnaryOp(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06005922 RID: 22818 RVA: 0x000802D7 File Offset: 0x0007E4D7
		public FRigUnit_MathVectorUnaryOp(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06005923 RID: 22819 RVA: 0x000802E2 File Offset: 0x0007E4E2
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_MathVectorUnaryOp(Pointer, false, true);
		}

		// Token: 0x06005924 RID: 22820 RVA: 0x000802EC File Offset: 0x0007E4EC
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_MathVectorUnaryOp(Pointer, MemoryOwner);
		}

		// Token: 0x040029CA RID: 10698
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_MathVectorUnaryOp";

		// Token: 0x040029CB RID: 10699
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040029CC RID: 10700
		internal static int __PropertyOffset_Value;

		// Token: 0x040029CD RID: 10701
		internal static int __PropertyOffset_Result;
	}
}
