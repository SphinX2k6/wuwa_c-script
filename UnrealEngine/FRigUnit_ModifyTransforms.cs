using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000691 RID: 1681
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ControlRig.RigUnit_ModifyTransforms")]
	[UnrealStructLayout(160, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 160)]
	public class FRigUnit_ModifyTransforms : FRigUnit_HighlevelBaseMutable, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06005955 RID: 22869 RVA: 0x0008067C File Offset: 0x0007E87C
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_ModifyTransforms._ScriptStructPtr != 0) ? FRigUnit_ModifyTransforms._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_ModifyTransforms", ref FRigUnit_ModifyTransforms._ScriptStructPtr);
		}

		// Token: 0x17001543 RID: 5443
		// (get) Token: 0x06005956 RID: 22870 RVA: 0x000806A0 File Offset: 0x0007E8A0
		// (set) Token: 0x06005957 RID: 22871 RVA: 0x000806E3 File Offset: 0x0007E8E3
		public TArray<FRigUnit_ModifyTransforms_PerItem> ItemToModify
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FRigUnit_ModifyTransforms_PerItem> result;
				if ((result = this._ItemToModify) == null)
				{
					result = (this._ItemToModify = new TArray<FRigUnit_ModifyTransforms_PerItem>(base.NativePtr + (IntPtr)FRigUnit_ModifyTransforms.__PropertyOffset_ItemToModify, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ItemToModify.CopyAssign(value);
			}
		}

		// Token: 0x17001544 RID: 5444
		// (get) Token: 0x06005958 RID: 22872 RVA: 0x000806F1 File Offset: 0x0007E8F1
		// (set) Token: 0x06005959 RID: 22873 RVA: 0x00080701 File Offset: 0x0007E901
		public unsafe float Weight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_ModifyTransforms.__PropertyOffset_Weight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_ModifyTransforms.__PropertyOffset_Weight) = value;
			}
		}

		// Token: 0x17001545 RID: 5445
		// (get) Token: 0x0600595A RID: 22874 RVA: 0x00080712 File Offset: 0x0007E912
		// (set) Token: 0x0600595B RID: 22875 RVA: 0x00080722 File Offset: 0x0007E922
		public unsafe float WeightMinimum
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_ModifyTransforms.__PropertyOffset_WeightMinimum);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_ModifyTransforms.__PropertyOffset_WeightMinimum) = value;
			}
		}

		// Token: 0x17001546 RID: 5446
		// (get) Token: 0x0600595C RID: 22876 RVA: 0x00080733 File Offset: 0x0007E933
		// (set) Token: 0x0600595D RID: 22877 RVA: 0x00080743 File Offset: 0x0007E943
		public unsafe float WeightMaximum
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_ModifyTransforms.__PropertyOffset_WeightMaximum);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_ModifyTransforms.__PropertyOffset_WeightMaximum) = value;
			}
		}

		// Token: 0x17001547 RID: 5447
		// (get) Token: 0x0600595E RID: 22878 RVA: 0x00080754 File Offset: 0x0007E954
		// (set) Token: 0x0600595F RID: 22879 RVA: 0x00080764 File Offset: 0x0007E964
		public unsafe EControlRigModifyBoneMode Mode
		{
			get
			{
				return (EControlRigModifyBoneMode)(*(base.NativePtr + (IntPtr)FRigUnit_ModifyTransforms.__PropertyOffset_Mode));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_ModifyTransforms.__PropertyOffset_Mode) = (byte)value;
			}
		}

		// Token: 0x17001548 RID: 5448
		// (get) Token: 0x06005960 RID: 22880 RVA: 0x00080778 File Offset: 0x0007E978
		// (set) Token: 0x06005961 RID: 22881 RVA: 0x000807BB File Offset: 0x0007E9BB
		public FRigUnit_ModifyTransforms_WorkData WorkData
		{
			get
			{
				base.FastCheckIsValid();
				FRigUnit_ModifyTransforms_WorkData result;
				if ((result = this._WorkData) == null)
				{
					result = (this._WorkData = new FRigUnit_ModifyTransforms_WorkData(base.NativePtr + (IntPtr)FRigUnit_ModifyTransforms.__PropertyOffset_WorkData, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRigUnit_ModifyTransforms_WorkData.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_ModifyTransforms.__PropertyOffset_WorkData, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06005962 RID: 22882 RVA: 0x000807DC File Offset: 0x0007E9DC
		public FRigUnit_ModifyTransforms()
		{
		}

		// Token: 0x06005963 RID: 22883 RVA: 0x000807E4 File Offset: 0x0007E9E4
		public FRigUnit_ModifyTransforms(TArray<FRigUnit_ModifyTransforms_PerItem> ItemToModify, float Weight, float WeightMinimum, float WeightMaximum, EControlRigModifyBoneMode Mode, FRigUnit_ModifyTransforms_WorkData WorkData, FControlRigExecuteContext ExecuteContext)
		{
			this.ItemToModify = ItemToModify;
			this.Weight = Weight;
			this.WeightMinimum = WeightMinimum;
			this.WeightMaximum = WeightMaximum;
			this.Mode = Mode;
			this.WorkData = WorkData;
			base.ExecuteContext = ExecuteContext;
		}

		// Token: 0x06005964 RID: 22884 RVA: 0x00080821 File Offset: 0x0007EA21
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_ModifyTransforms.StaticStruct();
		}

		// Token: 0x06005965 RID: 22885 RVA: 0x0008082D File Offset: 0x0007EA2D
		[NullableContext(2)]
		public FRigUnit_ModifyTransforms(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06005966 RID: 22886 RVA: 0x00080837 File Offset: 0x0007EA37
		public FRigUnit_ModifyTransforms(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06005967 RID: 22887 RVA: 0x00080842 File Offset: 0x0007EA42
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_ModifyTransforms(Pointer, false, true);
		}

		// Token: 0x06005968 RID: 22888 RVA: 0x0008084C File Offset: 0x0007EA4C
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_ModifyTransforms(Pointer, MemoryOwner);
		}

		// Token: 0x040029E0 RID: 10720
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_ModifyTransforms";

		// Token: 0x040029E1 RID: 10721
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040029E2 RID: 10722
		internal static int __PropertyOffset_ItemToModify;

		// Token: 0x040029E3 RID: 10723
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FRigUnit_ModifyTransforms_PerItem> _ItemToModify;

		// Token: 0x040029E4 RID: 10724
		internal static int __PropertyOffset_Weight;

		// Token: 0x040029E5 RID: 10725
		internal static int __PropertyOffset_WeightMinimum;

		// Token: 0x040029E6 RID: 10726
		internal static int __PropertyOffset_WeightMaximum;

		// Token: 0x040029E7 RID: 10727
		internal static int __PropertyOffset_Mode;

		// Token: 0x040029E8 RID: 10728
		internal static int __PropertyOffset_WorkData;

		// Token: 0x040029E9 RID: 10729
		[Nullable(2)]
		private FRigUnit_ModifyTransforms_WorkData _WorkData;
	}
}
