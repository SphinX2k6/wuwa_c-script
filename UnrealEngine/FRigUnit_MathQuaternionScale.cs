using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200063C RID: 1596
	[UnrealObjectPath("/Script/ControlRig.RigUnit_MathQuaternionScale")]
	[UnrealStructLayout(48, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FRigUnit_MathQuaternionScale : FRigUnit_MathQuaternionBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600552A RID: 21802 RVA: 0x0007B92F File Offset: 0x00079B2F
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_MathQuaternionScale._ScriptStructPtr != 0) ? FRigUnit_MathQuaternionScale._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_MathQuaternionScale", ref FRigUnit_MathQuaternionScale._ScriptStructPtr);
		}

		// Token: 0x1700147F RID: 5247
		// (get) Token: 0x0600552B RID: 21803 RVA: 0x0007B953 File Offset: 0x00079B53
		// (set) Token: 0x0600552C RID: 21804 RVA: 0x0007B967 File Offset: 0x00079B67
		public unsafe FQuat Value
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathQuaternionScale.__PropertyOffset_Value);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathQuaternionScale.__PropertyOffset_Value) = value;
			}
		}

		// Token: 0x17001480 RID: 5248
		// (get) Token: 0x0600552D RID: 21805 RVA: 0x0007B97C File Offset: 0x00079B7C
		// (set) Token: 0x0600552E RID: 21806 RVA: 0x0007B98C File Offset: 0x00079B8C
		public unsafe float Scale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathQuaternionScale.__PropertyOffset_Scale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathQuaternionScale.__PropertyOffset_Scale) = value;
			}
		}

		// Token: 0x0600552F RID: 21807 RVA: 0x0007B99D File Offset: 0x00079B9D
		public FRigUnit_MathQuaternionScale()
		{
		}

		// Token: 0x06005530 RID: 21808 RVA: 0x0007B9A5 File Offset: 0x00079BA5
		public FRigUnit_MathQuaternionScale(FQuat Value, float Scale)
		{
			this.Value = Value;
			this.Scale = Scale;
		}

		// Token: 0x06005531 RID: 21809 RVA: 0x0007B9BB File Offset: 0x00079BBB
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_MathQuaternionScale.StaticStruct();
		}

		// Token: 0x06005532 RID: 21810 RVA: 0x0007B9C7 File Offset: 0x00079BC7
		[NullableContext(2)]
		public FRigUnit_MathQuaternionScale(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06005533 RID: 21811 RVA: 0x0007B9D1 File Offset: 0x00079BD1
		public FRigUnit_MathQuaternionScale(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06005534 RID: 21812 RVA: 0x0007B9DC File Offset: 0x00079BDC
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_MathQuaternionScale(Pointer, false, true);
		}

		// Token: 0x06005535 RID: 21813 RVA: 0x0007B9E6 File Offset: 0x00079BE6
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_MathQuaternionScale(Pointer, MemoryOwner);
		}

		// Token: 0x0400285F RID: 10335
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_MathQuaternionScale";

		// Token: 0x04002860 RID: 10336
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002861 RID: 10337
		internal static int __PropertyOffset_Value;

		// Token: 0x04002862 RID: 10338
		internal static int __PropertyOffset_Scale;
	}
}
