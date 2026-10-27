using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000123 RID: 291
	[UnrealObjectPath("/Script/AIModule.BlackboardEntry")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FBlackboardEntry : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06001540 RID: 5440 RVA: 0x0001F3E3 File Offset: 0x0001D5E3
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FBlackboardEntry._ScriptStructPtr != 0) ? FBlackboardEntry._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AIModule.BlackboardEntry", ref FBlackboardEntry._ScriptStructPtr);
		}

		// Token: 0x170005A1 RID: 1441
		// (get) Token: 0x06001541 RID: 5441 RVA: 0x0001F407 File Offset: 0x0001D607
		// (set) Token: 0x06001542 RID: 5442 RVA: 0x0001F41B File Offset: 0x0001D61B
		public unsafe FName EntryName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBlackboardEntry.__PropertyOffset_EntryName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBlackboardEntry.__PropertyOffset_EntryName) = value;
			}
		}

		// Token: 0x170005A2 RID: 1442
		// (get) Token: 0x06001543 RID: 5443 RVA: 0x0001F430 File Offset: 0x0001D630
		// (set) Token: 0x06001544 RID: 5444 RVA: 0x0001F444 File Offset: 0x0001D644
		[Nullable(2)]
		public unsafe UBlackboardKeyType KeyType
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBlackboardKeyType>(base.NativePtr / (IntPtr)sizeof(void*) + FBlackboardEntry.__PropertyOffset_KeyType);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FBlackboardEntry.__PropertyOffset_KeyType, value);
			}
		}

		// Token: 0x170005A3 RID: 1443
		// (get) Token: 0x06001545 RID: 5445 RVA: 0x0001F459 File Offset: 0x0001D659
		// (set) Token: 0x06001546 RID: 5446 RVA: 0x0001F472 File Offset: 0x0001D672
		public unsafe bool bInstanceSynced
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FBlackboardEntry.__PropertyOffset_bInstanceSynced) & FBlackboardEntry.__PropertyMask_bInstanceSynced) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FBlackboardEntry.__PropertyOffset_bInstanceSynced) = ((*(base.NativePtr + (IntPtr)FBlackboardEntry.__PropertyOffset_bInstanceSynced) & ~FBlackboardEntry.__PropertyMask_bInstanceSynced) | (value ? FBlackboardEntry.__PropertyMask_bInstanceSynced : 0));
			}
		}

		// Token: 0x06001547 RID: 5447 RVA: 0x0001F4A2 File Offset: 0x0001D6A2
		public FBlackboardEntry()
		{
		}

		// Token: 0x06001548 RID: 5448 RVA: 0x0001F4AA File Offset: 0x0001D6AA
		[NullableContext(1)]
		public FBlackboardEntry(FName EntryName, string EntryDescription, UBlackboardKeyType KeyType, bool bInstanceSynced)
		{
			this.EntryName = EntryName;
			this.KeyType = KeyType;
			this.bInstanceSynced = bInstanceSynced;
		}

		// Token: 0x06001549 RID: 5449 RVA: 0x0001F4C8 File Offset: 0x0001D6C8
		protected override IntPtr GetUStructPtr()
		{
			return FBlackboardEntry.StaticStruct();
		}

		// Token: 0x0600154A RID: 5450 RVA: 0x0001F4D4 File Offset: 0x0001D6D4
		[NullableContext(2)]
		public FBlackboardEntry(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600154B RID: 5451 RVA: 0x0001F4DE File Offset: 0x0001D6DE
		public FBlackboardEntry(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600154C RID: 5452 RVA: 0x0001F4E9 File Offset: 0x0001D6E9
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FBlackboardEntry(Pointer, false, true);
		}

		// Token: 0x0600154D RID: 5453 RVA: 0x0001F4F3 File Offset: 0x0001D6F3
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FBlackboardEntry(Pointer, MemoryOwner);
		}

		// Token: 0x04000471 RID: 1137
		[Nullable(1)]
		public const string __ObjectPath = "/Script/AIModule.BlackboardEntry";

		// Token: 0x04000472 RID: 1138
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04000473 RID: 1139
		internal static int __PropertyOffset_EntryName;

		// Token: 0x04000474 RID: 1140
		internal static int __PropertyOffset_KeyType;

		// Token: 0x04000475 RID: 1141
		internal static int __PropertyOffset_bInstanceSynced;

		// Token: 0x04000476 RID: 1142
		internal static byte __PropertyMask_bInstanceSynced;
	}
}
