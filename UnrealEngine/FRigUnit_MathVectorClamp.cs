using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200066A RID: 1642
	[UnrealObjectPath("/Script/ControlRig.RigUnit_MathVectorClamp")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 56)]
	public class FRigUnit_MathVectorClamp : FRigUnit_MathVectorBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06005775 RID: 22389 RVA: 0x0007E5FE File Offset: 0x0007C7FE
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_MathVectorClamp._ScriptStructPtr != 0) ? FRigUnit_MathVectorClamp._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_MathVectorClamp", ref FRigUnit_MathVectorClamp._ScriptStructPtr);
		}

		// Token: 0x170014EF RID: 5359
		// (get) Token: 0x06005776 RID: 22390 RVA: 0x0007E622 File Offset: 0x0007C822
		// (set) Token: 0x06005777 RID: 22391 RVA: 0x0007E636 File Offset: 0x0007C836
		public unsafe FVector Value
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathVectorClamp.__PropertyOffset_Value);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathVectorClamp.__PropertyOffset_Value) = value;
			}
		}

		// Token: 0x170014F0 RID: 5360
		// (get) Token: 0x06005778 RID: 22392 RVA: 0x0007E64B File Offset: 0x0007C84B
		// (set) Token: 0x06005779 RID: 22393 RVA: 0x0007E65F File Offset: 0x0007C85F
		public unsafe FVector Minimum
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathVectorClamp.__PropertyOffset_Minimum);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathVectorClamp.__PropertyOffset_Minimum) = value;
			}
		}

		// Token: 0x170014F1 RID: 5361
		// (get) Token: 0x0600577A RID: 22394 RVA: 0x0007E674 File Offset: 0x0007C874
		// (set) Token: 0x0600577B RID: 22395 RVA: 0x0007E688 File Offset: 0x0007C888
		public unsafe FVector Maximum
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathVectorClamp.__PropertyOffset_Maximum);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathVectorClamp.__PropertyOffset_Maximum) = value;
			}
		}

		// Token: 0x170014F2 RID: 5362
		// (get) Token: 0x0600577C RID: 22396 RVA: 0x0007E69D File Offset: 0x0007C89D
		// (set) Token: 0x0600577D RID: 22397 RVA: 0x0007E6B1 File Offset: 0x0007C8B1
		public unsafe FVector Result
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathVectorClamp.__PropertyOffset_Result);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathVectorClamp.__PropertyOffset_Result) = value;
			}
		}

		// Token: 0x0600577E RID: 22398 RVA: 0x0007E6C6 File Offset: 0x0007C8C6
		public FRigUnit_MathVectorClamp()
		{
		}

		// Token: 0x0600577F RID: 22399 RVA: 0x0007E6CE File Offset: 0x0007C8CE
		public FRigUnit_MathVectorClamp(FVector Value, FVector Minimum, FVector Maximum, FVector Result)
		{
			this.Value = Value;
			this.Minimum = Minimum;
			this.Maximum = Maximum;
			this.Result = Result;
		}

		// Token: 0x06005780 RID: 22400 RVA: 0x0007E6F3 File Offset: 0x0007C8F3
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_MathVectorClamp.StaticStruct();
		}

		// Token: 0x06005781 RID: 22401 RVA: 0x0007E6FF File Offset: 0x0007C8FF
		[NullableContext(2)]
		public FRigUnit_MathVectorClamp(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06005782 RID: 22402 RVA: 0x0007E709 File Offset: 0x0007C909
		public FRigUnit_MathVectorClamp(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06005783 RID: 22403 RVA: 0x0007E714 File Offset: 0x0007C914
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_MathVectorClamp(Pointer, false, true);
		}

		// Token: 0x06005784 RID: 22404 RVA: 0x0007E71E File Offset: 0x0007C91E
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_MathVectorClamp(Pointer, MemoryOwner);
		}

		// Token: 0x0400293B RID: 10555
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_MathVectorClamp";

		// Token: 0x0400293C RID: 10556
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400293D RID: 10557
		internal static int __PropertyOffset_Value;

		// Token: 0x0400293E RID: 10558
		internal static int __PropertyOffset_Minimum;

		// Token: 0x0400293F RID: 10559
		internal static int __PropertyOffset_Maximum;

		// Token: 0x04002940 RID: 10560
		internal static int __PropertyOffset_Result;
	}
}
