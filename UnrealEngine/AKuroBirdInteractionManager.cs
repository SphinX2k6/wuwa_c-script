using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001AB0 RID: 6832
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroBirdInteractionManager")]
	[UnrealStructLayout(2080, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2080)]
	public class AKuroBirdInteractionManager : AKuroBPActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06019542 RID: 103746 RVA: 0x00256F76 File Offset: 0x00255176
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AKuroBirdInteractionManager._ClassPtr;
		}

		// Token: 0x06019543 RID: 103747 RVA: 0x00256F84 File Offset: 0x00255184
		public AKuroBirdInteractionManager() : this(BuiltinUtils.AllocNativeUObject(AKuroBirdInteractionManager.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06019544 RID: 103748 RVA: 0x00256FAC File Offset: 0x002551AC
		public AKuroBirdInteractionManager(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AKuroBirdInteractionManager.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700650C RID: 25868
		// (get) Token: 0x06019545 RID: 103749 RVA: 0x00256FE0 File Offset: 0x002551E0
		// (set) Token: 0x06019546 RID: 103750 RVA: 0x00257019 File Offset: 0x00255219
		public TArray<FTransform> EditorBirdTransforms
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FTransform> result;
				if ((result = this._EditorBirdTransforms) == null)
				{
					result = (this._EditorBirdTransforms = new TArray<FTransform>(base.NativePtr + (IntPtr)AKuroBirdInteractionManager.__PropertyOffset_EditorBirdTransforms, this));
				}
				return result;
			}
			set
			{
				this.EditorBirdTransforms.CopyAssign(value);
			}
		}

		// Token: 0x1700650D RID: 25869
		// (get) Token: 0x06019547 RID: 103751 RVA: 0x00257027 File Offset: 0x00255227
		// (set) Token: 0x06019548 RID: 103752 RVA: 0x00257037 File Offset: 0x00255237
		public unsafe bool bEditorBirdTransformsUseActorLocalSpace
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroBirdInteractionManager.__PropertyOffset_bEditorBirdTransformsUseActorLocalSpace) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroBirdInteractionManager.__PropertyOffset_bEditorBirdTransformsUseActorLocalSpace) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700650E RID: 25870
		// (get) Token: 0x06019549 RID: 103753 RVA: 0x00257048 File Offset: 0x00255248
		// (set) Token: 0x0601954A RID: 103754 RVA: 0x00257058 File Offset: 0x00255258
		public unsafe bool bClearEditorBirdTransformsBeforeConstructionScript
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroBirdInteractionManager.__PropertyOffset_bClearEditorBirdTransformsBeforeConstructionScript) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroBirdInteractionManager.__PropertyOffset_bClearEditorBirdTransformsBeforeConstructionScript) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700650F RID: 25871
		// (get) Token: 0x0601954B RID: 103755 RVA: 0x00257069 File Offset: 0x00255269
		// (set) Token: 0x0601954C RID: 103756 RVA: 0x0025707D File Offset: 0x0025527D
		[Nullable(2)]
		public unsafe UStaticMesh BirdVATStaticMesh
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMesh>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroBirdInteractionManager.__PropertyOffset_BirdVATStaticMesh);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroBirdInteractionManager.__PropertyOffset_BirdVATStaticMesh, value);
			}
		}

		// Token: 0x17006510 RID: 25872
		// (get) Token: 0x0601954D RID: 103757 RVA: 0x00257092 File Offset: 0x00255292
		// (set) Token: 0x0601954E RID: 103758 RVA: 0x002570A2 File Offset: 0x002552A2
		public unsafe float InteractionSphereRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroBirdInteractionManager.__PropertyOffset_InteractionSphereRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroBirdInteractionManager.__PropertyOffset_InteractionSphereRadius) = value;
			}
		}

		// Token: 0x17006511 RID: 25873
		// (get) Token: 0x0601954F RID: 103759 RVA: 0x002570B3 File Offset: 0x002552B3
		// (set) Token: 0x06019550 RID: 103760 RVA: 0x002570C3 File Offset: 0x002552C3
		public unsafe int PlayerIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroBirdInteractionManager.__PropertyOffset_PlayerIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroBirdInteractionManager.__PropertyOffset_PlayerIndex) = value;
			}
		}

		// Token: 0x17006512 RID: 25874
		// (get) Token: 0x06019551 RID: 103761 RVA: 0x002570D4 File Offset: 0x002552D4
		// (set) Token: 0x06019552 RID: 103762 RVA: 0x002570E4 File Offset: 0x002552E4
		public unsafe bool bEnableScareForwardFleeBeforeTakeoff
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroBirdInteractionManager.__PropertyOffset_bEnableScareForwardFleeBeforeTakeoff) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroBirdInteractionManager.__PropertyOffset_bEnableScareForwardFleeBeforeTakeoff) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006513 RID: 25875
		// (get) Token: 0x06019553 RID: 103763 RVA: 0x002570F5 File Offset: 0x002552F5
		// (set) Token: 0x06019554 RID: 103764 RVA: 0x00257105 File Offset: 0x00255305
		public unsafe float ScareForwardFleeDistanceMin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroBirdInteractionManager.__PropertyOffset_ScareForwardFleeDistanceMin);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroBirdInteractionManager.__PropertyOffset_ScareForwardFleeDistanceMin) = value;
			}
		}

		// Token: 0x17006514 RID: 25876
		// (get) Token: 0x06019555 RID: 103765 RVA: 0x00257116 File Offset: 0x00255316
		// (set) Token: 0x06019556 RID: 103766 RVA: 0x00257126 File Offset: 0x00255326
		public unsafe float ScareForwardFleeDistanceMax
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroBirdInteractionManager.__PropertyOffset_ScareForwardFleeDistanceMax);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroBirdInteractionManager.__PropertyOffset_ScareForwardFleeDistanceMax) = value;
			}
		}

		// Token: 0x17006515 RID: 25877
		// (get) Token: 0x06019557 RID: 103767 RVA: 0x00257137 File Offset: 0x00255337
		// (set) Token: 0x06019558 RID: 103768 RVA: 0x00257147 File Offset: 0x00255347
		public unsafe float ScareForwardHopStepDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroBirdInteractionManager.__PropertyOffset_ScareForwardHopStepDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroBirdInteractionManager.__PropertyOffset_ScareForwardHopStepDistance) = value;
			}
		}

		// Token: 0x17006516 RID: 25878
		// (get) Token: 0x06019559 RID: 103769 RVA: 0x00257158 File Offset: 0x00255358
		// (set) Token: 0x0601955A RID: 103770 RVA: 0x00257168 File Offset: 0x00255368
		public unsafe float ScareForwardHopDuration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroBirdInteractionManager.__PropertyOffset_ScareForwardHopDuration);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroBirdInteractionManager.__PropertyOffset_ScareForwardHopDuration) = value;
			}
		}

		// Token: 0x17006517 RID: 25879
		// (get) Token: 0x0601955B RID: 103771 RVA: 0x00257179 File Offset: 0x00255379
		// (set) Token: 0x0601955C RID: 103772 RVA: 0x00257189 File Offset: 0x00255389
		public unsafe float ScareForwardHopHeightMin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroBirdInteractionManager.__PropertyOffset_ScareForwardHopHeightMin);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroBirdInteractionManager.__PropertyOffset_ScareForwardHopHeightMin) = value;
			}
		}

		// Token: 0x17006518 RID: 25880
		// (get) Token: 0x0601955D RID: 103773 RVA: 0x0025719A File Offset: 0x0025539A
		// (set) Token: 0x0601955E RID: 103774 RVA: 0x002571AA File Offset: 0x002553AA
		public unsafe float ScareForwardHopHeightMax
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroBirdInteractionManager.__PropertyOffset_ScareForwardHopHeightMax);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroBirdInteractionManager.__PropertyOffset_ScareForwardHopHeightMax) = value;
			}
		}

		// Token: 0x17006519 RID: 25881
		// (get) Token: 0x0601955F RID: 103775 RVA: 0x002571BB File Offset: 0x002553BB
		// (set) Token: 0x06019560 RID: 103776 RVA: 0x002571CB File Offset: 0x002553CB
		public unsafe bool bScareFleeFaceAwayFromPlayer
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroBirdInteractionManager.__PropertyOffset_bScareFleeFaceAwayFromPlayer) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroBirdInteractionManager.__PropertyOffset_bScareFleeFaceAwayFromPlayer) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700651A RID: 25882
		// (get) Token: 0x06019561 RID: 103777 RVA: 0x002571DC File Offset: 0x002553DC
		// (set) Token: 0x06019562 RID: 103778 RVA: 0x002571EC File Offset: 0x002553EC
		public unsafe float ScareFleeTurnDuration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroBirdInteractionManager.__PropertyOffset_ScareFleeTurnDuration);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroBirdInteractionManager.__PropertyOffset_ScareFleeTurnDuration) = value;
			}
		}

		// Token: 0x1700651B RID: 25883
		// (get) Token: 0x06019563 RID: 103779 RVA: 0x002571FD File Offset: 0x002553FD
		// (set) Token: 0x06019564 RID: 103780 RVA: 0x0025720D File Offset: 0x0025540D
		public unsafe float ScareFleeTurnMinAngleDegrees
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroBirdInteractionManager.__PropertyOffset_ScareFleeTurnMinAngleDegrees);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroBirdInteractionManager.__PropertyOffset_ScareFleeTurnMinAngleDegrees) = value;
			}
		}

		// Token: 0x1700651C RID: 25884
		// (get) Token: 0x06019565 RID: 103781 RVA: 0x0025721E File Offset: 0x0025541E
		// (set) Token: 0x06019566 RID: 103782 RVA: 0x0025722E File Offset: 0x0025542E
		public unsafe float FlySpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroBirdInteractionManager.__PropertyOffset_FlySpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroBirdInteractionManager.__PropertyOffset_FlySpeed) = value;
			}
		}

		// Token: 0x1700651D RID: 25885
		// (get) Token: 0x06019567 RID: 103783 RVA: 0x0025723F File Offset: 0x0025543F
		// (set) Token: 0x06019568 RID: 103784 RVA: 0x0025724F File Offset: 0x0025544F
		public unsafe float InitUpSpeedBase
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroBirdInteractionManager.__PropertyOffset_InitUpSpeedBase);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroBirdInteractionManager.__PropertyOffset_InitUpSpeedBase) = value;
			}
		}

		// Token: 0x1700651E RID: 25886
		// (get) Token: 0x06019569 RID: 103785 RVA: 0x00257260 File Offset: 0x00255460
		// (set) Token: 0x0601956A RID: 103786 RVA: 0x00257270 File Offset: 0x00255470
		public unsafe float InitUpSpeedExtraMax
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroBirdInteractionManager.__PropertyOffset_InitUpSpeedExtraMax);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroBirdInteractionManager.__PropertyOffset_InitUpSpeedExtraMax) = value;
			}
		}

		// Token: 0x1700651F RID: 25887
		// (get) Token: 0x0601956B RID: 103787 RVA: 0x00257281 File Offset: 0x00255481
		// (set) Token: 0x0601956C RID: 103788 RVA: 0x00257291 File Offset: 0x00255491
		public unsafe float InitTurnSpeedAbs
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroBirdInteractionManager.__PropertyOffset_InitTurnSpeedAbs);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroBirdInteractionManager.__PropertyOffset_InitTurnSpeedAbs) = value;
			}
		}

		// Token: 0x17006520 RID: 25888
		// (get) Token: 0x0601956D RID: 103789 RVA: 0x002572A2 File Offset: 0x002554A2
		// (set) Token: 0x0601956E RID: 103790 RVA: 0x002572B2 File Offset: 0x002554B2
		public unsafe float StopAscentTimeMin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroBirdInteractionManager.__PropertyOffset_StopAscentTimeMin);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroBirdInteractionManager.__PropertyOffset_StopAscentTimeMin) = value;
			}
		}

		// Token: 0x17006521 RID: 25889
		// (get) Token: 0x0601956F RID: 103791 RVA: 0x002572C3 File Offset: 0x002554C3
		// (set) Token: 0x06019570 RID: 103792 RVA: 0x002572D3 File Offset: 0x002554D3
		public unsafe float StopAscentTimeMax
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroBirdInteractionManager.__PropertyOffset_StopAscentTimeMax);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroBirdInteractionManager.__PropertyOffset_StopAscentTimeMax) = value;
			}
		}

		// Token: 0x17006522 RID: 25890
		// (get) Token: 0x06019571 RID: 103793 RVA: 0x002572E4 File Offset: 0x002554E4
		// (set) Token: 0x06019572 RID: 103794 RVA: 0x002572F4 File Offset: 0x002554F4
		public unsafe float HoverTimeMin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroBirdInteractionManager.__PropertyOffset_HoverTimeMin);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroBirdInteractionManager.__PropertyOffset_HoverTimeMin) = value;
			}
		}

		// Token: 0x17006523 RID: 25891
		// (get) Token: 0x06019573 RID: 103795 RVA: 0x00257305 File Offset: 0x00255505
		// (set) Token: 0x06019574 RID: 103796 RVA: 0x00257315 File Offset: 0x00255515
		public unsafe float HoverTimeMax
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroBirdInteractionManager.__PropertyOffset_HoverTimeMax);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroBirdInteractionManager.__PropertyOffset_HoverTimeMax) = value;
			}
		}

		// Token: 0x17006524 RID: 25892
		// (get) Token: 0x06019575 RID: 103797 RVA: 0x00257326 File Offset: 0x00255526
		// (set) Token: 0x06019576 RID: 103798 RVA: 0x00257336 File Offset: 0x00255536
		public unsafe float GroundShuffleMin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroBirdInteractionManager.__PropertyOffset_GroundShuffleMin);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroBirdInteractionManager.__PropertyOffset_GroundShuffleMin) = value;
			}
		}

		// Token: 0x17006525 RID: 25893
		// (get) Token: 0x06019577 RID: 103799 RVA: 0x00257347 File Offset: 0x00255547
		// (set) Token: 0x06019578 RID: 103800 RVA: 0x00257357 File Offset: 0x00255557
		public unsafe float GroundShuffleMax
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroBirdInteractionManager.__PropertyOffset_GroundShuffleMax);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroBirdInteractionManager.__PropertyOffset_GroundShuffleMax) = value;
			}
		}

		// Token: 0x17006526 RID: 25894
		// (get) Token: 0x06019579 RID: 103801 RVA: 0x00257368 File Offset: 0x00255568
		// (set) Token: 0x0601957A RID: 103802 RVA: 0x00257378 File Offset: 0x00255578
		public unsafe bool bEnableIdleRandomHop
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroBirdInteractionManager.__PropertyOffset_bEnableIdleRandomHop) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroBirdInteractionManager.__PropertyOffset_bEnableIdleRandomHop) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006527 RID: 25895
		// (get) Token: 0x0601957B RID: 103803 RVA: 0x00257389 File Offset: 0x00255589
		// (set) Token: 0x0601957C RID: 103804 RVA: 0x00257399 File Offset: 0x00255599
		public unsafe float IdleHopCheckInterval
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroBirdInteractionManager.__PropertyOffset_IdleHopCheckInterval);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroBirdInteractionManager.__PropertyOffset_IdleHopCheckInterval) = value;
			}
		}

		// Token: 0x17006528 RID: 25896
		// (get) Token: 0x0601957D RID: 103805 RVA: 0x002573AA File Offset: 0x002555AA
		// (set) Token: 0x0601957E RID: 103806 RVA: 0x002573BA File Offset: 0x002555BA
		public unsafe float IdleHopProbability
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroBirdInteractionManager.__PropertyOffset_IdleHopProbability);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroBirdInteractionManager.__PropertyOffset_IdleHopProbability) = value;
			}
		}

		// Token: 0x17006529 RID: 25897
		// (get) Token: 0x0601957F RID: 103807 RVA: 0x002573CB File Offset: 0x002555CB
		// (set) Token: 0x06019580 RID: 103808 RVA: 0x002573DB File Offset: 0x002555DB
		public unsafe float IdleHopHeightMin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroBirdInteractionManager.__PropertyOffset_IdleHopHeightMin);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroBirdInteractionManager.__PropertyOffset_IdleHopHeightMin) = value;
			}
		}

		// Token: 0x1700652A RID: 25898
		// (get) Token: 0x06019581 RID: 103809 RVA: 0x002573EC File Offset: 0x002555EC
		// (set) Token: 0x06019582 RID: 103810 RVA: 0x002573FC File Offset: 0x002555FC
		public unsafe float IdleHopHeightMax
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroBirdInteractionManager.__PropertyOffset_IdleHopHeightMax);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroBirdInteractionManager.__PropertyOffset_IdleHopHeightMax) = value;
			}
		}

		// Token: 0x1700652B RID: 25899
		// (get) Token: 0x06019583 RID: 103811 RVA: 0x0025740D File Offset: 0x0025560D
		// (set) Token: 0x06019584 RID: 103812 RVA: 0x0025741D File Offset: 0x0025561D
		public unsafe float IdleHopDuration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroBirdInteractionManager.__PropertyOffset_IdleHopDuration);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroBirdInteractionManager.__PropertyOffset_IdleHopDuration) = value;
			}
		}

		// Token: 0x1700652C RID: 25900
		// (get) Token: 0x06019585 RID: 103813 RVA: 0x0025742E File Offset: 0x0025562E
		// (set) Token: 0x06019586 RID: 103814 RVA: 0x0025743E File Offset: 0x0025563E
		public unsafe float GroundWalkDistancePerCycle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroBirdInteractionManager.__PropertyOffset_GroundWalkDistancePerCycle);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroBirdInteractionManager.__PropertyOffset_GroundWalkDistancePerCycle) = value;
			}
		}

		// Token: 0x1700652D RID: 25901
		// (get) Token: 0x06019587 RID: 103815 RVA: 0x0025744F File Offset: 0x0025564F
		// (set) Token: 0x06019588 RID: 103816 RVA: 0x0025745F File Offset: 0x0025565F
		public unsafe float GroundJumpDistancePerCycle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroBirdInteractionManager.__PropertyOffset_GroundJumpDistancePerCycle);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroBirdInteractionManager.__PropertyOffset_GroundJumpDistancePerCycle) = value;
			}
		}

		// Token: 0x1700652E RID: 25902
		// (get) Token: 0x06019589 RID: 103817 RVA: 0x00257470 File Offset: 0x00255670
		// (set) Token: 0x0601958A RID: 103818 RVA: 0x00257480 File Offset: 0x00255680
		public unsafe float GroundWalkDisplacementTriggerNormalized
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroBirdInteractionManager.__PropertyOffset_GroundWalkDisplacementTriggerNormalized);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroBirdInteractionManager.__PropertyOffset_GroundWalkDisplacementTriggerNormalized) = value;
			}
		}

		// Token: 0x1700652F RID: 25903
		// (get) Token: 0x0601958B RID: 103819 RVA: 0x00257491 File Offset: 0x00255691
		// (set) Token: 0x0601958C RID: 103820 RVA: 0x002574A1 File Offset: 0x002556A1
		public unsafe float GroundJumpDisplacementTriggerNormalized
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroBirdInteractionManager.__PropertyOffset_GroundJumpDisplacementTriggerNormalized);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroBirdInteractionManager.__PropertyOffset_GroundJumpDisplacementTriggerNormalized) = value;
			}
		}

		// Token: 0x17006530 RID: 25904
		// (get) Token: 0x0601958D RID: 103821 RVA: 0x002574B2 File Offset: 0x002556B2
		// (set) Token: 0x0601958E RID: 103822 RVA: 0x002574C2 File Offset: 0x002556C2
		public unsafe bool bGroundWalkJumpContinuousForwardMovement
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroBirdInteractionManager.__PropertyOffset_bGroundWalkJumpContinuousForwardMovement) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroBirdInteractionManager.__PropertyOffset_bGroundWalkJumpContinuousForwardMovement) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006531 RID: 25905
		// (get) Token: 0x0601958F RID: 103823 RVA: 0x002574D3 File Offset: 0x002556D3
		// (set) Token: 0x06019590 RID: 103824 RVA: 0x002574E3 File Offset: 0x002556E3
		public unsafe float LandingTraceLength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroBirdInteractionManager.__PropertyOffset_LandingTraceLength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroBirdInteractionManager.__PropertyOffset_LandingTraceLength) = value;
			}
		}

		// Token: 0x17006532 RID: 25906
		// (get) Token: 0x06019591 RID: 103825 RVA: 0x002574F4 File Offset: 0x002556F4
		// (set) Token: 0x06019592 RID: 103826 RVA: 0x0025752D File Offset: 0x0025572D
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
					result = (this._LandingTraceObjectTypes = new TArray<TEnumAsByte<EObjectTypeQuery>>(base.NativePtr + (IntPtr)AKuroBirdInteractionManager.__PropertyOffset_LandingTraceObjectTypes, this));
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

		// Token: 0x17006533 RID: 25907
		// (get) Token: 0x06019593 RID: 103827 RVA: 0x0025753B File Offset: 0x0025573B
		// (set) Token: 0x06019594 RID: 103828 RVA: 0x0025754B File Offset: 0x0025574B
		public unsafe float LandingGroundDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroBirdInteractionManager.__PropertyOffset_LandingGroundDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroBirdInteractionManager.__PropertyOffset_LandingGroundDistance) = value;
			}
		}

		// Token: 0x17006534 RID: 25908
		// (get) Token: 0x06019595 RID: 103829 RVA: 0x0025755C File Offset: 0x0025575C
		// (set) Token: 0x06019596 RID: 103830 RVA: 0x0025756C File Offset: 0x0025576C
		public unsafe float LandingVATLeadDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroBirdInteractionManager.__PropertyOffset_LandingVATLeadDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroBirdInteractionManager.__PropertyOffset_LandingVATLeadDistance) = value;
			}
		}

		// Token: 0x17006535 RID: 25909
		// (get) Token: 0x06019597 RID: 103831 RVA: 0x0025757D File Offset: 0x0025577D
		// (set) Token: 0x06019598 RID: 103832 RVA: 0x0025758D File Offset: 0x0025578D
		public unsafe float GroundSnapOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroBirdInteractionManager.__PropertyOffset_GroundSnapOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroBirdInteractionManager.__PropertyOffset_GroundSnapOffset) = value;
			}
		}

		// Token: 0x17006536 RID: 25910
		// (get) Token: 0x06019599 RID: 103833 RVA: 0x0025759E File Offset: 0x0025579E
		// (set) Token: 0x0601959A RID: 103834 RVA: 0x002575B2 File Offset: 0x002557B2
		public unsafe FVector LandingBoxExtent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroBirdInteractionManager.__PropertyOffset_LandingBoxExtent);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroBirdInteractionManager.__PropertyOffset_LandingBoxExtent) = value;
			}
		}

		// Token: 0x17006537 RID: 25911
		// (get) Token: 0x0601959B RID: 103835 RVA: 0x002575C7 File Offset: 0x002557C7
		// (set) Token: 0x0601959C RID: 103836 RVA: 0x002575D7 File Offset: 0x002557D7
		public unsafe float FlightClearTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroBirdInteractionManager.__PropertyOffset_FlightClearTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroBirdInteractionManager.__PropertyOffset_FlightClearTime) = value;
			}
		}

		// Token: 0x17006538 RID: 25912
		// (get) Token: 0x0601959D RID: 103837 RVA: 0x002575E8 File Offset: 0x002557E8
		// (set) Token: 0x0601959E RID: 103838 RVA: 0x002575F8 File Offset: 0x002557F8
		public unsafe float ReturnToCenterAfterFlightTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroBirdInteractionManager.__PropertyOffset_ReturnToCenterAfterFlightTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroBirdInteractionManager.__PropertyOffset_ReturnToCenterAfterFlightTime) = value;
			}
		}

		// Token: 0x17006539 RID: 25913
		// (get) Token: 0x0601959F RID: 103839 RVA: 0x00257609 File Offset: 0x00255809
		// (set) Token: 0x060195A0 RID: 103840 RVA: 0x00257619 File Offset: 0x00255819
		public unsafe float ReturnToCenterSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroBirdInteractionManager.__PropertyOffset_ReturnToCenterSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroBirdInteractionManager.__PropertyOffset_ReturnToCenterSpeed) = value;
			}
		}

		// Token: 0x1700653A RID: 25914
		// (get) Token: 0x060195A1 RID: 103841 RVA: 0x0025762A File Offset: 0x0025582A
		// (set) Token: 0x060195A2 RID: 103842 RVA: 0x0025763A File Offset: 0x0025583A
		public unsafe float FlightYawDeltaDegrees
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroBirdInteractionManager.__PropertyOffset_FlightYawDeltaDegrees);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroBirdInteractionManager.__PropertyOffset_FlightYawDeltaDegrees) = value;
			}
		}

		// Token: 0x1700653B RID: 25915
		// (get) Token: 0x060195A3 RID: 103843 RVA: 0x0025764B File Offset: 0x0025584B
		// (set) Token: 0x060195A4 RID: 103844 RVA: 0x0025765B File Offset: 0x0025585B
		public unsafe bool bUseWorldUpForVerticalFlight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroBirdInteractionManager.__PropertyOffset_bUseWorldUpForVerticalFlight) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroBirdInteractionManager.__PropertyOffset_bUseWorldUpForVerticalFlight) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700653C RID: 25916
		// (get) Token: 0x060195A5 RID: 103845 RVA: 0x0025766C File Offset: 0x0025586C
		// (set) Token: 0x060195A6 RID: 103846 RVA: 0x0025767C File Offset: 0x0025587C
		public unsafe float MaxFlightHeightAboveSpawn
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroBirdInteractionManager.__PropertyOffset_MaxFlightHeightAboveSpawn);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroBirdInteractionManager.__PropertyOffset_MaxFlightHeightAboveSpawn) = value;
			}
		}

		// Token: 0x1700653D RID: 25917
		// (get) Token: 0x060195A7 RID: 103847 RVA: 0x0025768D File Offset: 0x0025588D
		// (set) Token: 0x060195A8 RID: 103848 RVA: 0x0025769D File Offset: 0x0025589D
		public unsafe float FlySpeedRandomMin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroBirdInteractionManager.__PropertyOffset_FlySpeedRandomMin);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroBirdInteractionManager.__PropertyOffset_FlySpeedRandomMin) = value;
			}
		}

		// Token: 0x1700653E RID: 25918
		// (get) Token: 0x060195A9 RID: 103849 RVA: 0x002576AE File Offset: 0x002558AE
		// (set) Token: 0x060195AA RID: 103850 RVA: 0x002576BE File Offset: 0x002558BE
		public unsafe float FlySpeedRandomMax
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroBirdInteractionManager.__PropertyOffset_FlySpeedRandomMax);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroBirdInteractionManager.__PropertyOffset_FlySpeedRandomMax) = value;
			}
		}

		// Token: 0x1700653F RID: 25919
		// (get) Token: 0x060195AB RID: 103851 RVA: 0x002576CF File Offset: 0x002558CF
		// (set) Token: 0x060195AC RID: 103852 RVA: 0x002576DF File Offset: 0x002558DF
		public unsafe float BirdBodyRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroBirdInteractionManager.__PropertyOffset_BirdBodyRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroBirdInteractionManager.__PropertyOffset_BirdBodyRadius) = value;
			}
		}

		// Token: 0x17006540 RID: 25920
		// (get) Token: 0x060195AD RID: 103853 RVA: 0x002576F0 File Offset: 0x002558F0
		// (set) Token: 0x060195AE RID: 103854 RVA: 0x00257700 File Offset: 0x00255900
		public unsafe float GroundSupportTraceLength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroBirdInteractionManager.__PropertyOffset_GroundSupportTraceLength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroBirdInteractionManager.__PropertyOffset_GroundSupportTraceLength) = value;
			}
		}

		// Token: 0x17006541 RID: 25921
		// (get) Token: 0x060195AF RID: 103855 RVA: 0x00257711 File Offset: 0x00255911
		// (set) Token: 0x060195B0 RID: 103856 RVA: 0x00257721 File Offset: 0x00255921
		public unsafe float GroundedMaxSupportDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroBirdInteractionManager.__PropertyOffset_GroundedMaxSupportDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroBirdInteractionManager.__PropertyOffset_GroundedMaxSupportDistance) = value;
			}
		}

		// Token: 0x17006542 RID: 25922
		// (get) Token: 0x060195B1 RID: 103857 RVA: 0x00257732 File Offset: 0x00255932
		// (set) Token: 0x060195B2 RID: 103858 RVA: 0x00257742 File Offset: 0x00255942
		public unsafe float GroundFallAcceleration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroBirdInteractionManager.__PropertyOffset_GroundFallAcceleration);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroBirdInteractionManager.__PropertyOffset_GroundFallAcceleration) = value;
			}
		}

		// Token: 0x17006543 RID: 25923
		// (get) Token: 0x060195B3 RID: 103859 RVA: 0x00257753 File Offset: 0x00255953
		// (set) Token: 0x060195B4 RID: 103860 RVA: 0x00257763 File Offset: 0x00255963
		public unsafe float GroundMaxFallSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroBirdInteractionManager.__PropertyOffset_GroundMaxFallSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroBirdInteractionManager.__PropertyOffset_GroundMaxFallSpeed) = value;
			}
		}

		// Token: 0x17006544 RID: 25924
		// (get) Token: 0x060195B5 RID: 103861 RVA: 0x00257774 File Offset: 0x00255974
		// (set) Token: 0x060195B6 RID: 103862 RVA: 0x00257784 File Offset: 0x00255984
		public unsafe bool bRandomizeInitialIdleStartTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroBirdInteractionManager.__PropertyOffset_bRandomizeInitialIdleStartTime) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroBirdInteractionManager.__PropertyOffset_bRandomizeInitialIdleStartTime) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006545 RID: 25925
		// (get) Token: 0x060195B7 RID: 103863 RVA: 0x00257795 File Offset: 0x00255995
		// (set) Token: 0x060195B8 RID: 103864 RVA: 0x002577A5 File Offset: 0x002559A5
		public unsafe float VATBlendWalkToIdleForwardCompensationUU
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroBirdInteractionManager.__PropertyOffset_VATBlendWalkToIdleForwardCompensationUU);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroBirdInteractionManager.__PropertyOffset_VATBlendWalkToIdleForwardCompensationUU) = value;
			}
		}

		// Token: 0x17006546 RID: 25926
		// (get) Token: 0x060195B9 RID: 103865 RVA: 0x002577B6 File Offset: 0x002559B6
		// (set) Token: 0x060195BA RID: 103866 RVA: 0x002577C6 File Offset: 0x002559C6
		public unsafe float VATBlendJumpToIdleForwardCompensationUU
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroBirdInteractionManager.__PropertyOffset_VATBlendJumpToIdleForwardCompensationUU);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroBirdInteractionManager.__PropertyOffset_VATBlendJumpToIdleForwardCompensationUU) = value;
			}
		}

		// Token: 0x17006547 RID: 25927
		// (get) Token: 0x060195BB RID: 103867 RVA: 0x002577D8 File Offset: 0x002559D8
		// (set) Token: 0x060195BC RID: 103868 RVA: 0x00257811 File Offset: 0x00255A11
		public TMap<EBirdVATState, FBirdVATClip> StateClips
		{
			get
			{
				base.FastCheckIsValid();
				TMap<EBirdVATState, FBirdVATClip> result;
				if ((result = this._StateClips) == null)
				{
					result = (this._StateClips = new TMap<EBirdVATState, FBirdVATClip>(base.NativePtr + (IntPtr)AKuroBirdInteractionManager.__PropertyOffset_StateClips, this));
				}
				return result;
			}
			set
			{
				this.StateClips.CopyAssign(value);
			}
		}

		// Token: 0x17006548 RID: 25928
		// (get) Token: 0x060195BD RID: 103869 RVA: 0x0025781F File Offset: 0x00255A1F
		// (set) Token: 0x060195BE RID: 103870 RVA: 0x0025782F File Offset: 0x00255A2F
		public unsafe int BirdRaysPerFrame
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroBirdInteractionManager.__PropertyOffset_BirdRaysPerFrame);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroBirdInteractionManager.__PropertyOffset_BirdRaysPerFrame) = value;
			}
		}

		// Token: 0x17006549 RID: 25929
		// (get) Token: 0x060195BF RID: 103871 RVA: 0x00257840 File Offset: 0x00255A40
		// (set) Token: 0x060195C0 RID: 103872 RVA: 0x00257850 File Offset: 0x00255A50
		public unsafe bool bUseAsyncBirdRays
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroBirdInteractionManager.__PropertyOffset_bUseAsyncBirdRays) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroBirdInteractionManager.__PropertyOffset_bUseAsyncBirdRays) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700654A RID: 25930
		// (get) Token: 0x060195C1 RID: 103873 RVA: 0x00257864 File Offset: 0x00255A64
		// (set) Token: 0x060195C2 RID: 103874 RVA: 0x0025789D File Offset: 0x00255A9D
		public FKuroBirdManagerBirdIndexEvent OnScaredByPlayer
		{
			get
			{
				base.FastCheckIsValid();
				FKuroBirdManagerBirdIndexEvent result;
				if ((result = this._OnScaredByPlayer) == null)
				{
					result = (this._OnScaredByPlayer = new FKuroBirdManagerBirdIndexEvent(base.NativePtr + (IntPtr)AKuroBirdInteractionManager.__PropertyOffset_OnScaredByPlayer, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)AKuroBirdInteractionManager.__PropertyOffset_OnScaredByPlayer, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x1700654B RID: 25931
		// (get) Token: 0x060195C3 RID: 103875 RVA: 0x002578C0 File Offset: 0x00255AC0
		// (set) Token: 0x060195C4 RID: 103876 RVA: 0x002578F9 File Offset: 0x00255AF9
		public FKuroBirdManagerBirdIndexEvent OnLanded
		{
			get
			{
				base.FastCheckIsValid();
				FKuroBirdManagerBirdIndexEvent result;
				if ((result = this._OnLanded) == null)
				{
					result = (this._OnLanded = new FKuroBirdManagerBirdIndexEvent(base.NativePtr + (IntPtr)AKuroBirdInteractionManager.__PropertyOffset_OnLanded, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)AKuroBirdInteractionManager.__PropertyOffset_OnLanded, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x1700654C RID: 25932
		// (get) Token: 0x060195C5 RID: 103877 RVA: 0x0025791C File Offset: 0x00255B1C
		// (set) Token: 0x060195C6 RID: 103878 RVA: 0x00257955 File Offset: 0x00255B55
		public FKuroBirdVATStateChanged OnVATStateChanged
		{
			get
			{
				base.FastCheckIsValid();
				FKuroBirdVATStateChanged result;
				if ((result = this._OnVATStateChanged) == null)
				{
					result = (this._OnVATStateChanged = new FKuroBirdVATStateChanged(base.NativePtr + (IntPtr)AKuroBirdInteractionManager.__PropertyOffset_OnVATStateChanged, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)AKuroBirdInteractionManager.__PropertyOffset_OnVATStateChanged, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x1700654D RID: 25933
		// (get) Token: 0x060195C7 RID: 103879 RVA: 0x00257976 File Offset: 0x00255B76
		// (set) Token: 0x060195C8 RID: 103880 RVA: 0x0025798A File Offset: 0x00255B8A
		[Nullable(2)]
		public unsafe UInstancedStaticMeshComponent BirdISM
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UInstancedStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroBirdInteractionManager.__PropertyOffset_BirdISM);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroBirdInteractionManager.__PropertyOffset_BirdISM, value);
			}
		}

		// Token: 0x060195C9 RID: 103881 RVA: 0x0025799F File Offset: 0x00255B9F
		[NullableContext(2)]
		public void SetEditorBirdTransforms(in TArray<FTransform> InTransforms)
		{
			AKuroBirdInteractionManager.__SetEditorBirdTransforms_Internal(base.NativePtr, (InTransforms ?? new TArray<FTransform>()).NativePtr);
		}

		// Token: 0x060195CA RID: 103882 RVA: 0x002579BC File Offset: 0x00255BBC
		public bool SetBirdVATState(int BirdIndex, EBirdVATState NewState)
		{
			return AKuroBirdInteractionManager.__SetBirdVATState_Internal(base.NativePtr, BirdIndex, NewState);
		}

		// Token: 0x060195CB RID: 103883 RVA: 0x002579CB File Offset: 0x00255BCB
		public void RebuildInstancesFromEditorTransforms()
		{
			AKuroBirdInteractionManager.__RebuildInstancesFromEditorTransforms_Internal(base.NativePtr);
		}

		// Token: 0x060195CC RID: 103884 RVA: 0x002579D8 File Offset: 0x00255BD8
		[NullableContext(2)]
		public bool GetBirdState(int BirdIndex, ref FKuroBirdInstanceState OutState)
		{
			return AKuroBirdInteractionManager.__GetBirdState_Internal(base.NativePtr, BirdIndex, (OutState ?? new FKuroBirdInstanceState()).NativePtr);
		}

		// Token: 0x060195CD RID: 103885 RVA: 0x002579F6 File Offset: 0x00255BF6
		public virtual void BP_OnScaredByPlayer(int BirdIndex)
		{
			AKuroBirdInteractionManager.__BP_OnScaredByPlayer_Internal(base.NativePtr, BirdIndex);
		}

		// Token: 0x060195CE RID: 103886 RVA: 0x00257A04 File Offset: 0x00255C04
		public virtual void BP_OnLanded(int BirdIndex)
		{
			AKuroBirdInteractionManager.__BP_OnLanded_Internal(base.NativePtr, BirdIndex);
		}

		// Token: 0x060195CF RID: 103887
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetEditorBirdTransforms_Internal(IntPtr @this, IntPtr InTransforms);

		// Token: 0x060195D0 RID: 103888
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __SetBirdVATState_Internal(IntPtr @this, int BirdIndex, EBirdVATState NewState);

		// Token: 0x060195D1 RID: 103889
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RebuildInstancesFromEditorTransforms_Internal(IntPtr @this);

		// Token: 0x060195D2 RID: 103890
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetBirdState_Internal(IntPtr @this, int BirdIndex, IntPtr OutState);

		// Token: 0x060195D3 RID: 103891
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __BP_OnScaredByPlayer_Internal(IntPtr @this, int BirdIndex);

		// Token: 0x060195D4 RID: 103892
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __BP_OnLanded_Internal(IntPtr @this, int BirdIndex);

		// Token: 0x060195D5 RID: 103893 RVA: 0x00257A12 File Offset: 0x00255C12
		static AKuroBirdInteractionManager()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroBirdInteractionManager");
		}

		// Token: 0x060195D6 RID: 103894 RVA: 0x00257A20 File Offset: 0x00255C20
		protected AKuroBirdInteractionManager(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400DCE4 RID: 56548
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroBirdInteractionManager";

		// Token: 0x0400DCE5 RID: 56549
		private static IntPtr _ClassPtr;

		// Token: 0x0400DCE6 RID: 56550
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400DCE7 RID: 56551
		internal static int __PropertyOffset_EditorBirdTransforms;

		// Token: 0x0400DCE8 RID: 56552
		[Nullable(2)]
		private TArray<FTransform> _EditorBirdTransforms;

		// Token: 0x0400DCE9 RID: 56553
		internal static int __PropertyOffset_bEditorBirdTransformsUseActorLocalSpace;

		// Token: 0x0400DCEA RID: 56554
		internal static int __PropertyOffset_bClearEditorBirdTransformsBeforeConstructionScript;

		// Token: 0x0400DCEB RID: 56555
		internal static int __PropertyOffset_BirdVATStaticMesh;

		// Token: 0x0400DCEC RID: 56556
		internal static int __PropertyOffset_InteractionSphereRadius;

		// Token: 0x0400DCED RID: 56557
		internal static int __PropertyOffset_PlayerIndex;

		// Token: 0x0400DCEE RID: 56558
		internal static int __PropertyOffset_bEnableScareForwardFleeBeforeTakeoff;

		// Token: 0x0400DCEF RID: 56559
		internal static int __PropertyOffset_ScareForwardFleeDistanceMin;

		// Token: 0x0400DCF0 RID: 56560
		internal static int __PropertyOffset_ScareForwardFleeDistanceMax;

		// Token: 0x0400DCF1 RID: 56561
		internal static int __PropertyOffset_ScareForwardHopStepDistance;

		// Token: 0x0400DCF2 RID: 56562
		internal static int __PropertyOffset_ScareForwardHopDuration;

		// Token: 0x0400DCF3 RID: 56563
		internal static int __PropertyOffset_ScareForwardHopHeightMin;

		// Token: 0x0400DCF4 RID: 56564
		internal static int __PropertyOffset_ScareForwardHopHeightMax;

		// Token: 0x0400DCF5 RID: 56565
		internal static int __PropertyOffset_bScareFleeFaceAwayFromPlayer;

		// Token: 0x0400DCF6 RID: 56566
		internal static int __PropertyOffset_ScareFleeTurnDuration;

		// Token: 0x0400DCF7 RID: 56567
		internal static int __PropertyOffset_ScareFleeTurnMinAngleDegrees;

		// Token: 0x0400DCF8 RID: 56568
		internal static int __PropertyOffset_FlySpeed;

		// Token: 0x0400DCF9 RID: 56569
		internal static int __PropertyOffset_InitUpSpeedBase;

		// Token: 0x0400DCFA RID: 56570
		internal static int __PropertyOffset_InitUpSpeedExtraMax;

		// Token: 0x0400DCFB RID: 56571
		internal static int __PropertyOffset_InitTurnSpeedAbs;

		// Token: 0x0400DCFC RID: 56572
		internal static int __PropertyOffset_StopAscentTimeMin;

		// Token: 0x0400DCFD RID: 56573
		internal static int __PropertyOffset_StopAscentTimeMax;

		// Token: 0x0400DCFE RID: 56574
		internal static int __PropertyOffset_HoverTimeMin;

		// Token: 0x0400DCFF RID: 56575
		internal static int __PropertyOffset_HoverTimeMax;

		// Token: 0x0400DD00 RID: 56576
		internal static int __PropertyOffset_GroundShuffleMin;

		// Token: 0x0400DD01 RID: 56577
		internal static int __PropertyOffset_GroundShuffleMax;

		// Token: 0x0400DD02 RID: 56578
		internal static int __PropertyOffset_bEnableIdleRandomHop;

		// Token: 0x0400DD03 RID: 56579
		internal static int __PropertyOffset_IdleHopCheckInterval;

		// Token: 0x0400DD04 RID: 56580
		internal static int __PropertyOffset_IdleHopProbability;

		// Token: 0x0400DD05 RID: 56581
		internal static int __PropertyOffset_IdleHopHeightMin;

		// Token: 0x0400DD06 RID: 56582
		internal static int __PropertyOffset_IdleHopHeightMax;

		// Token: 0x0400DD07 RID: 56583
		internal static int __PropertyOffset_IdleHopDuration;

		// Token: 0x0400DD08 RID: 56584
		internal static int __PropertyOffset_GroundWalkDistancePerCycle;

		// Token: 0x0400DD09 RID: 56585
		internal static int __PropertyOffset_GroundJumpDistancePerCycle;

		// Token: 0x0400DD0A RID: 56586
		internal static int __PropertyOffset_GroundWalkDisplacementTriggerNormalized;

		// Token: 0x0400DD0B RID: 56587
		internal static int __PropertyOffset_GroundJumpDisplacementTriggerNormalized;

		// Token: 0x0400DD0C RID: 56588
		internal static int __PropertyOffset_bGroundWalkJumpContinuousForwardMovement;

		// Token: 0x0400DD0D RID: 56589
		internal static int __PropertyOffset_LandingTraceLength;

		// Token: 0x0400DD0E RID: 56590
		internal static int __PropertyOffset_LandingTraceObjectTypes;

		// Token: 0x0400DD0F RID: 56591
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private TArray<TEnumAsByte<EObjectTypeQuery>> _LandingTraceObjectTypes;

		// Token: 0x0400DD10 RID: 56592
		internal static int __PropertyOffset_LandingGroundDistance;

		// Token: 0x0400DD11 RID: 56593
		internal static int __PropertyOffset_LandingVATLeadDistance;

		// Token: 0x0400DD12 RID: 56594
		internal static int __PropertyOffset_GroundSnapOffset;

		// Token: 0x0400DD13 RID: 56595
		internal static int __PropertyOffset_LandingBoxExtent;

		// Token: 0x0400DD14 RID: 56596
		internal static int __PropertyOffset_FlightClearTime;

		// Token: 0x0400DD15 RID: 56597
		internal static int __PropertyOffset_ReturnToCenterAfterFlightTime;

		// Token: 0x0400DD16 RID: 56598
		internal static int __PropertyOffset_ReturnToCenterSpeed;

		// Token: 0x0400DD17 RID: 56599
		internal static int __PropertyOffset_FlightYawDeltaDegrees;

		// Token: 0x0400DD18 RID: 56600
		internal static int __PropertyOffset_bUseWorldUpForVerticalFlight;

		// Token: 0x0400DD19 RID: 56601
		internal static int __PropertyOffset_MaxFlightHeightAboveSpawn;

		// Token: 0x0400DD1A RID: 56602
		internal static int __PropertyOffset_FlySpeedRandomMin;

		// Token: 0x0400DD1B RID: 56603
		internal static int __PropertyOffset_FlySpeedRandomMax;

		// Token: 0x0400DD1C RID: 56604
		internal static int __PropertyOffset_BirdBodyRadius;

		// Token: 0x0400DD1D RID: 56605
		internal static int __PropertyOffset_GroundSupportTraceLength;

		// Token: 0x0400DD1E RID: 56606
		internal static int __PropertyOffset_GroundedMaxSupportDistance;

		// Token: 0x0400DD1F RID: 56607
		internal static int __PropertyOffset_GroundFallAcceleration;

		// Token: 0x0400DD20 RID: 56608
		internal static int __PropertyOffset_GroundMaxFallSpeed;

		// Token: 0x0400DD21 RID: 56609
		internal static int __PropertyOffset_bRandomizeInitialIdleStartTime;

		// Token: 0x0400DD22 RID: 56610
		internal static int __PropertyOffset_VATBlendWalkToIdleForwardCompensationUU;

		// Token: 0x0400DD23 RID: 56611
		internal static int __PropertyOffset_VATBlendJumpToIdleForwardCompensationUU;

		// Token: 0x0400DD24 RID: 56612
		internal static int __PropertyOffset_StateClips;

		// Token: 0x0400DD25 RID: 56613
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<EBirdVATState, FBirdVATClip> _StateClips;

		// Token: 0x0400DD26 RID: 56614
		internal static int __PropertyOffset_BirdRaysPerFrame;

		// Token: 0x0400DD27 RID: 56615
		internal static int __PropertyOffset_bUseAsyncBirdRays;

		// Token: 0x0400DD28 RID: 56616
		internal static int __PropertyOffset_OnScaredByPlayer;

		// Token: 0x0400DD29 RID: 56617
		[Nullable(2)]
		private FKuroBirdManagerBirdIndexEvent _OnScaredByPlayer;

		// Token: 0x0400DD2A RID: 56618
		internal static int __PropertyOffset_OnLanded;

		// Token: 0x0400DD2B RID: 56619
		[Nullable(2)]
		private FKuroBirdManagerBirdIndexEvent _OnLanded;

		// Token: 0x0400DD2C RID: 56620
		internal static int __PropertyOffset_OnVATStateChanged;

		// Token: 0x0400DD2D RID: 56621
		[Nullable(2)]
		private FKuroBirdVATStateChanged _OnVATStateChanged;

		// Token: 0x0400DD2E RID: 56622
		internal static int __PropertyOffset_BirdISM;

		// Token: 0x02003130 RID: 12592
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __BP_OnScaredByPlayer_FunctionParams
		{
			// Token: 0x04016F40 RID: 94016
			[FieldOffset(0)]
			public int BirdIndex;
		}

		// Token: 0x02003131 RID: 12593
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __BP_OnLanded_FunctionParams
		{
			// Token: 0x04016F41 RID: 94017
			[FieldOffset(0)]
			public int BirdIndex;
		}
	}
}
