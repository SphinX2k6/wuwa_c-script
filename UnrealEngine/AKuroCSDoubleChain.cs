using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020017AC RID: 6060
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroComputeShader.KuroCSDoubleChain")]
	[UnrealStructLayout(1184, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1184)]
	public class AKuroCSDoubleChain : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06015F24 RID: 89892 RVA: 0x00202EA9 File Offset: 0x002010A9
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AKuroCSDoubleChain._ClassPtr;
		}

		// Token: 0x06015F25 RID: 89893 RVA: 0x00202EB8 File Offset: 0x002010B8
		public AKuroCSDoubleChain() : this(BuiltinUtils.AllocNativeUObject(AKuroCSDoubleChain.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06015F26 RID: 89894 RVA: 0x00202EE0 File Offset: 0x002010E0
		[NullableContext(1)]
		public AKuroCSDoubleChain(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AKuroCSDoubleChain.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005737 RID: 22327
		// (get) Token: 0x06015F27 RID: 89895 RVA: 0x00202F13 File Offset: 0x00201113
		// (set) Token: 0x06015F28 RID: 89896 RVA: 0x00202F27 File Offset: 0x00201127
		public unsafe USceneComponent Root
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroCSDoubleChain.__PropertyOffset_Root);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroCSDoubleChain.__PropertyOffset_Root, value);
			}
		}

		// Token: 0x17005738 RID: 22328
		// (get) Token: 0x06015F29 RID: 89897 RVA: 0x00202F3C File Offset: 0x0020113C
		// (set) Token: 0x06015F2A RID: 89898 RVA: 0x00202F4C File Offset: 0x0020114C
		public unsafe bool useExternalRT
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSDoubleChain.__PropertyOffset_useExternalRT) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSDoubleChain.__PropertyOffset_useExternalRT) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005739 RID: 22329
		// (get) Token: 0x06015F2B RID: 89899 RVA: 0x00202F5D File Offset: 0x0020115D
		// (set) Token: 0x06015F2C RID: 89900 RVA: 0x00202F71 File Offset: 0x00201171
		public unsafe UTextureRenderTarget2D RenderTarget
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTarget2D>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroCSDoubleChain.__PropertyOffset_RenderTarget);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroCSDoubleChain.__PropertyOffset_RenderTarget, value);
			}
		}

		// Token: 0x1700573A RID: 22330
		// (get) Token: 0x06015F2D RID: 89901 RVA: 0x00202F88 File Offset: 0x00201188
		// (set) Token: 0x06015F2E RID: 89902 RVA: 0x00202FC1 File Offset: 0x002011C1
		[Nullable(1)]
		public TArray<FKuroCSParticle_doubleChain> DebugArr
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FKuroCSParticle_doubleChain> result;
				if ((result = this._DebugArr) == null)
				{
					result = (this._DebugArr = new TArray<FKuroCSParticle_doubleChain>(base.NativePtr + (IntPtr)AKuroCSDoubleChain.__PropertyOffset_DebugArr, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.DebugArr.CopyAssign(value);
			}
		}

		// Token: 0x1700573B RID: 22331
		// (get) Token: 0x06015F2F RID: 89903 RVA: 0x00202FCF File Offset: 0x002011CF
		// (set) Token: 0x06015F30 RID: 89904 RVA: 0x00202FDF File Offset: 0x002011DF
		public unsafe int XCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSDoubleChain.__PropertyOffset_XCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSDoubleChain.__PropertyOffset_XCount) = value;
			}
		}

		// Token: 0x1700573C RID: 22332
		// (get) Token: 0x06015F31 RID: 89905 RVA: 0x00202FF0 File Offset: 0x002011F0
		// (set) Token: 0x06015F32 RID: 89906 RVA: 0x00203000 File Offset: 0x00201200
		public unsafe int YCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSDoubleChain.__PropertyOffset_YCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSDoubleChain.__PropertyOffset_YCount) = value;
			}
		}

		// Token: 0x1700573D RID: 22333
		// (get) Token: 0x06015F33 RID: 89907 RVA: 0x00203011 File Offset: 0x00201211
		// (set) Token: 0x06015F34 RID: 89908 RVA: 0x00203021 File Offset: 0x00201221
		public unsafe float DisStiffness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSDoubleChain.__PropertyOffset_DisStiffness);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSDoubleChain.__PropertyOffset_DisStiffness) = value;
			}
		}

		// Token: 0x1700573E RID: 22334
		// (get) Token: 0x06015F35 RID: 89909 RVA: 0x00203032 File Offset: 0x00201232
		// (set) Token: 0x06015F36 RID: 89910 RVA: 0x00203042 File Offset: 0x00201242
		public unsafe float bendStiffness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSDoubleChain.__PropertyOffset_bendStiffness);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSDoubleChain.__PropertyOffset_bendStiffness) = value;
			}
		}

		// Token: 0x1700573F RID: 22335
		// (get) Token: 0x06015F37 RID: 89911 RVA: 0x00203053 File Offset: 0x00201253
		// (set) Token: 0x06015F38 RID: 89912 RVA: 0x00203067 File Offset: 0x00201267
		public unsafe FVector playerPos
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSDoubleChain.__PropertyOffset_playerPos);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSDoubleChain.__PropertyOffset_playerPos) = value;
			}
		}

		// Token: 0x17005740 RID: 22336
		// (get) Token: 0x06015F39 RID: 89913 RVA: 0x0020307C File Offset: 0x0020127C
		// (set) Token: 0x06015F3A RID: 89914 RVA: 0x0020308C File Offset: 0x0020128C
		public unsafe float collisionR
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSDoubleChain.__PropertyOffset_collisionR);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSDoubleChain.__PropertyOffset_collisionR) = value;
			}
		}

		// Token: 0x17005741 RID: 22337
		// (get) Token: 0x06015F3B RID: 89915 RVA: 0x0020309D File Offset: 0x0020129D
		// (set) Token: 0x06015F3C RID: 89916 RVA: 0x002030AD File Offset: 0x002012AD
		public unsafe int ParticleCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSDoubleChain.__PropertyOffset_ParticleCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSDoubleChain.__PropertyOffset_ParticleCount) = value;
			}
		}

		// Token: 0x17005742 RID: 22338
		// (get) Token: 0x06015F3D RID: 89917 RVA: 0x002030BE File Offset: 0x002012BE
		// (set) Token: 0x06015F3E RID: 89918 RVA: 0x002030CE File Offset: 0x002012CE
		public unsafe float linkDis
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSDoubleChain.__PropertyOffset_linkDis);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSDoubleChain.__PropertyOffset_linkDis) = value;
			}
		}

		// Token: 0x17005743 RID: 22339
		// (get) Token: 0x06015F3F RID: 89919 RVA: 0x002030DF File Offset: 0x002012DF
		// (set) Token: 0x06015F40 RID: 89920 RVA: 0x002030EF File Offset: 0x002012EF
		public unsafe int substepCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSDoubleChain.__PropertyOffset_substepCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSDoubleChain.__PropertyOffset_substepCount) = value;
			}
		}

		// Token: 0x17005744 RID: 22340
		// (get) Token: 0x06015F41 RID: 89921 RVA: 0x00203100 File Offset: 0x00201300
		// (set) Token: 0x06015F42 RID: 89922 RVA: 0x00203114 File Offset: 0x00201314
		public unsafe FVector accel_ext
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSDoubleChain.__PropertyOffset_accel_ext);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSDoubleChain.__PropertyOffset_accel_ext) = value;
			}
		}

		// Token: 0x17005745 RID: 22341
		// (get) Token: 0x06015F43 RID: 89923 RVA: 0x00203129 File Offset: 0x00201329
		// (set) Token: 0x06015F44 RID: 89924 RVA: 0x0020313D File Offset: 0x0020133D
		public unsafe FVector actorPos
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSDoubleChain.__PropertyOffset_actorPos);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSDoubleChain.__PropertyOffset_actorPos) = value;
			}
		}

		// Token: 0x17005746 RID: 22342
		// (get) Token: 0x06015F45 RID: 89925 RVA: 0x00203152 File Offset: 0x00201352
		// (set) Token: 0x06015F46 RID: 89926 RVA: 0x00203166 File Offset: 0x00201366
		public unsafe FVector SecondArrayStart
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSDoubleChain.__PropertyOffset_SecondArrayStart);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSDoubleChain.__PropertyOffset_SecondArrayStart) = value;
			}
		}

		// Token: 0x17005747 RID: 22343
		// (get) Token: 0x06015F47 RID: 89927 RVA: 0x0020317B File Offset: 0x0020137B
		// (set) Token: 0x06015F48 RID: 89928 RVA: 0x0020318B File Offset: 0x0020138B
		public unsafe int SecondArrayIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSDoubleChain.__PropertyOffset_SecondArrayIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSDoubleChain.__PropertyOffset_SecondArrayIndex) = value;
			}
		}

		// Token: 0x17005748 RID: 22344
		// (get) Token: 0x06015F49 RID: 89929 RVA: 0x0020319C File Offset: 0x0020139C
		// (set) Token: 0x06015F4A RID: 89930 RVA: 0x002031B0 File Offset: 0x002013B0
		public unsafe FVector LocalPosOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSDoubleChain.__PropertyOffset_LocalPosOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSDoubleChain.__PropertyOffset_LocalPosOffset) = value;
			}
		}

		// Token: 0x06015F4B RID: 89931 RVA: 0x002031C5 File Offset: 0x002013C5
		public void StopSimulation()
		{
			AKuroCSDoubleChain.__StopSimulation_Internal(base.NativePtr);
		}

		// Token: 0x06015F4C RID: 89932 RVA: 0x002031D2 File Offset: 0x002013D2
		public void StartSimulation()
		{
			AKuroCSDoubleChain.__StartSimulation_Internal(base.NativePtr);
		}

		// Token: 0x06015F4D RID: 89933
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __StopSimulation_Internal(IntPtr @this);

		// Token: 0x06015F4E RID: 89934
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __StartSimulation_Internal(IntPtr @this);

		// Token: 0x06015F4F RID: 89935 RVA: 0x002031DF File Offset: 0x002013DF
		static AKuroCSDoubleChain()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroComputeShader.KuroCSDoubleChain");
		}

		// Token: 0x06015F50 RID: 89936 RVA: 0x002031ED File Offset: 0x002013ED
		protected AKuroCSDoubleChain(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400BF54 RID: 48980
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroComputeShader.KuroCSDoubleChain";

		// Token: 0x0400BF55 RID: 48981
		private static IntPtr _ClassPtr;

		// Token: 0x0400BF56 RID: 48982
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400BF57 RID: 48983
		internal static int __PropertyOffset_Root;

		// Token: 0x0400BF58 RID: 48984
		internal static int __PropertyOffset_useExternalRT;

		// Token: 0x0400BF59 RID: 48985
		internal static int __PropertyOffset_RenderTarget;

		// Token: 0x0400BF5A RID: 48986
		internal static int __PropertyOffset_DebugArr;

		// Token: 0x0400BF5B RID: 48987
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKuroCSParticle_doubleChain> _DebugArr;

		// Token: 0x0400BF5C RID: 48988
		internal static int __PropertyOffset_XCount;

		// Token: 0x0400BF5D RID: 48989
		internal static int __PropertyOffset_YCount;

		// Token: 0x0400BF5E RID: 48990
		internal static int __PropertyOffset_DisStiffness;

		// Token: 0x0400BF5F RID: 48991
		internal static int __PropertyOffset_bendStiffness;

		// Token: 0x0400BF60 RID: 48992
		internal static int __PropertyOffset_playerPos;

		// Token: 0x0400BF61 RID: 48993
		internal static int __PropertyOffset_collisionR;

		// Token: 0x0400BF62 RID: 48994
		internal static int __PropertyOffset_ParticleCount;

		// Token: 0x0400BF63 RID: 48995
		internal static int __PropertyOffset_linkDis;

		// Token: 0x0400BF64 RID: 48996
		internal static int __PropertyOffset_substepCount;

		// Token: 0x0400BF65 RID: 48997
		internal static int __PropertyOffset_accel_ext;

		// Token: 0x0400BF66 RID: 48998
		internal static int __PropertyOffset_actorPos;

		// Token: 0x0400BF67 RID: 48999
		internal static int __PropertyOffset_SecondArrayStart;

		// Token: 0x0400BF68 RID: 49000
		internal static int __PropertyOffset_SecondArrayIndex;

		// Token: 0x0400BF69 RID: 49001
		internal static int __PropertyOffset_LocalPosOffset;
	}
}
