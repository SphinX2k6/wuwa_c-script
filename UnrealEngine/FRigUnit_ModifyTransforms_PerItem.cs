using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000692 RID: 1682
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ControlRig.RigUnit_ModifyTransforms_PerItem")]
	[UnrealStructLayout(64, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 64)]
	public class FRigUnit_ModifyTransforms_PerItem : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06005969 RID: 22889 RVA: 0x00080855 File Offset: 0x0007EA55
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_ModifyTransforms_PerItem._ScriptStructPtr != 0) ? FRigUnit_ModifyTransforms_PerItem._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_ModifyTransforms_PerItem", ref FRigUnit_ModifyTransforms_PerItem._ScriptStructPtr);
		}

		// Token: 0x17001549 RID: 5449
		// (get) Token: 0x0600596A RID: 22890 RVA: 0x0008087C File Offset: 0x0007EA7C
		// (set) Token: 0x0600596B RID: 22891 RVA: 0x000808BF File Offset: 0x0007EABF
		public FRigElementKey Item
		{
			get
			{
				base.FastCheckIsValid();
				FRigElementKey result;
				if ((result = this._Item) == null)
				{
					result = (this._Item = new FRigElementKey(base.NativePtr + (IntPtr)FRigUnit_ModifyTransforms_PerItem.__PropertyOffset_Item, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRigElementKey.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_ModifyTransforms_PerItem.__PropertyOffset_Item, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700154A RID: 5450
		// (get) Token: 0x0600596C RID: 22892 RVA: 0x000808E0 File Offset: 0x0007EAE0
		// (set) Token: 0x0600596D RID: 22893 RVA: 0x000808F4 File Offset: 0x0007EAF4
		public unsafe FTransform Transform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_ModifyTransforms_PerItem.__PropertyOffset_Transform);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_ModifyTransforms_PerItem.__PropertyOffset_Transform) = value;
			}
		}

		// Token: 0x0600596E RID: 22894 RVA: 0x00080909 File Offset: 0x0007EB09
		public FRigUnit_ModifyTransforms_PerItem()
		{
		}

		// Token: 0x0600596F RID: 22895 RVA: 0x00080911 File Offset: 0x0007EB11
		public FRigUnit_ModifyTransforms_PerItem(FRigElementKey Item, FTransform Transform)
		{
			this.Item = Item;
			this.Transform = Transform;
		}

		// Token: 0x06005970 RID: 22896 RVA: 0x00080927 File Offset: 0x0007EB27
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_ModifyTransforms_PerItem.StaticStruct();
		}

		// Token: 0x06005971 RID: 22897 RVA: 0x00080933 File Offset: 0x0007EB33
		[NullableContext(2)]
		public FRigUnit_ModifyTransforms_PerItem(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06005972 RID: 22898 RVA: 0x0008093D File Offset: 0x0007EB3D
		public FRigUnit_ModifyTransforms_PerItem(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06005973 RID: 22899 RVA: 0x00080948 File Offset: 0x0007EB48
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_ModifyTransforms_PerItem(Pointer, false, true);
		}

		// Token: 0x06005974 RID: 22900 RVA: 0x00080952 File Offset: 0x0007EB52
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_ModifyTransforms_PerItem(Pointer, MemoryOwner);
		}

		// Token: 0x040029EA RID: 10730
		public const string __ObjectPath = "/Script/ControlRig.RigUnit_ModifyTransforms_PerItem";

		// Token: 0x040029EB RID: 10731
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040029EC RID: 10732
		internal static int __PropertyOffset_Item;

		// Token: 0x040029ED RID: 10733
		[Nullable(2)]
		private FRigElementKey _Item;

		// Token: 0x040029EE RID: 10734
		internal static int __PropertyOffset_Transform;
	}
}
