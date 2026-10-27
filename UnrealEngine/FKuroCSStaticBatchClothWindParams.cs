using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020017D1 RID: 6097
	[UnrealObjectPath("/Script/KuroComputeShader.KuroCSStaticBatchClothWindParams")]
	[UnrealStructLayout(60, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 60)]
	public class FKuroCSStaticBatchClothWindParams : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601671E RID: 91934 RVA: 0x0020CB61 File Offset: 0x0020AD61
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroCSStaticBatchClothWindParams._ScriptStructPtr != 0) ? FKuroCSStaticBatchClothWindParams._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroComputeShader.KuroCSStaticBatchClothWindParams", ref FKuroCSStaticBatchClothWindParams._ScriptStructPtr);
		}

		// Token: 0x17005A76 RID: 23158
		// (get) Token: 0x0601671F RID: 91935 RVA: 0x0020CB85 File Offset: 0x0020AD85
		// (set) Token: 0x06016720 RID: 91936 RVA: 0x0020CB95 File Offset: 0x0020AD95
		public unsafe float WindFieldRTScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSStaticBatchClothWindParams.__PropertyOffset_WindFieldRTScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSStaticBatchClothWindParams.__PropertyOffset_WindFieldRTScale) = value;
			}
		}

		// Token: 0x17005A77 RID: 23159
		// (get) Token: 0x06016721 RID: 91937 RVA: 0x0020CBA6 File Offset: 0x0020ADA6
		// (set) Token: 0x06016722 RID: 91938 RVA: 0x0020CBBA File Offset: 0x0020ADBA
		public unsafe FVector Gravity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSStaticBatchClothWindParams.__PropertyOffset_Gravity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSStaticBatchClothWindParams.__PropertyOffset_Gravity) = value;
			}
		}

		// Token: 0x17005A78 RID: 23160
		// (get) Token: 0x06016723 RID: 91939 RVA: 0x0020CBCF File Offset: 0x0020ADCF
		// (set) Token: 0x06016724 RID: 91940 RVA: 0x0020CBDF File Offset: 0x0020ADDF
		public unsafe float GravityDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSStaticBatchClothWindParams.__PropertyOffset_GravityDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSStaticBatchClothWindParams.__PropertyOffset_GravityDistance) = value;
			}
		}

		// Token: 0x17005A79 RID: 23161
		// (get) Token: 0x06016725 RID: 91941 RVA: 0x0020CBF0 File Offset: 0x0020ADF0
		// (set) Token: 0x06016726 RID: 91942 RVA: 0x0020CC00 File Offset: 0x0020AE00
		public unsafe int WindContactCooldownFrames
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSStaticBatchClothWindParams.__PropertyOffset_WindContactCooldownFrames);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSStaticBatchClothWindParams.__PropertyOffset_WindContactCooldownFrames) = value;
			}
		}

		// Token: 0x17005A7A RID: 23162
		// (get) Token: 0x06016727 RID: 91943 RVA: 0x0020CC11 File Offset: 0x0020AE11
		// (set) Token: 0x06016728 RID: 91944 RVA: 0x0020CC21 File Offset: 0x0020AE21
		public unsafe float WilsonRho
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSStaticBatchClothWindParams.__PropertyOffset_WilsonRho);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSStaticBatchClothWindParams.__PropertyOffset_WilsonRho) = value;
			}
		}

		// Token: 0x17005A7B RID: 23163
		// (get) Token: 0x06016729 RID: 91945 RVA: 0x0020CC32 File Offset: 0x0020AE32
		// (set) Token: 0x0601672A RID: 91946 RVA: 0x0020CC42 File Offset: 0x0020AE42
		public unsafe float WilsonCD
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSStaticBatchClothWindParams.__PropertyOffset_WilsonCD);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSStaticBatchClothWindParams.__PropertyOffset_WilsonCD) = value;
			}
		}

		// Token: 0x17005A7C RID: 23164
		// (get) Token: 0x0601672B RID: 91947 RVA: 0x0020CC53 File Offset: 0x0020AE53
		// (set) Token: 0x0601672C RID: 91948 RVA: 0x0020CC63 File Offset: 0x0020AE63
		public unsafe float WilsonCL
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSStaticBatchClothWindParams.__PropertyOffset_WilsonCL);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSStaticBatchClothWindParams.__PropertyOffset_WilsonCL) = value;
			}
		}

		// Token: 0x17005A7D RID: 23165
		// (get) Token: 0x0601672D RID: 91949 RVA: 0x0020CC74 File Offset: 0x0020AE74
		// (set) Token: 0x0601672E RID: 91950 RVA: 0x0020CC84 File Offset: 0x0020AE84
		public unsafe float WilsonGustAmp
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSStaticBatchClothWindParams.__PropertyOffset_WilsonGustAmp);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSStaticBatchClothWindParams.__PropertyOffset_WilsonGustAmp) = value;
			}
		}

		// Token: 0x17005A7E RID: 23166
		// (get) Token: 0x0601672F RID: 91951 RVA: 0x0020CC95 File Offset: 0x0020AE95
		// (set) Token: 0x06016730 RID: 91952 RVA: 0x0020CCA5 File Offset: 0x0020AEA5
		public unsafe float WilsonGustTimeFreq
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSStaticBatchClothWindParams.__PropertyOffset_WilsonGustTimeFreq);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSStaticBatchClothWindParams.__PropertyOffset_WilsonGustTimeFreq) = value;
			}
		}

		// Token: 0x17005A7F RID: 23167
		// (get) Token: 0x06016731 RID: 91953 RVA: 0x0020CCB6 File Offset: 0x0020AEB6
		// (set) Token: 0x06016732 RID: 91954 RVA: 0x0020CCC6 File Offset: 0x0020AEC6
		public unsafe float WilsonGustSpaceFreq
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSStaticBatchClothWindParams.__PropertyOffset_WilsonGustSpaceFreq);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSStaticBatchClothWindParams.__PropertyOffset_WilsonGustSpaceFreq) = value;
			}
		}

		// Token: 0x17005A80 RID: 23168
		// (get) Token: 0x06016733 RID: 91955 RVA: 0x0020CCD7 File Offset: 0x0020AED7
		// (set) Token: 0x06016734 RID: 91956 RVA: 0x0020CCE7 File Offset: 0x0020AEE7
		public unsafe float WilsonDirSwayAmp
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSStaticBatchClothWindParams.__PropertyOffset_WilsonDirSwayAmp);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSStaticBatchClothWindParams.__PropertyOffset_WilsonDirSwayAmp) = value;
			}
		}

		// Token: 0x17005A81 RID: 23169
		// (get) Token: 0x06016735 RID: 91957 RVA: 0x0020CCF8 File Offset: 0x0020AEF8
		// (set) Token: 0x06016736 RID: 91958 RVA: 0x0020CD08 File Offset: 0x0020AF08
		public unsafe float WilsonDirSwayFreq
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSStaticBatchClothWindParams.__PropertyOffset_WilsonDirSwayFreq);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSStaticBatchClothWindParams.__PropertyOffset_WilsonDirSwayFreq) = value;
			}
		}

		// Token: 0x17005A82 RID: 23170
		// (get) Token: 0x06016737 RID: 91959 RVA: 0x0020CD19 File Offset: 0x0020AF19
		// (set) Token: 0x06016738 RID: 91960 RVA: 0x0020CD29 File Offset: 0x0020AF29
		public unsafe float WilsonMaxDvPerStep
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSStaticBatchClothWindParams.__PropertyOffset_WilsonMaxDvPerStep);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSStaticBatchClothWindParams.__PropertyOffset_WilsonMaxDvPerStep) = value;
			}
		}

		// Token: 0x06016739 RID: 91961 RVA: 0x0020CD3A File Offset: 0x0020AF3A
		public FKuroCSStaticBatchClothWindParams()
		{
		}

		// Token: 0x0601673A RID: 91962 RVA: 0x0020CD44 File Offset: 0x0020AF44
		public FKuroCSStaticBatchClothWindParams(float WindFieldRTScale, FVector Gravity, float GravityDistance, int WindContactCooldownFrames, float WilsonRho, float WilsonCD, float WilsonCL, float WilsonGustAmp, float WilsonGustTimeFreq, float WilsonGustSpaceFreq, float WilsonDirSwayAmp, float WilsonDirSwayFreq, float WilsonMaxDvPerStep)
		{
			this.WindFieldRTScale = WindFieldRTScale;
			this.Gravity = Gravity;
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
		}

		// Token: 0x0601673B RID: 91963 RVA: 0x0020CDBC File Offset: 0x0020AFBC
		protected override IntPtr GetUStructPtr()
		{
			return FKuroCSStaticBatchClothWindParams.StaticStruct();
		}

		// Token: 0x0601673C RID: 91964 RVA: 0x0020CDC8 File Offset: 0x0020AFC8
		[NullableContext(2)]
		public FKuroCSStaticBatchClothWindParams(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601673D RID: 91965 RVA: 0x0020CDD2 File Offset: 0x0020AFD2
		public FKuroCSStaticBatchClothWindParams(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601673E RID: 91966 RVA: 0x0020CDDD File Offset: 0x0020AFDD
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroCSStaticBatchClothWindParams(Pointer, false, true);
		}

		// Token: 0x0601673F RID: 91967 RVA: 0x0020CDE7 File Offset: 0x0020AFE7
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroCSStaticBatchClothWindParams(Pointer, MemoryOwner);
		}

		// Token: 0x0400C322 RID: 49954
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroComputeShader.KuroCSStaticBatchClothWindParams";

		// Token: 0x0400C323 RID: 49955
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400C324 RID: 49956
		internal static int __PropertyOffset_WindFieldRTScale;

		// Token: 0x0400C325 RID: 49957
		internal static int __PropertyOffset_Gravity;

		// Token: 0x0400C326 RID: 49958
		internal static int __PropertyOffset_GravityDistance;

		// Token: 0x0400C327 RID: 49959
		internal static int __PropertyOffset_WindContactCooldownFrames;

		// Token: 0x0400C328 RID: 49960
		internal static int __PropertyOffset_WilsonRho;

		// Token: 0x0400C329 RID: 49961
		internal static int __PropertyOffset_WilsonCD;

		// Token: 0x0400C32A RID: 49962
		internal static int __PropertyOffset_WilsonCL;

		// Token: 0x0400C32B RID: 49963
		internal static int __PropertyOffset_WilsonGustAmp;

		// Token: 0x0400C32C RID: 49964
		internal static int __PropertyOffset_WilsonGustTimeFreq;

		// Token: 0x0400C32D RID: 49965
		internal static int __PropertyOffset_WilsonGustSpaceFreq;

		// Token: 0x0400C32E RID: 49966
		internal static int __PropertyOffset_WilsonDirSwayAmp;

		// Token: 0x0400C32F RID: 49967
		internal static int __PropertyOffset_WilsonDirSwayFreq;

		// Token: 0x0400C330 RID: 49968
		internal static int __PropertyOffset_WilsonMaxDvPerStep;
	}
}
