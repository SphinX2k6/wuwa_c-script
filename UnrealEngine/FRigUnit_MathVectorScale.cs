using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000687 RID: 1671
	[UnrealObjectPath("/Script/ControlRig.RigUnit_MathVectorScale")]
	[UnrealStructLayout(40, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 40)]
	public class FRigUnit_MathVectorScale : FRigUnit_MathVectorBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060058DD RID: 22749 RVA: 0x0007FE39 File Offset: 0x0007E039
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_MathVectorScale._ScriptStructPtr != 0) ? FRigUnit_MathVectorScale._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_MathVectorScale", ref FRigUnit_MathVectorScale._ScriptStructPtr);
		}

		// Token: 0x1700152F RID: 5423
		// (get) Token: 0x060058DE RID: 22750 RVA: 0x0007FE5D File Offset: 0x0007E05D
		// (set) Token: 0x060058DF RID: 22751 RVA: 0x0007FE71 File Offset: 0x0007E071
		public unsafe FVector Value
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathVectorScale.__PropertyOffset_Value);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathVectorScale.__PropertyOffset_Value) = value;
			}
		}

		// Token: 0x17001530 RID: 5424
		// (get) Token: 0x060058E0 RID: 22752 RVA: 0x0007FE86 File Offset: 0x0007E086
		// (set) Token: 0x060058E1 RID: 22753 RVA: 0x0007FE96 File Offset: 0x0007E096
		public unsafe float Factor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathVectorScale.__PropertyOffset_Factor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathVectorScale.__PropertyOffset_Factor) = value;
			}
		}

		// Token: 0x17001531 RID: 5425
		// (get) Token: 0x060058E2 RID: 22754 RVA: 0x0007FEA7 File Offset: 0x0007E0A7
		// (set) Token: 0x060058E3 RID: 22755 RVA: 0x0007FEBB File Offset: 0x0007E0BB
		public unsafe FVector Result
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathVectorScale.__PropertyOffset_Result);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathVectorScale.__PropertyOffset_Result) = value;
			}
		}

		// Token: 0x060058E4 RID: 22756 RVA: 0x0007FED0 File Offset: 0x0007E0D0
		public FRigUnit_MathVectorScale()
		{
		}

		// Token: 0x060058E5 RID: 22757 RVA: 0x0007FED8 File Offset: 0x0007E0D8
		public FRigUnit_MathVectorScale(FVector Value, float Factor, FVector Result)
		{
			this.Value = Value;
			this.Factor = Factor;
			this.Result = Result;
		}

		// Token: 0x060058E6 RID: 22758 RVA: 0x0007FEF5 File Offset: 0x0007E0F5
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_MathVectorScale.StaticStruct();
		}

		// Token: 0x060058E7 RID: 22759 RVA: 0x0007FF01 File Offset: 0x0007E101
		[NullableContext(2)]
		public FRigUnit_MathVectorScale(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060058E8 RID: 22760 RVA: 0x0007FF0B File Offset: 0x0007E10B
		public FRigUnit_MathVectorScale(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060058E9 RID: 22761 RVA: 0x0007FF16 File Offset: 0x0007E116
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_MathVectorScale(Pointer, false, true);
		}

		// Token: 0x060058EA RID: 22762 RVA: 0x0007FF20 File Offset: 0x0007E120
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_MathVectorScale(Pointer, MemoryOwner);
		}

		// Token: 0x040029B6 RID: 10678
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_MathVectorScale";

		// Token: 0x040029B7 RID: 10679
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040029B8 RID: 10680
		internal static int __PropertyOffset_Value;

		// Token: 0x040029B9 RID: 10681
		internal static int __PropertyOffset_Factor;

		// Token: 0x040029BA RID: 10682
		internal static int __PropertyOffset_Result;
	}
}
