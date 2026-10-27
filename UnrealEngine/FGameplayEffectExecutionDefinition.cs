using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200138A RID: 5002
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/GameplayAbilities.GameplayEffectExecutionDefinition")]
	[UnrealStructLayout(88, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 88)]
	public class FGameplayEffectExecutionDefinition : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060125C0 RID: 75200 RVA: 0x001AF7BD File Offset: 0x001AD9BD
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FGameplayEffectExecutionDefinition._ScriptStructPtr != 0) ? FGameplayEffectExecutionDefinition._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/GameplayAbilities.GameplayEffectExecutionDefinition", ref FGameplayEffectExecutionDefinition._ScriptStructPtr);
		}

		// Token: 0x17004788 RID: 18312
		// (get) Token: 0x060125C1 RID: 75201 RVA: 0x001AF7E1 File Offset: 0x001AD9E1
		// (set) Token: 0x060125C2 RID: 75202 RVA: 0x001AF7F5 File Offset: 0x001AD9F5
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<UGameplayEffectExecutionCalculation> CalculationClass
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)FGameplayEffectExecutionDefinition.__PropertyOffset_CalculationClass);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)FGameplayEffectExecutionDefinition.__PropertyOffset_CalculationClass) = value;
			}
		}

		// Token: 0x17004789 RID: 18313
		// (get) Token: 0x060125C3 RID: 75203 RVA: 0x001AF80C File Offset: 0x001ADA0C
		// (set) Token: 0x060125C4 RID: 75204 RVA: 0x001AF84F File Offset: 0x001ADA4F
		public FGameplayTagContainer PassedInTags
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayTagContainer result;
				if ((result = this._PassedInTags) == null)
				{
					result = (this._PassedInTags = new FGameplayTagContainer(base.NativePtr + (IntPtr)FGameplayEffectExecutionDefinition.__PropertyOffset_PassedInTags, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayTagContainer.StaticStruct(), base.NativePtr + (IntPtr)FGameplayEffectExecutionDefinition.__PropertyOffset_PassedInTags, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700478A RID: 18314
		// (get) Token: 0x060125C5 RID: 75205 RVA: 0x001AF870 File Offset: 0x001ADA70
		// (set) Token: 0x060125C6 RID: 75206 RVA: 0x001AF8B3 File Offset: 0x001ADAB3
		public TArray<FGameplayEffectExecutionScopedModifierInfo> CalculationModifiers
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FGameplayEffectExecutionScopedModifierInfo> result;
				if ((result = this._CalculationModifiers) == null)
				{
					result = (this._CalculationModifiers = new TArray<FGameplayEffectExecutionScopedModifierInfo>(base.NativePtr + (IntPtr)FGameplayEffectExecutionDefinition.__PropertyOffset_CalculationModifiers, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.CalculationModifiers.CopyAssign(value);
			}
		}

		// Token: 0x1700478B RID: 18315
		// (get) Token: 0x060125C7 RID: 75207 RVA: 0x001AF8C4 File Offset: 0x001ADAC4
		// (set) Token: 0x060125C8 RID: 75208 RVA: 0x001AF907 File Offset: 0x001ADB07
		[Nullable(new byte[]
		{
			1,
			0,
			1
		})]
		public TArray<TSubclassOf<UGameplayEffect>> ConditionalGameplayEffectClasses_DEPRECATED
		{
			[return: Nullable(new byte[]
			{
				1,
				0,
				1
			})]
			get
			{
				base.FastCheckIsValid();
				TArray<TSubclassOf<UGameplayEffect>> result;
				if ((result = this._ConditionalGameplayEffectClasses_DEPRECATED) == null)
				{
					result = (this._ConditionalGameplayEffectClasses_DEPRECATED = new TArray<TSubclassOf<UGameplayEffect>>(base.NativePtr + (IntPtr)FGameplayEffectExecutionDefinition.__PropertyOffset_ConditionalGameplayEffectClasses_DEPRECATED, base.MemoryOwner ?? this));
				}
				return result;
			}
			[param: Nullable(new byte[]
			{
				1,
				0,
				1
			})]
			set
			{
				this.ConditionalGameplayEffectClasses_DEPRECATED.CopyAssign(value);
			}
		}

		// Token: 0x1700478C RID: 18316
		// (get) Token: 0x060125C9 RID: 75209 RVA: 0x001AF918 File Offset: 0x001ADB18
		// (set) Token: 0x060125CA RID: 75210 RVA: 0x001AF95B File Offset: 0x001ADB5B
		public TArray<FConditionalGameplayEffect> ConditionalGameplayEffects
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FConditionalGameplayEffect> result;
				if ((result = this._ConditionalGameplayEffects) == null)
				{
					result = (this._ConditionalGameplayEffects = new TArray<FConditionalGameplayEffect>(base.NativePtr + (IntPtr)FGameplayEffectExecutionDefinition.__PropertyOffset_ConditionalGameplayEffects, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ConditionalGameplayEffects.CopyAssign(value);
			}
		}

		// Token: 0x060125CB RID: 75211 RVA: 0x001AF969 File Offset: 0x001ADB69
		public FGameplayEffectExecutionDefinition()
		{
		}

		// Token: 0x060125CC RID: 75212 RVA: 0x001AF971 File Offset: 0x001ADB71
		public FGameplayEffectExecutionDefinition([Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UGameplayEffectExecutionCalculation> CalculationClass, FGameplayTagContainer PassedInTags, TArray<FGameplayEffectExecutionScopedModifierInfo> CalculationModifiers, [Nullable(new byte[]
		{
			1,
			0,
			1
		})] TArray<TSubclassOf<UGameplayEffect>> ConditionalGameplayEffectClasses_DEPRECATED, TArray<FConditionalGameplayEffect> ConditionalGameplayEffects)
		{
			this.CalculationClass = CalculationClass;
			this.PassedInTags = PassedInTags;
			this.CalculationModifiers = CalculationModifiers;
			this.ConditionalGameplayEffectClasses_DEPRECATED = ConditionalGameplayEffectClasses_DEPRECATED;
			this.ConditionalGameplayEffects = ConditionalGameplayEffects;
		}

		// Token: 0x060125CD RID: 75213 RVA: 0x001AF99E File Offset: 0x001ADB9E
		protected override IntPtr GetUStructPtr()
		{
			return FGameplayEffectExecutionDefinition.StaticStruct();
		}

		// Token: 0x060125CE RID: 75214 RVA: 0x001AF9AA File Offset: 0x001ADBAA
		[NullableContext(2)]
		public FGameplayEffectExecutionDefinition(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060125CF RID: 75215 RVA: 0x001AF9B4 File Offset: 0x001ADBB4
		public FGameplayEffectExecutionDefinition(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060125D0 RID: 75216 RVA: 0x001AF9BF File Offset: 0x001ADBBF
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FGameplayEffectExecutionDefinition(Pointer, false, true);
		}

		// Token: 0x060125D1 RID: 75217 RVA: 0x001AF9C9 File Offset: 0x001ADBC9
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FGameplayEffectExecutionDefinition(Pointer, MemoryOwner);
		}

		// Token: 0x04009D42 RID: 40258
		public const string __ObjectPath = "/Script/GameplayAbilities.GameplayEffectExecutionDefinition";

		// Token: 0x04009D43 RID: 40259
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04009D44 RID: 40260
		internal static int __PropertyOffset_CalculationClass;

		// Token: 0x04009D45 RID: 40261
		internal static int __PropertyOffset_PassedInTags;

		// Token: 0x04009D46 RID: 40262
		[Nullable(2)]
		private FGameplayTagContainer _PassedInTags;

		// Token: 0x04009D47 RID: 40263
		internal static int __PropertyOffset_CalculationModifiers;

		// Token: 0x04009D48 RID: 40264
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FGameplayEffectExecutionScopedModifierInfo> _CalculationModifiers;

		// Token: 0x04009D49 RID: 40265
		internal static int __PropertyOffset_ConditionalGameplayEffectClasses_DEPRECATED;

		// Token: 0x04009D4A RID: 40266
		[Nullable(new byte[]
		{
			2,
			0,
			1
		})]
		private TArray<TSubclassOf<UGameplayEffect>> _ConditionalGameplayEffectClasses_DEPRECATED;

		// Token: 0x04009D4B RID: 40267
		internal static int __PropertyOffset_ConditionalGameplayEffects;

		// Token: 0x04009D4C RID: 40268
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FConditionalGameplayEffect> _ConditionalGameplayEffects;
	}
}
