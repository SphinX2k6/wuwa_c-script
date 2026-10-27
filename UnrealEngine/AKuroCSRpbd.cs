using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020017C8 RID: 6088
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroComputeShader.KuroCSRpbd")]
	[UnrealStructLayout(1616, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1616)]
	public class AKuroCSRpbd : AKuroPhysicActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601649C RID: 91292 RVA: 0x00209C79 File Offset: 0x00207E79
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AKuroCSRpbd._ClassPtr;
		}

		// Token: 0x0601649D RID: 91293 RVA: 0x00209C88 File Offset: 0x00207E88
		public AKuroCSRpbd() : this(BuiltinUtils.AllocNativeUObject(AKuroCSRpbd.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601649E RID: 91294 RVA: 0x00209CB0 File Offset: 0x00207EB0
		public AKuroCSRpbd(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AKuroCSRpbd.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005975 RID: 22901
		// (get) Token: 0x0601649F RID: 91295 RVA: 0x00209CE3 File Offset: 0x00207EE3
		// (set) Token: 0x060164A0 RID: 91296 RVA: 0x00209CF7 File Offset: 0x00207EF7
		[Nullable(2)]
		public unsafe USceneComponent Root
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroCSRpbd.__PropertyOffset_Root);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroCSRpbd.__PropertyOffset_Root, value);
			}
		}

		// Token: 0x17005976 RID: 22902
		// (get) Token: 0x060164A1 RID: 91297 RVA: 0x00209D0C File Offset: 0x00207F0C
		// (set) Token: 0x060164A2 RID: 91298 RVA: 0x00209D1C File Offset: 0x00207F1C
		public unsafe bool useExternalRT
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSRpbd.__PropertyOffset_useExternalRT) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSRpbd.__PropertyOffset_useExternalRT) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005977 RID: 22903
		// (get) Token: 0x060164A3 RID: 91299 RVA: 0x00209D2D File Offset: 0x00207F2D
		// (set) Token: 0x060164A4 RID: 91300 RVA: 0x00209D41 File Offset: 0x00207F41
		[Nullable(2)]
		public unsafe UTextureRenderTarget2D RenderTarget
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTarget2D>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroCSRpbd.__PropertyOffset_RenderTarget);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroCSRpbd.__PropertyOffset_RenderTarget, value);
			}
		}

		// Token: 0x17005978 RID: 22904
		// (get) Token: 0x060164A5 RID: 91301 RVA: 0x00209D58 File Offset: 0x00207F58
		// (set) Token: 0x060164A6 RID: 91302 RVA: 0x00209D91 File Offset: 0x00207F91
		public TArray<FKuroCSParticle_rpbd> DebugArr
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FKuroCSParticle_rpbd> result;
				if ((result = this._DebugArr) == null)
				{
					result = (this._DebugArr = new TArray<FKuroCSParticle_rpbd>(base.NativePtr + (IntPtr)AKuroCSRpbd.__PropertyOffset_DebugArr, this));
				}
				return result;
			}
			set
			{
				this.DebugArr.CopyAssign(value);
			}
		}

		// Token: 0x17005979 RID: 22905
		// (get) Token: 0x060164A7 RID: 91303 RVA: 0x00209D9F File Offset: 0x00207F9F
		// (set) Token: 0x060164A8 RID: 91304 RVA: 0x00209DAF File Offset: 0x00207FAF
		public unsafe float DisStiffness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSRpbd.__PropertyOffset_DisStiffness);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSRpbd.__PropertyOffset_DisStiffness) = value;
			}
		}

		// Token: 0x1700597A RID: 22906
		// (get) Token: 0x060164A9 RID: 91305 RVA: 0x00209DC0 File Offset: 0x00207FC0
		// (set) Token: 0x060164AA RID: 91306 RVA: 0x00209DD0 File Offset: 0x00207FD0
		public unsafe int revertOrNot
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSRpbd.__PropertyOffset_revertOrNot);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSRpbd.__PropertyOffset_revertOrNot) = value;
			}
		}

		// Token: 0x1700597B RID: 22907
		// (get) Token: 0x060164AB RID: 91307 RVA: 0x00209DE1 File Offset: 0x00207FE1
		// (set) Token: 0x060164AC RID: 91308 RVA: 0x00209DF5 File Offset: 0x00207FF5
		public unsafe FVector playerPos
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSRpbd.__PropertyOffset_playerPos);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSRpbd.__PropertyOffset_playerPos) = value;
			}
		}

		// Token: 0x1700597C RID: 22908
		// (get) Token: 0x060164AD RID: 91309 RVA: 0x00209E0A File Offset: 0x0020800A
		// (set) Token: 0x060164AE RID: 91310 RVA: 0x00209E1A File Offset: 0x0020801A
		public unsafe float collisionR
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSRpbd.__PropertyOffset_collisionR);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSRpbd.__PropertyOffset_collisionR) = value;
			}
		}

		// Token: 0x1700597D RID: 22909
		// (get) Token: 0x060164AF RID: 91311 RVA: 0x00209E2B File Offset: 0x0020802B
		// (set) Token: 0x060164B0 RID: 91312 RVA: 0x00209E3B File Offset: 0x0020803B
		public unsafe int ParticleCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSRpbd.__PropertyOffset_ParticleCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSRpbd.__PropertyOffset_ParticleCount) = value;
			}
		}

		// Token: 0x1700597E RID: 22910
		// (get) Token: 0x060164B1 RID: 91313 RVA: 0x00209E4C File Offset: 0x0020804C
		// (set) Token: 0x060164B2 RID: 91314 RVA: 0x00209E5C File Offset: 0x0020805C
		public unsafe float linkDis
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSRpbd.__PropertyOffset_linkDis);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSRpbd.__PropertyOffset_linkDis) = value;
			}
		}

		// Token: 0x1700597F RID: 22911
		// (get) Token: 0x060164B3 RID: 91315 RVA: 0x00209E6D File Offset: 0x0020806D
		// (set) Token: 0x060164B4 RID: 91316 RVA: 0x00209E7D File Offset: 0x0020807D
		public unsafe float moveableDis
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSRpbd.__PropertyOffset_moveableDis);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSRpbd.__PropertyOffset_moveableDis) = value;
			}
		}

		// Token: 0x17005980 RID: 22912
		// (get) Token: 0x060164B5 RID: 91317 RVA: 0x00209E8E File Offset: 0x0020808E
		// (set) Token: 0x060164B6 RID: 91318 RVA: 0x00209E9E File Offset: 0x0020809E
		public unsafe int substepCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSRpbd.__PropertyOffset_substepCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSRpbd.__PropertyOffset_substepCount) = value;
			}
		}

		// Token: 0x17005981 RID: 22913
		// (get) Token: 0x060164B7 RID: 91319 RVA: 0x00209EAF File Offset: 0x002080AF
		// (set) Token: 0x060164B8 RID: 91320 RVA: 0x00209EC3 File Offset: 0x002080C3
		public unsafe FVector accel_ext
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSRpbd.__PropertyOffset_accel_ext);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSRpbd.__PropertyOffset_accel_ext) = value;
			}
		}

		// Token: 0x17005982 RID: 22914
		// (get) Token: 0x060164B9 RID: 91321 RVA: 0x00209ED8 File Offset: 0x002080D8
		// (set) Token: 0x060164BA RID: 91322 RVA: 0x00209EEC File Offset: 0x002080EC
		public unsafe FVector actorPos
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSRpbd.__PropertyOffset_actorPos);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSRpbd.__PropertyOffset_actorPos) = value;
			}
		}

		// Token: 0x17005983 RID: 22915
		// (get) Token: 0x060164BB RID: 91323 RVA: 0x00209F01 File Offset: 0x00208101
		// (set) Token: 0x060164BC RID: 91324 RVA: 0x00209F15 File Offset: 0x00208115
		public unsafe FVector actorRotator
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSRpbd.__PropertyOffset_actorRotator);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSRpbd.__PropertyOffset_actorRotator) = value;
			}
		}

		// Token: 0x17005984 RID: 22916
		// (get) Token: 0x060164BD RID: 91325 RVA: 0x00209F2A File Offset: 0x0020812A
		// (set) Token: 0x060164BE RID: 91326 RVA: 0x00209F3A File Offset: 0x0020813A
		public unsafe bool bEnableCPURead
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSRpbd.__PropertyOffset_bEnableCPURead) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSRpbd.__PropertyOffset_bEnableCPURead) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005985 RID: 22917
		// (get) Token: 0x060164BF RID: 91327 RVA: 0x00209F4B File Offset: 0x0020814B
		// (set) Token: 0x060164C0 RID: 91328 RVA: 0x00209F5B File Offset: 0x0020815B
		public unsafe int XCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSRpbd.__PropertyOffset_XCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSRpbd.__PropertyOffset_XCount) = value;
			}
		}

		// Token: 0x17005986 RID: 22918
		// (get) Token: 0x060164C1 RID: 91329 RVA: 0x00209F6C File Offset: 0x0020816C
		// (set) Token: 0x060164C2 RID: 91330 RVA: 0x00209F7C File Offset: 0x0020817C
		public unsafe float springK
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSRpbd.__PropertyOffset_springK);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSRpbd.__PropertyOffset_springK) = value;
			}
		}

		// Token: 0x17005987 RID: 22919
		// (get) Token: 0x060164C3 RID: 91331 RVA: 0x00209F8D File Offset: 0x0020818D
		// (set) Token: 0x060164C4 RID: 91332 RVA: 0x00209F9D File Offset: 0x0020819D
		public unsafe float springC
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSRpbd.__PropertyOffset_springC);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSRpbd.__PropertyOffset_springC) = value;
			}
		}

		// Token: 0x17005988 RID: 22920
		// (get) Token: 0x060164C5 RID: 91333 RVA: 0x00209FAE File Offset: 0x002081AE
		// (set) Token: 0x060164C6 RID: 91334 RVA: 0x00209FBE File Offset: 0x002081BE
		public unsafe float pushStrength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSRpbd.__PropertyOffset_pushStrength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSRpbd.__PropertyOffset_pushStrength) = value;
			}
		}

		// Token: 0x17005989 RID: 22921
		// (get) Token: 0x060164C7 RID: 91335 RVA: 0x00209FCF File Offset: 0x002081CF
		// (set) Token: 0x060164C8 RID: 91336 RVA: 0x00209FDF File Offset: 0x002081DF
		public unsafe int RT2DOrNot
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSRpbd.__PropertyOffset_RT2DOrNot);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSRpbd.__PropertyOffset_RT2DOrNot) = value;
			}
		}

		// Token: 0x1700598A RID: 22922
		// (get) Token: 0x060164C9 RID: 91337 RVA: 0x00209FF0 File Offset: 0x002081F0
		// (set) Token: 0x060164CA RID: 91338 RVA: 0x0020A000 File Offset: 0x00208200
		public unsafe int lockXYZ
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSRpbd.__PropertyOffset_lockXYZ);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSRpbd.__PropertyOffset_lockXYZ) = value;
			}
		}

		// Token: 0x1700598B RID: 22923
		// (get) Token: 0x060164CB RID: 91339 RVA: 0x0020A011 File Offset: 0x00208211
		// (set) Token: 0x060164CC RID: 91340 RVA: 0x0020A021 File Offset: 0x00208221
		public unsafe float deltaTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSRpbd.__PropertyOffset_deltaTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSRpbd.__PropertyOffset_deltaTime) = value;
			}
		}

		// Token: 0x1700598C RID: 22924
		// (get) Token: 0x060164CD RID: 91341 RVA: 0x0020A032 File Offset: 0x00208232
		// (set) Token: 0x060164CE RID: 91342 RVA: 0x0020A042 File Offset: 0x00208242
		public unsafe int attackOrNot
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSRpbd.__PropertyOffset_attackOrNot);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSRpbd.__PropertyOffset_attackOrNot) = value;
			}
		}

		// Token: 0x1700598D RID: 22925
		// (get) Token: 0x060164CF RID: 91343 RVA: 0x0020A053 File Offset: 0x00208253
		// (set) Token: 0x060164D0 RID: 91344 RVA: 0x0020A063 File Offset: 0x00208263
		public unsafe int overlapOrNot
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSRpbd.__PropertyOffset_overlapOrNot);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSRpbd.__PropertyOffset_overlapOrNot) = value;
			}
		}

		// Token: 0x1700598E RID: 22926
		// (get) Token: 0x060164D1 RID: 91345 RVA: 0x0020A074 File Offset: 0x00208274
		// (set) Token: 0x060164D2 RID: 91346 RVA: 0x0020A0AD File Offset: 0x002082AD
		public TArray<FKuroCSParticle_rpbd> ParticlesArr
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FKuroCSParticle_rpbd> result;
				if ((result = this._ParticlesArr) == null)
				{
					result = (this._ParticlesArr = new TArray<FKuroCSParticle_rpbd>(base.NativePtr + (IntPtr)AKuroCSRpbd.__PropertyOffset_ParticlesArr, this));
				}
				return result;
			}
			set
			{
				this.ParticlesArr.CopyAssign(value);
			}
		}

		// Token: 0x060164D3 RID: 91347 RVA: 0x0020A0BB File Offset: 0x002082BB
		public void StopSimulation()
		{
			AKuroCSRpbd.__StopSimulation_Internal(base.NativePtr);
		}

		// Token: 0x060164D4 RID: 91348 RVA: 0x0020A0C8 File Offset: 0x002082C8
		public void StartSimulation()
		{
			AKuroCSRpbd.__StartSimulation_Internal(base.NativePtr);
		}

		// Token: 0x060164D5 RID: 91349 RVA: 0x0020A0D5 File Offset: 0x002082D5
		public void ReleaseShaderManager()
		{
			AKuroCSRpbd.__ReleaseShaderManager_Internal(base.NativePtr);
		}

		// Token: 0x060164D6 RID: 91350 RVA: 0x0020A0E2 File Offset: 0x002082E2
		public void InitShaderManager()
		{
			AKuroCSRpbd.__InitShaderManager_Internal(base.NativePtr);
		}

		// Token: 0x060164D7 RID: 91351
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __StopSimulation_Internal(IntPtr @this);

		// Token: 0x060164D8 RID: 91352
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __StartSimulation_Internal(IntPtr @this);

		// Token: 0x060164D9 RID: 91353
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ReleaseShaderManager_Internal(IntPtr @this);

		// Token: 0x060164DA RID: 91354
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __InitShaderManager_Internal(IntPtr @this);

		// Token: 0x060164DB RID: 91355 RVA: 0x0020A0EF File Offset: 0x002082EF
		static AKuroCSRpbd()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroComputeShader.KuroCSRpbd");
		}

		// Token: 0x060164DC RID: 91356 RVA: 0x0020A0FD File Offset: 0x002082FD
		protected AKuroCSRpbd(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400C1F1 RID: 49649
		public new const string __ObjectPath = "/Script/KuroComputeShader.KuroCSRpbd";

		// Token: 0x0400C1F2 RID: 49650
		private static IntPtr _ClassPtr;

		// Token: 0x0400C1F3 RID: 49651
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400C1F4 RID: 49652
		internal static int __PropertyOffset_Root;

		// Token: 0x0400C1F5 RID: 49653
		internal static int __PropertyOffset_useExternalRT;

		// Token: 0x0400C1F6 RID: 49654
		internal static int __PropertyOffset_RenderTarget;

		// Token: 0x0400C1F7 RID: 49655
		internal static int __PropertyOffset_DebugArr;

		// Token: 0x0400C1F8 RID: 49656
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKuroCSParticle_rpbd> _DebugArr;

		// Token: 0x0400C1F9 RID: 49657
		internal static int __PropertyOffset_DisStiffness;

		// Token: 0x0400C1FA RID: 49658
		internal static int __PropertyOffset_revertOrNot;

		// Token: 0x0400C1FB RID: 49659
		internal static int __PropertyOffset_playerPos;

		// Token: 0x0400C1FC RID: 49660
		internal static int __PropertyOffset_collisionR;

		// Token: 0x0400C1FD RID: 49661
		internal static int __PropertyOffset_ParticleCount;

		// Token: 0x0400C1FE RID: 49662
		internal static int __PropertyOffset_linkDis;

		// Token: 0x0400C1FF RID: 49663
		internal static int __PropertyOffset_moveableDis;

		// Token: 0x0400C200 RID: 49664
		internal static int __PropertyOffset_substepCount;

		// Token: 0x0400C201 RID: 49665
		internal static int __PropertyOffset_accel_ext;

		// Token: 0x0400C202 RID: 49666
		internal static int __PropertyOffset_actorPos;

		// Token: 0x0400C203 RID: 49667
		internal static int __PropertyOffset_actorRotator;

		// Token: 0x0400C204 RID: 49668
		internal static int __PropertyOffset_bEnableCPURead;

		// Token: 0x0400C205 RID: 49669
		internal static int __PropertyOffset_XCount;

		// Token: 0x0400C206 RID: 49670
		internal static int __PropertyOffset_springK;

		// Token: 0x0400C207 RID: 49671
		internal static int __PropertyOffset_springC;

		// Token: 0x0400C208 RID: 49672
		internal static int __PropertyOffset_pushStrength;

		// Token: 0x0400C209 RID: 49673
		internal static int __PropertyOffset_RT2DOrNot;

		// Token: 0x0400C20A RID: 49674
		internal static int __PropertyOffset_lockXYZ;

		// Token: 0x0400C20B RID: 49675
		internal static int __PropertyOffset_deltaTime;

		// Token: 0x0400C20C RID: 49676
		internal static int __PropertyOffset_attackOrNot;

		// Token: 0x0400C20D RID: 49677
		internal static int __PropertyOffset_overlapOrNot;

		// Token: 0x0400C20E RID: 49678
		internal static int __PropertyOffset_ParticlesArr;

		// Token: 0x0400C20F RID: 49679
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKuroCSParticle_rpbd> _ParticlesArr;
	}
}
