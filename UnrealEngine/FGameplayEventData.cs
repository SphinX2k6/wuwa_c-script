using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001395 RID: 5013
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/GameplayAbilities.GameplayEventData")]
	[UnrealStructLayout(184, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 184)]
	public class FGameplayEventData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06012686 RID: 75398 RVA: 0x001B0EC7 File Offset: 0x001AF0C7
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FGameplayEventData._ScriptStructPtr != 0) ? FGameplayEventData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/GameplayAbilities.GameplayEventData", ref FGameplayEventData._ScriptStructPtr);
		}

		// Token: 0x170047C3 RID: 18371
		// (get) Token: 0x06012687 RID: 75399 RVA: 0x001B0EEB File Offset: 0x001AF0EB
		// (set) Token: 0x06012688 RID: 75400 RVA: 0x001B0EFF File Offset: 0x001AF0FF
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

		// Token: 0x170047C4 RID: 18372
		// (get) Token: 0x06012689 RID: 75401 RVA: 0x001B0F14 File Offset: 0x001AF114
		// (set) Token: 0x0601268A RID: 75402 RVA: 0x001B0F28 File Offset: 0x001AF128
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

		// Token: 0x170047C5 RID: 18373
		// (get) Token: 0x0601268B RID: 75403 RVA: 0x001B0F3D File Offset: 0x001AF13D
		// (set) Token: 0x0601268C RID: 75404 RVA: 0x001B0F51 File Offset: 0x001AF151
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

		// Token: 0x170047C6 RID: 18374
		// (get) Token: 0x0601268D RID: 75405 RVA: 0x001B0F66 File Offset: 0x001AF166
		// (set) Token: 0x0601268E RID: 75406 RVA: 0x001B0F7A File Offset: 0x001AF17A
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

		// Token: 0x170047C7 RID: 18375
		// (get) Token: 0x0601268F RID: 75407 RVA: 0x001B0F8F File Offset: 0x001AF18F
		// (set) Token: 0x06012690 RID: 75408 RVA: 0x001B0FA3 File Offset: 0x001AF1A3
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

		// Token: 0x170047C8 RID: 18376
		// (get) Token: 0x06012691 RID: 75409 RVA: 0x001B0FB8 File Offset: 0x001AF1B8
		// (set) Token: 0x06012692 RID: 75410 RVA: 0x001B0FFB File Offset: 0x001AF1FB
		[Nullable(1)]
		public FGameplayEffectContextHandle ContextHandle
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FGameplayEffectContextHandle result;
				if ((result = this._ContextHandle) == null)
				{
					result = (this._ContextHandle = new FGameplayEffectContextHandle(base.NativePtr + (IntPtr)FGameplayEventData.__PropertyOffset_ContextHandle, base.MemoryOwner ?? this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayEffectContextHandle.StaticStruct(), base.NativePtr + (IntPtr)FGameplayEventData.__PropertyOffset_ContextHandle, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170047C9 RID: 18377
		// (get) Token: 0x06012693 RID: 75411 RVA: 0x001B101C File Offset: 0x001AF21C
		// (set) Token: 0x06012694 RID: 75412 RVA: 0x001B105F File Offset: 0x001AF25F
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

		// Token: 0x170047CA RID: 18378
		// (get) Token: 0x06012695 RID: 75413 RVA: 0x001B1080 File Offset: 0x001AF280
		// (set) Token: 0x06012696 RID: 75414 RVA: 0x001B10C3 File Offset: 0x001AF2C3
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

		// Token: 0x170047CB RID: 18379
		// (get) Token: 0x06012697 RID: 75415 RVA: 0x001B10E4 File Offset: 0x001AF2E4
		// (set) Token: 0x06012698 RID: 75416 RVA: 0x001B10F4 File Offset: 0x001AF2F4
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

		// Token: 0x170047CC RID: 18380
		// (get) Token: 0x06012699 RID: 75417 RVA: 0x001B1108 File Offset: 0x001AF308
		// (set) Token: 0x0601269A RID: 75418 RVA: 0x001B114B File Offset: 0x001AF34B
		[Nullable(1)]
		public FGameplayAbilityTargetDataHandle TargetData
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FGameplayAbilityTargetDataHandle result;
				if ((result = this._TargetData) == null)
				{
					result = (this._TargetData = new FGameplayAbilityTargetDataHandle(base.NativePtr + (IntPtr)FGameplayEventData.__PropertyOffset_TargetData, base.MemoryOwner ?? this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayAbilityTargetDataHandle.StaticStruct(), base.NativePtr + (IntPtr)FGameplayEventData.__PropertyOffset_TargetData, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0601269B RID: 75419 RVA: 0x001B116C File Offset: 0x001AF36C
		public FGameplayEventData()
		{
		}

		// Token: 0x0601269C RID: 75420 RVA: 0x001B1174 File Offset: 0x001AF374
		[NullableContext(1)]
		public FGameplayEventData(FGameplayTag EventTag, AActor Instigator, AActor Target, UObject OptionalObject, UObject OptionalObject2, FGameplayEffectContextHandle ContextHandle, FGameplayTagContainer InstigatorTags, FGameplayTagContainer TargetTags, float EventMagnitude, FGameplayAbilityTargetDataHandle TargetData)
		{
			this.EventTag = EventTag;
			this.Instigator = Instigator;
			this.Target = Target;
			this.OptionalObject = OptionalObject;
			this.OptionalObject2 = OptionalObject2;
			this.ContextHandle = ContextHandle;
			this.InstigatorTags = InstigatorTags;
			this.TargetTags = TargetTags;
			this.EventMagnitude = EventMagnitude;
			this.TargetData = TargetData;
		}

		// Token: 0x0601269D RID: 75421 RVA: 0x001B11D4 File Offset: 0x001AF3D4
		protected override IntPtr GetUStructPtr()
		{
			return FGameplayEventData.StaticStruct();
		}

		// Token: 0x0601269E RID: 75422 RVA: 0x001B11E0 File Offset: 0x001AF3E0
		public FGameplayEventData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601269F RID: 75423 RVA: 0x001B11EA File Offset: 0x001AF3EA
		public FGameplayEventData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060126A0 RID: 75424 RVA: 0x001B11F5 File Offset: 0x001AF3F5
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FGameplayEventData(Pointer, false, true);
		}

		// Token: 0x060126A1 RID: 75425 RVA: 0x001B11FF File Offset: 0x001AF3FF
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FGameplayEventData(Pointer, MemoryOwner);
		}

		// Token: 0x04009DBA RID: 40378
		[Nullable(1)]
		public const string __ObjectPath = "/Script/GameplayAbilities.GameplayEventData";

		// Token: 0x04009DBB RID: 40379
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04009DBC RID: 40380
		internal static int __PropertyOffset_EventTag;

		// Token: 0x04009DBD RID: 40381
		internal static int __PropertyOffset_Instigator;

		// Token: 0x04009DBE RID: 40382
		internal static int __PropertyOffset_Target;

		// Token: 0x04009DBF RID: 40383
		internal static int __PropertyOffset_OptionalObject;

		// Token: 0x04009DC0 RID: 40384
		internal static int __PropertyOffset_OptionalObject2;

		// Token: 0x04009DC1 RID: 40385
		internal static int __PropertyOffset_ContextHandle;

		// Token: 0x04009DC2 RID: 40386
		private FGameplayEffectContextHandle _ContextHandle;

		// Token: 0x04009DC3 RID: 40387
		internal static int __PropertyOffset_InstigatorTags;

		// Token: 0x04009DC4 RID: 40388
		private FGameplayTagContainer _InstigatorTags;

		// Token: 0x04009DC5 RID: 40389
		internal static int __PropertyOffset_TargetTags;

		// Token: 0x04009DC6 RID: 40390
		private FGameplayTagContainer _TargetTags;

		// Token: 0x04009DC7 RID: 40391
		internal static int __PropertyOffset_EventMagnitude;

		// Token: 0x04009DC8 RID: 40392
		internal static int __PropertyOffset_TargetData;

		// Token: 0x04009DC9 RID: 40393
		private FGameplayAbilityTargetDataHandle _TargetData;
	}
}
