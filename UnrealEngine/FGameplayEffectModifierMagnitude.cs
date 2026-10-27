using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200138D RID: 5005
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/GameplayAbilities.GameplayEffectModifierMagnitude")]
	[UnrealStructLayout(536, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 536)]
	public class FGameplayEffectModifierMagnitude : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060125F6 RID: 75254 RVA: 0x001AFDE7 File Offset: 0x001ADFE7
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FGameplayEffectModifierMagnitude._ScriptStructPtr != 0) ? FGameplayEffectModifierMagnitude._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/GameplayAbilities.GameplayEffectModifierMagnitude", ref FGameplayEffectModifierMagnitude._ScriptStructPtr);
		}

		// Token: 0x17004797 RID: 18327
		// (get) Token: 0x060125F7 RID: 75255 RVA: 0x001AFE0B File Offset: 0x001AE00B
		// (set) Token: 0x060125F8 RID: 75256 RVA: 0x001AFE1B File Offset: 0x001AE01B
		public unsafe EGameplayEffectMagnitudeCalculation MagnitudeCalculationType
		{
			get
			{
				return (EGameplayEffectMagnitudeCalculation)(*(base.NativePtr + (IntPtr)FGameplayEffectModifierMagnitude.__PropertyOffset_MagnitudeCalculationType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGameplayEffectModifierMagnitude.__PropertyOffset_MagnitudeCalculationType) = (byte)value;
			}
		}

		// Token: 0x17004798 RID: 18328
		// (get) Token: 0x060125F9 RID: 75257 RVA: 0x001AFE2C File Offset: 0x001AE02C
		// (set) Token: 0x060125FA RID: 75258 RVA: 0x001AFE6F File Offset: 0x001AE06F
		public FScalableFloat ScalableFloatMagnitude
		{
			get
			{
				base.FastCheckIsValid();
				FScalableFloat result;
				if ((result = this._ScalableFloatMagnitude) == null)
				{
					result = (this._ScalableFloatMagnitude = new FScalableFloat(base.NativePtr + (IntPtr)FGameplayEffectModifierMagnitude.__PropertyOffset_ScalableFloatMagnitude, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FScalableFloat.StaticStruct(), base.NativePtr + (IntPtr)FGameplayEffectModifierMagnitude.__PropertyOffset_ScalableFloatMagnitude, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17004799 RID: 18329
		// (get) Token: 0x060125FB RID: 75259 RVA: 0x001AFE90 File Offset: 0x001AE090
		// (set) Token: 0x060125FC RID: 75260 RVA: 0x001AFED3 File Offset: 0x001AE0D3
		public FAttributeBasedFloat AttributeBasedMagnitude
		{
			get
			{
				base.FastCheckIsValid();
				FAttributeBasedFloat result;
				if ((result = this._AttributeBasedMagnitude) == null)
				{
					result = (this._AttributeBasedMagnitude = new FAttributeBasedFloat(base.NativePtr + (IntPtr)FGameplayEffectModifierMagnitude.__PropertyOffset_AttributeBasedMagnitude, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FAttributeBasedFloat.StaticStruct(), base.NativePtr + (IntPtr)FGameplayEffectModifierMagnitude.__PropertyOffset_AttributeBasedMagnitude, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700479A RID: 18330
		// (get) Token: 0x060125FD RID: 75261 RVA: 0x001AFEF4 File Offset: 0x001AE0F4
		// (set) Token: 0x060125FE RID: 75262 RVA: 0x001AFF37 File Offset: 0x001AE137
		public FCustomCalculationBasedFloat CustomMagnitude
		{
			get
			{
				base.FastCheckIsValid();
				FCustomCalculationBasedFloat result;
				if ((result = this._CustomMagnitude) == null)
				{
					result = (this._CustomMagnitude = new FCustomCalculationBasedFloat(base.NativePtr + (IntPtr)FGameplayEffectModifierMagnitude.__PropertyOffset_CustomMagnitude, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FCustomCalculationBasedFloat.StaticStruct(), base.NativePtr + (IntPtr)FGameplayEffectModifierMagnitude.__PropertyOffset_CustomMagnitude, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700479B RID: 18331
		// (get) Token: 0x060125FF RID: 75263 RVA: 0x001AFF58 File Offset: 0x001AE158
		// (set) Token: 0x06012600 RID: 75264 RVA: 0x001AFF9B File Offset: 0x001AE19B
		public FSetByCallerFloat SetByCallerMagnitude
		{
			get
			{
				base.FastCheckIsValid();
				FSetByCallerFloat result;
				if ((result = this._SetByCallerMagnitude) == null)
				{
					result = (this._SetByCallerMagnitude = new FSetByCallerFloat(base.NativePtr + (IntPtr)FGameplayEffectModifierMagnitude.__PropertyOffset_SetByCallerMagnitude, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSetByCallerFloat.StaticStruct(), base.NativePtr + (IntPtr)FGameplayEffectModifierMagnitude.__PropertyOffset_SetByCallerMagnitude, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06012601 RID: 75265 RVA: 0x001AFFBC File Offset: 0x001AE1BC
		public FGameplayEffectModifierMagnitude()
		{
		}

		// Token: 0x06012602 RID: 75266 RVA: 0x001AFFC4 File Offset: 0x001AE1C4
		public FGameplayEffectModifierMagnitude(EGameplayEffectMagnitudeCalculation MagnitudeCalculationType, FScalableFloat ScalableFloatMagnitude, FAttributeBasedFloat AttributeBasedMagnitude, FCustomCalculationBasedFloat CustomMagnitude, FSetByCallerFloat SetByCallerMagnitude)
		{
			this.MagnitudeCalculationType = MagnitudeCalculationType;
			this.ScalableFloatMagnitude = ScalableFloatMagnitude;
			this.AttributeBasedMagnitude = AttributeBasedMagnitude;
			this.CustomMagnitude = CustomMagnitude;
			this.SetByCallerMagnitude = SetByCallerMagnitude;
		}

		// Token: 0x06012603 RID: 75267 RVA: 0x001AFFF1 File Offset: 0x001AE1F1
		protected override IntPtr GetUStructPtr()
		{
			return FGameplayEffectModifierMagnitude.StaticStruct();
		}

		// Token: 0x06012604 RID: 75268 RVA: 0x001AFFFD File Offset: 0x001AE1FD
		[NullableContext(2)]
		public FGameplayEffectModifierMagnitude(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06012605 RID: 75269 RVA: 0x001B0007 File Offset: 0x001AE207
		public FGameplayEffectModifierMagnitude(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06012606 RID: 75270 RVA: 0x001B0012 File Offset: 0x001AE212
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FGameplayEffectModifierMagnitude(Pointer, false, true);
		}

		// Token: 0x06012607 RID: 75271 RVA: 0x001B001C File Offset: 0x001AE21C
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FGameplayEffectModifierMagnitude(Pointer, MemoryOwner);
		}

		// Token: 0x04009D61 RID: 40289
		public const string __ObjectPath = "/Script/GameplayAbilities.GameplayEffectModifierMagnitude";

		// Token: 0x04009D62 RID: 40290
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04009D63 RID: 40291
		internal static int __PropertyOffset_MagnitudeCalculationType;

		// Token: 0x04009D64 RID: 40292
		internal static int __PropertyOffset_ScalableFloatMagnitude;

		// Token: 0x04009D65 RID: 40293
		[Nullable(2)]
		private FScalableFloat _ScalableFloatMagnitude;

		// Token: 0x04009D66 RID: 40294
		internal static int __PropertyOffset_AttributeBasedMagnitude;

		// Token: 0x04009D67 RID: 40295
		[Nullable(2)]
		private FAttributeBasedFloat _AttributeBasedMagnitude;

		// Token: 0x04009D68 RID: 40296
		internal static int __PropertyOffset_CustomMagnitude;

		// Token: 0x04009D69 RID: 40297
		[Nullable(2)]
		private FCustomCalculationBasedFloat _CustomMagnitude;

		// Token: 0x04009D6A RID: 40298
		internal static int __PropertyOffset_SetByCallerMagnitude;

		// Token: 0x04009D6B RID: 40299
		[Nullable(2)]
		private FSetByCallerFloat _SetByCallerMagnitude;
	}
}
