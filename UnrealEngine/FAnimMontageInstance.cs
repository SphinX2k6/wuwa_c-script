using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000812 RID: 2066
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.AnimMontageInstance")]
	[UnrealStructLayout(456, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 456)]
	public class FAnimMontageInstance : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06006EFB RID: 28411 RVA: 0x0009F339 File Offset: 0x0009D539
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAnimMontageInstance._ScriptStructPtr != 0) ? FAnimMontageInstance._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.AnimMontageInstance", ref FAnimMontageInstance._ScriptStructPtr);
		}

		// Token: 0x17001A17 RID: 6679
		// (get) Token: 0x06006EFC RID: 28412 RVA: 0x0009F35D File Offset: 0x0009D55D
		// (set) Token: 0x06006EFD RID: 28413 RVA: 0x0009F371 File Offset: 0x0009D571
		[Nullable(2)]
		public unsafe UAnimMontage Montage
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAnimMontage>(base.NativePtr / (IntPtr)sizeof(void*) + FAnimMontageInstance.__PropertyOffset_Montage);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FAnimMontageInstance.__PropertyOffset_Montage, value);
			}
		}

		// Token: 0x17001A18 RID: 6680
		// (get) Token: 0x06006EFE RID: 28414 RVA: 0x0009F386 File Offset: 0x0009D586
		// (set) Token: 0x06006EFF RID: 28415 RVA: 0x0009F396 File Offset: 0x0009D596
		public unsafe bool bPlaying
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimMontageInstance.__PropertyOffset_bPlaying) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimMontageInstance.__PropertyOffset_bPlaying) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001A19 RID: 6681
		// (get) Token: 0x06006F00 RID: 28416 RVA: 0x0009F3A7 File Offset: 0x0009D5A7
		// (set) Token: 0x06006F01 RID: 28417 RVA: 0x0009F3B7 File Offset: 0x0009D5B7
		public unsafe float DefaultBlendTimeMultiplier
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimMontageInstance.__PropertyOffset_DefaultBlendTimeMultiplier);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimMontageInstance.__PropertyOffset_DefaultBlendTimeMultiplier) = value;
			}
		}

		// Token: 0x17001A1A RID: 6682
		// (get) Token: 0x06006F02 RID: 28418 RVA: 0x0009F3C8 File Offset: 0x0009D5C8
		// (set) Token: 0x06006F03 RID: 28419 RVA: 0x0009F40B File Offset: 0x0009D60B
		public TArray<int> NextSections
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._NextSections) == null)
				{
					result = (this._NextSections = new TArray<int>(base.NativePtr + (IntPtr)FAnimMontageInstance.__PropertyOffset_NextSections, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.NextSections.CopyAssign(value);
			}
		}

		// Token: 0x17001A1B RID: 6683
		// (get) Token: 0x06006F04 RID: 28420 RVA: 0x0009F41C File Offset: 0x0009D61C
		// (set) Token: 0x06006F05 RID: 28421 RVA: 0x0009F45F File Offset: 0x0009D65F
		public TArray<int> PrevSections
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._PrevSections) == null)
				{
					result = (this._PrevSections = new TArray<int>(base.NativePtr + (IntPtr)FAnimMontageInstance.__PropertyOffset_PrevSections, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.PrevSections.CopyAssign(value);
			}
		}

		// Token: 0x17001A1C RID: 6684
		// (get) Token: 0x06006F06 RID: 28422 RVA: 0x0009F470 File Offset: 0x0009D670
		// (set) Token: 0x06006F07 RID: 28423 RVA: 0x0009F4B3 File Offset: 0x0009D6B3
		public TArray<FAnimNotifyEvent> ActiveStateBranchingPoints
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FAnimNotifyEvent> result;
				if ((result = this._ActiveStateBranchingPoints) == null)
				{
					result = (this._ActiveStateBranchingPoints = new TArray<FAnimNotifyEvent>(base.NativePtr + (IntPtr)FAnimMontageInstance.__PropertyOffset_ActiveStateBranchingPoints, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ActiveStateBranchingPoints.CopyAssign(value);
			}
		}

		// Token: 0x17001A1D RID: 6685
		// (get) Token: 0x06006F08 RID: 28424 RVA: 0x0009F4C1 File Offset: 0x0009D6C1
		// (set) Token: 0x06006F09 RID: 28425 RVA: 0x0009F4D1 File Offset: 0x0009D6D1
		public unsafe float Position
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimMontageInstance.__PropertyOffset_Position);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimMontageInstance.__PropertyOffset_Position) = value;
			}
		}

		// Token: 0x17001A1E RID: 6686
		// (get) Token: 0x06006F0A RID: 28426 RVA: 0x0009F4E2 File Offset: 0x0009D6E2
		// (set) Token: 0x06006F0B RID: 28427 RVA: 0x0009F4F2 File Offset: 0x0009D6F2
		public unsafe float PlayRate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimMontageInstance.__PropertyOffset_PlayRate);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimMontageInstance.__PropertyOffset_PlayRate) = value;
			}
		}

		// Token: 0x17001A1F RID: 6687
		// (get) Token: 0x06006F0C RID: 28428 RVA: 0x0009F504 File Offset: 0x0009D704
		// (set) Token: 0x06006F0D RID: 28429 RVA: 0x0009F547 File Offset: 0x0009D747
		public FAlphaBlend Blend
		{
			get
			{
				base.FastCheckIsValid();
				FAlphaBlend result;
				if ((result = this._Blend) == null)
				{
					result = (this._Blend = new FAlphaBlend(base.NativePtr + (IntPtr)FAnimMontageInstance.__PropertyOffset_Blend, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FAlphaBlend.StaticStruct(), base.NativePtr + (IntPtr)FAnimMontageInstance.__PropertyOffset_Blend, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001A20 RID: 6688
		// (get) Token: 0x06006F0E RID: 28430 RVA: 0x0009F568 File Offset: 0x0009D768
		// (set) Token: 0x06006F0F RID: 28431 RVA: 0x0009F578 File Offset: 0x0009D778
		public unsafe int DisableRootMotionCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimMontageInstance.__PropertyOffset_DisableRootMotionCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimMontageInstance.__PropertyOffset_DisableRootMotionCount) = value;
			}
		}

		// Token: 0x06006F10 RID: 28432 RVA: 0x0009F589 File Offset: 0x0009D789
		public FAnimMontageInstance()
		{
		}

		// Token: 0x06006F11 RID: 28433 RVA: 0x0009F594 File Offset: 0x0009D794
		public FAnimMontageInstance(UAnimMontage Montage, bool bPlaying, float DefaultBlendTimeMultiplier, TArray<int> NextSections, TArray<int> PrevSections, TArray<FAnimNotifyEvent> ActiveStateBranchingPoints, float Position, float PlayRate, FAlphaBlend Blend, int DisableRootMotionCount)
		{
			this.Montage = Montage;
			this.bPlaying = bPlaying;
			this.DefaultBlendTimeMultiplier = DefaultBlendTimeMultiplier;
			this.NextSections = NextSections;
			this.PrevSections = PrevSections;
			this.ActiveStateBranchingPoints = ActiveStateBranchingPoints;
			this.Position = Position;
			this.PlayRate = PlayRate;
			this.Blend = Blend;
			this.DisableRootMotionCount = DisableRootMotionCount;
		}

		// Token: 0x06006F12 RID: 28434 RVA: 0x0009F5F4 File Offset: 0x0009D7F4
		protected override IntPtr GetUStructPtr()
		{
			return FAnimMontageInstance.StaticStruct();
		}

		// Token: 0x06006F13 RID: 28435 RVA: 0x0009F600 File Offset: 0x0009D800
		[NullableContext(2)]
		public FAnimMontageInstance(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06006F14 RID: 28436 RVA: 0x0009F60A File Offset: 0x0009D80A
		public FAnimMontageInstance(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06006F15 RID: 28437 RVA: 0x0009F615 File Offset: 0x0009D815
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAnimMontageInstance(Pointer, false, true);
		}

		// Token: 0x06006F16 RID: 28438 RVA: 0x0009F61F File Offset: 0x0009D81F
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAnimMontageInstance(Pointer, MemoryOwner);
		}

		// Token: 0x04003553 RID: 13651
		public const string __ObjectPath = "/Script/Engine.AnimMontageInstance";

		// Token: 0x04003554 RID: 13652
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04003555 RID: 13653
		internal static int __PropertyOffset_Montage;

		// Token: 0x04003556 RID: 13654
		internal static int __PropertyOffset_bPlaying;

		// Token: 0x04003557 RID: 13655
		internal static int __PropertyOffset_DefaultBlendTimeMultiplier;

		// Token: 0x04003558 RID: 13656
		internal static int __PropertyOffset_NextSections;

		// Token: 0x04003559 RID: 13657
		[Nullable(2)]
		private TArray<int> _NextSections;

		// Token: 0x0400355A RID: 13658
		internal static int __PropertyOffset_PrevSections;

		// Token: 0x0400355B RID: 13659
		[Nullable(2)]
		private TArray<int> _PrevSections;

		// Token: 0x0400355C RID: 13660
		internal static int __PropertyOffset_ActiveStateBranchingPoints;

		// Token: 0x0400355D RID: 13661
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FAnimNotifyEvent> _ActiveStateBranchingPoints;

		// Token: 0x0400355E RID: 13662
		internal static int __PropertyOffset_Position;

		// Token: 0x0400355F RID: 13663
		internal static int __PropertyOffset_PlayRate;

		// Token: 0x04003560 RID: 13664
		internal static int __PropertyOffset_Blend;

		// Token: 0x04003561 RID: 13665
		[Nullable(2)]
		private FAlphaBlend _Blend;

		// Token: 0x04003562 RID: 13666
		internal static int __PropertyOffset_DisableRootMotionCount;
	}
}
