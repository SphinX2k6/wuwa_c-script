using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000665 RID: 1637
	[UnrealObjectPath("/Script/ControlRig.RigUnit_MathVectorAngle")]
	[UnrealStructLayout(40, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 40)]
	public class FRigUnit_MathVectorAngle : FRigUnit_MathVectorBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600573A RID: 22330 RVA: 0x0007E1E1 File Offset: 0x0007C3E1
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_MathVectorAngle._ScriptStructPtr != 0) ? FRigUnit_MathVectorAngle._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_MathVectorAngle", ref FRigUnit_MathVectorAngle._ScriptStructPtr);
		}

		// Token: 0x170014E5 RID: 5349
		// (get) Token: 0x0600573B RID: 22331 RVA: 0x0007E205 File Offset: 0x0007C405
		// (set) Token: 0x0600573C RID: 22332 RVA: 0x0007E219 File Offset: 0x0007C419
		public unsafe FVector A
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathVectorAngle.__PropertyOffset_A);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathVectorAngle.__PropertyOffset_A) = value;
			}
		}

		// Token: 0x170014E6 RID: 5350
		// (get) Token: 0x0600573D RID: 22333 RVA: 0x0007E22E File Offset: 0x0007C42E
		// (set) Token: 0x0600573E RID: 22334 RVA: 0x0007E242 File Offset: 0x0007C442
		public unsafe FVector B
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathVectorAngle.__PropertyOffset_B);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathVectorAngle.__PropertyOffset_B) = value;
			}
		}

		// Token: 0x170014E7 RID: 5351
		// (get) Token: 0x0600573F RID: 22335 RVA: 0x0007E257 File Offset: 0x0007C457
		// (set) Token: 0x06005740 RID: 22336 RVA: 0x0007E267 File Offset: 0x0007C467
		public unsafe float Result
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathVectorAngle.__PropertyOffset_Result);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathVectorAngle.__PropertyOffset_Result) = value;
			}
		}

		// Token: 0x06005741 RID: 22337 RVA: 0x0007E278 File Offset: 0x0007C478
		public FRigUnit_MathVectorAngle()
		{
		}

		// Token: 0x06005742 RID: 22338 RVA: 0x0007E280 File Offset: 0x0007C480
		public FRigUnit_MathVectorAngle(FVector A, FVector B, float Result)
		{
			this.A = A;
			this.B = B;
			this.Result = Result;
		}

		// Token: 0x06005743 RID: 22339 RVA: 0x0007E29D File Offset: 0x0007C49D
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_MathVectorAngle.StaticStruct();
		}

		// Token: 0x06005744 RID: 22340 RVA: 0x0007E2A9 File Offset: 0x0007C4A9
		[NullableContext(2)]
		public FRigUnit_MathVectorAngle(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06005745 RID: 22341 RVA: 0x0007E2B3 File Offset: 0x0007C4B3
		public FRigUnit_MathVectorAngle(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06005746 RID: 22342 RVA: 0x0007E2BE File Offset: 0x0007C4BE
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_MathVectorAngle(Pointer, false, true);
		}

		// Token: 0x06005747 RID: 22343 RVA: 0x0007E2C8 File Offset: 0x0007C4C8
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_MathVectorAngle(Pointer, MemoryOwner);
		}

		// Token: 0x04002926 RID: 10534
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_MathVectorAngle";

		// Token: 0x04002927 RID: 10535
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002928 RID: 10536
		internal static int __PropertyOffset_A;

		// Token: 0x04002929 RID: 10537
		internal static int __PropertyOffset_B;

		// Token: 0x0400292A RID: 10538
		internal static int __PropertyOffset_Result;
	}
}
