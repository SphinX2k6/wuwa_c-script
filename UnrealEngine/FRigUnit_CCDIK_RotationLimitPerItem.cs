using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200055C RID: 1372
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ControlRig.RigUnit_CCDIK_RotationLimitPerItem")]
	[UnrealStructLayout(20, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 20)]
	public class FRigUnit_CCDIK_RotationLimitPerItem : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060048B3 RID: 18611 RVA: 0x0006BBDC File Offset: 0x00069DDC
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_CCDIK_RotationLimitPerItem._ScriptStructPtr != 0) ? FRigUnit_CCDIK_RotationLimitPerItem._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_CCDIK_RotationLimitPerItem", ref FRigUnit_CCDIK_RotationLimitPerItem._ScriptStructPtr);
		}

		// Token: 0x170011BE RID: 4542
		// (get) Token: 0x060048B4 RID: 18612 RVA: 0x0006BC00 File Offset: 0x00069E00
		// (set) Token: 0x060048B5 RID: 18613 RVA: 0x0006BC43 File Offset: 0x00069E43
		public FRigElementKey Item
		{
			get
			{
				base.FastCheckIsValid();
				FRigElementKey result;
				if ((result = this._Item) == null)
				{
					result = (this._Item = new FRigElementKey(base.NativePtr + (IntPtr)FRigUnit_CCDIK_RotationLimitPerItem.__PropertyOffset_Item, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRigElementKey.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_CCDIK_RotationLimitPerItem.__PropertyOffset_Item, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170011BF RID: 4543
		// (get) Token: 0x060048B6 RID: 18614 RVA: 0x0006BC64 File Offset: 0x00069E64
		// (set) Token: 0x060048B7 RID: 18615 RVA: 0x0006BC74 File Offset: 0x00069E74
		public unsafe float Limit
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_CCDIK_RotationLimitPerItem.__PropertyOffset_Limit);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_CCDIK_RotationLimitPerItem.__PropertyOffset_Limit) = value;
			}
		}

		// Token: 0x060048B8 RID: 18616 RVA: 0x0006BC85 File Offset: 0x00069E85
		public FRigUnit_CCDIK_RotationLimitPerItem()
		{
		}

		// Token: 0x060048B9 RID: 18617 RVA: 0x0006BC8D File Offset: 0x00069E8D
		public FRigUnit_CCDIK_RotationLimitPerItem(FRigElementKey Item, float Limit)
		{
			this.Item = Item;
			this.Limit = Limit;
		}

		// Token: 0x060048BA RID: 18618 RVA: 0x0006BCA3 File Offset: 0x00069EA3
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_CCDIK_RotationLimitPerItem.StaticStruct();
		}

		// Token: 0x060048BB RID: 18619 RVA: 0x0006BCAF File Offset: 0x00069EAF
		[NullableContext(2)]
		public FRigUnit_CCDIK_RotationLimitPerItem(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060048BC RID: 18620 RVA: 0x0006BCB9 File Offset: 0x00069EB9
		public FRigUnit_CCDIK_RotationLimitPerItem(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060048BD RID: 18621 RVA: 0x0006BCC4 File Offset: 0x00069EC4
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_CCDIK_RotationLimitPerItem(Pointer, false, true);
		}

		// Token: 0x060048BE RID: 18622 RVA: 0x0006BCCE File Offset: 0x00069ECE
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_CCDIK_RotationLimitPerItem(Pointer, MemoryOwner);
		}

		// Token: 0x04002342 RID: 9026
		public const string __ObjectPath = "/Script/ControlRig.RigUnit_CCDIK_RotationLimitPerItem";

		// Token: 0x04002343 RID: 9027
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002344 RID: 9028
		internal static int __PropertyOffset_Item;

		// Token: 0x04002345 RID: 9029
		[Nullable(2)]
		private FRigElementKey _Item;

		// Token: 0x04002346 RID: 9030
		internal static int __PropertyOffset_Limit;
	}
}
