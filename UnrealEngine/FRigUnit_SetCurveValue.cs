using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020006C0 RID: 1728
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ControlRig.RigUnit_SetCurveValue")]
	[UnrealStructLayout(152, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 152)]
	public class FRigUnit_SetCurveValue : FRigUnitMutable, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06005C63 RID: 23651 RVA: 0x00084A1A File Offset: 0x00082C1A
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_SetCurveValue._ScriptStructPtr != 0) ? FRigUnit_SetCurveValue._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_SetCurveValue", ref FRigUnit_SetCurveValue._ScriptStructPtr);
		}

		// Token: 0x1700160F RID: 5647
		// (get) Token: 0x06005C64 RID: 23652 RVA: 0x00084A3E File Offset: 0x00082C3E
		// (set) Token: 0x06005C65 RID: 23653 RVA: 0x00084A52 File Offset: 0x00082C52
		public unsafe FName Curve
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_SetCurveValue.__PropertyOffset_Curve);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_SetCurveValue.__PropertyOffset_Curve) = value;
			}
		}

		// Token: 0x17001610 RID: 5648
		// (get) Token: 0x06005C66 RID: 23654 RVA: 0x00084A67 File Offset: 0x00082C67
		// (set) Token: 0x06005C67 RID: 23655 RVA: 0x00084A77 File Offset: 0x00082C77
		public unsafe float Value
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_SetCurveValue.__PropertyOffset_Value);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_SetCurveValue.__PropertyOffset_Value) = value;
			}
		}

		// Token: 0x17001611 RID: 5649
		// (get) Token: 0x06005C68 RID: 23656 RVA: 0x00084A88 File Offset: 0x00082C88
		// (set) Token: 0x06005C69 RID: 23657 RVA: 0x00084ACB File Offset: 0x00082CCB
		public FCachedRigElement CachedCurveIndex
		{
			get
			{
				base.FastCheckIsValid();
				FCachedRigElement result;
				if ((result = this._CachedCurveIndex) == null)
				{
					result = (this._CachedCurveIndex = new FCachedRigElement(base.NativePtr + (IntPtr)FRigUnit_SetCurveValue.__PropertyOffset_CachedCurveIndex, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FCachedRigElement.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_SetCurveValue.__PropertyOffset_CachedCurveIndex, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06005C6A RID: 23658 RVA: 0x00084AEC File Offset: 0x00082CEC
		public FRigUnit_SetCurveValue()
		{
		}

		// Token: 0x06005C6B RID: 23659 RVA: 0x00084AF4 File Offset: 0x00082CF4
		public FRigUnit_SetCurveValue(FName Curve, float Value, FCachedRigElement CachedCurveIndex, FControlRigExecuteContext ExecuteContext)
		{
			this.Curve = Curve;
			this.Value = Value;
			this.CachedCurveIndex = CachedCurveIndex;
			base.ExecuteContext = ExecuteContext;
		}

		// Token: 0x06005C6C RID: 23660 RVA: 0x00084B19 File Offset: 0x00082D19
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_SetCurveValue.StaticStruct();
		}

		// Token: 0x06005C6D RID: 23661 RVA: 0x00084B25 File Offset: 0x00082D25
		[NullableContext(2)]
		public FRigUnit_SetCurveValue(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06005C6E RID: 23662 RVA: 0x00084B2F File Offset: 0x00082D2F
		public FRigUnit_SetCurveValue(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06005C6F RID: 23663 RVA: 0x00084B3A File Offset: 0x00082D3A
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_SetCurveValue(Pointer, false, true);
		}

		// Token: 0x06005C70 RID: 23664 RVA: 0x00084B44 File Offset: 0x00082D44
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_SetCurveValue(Pointer, MemoryOwner);
		}

		// Token: 0x04002B3E RID: 11070
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_SetCurveValue";

		// Token: 0x04002B3F RID: 11071
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002B40 RID: 11072
		internal static int __PropertyOffset_Curve;

		// Token: 0x04002B41 RID: 11073
		internal static int __PropertyOffset_Value;

		// Token: 0x04002B42 RID: 11074
		internal static int __PropertyOffset_CachedCurveIndex;

		// Token: 0x04002B43 RID: 11075
		[Nullable(2)]
		private FCachedRigElement _CachedCurveIndex;
	}
}
