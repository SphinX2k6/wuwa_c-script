using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000182 RID: 386
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.AnimSlotGroup")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FAnimSlotGroup : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060018D0 RID: 6352 RVA: 0x000259CC File Offset: 0x00023BCC
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAnimSlotGroup._ScriptStructPtr != 0) ? FAnimSlotGroup._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.AnimSlotGroup", ref FAnimSlotGroup._ScriptStructPtr);
		}

		// Token: 0x170002C0 RID: 704
		// (get) Token: 0x060018D1 RID: 6353 RVA: 0x000259F0 File Offset: 0x00023BF0
		// (set) Token: 0x060018D2 RID: 6354 RVA: 0x00025A04 File Offset: 0x00023C04
		public unsafe FName GroupName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimSlotGroup.__PropertyOffset_GroupName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimSlotGroup.__PropertyOffset_GroupName) = value;
			}
		}

		// Token: 0x170002C1 RID: 705
		// (get) Token: 0x060018D3 RID: 6355 RVA: 0x00025A1C File Offset: 0x00023C1C
		// (set) Token: 0x060018D4 RID: 6356 RVA: 0x00025A5F File Offset: 0x00023C5F
		public TArray<FName> SlotNames
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._SlotNames) == null)
				{
					result = (this._SlotNames = new TArray<FName>(base.NativePtr + (IntPtr)FAnimSlotGroup.__PropertyOffset_SlotNames, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.SlotNames.CopyAssign(value);
			}
		}

		// Token: 0x060018D5 RID: 6357 RVA: 0x00025A6D File Offset: 0x00023C6D
		public FAnimSlotGroup()
		{
		}

		// Token: 0x060018D6 RID: 6358 RVA: 0x00025A75 File Offset: 0x00023C75
		protected override IntPtr GetUStructPtr()
		{
			return FAnimSlotGroup.StaticStruct();
		}

		// Token: 0x060018D7 RID: 6359 RVA: 0x00025A81 File Offset: 0x00023C81
		[NullableContext(2)]
		public FAnimSlotGroup(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060018D8 RID: 6360 RVA: 0x00025A8B File Offset: 0x00023C8B
		public FAnimSlotGroup(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060018D9 RID: 6361 RVA: 0x00025A96 File Offset: 0x00023C96
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAnimSlotGroup(Pointer, false, true);
		}

		// Token: 0x060018DA RID: 6362 RVA: 0x00025AA0 File Offset: 0x00023CA0
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAnimSlotGroup(Pointer, MemoryOwner);
		}

		// Token: 0x040007E0 RID: 2016
		public const string __ObjectPath = "/Script/Engine.AnimSlotGroup";

		// Token: 0x040007E1 RID: 2017
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040007E2 RID: 2018
		internal static int __PropertyOffset_GroupName;

		// Token: 0x040007E3 RID: 2019
		internal static int __PropertyOffset_SlotNames;

		// Token: 0x040007E4 RID: 2020
		[Nullable(2)]
		private TArray<FName> _SlotNames;
	}
}
