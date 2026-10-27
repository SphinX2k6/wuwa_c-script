using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020017D8 RID: 6104
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroComputeShader.KuroCSWindbell_set")]
	[UnrealStructLayout(1608, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1608)]
	public class AKuroCSWindbell_set : AKuroBPActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060167C9 RID: 92105 RVA: 0x0020D7BD File Offset: 0x0020B9BD
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AKuroCSWindbell_set._ClassPtr;
		}

		// Token: 0x060167CA RID: 92106 RVA: 0x0020D7CC File Offset: 0x0020B9CC
		public AKuroCSWindbell_set() : this(BuiltinUtils.AllocNativeUObject(AKuroCSWindbell_set.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060167CB RID: 92107 RVA: 0x0020D7F4 File Offset: 0x0020B9F4
		[NullableContext(1)]
		public AKuroCSWindbell_set(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AKuroCSWindbell_set.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005AAF RID: 23215
		// (get) Token: 0x060167CC RID: 92108 RVA: 0x0020D827 File Offset: 0x0020BA27
		// (set) Token: 0x060167CD RID: 92109 RVA: 0x0020D83B File Offset: 0x0020BA3B
		public unsafe USceneComponent Root
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroCSWindbell_set.__PropertyOffset_Root);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroCSWindbell_set.__PropertyOffset_Root, value);
			}
		}

		// Token: 0x17005AB0 RID: 23216
		// (get) Token: 0x060167CE RID: 92110 RVA: 0x0020D850 File Offset: 0x0020BA50
		// (set) Token: 0x060167CF RID: 92111 RVA: 0x0020D860 File Offset: 0x0020BA60
		public unsafe bool useExternalRT
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSWindbell_set.__PropertyOffset_useExternalRT) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSWindbell_set.__PropertyOffset_useExternalRT) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005AB1 RID: 23217
		// (get) Token: 0x060167D0 RID: 92112 RVA: 0x0020D871 File Offset: 0x0020BA71
		// (set) Token: 0x060167D1 RID: 92113 RVA: 0x0020D885 File Offset: 0x0020BA85
		public unsafe UTextureRenderTarget2D RenderTarget
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTarget2D>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroCSWindbell_set.__PropertyOffset_RenderTarget);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroCSWindbell_set.__PropertyOffset_RenderTarget, value);
			}
		}

		// Token: 0x17005AB2 RID: 23218
		// (get) Token: 0x060167D2 RID: 92114 RVA: 0x0020D89A File Offset: 0x0020BA9A
		// (set) Token: 0x060167D3 RID: 92115 RVA: 0x0020D8AE File Offset: 0x0020BAAE
		public unsafe UTextureRenderTarget2D RenderTarget_N
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTarget2D>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroCSWindbell_set.__PropertyOffset_RenderTarget_N);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroCSWindbell_set.__PropertyOffset_RenderTarget_N, value);
			}
		}

		// Token: 0x17005AB3 RID: 23219
		// (get) Token: 0x060167D4 RID: 92116 RVA: 0x0020D8C4 File Offset: 0x0020BAC4
		// (set) Token: 0x060167D5 RID: 92117 RVA: 0x0020D8FD File Offset: 0x0020BAFD
		[Nullable(1)]
		public TArray<FKuroCSParticle_windbell_set> DebugArr
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FKuroCSParticle_windbell_set> result;
				if ((result = this._DebugArr) == null)
				{
					result = (this._DebugArr = new TArray<FKuroCSParticle_windbell_set>(base.NativePtr + (IntPtr)AKuroCSWindbell_set.__PropertyOffset_DebugArr, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.DebugArr.CopyAssign(value);
			}
		}

		// Token: 0x17005AB4 RID: 23220
		// (get) Token: 0x060167D6 RID: 92118 RVA: 0x0020D90B File Offset: 0x0020BB0B
		// (set) Token: 0x060167D7 RID: 92119 RVA: 0x0020D91B File Offset: 0x0020BB1B
		public unsafe float DisStiffness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSWindbell_set.__PropertyOffset_DisStiffness);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSWindbell_set.__PropertyOffset_DisStiffness) = value;
			}
		}

		// Token: 0x17005AB5 RID: 23221
		// (get) Token: 0x060167D8 RID: 92120 RVA: 0x0020D92C File Offset: 0x0020BB2C
		// (set) Token: 0x060167D9 RID: 92121 RVA: 0x0020D93C File Offset: 0x0020BB3C
		public unsafe float bendStiffness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSWindbell_set.__PropertyOffset_bendStiffness);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSWindbell_set.__PropertyOffset_bendStiffness) = value;
			}
		}

		// Token: 0x17005AB6 RID: 23222
		// (get) Token: 0x060167DA RID: 92122 RVA: 0x0020D94D File Offset: 0x0020BB4D
		// (set) Token: 0x060167DB RID: 92123 RVA: 0x0020D961 File Offset: 0x0020BB61
		public unsafe FVector playerPos
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSWindbell_set.__PropertyOffset_playerPos);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSWindbell_set.__PropertyOffset_playerPos) = value;
			}
		}

		// Token: 0x17005AB7 RID: 23223
		// (get) Token: 0x060167DC RID: 92124 RVA: 0x0020D976 File Offset: 0x0020BB76
		// (set) Token: 0x060167DD RID: 92125 RVA: 0x0020D986 File Offset: 0x0020BB86
		public unsafe float collisionR
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSWindbell_set.__PropertyOffset_collisionR);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSWindbell_set.__PropertyOffset_collisionR) = value;
			}
		}

		// Token: 0x17005AB8 RID: 23224
		// (get) Token: 0x060167DE RID: 92126 RVA: 0x0020D997 File Offset: 0x0020BB97
		// (set) Token: 0x060167DF RID: 92127 RVA: 0x0020D9A7 File Offset: 0x0020BBA7
		public unsafe int ParticleCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSWindbell_set.__PropertyOffset_ParticleCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSWindbell_set.__PropertyOffset_ParticleCount) = value;
			}
		}

		// Token: 0x17005AB9 RID: 23225
		// (get) Token: 0x060167E0 RID: 92128 RVA: 0x0020D9B8 File Offset: 0x0020BBB8
		// (set) Token: 0x060167E1 RID: 92129 RVA: 0x0020D9C8 File Offset: 0x0020BBC8
		public unsafe float linkDis
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSWindbell_set.__PropertyOffset_linkDis);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSWindbell_set.__PropertyOffset_linkDis) = value;
			}
		}

		// Token: 0x17005ABA RID: 23226
		// (get) Token: 0x060167E2 RID: 92130 RVA: 0x0020D9D9 File Offset: 0x0020BBD9
		// (set) Token: 0x060167E3 RID: 92131 RVA: 0x0020D9E9 File Offset: 0x0020BBE9
		public unsafe int substepCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSWindbell_set.__PropertyOffset_substepCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSWindbell_set.__PropertyOffset_substepCount) = value;
			}
		}

		// Token: 0x17005ABB RID: 23227
		// (get) Token: 0x060167E4 RID: 92132 RVA: 0x0020D9FA File Offset: 0x0020BBFA
		// (set) Token: 0x060167E5 RID: 92133 RVA: 0x0020DA0E File Offset: 0x0020BC0E
		public unsafe FVector accel_ext
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSWindbell_set.__PropertyOffset_accel_ext);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSWindbell_set.__PropertyOffset_accel_ext) = value;
			}
		}

		// Token: 0x17005ABC RID: 23228
		// (get) Token: 0x060167E6 RID: 92134 RVA: 0x0020DA23 File Offset: 0x0020BC23
		// (set) Token: 0x060167E7 RID: 92135 RVA: 0x0020DA37 File Offset: 0x0020BC37
		public unsafe FVector actorPos
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSWindbell_set.__PropertyOffset_actorPos);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSWindbell_set.__PropertyOffset_actorPos) = value;
			}
		}

		// Token: 0x17005ABD RID: 23229
		// (get) Token: 0x060167E8 RID: 92136 RVA: 0x0020DA4C File Offset: 0x0020BC4C
		// (set) Token: 0x060167E9 RID: 92137 RVA: 0x0020DA5C File Offset: 0x0020BC5C
		public unsafe bool bEnableCPURead
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSWindbell_set.__PropertyOffset_bEnableCPURead) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSWindbell_set.__PropertyOffset_bEnableCPURead) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005ABE RID: 23230
		// (get) Token: 0x060167EA RID: 92138 RVA: 0x0020DA70 File Offset: 0x0020BC70
		// (set) Token: 0x060167EB RID: 92139 RVA: 0x0020DAA9 File Offset: 0x0020BCA9
		[Nullable(1)]
		public TArray<FKuroCSParticle_windbell_set> ParticlesArr
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FKuroCSParticle_windbell_set> result;
				if ((result = this._ParticlesArr) == null)
				{
					result = (this._ParticlesArr = new TArray<FKuroCSParticle_windbell_set>(base.NativePtr + (IntPtr)AKuroCSWindbell_set.__PropertyOffset_ParticlesArr, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.ParticlesArr.CopyAssign(value);
			}
		}

		// Token: 0x17005ABF RID: 23231
		// (get) Token: 0x060167EC RID: 92140 RVA: 0x0020DAB7 File Offset: 0x0020BCB7
		// (set) Token: 0x060167ED RID: 92141 RVA: 0x0020DACB File Offset: 0x0020BCCB
		public unsafe FVector startPos
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSWindbell_set.__PropertyOffset_startPos);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSWindbell_set.__PropertyOffset_startPos) = value;
			}
		}

		// Token: 0x17005AC0 RID: 23232
		// (get) Token: 0x060167EE RID: 92142 RVA: 0x0020DAE0 File Offset: 0x0020BCE0
		// (set) Token: 0x060167EF RID: 92143 RVA: 0x0020DAF4 File Offset: 0x0020BCF4
		public unsafe FVector endPos
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSWindbell_set.__PropertyOffset_endPos);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSWindbell_set.__PropertyOffset_endPos) = value;
			}
		}

		// Token: 0x17005AC1 RID: 23233
		// (get) Token: 0x060167F0 RID: 92144 RVA: 0x0020DB09 File Offset: 0x0020BD09
		// (set) Token: 0x060167F1 RID: 92145 RVA: 0x0020DB1D File Offset: 0x0020BD1D
		public unsafe FVector dynamicGravity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSWindbell_set.__PropertyOffset_dynamicGravity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSWindbell_set.__PropertyOffset_dynamicGravity) = value;
			}
		}

		// Token: 0x060167F2 RID: 92146 RVA: 0x0020DB32 File Offset: 0x0020BD32
		public void StopSimulation()
		{
			AKuroCSWindbell_set.__StopSimulation_Internal(base.NativePtr);
		}

		// Token: 0x060167F3 RID: 92147 RVA: 0x0020DB3F File Offset: 0x0020BD3F
		public void StartSimulation()
		{
			AKuroCSWindbell_set.__StartSimulation_Internal(base.NativePtr);
		}

		// Token: 0x060167F4 RID: 92148 RVA: 0x0020DB4C File Offset: 0x0020BD4C
		public void ReleaseShaderManager()
		{
			AKuroCSWindbell_set.__ReleaseShaderManager_Internal(base.NativePtr);
		}

		// Token: 0x060167F5 RID: 92149 RVA: 0x0020DB59 File Offset: 0x0020BD59
		public void InitShaderManager()
		{
			AKuroCSWindbell_set.__InitShaderManager_Internal(base.NativePtr);
		}

		// Token: 0x060167F6 RID: 92150
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __StopSimulation_Internal(IntPtr @this);

		// Token: 0x060167F7 RID: 92151
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __StartSimulation_Internal(IntPtr @this);

		// Token: 0x060167F8 RID: 92152
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ReleaseShaderManager_Internal(IntPtr @this);

		// Token: 0x060167F9 RID: 92153
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __InitShaderManager_Internal(IntPtr @this);

		// Token: 0x060167FA RID: 92154 RVA: 0x0020DB66 File Offset: 0x0020BD66
		static AKuroCSWindbell_set()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroComputeShader.KuroCSWindbell_set");
		}

		// Token: 0x060167FB RID: 92155 RVA: 0x0020DB74 File Offset: 0x0020BD74
		protected AKuroCSWindbell_set(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400C36B RID: 50027
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroComputeShader.KuroCSWindbell_set";

		// Token: 0x0400C36C RID: 50028
		private static IntPtr _ClassPtr;

		// Token: 0x0400C36D RID: 50029
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400C36E RID: 50030
		internal static int __PropertyOffset_Root;

		// Token: 0x0400C36F RID: 50031
		internal static int __PropertyOffset_useExternalRT;

		// Token: 0x0400C370 RID: 50032
		internal static int __PropertyOffset_RenderTarget;

		// Token: 0x0400C371 RID: 50033
		internal static int __PropertyOffset_RenderTarget_N;

		// Token: 0x0400C372 RID: 50034
		internal static int __PropertyOffset_DebugArr;

		// Token: 0x0400C373 RID: 50035
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKuroCSParticle_windbell_set> _DebugArr;

		// Token: 0x0400C374 RID: 50036
		internal static int __PropertyOffset_DisStiffness;

		// Token: 0x0400C375 RID: 50037
		internal static int __PropertyOffset_bendStiffness;

		// Token: 0x0400C376 RID: 50038
		internal static int __PropertyOffset_playerPos;

		// Token: 0x0400C377 RID: 50039
		internal static int __PropertyOffset_collisionR;

		// Token: 0x0400C378 RID: 50040
		internal static int __PropertyOffset_ParticleCount;

		// Token: 0x0400C379 RID: 50041
		internal static int __PropertyOffset_linkDis;

		// Token: 0x0400C37A RID: 50042
		internal static int __PropertyOffset_substepCount;

		// Token: 0x0400C37B RID: 50043
		internal static int __PropertyOffset_accel_ext;

		// Token: 0x0400C37C RID: 50044
		internal static int __PropertyOffset_actorPos;

		// Token: 0x0400C37D RID: 50045
		internal static int __PropertyOffset_bEnableCPURead;

		// Token: 0x0400C37E RID: 50046
		internal static int __PropertyOffset_ParticlesArr;

		// Token: 0x0400C37F RID: 50047
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKuroCSParticle_windbell_set> _ParticlesArr;

		// Token: 0x0400C380 RID: 50048
		internal static int __PropertyOffset_startPos;

		// Token: 0x0400C381 RID: 50049
		internal static int __PropertyOffset_endPos;

		// Token: 0x0400C382 RID: 50050
		internal static int __PropertyOffset_dynamicGravity;
	}
}
