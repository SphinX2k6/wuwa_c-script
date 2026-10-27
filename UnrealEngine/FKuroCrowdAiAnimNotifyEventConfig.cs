using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020017E8 RID: 6120
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroCrowdAi.KuroCrowdAiAnimNotifyEventConfig")]
	[UnrealStructLayout(128, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 128)]
	public class FKuroCrowdAiAnimNotifyEventConfig : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06016964 RID: 92516 RVA: 0x0020F67B File Offset: 0x0020D87B
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroCrowdAiAnimNotifyEventConfig._ScriptStructPtr != 0) ? FKuroCrowdAiAnimNotifyEventConfig._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroCrowdAi.KuroCrowdAiAnimNotifyEventConfig", ref FKuroCrowdAiAnimNotifyEventConfig._ScriptStructPtr);
		}

		// Token: 0x17005B42 RID: 23362
		// (get) Token: 0x06016965 RID: 92517 RVA: 0x0020F69F File Offset: 0x0020D89F
		// (set) Token: 0x06016966 RID: 92518 RVA: 0x0020F6AF File Offset: 0x0020D8AF
		public unsafe EKuroCrowdAiNotifyType Type
		{
			get
			{
				return (EKuroCrowdAiNotifyType)(*(base.NativePtr + (IntPtr)FKuroCrowdAiAnimNotifyEventConfig.__PropertyOffset_Type));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCrowdAiAnimNotifyEventConfig.__PropertyOffset_Type) = (byte)value;
			}
		}

		// Token: 0x17005B43 RID: 23363
		// (get) Token: 0x06016967 RID: 92519 RVA: 0x0020F6C0 File Offset: 0x0020D8C0
		// (set) Token: 0x06016968 RID: 92520 RVA: 0x0020F6D0 File Offset: 0x0020D8D0
		public unsafe EKuroCrowdAiAnimNotifyType AnimNotifyType
		{
			get
			{
				return (EKuroCrowdAiAnimNotifyType)(*(base.NativePtr + (IntPtr)FKuroCrowdAiAnimNotifyEventConfig.__PropertyOffset_AnimNotifyType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCrowdAiAnimNotifyEventConfig.__PropertyOffset_AnimNotifyType) = (byte)value;
			}
		}

		// Token: 0x17005B44 RID: 23364
		// (get) Token: 0x06016969 RID: 92521 RVA: 0x0020F6E1 File Offset: 0x0020D8E1
		// (set) Token: 0x0601696A RID: 92522 RVA: 0x0020F6F1 File Offset: 0x0020D8F1
		public unsafe EKuroCrowdAiAnimNotifyStateType AnimNotifyStateType
		{
			get
			{
				return (EKuroCrowdAiAnimNotifyStateType)(*(base.NativePtr + (IntPtr)FKuroCrowdAiAnimNotifyEventConfig.__PropertyOffset_AnimNotifyStateType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCrowdAiAnimNotifyEventConfig.__PropertyOffset_AnimNotifyStateType) = (byte)value;
			}
		}

		// Token: 0x17005B45 RID: 23365
		// (get) Token: 0x0601696B RID: 92523 RVA: 0x0020F702 File Offset: 0x0020D902
		// (set) Token: 0x0601696C RID: 92524 RVA: 0x0020F712 File Offset: 0x0020D912
		public unsafe float TriggerTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCrowdAiAnimNotifyEventConfig.__PropertyOffset_TriggerTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCrowdAiAnimNotifyEventConfig.__PropertyOffset_TriggerTime) = value;
			}
		}

		// Token: 0x17005B46 RID: 23366
		// (get) Token: 0x0601696D RID: 92525 RVA: 0x0020F723 File Offset: 0x0020D923
		// (set) Token: 0x0601696E RID: 92526 RVA: 0x0020F733 File Offset: 0x0020D933
		public unsafe float Duration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCrowdAiAnimNotifyEventConfig.__PropertyOffset_Duration);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCrowdAiAnimNotifyEventConfig.__PropertyOffset_Duration) = value;
			}
		}

		// Token: 0x17005B47 RID: 23367
		// (get) Token: 0x0601696F RID: 92527 RVA: 0x0020F744 File Offset: 0x0020D944
		// (set) Token: 0x06016970 RID: 92528 RVA: 0x0020F758 File Offset: 0x0020D958
		public unsafe UEffectModelBase EffectAsset
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UEffectModelBase>(base.NativePtr / (IntPtr)sizeof(void*) + FKuroCrowdAiAnimNotifyEventConfig.__PropertyOffset_EffectAsset);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FKuroCrowdAiAnimNotifyEventConfig.__PropertyOffset_EffectAsset, value);
			}
		}

		// Token: 0x17005B48 RID: 23368
		// (get) Token: 0x06016971 RID: 92529 RVA: 0x0020F76D File Offset: 0x0020D96D
		// (set) Token: 0x06016972 RID: 92530 RVA: 0x0020F781 File Offset: 0x0020D981
		public unsafe FTransform EffectTransform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCrowdAiAnimNotifyEventConfig.__PropertyOffset_EffectTransform);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCrowdAiAnimNotifyEventConfig.__PropertyOffset_EffectTransform) = value;
			}
		}

		// Token: 0x17005B49 RID: 23369
		// (get) Token: 0x06016973 RID: 92531 RVA: 0x0020F796 File Offset: 0x0020D996
		// (set) Token: 0x06016974 RID: 92532 RVA: 0x0020F7AA File Offset: 0x0020D9AA
		public unsafe UKuroMaterialControllerDataAsset MaterialDataAsset
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroMaterialControllerDataAsset>(base.NativePtr / (IntPtr)sizeof(void*) + FKuroCrowdAiAnimNotifyEventConfig.__PropertyOffset_MaterialDataAsset);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FKuroCrowdAiAnimNotifyEventConfig.__PropertyOffset_MaterialDataAsset, value);
			}
		}

		// Token: 0x17005B4A RID: 23370
		// (get) Token: 0x06016975 RID: 92533 RVA: 0x0020F7BF File Offset: 0x0020D9BF
		// (set) Token: 0x06016976 RID: 92534 RVA: 0x0020F7CF File Offset: 0x0020D9CF
		public unsafe float TargetRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCrowdAiAnimNotifyEventConfig.__PropertyOffset_TargetRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCrowdAiAnimNotifyEventConfig.__PropertyOffset_TargetRadius) = value;
			}
		}

		// Token: 0x17005B4B RID: 23371
		// (get) Token: 0x06016977 RID: 92535 RVA: 0x0020F7E0 File Offset: 0x0020D9E0
		// (set) Token: 0x06016978 RID: 92536 RVA: 0x0020F7F4 File Offset: 0x0020D9F4
		public unsafe UCurveFloat LerpCurve
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + FKuroCrowdAiAnimNotifyEventConfig.__PropertyOffset_LerpCurve);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FKuroCrowdAiAnimNotifyEventConfig.__PropertyOffset_LerpCurve, value);
			}
		}

		// Token: 0x17005B4C RID: 23372
		// (get) Token: 0x06016979 RID: 92537 RVA: 0x0020F809 File Offset: 0x0020DA09
		// (set) Token: 0x0601697A RID: 92538 RVA: 0x0020F81D File Offset: 0x0020DA1D
		public unsafe UAkAudioEvent AudioEvent
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAkAudioEvent>(base.NativePtr / (IntPtr)sizeof(void*) + FKuroCrowdAiAnimNotifyEventConfig.__PropertyOffset_AudioEvent);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FKuroCrowdAiAnimNotifyEventConfig.__PropertyOffset_AudioEvent, value);
			}
		}

		// Token: 0x17005B4D RID: 23373
		// (get) Token: 0x0601697B RID: 92539 RVA: 0x0020F832 File Offset: 0x0020DA32
		// (set) Token: 0x0601697C RID: 92540 RVA: 0x0020F842 File Offset: 0x0020DA42
		public unsafe float FadeDuration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCrowdAiAnimNotifyEventConfig.__PropertyOffset_FadeDuration);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCrowdAiAnimNotifyEventConfig.__PropertyOffset_FadeDuration) = value;
			}
		}

		// Token: 0x17005B4E RID: 23374
		// (get) Token: 0x0601697D RID: 92541 RVA: 0x0020F853 File Offset: 0x0020DA53
		// (set) Token: 0x0601697E RID: 92542 RVA: 0x0020F863 File Offset: 0x0020DA63
		public unsafe EAudioFadeCurve FadeCurve
		{
			get
			{
				return (EAudioFadeCurve)(*(base.NativePtr + (IntPtr)FKuroCrowdAiAnimNotifyEventConfig.__PropertyOffset_FadeCurve));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCrowdAiAnimNotifyEventConfig.__PropertyOffset_FadeCurve) = (byte)value;
			}
		}

		// Token: 0x0601697F RID: 92543 RVA: 0x0020F874 File Offset: 0x0020DA74
		public FKuroCrowdAiAnimNotifyEventConfig()
		{
		}

		// Token: 0x06016980 RID: 92544 RVA: 0x0020F87C File Offset: 0x0020DA7C
		[NullableContext(1)]
		public FKuroCrowdAiAnimNotifyEventConfig(EKuroCrowdAiNotifyType Type, EKuroCrowdAiAnimNotifyType AnimNotifyType, EKuroCrowdAiAnimNotifyStateType AnimNotifyStateType, float TriggerTime, float Duration, UEffectModelBase EffectAsset, FTransform EffectTransform, UKuroMaterialControllerDataAsset MaterialDataAsset, float TargetRadius, UCurveFloat LerpCurve, UAkAudioEvent AudioEvent, float FadeDuration, EAudioFadeCurve FadeCurve)
		{
			this.Type = Type;
			this.AnimNotifyType = AnimNotifyType;
			this.AnimNotifyStateType = AnimNotifyStateType;
			this.TriggerTime = TriggerTime;
			this.Duration = Duration;
			this.EffectAsset = EffectAsset;
			this.EffectTransform = EffectTransform;
			this.MaterialDataAsset = MaterialDataAsset;
			this.TargetRadius = TargetRadius;
			this.LerpCurve = LerpCurve;
			this.AudioEvent = AudioEvent;
			this.FadeDuration = FadeDuration;
			this.FadeCurve = FadeCurve;
		}

		// Token: 0x06016981 RID: 92545 RVA: 0x0020F8F4 File Offset: 0x0020DAF4
		protected override IntPtr GetUStructPtr()
		{
			return FKuroCrowdAiAnimNotifyEventConfig.StaticStruct();
		}

		// Token: 0x06016982 RID: 92546 RVA: 0x0020F900 File Offset: 0x0020DB00
		public FKuroCrowdAiAnimNotifyEventConfig(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06016983 RID: 92547 RVA: 0x0020F90A File Offset: 0x0020DB0A
		public FKuroCrowdAiAnimNotifyEventConfig(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06016984 RID: 92548 RVA: 0x0020F915 File Offset: 0x0020DB15
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroCrowdAiAnimNotifyEventConfig(Pointer, false, true);
		}

		// Token: 0x06016985 RID: 92549 RVA: 0x0020F91F File Offset: 0x0020DB1F
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroCrowdAiAnimNotifyEventConfig(Pointer, MemoryOwner);
		}

		// Token: 0x0400C44F RID: 50255
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroCrowdAi.KuroCrowdAiAnimNotifyEventConfig";

		// Token: 0x0400C450 RID: 50256
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400C451 RID: 50257
		internal static int __PropertyOffset_Type;

		// Token: 0x0400C452 RID: 50258
		internal static int __PropertyOffset_AnimNotifyType;

		// Token: 0x0400C453 RID: 50259
		internal static int __PropertyOffset_AnimNotifyStateType;

		// Token: 0x0400C454 RID: 50260
		internal static int __PropertyOffset_TriggerTime;

		// Token: 0x0400C455 RID: 50261
		internal static int __PropertyOffset_Duration;

		// Token: 0x0400C456 RID: 50262
		internal static int __PropertyOffset_EffectAsset;

		// Token: 0x0400C457 RID: 50263
		internal static int __PropertyOffset_EffectTransform;

		// Token: 0x0400C458 RID: 50264
		internal static int __PropertyOffset_MaterialDataAsset;

		// Token: 0x0400C459 RID: 50265
		internal static int __PropertyOffset_TargetRadius;

		// Token: 0x0400C45A RID: 50266
		internal static int __PropertyOffset_LerpCurve;

		// Token: 0x0400C45B RID: 50267
		internal static int __PropertyOffset_AudioEvent;

		// Token: 0x0400C45C RID: 50268
		internal static int __PropertyOffset_FadeDuration;

		// Token: 0x0400C45D RID: 50269
		internal static int __PropertyOffset_FadeCurve;
	}
}
