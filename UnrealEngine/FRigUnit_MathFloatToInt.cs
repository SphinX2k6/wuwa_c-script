using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000615 RID: 1557
	[UnrealObjectPath("/Script/ControlRig.RigUnit_MathFloatToInt")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FRigUnit_MathFloatToInt : FRigUnit_MathFloatBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600536A RID: 21354 RVA: 0x00079CBE File Offset: 0x00077EBE
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_MathFloatToInt._ScriptStructPtr != 0) ? FRigUnit_MathFloatToInt._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_MathFloatToInt", ref FRigUnit_MathFloatToInt._ScriptStructPtr);
		}

		// Token: 0x1700143A RID: 5178
		// (get) Token: 0x0600536B RID: 21355 RVA: 0x00079CE2 File Offset: 0x00077EE2
		// (set) Token: 0x0600536C RID: 21356 RVA: 0x00079CF2 File Offset: 0x00077EF2
		public unsafe float Value
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathFloatToInt.__PropertyOffset_Value);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathFloatToInt.__PropertyOffset_Value) = value;
			}
		}

		// Token: 0x1700143B RID: 5179
		// (get) Token: 0x0600536D RID: 21357 RVA: 0x00079D03 File Offset: 0x00077F03
		// (set) Token: 0x0600536E RID: 21358 RVA: 0x00079D13 File Offset: 0x00077F13
		public unsafe int Result
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathFloatToInt.__PropertyOffset_Result);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathFloatToInt.__PropertyOffset_Result) = value;
			}
		}

		// Token: 0x0600536F RID: 21359 RVA: 0x00079D24 File Offset: 0x00077F24
		public FRigUnit_MathFloatToInt()
		{
		}

		// Token: 0x06005370 RID: 21360 RVA: 0x00079D2C File Offset: 0x00077F2C
		public FRigUnit_MathFloatToInt(float Value, int Result)
		{
			this.Value = Value;
			this.Result = Result;
		}

		// Token: 0x06005371 RID: 21361 RVA: 0x00079D42 File Offset: 0x00077F42
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_MathFloatToInt.StaticStruct();
		}

		// Token: 0x06005372 RID: 21362 RVA: 0x00079D4E File Offset: 0x00077F4E
		[NullableContext(2)]
		public FRigUnit_MathFloatToInt(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06005373 RID: 21363 RVA: 0x00079D58 File Offset: 0x00077F58
		public FRigUnit_MathFloatToInt(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06005374 RID: 21364 RVA: 0x00079D63 File Offset: 0x00077F63
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_MathFloatToInt(Pointer, false, true);
		}

		// Token: 0x06005375 RID: 21365 RVA: 0x00079D6D File Offset: 0x00077F6D
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_MathFloatToInt(Pointer, MemoryOwner);
		}

		// Token: 0x040027CC RID: 10188
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_MathFloatToInt";

		// Token: 0x040027CD RID: 10189
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040027CE RID: 10190
		internal static int __PropertyOffset_Value;

		// Token: 0x040027CF RID: 10191
		internal static int __PropertyOffset_Result;
	}
}
