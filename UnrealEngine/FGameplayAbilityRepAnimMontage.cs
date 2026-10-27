using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001351 RID: 4945
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/GameplayAbilities.GameplayAbilityRepAnimMontage")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FGameplayAbilityRepAnimMontage : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06012238 RID: 74296 RVA: 0x001AA046 File Offset: 0x001A8246
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FGameplayAbilityRepAnimMontage._ScriptStructPtr != 0) ? FGameplayAbilityRepAnimMontage._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/GameplayAbilities.GameplayAbilityRepAnimMontage", ref FGameplayAbilityRepAnimMontage._ScriptStructPtr);
		}

		// Token: 0x170046A1 RID: 18081
		// (get) Token: 0x06012239 RID: 74297 RVA: 0x001AA06A File Offset: 0x001A826A
		// (set) Token: 0x0601223A RID: 74298 RVA: 0x001AA07E File Offset: 0x001A827E
		[Nullable(2)]
		public unsafe UAnimMontage AnimMontage
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAnimMontage>(base.NativePtr / (IntPtr)sizeof(void*) + FGameplayAbilityRepAnimMontage.__PropertyOffset_AnimMontage);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FGameplayAbilityRepAnimMontage.__PropertyOffset_AnimMontage, value);
			}
		}

		// Token: 0x170046A2 RID: 18082
		// (get) Token: 0x0601223B RID: 74299 RVA: 0x001AA093 File Offset: 0x001A8293
		// (set) Token: 0x0601223C RID: 74300 RVA: 0x001AA0A3 File Offset: 0x001A82A3
		public unsafe float PlayRate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGameplayAbilityRepAnimMontage.__PropertyOffset_PlayRate);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGameplayAbilityRepAnimMontage.__PropertyOffset_PlayRate) = value;
			}
		}

		// Token: 0x170046A3 RID: 18083
		// (get) Token: 0x0601223D RID: 74301 RVA: 0x001AA0B4 File Offset: 0x001A82B4
		// (set) Token: 0x0601223E RID: 74302 RVA: 0x001AA0C4 File Offset: 0x001A82C4
		public unsafe float Position
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGameplayAbilityRepAnimMontage.__PropertyOffset_Position);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGameplayAbilityRepAnimMontage.__PropertyOffset_Position) = value;
			}
		}

		// Token: 0x170046A4 RID: 18084
		// (get) Token: 0x0601223F RID: 74303 RVA: 0x001AA0D5 File Offset: 0x001A82D5
		// (set) Token: 0x06012240 RID: 74304 RVA: 0x001AA0E5 File Offset: 0x001A82E5
		public unsafe float BlendTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGameplayAbilityRepAnimMontage.__PropertyOffset_BlendTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGameplayAbilityRepAnimMontage.__PropertyOffset_BlendTime) = value;
			}
		}

		// Token: 0x170046A5 RID: 18085
		// (get) Token: 0x06012241 RID: 74305 RVA: 0x001AA0F6 File Offset: 0x001A82F6
		// (set) Token: 0x06012242 RID: 74306 RVA: 0x001AA106 File Offset: 0x001A8306
		public unsafe byte NextSectionID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGameplayAbilityRepAnimMontage.__PropertyOffset_NextSectionID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGameplayAbilityRepAnimMontage.__PropertyOffset_NextSectionID) = value;
			}
		}

		// Token: 0x170046A6 RID: 18086
		// (get) Token: 0x06012243 RID: 74307 RVA: 0x001AA117 File Offset: 0x001A8317
		// (set) Token: 0x06012244 RID: 74308 RVA: 0x001AA130 File Offset: 0x001A8330
		public unsafe bool bRepPosition
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FGameplayAbilityRepAnimMontage.__PropertyOffset_bRepPosition) & FGameplayAbilityRepAnimMontage.__PropertyMask_bRepPosition) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FGameplayAbilityRepAnimMontage.__PropertyOffset_bRepPosition) = ((*(base.NativePtr + (IntPtr)FGameplayAbilityRepAnimMontage.__PropertyOffset_bRepPosition) & ~FGameplayAbilityRepAnimMontage.__PropertyMask_bRepPosition) | (value ? FGameplayAbilityRepAnimMontage.__PropertyMask_bRepPosition : 0));
			}
		}

		// Token: 0x170046A7 RID: 18087
		// (get) Token: 0x06012245 RID: 74309 RVA: 0x001AA160 File Offset: 0x001A8360
		// (set) Token: 0x06012246 RID: 74310 RVA: 0x001AA179 File Offset: 0x001A8379
		public unsafe bool IsStopped
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FGameplayAbilityRepAnimMontage.__PropertyOffset_IsStopped) & FGameplayAbilityRepAnimMontage.__PropertyMask_IsStopped) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FGameplayAbilityRepAnimMontage.__PropertyOffset_IsStopped) = ((*(base.NativePtr + (IntPtr)FGameplayAbilityRepAnimMontage.__PropertyOffset_IsStopped) & ~FGameplayAbilityRepAnimMontage.__PropertyMask_IsStopped) | (value ? FGameplayAbilityRepAnimMontage.__PropertyMask_IsStopped : 0));
			}
		}

		// Token: 0x170046A8 RID: 18088
		// (get) Token: 0x06012247 RID: 74311 RVA: 0x001AA1A9 File Offset: 0x001A83A9
		// (set) Token: 0x06012248 RID: 74312 RVA: 0x001AA1C2 File Offset: 0x001A83C2
		public unsafe bool ForcePlayBit
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FGameplayAbilityRepAnimMontage.__PropertyOffset_ForcePlayBit) & FGameplayAbilityRepAnimMontage.__PropertyMask_ForcePlayBit) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FGameplayAbilityRepAnimMontage.__PropertyOffset_ForcePlayBit) = ((*(base.NativePtr + (IntPtr)FGameplayAbilityRepAnimMontage.__PropertyOffset_ForcePlayBit) & ~FGameplayAbilityRepAnimMontage.__PropertyMask_ForcePlayBit) | (value ? FGameplayAbilityRepAnimMontage.__PropertyMask_ForcePlayBit : 0));
			}
		}

		// Token: 0x170046A9 RID: 18089
		// (get) Token: 0x06012249 RID: 74313 RVA: 0x001AA1F2 File Offset: 0x001A83F2
		// (set) Token: 0x0601224A RID: 74314 RVA: 0x001AA20B File Offset: 0x001A840B
		public unsafe bool SkipPositionCorrection
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FGameplayAbilityRepAnimMontage.__PropertyOffset_SkipPositionCorrection) & FGameplayAbilityRepAnimMontage.__PropertyMask_SkipPositionCorrection) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FGameplayAbilityRepAnimMontage.__PropertyOffset_SkipPositionCorrection) = ((*(base.NativePtr + (IntPtr)FGameplayAbilityRepAnimMontage.__PropertyOffset_SkipPositionCorrection) & ~FGameplayAbilityRepAnimMontage.__PropertyMask_SkipPositionCorrection) | (value ? FGameplayAbilityRepAnimMontage.__PropertyMask_SkipPositionCorrection : 0));
			}
		}

		// Token: 0x170046AA RID: 18090
		// (get) Token: 0x0601224B RID: 74315 RVA: 0x001AA23B File Offset: 0x001A843B
		// (set) Token: 0x0601224C RID: 74316 RVA: 0x001AA254 File Offset: 0x001A8454
		public unsafe bool bSkipPlayRate
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FGameplayAbilityRepAnimMontage.__PropertyOffset_bSkipPlayRate) & FGameplayAbilityRepAnimMontage.__PropertyMask_bSkipPlayRate) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FGameplayAbilityRepAnimMontage.__PropertyOffset_bSkipPlayRate) = ((*(base.NativePtr + (IntPtr)FGameplayAbilityRepAnimMontage.__PropertyOffset_bSkipPlayRate) & ~FGameplayAbilityRepAnimMontage.__PropertyMask_bSkipPlayRate) | (value ? FGameplayAbilityRepAnimMontage.__PropertyMask_bSkipPlayRate : 0));
			}
		}

		// Token: 0x170046AB RID: 18091
		// (get) Token: 0x0601224D RID: 74317 RVA: 0x001AA284 File Offset: 0x001A8484
		// (set) Token: 0x0601224E RID: 74318 RVA: 0x001AA2C7 File Offset: 0x001A84C7
		public FPredictionKey PredictionKey
		{
			get
			{
				base.FastCheckIsValid();
				FPredictionKey result;
				if ((result = this._PredictionKey) == null)
				{
					result = (this._PredictionKey = new FPredictionKey(base.NativePtr + (IntPtr)FGameplayAbilityRepAnimMontage.__PropertyOffset_PredictionKey, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FPredictionKey.StaticStruct(), base.NativePtr + (IntPtr)FGameplayAbilityRepAnimMontage.__PropertyOffset_PredictionKey, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170046AC RID: 18092
		// (get) Token: 0x0601224F RID: 74319 RVA: 0x001AA2E8 File Offset: 0x001A84E8
		// (set) Token: 0x06012250 RID: 74320 RVA: 0x001AA2F8 File Offset: 0x001A84F8
		public unsafe byte SectionIdToPlay
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGameplayAbilityRepAnimMontage.__PropertyOffset_SectionIdToPlay);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGameplayAbilityRepAnimMontage.__PropertyOffset_SectionIdToPlay) = value;
			}
		}

		// Token: 0x06012251 RID: 74321 RVA: 0x001AA309 File Offset: 0x001A8509
		public FGameplayAbilityRepAnimMontage()
		{
		}

		// Token: 0x06012252 RID: 74322 RVA: 0x001AA314 File Offset: 0x001A8514
		public FGameplayAbilityRepAnimMontage(UAnimMontage AnimMontage, float PlayRate, float Position, float BlendTime, byte NextSectionID, bool bRepPosition, bool IsStopped, bool ForcePlayBit, bool SkipPositionCorrection, bool bSkipPlayRate, FPredictionKey PredictionKey, byte SectionIdToPlay)
		{
			this.AnimMontage = AnimMontage;
			this.PlayRate = PlayRate;
			this.Position = Position;
			this.BlendTime = BlendTime;
			this.NextSectionID = NextSectionID;
			this.bRepPosition = bRepPosition;
			this.IsStopped = IsStopped;
			this.ForcePlayBit = ForcePlayBit;
			this.SkipPositionCorrection = SkipPositionCorrection;
			this.bSkipPlayRate = bSkipPlayRate;
			this.PredictionKey = PredictionKey;
			this.SectionIdToPlay = SectionIdToPlay;
		}

		// Token: 0x06012253 RID: 74323 RVA: 0x001AA384 File Offset: 0x001A8584
		protected override IntPtr GetUStructPtr()
		{
			return FGameplayAbilityRepAnimMontage.StaticStruct();
		}

		// Token: 0x06012254 RID: 74324 RVA: 0x001AA390 File Offset: 0x001A8590
		[NullableContext(2)]
		public FGameplayAbilityRepAnimMontage(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06012255 RID: 74325 RVA: 0x001AA39A File Offset: 0x001A859A
		public FGameplayAbilityRepAnimMontage(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06012256 RID: 74326 RVA: 0x001AA3A5 File Offset: 0x001A85A5
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FGameplayAbilityRepAnimMontage(Pointer, false, true);
		}

		// Token: 0x06012257 RID: 74327 RVA: 0x001AA3AF File Offset: 0x001A85AF
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FGameplayAbilityRepAnimMontage(Pointer, MemoryOwner);
		}

		// Token: 0x04009B72 RID: 39794
		public const string __ObjectPath = "/Script/GameplayAbilities.GameplayAbilityRepAnimMontage";

		// Token: 0x04009B73 RID: 39795
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04009B74 RID: 39796
		internal static int __PropertyOffset_AnimMontage;

		// Token: 0x04009B75 RID: 39797
		internal static int __PropertyOffset_PlayRate;

		// Token: 0x04009B76 RID: 39798
		internal static int __PropertyOffset_Position;

		// Token: 0x04009B77 RID: 39799
		internal static int __PropertyOffset_BlendTime;

		// Token: 0x04009B78 RID: 39800
		internal static int __PropertyOffset_NextSectionID;

		// Token: 0x04009B79 RID: 39801
		internal static int __PropertyOffset_bRepPosition;

		// Token: 0x04009B7A RID: 39802
		internal static byte __PropertyMask_bRepPosition;

		// Token: 0x04009B7B RID: 39803
		internal static int __PropertyOffset_IsStopped;

		// Token: 0x04009B7C RID: 39804
		internal static byte __PropertyMask_IsStopped;

		// Token: 0x04009B7D RID: 39805
		internal static int __PropertyOffset_ForcePlayBit;

		// Token: 0x04009B7E RID: 39806
		internal static byte __PropertyMask_ForcePlayBit;

		// Token: 0x04009B7F RID: 39807
		internal static int __PropertyOffset_SkipPositionCorrection;

		// Token: 0x04009B80 RID: 39808
		internal static byte __PropertyMask_SkipPositionCorrection;

		// Token: 0x04009B81 RID: 39809
		internal static int __PropertyOffset_bSkipPlayRate;

		// Token: 0x04009B82 RID: 39810
		internal static byte __PropertyMask_bSkipPlayRate;

		// Token: 0x04009B83 RID: 39811
		internal static int __PropertyOffset_PredictionKey;

		// Token: 0x04009B84 RID: 39812
		[Nullable(2)]
		private FPredictionKey _PredictionKey;

		// Token: 0x04009B85 RID: 39813
		internal static int __PropertyOffset_SectionIdToPlay;
	}
}
