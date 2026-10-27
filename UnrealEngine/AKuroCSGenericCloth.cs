using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020017AD RID: 6061
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroComputeShader.KuroCSGenericCloth")]
	[UnrealStructLayout(1648, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1648)]
	public class AKuroCSGenericCloth : AKuroBPActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06015F51 RID: 89937 RVA: 0x002031F6 File Offset: 0x002013F6
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AKuroCSGenericCloth._ClassPtr;
		}

		// Token: 0x06015F52 RID: 89938 RVA: 0x00203204 File Offset: 0x00201404
		public AKuroCSGenericCloth() : this(BuiltinUtils.AllocNativeUObject(AKuroCSGenericCloth.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06015F53 RID: 89939 RVA: 0x0020322C File Offset: 0x0020142C
		public AKuroCSGenericCloth(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AKuroCSGenericCloth.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005749 RID: 22345
		// (get) Token: 0x06015F54 RID: 89940 RVA: 0x0020325F File Offset: 0x0020145F
		// (set) Token: 0x06015F55 RID: 89941 RVA: 0x00203273 File Offset: 0x00201473
		[Nullable(2)]
		public unsafe USceneComponent Root
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroCSGenericCloth.__PropertyOffset_Root);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroCSGenericCloth.__PropertyOffset_Root, value);
			}
		}

		// Token: 0x1700574A RID: 22346
		// (get) Token: 0x06015F56 RID: 89942 RVA: 0x00203288 File Offset: 0x00201488
		// (set) Token: 0x06015F57 RID: 89943 RVA: 0x00203298 File Offset: 0x00201498
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

		// Token: 0x1700574B RID: 22347
		// (get) Token: 0x06015F58 RID: 89944 RVA: 0x002032A9 File Offset: 0x002014A9
		// (set) Token: 0x06015F59 RID: 89945 RVA: 0x002032BD File Offset: 0x002014BD
		[Nullable(2)]
		public unsafe UTextureRenderTarget2D RenderTarget
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTarget2D>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroCSGenericCloth.__PropertyOffset_RenderTarget);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroCSGenericCloth.__PropertyOffset_RenderTarget, value);
			}
		}

		// Token: 0x1700574C RID: 22348
		// (get) Token: 0x06015F5A RID: 89946 RVA: 0x002032D2 File Offset: 0x002014D2
		// (set) Token: 0x06015F5B RID: 89947 RVA: 0x002032E6 File Offset: 0x002014E6
		[Nullable(2)]
		public unsafe UTextureRenderTarget2D RenderTarget_N
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTarget2D>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroCSGenericCloth.__PropertyOffset_RenderTarget_N);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroCSGenericCloth.__PropertyOffset_RenderTarget_N, value);
			}
		}

		// Token: 0x1700574D RID: 22349
		// (get) Token: 0x06015F5C RID: 89948 RVA: 0x002032FC File Offset: 0x002014FC
		// (set) Token: 0x06015F5D RID: 89949 RVA: 0x00203335 File Offset: 0x00201535
		public TArray<FKuroCSParticle_genericCloth> DebugArr
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FKuroCSParticle_genericCloth> result;
				if ((result = this._DebugArr) == null)
				{
					result = (this._DebugArr = new TArray<FKuroCSParticle_genericCloth>(base.NativePtr + (IntPtr)AKuroCSGenericCloth.__PropertyOffset_DebugArr, this));
				}
				return result;
			}
			set
			{
				this.DebugArr.CopyAssign(value);
			}
		}

		// Token: 0x1700574E RID: 22350
		// (get) Token: 0x06015F5E RID: 89950 RVA: 0x00203343 File Offset: 0x00201543
		// (set) Token: 0x06015F5F RID: 89951 RVA: 0x00203353 File Offset: 0x00201553
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

		// Token: 0x1700574F RID: 22351
		// (get) Token: 0x06015F60 RID: 89952 RVA: 0x00203364 File Offset: 0x00201564
		// (set) Token: 0x06015F61 RID: 89953 RVA: 0x00203374 File Offset: 0x00201574
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

		// Token: 0x17005750 RID: 22352
		// (get) Token: 0x06015F62 RID: 89954 RVA: 0x00203385 File Offset: 0x00201585
		// (set) Token: 0x06015F63 RID: 89955 RVA: 0x00203399 File Offset: 0x00201599
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

		// Token: 0x17005751 RID: 22353
		// (get) Token: 0x06015F64 RID: 89956 RVA: 0x002033AE File Offset: 0x002015AE
		// (set) Token: 0x06015F65 RID: 89957 RVA: 0x002033BE File Offset: 0x002015BE
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

		// Token: 0x17005752 RID: 22354
		// (get) Token: 0x06015F66 RID: 89958 RVA: 0x002033CF File Offset: 0x002015CF
		// (set) Token: 0x06015F67 RID: 89959 RVA: 0x002033DF File Offset: 0x002015DF
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

		// Token: 0x17005753 RID: 22355
		// (get) Token: 0x06015F68 RID: 89960 RVA: 0x002033F0 File Offset: 0x002015F0
		// (set) Token: 0x06015F69 RID: 89961 RVA: 0x00203400 File Offset: 0x00201600
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

		// Token: 0x17005754 RID: 22356
		// (get) Token: 0x06015F6A RID: 89962 RVA: 0x00203411 File Offset: 0x00201611
		// (set) Token: 0x06015F6B RID: 89963 RVA: 0x00203421 File Offset: 0x00201621
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

		// Token: 0x17005755 RID: 22357
		// (get) Token: 0x06015F6C RID: 89964 RVA: 0x00203432 File Offset: 0x00201632
		// (set) Token: 0x06015F6D RID: 89965 RVA: 0x00203442 File Offset: 0x00201642
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

		// Token: 0x17005756 RID: 22358
		// (get) Token: 0x06015F6E RID: 89966 RVA: 0x00203453 File Offset: 0x00201653
		// (set) Token: 0x06015F6F RID: 89967 RVA: 0x00203467 File Offset: 0x00201667
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

		// Token: 0x17005757 RID: 22359
		// (get) Token: 0x06015F70 RID: 89968 RVA: 0x0020347C File Offset: 0x0020167C
		// (set) Token: 0x06015F71 RID: 89969 RVA: 0x00203490 File Offset: 0x00201690
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

		// Token: 0x17005758 RID: 22360
		// (get) Token: 0x06015F72 RID: 89970 RVA: 0x002034A5 File Offset: 0x002016A5
		// (set) Token: 0x06015F73 RID: 89971 RVA: 0x002034B9 File Offset: 0x002016B9
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

		// Token: 0x17005759 RID: 22361
		// (get) Token: 0x06015F74 RID: 89972 RVA: 0x002034CE File Offset: 0x002016CE
		// (set) Token: 0x06015F75 RID: 89973 RVA: 0x002034DE File Offset: 0x002016DE
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

		// Token: 0x1700575A RID: 22362
		// (get) Token: 0x06015F76 RID: 89974 RVA: 0x002034EF File Offset: 0x002016EF
		// (set) Token: 0x06015F77 RID: 89975 RVA: 0x002034FF File Offset: 0x002016FF
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

		// Token: 0x1700575B RID: 22363
		// (get) Token: 0x06015F78 RID: 89976 RVA: 0x00203510 File Offset: 0x00201710
		// (set) Token: 0x06015F79 RID: 89977 RVA: 0x00203520 File Offset: 0x00201720
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

		// Token: 0x1700575C RID: 22364
		// (get) Token: 0x06015F7A RID: 89978 RVA: 0x00203531 File Offset: 0x00201731
		// (set) Token: 0x06015F7B RID: 89979 RVA: 0x00203541 File Offset: 0x00201741
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

		// Token: 0x1700575D RID: 22365
		// (get) Token: 0x06015F7C RID: 89980 RVA: 0x00203552 File Offset: 0x00201752
		// (set) Token: 0x06015F7D RID: 89981 RVA: 0x00203562 File Offset: 0x00201762
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

		// Token: 0x1700575E RID: 22366
		// (get) Token: 0x06015F7E RID: 89982 RVA: 0x00203573 File Offset: 0x00201773
		// (set) Token: 0x06015F7F RID: 89983 RVA: 0x00203583 File Offset: 0x00201783
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

		// Token: 0x1700575F RID: 22367
		// (get) Token: 0x06015F80 RID: 89984 RVA: 0x00203594 File Offset: 0x00201794
		// (set) Token: 0x06015F81 RID: 89985 RVA: 0x002035A4 File Offset: 0x002017A4
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

		// Token: 0x17005760 RID: 22368
		// (get) Token: 0x06015F82 RID: 89986 RVA: 0x002035B5 File Offset: 0x002017B5
		// (set) Token: 0x06015F83 RID: 89987 RVA: 0x002035C5 File Offset: 0x002017C5
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

		// Token: 0x17005761 RID: 22369
		// (get) Token: 0x06015F84 RID: 89988 RVA: 0x002035D6 File Offset: 0x002017D6
		// (set) Token: 0x06015F85 RID: 89989 RVA: 0x002035E6 File Offset: 0x002017E6
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

		// Token: 0x17005762 RID: 22370
		// (get) Token: 0x06015F86 RID: 89990 RVA: 0x002035F7 File Offset: 0x002017F7
		// (set) Token: 0x06015F87 RID: 89991 RVA: 0x00203607 File Offset: 0x00201807
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

		// Token: 0x17005763 RID: 22371
		// (get) Token: 0x06015F88 RID: 89992 RVA: 0x00203618 File Offset: 0x00201818
		// (set) Token: 0x06015F89 RID: 89993 RVA: 0x00203651 File Offset: 0x00201851
		public TArray<FKuroCSParticle_genericCloth> ParticlesArr
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FKuroCSParticle_genericCloth> result;
				if ((result = this._ParticlesArr) == null)
				{
					result = (this._ParticlesArr = new TArray<FKuroCSParticle_genericCloth>(base.NativePtr + (IntPtr)AKuroCSGenericCloth.__PropertyOffset_ParticlesArr, this));
				}
				return result;
			}
			set
			{
				this.ParticlesArr.CopyAssign(value);
			}
		}

		// Token: 0x17005764 RID: 22372
		// (get) Token: 0x06015F8A RID: 89994 RVA: 0x00203660 File Offset: 0x00201860
		// (set) Token: 0x06015F8B RID: 89995 RVA: 0x00203699 File Offset: 0x00201899
		public TArray<FKuroCSUnifiedCollider_genericCloth> Colliders
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FKuroCSUnifiedCollider_genericCloth> result;
				if ((result = this._Colliders) == null)
				{
					result = (this._Colliders = new TArray<FKuroCSUnifiedCollider_genericCloth>(base.NativePtr + (IntPtr)AKuroCSGenericCloth.__PropertyOffset_Colliders, this));
				}
				return result;
			}
			set
			{
				this.Colliders.CopyAssign(value);
			}
		}

		// Token: 0x17005765 RID: 22373
		// (get) Token: 0x06015F8C RID: 89996 RVA: 0x002036A7 File Offset: 0x002018A7
		// (set) Token: 0x06015F8D RID: 89997 RVA: 0x002036B7 File Offset: 0x002018B7
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

		// Token: 0x06015F8E RID: 89998 RVA: 0x002036C8 File Offset: 0x002018C8
		public void StopSimulation()
		{
			AKuroCSGenericCloth.__StopSimulation_Internal(base.NativePtr);
		}

		// Token: 0x06015F8F RID: 89999 RVA: 0x002036D5 File Offset: 0x002018D5
		public void StartSimulation()
		{
			AKuroCSGenericCloth.__StartSimulation_Internal(base.NativePtr);
		}

		// Token: 0x06015F90 RID: 90000 RVA: 0x002036E2 File Offset: 0x002018E2
		public void ReleaseShaderManager()
		{
			AKuroCSGenericCloth.__ReleaseShaderManager_Internal(base.NativePtr);
		}

		// Token: 0x06015F91 RID: 90001 RVA: 0x002036EF File Offset: 0x002018EF
		public void InitShaderManager()
		{
			AKuroCSGenericCloth.__InitShaderManager_Internal(base.NativePtr);
		}

		// Token: 0x06015F92 RID: 90002
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __StopSimulation_Internal(IntPtr @this);

		// Token: 0x06015F93 RID: 90003
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __StartSimulation_Internal(IntPtr @this);

		// Token: 0x06015F94 RID: 90004
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ReleaseShaderManager_Internal(IntPtr @this);

		// Token: 0x06015F95 RID: 90005
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __InitShaderManager_Internal(IntPtr @this);

		// Token: 0x06015F96 RID: 90006 RVA: 0x002036FC File Offset: 0x002018FC
		static AKuroCSGenericCloth()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroComputeShader.KuroCSGenericCloth");
		}

		// Token: 0x06015F97 RID: 90007 RVA: 0x0020370A File Offset: 0x0020190A
		protected AKuroCSGenericCloth(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400BF6A RID: 49002
		public new const string __ObjectPath = "/Script/KuroComputeShader.KuroCSGenericCloth";

		// Token: 0x0400BF6B RID: 49003
		private static IntPtr _ClassPtr;

		// Token: 0x0400BF6C RID: 49004
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400BF6D RID: 49005
		internal static int __PropertyOffset_Root;

		// Token: 0x0400BF6E RID: 49006
		internal static int __PropertyOffset_useExternalRT;

		// Token: 0x0400BF6F RID: 49007
		internal static int __PropertyOffset_RenderTarget;

		// Token: 0x0400BF70 RID: 49008
		internal static int __PropertyOffset_RenderTarget_N;

		// Token: 0x0400BF71 RID: 49009
		internal static int __PropertyOffset_DebugArr;

		// Token: 0x0400BF72 RID: 49010
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKuroCSParticle_genericCloth> _DebugArr;

		// Token: 0x0400BF73 RID: 49011
		internal static int __PropertyOffset_DisStiffness;

		// Token: 0x0400BF74 RID: 49012
		internal static int __PropertyOffset_revertOrNot;

		// Token: 0x0400BF75 RID: 49013
		internal static int __PropertyOffset_playerPos;

		// Token: 0x0400BF76 RID: 49014
		internal static int __PropertyOffset_collisionR;

		// Token: 0x0400BF77 RID: 49015
		internal static int __PropertyOffset_ParticleCount;

		// Token: 0x0400BF78 RID: 49016
		internal static int __PropertyOffset_linkDis;

		// Token: 0x0400BF79 RID: 49017
		internal static int __PropertyOffset_moveableDis;

		// Token: 0x0400BF7A RID: 49018
		internal static int __PropertyOffset_substepCount;

		// Token: 0x0400BF7B RID: 49019
		internal static int __PropertyOffset_accel_ext;

		// Token: 0x0400BF7C RID: 49020
		internal static int __PropertyOffset_actorPos;

		// Token: 0x0400BF7D RID: 49021
		internal static int __PropertyOffset_actorRotator;

		// Token: 0x0400BF7E RID: 49022
		internal static int __PropertyOffset_bEnableCPURead;

		// Token: 0x0400BF7F RID: 49023
		internal static int __PropertyOffset_XCount;

		// Token: 0x0400BF80 RID: 49024
		internal static int __PropertyOffset_springK;

		// Token: 0x0400BF81 RID: 49025
		internal static int __PropertyOffset_springC;

		// Token: 0x0400BF82 RID: 49026
		internal static int __PropertyOffset_pushStrength;

		// Token: 0x0400BF83 RID: 49027
		internal static int __PropertyOffset_forcePlayerCol;

		// Token: 0x0400BF84 RID: 49028
		internal static int __PropertyOffset_lockXYZ;

		// Token: 0x0400BF85 RID: 49029
		internal static int __PropertyOffset_deltaTime;

		// Token: 0x0400BF86 RID: 49030
		internal static int __PropertyOffset_attackOrNot;

		// Token: 0x0400BF87 RID: 49031
		internal static int __PropertyOffset_overlapOrNot;

		// Token: 0x0400BF88 RID: 49032
		internal static int __PropertyOffset_ParticlesArr;

		// Token: 0x0400BF89 RID: 49033
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKuroCSParticle_genericCloth> _ParticlesArr;

		// Token: 0x0400BF8A RID: 49034
		internal static int __PropertyOffset_Colliders;

		// Token: 0x0400BF8B RID: 49035
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKuroCSUnifiedCollider_genericCloth> _Colliders;

		// Token: 0x0400BF8C RID: 49036
		internal static int __PropertyOffset_useStaticCol;
	}
}
