using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020005D0 RID: 1488
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ControlRig.RigUnit_ItemExists")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 56)]
	public class FRigUnit_ItemExists : FRigUnit_ItemBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600504E RID: 20558 RVA: 0x00076896 File Offset: 0x00074A96
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_ItemExists._ScriptStructPtr != 0) ? FRigUnit_ItemExists._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_ItemExists", ref FRigUnit_ItemExists._ScriptStructPtr);
		}

		// Token: 0x170013BE RID: 5054
		// (get) Token: 0x0600504F RID: 20559 RVA: 0x000768BC File Offset: 0x00074ABC
		// (set) Token: 0x06005050 RID: 20560 RVA: 0x000768FF File Offset: 0x00074AFF
		public FRigElementKey Item
		{
			get
			{
				base.FastCheckIsValid();
				FRigElementKey result;
				if ((result = this._Item) == null)
				{
					result = (this._Item = new FRigElementKey(base.NativePtr + (IntPtr)FRigUnit_ItemExists.__PropertyOffset_Item, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRigElementKey.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_ItemExists.__PropertyOffset_Item, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170013BF RID: 5055
		// (get) Token: 0x06005051 RID: 20561 RVA: 0x00076920 File Offset: 0x00074B20
		// (set) Token: 0x06005052 RID: 20562 RVA: 0x00076930 File Offset: 0x00074B30
		public unsafe bool Exists
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_ItemExists.__PropertyOffset_Exists) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_ItemExists.__PropertyOffset_Exists) = (value ? 1 : 0);
			}
		}

		// Token: 0x170013C0 RID: 5056
		// (get) Token: 0x06005053 RID: 20563 RVA: 0x00076944 File Offset: 0x00074B44
		// (set) Token: 0x06005054 RID: 20564 RVA: 0x00076987 File Offset: 0x00074B87
		public FCachedRigElement CachedIndex
		{
			get
			{
				base.FastCheckIsValid();
				FCachedRigElement result;
				if ((result = this._CachedIndex) == null)
				{
					result = (this._CachedIndex = new FCachedRigElement(base.NativePtr + (IntPtr)FRigUnit_ItemExists.__PropertyOffset_CachedIndex, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FCachedRigElement.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_ItemExists.__PropertyOffset_CachedIndex, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06005055 RID: 20565 RVA: 0x000769A8 File Offset: 0x00074BA8
		public FRigUnit_ItemExists()
		{
		}

		// Token: 0x06005056 RID: 20566 RVA: 0x000769B0 File Offset: 0x00074BB0
		public FRigUnit_ItemExists(FRigElementKey Item, bool Exists, FCachedRigElement CachedIndex)
		{
			this.Item = Item;
			this.Exists = Exists;
			this.CachedIndex = CachedIndex;
		}

		// Token: 0x06005057 RID: 20567 RVA: 0x000769CD File Offset: 0x00074BCD
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_ItemExists.StaticStruct();
		}

		// Token: 0x06005058 RID: 20568 RVA: 0x000769D9 File Offset: 0x00074BD9
		[NullableContext(2)]
		public FRigUnit_ItemExists(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06005059 RID: 20569 RVA: 0x000769E3 File Offset: 0x00074BE3
		public FRigUnit_ItemExists(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600505A RID: 20570 RVA: 0x000769EE File Offset: 0x00074BEE
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_ItemExists(Pointer, false, true);
		}

		// Token: 0x0600505B RID: 20571 RVA: 0x000769F8 File Offset: 0x00074BF8
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_ItemExists(Pointer, MemoryOwner);
		}

		// Token: 0x040026BD RID: 9917
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_ItemExists";

		// Token: 0x040026BE RID: 9918
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040026BF RID: 9919
		internal static int __PropertyOffset_Item;

		// Token: 0x040026C0 RID: 9920
		[Nullable(2)]
		private FRigElementKey _Item;

		// Token: 0x040026C1 RID: 9921
		internal static int __PropertyOffset_Exists;

		// Token: 0x040026C2 RID: 9922
		internal static int __PropertyOffset_CachedIndex;

		// Token: 0x040026C3 RID: 9923
		[Nullable(2)]
		private FCachedRigElement _CachedIndex;
	}
}
