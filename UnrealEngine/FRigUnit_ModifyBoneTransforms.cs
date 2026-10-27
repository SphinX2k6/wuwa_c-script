using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200068E RID: 1678
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ControlRig.RigUnit_ModifyBoneTransforms")]
	[UnrealStructLayout(160, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 160)]
	public class FRigUnit_ModifyBoneTransforms : FRigUnit_HighlevelBaseMutable, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600592D RID: 22829 RVA: 0x0008036B File Offset: 0x0007E56B
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_ModifyBoneTransforms._ScriptStructPtr != 0) ? FRigUnit_ModifyBoneTransforms._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_ModifyBoneTransforms", ref FRigUnit_ModifyBoneTransforms._ScriptStructPtr);
		}

		// Token: 0x1700153B RID: 5435
		// (get) Token: 0x0600592E RID: 22830 RVA: 0x00080390 File Offset: 0x0007E590
		// (set) Token: 0x0600592F RID: 22831 RVA: 0x000803D3 File Offset: 0x0007E5D3
		public TArray<FRigUnit_ModifyBoneTransforms_PerBone> BoneToModify
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FRigUnit_ModifyBoneTransforms_PerBone> result;
				if ((result = this._BoneToModify) == null)
				{
					result = (this._BoneToModify = new TArray<FRigUnit_ModifyBoneTransforms_PerBone>(base.NativePtr + (IntPtr)FRigUnit_ModifyBoneTransforms.__PropertyOffset_BoneToModify, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.BoneToModify.CopyAssign(value);
			}
		}

		// Token: 0x1700153C RID: 5436
		// (get) Token: 0x06005930 RID: 22832 RVA: 0x000803E1 File Offset: 0x0007E5E1
		// (set) Token: 0x06005931 RID: 22833 RVA: 0x000803F1 File Offset: 0x0007E5F1
		public unsafe float Weight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_ModifyBoneTransforms.__PropertyOffset_Weight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_ModifyBoneTransforms.__PropertyOffset_Weight) = value;
			}
		}

		// Token: 0x1700153D RID: 5437
		// (get) Token: 0x06005932 RID: 22834 RVA: 0x00080402 File Offset: 0x0007E602
		// (set) Token: 0x06005933 RID: 22835 RVA: 0x00080412 File Offset: 0x0007E612
		public unsafe float WeightMinimum
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_ModifyBoneTransforms.__PropertyOffset_WeightMinimum);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_ModifyBoneTransforms.__PropertyOffset_WeightMinimum) = value;
			}
		}

		// Token: 0x1700153E RID: 5438
		// (get) Token: 0x06005934 RID: 22836 RVA: 0x00080423 File Offset: 0x0007E623
		// (set) Token: 0x06005935 RID: 22837 RVA: 0x00080433 File Offset: 0x0007E633
		public unsafe float WeightMaximum
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_ModifyBoneTransforms.__PropertyOffset_WeightMaximum);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_ModifyBoneTransforms.__PropertyOffset_WeightMaximum) = value;
			}
		}

		// Token: 0x1700153F RID: 5439
		// (get) Token: 0x06005936 RID: 22838 RVA: 0x00080444 File Offset: 0x0007E644
		// (set) Token: 0x06005937 RID: 22839 RVA: 0x00080454 File Offset: 0x0007E654
		public unsafe EControlRigModifyBoneMode Mode
		{
			get
			{
				return (EControlRigModifyBoneMode)(*(base.NativePtr + (IntPtr)FRigUnit_ModifyBoneTransforms.__PropertyOffset_Mode));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_ModifyBoneTransforms.__PropertyOffset_Mode) = (byte)value;
			}
		}

		// Token: 0x17001540 RID: 5440
		// (get) Token: 0x06005938 RID: 22840 RVA: 0x00080468 File Offset: 0x0007E668
		// (set) Token: 0x06005939 RID: 22841 RVA: 0x000804AB File Offset: 0x0007E6AB
		public FRigUnit_ModifyBoneTransforms_WorkData WorkData
		{
			get
			{
				base.FastCheckIsValid();
				FRigUnit_ModifyBoneTransforms_WorkData result;
				if ((result = this._WorkData) == null)
				{
					result = (this._WorkData = new FRigUnit_ModifyBoneTransforms_WorkData(base.NativePtr + (IntPtr)FRigUnit_ModifyBoneTransforms.__PropertyOffset_WorkData, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRigUnit_ModifyBoneTransforms_WorkData.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_ModifyBoneTransforms.__PropertyOffset_WorkData, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0600593A RID: 22842 RVA: 0x000804CC File Offset: 0x0007E6CC
		public FRigUnit_ModifyBoneTransforms()
		{
		}

		// Token: 0x0600593B RID: 22843 RVA: 0x000804D4 File Offset: 0x0007E6D4
		public FRigUnit_ModifyBoneTransforms(TArray<FRigUnit_ModifyBoneTransforms_PerBone> BoneToModify, float Weight, float WeightMinimum, float WeightMaximum, EControlRigModifyBoneMode Mode, FRigUnit_ModifyBoneTransforms_WorkData WorkData, FControlRigExecuteContext ExecuteContext)
		{
			this.BoneToModify = BoneToModify;
			this.Weight = Weight;
			this.WeightMinimum = WeightMinimum;
			this.WeightMaximum = WeightMaximum;
			this.Mode = Mode;
			this.WorkData = WorkData;
			base.ExecuteContext = ExecuteContext;
		}

		// Token: 0x0600593C RID: 22844 RVA: 0x00080511 File Offset: 0x0007E711
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_ModifyBoneTransforms.StaticStruct();
		}

		// Token: 0x0600593D RID: 22845 RVA: 0x0008051D File Offset: 0x0007E71D
		[NullableContext(2)]
		public FRigUnit_ModifyBoneTransforms(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600593E RID: 22846 RVA: 0x00080527 File Offset: 0x0007E727
		public FRigUnit_ModifyBoneTransforms(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600593F RID: 22847 RVA: 0x00080532 File Offset: 0x0007E732
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_ModifyBoneTransforms(Pointer, false, true);
		}

		// Token: 0x06005940 RID: 22848 RVA: 0x0008053C File Offset: 0x0007E73C
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_ModifyBoneTransforms(Pointer, MemoryOwner);
		}

		// Token: 0x040029D0 RID: 10704
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_ModifyBoneTransforms";

		// Token: 0x040029D1 RID: 10705
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040029D2 RID: 10706
		internal static int __PropertyOffset_BoneToModify;

		// Token: 0x040029D3 RID: 10707
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FRigUnit_ModifyBoneTransforms_PerBone> _BoneToModify;

		// Token: 0x040029D4 RID: 10708
		internal static int __PropertyOffset_Weight;

		// Token: 0x040029D5 RID: 10709
		internal static int __PropertyOffset_WeightMinimum;

		// Token: 0x040029D6 RID: 10710
		internal static int __PropertyOffset_WeightMaximum;

		// Token: 0x040029D7 RID: 10711
		internal static int __PropertyOffset_Mode;

		// Token: 0x040029D8 RID: 10712
		internal static int __PropertyOffset_WorkData;

		// Token: 0x040029D9 RID: 10713
		[Nullable(2)]
		private FRigUnit_ModifyBoneTransforms_WorkData _WorkData;
	}
}
