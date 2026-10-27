using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200081F RID: 2079
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.AnimNode_SequencePlayer")]
	[UnrealStructLayout(216, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 216)]
	public class FAnimNode_SequencePlayer : FAnimNode_AssetPlayerBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06006FCC RID: 28620 RVA: 0x000A06FF File Offset: 0x0009E8FF
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAnimNode_SequencePlayer._ScriptStructPtr != 0) ? FAnimNode_SequencePlayer._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.AnimNode_SequencePlayer", ref FAnimNode_SequencePlayer._ScriptStructPtr);
		}

		// Token: 0x17001A4C RID: 6732
		// (get) Token: 0x06006FCD RID: 28621 RVA: 0x000A0723 File Offset: 0x0009E923
		// (set) Token: 0x06006FCE RID: 28622 RVA: 0x000A0737 File Offset: 0x0009E937
		[Nullable(2)]
		public unsafe UAnimSequenceBase Sequence
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAnimSequenceBase>(base.NativePtr / (IntPtr)sizeof(void*) + FAnimNode_SequencePlayer.__PropertyOffset_Sequence);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FAnimNode_SequencePlayer.__PropertyOffset_Sequence, value);
			}
		}

		// Token: 0x17001A4D RID: 6733
		// (get) Token: 0x06006FCF RID: 28623 RVA: 0x000A074C File Offset: 0x0009E94C
		// (set) Token: 0x06006FD0 RID: 28624 RVA: 0x000A076B File Offset: 0x0009E96B
		public TSoftObjectPtr<UAnimSequenceBase> SequenceSoft
		{
			get
			{
				return new TSoftObjectPtr<UAnimSequenceBase>(base.NativePtr + (IntPtr)FAnimNode_SequencePlayer.__PropertyOffset_SequenceSoft, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)FAnimNode_SequencePlayer.__PropertyOffset_SequenceSoft, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17001A4E RID: 6734
		// (get) Token: 0x06006FD1 RID: 28625 RVA: 0x000A0790 File Offset: 0x0009E990
		// (set) Token: 0x06006FD2 RID: 28626 RVA: 0x000A07A0 File Offset: 0x0009E9A0
		public unsafe float PlayRateBasis
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_SequencePlayer.__PropertyOffset_PlayRateBasis);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_SequencePlayer.__PropertyOffset_PlayRateBasis) = value;
			}
		}

		// Token: 0x17001A4F RID: 6735
		// (get) Token: 0x06006FD3 RID: 28627 RVA: 0x000A07B1 File Offset: 0x0009E9B1
		// (set) Token: 0x06006FD4 RID: 28628 RVA: 0x000A07C1 File Offset: 0x0009E9C1
		public unsafe float PlayRate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_SequencePlayer.__PropertyOffset_PlayRate);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_SequencePlayer.__PropertyOffset_PlayRate) = value;
			}
		}

		// Token: 0x17001A50 RID: 6736
		// (get) Token: 0x06006FD5 RID: 28629 RVA: 0x000A07D4 File Offset: 0x0009E9D4
		// (set) Token: 0x06006FD6 RID: 28630 RVA: 0x000A0817 File Offset: 0x0009EA17
		public FInputScaleBiasClamp PlayRateScaleBiasClamp
		{
			get
			{
				base.FastCheckIsValid();
				FInputScaleBiasClamp result;
				if ((result = this._PlayRateScaleBiasClamp) == null)
				{
					result = (this._PlayRateScaleBiasClamp = new FInputScaleBiasClamp(base.NativePtr + (IntPtr)FAnimNode_SequencePlayer.__PropertyOffset_PlayRateScaleBiasClamp, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FInputScaleBiasClamp.StaticStruct(), base.NativePtr + (IntPtr)FAnimNode_SequencePlayer.__PropertyOffset_PlayRateScaleBiasClamp, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001A51 RID: 6737
		// (get) Token: 0x06006FD7 RID: 28631 RVA: 0x000A0838 File Offset: 0x0009EA38
		// (set) Token: 0x06006FD8 RID: 28632 RVA: 0x000A0848 File Offset: 0x0009EA48
		public unsafe float StartPosition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_SequencePlayer.__PropertyOffset_StartPosition);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_SequencePlayer.__PropertyOffset_StartPosition) = value;
			}
		}

		// Token: 0x17001A52 RID: 6738
		// (get) Token: 0x06006FD9 RID: 28633 RVA: 0x000A0859 File Offset: 0x0009EA59
		// (set) Token: 0x06006FDA RID: 28634 RVA: 0x000A0869 File Offset: 0x0009EA69
		public unsafe bool bLoopAnimation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_SequencePlayer.__PropertyOffset_bLoopAnimation) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_SequencePlayer.__PropertyOffset_bLoopAnimation) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001A53 RID: 6739
		// (get) Token: 0x06006FDB RID: 28635 RVA: 0x000A087A File Offset: 0x0009EA7A
		// (set) Token: 0x06006FDC RID: 28636 RVA: 0x000A088A File Offset: 0x0009EA8A
		public unsafe int CachedNumOfFrames
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_SequencePlayer.__PropertyOffset_CachedNumOfFrames);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_SequencePlayer.__PropertyOffset_CachedNumOfFrames) = value;
			}
		}

		// Token: 0x06006FDD RID: 28637 RVA: 0x000A089B File Offset: 0x0009EA9B
		public FAnimNode_SequencePlayer()
		{
		}

		// Token: 0x06006FDE RID: 28638 RVA: 0x000A08A4 File Offset: 0x0009EAA4
		public FAnimNode_SequencePlayer(UAnimSequenceBase Sequence, TSoftObjectPtr<UAnimSequenceBase> SequenceSoft, float PlayRateBasis, float PlayRate, FInputScaleBiasClamp PlayRateScaleBiasClamp, float StartPosition, bool bLoopAnimation, int CachedNumOfFrames, FName GroupName, int GroupIndex_DEPRECATED, [Nullable(0)] TEnumAsByte<EAnimGroupRole> GroupRole, EAnimSyncGroupScope GroupScope, bool bIgnoreForRelevancyTest, float BlendWeight, float InternalTimeAccumulator, float CachedSequenceLength, float CachedRateScale, bool bUseSoftRef, string AnimationName)
		{
			this.Sequence = Sequence;
			this.SequenceSoft = SequenceSoft;
			this.PlayRateBasis = PlayRateBasis;
			this.PlayRate = PlayRate;
			this.PlayRateScaleBiasClamp = PlayRateScaleBiasClamp;
			this.StartPosition = StartPosition;
			this.bLoopAnimation = bLoopAnimation;
			this.CachedNumOfFrames = CachedNumOfFrames;
			base.GroupName = GroupName;
			base.GroupRole = GroupRole;
			base.GroupScope = GroupScope;
			base.bIgnoreForRelevancyTest = bIgnoreForRelevancyTest;
			base.BlendWeight = BlendWeight;
			base.InternalTimeAccumulator = InternalTimeAccumulator;
			base.CachedSequenceLength = CachedSequenceLength;
			base.CachedRateScale = CachedRateScale;
			base.bUseSoftRef = bUseSoftRef;
			base.AnimationName = AnimationName;
		}

		// Token: 0x06006FDF RID: 28639 RVA: 0x000A0944 File Offset: 0x0009EB44
		protected override IntPtr GetUStructPtr()
		{
			return FAnimNode_SequencePlayer.StaticStruct();
		}

		// Token: 0x06006FE0 RID: 28640 RVA: 0x000A0950 File Offset: 0x0009EB50
		[NullableContext(2)]
		public FAnimNode_SequencePlayer(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06006FE1 RID: 28641 RVA: 0x000A095A File Offset: 0x0009EB5A
		public FAnimNode_SequencePlayer(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06006FE2 RID: 28642 RVA: 0x000A0965 File Offset: 0x0009EB65
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAnimNode_SequencePlayer(Pointer, false, true);
		}

		// Token: 0x06006FE3 RID: 28643 RVA: 0x000A096F File Offset: 0x0009EB6F
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAnimNode_SequencePlayer(Pointer, MemoryOwner);
		}

		// Token: 0x040035B8 RID: 13752
		public new const string __ObjectPath = "/Script/Engine.AnimNode_SequencePlayer";

		// Token: 0x040035B9 RID: 13753
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040035BA RID: 13754
		internal static int __PropertyOffset_Sequence;

		// Token: 0x040035BB RID: 13755
		internal static int __PropertyOffset_SequenceSoft;

		// Token: 0x040035BC RID: 13756
		internal static int __PropertyOffset_PlayRateBasis;

		// Token: 0x040035BD RID: 13757
		internal static int __PropertyOffset_PlayRate;

		// Token: 0x040035BE RID: 13758
		internal static int __PropertyOffset_PlayRateScaleBiasClamp;

		// Token: 0x040035BF RID: 13759
		[Nullable(2)]
		private FInputScaleBiasClamp _PlayRateScaleBiasClamp;

		// Token: 0x040035C0 RID: 13760
		internal static int __PropertyOffset_StartPosition;

		// Token: 0x040035C1 RID: 13761
		internal static int __PropertyOffset_bLoopAnimation;

		// Token: 0x040035C2 RID: 13762
		internal static int __PropertyOffset_CachedNumOfFrames;
	}
}
