using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000681 RID: 1665
	[UnrealObjectPath("/Script/ControlRig.RigUnit_MathVectorNotEquals")]
	[UnrealStructLayout(40, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 40)]
	public class FRigUnit_MathVectorNotEquals : FRigUnit_MathVectorBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600588D RID: 22669 RVA: 0x0007F8C9 File Offset: 0x0007DAC9
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_MathVectorNotEquals._ScriptStructPtr != 0) ? FRigUnit_MathVectorNotEquals._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_MathVectorNotEquals", ref FRigUnit_MathVectorNotEquals._ScriptStructPtr);
		}

		// Token: 0x1700151F RID: 5407
		// (get) Token: 0x0600588E RID: 22670 RVA: 0x0007F8ED File Offset: 0x0007DAED
		// (set) Token: 0x0600588F RID: 22671 RVA: 0x0007F901 File Offset: 0x0007DB01
		public unsafe FVector A
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathVectorNotEquals.__PropertyOffset_A);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathVectorNotEquals.__PropertyOffset_A) = value;
			}
		}

		// Token: 0x17001520 RID: 5408
		// (get) Token: 0x06005890 RID: 22672 RVA: 0x0007F916 File Offset: 0x0007DB16
		// (set) Token: 0x06005891 RID: 22673 RVA: 0x0007F92A File Offset: 0x0007DB2A
		public unsafe FVector B
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathVectorNotEquals.__PropertyOffset_B);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathVectorNotEquals.__PropertyOffset_B) = value;
			}
		}

		// Token: 0x17001521 RID: 5409
		// (get) Token: 0x06005892 RID: 22674 RVA: 0x0007F93F File Offset: 0x0007DB3F
		// (set) Token: 0x06005893 RID: 22675 RVA: 0x0007F94F File Offset: 0x0007DB4F
		public unsafe bool Result
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathVectorNotEquals.__PropertyOffset_Result) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathVectorNotEquals.__PropertyOffset_Result) = (value ? 1 : 0);
			}
		}

		// Token: 0x06005894 RID: 22676 RVA: 0x0007F960 File Offset: 0x0007DB60
		public FRigUnit_MathVectorNotEquals()
		{
		}

		// Token: 0x06005895 RID: 22677 RVA: 0x0007F968 File Offset: 0x0007DB68
		public FRigUnit_MathVectorNotEquals(FVector A, FVector B, bool Result)
		{
			this.A = A;
			this.B = B;
			this.Result = Result;
		}

		// Token: 0x06005896 RID: 22678 RVA: 0x0007F985 File Offset: 0x0007DB85
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_MathVectorNotEquals.StaticStruct();
		}

		// Token: 0x06005897 RID: 22679 RVA: 0x0007F991 File Offset: 0x0007DB91
		[NullableContext(2)]
		public FRigUnit_MathVectorNotEquals(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06005898 RID: 22680 RVA: 0x0007F99B File Offset: 0x0007DB9B
		public FRigUnit_MathVectorNotEquals(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06005899 RID: 22681 RVA: 0x0007F9A6 File Offset: 0x0007DBA6
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_MathVectorNotEquals(Pointer, false, true);
		}

		// Token: 0x0600589A RID: 22682 RVA: 0x0007F9B0 File Offset: 0x0007DBB0
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_MathVectorNotEquals(Pointer, MemoryOwner);
		}

		// Token: 0x0400299A RID: 10650
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_MathVectorNotEquals";

		// Token: 0x0400299B RID: 10651
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400299C RID: 10652
		internal static int __PropertyOffset_A;

		// Token: 0x0400299D RID: 10653
		internal static int __PropertyOffset_B;

		// Token: 0x0400299E RID: 10654
		internal static int __PropertyOffset_Result;
	}
}
