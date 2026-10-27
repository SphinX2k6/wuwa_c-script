using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020017C3 RID: 6083
	[UnrealObjectPath("/Script/KuroComputeShader.KuroCSParticle_staticBatchCloth")]
	[UnrealStructLayout(272, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 272)]
	public class FKuroCSParticle_staticBatchCloth : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060163D1 RID: 91089 RVA: 0x00208C70 File Offset: 0x00206E70
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroCSParticle_staticBatchCloth._ScriptStructPtr != 0) ? FKuroCSParticle_staticBatchCloth._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroComputeShader.KuroCSParticle_staticBatchCloth", ref FKuroCSParticle_staticBatchCloth._ScriptStructPtr);
		}

		// Token: 0x17005925 RID: 22821
		// (get) Token: 0x060163D2 RID: 91090 RVA: 0x00208C94 File Offset: 0x00206E94
		// (set) Token: 0x060163D3 RID: 91091 RVA: 0x00208CA8 File Offset: 0x00206EA8
		public unsafe FVector pos
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_staticBatchCloth.__PropertyOffset_pos);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_staticBatchCloth.__PropertyOffset_pos) = value;
			}
		}

		// Token: 0x17005926 RID: 22822
		// (get) Token: 0x060163D4 RID: 91092 RVA: 0x00208CBD File Offset: 0x00206EBD
		// (set) Token: 0x060163D5 RID: 91093 RVA: 0x00208CCD File Offset: 0x00206ECD
		public unsafe int index
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_staticBatchCloth.__PropertyOffset_index);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_staticBatchCloth.__PropertyOffset_index) = value;
			}
		}

		// Token: 0x17005927 RID: 22823
		// (get) Token: 0x060163D6 RID: 91094 RVA: 0x00208CDE File Offset: 0x00206EDE
		// (set) Token: 0x060163D7 RID: 91095 RVA: 0x00208CEE File Offset: 0x00206EEE
		public unsafe int neighbour1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_staticBatchCloth.__PropertyOffset_neighbour1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_staticBatchCloth.__PropertyOffset_neighbour1) = value;
			}
		}

		// Token: 0x17005928 RID: 22824
		// (get) Token: 0x060163D8 RID: 91096 RVA: 0x00208CFF File Offset: 0x00206EFF
		// (set) Token: 0x060163D9 RID: 91097 RVA: 0x00208D0F File Offset: 0x00206F0F
		public unsafe int neighbour2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_staticBatchCloth.__PropertyOffset_neighbour2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_staticBatchCloth.__PropertyOffset_neighbour2) = value;
			}
		}

		// Token: 0x17005929 RID: 22825
		// (get) Token: 0x060163DA RID: 91098 RVA: 0x00208D20 File Offset: 0x00206F20
		// (set) Token: 0x060163DB RID: 91099 RVA: 0x00208D30 File Offset: 0x00206F30
		public unsafe int neighbour3
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_staticBatchCloth.__PropertyOffset_neighbour3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_staticBatchCloth.__PropertyOffset_neighbour3) = value;
			}
		}

		// Token: 0x1700592A RID: 22826
		// (get) Token: 0x060163DC RID: 91100 RVA: 0x00208D41 File Offset: 0x00206F41
		// (set) Token: 0x060163DD RID: 91101 RVA: 0x00208D51 File Offset: 0x00206F51
		public unsafe int neighbour4
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_staticBatchCloth.__PropertyOffset_neighbour4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_staticBatchCloth.__PropertyOffset_neighbour4) = value;
			}
		}

		// Token: 0x1700592B RID: 22827
		// (get) Token: 0x060163DE RID: 91102 RVA: 0x00208D62 File Offset: 0x00206F62
		// (set) Token: 0x060163DF RID: 91103 RVA: 0x00208D76 File Offset: 0x00206F76
		public unsafe FVector pos_bind
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_staticBatchCloth.__PropertyOffset_pos_bind);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_staticBatchCloth.__PropertyOffset_pos_bind) = value;
			}
		}

		// Token: 0x1700592C RID: 22828
		// (get) Token: 0x060163E0 RID: 91104 RVA: 0x00208D8B File Offset: 0x00206F8B
		// (set) Token: 0x060163E1 RID: 91105 RVA: 0x00208D9B File Offset: 0x00206F9B
		public unsafe int neighbour5
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_staticBatchCloth.__PropertyOffset_neighbour5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_staticBatchCloth.__PropertyOffset_neighbour5) = value;
			}
		}

		// Token: 0x1700592D RID: 22829
		// (get) Token: 0x060163E2 RID: 91106 RVA: 0x00208DAC File Offset: 0x00206FAC
		// (set) Token: 0x060163E3 RID: 91107 RVA: 0x00208DC0 File Offset: 0x00206FC0
		public unsafe FVector pos_foe
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_staticBatchCloth.__PropertyOffset_pos_foe);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_staticBatchCloth.__PropertyOffset_pos_foe) = value;
			}
		}

		// Token: 0x1700592E RID: 22830
		// (get) Token: 0x060163E4 RID: 91108 RVA: 0x00208DD5 File Offset: 0x00206FD5
		// (set) Token: 0x060163E5 RID: 91109 RVA: 0x00208DE5 File Offset: 0x00206FE5
		public unsafe int neighbour6
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_staticBatchCloth.__PropertyOffset_neighbour6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_staticBatchCloth.__PropertyOffset_neighbour6) = value;
			}
		}

		// Token: 0x1700592F RID: 22831
		// (get) Token: 0x060163E6 RID: 91110 RVA: 0x00208DF6 File Offset: 0x00206FF6
		// (set) Token: 0x060163E7 RID: 91111 RVA: 0x00208E06 File Offset: 0x00207006
		public unsafe float dis1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_staticBatchCloth.__PropertyOffset_dis1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_staticBatchCloth.__PropertyOffset_dis1) = value;
			}
		}

		// Token: 0x17005930 RID: 22832
		// (get) Token: 0x060163E8 RID: 91112 RVA: 0x00208E17 File Offset: 0x00207017
		// (set) Token: 0x060163E9 RID: 91113 RVA: 0x00208E27 File Offset: 0x00207027
		public unsafe float dis2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_staticBatchCloth.__PropertyOffset_dis2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_staticBatchCloth.__PropertyOffset_dis2) = value;
			}
		}

		// Token: 0x17005931 RID: 22833
		// (get) Token: 0x060163EA RID: 91114 RVA: 0x00208E38 File Offset: 0x00207038
		// (set) Token: 0x060163EB RID: 91115 RVA: 0x00208E48 File Offset: 0x00207048
		public unsafe float dis3
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_staticBatchCloth.__PropertyOffset_dis3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_staticBatchCloth.__PropertyOffset_dis3) = value;
			}
		}

		// Token: 0x17005932 RID: 22834
		// (get) Token: 0x060163EC RID: 91116 RVA: 0x00208E59 File Offset: 0x00207059
		// (set) Token: 0x060163ED RID: 91117 RVA: 0x00208E69 File Offset: 0x00207069
		public unsafe float dis4
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_staticBatchCloth.__PropertyOffset_dis4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_staticBatchCloth.__PropertyOffset_dis4) = value;
			}
		}

		// Token: 0x17005933 RID: 22835
		// (get) Token: 0x060163EE RID: 91118 RVA: 0x00208E7A File Offset: 0x0020707A
		// (set) Token: 0x060163EF RID: 91119 RVA: 0x00208E8A File Offset: 0x0020708A
		public unsafe float dis5
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_staticBatchCloth.__PropertyOffset_dis5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_staticBatchCloth.__PropertyOffset_dis5) = value;
			}
		}

		// Token: 0x17005934 RID: 22836
		// (get) Token: 0x060163F0 RID: 91120 RVA: 0x00208E9B File Offset: 0x0020709B
		// (set) Token: 0x060163F1 RID: 91121 RVA: 0x00208EAB File Offset: 0x002070AB
		public unsafe float dis6
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_staticBatchCloth.__PropertyOffset_dis6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_staticBatchCloth.__PropertyOffset_dis6) = value;
			}
		}

		// Token: 0x17005935 RID: 22837
		// (get) Token: 0x060163F2 RID: 91122 RVA: 0x00208EBC File Offset: 0x002070BC
		// (set) Token: 0x060163F3 RID: 91123 RVA: 0x00208ECC File Offset: 0x002070CC
		public unsafe int neighbour7
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_staticBatchCloth.__PropertyOffset_neighbour7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_staticBatchCloth.__PropertyOffset_neighbour7) = value;
			}
		}

		// Token: 0x17005936 RID: 22838
		// (get) Token: 0x060163F4 RID: 91124 RVA: 0x00208EDD File Offset: 0x002070DD
		// (set) Token: 0x060163F5 RID: 91125 RVA: 0x00208EED File Offset: 0x002070ED
		public unsafe int neighbour8
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_staticBatchCloth.__PropertyOffset_neighbour8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_staticBatchCloth.__PropertyOffset_neighbour8) = value;
			}
		}

		// Token: 0x17005937 RID: 22839
		// (get) Token: 0x060163F6 RID: 91126 RVA: 0x00208EFE File Offset: 0x002070FE
		// (set) Token: 0x060163F7 RID: 91127 RVA: 0x00208F12 File Offset: 0x00207112
		public unsafe FVector vol
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_staticBatchCloth.__PropertyOffset_vol);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_staticBatchCloth.__PropertyOffset_vol) = value;
			}
		}

		// Token: 0x17005938 RID: 22840
		// (get) Token: 0x060163F8 RID: 91128 RVA: 0x00208F27 File Offset: 0x00207127
		// (set) Token: 0x060163F9 RID: 91129 RVA: 0x00208F37 File Offset: 0x00207137
		public unsafe float dis7
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_staticBatchCloth.__PropertyOffset_dis7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_staticBatchCloth.__PropertyOffset_dis7) = value;
			}
		}

		// Token: 0x17005939 RID: 22841
		// (get) Token: 0x060163FA RID: 91130 RVA: 0x00208F48 File Offset: 0x00207148
		// (set) Token: 0x060163FB RID: 91131 RVA: 0x00208F5C File Offset: 0x0020715C
		public unsafe FVector debugFloat3
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_staticBatchCloth.__PropertyOffset_debugFloat3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_staticBatchCloth.__PropertyOffset_debugFloat3) = value;
			}
		}

		// Token: 0x1700593A RID: 22842
		// (get) Token: 0x060163FC RID: 91132 RVA: 0x00208F71 File Offset: 0x00207171
		// (set) Token: 0x060163FD RID: 91133 RVA: 0x00208F81 File Offset: 0x00207181
		public unsafe float dis8
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_staticBatchCloth.__PropertyOffset_dis8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_staticBatchCloth.__PropertyOffset_dis8) = value;
			}
		}

		// Token: 0x1700593B RID: 22843
		// (get) Token: 0x060163FE RID: 91134 RVA: 0x00208F92 File Offset: 0x00207192
		// (set) Token: 0x060163FF RID: 91135 RVA: 0x00208FA6 File Offset: 0x002071A6
		public unsafe FVector myNormal
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_staticBatchCloth.__PropertyOffset_myNormal);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_staticBatchCloth.__PropertyOffset_myNormal) = value;
			}
		}

		// Token: 0x1700593C RID: 22844
		// (get) Token: 0x06016400 RID: 91136 RVA: 0x00208FBB File Offset: 0x002071BB
		// (set) Token: 0x06016401 RID: 91137 RVA: 0x00208FCB File Offset: 0x002071CB
		public unsafe int isPinned
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_staticBatchCloth.__PropertyOffset_isPinned);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_staticBatchCloth.__PropertyOffset_isPinned) = value;
			}
		}

		// Token: 0x1700593D RID: 22845
		// (get) Token: 0x06016402 RID: 91138 RVA: 0x00208FDC File Offset: 0x002071DC
		// (set) Token: 0x06016403 RID: 91139 RVA: 0x00208FEC File Offset: 0x002071EC
		public unsafe float bending_rest_0
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_staticBatchCloth.__PropertyOffset_bending_rest_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_staticBatchCloth.__PropertyOffset_bending_rest_0) = value;
			}
		}

		// Token: 0x1700593E RID: 22846
		// (get) Token: 0x06016404 RID: 91140 RVA: 0x00208FFD File Offset: 0x002071FD
		// (set) Token: 0x06016405 RID: 91141 RVA: 0x0020900D File Offset: 0x0020720D
		public unsafe float bending_rest_1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_staticBatchCloth.__PropertyOffset_bending_rest_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_staticBatchCloth.__PropertyOffset_bending_rest_1) = value;
			}
		}

		// Token: 0x1700593F RID: 22847
		// (get) Token: 0x06016406 RID: 91142 RVA: 0x0020901E File Offset: 0x0020721E
		// (set) Token: 0x06016407 RID: 91143 RVA: 0x0020902E File Offset: 0x0020722E
		public unsafe float bending_rest_2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_staticBatchCloth.__PropertyOffset_bending_rest_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_staticBatchCloth.__PropertyOffset_bending_rest_2) = value;
			}
		}

		// Token: 0x17005940 RID: 22848
		// (get) Token: 0x06016408 RID: 91144 RVA: 0x0020903F File Offset: 0x0020723F
		// (set) Token: 0x06016409 RID: 91145 RVA: 0x0020904F File Offset: 0x0020724F
		public unsafe float bending_rest_3
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_staticBatchCloth.__PropertyOffset_bending_rest_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_staticBatchCloth.__PropertyOffset_bending_rest_3) = value;
			}
		}

		// Token: 0x17005941 RID: 22849
		// (get) Token: 0x0601640A RID: 91146 RVA: 0x00209060 File Offset: 0x00207260
		// (set) Token: 0x0601640B RID: 91147 RVA: 0x00209070 File Offset: 0x00207270
		public unsafe int bending_self_idx_0
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_staticBatchCloth.__PropertyOffset_bending_self_idx_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_staticBatchCloth.__PropertyOffset_bending_self_idx_0) = value;
			}
		}

		// Token: 0x17005942 RID: 22850
		// (get) Token: 0x0601640C RID: 91148 RVA: 0x00209081 File Offset: 0x00207281
		// (set) Token: 0x0601640D RID: 91149 RVA: 0x00209091 File Offset: 0x00207291
		public unsafe int bending_self_idx_1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_staticBatchCloth.__PropertyOffset_bending_self_idx_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_staticBatchCloth.__PropertyOffset_bending_self_idx_1) = value;
			}
		}

		// Token: 0x17005943 RID: 22851
		// (get) Token: 0x0601640E RID: 91150 RVA: 0x002090A2 File Offset: 0x002072A2
		// (set) Token: 0x0601640F RID: 91151 RVA: 0x002090B2 File Offset: 0x002072B2
		public unsafe int bending_self_idx_2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_staticBatchCloth.__PropertyOffset_bending_self_idx_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_staticBatchCloth.__PropertyOffset_bending_self_idx_2) = value;
			}
		}

		// Token: 0x17005944 RID: 22852
		// (get) Token: 0x06016410 RID: 91152 RVA: 0x002090C3 File Offset: 0x002072C3
		// (set) Token: 0x06016411 RID: 91153 RVA: 0x002090D3 File Offset: 0x002072D3
		public unsafe int bending_self_idx_3
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_staticBatchCloth.__PropertyOffset_bending_self_idx_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_staticBatchCloth.__PropertyOffset_bending_self_idx_3) = value;
			}
		}

		// Token: 0x17005945 RID: 22853
		// (get) Token: 0x06016412 RID: 91154 RVA: 0x002090E4 File Offset: 0x002072E4
		// (set) Token: 0x06016413 RID: 91155 RVA: 0x002090F8 File Offset: 0x002072F8
		public unsafe FVector bending_nbs_0
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_staticBatchCloth.__PropertyOffset_bending_nbs_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_staticBatchCloth.__PropertyOffset_bending_nbs_0) = value;
			}
		}

		// Token: 0x17005946 RID: 22854
		// (get) Token: 0x06016414 RID: 91156 RVA: 0x0020910D File Offset: 0x0020730D
		// (set) Token: 0x06016415 RID: 91157 RVA: 0x00209121 File Offset: 0x00207321
		public unsafe FVector bending_nbs_1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_staticBatchCloth.__PropertyOffset_bending_nbs_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_staticBatchCloth.__PropertyOffset_bending_nbs_1) = value;
			}
		}

		// Token: 0x17005947 RID: 22855
		// (get) Token: 0x06016416 RID: 91158 RVA: 0x00209136 File Offset: 0x00207336
		// (set) Token: 0x06016417 RID: 91159 RVA: 0x0020914A File Offset: 0x0020734A
		public unsafe FVector bending_nbs_2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_staticBatchCloth.__PropertyOffset_bending_nbs_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_staticBatchCloth.__PropertyOffset_bending_nbs_2) = value;
			}
		}

		// Token: 0x17005948 RID: 22856
		// (get) Token: 0x06016418 RID: 91160 RVA: 0x0020915F File Offset: 0x0020735F
		// (set) Token: 0x06016419 RID: 91161 RVA: 0x00209173 File Offset: 0x00207373
		public unsafe FVector bending_nbs_3
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_staticBatchCloth.__PropertyOffset_bending_nbs_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_staticBatchCloth.__PropertyOffset_bending_nbs_3) = value;
			}
		}

		// Token: 0x17005949 RID: 22857
		// (get) Token: 0x0601641A RID: 91162 RVA: 0x00209188 File Offset: 0x00207388
		// (set) Token: 0x0601641B RID: 91163 RVA: 0x0020919C File Offset: 0x0020739C
		public unsafe FVector pos_beforeStage
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_staticBatchCloth.__PropertyOffset_pos_beforeStage);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_staticBatchCloth.__PropertyOffset_pos_beforeStage) = value;
			}
		}

		// Token: 0x1700594A RID: 22858
		// (get) Token: 0x0601641C RID: 91164 RVA: 0x002091B1 File Offset: 0x002073B1
		// (set) Token: 0x0601641D RID: 91165 RVA: 0x002091C1 File Offset: 0x002073C1
		public unsafe int deadNode
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_staticBatchCloth.__PropertyOffset_deadNode);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_staticBatchCloth.__PropertyOffset_deadNode) = value;
			}
		}

		// Token: 0x1700594B RID: 22859
		// (get) Token: 0x0601641E RID: 91166 RVA: 0x002091D2 File Offset: 0x002073D2
		// (set) Token: 0x0601641F RID: 91167 RVA: 0x002091E2 File Offset: 0x002073E2
		public unsafe int clothID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_staticBatchCloth.__PropertyOffset_clothID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_staticBatchCloth.__PropertyOffset_clothID) = value;
			}
		}

		// Token: 0x06016420 RID: 91168 RVA: 0x002091F3 File Offset: 0x002073F3
		public FKuroCSParticle_staticBatchCloth()
		{
		}

		// Token: 0x06016421 RID: 91169 RVA: 0x002091FC File Offset: 0x002073FC
		public FKuroCSParticle_staticBatchCloth(FVector pos, int index, int neighbour1, int neighbour2, int neighbour3, int neighbour4, FVector pos_bind, int neighbour5, FVector pos_foe, int neighbour6, float dis1, float dis2, float dis3, float dis4, float dis5, float dis6, int neighbour7, int neighbour8, FVector vol, float dis7, FVector debugFloat3, float dis8, FVector myNormal, int isPinned, float bending_rest_0, float bending_rest_1, float bending_rest_2, float bending_rest_3, int bending_self_idx_0, int bending_self_idx_1, int bending_self_idx_2, int bending_self_idx_3, FVector bending_nbs_0, FVector bending_nbs_1, FVector bending_nbs_2, FVector bending_nbs_3, FVector pos_beforeStage, int deadNode, int clothID)
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
			this.debugFloat3 = debugFloat3;
			this.dis8 = dis8;
			this.myNormal = myNormal;
			this.isPinned = isPinned;
			this.bending_rest_0 = bending_rest_0;
			this.bending_rest_1 = bending_rest_1;
			this.bending_rest_2 = bending_rest_2;
			this.bending_rest_3 = bending_rest_3;
			this.bending_self_idx_0 = bending_self_idx_0;
			this.bending_self_idx_1 = bending_self_idx_1;
			this.bending_self_idx_2 = bending_self_idx_2;
			this.bending_self_idx_3 = bending_self_idx_3;
			this.bending_nbs_0 = bending_nbs_0;
			this.bending_nbs_1 = bending_nbs_1;
			this.bending_nbs_2 = bending_nbs_2;
			this.bending_nbs_3 = bending_nbs_3;
			this.pos_beforeStage = pos_beforeStage;
			this.deadNode = deadNode;
			this.clothID = clothID;
		}

		// Token: 0x06016422 RID: 91170 RVA: 0x00209344 File Offset: 0x00207544
		protected override IntPtr GetUStructPtr()
		{
			return FKuroCSParticle_staticBatchCloth.StaticStruct();
		}

		// Token: 0x06016423 RID: 91171 RVA: 0x00209350 File Offset: 0x00207550
		[NullableContext(2)]
		public FKuroCSParticle_staticBatchCloth(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06016424 RID: 91172 RVA: 0x0020935A File Offset: 0x0020755A
		public FKuroCSParticle_staticBatchCloth(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06016425 RID: 91173 RVA: 0x00209365 File Offset: 0x00207565
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroCSParticle_staticBatchCloth(Pointer, false, true);
		}

		// Token: 0x06016426 RID: 91174 RVA: 0x0020936F File Offset: 0x0020756F
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroCSParticle_staticBatchCloth(Pointer, MemoryOwner);
		}

		// Token: 0x0400C190 RID: 49552
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroComputeShader.KuroCSParticle_staticBatchCloth";

		// Token: 0x0400C191 RID: 49553
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400C192 RID: 49554
		internal static int __PropertyOffset_pos;

		// Token: 0x0400C193 RID: 49555
		internal static int __PropertyOffset_index;

		// Token: 0x0400C194 RID: 49556
		internal static int __PropertyOffset_neighbour1;

		// Token: 0x0400C195 RID: 49557
		internal static int __PropertyOffset_neighbour2;

		// Token: 0x0400C196 RID: 49558
		internal static int __PropertyOffset_neighbour3;

		// Token: 0x0400C197 RID: 49559
		internal static int __PropertyOffset_neighbour4;

		// Token: 0x0400C198 RID: 49560
		internal static int __PropertyOffset_pos_bind;

		// Token: 0x0400C199 RID: 49561
		internal static int __PropertyOffset_neighbour5;

		// Token: 0x0400C19A RID: 49562
		internal static int __PropertyOffset_pos_foe;

		// Token: 0x0400C19B RID: 49563
		internal static int __PropertyOffset_neighbour6;

		// Token: 0x0400C19C RID: 49564
		internal static int __PropertyOffset_dis1;

		// Token: 0x0400C19D RID: 49565
		internal static int __PropertyOffset_dis2;

		// Token: 0x0400C19E RID: 49566
		internal static int __PropertyOffset_dis3;

		// Token: 0x0400C19F RID: 49567
		internal static int __PropertyOffset_dis4;

		// Token: 0x0400C1A0 RID: 49568
		internal static int __PropertyOffset_dis5;

		// Token: 0x0400C1A1 RID: 49569
		internal static int __PropertyOffset_dis6;

		// Token: 0x0400C1A2 RID: 49570
		internal static int __PropertyOffset_neighbour7;

		// Token: 0x0400C1A3 RID: 49571
		internal static int __PropertyOffset_neighbour8;

		// Token: 0x0400C1A4 RID: 49572
		internal static int __PropertyOffset_vol;

		// Token: 0x0400C1A5 RID: 49573
		internal static int __PropertyOffset_dis7;

		// Token: 0x0400C1A6 RID: 49574
		internal static int __PropertyOffset_debugFloat3;

		// Token: 0x0400C1A7 RID: 49575
		internal static int __PropertyOffset_dis8;

		// Token: 0x0400C1A8 RID: 49576
		internal static int __PropertyOffset_myNormal;

		// Token: 0x0400C1A9 RID: 49577
		internal static int __PropertyOffset_isPinned;

		// Token: 0x0400C1AA RID: 49578
		internal static int __PropertyOffset_bending_rest_0;

		// Token: 0x0400C1AB RID: 49579
		internal static int __PropertyOffset_bending_rest_1;

		// Token: 0x0400C1AC RID: 49580
		internal static int __PropertyOffset_bending_rest_2;

		// Token: 0x0400C1AD RID: 49581
		internal static int __PropertyOffset_bending_rest_3;

		// Token: 0x0400C1AE RID: 49582
		internal static int __PropertyOffset_bending_self_idx_0;

		// Token: 0x0400C1AF RID: 49583
		internal static int __PropertyOffset_bending_self_idx_1;

		// Token: 0x0400C1B0 RID: 49584
		internal static int __PropertyOffset_bending_self_idx_2;

		// Token: 0x0400C1B1 RID: 49585
		internal static int __PropertyOffset_bending_self_idx_3;

		// Token: 0x0400C1B2 RID: 49586
		internal static int __PropertyOffset_bending_nbs_0;

		// Token: 0x0400C1B3 RID: 49587
		internal static int __PropertyOffset_bending_nbs_1;

		// Token: 0x0400C1B4 RID: 49588
		internal static int __PropertyOffset_bending_nbs_2;

		// Token: 0x0400C1B5 RID: 49589
		internal static int __PropertyOffset_bending_nbs_3;

		// Token: 0x0400C1B6 RID: 49590
		internal static int __PropertyOffset_pos_beforeStage;

		// Token: 0x0400C1B7 RID: 49591
		internal static int __PropertyOffset_deadNode;

		// Token: 0x0400C1B8 RID: 49592
		internal static int __PropertyOffset_clothID;
	}
}
