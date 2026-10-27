using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200055A RID: 1370
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ControlRig.RigUnit_CCDIKPerItem")]
	[UnrealStructLayout(320, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 320)]
	public class FRigUnit_CCDIKPerItem : FRigUnit_HighlevelBaseMutable, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600488B RID: 18571 RVA: 0x0006B848 File Offset: 0x00069A48
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_CCDIKPerItem._ScriptStructPtr != 0) ? FRigUnit_CCDIKPerItem._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_CCDIKPerItem", ref FRigUnit_CCDIKPerItem._ScriptStructPtr);
		}

		// Token: 0x170011B2 RID: 4530
		// (get) Token: 0x0600488C RID: 18572 RVA: 0x0006B86C File Offset: 0x00069A6C
		// (set) Token: 0x0600488D RID: 18573 RVA: 0x0006B8AF File Offset: 0x00069AAF
		public FRigElementKeyCollection Items
		{
			get
			{
				base.FastCheckIsValid();
				FRigElementKeyCollection result;
				if ((result = this._Items) == null)
				{
					result = (this._Items = new FRigElementKeyCollection(base.NativePtr + (IntPtr)FRigUnit_CCDIKPerItem.__PropertyOffset_Items, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRigElementKeyCollection.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_CCDIKPerItem.__PropertyOffset_Items, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170011B3 RID: 4531
		// (get) Token: 0x0600488E RID: 18574 RVA: 0x0006B8D0 File Offset: 0x00069AD0
		// (set) Token: 0x0600488F RID: 18575 RVA: 0x0006B8E4 File Offset: 0x00069AE4
		public unsafe FTransform EffectorTransform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_CCDIKPerItem.__PropertyOffset_EffectorTransform);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_CCDIKPerItem.__PropertyOffset_EffectorTransform) = value;
			}
		}

		// Token: 0x170011B4 RID: 4532
		// (get) Token: 0x06004890 RID: 18576 RVA: 0x0006B8F9 File Offset: 0x00069AF9
		// (set) Token: 0x06004891 RID: 18577 RVA: 0x0006B909 File Offset: 0x00069B09
		public unsafe float Precision
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_CCDIKPerItem.__PropertyOffset_Precision);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_CCDIKPerItem.__PropertyOffset_Precision) = value;
			}
		}

		// Token: 0x170011B5 RID: 4533
		// (get) Token: 0x06004892 RID: 18578 RVA: 0x0006B91A File Offset: 0x00069B1A
		// (set) Token: 0x06004893 RID: 18579 RVA: 0x0006B92A File Offset: 0x00069B2A
		public unsafe float Weight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_CCDIKPerItem.__PropertyOffset_Weight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_CCDIKPerItem.__PropertyOffset_Weight) = value;
			}
		}

		// Token: 0x170011B6 RID: 4534
		// (get) Token: 0x06004894 RID: 18580 RVA: 0x0006B93B File Offset: 0x00069B3B
		// (set) Token: 0x06004895 RID: 18581 RVA: 0x0006B94B File Offset: 0x00069B4B
		public unsafe int MaxIterations
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_CCDIKPerItem.__PropertyOffset_MaxIterations);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_CCDIKPerItem.__PropertyOffset_MaxIterations) = value;
			}
		}

		// Token: 0x170011B7 RID: 4535
		// (get) Token: 0x06004896 RID: 18582 RVA: 0x0006B95C File Offset: 0x00069B5C
		// (set) Token: 0x06004897 RID: 18583 RVA: 0x0006B96C File Offset: 0x00069B6C
		public unsafe bool bStartFromTail
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_CCDIKPerItem.__PropertyOffset_bStartFromTail) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_CCDIKPerItem.__PropertyOffset_bStartFromTail) = (value ? 1 : 0);
			}
		}

		// Token: 0x170011B8 RID: 4536
		// (get) Token: 0x06004898 RID: 18584 RVA: 0x0006B97D File Offset: 0x00069B7D
		// (set) Token: 0x06004899 RID: 18585 RVA: 0x0006B98D File Offset: 0x00069B8D
		public unsafe float BaseRotationLimit
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_CCDIKPerItem.__PropertyOffset_BaseRotationLimit);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_CCDIKPerItem.__PropertyOffset_BaseRotationLimit) = value;
			}
		}

		// Token: 0x170011B9 RID: 4537
		// (get) Token: 0x0600489A RID: 18586 RVA: 0x0006B9A0 File Offset: 0x00069BA0
		// (set) Token: 0x0600489B RID: 18587 RVA: 0x0006B9E3 File Offset: 0x00069BE3
		public TArray<FRigUnit_CCDIK_RotationLimitPerItem> RotationLimits
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FRigUnit_CCDIK_RotationLimitPerItem> result;
				if ((result = this._RotationLimits) == null)
				{
					result = (this._RotationLimits = new TArray<FRigUnit_CCDIK_RotationLimitPerItem>(base.NativePtr + (IntPtr)FRigUnit_CCDIKPerItem.__PropertyOffset_RotationLimits, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.RotationLimits.CopyAssign(value);
			}
		}

		// Token: 0x170011BA RID: 4538
		// (get) Token: 0x0600489C RID: 18588 RVA: 0x0006B9F1 File Offset: 0x00069BF1
		// (set) Token: 0x0600489D RID: 18589 RVA: 0x0006BA01 File Offset: 0x00069C01
		public unsafe bool bPropagateToChildren
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_CCDIKPerItem.__PropertyOffset_bPropagateToChildren) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_CCDIKPerItem.__PropertyOffset_bPropagateToChildren) = (value ? 1 : 0);
			}
		}

		// Token: 0x170011BB RID: 4539
		// (get) Token: 0x0600489E RID: 18590 RVA: 0x0006BA14 File Offset: 0x00069C14
		// (set) Token: 0x0600489F RID: 18591 RVA: 0x0006BA57 File Offset: 0x00069C57
		public FRigUnit_CCDIK_WorkData WorkData
		{
			get
			{
				base.FastCheckIsValid();
				FRigUnit_CCDIK_WorkData result;
				if ((result = this._WorkData) == null)
				{
					result = (this._WorkData = new FRigUnit_CCDIK_WorkData(base.NativePtr + (IntPtr)FRigUnit_CCDIKPerItem.__PropertyOffset_WorkData, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRigUnit_CCDIK_WorkData.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_CCDIKPerItem.__PropertyOffset_WorkData, value.NativePtr, 1, false);
			}
		}

		// Token: 0x060048A0 RID: 18592 RVA: 0x0006BA78 File Offset: 0x00069C78
		public FRigUnit_CCDIKPerItem()
		{
		}

		// Token: 0x060048A1 RID: 18593 RVA: 0x0006BA80 File Offset: 0x00069C80
		public FRigUnit_CCDIKPerItem(FRigElementKeyCollection Items, FTransform EffectorTransform, float Precision, float Weight, int MaxIterations, bool bStartFromTail, float BaseRotationLimit, TArray<FRigUnit_CCDIK_RotationLimitPerItem> RotationLimits, bool bPropagateToChildren, FRigUnit_CCDIK_WorkData WorkData, FControlRigExecuteContext ExecuteContext)
		{
			this.Items = Items;
			this.EffectorTransform = EffectorTransform;
			this.Precision = Precision;
			this.Weight = Weight;
			this.MaxIterations = MaxIterations;
			this.bStartFromTail = bStartFromTail;
			this.BaseRotationLimit = BaseRotationLimit;
			this.RotationLimits = RotationLimits;
			this.bPropagateToChildren = bPropagateToChildren;
			this.WorkData = WorkData;
			base.ExecuteContext = ExecuteContext;
		}

		// Token: 0x060048A2 RID: 18594 RVA: 0x0006BAE8 File Offset: 0x00069CE8
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_CCDIKPerItem.StaticStruct();
		}

		// Token: 0x060048A3 RID: 18595 RVA: 0x0006BAF4 File Offset: 0x00069CF4
		[NullableContext(2)]
		public FRigUnit_CCDIKPerItem(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060048A4 RID: 18596 RVA: 0x0006BAFE File Offset: 0x00069CFE
		public FRigUnit_CCDIKPerItem(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060048A5 RID: 18597 RVA: 0x0006BB09 File Offset: 0x00069D09
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_CCDIKPerItem(Pointer, false, true);
		}

		// Token: 0x060048A6 RID: 18598 RVA: 0x0006BB13 File Offset: 0x00069D13
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_CCDIKPerItem(Pointer, MemoryOwner);
		}

		// Token: 0x0400232F RID: 9007
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_CCDIKPerItem";

		// Token: 0x04002330 RID: 9008
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002331 RID: 9009
		internal static int __PropertyOffset_Items;

		// Token: 0x04002332 RID: 9010
		[Nullable(2)]
		private FRigElementKeyCollection _Items;

		// Token: 0x04002333 RID: 9011
		internal static int __PropertyOffset_EffectorTransform;

		// Token: 0x04002334 RID: 9012
		internal static int __PropertyOffset_Precision;

		// Token: 0x04002335 RID: 9013
		internal static int __PropertyOffset_Weight;

		// Token: 0x04002336 RID: 9014
		internal static int __PropertyOffset_MaxIterations;

		// Token: 0x04002337 RID: 9015
		internal static int __PropertyOffset_bStartFromTail;

		// Token: 0x04002338 RID: 9016
		internal static int __PropertyOffset_BaseRotationLimit;

		// Token: 0x04002339 RID: 9017
		internal static int __PropertyOffset_RotationLimits;

		// Token: 0x0400233A RID: 9018
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FRigUnit_CCDIK_RotationLimitPerItem> _RotationLimits;

		// Token: 0x0400233B RID: 9019
		internal static int __PropertyOffset_bPropagateToChildren;

		// Token: 0x0400233C RID: 9020
		internal static int __PropertyOffset_WorkData;

		// Token: 0x0400233D RID: 9021
		[Nullable(2)]
		private FRigUnit_CCDIK_WorkData _WorkData;
	}
}
