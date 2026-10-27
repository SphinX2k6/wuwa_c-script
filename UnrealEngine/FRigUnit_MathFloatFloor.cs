using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020005FC RID: 1532
	[UnrealObjectPath("/Script/ControlRig.RigUnit_MathFloatFloor")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FRigUnit_MathFloatFloor : FRigUnit_MathFloatBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600523E RID: 21054 RVA: 0x000789E9 File Offset: 0x00076BE9
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_MathFloatFloor._ScriptStructPtr != 0) ? FRigUnit_MathFloatFloor._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_MathFloatFloor", ref FRigUnit_MathFloatFloor._ScriptStructPtr);
		}

		// Token: 0x17001408 RID: 5128
		// (get) Token: 0x0600523F RID: 21055 RVA: 0x00078A0D File Offset: 0x00076C0D
		// (set) Token: 0x06005240 RID: 21056 RVA: 0x00078A1D File Offset: 0x00076C1D
		public unsafe float Value
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathFloatFloor.__PropertyOffset_Value);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathFloatFloor.__PropertyOffset_Value) = value;
			}
		}

		// Token: 0x17001409 RID: 5129
		// (get) Token: 0x06005241 RID: 21057 RVA: 0x00078A2E File Offset: 0x00076C2E
		// (set) Token: 0x06005242 RID: 21058 RVA: 0x00078A3E File Offset: 0x00076C3E
		public unsafe float Result
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathFloatFloor.__PropertyOffset_Result);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathFloatFloor.__PropertyOffset_Result) = value;
			}
		}

		// Token: 0x1700140A RID: 5130
		// (get) Token: 0x06005243 RID: 21059 RVA: 0x00078A4F File Offset: 0x00076C4F
		// (set) Token: 0x06005244 RID: 21060 RVA: 0x00078A5F File Offset: 0x00076C5F
		public unsafe int Int
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathFloatFloor.__PropertyOffset_Int);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathFloatFloor.__PropertyOffset_Int) = value;
			}
		}

		// Token: 0x06005245 RID: 21061 RVA: 0x00078A70 File Offset: 0x00076C70
		public FRigUnit_MathFloatFloor()
		{
		}

		// Token: 0x06005246 RID: 21062 RVA: 0x00078A78 File Offset: 0x00076C78
		public FRigUnit_MathFloatFloor(float Value, float Result, int Int)
		{
			this.Value = Value;
			this.Result = Result;
			this.Int = Int;
		}

		// Token: 0x06005247 RID: 21063 RVA: 0x00078A95 File Offset: 0x00076C95
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_MathFloatFloor.StaticStruct();
		}

		// Token: 0x06005248 RID: 21064 RVA: 0x00078AA1 File Offset: 0x00076CA1
		[NullableContext(2)]
		public FRigUnit_MathFloatFloor(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06005249 RID: 21065 RVA: 0x00078AAB File Offset: 0x00076CAB
		public FRigUnit_MathFloatFloor(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600524A RID: 21066 RVA: 0x00078AB6 File Offset: 0x00076CB6
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_MathFloatFloor(Pointer, false, true);
		}

		// Token: 0x0600524B RID: 21067 RVA: 0x00078AC0 File Offset: 0x00076CC0
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_MathFloatFloor(Pointer, MemoryOwner);
		}

		// Token: 0x04002768 RID: 10088
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_MathFloatFloor";

		// Token: 0x04002769 RID: 10089
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400276A RID: 10090
		internal static int __PropertyOffset_Value;

		// Token: 0x0400276B RID: 10091
		internal static int __PropertyOffset_Result;

		// Token: 0x0400276C RID: 10092
		internal static int __PropertyOffset_Int;
	}
}
