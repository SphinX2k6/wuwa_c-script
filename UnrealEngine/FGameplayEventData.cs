using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020002C5 RID: 709
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/GameplayAbilities.GameplayEventData")]
	[UnrealStructLayout(184, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 184)]
	public class FGameplayEventData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06004D9C RID: 19868 RVA: 0x0006C67D File Offset: 0x0006A87D
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FGameplayEventData._ScriptStructPtr != 0) ? FGameplayEventData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/GameplayAbilities.GameplayEventData", ref FGameplayEventData._ScriptStructPtr);
		}

		// Token: 0x17000EE3 RID: 3811
		// (get) Token: 0x06004D9D RID: 19869 RVA: 0x0006C6A1 File Offset: 0x0006A8A1
		// (set) Token: 0x06004D9E RID: 19870 RVA: 0x0006C6B5 File Offset: 0x0006A8B5
		public unsafe FGameplayTag EventTag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGameplayEventData.__PropertyOffset_EventTag);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGameplayEventData.__PropertyOffset_EventTag) = value;
			}
		}

		// Token: 0x17000EE4 RID: 3812
		// (get) Token: 0x06004D9F RID: 19871 RVA: 0x0006C6CA File Offset: 0x0006A8CA
		// (set) Token: 0x06004DA0 RID: 19872 RVA: 0x0006C6DE File Offset: 0x0006A8DE
		public unsafe AActor Instigator
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + FGameplayEventData.__PropertyOffset_Instigator);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FGameplayEventData.__PropertyOffset_Instigator, value);
			}
		}

		// Token: 0x17000EE5 RID: 3813
		// (get) Token: 0x06004DA1 RID: 19873 RVA: 0x0006C6F3 File Offset: 0x0006A8F3
		// (set) Token: 0x06004DA2 RID: 19874 RVA: 0x0006C707 File Offset: 0x0006A907
		public unsafe AActor Target
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + FGameplayEventData.__PropertyOffset_Target);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FGameplayEventData.__PropertyOffset_Target, value);
			}
		}

		// Token: 0x17000EE6 RID: 3814
		// (get) Token: 0x06004DA3 RID: 19875 RVA: 0x0006C71C File Offset: 0x0006A91C
		// (set) Token: 0x06004DA4 RID: 19876 RVA: 0x0006C730 File Offset: 0x0006A930
		public unsafe UObject OptionalObject
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UObject>(base.NativePtr / (IntPtr)sizeof(void*) + FGameplayEventData.__PropertyOffset_OptionalObject);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FGameplayEventData.__PropertyOffset_OptionalObject, value);
			}
		}

		// Token: 0x17000EE7 RID: 3815
		// (get) Token: 0x06004DA5 RID: 19877 RVA: 0x0006C745 File Offset: 0x0006A945
		// (set) Token: 0x06004DA6 RID: 19878 RVA: 0x0006C759 File Offset: 0x0006A959
		public unsafe UObject OptionalObject2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UObject>(base.NativePtr / (IntPtr)sizeof(void*) + FGameplayEventData.__PropertyOffset_OptionalObject2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FGameplayEventData.__PropertyOffset_OptionalObject2, value);
			}
		}

		// Token: 0x17000EE8 RID: 3816
		// (get) Token: 0x06004DA7 RID: 19879 RVA: 0x0006C770 File Offset: 0x0006A970
		// (set) Token: 0x06004DA8 RID: 19880 RVA: 0x0006C7B3 File Offset: 0x0006A9B3
		[Nullable(1)]
		public FGameplayTagContainer InstigatorTags
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FGameplayTagContainer result;
				if ((result = this._InstigatorTags) == null)
				{
					result = (this._InstigatorTags = new FGameplayTagContainer(base.NativePtr + (IntPtr)FGameplayEventData.__PropertyOffset_InstigatorTags, base.MemoryOwner ?? this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayTagContainer.StaticStruct(), base.NativePtr + (IntPtr)FGameplayEventData.__PropertyOffset_InstigatorTags, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000EE9 RID: 3817
		// (get) Token: 0x06004DA9 RID: 19881 RVA: 0x0006C7D4 File Offset: 0x0006A9D4
		// (set) Token: 0x06004DAA RID: 19882 RVA: 0x0006C817 File Offset: 0x0006AA17
		[Nullable(1)]
		public FGameplayTagContainer TargetTags
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FGameplayTagContainer result;
				if ((result = this._TargetTags) == null)
				{
					result = (this._TargetTags = new FGameplayTagContainer(base.NativePtr + (IntPtr)FGameplayEventData.__PropertyOffset_TargetTags, base.MemoryOwner ?? this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayTagContainer.StaticStruct(), base.NativePtr + (IntPtr)FGameplayEventData.__PropertyOffset_TargetTags, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000EEA RID: 3818
		// (get) Token: 0x06004DAB RID: 19883 RVA: 0x0006C838 File Offset: 0x0006AA38
		// (set) Token: 0x06004DAC RID: 19884 RVA: 0x0006C848 File Offset: 0x0006AA48
		public unsafe float EventMagnitude
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGameplayEventData.__PropertyOffset_EventMagnitude);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGameplayEventData.__PropertyOffset_EventMagnitude) = value;
			}
		}

		// Token: 0x06004DAD RID: 19885 RVA: 0x0006C859 File Offset: 0x0006AA59
		public FGameplayEventData()
		{
		}

		// Token: 0x06004DAE RID: 19886 RVA: 0x0006C861 File Offset: 0x0006AA61
		protected override IntPtr GetUStructPtr()
		{
			return FGameplayEventData.StaticStruct();
		}

		// Token: 0x06004DAF RID: 19887 RVA: 0x0006C86D File Offset: 0x0006AA6D
		public FGameplayEventData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06004DB0 RID: 19888 RVA: 0x0006C877 File Offset: 0x0006AA77
		public FGameplayEventData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06004DB1 RID: 19889 RVA: 0x0006C882 File Offset: 0x0006AA82
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FGameplayEventData(Pointer, false, true);
		}

		// Token: 0x06004DB2 RID: 19890 RVA: 0x0006C88C File Offset: 0x0006AA8C
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FGameplayEventData(Pointer, MemoryOwner);
		}

		// Token: 0x04001EF5 RID: 7925
		[Nullable(1)]
		public const string __ObjectPath = "/Script/GameplayAbilities.GameplayEventData";

		// Token: 0x04001EF6 RID: 7926
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04001EF7 RID: 7927
		internal static int __PropertyOffset_EventTag;

		// Token: 0x04001EF8 RID: 7928
		internal static int __PropertyOffset_Instigator;

		// Token: 0x04001EF9 RID: 7929
		internal static int __PropertyOffset_Target;

		// Token: 0x04001EFA RID: 7930
		internal static int __PropertyOffset_OptionalObject;

		// Token: 0x04001EFB RID: 7931
		internal static int __PropertyOffset_OptionalObject2;

		// Token: 0x04001EFC RID: 7932
		internal static int __PropertyOffset_InstigatorTags;

		// Token: 0x04001EFD RID: 7933
		private FGameplayTagContainer _InstigatorTags;

		// Token: 0x04001EFE RID: 7934
		internal static int __PropertyOffset_TargetTags;

		// Token: 0x04001EFF RID: 7935
		private FGameplayTagContainer _TargetTags;

		// Token: 0x04001F00 RID: 7936
		internal static int __PropertyOffset_EventMagnitude;
	}
}
