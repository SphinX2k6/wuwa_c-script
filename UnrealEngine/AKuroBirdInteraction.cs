using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001AAF RID: 6831
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroBirdInteraction")]
	[UnrealStructLayout(2032, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2032)]
	public class AKuroBirdInteraction : AKuroBPActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060194AB RID: 103595 RVA: 0x00256494 File Offset: 0x00254694
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AKuroBirdInteraction._ClassPtr;
		}

		// Token: 0x060194AC RID: 103596 RVA: 0x002564A0 File Offset: 0x002546A0
		public AKuroBirdInteraction() : this(BuiltinUtils.AllocNativeUObject(AKuroBirdInteraction.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060194AD RID: 103597 RVA: 0x002564C8 File Offset: 0x002546C8
		[NullableContext(1)]
		public AKuroBirdInteraction(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AKuroBirdInteraction.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170064C9 RID: 25801
		// (get) Token: 0x060194AE RID: 103598 RVA: 0x002564FB File Offset: 0x002546FB
		// (set) Token: 0x060194AF RID: 103599 RVA: 0x0025650B File Offset: 0x0025470B
		public unsafe int PlayerIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroBirdInteraction.__PropertyOffset_PlayerIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroBirdInteraction.__PropertyOffset_PlayerIndex) = value;
			}
		}

		// Token: 0x170064CA RID: 25802
		// (get) Token: 0x060194B0 RID: 103600 RVA: 0x0025651C File Offset: 0x0025471C
		// (set) Token: 0x060194B1 RID: 103601 RVA: 0x0025652C File Offset: 0x0025472C
		public unsafe bool bEnableScareForwardFleeBeforeTakeoff
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroBirdInteraction.__PropertyOffset_bEnableScareForwardFleeBeforeTakeoff) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroBirdInteraction.__PropertyOffset_bEnableScareForwardFleeBeforeTakeoff) = (value ? 1 : 0);
			}
		}

		// Token: 0x170064CB RID: 25803
		// (get) Token: 0x060194B2 RID: 103602 RVA: 0x0025653D File Offset: 0x0025473D
		// (set) Token: 0x060194B3 RID: 103603 RVA: 0x0025654D File Offset: 0x0025474D
		public unsafe float ScareForwardFleeDistanceMin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroBirdInteraction.__PropertyOffset_ScareForwardFleeDistanceMin);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroBirdInteraction.__PropertyOffset_ScareForwardFleeDistanceMin) = value;
			}
		}

		// Token: 0x170064CC RID: 25804
		// (get) Token: 0x060194B4 RID: 103604 RVA: 0x0025655E File Offset: 0x0025475E
		// (set) Token: 0x060194B5 RID: 103605 RVA: 0x0025656E File Offset: 0x0025476E
		public unsafe float ScareForwardFleeDistanceMax
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroBirdInteraction.__PropertyOffset_ScareForwardFleeDistanceMax);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroBirdInteraction.__PropertyOffset_ScareForwardFleeDistanceMax) = value;
			}
		}

		// Token: 0x170064CD RID: 25805
		// (get) Token: 0x060194B6 RID: 103606 RVA: 0x0025657F File Offset: 0x0025477F
		// (set) Token: 0x060194B7 RID: 103607 RVA: 0x0025658F File Offset: 0x0025478F
		public unsafe float ScareForwardHopStepDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroBirdInteraction.__PropertyOffset_ScareForwardHopStepDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroBirdInteraction.__PropertyOffset_ScareForwardHopStepDistance) = value;
			}
		}

		// Token: 0x170064CE RID: 25806
		// (get) Token: 0x060194B8 RID: 103608 RVA: 0x002565A0 File Offset: 0x002547A0
		// (set) Token: 0x060194B9 RID: 103609 RVA: 0x002565B0 File Offset: 0x002547B0
		public unsafe float ScareForwardHopDuration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroBirdInteraction.__PropertyOffset_ScareForwardHopDuration);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroBirdInteraction.__PropertyOffset_ScareForwardHopDuration) = value;
			}
		}

		// Token: 0x170064CF RID: 25807
		// (get) Token: 0x060194BA RID: 103610 RVA: 0x002565C1 File Offset: 0x002547C1
		// (set) Token: 0x060194BB RID: 103611 RVA: 0x002565D1 File Offset: 0x002547D1
		public unsafe float ScareForwardHopHeightMin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroBirdInteraction.__PropertyOffset_ScareForwardHopHeightMin);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroBirdInteraction.__PropertyOffset_ScareForwardHopHeightMin) = value;
			}
		}

		// Token: 0x170064D0 RID: 25808
		// (get) Token: 0x060194BC RID: 103612 RVA: 0x002565E2 File Offset: 0x002547E2
		// (set) Token: 0x060194BD RID: 103613 RVA: 0x002565F2 File Offset: 0x002547F2
		public unsafe float ScareForwardHopHeightMax
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroBirdInteraction.__PropertyOffset_ScareForwardHopHeightMax);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroBirdInteraction.__PropertyOffset_ScareForwardHopHeightMax) = value;
			}
		}

		// Token: 0x170064D1 RID: 25809
		// (get) Token: 0x060194BE RID: 103614 RVA: 0x00256603 File Offset: 0x00254803
		// (set) Token: 0x060194BF RID: 103615 RVA: 0x00256613 File Offset: 0x00254813
		public unsafe bool bScareFleeFaceAwayFromPlayer
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroBirdInteraction.__PropertyOffset_bScareFleeFaceAwayFromPlayer) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroBirdInteraction.__PropertyOffset_bScareFleeFaceAwayFromPlayer) = (value ? 1 : 0);
			}
		}

		// Token: 0x170064D2 RID: 25810
		// (get) Token: 0x060194C0 RID: 103616 RVA: 0x00256624 File Offset: 0x00254824
		// (set) Token: 0x060194C1 RID: 103617 RVA: 0x00256634 File Offset: 0x00254834
		public unsafe float ScareFleeTurnDuration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroBirdInteraction.__PropertyOffset_ScareFleeTurnDuration);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroBirdInteraction.__PropertyOffset_ScareFleeTurnDuration) = value;
			}
		}

		// Token: 0x170064D3 RID: 25811
		// (get) Token: 0x060194C2 RID: 103618 RVA: 0x00256645 File Offset: 0x00254845
		// (set) Token: 0x060194C3 RID: 103619 RVA: 0x00256655 File Offset: 0x00254855
		public unsafe float ScareFleeTurnMinAngleDegrees
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroBirdInteraction.__PropertyOffset_ScareFleeTurnMinAngleDegrees);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroBirdInteraction.__PropertyOffset_ScareFleeTurnMinAngleDegrees) = value;
			}
		}

		// Token: 0x170064D4 RID: 25812
		// (get) Token: 0x060194C4 RID: 103620 RVA: 0x00256666 File Offset: 0x00254866
		// (set) Token: 0x060194C5 RID: 103621 RVA: 0x00256676 File Offset: 0x00254876
		public unsafe bool bCanBeScaredAgain
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroBirdInteraction.__PropertyOffset_bCanBeScaredAgain) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroBirdInteraction.__PropertyOffset_bCanBeScaredAgain) = (value ? 1 : 0);
			}
		}

		// Token: 0x170064D5 RID: 25813
		// (get) Token: 0x060194C6 RID: 103622 RVA: 0x00256687 File Offset: 0x00254887
		// (set) Token: 0x060194C7 RID: 103623 RVA: 0x00256697 File Offset: 0x00254897
		public unsafe bool bIsFlying
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroBirdInteraction.__PropertyOffset_bIsFlying) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroBirdInteraction.__PropertyOffset_bIsFlying) = (value ? 1 : 0);
			}
		}

		// Token: 0x170064D6 RID: 25814
		// (get) Token: 0x060194C8 RID: 103624 RVA: 0x002566A8 File Offset: 0x002548A8
		// (set) Token: 0x060194C9 RID: 103625 RVA: 0x002566B8 File Offset: 0x002548B8
		public unsafe bool bScareForwardFleeActive
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroBirdInteraction.__PropertyOffset_bScareForwardFleeActive) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroBirdInteraction.__PropertyOffset_bScareForwardFleeActive) = (value ? 1 : 0);
			}
		}

		// Token: 0x170064D7 RID: 25815
		// (get) Token: 0x060194CA RID: 103626 RVA: 0x002566C9 File Offset: 0x002548C9
		// (set) Token: 0x060194CB RID: 103627 RVA: 0x002566D9 File Offset: 0x002548D9
		public unsafe EBirdGroundLocomotion GroundLocomotion
		{
			get
			{
				return (EBirdGroundLocomotion)(*(base.NativePtr + (IntPtr)AKuroBirdInteraction.__PropertyOffset_GroundLocomotion));
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroBirdInteraction.__PropertyOffset_GroundLocomotion) = (byte)value;
			}
		}

		// Token: 0x170064D8 RID: 25816
		// (get) Token: 0x060194CC RID: 103628 RVA: 0x002566EA File Offset: 0x002548EA
		// (set) Token: 0x060194CD RID: 103629 RVA: 0x002566FA File Offset: 0x002548FA
		public unsafe EBirdFlightPhase FlightPhase
		{
			get
			{
				return (EBirdFlightPhase)(*(base.NativePtr + (IntPtr)AKuroBirdInteraction.__PropertyOffset_FlightPhase));
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroBirdInteraction.__PropertyOffset_FlightPhase) = (byte)value;
			}
		}

		// Token: 0x170064D9 RID: 25817
		// (get) Token: 0x060194CE RID: 103630 RVA: 0x0025670B File Offset: 0x0025490B
		// (set) Token: 0x060194CF RID: 103631 RVA: 0x0025671B File Offset: 0x0025491B
		public unsafe float FlySpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroBirdInteraction.__PropertyOffset_FlySpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroBirdInteraction.__PropertyOffset_FlySpeed) = value;
			}
		}

		// Token: 0x170064DA RID: 25818
		// (get) Token: 0x060194D0 RID: 103632 RVA: 0x0025672C File Offset: 0x0025492C
		// (set) Token: 0x060194D1 RID: 103633 RVA: 0x0025673C File Offset: 0x0025493C
		public unsafe float UpSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroBirdInteraction.__PropertyOffset_UpSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroBirdInteraction.__PropertyOffset_UpSpeed) = value;
			}
		}

		// Token: 0x170064DB RID: 25819
		// (get) Token: 0x060194D2 RID: 103634 RVA: 0x0025674D File Offset: 0x0025494D
		// (set) Token: 0x060194D3 RID: 103635 RVA: 0x0025675D File Offset: 0x0025495D
		public unsafe float DateStore
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroBirdInteraction.__PropertyOffset_DateStore);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroBirdInteraction.__PropertyOffset_DateStore) = value;
			}
		}

		// Token: 0x170064DC RID: 25820
		// (get) Token: 0x060194D4 RID: 103636 RVA: 0x0025676E File Offset: 0x0025496E
		// (set) Token: 0x060194D5 RID: 103637 RVA: 0x0025677E File Offset: 0x0025497E
		public unsafe float InitUpSpeedBase
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroBirdInteraction.__PropertyOffset_InitUpSpeedBase);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroBirdInteraction.__PropertyOffset_InitUpSpeedBase) = value;
			}
		}

		// Token: 0x170064DD RID: 25821
		// (get) Token: 0x060194D6 RID: 103638 RVA: 0x0025678F File Offset: 0x0025498F
		// (set) Token: 0x060194D7 RID: 103639 RVA: 0x0025679F File Offset: 0x0025499F
		public unsafe float InitUpSpeedExtraMax
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroBirdInteraction.__PropertyOffset_InitUpSpeedExtraMax);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroBirdInteraction.__PropertyOffset_InitUpSpeedExtraMax) = value;
			}
		}

		// Token: 0x170064DE RID: 25822
		// (get) Token: 0x060194D8 RID: 103640 RVA: 0x002567B0 File Offset: 0x002549B0
		// (set) Token: 0x060194D9 RID: 103641 RVA: 0x002567C0 File Offset: 0x002549C0
		public unsafe float InitTurnSpeedAbs
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroBirdInteraction.__PropertyOffset_InitTurnSpeedAbs);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroBirdInteraction.__PropertyOffset_InitTurnSpeedAbs) = value;
			}
		}

		// Token: 0x170064DF RID: 25823
		// (get) Token: 0x060194DA RID: 103642 RVA: 0x002567D1 File Offset: 0x002549D1
		// (set) Token: 0x060194DB RID: 103643 RVA: 0x002567E1 File Offset: 0x002549E1
		public unsafe float StopAscentTimeMin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroBirdInteraction.__PropertyOffset_StopAscentTimeMin);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroBirdInteraction.__PropertyOffset_StopAscentTimeMin) = value;
			}
		}

		// Token: 0x170064E0 RID: 25824
		// (get) Token: 0x060194DC RID: 103644 RVA: 0x002567F2 File Offset: 0x002549F2
		// (set) Token: 0x060194DD RID: 103645 RVA: 0x00256802 File Offset: 0x00254A02
		public unsafe float StopAscentTimeMax
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroBirdInteraction.__PropertyOffset_StopAscentTimeMax);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroBirdInteraction.__PropertyOffset_StopAscentTimeMax) = value;
			}
		}

		// Token: 0x170064E1 RID: 25825
		// (get) Token: 0x060194DE RID: 103646 RVA: 0x00256813 File Offset: 0x00254A13
		// (set) Token: 0x060194DF RID: 103647 RVA: 0x00256823 File Offset: 0x00254A23
		public unsafe float HoverTimeMin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroBirdInteraction.__PropertyOffset_HoverTimeMin);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroBirdInteraction.__PropertyOffset_HoverTimeMin) = value;
			}
		}

		// Token: 0x170064E2 RID: 25826
		// (get) Token: 0x060194E0 RID: 103648 RVA: 0x00256834 File Offset: 0x00254A34
		// (set) Token: 0x060194E1 RID: 103649 RVA: 0x00256844 File Offset: 0x00254A44
		public unsafe float HoverTimeMax
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroBirdInteraction.__PropertyOffset_HoverTimeMax);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroBirdInteraction.__PropertyOffset_HoverTimeMax) = value;
			}
		}

		// Token: 0x170064E3 RID: 25827
		// (get) Token: 0x060194E2 RID: 103650 RVA: 0x00256855 File Offset: 0x00254A55
		// (set) Token: 0x060194E3 RID: 103651 RVA: 0x00256865 File Offset: 0x00254A65
		public unsafe float GroundShuffleMin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroBirdInteraction.__PropertyOffset_GroundShuffleMin);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroBirdInteraction.__PropertyOffset_GroundShuffleMin) = value;
			}
		}

		// Token: 0x170064E4 RID: 25828
		// (get) Token: 0x060194E4 RID: 103652 RVA: 0x00256876 File Offset: 0x00254A76
		// (set) Token: 0x060194E5 RID: 103653 RVA: 0x00256886 File Offset: 0x00254A86
		public unsafe float GroundShuffleMax
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroBirdInteraction.__PropertyOffset_GroundShuffleMax);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroBirdInteraction.__PropertyOffset_GroundShuffleMax) = value;
			}
		}

		// Token: 0x170064E5 RID: 25829
		// (get) Token: 0x060194E6 RID: 103654 RVA: 0x00256897 File Offset: 0x00254A97
		// (set) Token: 0x060194E7 RID: 103655 RVA: 0x002568A7 File Offset: 0x00254AA7
		public unsafe bool bEnableIdleRandomHop
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroBirdInteraction.__PropertyOffset_bEnableIdleRandomHop) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroBirdInteraction.__PropertyOffset_bEnableIdleRandomHop) = (value ? 1 : 0);
			}
		}

		// Token: 0x170064E6 RID: 25830
		// (get) Token: 0x060194E8 RID: 103656 RVA: 0x002568B8 File Offset: 0x00254AB8
		// (set) Token: 0x060194E9 RID: 103657 RVA: 0x002568C8 File Offset: 0x00254AC8
		public unsafe float IdleHopCheckInterval
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroBirdInteraction.__PropertyOffset_IdleHopCheckInterval);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroBirdInteraction.__PropertyOffset_IdleHopCheckInterval) = value;
			}
		}

		// Token: 0x170064E7 RID: 25831
		// (get) Token: 0x060194EA RID: 103658 RVA: 0x002568D9 File Offset: 0x00254AD9
		// (set) Token: 0x060194EB RID: 103659 RVA: 0x002568E9 File Offset: 0x00254AE9
		public unsafe float IdleHopProbability
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroBirdInteraction.__PropertyOffset_IdleHopProbability);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroBirdInteraction.__PropertyOffset_IdleHopProbability) = value;
			}
		}

		// Token: 0x170064E8 RID: 25832
		// (get) Token: 0x060194EC RID: 103660 RVA: 0x002568FA File Offset: 0x00254AFA
		// (set) Token: 0x060194ED RID: 103661 RVA: 0x0025690A File Offset: 0x00254B0A
		public unsafe float IdleHopHeightMin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroBirdInteraction.__PropertyOffset_IdleHopHeightMin);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroBirdInteraction.__PropertyOffset_IdleHopHeightMin) = value;
			}
		}

		// Token: 0x170064E9 RID: 25833
		// (get) Token: 0x060194EE RID: 103662 RVA: 0x0025691B File Offset: 0x00254B1B
		// (set) Token: 0x060194EF RID: 103663 RVA: 0x0025692B File Offset: 0x00254B2B
		public unsafe float IdleHopHeightMax
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroBirdInteraction.__PropertyOffset_IdleHopHeightMax);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroBirdInteraction.__PropertyOffset_IdleHopHeightMax) = value;
			}
		}

		// Token: 0x170064EA RID: 25834
		// (get) Token: 0x060194F0 RID: 103664 RVA: 0x0025693C File Offset: 0x00254B3C
		// (set) Token: 0x060194F1 RID: 103665 RVA: 0x0025694C File Offset: 0x00254B4C
		public unsafe float IdleHopDuration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroBirdInteraction.__PropertyOffset_IdleHopDuration);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroBirdInteraction.__PropertyOffset_IdleHopDuration) = value;
			}
		}

		// Token: 0x170064EB RID: 25835
		// (get) Token: 0x060194F2 RID: 103666 RVA: 0x0025695D File Offset: 0x00254B5D
		// (set) Token: 0x060194F3 RID: 103667 RVA: 0x0025696D File Offset: 0x00254B6D
		public unsafe float GroundWalkDistancePerCycle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroBirdInteraction.__PropertyOffset_GroundWalkDistancePerCycle);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroBirdInteraction.__PropertyOffset_GroundWalkDistancePerCycle) = value;
			}
		}

		// Token: 0x170064EC RID: 25836
		// (get) Token: 0x060194F4 RID: 103668 RVA: 0x0025697E File Offset: 0x00254B7E
		// (set) Token: 0x060194F5 RID: 103669 RVA: 0x0025698E File Offset: 0x00254B8E
		public unsafe float GroundJumpDistancePerCycle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroBirdInteraction.__PropertyOffset_GroundJumpDistancePerCycle);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroBirdInteraction.__PropertyOffset_GroundJumpDistancePerCycle) = value;
			}
		}

		// Token: 0x170064ED RID: 25837
		// (get) Token: 0x060194F6 RID: 103670 RVA: 0x0025699F File Offset: 0x00254B9F
		// (set) Token: 0x060194F7 RID: 103671 RVA: 0x002569AF File Offset: 0x00254BAF
		public unsafe float GroundWalkDisplacementTriggerNormalized
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroBirdInteraction.__PropertyOffset_GroundWalkDisplacementTriggerNormalized);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroBirdInteraction.__PropertyOffset_GroundWalkDisplacementTriggerNormalized) = value;
			}
		}

		// Token: 0x170064EE RID: 25838
		// (get) Token: 0x060194F8 RID: 103672 RVA: 0x002569C0 File Offset: 0x00254BC0
		// (set) Token: 0x060194F9 RID: 103673 RVA: 0x002569D0 File Offset: 0x00254BD0
		public unsafe float GroundJumpDisplacementTriggerNormalized
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroBirdInteraction.__PropertyOffset_GroundJumpDisplacementTriggerNormalized);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroBirdInteraction.__PropertyOffset_GroundJumpDisplacementTriggerNormalized) = value;
			}
		}

		// Token: 0x170064EF RID: 25839
		// (get) Token: 0x060194FA RID: 103674 RVA: 0x002569E1 File Offset: 0x00254BE1
		// (set) Token: 0x060194FB RID: 103675 RVA: 0x002569F1 File Offset: 0x00254BF1
		public unsafe bool bGroundWalkJumpContinuousForwardMovement
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroBirdInteraction.__PropertyOffset_bGroundWalkJumpContinuousForwardMovement) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroBirdInteraction.__PropertyOffset_bGroundWalkJumpContinuousForwardMovement) = (value ? 1 : 0);
			}
		}

		// Token: 0x170064F0 RID: 25840
		// (get) Token: 0x060194FC RID: 103676 RVA: 0x00256A02 File Offset: 0x00254C02
		// (set) Token: 0x060194FD RID: 103677 RVA: 0x00256A12 File Offset: 0x00254C12
		public unsafe float LandingTraceLength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroBirdInteraction.__PropertyOffset_LandingTraceLength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroBirdInteraction.__PropertyOffset_LandingTraceLength) = value;
			}
		}

		// Token: 0x170064F1 RID: 25841
		// (get) Token: 0x060194FE RID: 103678 RVA: 0x00256A24 File Offset: 0x00254C24
		// (set) Token: 0x060194FF RID: 103679 RVA: 0x00256A5D File Offset: 0x00254C5D
		[Nullable(new byte[]
		{
			1,
			0
		})]
		public TArray<TEnumAsByte<EObjectTypeQuery>> LandingTraceObjectTypes
		{
			[return: Nullable(new byte[]
			{
				1,
				0
			})]
			get
			{
				base.FastCheckIsValid();
				TArray<TEnumAsByte<EObjectTypeQuery>> result;
				if ((result = this._LandingTraceObjectTypes) == null)
				{
					result = (this._LandingTraceObjectTypes = new TArray<TEnumAsByte<EObjectTypeQuery>>(base.NativePtr + (IntPtr)AKuroBirdInteraction.__PropertyOffset_LandingTraceObjectTypes, this));
				}
				return result;
			}
			[param: Nullable(new byte[]
			{
				1,
				0
			})]
			set
			{
				this.LandingTraceObjectTypes.CopyAssign(value);
			}
		}

		// Token: 0x170064F2 RID: 25842
		// (get) Token: 0x06019500 RID: 103680 RVA: 0x00256A6B File Offset: 0x00254C6B
		// (set) Token: 0x06019501 RID: 103681 RVA: 0x00256A7B File Offset: 0x00254C7B
		public unsafe float LandingGroundDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroBirdInteraction.__PropertyOffset_LandingGroundDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroBirdInteraction.__PropertyOffset_LandingGroundDistance) = value;
			}
		}

		// Token: 0x170064F3 RID: 25843
		// (get) Token: 0x06019502 RID: 103682 RVA: 0x00256A8C File Offset: 0x00254C8C
		// (set) Token: 0x06019503 RID: 103683 RVA: 0x00256A9C File Offset: 0x00254C9C
		public unsafe float LandingVATLeadDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroBirdInteraction.__PropertyOffset_LandingVATLeadDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroBirdInteraction.__PropertyOffset_LandingVATLeadDistance) = value;
			}
		}

		// Token: 0x170064F4 RID: 25844
		// (get) Token: 0x06019504 RID: 103684 RVA: 0x00256AAD File Offset: 0x00254CAD
		// (set) Token: 0x06019505 RID: 103685 RVA: 0x00256ABD File Offset: 0x00254CBD
		public unsafe float GroundSnapOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroBirdInteraction.__PropertyOffset_GroundSnapOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroBirdInteraction.__PropertyOffset_GroundSnapOffset) = value;
			}
		}

		// Token: 0x170064F5 RID: 25845
		// (get) Token: 0x06019506 RID: 103686 RVA: 0x00256ACE File Offset: 0x00254CCE
		// (set) Token: 0x06019507 RID: 103687 RVA: 0x00256ADE File Offset: 0x00254CDE
		public unsafe float FlightYawDeltaDegrees
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroBirdInteraction.__PropertyOffset_FlightYawDeltaDegrees);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroBirdInteraction.__PropertyOffset_FlightYawDeltaDegrees) = value;
			}
		}

		// Token: 0x170064F6 RID: 25846
		// (get) Token: 0x06019508 RID: 103688 RVA: 0x00256AEF File Offset: 0x00254CEF
		// (set) Token: 0x06019509 RID: 103689 RVA: 0x00256AFF File Offset: 0x00254CFF
		public unsafe bool bUseWorldUpForVerticalFlight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroBirdInteraction.__PropertyOffset_bUseWorldUpForVerticalFlight) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroBirdInteraction.__PropertyOffset_bUseWorldUpForVerticalFlight) = (value ? 1 : 0);
			}
		}

		// Token: 0x170064F7 RID: 25847
		// (get) Token: 0x0601950A RID: 103690 RVA: 0x00256B10 File Offset: 0x00254D10
		// (set) Token: 0x0601950B RID: 103691 RVA: 0x00256B20 File Offset: 0x00254D20
		public unsafe float MaxFlightHeightAboveSpawn
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroBirdInteraction.__PropertyOffset_MaxFlightHeightAboveSpawn);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroBirdInteraction.__PropertyOffset_MaxFlightHeightAboveSpawn) = value;
			}
		}

		// Token: 0x170064F8 RID: 25848
		// (get) Token: 0x0601950C RID: 103692 RVA: 0x00256B31 File Offset: 0x00254D31
		// (set) Token: 0x0601950D RID: 103693 RVA: 0x00256B41 File Offset: 0x00254D41
		public unsafe float BirdBodyRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroBirdInteraction.__PropertyOffset_BirdBodyRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroBirdInteraction.__PropertyOffset_BirdBodyRadius) = value;
			}
		}

		// Token: 0x170064F9 RID: 25849
		// (get) Token: 0x0601950E RID: 103694 RVA: 0x00256B52 File Offset: 0x00254D52
		// (set) Token: 0x0601950F RID: 103695 RVA: 0x00256B62 File Offset: 0x00254D62
		public unsafe float GroundSupportTraceLength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroBirdInteraction.__PropertyOffset_GroundSupportTraceLength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroBirdInteraction.__PropertyOffset_GroundSupportTraceLength) = value;
			}
		}

		// Token: 0x170064FA RID: 25850
		// (get) Token: 0x06019510 RID: 103696 RVA: 0x00256B73 File Offset: 0x00254D73
		// (set) Token: 0x06019511 RID: 103697 RVA: 0x00256B83 File Offset: 0x00254D83
		public unsafe float GroundedMaxSupportDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroBirdInteraction.__PropertyOffset_GroundedMaxSupportDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroBirdInteraction.__PropertyOffset_GroundedMaxSupportDistance) = value;
			}
		}

		// Token: 0x170064FB RID: 25851
		// (get) Token: 0x06019512 RID: 103698 RVA: 0x00256B94 File Offset: 0x00254D94
		// (set) Token: 0x06019513 RID: 103699 RVA: 0x00256BA4 File Offset: 0x00254DA4
		public unsafe float GroundFallAcceleration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroBirdInteraction.__PropertyOffset_GroundFallAcceleration);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroBirdInteraction.__PropertyOffset_GroundFallAcceleration) = value;
			}
		}

		// Token: 0x170064FC RID: 25852
		// (get) Token: 0x06019514 RID: 103700 RVA: 0x00256BB5 File Offset: 0x00254DB5
		// (set) Token: 0x06019515 RID: 103701 RVA: 0x00256BC5 File Offset: 0x00254DC5
		public unsafe float GroundMaxFallSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroBirdInteraction.__PropertyOffset_GroundMaxFallSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroBirdInteraction.__PropertyOffset_GroundMaxFallSpeed) = value;
			}
		}

		// Token: 0x170064FD RID: 25853
		// (get) Token: 0x06019516 RID: 103702 RVA: 0x00256BD6 File Offset: 0x00254DD6
		// (set) Token: 0x06019517 RID: 103703 RVA: 0x00256BEA File Offset: 0x00254DEA
		public unsafe USphereComponent InteractionSphere
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USphereComponent>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroBirdInteraction.__PropertyOffset_InteractionSphere);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroBirdInteraction.__PropertyOffset_InteractionSphere, value);
			}
		}

		// Token: 0x170064FE RID: 25854
		// (get) Token: 0x06019518 RID: 103704 RVA: 0x00256BFF File Offset: 0x00254DFF
		// (set) Token: 0x06019519 RID: 103705 RVA: 0x00256C13 File Offset: 0x00254E13
		public unsafe USphereComponent BirdBodyCollision
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USphereComponent>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroBirdInteraction.__PropertyOffset_BirdBodyCollision);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroBirdInteraction.__PropertyOffset_BirdBodyCollision, value);
			}
		}

		// Token: 0x170064FF RID: 25855
		// (get) Token: 0x0601951A RID: 103706 RVA: 0x00256C28 File Offset: 0x00254E28
		// (set) Token: 0x0601951B RID: 103707 RVA: 0x00256C3C File Offset: 0x00254E3C
		public unsafe UStaticMeshComponent VATMesh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroBirdInteraction.__PropertyOffset_VATMesh);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroBirdInteraction.__PropertyOffset_VATMesh, value);
			}
		}

		// Token: 0x17006500 RID: 25856
		// (get) Token: 0x0601951C RID: 103708 RVA: 0x00256C51 File Offset: 0x00254E51
		// (set) Token: 0x0601951D RID: 103709 RVA: 0x00256C61 File Offset: 0x00254E61
		public unsafe int VATMaterialSlot
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroBirdInteraction.__PropertyOffset_VATMaterialSlot);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroBirdInteraction.__PropertyOffset_VATMaterialSlot) = value;
			}
		}

		// Token: 0x17006501 RID: 25857
		// (get) Token: 0x0601951E RID: 103710 RVA: 0x00256C72 File Offset: 0x00254E72
		// (set) Token: 0x0601951F RID: 103711 RVA: 0x00256C82 File Offset: 0x00254E82
		public unsafe bool bAutoCreateVATMID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroBirdInteraction.__PropertyOffset_bAutoCreateVATMID) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroBirdInteraction.__PropertyOffset_bAutoCreateVATMID) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006502 RID: 25858
		// (get) Token: 0x06019520 RID: 103712 RVA: 0x00256C93 File Offset: 0x00254E93
		// (set) Token: 0x06019521 RID: 103713 RVA: 0x00256CA3 File Offset: 0x00254EA3
		public unsafe bool bRandomizeInitialIdleStartTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroBirdInteraction.__PropertyOffset_bRandomizeInitialIdleStartTime) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroBirdInteraction.__PropertyOffset_bRandomizeInitialIdleStartTime) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006503 RID: 25859
		// (get) Token: 0x06019522 RID: 103714 RVA: 0x00256CB4 File Offset: 0x00254EB4
		// (set) Token: 0x06019523 RID: 103715 RVA: 0x00256CC4 File Offset: 0x00254EC4
		public unsafe float VATBlendWalkToIdleForwardCompensationUU
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroBirdInteraction.__PropertyOffset_VATBlendWalkToIdleForwardCompensationUU);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroBirdInteraction.__PropertyOffset_VATBlendWalkToIdleForwardCompensationUU) = value;
			}
		}

		// Token: 0x17006504 RID: 25860
		// (get) Token: 0x06019524 RID: 103716 RVA: 0x00256CD5 File Offset: 0x00254ED5
		// (set) Token: 0x06019525 RID: 103717 RVA: 0x00256CE5 File Offset: 0x00254EE5
		public unsafe float VATBlendJumpToIdleForwardCompensationUU
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroBirdInteraction.__PropertyOffset_VATBlendJumpToIdleForwardCompensationUU);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroBirdInteraction.__PropertyOffset_VATBlendJumpToIdleForwardCompensationUU) = value;
			}
		}

		// Token: 0x17006505 RID: 25861
		// (get) Token: 0x06019526 RID: 103718 RVA: 0x00256CF8 File Offset: 0x00254EF8
		// (set) Token: 0x06019527 RID: 103719 RVA: 0x00256D31 File Offset: 0x00254F31
		[Nullable(1)]
		public TMap<EBirdVATState, FBirdVATClip> StateClips
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TMap<EBirdVATState, FBirdVATClip> result;
				if ((result = this._StateClips) == null)
				{
					result = (this._StateClips = new TMap<EBirdVATState, FBirdVATClip>(base.NativePtr + (IntPtr)AKuroBirdInteraction.__PropertyOffset_StateClips, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.StateClips.CopyAssign(value);
			}
		}

		// Token: 0x17006506 RID: 25862
		// (get) Token: 0x06019528 RID: 103720 RVA: 0x00256D3F File Offset: 0x00254F3F
		// (set) Token: 0x06019529 RID: 103721 RVA: 0x00256D4F File Offset: 0x00254F4F
		public unsafe EBirdVATState CurrentVATState
		{
			get
			{
				return (EBirdVATState)(*(base.NativePtr + (IntPtr)AKuroBirdInteraction.__PropertyOffset_CurrentVATState));
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroBirdInteraction.__PropertyOffset_CurrentVATState) = (byte)value;
			}
		}

		// Token: 0x17006507 RID: 25863
		// (get) Token: 0x0601952A RID: 103722 RVA: 0x00256D60 File Offset: 0x00254F60
		// (set) Token: 0x0601952B RID: 103723 RVA: 0x00256D70 File Offset: 0x00254F70
		public unsafe EBirdVATState PreviousVATState
		{
			get
			{
				return (EBirdVATState)(*(base.NativePtr + (IntPtr)AKuroBirdInteraction.__PropertyOffset_PreviousVATState));
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroBirdInteraction.__PropertyOffset_PreviousVATState) = (byte)value;
			}
		}

		// Token: 0x17006508 RID: 25864
		// (get) Token: 0x0601952C RID: 103724 RVA: 0x00256D84 File Offset: 0x00254F84
		// (set) Token: 0x0601952D RID: 103725 RVA: 0x00256DBD File Offset: 0x00254FBD
		[Nullable(1)]
		public FKuroBirdVATStateChanged OnVATStateChanged
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FKuroBirdVATStateChanged result;
				if ((result = this._OnVATStateChanged) == null)
				{
					result = (this._OnVATStateChanged = new FKuroBirdVATStateChanged(base.NativePtr + (IntPtr)AKuroBirdInteraction.__PropertyOffset_OnVATStateChanged, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)AKuroBirdInteraction.__PropertyOffset_OnVATStateChanged, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17006509 RID: 25865
		// (get) Token: 0x0601952E RID: 103726 RVA: 0x00256DE0 File Offset: 0x00254FE0
		// (set) Token: 0x0601952F RID: 103727 RVA: 0x00256E19 File Offset: 0x00255019
		[Nullable(1)]
		public FKuroBirdInteractionSimpleEvent OnScaredByPlayer
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FKuroBirdInteractionSimpleEvent result;
				if ((result = this._OnScaredByPlayer) == null)
				{
					result = (this._OnScaredByPlayer = new FKuroBirdInteractionSimpleEvent(base.NativePtr + (IntPtr)AKuroBirdInteraction.__PropertyOffset_OnScaredByPlayer, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)AKuroBirdInteraction.__PropertyOffset_OnScaredByPlayer, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x1700650A RID: 25866
		// (get) Token: 0x06019530 RID: 103728 RVA: 0x00256E3C File Offset: 0x0025503C
		// (set) Token: 0x06019531 RID: 103729 RVA: 0x00256E75 File Offset: 0x00255075
		[Nullable(1)]
		public FKuroBirdInteractionSimpleEvent OnLanded
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FKuroBirdInteractionSimpleEvent result;
				if ((result = this._OnLanded) == null)
				{
					result = (this._OnLanded = new FKuroBirdInteractionSimpleEvent(base.NativePtr + (IntPtr)AKuroBirdInteraction.__PropertyOffset_OnLanded, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)AKuroBirdInteraction.__PropertyOffset_OnLanded, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x1700650B RID: 25867
		// (get) Token: 0x06019532 RID: 103730 RVA: 0x00256E96 File Offset: 0x00255096
		// (set) Token: 0x06019533 RID: 103731 RVA: 0x00256EAA File Offset: 0x002550AA
		public unsafe UMaterialInstanceDynamic CachedVATMID
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroBirdInteraction.__PropertyOffset_CachedVATMID);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroBirdInteraction.__PropertyOffset_CachedVATMID, value);
			}
		}

		// Token: 0x06019534 RID: 103732 RVA: 0x00256EBF File Offset: 0x002550BF
		public bool SetVATState(EBirdVATState NewState)
		{
			return AKuroBirdInteraction.__SetVATState_Internal(base.NativePtr, NewState);
		}

		// Token: 0x06019535 RID: 103733 RVA: 0x00256ECD File Offset: 0x002550CD
		public void RefreshVATMaterialParams()
		{
			AKuroBirdInteraction.__RefreshVATMaterialParams_Internal(base.NativePtr);
		}

		// Token: 0x06019536 RID: 103734 RVA: 0x00256EDA File Offset: 0x002550DA
		public void OnVATOneShotFinished()
		{
			AKuroBirdInteraction.__OnVATOneShotFinished_Internal(base.NativePtr);
		}

		// Token: 0x06019537 RID: 103735 RVA: 0x00256EE8 File Offset: 0x002550E8
		public void HandleInteractionSphereBeginOverlap(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex, bool bFromSweep, in FHitResult SweepResult)
		{
			AKuroBirdInteraction.__HandleInteractionSphereBeginOverlap_Internal(base.NativePtr, (OverlappedComponent != null) ? OverlappedComponent.NativePtr : IntPtr.Zero, (OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero, (OtherComp != null) ? OtherComp.NativePtr : IntPtr.Zero, OtherBodyIndex, bFromSweep, (SweepResult ?? new FHitResult()).NativePtr);
		}

		// Token: 0x06019538 RID: 103736 RVA: 0x00256F45 File Offset: 0x00255145
		public virtual void BP_OnScaredByPlayer()
		{
			AKuroBirdInteraction.__BP_OnScaredByPlayer_Internal(base.NativePtr);
		}

		// Token: 0x06019539 RID: 103737 RVA: 0x00256F52 File Offset: 0x00255152
		public virtual void BP_OnLanded()
		{
			AKuroBirdInteraction.__BP_OnLanded_Internal(base.NativePtr);
		}

		// Token: 0x0601953A RID: 103738
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __SetVATState_Internal(IntPtr @this, EBirdVATState NewState);

		// Token: 0x0601953B RID: 103739
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RefreshVATMaterialParams_Internal(IntPtr @this);

		// Token: 0x0601953C RID: 103740
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnVATOneShotFinished_Internal(IntPtr @this);

		// Token: 0x0601953D RID: 103741
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __HandleInteractionSphereBeginOverlap_Internal(IntPtr @this, IntPtr OverlappedComponent, IntPtr OtherActor, IntPtr OtherComp, int OtherBodyIndex, bool bFromSweep, IntPtr SweepResult);

		// Token: 0x0601953E RID: 103742
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __BP_OnScaredByPlayer_Internal(IntPtr @this);

		// Token: 0x0601953F RID: 103743
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __BP_OnLanded_Internal(IntPtr @this);

		// Token: 0x06019540 RID: 103744 RVA: 0x00256F5F File Offset: 0x0025515F
		static AKuroBirdInteraction()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroBirdInteraction");
		}

		// Token: 0x06019541 RID: 103745 RVA: 0x00256F6D File Offset: 0x0025516D
		protected AKuroBirdInteraction(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400DC99 RID: 56473
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroBirdInteraction";

		// Token: 0x0400DC9A RID: 56474
		private static IntPtr _ClassPtr;

		// Token: 0x0400DC9B RID: 56475
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400DC9C RID: 56476
		internal static int __PropertyOffset_PlayerIndex;

		// Token: 0x0400DC9D RID: 56477
		internal static int __PropertyOffset_bEnableScareForwardFleeBeforeTakeoff;

		// Token: 0x0400DC9E RID: 56478
		internal static int __PropertyOffset_ScareForwardFleeDistanceMin;

		// Token: 0x0400DC9F RID: 56479
		internal static int __PropertyOffset_ScareForwardFleeDistanceMax;

		// Token: 0x0400DCA0 RID: 56480
		internal static int __PropertyOffset_ScareForwardHopStepDistance;

		// Token: 0x0400DCA1 RID: 56481
		internal static int __PropertyOffset_ScareForwardHopDuration;

		// Token: 0x0400DCA2 RID: 56482
		internal static int __PropertyOffset_ScareForwardHopHeightMin;

		// Token: 0x0400DCA3 RID: 56483
		internal static int __PropertyOffset_ScareForwardHopHeightMax;

		// Token: 0x0400DCA4 RID: 56484
		internal static int __PropertyOffset_bScareFleeFaceAwayFromPlayer;

		// Token: 0x0400DCA5 RID: 56485
		internal static int __PropertyOffset_ScareFleeTurnDuration;

		// Token: 0x0400DCA6 RID: 56486
		internal static int __PropertyOffset_ScareFleeTurnMinAngleDegrees;

		// Token: 0x0400DCA7 RID: 56487
		internal static int __PropertyOffset_bCanBeScaredAgain;

		// Token: 0x0400DCA8 RID: 56488
		internal static int __PropertyOffset_bIsFlying;

		// Token: 0x0400DCA9 RID: 56489
		internal static int __PropertyOffset_bScareForwardFleeActive;

		// Token: 0x0400DCAA RID: 56490
		internal static int __PropertyOffset_GroundLocomotion;

		// Token: 0x0400DCAB RID: 56491
		internal static int __PropertyOffset_FlightPhase;

		// Token: 0x0400DCAC RID: 56492
		internal static int __PropertyOffset_FlySpeed;

		// Token: 0x0400DCAD RID: 56493
		internal static int __PropertyOffset_UpSpeed;

		// Token: 0x0400DCAE RID: 56494
		internal static int __PropertyOffset_DateStore;

		// Token: 0x0400DCAF RID: 56495
		internal static int __PropertyOffset_InitUpSpeedBase;

		// Token: 0x0400DCB0 RID: 56496
		internal static int __PropertyOffset_InitUpSpeedExtraMax;

		// Token: 0x0400DCB1 RID: 56497
		internal static int __PropertyOffset_InitTurnSpeedAbs;

		// Token: 0x0400DCB2 RID: 56498
		internal static int __PropertyOffset_StopAscentTimeMin;

		// Token: 0x0400DCB3 RID: 56499
		internal static int __PropertyOffset_StopAscentTimeMax;

		// Token: 0x0400DCB4 RID: 56500
		internal static int __PropertyOffset_HoverTimeMin;

		// Token: 0x0400DCB5 RID: 56501
		internal static int __PropertyOffset_HoverTimeMax;

		// Token: 0x0400DCB6 RID: 56502
		internal static int __PropertyOffset_GroundShuffleMin;

		// Token: 0x0400DCB7 RID: 56503
		internal static int __PropertyOffset_GroundShuffleMax;

		// Token: 0x0400DCB8 RID: 56504
		internal static int __PropertyOffset_bEnableIdleRandomHop;

		// Token: 0x0400DCB9 RID: 56505
		internal static int __PropertyOffset_IdleHopCheckInterval;

		// Token: 0x0400DCBA RID: 56506
		internal static int __PropertyOffset_IdleHopProbability;

		// Token: 0x0400DCBB RID: 56507
		internal static int __PropertyOffset_IdleHopHeightMin;

		// Token: 0x0400DCBC RID: 56508
		internal static int __PropertyOffset_IdleHopHeightMax;

		// Token: 0x0400DCBD RID: 56509
		internal static int __PropertyOffset_IdleHopDuration;

		// Token: 0x0400DCBE RID: 56510
		internal static int __PropertyOffset_GroundWalkDistancePerCycle;

		// Token: 0x0400DCBF RID: 56511
		internal static int __PropertyOffset_GroundJumpDistancePerCycle;

		// Token: 0x0400DCC0 RID: 56512
		internal static int __PropertyOffset_GroundWalkDisplacementTriggerNormalized;

		// Token: 0x0400DCC1 RID: 56513
		internal static int __PropertyOffset_GroundJumpDisplacementTriggerNormalized;

		// Token: 0x0400DCC2 RID: 56514
		internal static int __PropertyOffset_bGroundWalkJumpContinuousForwardMovement;

		// Token: 0x0400DCC3 RID: 56515
		internal static int __PropertyOffset_LandingTraceLength;

		// Token: 0x0400DCC4 RID: 56516
		internal static int __PropertyOffset_LandingTraceObjectTypes;

		// Token: 0x0400DCC5 RID: 56517
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private TArray<TEnumAsByte<EObjectTypeQuery>> _LandingTraceObjectTypes;

		// Token: 0x0400DCC6 RID: 56518
		internal static int __PropertyOffset_LandingGroundDistance;

		// Token: 0x0400DCC7 RID: 56519
		internal static int __PropertyOffset_LandingVATLeadDistance;

		// Token: 0x0400DCC8 RID: 56520
		internal static int __PropertyOffset_GroundSnapOffset;

		// Token: 0x0400DCC9 RID: 56521
		internal static int __PropertyOffset_FlightYawDeltaDegrees;

		// Token: 0x0400DCCA RID: 56522
		internal static int __PropertyOffset_bUseWorldUpForVerticalFlight;

		// Token: 0x0400DCCB RID: 56523
		internal static int __PropertyOffset_MaxFlightHeightAboveSpawn;

		// Token: 0x0400DCCC RID: 56524
		internal static int __PropertyOffset_BirdBodyRadius;

		// Token: 0x0400DCCD RID: 56525
		internal static int __PropertyOffset_GroundSupportTraceLength;

		// Token: 0x0400DCCE RID: 56526
		internal static int __PropertyOffset_GroundedMaxSupportDistance;

		// Token: 0x0400DCCF RID: 56527
		internal static int __PropertyOffset_GroundFallAcceleration;

		// Token: 0x0400DCD0 RID: 56528
		internal static int __PropertyOffset_GroundMaxFallSpeed;

		// Token: 0x0400DCD1 RID: 56529
		internal static int __PropertyOffset_InteractionSphere;

		// Token: 0x0400DCD2 RID: 56530
		internal static int __PropertyOffset_BirdBodyCollision;

		// Token: 0x0400DCD3 RID: 56531
		internal static int __PropertyOffset_VATMesh;

		// Token: 0x0400DCD4 RID: 56532
		internal static int __PropertyOffset_VATMaterialSlot;

		// Token: 0x0400DCD5 RID: 56533
		internal static int __PropertyOffset_bAutoCreateVATMID;

		// Token: 0x0400DCD6 RID: 56534
		internal static int __PropertyOffset_bRandomizeInitialIdleStartTime;

		// Token: 0x0400DCD7 RID: 56535
		internal static int __PropertyOffset_VATBlendWalkToIdleForwardCompensationUU;

		// Token: 0x0400DCD8 RID: 56536
		internal static int __PropertyOffset_VATBlendJumpToIdleForwardCompensationUU;

		// Token: 0x0400DCD9 RID: 56537
		internal static int __PropertyOffset_StateClips;

		// Token: 0x0400DCDA RID: 56538
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<EBirdVATState, FBirdVATClip> _StateClips;

		// Token: 0x0400DCDB RID: 56539
		internal static int __PropertyOffset_CurrentVATState;

		// Token: 0x0400DCDC RID: 56540
		internal static int __PropertyOffset_PreviousVATState;

		// Token: 0x0400DCDD RID: 56541
		internal static int __PropertyOffset_OnVATStateChanged;

		// Token: 0x0400DCDE RID: 56542
		private FKuroBirdVATStateChanged _OnVATStateChanged;

		// Token: 0x0400DCDF RID: 56543
		internal static int __PropertyOffset_OnScaredByPlayer;

		// Token: 0x0400DCE0 RID: 56544
		private FKuroBirdInteractionSimpleEvent _OnScaredByPlayer;

		// Token: 0x0400DCE1 RID: 56545
		internal static int __PropertyOffset_OnLanded;

		// Token: 0x0400DCE2 RID: 56546
		private FKuroBirdInteractionSimpleEvent _OnLanded;

		// Token: 0x0400DCE3 RID: 56547
		internal static int __PropertyOffset_CachedVATMID;
	}
}
