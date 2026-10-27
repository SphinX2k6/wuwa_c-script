using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020017A4 RID: 6052
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroComputeShader.KuroCSChain30")]
	[UnrealStructLayout(1632, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1632)]
	public class AKuroCSChain30 : AKuroBPActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06015D88 RID: 89480 RVA: 0x002012BE File Offset: 0x001FF4BE
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AKuroCSChain30._ClassPtr;
		}

		// Token: 0x06015D89 RID: 89481 RVA: 0x002012CC File Offset: 0x001FF4CC
		public AKuroCSChain30() : this(BuiltinUtils.AllocNativeUObject(AKuroCSChain30.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06015D8A RID: 89482 RVA: 0x002012F4 File Offset: 0x001FF4F4
		[NullableContext(1)]
		public AKuroCSChain30(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AKuroCSChain30.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700569F RID: 22175
		// (get) Token: 0x06015D8B RID: 89483 RVA: 0x00201327 File Offset: 0x001FF527
		// (set) Token: 0x06015D8C RID: 89484 RVA: 0x0020133B File Offset: 0x001FF53B
		public unsafe USceneComponent Root
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroCSChain30.__PropertyOffset_Root);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroCSChain30.__PropertyOffset_Root, value);
			}
		}

		// Token: 0x170056A0 RID: 22176
		// (get) Token: 0x06015D8D RID: 89485 RVA: 0x00201350 File Offset: 0x001FF550
		// (set) Token: 0x06015D8E RID: 89486 RVA: 0x00201360 File Offset: 0x001FF560
		public unsafe bool useExternalRT
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSChain30.__PropertyOffset_useExternalRT) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSChain30.__PropertyOffset_useExternalRT) = (value ? 1 : 0);
			}
		}

		// Token: 0x170056A1 RID: 22177
		// (get) Token: 0x06015D8F RID: 89487 RVA: 0x00201371 File Offset: 0x001FF571
		// (set) Token: 0x06015D90 RID: 89488 RVA: 0x00201385 File Offset: 0x001FF585
		public unsafe UTextureRenderTarget2D RenderTarget
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTarget2D>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroCSChain30.__PropertyOffset_RenderTarget);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroCSChain30.__PropertyOffset_RenderTarget, value);
			}
		}

		// Token: 0x170056A2 RID: 22178
		// (get) Token: 0x06015D91 RID: 89489 RVA: 0x0020139A File Offset: 0x001FF59A
		// (set) Token: 0x06015D92 RID: 89490 RVA: 0x002013AE File Offset: 0x001FF5AE
		public unsafe UTextureRenderTarget2D RenderTarget_N
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTarget2D>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroCSChain30.__PropertyOffset_RenderTarget_N);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroCSChain30.__PropertyOffset_RenderTarget_N, value);
			}
		}

		// Token: 0x170056A3 RID: 22179
		// (get) Token: 0x06015D93 RID: 89491 RVA: 0x002013C3 File Offset: 0x001FF5C3
		// (set) Token: 0x06015D94 RID: 89492 RVA: 0x002013D7 File Offset: 0x001FF5D7
		public unsafe UTextureRenderTarget2D RenderTarget_P
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTarget2D>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroCSChain30.__PropertyOffset_RenderTarget_P);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroCSChain30.__PropertyOffset_RenderTarget_P, value);
			}
		}

		// Token: 0x170056A4 RID: 22180
		// (get) Token: 0x06015D95 RID: 89493 RVA: 0x002013EC File Offset: 0x001FF5EC
		// (set) Token: 0x06015D96 RID: 89494 RVA: 0x00201425 File Offset: 0x001FF625
		[Nullable(1)]
		public TArray<FKuroCSParticle_chain30> DebugArr
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FKuroCSParticle_chain30> result;
				if ((result = this._DebugArr) == null)
				{
					result = (this._DebugArr = new TArray<FKuroCSParticle_chain30>(base.NativePtr + (IntPtr)AKuroCSChain30.__PropertyOffset_DebugArr, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.DebugArr.CopyAssign(value);
			}
		}

		// Token: 0x170056A5 RID: 22181
		// (get) Token: 0x06015D97 RID: 89495 RVA: 0x00201434 File Offset: 0x001FF634
		// (set) Token: 0x06015D98 RID: 89496 RVA: 0x0020146D File Offset: 0x001FF66D
		[Nullable(1)]
		public TArray<FKuroCSParticle_chain30> ParticlesArr
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FKuroCSParticle_chain30> result;
				if ((result = this._ParticlesArr) == null)
				{
					result = (this._ParticlesArr = new TArray<FKuroCSParticle_chain30>(base.NativePtr + (IntPtr)AKuroCSChain30.__PropertyOffset_ParticlesArr, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.ParticlesArr.CopyAssign(value);
			}
		}

		// Token: 0x170056A6 RID: 22182
		// (get) Token: 0x06015D99 RID: 89497 RVA: 0x0020147B File Offset: 0x001FF67B
		// (set) Token: 0x06015D9A RID: 89498 RVA: 0x0020148B File Offset: 0x001FF68B
		public unsafe float DisStiffness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSChain30.__PropertyOffset_DisStiffness);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSChain30.__PropertyOffset_DisStiffness) = value;
			}
		}

		// Token: 0x170056A7 RID: 22183
		// (get) Token: 0x06015D9B RID: 89499 RVA: 0x0020149C File Offset: 0x001FF69C
		// (set) Token: 0x06015D9C RID: 89500 RVA: 0x002014AC File Offset: 0x001FF6AC
		public unsafe float bendStiffness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSChain30.__PropertyOffset_bendStiffness);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSChain30.__PropertyOffset_bendStiffness) = value;
			}
		}

		// Token: 0x170056A8 RID: 22184
		// (get) Token: 0x06015D9D RID: 89501 RVA: 0x002014BD File Offset: 0x001FF6BD
		// (set) Token: 0x06015D9E RID: 89502 RVA: 0x002014CD File Offset: 0x001FF6CD
		public unsafe float volDamping
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSChain30.__PropertyOffset_volDamping);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSChain30.__PropertyOffset_volDamping) = value;
			}
		}

		// Token: 0x170056A9 RID: 22185
		// (get) Token: 0x06015D9F RID: 89503 RVA: 0x002014DE File Offset: 0x001FF6DE
		// (set) Token: 0x06015DA0 RID: 89504 RVA: 0x002014F2 File Offset: 0x001FF6F2
		public unsafe FVector playerPos
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSChain30.__PropertyOffset_playerPos);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSChain30.__PropertyOffset_playerPos) = value;
			}
		}

		// Token: 0x170056AA RID: 22186
		// (get) Token: 0x06015DA1 RID: 89505 RVA: 0x00201507 File Offset: 0x001FF707
		// (set) Token: 0x06015DA2 RID: 89506 RVA: 0x00201517 File Offset: 0x001FF717
		public unsafe float collisionR
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSChain30.__PropertyOffset_collisionR);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSChain30.__PropertyOffset_collisionR) = value;
			}
		}

		// Token: 0x170056AB RID: 22187
		// (get) Token: 0x06015DA3 RID: 89507 RVA: 0x00201528 File Offset: 0x001FF728
		// (set) Token: 0x06015DA4 RID: 89508 RVA: 0x00201538 File Offset: 0x001FF738
		public unsafe int ParticleCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSChain30.__PropertyOffset_ParticleCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSChain30.__PropertyOffset_ParticleCount) = value;
			}
		}

		// Token: 0x170056AC RID: 22188
		// (get) Token: 0x06015DA5 RID: 89509 RVA: 0x00201549 File Offset: 0x001FF749
		// (set) Token: 0x06015DA6 RID: 89510 RVA: 0x00201559 File Offset: 0x001FF759
		public unsafe float linkDis
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSChain30.__PropertyOffset_linkDis);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSChain30.__PropertyOffset_linkDis) = value;
			}
		}

		// Token: 0x170056AD RID: 22189
		// (get) Token: 0x06015DA7 RID: 89511 RVA: 0x0020156A File Offset: 0x001FF76A
		// (set) Token: 0x06015DA8 RID: 89512 RVA: 0x0020157A File Offset: 0x001FF77A
		public unsafe int substepCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSChain30.__PropertyOffset_substepCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSChain30.__PropertyOffset_substepCount) = value;
			}
		}

		// Token: 0x170056AE RID: 22190
		// (get) Token: 0x06015DA9 RID: 89513 RVA: 0x0020158B File Offset: 0x001FF78B
		// (set) Token: 0x06015DAA RID: 89514 RVA: 0x0020159F File Offset: 0x001FF79F
		public unsafe FVector accel_ext
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSChain30.__PropertyOffset_accel_ext);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSChain30.__PropertyOffset_accel_ext) = value;
			}
		}

		// Token: 0x170056AF RID: 22191
		// (get) Token: 0x06015DAB RID: 89515 RVA: 0x002015B4 File Offset: 0x001FF7B4
		// (set) Token: 0x06015DAC RID: 89516 RVA: 0x002015C8 File Offset: 0x001FF7C8
		public unsafe FVector actorPos
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSChain30.__PropertyOffset_actorPos);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSChain30.__PropertyOffset_actorPos) = value;
			}
		}

		// Token: 0x170056B0 RID: 22192
		// (get) Token: 0x06015DAD RID: 89517 RVA: 0x002015DD File Offset: 0x001FF7DD
		// (set) Token: 0x06015DAE RID: 89518 RVA: 0x002015ED File Offset: 0x001FF7ED
		public unsafe bool bEnableCPURead
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSChain30.__PropertyOffset_bEnableCPURead) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSChain30.__PropertyOffset_bEnableCPURead) = (value ? 1 : 0);
			}
		}

		// Token: 0x170056B1 RID: 22193
		// (get) Token: 0x06015DAF RID: 89519 RVA: 0x002015FE File Offset: 0x001FF7FE
		// (set) Token: 0x06015DB0 RID: 89520 RVA: 0x00201612 File Offset: 0x001FF812
		public unsafe FVector startPos
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSChain30.__PropertyOffset_startPos);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSChain30.__PropertyOffset_startPos) = value;
			}
		}

		// Token: 0x170056B2 RID: 22194
		// (get) Token: 0x06015DB1 RID: 89521 RVA: 0x00201627 File Offset: 0x001FF827
		// (set) Token: 0x06015DB2 RID: 89522 RVA: 0x0020163B File Offset: 0x001FF83B
		public unsafe FVector endPos
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSChain30.__PropertyOffset_endPos);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSChain30.__PropertyOffset_endPos) = value;
			}
		}

		// Token: 0x170056B3 RID: 22195
		// (get) Token: 0x06015DB3 RID: 89523 RVA: 0x00201650 File Offset: 0x001FF850
		// (set) Token: 0x06015DB4 RID: 89524 RVA: 0x00201664 File Offset: 0x001FF864
		public unsafe FVector dynamicGravity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSChain30.__PropertyOffset_dynamicGravity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSChain30.__PropertyOffset_dynamicGravity) = value;
			}
		}

		// Token: 0x170056B4 RID: 22196
		// (get) Token: 0x06015DB5 RID: 89525 RVA: 0x00201679 File Offset: 0x001FF879
		// (set) Token: 0x06015DB6 RID: 89526 RVA: 0x00201689 File Offset: 0x001FF889
		public unsafe bool bEnableSDFCollision
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSChain30.__PropertyOffset_bEnableSDFCollision) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSChain30.__PropertyOffset_bEnableSDFCollision) = (value ? 1 : 0);
			}
		}

		// Token: 0x170056B5 RID: 22197
		// (get) Token: 0x06015DB7 RID: 89527 RVA: 0x0020169A File Offset: 0x001FF89A
		// (set) Token: 0x06015DB8 RID: 89528 RVA: 0x002016AA File Offset: 0x001FF8AA
		public unsafe float SDFMinSafeDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSChain30.__PropertyOffset_SDFMinSafeDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSChain30.__PropertyOffset_SDFMinSafeDistance) = value;
			}
		}

		// Token: 0x170056B6 RID: 22198
		// (get) Token: 0x06015DB9 RID: 89529 RVA: 0x002016BB File Offset: 0x001FF8BB
		// (set) Token: 0x06015DBA RID: 89530 RVA: 0x002016CB File Offset: 0x001FF8CB
		public unsafe float SDFDynamicSafeDistanceFactor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSChain30.__PropertyOffset_SDFDynamicSafeDistanceFactor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSChain30.__PropertyOffset_SDFDynamicSafeDistanceFactor) = value;
			}
		}

		// Token: 0x06015DBB RID: 89531 RVA: 0x002016DC File Offset: 0x001FF8DC
		public void StopSimulation()
		{
			AKuroCSChain30.__StopSimulation_Internal(base.NativePtr);
		}

		// Token: 0x06015DBC RID: 89532 RVA: 0x002016E9 File Offset: 0x001FF8E9
		public void StartSimulation()
		{
			AKuroCSChain30.__StartSimulation_Internal(base.NativePtr);
		}

		// Token: 0x06015DBD RID: 89533 RVA: 0x002016F6 File Offset: 0x001FF8F6
		public void ReleaseShaderManager()
		{
			AKuroCSChain30.__ReleaseShaderManager_Internal(base.NativePtr);
		}

		// Token: 0x06015DBE RID: 89534 RVA: 0x00201703 File Offset: 0x001FF903
		public void InitShaderManager()
		{
			AKuroCSChain30.__InitShaderManager_Internal(base.NativePtr);
		}

		// Token: 0x06015DBF RID: 89535
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __StopSimulation_Internal(IntPtr @this);

		// Token: 0x06015DC0 RID: 89536
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __StartSimulation_Internal(IntPtr @this);

		// Token: 0x06015DC1 RID: 89537
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ReleaseShaderManager_Internal(IntPtr @this);

		// Token: 0x06015DC2 RID: 89538
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __InitShaderManager_Internal(IntPtr @this);

		// Token: 0x06015DC3 RID: 89539 RVA: 0x00201710 File Offset: 0x001FF910
		static AKuroCSChain30()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroComputeShader.KuroCSChain30");
		}

		// Token: 0x06015DC4 RID: 89540 RVA: 0x0020171E File Offset: 0x001FF91E
		protected AKuroCSChain30(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400BEA0 RID: 48800
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroComputeShader.KuroCSChain30";

		// Token: 0x0400BEA1 RID: 48801
		private static IntPtr _ClassPtr;

		// Token: 0x0400BEA2 RID: 48802
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400BEA3 RID: 48803
		internal static int __PropertyOffset_Root;

		// Token: 0x0400BEA4 RID: 48804
		internal static int __PropertyOffset_useExternalRT;

		// Token: 0x0400BEA5 RID: 48805
		internal static int __PropertyOffset_RenderTarget;

		// Token: 0x0400BEA6 RID: 48806
		internal static int __PropertyOffset_RenderTarget_N;

		// Token: 0x0400BEA7 RID: 48807
		internal static int __PropertyOffset_RenderTarget_P;

		// Token: 0x0400BEA8 RID: 48808
		internal static int __PropertyOffset_DebugArr;

		// Token: 0x0400BEA9 RID: 48809
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKuroCSParticle_chain30> _DebugArr;

		// Token: 0x0400BEAA RID: 48810
		internal static int __PropertyOffset_ParticlesArr;

		// Token: 0x0400BEAB RID: 48811
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKuroCSParticle_chain30> _ParticlesArr;

		// Token: 0x0400BEAC RID: 48812
		internal static int __PropertyOffset_DisStiffness;

		// Token: 0x0400BEAD RID: 48813
		internal static int __PropertyOffset_bendStiffness;

		// Token: 0x0400BEAE RID: 48814
		internal static int __PropertyOffset_volDamping;

		// Token: 0x0400BEAF RID: 48815
		internal static int __PropertyOffset_playerPos;

		// Token: 0x0400BEB0 RID: 48816
		internal static int __PropertyOffset_collisionR;

		// Token: 0x0400BEB1 RID: 48817
		internal static int __PropertyOffset_ParticleCount;

		// Token: 0x0400BEB2 RID: 48818
		internal static int __PropertyOffset_linkDis;

		// Token: 0x0400BEB3 RID: 48819
		internal static int __PropertyOffset_substepCount;

		// Token: 0x0400BEB4 RID: 48820
		internal static int __PropertyOffset_accel_ext;

		// Token: 0x0400BEB5 RID: 48821
		internal static int __PropertyOffset_actorPos;

		// Token: 0x0400BEB6 RID: 48822
		internal static int __PropertyOffset_bEnableCPURead;

		// Token: 0x0400BEB7 RID: 48823
		internal static int __PropertyOffset_startPos;

		// Token: 0x0400BEB8 RID: 48824
		internal static int __PropertyOffset_endPos;

		// Token: 0x0400BEB9 RID: 48825
		internal static int __PropertyOffset_dynamicGravity;

		// Token: 0x0400BEBA RID: 48826
		internal static int __PropertyOffset_bEnableSDFCollision;

		// Token: 0x0400BEBB RID: 48827
		internal static int __PropertyOffset_SDFMinSafeDistance;

		// Token: 0x0400BEBC RID: 48828
		internal static int __PropertyOffset_SDFDynamicSafeDistanceFactor;
	}
}
