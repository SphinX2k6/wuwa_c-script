using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020005D2 RID: 1490
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ControlRig.RigUnit_ItemReplace")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 64)]
	public class FRigUnit_ItemReplace : FRigUnit_ItemBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600507A RID: 20602 RVA: 0x00076CDC File Offset: 0x00074EDC
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_ItemReplace._ScriptStructPtr != 0) ? FRigUnit_ItemReplace._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_ItemReplace", ref FRigUnit_ItemReplace._ScriptStructPtr);
		}

		// Token: 0x170013CC RID: 5068
		// (get) Token: 0x0600507B RID: 20603 RVA: 0x00076D00 File Offset: 0x00074F00
		// (set) Token: 0x0600507C RID: 20604 RVA: 0x00076D43 File Offset: 0x00074F43
		public FRigElementKey Item
		{
			get
			{
				base.FastCheckIsValid();
				FRigElementKey result;
				if ((result = this._Item) == null)
				{
					result = (this._Item = new FRigElementKey(base.NativePtr + (IntPtr)FRigUnit_ItemReplace.__PropertyOffset_Item, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRigElementKey.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_ItemReplace.__PropertyOffset_Item, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170013CD RID: 5069
		// (get) Token: 0x0600507D RID: 20605 RVA: 0x00076D64 File Offset: 0x00074F64
		// (set) Token: 0x0600507E RID: 20606 RVA: 0x00076D78 File Offset: 0x00074F78
		public unsafe FName Old
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_ItemReplace.__PropertyOffset_Old);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_ItemReplace.__PropertyOffset_Old) = value;
			}
		}

		// Token: 0x170013CE RID: 5070
		// (get) Token: 0x0600507F RID: 20607 RVA: 0x00076D8D File Offset: 0x00074F8D
		// (set) Token: 0x06005080 RID: 20608 RVA: 0x00076DA1 File Offset: 0x00074FA1
		public unsafe FName New
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_ItemReplace.__PropertyOffset_New);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_ItemReplace.__PropertyOffset_New) = value;
			}
		}

		// Token: 0x170013CF RID: 5071
		// (get) Token: 0x06005081 RID: 20609 RVA: 0x00076DB8 File Offset: 0x00074FB8
		// (set) Token: 0x06005082 RID: 20610 RVA: 0x00076DFB File Offset: 0x00074FFB
		public FRigElementKey Result
		{
			get
			{
				base.FastCheckIsValid();
				FRigElementKey result;
				if ((result = this._Result) == null)
				{
					result = (this._Result = new FRigElementKey(base.NativePtr + (IntPtr)FRigUnit_ItemReplace.__PropertyOffset_Result, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRigElementKey.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_ItemReplace.__PropertyOffset_Result, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06005083 RID: 20611 RVA: 0x00076E1C File Offset: 0x0007501C
		public FRigUnit_ItemReplace()
		{
		}

		// Token: 0x06005084 RID: 20612 RVA: 0x00076E24 File Offset: 0x00075024
		public FRigUnit_ItemReplace(FRigElementKey Item, FName Old, FName New, FRigElementKey Result)
		{
			this.Item = Item;
			this.Old = Old;
			this.New = New;
			this.Result = Result;
		}

		// Token: 0x06005085 RID: 20613 RVA: 0x00076E49 File Offset: 0x00075049
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_ItemReplace.StaticStruct();
		}

		// Token: 0x06005086 RID: 20614 RVA: 0x00076E55 File Offset: 0x00075055
		[NullableContext(2)]
		public FRigUnit_ItemReplace(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06005087 RID: 20615 RVA: 0x00076E5F File Offset: 0x0007505F
		public FRigUnit_ItemReplace(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06005088 RID: 20616 RVA: 0x00076E6A File Offset: 0x0007506A
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_ItemReplace(Pointer, false, true);
		}

		// Token: 0x06005089 RID: 20617 RVA: 0x00076E74 File Offset: 0x00075074
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_ItemReplace(Pointer, MemoryOwner);
		}

		// Token: 0x040026D3 RID: 9939
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_ItemReplace";

		// Token: 0x040026D4 RID: 9940
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040026D5 RID: 9941
		internal static int __PropertyOffset_Item;

		// Token: 0x040026D6 RID: 9942
		[Nullable(2)]
		private FRigElementKey _Item;

		// Token: 0x040026D7 RID: 9943
		internal static int __PropertyOffset_Old;

		// Token: 0x040026D8 RID: 9944
		internal static int __PropertyOffset_New;

		// Token: 0x040026D9 RID: 9945
		internal static int __PropertyOffset_Result;

		// Token: 0x040026DA RID: 9946
		[Nullable(2)]
		private FRigElementKey _Result;
	}
}
