using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020017BD RID: 6077
	[UnrealObjectPath("/Script/KuroComputeShader.KuroCSParticle_genericCloth_33")]
	[UnrealStructLayout(256, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 256)]
	public class FKuroCSParticle_genericCloth_33 : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06016299 RID: 90777 RVA: 0x00207348 File Offset: 0x00205548
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroCSParticle_genericCloth_33._ScriptStructPtr != 0) ? FKuroCSParticle_genericCloth_33._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroComputeShader.KuroCSParticle_genericCloth_33", ref FKuroCSParticle_genericCloth_33._ScriptStructPtr);
		}

		// Token: 0x170058A1 RID: 22689
		// (get) Token: 0x0601629A RID: 90778 RVA: 0x0020736C File Offset: 0x0020556C
		// (set) Token: 0x0601629B RID: 90779 RVA: 0x00207380 File Offset: 0x00205580
		public unsafe FVector pos
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_genericCloth_33.__PropertyOffset_pos);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_genericCloth_33.__PropertyOffset_pos) = value;
			}
		}

		// Token: 0x170058A2 RID: 22690
		// (get) Token: 0x0601629C RID: 90780 RVA: 0x00207395 File Offset: 0x00205595
		// (set) Token: 0x0601629D RID: 90781 RVA: 0x002073A5 File Offset: 0x002055A5
		public unsafe int index
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_genericCloth_33.__PropertyOffset_index);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_genericCloth_33.__PropertyOffset_index) = value;
			}
		}

		// Token: 0x170058A3 RID: 22691
		// (get) Token: 0x0601629E RID: 90782 RVA: 0x002073B6 File Offset: 0x002055B6
		// (set) Token: 0x0601629F RID: 90783 RVA: 0x002073C6 File Offset: 0x002055C6
		public unsafe int neighbour1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_genericCloth_33.__PropertyOffset_neighbour1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_genericCloth_33.__PropertyOffset_neighbour1) = value;
			}
		}

		// Token: 0x170058A4 RID: 22692
		// (get) Token: 0x060162A0 RID: 90784 RVA: 0x002073D7 File Offset: 0x002055D7
		// (set) Token: 0x060162A1 RID: 90785 RVA: 0x002073E7 File Offset: 0x002055E7
		public unsafe int neighbour2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_genericCloth_33.__PropertyOffset_neighbour2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_genericCloth_33.__PropertyOffset_neighbour2) = value;
			}
		}

		// Token: 0x170058A5 RID: 22693
		// (get) Token: 0x060162A2 RID: 90786 RVA: 0x002073F8 File Offset: 0x002055F8
		// (set) Token: 0x060162A3 RID: 90787 RVA: 0x00207408 File Offset: 0x00205608
		public unsafe int neighbour3
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_genericCloth_33.__PropertyOffset_neighbour3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_genericCloth_33.__PropertyOffset_neighbour3) = value;
			}
		}

		// Token: 0x170058A6 RID: 22694
		// (get) Token: 0x060162A4 RID: 90788 RVA: 0x00207419 File Offset: 0x00205619
		// (set) Token: 0x060162A5 RID: 90789 RVA: 0x00207429 File Offset: 0x00205629
		public unsafe int neighbour4
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_genericCloth_33.__PropertyOffset_neighbour4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_genericCloth_33.__PropertyOffset_neighbour4) = value;
			}
		}

		// Token: 0x170058A7 RID: 22695
		// (get) Token: 0x060162A6 RID: 90790 RVA: 0x0020743A File Offset: 0x0020563A
		// (set) Token: 0x060162A7 RID: 90791 RVA: 0x0020744E File Offset: 0x0020564E
		public unsafe FVector pos_bind
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_genericCloth_33.__PropertyOffset_pos_bind);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_genericCloth_33.__PropertyOffset_pos_bind) = value;
			}
		}

		// Token: 0x170058A8 RID: 22696
		// (get) Token: 0x060162A8 RID: 90792 RVA: 0x00207463 File Offset: 0x00205663
		// (set) Token: 0x060162A9 RID: 90793 RVA: 0x00207473 File Offset: 0x00205673
		public unsafe int neighbour5
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_genericCloth_33.__PropertyOffset_neighbour5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_genericCloth_33.__PropertyOffset_neighbour5) = value;
			}
		}

		// Token: 0x170058A9 RID: 22697
		// (get) Token: 0x060162AA RID: 90794 RVA: 0x00207484 File Offset: 0x00205684
		// (set) Token: 0x060162AB RID: 90795 RVA: 0x00207498 File Offset: 0x00205698
		public unsafe FVector pos_foe
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_genericCloth_33.__PropertyOffset_pos_foe);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_genericCloth_33.__PropertyOffset_pos_foe) = value;
			}
		}

		// Token: 0x170058AA RID: 22698
		// (get) Token: 0x060162AC RID: 90796 RVA: 0x002074AD File Offset: 0x002056AD
		// (set) Token: 0x060162AD RID: 90797 RVA: 0x002074BD File Offset: 0x002056BD
		public unsafe int neighbour6
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_genericCloth_33.__PropertyOffset_neighbour6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_genericCloth_33.__PropertyOffset_neighbour6) = value;
			}
		}

		// Token: 0x170058AB RID: 22699
		// (get) Token: 0x060162AE RID: 90798 RVA: 0x002074CE File Offset: 0x002056CE
		// (set) Token: 0x060162AF RID: 90799 RVA: 0x002074DE File Offset: 0x002056DE
		public unsafe float dis1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_genericCloth_33.__PropertyOffset_dis1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_genericCloth_33.__PropertyOffset_dis1) = value;
			}
		}

		// Token: 0x170058AC RID: 22700
		// (get) Token: 0x060162B0 RID: 90800 RVA: 0x002074EF File Offset: 0x002056EF
		// (set) Token: 0x060162B1 RID: 90801 RVA: 0x002074FF File Offset: 0x002056FF
		public unsafe float dis2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_genericCloth_33.__PropertyOffset_dis2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_genericCloth_33.__PropertyOffset_dis2) = value;
			}
		}

		// Token: 0x170058AD RID: 22701
		// (get) Token: 0x060162B2 RID: 90802 RVA: 0x00207510 File Offset: 0x00205710
		// (set) Token: 0x060162B3 RID: 90803 RVA: 0x00207520 File Offset: 0x00205720
		public unsafe float dis3
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_genericCloth_33.__PropertyOffset_dis3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_genericCloth_33.__PropertyOffset_dis3) = value;
			}
		}

		// Token: 0x170058AE RID: 22702
		// (get) Token: 0x060162B4 RID: 90804 RVA: 0x00207531 File Offset: 0x00205731
		// (set) Token: 0x060162B5 RID: 90805 RVA: 0x00207541 File Offset: 0x00205741
		public unsafe float dis4
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_genericCloth_33.__PropertyOffset_dis4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_genericCloth_33.__PropertyOffset_dis4) = value;
			}
		}

		// Token: 0x170058AF RID: 22703
		// (get) Token: 0x060162B6 RID: 90806 RVA: 0x00207552 File Offset: 0x00205752
		// (set) Token: 0x060162B7 RID: 90807 RVA: 0x00207562 File Offset: 0x00205762
		public unsafe float dis5
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_genericCloth_33.__PropertyOffset_dis5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_genericCloth_33.__PropertyOffset_dis5) = value;
			}
		}

		// Token: 0x170058B0 RID: 22704
		// (get) Token: 0x060162B8 RID: 90808 RVA: 0x00207573 File Offset: 0x00205773
		// (set) Token: 0x060162B9 RID: 90809 RVA: 0x00207583 File Offset: 0x00205783
		public unsafe float dis6
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_genericCloth_33.__PropertyOffset_dis6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_genericCloth_33.__PropertyOffset_dis6) = value;
			}
		}

		// Token: 0x170058B1 RID: 22705
		// (get) Token: 0x060162BA RID: 90810 RVA: 0x00207594 File Offset: 0x00205794
		// (set) Token: 0x060162BB RID: 90811 RVA: 0x002075A4 File Offset: 0x002057A4
		public unsafe int neighbour7
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_genericCloth_33.__PropertyOffset_neighbour7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_genericCloth_33.__PropertyOffset_neighbour7) = value;
			}
		}

		// Token: 0x170058B2 RID: 22706
		// (get) Token: 0x060162BC RID: 90812 RVA: 0x002075B5 File Offset: 0x002057B5
		// (set) Token: 0x060162BD RID: 90813 RVA: 0x002075C5 File Offset: 0x002057C5
		public unsafe int neighbour8
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_genericCloth_33.__PropertyOffset_neighbour8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_genericCloth_33.__PropertyOffset_neighbour8) = value;
			}
		}

		// Token: 0x170058B3 RID: 22707
		// (get) Token: 0x060162BE RID: 90814 RVA: 0x002075D6 File Offset: 0x002057D6
		// (set) Token: 0x060162BF RID: 90815 RVA: 0x002075EA File Offset: 0x002057EA
		public unsafe FVector vol
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_genericCloth_33.__PropertyOffset_vol);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_genericCloth_33.__PropertyOffset_vol) = value;
			}
		}

		// Token: 0x170058B4 RID: 22708
		// (get) Token: 0x060162C0 RID: 90816 RVA: 0x002075FF File Offset: 0x002057FF
		// (set) Token: 0x060162C1 RID: 90817 RVA: 0x0020760F File Offset: 0x0020580F
		public unsafe float dis7
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_genericCloth_33.__PropertyOffset_dis7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_genericCloth_33.__PropertyOffset_dis7) = value;
			}
		}

		// Token: 0x170058B5 RID: 22709
		// (get) Token: 0x060162C2 RID: 90818 RVA: 0x00207620 File Offset: 0x00205820
		// (set) Token: 0x060162C3 RID: 90819 RVA: 0x00207634 File Offset: 0x00205834
		public unsafe FVector debugFloat3
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_genericCloth_33.__PropertyOffset_debugFloat3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_genericCloth_33.__PropertyOffset_debugFloat3) = value;
			}
		}

		// Token: 0x170058B6 RID: 22710
		// (get) Token: 0x060162C4 RID: 90820 RVA: 0x00207649 File Offset: 0x00205849
		// (set) Token: 0x060162C5 RID: 90821 RVA: 0x00207659 File Offset: 0x00205859
		public unsafe float dis8
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_genericCloth_33.__PropertyOffset_dis8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_genericCloth_33.__PropertyOffset_dis8) = value;
			}
		}

		// Token: 0x170058B7 RID: 22711
		// (get) Token: 0x060162C6 RID: 90822 RVA: 0x0020766A File Offset: 0x0020586A
		// (set) Token: 0x060162C7 RID: 90823 RVA: 0x0020767E File Offset: 0x0020587E
		public unsafe FVector myNormal
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_genericCloth_33.__PropertyOffset_myNormal);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_genericCloth_33.__PropertyOffset_myNormal) = value;
			}
		}

		// Token: 0x170058B8 RID: 22712
		// (get) Token: 0x060162C8 RID: 90824 RVA: 0x00207693 File Offset: 0x00205893
		// (set) Token: 0x060162C9 RID: 90825 RVA: 0x002076A3 File Offset: 0x002058A3
		public unsafe int isPinned
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_genericCloth_33.__PropertyOffset_isPinned);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_genericCloth_33.__PropertyOffset_isPinned) = value;
			}
		}

		// Token: 0x170058B9 RID: 22713
		// (get) Token: 0x060162CA RID: 90826 RVA: 0x002076B4 File Offset: 0x002058B4
		// (set) Token: 0x060162CB RID: 90827 RVA: 0x002076C4 File Offset: 0x002058C4
		public unsafe float bending_rest_0
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_genericCloth_33.__PropertyOffset_bending_rest_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_genericCloth_33.__PropertyOffset_bending_rest_0) = value;
			}
		}

		// Token: 0x170058BA RID: 22714
		// (get) Token: 0x060162CC RID: 90828 RVA: 0x002076D5 File Offset: 0x002058D5
		// (set) Token: 0x060162CD RID: 90829 RVA: 0x002076E5 File Offset: 0x002058E5
		public unsafe float bending_rest_1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_genericCloth_33.__PropertyOffset_bending_rest_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_genericCloth_33.__PropertyOffset_bending_rest_1) = value;
			}
		}

		// Token: 0x170058BB RID: 22715
		// (get) Token: 0x060162CE RID: 90830 RVA: 0x002076F6 File Offset: 0x002058F6
		// (set) Token: 0x060162CF RID: 90831 RVA: 0x00207706 File Offset: 0x00205906
		public unsafe float bending_rest_2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_genericCloth_33.__PropertyOffset_bending_rest_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_genericCloth_33.__PropertyOffset_bending_rest_2) = value;
			}
		}

		// Token: 0x170058BC RID: 22716
		// (get) Token: 0x060162D0 RID: 90832 RVA: 0x00207717 File Offset: 0x00205917
		// (set) Token: 0x060162D1 RID: 90833 RVA: 0x00207727 File Offset: 0x00205927
		public unsafe float bending_rest_3
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_genericCloth_33.__PropertyOffset_bending_rest_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_genericCloth_33.__PropertyOffset_bending_rest_3) = value;
			}
		}

		// Token: 0x170058BD RID: 22717
		// (get) Token: 0x060162D2 RID: 90834 RVA: 0x00207738 File Offset: 0x00205938
		// (set) Token: 0x060162D3 RID: 90835 RVA: 0x00207748 File Offset: 0x00205948
		public unsafe int bending_self_idx_0
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_genericCloth_33.__PropertyOffset_bending_self_idx_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_genericCloth_33.__PropertyOffset_bending_self_idx_0) = value;
			}
		}

		// Token: 0x170058BE RID: 22718
		// (get) Token: 0x060162D4 RID: 90836 RVA: 0x00207759 File Offset: 0x00205959
		// (set) Token: 0x060162D5 RID: 90837 RVA: 0x00207769 File Offset: 0x00205969
		public unsafe int bending_self_idx_1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_genericCloth_33.__PropertyOffset_bending_self_idx_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_genericCloth_33.__PropertyOffset_bending_self_idx_1) = value;
			}
		}

		// Token: 0x170058BF RID: 22719
		// (get) Token: 0x060162D6 RID: 90838 RVA: 0x0020777A File Offset: 0x0020597A
		// (set) Token: 0x060162D7 RID: 90839 RVA: 0x0020778A File Offset: 0x0020598A
		public unsafe int bending_self_idx_2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_genericCloth_33.__PropertyOffset_bending_self_idx_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_genericCloth_33.__PropertyOffset_bending_self_idx_2) = value;
			}
		}

		// Token: 0x170058C0 RID: 22720
		// (get) Token: 0x060162D8 RID: 90840 RVA: 0x0020779B File Offset: 0x0020599B
		// (set) Token: 0x060162D9 RID: 90841 RVA: 0x002077AB File Offset: 0x002059AB
		public unsafe int bending_self_idx_3
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_genericCloth_33.__PropertyOffset_bending_self_idx_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_genericCloth_33.__PropertyOffset_bending_self_idx_3) = value;
			}
		}

		// Token: 0x170058C1 RID: 22721
		// (get) Token: 0x060162DA RID: 90842 RVA: 0x002077BC File Offset: 0x002059BC
		// (set) Token: 0x060162DB RID: 90843 RVA: 0x002077D0 File Offset: 0x002059D0
		public unsafe FVector bending_nbs_0
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_genericCloth_33.__PropertyOffset_bending_nbs_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_genericCloth_33.__PropertyOffset_bending_nbs_0) = value;
			}
		}

		// Token: 0x170058C2 RID: 22722
		// (get) Token: 0x060162DC RID: 90844 RVA: 0x002077E5 File Offset: 0x002059E5
		// (set) Token: 0x060162DD RID: 90845 RVA: 0x002077F9 File Offset: 0x002059F9
		public unsafe FVector bending_nbs_1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_genericCloth_33.__PropertyOffset_bending_nbs_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_genericCloth_33.__PropertyOffset_bending_nbs_1) = value;
			}
		}

		// Token: 0x170058C3 RID: 22723
		// (get) Token: 0x060162DE RID: 90846 RVA: 0x0020780E File Offset: 0x00205A0E
		// (set) Token: 0x060162DF RID: 90847 RVA: 0x00207822 File Offset: 0x00205A22
		public unsafe FVector bending_nbs_2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_genericCloth_33.__PropertyOffset_bending_nbs_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_genericCloth_33.__PropertyOffset_bending_nbs_2) = value;
			}
		}

		// Token: 0x170058C4 RID: 22724
		// (get) Token: 0x060162E0 RID: 90848 RVA: 0x00207837 File Offset: 0x00205A37
		// (set) Token: 0x060162E1 RID: 90849 RVA: 0x0020784B File Offset: 0x00205A4B
		public unsafe FVector bending_nbs_3
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_genericCloth_33.__PropertyOffset_bending_nbs_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_genericCloth_33.__PropertyOffset_bending_nbs_3) = value;
			}
		}

		// Token: 0x170058C5 RID: 22725
		// (get) Token: 0x060162E2 RID: 90850 RVA: 0x00207860 File Offset: 0x00205A60
		// (set) Token: 0x060162E3 RID: 90851 RVA: 0x00207874 File Offset: 0x00205A74
		public unsafe FVector pos_beforeStage
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_genericCloth_33.__PropertyOffset_pos_beforeStage);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_genericCloth_33.__PropertyOffset_pos_beforeStage) = value;
			}
		}

		// Token: 0x170058C6 RID: 22726
		// (get) Token: 0x060162E4 RID: 90852 RVA: 0x00207889 File Offset: 0x00205A89
		// (set) Token: 0x060162E5 RID: 90853 RVA: 0x00207899 File Offset: 0x00205A99
		public unsafe int deadNode
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_genericCloth_33.__PropertyOffset_deadNode);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_genericCloth_33.__PropertyOffset_deadNode) = value;
			}
		}

		// Token: 0x060162E6 RID: 90854 RVA: 0x002078AA File Offset: 0x00205AAA
		public FKuroCSParticle_genericCloth_33()
		{
		}

		// Token: 0x060162E7 RID: 90855 RVA: 0x002078B4 File Offset: 0x00205AB4
		public FKuroCSParticle_genericCloth_33(FVector pos, int index, int neighbour1, int neighbour2, int neighbour3, int neighbour4, FVector pos_bind, int neighbour5, FVector pos_foe, int neighbour6, float dis1, float dis2, float dis3, float dis4, float dis5, float dis6, int neighbour7, int neighbour8, FVector vol, float dis7, FVector debugFloat3, float dis8, FVector myNormal, int isPinned, float bending_rest_0, float bending_rest_1, float bending_rest_2, float bending_rest_3, int bending_self_idx_0, int bending_self_idx_1, int bending_self_idx_2, int bending_self_idx_3, FVector bending_nbs_0, FVector bending_nbs_1, FVector bending_nbs_2, FVector bending_nbs_3, FVector pos_beforeStage, int deadNode)
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
		}

		// Token: 0x060162E8 RID: 90856 RVA: 0x002079F4 File Offset: 0x00205BF4
		protected override IntPtr GetUStructPtr()
		{
			return FKuroCSParticle_genericCloth_33.StaticStruct();
		}

		// Token: 0x060162E9 RID: 90857 RVA: 0x00207A00 File Offset: 0x00205C00
		[NullableContext(2)]
		public FKuroCSParticle_genericCloth_33(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060162EA RID: 90858 RVA: 0x00207A0A File Offset: 0x00205C0A
		public FKuroCSParticle_genericCloth_33(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060162EB RID: 90859 RVA: 0x00207A15 File Offset: 0x00205C15
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroCSParticle_genericCloth_33(Pointer, false, true);
		}

		// Token: 0x060162EC RID: 90860 RVA: 0x00207A1F File Offset: 0x00205C1F
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroCSParticle_genericCloth_33(Pointer, MemoryOwner);
		}

		// Token: 0x0400C100 RID: 49408
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroComputeShader.KuroCSParticle_genericCloth_33";

		// Token: 0x0400C101 RID: 49409
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400C102 RID: 49410
		internal static int __PropertyOffset_pos;

		// Token: 0x0400C103 RID: 49411
		internal static int __PropertyOffset_index;

		// Token: 0x0400C104 RID: 49412
		internal static int __PropertyOffset_neighbour1;

		// Token: 0x0400C105 RID: 49413
		internal static int __PropertyOffset_neighbour2;

		// Token: 0x0400C106 RID: 49414
		internal static int __PropertyOffset_neighbour3;

		// Token: 0x0400C107 RID: 49415
		internal static int __PropertyOffset_neighbour4;

		// Token: 0x0400C108 RID: 49416
		internal static int __PropertyOffset_pos_bind;

		// Token: 0x0400C109 RID: 49417
		internal static int __PropertyOffset_neighbour5;

		// Token: 0x0400C10A RID: 49418
		internal static int __PropertyOffset_pos_foe;

		// Token: 0x0400C10B RID: 49419
		internal static int __PropertyOffset_neighbour6;

		// Token: 0x0400C10C RID: 49420
		internal static int __PropertyOffset_dis1;

		// Token: 0x0400C10D RID: 49421
		internal static int __PropertyOffset_dis2;

		// Token: 0x0400C10E RID: 49422
		internal static int __PropertyOffset_dis3;

		// Token: 0x0400C10F RID: 49423
		internal static int __PropertyOffset_dis4;

		// Token: 0x0400C110 RID: 49424
		internal static int __PropertyOffset_dis5;

		// Token: 0x0400C111 RID: 49425
		internal static int __PropertyOffset_dis6;

		// Token: 0x0400C112 RID: 49426
		internal static int __PropertyOffset_neighbour7;

		// Token: 0x0400C113 RID: 49427
		internal static int __PropertyOffset_neighbour8;

		// Token: 0x0400C114 RID: 49428
		internal static int __PropertyOffset_vol;

		// Token: 0x0400C115 RID: 49429
		internal static int __PropertyOffset_dis7;

		// Token: 0x0400C116 RID: 49430
		internal static int __PropertyOffset_debugFloat3;

		// Token: 0x0400C117 RID: 49431
		internal static int __PropertyOffset_dis8;

		// Token: 0x0400C118 RID: 49432
		internal static int __PropertyOffset_myNormal;

		// Token: 0x0400C119 RID: 49433
		internal static int __PropertyOffset_isPinned;

		// Token: 0x0400C11A RID: 49434
		internal static int __PropertyOffset_bending_rest_0;

		// Token: 0x0400C11B RID: 49435
		internal static int __PropertyOffset_bending_rest_1;

		// Token: 0x0400C11C RID: 49436
		internal static int __PropertyOffset_bending_rest_2;

		// Token: 0x0400C11D RID: 49437
		internal static int __PropertyOffset_bending_rest_3;

		// Token: 0x0400C11E RID: 49438
		internal static int __PropertyOffset_bending_self_idx_0;

		// Token: 0x0400C11F RID: 49439
		internal static int __PropertyOffset_bending_self_idx_1;

		// Token: 0x0400C120 RID: 49440
		internal static int __PropertyOffset_bending_self_idx_2;

		// Token: 0x0400C121 RID: 49441
		internal static int __PropertyOffset_bending_self_idx_3;

		// Token: 0x0400C122 RID: 49442
		internal static int __PropertyOffset_bending_nbs_0;

		// Token: 0x0400C123 RID: 49443
		internal static int __PropertyOffset_bending_nbs_1;

		// Token: 0x0400C124 RID: 49444
		internal static int __PropertyOffset_bending_nbs_2;

		// Token: 0x0400C125 RID: 49445
		internal static int __PropertyOffset_bending_nbs_3;

		// Token: 0x0400C126 RID: 49446
		internal static int __PropertyOffset_pos_beforeStage;

		// Token: 0x0400C127 RID: 49447
		internal static int __PropertyOffset_deadNode;
	}
}
