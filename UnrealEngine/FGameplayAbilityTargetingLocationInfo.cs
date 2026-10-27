using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001363 RID: 4963
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/GameplayAbilities.GameplayAbilityTargetingLocationInfo")]
	[UnrealStructLayout(128, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 128)]
	public class FGameplayAbilityTargetingLocationInfo : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06012333 RID: 74547 RVA: 0x001AB87F File Offset: 0x001A9A7F
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FGameplayAbilityTargetingLocationInfo._ScriptStructPtr != 0) ? FGameplayAbilityTargetingLocationInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/GameplayAbilities.GameplayAbilityTargetingLocationInfo", ref FGameplayAbilityTargetingLocationInfo._ScriptStructPtr);
		}

		// Token: 0x170046E1 RID: 18145
		// (get) Token: 0x06012334 RID: 74548 RVA: 0x001AB8A3 File Offset: 0x001A9AA3
		// (set) Token: 0x06012335 RID: 74549 RVA: 0x001AB8B7 File Offset: 0x001A9AB7
		[Nullable(0)]
		public unsafe TEnumAsByte<EGameplayAbilityTargetingLocationType> LocationType
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)FGameplayAbilityTargetingLocationInfo.__PropertyOffset_LocationType);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)FGameplayAbilityTargetingLocationInfo.__PropertyOffset_LocationType) = value;
			}
		}

		// Token: 0x170046E2 RID: 18146
		// (get) Token: 0x06012336 RID: 74550 RVA: 0x001AB8CC File Offset: 0x001A9ACC
		// (set) Token: 0x06012337 RID: 74551 RVA: 0x001AB8E0 File Offset: 0x001A9AE0
		public unsafe FTransform LiteralTransform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGameplayAbilityTargetingLocationInfo.__PropertyOffset_LiteralTransform);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGameplayAbilityTargetingLocationInfo.__PropertyOffset_LiteralTransform) = value;
			}
		}

		// Token: 0x170046E3 RID: 18147
		// (get) Token: 0x06012338 RID: 74552 RVA: 0x001AB8F5 File Offset: 0x001A9AF5
		// (set) Token: 0x06012339 RID: 74553 RVA: 0x001AB909 File Offset: 0x001A9B09
		public unsafe AActor SourceActor
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + FGameplayAbilityTargetingLocationInfo.__PropertyOffset_SourceActor);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FGameplayAbilityTargetingLocationInfo.__PropertyOffset_SourceActor, value);
			}
		}

		// Token: 0x170046E4 RID: 18148
		// (get) Token: 0x0601233A RID: 74554 RVA: 0x001AB91E File Offset: 0x001A9B1E
		// (set) Token: 0x0601233B RID: 74555 RVA: 0x001AB932 File Offset: 0x001A9B32
		public unsafe UMeshComponent SourceComponent
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + FGameplayAbilityTargetingLocationInfo.__PropertyOffset_SourceComponent);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FGameplayAbilityTargetingLocationInfo.__PropertyOffset_SourceComponent, value);
			}
		}

		// Token: 0x170046E5 RID: 18149
		// (get) Token: 0x0601233C RID: 74556 RVA: 0x001AB947 File Offset: 0x001A9B47
		// (set) Token: 0x0601233D RID: 74557 RVA: 0x001AB95B File Offset: 0x001A9B5B
		public unsafe UGameplayAbility SourceAbility
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UGameplayAbility>(base.NativePtr / (IntPtr)sizeof(void*) + FGameplayAbilityTargetingLocationInfo.__PropertyOffset_SourceAbility);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FGameplayAbilityTargetingLocationInfo.__PropertyOffset_SourceAbility, value);
			}
		}

		// Token: 0x170046E6 RID: 18150
		// (get) Token: 0x0601233E RID: 74558 RVA: 0x001AB970 File Offset: 0x001A9B70
		// (set) Token: 0x0601233F RID: 74559 RVA: 0x001AB984 File Offset: 0x001A9B84
		public unsafe FName SourceSocketName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGameplayAbilityTargetingLocationInfo.__PropertyOffset_SourceSocketName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGameplayAbilityTargetingLocationInfo.__PropertyOffset_SourceSocketName) = value;
			}
		}

		// Token: 0x06012340 RID: 74560 RVA: 0x001AB999 File Offset: 0x001A9B99
		public FGameplayAbilityTargetingLocationInfo()
		{
		}

		// Token: 0x06012341 RID: 74561 RVA: 0x001AB9A1 File Offset: 0x001A9BA1
		[NullableContext(1)]
		public FGameplayAbilityTargetingLocationInfo([Nullable(0)] TEnumAsByte<EGameplayAbilityTargetingLocationType> LocationType, FTransform LiteralTransform, AActor SourceActor, UMeshComponent SourceComponent, UGameplayAbility SourceAbility, FName SourceSocketName)
		{
			this.LocationType = LocationType;
			this.LiteralTransform = LiteralTransform;
			this.SourceActor = SourceActor;
			this.SourceComponent = SourceComponent;
			this.SourceAbility = SourceAbility;
			this.SourceSocketName = SourceSocketName;
		}

		// Token: 0x06012342 RID: 74562 RVA: 0x001AB9D6 File Offset: 0x001A9BD6
		protected override IntPtr GetUStructPtr()
		{
			return FGameplayAbilityTargetingLocationInfo.StaticStruct();
		}

		// Token: 0x06012343 RID: 74563 RVA: 0x001AB9E2 File Offset: 0x001A9BE2
		public FGameplayAbilityTargetingLocationInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06012344 RID: 74564 RVA: 0x001AB9EC File Offset: 0x001A9BEC
		public FGameplayAbilityTargetingLocationInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06012345 RID: 74565 RVA: 0x001AB9F7 File Offset: 0x001A9BF7
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FGameplayAbilityTargetingLocationInfo(Pointer, false, true);
		}

		// Token: 0x06012346 RID: 74566 RVA: 0x001ABA01 File Offset: 0x001A9C01
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FGameplayAbilityTargetingLocationInfo(Pointer, MemoryOwner);
		}

		// Token: 0x04009BFB RID: 39931
		[Nullable(1)]
		public const string __ObjectPath = "/Script/GameplayAbilities.GameplayAbilityTargetingLocationInfo";

		// Token: 0x04009BFC RID: 39932
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04009BFD RID: 39933
		internal static int __PropertyOffset_LocationType;

		// Token: 0x04009BFE RID: 39934
		internal static int __PropertyOffset_LiteralTransform;

		// Token: 0x04009BFF RID: 39935
		internal static int __PropertyOffset_SourceActor;

		// Token: 0x04009C00 RID: 39936
		internal static int __PropertyOffset_SourceComponent;

		// Token: 0x04009C01 RID: 39937
		internal static int __PropertyOffset_SourceAbility;

		// Token: 0x04009C02 RID: 39938
		internal static int __PropertyOffset_SourceSocketName;
	}
}
