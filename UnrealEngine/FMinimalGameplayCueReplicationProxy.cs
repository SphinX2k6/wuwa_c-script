using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020013A5 RID: 5029
	[UnrealObjectPath("/Script/GameplayAbilities.MinimalGameplayCueReplicationProxy")]
	[UnrealStructLayout(592, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 592)]
	public class FMinimalGameplayCueReplicationProxy : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06012764 RID: 75620 RVA: 0x001B24B2 File Offset: 0x001B06B2
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMinimalGameplayCueReplicationProxy._ScriptStructPtr != 0) ? FMinimalGameplayCueReplicationProxy._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/GameplayAbilities.MinimalGameplayCueReplicationProxy", ref FMinimalGameplayCueReplicationProxy._ScriptStructPtr);
		}

		// Token: 0x170047F3 RID: 18419
		// (get) Token: 0x06012765 RID: 75621 RVA: 0x001B24D6 File Offset: 0x001B06D6
		// (set) Token: 0x06012766 RID: 75622 RVA: 0x001B24EA File Offset: 0x001B06EA
		[Nullable(2)]
		public unsafe UAbilitySystemComponent Owner
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAbilitySystemComponent>(base.NativePtr / (IntPtr)sizeof(void*) + FMinimalGameplayCueReplicationProxy.__PropertyOffset_Owner);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FMinimalGameplayCueReplicationProxy.__PropertyOffset_Owner, value);
			}
		}

		// Token: 0x06012767 RID: 75623 RVA: 0x001B24FF File Offset: 0x001B06FF
		public FMinimalGameplayCueReplicationProxy()
		{
		}

		// Token: 0x06012768 RID: 75624 RVA: 0x001B2507 File Offset: 0x001B0707
		[NullableContext(1)]
		public FMinimalGameplayCueReplicationProxy(UAbilitySystemComponent Owner)
		{
			this.Owner = Owner;
		}

		// Token: 0x06012769 RID: 75625 RVA: 0x001B2516 File Offset: 0x001B0716
		protected override IntPtr GetUStructPtr()
		{
			return FMinimalGameplayCueReplicationProxy.StaticStruct();
		}

		// Token: 0x0601276A RID: 75626 RVA: 0x001B2522 File Offset: 0x001B0722
		[NullableContext(2)]
		public FMinimalGameplayCueReplicationProxy(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601276B RID: 75627 RVA: 0x001B252C File Offset: 0x001B072C
		public FMinimalGameplayCueReplicationProxy(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601276C RID: 75628 RVA: 0x001B2537 File Offset: 0x001B0737
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMinimalGameplayCueReplicationProxy(Pointer, false, true);
		}

		// Token: 0x0601276D RID: 75629 RVA: 0x001B2541 File Offset: 0x001B0741
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMinimalGameplayCueReplicationProxy(Pointer, MemoryOwner);
		}

		// Token: 0x04009E24 RID: 40484
		[Nullable(1)]
		public const string __ObjectPath = "/Script/GameplayAbilities.MinimalGameplayCueReplicationProxy";

		// Token: 0x04009E25 RID: 40485
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04009E26 RID: 40486
		internal static int __PropertyOffset_Owner;
	}
}
