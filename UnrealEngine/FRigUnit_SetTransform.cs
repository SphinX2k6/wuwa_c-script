using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020006D1 RID: 1745
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ControlRig.RigUnit_SetTransform")]
	[UnrealStructLayout(224, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 224)]
	public class FRigUnit_SetTransform : FRigUnitMutable, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06005D6D RID: 23917 RVA: 0x000861B1 File Offset: 0x000843B1
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_SetTransform._ScriptStructPtr != 0) ? FRigUnit_SetTransform._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_SetTransform", ref FRigUnit_SetTransform._ScriptStructPtr);
		}

		// Token: 0x17001650 RID: 5712
		// (get) Token: 0x06005D6E RID: 23918 RVA: 0x000861D8 File Offset: 0x000843D8
		// (set) Token: 0x06005D6F RID: 23919 RVA: 0x0008621B File Offset: 0x0008441B
		public FRigElementKey Item
		{
			get
			{
				base.FastCheckIsValid();
				FRigElementKey result;
				if ((result = this._Item) == null)
				{
					result = (this._Item = new FRigElementKey(base.NativePtr + (IntPtr)FRigUnit_SetTransform.__PropertyOffset_Item, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRigElementKey.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_SetTransform.__PropertyOffset_Item, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001651 RID: 5713
		// (get) Token: 0x06005D70 RID: 23920 RVA: 0x0008623C File Offset: 0x0008443C
		// (set) Token: 0x06005D71 RID: 23921 RVA: 0x0008624C File Offset: 0x0008444C
		public unsafe EBoneGetterSetterMode Space
		{
			get
			{
				return (EBoneGetterSetterMode)(*(base.NativePtr + (IntPtr)FRigUnit_SetTransform.__PropertyOffset_Space));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_SetTransform.__PropertyOffset_Space) = (byte)value;
			}
		}

		// Token: 0x17001652 RID: 5714
		// (get) Token: 0x06005D72 RID: 23922 RVA: 0x0008625D File Offset: 0x0008445D
		// (set) Token: 0x06005D73 RID: 23923 RVA: 0x0008626D File Offset: 0x0008446D
		public unsafe bool bInitial
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_SetTransform.__PropertyOffset_bInitial) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_SetTransform.__PropertyOffset_bInitial) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001653 RID: 5715
		// (get) Token: 0x06005D74 RID: 23924 RVA: 0x0008627E File Offset: 0x0008447E
		// (set) Token: 0x06005D75 RID: 23925 RVA: 0x00086292 File Offset: 0x00084492
		public unsafe FTransform Transform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_SetTransform.__PropertyOffset_Transform);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_SetTransform.__PropertyOffset_Transform) = value;
			}
		}

		// Token: 0x17001654 RID: 5716
		// (get) Token: 0x06005D76 RID: 23926 RVA: 0x000862A7 File Offset: 0x000844A7
		// (set) Token: 0x06005D77 RID: 23927 RVA: 0x000862B7 File Offset: 0x000844B7
		public unsafe float Weight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_SetTransform.__PropertyOffset_Weight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_SetTransform.__PropertyOffset_Weight) = value;
			}
		}

		// Token: 0x17001655 RID: 5717
		// (get) Token: 0x06005D78 RID: 23928 RVA: 0x000862C8 File Offset: 0x000844C8
		// (set) Token: 0x06005D79 RID: 23929 RVA: 0x000862D8 File Offset: 0x000844D8
		public unsafe bool bPropagateToChildren
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_SetTransform.__PropertyOffset_bPropagateToChildren) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_SetTransform.__PropertyOffset_bPropagateToChildren) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001656 RID: 5718
		// (get) Token: 0x06005D7A RID: 23930 RVA: 0x000862EC File Offset: 0x000844EC
		// (set) Token: 0x06005D7B RID: 23931 RVA: 0x0008632F File Offset: 0x0008452F
		public FCachedRigElement CachedIndex
		{
			get
			{
				base.FastCheckIsValid();
				FCachedRigElement result;
				if ((result = this._CachedIndex) == null)
				{
					result = (this._CachedIndex = new FCachedRigElement(base.NativePtr + (IntPtr)FRigUnit_SetTransform.__PropertyOffset_CachedIndex, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FCachedRigElement.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_SetTransform.__PropertyOffset_CachedIndex, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06005D7C RID: 23932 RVA: 0x00086350 File Offset: 0x00084550
		public FRigUnit_SetTransform()
		{
		}

		// Token: 0x06005D7D RID: 23933 RVA: 0x00086358 File Offset: 0x00084558
		public FRigUnit_SetTransform(FRigElementKey Item, EBoneGetterSetterMode Space, bool bInitial, FTransform Transform, float Weight, bool bPropagateToChildren, FCachedRigElement CachedIndex, FControlRigExecuteContext ExecuteContext)
		{
			this.Item = Item;
			this.Space = Space;
			this.bInitial = bInitial;
			this.Transform = Transform;
			this.Weight = Weight;
			this.bPropagateToChildren = bPropagateToChildren;
			this.CachedIndex = CachedIndex;
			base.ExecuteContext = ExecuteContext;
		}

		// Token: 0x06005D7E RID: 23934 RVA: 0x000863A8 File Offset: 0x000845A8
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_SetTransform.StaticStruct();
		}

		// Token: 0x06005D7F RID: 23935 RVA: 0x000863B4 File Offset: 0x000845B4
		[NullableContext(2)]
		public FRigUnit_SetTransform(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06005D80 RID: 23936 RVA: 0x000863BE File Offset: 0x000845BE
		public FRigUnit_SetTransform(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06005D81 RID: 23937 RVA: 0x000863C9 File Offset: 0x000845C9
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_SetTransform(Pointer, false, true);
		}

		// Token: 0x06005D82 RID: 23938 RVA: 0x000863D3 File Offset: 0x000845D3
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_SetTransform(Pointer, MemoryOwner);
		}

		// Token: 0x04002BB8 RID: 11192
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_SetTransform";

		// Token: 0x04002BB9 RID: 11193
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002BBA RID: 11194
		internal static int __PropertyOffset_Item;

		// Token: 0x04002BBB RID: 11195
		[Nullable(2)]
		private FRigElementKey _Item;

		// Token: 0x04002BBC RID: 11196
		internal static int __PropertyOffset_Space;

		// Token: 0x04002BBD RID: 11197
		internal static int __PropertyOffset_bInitial;

		// Token: 0x04002BBE RID: 11198
		internal static int __PropertyOffset_Transform;

		// Token: 0x04002BBF RID: 11199
		internal static int __PropertyOffset_Weight;

		// Token: 0x04002BC0 RID: 11200
		internal static int __PropertyOffset_bPropagateToChildren;

		// Token: 0x04002BC1 RID: 11201
		internal static int __PropertyOffset_CachedIndex;

		// Token: 0x04002BC2 RID: 11202
		[Nullable(2)]
		private FCachedRigElement _CachedIndex;
	}
}
