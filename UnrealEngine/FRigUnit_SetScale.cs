using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020006CE RID: 1742
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ControlRig.RigUnit_SetScale")]
	[UnrealStructLayout(176, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 176)]
	public class FRigUnit_SetScale : FRigUnitMutable, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06005D35 RID: 23861 RVA: 0x00085C95 File Offset: 0x00083E95
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_SetScale._ScriptStructPtr != 0) ? FRigUnit_SetScale._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_SetScale", ref FRigUnit_SetScale._ScriptStructPtr);
		}

		// Token: 0x17001640 RID: 5696
		// (get) Token: 0x06005D36 RID: 23862 RVA: 0x00085CBC File Offset: 0x00083EBC
		// (set) Token: 0x06005D37 RID: 23863 RVA: 0x00085CFF File Offset: 0x00083EFF
		public FRigElementKey Item
		{
			get
			{
				base.FastCheckIsValid();
				FRigElementKey result;
				if ((result = this._Item) == null)
				{
					result = (this._Item = new FRigElementKey(base.NativePtr + (IntPtr)FRigUnit_SetScale.__PropertyOffset_Item, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRigElementKey.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_SetScale.__PropertyOffset_Item, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001641 RID: 5697
		// (get) Token: 0x06005D38 RID: 23864 RVA: 0x00085D20 File Offset: 0x00083F20
		// (set) Token: 0x06005D39 RID: 23865 RVA: 0x00085D30 File Offset: 0x00083F30
		public unsafe EBoneGetterSetterMode Space
		{
			get
			{
				return (EBoneGetterSetterMode)(*(base.NativePtr + (IntPtr)FRigUnit_SetScale.__PropertyOffset_Space));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_SetScale.__PropertyOffset_Space) = (byte)value;
			}
		}

		// Token: 0x17001642 RID: 5698
		// (get) Token: 0x06005D3A RID: 23866 RVA: 0x00085D41 File Offset: 0x00083F41
		// (set) Token: 0x06005D3B RID: 23867 RVA: 0x00085D55 File Offset: 0x00083F55
		public unsafe FVector Scale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_SetScale.__PropertyOffset_Scale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_SetScale.__PropertyOffset_Scale) = value;
			}
		}

		// Token: 0x17001643 RID: 5699
		// (get) Token: 0x06005D3C RID: 23868 RVA: 0x00085D6A File Offset: 0x00083F6A
		// (set) Token: 0x06005D3D RID: 23869 RVA: 0x00085D7A File Offset: 0x00083F7A
		public unsafe float Weight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_SetScale.__PropertyOffset_Weight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_SetScale.__PropertyOffset_Weight) = value;
			}
		}

		// Token: 0x17001644 RID: 5700
		// (get) Token: 0x06005D3E RID: 23870 RVA: 0x00085D8B File Offset: 0x00083F8B
		// (set) Token: 0x06005D3F RID: 23871 RVA: 0x00085D9B File Offset: 0x00083F9B
		public unsafe bool bPropagateToChildren
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_SetScale.__PropertyOffset_bPropagateToChildren) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_SetScale.__PropertyOffset_bPropagateToChildren) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001645 RID: 5701
		// (get) Token: 0x06005D40 RID: 23872 RVA: 0x00085DAC File Offset: 0x00083FAC
		// (set) Token: 0x06005D41 RID: 23873 RVA: 0x00085DEF File Offset: 0x00083FEF
		public FCachedRigElement CachedIndex
		{
			get
			{
				base.FastCheckIsValid();
				FCachedRigElement result;
				if ((result = this._CachedIndex) == null)
				{
					result = (this._CachedIndex = new FCachedRigElement(base.NativePtr + (IntPtr)FRigUnit_SetScale.__PropertyOffset_CachedIndex, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FCachedRigElement.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_SetScale.__PropertyOffset_CachedIndex, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06005D42 RID: 23874 RVA: 0x00085E10 File Offset: 0x00084010
		public FRigUnit_SetScale()
		{
		}

		// Token: 0x06005D43 RID: 23875 RVA: 0x00085E18 File Offset: 0x00084018
		public FRigUnit_SetScale(FRigElementKey Item, EBoneGetterSetterMode Space, FVector Scale, float Weight, bool bPropagateToChildren, FCachedRigElement CachedIndex, FControlRigExecuteContext ExecuteContext)
		{
			this.Item = Item;
			this.Space = Space;
			this.Scale = Scale;
			this.Weight = Weight;
			this.bPropagateToChildren = bPropagateToChildren;
			this.CachedIndex = CachedIndex;
			base.ExecuteContext = ExecuteContext;
		}

		// Token: 0x06005D44 RID: 23876 RVA: 0x00085E55 File Offset: 0x00084055
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_SetScale.StaticStruct();
		}

		// Token: 0x06005D45 RID: 23877 RVA: 0x00085E61 File Offset: 0x00084061
		[NullableContext(2)]
		public FRigUnit_SetScale(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06005D46 RID: 23878 RVA: 0x00085E6B File Offset: 0x0008406B
		public FRigUnit_SetScale(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06005D47 RID: 23879 RVA: 0x00085E76 File Offset: 0x00084076
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_SetScale(Pointer, false, true);
		}

		// Token: 0x06005D48 RID: 23880 RVA: 0x00085E80 File Offset: 0x00084080
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_SetScale(Pointer, MemoryOwner);
		}

		// Token: 0x04002B9E RID: 11166
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_SetScale";

		// Token: 0x04002B9F RID: 11167
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002BA0 RID: 11168
		internal static int __PropertyOffset_Item;

		// Token: 0x04002BA1 RID: 11169
		[Nullable(2)]
		private FRigElementKey _Item;

		// Token: 0x04002BA2 RID: 11170
		internal static int __PropertyOffset_Space;

		// Token: 0x04002BA3 RID: 11171
		internal static int __PropertyOffset_Scale;

		// Token: 0x04002BA4 RID: 11172
		internal static int __PropertyOffset_Weight;

		// Token: 0x04002BA5 RID: 11173
		internal static int __PropertyOffset_bPropagateToChildren;

		// Token: 0x04002BA6 RID: 11174
		internal static int __PropertyOffset_CachedIndex;

		// Token: 0x04002BA7 RID: 11175
		[Nullable(2)]
		private FCachedRigElement _CachedIndex;
	}
}
