using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020013A6 RID: 5030
	[UnrealObjectPath("/Script/GameplayAbilities.MinimalReplicationTagCountMap")]
	[UnrealStructLayout(96, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 96)]
	public class FMinimalReplicationTagCountMap : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601276E RID: 75630 RVA: 0x001B254A File Offset: 0x001B074A
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMinimalReplicationTagCountMap._ScriptStructPtr != 0) ? FMinimalReplicationTagCountMap._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/GameplayAbilities.MinimalReplicationTagCountMap", ref FMinimalReplicationTagCountMap._ScriptStructPtr);
		}

		// Token: 0x170047F4 RID: 18420
		// (get) Token: 0x0601276F RID: 75631 RVA: 0x001B256E File Offset: 0x001B076E
		// (set) Token: 0x06012770 RID: 75632 RVA: 0x001B2582 File Offset: 0x001B0782
		[Nullable(2)]
		public unsafe UAbilitySystemComponent Owner
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAbilitySystemComponent>(base.NativePtr / (IntPtr)sizeof(void*) + FMinimalReplicationTagCountMap.__PropertyOffset_Owner);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FMinimalReplicationTagCountMap.__PropertyOffset_Owner, value);
			}
		}

		// Token: 0x06012771 RID: 75633 RVA: 0x001B2597 File Offset: 0x001B0797
		public FMinimalReplicationTagCountMap()
		{
		}

		// Token: 0x06012772 RID: 75634 RVA: 0x001B259F File Offset: 0x001B079F
		[NullableContext(1)]
		public FMinimalReplicationTagCountMap(UAbilitySystemComponent Owner)
		{
			this.Owner = Owner;
		}

		// Token: 0x06012773 RID: 75635 RVA: 0x001B25AE File Offset: 0x001B07AE
		protected override IntPtr GetUStructPtr()
		{
			return FMinimalReplicationTagCountMap.StaticStruct();
		}

		// Token: 0x06012774 RID: 75636 RVA: 0x001B25BA File Offset: 0x001B07BA
		[NullableContext(2)]
		public FMinimalReplicationTagCountMap(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06012775 RID: 75637 RVA: 0x001B25C4 File Offset: 0x001B07C4
		public FMinimalReplicationTagCountMap(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06012776 RID: 75638 RVA: 0x001B25CF File Offset: 0x001B07CF
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMinimalReplicationTagCountMap(Pointer, false, true);
		}

		// Token: 0x06012777 RID: 75639 RVA: 0x001B25D9 File Offset: 0x001B07D9
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMinimalReplicationTagCountMap(Pointer, MemoryOwner);
		}

		// Token: 0x04009E27 RID: 40487
		[Nullable(1)]
		public const string __ObjectPath = "/Script/GameplayAbilities.MinimalReplicationTagCountMap";

		// Token: 0x04009E28 RID: 40488
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04009E29 RID: 40489
		internal static int __PropertyOffset_Owner;
	}
}
