using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020017BE RID: 6078
	[UnrealObjectPath("/Script/KuroComputeShader.KuroCSParticle_jacobiCloth")]
	[UnrealStructLayout(272, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 272)]
	public class FKuroCSParticle_jacobiCloth : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060162ED RID: 90861 RVA: 0x00207A28 File Offset: 0x00205C28
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroCSParticle_jacobiCloth._ScriptStructPtr != 0) ? FKuroCSParticle_jacobiCloth._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroComputeShader.KuroCSParticle_jacobiCloth", ref FKuroCSParticle_jacobiCloth._ScriptStructPtr);
		}

		// Token: 0x170058C7 RID: 22727
		// (get) Token: 0x060162EE RID: 90862 RVA: 0x00207A4C File Offset: 0x00205C4C
		// (set) Token: 0x060162EF RID: 90863 RVA: 0x00207A60 File Offset: 0x00205C60
		public unsafe FVector pos
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_jacobiCloth.__PropertyOffset_pos);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_jacobiCloth.__PropertyOffset_pos) = value;
			}
		}

		// Token: 0x170058C8 RID: 22728
		// (get) Token: 0x060162F0 RID: 90864 RVA: 0x00207A75 File Offset: 0x00205C75
		// (set) Token: 0x060162F1 RID: 90865 RVA: 0x00207A85 File Offset: 0x00205C85
		public unsafe int index
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_jacobiCloth.__PropertyOffset_index);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_jacobiCloth.__PropertyOffset_index) = value;
			}
		}

		// Token: 0x170058C9 RID: 22729
		// (get) Token: 0x060162F2 RID: 90866 RVA: 0x00207A96 File Offset: 0x00205C96
		// (set) Token: 0x060162F3 RID: 90867 RVA: 0x00207AA6 File Offset: 0x00205CA6
		public unsafe int neighbour1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_jacobiCloth.__PropertyOffset_neighbour1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_jacobiCloth.__PropertyOffset_neighbour1) = value;
			}
		}

		// Token: 0x170058CA RID: 22730
		// (get) Token: 0x060162F4 RID: 90868 RVA: 0x00207AB7 File Offset: 0x00205CB7
		// (set) Token: 0x060162F5 RID: 90869 RVA: 0x00207AC7 File Offset: 0x00205CC7
		public unsafe int neighbour2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_jacobiCloth.__PropertyOffset_neighbour2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_jacobiCloth.__PropertyOffset_neighbour2) = value;
			}
		}

		// Token: 0x170058CB RID: 22731
		// (get) Token: 0x060162F6 RID: 90870 RVA: 0x00207AD8 File Offset: 0x00205CD8
		// (set) Token: 0x060162F7 RID: 90871 RVA: 0x00207AE8 File Offset: 0x00205CE8
		public unsafe int neighbour3
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_jacobiCloth.__PropertyOffset_neighbour3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_jacobiCloth.__PropertyOffset_neighbour3) = value;
			}
		}

		// Token: 0x170058CC RID: 22732
		// (get) Token: 0x060162F8 RID: 90872 RVA: 0x00207AF9 File Offset: 0x00205CF9
		// (set) Token: 0x060162F9 RID: 90873 RVA: 0x00207B09 File Offset: 0x00205D09
		public unsafe int neighbour4
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_jacobiCloth.__PropertyOffset_neighbour4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_jacobiCloth.__PropertyOffset_neighbour4) = value;
			}
		}

		// Token: 0x170058CD RID: 22733
		// (get) Token: 0x060162FA RID: 90874 RVA: 0x00207B1A File Offset: 0x00205D1A
		// (set) Token: 0x060162FB RID: 90875 RVA: 0x00207B2E File Offset: 0x00205D2E
		public unsafe FVector pos_bind
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_jacobiCloth.__PropertyOffset_pos_bind);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_jacobiCloth.__PropertyOffset_pos_bind) = value;
			}
		}

		// Token: 0x170058CE RID: 22734
		// (get) Token: 0x060162FC RID: 90876 RVA: 0x00207B43 File Offset: 0x00205D43
		// (set) Token: 0x060162FD RID: 90877 RVA: 0x00207B53 File Offset: 0x00205D53
		public unsafe int neighbour5
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_jacobiCloth.__PropertyOffset_neighbour5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_jacobiCloth.__PropertyOffset_neighbour5) = value;
			}
		}

		// Token: 0x170058CF RID: 22735
		// (get) Token: 0x060162FE RID: 90878 RVA: 0x00207B64 File Offset: 0x00205D64
		// (set) Token: 0x060162FF RID: 90879 RVA: 0x00207B78 File Offset: 0x00205D78
		public unsafe FVector pos_foe
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_jacobiCloth.__PropertyOffset_pos_foe);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_jacobiCloth.__PropertyOffset_pos_foe) = value;
			}
		}

		// Token: 0x170058D0 RID: 22736
		// (get) Token: 0x06016300 RID: 90880 RVA: 0x00207B8D File Offset: 0x00205D8D
		// (set) Token: 0x06016301 RID: 90881 RVA: 0x00207B9D File Offset: 0x00205D9D
		public unsafe int neighbour6
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_jacobiCloth.__PropertyOffset_neighbour6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_jacobiCloth.__PropertyOffset_neighbour6) = value;
			}
		}

		// Token: 0x170058D1 RID: 22737
		// (get) Token: 0x06016302 RID: 90882 RVA: 0x00207BAE File Offset: 0x00205DAE
		// (set) Token: 0x06016303 RID: 90883 RVA: 0x00207BBE File Offset: 0x00205DBE
		public unsafe float dis1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_jacobiCloth.__PropertyOffset_dis1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_jacobiCloth.__PropertyOffset_dis1) = value;
			}
		}

		// Token: 0x170058D2 RID: 22738
		// (get) Token: 0x06016304 RID: 90884 RVA: 0x00207BCF File Offset: 0x00205DCF
		// (set) Token: 0x06016305 RID: 90885 RVA: 0x00207BDF File Offset: 0x00205DDF
		public unsafe float dis2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_jacobiCloth.__PropertyOffset_dis2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_jacobiCloth.__PropertyOffset_dis2) = value;
			}
		}

		// Token: 0x170058D3 RID: 22739
		// (get) Token: 0x06016306 RID: 90886 RVA: 0x00207BF0 File Offset: 0x00205DF0
		// (set) Token: 0x06016307 RID: 90887 RVA: 0x00207C00 File Offset: 0x00205E00
		public unsafe float dis3
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_jacobiCloth.__PropertyOffset_dis3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_jacobiCloth.__PropertyOffset_dis3) = value;
			}
		}

		// Token: 0x170058D4 RID: 22740
		// (get) Token: 0x06016308 RID: 90888 RVA: 0x00207C11 File Offset: 0x00205E11
		// (set) Token: 0x06016309 RID: 90889 RVA: 0x00207C21 File Offset: 0x00205E21
		public unsafe float dis4
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_jacobiCloth.__PropertyOffset_dis4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_jacobiCloth.__PropertyOffset_dis4) = value;
			}
		}

		// Token: 0x170058D5 RID: 22741
		// (get) Token: 0x0601630A RID: 90890 RVA: 0x00207C32 File Offset: 0x00205E32
		// (set) Token: 0x0601630B RID: 90891 RVA: 0x00207C42 File Offset: 0x00205E42
		public unsafe float dis5
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_jacobiCloth.__PropertyOffset_dis5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_jacobiCloth.__PropertyOffset_dis5) = value;
			}
		}

		// Token: 0x170058D6 RID: 22742
		// (get) Token: 0x0601630C RID: 90892 RVA: 0x00207C53 File Offset: 0x00205E53
		// (set) Token: 0x0601630D RID: 90893 RVA: 0x00207C63 File Offset: 0x00205E63
		public unsafe float dis6
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_jacobiCloth.__PropertyOffset_dis6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_jacobiCloth.__PropertyOffset_dis6) = value;
			}
		}

		// Token: 0x170058D7 RID: 22743
		// (get) Token: 0x0601630E RID: 90894 RVA: 0x00207C74 File Offset: 0x00205E74
		// (set) Token: 0x0601630F RID: 90895 RVA: 0x00207C84 File Offset: 0x00205E84
		public unsafe int neighbour7
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_jacobiCloth.__PropertyOffset_neighbour7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_jacobiCloth.__PropertyOffset_neighbour7) = value;
			}
		}

		// Token: 0x170058D8 RID: 22744
		// (get) Token: 0x06016310 RID: 90896 RVA: 0x00207C95 File Offset: 0x00205E95
		// (set) Token: 0x06016311 RID: 90897 RVA: 0x00207CA5 File Offset: 0x00205EA5
		public unsafe int neighbour8
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_jacobiCloth.__PropertyOffset_neighbour8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_jacobiCloth.__PropertyOffset_neighbour8) = value;
			}
		}

		// Token: 0x170058D9 RID: 22745
		// (get) Token: 0x06016312 RID: 90898 RVA: 0x00207CB6 File Offset: 0x00205EB6
		// (set) Token: 0x06016313 RID: 90899 RVA: 0x00207CCA File Offset: 0x00205ECA
		public unsafe FVector vol
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_jacobiCloth.__PropertyOffset_vol);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_jacobiCloth.__PropertyOffset_vol) = value;
			}
		}

		// Token: 0x170058DA RID: 22746
		// (get) Token: 0x06016314 RID: 90900 RVA: 0x00207CDF File Offset: 0x00205EDF
		// (set) Token: 0x06016315 RID: 90901 RVA: 0x00207CEF File Offset: 0x00205EEF
		public unsafe float dis7
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_jacobiCloth.__PropertyOffset_dis7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_jacobiCloth.__PropertyOffset_dis7) = value;
			}
		}

		// Token: 0x170058DB RID: 22747
		// (get) Token: 0x06016316 RID: 90902 RVA: 0x00207D00 File Offset: 0x00205F00
		// (set) Token: 0x06016317 RID: 90903 RVA: 0x00207D14 File Offset: 0x00205F14
		public unsafe FVector debugFloat3
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_jacobiCloth.__PropertyOffset_debugFloat3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_jacobiCloth.__PropertyOffset_debugFloat3) = value;
			}
		}

		// Token: 0x170058DC RID: 22748
		// (get) Token: 0x06016318 RID: 90904 RVA: 0x00207D29 File Offset: 0x00205F29
		// (set) Token: 0x06016319 RID: 90905 RVA: 0x00207D39 File Offset: 0x00205F39
		public unsafe float dis8
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_jacobiCloth.__PropertyOffset_dis8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_jacobiCloth.__PropertyOffset_dis8) = value;
			}
		}

		// Token: 0x170058DD RID: 22749
		// (get) Token: 0x0601631A RID: 90906 RVA: 0x00207D4A File Offset: 0x00205F4A
		// (set) Token: 0x0601631B RID: 90907 RVA: 0x00207D5E File Offset: 0x00205F5E
		public unsafe FVector myNormal
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_jacobiCloth.__PropertyOffset_myNormal);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_jacobiCloth.__PropertyOffset_myNormal) = value;
			}
		}

		// Token: 0x170058DE RID: 22750
		// (get) Token: 0x0601631C RID: 90908 RVA: 0x00207D73 File Offset: 0x00205F73
		// (set) Token: 0x0601631D RID: 90909 RVA: 0x00207D83 File Offset: 0x00205F83
		public unsafe int isPinned
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_jacobiCloth.__PropertyOffset_isPinned);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_jacobiCloth.__PropertyOffset_isPinned) = value;
			}
		}

		// Token: 0x170058DF RID: 22751
		// (get) Token: 0x0601631E RID: 90910 RVA: 0x00207D94 File Offset: 0x00205F94
		// (set) Token: 0x0601631F RID: 90911 RVA: 0x00207DA4 File Offset: 0x00205FA4
		public unsafe float bending_rest_0
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_jacobiCloth.__PropertyOffset_bending_rest_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_jacobiCloth.__PropertyOffset_bending_rest_0) = value;
			}
		}

		// Token: 0x170058E0 RID: 22752
		// (get) Token: 0x06016320 RID: 90912 RVA: 0x00207DB5 File Offset: 0x00205FB5
		// (set) Token: 0x06016321 RID: 90913 RVA: 0x00207DC5 File Offset: 0x00205FC5
		public unsafe float bending_rest_1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_jacobiCloth.__PropertyOffset_bending_rest_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_jacobiCloth.__PropertyOffset_bending_rest_1) = value;
			}
		}

		// Token: 0x170058E1 RID: 22753
		// (get) Token: 0x06016322 RID: 90914 RVA: 0x00207DD6 File Offset: 0x00205FD6
		// (set) Token: 0x06016323 RID: 90915 RVA: 0x00207DE6 File Offset: 0x00205FE6
		public unsafe float bending_rest_2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_jacobiCloth.__PropertyOffset_bending_rest_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_jacobiCloth.__PropertyOffset_bending_rest_2) = value;
			}
		}

		// Token: 0x170058E2 RID: 22754
		// (get) Token: 0x06016324 RID: 90916 RVA: 0x00207DF7 File Offset: 0x00205FF7
		// (set) Token: 0x06016325 RID: 90917 RVA: 0x00207E07 File Offset: 0x00206007
		public unsafe float bending_rest_3
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_jacobiCloth.__PropertyOffset_bending_rest_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_jacobiCloth.__PropertyOffset_bending_rest_3) = value;
			}
		}

		// Token: 0x170058E3 RID: 22755
		// (get) Token: 0x06016326 RID: 90918 RVA: 0x00207E18 File Offset: 0x00206018
		// (set) Token: 0x06016327 RID: 90919 RVA: 0x00207E28 File Offset: 0x00206028
		public unsafe int bending_self_idx_0
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_jacobiCloth.__PropertyOffset_bending_self_idx_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_jacobiCloth.__PropertyOffset_bending_self_idx_0) = value;
			}
		}

		// Token: 0x170058E4 RID: 22756
		// (get) Token: 0x06016328 RID: 90920 RVA: 0x00207E39 File Offset: 0x00206039
		// (set) Token: 0x06016329 RID: 90921 RVA: 0x00207E49 File Offset: 0x00206049
		public unsafe int bending_self_idx_1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_jacobiCloth.__PropertyOffset_bending_self_idx_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_jacobiCloth.__PropertyOffset_bending_self_idx_1) = value;
			}
		}

		// Token: 0x170058E5 RID: 22757
		// (get) Token: 0x0601632A RID: 90922 RVA: 0x00207E5A File Offset: 0x0020605A
		// (set) Token: 0x0601632B RID: 90923 RVA: 0x00207E6A File Offset: 0x0020606A
		public unsafe int bending_self_idx_2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_jacobiCloth.__PropertyOffset_bending_self_idx_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_jacobiCloth.__PropertyOffset_bending_self_idx_2) = value;
			}
		}

		// Token: 0x170058E6 RID: 22758
		// (get) Token: 0x0601632C RID: 90924 RVA: 0x00207E7B File Offset: 0x0020607B
		// (set) Token: 0x0601632D RID: 90925 RVA: 0x00207E8B File Offset: 0x0020608B
		public unsafe int bending_self_idx_3
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_jacobiCloth.__PropertyOffset_bending_self_idx_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_jacobiCloth.__PropertyOffset_bending_self_idx_3) = value;
			}
		}

		// Token: 0x170058E7 RID: 22759
		// (get) Token: 0x0601632E RID: 90926 RVA: 0x00207E9C File Offset: 0x0020609C
		// (set) Token: 0x0601632F RID: 90927 RVA: 0x00207EB0 File Offset: 0x002060B0
		public unsafe FVector bending_nbs_0
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_jacobiCloth.__PropertyOffset_bending_nbs_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_jacobiCloth.__PropertyOffset_bending_nbs_0) = value;
			}
		}

		// Token: 0x170058E8 RID: 22760
		// (get) Token: 0x06016330 RID: 90928 RVA: 0x00207EC5 File Offset: 0x002060C5
		// (set) Token: 0x06016331 RID: 90929 RVA: 0x00207ED9 File Offset: 0x002060D9
		public unsafe FVector bending_nbs_1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_jacobiCloth.__PropertyOffset_bending_nbs_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_jacobiCloth.__PropertyOffset_bending_nbs_1) = value;
			}
		}

		// Token: 0x170058E9 RID: 22761
		// (get) Token: 0x06016332 RID: 90930 RVA: 0x00207EEE File Offset: 0x002060EE
		// (set) Token: 0x06016333 RID: 90931 RVA: 0x00207F02 File Offset: 0x00206102
		public unsafe FVector bending_nbs_2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_jacobiCloth.__PropertyOffset_bending_nbs_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_jacobiCloth.__PropertyOffset_bending_nbs_2) = value;
			}
		}

		// Token: 0x170058EA RID: 22762
		// (get) Token: 0x06016334 RID: 90932 RVA: 0x00207F17 File Offset: 0x00206117
		// (set) Token: 0x06016335 RID: 90933 RVA: 0x00207F2B File Offset: 0x0020612B
		public unsafe FVector bending_nbs_3
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_jacobiCloth.__PropertyOffset_bending_nbs_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_jacobiCloth.__PropertyOffset_bending_nbs_3) = value;
			}
		}

		// Token: 0x170058EB RID: 22763
		// (get) Token: 0x06016336 RID: 90934 RVA: 0x00207F40 File Offset: 0x00206140
		// (set) Token: 0x06016337 RID: 90935 RVA: 0x00207F54 File Offset: 0x00206154
		public unsafe FVector pos_beforeStage
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_jacobiCloth.__PropertyOffset_pos_beforeStage);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_jacobiCloth.__PropertyOffset_pos_beforeStage) = value;
			}
		}

		// Token: 0x170058EC RID: 22764
		// (get) Token: 0x06016338 RID: 90936 RVA: 0x00207F69 File Offset: 0x00206169
		// (set) Token: 0x06016339 RID: 90937 RVA: 0x00207F79 File Offset: 0x00206179
		public unsafe int deadNode
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_jacobiCloth.__PropertyOffset_deadNode);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_jacobiCloth.__PropertyOffset_deadNode) = value;
			}
		}

		// Token: 0x170058ED RID: 22765
		// (get) Token: 0x0601633A RID: 90938 RVA: 0x00207F8A File Offset: 0x0020618A
		// (set) Token: 0x0601633B RID: 90939 RVA: 0x00207F9A File Offset: 0x0020619A
		public unsafe int clothID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_jacobiCloth.__PropertyOffset_clothID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_jacobiCloth.__PropertyOffset_clothID) = value;
			}
		}

		// Token: 0x0601633C RID: 90940 RVA: 0x00207FAB File Offset: 0x002061AB
		public FKuroCSParticle_jacobiCloth()
		{
		}

		// Token: 0x0601633D RID: 90941 RVA: 0x00207FB4 File Offset: 0x002061B4
		public FKuroCSParticle_jacobiCloth(FVector pos, int index, int neighbour1, int neighbour2, int neighbour3, int neighbour4, FVector pos_bind, int neighbour5, FVector pos_foe, int neighbour6, float dis1, float dis2, float dis3, float dis4, float dis5, float dis6, int neighbour7, int neighbour8, FVector vol, float dis7, FVector debugFloat3, float dis8, FVector myNormal, int isPinned, float bending_rest_0, float bending_rest_1, float bending_rest_2, float bending_rest_3, int bending_self_idx_0, int bending_self_idx_1, int bending_self_idx_2, int bending_self_idx_3, FVector bending_nbs_0, FVector bending_nbs_1, FVector bending_nbs_2, FVector bending_nbs_3, FVector pos_beforeStage, int deadNode, int clothID)
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

		// Token: 0x0601633E RID: 90942 RVA: 0x002080FC File Offset: 0x002062FC
		protected override IntPtr GetUStructPtr()
		{
			return FKuroCSParticle_jacobiCloth.StaticStruct();
		}

		// Token: 0x0601633F RID: 90943 RVA: 0x00208108 File Offset: 0x00206308
		[NullableContext(2)]
		public FKuroCSParticle_jacobiCloth(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06016340 RID: 90944 RVA: 0x00208112 File Offset: 0x00206312
		public FKuroCSParticle_jacobiCloth(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06016341 RID: 90945 RVA: 0x0020811D File Offset: 0x0020631D
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroCSParticle_jacobiCloth(Pointer, false, true);
		}

		// Token: 0x06016342 RID: 90946 RVA: 0x00208127 File Offset: 0x00206327
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroCSParticle_jacobiCloth(Pointer, MemoryOwner);
		}

		// Token: 0x0400C128 RID: 49448
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroComputeShader.KuroCSParticle_jacobiCloth";

		// Token: 0x0400C129 RID: 49449
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400C12A RID: 49450
		internal static int __PropertyOffset_pos;

		// Token: 0x0400C12B RID: 49451
		internal static int __PropertyOffset_index;

		// Token: 0x0400C12C RID: 49452
		internal static int __PropertyOffset_neighbour1;

		// Token: 0x0400C12D RID: 49453
		internal static int __PropertyOffset_neighbour2;

		// Token: 0x0400C12E RID: 49454
		internal static int __PropertyOffset_neighbour3;

		// Token: 0x0400C12F RID: 49455
		internal static int __PropertyOffset_neighbour4;

		// Token: 0x0400C130 RID: 49456
		internal static int __PropertyOffset_pos_bind;

		// Token: 0x0400C131 RID: 49457
		internal static int __PropertyOffset_neighbour5;

		// Token: 0x0400C132 RID: 49458
		internal static int __PropertyOffset_pos_foe;

		// Token: 0x0400C133 RID: 49459
		internal static int __PropertyOffset_neighbour6;

		// Token: 0x0400C134 RID: 49460
		internal static int __PropertyOffset_dis1;

		// Token: 0x0400C135 RID: 49461
		internal static int __PropertyOffset_dis2;

		// Token: 0x0400C136 RID: 49462
		internal static int __PropertyOffset_dis3;

		// Token: 0x0400C137 RID: 49463
		internal static int __PropertyOffset_dis4;

		// Token: 0x0400C138 RID: 49464
		internal static int __PropertyOffset_dis5;

		// Token: 0x0400C139 RID: 49465
		internal static int __PropertyOffset_dis6;

		// Token: 0x0400C13A RID: 49466
		internal static int __PropertyOffset_neighbour7;

		// Token: 0x0400C13B RID: 49467
		internal static int __PropertyOffset_neighbour8;

		// Token: 0x0400C13C RID: 49468
		internal static int __PropertyOffset_vol;

		// Token: 0x0400C13D RID: 49469
		internal static int __PropertyOffset_dis7;

		// Token: 0x0400C13E RID: 49470
		internal static int __PropertyOffset_debugFloat3;

		// Token: 0x0400C13F RID: 49471
		internal static int __PropertyOffset_dis8;

		// Token: 0x0400C140 RID: 49472
		internal static int __PropertyOffset_myNormal;

		// Token: 0x0400C141 RID: 49473
		internal static int __PropertyOffset_isPinned;

		// Token: 0x0400C142 RID: 49474
		internal static int __PropertyOffset_bending_rest_0;

		// Token: 0x0400C143 RID: 49475
		internal static int __PropertyOffset_bending_rest_1;

		// Token: 0x0400C144 RID: 49476
		internal static int __PropertyOffset_bending_rest_2;

		// Token: 0x0400C145 RID: 49477
		internal static int __PropertyOffset_bending_rest_3;

		// Token: 0x0400C146 RID: 49478
		internal static int __PropertyOffset_bending_self_idx_0;

		// Token: 0x0400C147 RID: 49479
		internal static int __PropertyOffset_bending_self_idx_1;

		// Token: 0x0400C148 RID: 49480
		internal static int __PropertyOffset_bending_self_idx_2;

		// Token: 0x0400C149 RID: 49481
		internal static int __PropertyOffset_bending_self_idx_3;

		// Token: 0x0400C14A RID: 49482
		internal static int __PropertyOffset_bending_nbs_0;

		// Token: 0x0400C14B RID: 49483
		internal static int __PropertyOffset_bending_nbs_1;

		// Token: 0x0400C14C RID: 49484
		internal static int __PropertyOffset_bending_nbs_2;

		// Token: 0x0400C14D RID: 49485
		internal static int __PropertyOffset_bending_nbs_3;

		// Token: 0x0400C14E RID: 49486
		internal static int __PropertyOffset_pos_beforeStage;

		// Token: 0x0400C14F RID: 49487
		internal static int __PropertyOffset_deadNode;

		// Token: 0x0400C150 RID: 49488
		internal static int __PropertyOffset_clothID;
	}
}
