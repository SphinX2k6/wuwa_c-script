using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020017A2 RID: 6050
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroComputeShader.KuroCSBalloons")]
	[UnrealStructLayout(1704, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1704)]
	public class AKuroCSBalloons : AKuroPhysicActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06015CFE RID: 89342 RVA: 0x002008CE File Offset: 0x001FEACE
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AKuroCSBalloons._ClassPtr;
		}

		// Token: 0x06015CFF RID: 89343 RVA: 0x002008DC File Offset: 0x001FEADC
		public AKuroCSBalloons() : this(BuiltinUtils.AllocNativeUObject(AKuroCSBalloons.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06015D00 RID: 89344 RVA: 0x00200904 File Offset: 0x001FEB04
		public AKuroCSBalloons(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AKuroCSBalloons.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005668 RID: 22120
		// (get) Token: 0x06015D01 RID: 89345 RVA: 0x00200937 File Offset: 0x001FEB37
		// (set) Token: 0x06015D02 RID: 89346 RVA: 0x0020094B File Offset: 0x001FEB4B
		[Nullable(2)]
		public unsafe USceneComponent Root
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroCSBalloons.__PropertyOffset_Root);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroCSBalloons.__PropertyOffset_Root, value);
			}
		}

		// Token: 0x17005669 RID: 22121
		// (get) Token: 0x06015D03 RID: 89347 RVA: 0x00200960 File Offset: 0x001FEB60
		// (set) Token: 0x06015D04 RID: 89348 RVA: 0x00200970 File Offset: 0x001FEB70
		public unsafe bool useExternalRT
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSBalloons.__PropertyOffset_useExternalRT) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSBalloons.__PropertyOffset_useExternalRT) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700566A RID: 22122
		// (get) Token: 0x06015D05 RID: 89349 RVA: 0x00200981 File Offset: 0x001FEB81
		// (set) Token: 0x06015D06 RID: 89350 RVA: 0x00200995 File Offset: 0x001FEB95
		[Nullable(2)]
		public unsafe UTextureRenderTarget2D RenderTarget
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTarget2D>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroCSBalloons.__PropertyOffset_RenderTarget);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroCSBalloons.__PropertyOffset_RenderTarget, value);
			}
		}

		// Token: 0x1700566B RID: 22123
		// (get) Token: 0x06015D07 RID: 89351 RVA: 0x002009AA File Offset: 0x001FEBAA
		// (set) Token: 0x06015D08 RID: 89352 RVA: 0x002009BE File Offset: 0x001FEBBE
		[Nullable(2)]
		public unsafe UTextureRenderTarget2D RenderTarget_N
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTarget2D>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroCSBalloons.__PropertyOffset_RenderTarget_N);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroCSBalloons.__PropertyOffset_RenderTarget_N, value);
			}
		}

		// Token: 0x1700566C RID: 22124
		// (get) Token: 0x06015D09 RID: 89353 RVA: 0x002009D4 File Offset: 0x001FEBD4
		// (set) Token: 0x06015D0A RID: 89354 RVA: 0x00200A0D File Offset: 0x001FEC0D
		public TArray<FKuroCSParticle_Balloons> DebugArr
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FKuroCSParticle_Balloons> result;
				if ((result = this._DebugArr) == null)
				{
					result = (this._DebugArr = new TArray<FKuroCSParticle_Balloons>(base.NativePtr + (IntPtr)AKuroCSBalloons.__PropertyOffset_DebugArr, this));
				}
				return result;
			}
			set
			{
				this.DebugArr.CopyAssign(value);
			}
		}

		// Token: 0x1700566D RID: 22125
		// (get) Token: 0x06015D0B RID: 89355 RVA: 0x00200A1B File Offset: 0x001FEC1B
		// (set) Token: 0x06015D0C RID: 89356 RVA: 0x00200A2F File Offset: 0x001FEC2F
		public unsafe FVector playerPos
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSBalloons.__PropertyOffset_playerPos);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSBalloons.__PropertyOffset_playerPos) = value;
			}
		}

		// Token: 0x1700566E RID: 22126
		// (get) Token: 0x06015D0D RID: 89357 RVA: 0x00200A44 File Offset: 0x001FEC44
		// (set) Token: 0x06015D0E RID: 89358 RVA: 0x00200A58 File Offset: 0x001FEC58
		public unsafe FVector actorPos
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSBalloons.__PropertyOffset_actorPos);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSBalloons.__PropertyOffset_actorPos) = value;
			}
		}

		// Token: 0x1700566F RID: 22127
		// (get) Token: 0x06015D0F RID: 89359 RVA: 0x00200A6D File Offset: 0x001FEC6D
		// (set) Token: 0x06015D10 RID: 89360 RVA: 0x00200A81 File Offset: 0x001FEC81
		public unsafe FVector CurWeaponPos
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSBalloons.__PropertyOffset_CurWeaponPos);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSBalloons.__PropertyOffset_CurWeaponPos) = value;
			}
		}

		// Token: 0x17005670 RID: 22128
		// (get) Token: 0x06015D11 RID: 89361 RVA: 0x00200A96 File Offset: 0x001FEC96
		// (set) Token: 0x06015D12 RID: 89362 RVA: 0x00200AAA File Offset: 0x001FECAA
		public unsafe FVector LastWeaponPos
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSBalloons.__PropertyOffset_LastWeaponPos);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSBalloons.__PropertyOffset_LastWeaponPos) = value;
			}
		}

		// Token: 0x17005671 RID: 22129
		// (get) Token: 0x06015D13 RID: 89363 RVA: 0x00200ABF File Offset: 0x001FECBF
		// (set) Token: 0x06015D14 RID: 89364 RVA: 0x00200ACF File Offset: 0x001FECCF
		public unsafe bool bEnableCPURead
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSBalloons.__PropertyOffset_bEnableCPURead) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSBalloons.__PropertyOffset_bEnableCPURead) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005672 RID: 22130
		// (get) Token: 0x06015D15 RID: 89365 RVA: 0x00200AE0 File Offset: 0x001FECE0
		// (set) Token: 0x06015D16 RID: 89366 RVA: 0x00200AF0 File Offset: 0x001FECF0
		public unsafe float deltaTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSBalloons.__PropertyOffset_deltaTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSBalloons.__PropertyOffset_deltaTime) = value;
			}
		}

		// Token: 0x17005673 RID: 22131
		// (get) Token: 0x06015D17 RID: 89367 RVA: 0x00200B01 File Offset: 0x001FED01
		// (set) Token: 0x06015D18 RID: 89368 RVA: 0x00200B11 File Offset: 0x001FED11
		public unsafe int attackOrNot
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSBalloons.__PropertyOffset_attackOrNot);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSBalloons.__PropertyOffset_attackOrNot) = value;
			}
		}

		// Token: 0x17005674 RID: 22132
		// (get) Token: 0x06015D19 RID: 89369 RVA: 0x00200B22 File Offset: 0x001FED22
		// (set) Token: 0x06015D1A RID: 89370 RVA: 0x00200B32 File Offset: 0x001FED32
		public unsafe int ParticleCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSBalloons.__PropertyOffset_ParticleCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSBalloons.__PropertyOffset_ParticleCount) = value;
			}
		}

		// Token: 0x17005675 RID: 22133
		// (get) Token: 0x06015D1B RID: 89371 RVA: 0x00200B43 File Offset: 0x001FED43
		// (set) Token: 0x06015D1C RID: 89372 RVA: 0x00200B53 File Offset: 0x001FED53
		public unsafe int substepCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSBalloons.__PropertyOffset_substepCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSBalloons.__PropertyOffset_substepCount) = value;
			}
		}

		// Token: 0x17005676 RID: 22134
		// (get) Token: 0x06015D1D RID: 89373 RVA: 0x00200B64 File Offset: 0x001FED64
		// (set) Token: 0x06015D1E RID: 89374 RVA: 0x00200B78 File Offset: 0x001FED78
		public unsafe FVector accel_ext
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSBalloons.__PropertyOffset_accel_ext);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSBalloons.__PropertyOffset_accel_ext) = value;
			}
		}

		// Token: 0x17005677 RID: 22135
		// (get) Token: 0x06015D1F RID: 89375 RVA: 0x00200B8D File Offset: 0x001FED8D
		// (set) Token: 0x06015D20 RID: 89376 RVA: 0x00200B9D File Offset: 0x001FED9D
		public unsafe float collisionR
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSBalloons.__PropertyOffset_collisionR);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSBalloons.__PropertyOffset_collisionR) = value;
			}
		}

		// Token: 0x17005678 RID: 22136
		// (get) Token: 0x06015D21 RID: 89377 RVA: 0x00200BAE File Offset: 0x001FEDAE
		// (set) Token: 0x06015D22 RID: 89378 RVA: 0x00200BBE File Offset: 0x001FEDBE
		public unsafe float DisStiffness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSBalloons.__PropertyOffset_DisStiffness);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSBalloons.__PropertyOffset_DisStiffness) = value;
			}
		}

		// Token: 0x17005679 RID: 22137
		// (get) Token: 0x06015D23 RID: 89379 RVA: 0x00200BCF File Offset: 0x001FEDCF
		// (set) Token: 0x06015D24 RID: 89380 RVA: 0x00200BDF File Offset: 0x001FEDDF
		public unsafe int XCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSBalloons.__PropertyOffset_XCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSBalloons.__PropertyOffset_XCount) = value;
			}
		}

		// Token: 0x1700567A RID: 22138
		// (get) Token: 0x06015D25 RID: 89381 RVA: 0x00200BF0 File Offset: 0x001FEDF0
		// (set) Token: 0x06015D26 RID: 89382 RVA: 0x00200C04 File Offset: 0x001FEE04
		public unsafe FVector endGravity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSBalloons.__PropertyOffset_endGravity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSBalloons.__PropertyOffset_endGravity) = value;
			}
		}

		// Token: 0x1700567B RID: 22139
		// (get) Token: 0x06015D27 RID: 89383 RVA: 0x00200C19 File Offset: 0x001FEE19
		// (set) Token: 0x06015D28 RID: 89384 RVA: 0x00200C2D File Offset: 0x001FEE2D
		public unsafe FVector nonEndGravity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSBalloons.__PropertyOffset_nonEndGravity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSBalloons.__PropertyOffset_nonEndGravity) = value;
			}
		}

		// Token: 0x1700567C RID: 22140
		// (get) Token: 0x06015D29 RID: 89385 RVA: 0x00200C42 File Offset: 0x001FEE42
		// (set) Token: 0x06015D2A RID: 89386 RVA: 0x00200C52 File Offset: 0x001FEE52
		public unsafe float balloonM
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSBalloons.__PropertyOffset_balloonM);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSBalloons.__PropertyOffset_balloonM) = value;
			}
		}

		// Token: 0x1700567D RID: 22141
		// (get) Token: 0x06015D2B RID: 89387 RVA: 0x00200C63 File Offset: 0x001FEE63
		// (set) Token: 0x06015D2C RID: 89388 RVA: 0x00200C73 File Offset: 0x001FEE73
		public unsafe float chainM
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSBalloons.__PropertyOffset_chainM);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSBalloons.__PropertyOffset_chainM) = value;
			}
		}

		// Token: 0x1700567E RID: 22142
		// (get) Token: 0x06015D2D RID: 89389 RVA: 0x00200C84 File Offset: 0x001FEE84
		// (set) Token: 0x06015D2E RID: 89390 RVA: 0x00200C94 File Offset: 0x001FEE94
		public unsafe float Sfp
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSBalloons.__PropertyOffset_Sfp);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSBalloons.__PropertyOffset_Sfp) = value;
			}
		}

		// Token: 0x1700567F RID: 22143
		// (get) Token: 0x06015D2F RID: 89391 RVA: 0x00200CA5 File Offset: 0x001FEEA5
		// (set) Token: 0x06015D30 RID: 89392 RVA: 0x00200CB5 File Offset: 0x001FEEB5
		public unsafe float Sfc
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSBalloons.__PropertyOffset_Sfc);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSBalloons.__PropertyOffset_Sfc) = value;
			}
		}

		// Token: 0x17005680 RID: 22144
		// (get) Token: 0x06015D31 RID: 89393 RVA: 0x00200CC6 File Offset: 0x001FEEC6
		// (set) Token: 0x06015D32 RID: 89394 RVA: 0x00200CD6 File Offset: 0x001FEED6
		public unsafe float endRepulsionRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSBalloons.__PropertyOffset_endRepulsionRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSBalloons.__PropertyOffset_endRepulsionRadius) = value;
			}
		}

		// Token: 0x17005681 RID: 22145
		// (get) Token: 0x06015D33 RID: 89395 RVA: 0x00200CE7 File Offset: 0x001FEEE7
		// (set) Token: 0x06015D34 RID: 89396 RVA: 0x00200CF7 File Offset: 0x001FEEF7
		public unsafe float BalloonUpMax
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSBalloons.__PropertyOffset_BalloonUpMax);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSBalloons.__PropertyOffset_BalloonUpMax) = value;
			}
		}

		// Token: 0x17005682 RID: 22146
		// (get) Token: 0x06015D35 RID: 89397 RVA: 0x00200D08 File Offset: 0x001FEF08
		// (set) Token: 0x06015D36 RID: 89398 RVA: 0x00200D18 File Offset: 0x001FEF18
		public unsafe float dissolveSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSBalloons.__PropertyOffset_dissolveSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSBalloons.__PropertyOffset_dissolveSpeed) = value;
			}
		}

		// Token: 0x17005683 RID: 22147
		// (get) Token: 0x06015D37 RID: 89399 RVA: 0x00200D29 File Offset: 0x001FEF29
		// (set) Token: 0x06015D38 RID: 89400 RVA: 0x00200D39 File Offset: 0x001FEF39
		public unsafe float maxZSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSBalloons.__PropertyOffset_maxZSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSBalloons.__PropertyOffset_maxZSpeed) = value;
			}
		}

		// Token: 0x17005684 RID: 22148
		// (get) Token: 0x06015D39 RID: 89401 RVA: 0x00200D4A File Offset: 0x001FEF4A
		// (set) Token: 0x06015D3A RID: 89402 RVA: 0x00200D5A File Offset: 0x001FEF5A
		public unsafe float randomExploredPercentage
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSBalloons.__PropertyOffset_randomExploredPercentage);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSBalloons.__PropertyOffset_randomExploredPercentage) = value;
			}
		}

		// Token: 0x17005685 RID: 22149
		// (get) Token: 0x06015D3B RID: 89403 RVA: 0x00200D6B File Offset: 0x001FEF6B
		// (set) Token: 0x06015D3C RID: 89404 RVA: 0x00200D7B File Offset: 0x001FEF7B
		public unsafe float playerPushForce
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSBalloons.__PropertyOffset_playerPushForce);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSBalloons.__PropertyOffset_playerPushForce) = value;
			}
		}

		// Token: 0x17005686 RID: 22150
		// (get) Token: 0x06015D3D RID: 89405 RVA: 0x00200D8C File Offset: 0x001FEF8C
		// (set) Token: 0x06015D3E RID: 89406 RVA: 0x00200D9C File Offset: 0x001FEF9C
		public unsafe float explosionRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSBalloons.__PropertyOffset_explosionRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSBalloons.__PropertyOffset_explosionRadius) = value;
			}
		}

		// Token: 0x17005687 RID: 22151
		// (get) Token: 0x06015D3F RID: 89407 RVA: 0x00200DAD File Offset: 0x001FEFAD
		// (set) Token: 0x06015D40 RID: 89408 RVA: 0x00200DBD File Offset: 0x001FEFBD
		public unsafe float explosionForce
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSBalloons.__PropertyOffset_explosionForce);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSBalloons.__PropertyOffset_explosionForce) = value;
			}
		}

		// Token: 0x17005688 RID: 22152
		// (get) Token: 0x06015D41 RID: 89409 RVA: 0x00200DCE File Offset: 0x001FEFCE
		// (set) Token: 0x06015D42 RID: 89410 RVA: 0x00200DE2 File Offset: 0x001FEFE2
		public unsafe FVector BoxBoundMin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSBalloons.__PropertyOffset_BoxBoundMin);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSBalloons.__PropertyOffset_BoxBoundMin) = value;
			}
		}

		// Token: 0x17005689 RID: 22153
		// (get) Token: 0x06015D43 RID: 89411 RVA: 0x00200DF7 File Offset: 0x001FEFF7
		// (set) Token: 0x06015D44 RID: 89412 RVA: 0x00200E0B File Offset: 0x001FF00B
		public unsafe FVector BoxBoundMax
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSBalloons.__PropertyOffset_BoxBoundMax);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSBalloons.__PropertyOffset_BoxBoundMax) = value;
			}
		}

		// Token: 0x1700568A RID: 22154
		// (get) Token: 0x06015D45 RID: 89413 RVA: 0x00200E20 File Offset: 0x001FF020
		// (set) Token: 0x06015D46 RID: 89414 RVA: 0x00200E59 File Offset: 0x001FF059
		public TArray<FKuroCSParticle_Balloons> ParticlesArr
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FKuroCSParticle_Balloons> result;
				if ((result = this._ParticlesArr) == null)
				{
					result = (this._ParticlesArr = new TArray<FKuroCSParticle_Balloons>(base.NativePtr + (IntPtr)AKuroCSBalloons.__PropertyOffset_ParticlesArr, this));
				}
				return result;
			}
			set
			{
				this.ParticlesArr.CopyAssign(value);
			}
		}

		// Token: 0x06015D47 RID: 89415 RVA: 0x00200E67 File Offset: 0x001FF067
		public void StopSimulation()
		{
			AKuroCSBalloons.__StopSimulation_Internal(base.NativePtr);
		}

		// Token: 0x06015D48 RID: 89416 RVA: 0x00200E74 File Offset: 0x001FF074
		public void StartSimulation()
		{
			AKuroCSBalloons.__StartSimulation_Internal(base.NativePtr);
		}

		// Token: 0x06015D49 RID: 89417 RVA: 0x00200E84 File Offset: 0x001FF084
		public unsafe void SaveParticlesToCSV(string FilePath = "D:/ParticlesData.csv")
		{
			FString fstring = FString.AllocTemp(FilePath);
			AKuroCSBalloons.__SaveParticlesToCSV_Internal(base.NativePtr, fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06015D4A RID: 89418 RVA: 0x00200EAE File Offset: 0x001FF0AE
		public void ReleaseShaderManager()
		{
			AKuroCSBalloons.__ReleaseShaderManager_Internal(base.NativePtr);
		}

		// Token: 0x06015D4B RID: 89419 RVA: 0x00200EBB File Offset: 0x001FF0BB
		public void InitShaderManager()
		{
			AKuroCSBalloons.__InitShaderManager_Internal(base.NativePtr);
		}

		// Token: 0x06015D4C RID: 89420
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __StopSimulation_Internal(IntPtr @this);

		// Token: 0x06015D4D RID: 89421
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __StartSimulation_Internal(IntPtr @this);

		// Token: 0x06015D4E RID: 89422
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SaveParticlesToCSV_Internal(IntPtr @this, in FString FilePath);

		// Token: 0x06015D4F RID: 89423
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ReleaseShaderManager_Internal(IntPtr @this);

		// Token: 0x06015D50 RID: 89424
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __InitShaderManager_Internal(IntPtr @this);

		// Token: 0x06015D51 RID: 89425 RVA: 0x00200EC8 File Offset: 0x001FF0C8
		static AKuroCSBalloons()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroComputeShader.KuroCSBalloons");
		}

		// Token: 0x06015D52 RID: 89426 RVA: 0x00200ED6 File Offset: 0x001FF0D6
		protected AKuroCSBalloons(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400BE5F RID: 48735
		public new const string __ObjectPath = "/Script/KuroComputeShader.KuroCSBalloons";

		// Token: 0x0400BE60 RID: 48736
		private static IntPtr _ClassPtr;

		// Token: 0x0400BE61 RID: 48737
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400BE62 RID: 48738
		internal static int __PropertyOffset_Root;

		// Token: 0x0400BE63 RID: 48739
		internal static int __PropertyOffset_useExternalRT;

		// Token: 0x0400BE64 RID: 48740
		internal static int __PropertyOffset_RenderTarget;

		// Token: 0x0400BE65 RID: 48741
		internal static int __PropertyOffset_RenderTarget_N;

		// Token: 0x0400BE66 RID: 48742
		internal static int __PropertyOffset_DebugArr;

		// Token: 0x0400BE67 RID: 48743
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKuroCSParticle_Balloons> _DebugArr;

		// Token: 0x0400BE68 RID: 48744
		internal static int __PropertyOffset_playerPos;

		// Token: 0x0400BE69 RID: 48745
		internal static int __PropertyOffset_actorPos;

		// Token: 0x0400BE6A RID: 48746
		internal static int __PropertyOffset_CurWeaponPos;

		// Token: 0x0400BE6B RID: 48747
		internal static int __PropertyOffset_LastWeaponPos;

		// Token: 0x0400BE6C RID: 48748
		internal static int __PropertyOffset_bEnableCPURead;

		// Token: 0x0400BE6D RID: 48749
		internal static int __PropertyOffset_deltaTime;

		// Token: 0x0400BE6E RID: 48750
		internal static int __PropertyOffset_attackOrNot;

		// Token: 0x0400BE6F RID: 48751
		internal static int __PropertyOffset_ParticleCount;

		// Token: 0x0400BE70 RID: 48752
		internal static int __PropertyOffset_substepCount;

		// Token: 0x0400BE71 RID: 48753
		internal static int __PropertyOffset_accel_ext;

		// Token: 0x0400BE72 RID: 48754
		internal static int __PropertyOffset_collisionR;

		// Token: 0x0400BE73 RID: 48755
		internal static int __PropertyOffset_DisStiffness;

		// Token: 0x0400BE74 RID: 48756
		internal static int __PropertyOffset_XCount;

		// Token: 0x0400BE75 RID: 48757
		internal static int __PropertyOffset_endGravity;

		// Token: 0x0400BE76 RID: 48758
		internal static int __PropertyOffset_nonEndGravity;

		// Token: 0x0400BE77 RID: 48759
		internal static int __PropertyOffset_balloonM;

		// Token: 0x0400BE78 RID: 48760
		internal static int __PropertyOffset_chainM;

		// Token: 0x0400BE79 RID: 48761
		internal static int __PropertyOffset_Sfp;

		// Token: 0x0400BE7A RID: 48762
		internal static int __PropertyOffset_Sfc;

		// Token: 0x0400BE7B RID: 48763
		internal static int __PropertyOffset_endRepulsionRadius;

		// Token: 0x0400BE7C RID: 48764
		internal static int __PropertyOffset_BalloonUpMax;

		// Token: 0x0400BE7D RID: 48765
		internal static int __PropertyOffset_dissolveSpeed;

		// Token: 0x0400BE7E RID: 48766
		internal static int __PropertyOffset_maxZSpeed;

		// Token: 0x0400BE7F RID: 48767
		internal static int __PropertyOffset_randomExploredPercentage;

		// Token: 0x0400BE80 RID: 48768
		internal static int __PropertyOffset_playerPushForce;

		// Token: 0x0400BE81 RID: 48769
		internal static int __PropertyOffset_explosionRadius;

		// Token: 0x0400BE82 RID: 48770
		internal static int __PropertyOffset_explosionForce;

		// Token: 0x0400BE83 RID: 48771
		internal static int __PropertyOffset_BoxBoundMin;

		// Token: 0x0400BE84 RID: 48772
		internal static int __PropertyOffset_BoxBoundMax;

		// Token: 0x0400BE85 RID: 48773
		internal static int __PropertyOffset_ParticlesArr;

		// Token: 0x0400BE86 RID: 48774
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKuroCSParticle_Balloons> _ParticlesArr;
	}
}
