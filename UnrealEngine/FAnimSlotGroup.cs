using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000841 RID: 2113
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.AnimSlotGroup")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FAnimSlotGroup : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060071DD RID: 29149 RVA: 0x000A3140 File Offset: 0x000A1340
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAnimSlotGroup._ScriptStructPtr != 0) ? FAnimSlotGroup._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.AnimSlotGroup", ref FAnimSlotGroup._ScriptStructPtr);
		}

		// Token: 0x17001ACD RID: 6861
		// (get) Token: 0x060071DE RID: 29150 RVA: 0x000A3164 File Offset: 0x000A1364
		// (set) Token: 0x060071DF RID: 29151 RVA: 0x000A3178 File Offset: 0x000A1378
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

		// Token: 0x17001ACE RID: 6862
		// (get) Token: 0x060071E0 RID: 29152 RVA: 0x000A3190 File Offset: 0x000A1390
		// (set) Token: 0x060071E1 RID: 29153 RVA: 0x000A31D3 File Offset: 0x000A13D3
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

		// Token: 0x060071E2 RID: 29154 RVA: 0x000A31E1 File Offset: 0x000A13E1
		public FAnimSlotGroup()
		{
		}

		// Token: 0x060071E3 RID: 29155 RVA: 0x000A31E9 File Offset: 0x000A13E9
		public FAnimSlotGroup(FName GroupName, TArray<FName> SlotNames)
		{
			this.GroupName = GroupName;
			this.SlotNames = SlotNames;
		}

		// Token: 0x060071E4 RID: 29156 RVA: 0x000A31FF File Offset: 0x000A13FF
		protected override IntPtr GetUStructPtr()
		{
			return FAnimSlotGroup.StaticStruct();
		}

		// Token: 0x060071E5 RID: 29157 RVA: 0x000A320B File Offset: 0x000A140B
		[NullableContext(2)]
		public FAnimSlotGroup(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060071E6 RID: 29158 RVA: 0x000A3215 File Offset: 0x000A1415
		public FAnimSlotGroup(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060071E7 RID: 29159 RVA: 0x000A3220 File Offset: 0x000A1420
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAnimSlotGroup(Pointer, false, true);
		}

		// Token: 0x060071E8 RID: 29160 RVA: 0x000A322A File Offset: 0x000A142A
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAnimSlotGroup(Pointer, MemoryOwner);
		}

		// Token: 0x040036AF RID: 13999
		public const string __ObjectPath = "/Script/Engine.AnimSlotGroup";

		// Token: 0x040036B0 RID: 14000
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040036B1 RID: 14001
		internal static int __PropertyOffset_GroupName;

		// Token: 0x040036B2 RID: 14002
		internal static int __PropertyOffset_SlotNames;

		// Token: 0x040036B3 RID: 14003
		[Nullable(2)]
		private TArray<FName> _SlotNames;
	}
}
