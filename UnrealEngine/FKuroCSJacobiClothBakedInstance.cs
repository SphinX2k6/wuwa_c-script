using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020017B1 RID: 6065
	[UnrealObjectPath("/Script/KuroComputeShader.KuroCSJacobiClothBakedInstance")]
	[UnrealStructLayout(144, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 144)]
	public class FKuroCSJacobiClothBakedInstance : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060160B2 RID: 90290 RVA: 0x00204C6C File Offset: 0x00202E6C
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroCSJacobiClothBakedInstance._ScriptStructPtr != 0) ? FKuroCSJacobiClothBakedInstance._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroComputeShader.KuroCSJacobiClothBakedInstance", ref FKuroCSJacobiClothBakedInstance._ScriptStructPtr);
		}

		// Token: 0x170057DC RID: 22492
		// (get) Token: 0x060160B3 RID: 90291 RVA: 0x00204C90 File Offset: 0x00202E90
		// (set) Token: 0x060160B4 RID: 90292 RVA: 0x00204CA0 File Offset: 0x00202EA0
		public unsafe int ParticleOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSJacobiClothBakedInstance.__PropertyOffset_ParticleOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSJacobiClothBakedInstance.__PropertyOffset_ParticleOffset) = value;
			}
		}

		// Token: 0x170057DD RID: 22493
		// (get) Token: 0x060160B5 RID: 90293 RVA: 0x00204CB1 File Offset: 0x00202EB1
		// (set) Token: 0x060160B6 RID: 90294 RVA: 0x00204CC1 File Offset: 0x00202EC1
		public unsafe int BendingTopologyMode
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSJacobiClothBakedInstance.__PropertyOffset_BendingTopologyMode);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSJacobiClothBakedInstance.__PropertyOffset_BendingTopologyMode) = value;
			}
		}

		// Token: 0x170057DE RID: 22494
		// (get) Token: 0x060160B7 RID: 90295 RVA: 0x00204CD2 File Offset: 0x00202ED2
		// (set) Token: 0x060160B8 RID: 90296 RVA: 0x00204CE2 File Offset: 0x00202EE2
		public unsafe int XCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSJacobiClothBakedInstance.__PropertyOffset_XCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSJacobiClothBakedInstance.__PropertyOffset_XCount) = value;
			}
		}

		// Token: 0x170057DF RID: 22495
		// (get) Token: 0x060160B9 RID: 90297 RVA: 0x00204CF3 File Offset: 0x00202EF3
		// (set) Token: 0x060160BA RID: 90298 RVA: 0x00204D03 File Offset: 0x00202F03
		public unsafe int YCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSJacobiClothBakedInstance.__PropertyOffset_YCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSJacobiClothBakedInstance.__PropertyOffset_YCount) = value;
			}
		}

		// Token: 0x170057E0 RID: 22496
		// (get) Token: 0x060160BB RID: 90299 RVA: 0x00204D14 File Offset: 0x00202F14
		// (set) Token: 0x060160BC RID: 90300 RVA: 0x00204D24 File Offset: 0x00202F24
		public unsafe float DisStiffness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSJacobiClothBakedInstance.__PropertyOffset_DisStiffness);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSJacobiClothBakedInstance.__PropertyOffset_DisStiffness) = value;
			}
		}

		// Token: 0x170057E1 RID: 22497
		// (get) Token: 0x060160BD RID: 90301 RVA: 0x00204D35 File Offset: 0x00202F35
		// (set) Token: 0x060160BE RID: 90302 RVA: 0x00204D45 File Offset: 0x00202F45
		public unsafe float BendingStiffness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSJacobiClothBakedInstance.__PropertyOffset_BendingStiffness);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSJacobiClothBakedInstance.__PropertyOffset_BendingStiffness) = value;
			}
		}

		// Token: 0x170057E2 RID: 22498
		// (get) Token: 0x060160BF RID: 90303 RVA: 0x00204D56 File Offset: 0x00202F56
		// (set) Token: 0x060160C0 RID: 90304 RVA: 0x00204D66 File Offset: 0x00202F66
		public unsafe int ColliderOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSJacobiClothBakedInstance.__PropertyOffset_ColliderOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSJacobiClothBakedInstance.__PropertyOffset_ColliderOffset) = value;
			}
		}

		// Token: 0x170057E3 RID: 22499
		// (get) Token: 0x060160C1 RID: 90305 RVA: 0x00204D77 File Offset: 0x00202F77
		// (set) Token: 0x060160C2 RID: 90306 RVA: 0x00204D87 File Offset: 0x00202F87
		public unsafe int ColliderCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSJacobiClothBakedInstance.__PropertyOffset_ColliderCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSJacobiClothBakedInstance.__PropertyOffset_ColliderCount) = value;
			}
		}

		// Token: 0x170057E4 RID: 22500
		// (get) Token: 0x060160C3 RID: 90307 RVA: 0x00204D98 File Offset: 0x00202F98
		// (set) Token: 0x060160C4 RID: 90308 RVA: 0x00204DA8 File Offset: 0x00202FA8
		public unsafe float WindFieldRTScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSJacobiClothBakedInstance.__PropertyOffset_WindFieldRTScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSJacobiClothBakedInstance.__PropertyOffset_WindFieldRTScale) = value;
			}
		}

		// Token: 0x170057E5 RID: 22501
		// (get) Token: 0x060160C5 RID: 90309 RVA: 0x00204DB9 File Offset: 0x00202FB9
		// (set) Token: 0x060160C6 RID: 90310 RVA: 0x00204DC9 File Offset: 0x00202FC9
		public unsafe float VolDamping
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSJacobiClothBakedInstance.__PropertyOffset_VolDamping);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSJacobiClothBakedInstance.__PropertyOffset_VolDamping) = value;
			}
		}

		// Token: 0x170057E6 RID: 22502
		// (get) Token: 0x060160C7 RID: 90311 RVA: 0x00204DDA File Offset: 0x00202FDA
		// (set) Token: 0x060160C8 RID: 90312 RVA: 0x00204DEA File Offset: 0x00202FEA
		public unsafe float GravityDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSJacobiClothBakedInstance.__PropertyOffset_GravityDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSJacobiClothBakedInstance.__PropertyOffset_GravityDistance) = value;
			}
		}

		// Token: 0x170057E7 RID: 22503
		// (get) Token: 0x060160C9 RID: 90313 RVA: 0x00204DFB File Offset: 0x00202FFB
		// (set) Token: 0x060160CA RID: 90314 RVA: 0x00204E0B File Offset: 0x0020300B
		public unsafe int WindContactCooldownFrames
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSJacobiClothBakedInstance.__PropertyOffset_WindContactCooldownFrames);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSJacobiClothBakedInstance.__PropertyOffset_WindContactCooldownFrames) = value;
			}
		}

		// Token: 0x170057E8 RID: 22504
		// (get) Token: 0x060160CB RID: 90315 RVA: 0x00204E1C File Offset: 0x0020301C
		// (set) Token: 0x060160CC RID: 90316 RVA: 0x00204E2C File Offset: 0x0020302C
		public unsafe float WilsonRho
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSJacobiClothBakedInstance.__PropertyOffset_WilsonRho);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSJacobiClothBakedInstance.__PropertyOffset_WilsonRho) = value;
			}
		}

		// Token: 0x170057E9 RID: 22505
		// (get) Token: 0x060160CD RID: 90317 RVA: 0x00204E3D File Offset: 0x0020303D
		// (set) Token: 0x060160CE RID: 90318 RVA: 0x00204E4D File Offset: 0x0020304D
		public unsafe float WilsonCD
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSJacobiClothBakedInstance.__PropertyOffset_WilsonCD);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSJacobiClothBakedInstance.__PropertyOffset_WilsonCD) = value;
			}
		}

		// Token: 0x170057EA RID: 22506
		// (get) Token: 0x060160CF RID: 90319 RVA: 0x00204E5E File Offset: 0x0020305E
		// (set) Token: 0x060160D0 RID: 90320 RVA: 0x00204E6E File Offset: 0x0020306E
		public unsafe float WilsonCL
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSJacobiClothBakedInstance.__PropertyOffset_WilsonCL);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSJacobiClothBakedInstance.__PropertyOffset_WilsonCL) = value;
			}
		}

		// Token: 0x170057EB RID: 22507
		// (get) Token: 0x060160D1 RID: 90321 RVA: 0x00204E7F File Offset: 0x0020307F
		// (set) Token: 0x060160D2 RID: 90322 RVA: 0x00204E8F File Offset: 0x0020308F
		public unsafe float WilsonGustAmp
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSJacobiClothBakedInstance.__PropertyOffset_WilsonGustAmp);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSJacobiClothBakedInstance.__PropertyOffset_WilsonGustAmp) = value;
			}
		}

		// Token: 0x170057EC RID: 22508
		// (get) Token: 0x060160D3 RID: 90323 RVA: 0x00204EA0 File Offset: 0x002030A0
		// (set) Token: 0x060160D4 RID: 90324 RVA: 0x00204EB0 File Offset: 0x002030B0
		public unsafe float WilsonGustTimeFreq
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSJacobiClothBakedInstance.__PropertyOffset_WilsonGustTimeFreq);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSJacobiClothBakedInstance.__PropertyOffset_WilsonGustTimeFreq) = value;
			}
		}

		// Token: 0x170057ED RID: 22509
		// (get) Token: 0x060160D5 RID: 90325 RVA: 0x00204EC1 File Offset: 0x002030C1
		// (set) Token: 0x060160D6 RID: 90326 RVA: 0x00204ED1 File Offset: 0x002030D1
		public unsafe float WilsonGustSpaceFreq
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSJacobiClothBakedInstance.__PropertyOffset_WilsonGustSpaceFreq);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSJacobiClothBakedInstance.__PropertyOffset_WilsonGustSpaceFreq) = value;
			}
		}

		// Token: 0x170057EE RID: 22510
		// (get) Token: 0x060160D7 RID: 90327 RVA: 0x00204EE2 File Offset: 0x002030E2
		// (set) Token: 0x060160D8 RID: 90328 RVA: 0x00204EF2 File Offset: 0x002030F2
		public unsafe float WilsonDirSwayAmp
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSJacobiClothBakedInstance.__PropertyOffset_WilsonDirSwayAmp);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSJacobiClothBakedInstance.__PropertyOffset_WilsonDirSwayAmp) = value;
			}
		}

		// Token: 0x170057EF RID: 22511
		// (get) Token: 0x060160D9 RID: 90329 RVA: 0x00204F03 File Offset: 0x00203103
		// (set) Token: 0x060160DA RID: 90330 RVA: 0x00204F13 File Offset: 0x00203113
		public unsafe float WilsonDirSwayFreq
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSJacobiClothBakedInstance.__PropertyOffset_WilsonDirSwayFreq);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSJacobiClothBakedInstance.__PropertyOffset_WilsonDirSwayFreq) = value;
			}
		}

		// Token: 0x170057F0 RID: 22512
		// (get) Token: 0x060160DB RID: 90331 RVA: 0x00204F24 File Offset: 0x00203124
		// (set) Token: 0x060160DC RID: 90332 RVA: 0x00204F34 File Offset: 0x00203134
		public unsafe float WilsonMaxDvPerStep
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSJacobiClothBakedInstance.__PropertyOffset_WilsonMaxDvPerStep);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSJacobiClothBakedInstance.__PropertyOffset_WilsonMaxDvPerStep) = value;
			}
		}

		// Token: 0x170057F1 RID: 22513
		// (get) Token: 0x060160DD RID: 90333 RVA: 0x00204F45 File Offset: 0x00203145
		// (set) Token: 0x060160DE RID: 90334 RVA: 0x00204F55 File Offset: 0x00203155
		public unsafe float GravityX
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSJacobiClothBakedInstance.__PropertyOffset_GravityX);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSJacobiClothBakedInstance.__PropertyOffset_GravityX) = value;
			}
		}

		// Token: 0x170057F2 RID: 22514
		// (get) Token: 0x060160DF RID: 90335 RVA: 0x00204F66 File Offset: 0x00203166
		// (set) Token: 0x060160E0 RID: 90336 RVA: 0x00204F76 File Offset: 0x00203176
		public unsafe float GravityY
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSJacobiClothBakedInstance.__PropertyOffset_GravityY);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSJacobiClothBakedInstance.__PropertyOffset_GravityY) = value;
			}
		}

		// Token: 0x170057F3 RID: 22515
		// (get) Token: 0x060160E1 RID: 90337 RVA: 0x00204F87 File Offset: 0x00203187
		// (set) Token: 0x060160E2 RID: 90338 RVA: 0x00204F97 File Offset: 0x00203197
		public unsafe float GravityZ
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSJacobiClothBakedInstance.__PropertyOffset_GravityZ);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSJacobiClothBakedInstance.__PropertyOffset_GravityZ) = value;
			}
		}

		// Token: 0x170057F4 RID: 22516
		// (get) Token: 0x060160E3 RID: 90339 RVA: 0x00204FA8 File Offset: 0x002031A8
		// (set) Token: 0x060160E4 RID: 90340 RVA: 0x00204FB8 File Offset: 0x002031B8
		public unsafe int ClothPathEnabled
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSJacobiClothBakedInstance.__PropertyOffset_ClothPathEnabled);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSJacobiClothBakedInstance.__PropertyOffset_ClothPathEnabled) = value;
			}
		}

		// Token: 0x170057F5 RID: 22517
		// (get) Token: 0x060160E5 RID: 90341 RVA: 0x00204FC9 File Offset: 0x002031C9
		// (set) Token: 0x060160E6 RID: 90342 RVA: 0x00204FD9 File Offset: 0x002031D9
		public unsafe float ClothPathRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSJacobiClothBakedInstance.__PropertyOffset_ClothPathRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSJacobiClothBakedInstance.__PropertyOffset_ClothPathRadius) = value;
			}
		}

		// Token: 0x170057F6 RID: 22518
		// (get) Token: 0x060160E7 RID: 90343 RVA: 0x00204FEA File Offset: 0x002031EA
		// (set) Token: 0x060160E8 RID: 90344 RVA: 0x00204FFA File Offset: 0x002031FA
		public unsafe float ClothPathUpOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSJacobiClothBakedInstance.__PropertyOffset_ClothPathUpOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSJacobiClothBakedInstance.__PropertyOffset_ClothPathUpOffset) = value;
			}
		}

		// Token: 0x170057F7 RID: 22519
		// (get) Token: 0x060160E9 RID: 90345 RVA: 0x0020500B File Offset: 0x0020320B
		// (set) Token: 0x060160EA RID: 90346 RVA: 0x0020501B File Offset: 0x0020321B
		public unsafe float ClothPathAttenuationPower
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSJacobiClothBakedInstance.__PropertyOffset_ClothPathAttenuationPower);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSJacobiClothBakedInstance.__PropertyOffset_ClothPathAttenuationPower) = value;
			}
		}

		// Token: 0x170057F8 RID: 22520
		// (get) Token: 0x060160EB RID: 90347 RVA: 0x0020502C File Offset: 0x0020322C
		// (set) Token: 0x060160EC RID: 90348 RVA: 0x0020503C File Offset: 0x0020323C
		public unsafe float ClothPathRecoveryStiffness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSJacobiClothBakedInstance.__PropertyOffset_ClothPathRecoveryStiffness);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSJacobiClothBakedInstance.__PropertyOffset_ClothPathRecoveryStiffness) = value;
			}
		}

		// Token: 0x170057F9 RID: 22521
		// (get) Token: 0x060160ED RID: 90349 RVA: 0x0020504D File Offset: 0x0020324D
		// (set) Token: 0x060160EE RID: 90350 RVA: 0x0020505D File Offset: 0x0020325D
		public unsafe float ClothPathNormalThreshold
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSJacobiClothBakedInstance.__PropertyOffset_ClothPathNormalThreshold);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSJacobiClothBakedInstance.__PropertyOffset_ClothPathNormalThreshold) = value;
			}
		}

		// Token: 0x170057FA RID: 22522
		// (get) Token: 0x060160EF RID: 90351 RVA: 0x0020506E File Offset: 0x0020326E
		// (set) Token: 0x060160F0 RID: 90352 RVA: 0x0020507E File Offset: 0x0020327E
		public unsafe float WilsonBaseWindStrength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSJacobiClothBakedInstance.__PropertyOffset_WilsonBaseWindStrength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSJacobiClothBakedInstance.__PropertyOffset_WilsonBaseWindStrength) = value;
			}
		}

		// Token: 0x170057FB RID: 22523
		// (get) Token: 0x060160F1 RID: 90353 RVA: 0x0020508F File Offset: 0x0020328F
		// (set) Token: 0x060160F2 RID: 90354 RVA: 0x0020509F File Offset: 0x0020329F
		public unsafe float ClothPathPad1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSJacobiClothBakedInstance.__PropertyOffset_ClothPathPad1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSJacobiClothBakedInstance.__PropertyOffset_ClothPathPad1) = value;
			}
		}

		// Token: 0x170057FC RID: 22524
		// (get) Token: 0x060160F3 RID: 90355 RVA: 0x002050B0 File Offset: 0x002032B0
		// (set) Token: 0x060160F4 RID: 90356 RVA: 0x002050C0 File Offset: 0x002032C0
		public unsafe float WilsonWindDirX
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSJacobiClothBakedInstance.__PropertyOffset_WilsonWindDirX);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSJacobiClothBakedInstance.__PropertyOffset_WilsonWindDirX) = value;
			}
		}

		// Token: 0x170057FD RID: 22525
		// (get) Token: 0x060160F5 RID: 90357 RVA: 0x002050D1 File Offset: 0x002032D1
		// (set) Token: 0x060160F6 RID: 90358 RVA: 0x002050E1 File Offset: 0x002032E1
		public unsafe float WilsonWindDirY
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSJacobiClothBakedInstance.__PropertyOffset_WilsonWindDirY);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSJacobiClothBakedInstance.__PropertyOffset_WilsonWindDirY) = value;
			}
		}

		// Token: 0x170057FE RID: 22526
		// (get) Token: 0x060160F7 RID: 90359 RVA: 0x002050F2 File Offset: 0x002032F2
		// (set) Token: 0x060160F8 RID: 90360 RVA: 0x00205102 File Offset: 0x00203302
		public unsafe float WilsonWindDirZ
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSJacobiClothBakedInstance.__PropertyOffset_WilsonWindDirZ);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSJacobiClothBakedInstance.__PropertyOffset_WilsonWindDirZ) = value;
			}
		}

		// Token: 0x170057FF RID: 22527
		// (get) Token: 0x060160F9 RID: 90361 RVA: 0x00205113 File Offset: 0x00203313
		// (set) Token: 0x060160FA RID: 90362 RVA: 0x00205123 File Offset: 0x00203323
		public unsafe float WilsonWindDirPad
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSJacobiClothBakedInstance.__PropertyOffset_WilsonWindDirPad);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSJacobiClothBakedInstance.__PropertyOffset_WilsonWindDirPad) = value;
			}
		}

		// Token: 0x060160FB RID: 90363 RVA: 0x00205134 File Offset: 0x00203334
		public FKuroCSJacobiClothBakedInstance()
		{
		}

		// Token: 0x060160FC RID: 90364 RVA: 0x0020513C File Offset: 0x0020333C
		public FKuroCSJacobiClothBakedInstance(int ParticleOffset, int BendingTopologyMode, int XCount, int YCount, float DisStiffness, float BendingStiffness, int ColliderOffset, int ColliderCount, float WindFieldRTScale, float VolDamping, float GravityDistance, int WindContactCooldownFrames, float WilsonRho, float WilsonCD, float WilsonCL, float WilsonGustAmp, float WilsonGustTimeFreq, float WilsonGustSpaceFreq, float WilsonDirSwayAmp, float WilsonDirSwayFreq, float WilsonMaxDvPerStep, float GravityX, float GravityY, float GravityZ, int ClothPathEnabled, float ClothPathRadius, float ClothPathUpOffset, float ClothPathAttenuationPower, float ClothPathRecoveryStiffness, float ClothPathNormalThreshold, float WilsonBaseWindStrength, float ClothPathPad1, float WilsonWindDirX, float WilsonWindDirY, float WilsonWindDirZ, float WilsonWindDirPad)
		{
			this.ParticleOffset = ParticleOffset;
			this.BendingTopologyMode = BendingTopologyMode;
			this.XCount = XCount;
			this.YCount = YCount;
			this.DisStiffness = DisStiffness;
			this.BendingStiffness = BendingStiffness;
			this.ColliderOffset = ColliderOffset;
			this.ColliderCount = ColliderCount;
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
			this.ClothPathEnabled = ClothPathEnabled;
			this.ClothPathRadius = ClothPathRadius;
			this.ClothPathUpOffset = ClothPathUpOffset;
			this.ClothPathAttenuationPower = ClothPathAttenuationPower;
			this.ClothPathRecoveryStiffness = ClothPathRecoveryStiffness;
			this.ClothPathNormalThreshold = ClothPathNormalThreshold;
			this.WilsonBaseWindStrength = WilsonBaseWindStrength;
			this.ClothPathPad1 = ClothPathPad1;
			this.WilsonWindDirX = WilsonWindDirX;
			this.WilsonWindDirY = WilsonWindDirY;
			this.WilsonWindDirZ = WilsonWindDirZ;
			this.WilsonWindDirPad = WilsonWindDirPad;
		}

		// Token: 0x060160FD RID: 90365 RVA: 0x0020526C File Offset: 0x0020346C
		protected override IntPtr GetUStructPtr()
		{
			return FKuroCSJacobiClothBakedInstance.StaticStruct();
		}

		// Token: 0x060160FE RID: 90366 RVA: 0x00205278 File Offset: 0x00203478
		[NullableContext(2)]
		public FKuroCSJacobiClothBakedInstance(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060160FF RID: 90367 RVA: 0x00205282 File Offset: 0x00203482
		public FKuroCSJacobiClothBakedInstance(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06016100 RID: 90368 RVA: 0x0020528D File Offset: 0x0020348D
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroCSJacobiClothBakedInstance(Pointer, false, true);
		}

		// Token: 0x06016101 RID: 90369 RVA: 0x00205297 File Offset: 0x00203497
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroCSJacobiClothBakedInstance(Pointer, MemoryOwner);
		}

		// Token: 0x0400C020 RID: 49184
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroComputeShader.KuroCSJacobiClothBakedInstance";

		// Token: 0x0400C021 RID: 49185
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400C022 RID: 49186
		internal static int __PropertyOffset_ParticleOffset;

		// Token: 0x0400C023 RID: 49187
		internal static int __PropertyOffset_BendingTopologyMode;

		// Token: 0x0400C024 RID: 49188
		internal static int __PropertyOffset_XCount;

		// Token: 0x0400C025 RID: 49189
		internal static int __PropertyOffset_YCount;

		// Token: 0x0400C026 RID: 49190
		internal static int __PropertyOffset_DisStiffness;

		// Token: 0x0400C027 RID: 49191
		internal static int __PropertyOffset_BendingStiffness;

		// Token: 0x0400C028 RID: 49192
		internal static int __PropertyOffset_ColliderOffset;

		// Token: 0x0400C029 RID: 49193
		internal static int __PropertyOffset_ColliderCount;

		// Token: 0x0400C02A RID: 49194
		internal static int __PropertyOffset_WindFieldRTScale;

		// Token: 0x0400C02B RID: 49195
		internal static int __PropertyOffset_VolDamping;

		// Token: 0x0400C02C RID: 49196
		internal static int __PropertyOffset_GravityDistance;

		// Token: 0x0400C02D RID: 49197
		internal static int __PropertyOffset_WindContactCooldownFrames;

		// Token: 0x0400C02E RID: 49198
		internal static int __PropertyOffset_WilsonRho;

		// Token: 0x0400C02F RID: 49199
		internal static int __PropertyOffset_WilsonCD;

		// Token: 0x0400C030 RID: 49200
		internal static int __PropertyOffset_WilsonCL;

		// Token: 0x0400C031 RID: 49201
		internal static int __PropertyOffset_WilsonGustAmp;

		// Token: 0x0400C032 RID: 49202
		internal static int __PropertyOffset_WilsonGustTimeFreq;

		// Token: 0x0400C033 RID: 49203
		internal static int __PropertyOffset_WilsonGustSpaceFreq;

		// Token: 0x0400C034 RID: 49204
		internal static int __PropertyOffset_WilsonDirSwayAmp;

		// Token: 0x0400C035 RID: 49205
		internal static int __PropertyOffset_WilsonDirSwayFreq;

		// Token: 0x0400C036 RID: 49206
		internal static int __PropertyOffset_WilsonMaxDvPerStep;

		// Token: 0x0400C037 RID: 49207
		internal static int __PropertyOffset_GravityX;

		// Token: 0x0400C038 RID: 49208
		internal static int __PropertyOffset_GravityY;

		// Token: 0x0400C039 RID: 49209
		internal static int __PropertyOffset_GravityZ;

		// Token: 0x0400C03A RID: 49210
		internal static int __PropertyOffset_ClothPathEnabled;

		// Token: 0x0400C03B RID: 49211
		internal static int __PropertyOffset_ClothPathRadius;

		// Token: 0x0400C03C RID: 49212
		internal static int __PropertyOffset_ClothPathUpOffset;

		// Token: 0x0400C03D RID: 49213
		internal static int __PropertyOffset_ClothPathAttenuationPower;

		// Token: 0x0400C03E RID: 49214
		internal static int __PropertyOffset_ClothPathRecoveryStiffness;

		// Token: 0x0400C03F RID: 49215
		internal static int __PropertyOffset_ClothPathNormalThreshold;

		// Token: 0x0400C040 RID: 49216
		internal static int __PropertyOffset_WilsonBaseWindStrength;

		// Token: 0x0400C041 RID: 49217
		internal static int __PropertyOffset_ClothPathPad1;

		// Token: 0x0400C042 RID: 49218
		internal static int __PropertyOffset_WilsonWindDirX;

		// Token: 0x0400C043 RID: 49219
		internal static int __PropertyOffset_WilsonWindDirY;

		// Token: 0x0400C044 RID: 49220
		internal static int __PropertyOffset_WilsonWindDirZ;

		// Token: 0x0400C045 RID: 49221
		internal static int __PropertyOffset_WilsonWindDirPad;
	}
}
