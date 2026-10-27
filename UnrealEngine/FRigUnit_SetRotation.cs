using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020006CD RID: 1741
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ControlRig.RigUnit_SetRotation")]
	[UnrealStructLayout(192, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 192)]
	public class FRigUnit_SetRotation : FRigUnitMutable, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06005D21 RID: 23841 RVA: 0x00085AA4 File Offset: 0x00083CA4
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_SetRotation._ScriptStructPtr != 0) ? FRigUnit_SetRotation._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_SetRotation", ref FRigUnit_SetRotation._ScriptStructPtr);
		}

		// Token: 0x1700163A RID: 5690
		// (get) Token: 0x06005D22 RID: 23842 RVA: 0x00085AC8 File Offset: 0x00083CC8
		// (set) Token: 0x06005D23 RID: 23843 RVA: 0x00085B0B File Offset: 0x00083D0B
		public FRigElementKey Item
		{
			get
			{
				base.FastCheckIsValid();
				FRigElementKey result;
				if ((result = this._Item) == null)
				{
					result = (this._Item = new FRigElementKey(base.NativePtr + (IntPtr)FRigUnit_SetRotation.__PropertyOffset_Item, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRigElementKey.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_SetRotation.__PropertyOffset_Item, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700163B RID: 5691
		// (get) Token: 0x06005D24 RID: 23844 RVA: 0x00085B2C File Offset: 0x00083D2C
		// (set) Token: 0x06005D25 RID: 23845 RVA: 0x00085B3C File Offset: 0x00083D3C
		public unsafe EBoneGetterSetterMode Space
		{
			get
			{
				return (EBoneGetterSetterMode)(*(base.NativePtr + (IntPtr)FRigUnit_SetRotation.__PropertyOffset_Space));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_SetRotation.__PropertyOffset_Space) = (byte)value;
			}
		}

		// Token: 0x1700163C RID: 5692
		// (get) Token: 0x06005D26 RID: 23846 RVA: 0x00085B4D File Offset: 0x00083D4D
		// (set) Token: 0x06005D27 RID: 23847 RVA: 0x00085B61 File Offset: 0x00083D61
		public unsafe FQuat Rotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_SetRotation.__PropertyOffset_Rotation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_SetRotation.__PropertyOffset_Rotation) = value;
			}
		}

		// Token: 0x1700163D RID: 5693
		// (get) Token: 0x06005D28 RID: 23848 RVA: 0x00085B76 File Offset: 0x00083D76
		// (set) Token: 0x06005D29 RID: 23849 RVA: 0x00085B86 File Offset: 0x00083D86
		public unsafe float Weight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_SetRotation.__PropertyOffset_Weight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_SetRotation.__PropertyOffset_Weight) = value;
			}
		}

		// Token: 0x1700163E RID: 5694
		// (get) Token: 0x06005D2A RID: 23850 RVA: 0x00085B97 File Offset: 0x00083D97
		// (set) Token: 0x06005D2B RID: 23851 RVA: 0x00085BA7 File Offset: 0x00083DA7
		public unsafe bool bPropagateToChildren
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_SetRotation.__PropertyOffset_bPropagateToChildren) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_SetRotation.__PropertyOffset_bPropagateToChildren) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700163F RID: 5695
		// (get) Token: 0x06005D2C RID: 23852 RVA: 0x00085BB8 File Offset: 0x00083DB8
		// (set) Token: 0x06005D2D RID: 23853 RVA: 0x00085BFB File Offset: 0x00083DFB
		public FCachedRigElement CachedIndex
		{
			get
			{
				base.FastCheckIsValid();
				FCachedRigElement result;
				if ((result = this._CachedIndex) == null)
				{
					result = (this._CachedIndex = new FCachedRigElement(base.NativePtr + (IntPtr)FRigUnit_SetRotation.__PropertyOffset_CachedIndex, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FCachedRigElement.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_SetRotation.__PropertyOffset_CachedIndex, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06005D2E RID: 23854 RVA: 0x00085C1C File Offset: 0x00083E1C
		public FRigUnit_SetRotation()
		{
		}

		// Token: 0x06005D2F RID: 23855 RVA: 0x00085C24 File Offset: 0x00083E24
		public FRigUnit_SetRotation(FRigElementKey Item, EBoneGetterSetterMode Space, FQuat Rotation, float Weight, bool bPropagateToChildren, FCachedRigElement CachedIndex, FControlRigExecuteContext ExecuteContext)
		{
			this.Item = Item;
			this.Space = Space;
			this.Rotation = Rotation;
			this.Weight = Weight;
			this.bPropagateToChildren = bPropagateToChildren;
			this.CachedIndex = CachedIndex;
			base.ExecuteContext = ExecuteContext;
		}

		// Token: 0x06005D30 RID: 23856 RVA: 0x00085C61 File Offset: 0x00083E61
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_SetRotation.StaticStruct();
		}

		// Token: 0x06005D31 RID: 23857 RVA: 0x00085C6D File Offset: 0x00083E6D
		[NullableContext(2)]
		public FRigUnit_SetRotation(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06005D32 RID: 23858 RVA: 0x00085C77 File Offset: 0x00083E77
		public FRigUnit_SetRotation(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06005D33 RID: 23859 RVA: 0x00085C82 File Offset: 0x00083E82
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_SetRotation(Pointer, false, true);
		}

		// Token: 0x06005D34 RID: 23860 RVA: 0x00085C8C File Offset: 0x00083E8C
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_SetRotation(Pointer, MemoryOwner);
		}

		// Token: 0x04002B94 RID: 11156
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_SetRotation";

		// Token: 0x04002B95 RID: 11157
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002B96 RID: 11158
		internal static int __PropertyOffset_Item;

		// Token: 0x04002B97 RID: 11159
		[Nullable(2)]
		private FRigElementKey _Item;

		// Token: 0x04002B98 RID: 11160
		internal static int __PropertyOffset_Space;

		// Token: 0x04002B99 RID: 11161
		internal static int __PropertyOffset_Rotation;

		// Token: 0x04002B9A RID: 11162
		internal static int __PropertyOffset_Weight;

		// Token: 0x04002B9B RID: 11163
		internal static int __PropertyOffset_bPropagateToChildren;

		// Token: 0x04002B9C RID: 11164
		internal static int __PropertyOffset_CachedIndex;

		// Token: 0x04002B9D RID: 11165
		[Nullable(2)]
		private FCachedRigElement _CachedIndex;
	}
}
