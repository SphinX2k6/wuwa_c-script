using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000354 RID: 852
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroComputeShader.KuroCSGenericCloth")]
	[UnrealStructLayout(1648, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1648)]
	public class AKuroCSGenericCloth : AKuroBPActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060056FA RID: 22266 RVA: 0x0007A9C9 File Offset: 0x00078BC9
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AKuroCSGenericCloth._ClassPtr;
		}

		// Token: 0x060056FB RID: 22267 RVA: 0x0007A9D8 File Offset: 0x00078BD8
		public AKuroCSGenericCloth() : this(BuiltinUtils.AllocNativeUObject(AKuroCSGenericCloth.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060056FC RID: 22268 RVA: 0x0007AA00 File Offset: 0x00078C00
		[NullableContext(1)]
		public AKuroCSGenericCloth(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AKuroCSGenericCloth.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700110F RID: 4367
		// (get) Token: 0x060056FD RID: 22269 RVA: 0x0007AA33 File Offset: 0x00078C33
		// (set) Token: 0x060056FE RID: 22270 RVA: 0x0007AA47 File Offset: 0x00078C47
		public unsafe USceneComponent Root
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroCSGenericCloth.__PropertyOffset_Root);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroCSGenericCloth.__PropertyOffset_Root, value);
			}
		}

		// Token: 0x17001110 RID: 4368
		// (get) Token: 0x060056FF RID: 22271 RVA: 0x0007AA5C File Offset: 0x00078C5C
		// (set) Token: 0x06005700 RID: 22272 RVA: 0x0007AA6C File Offset: 0x00078C6C
		public unsafe bool useExternalRT
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSGenericCloth.__PropertyOffset_useExternalRT) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSGenericCloth.__PropertyOffset_useExternalRT) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001111 RID: 4369
		// (get) Token: 0x06005701 RID: 22273 RVA: 0x0007AA7D File Offset: 0x00078C7D
		// (set) Token: 0x06005702 RID: 22274 RVA: 0x0007AA91 File Offset: 0x00078C91
		public unsafe UTextureRenderTarget2D RenderTarget
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTarget2D>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroCSGenericCloth.__PropertyOffset_RenderTarget);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroCSGenericCloth.__PropertyOffset_RenderTarget, value);
			}
		}

		// Token: 0x17001112 RID: 4370
		// (get) Token: 0x06005703 RID: 22275 RVA: 0x0007AAA6 File Offset: 0x00078CA6
		// (set) Token: 0x06005704 RID: 22276 RVA: 0x0007AABA File Offset: 0x00078CBA
		public unsafe UTextureRenderTarget2D RenderTarget_N
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTarget2D>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroCSGenericCloth.__PropertyOffset_RenderTarget_N);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroCSGenericCloth.__PropertyOffset_RenderTarget_N, value);
			}
		}

		// Token: 0x17001113 RID: 4371
		// (get) Token: 0x06005705 RID: 22277 RVA: 0x0007AACF File Offset: 0x00078CCF
		// (set) Token: 0x06005706 RID: 22278 RVA: 0x0007AADF File Offset: 0x00078CDF
		public unsafe float DisStiffness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSGenericCloth.__PropertyOffset_DisStiffness);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSGenericCloth.__PropertyOffset_DisStiffness) = value;
			}
		}

		// Token: 0x17001114 RID: 4372
		// (get) Token: 0x06005707 RID: 22279 RVA: 0x0007AAF0 File Offset: 0x00078CF0
		// (set) Token: 0x06005708 RID: 22280 RVA: 0x0007AB00 File Offset: 0x00078D00
		public unsafe int revertOrNot
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSGenericCloth.__PropertyOffset_revertOrNot);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSGenericCloth.__PropertyOffset_revertOrNot) = value;
			}
		}

		// Token: 0x17001115 RID: 4373
		// (get) Token: 0x06005709 RID: 22281 RVA: 0x0007AB11 File Offset: 0x00078D11
		// (set) Token: 0x0600570A RID: 22282 RVA: 0x0007AB25 File Offset: 0x00078D25
		public unsafe FVector playerPos
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSGenericCloth.__PropertyOffset_playerPos);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSGenericCloth.__PropertyOffset_playerPos) = value;
			}
		}

		// Token: 0x17001116 RID: 4374
		// (get) Token: 0x0600570B RID: 22283 RVA: 0x0007AB3A File Offset: 0x00078D3A
		// (set) Token: 0x0600570C RID: 22284 RVA: 0x0007AB4A File Offset: 0x00078D4A
		public unsafe float collisionR
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSGenericCloth.__PropertyOffset_collisionR);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSGenericCloth.__PropertyOffset_collisionR) = value;
			}
		}

		// Token: 0x17001117 RID: 4375
		// (get) Token: 0x0600570D RID: 22285 RVA: 0x0007AB5B File Offset: 0x00078D5B
		// (set) Token: 0x0600570E RID: 22286 RVA: 0x0007AB6B File Offset: 0x00078D6B
		public unsafe int ParticleCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSGenericCloth.__PropertyOffset_ParticleCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSGenericCloth.__PropertyOffset_ParticleCount) = value;
			}
		}

		// Token: 0x17001118 RID: 4376
		// (get) Token: 0x0600570F RID: 22287 RVA: 0x0007AB7C File Offset: 0x00078D7C
		// (set) Token: 0x06005710 RID: 22288 RVA: 0x0007AB8C File Offset: 0x00078D8C
		public unsafe float linkDis
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSGenericCloth.__PropertyOffset_linkDis);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSGenericCloth.__PropertyOffset_linkDis) = value;
			}
		}

		// Token: 0x17001119 RID: 4377
		// (get) Token: 0x06005711 RID: 22289 RVA: 0x0007AB9D File Offset: 0x00078D9D
		// (set) Token: 0x06005712 RID: 22290 RVA: 0x0007ABAD File Offset: 0x00078DAD
		public unsafe float moveableDis
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSGenericCloth.__PropertyOffset_moveableDis);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSGenericCloth.__PropertyOffset_moveableDis) = value;
			}
		}

		// Token: 0x1700111A RID: 4378
		// (get) Token: 0x06005713 RID: 22291 RVA: 0x0007ABBE File Offset: 0x00078DBE
		// (set) Token: 0x06005714 RID: 22292 RVA: 0x0007ABCE File Offset: 0x00078DCE
		public unsafe int substepCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSGenericCloth.__PropertyOffset_substepCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSGenericCloth.__PropertyOffset_substepCount) = value;
			}
		}

		// Token: 0x1700111B RID: 4379
		// (get) Token: 0x06005715 RID: 22293 RVA: 0x0007ABDF File Offset: 0x00078DDF
		// (set) Token: 0x06005716 RID: 22294 RVA: 0x0007ABF3 File Offset: 0x00078DF3
		public unsafe FVector accel_ext
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSGenericCloth.__PropertyOffset_accel_ext);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSGenericCloth.__PropertyOffset_accel_ext) = value;
			}
		}

		// Token: 0x1700111C RID: 4380
		// (get) Token: 0x06005717 RID: 22295 RVA: 0x0007AC08 File Offset: 0x00078E08
		// (set) Token: 0x06005718 RID: 22296 RVA: 0x0007AC1C File Offset: 0x00078E1C
		public unsafe FVector actorPos
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSGenericCloth.__PropertyOffset_actorPos);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSGenericCloth.__PropertyOffset_actorPos) = value;
			}
		}

		// Token: 0x1700111D RID: 4381
		// (get) Token: 0x06005719 RID: 22297 RVA: 0x0007AC31 File Offset: 0x00078E31
		// (set) Token: 0x0600571A RID: 22298 RVA: 0x0007AC45 File Offset: 0x00078E45
		public unsafe FVector actorRotator
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSGenericCloth.__PropertyOffset_actorRotator);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSGenericCloth.__PropertyOffset_actorRotator) = value;
			}
		}

		// Token: 0x1700111E RID: 4382
		// (get) Token: 0x0600571B RID: 22299 RVA: 0x0007AC5A File Offset: 0x00078E5A
		// (set) Token: 0x0600571C RID: 22300 RVA: 0x0007AC6A File Offset: 0x00078E6A
		public unsafe bool bEnableCPURead
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSGenericCloth.__PropertyOffset_bEnableCPURead) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSGenericCloth.__PropertyOffset_bEnableCPURead) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700111F RID: 4383
		// (get) Token: 0x0600571D RID: 22301 RVA: 0x0007AC7B File Offset: 0x00078E7B
		// (set) Token: 0x0600571E RID: 22302 RVA: 0x0007AC8B File Offset: 0x00078E8B
		public unsafe int XCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSGenericCloth.__PropertyOffset_XCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSGenericCloth.__PropertyOffset_XCount) = value;
			}
		}

		// Token: 0x17001120 RID: 4384
		// (get) Token: 0x0600571F RID: 22303 RVA: 0x0007AC9C File Offset: 0x00078E9C
		// (set) Token: 0x06005720 RID: 22304 RVA: 0x0007ACAC File Offset: 0x00078EAC
		public unsafe float springK
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSGenericCloth.__PropertyOffset_springK);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSGenericCloth.__PropertyOffset_springK) = value;
			}
		}

		// Token: 0x17001121 RID: 4385
		// (get) Token: 0x06005721 RID: 22305 RVA: 0x0007ACBD File Offset: 0x00078EBD
		// (set) Token: 0x06005722 RID: 22306 RVA: 0x0007ACCD File Offset: 0x00078ECD
		public unsafe float springC
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSGenericCloth.__PropertyOffset_springC);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSGenericCloth.__PropertyOffset_springC) = value;
			}
		}

		// Token: 0x17001122 RID: 4386
		// (get) Token: 0x06005723 RID: 22307 RVA: 0x0007ACDE File Offset: 0x00078EDE
		// (set) Token: 0x06005724 RID: 22308 RVA: 0x0007ACEE File Offset: 0x00078EEE
		public unsafe float pushStrength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSGenericCloth.__PropertyOffset_pushStrength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSGenericCloth.__PropertyOffset_pushStrength) = value;
			}
		}

		// Token: 0x17001123 RID: 4387
		// (get) Token: 0x06005725 RID: 22309 RVA: 0x0007ACFF File Offset: 0x00078EFF
		// (set) Token: 0x06005726 RID: 22310 RVA: 0x0007AD0F File Offset: 0x00078F0F
		public unsafe int forcePlayerCol
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSGenericCloth.__PropertyOffset_forcePlayerCol);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSGenericCloth.__PropertyOffset_forcePlayerCol) = value;
			}
		}

		// Token: 0x17001124 RID: 4388
		// (get) Token: 0x06005727 RID: 22311 RVA: 0x0007AD20 File Offset: 0x00078F20
		// (set) Token: 0x06005728 RID: 22312 RVA: 0x0007AD30 File Offset: 0x00078F30
		public unsafe int lockXYZ
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSGenericCloth.__PropertyOffset_lockXYZ);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSGenericCloth.__PropertyOffset_lockXYZ) = value;
			}
		}

		// Token: 0x17001125 RID: 4389
		// (get) Token: 0x06005729 RID: 22313 RVA: 0x0007AD41 File Offset: 0x00078F41
		// (set) Token: 0x0600572A RID: 22314 RVA: 0x0007AD51 File Offset: 0x00078F51
		public unsafe float deltaTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSGenericCloth.__PropertyOffset_deltaTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSGenericCloth.__PropertyOffset_deltaTime) = value;
			}
		}

		// Token: 0x17001126 RID: 4390
		// (get) Token: 0x0600572B RID: 22315 RVA: 0x0007AD62 File Offset: 0x00078F62
		// (set) Token: 0x0600572C RID: 22316 RVA: 0x0007AD72 File Offset: 0x00078F72
		public unsafe int attackOrNot
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSGenericCloth.__PropertyOffset_attackOrNot);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSGenericCloth.__PropertyOffset_attackOrNot) = value;
			}
		}

		// Token: 0x17001127 RID: 4391
		// (get) Token: 0x0600572D RID: 22317 RVA: 0x0007AD83 File Offset: 0x00078F83
		// (set) Token: 0x0600572E RID: 22318 RVA: 0x0007AD93 File Offset: 0x00078F93
		public unsafe int overlapOrNot
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSGenericCloth.__PropertyOffset_overlapOrNot);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSGenericCloth.__PropertyOffset_overlapOrNot) = value;
			}
		}

		// Token: 0x17001128 RID: 4392
		// (get) Token: 0x0600572F RID: 22319 RVA: 0x0007ADA4 File Offset: 0x00078FA4
		// (set) Token: 0x06005730 RID: 22320 RVA: 0x0007ADB4 File Offset: 0x00078FB4
		public unsafe int useStaticCol
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSGenericCloth.__PropertyOffset_useStaticCol);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSGenericCloth.__PropertyOffset_useStaticCol) = value;
			}
		}

		// Token: 0x06005731 RID: 22321 RVA: 0x0007ADC5 File Offset: 0x00078FC5
		public void StopSimulation()
		{
			AKuroCSGenericCloth.__StopSimulation_Internal(base.NativePtr);
		}

		// Token: 0x06005732 RID: 22322 RVA: 0x0007ADD2 File Offset: 0x00078FD2
		public void StartSimulation()
		{
			AKuroCSGenericCloth.__StartSimulation_Internal(base.NativePtr);
		}

		// Token: 0x06005733 RID: 22323 RVA: 0x0007ADDF File Offset: 0x00078FDF
		public void ReleaseShaderManager()
		{
			AKuroCSGenericCloth.__ReleaseShaderManager_Internal(base.NativePtr);
		}

		// Token: 0x06005734 RID: 22324 RVA: 0x0007ADEC File Offset: 0x00078FEC
		public void InitShaderManager()
		{
			AKuroCSGenericCloth.__InitShaderManager_Internal(base.NativePtr);
		}

		// Token: 0x06005735 RID: 22325
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __StopSimulation_Internal(IntPtr @this);

		// Token: 0x06005736 RID: 22326
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __StartSimulation_Internal(IntPtr @this);

		// Token: 0x06005737 RID: 22327
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ReleaseShaderManager_Internal(IntPtr @this);

		// Token: 0x06005738 RID: 22328
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __InitShaderManager_Internal(IntPtr @this);

		// Token: 0x06005739 RID: 22329 RVA: 0x0007ADF9 File Offset: 0x00078FF9
		static AKuroCSGenericCloth()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroComputeShader.KuroCSGenericCloth");
		}

		// Token: 0x0600573A RID: 22330 RVA: 0x0007AE07 File Offset: 0x00079007
		protected AKuroCSGenericCloth(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040023CB RID: 9163
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroComputeShader.KuroCSGenericCloth";

		// Token: 0x040023CC RID: 9164
		private static IntPtr _ClassPtr;

		// Token: 0x040023CD RID: 9165
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040023CE RID: 9166
		internal static int __PropertyOffset_Root;

		// Token: 0x040023CF RID: 9167
		internal static int __PropertyOffset_useExternalRT;

		// Token: 0x040023D0 RID: 9168
		internal static int __PropertyOffset_RenderTarget;

		// Token: 0x040023D1 RID: 9169
		internal static int __PropertyOffset_RenderTarget_N;

		// Token: 0x040023D2 RID: 9170
		internal static int __PropertyOffset_DisStiffness;

		// Token: 0x040023D3 RID: 9171
		internal static int __PropertyOffset_revertOrNot;

		// Token: 0x040023D4 RID: 9172
		internal static int __PropertyOffset_playerPos;

		// Token: 0x040023D5 RID: 9173
		internal static int __PropertyOffset_collisionR;

		// Token: 0x040023D6 RID: 9174
		internal static int __PropertyOffset_ParticleCount;

		// Token: 0x040023D7 RID: 9175
		internal static int __PropertyOffset_linkDis;

		// Token: 0x040023D8 RID: 9176
		internal static int __PropertyOffset_moveableDis;

		// Token: 0x040023D9 RID: 9177
		internal static int __PropertyOffset_substepCount;

		// Token: 0x040023DA RID: 9178
		internal static int __PropertyOffset_accel_ext;

		// Token: 0x040023DB RID: 9179
		internal static int __PropertyOffset_actorPos;

		// Token: 0x040023DC RID: 9180
		internal static int __PropertyOffset_actorRotator;

		// Token: 0x040023DD RID: 9181
		internal static int __PropertyOffset_bEnableCPURead;

		// Token: 0x040023DE RID: 9182
		internal static int __PropertyOffset_XCount;

		// Token: 0x040023DF RID: 9183
		internal static int __PropertyOffset_springK;

		// Token: 0x040023E0 RID: 9184
		internal static int __PropertyOffset_springC;

		// Token: 0x040023E1 RID: 9185
		internal static int __PropertyOffset_pushStrength;

		// Token: 0x040023E2 RID: 9186
		internal static int __PropertyOffset_forcePlayerCol;

		// Token: 0x040023E3 RID: 9187
		internal static int __PropertyOffset_lockXYZ;

		// Token: 0x040023E4 RID: 9188
		internal static int __PropertyOffset_deltaTime;

		// Token: 0x040023E5 RID: 9189
		internal static int __PropertyOffset_attackOrNot;

		// Token: 0x040023E6 RID: 9190
		internal static int __PropertyOffset_overlapOrNot;

		// Token: 0x040023E7 RID: 9191
		internal static int __PropertyOffset_useStaticCol;
	}
}
