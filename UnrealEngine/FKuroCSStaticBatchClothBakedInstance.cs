using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020017CF RID: 6095
	[UnrealObjectPath("/Script/KuroComputeShader.KuroCSStaticBatchClothBakedInstance")]
	[UnrealStructLayout(288, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 288)]
	public class FKuroCSStaticBatchClothBakedInstance : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060166B8 RID: 91832 RVA: 0x0020C2FC File Offset: 0x0020A4FC
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroCSStaticBatchClothBakedInstance._ScriptStructPtr != 0) ? FKuroCSStaticBatchClothBakedInstance._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroComputeShader.KuroCSStaticBatchClothBakedInstance", ref FKuroCSStaticBatchClothBakedInstance._ScriptStructPtr);
		}

		// Token: 0x17005A4B RID: 23115
		// (get) Token: 0x060166B9 RID: 91833 RVA: 0x0020C320 File Offset: 0x0020A520
		// (set) Token: 0x060166BA RID: 91834 RVA: 0x0020C334 File Offset: 0x0020A534
		public unsafe FVector4 LocalToWorldRow0
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSStaticBatchClothBakedInstance.__PropertyOffset_LocalToWorldRow0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSStaticBatchClothBakedInstance.__PropertyOffset_LocalToWorldRow0) = value;
			}
		}

		// Token: 0x17005A4C RID: 23116
		// (get) Token: 0x060166BB RID: 91835 RVA: 0x0020C349 File Offset: 0x0020A549
		// (set) Token: 0x060166BC RID: 91836 RVA: 0x0020C35D File Offset: 0x0020A55D
		public unsafe FVector4 LocalToWorldRow1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSStaticBatchClothBakedInstance.__PropertyOffset_LocalToWorldRow1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSStaticBatchClothBakedInstance.__PropertyOffset_LocalToWorldRow1) = value;
			}
		}

		// Token: 0x17005A4D RID: 23117
		// (get) Token: 0x060166BD RID: 91837 RVA: 0x0020C372 File Offset: 0x0020A572
		// (set) Token: 0x060166BE RID: 91838 RVA: 0x0020C386 File Offset: 0x0020A586
		public unsafe FVector4 LocalToWorldRow2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSStaticBatchClothBakedInstance.__PropertyOffset_LocalToWorldRow2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSStaticBatchClothBakedInstance.__PropertyOffset_LocalToWorldRow2) = value;
			}
		}

		// Token: 0x17005A4E RID: 23118
		// (get) Token: 0x060166BF RID: 91839 RVA: 0x0020C39B File Offset: 0x0020A59B
		// (set) Token: 0x060166C0 RID: 91840 RVA: 0x0020C3AF File Offset: 0x0020A5AF
		public unsafe FVector4 LocalToWorldRow3
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSStaticBatchClothBakedInstance.__PropertyOffset_LocalToWorldRow3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSStaticBatchClothBakedInstance.__PropertyOffset_LocalToWorldRow3) = value;
			}
		}

		// Token: 0x17005A4F RID: 23119
		// (get) Token: 0x060166C1 RID: 91841 RVA: 0x0020C3C4 File Offset: 0x0020A5C4
		// (set) Token: 0x060166C2 RID: 91842 RVA: 0x0020C3D8 File Offset: 0x0020A5D8
		public unsafe FVector4 WorldToLocalRow0
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSStaticBatchClothBakedInstance.__PropertyOffset_WorldToLocalRow0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSStaticBatchClothBakedInstance.__PropertyOffset_WorldToLocalRow0) = value;
			}
		}

		// Token: 0x17005A50 RID: 23120
		// (get) Token: 0x060166C3 RID: 91843 RVA: 0x0020C3ED File Offset: 0x0020A5ED
		// (set) Token: 0x060166C4 RID: 91844 RVA: 0x0020C401 File Offset: 0x0020A601
		public unsafe FVector4 WorldToLocalRow1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSStaticBatchClothBakedInstance.__PropertyOffset_WorldToLocalRow1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSStaticBatchClothBakedInstance.__PropertyOffset_WorldToLocalRow1) = value;
			}
		}

		// Token: 0x17005A51 RID: 23121
		// (get) Token: 0x060166C5 RID: 91845 RVA: 0x0020C416 File Offset: 0x0020A616
		// (set) Token: 0x060166C6 RID: 91846 RVA: 0x0020C42A File Offset: 0x0020A62A
		public unsafe FVector4 WorldToLocalRow2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSStaticBatchClothBakedInstance.__PropertyOffset_WorldToLocalRow2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSStaticBatchClothBakedInstance.__PropertyOffset_WorldToLocalRow2) = value;
			}
		}

		// Token: 0x17005A52 RID: 23122
		// (get) Token: 0x060166C7 RID: 91847 RVA: 0x0020C43F File Offset: 0x0020A63F
		// (set) Token: 0x060166C8 RID: 91848 RVA: 0x0020C453 File Offset: 0x0020A653
		public unsafe FVector4 WorldToLocalRow3
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSStaticBatchClothBakedInstance.__PropertyOffset_WorldToLocalRow3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSStaticBatchClothBakedInstance.__PropertyOffset_WorldToLocalRow3) = value;
			}
		}

		// Token: 0x17005A53 RID: 23123
		// (get) Token: 0x060166C9 RID: 91849 RVA: 0x0020C468 File Offset: 0x0020A668
		// (set) Token: 0x060166CA RID: 91850 RVA: 0x0020C47C File Offset: 0x0020A67C
		public unsafe FVector4 BatchToClothRow0
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSStaticBatchClothBakedInstance.__PropertyOffset_BatchToClothRow0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSStaticBatchClothBakedInstance.__PropertyOffset_BatchToClothRow0) = value;
			}
		}

		// Token: 0x17005A54 RID: 23124
		// (get) Token: 0x060166CB RID: 91851 RVA: 0x0020C491 File Offset: 0x0020A691
		// (set) Token: 0x060166CC RID: 91852 RVA: 0x0020C4A5 File Offset: 0x0020A6A5
		public unsafe FVector4 BatchToClothRow1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSStaticBatchClothBakedInstance.__PropertyOffset_BatchToClothRow1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSStaticBatchClothBakedInstance.__PropertyOffset_BatchToClothRow1) = value;
			}
		}

		// Token: 0x17005A55 RID: 23125
		// (get) Token: 0x060166CD RID: 91853 RVA: 0x0020C4BA File Offset: 0x0020A6BA
		// (set) Token: 0x060166CE RID: 91854 RVA: 0x0020C4CE File Offset: 0x0020A6CE
		public unsafe FVector4 BatchToClothRow2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSStaticBatchClothBakedInstance.__PropertyOffset_BatchToClothRow2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSStaticBatchClothBakedInstance.__PropertyOffset_BatchToClothRow2) = value;
			}
		}

		// Token: 0x17005A56 RID: 23126
		// (get) Token: 0x060166CF RID: 91855 RVA: 0x0020C4E3 File Offset: 0x0020A6E3
		// (set) Token: 0x060166D0 RID: 91856 RVA: 0x0020C4F7 File Offset: 0x0020A6F7
		public unsafe FVector4 BatchToClothRow3
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSStaticBatchClothBakedInstance.__PropertyOffset_BatchToClothRow3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSStaticBatchClothBakedInstance.__PropertyOffset_BatchToClothRow3) = value;
			}
		}

		// Token: 0x17005A57 RID: 23127
		// (get) Token: 0x060166D1 RID: 91857 RVA: 0x0020C50C File Offset: 0x0020A70C
		// (set) Token: 0x060166D2 RID: 91858 RVA: 0x0020C51C File Offset: 0x0020A71C
		public unsafe int ParticleOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSStaticBatchClothBakedInstance.__PropertyOffset_ParticleOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSStaticBatchClothBakedInstance.__PropertyOffset_ParticleOffset) = value;
			}
		}

		// Token: 0x17005A58 RID: 23128
		// (get) Token: 0x060166D3 RID: 91859 RVA: 0x0020C52D File Offset: 0x0020A72D
		// (set) Token: 0x060166D4 RID: 91860 RVA: 0x0020C53D File Offset: 0x0020A73D
		public unsafe int BendingTopologyMode
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSStaticBatchClothBakedInstance.__PropertyOffset_BendingTopologyMode);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSStaticBatchClothBakedInstance.__PropertyOffset_BendingTopologyMode) = value;
			}
		}

		// Token: 0x17005A59 RID: 23129
		// (get) Token: 0x060166D5 RID: 91861 RVA: 0x0020C54E File Offset: 0x0020A74E
		// (set) Token: 0x060166D6 RID: 91862 RVA: 0x0020C55E File Offset: 0x0020A75E
		public unsafe int XCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSStaticBatchClothBakedInstance.__PropertyOffset_XCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSStaticBatchClothBakedInstance.__PropertyOffset_XCount) = value;
			}
		}

		// Token: 0x17005A5A RID: 23130
		// (get) Token: 0x060166D7 RID: 91863 RVA: 0x0020C56F File Offset: 0x0020A76F
		// (set) Token: 0x060166D8 RID: 91864 RVA: 0x0020C57F File Offset: 0x0020A77F
		public unsafe int YCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSStaticBatchClothBakedInstance.__PropertyOffset_YCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSStaticBatchClothBakedInstance.__PropertyOffset_YCount) = value;
			}
		}

		// Token: 0x17005A5B RID: 23131
		// (get) Token: 0x060166D9 RID: 91865 RVA: 0x0020C590 File Offset: 0x0020A790
		// (set) Token: 0x060166DA RID: 91866 RVA: 0x0020C5A0 File Offset: 0x0020A7A0
		public unsafe int RTOffsetU
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSStaticBatchClothBakedInstance.__PropertyOffset_RTOffsetU);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSStaticBatchClothBakedInstance.__PropertyOffset_RTOffsetU) = value;
			}
		}

		// Token: 0x17005A5C RID: 23132
		// (get) Token: 0x060166DB RID: 91867 RVA: 0x0020C5B1 File Offset: 0x0020A7B1
		// (set) Token: 0x060166DC RID: 91868 RVA: 0x0020C5C1 File Offset: 0x0020A7C1
		public unsafe int RTOffsetV
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSStaticBatchClothBakedInstance.__PropertyOffset_RTOffsetV);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSStaticBatchClothBakedInstance.__PropertyOffset_RTOffsetV) = value;
			}
		}

		// Token: 0x17005A5D RID: 23133
		// (get) Token: 0x060166DD RID: 91869 RVA: 0x0020C5D2 File Offset: 0x0020A7D2
		// (set) Token: 0x060166DE RID: 91870 RVA: 0x0020C5E2 File Offset: 0x0020A7E2
		public unsafe float DisStiffness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSStaticBatchClothBakedInstance.__PropertyOffset_DisStiffness);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSStaticBatchClothBakedInstance.__PropertyOffset_DisStiffness) = value;
			}
		}

		// Token: 0x17005A5E RID: 23134
		// (get) Token: 0x060166DF RID: 91871 RVA: 0x0020C5F3 File Offset: 0x0020A7F3
		// (set) Token: 0x060166E0 RID: 91872 RVA: 0x0020C603 File Offset: 0x0020A803
		public unsafe float BendingStiffness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSStaticBatchClothBakedInstance.__PropertyOffset_BendingStiffness);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSStaticBatchClothBakedInstance.__PropertyOffset_BendingStiffness) = value;
			}
		}

		// Token: 0x17005A5F RID: 23135
		// (get) Token: 0x060166E1 RID: 91873 RVA: 0x0020C614 File Offset: 0x0020A814
		// (set) Token: 0x060166E2 RID: 91874 RVA: 0x0020C624 File Offset: 0x0020A824
		public unsafe float WindFieldRTScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSStaticBatchClothBakedInstance.__PropertyOffset_WindFieldRTScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSStaticBatchClothBakedInstance.__PropertyOffset_WindFieldRTScale) = value;
			}
		}

		// Token: 0x17005A60 RID: 23136
		// (get) Token: 0x060166E3 RID: 91875 RVA: 0x0020C635 File Offset: 0x0020A835
		// (set) Token: 0x060166E4 RID: 91876 RVA: 0x0020C645 File Offset: 0x0020A845
		public unsafe float VolDamping
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSStaticBatchClothBakedInstance.__PropertyOffset_VolDamping);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSStaticBatchClothBakedInstance.__PropertyOffset_VolDamping) = value;
			}
		}

		// Token: 0x17005A61 RID: 23137
		// (get) Token: 0x060166E5 RID: 91877 RVA: 0x0020C656 File Offset: 0x0020A856
		// (set) Token: 0x060166E6 RID: 91878 RVA: 0x0020C666 File Offset: 0x0020A866
		public unsafe float GravityDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSStaticBatchClothBakedInstance.__PropertyOffset_GravityDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSStaticBatchClothBakedInstance.__PropertyOffset_GravityDistance) = value;
			}
		}

		// Token: 0x17005A62 RID: 23138
		// (get) Token: 0x060166E7 RID: 91879 RVA: 0x0020C677 File Offset: 0x0020A877
		// (set) Token: 0x060166E8 RID: 91880 RVA: 0x0020C687 File Offset: 0x0020A887
		public unsafe int WindContactCooldownFrames
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSStaticBatchClothBakedInstance.__PropertyOffset_WindContactCooldownFrames);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSStaticBatchClothBakedInstance.__PropertyOffset_WindContactCooldownFrames) = value;
			}
		}

		// Token: 0x17005A63 RID: 23139
		// (get) Token: 0x060166E9 RID: 91881 RVA: 0x0020C698 File Offset: 0x0020A898
		// (set) Token: 0x060166EA RID: 91882 RVA: 0x0020C6A8 File Offset: 0x0020A8A8
		public unsafe float WilsonRho
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSStaticBatchClothBakedInstance.__PropertyOffset_WilsonRho);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSStaticBatchClothBakedInstance.__PropertyOffset_WilsonRho) = value;
			}
		}

		// Token: 0x17005A64 RID: 23140
		// (get) Token: 0x060166EB RID: 91883 RVA: 0x0020C6B9 File Offset: 0x0020A8B9
		// (set) Token: 0x060166EC RID: 91884 RVA: 0x0020C6C9 File Offset: 0x0020A8C9
		public unsafe float WilsonCD
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSStaticBatchClothBakedInstance.__PropertyOffset_WilsonCD);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSStaticBatchClothBakedInstance.__PropertyOffset_WilsonCD) = value;
			}
		}

		// Token: 0x17005A65 RID: 23141
		// (get) Token: 0x060166ED RID: 91885 RVA: 0x0020C6DA File Offset: 0x0020A8DA
		// (set) Token: 0x060166EE RID: 91886 RVA: 0x0020C6EA File Offset: 0x0020A8EA
		public unsafe float WilsonCL
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSStaticBatchClothBakedInstance.__PropertyOffset_WilsonCL);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSStaticBatchClothBakedInstance.__PropertyOffset_WilsonCL) = value;
			}
		}

		// Token: 0x17005A66 RID: 23142
		// (get) Token: 0x060166EF RID: 91887 RVA: 0x0020C6FB File Offset: 0x0020A8FB
		// (set) Token: 0x060166F0 RID: 91888 RVA: 0x0020C70B File Offset: 0x0020A90B
		public unsafe float WilsonGustAmp
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSStaticBatchClothBakedInstance.__PropertyOffset_WilsonGustAmp);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSStaticBatchClothBakedInstance.__PropertyOffset_WilsonGustAmp) = value;
			}
		}

		// Token: 0x17005A67 RID: 23143
		// (get) Token: 0x060166F1 RID: 91889 RVA: 0x0020C71C File Offset: 0x0020A91C
		// (set) Token: 0x060166F2 RID: 91890 RVA: 0x0020C72C File Offset: 0x0020A92C
		public unsafe float WilsonGustTimeFreq
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSStaticBatchClothBakedInstance.__PropertyOffset_WilsonGustTimeFreq);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSStaticBatchClothBakedInstance.__PropertyOffset_WilsonGustTimeFreq) = value;
			}
		}

		// Token: 0x17005A68 RID: 23144
		// (get) Token: 0x060166F3 RID: 91891 RVA: 0x0020C73D File Offset: 0x0020A93D
		// (set) Token: 0x060166F4 RID: 91892 RVA: 0x0020C74D File Offset: 0x0020A94D
		public unsafe float WilsonGustSpaceFreq
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSStaticBatchClothBakedInstance.__PropertyOffset_WilsonGustSpaceFreq);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSStaticBatchClothBakedInstance.__PropertyOffset_WilsonGustSpaceFreq) = value;
			}
		}

		// Token: 0x17005A69 RID: 23145
		// (get) Token: 0x060166F5 RID: 91893 RVA: 0x0020C75E File Offset: 0x0020A95E
		// (set) Token: 0x060166F6 RID: 91894 RVA: 0x0020C76E File Offset: 0x0020A96E
		public unsafe float WilsonDirSwayAmp
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSStaticBatchClothBakedInstance.__PropertyOffset_WilsonDirSwayAmp);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSStaticBatchClothBakedInstance.__PropertyOffset_WilsonDirSwayAmp) = value;
			}
		}

		// Token: 0x17005A6A RID: 23146
		// (get) Token: 0x060166F7 RID: 91895 RVA: 0x0020C77F File Offset: 0x0020A97F
		// (set) Token: 0x060166F8 RID: 91896 RVA: 0x0020C78F File Offset: 0x0020A98F
		public unsafe float WilsonDirSwayFreq
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSStaticBatchClothBakedInstance.__PropertyOffset_WilsonDirSwayFreq);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSStaticBatchClothBakedInstance.__PropertyOffset_WilsonDirSwayFreq) = value;
			}
		}

		// Token: 0x17005A6B RID: 23147
		// (get) Token: 0x060166F9 RID: 91897 RVA: 0x0020C7A0 File Offset: 0x0020A9A0
		// (set) Token: 0x060166FA RID: 91898 RVA: 0x0020C7B0 File Offset: 0x0020A9B0
		public unsafe float WilsonMaxDvPerStep
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSStaticBatchClothBakedInstance.__PropertyOffset_WilsonMaxDvPerStep);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSStaticBatchClothBakedInstance.__PropertyOffset_WilsonMaxDvPerStep) = value;
			}
		}

		// Token: 0x17005A6C RID: 23148
		// (get) Token: 0x060166FB RID: 91899 RVA: 0x0020C7C1 File Offset: 0x0020A9C1
		// (set) Token: 0x060166FC RID: 91900 RVA: 0x0020C7D1 File Offset: 0x0020A9D1
		public unsafe float GravityX
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSStaticBatchClothBakedInstance.__PropertyOffset_GravityX);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSStaticBatchClothBakedInstance.__PropertyOffset_GravityX) = value;
			}
		}

		// Token: 0x17005A6D RID: 23149
		// (get) Token: 0x060166FD RID: 91901 RVA: 0x0020C7E2 File Offset: 0x0020A9E2
		// (set) Token: 0x060166FE RID: 91902 RVA: 0x0020C7F2 File Offset: 0x0020A9F2
		public unsafe float GravityY
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSStaticBatchClothBakedInstance.__PropertyOffset_GravityY);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSStaticBatchClothBakedInstance.__PropertyOffset_GravityY) = value;
			}
		}

		// Token: 0x17005A6E RID: 23150
		// (get) Token: 0x060166FF RID: 91903 RVA: 0x0020C803 File Offset: 0x0020AA03
		// (set) Token: 0x06016700 RID: 91904 RVA: 0x0020C813 File Offset: 0x0020AA13
		public unsafe float GravityZ
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSStaticBatchClothBakedInstance.__PropertyOffset_GravityZ);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSStaticBatchClothBakedInstance.__PropertyOffset_GravityZ) = value;
			}
		}

		// Token: 0x06016701 RID: 91905 RVA: 0x0020C824 File Offset: 0x0020AA24
		public FKuroCSStaticBatchClothBakedInstance()
		{
		}

		// Token: 0x06016702 RID: 91906 RVA: 0x0020C82C File Offset: 0x0020AA2C
		public FKuroCSStaticBatchClothBakedInstance(FVector4 LocalToWorldRow0, FVector4 LocalToWorldRow1, FVector4 LocalToWorldRow2, FVector4 LocalToWorldRow3, FVector4 WorldToLocalRow0, FVector4 WorldToLocalRow1, FVector4 WorldToLocalRow2, FVector4 WorldToLocalRow3, FVector4 BatchToClothRow0, FVector4 BatchToClothRow1, FVector4 BatchToClothRow2, FVector4 BatchToClothRow3, int ParticleOffset, int BendingTopologyMode, int XCount, int YCount, int RTOffsetU, int RTOffsetV, float DisStiffness, float BendingStiffness, float WindFieldRTScale, float VolDamping, float GravityDistance, int WindContactCooldownFrames, float WilsonRho, float WilsonCD, float WilsonCL, float WilsonGustAmp, float WilsonGustTimeFreq, float WilsonGustSpaceFreq, float WilsonDirSwayAmp, float WilsonDirSwayFreq, float WilsonMaxDvPerStep, float GravityX, float GravityY, float GravityZ)
		{
			this.LocalToWorldRow0 = LocalToWorldRow0;
			this.LocalToWorldRow1 = LocalToWorldRow1;
			this.LocalToWorldRow2 = LocalToWorldRow2;
			this.LocalToWorldRow3 = LocalToWorldRow3;
			this.WorldToLocalRow0 = WorldToLocalRow0;
			this.WorldToLocalRow1 = WorldToLocalRow1;
			this.WorldToLocalRow2 = WorldToLocalRow2;
			this.WorldToLocalRow3 = WorldToLocalRow3;
			this.BatchToClothRow0 = BatchToClothRow0;
			this.BatchToClothRow1 = BatchToClothRow1;
			this.BatchToClothRow2 = BatchToClothRow2;
			this.BatchToClothRow3 = BatchToClothRow3;
			this.ParticleOffset = ParticleOffset;
			this.BendingTopologyMode = BendingTopologyMode;
			this.XCount = XCount;
			this.YCount = YCount;
			this.RTOffsetU = RTOffsetU;
			this.RTOffsetV = RTOffsetV;
			this.DisStiffness = DisStiffness;
			this.BendingStiffness = BendingStiffness;
			this.WindFieldRTScale = WindFieldRTScale;
			this.VolDamping = VolDamping;
			this.GravityDistance = GravityDistance;
			this.WindContactCooldownFrames = WindContactCooldownFrames;
			this.WilsonRho = WilsonRho;
			this.WilsonCD = WilsonCD;
			this.WilsonCL = WilsonCL;
			this.WilsonGustAmp = WilsonGustAmp;
			this.WilsonGustTimeFreq = WilsonGustTimeFreq;
			this.WilsonGustSpaceFreq = WilsonGustSpaceFreq;
			this.WilsonDirSwayAmp = WilsonDirSwayAmp;
			this.WilsonDirSwayFreq = WilsonDirSwayFreq;
			this.WilsonMaxDvPerStep = WilsonMaxDvPerStep;
			this.GravityX = GravityX;
			this.GravityY = GravityY;
			this.GravityZ = GravityZ;
		}

		// Token: 0x06016703 RID: 91907 RVA: 0x0020C95C File Offset: 0x0020AB5C
		protected override IntPtr GetUStructPtr()
		{
			return FKuroCSStaticBatchClothBakedInstance.StaticStruct();
		}

		// Token: 0x06016704 RID: 91908 RVA: 0x0020C968 File Offset: 0x0020AB68
		[NullableContext(2)]
		public FKuroCSStaticBatchClothBakedInstance(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06016705 RID: 91909 RVA: 0x0020C972 File Offset: 0x0020AB72
		public FKuroCSStaticBatchClothBakedInstance(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06016706 RID: 91910 RVA: 0x0020C97D File Offset: 0x0020AB7D
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroCSStaticBatchClothBakedInstance(Pointer, false, true);
		}

		// Token: 0x06016707 RID: 91911 RVA: 0x0020C987 File Offset: 0x0020AB87
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroCSStaticBatchClothBakedInstance(Pointer, MemoryOwner);
		}

		// Token: 0x0400C2F2 RID: 49906
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroComputeShader.KuroCSStaticBatchClothBakedInstance";

		// Token: 0x0400C2F3 RID: 49907
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400C2F4 RID: 49908
		internal static int __PropertyOffset_LocalToWorldRow0;

		// Token: 0x0400C2F5 RID: 49909
		internal static int __PropertyOffset_LocalToWorldRow1;

		// Token: 0x0400C2F6 RID: 49910
		internal static int __PropertyOffset_LocalToWorldRow2;

		// Token: 0x0400C2F7 RID: 49911
		internal static int __PropertyOffset_LocalToWorldRow3;

		// Token: 0x0400C2F8 RID: 49912
		internal static int __PropertyOffset_WorldToLocalRow0;

		// Token: 0x0400C2F9 RID: 49913
		internal static int __PropertyOffset_WorldToLocalRow1;

		// Token: 0x0400C2FA RID: 49914
		internal static int __PropertyOffset_WorldToLocalRow2;

		// Token: 0x0400C2FB RID: 49915
		internal static int __PropertyOffset_WorldToLocalRow3;

		// Token: 0x0400C2FC RID: 49916
		internal static int __PropertyOffset_BatchToClothRow0;

		// Token: 0x0400C2FD RID: 49917
		internal static int __PropertyOffset_BatchToClothRow1;

		// Token: 0x0400C2FE RID: 49918
		internal static int __PropertyOffset_BatchToClothRow2;

		// Token: 0x0400C2FF RID: 49919
		internal static int __PropertyOffset_BatchToClothRow3;

		// Token: 0x0400C300 RID: 49920
		internal static int __PropertyOffset_ParticleOffset;

		// Token: 0x0400C301 RID: 49921
		internal static int __PropertyOffset_BendingTopologyMode;

		// Token: 0x0400C302 RID: 49922
		internal static int __PropertyOffset_XCount;

		// Token: 0x0400C303 RID: 49923
		internal static int __PropertyOffset_YCount;

		// Token: 0x0400C304 RID: 49924
		internal static int __PropertyOffset_RTOffsetU;

		// Token: 0x0400C305 RID: 49925
		internal static int __PropertyOffset_RTOffsetV;

		// Token: 0x0400C306 RID: 49926
		internal static int __PropertyOffset_DisStiffness;

		// Token: 0x0400C307 RID: 49927
		internal static int __PropertyOffset_BendingStiffness;

		// Token: 0x0400C308 RID: 49928
		internal static int __PropertyOffset_WindFieldRTScale;

		// Token: 0x0400C309 RID: 49929
		internal static int __PropertyOffset_VolDamping;

		// Token: 0x0400C30A RID: 49930
		internal static int __PropertyOffset_GravityDistance;

		// Token: 0x0400C30B RID: 49931
		internal static int __PropertyOffset_WindContactCooldownFrames;

		// Token: 0x0400C30C RID: 49932
		internal static int __PropertyOffset_WilsonRho;

		// Token: 0x0400C30D RID: 49933
		internal static int __PropertyOffset_WilsonCD;

		// Token: 0x0400C30E RID: 49934
		internal static int __PropertyOffset_WilsonCL;

		// Token: 0x0400C30F RID: 49935
		internal static int __PropertyOffset_WilsonGustAmp;

		// Token: 0x0400C310 RID: 49936
		internal static int __PropertyOffset_WilsonGustTimeFreq;

		// Token: 0x0400C311 RID: 49937
		internal static int __PropertyOffset_WilsonGustSpaceFreq;

		// Token: 0x0400C312 RID: 49938
		internal static int __PropertyOffset_WilsonDirSwayAmp;

		// Token: 0x0400C313 RID: 49939
		internal static int __PropertyOffset_WilsonDirSwayFreq;

		// Token: 0x0400C314 RID: 49940
		internal static int __PropertyOffset_WilsonMaxDvPerStep;

		// Token: 0x0400C315 RID: 49941
		internal static int __PropertyOffset_GravityX;

		// Token: 0x0400C316 RID: 49942
		internal static int __PropertyOffset_GravityY;

		// Token: 0x0400C317 RID: 49943
		internal static int __PropertyOffset_GravityZ;
	}
}
