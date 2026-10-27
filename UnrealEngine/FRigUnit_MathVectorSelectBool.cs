using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000688 RID: 1672
	[UnrealObjectPath("/Script/ControlRig.RigUnit_MathVectorSelectBool")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FRigUnit_MathVectorSelectBool : FRigUnit_MathVectorBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060058EB RID: 22763 RVA: 0x0007FF29 File Offset: 0x0007E129
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_MathVectorSelectBool._ScriptStructPtr != 0) ? FRigUnit_MathVectorSelectBool._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_MathVectorSelectBool", ref FRigUnit_MathVectorSelectBool._ScriptStructPtr);
		}

		// Token: 0x17001532 RID: 5426
		// (get) Token: 0x060058EC RID: 22764 RVA: 0x0007FF4D File Offset: 0x0007E14D
		// (set) Token: 0x060058ED RID: 22765 RVA: 0x0007FF5D File Offset: 0x0007E15D
		public unsafe bool Condition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathVectorSelectBool.__PropertyOffset_Condition) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathVectorSelectBool.__PropertyOffset_Condition) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001533 RID: 5427
		// (get) Token: 0x060058EE RID: 22766 RVA: 0x0007FF6E File Offset: 0x0007E16E
		// (set) Token: 0x060058EF RID: 22767 RVA: 0x0007FF82 File Offset: 0x0007E182
		public unsafe FVector IfTrue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathVectorSelectBool.__PropertyOffset_IfTrue);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathVectorSelectBool.__PropertyOffset_IfTrue) = value;
			}
		}

		// Token: 0x17001534 RID: 5428
		// (get) Token: 0x060058F0 RID: 22768 RVA: 0x0007FF97 File Offset: 0x0007E197
		// (set) Token: 0x060058F1 RID: 22769 RVA: 0x0007FFAB File Offset: 0x0007E1AB
		public unsafe FVector IfFalse
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathVectorSelectBool.__PropertyOffset_IfFalse);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathVectorSelectBool.__PropertyOffset_IfFalse) = value;
			}
		}

		// Token: 0x17001535 RID: 5429
		// (get) Token: 0x060058F2 RID: 22770 RVA: 0x0007FFC0 File Offset: 0x0007E1C0
		// (set) Token: 0x060058F3 RID: 22771 RVA: 0x0007FFD4 File Offset: 0x0007E1D4
		public unsafe FVector Result
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathVectorSelectBool.__PropertyOffset_Result);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathVectorSelectBool.__PropertyOffset_Result) = value;
			}
		}

		// Token: 0x060058F4 RID: 22772 RVA: 0x0007FFE9 File Offset: 0x0007E1E9
		public FRigUnit_MathVectorSelectBool()
		{
		}

		// Token: 0x060058F5 RID: 22773 RVA: 0x0007FFF1 File Offset: 0x0007E1F1
		public FRigUnit_MathVectorSelectBool(bool Condition, FVector IfTrue, FVector IfFalse, FVector Result)
		{
			this.Condition = Condition;
			this.IfTrue = IfTrue;
			this.IfFalse = IfFalse;
			this.Result = Result;
		}

		// Token: 0x060058F6 RID: 22774 RVA: 0x00080016 File Offset: 0x0007E216
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_MathVectorSelectBool.StaticStruct();
		}

		// Token: 0x060058F7 RID: 22775 RVA: 0x00080022 File Offset: 0x0007E222
		[NullableContext(2)]
		public FRigUnit_MathVectorSelectBool(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060058F8 RID: 22776 RVA: 0x0008002C File Offset: 0x0007E22C
		public FRigUnit_MathVectorSelectBool(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060058F9 RID: 22777 RVA: 0x00080037 File Offset: 0x0007E237
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_MathVectorSelectBool(Pointer, false, true);
		}

		// Token: 0x060058FA RID: 22778 RVA: 0x00080041 File Offset: 0x0007E241
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_MathVectorSelectBool(Pointer, MemoryOwner);
		}

		// Token: 0x040029BB RID: 10683
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_MathVectorSelectBool";

		// Token: 0x040029BC RID: 10684
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040029BD RID: 10685
		internal static int __PropertyOffset_Condition;

		// Token: 0x040029BE RID: 10686
		internal static int __PropertyOffset_IfTrue;

		// Token: 0x040029BF RID: 10687
		internal static int __PropertyOffset_IfFalse;

		// Token: 0x040029C0 RID: 10688
		internal static int __PropertyOffset_Result;
	}
}
