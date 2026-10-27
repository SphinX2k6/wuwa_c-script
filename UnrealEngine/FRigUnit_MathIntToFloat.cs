using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200062C RID: 1580
	[UnrealObjectPath("/Script/ControlRig.RigUnit_MathIntToFloat")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FRigUnit_MathIntToFloat : FRigUnit_MathIntBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06005467 RID: 21607 RVA: 0x0007AC84 File Offset: 0x00078E84
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_MathIntToFloat._ScriptStructPtr != 0) ? FRigUnit_MathIntToFloat._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_MathIntToFloat", ref FRigUnit_MathIntToFloat._ScriptStructPtr);
		}

		// Token: 0x1700145D RID: 5213
		// (get) Token: 0x06005468 RID: 21608 RVA: 0x0007ACA8 File Offset: 0x00078EA8
		// (set) Token: 0x06005469 RID: 21609 RVA: 0x0007ACB8 File Offset: 0x00078EB8
		public unsafe int Value
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathIntToFloat.__PropertyOffset_Value);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathIntToFloat.__PropertyOffset_Value) = value;
			}
		}

		// Token: 0x1700145E RID: 5214
		// (get) Token: 0x0600546A RID: 21610 RVA: 0x0007ACC9 File Offset: 0x00078EC9
		// (set) Token: 0x0600546B RID: 21611 RVA: 0x0007ACD9 File Offset: 0x00078ED9
		public unsafe float Result
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathIntToFloat.__PropertyOffset_Result);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathIntToFloat.__PropertyOffset_Result) = value;
			}
		}

		// Token: 0x0600546C RID: 21612 RVA: 0x0007ACEA File Offset: 0x00078EEA
		public FRigUnit_MathIntToFloat()
		{
		}

		// Token: 0x0600546D RID: 21613 RVA: 0x0007ACF2 File Offset: 0x00078EF2
		public FRigUnit_MathIntToFloat(int Value, float Result)
		{
			this.Value = Value;
			this.Result = Result;
		}

		// Token: 0x0600546E RID: 21614 RVA: 0x0007AD08 File Offset: 0x00078F08
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_MathIntToFloat.StaticStruct();
		}

		// Token: 0x0600546F RID: 21615 RVA: 0x0007AD14 File Offset: 0x00078F14
		[NullableContext(2)]
		public FRigUnit_MathIntToFloat(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06005470 RID: 21616 RVA: 0x0007AD1E File Offset: 0x00078F1E
		public FRigUnit_MathIntToFloat(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06005471 RID: 21617 RVA: 0x0007AD29 File Offset: 0x00078F29
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_MathIntToFloat(Pointer, false, true);
		}

		// Token: 0x06005472 RID: 21618 RVA: 0x0007AD33 File Offset: 0x00078F33
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_MathIntToFloat(Pointer, MemoryOwner);
		}

		// Token: 0x0400281D RID: 10269
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_MathIntToFloat";

		// Token: 0x0400281E RID: 10270
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400281F RID: 10271
		internal static int __PropertyOffset_Value;

		// Token: 0x04002820 RID: 10272
		internal static int __PropertyOffset_Result;
	}
}
