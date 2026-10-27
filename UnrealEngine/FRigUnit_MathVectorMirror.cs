using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200067D RID: 1661
	[UnrealObjectPath("/Script/ControlRig.RigUnit_MathVectorMirror")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FRigUnit_MathVectorMirror : FRigUnit_MathVectorBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06005867 RID: 22631 RVA: 0x0007F661 File Offset: 0x0007D861
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_MathVectorMirror._ScriptStructPtr != 0) ? FRigUnit_MathVectorMirror._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_MathVectorMirror", ref FRigUnit_MathVectorMirror._ScriptStructPtr);
		}

		// Token: 0x1700151C RID: 5404
		// (get) Token: 0x06005868 RID: 22632 RVA: 0x0007F685 File Offset: 0x0007D885
		// (set) Token: 0x06005869 RID: 22633 RVA: 0x0007F699 File Offset: 0x0007D899
		public unsafe FVector Value
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathVectorMirror.__PropertyOffset_Value);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathVectorMirror.__PropertyOffset_Value) = value;
			}
		}

		// Token: 0x1700151D RID: 5405
		// (get) Token: 0x0600586A RID: 22634 RVA: 0x0007F6AE File Offset: 0x0007D8AE
		// (set) Token: 0x0600586B RID: 22635 RVA: 0x0007F6C2 File Offset: 0x0007D8C2
		public unsafe FVector Normal
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathVectorMirror.__PropertyOffset_Normal);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathVectorMirror.__PropertyOffset_Normal) = value;
			}
		}

		// Token: 0x1700151E RID: 5406
		// (get) Token: 0x0600586C RID: 22636 RVA: 0x0007F6D7 File Offset: 0x0007D8D7
		// (set) Token: 0x0600586D RID: 22637 RVA: 0x0007F6EB File Offset: 0x0007D8EB
		public unsafe FVector Result
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathVectorMirror.__PropertyOffset_Result);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathVectorMirror.__PropertyOffset_Result) = value;
			}
		}

		// Token: 0x0600586E RID: 22638 RVA: 0x0007F700 File Offset: 0x0007D900
		public FRigUnit_MathVectorMirror()
		{
		}

		// Token: 0x0600586F RID: 22639 RVA: 0x0007F708 File Offset: 0x0007D908
		public FRigUnit_MathVectorMirror(FVector Value, FVector Normal, FVector Result)
		{
			this.Value = Value;
			this.Normal = Normal;
			this.Result = Result;
		}

		// Token: 0x06005870 RID: 22640 RVA: 0x0007F725 File Offset: 0x0007D925
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_MathVectorMirror.StaticStruct();
		}

		// Token: 0x06005871 RID: 22641 RVA: 0x0007F731 File Offset: 0x0007D931
		[NullableContext(2)]
		public FRigUnit_MathVectorMirror(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06005872 RID: 22642 RVA: 0x0007F73B File Offset: 0x0007D93B
		public FRigUnit_MathVectorMirror(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06005873 RID: 22643 RVA: 0x0007F746 File Offset: 0x0007D946
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_MathVectorMirror(Pointer, false, true);
		}

		// Token: 0x06005874 RID: 22644 RVA: 0x0007F750 File Offset: 0x0007D950
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_MathVectorMirror(Pointer, MemoryOwner);
		}

		// Token: 0x0400298F RID: 10639
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_MathVectorMirror";

		// Token: 0x04002990 RID: 10640
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002991 RID: 10641
		internal static int __PropertyOffset_Value;

		// Token: 0x04002992 RID: 10642
		internal static int __PropertyOffset_Normal;

		// Token: 0x04002993 RID: 10643
		internal static int __PropertyOffset_Result;
	}
}
