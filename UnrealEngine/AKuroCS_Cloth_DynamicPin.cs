using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020017D9 RID: 6105
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroComputeShader.KuroCS_Cloth_DynamicPin")]
	[UnrealStructLayout(1640, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1640)]
	public class AKuroCS_Cloth_DynamicPin : AKuroBPActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060167FC RID: 92156 RVA: 0x0020DB7D File Offset: 0x0020BD7D
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AKuroCS_Cloth_DynamicPin._ClassPtr;
		}

		// Token: 0x060167FD RID: 92157 RVA: 0x0020DB8C File Offset: 0x0020BD8C
		public AKuroCS_Cloth_DynamicPin() : this(BuiltinUtils.AllocNativeUObject(AKuroCS_Cloth_DynamicPin.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060167FE RID: 92158 RVA: 0x0020DBB4 File Offset: 0x0020BDB4
		[NullableContext(1)]
		public AKuroCS_Cloth_DynamicPin(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AKuroCS_Cloth_DynamicPin.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005AC2 RID: 23234
		// (get) Token: 0x060167FF RID: 92159 RVA: 0x0020DBE7 File Offset: 0x0020BDE7
		// (set) Token: 0x06016800 RID: 92160 RVA: 0x0020DBFB File Offset: 0x0020BDFB
		public unsafe USceneComponent Root
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroCS_Cloth_DynamicPin.__PropertyOffset_Root);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroCS_Cloth_DynamicPin.__PropertyOffset_Root, value);
			}
		}

		// Token: 0x17005AC3 RID: 23235
		// (get) Token: 0x06016801 RID: 92161 RVA: 0x0020DC10 File Offset: 0x0020BE10
		// (set) Token: 0x06016802 RID: 92162 RVA: 0x0020DC20 File Offset: 0x0020BE20
		public unsafe bool useExternalRT
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCS_Cloth_DynamicPin.__PropertyOffset_useExternalRT) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCS_Cloth_DynamicPin.__PropertyOffset_useExternalRT) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005AC4 RID: 23236
		// (get) Token: 0x06016803 RID: 92163 RVA: 0x0020DC31 File Offset: 0x0020BE31
		// (set) Token: 0x06016804 RID: 92164 RVA: 0x0020DC45 File Offset: 0x0020BE45
		public unsafe UTextureRenderTarget2D RenderTarget
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTarget2D>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroCS_Cloth_DynamicPin.__PropertyOffset_RenderTarget);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroCS_Cloth_DynamicPin.__PropertyOffset_RenderTarget, value);
			}
		}

		// Token: 0x17005AC5 RID: 23237
		// (get) Token: 0x06016805 RID: 92165 RVA: 0x0020DC5C File Offset: 0x0020BE5C
		// (set) Token: 0x06016806 RID: 92166 RVA: 0x0020DC95 File Offset: 0x0020BE95
		[Nullable(1)]
		public TArray<FKuroCSParticle_Cloth_DynamicPin> DebugArr
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FKuroCSParticle_Cloth_DynamicPin> result;
				if ((result = this._DebugArr) == null)
				{
					result = (this._DebugArr = new TArray<FKuroCSParticle_Cloth_DynamicPin>(base.NativePtr + (IntPtr)AKuroCS_Cloth_DynamicPin.__PropertyOffset_DebugArr, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.DebugArr.CopyAssign(value);
			}
		}

		// Token: 0x17005AC6 RID: 23238
		// (get) Token: 0x06016807 RID: 92167 RVA: 0x0020DCA3 File Offset: 0x0020BEA3
		// (set) Token: 0x06016808 RID: 92168 RVA: 0x0020DCB3 File Offset: 0x0020BEB3
		public unsafe int XCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCS_Cloth_DynamicPin.__PropertyOffset_XCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCS_Cloth_DynamicPin.__PropertyOffset_XCount) = value;
			}
		}

		// Token: 0x17005AC7 RID: 23239
		// (get) Token: 0x06016809 RID: 92169 RVA: 0x0020DCC4 File Offset: 0x0020BEC4
		// (set) Token: 0x0601680A RID: 92170 RVA: 0x0020DCD4 File Offset: 0x0020BED4
		public unsafe int YCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCS_Cloth_DynamicPin.__PropertyOffset_YCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCS_Cloth_DynamicPin.__PropertyOffset_YCount) = value;
			}
		}

		// Token: 0x17005AC8 RID: 23240
		// (get) Token: 0x0601680B RID: 92171 RVA: 0x0020DCE5 File Offset: 0x0020BEE5
		// (set) Token: 0x0601680C RID: 92172 RVA: 0x0020DCF5 File Offset: 0x0020BEF5
		public unsafe float DisStiffness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCS_Cloth_DynamicPin.__PropertyOffset_DisStiffness);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCS_Cloth_DynamicPin.__PropertyOffset_DisStiffness) = value;
			}
		}

		// Token: 0x17005AC9 RID: 23241
		// (get) Token: 0x0601680D RID: 92173 RVA: 0x0020DD06 File Offset: 0x0020BF06
		// (set) Token: 0x0601680E RID: 92174 RVA: 0x0020DD16 File Offset: 0x0020BF16
		public unsafe float bendStiffness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCS_Cloth_DynamicPin.__PropertyOffset_bendStiffness);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCS_Cloth_DynamicPin.__PropertyOffset_bendStiffness) = value;
			}
		}

		// Token: 0x17005ACA RID: 23242
		// (get) Token: 0x0601680F RID: 92175 RVA: 0x0020DD27 File Offset: 0x0020BF27
		// (set) Token: 0x06016810 RID: 92176 RVA: 0x0020DD3B File Offset: 0x0020BF3B
		public unsafe FVector playerPos
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCS_Cloth_DynamicPin.__PropertyOffset_playerPos);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCS_Cloth_DynamicPin.__PropertyOffset_playerPos) = value;
			}
		}

		// Token: 0x17005ACB RID: 23243
		// (get) Token: 0x06016811 RID: 92177 RVA: 0x0020DD50 File Offset: 0x0020BF50
		// (set) Token: 0x06016812 RID: 92178 RVA: 0x0020DD60 File Offset: 0x0020BF60
		public unsafe float collisionR
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCS_Cloth_DynamicPin.__PropertyOffset_collisionR);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCS_Cloth_DynamicPin.__PropertyOffset_collisionR) = value;
			}
		}

		// Token: 0x17005ACC RID: 23244
		// (get) Token: 0x06016813 RID: 92179 RVA: 0x0020DD71 File Offset: 0x0020BF71
		// (set) Token: 0x06016814 RID: 92180 RVA: 0x0020DD81 File Offset: 0x0020BF81
		public unsafe int ParticleCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCS_Cloth_DynamicPin.__PropertyOffset_ParticleCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCS_Cloth_DynamicPin.__PropertyOffset_ParticleCount) = value;
			}
		}

		// Token: 0x17005ACD RID: 23245
		// (get) Token: 0x06016815 RID: 92181 RVA: 0x0020DD92 File Offset: 0x0020BF92
		// (set) Token: 0x06016816 RID: 92182 RVA: 0x0020DDA2 File Offset: 0x0020BFA2
		public unsafe float linkDis
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCS_Cloth_DynamicPin.__PropertyOffset_linkDis);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCS_Cloth_DynamicPin.__PropertyOffset_linkDis) = value;
			}
		}

		// Token: 0x17005ACE RID: 23246
		// (get) Token: 0x06016817 RID: 92183 RVA: 0x0020DDB3 File Offset: 0x0020BFB3
		// (set) Token: 0x06016818 RID: 92184 RVA: 0x0020DDC3 File Offset: 0x0020BFC3
		public unsafe float linkDisY
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCS_Cloth_DynamicPin.__PropertyOffset_linkDisY);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCS_Cloth_DynamicPin.__PropertyOffset_linkDisY) = value;
			}
		}

		// Token: 0x17005ACF RID: 23247
		// (get) Token: 0x06016819 RID: 92185 RVA: 0x0020DDD4 File Offset: 0x0020BFD4
		// (set) Token: 0x0601681A RID: 92186 RVA: 0x0020DDE4 File Offset: 0x0020BFE4
		public unsafe int substepCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCS_Cloth_DynamicPin.__PropertyOffset_substepCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCS_Cloth_DynamicPin.__PropertyOffset_substepCount) = value;
			}
		}

		// Token: 0x17005AD0 RID: 23248
		// (get) Token: 0x0601681B RID: 92187 RVA: 0x0020DDF5 File Offset: 0x0020BFF5
		// (set) Token: 0x0601681C RID: 92188 RVA: 0x0020DE09 File Offset: 0x0020C009
		public unsafe FVector accel_ext
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCS_Cloth_DynamicPin.__PropertyOffset_accel_ext);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCS_Cloth_DynamicPin.__PropertyOffset_accel_ext) = value;
			}
		}

		// Token: 0x17005AD1 RID: 23249
		// (get) Token: 0x0601681D RID: 92189 RVA: 0x0020DE1E File Offset: 0x0020C01E
		// (set) Token: 0x0601681E RID: 92190 RVA: 0x0020DE32 File Offset: 0x0020C032
		public unsafe FVector actorPos
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCS_Cloth_DynamicPin.__PropertyOffset_actorPos);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCS_Cloth_DynamicPin.__PropertyOffset_actorPos) = value;
			}
		}

		// Token: 0x17005AD2 RID: 23250
		// (get) Token: 0x0601681F RID: 92191 RVA: 0x0020DE47 File Offset: 0x0020C047
		// (set) Token: 0x06016820 RID: 92192 RVA: 0x0020DE57 File Offset: 0x0020C057
		public unsafe int restoringOrNot
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCS_Cloth_DynamicPin.__PropertyOffset_restoringOrNot);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCS_Cloth_DynamicPin.__PropertyOffset_restoringOrNot) = value;
			}
		}

		// Token: 0x17005AD3 RID: 23251
		// (get) Token: 0x06016821 RID: 92193 RVA: 0x0020DE68 File Offset: 0x0020C068
		// (set) Token: 0x06016822 RID: 92194 RVA: 0x0020DE78 File Offset: 0x0020C078
		public unsafe float k
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCS_Cloth_DynamicPin.__PropertyOffset_k);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCS_Cloth_DynamicPin.__PropertyOffset_k) = value;
			}
		}

		// Token: 0x17005AD4 RID: 23252
		// (get) Token: 0x06016823 RID: 92195 RVA: 0x0020DE89 File Offset: 0x0020C089
		// (set) Token: 0x06016824 RID: 92196 RVA: 0x0020DE99 File Offset: 0x0020C099
		public unsafe float c
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCS_Cloth_DynamicPin.__PropertyOffset_c);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCS_Cloth_DynamicPin.__PropertyOffset_c) = value;
			}
		}

		// Token: 0x17005AD5 RID: 23253
		// (get) Token: 0x06016825 RID: 92197 RVA: 0x0020DEAA File Offset: 0x0020C0AA
		// (set) Token: 0x06016826 RID: 92198 RVA: 0x0020DEBA File Offset: 0x0020C0BA
		public unsafe float deltaTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCS_Cloth_DynamicPin.__PropertyOffset_deltaTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCS_Cloth_DynamicPin.__PropertyOffset_deltaTime) = value;
			}
		}

		// Token: 0x17005AD6 RID: 23254
		// (get) Token: 0x06016827 RID: 92199 RVA: 0x0020DECB File Offset: 0x0020C0CB
		// (set) Token: 0x06016828 RID: 92200 RVA: 0x0020DEDB File Offset: 0x0020C0DB
		public unsafe int lerpGravityOrNot
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCS_Cloth_DynamicPin.__PropertyOffset_lerpGravityOrNot);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCS_Cloth_DynamicPin.__PropertyOffset_lerpGravityOrNot) = value;
			}
		}

		// Token: 0x17005AD7 RID: 23255
		// (get) Token: 0x06016829 RID: 92201 RVA: 0x0020DEEC File Offset: 0x0020C0EC
		// (set) Token: 0x0601682A RID: 92202 RVA: 0x0020DEFC File Offset: 0x0020C0FC
		public unsafe int PinnedPointsOrNot
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCS_Cloth_DynamicPin.__PropertyOffset_PinnedPointsOrNot);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCS_Cloth_DynamicPin.__PropertyOffset_PinnedPointsOrNot) = value;
			}
		}

		// Token: 0x17005AD8 RID: 23256
		// (get) Token: 0x0601682B RID: 92203 RVA: 0x0020DF0D File Offset: 0x0020C10D
		// (set) Token: 0x0601682C RID: 92204 RVA: 0x0020DF1D File Offset: 0x0020C11D
		public unsafe float dragCoefficient
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCS_Cloth_DynamicPin.__PropertyOffset_dragCoefficient);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCS_Cloth_DynamicPin.__PropertyOffset_dragCoefficient) = value;
			}
		}

		// Token: 0x17005AD9 RID: 23257
		// (get) Token: 0x0601682D RID: 92205 RVA: 0x0020DF2E File Offset: 0x0020C12E
		// (set) Token: 0x0601682E RID: 92206 RVA: 0x0020DF42 File Offset: 0x0020C142
		public unsafe FVector pinned11
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCS_Cloth_DynamicPin.__PropertyOffset_pinned11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCS_Cloth_DynamicPin.__PropertyOffset_pinned11) = value;
			}
		}

		// Token: 0x17005ADA RID: 23258
		// (get) Token: 0x0601682F RID: 92207 RVA: 0x0020DF57 File Offset: 0x0020C157
		// (set) Token: 0x06016830 RID: 92208 RVA: 0x0020DF6B File Offset: 0x0020C16B
		public unsafe FVector pinned12
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCS_Cloth_DynamicPin.__PropertyOffset_pinned12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCS_Cloth_DynamicPin.__PropertyOffset_pinned12) = value;
			}
		}

		// Token: 0x17005ADB RID: 23259
		// (get) Token: 0x06016831 RID: 92209 RVA: 0x0020DF80 File Offset: 0x0020C180
		// (set) Token: 0x06016832 RID: 92210 RVA: 0x0020DF94 File Offset: 0x0020C194
		public unsafe FVector pinned21
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCS_Cloth_DynamicPin.__PropertyOffset_pinned21);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCS_Cloth_DynamicPin.__PropertyOffset_pinned21) = value;
			}
		}

		// Token: 0x17005ADC RID: 23260
		// (get) Token: 0x06016833 RID: 92211 RVA: 0x0020DFA9 File Offset: 0x0020C1A9
		// (set) Token: 0x06016834 RID: 92212 RVA: 0x0020DFBD File Offset: 0x0020C1BD
		public unsafe FVector pinned22
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCS_Cloth_DynamicPin.__PropertyOffset_pinned22);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCS_Cloth_DynamicPin.__PropertyOffset_pinned22) = value;
			}
		}

		// Token: 0x17005ADD RID: 23261
		// (get) Token: 0x06016835 RID: 92213 RVA: 0x0020DFD2 File Offset: 0x0020C1D2
		// (set) Token: 0x06016836 RID: 92214 RVA: 0x0020DFE2 File Offset: 0x0020C1E2
		public unsafe bool bPinRow0
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCS_Cloth_DynamicPin.__PropertyOffset_bPinRow0) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCS_Cloth_DynamicPin.__PropertyOffset_bPinRow0) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005ADE RID: 23262
		// (get) Token: 0x06016837 RID: 92215 RVA: 0x0020DFF3 File Offset: 0x0020C1F3
		// (set) Token: 0x06016838 RID: 92216 RVA: 0x0020E003 File Offset: 0x0020C203
		public unsafe bool bPinRowN
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCS_Cloth_DynamicPin.__PropertyOffset_bPinRowN) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCS_Cloth_DynamicPin.__PropertyOffset_bPinRowN) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005ADF RID: 23263
		// (get) Token: 0x06016839 RID: 92217 RVA: 0x0020E014 File Offset: 0x0020C214
		// (set) Token: 0x0601683A RID: 92218 RVA: 0x0020E024 File Offset: 0x0020C224
		public unsafe bool bPinCol0
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCS_Cloth_DynamicPin.__PropertyOffset_bPinCol0) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCS_Cloth_DynamicPin.__PropertyOffset_bPinCol0) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005AE0 RID: 23264
		// (get) Token: 0x0601683B RID: 92219 RVA: 0x0020E035 File Offset: 0x0020C235
		// (set) Token: 0x0601683C RID: 92220 RVA: 0x0020E045 File Offset: 0x0020C245
		public unsafe bool bPinColN
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCS_Cloth_DynamicPin.__PropertyOffset_bPinColN) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCS_Cloth_DynamicPin.__PropertyOffset_bPinColN) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005AE1 RID: 23265
		// (get) Token: 0x0601683D RID: 92221 RVA: 0x0020E056 File Offset: 0x0020C256
		// (set) Token: 0x0601683E RID: 92222 RVA: 0x0020E066 File Offset: 0x0020C266
		public unsafe bool bOffsetFirstPoint
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCS_Cloth_DynamicPin.__PropertyOffset_bOffsetFirstPoint) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCS_Cloth_DynamicPin.__PropertyOffset_bOffsetFirstPoint) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005AE2 RID: 23266
		// (get) Token: 0x0601683F RID: 92223 RVA: 0x0020E077 File Offset: 0x0020C277
		// (set) Token: 0x06016840 RID: 92224 RVA: 0x0020E087 File Offset: 0x0020C287
		public unsafe bool bBreakChainConstraint
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCS_Cloth_DynamicPin.__PropertyOffset_bBreakChainConstraint) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCS_Cloth_DynamicPin.__PropertyOffset_bBreakChainConstraint) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005AE3 RID: 23267
		// (get) Token: 0x06016841 RID: 92225 RVA: 0x0020E098 File Offset: 0x0020C298
		// (set) Token: 0x06016842 RID: 92226 RVA: 0x0020E0A8 File Offset: 0x0020C2A8
		public unsafe int BreakChainParticleIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCS_Cloth_DynamicPin.__PropertyOffset_BreakChainParticleIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCS_Cloth_DynamicPin.__PropertyOffset_BreakChainParticleIndex) = value;
			}
		}

		// Token: 0x06016843 RID: 92227 RVA: 0x0020E0B9 File Offset: 0x0020C2B9
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void StopSimulation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, AKuroCS_Cloth_DynamicPin.__StopSimulation_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06016844 RID: 92228 RVA: 0x0020E0CE File Offset: 0x0020C2CE
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void StartSimulation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, AKuroCS_Cloth_DynamicPin.__StartSimulation_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06016845 RID: 92229 RVA: 0x0020E0E3 File Offset: 0x0020C2E3
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void ReleaseShaderManager()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, AKuroCS_Cloth_DynamicPin.__ReleaseShaderManager_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06016846 RID: 92230 RVA: 0x0020E0F8 File Offset: 0x0020C2F8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void InitShaderManager()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, AKuroCS_Cloth_DynamicPin.__InitShaderManager_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06016847 RID: 92231 RVA: 0x0020E10D File Offset: 0x0020C30D
		static AKuroCS_Cloth_DynamicPin()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroComputeShader.KuroCS_Cloth_DynamicPin");
		}

		// Token: 0x06016848 RID: 92232 RVA: 0x0020E11B File Offset: 0x0020C31B
		protected AKuroCS_Cloth_DynamicPin(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400C383 RID: 50051
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroComputeShader.KuroCS_Cloth_DynamicPin";

		// Token: 0x0400C384 RID: 50052
		private static IntPtr _ClassPtr;

		// Token: 0x0400C385 RID: 50053
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400C386 RID: 50054
		internal static int __PropertyOffset_Root;

		// Token: 0x0400C387 RID: 50055
		internal static int __PropertyOffset_useExternalRT;

		// Token: 0x0400C388 RID: 50056
		internal static int __PropertyOffset_RenderTarget;

		// Token: 0x0400C389 RID: 50057
		internal static int __PropertyOffset_DebugArr;

		// Token: 0x0400C38A RID: 50058
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKuroCSParticle_Cloth_DynamicPin> _DebugArr;

		// Token: 0x0400C38B RID: 50059
		internal static int __PropertyOffset_XCount;

		// Token: 0x0400C38C RID: 50060
		internal static int __PropertyOffset_YCount;

		// Token: 0x0400C38D RID: 50061
		internal static int __PropertyOffset_DisStiffness;

		// Token: 0x0400C38E RID: 50062
		internal static int __PropertyOffset_bendStiffness;

		// Token: 0x0400C38F RID: 50063
		internal static int __PropertyOffset_playerPos;

		// Token: 0x0400C390 RID: 50064
		internal static int __PropertyOffset_collisionR;

		// Token: 0x0400C391 RID: 50065
		internal static int __PropertyOffset_ParticleCount;

		// Token: 0x0400C392 RID: 50066
		internal static int __PropertyOffset_linkDis;

		// Token: 0x0400C393 RID: 50067
		internal static int __PropertyOffset_linkDisY;

		// Token: 0x0400C394 RID: 50068
		internal static int __PropertyOffset_substepCount;

		// Token: 0x0400C395 RID: 50069
		internal static int __PropertyOffset_accel_ext;

		// Token: 0x0400C396 RID: 50070
		internal static int __PropertyOffset_actorPos;

		// Token: 0x0400C397 RID: 50071
		internal static int __PropertyOffset_restoringOrNot;

		// Token: 0x0400C398 RID: 50072
		internal static int __PropertyOffset_k;

		// Token: 0x0400C399 RID: 50073
		internal static int __PropertyOffset_c;

		// Token: 0x0400C39A RID: 50074
		internal static int __PropertyOffset_deltaTime;

		// Token: 0x0400C39B RID: 50075
		internal static int __PropertyOffset_lerpGravityOrNot;

		// Token: 0x0400C39C RID: 50076
		internal static int __PropertyOffset_PinnedPointsOrNot;

		// Token: 0x0400C39D RID: 50077
		internal static int __PropertyOffset_dragCoefficient;

		// Token: 0x0400C39E RID: 50078
		internal static int __PropertyOffset_pinned11;

		// Token: 0x0400C39F RID: 50079
		internal static int __PropertyOffset_pinned12;

		// Token: 0x0400C3A0 RID: 50080
		internal static int __PropertyOffset_pinned21;

		// Token: 0x0400C3A1 RID: 50081
		internal static int __PropertyOffset_pinned22;

		// Token: 0x0400C3A2 RID: 50082
		internal static int __PropertyOffset_bPinRow0;

		// Token: 0x0400C3A3 RID: 50083
		internal static int __PropertyOffset_bPinRowN;

		// Token: 0x0400C3A4 RID: 50084
		internal static int __PropertyOffset_bPinCol0;

		// Token: 0x0400C3A5 RID: 50085
		internal static int __PropertyOffset_bPinColN;

		// Token: 0x0400C3A6 RID: 50086
		internal static int __PropertyOffset_bOffsetFirstPoint;

		// Token: 0x0400C3A7 RID: 50087
		internal static int __PropertyOffset_bBreakChainConstraint;

		// Token: 0x0400C3A8 RID: 50088
		internal static int __PropertyOffset_BreakChainParticleIndex;

		// Token: 0x0400C3A9 RID: 50089
		private static IntPtr __StopSimulation_NativeFunctionPtr;

		// Token: 0x0400C3AA RID: 50090
		private static IntPtr __StartSimulation_NativeFunctionPtr;

		// Token: 0x0400C3AB RID: 50091
		private static IntPtr __ReleaseShaderManager_NativeFunctionPtr;

		// Token: 0x0400C3AC RID: 50092
		private static IntPtr __InitShaderManager_NativeFunctionPtr;
	}
}
