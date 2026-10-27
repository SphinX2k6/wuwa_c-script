using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020017C6 RID: 6086
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroComputeShader.KuroCSPlantAnim")]
	[UnrealStructLayout(1208, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1208)]
	public class AKuroCSPlantAnim : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06016457 RID: 91223 RVA: 0x00209728 File Offset: 0x00207928
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AKuroCSPlantAnim._ClassPtr;
		}

		// Token: 0x06016458 RID: 91224 RVA: 0x00209734 File Offset: 0x00207934
		public AKuroCSPlantAnim() : this(BuiltinUtils.AllocNativeUObject(AKuroCSPlantAnim.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06016459 RID: 91225 RVA: 0x0020975C File Offset: 0x0020795C
		[NullableContext(1)]
		public AKuroCSPlantAnim(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AKuroCSPlantAnim.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700595C RID: 22876
		// (get) Token: 0x0601645A RID: 91226 RVA: 0x0020978F File Offset: 0x0020798F
		// (set) Token: 0x0601645B RID: 91227 RVA: 0x002097A3 File Offset: 0x002079A3
		public unsafe USceneComponent Root
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroCSPlantAnim.__PropertyOffset_Root);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroCSPlantAnim.__PropertyOffset_Root, value);
			}
		}

		// Token: 0x1700595D RID: 22877
		// (get) Token: 0x0601645C RID: 91228 RVA: 0x002097B8 File Offset: 0x002079B8
		// (set) Token: 0x0601645D RID: 91229 RVA: 0x002097CC File Offset: 0x002079CC
		public unsafe UTextureRenderTarget2D RenderTarget
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTarget2D>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroCSPlantAnim.__PropertyOffset_RenderTarget);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroCSPlantAnim.__PropertyOffset_RenderTarget, value);
			}
		}

		// Token: 0x1700595E RID: 22878
		// (get) Token: 0x0601645E RID: 91230 RVA: 0x002097E1 File Offset: 0x002079E1
		// (set) Token: 0x0601645F RID: 91231 RVA: 0x002097F1 File Offset: 0x002079F1
		public unsafe int ParticleCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSPlantAnim.__PropertyOffset_ParticleCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSPlantAnim.__PropertyOffset_ParticleCount) = value;
			}
		}

		// Token: 0x1700595F RID: 22879
		// (get) Token: 0x06016460 RID: 91232 RVA: 0x00209802 File Offset: 0x00207A02
		// (set) Token: 0x06016461 RID: 91233 RVA: 0x00209816 File Offset: 0x00207A16
		public unsafe FVector PlayerPos
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSPlantAnim.__PropertyOffset_PlayerPos);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSPlantAnim.__PropertyOffset_PlayerPos) = value;
			}
		}

		// Token: 0x17005960 RID: 22880
		// (get) Token: 0x06016462 RID: 91234 RVA: 0x0020982B File Offset: 0x00207A2B
		// (set) Token: 0x06016463 RID: 91235 RVA: 0x0020983B File Offset: 0x00207A3B
		public unsafe float CollisionR
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSPlantAnim.__PropertyOffset_CollisionR);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSPlantAnim.__PropertyOffset_CollisionR) = value;
			}
		}

		// Token: 0x17005961 RID: 22881
		// (get) Token: 0x06016464 RID: 91236 RVA: 0x0020984C File Offset: 0x00207A4C
		// (set) Token: 0x06016465 RID: 91237 RVA: 0x0020985C File Offset: 0x00207A5C
		public unsafe float PushStrength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSPlantAnim.__PropertyOffset_PushStrength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSPlantAnim.__PropertyOffset_PushStrength) = value;
			}
		}

		// Token: 0x17005962 RID: 22882
		// (get) Token: 0x06016466 RID: 91238 RVA: 0x0020986D File Offset: 0x00207A6D
		// (set) Token: 0x06016467 RID: 91239 RVA: 0x0020987D File Offset: 0x00207A7D
		public unsafe int LeafPointCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSPlantAnim.__PropertyOffset_LeafPointCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSPlantAnim.__PropertyOffset_LeafPointCount) = value;
			}
		}

		// Token: 0x17005963 RID: 22883
		// (get) Token: 0x06016468 RID: 91240 RVA: 0x0020988E File Offset: 0x00207A8E
		// (set) Token: 0x06016469 RID: 91241 RVA: 0x0020989E File Offset: 0x00207A9E
		public unsafe float AnimFPS
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSPlantAnim.__PropertyOffset_AnimFPS);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSPlantAnim.__PropertyOffset_AnimFPS) = value;
			}
		}

		// Token: 0x17005964 RID: 22884
		// (get) Token: 0x0601646A RID: 91242 RVA: 0x002098AF File Offset: 0x00207AAF
		// (set) Token: 0x0601646B RID: 91243 RVA: 0x002098BF File Offset: 0x00207ABF
		public unsafe int AnimFrameCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSPlantAnim.__PropertyOffset_AnimFrameCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSPlantAnim.__PropertyOffset_AnimFrameCount) = value;
			}
		}

		// Token: 0x17005965 RID: 22885
		// (get) Token: 0x0601646C RID: 91244 RVA: 0x002098D0 File Offset: 0x00207AD0
		// (set) Token: 0x0601646D RID: 91245 RVA: 0x002098E0 File Offset: 0x00207AE0
		public unsafe float ParentRotWeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSPlantAnim.__PropertyOffset_ParentRotWeight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSPlantAnim.__PropertyOffset_ParentRotWeight) = value;
			}
		}

		// Token: 0x17005966 RID: 22886
		// (get) Token: 0x0601646E RID: 91246 RVA: 0x002098F1 File Offset: 0x00207AF1
		// (set) Token: 0x0601646F RID: 91247 RVA: 0x00209901 File Offset: 0x00207B01
		public unsafe float BranchStiffness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSPlantAnim.__PropertyOffset_BranchStiffness);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSPlantAnim.__PropertyOffset_BranchStiffness) = value;
			}
		}

		// Token: 0x17005967 RID: 22887
		// (get) Token: 0x06016470 RID: 91248 RVA: 0x00209912 File Offset: 0x00207B12
		// (set) Token: 0x06016471 RID: 91249 RVA: 0x00209926 File Offset: 0x00207B26
		public unsafe UTexture2D AniTex
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroCSPlantAnim.__PropertyOffset_AniTex);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroCSPlantAnim.__PropertyOffset_AniTex, value);
			}
		}

		// Token: 0x17005968 RID: 22888
		// (get) Token: 0x06016472 RID: 91250 RVA: 0x0020993B File Offset: 0x00207B3B
		// (set) Token: 0x06016473 RID: 91251 RVA: 0x0020994F File Offset: 0x00207B4F
		public unsafe UTexture2D NormTex
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroCSPlantAnim.__PropertyOffset_NormTex);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroCSPlantAnim.__PropertyOffset_NormTex, value);
			}
		}

		// Token: 0x17005969 RID: 22889
		// (get) Token: 0x06016474 RID: 91252 RVA: 0x00209964 File Offset: 0x00207B64
		// (set) Token: 0x06016475 RID: 91253 RVA: 0x0020999D File Offset: 0x00207B9D
		[Nullable(1)]
		public TArray<FVector> PosArray
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FVector> result;
				if ((result = this._PosArray) == null)
				{
					result = (this._PosArray = new TArray<FVector>(base.NativePtr + (IntPtr)AKuroCSPlantAnim.__PropertyOffset_PosArray, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.PosArray.CopyAssign(value);
			}
		}

		// Token: 0x1700596A RID: 22890
		// (get) Token: 0x06016476 RID: 91254 RVA: 0x002099AC File Offset: 0x00207BAC
		// (set) Token: 0x06016477 RID: 91255 RVA: 0x002099E5 File Offset: 0x00207BE5
		[Nullable(1)]
		public TArray<FVector> NormArray
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FVector> result;
				if ((result = this._NormArray) == null)
				{
					result = (this._NormArray = new TArray<FVector>(base.NativePtr + (IntPtr)AKuroCSPlantAnim.__PropertyOffset_NormArray, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.NormArray.CopyAssign(value);
			}
		}

		// Token: 0x1700596B RID: 22891
		// (get) Token: 0x06016478 RID: 91256 RVA: 0x002099F4 File Offset: 0x00207BF4
		// (set) Token: 0x06016479 RID: 91257 RVA: 0x00209A2D File Offset: 0x00207C2D
		[Nullable(1)]
		public TArray<FVector> DirArray
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FVector> result;
				if ((result = this._DirArray) == null)
				{
					result = (this._DirArray = new TArray<FVector>(base.NativePtr + (IntPtr)AKuroCSPlantAnim.__PropertyOffset_DirArray, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.DirArray.CopyAssign(value);
			}
		}

		// Token: 0x1700596C RID: 22892
		// (get) Token: 0x0601647A RID: 91258 RVA: 0x00209A3B File Offset: 0x00207C3B
		// (set) Token: 0x0601647B RID: 91259 RVA: 0x00209A4B File Offset: 0x00207C4B
		public unsafe bool bEnableCPURead
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSPlantAnim.__PropertyOffset_bEnableCPURead) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSPlantAnim.__PropertyOffset_bEnableCPURead) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700596D RID: 22893
		// (get) Token: 0x0601647C RID: 91260 RVA: 0x00209A5C File Offset: 0x00207C5C
		// (set) Token: 0x0601647D RID: 91261 RVA: 0x00209A95 File Offset: 0x00207C95
		[Nullable(1)]
		public TArray<FKuroCSParticle_PlantAnim> DebugArr
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FKuroCSParticle_PlantAnim> result;
				if ((result = this._DebugArr) == null)
				{
					result = (this._DebugArr = new TArray<FKuroCSParticle_PlantAnim>(base.NativePtr + (IntPtr)AKuroCSPlantAnim.__PropertyOffset_DebugArr, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.DebugArr.CopyAssign(value);
			}
		}

		// Token: 0x0601647E RID: 91262 RVA: 0x00209AA3 File Offset: 0x00207CA3
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void AfterBeginPlay()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, AKuroCSPlantAnim.__AfterBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0601647F RID: 91263 RVA: 0x00209AB8 File Offset: 0x00207CB8
		static AKuroCSPlantAnim()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroComputeShader.KuroCSPlantAnim");
		}

		// Token: 0x06016480 RID: 91264 RVA: 0x00209AC6 File Offset: 0x00207CC6
		protected AKuroCSPlantAnim(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400C1CD RID: 49613
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroComputeShader.KuroCSPlantAnim";

		// Token: 0x0400C1CE RID: 49614
		private static IntPtr _ClassPtr;

		// Token: 0x0400C1CF RID: 49615
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400C1D0 RID: 49616
		internal static int __PropertyOffset_Root;

		// Token: 0x0400C1D1 RID: 49617
		internal static int __PropertyOffset_RenderTarget;

		// Token: 0x0400C1D2 RID: 49618
		internal static int __PropertyOffset_ParticleCount;

		// Token: 0x0400C1D3 RID: 49619
		internal static int __PropertyOffset_PlayerPos;

		// Token: 0x0400C1D4 RID: 49620
		internal static int __PropertyOffset_CollisionR;

		// Token: 0x0400C1D5 RID: 49621
		internal static int __PropertyOffset_PushStrength;

		// Token: 0x0400C1D6 RID: 49622
		internal static int __PropertyOffset_LeafPointCount;

		// Token: 0x0400C1D7 RID: 49623
		internal static int __PropertyOffset_AnimFPS;

		// Token: 0x0400C1D8 RID: 49624
		internal static int __PropertyOffset_AnimFrameCount;

		// Token: 0x0400C1D9 RID: 49625
		internal static int __PropertyOffset_ParentRotWeight;

		// Token: 0x0400C1DA RID: 49626
		internal static int __PropertyOffset_BranchStiffness;

		// Token: 0x0400C1DB RID: 49627
		internal static int __PropertyOffset_AniTex;

		// Token: 0x0400C1DC RID: 49628
		internal static int __PropertyOffset_NormTex;

		// Token: 0x0400C1DD RID: 49629
		internal static int __PropertyOffset_PosArray;

		// Token: 0x0400C1DE RID: 49630
		private TArray<FVector> _PosArray;

		// Token: 0x0400C1DF RID: 49631
		internal static int __PropertyOffset_NormArray;

		// Token: 0x0400C1E0 RID: 49632
		private TArray<FVector> _NormArray;

		// Token: 0x0400C1E1 RID: 49633
		internal static int __PropertyOffset_DirArray;

		// Token: 0x0400C1E2 RID: 49634
		private TArray<FVector> _DirArray;

		// Token: 0x0400C1E3 RID: 49635
		internal static int __PropertyOffset_bEnableCPURead;

		// Token: 0x0400C1E4 RID: 49636
		internal static int __PropertyOffset_DebugArr;

		// Token: 0x0400C1E5 RID: 49637
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKuroCSParticle_PlantAnim> _DebugArr;

		// Token: 0x0400C1E6 RID: 49638
		private static IntPtr __AfterBeginPlay_NativeFunctionPtr;
	}
}
