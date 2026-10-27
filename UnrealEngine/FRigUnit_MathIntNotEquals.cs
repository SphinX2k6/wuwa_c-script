using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000628 RID: 1576
	[UnrealObjectPath("/Script/ControlRig.RigUnit_MathIntNotEquals")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FRigUnit_MathIntNotEquals : FRigUnit_MathIntBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06005441 RID: 21569 RVA: 0x0007AA34 File Offset: 0x00078C34
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_MathIntNotEquals._ScriptStructPtr != 0) ? FRigUnit_MathIntNotEquals._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_MathIntNotEquals", ref FRigUnit_MathIntNotEquals._ScriptStructPtr);
		}

		// Token: 0x1700145A RID: 5210
		// (get) Token: 0x06005442 RID: 21570 RVA: 0x0007AA58 File Offset: 0x00078C58
		// (set) Token: 0x06005443 RID: 21571 RVA: 0x0007AA68 File Offset: 0x00078C68
		public unsafe int A
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathIntNotEquals.__PropertyOffset_A);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathIntNotEquals.__PropertyOffset_A) = value;
			}
		}

		// Token: 0x1700145B RID: 5211
		// (get) Token: 0x06005444 RID: 21572 RVA: 0x0007AA79 File Offset: 0x00078C79
		// (set) Token: 0x06005445 RID: 21573 RVA: 0x0007AA89 File Offset: 0x00078C89
		public unsafe int B
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathIntNotEquals.__PropertyOffset_B);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathIntNotEquals.__PropertyOffset_B) = value;
			}
		}

		// Token: 0x1700145C RID: 5212
		// (get) Token: 0x06005446 RID: 21574 RVA: 0x0007AA9A File Offset: 0x00078C9A
		// (set) Token: 0x06005447 RID: 21575 RVA: 0x0007AAAA File Offset: 0x00078CAA
		public unsafe bool Result
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathIntNotEquals.__PropertyOffset_Result) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathIntNotEquals.__PropertyOffset_Result) = (value ? 1 : 0);
			}
		}

		// Token: 0x06005448 RID: 21576 RVA: 0x0007AABB File Offset: 0x00078CBB
		public FRigUnit_MathIntNotEquals()
		{
		}

		// Token: 0x06005449 RID: 21577 RVA: 0x0007AAC3 File Offset: 0x00078CC3
		public FRigUnit_MathIntNotEquals(int A, int B, bool Result)
		{
			this.A = A;
			this.B = B;
			this.Result = Result;
		}

		// Token: 0x0600544A RID: 21578 RVA: 0x0007AAE0 File Offset: 0x00078CE0
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_MathIntNotEquals.StaticStruct();
		}

		// Token: 0x0600544B RID: 21579 RVA: 0x0007AAEC File Offset: 0x00078CEC
		[NullableContext(2)]
		public FRigUnit_MathIntNotEquals(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600544C RID: 21580 RVA: 0x0007AAF6 File Offset: 0x00078CF6
		public FRigUnit_MathIntNotEquals(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600544D RID: 21581 RVA: 0x0007AB01 File Offset: 0x00078D01
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_MathIntNotEquals(Pointer, false, true);
		}

		// Token: 0x0600544E RID: 21582 RVA: 0x0007AB0B File Offset: 0x00078D0B
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_MathIntNotEquals(Pointer, MemoryOwner);
		}

		// Token: 0x04002812 RID: 10258
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_MathIntNotEquals";

		// Token: 0x04002813 RID: 10259
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002814 RID: 10260
		internal static int __PropertyOffset_A;

		// Token: 0x04002815 RID: 10261
		internal static int __PropertyOffset_B;

		// Token: 0x04002816 RID: 10262
		internal static int __PropertyOffset_Result;
	}
}
