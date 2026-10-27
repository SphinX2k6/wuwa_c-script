using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020005E7 RID: 1511
	[UnrealObjectPath("/Script/ControlRig.RigUnit_MathColorFromFloat")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FRigUnit_MathColorFromFloat : FRigUnit_MathColorBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600516F RID: 20847 RVA: 0x00077D6A File Offset: 0x00075F6A
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_MathColorFromFloat._ScriptStructPtr != 0) ? FRigUnit_MathColorFromFloat._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_MathColorFromFloat", ref FRigUnit_MathColorFromFloat._ScriptStructPtr);
		}

		// Token: 0x170013F4 RID: 5108
		// (get) Token: 0x06005170 RID: 20848 RVA: 0x00077D8E File Offset: 0x00075F8E
		// (set) Token: 0x06005171 RID: 20849 RVA: 0x00077D9E File Offset: 0x00075F9E
		public unsafe float Value
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathColorFromFloat.__PropertyOffset_Value);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathColorFromFloat.__PropertyOffset_Value) = value;
			}
		}

		// Token: 0x170013F5 RID: 5109
		// (get) Token: 0x06005172 RID: 20850 RVA: 0x00077DAF File Offset: 0x00075FAF
		// (set) Token: 0x06005173 RID: 20851 RVA: 0x00077DC3 File Offset: 0x00075FC3
		public unsafe FLinearColor Result
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathColorFromFloat.__PropertyOffset_Result);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathColorFromFloat.__PropertyOffset_Result) = value;
			}
		}

		// Token: 0x06005174 RID: 20852 RVA: 0x00077DD8 File Offset: 0x00075FD8
		public FRigUnit_MathColorFromFloat()
		{
		}

		// Token: 0x06005175 RID: 20853 RVA: 0x00077DE0 File Offset: 0x00075FE0
		public FRigUnit_MathColorFromFloat(float Value, FLinearColor Result)
		{
			this.Value = Value;
			this.Result = Result;
		}

		// Token: 0x06005176 RID: 20854 RVA: 0x00077DF6 File Offset: 0x00075FF6
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_MathColorFromFloat.StaticStruct();
		}

		// Token: 0x06005177 RID: 20855 RVA: 0x00077E02 File Offset: 0x00076002
		[NullableContext(2)]
		public FRigUnit_MathColorFromFloat(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06005178 RID: 20856 RVA: 0x00077E0C File Offset: 0x0007600C
		public FRigUnit_MathColorFromFloat(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06005179 RID: 20857 RVA: 0x00077E17 File Offset: 0x00076017
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_MathColorFromFloat(Pointer, false, true);
		}

		// Token: 0x0600517A RID: 20858 RVA: 0x00077E21 File Offset: 0x00076021
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_MathColorFromFloat(Pointer, MemoryOwner);
		}

		// Token: 0x0400272A RID: 10026
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_MathColorFromFloat";

		// Token: 0x0400272B RID: 10027
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400272C RID: 10028
		internal static int __PropertyOffset_Value;

		// Token: 0x0400272D RID: 10029
		internal static int __PropertyOffset_Result;
	}
}
