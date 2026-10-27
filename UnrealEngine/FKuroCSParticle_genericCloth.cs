using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020017BC RID: 6076
	[UnrealObjectPath("/Script/KuroComputeShader.KuroCSParticle_genericCloth")]
	[UnrealStructLayout(192, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 192)]
	public class FKuroCSParticle_genericCloth : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601624F RID: 90703 RVA: 0x00206D54 File Offset: 0x00204F54
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroCSParticle_genericCloth._ScriptStructPtr != 0) ? FKuroCSParticle_genericCloth._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroComputeShader.KuroCSParticle_genericCloth", ref FKuroCSParticle_genericCloth._ScriptStructPtr);
		}

		// Token: 0x17005880 RID: 22656
		// (get) Token: 0x06016250 RID: 90704 RVA: 0x00206D78 File Offset: 0x00204F78
		// (set) Token: 0x06016251 RID: 90705 RVA: 0x00206D8C File Offset: 0x00204F8C
		public unsafe FVector pos
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_genericCloth.__PropertyOffset_pos);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_genericCloth.__PropertyOffset_pos) = value;
			}
		}

		// Token: 0x17005881 RID: 22657
		// (get) Token: 0x06016252 RID: 90706 RVA: 0x00206DA1 File Offset: 0x00204FA1
		// (set) Token: 0x06016253 RID: 90707 RVA: 0x00206DB1 File Offset: 0x00204FB1
		public unsafe int index
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_genericCloth.__PropertyOffset_index);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_genericCloth.__PropertyOffset_index) = value;
			}
		}

		// Token: 0x17005882 RID: 22658
		// (get) Token: 0x06016254 RID: 90708 RVA: 0x00206DC2 File Offset: 0x00204FC2
		// (set) Token: 0x06016255 RID: 90709 RVA: 0x00206DD2 File Offset: 0x00204FD2
		public unsafe int neighbour1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_genericCloth.__PropertyOffset_neighbour1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_genericCloth.__PropertyOffset_neighbour1) = value;
			}
		}

		// Token: 0x17005883 RID: 22659
		// (get) Token: 0x06016256 RID: 90710 RVA: 0x00206DE3 File Offset: 0x00204FE3
		// (set) Token: 0x06016257 RID: 90711 RVA: 0x00206DF3 File Offset: 0x00204FF3
		public unsafe int neighbour2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_genericCloth.__PropertyOffset_neighbour2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_genericCloth.__PropertyOffset_neighbour2) = value;
			}
		}

		// Token: 0x17005884 RID: 22660
		// (get) Token: 0x06016258 RID: 90712 RVA: 0x00206E04 File Offset: 0x00205004
		// (set) Token: 0x06016259 RID: 90713 RVA: 0x00206E14 File Offset: 0x00205014
		public unsafe int neighbour3
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_genericCloth.__PropertyOffset_neighbour3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_genericCloth.__PropertyOffset_neighbour3) = value;
			}
		}

		// Token: 0x17005885 RID: 22661
		// (get) Token: 0x0601625A RID: 90714 RVA: 0x00206E25 File Offset: 0x00205025
		// (set) Token: 0x0601625B RID: 90715 RVA: 0x00206E35 File Offset: 0x00205035
		public unsafe int neighbour4
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_genericCloth.__PropertyOffset_neighbour4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_genericCloth.__PropertyOffset_neighbour4) = value;
			}
		}

		// Token: 0x17005886 RID: 22662
		// (get) Token: 0x0601625C RID: 90716 RVA: 0x00206E46 File Offset: 0x00205046
		// (set) Token: 0x0601625D RID: 90717 RVA: 0x00206E5A File Offset: 0x0020505A
		public unsafe FVector pos_bind
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_genericCloth.__PropertyOffset_pos_bind);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_genericCloth.__PropertyOffset_pos_bind) = value;
			}
		}

		// Token: 0x17005887 RID: 22663
		// (get) Token: 0x0601625E RID: 90718 RVA: 0x00206E6F File Offset: 0x0020506F
		// (set) Token: 0x0601625F RID: 90719 RVA: 0x00206E7F File Offset: 0x0020507F
		public unsafe int neighbour5
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_genericCloth.__PropertyOffset_neighbour5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_genericCloth.__PropertyOffset_neighbour5) = value;
			}
		}

		// Token: 0x17005888 RID: 22664
		// (get) Token: 0x06016260 RID: 90720 RVA: 0x00206E90 File Offset: 0x00205090
		// (set) Token: 0x06016261 RID: 90721 RVA: 0x00206EA4 File Offset: 0x002050A4
		public unsafe FVector pos_foe
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_genericCloth.__PropertyOffset_pos_foe);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_genericCloth.__PropertyOffset_pos_foe) = value;
			}
		}

		// Token: 0x17005889 RID: 22665
		// (get) Token: 0x06016262 RID: 90722 RVA: 0x00206EB9 File Offset: 0x002050B9
		// (set) Token: 0x06016263 RID: 90723 RVA: 0x00206EC9 File Offset: 0x002050C9
		public unsafe int neighbour6
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_genericCloth.__PropertyOffset_neighbour6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_genericCloth.__PropertyOffset_neighbour6) = value;
			}
		}

		// Token: 0x1700588A RID: 22666
		// (get) Token: 0x06016264 RID: 90724 RVA: 0x00206EDA File Offset: 0x002050DA
		// (set) Token: 0x06016265 RID: 90725 RVA: 0x00206EEA File Offset: 0x002050EA
		public unsafe float dis1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_genericCloth.__PropertyOffset_dis1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_genericCloth.__PropertyOffset_dis1) = value;
			}
		}

		// Token: 0x1700588B RID: 22667
		// (get) Token: 0x06016266 RID: 90726 RVA: 0x00206EFB File Offset: 0x002050FB
		// (set) Token: 0x06016267 RID: 90727 RVA: 0x00206F0B File Offset: 0x0020510B
		public unsafe float dis2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_genericCloth.__PropertyOffset_dis2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_genericCloth.__PropertyOffset_dis2) = value;
			}
		}

		// Token: 0x1700588C RID: 22668
		// (get) Token: 0x06016268 RID: 90728 RVA: 0x00206F1C File Offset: 0x0020511C
		// (set) Token: 0x06016269 RID: 90729 RVA: 0x00206F2C File Offset: 0x0020512C
		public unsafe float dis3
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_genericCloth.__PropertyOffset_dis3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_genericCloth.__PropertyOffset_dis3) = value;
			}
		}

		// Token: 0x1700588D RID: 22669
		// (get) Token: 0x0601626A RID: 90730 RVA: 0x00206F3D File Offset: 0x0020513D
		// (set) Token: 0x0601626B RID: 90731 RVA: 0x00206F4D File Offset: 0x0020514D
		public unsafe float dis4
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_genericCloth.__PropertyOffset_dis4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_genericCloth.__PropertyOffset_dis4) = value;
			}
		}

		// Token: 0x1700588E RID: 22670
		// (get) Token: 0x0601626C RID: 90732 RVA: 0x00206F5E File Offset: 0x0020515E
		// (set) Token: 0x0601626D RID: 90733 RVA: 0x00206F6E File Offset: 0x0020516E
		public unsafe float dis5
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_genericCloth.__PropertyOffset_dis5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_genericCloth.__PropertyOffset_dis5) = value;
			}
		}

		// Token: 0x1700588F RID: 22671
		// (get) Token: 0x0601626E RID: 90734 RVA: 0x00206F7F File Offset: 0x0020517F
		// (set) Token: 0x0601626F RID: 90735 RVA: 0x00206F8F File Offset: 0x0020518F
		public unsafe float dis6
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_genericCloth.__PropertyOffset_dis6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_genericCloth.__PropertyOffset_dis6) = value;
			}
		}

		// Token: 0x17005890 RID: 22672
		// (get) Token: 0x06016270 RID: 90736 RVA: 0x00206FA0 File Offset: 0x002051A0
		// (set) Token: 0x06016271 RID: 90737 RVA: 0x00206FB0 File Offset: 0x002051B0
		public unsafe int neighbour7
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_genericCloth.__PropertyOffset_neighbour7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_genericCloth.__PropertyOffset_neighbour7) = value;
			}
		}

		// Token: 0x17005891 RID: 22673
		// (get) Token: 0x06016272 RID: 90738 RVA: 0x00206FC1 File Offset: 0x002051C1
		// (set) Token: 0x06016273 RID: 90739 RVA: 0x00206FD1 File Offset: 0x002051D1
		public unsafe int neighbour8
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_genericCloth.__PropertyOffset_neighbour8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_genericCloth.__PropertyOffset_neighbour8) = value;
			}
		}

		// Token: 0x17005892 RID: 22674
		// (get) Token: 0x06016274 RID: 90740 RVA: 0x00206FE2 File Offset: 0x002051E2
		// (set) Token: 0x06016275 RID: 90741 RVA: 0x00206FF6 File Offset: 0x002051F6
		public unsafe FVector vol
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_genericCloth.__PropertyOffset_vol);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_genericCloth.__PropertyOffset_vol) = value;
			}
		}

		// Token: 0x17005893 RID: 22675
		// (get) Token: 0x06016276 RID: 90742 RVA: 0x0020700B File Offset: 0x0020520B
		// (set) Token: 0x06016277 RID: 90743 RVA: 0x0020701B File Offset: 0x0020521B
		public unsafe float dis7
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_genericCloth.__PropertyOffset_dis7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_genericCloth.__PropertyOffset_dis7) = value;
			}
		}

		// Token: 0x17005894 RID: 22676
		// (get) Token: 0x06016278 RID: 90744 RVA: 0x0020702C File Offset: 0x0020522C
		// (set) Token: 0x06016279 RID: 90745 RVA: 0x00207040 File Offset: 0x00205240
		public unsafe FVector pos_before_rotate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_genericCloth.__PropertyOffset_pos_before_rotate);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_genericCloth.__PropertyOffset_pos_before_rotate) = value;
			}
		}

		// Token: 0x17005895 RID: 22677
		// (get) Token: 0x0601627A RID: 90746 RVA: 0x00207055 File Offset: 0x00205255
		// (set) Token: 0x0601627B RID: 90747 RVA: 0x00207065 File Offset: 0x00205265
		public unsafe float dis8
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_genericCloth.__PropertyOffset_dis8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_genericCloth.__PropertyOffset_dis8) = value;
			}
		}

		// Token: 0x17005896 RID: 22678
		// (get) Token: 0x0601627C RID: 90748 RVA: 0x00207076 File Offset: 0x00205276
		// (set) Token: 0x0601627D RID: 90749 RVA: 0x0020708A File Offset: 0x0020528A
		public unsafe FVector myNormal
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_genericCloth.__PropertyOffset_myNormal);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_genericCloth.__PropertyOffset_myNormal) = value;
			}
		}

		// Token: 0x17005897 RID: 22679
		// (get) Token: 0x0601627E RID: 90750 RVA: 0x0020709F File Offset: 0x0020529F
		// (set) Token: 0x0601627F RID: 90751 RVA: 0x002070AF File Offset: 0x002052AF
		public unsafe int isPinned
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_genericCloth.__PropertyOffset_isPinned);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_genericCloth.__PropertyOffset_isPinned) = value;
			}
		}

		// Token: 0x17005898 RID: 22680
		// (get) Token: 0x06016280 RID: 90752 RVA: 0x002070C0 File Offset: 0x002052C0
		// (set) Token: 0x06016281 RID: 90753 RVA: 0x002070D0 File Offset: 0x002052D0
		public unsafe float bend1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_genericCloth.__PropertyOffset_bend1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_genericCloth.__PropertyOffset_bend1) = value;
			}
		}

		// Token: 0x17005899 RID: 22681
		// (get) Token: 0x06016282 RID: 90754 RVA: 0x002070E1 File Offset: 0x002052E1
		// (set) Token: 0x06016283 RID: 90755 RVA: 0x002070F1 File Offset: 0x002052F1
		public unsafe float bend2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_genericCloth.__PropertyOffset_bend2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_genericCloth.__PropertyOffset_bend2) = value;
			}
		}

		// Token: 0x1700589A RID: 22682
		// (get) Token: 0x06016284 RID: 90756 RVA: 0x00207102 File Offset: 0x00205302
		// (set) Token: 0x06016285 RID: 90757 RVA: 0x00207112 File Offset: 0x00205312
		public unsafe float bend3
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_genericCloth.__PropertyOffset_bend3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_genericCloth.__PropertyOffset_bend3) = value;
			}
		}

		// Token: 0x1700589B RID: 22683
		// (get) Token: 0x06016286 RID: 90758 RVA: 0x00207123 File Offset: 0x00205323
		// (set) Token: 0x06016287 RID: 90759 RVA: 0x00207133 File Offset: 0x00205333
		public unsafe float bend4
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_genericCloth.__PropertyOffset_bend4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_genericCloth.__PropertyOffset_bend4) = value;
			}
		}

		// Token: 0x1700589C RID: 22684
		// (get) Token: 0x06016288 RID: 90760 RVA: 0x00207144 File Offset: 0x00205344
		// (set) Token: 0x06016289 RID: 90761 RVA: 0x00207154 File Offset: 0x00205354
		public unsafe float bend5
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_genericCloth.__PropertyOffset_bend5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_genericCloth.__PropertyOffset_bend5) = value;
			}
		}

		// Token: 0x1700589D RID: 22685
		// (get) Token: 0x0601628A RID: 90762 RVA: 0x00207165 File Offset: 0x00205365
		// (set) Token: 0x0601628B RID: 90763 RVA: 0x00207175 File Offset: 0x00205375
		public unsafe float bend6
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_genericCloth.__PropertyOffset_bend6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_genericCloth.__PropertyOffset_bend6) = value;
			}
		}

		// Token: 0x1700589E RID: 22686
		// (get) Token: 0x0601628C RID: 90764 RVA: 0x00207186 File Offset: 0x00205386
		// (set) Token: 0x0601628D RID: 90765 RVA: 0x00207196 File Offset: 0x00205396
		public unsafe float bend7
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_genericCloth.__PropertyOffset_bend7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_genericCloth.__PropertyOffset_bend7) = value;
			}
		}

		// Token: 0x1700589F RID: 22687
		// (get) Token: 0x0601628E RID: 90766 RVA: 0x002071A7 File Offset: 0x002053A7
		// (set) Token: 0x0601628F RID: 90767 RVA: 0x002071B7 File Offset: 0x002053B7
		public unsafe float bend8
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_genericCloth.__PropertyOffset_bend8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_genericCloth.__PropertyOffset_bend8) = value;
			}
		}

		// Token: 0x170058A0 RID: 22688
		// (get) Token: 0x06016290 RID: 90768 RVA: 0x002071C8 File Offset: 0x002053C8
		// (set) Token: 0x06016291 RID: 90769 RVA: 0x002071DC File Offset: 0x002053DC
		public unsafe FVector pos_beforeStage
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_genericCloth.__PropertyOffset_pos_beforeStage);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_genericCloth.__PropertyOffset_pos_beforeStage) = value;
			}
		}

		// Token: 0x06016292 RID: 90770 RVA: 0x002071F1 File Offset: 0x002053F1
		public FKuroCSParticle_genericCloth()
		{
		}

		// Token: 0x06016293 RID: 90771 RVA: 0x002071FC File Offset: 0x002053FC
		public FKuroCSParticle_genericCloth(FVector pos, int index, int neighbour1, int neighbour2, int neighbour3, int neighbour4, FVector pos_bind, int neighbour5, FVector pos_foe, int neighbour6, float dis1, float dis2, float dis3, float dis4, float dis5, float dis6, int neighbour7, int neighbour8, FVector vol, float dis7, FVector pos_before_rotate, float dis8, FVector myNormal, int isPinned, float bend1, float bend2, float bend3, float bend4, float bend5, float bend6, float bend7, float bend8, FVector pos_beforeStage)
		{
			this.pos = pos;
			this.index = index;
			this.neighbour1 = neighbour1;
			this.neighbour2 = neighbour2;
			this.neighbour3 = neighbour3;
			this.neighbour4 = neighbour4;
			this.pos_bind = pos_bind;
			this.neighbour5 = neighbour5;
			this.pos_foe = pos_foe;
			this.neighbour6 = neighbour6;
			this.dis1 = dis1;
			this.dis2 = dis2;
			this.dis3 = dis3;
			this.dis4 = dis4;
			this.dis5 = dis5;
			this.dis6 = dis6;
			this.neighbour7 = neighbour7;
			this.neighbour8 = neighbour8;
			this.vol = vol;
			this.dis7 = dis7;
			this.pos_before_rotate = pos_before_rotate;
			this.dis8 = dis8;
			this.myNormal = myNormal;
			this.isPinned = isPinned;
			this.bend1 = bend1;
			this.bend2 = bend2;
			this.bend3 = bend3;
			this.bend4 = bend4;
			this.bend5 = bend5;
			this.bend6 = bend6;
			this.bend7 = bend7;
			this.bend8 = bend8;
			this.pos_beforeStage = pos_beforeStage;
		}

		// Token: 0x06016294 RID: 90772 RVA: 0x00207314 File Offset: 0x00205514
		protected override IntPtr GetUStructPtr()
		{
			return FKuroCSParticle_genericCloth.StaticStruct();
		}

		// Token: 0x06016295 RID: 90773 RVA: 0x00207320 File Offset: 0x00205520
		[NullableContext(2)]
		public FKuroCSParticle_genericCloth(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06016296 RID: 90774 RVA: 0x0020732A File Offset: 0x0020552A
		public FKuroCSParticle_genericCloth(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06016297 RID: 90775 RVA: 0x00207335 File Offset: 0x00205535
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroCSParticle_genericCloth(Pointer, false, true);
		}

		// Token: 0x06016298 RID: 90776 RVA: 0x0020733F File Offset: 0x0020553F
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroCSParticle_genericCloth(Pointer, MemoryOwner);
		}

		// Token: 0x0400C0DD RID: 49373
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroComputeShader.KuroCSParticle_genericCloth";

		// Token: 0x0400C0DE RID: 49374
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400C0DF RID: 49375
		internal static int __PropertyOffset_pos;

		// Token: 0x0400C0E0 RID: 49376
		internal static int __PropertyOffset_index;

		// Token: 0x0400C0E1 RID: 49377
		internal static int __PropertyOffset_neighbour1;

		// Token: 0x0400C0E2 RID: 49378
		internal static int __PropertyOffset_neighbour2;

		// Token: 0x0400C0E3 RID: 49379
		internal static int __PropertyOffset_neighbour3;

		// Token: 0x0400C0E4 RID: 49380
		internal static int __PropertyOffset_neighbour4;

		// Token: 0x0400C0E5 RID: 49381
		internal static int __PropertyOffset_pos_bind;

		// Token: 0x0400C0E6 RID: 49382
		internal static int __PropertyOffset_neighbour5;

		// Token: 0x0400C0E7 RID: 49383
		internal static int __PropertyOffset_pos_foe;

		// Token: 0x0400C0E8 RID: 49384
		internal static int __PropertyOffset_neighbour6;

		// Token: 0x0400C0E9 RID: 49385
		internal static int __PropertyOffset_dis1;

		// Token: 0x0400C0EA RID: 49386
		internal static int __PropertyOffset_dis2;

		// Token: 0x0400C0EB RID: 49387
		internal static int __PropertyOffset_dis3;

		// Token: 0x0400C0EC RID: 49388
		internal static int __PropertyOffset_dis4;

		// Token: 0x0400C0ED RID: 49389
		internal static int __PropertyOffset_dis5;

		// Token: 0x0400C0EE RID: 49390
		internal static int __PropertyOffset_dis6;

		// Token: 0x0400C0EF RID: 49391
		internal static int __PropertyOffset_neighbour7;

		// Token: 0x0400C0F0 RID: 49392
		internal static int __PropertyOffset_neighbour8;

		// Token: 0x0400C0F1 RID: 49393
		internal static int __PropertyOffset_vol;

		// Token: 0x0400C0F2 RID: 49394
		internal static int __PropertyOffset_dis7;

		// Token: 0x0400C0F3 RID: 49395
		internal static int __PropertyOffset_pos_before_rotate;

		// Token: 0x0400C0F4 RID: 49396
		internal static int __PropertyOffset_dis8;

		// Token: 0x0400C0F5 RID: 49397
		internal static int __PropertyOffset_myNormal;

		// Token: 0x0400C0F6 RID: 49398
		internal static int __PropertyOffset_isPinned;

		// Token: 0x0400C0F7 RID: 49399
		internal static int __PropertyOffset_bend1;

		// Token: 0x0400C0F8 RID: 49400
		internal static int __PropertyOffset_bend2;

		// Token: 0x0400C0F9 RID: 49401
		internal static int __PropertyOffset_bend3;

		// Token: 0x0400C0FA RID: 49402
		internal static int __PropertyOffset_bend4;

		// Token: 0x0400C0FB RID: 49403
		internal static int __PropertyOffset_bend5;

		// Token: 0x0400C0FC RID: 49404
		internal static int __PropertyOffset_bend6;

		// Token: 0x0400C0FD RID: 49405
		internal static int __PropertyOffset_bend7;

		// Token: 0x0400C0FE RID: 49406
		internal static int __PropertyOffset_bend8;

		// Token: 0x0400C0FF RID: 49407
		internal static int __PropertyOffset_pos_beforeStage;
	}
}
