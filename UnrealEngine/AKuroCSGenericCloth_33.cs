using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020017AE RID: 6062
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroComputeShader.KuroCSGenericCloth_33")]
	[UnrealStructLayout(1624, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1624)]
	public class AKuroCSGenericCloth_33 : AKuroBPActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06015F98 RID: 90008 RVA: 0x00203713 File Offset: 0x00201913
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AKuroCSGenericCloth_33._ClassPtr;
		}

		// Token: 0x06015F99 RID: 90009 RVA: 0x00203720 File Offset: 0x00201920
		public AKuroCSGenericCloth_33() : this(BuiltinUtils.AllocNativeUObject(AKuroCSGenericCloth_33.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06015F9A RID: 90010 RVA: 0x00203748 File Offset: 0x00201948
		public AKuroCSGenericCloth_33(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AKuroCSGenericCloth_33.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005766 RID: 22374
		// (get) Token: 0x06015F9B RID: 90011 RVA: 0x0020377B File Offset: 0x0020197B
		// (set) Token: 0x06015F9C RID: 90012 RVA: 0x0020378F File Offset: 0x0020198F
		[Nullable(2)]
		public unsafe USceneComponent Root
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroCSGenericCloth_33.__PropertyOffset_Root);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroCSGenericCloth_33.__PropertyOffset_Root, value);
			}
		}

		// Token: 0x17005767 RID: 22375
		// (get) Token: 0x06015F9D RID: 90013 RVA: 0x002037A4 File Offset: 0x002019A4
		// (set) Token: 0x06015F9E RID: 90014 RVA: 0x002037B4 File Offset: 0x002019B4
		public unsafe bool useExternalRT
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSGenericCloth_33.__PropertyOffset_useExternalRT) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSGenericCloth_33.__PropertyOffset_useExternalRT) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005768 RID: 22376
		// (get) Token: 0x06015F9F RID: 90015 RVA: 0x002037C5 File Offset: 0x002019C5
		// (set) Token: 0x06015FA0 RID: 90016 RVA: 0x002037D9 File Offset: 0x002019D9
		[Nullable(2)]
		public unsafe UTextureRenderTarget2D RenderTarget
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTarget2D>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroCSGenericCloth_33.__PropertyOffset_RenderTarget);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroCSGenericCloth_33.__PropertyOffset_RenderTarget, value);
			}
		}

		// Token: 0x17005769 RID: 22377
		// (get) Token: 0x06015FA1 RID: 90017 RVA: 0x002037EE File Offset: 0x002019EE
		// (set) Token: 0x06015FA2 RID: 90018 RVA: 0x00203802 File Offset: 0x00201A02
		[Nullable(2)]
		public unsafe UTextureRenderTarget2D RenderTarget_N
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTarget2D>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroCSGenericCloth_33.__PropertyOffset_RenderTarget_N);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroCSGenericCloth_33.__PropertyOffset_RenderTarget_N, value);
			}
		}

		// Token: 0x1700576A RID: 22378
		// (get) Token: 0x06015FA3 RID: 90019 RVA: 0x00203817 File Offset: 0x00201A17
		// (set) Token: 0x06015FA4 RID: 90020 RVA: 0x00203827 File Offset: 0x00201A27
		public unsafe bool bShowParticleArraysInDetails
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSGenericCloth_33.__PropertyOffset_bShowParticleArraysInDetails) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSGenericCloth_33.__PropertyOffset_bShowParticleArraysInDetails) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700576B RID: 22379
		// (get) Token: 0x06015FA5 RID: 90021 RVA: 0x00203838 File Offset: 0x00201A38
		// (set) Token: 0x06015FA6 RID: 90022 RVA: 0x00203871 File Offset: 0x00201A71
		public TArray<FKuroCSParticle_genericCloth_33> ParticlesArr
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FKuroCSParticle_genericCloth_33> result;
				if ((result = this._ParticlesArr) == null)
				{
					result = (this._ParticlesArr = new TArray<FKuroCSParticle_genericCloth_33>(base.NativePtr + (IntPtr)AKuroCSGenericCloth_33.__PropertyOffset_ParticlesArr, this));
				}
				return result;
			}
			set
			{
				this.ParticlesArr.CopyAssign(value);
			}
		}

		// Token: 0x1700576C RID: 22380
		// (get) Token: 0x06015FA7 RID: 90023 RVA: 0x00203880 File Offset: 0x00201A80
		// (set) Token: 0x06015FA8 RID: 90024 RVA: 0x002038B9 File Offset: 0x00201AB9
		public TArray<FKuroCSParticle_genericCloth_33> DebugArr
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FKuroCSParticle_genericCloth_33> result;
				if ((result = this._DebugArr) == null)
				{
					result = (this._DebugArr = new TArray<FKuroCSParticle_genericCloth_33>(base.NativePtr + (IntPtr)AKuroCSGenericCloth_33.__PropertyOffset_DebugArr, this));
				}
				return result;
			}
			set
			{
				this.DebugArr.CopyAssign(value);
			}
		}

		// Token: 0x1700576D RID: 22381
		// (get) Token: 0x06015FA9 RID: 90025 RVA: 0x002038C7 File Offset: 0x00201AC7
		// (set) Token: 0x06015FAA RID: 90026 RVA: 0x002038DB File Offset: 0x00201ADB
		public unsafe FVector playerPos
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSGenericCloth_33.__PropertyOffset_playerPos);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSGenericCloth_33.__PropertyOffset_playerPos) = value;
			}
		}

		// Token: 0x1700576E RID: 22382
		// (get) Token: 0x06015FAB RID: 90027 RVA: 0x002038F0 File Offset: 0x00201AF0
		// (set) Token: 0x06015FAC RID: 90028 RVA: 0x00203900 File Offset: 0x00201B00
		public unsafe float collisionR
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSGenericCloth_33.__PropertyOffset_collisionR);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSGenericCloth_33.__PropertyOffset_collisionR) = value;
			}
		}

		// Token: 0x1700576F RID: 22383
		// (get) Token: 0x06015FAD RID: 90029 RVA: 0x00203911 File Offset: 0x00201B11
		// (set) Token: 0x06015FAE RID: 90030 RVA: 0x00203921 File Offset: 0x00201B21
		public unsafe int ParticleCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSGenericCloth_33.__PropertyOffset_ParticleCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSGenericCloth_33.__PropertyOffset_ParticleCount) = value;
			}
		}

		// Token: 0x17005770 RID: 22384
		// (get) Token: 0x06015FAF RID: 90031 RVA: 0x00203932 File Offset: 0x00201B32
		// (set) Token: 0x06015FB0 RID: 90032 RVA: 0x00203942 File Offset: 0x00201B42
		public unsafe int substepCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSGenericCloth_33.__PropertyOffset_substepCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSGenericCloth_33.__PropertyOffset_substepCount) = value;
			}
		}

		// Token: 0x17005771 RID: 22385
		// (get) Token: 0x06015FB1 RID: 90033 RVA: 0x00203953 File Offset: 0x00201B53
		// (set) Token: 0x06015FB2 RID: 90034 RVA: 0x00203967 File Offset: 0x00201B67
		public unsafe FVector accel_ext
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSGenericCloth_33.__PropertyOffset_accel_ext);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSGenericCloth_33.__PropertyOffset_accel_ext) = value;
			}
		}

		// Token: 0x17005772 RID: 22386
		// (get) Token: 0x06015FB3 RID: 90035 RVA: 0x0020397C File Offset: 0x00201B7C
		// (set) Token: 0x06015FB4 RID: 90036 RVA: 0x00203990 File Offset: 0x00201B90
		public unsafe FVector actorPos
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSGenericCloth_33.__PropertyOffset_actorPos);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSGenericCloth_33.__PropertyOffset_actorPos) = value;
			}
		}

		// Token: 0x17005773 RID: 22387
		// (get) Token: 0x06015FB5 RID: 90037 RVA: 0x002039A5 File Offset: 0x00201BA5
		// (set) Token: 0x06015FB6 RID: 90038 RVA: 0x002039B9 File Offset: 0x00201BB9
		public unsafe FVector actorRotator
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSGenericCloth_33.__PropertyOffset_actorRotator);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSGenericCloth_33.__PropertyOffset_actorRotator) = value;
			}
		}

		// Token: 0x17005774 RID: 22388
		// (get) Token: 0x06015FB7 RID: 90039 RVA: 0x002039CE File Offset: 0x00201BCE
		// (set) Token: 0x06015FB8 RID: 90040 RVA: 0x002039DE File Offset: 0x00201BDE
		public unsafe bool bEnableCPURead
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSGenericCloth_33.__PropertyOffset_bEnableCPURead) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSGenericCloth_33.__PropertyOffset_bEnableCPURead) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005775 RID: 22389
		// (get) Token: 0x06015FB9 RID: 90041 RVA: 0x002039EF File Offset: 0x00201BEF
		// (set) Token: 0x06015FBA RID: 90042 RVA: 0x002039FF File Offset: 0x00201BFF
		public unsafe int XCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSGenericCloth_33.__PropertyOffset_XCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSGenericCloth_33.__PropertyOffset_XCount) = value;
			}
		}

		// Token: 0x17005776 RID: 22390
		// (get) Token: 0x06015FBB RID: 90043 RVA: 0x00203A10 File Offset: 0x00201C10
		// (set) Token: 0x06015FBC RID: 90044 RVA: 0x00203A20 File Offset: 0x00201C20
		public unsafe float DisStiffness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSGenericCloth_33.__PropertyOffset_DisStiffness);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSGenericCloth_33.__PropertyOffset_DisStiffness) = value;
			}
		}

		// Token: 0x17005777 RID: 22391
		// (get) Token: 0x06015FBD RID: 90045 RVA: 0x00203A31 File Offset: 0x00201C31
		// (set) Token: 0x06015FBE RID: 90046 RVA: 0x00203A41 File Offset: 0x00201C41
		public unsafe float BendingStiffness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSGenericCloth_33.__PropertyOffset_BendingStiffness);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSGenericCloth_33.__PropertyOffset_BendingStiffness) = value;
			}
		}

		// Token: 0x17005778 RID: 22392
		// (get) Token: 0x06015FBF RID: 90047 RVA: 0x00203A52 File Offset: 0x00201C52
		// (set) Token: 0x06015FC0 RID: 90048 RVA: 0x00203A62 File Offset: 0x00201C62
		public unsafe float pushStrength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSGenericCloth_33.__PropertyOffset_pushStrength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSGenericCloth_33.__PropertyOffset_pushStrength) = value;
			}
		}

		// Token: 0x17005779 RID: 22393
		// (get) Token: 0x06015FC1 RID: 90049 RVA: 0x00203A73 File Offset: 0x00201C73
		// (set) Token: 0x06015FC2 RID: 90050 RVA: 0x00203A83 File Offset: 0x00201C83
		public unsafe int forcePlayerCol
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSGenericCloth_33.__PropertyOffset_forcePlayerCol);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSGenericCloth_33.__PropertyOffset_forcePlayerCol) = value;
			}
		}

		// Token: 0x1700577A RID: 22394
		// (get) Token: 0x06015FC3 RID: 90051 RVA: 0x00203A94 File Offset: 0x00201C94
		// (set) Token: 0x06015FC4 RID: 90052 RVA: 0x00203AA4 File Offset: 0x00201CA4
		public unsafe int deadNodeHold
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSGenericCloth_33.__PropertyOffset_deadNodeHold);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSGenericCloth_33.__PropertyOffset_deadNodeHold) = value;
			}
		}

		// Token: 0x1700577B RID: 22395
		// (get) Token: 0x06015FC5 RID: 90053 RVA: 0x00203AB5 File Offset: 0x00201CB5
		// (set) Token: 0x06015FC6 RID: 90054 RVA: 0x00203AC5 File Offset: 0x00201CC5
		public unsafe float deltaTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSGenericCloth_33.__PropertyOffset_deltaTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSGenericCloth_33.__PropertyOffset_deltaTime) = value;
			}
		}

		// Token: 0x1700577C RID: 22396
		// (get) Token: 0x06015FC7 RID: 90055 RVA: 0x00203AD8 File Offset: 0x00201CD8
		// (set) Token: 0x06015FC8 RID: 90056 RVA: 0x00203B11 File Offset: 0x00201D11
		public TArray<FKuroCSUnifiedCollider_genericCloth_33> Colliders
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FKuroCSUnifiedCollider_genericCloth_33> result;
				if ((result = this._Colliders) == null)
				{
					result = (this._Colliders = new TArray<FKuroCSUnifiedCollider_genericCloth_33>(base.NativePtr + (IntPtr)AKuroCSGenericCloth_33.__PropertyOffset_Colliders, this));
				}
				return result;
			}
			set
			{
				this.Colliders.CopyAssign(value);
			}
		}

		// Token: 0x06015FC9 RID: 90057 RVA: 0x00203B1F File Offset: 0x00201D1F
		public void StopSimulation()
		{
			AKuroCSGenericCloth_33.__StopSimulation_Internal(base.NativePtr);
		}

		// Token: 0x06015FCA RID: 90058 RVA: 0x00203B2C File Offset: 0x00201D2C
		public void StartSimulation()
		{
			AKuroCSGenericCloth_33.__StartSimulation_Internal(base.NativePtr);
		}

		// Token: 0x06015FCB RID: 90059 RVA: 0x00203B39 File Offset: 0x00201D39
		public void ReleaseShaderManager()
		{
			AKuroCSGenericCloth_33.__ReleaseShaderManager_Internal(base.NativePtr);
		}

		// Token: 0x06015FCC RID: 90060 RVA: 0x00203B46 File Offset: 0x00201D46
		public void InitShaderManager()
		{
			AKuroCSGenericCloth_33.__InitShaderManager_Internal(base.NativePtr);
		}

		// Token: 0x06015FCD RID: 90061
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __StopSimulation_Internal(IntPtr @this);

		// Token: 0x06015FCE RID: 90062
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __StartSimulation_Internal(IntPtr @this);

		// Token: 0x06015FCF RID: 90063
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ReleaseShaderManager_Internal(IntPtr @this);

		// Token: 0x06015FD0 RID: 90064
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __InitShaderManager_Internal(IntPtr @this);

		// Token: 0x06015FD1 RID: 90065 RVA: 0x00203B53 File Offset: 0x00201D53
		static AKuroCSGenericCloth_33()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroComputeShader.KuroCSGenericCloth_33");
		}

		// Token: 0x06015FD2 RID: 90066 RVA: 0x00203B61 File Offset: 0x00201D61
		protected AKuroCSGenericCloth_33(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400BF8D RID: 49037
		public new const string __ObjectPath = "/Script/KuroComputeShader.KuroCSGenericCloth_33";

		// Token: 0x0400BF8E RID: 49038
		private static IntPtr _ClassPtr;

		// Token: 0x0400BF8F RID: 49039
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400BF90 RID: 49040
		internal static int __PropertyOffset_Root;

		// Token: 0x0400BF91 RID: 49041
		internal static int __PropertyOffset_useExternalRT;

		// Token: 0x0400BF92 RID: 49042
		internal static int __PropertyOffset_RenderTarget;

		// Token: 0x0400BF93 RID: 49043
		internal static int __PropertyOffset_RenderTarget_N;

		// Token: 0x0400BF94 RID: 49044
		internal static int __PropertyOffset_bShowParticleArraysInDetails;

		// Token: 0x0400BF95 RID: 49045
		internal static int __PropertyOffset_ParticlesArr;

		// Token: 0x0400BF96 RID: 49046
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKuroCSParticle_genericCloth_33> _ParticlesArr;

		// Token: 0x0400BF97 RID: 49047
		internal static int __PropertyOffset_DebugArr;

		// Token: 0x0400BF98 RID: 49048
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKuroCSParticle_genericCloth_33> _DebugArr;

		// Token: 0x0400BF99 RID: 49049
		internal static int __PropertyOffset_playerPos;

		// Token: 0x0400BF9A RID: 49050
		internal static int __PropertyOffset_collisionR;

		// Token: 0x0400BF9B RID: 49051
		internal static int __PropertyOffset_ParticleCount;

		// Token: 0x0400BF9C RID: 49052
		internal static int __PropertyOffset_substepCount;

		// Token: 0x0400BF9D RID: 49053
		internal static int __PropertyOffset_accel_ext;

		// Token: 0x0400BF9E RID: 49054
		internal static int __PropertyOffset_actorPos;

		// Token: 0x0400BF9F RID: 49055
		internal static int __PropertyOffset_actorRotator;

		// Token: 0x0400BFA0 RID: 49056
		internal static int __PropertyOffset_bEnableCPURead;

		// Token: 0x0400BFA1 RID: 49057
		internal static int __PropertyOffset_XCount;

		// Token: 0x0400BFA2 RID: 49058
		internal static int __PropertyOffset_DisStiffness;

		// Token: 0x0400BFA3 RID: 49059
		internal static int __PropertyOffset_BendingStiffness;

		// Token: 0x0400BFA4 RID: 49060
		internal static int __PropertyOffset_pushStrength;

		// Token: 0x0400BFA5 RID: 49061
		internal static int __PropertyOffset_forcePlayerCol;

		// Token: 0x0400BFA6 RID: 49062
		internal static int __PropertyOffset_deadNodeHold;

		// Token: 0x0400BFA7 RID: 49063
		internal static int __PropertyOffset_deltaTime;

		// Token: 0x0400BFA8 RID: 49064
		internal static int __PropertyOffset_Colliders;

		// Token: 0x0400BFA9 RID: 49065
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKuroCSUnifiedCollider_genericCloth_33> _Colliders;
	}
}
