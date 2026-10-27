using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020013A0 RID: 5024
	[UnrealObjectPath("/Script/GameplayAbilities.GameplayTargetDataFilter")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FGameplayTargetDataFilter : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601272B RID: 75563 RVA: 0x001B1EF6 File Offset: 0x001B00F6
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FGameplayTargetDataFilter._ScriptStructPtr != 0) ? FGameplayTargetDataFilter._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/GameplayAbilities.GameplayTargetDataFilter", ref FGameplayTargetDataFilter._ScriptStructPtr);
		}

		// Token: 0x170047EC RID: 18412
		// (get) Token: 0x0601272C RID: 75564 RVA: 0x001B1F1A File Offset: 0x001B011A
		// (set) Token: 0x0601272D RID: 75565 RVA: 0x001B1F2E File Offset: 0x001B012E
		[Nullable(2)]
		public unsafe AActor SelfActor
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + FGameplayTargetDataFilter.__PropertyOffset_SelfActor);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FGameplayTargetDataFilter.__PropertyOffset_SelfActor, value);
			}
		}

		// Token: 0x170047ED RID: 18413
		// (get) Token: 0x0601272E RID: 75566 RVA: 0x001B1F43 File Offset: 0x001B0143
		// (set) Token: 0x0601272F RID: 75567 RVA: 0x001B1F57 File Offset: 0x001B0157
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<AActor> RequiredActorClass
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)FGameplayTargetDataFilter.__PropertyOffset_RequiredActorClass);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)FGameplayTargetDataFilter.__PropertyOffset_RequiredActorClass) = value;
			}
		}

		// Token: 0x170047EE RID: 18414
		// (get) Token: 0x06012730 RID: 75568 RVA: 0x001B1F6C File Offset: 0x001B016C
		// (set) Token: 0x06012731 RID: 75569 RVA: 0x001B1F80 File Offset: 0x001B0180
		public unsafe TEnumAsByte<ETargetDataFilterSelf> SelfFilter
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGameplayTargetDataFilter.__PropertyOffset_SelfFilter);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGameplayTargetDataFilter.__PropertyOffset_SelfFilter) = value;
			}
		}

		// Token: 0x170047EF RID: 18415
		// (get) Token: 0x06012732 RID: 75570 RVA: 0x001B1F95 File Offset: 0x001B0195
		// (set) Token: 0x06012733 RID: 75571 RVA: 0x001B1FA5 File Offset: 0x001B01A5
		public unsafe bool bReverseFilter
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGameplayTargetDataFilter.__PropertyOffset_bReverseFilter) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGameplayTargetDataFilter.__PropertyOffset_bReverseFilter) = (value ? 1 : 0);
			}
		}

		// Token: 0x06012734 RID: 75572 RVA: 0x001B1FB6 File Offset: 0x001B01B6
		public FGameplayTargetDataFilter()
		{
		}

		// Token: 0x06012735 RID: 75573 RVA: 0x001B1FBE File Offset: 0x001B01BE
		public FGameplayTargetDataFilter([Nullable(1)] AActor SelfActor, [Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<AActor> RequiredActorClass, TEnumAsByte<ETargetDataFilterSelf> SelfFilter, bool bReverseFilter)
		{
			this.SelfActor = SelfActor;
			this.RequiredActorClass = RequiredActorClass;
			this.SelfFilter = SelfFilter;
			this.bReverseFilter = bReverseFilter;
		}

		// Token: 0x06012736 RID: 75574 RVA: 0x001B1FE3 File Offset: 0x001B01E3
		protected override IntPtr GetUStructPtr()
		{
			return FGameplayTargetDataFilter.StaticStruct();
		}

		// Token: 0x06012737 RID: 75575 RVA: 0x001B1FEF File Offset: 0x001B01EF
		[NullableContext(2)]
		public FGameplayTargetDataFilter(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06012738 RID: 75576 RVA: 0x001B1FF9 File Offset: 0x001B01F9
		public FGameplayTargetDataFilter(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06012739 RID: 75577 RVA: 0x001B2004 File Offset: 0x001B0204
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FGameplayTargetDataFilter(Pointer, false, true);
		}

		// Token: 0x0601273A RID: 75578 RVA: 0x001B200E File Offset: 0x001B020E
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FGameplayTargetDataFilter(Pointer, MemoryOwner);
		}

		// Token: 0x04009E0E RID: 40462
		[Nullable(1)]
		public const string __ObjectPath = "/Script/GameplayAbilities.GameplayTargetDataFilter";

		// Token: 0x04009E0F RID: 40463
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04009E10 RID: 40464
		internal static int __PropertyOffset_SelfActor;

		// Token: 0x04009E11 RID: 40465
		internal static int __PropertyOffset_RequiredActorClass;

		// Token: 0x04009E12 RID: 40466
		internal static int __PropertyOffset_SelfFilter;

		// Token: 0x04009E13 RID: 40467
		internal static int __PropertyOffset_bReverseFilter;
	}
}
