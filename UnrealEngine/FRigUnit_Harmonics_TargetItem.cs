using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020005C2 RID: 1474
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ControlRig.RigUnit_Harmonics_TargetItem")]
	[UnrealStructLayout(20, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 20)]
	public class FRigUnit_Harmonics_TargetItem : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06004FAD RID: 20397 RVA: 0x000759BC File Offset: 0x00073BBC
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_Harmonics_TargetItem._ScriptStructPtr != 0) ? FRigUnit_Harmonics_TargetItem._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_Harmonics_TargetItem", ref FRigUnit_Harmonics_TargetItem._ScriptStructPtr);
		}

		// Token: 0x170013A4 RID: 5028
		// (get) Token: 0x06004FAE RID: 20398 RVA: 0x000759E0 File Offset: 0x00073BE0
		// (set) Token: 0x06004FAF RID: 20399 RVA: 0x00075A23 File Offset: 0x00073C23
		public FRigElementKey Item
		{
			get
			{
				base.FastCheckIsValid();
				FRigElementKey result;
				if ((result = this._Item) == null)
				{
					result = (this._Item = new FRigElementKey(base.NativePtr + (IntPtr)FRigUnit_Harmonics_TargetItem.__PropertyOffset_Item, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRigElementKey.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_Harmonics_TargetItem.__PropertyOffset_Item, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170013A5 RID: 5029
		// (get) Token: 0x06004FB0 RID: 20400 RVA: 0x00075A44 File Offset: 0x00073C44
		// (set) Token: 0x06004FB1 RID: 20401 RVA: 0x00075A54 File Offset: 0x00073C54
		public unsafe float Ratio
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_Harmonics_TargetItem.__PropertyOffset_Ratio);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_Harmonics_TargetItem.__PropertyOffset_Ratio) = value;
			}
		}

		// Token: 0x06004FB2 RID: 20402 RVA: 0x00075A65 File Offset: 0x00073C65
		public FRigUnit_Harmonics_TargetItem()
		{
		}

		// Token: 0x06004FB3 RID: 20403 RVA: 0x00075A6D File Offset: 0x00073C6D
		public FRigUnit_Harmonics_TargetItem(FRigElementKey Item, float Ratio)
		{
			this.Item = Item;
			this.Ratio = Ratio;
		}

		// Token: 0x06004FB4 RID: 20404 RVA: 0x00075A83 File Offset: 0x00073C83
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_Harmonics_TargetItem.StaticStruct();
		}

		// Token: 0x06004FB5 RID: 20405 RVA: 0x00075A8F File Offset: 0x00073C8F
		[NullableContext(2)]
		public FRigUnit_Harmonics_TargetItem(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06004FB6 RID: 20406 RVA: 0x00075A99 File Offset: 0x00073C99
		public FRigUnit_Harmonics_TargetItem(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06004FB7 RID: 20407 RVA: 0x00075AA4 File Offset: 0x00073CA4
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_Harmonics_TargetItem(Pointer, false, true);
		}

		// Token: 0x06004FB8 RID: 20408 RVA: 0x00075AAE File Offset: 0x00073CAE
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_Harmonics_TargetItem(Pointer, MemoryOwner);
		}

		// Token: 0x04002674 RID: 9844
		public const string __ObjectPath = "/Script/ControlRig.RigUnit_Harmonics_TargetItem";

		// Token: 0x04002675 RID: 9845
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002676 RID: 9846
		internal static int __PropertyOffset_Item;

		// Token: 0x04002677 RID: 9847
		[Nullable(2)]
		private FRigElementKey _Item;

		// Token: 0x04002678 RID: 9848
		internal static int __PropertyOffset_Ratio;
	}
}
