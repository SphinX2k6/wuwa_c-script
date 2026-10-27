using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020017A3 RID: 6051
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroComputeShader.KuroCSChain")]
	[UnrealStructLayout(1216, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1216)]
	public class AKuroCSChain : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06015D53 RID: 89427 RVA: 0x00200EDF File Offset: 0x001FF0DF
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AKuroCSChain._ClassPtr;
		}

		// Token: 0x06015D54 RID: 89428 RVA: 0x00200EEC File Offset: 0x001FF0EC
		public AKuroCSChain() : this(BuiltinUtils.AllocNativeUObject(AKuroCSChain.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06015D55 RID: 89429 RVA: 0x00200F14 File Offset: 0x001FF114
		[NullableContext(1)]
		public AKuroCSChain(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AKuroCSChain.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700568B RID: 22155
		// (get) Token: 0x06015D56 RID: 89430 RVA: 0x00200F47 File Offset: 0x001FF147
		// (set) Token: 0x06015D57 RID: 89431 RVA: 0x00200F5B File Offset: 0x001FF15B
		public unsafe USceneComponent Root
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroCSChain.__PropertyOffset_Root);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroCSChain.__PropertyOffset_Root, value);
			}
		}

		// Token: 0x1700568C RID: 22156
		// (get) Token: 0x06015D58 RID: 89432 RVA: 0x00200F70 File Offset: 0x001FF170
		// (set) Token: 0x06015D59 RID: 89433 RVA: 0x00200F80 File Offset: 0x001FF180
		public unsafe bool useExternalRT
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSChain.__PropertyOffset_useExternalRT) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSChain.__PropertyOffset_useExternalRT) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700568D RID: 22157
		// (get) Token: 0x06015D5A RID: 89434 RVA: 0x00200F91 File Offset: 0x001FF191
		// (set) Token: 0x06015D5B RID: 89435 RVA: 0x00200FA5 File Offset: 0x001FF1A5
		public unsafe UTextureRenderTarget2D RenderTarget
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTarget2D>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroCSChain.__PropertyOffset_RenderTarget);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroCSChain.__PropertyOffset_RenderTarget, value);
			}
		}

		// Token: 0x1700568E RID: 22158
		// (get) Token: 0x06015D5C RID: 89436 RVA: 0x00200FBA File Offset: 0x001FF1BA
		// (set) Token: 0x06015D5D RID: 89437 RVA: 0x00200FCE File Offset: 0x001FF1CE
		public unsafe UTextureRenderTarget2D RenderTarget_N
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTarget2D>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroCSChain.__PropertyOffset_RenderTarget_N);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroCSChain.__PropertyOffset_RenderTarget_N, value);
			}
		}

		// Token: 0x1700568F RID: 22159
		// (get) Token: 0x06015D5E RID: 89438 RVA: 0x00200FE4 File Offset: 0x001FF1E4
		// (set) Token: 0x06015D5F RID: 89439 RVA: 0x0020101D File Offset: 0x001FF21D
		[Nullable(1)]
		public TArray<FKuroCSParticle_chain> DebugArr
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FKuroCSParticle_chain> result;
				if ((result = this._DebugArr) == null)
				{
					result = (this._DebugArr = new TArray<FKuroCSParticle_chain>(base.NativePtr + (IntPtr)AKuroCSChain.__PropertyOffset_DebugArr, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.DebugArr.CopyAssign(value);
			}
		}

		// Token: 0x17005690 RID: 22160
		// (get) Token: 0x06015D60 RID: 89440 RVA: 0x0020102B File Offset: 0x001FF22B
		// (set) Token: 0x06015D61 RID: 89441 RVA: 0x0020103B File Offset: 0x001FF23B
		public unsafe float DisStiffness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSChain.__PropertyOffset_DisStiffness);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSChain.__PropertyOffset_DisStiffness) = value;
			}
		}

		// Token: 0x17005691 RID: 22161
		// (get) Token: 0x06015D62 RID: 89442 RVA: 0x0020104C File Offset: 0x001FF24C
		// (set) Token: 0x06015D63 RID: 89443 RVA: 0x0020105C File Offset: 0x001FF25C
		public unsafe float bendStiffness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSChain.__PropertyOffset_bendStiffness);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSChain.__PropertyOffset_bendStiffness) = value;
			}
		}

		// Token: 0x17005692 RID: 22162
		// (get) Token: 0x06015D64 RID: 89444 RVA: 0x0020106D File Offset: 0x001FF26D
		// (set) Token: 0x06015D65 RID: 89445 RVA: 0x00201081 File Offset: 0x001FF281
		public unsafe FVector playerPos
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSChain.__PropertyOffset_playerPos);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSChain.__PropertyOffset_playerPos) = value;
			}
		}

		// Token: 0x17005693 RID: 22163
		// (get) Token: 0x06015D66 RID: 89446 RVA: 0x00201096 File Offset: 0x001FF296
		// (set) Token: 0x06015D67 RID: 89447 RVA: 0x002010A6 File Offset: 0x001FF2A6
		public unsafe float collisionR
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSChain.__PropertyOffset_collisionR);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSChain.__PropertyOffset_collisionR) = value;
			}
		}

		// Token: 0x17005694 RID: 22164
		// (get) Token: 0x06015D68 RID: 89448 RVA: 0x002010B7 File Offset: 0x001FF2B7
		// (set) Token: 0x06015D69 RID: 89449 RVA: 0x002010C7 File Offset: 0x001FF2C7
		public unsafe int ParticleCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSChain.__PropertyOffset_ParticleCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSChain.__PropertyOffset_ParticleCount) = value;
			}
		}

		// Token: 0x17005695 RID: 22165
		// (get) Token: 0x06015D6A RID: 89450 RVA: 0x002010D8 File Offset: 0x001FF2D8
		// (set) Token: 0x06015D6B RID: 89451 RVA: 0x002010E8 File Offset: 0x001FF2E8
		public unsafe float linkDis
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSChain.__PropertyOffset_linkDis);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSChain.__PropertyOffset_linkDis) = value;
			}
		}

		// Token: 0x17005696 RID: 22166
		// (get) Token: 0x06015D6C RID: 89452 RVA: 0x002010F9 File Offset: 0x001FF2F9
		// (set) Token: 0x06015D6D RID: 89453 RVA: 0x00201109 File Offset: 0x001FF309
		public unsafe float initDis
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSChain.__PropertyOffset_initDis);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSChain.__PropertyOffset_initDis) = value;
			}
		}

		// Token: 0x17005697 RID: 22167
		// (get) Token: 0x06015D6E RID: 89454 RVA: 0x0020111A File Offset: 0x001FF31A
		// (set) Token: 0x06015D6F RID: 89455 RVA: 0x0020112A File Offset: 0x001FF32A
		public unsafe int substepCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSChain.__PropertyOffset_substepCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSChain.__PropertyOffset_substepCount) = value;
			}
		}

		// Token: 0x17005698 RID: 22168
		// (get) Token: 0x06015D70 RID: 89456 RVA: 0x0020113B File Offset: 0x001FF33B
		// (set) Token: 0x06015D71 RID: 89457 RVA: 0x0020114F File Offset: 0x001FF34F
		public unsafe FVector accel_ext
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSChain.__PropertyOffset_accel_ext);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSChain.__PropertyOffset_accel_ext) = value;
			}
		}

		// Token: 0x17005699 RID: 22169
		// (get) Token: 0x06015D72 RID: 89458 RVA: 0x00201164 File Offset: 0x001FF364
		// (set) Token: 0x06015D73 RID: 89459 RVA: 0x00201178 File Offset: 0x001FF378
		public unsafe FVector actorPos
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSChain.__PropertyOffset_actorPos);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSChain.__PropertyOffset_actorPos) = value;
			}
		}

		// Token: 0x1700569A RID: 22170
		// (get) Token: 0x06015D74 RID: 89460 RVA: 0x0020118D File Offset: 0x001FF38D
		// (set) Token: 0x06015D75 RID: 89461 RVA: 0x0020119D File Offset: 0x001FF39D
		public unsafe bool bEnableCPURead
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSChain.__PropertyOffset_bEnableCPURead) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSChain.__PropertyOffset_bEnableCPURead) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700569B RID: 22171
		// (get) Token: 0x06015D76 RID: 89462 RVA: 0x002011AE File Offset: 0x001FF3AE
		// (set) Token: 0x06015D77 RID: 89463 RVA: 0x002011C2 File Offset: 0x001FF3C2
		public unsafe FVector playerDir
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSChain.__PropertyOffset_playerDir);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSChain.__PropertyOffset_playerDir) = value;
			}
		}

		// Token: 0x1700569C RID: 22172
		// (get) Token: 0x06015D78 RID: 89464 RVA: 0x002011D7 File Offset: 0x001FF3D7
		// (set) Token: 0x06015D79 RID: 89465 RVA: 0x002011EB File Offset: 0x001FF3EB
		public unsafe FVector startPos
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSChain.__PropertyOffset_startPos);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSChain.__PropertyOffset_startPos) = value;
			}
		}

		// Token: 0x1700569D RID: 22173
		// (get) Token: 0x06015D7A RID: 89466 RVA: 0x00201200 File Offset: 0x001FF400
		// (set) Token: 0x06015D7B RID: 89467 RVA: 0x00201214 File Offset: 0x001FF414
		public unsafe FVector dynamicGravity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSChain.__PropertyOffset_dynamicGravity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSChain.__PropertyOffset_dynamicGravity) = value;
			}
		}

		// Token: 0x1700569E RID: 22174
		// (get) Token: 0x06015D7C RID: 89468 RVA: 0x0020122C File Offset: 0x001FF42C
		// (set) Token: 0x06015D7D RID: 89469 RVA: 0x00201265 File Offset: 0x001FF465
		[Nullable(1)]
		public TArray<FKuroCSParticle_chain> ParticlesArr
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FKuroCSParticle_chain> result;
				if ((result = this._ParticlesArr) == null)
				{
					result = (this._ParticlesArr = new TArray<FKuroCSParticle_chain>(base.NativePtr + (IntPtr)AKuroCSChain.__PropertyOffset_ParticlesArr, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.ParticlesArr.CopyAssign(value);
			}
		}

		// Token: 0x06015D7E RID: 89470 RVA: 0x00201273 File Offset: 0x001FF473
		public void StopSimulation()
		{
			AKuroCSChain.__StopSimulation_Internal(base.NativePtr);
		}

		// Token: 0x06015D7F RID: 89471 RVA: 0x00201280 File Offset: 0x001FF480
		public void StartSimulation()
		{
			AKuroCSChain.__StartSimulation_Internal(base.NativePtr);
		}

		// Token: 0x06015D80 RID: 89472 RVA: 0x0020128D File Offset: 0x001FF48D
		public void ReleaseShaderManager()
		{
			AKuroCSChain.__ReleaseShaderManager_Internal(base.NativePtr);
		}

		// Token: 0x06015D81 RID: 89473 RVA: 0x0020129A File Offset: 0x001FF49A
		public void InitShaderManager()
		{
			AKuroCSChain.__InitShaderManager_Internal(base.NativePtr);
		}

		// Token: 0x06015D82 RID: 89474
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __StopSimulation_Internal(IntPtr @this);

		// Token: 0x06015D83 RID: 89475
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __StartSimulation_Internal(IntPtr @this);

		// Token: 0x06015D84 RID: 89476
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ReleaseShaderManager_Internal(IntPtr @this);

		// Token: 0x06015D85 RID: 89477
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __InitShaderManager_Internal(IntPtr @this);

		// Token: 0x06015D86 RID: 89478 RVA: 0x002012A7 File Offset: 0x001FF4A7
		static AKuroCSChain()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroComputeShader.KuroCSChain");
		}

		// Token: 0x06015D87 RID: 89479 RVA: 0x002012B5 File Offset: 0x001FF4B5
		protected AKuroCSChain(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400BE87 RID: 48775
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroComputeShader.KuroCSChain";

		// Token: 0x0400BE88 RID: 48776
		private static IntPtr _ClassPtr;

		// Token: 0x0400BE89 RID: 48777
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400BE8A RID: 48778
		internal static int __PropertyOffset_Root;

		// Token: 0x0400BE8B RID: 48779
		internal static int __PropertyOffset_useExternalRT;

		// Token: 0x0400BE8C RID: 48780
		internal static int __PropertyOffset_RenderTarget;

		// Token: 0x0400BE8D RID: 48781
		internal static int __PropertyOffset_RenderTarget_N;

		// Token: 0x0400BE8E RID: 48782
		internal static int __PropertyOffset_DebugArr;

		// Token: 0x0400BE8F RID: 48783
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKuroCSParticle_chain> _DebugArr;

		// Token: 0x0400BE90 RID: 48784
		internal static int __PropertyOffset_DisStiffness;

		// Token: 0x0400BE91 RID: 48785
		internal static int __PropertyOffset_bendStiffness;

		// Token: 0x0400BE92 RID: 48786
		internal static int __PropertyOffset_playerPos;

		// Token: 0x0400BE93 RID: 48787
		internal static int __PropertyOffset_collisionR;

		// Token: 0x0400BE94 RID: 48788
		internal static int __PropertyOffset_ParticleCount;

		// Token: 0x0400BE95 RID: 48789
		internal static int __PropertyOffset_linkDis;

		// Token: 0x0400BE96 RID: 48790
		internal static int __PropertyOffset_initDis;

		// Token: 0x0400BE97 RID: 48791
		internal static int __PropertyOffset_substepCount;

		// Token: 0x0400BE98 RID: 48792
		internal static int __PropertyOffset_accel_ext;

		// Token: 0x0400BE99 RID: 48793
		internal static int __PropertyOffset_actorPos;

		// Token: 0x0400BE9A RID: 48794
		internal static int __PropertyOffset_bEnableCPURead;

		// Token: 0x0400BE9B RID: 48795
		internal static int __PropertyOffset_playerDir;

		// Token: 0x0400BE9C RID: 48796
		internal static int __PropertyOffset_startPos;

		// Token: 0x0400BE9D RID: 48797
		internal static int __PropertyOffset_dynamicGravity;

		// Token: 0x0400BE9E RID: 48798
		internal static int __PropertyOffset_ParticlesArr;

		// Token: 0x0400BE9F RID: 48799
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKuroCSParticle_chain> _ParticlesArr;
	}
}
