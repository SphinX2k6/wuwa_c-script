using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020006F0 RID: 1776
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ControlRig.RigUnit_TwistBonesPerItem")]
	[UnrealStructLayout(216, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 216)]
	public class FRigUnit_TwistBonesPerItem : FRigUnit_HighlevelBaseMutable, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06005F74 RID: 24436 RVA: 0x00088D84 File Offset: 0x00086F84
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_TwistBonesPerItem._ScriptStructPtr != 0) ? FRigUnit_TwistBonesPerItem._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_TwistBonesPerItem", ref FRigUnit_TwistBonesPerItem._ScriptStructPtr);
		}

		// Token: 0x170016D8 RID: 5848
		// (get) Token: 0x06005F75 RID: 24437 RVA: 0x00088DA8 File Offset: 0x00086FA8
		// (set) Token: 0x06005F76 RID: 24438 RVA: 0x00088DEB File Offset: 0x00086FEB
		public FRigElementKeyCollection Items
		{
			get
			{
				base.FastCheckIsValid();
				FRigElementKeyCollection result;
				if ((result = this._Items) == null)
				{
					result = (this._Items = new FRigElementKeyCollection(base.NativePtr + (IntPtr)FRigUnit_TwistBonesPerItem.__PropertyOffset_Items, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRigElementKeyCollection.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_TwistBonesPerItem.__PropertyOffset_Items, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170016D9 RID: 5849
		// (get) Token: 0x06005F77 RID: 24439 RVA: 0x00088E0C File Offset: 0x0008700C
		// (set) Token: 0x06005F78 RID: 24440 RVA: 0x00088E20 File Offset: 0x00087020
		public unsafe FVector TwistAxis
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_TwistBonesPerItem.__PropertyOffset_TwistAxis);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_TwistBonesPerItem.__PropertyOffset_TwistAxis) = value;
			}
		}

		// Token: 0x170016DA RID: 5850
		// (get) Token: 0x06005F79 RID: 24441 RVA: 0x00088E35 File Offset: 0x00087035
		// (set) Token: 0x06005F7A RID: 24442 RVA: 0x00088E49 File Offset: 0x00087049
		public unsafe FVector PoleAxis
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_TwistBonesPerItem.__PropertyOffset_PoleAxis);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_TwistBonesPerItem.__PropertyOffset_PoleAxis) = value;
			}
		}

		// Token: 0x170016DB RID: 5851
		// (get) Token: 0x06005F7B RID: 24443 RVA: 0x00088E5E File Offset: 0x0008705E
		// (set) Token: 0x06005F7C RID: 24444 RVA: 0x00088E6E File Offset: 0x0008706E
		public unsafe EControlRigAnimEasingType TwistEaseType
		{
			get
			{
				return (EControlRigAnimEasingType)(*(base.NativePtr + (IntPtr)FRigUnit_TwistBonesPerItem.__PropertyOffset_TwistEaseType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_TwistBonesPerItem.__PropertyOffset_TwistEaseType) = (byte)value;
			}
		}

		// Token: 0x170016DC RID: 5852
		// (get) Token: 0x06005F7D RID: 24445 RVA: 0x00088E7F File Offset: 0x0008707F
		// (set) Token: 0x06005F7E RID: 24446 RVA: 0x00088E8F File Offset: 0x0008708F
		public unsafe float Weight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_TwistBonesPerItem.__PropertyOffset_Weight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_TwistBonesPerItem.__PropertyOffset_Weight) = value;
			}
		}

		// Token: 0x170016DD RID: 5853
		// (get) Token: 0x06005F7F RID: 24447 RVA: 0x00088EA0 File Offset: 0x000870A0
		// (set) Token: 0x06005F80 RID: 24448 RVA: 0x00088EB0 File Offset: 0x000870B0
		public unsafe bool bPropagateToChildren
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_TwistBonesPerItem.__PropertyOffset_bPropagateToChildren) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_TwistBonesPerItem.__PropertyOffset_bPropagateToChildren) = (value ? 1 : 0);
			}
		}

		// Token: 0x170016DE RID: 5854
		// (get) Token: 0x06005F81 RID: 24449 RVA: 0x00088EC4 File Offset: 0x000870C4
		// (set) Token: 0x06005F82 RID: 24450 RVA: 0x00088F07 File Offset: 0x00087107
		public FRigUnit_TwistBones_WorkData WorkData
		{
			get
			{
				base.FastCheckIsValid();
				FRigUnit_TwistBones_WorkData result;
				if ((result = this._WorkData) == null)
				{
					result = (this._WorkData = new FRigUnit_TwistBones_WorkData(base.NativePtr + (IntPtr)FRigUnit_TwistBonesPerItem.__PropertyOffset_WorkData, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRigUnit_TwistBones_WorkData.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_TwistBonesPerItem.__PropertyOffset_WorkData, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06005F83 RID: 24451 RVA: 0x00088F28 File Offset: 0x00087128
		public FRigUnit_TwistBonesPerItem()
		{
		}

		// Token: 0x06005F84 RID: 24452 RVA: 0x00088F30 File Offset: 0x00087130
		public FRigUnit_TwistBonesPerItem(FRigElementKeyCollection Items, FVector TwistAxis, FVector PoleAxis, EControlRigAnimEasingType TwistEaseType, float Weight, bool bPropagateToChildren, FRigUnit_TwistBones_WorkData WorkData, FControlRigExecuteContext ExecuteContext)
		{
			this.Items = Items;
			this.TwistAxis = TwistAxis;
			this.PoleAxis = PoleAxis;
			this.TwistEaseType = TwistEaseType;
			this.Weight = Weight;
			this.bPropagateToChildren = bPropagateToChildren;
			this.WorkData = WorkData;
			base.ExecuteContext = ExecuteContext;
		}

		// Token: 0x06005F85 RID: 24453 RVA: 0x00088F80 File Offset: 0x00087180
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_TwistBonesPerItem.StaticStruct();
		}

		// Token: 0x06005F86 RID: 24454 RVA: 0x00088F8C File Offset: 0x0008718C
		[NullableContext(2)]
		public FRigUnit_TwistBonesPerItem(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06005F87 RID: 24455 RVA: 0x00088F96 File Offset: 0x00087196
		public FRigUnit_TwistBonesPerItem(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06005F88 RID: 24456 RVA: 0x00088FA1 File Offset: 0x000871A1
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_TwistBonesPerItem(Pointer, false, true);
		}

		// Token: 0x06005F89 RID: 24457 RVA: 0x00088FAB File Offset: 0x000871AB
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_TwistBonesPerItem(Pointer, MemoryOwner);
		}

		// Token: 0x04002C9E RID: 11422
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_TwistBonesPerItem";

		// Token: 0x04002C9F RID: 11423
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002CA0 RID: 11424
		internal static int __PropertyOffset_Items;

		// Token: 0x04002CA1 RID: 11425
		[Nullable(2)]
		private FRigElementKeyCollection _Items;

		// Token: 0x04002CA2 RID: 11426
		internal static int __PropertyOffset_TwistAxis;

		// Token: 0x04002CA3 RID: 11427
		internal static int __PropertyOffset_PoleAxis;

		// Token: 0x04002CA4 RID: 11428
		internal static int __PropertyOffset_TwistEaseType;

		// Token: 0x04002CA5 RID: 11429
		internal static int __PropertyOffset_Weight;

		// Token: 0x04002CA6 RID: 11430
		internal static int __PropertyOffset_bPropagateToChildren;

		// Token: 0x04002CA7 RID: 11431
		internal static int __PropertyOffset_WorkData;

		// Token: 0x04002CA8 RID: 11432
		[Nullable(2)]
		private FRigUnit_TwistBones_WorkData _WorkData;
	}
}
