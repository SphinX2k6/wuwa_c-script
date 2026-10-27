using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020017DB RID: 6107
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroComputeShader.KuroCS_liuShu")]
	[UnrealStructLayout(1576, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1576)]
	public class AKuroCS_liuShu : AKuroBPCustomCookActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06016872 RID: 92274 RVA: 0x0020E47E File Offset: 0x0020C67E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AKuroCS_liuShu._ClassPtr;
		}

		// Token: 0x06016873 RID: 92275 RVA: 0x0020E48C File Offset: 0x0020C68C
		public AKuroCS_liuShu() : this(BuiltinUtils.AllocNativeUObject(AKuroCS_liuShu.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06016874 RID: 92276 RVA: 0x0020E4B4 File Offset: 0x0020C6B4
		public AKuroCS_liuShu(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AKuroCS_liuShu.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005AF4 RID: 23284
		// (get) Token: 0x06016875 RID: 92277 RVA: 0x0020E4E7 File Offset: 0x0020C6E7
		// (set) Token: 0x06016876 RID: 92278 RVA: 0x0020E4FB File Offset: 0x0020C6FB
		[Nullable(2)]
		public unsafe USceneComponent Root
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroCS_liuShu.__PropertyOffset_Root);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroCS_liuShu.__PropertyOffset_Root, value);
			}
		}

		// Token: 0x17005AF5 RID: 23285
		// (get) Token: 0x06016877 RID: 92279 RVA: 0x0020E510 File Offset: 0x0020C710
		// (set) Token: 0x06016878 RID: 92280 RVA: 0x0020E520 File Offset: 0x0020C720
		public unsafe bool useExternalRT
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCS_liuShu.__PropertyOffset_useExternalRT) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCS_liuShu.__PropertyOffset_useExternalRT) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005AF6 RID: 23286
		// (get) Token: 0x06016879 RID: 92281 RVA: 0x0020E531 File Offset: 0x0020C731
		// (set) Token: 0x0601687A RID: 92282 RVA: 0x0020E545 File Offset: 0x0020C745
		[Nullable(2)]
		public unsafe UTextureRenderTarget2D RenderTarget
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTarget2D>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroCS_liuShu.__PropertyOffset_RenderTarget);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroCS_liuShu.__PropertyOffset_RenderTarget, value);
			}
		}

		// Token: 0x17005AF7 RID: 23287
		// (get) Token: 0x0601687B RID: 92283 RVA: 0x0020E55A File Offset: 0x0020C75A
		// (set) Token: 0x0601687C RID: 92284 RVA: 0x0020E56A File Offset: 0x0020C76A
		public unsafe float DisStiffness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCS_liuShu.__PropertyOffset_DisStiffness);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCS_liuShu.__PropertyOffset_DisStiffness) = value;
			}
		}

		// Token: 0x17005AF8 RID: 23288
		// (get) Token: 0x0601687D RID: 92285 RVA: 0x0020E57B File Offset: 0x0020C77B
		// (set) Token: 0x0601687E RID: 92286 RVA: 0x0020E58F File Offset: 0x0020C78F
		public unsafe FVector playerPos
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCS_liuShu.__PropertyOffset_playerPos);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCS_liuShu.__PropertyOffset_playerPos) = value;
			}
		}

		// Token: 0x17005AF9 RID: 23289
		// (get) Token: 0x0601687F RID: 92287 RVA: 0x0020E5A4 File Offset: 0x0020C7A4
		// (set) Token: 0x06016880 RID: 92288 RVA: 0x0020E5B4 File Offset: 0x0020C7B4
		public unsafe float collisionR
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCS_liuShu.__PropertyOffset_collisionR);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCS_liuShu.__PropertyOffset_collisionR) = value;
			}
		}

		// Token: 0x17005AFA RID: 23290
		// (get) Token: 0x06016881 RID: 92289 RVA: 0x0020E5C5 File Offset: 0x0020C7C5
		// (set) Token: 0x06016882 RID: 92290 RVA: 0x0020E5D5 File Offset: 0x0020C7D5
		public unsafe int ParticleCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCS_liuShu.__PropertyOffset_ParticleCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCS_liuShu.__PropertyOffset_ParticleCount) = value;
			}
		}

		// Token: 0x17005AFB RID: 23291
		// (get) Token: 0x06016883 RID: 92291 RVA: 0x0020E5E6 File Offset: 0x0020C7E6
		// (set) Token: 0x06016884 RID: 92292 RVA: 0x0020E5FA File Offset: 0x0020C7FA
		public unsafe FVector accel_ext
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCS_liuShu.__PropertyOffset_accel_ext);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCS_liuShu.__PropertyOffset_accel_ext) = value;
			}
		}

		// Token: 0x17005AFC RID: 23292
		// (get) Token: 0x06016885 RID: 92293 RVA: 0x0020E60F File Offset: 0x0020C80F
		// (set) Token: 0x06016886 RID: 92294 RVA: 0x0020E61F File Offset: 0x0020C81F
		public unsafe float volDamping
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCS_liuShu.__PropertyOffset_volDamping);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCS_liuShu.__PropertyOffset_volDamping) = value;
			}
		}

		// Token: 0x17005AFD RID: 23293
		// (get) Token: 0x06016887 RID: 92295 RVA: 0x0020E630 File Offset: 0x0020C830
		// (set) Token: 0x06016888 RID: 92296 RVA: 0x0020E640 File Offset: 0x0020C840
		public unsafe float CustomDetalTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCS_liuShu.__PropertyOffset_CustomDetalTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCS_liuShu.__PropertyOffset_CustomDetalTime) = value;
			}
		}

		// Token: 0x17005AFE RID: 23294
		// (get) Token: 0x06016889 RID: 92297 RVA: 0x0020E651 File Offset: 0x0020C851
		// (set) Token: 0x0601688A RID: 92298 RVA: 0x0020E665 File Offset: 0x0020C865
		public unsafe FVector actorPos
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCS_liuShu.__PropertyOffset_actorPos);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCS_liuShu.__PropertyOffset_actorPos) = value;
			}
		}

		// Token: 0x17005AFF RID: 23295
		// (get) Token: 0x0601688B RID: 92299 RVA: 0x0020E67A File Offset: 0x0020C87A
		// (set) Token: 0x0601688C RID: 92300 RVA: 0x0020E68E File Offset: 0x0020C88E
		public unsafe FVector WindForce
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCS_liuShu.__PropertyOffset_WindForce);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCS_liuShu.__PropertyOffset_WindForce) = value;
			}
		}

		// Token: 0x17005B00 RID: 23296
		// (get) Token: 0x0601688D RID: 92301 RVA: 0x0020E6A3 File Offset: 0x0020C8A3
		// (set) Token: 0x0601688E RID: 92302 RVA: 0x0020E6B3 File Offset: 0x0020C8B3
		public unsafe int SubstepCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCS_liuShu.__PropertyOffset_SubstepCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCS_liuShu.__PropertyOffset_SubstepCount) = value;
			}
		}

		// Token: 0x17005B01 RID: 23297
		// (get) Token: 0x0601688F RID: 92303 RVA: 0x0020E6C4 File Offset: 0x0020C8C4
		// (set) Token: 0x06016890 RID: 92304 RVA: 0x0020E6D4 File Offset: 0x0020C8D4
		public unsafe int particleCountPerChain
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCS_liuShu.__PropertyOffset_particleCountPerChain);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCS_liuShu.__PropertyOffset_particleCountPerChain) = value;
			}
		}

		// Token: 0x17005B02 RID: 23298
		// (get) Token: 0x06016891 RID: 92305 RVA: 0x0020E6E8 File Offset: 0x0020C8E8
		// (set) Token: 0x06016892 RID: 92306 RVA: 0x0020E721 File Offset: 0x0020C921
		public TArray<FKuroCSParticle_liuShu> ParticlesArr
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FKuroCSParticle_liuShu> result;
				if ((result = this._ParticlesArr) == null)
				{
					result = (this._ParticlesArr = new TArray<FKuroCSParticle_liuShu>(base.NativePtr + (IntPtr)AKuroCS_liuShu.__PropertyOffset_ParticlesArr, this));
				}
				return result;
			}
			set
			{
				this.ParticlesArr.CopyAssign(value);
			}
		}

		// Token: 0x17005B03 RID: 23299
		// (get) Token: 0x06016893 RID: 92307 RVA: 0x0020E730 File Offset: 0x0020C930
		// (set) Token: 0x06016894 RID: 92308 RVA: 0x0020E769 File Offset: 0x0020C969
		public TArray<FKuroCSParticle_liuShu> DebugArr
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FKuroCSParticle_liuShu> result;
				if ((result = this._DebugArr) == null)
				{
					result = (this._DebugArr = new TArray<FKuroCSParticle_liuShu>(base.NativePtr + (IntPtr)AKuroCS_liuShu.__PropertyOffset_DebugArr, this));
				}
				return result;
			}
			set
			{
				this.DebugArr.CopyAssign(value);
			}
		}

		// Token: 0x06016895 RID: 92309 RVA: 0x0020E777 File Offset: 0x0020C977
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void StopSimulation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, AKuroCS_liuShu.__StopSimulation_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06016896 RID: 92310 RVA: 0x0020E78C File Offset: 0x0020C98C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void StartSimulation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, AKuroCS_liuShu.__StartSimulation_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06016897 RID: 92311 RVA: 0x0020E7A1 File Offset: 0x0020C9A1
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void ReleaseShaderManager()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, AKuroCS_liuShu.__ReleaseShaderManager_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06016898 RID: 92312 RVA: 0x0020E7B6 File Offset: 0x0020C9B6
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void InitShaderManager()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, AKuroCS_liuShu.__InitShaderManager_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06016899 RID: 92313 RVA: 0x0020E7CB File Offset: 0x0020C9CB
		static AKuroCS_liuShu()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroComputeShader.KuroCS_liuShu");
		}

		// Token: 0x0601689A RID: 92314 RVA: 0x0020E7D9 File Offset: 0x0020C9D9
		protected AKuroCS_liuShu(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400C3C6 RID: 50118
		public new const string __ObjectPath = "/Script/KuroComputeShader.KuroCS_liuShu";

		// Token: 0x0400C3C7 RID: 50119
		private static IntPtr _ClassPtr;

		// Token: 0x0400C3C8 RID: 50120
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400C3C9 RID: 50121
		internal static int __PropertyOffset_Root;

		// Token: 0x0400C3CA RID: 50122
		internal static int __PropertyOffset_useExternalRT;

		// Token: 0x0400C3CB RID: 50123
		internal static int __PropertyOffset_RenderTarget;

		// Token: 0x0400C3CC RID: 50124
		internal static int __PropertyOffset_DisStiffness;

		// Token: 0x0400C3CD RID: 50125
		internal static int __PropertyOffset_playerPos;

		// Token: 0x0400C3CE RID: 50126
		internal static int __PropertyOffset_collisionR;

		// Token: 0x0400C3CF RID: 50127
		internal static int __PropertyOffset_ParticleCount;

		// Token: 0x0400C3D0 RID: 50128
		internal static int __PropertyOffset_accel_ext;

		// Token: 0x0400C3D1 RID: 50129
		internal static int __PropertyOffset_volDamping;

		// Token: 0x0400C3D2 RID: 50130
		internal static int __PropertyOffset_CustomDetalTime;

		// Token: 0x0400C3D3 RID: 50131
		internal static int __PropertyOffset_actorPos;

		// Token: 0x0400C3D4 RID: 50132
		internal static int __PropertyOffset_WindForce;

		// Token: 0x0400C3D5 RID: 50133
		internal static int __PropertyOffset_SubstepCount;

		// Token: 0x0400C3D6 RID: 50134
		internal static int __PropertyOffset_particleCountPerChain;

		// Token: 0x0400C3D7 RID: 50135
		internal static int __PropertyOffset_ParticlesArr;

		// Token: 0x0400C3D8 RID: 50136
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKuroCSParticle_liuShu> _ParticlesArr;

		// Token: 0x0400C3D9 RID: 50137
		internal static int __PropertyOffset_DebugArr;

		// Token: 0x0400C3DA RID: 50138
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKuroCSParticle_liuShu> _DebugArr;

		// Token: 0x0400C3DB RID: 50139
		private static IntPtr __StopSimulation_NativeFunctionPtr;

		// Token: 0x0400C3DC RID: 50140
		private static IntPtr __StartSimulation_NativeFunctionPtr;

		// Token: 0x0400C3DD RID: 50141
		private static IntPtr __ReleaseShaderManager_NativeFunctionPtr;

		// Token: 0x0400C3DE RID: 50142
		private static IntPtr __InitShaderManager_NativeFunctionPtr;
	}
}
