using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020005F3 RID: 1523
	[UnrealObjectPath("/Script/ControlRig.RigUnit_MathFloatClamp")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FRigUnit_MathFloatClamp : FRigUnit_MathFloatBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060051E6 RID: 20966 RVA: 0x000784BA File Offset: 0x000766BA
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_MathFloatClamp._ScriptStructPtr != 0) ? FRigUnit_MathFloatClamp._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_MathFloatClamp", ref FRigUnit_MathFloatClamp._ScriptStructPtr);
		}

		// Token: 0x17001400 RID: 5120
		// (get) Token: 0x060051E7 RID: 20967 RVA: 0x000784DE File Offset: 0x000766DE
		// (set) Token: 0x060051E8 RID: 20968 RVA: 0x000784EE File Offset: 0x000766EE
		public unsafe float Value
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathFloatClamp.__PropertyOffset_Value);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathFloatClamp.__PropertyOffset_Value) = value;
			}
		}

		// Token: 0x17001401 RID: 5121
		// (get) Token: 0x060051E9 RID: 20969 RVA: 0x000784FF File Offset: 0x000766FF
		// (set) Token: 0x060051EA RID: 20970 RVA: 0x0007850F File Offset: 0x0007670F
		public unsafe float Minimum
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathFloatClamp.__PropertyOffset_Minimum);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathFloatClamp.__PropertyOffset_Minimum) = value;
			}
		}

		// Token: 0x17001402 RID: 5122
		// (get) Token: 0x060051EB RID: 20971 RVA: 0x00078520 File Offset: 0x00076720
		// (set) Token: 0x060051EC RID: 20972 RVA: 0x00078530 File Offset: 0x00076730
		public unsafe float Maximum
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathFloatClamp.__PropertyOffset_Maximum);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathFloatClamp.__PropertyOffset_Maximum) = value;
			}
		}

		// Token: 0x17001403 RID: 5123
		// (get) Token: 0x060051ED RID: 20973 RVA: 0x00078541 File Offset: 0x00076741
		// (set) Token: 0x060051EE RID: 20974 RVA: 0x00078551 File Offset: 0x00076751
		public unsafe float Result
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathFloatClamp.__PropertyOffset_Result);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathFloatClamp.__PropertyOffset_Result) = value;
			}
		}

		// Token: 0x060051EF RID: 20975 RVA: 0x00078562 File Offset: 0x00076762
		public FRigUnit_MathFloatClamp()
		{
		}

		// Token: 0x060051F0 RID: 20976 RVA: 0x0007856A File Offset: 0x0007676A
		public FRigUnit_MathFloatClamp(float Value, float Minimum, float Maximum, float Result)
		{
			this.Value = Value;
			this.Minimum = Minimum;
			this.Maximum = Maximum;
			this.Result = Result;
		}

		// Token: 0x060051F1 RID: 20977 RVA: 0x0007858F File Offset: 0x0007678F
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_MathFloatClamp.StaticStruct();
		}

		// Token: 0x060051F2 RID: 20978 RVA: 0x0007859B File Offset: 0x0007679B
		[NullableContext(2)]
		public FRigUnit_MathFloatClamp(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060051F3 RID: 20979 RVA: 0x000785A5 File Offset: 0x000767A5
		public FRigUnit_MathFloatClamp(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060051F4 RID: 20980 RVA: 0x000785B0 File Offset: 0x000767B0
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_MathFloatClamp(Pointer, false, true);
		}

		// Token: 0x060051F5 RID: 20981 RVA: 0x000785BA File Offset: 0x000767BA
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_MathFloatClamp(Pointer, MemoryOwner);
		}

		// Token: 0x0400274E RID: 10062
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_MathFloatClamp";

		// Token: 0x0400274F RID: 10063
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002750 RID: 10064
		internal static int __PropertyOffset_Value;

		// Token: 0x04002751 RID: 10065
		internal static int __PropertyOffset_Minimum;

		// Token: 0x04002752 RID: 10066
		internal static int __PropertyOffset_Maximum;

		// Token: 0x04002753 RID: 10067
		internal static int __PropertyOffset_Result;
	}
}
