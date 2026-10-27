using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020005A6 RID: 1446
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ControlRig.RigUnit_FABRIKPerItem")]
	[UnrealStructLayout(256, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 256)]
	public class FRigUnit_FABRIKPerItem : FRigUnit_HighlevelBaseMutable, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06004D9D RID: 19869 RVA: 0x00072978 File Offset: 0x00070B78
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_FABRIKPerItem._ScriptStructPtr != 0) ? FRigUnit_FABRIKPerItem._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_FABRIKPerItem", ref FRigUnit_FABRIKPerItem._ScriptStructPtr);
		}

		// Token: 0x1700130C RID: 4876
		// (get) Token: 0x06004D9E RID: 19870 RVA: 0x0007299C File Offset: 0x00070B9C
		// (set) Token: 0x06004D9F RID: 19871 RVA: 0x000729DF File Offset: 0x00070BDF
		public FRigElementKeyCollection Items
		{
			get
			{
				base.FastCheckIsValid();
				FRigElementKeyCollection result;
				if ((result = this._Items) == null)
				{
					result = (this._Items = new FRigElementKeyCollection(base.NativePtr + (IntPtr)FRigUnit_FABRIKPerItem.__PropertyOffset_Items, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRigElementKeyCollection.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_FABRIKPerItem.__PropertyOffset_Items, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700130D RID: 4877
		// (get) Token: 0x06004DA0 RID: 19872 RVA: 0x00072A00 File Offset: 0x00070C00
		// (set) Token: 0x06004DA1 RID: 19873 RVA: 0x00072A14 File Offset: 0x00070C14
		public unsafe FTransform EffectorTransform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_FABRIKPerItem.__PropertyOffset_EffectorTransform);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_FABRIKPerItem.__PropertyOffset_EffectorTransform) = value;
			}
		}

		// Token: 0x1700130E RID: 4878
		// (get) Token: 0x06004DA2 RID: 19874 RVA: 0x00072A29 File Offset: 0x00070C29
		// (set) Token: 0x06004DA3 RID: 19875 RVA: 0x00072A39 File Offset: 0x00070C39
		public unsafe float Precision
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_FABRIKPerItem.__PropertyOffset_Precision);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_FABRIKPerItem.__PropertyOffset_Precision) = value;
			}
		}

		// Token: 0x1700130F RID: 4879
		// (get) Token: 0x06004DA4 RID: 19876 RVA: 0x00072A4A File Offset: 0x00070C4A
		// (set) Token: 0x06004DA5 RID: 19877 RVA: 0x00072A5A File Offset: 0x00070C5A
		public unsafe float Weight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_FABRIKPerItem.__PropertyOffset_Weight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_FABRIKPerItem.__PropertyOffset_Weight) = value;
			}
		}

		// Token: 0x17001310 RID: 4880
		// (get) Token: 0x06004DA6 RID: 19878 RVA: 0x00072A6B File Offset: 0x00070C6B
		// (set) Token: 0x06004DA7 RID: 19879 RVA: 0x00072A7B File Offset: 0x00070C7B
		public unsafe bool bPropagateToChildren
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_FABRIKPerItem.__PropertyOffset_bPropagateToChildren) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_FABRIKPerItem.__PropertyOffset_bPropagateToChildren) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001311 RID: 4881
		// (get) Token: 0x06004DA8 RID: 19880 RVA: 0x00072A8C File Offset: 0x00070C8C
		// (set) Token: 0x06004DA9 RID: 19881 RVA: 0x00072A9C File Offset: 0x00070C9C
		public unsafe int MaxIterations
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_FABRIKPerItem.__PropertyOffset_MaxIterations);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_FABRIKPerItem.__PropertyOffset_MaxIterations) = value;
			}
		}

		// Token: 0x17001312 RID: 4882
		// (get) Token: 0x06004DAA RID: 19882 RVA: 0x00072AB0 File Offset: 0x00070CB0
		// (set) Token: 0x06004DAB RID: 19883 RVA: 0x00072AF3 File Offset: 0x00070CF3
		public FRigUnit_FABRIK_WorkData WorkData
		{
			get
			{
				base.FastCheckIsValid();
				FRigUnit_FABRIK_WorkData result;
				if ((result = this._WorkData) == null)
				{
					result = (this._WorkData = new FRigUnit_FABRIK_WorkData(base.NativePtr + (IntPtr)FRigUnit_FABRIKPerItem.__PropertyOffset_WorkData, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRigUnit_FABRIK_WorkData.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_FABRIKPerItem.__PropertyOffset_WorkData, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06004DAC RID: 19884 RVA: 0x00072B14 File Offset: 0x00070D14
		public FRigUnit_FABRIKPerItem()
		{
		}

		// Token: 0x06004DAD RID: 19885 RVA: 0x00072B1C File Offset: 0x00070D1C
		public FRigUnit_FABRIKPerItem(FRigElementKeyCollection Items, FTransform EffectorTransform, float Precision, float Weight, bool bPropagateToChildren, int MaxIterations, FRigUnit_FABRIK_WorkData WorkData, FControlRigExecuteContext ExecuteContext)
		{
			this.Items = Items;
			this.EffectorTransform = EffectorTransform;
			this.Precision = Precision;
			this.Weight = Weight;
			this.bPropagateToChildren = bPropagateToChildren;
			this.MaxIterations = MaxIterations;
			this.WorkData = WorkData;
			base.ExecuteContext = ExecuteContext;
		}

		// Token: 0x06004DAE RID: 19886 RVA: 0x00072B6C File Offset: 0x00070D6C
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_FABRIKPerItem.StaticStruct();
		}

		// Token: 0x06004DAF RID: 19887 RVA: 0x00072B78 File Offset: 0x00070D78
		[NullableContext(2)]
		public FRigUnit_FABRIKPerItem(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06004DB0 RID: 19888 RVA: 0x00072B82 File Offset: 0x00070D82
		public FRigUnit_FABRIKPerItem(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06004DB1 RID: 19889 RVA: 0x00072B8D File Offset: 0x00070D8D
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_FABRIKPerItem(Pointer, false, true);
		}

		// Token: 0x06004DB2 RID: 19890 RVA: 0x00072B97 File Offset: 0x00070D97
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_FABRIKPerItem(Pointer, MemoryOwner);
		}

		// Token: 0x04002578 RID: 9592
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_FABRIKPerItem";

		// Token: 0x04002579 RID: 9593
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400257A RID: 9594
		internal static int __PropertyOffset_Items;

		// Token: 0x0400257B RID: 9595
		[Nullable(2)]
		private FRigElementKeyCollection _Items;

		// Token: 0x0400257C RID: 9596
		internal static int __PropertyOffset_EffectorTransform;

		// Token: 0x0400257D RID: 9597
		internal static int __PropertyOffset_Precision;

		// Token: 0x0400257E RID: 9598
		internal static int __PropertyOffset_Weight;

		// Token: 0x0400257F RID: 9599
		internal static int __PropertyOffset_bPropagateToChildren;

		// Token: 0x04002580 RID: 9600
		internal static int __PropertyOffset_MaxIterations;

		// Token: 0x04002581 RID: 9601
		internal static int __PropertyOffset_WorkData;

		// Token: 0x04002582 RID: 9602
		[Nullable(2)]
		private FRigUnit_FABRIK_WorkData _WorkData;
	}
}
