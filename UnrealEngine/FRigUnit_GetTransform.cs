using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020005C0 RID: 1472
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ControlRig.RigUnit_GetTransform")]
	[UnrealStructLayout(112, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 112)]
	public class FRigUnit_GetTransform : FRigUnit, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06004F83 RID: 20355 RVA: 0x0007563D File Offset: 0x0007383D
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_GetTransform._ScriptStructPtr != 0) ? FRigUnit_GetTransform._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_GetTransform", ref FRigUnit_GetTransform._ScriptStructPtr);
		}

		// Token: 0x17001397 RID: 5015
		// (get) Token: 0x06004F84 RID: 20356 RVA: 0x00075664 File Offset: 0x00073864
		// (set) Token: 0x06004F85 RID: 20357 RVA: 0x000756A7 File Offset: 0x000738A7
		public FRigElementKey Item
		{
			get
			{
				base.FastCheckIsValid();
				FRigElementKey result;
				if ((result = this._Item) == null)
				{
					result = (this._Item = new FRigElementKey(base.NativePtr + (IntPtr)FRigUnit_GetTransform.__PropertyOffset_Item, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRigElementKey.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_GetTransform.__PropertyOffset_Item, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001398 RID: 5016
		// (get) Token: 0x06004F86 RID: 20358 RVA: 0x000756C8 File Offset: 0x000738C8
		// (set) Token: 0x06004F87 RID: 20359 RVA: 0x000756D8 File Offset: 0x000738D8
		public unsafe EBoneGetterSetterMode Space
		{
			get
			{
				return (EBoneGetterSetterMode)(*(base.NativePtr + (IntPtr)FRigUnit_GetTransform.__PropertyOffset_Space));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_GetTransform.__PropertyOffset_Space) = (byte)value;
			}
		}

		// Token: 0x17001399 RID: 5017
		// (get) Token: 0x06004F88 RID: 20360 RVA: 0x000756E9 File Offset: 0x000738E9
		// (set) Token: 0x06004F89 RID: 20361 RVA: 0x000756F9 File Offset: 0x000738F9
		public unsafe bool bInitial
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_GetTransform.__PropertyOffset_bInitial) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_GetTransform.__PropertyOffset_bInitial) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700139A RID: 5018
		// (get) Token: 0x06004F8A RID: 20362 RVA: 0x0007570A File Offset: 0x0007390A
		// (set) Token: 0x06004F8B RID: 20363 RVA: 0x0007571E File Offset: 0x0007391E
		public unsafe FTransform Transform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_GetTransform.__PropertyOffset_Transform);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_GetTransform.__PropertyOffset_Transform) = value;
			}
		}

		// Token: 0x1700139B RID: 5019
		// (get) Token: 0x06004F8C RID: 20364 RVA: 0x00075734 File Offset: 0x00073934
		// (set) Token: 0x06004F8D RID: 20365 RVA: 0x00075777 File Offset: 0x00073977
		public FCachedRigElement CachedIndex
		{
			get
			{
				base.FastCheckIsValid();
				FCachedRigElement result;
				if ((result = this._CachedIndex) == null)
				{
					result = (this._CachedIndex = new FCachedRigElement(base.NativePtr + (IntPtr)FRigUnit_GetTransform.__PropertyOffset_CachedIndex, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FCachedRigElement.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_GetTransform.__PropertyOffset_CachedIndex, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06004F8E RID: 20366 RVA: 0x00075798 File Offset: 0x00073998
		public FRigUnit_GetTransform()
		{
		}

		// Token: 0x06004F8F RID: 20367 RVA: 0x000757A0 File Offset: 0x000739A0
		public FRigUnit_GetTransform(FRigElementKey Item, EBoneGetterSetterMode Space, bool bInitial, FTransform Transform, FCachedRigElement CachedIndex)
		{
			this.Item = Item;
			this.Space = Space;
			this.bInitial = bInitial;
			this.Transform = Transform;
			this.CachedIndex = CachedIndex;
		}

		// Token: 0x06004F90 RID: 20368 RVA: 0x000757CD File Offset: 0x000739CD
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_GetTransform.StaticStruct();
		}

		// Token: 0x06004F91 RID: 20369 RVA: 0x000757D9 File Offset: 0x000739D9
		[NullableContext(2)]
		public FRigUnit_GetTransform(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06004F92 RID: 20370 RVA: 0x000757E3 File Offset: 0x000739E3
		public FRigUnit_GetTransform(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06004F93 RID: 20371 RVA: 0x000757EE File Offset: 0x000739EE
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_GetTransform(Pointer, false, true);
		}

		// Token: 0x06004F94 RID: 20372 RVA: 0x000757F8 File Offset: 0x000739F8
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_GetTransform(Pointer, MemoryOwner);
		}

		// Token: 0x04002661 RID: 9825
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_GetTransform";

		// Token: 0x04002662 RID: 9826
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002663 RID: 9827
		internal static int __PropertyOffset_Item;

		// Token: 0x04002664 RID: 9828
		[Nullable(2)]
		private FRigElementKey _Item;

		// Token: 0x04002665 RID: 9829
		internal static int __PropertyOffset_Space;

		// Token: 0x04002666 RID: 9830
		internal static int __PropertyOffset_bInitial;

		// Token: 0x04002667 RID: 9831
		internal static int __PropertyOffset_Transform;

		// Token: 0x04002668 RID: 9832
		internal static int __PropertyOffset_CachedIndex;

		// Token: 0x04002669 RID: 9833
		[Nullable(2)]
		private FCachedRigElement _CachedIndex;
	}
}
