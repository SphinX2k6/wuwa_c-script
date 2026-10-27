using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020017DA RID: 6106
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroComputeShader.KuroCS_Cloth_Path")]
	[UnrealStructLayout(1168, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1168)]
	public class AKuroCS_Cloth_Path : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06016849 RID: 92233 RVA: 0x0020E124 File Offset: 0x0020C324
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AKuroCS_Cloth_Path._ClassPtr;
		}

		// Token: 0x0601684A RID: 92234 RVA: 0x0020E130 File Offset: 0x0020C330
		public AKuroCS_Cloth_Path() : this(BuiltinUtils.AllocNativeUObject(AKuroCS_Cloth_Path.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601684B RID: 92235 RVA: 0x0020E158 File Offset: 0x0020C358
		[NullableContext(1)]
		public AKuroCS_Cloth_Path(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AKuroCS_Cloth_Path.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005AE4 RID: 23268
		// (get) Token: 0x0601684C RID: 92236 RVA: 0x0020E18B File Offset: 0x0020C38B
		// (set) Token: 0x0601684D RID: 92237 RVA: 0x0020E19F File Offset: 0x0020C39F
		public unsafe USceneComponent Root
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroCS_Cloth_Path.__PropertyOffset_Root);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroCS_Cloth_Path.__PropertyOffset_Root, value);
			}
		}

		// Token: 0x17005AE5 RID: 23269
		// (get) Token: 0x0601684E RID: 92238 RVA: 0x0020E1B4 File Offset: 0x0020C3B4
		// (set) Token: 0x0601684F RID: 92239 RVA: 0x0020E1C4 File Offset: 0x0020C3C4
		public unsafe bool useExternalRT
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCS_Cloth_Path.__PropertyOffset_useExternalRT) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCS_Cloth_Path.__PropertyOffset_useExternalRT) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005AE6 RID: 23270
		// (get) Token: 0x06016850 RID: 92240 RVA: 0x0020E1D5 File Offset: 0x0020C3D5
		// (set) Token: 0x06016851 RID: 92241 RVA: 0x0020E1E9 File Offset: 0x0020C3E9
		public unsafe UTextureRenderTarget2D RenderTarget
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTarget2D>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroCS_Cloth_Path.__PropertyOffset_RenderTarget);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroCS_Cloth_Path.__PropertyOffset_RenderTarget, value);
			}
		}

		// Token: 0x17005AE7 RID: 23271
		// (get) Token: 0x06016852 RID: 92242 RVA: 0x0020E1FE File Offset: 0x0020C3FE
		// (set) Token: 0x06016853 RID: 92243 RVA: 0x0020E212 File Offset: 0x0020C412
		public unsafe UTextureRenderTarget2D RenderTarget_N
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTarget2D>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroCS_Cloth_Path.__PropertyOffset_RenderTarget_N);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroCS_Cloth_Path.__PropertyOffset_RenderTarget_N, value);
			}
		}

		// Token: 0x17005AE8 RID: 23272
		// (get) Token: 0x06016854 RID: 92244 RVA: 0x0020E228 File Offset: 0x0020C428
		// (set) Token: 0x06016855 RID: 92245 RVA: 0x0020E261 File Offset: 0x0020C461
		[Nullable(1)]
		public TArray<FKuroCSParticle_Cloth_Path> DebugArr
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FKuroCSParticle_Cloth_Path> result;
				if ((result = this._DebugArr) == null)
				{
					result = (this._DebugArr = new TArray<FKuroCSParticle_Cloth_Path>(base.NativePtr + (IntPtr)AKuroCS_Cloth_Path.__PropertyOffset_DebugArr, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.DebugArr.CopyAssign(value);
			}
		}

		// Token: 0x17005AE9 RID: 23273
		// (get) Token: 0x06016856 RID: 92246 RVA: 0x0020E26F File Offset: 0x0020C46F
		// (set) Token: 0x06016857 RID: 92247 RVA: 0x0020E27F File Offset: 0x0020C47F
		public unsafe int XCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCS_Cloth_Path.__PropertyOffset_XCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCS_Cloth_Path.__PropertyOffset_XCount) = value;
			}
		}

		// Token: 0x17005AEA RID: 23274
		// (get) Token: 0x06016858 RID: 92248 RVA: 0x0020E290 File Offset: 0x0020C490
		// (set) Token: 0x06016859 RID: 92249 RVA: 0x0020E2A0 File Offset: 0x0020C4A0
		public unsafe int YCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCS_Cloth_Path.__PropertyOffset_YCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCS_Cloth_Path.__PropertyOffset_YCount) = value;
			}
		}

		// Token: 0x17005AEB RID: 23275
		// (get) Token: 0x0601685A RID: 92250 RVA: 0x0020E2B1 File Offset: 0x0020C4B1
		// (set) Token: 0x0601685B RID: 92251 RVA: 0x0020E2C1 File Offset: 0x0020C4C1
		public unsafe float DisStiffness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCS_Cloth_Path.__PropertyOffset_DisStiffness);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCS_Cloth_Path.__PropertyOffset_DisStiffness) = value;
			}
		}

		// Token: 0x17005AEC RID: 23276
		// (get) Token: 0x0601685C RID: 92252 RVA: 0x0020E2D2 File Offset: 0x0020C4D2
		// (set) Token: 0x0601685D RID: 92253 RVA: 0x0020E2E6 File Offset: 0x0020C4E6
		public unsafe FVector playerPos
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCS_Cloth_Path.__PropertyOffset_playerPos);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCS_Cloth_Path.__PropertyOffset_playerPos) = value;
			}
		}

		// Token: 0x17005AED RID: 23277
		// (get) Token: 0x0601685E RID: 92254 RVA: 0x0020E2FB File Offset: 0x0020C4FB
		// (set) Token: 0x0601685F RID: 92255 RVA: 0x0020E30B File Offset: 0x0020C50B
		public unsafe float collisionR
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCS_Cloth_Path.__PropertyOffset_collisionR);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCS_Cloth_Path.__PropertyOffset_collisionR) = value;
			}
		}

		// Token: 0x17005AEE RID: 23278
		// (get) Token: 0x06016860 RID: 92256 RVA: 0x0020E31C File Offset: 0x0020C51C
		// (set) Token: 0x06016861 RID: 92257 RVA: 0x0020E32C File Offset: 0x0020C52C
		public unsafe float upOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCS_Cloth_Path.__PropertyOffset_upOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCS_Cloth_Path.__PropertyOffset_upOffset) = value;
			}
		}

		// Token: 0x17005AEF RID: 23279
		// (get) Token: 0x06016862 RID: 92258 RVA: 0x0020E33D File Offset: 0x0020C53D
		// (set) Token: 0x06016863 RID: 92259 RVA: 0x0020E34D File Offset: 0x0020C54D
		public unsafe float volDamping
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCS_Cloth_Path.__PropertyOffset_volDamping);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCS_Cloth_Path.__PropertyOffset_volDamping) = value;
			}
		}

		// Token: 0x17005AF0 RID: 23280
		// (get) Token: 0x06016864 RID: 92260 RVA: 0x0020E35E File Offset: 0x0020C55E
		// (set) Token: 0x06016865 RID: 92261 RVA: 0x0020E36E File Offset: 0x0020C56E
		public unsafe float linkDisScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCS_Cloth_Path.__PropertyOffset_linkDisScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCS_Cloth_Path.__PropertyOffset_linkDisScale) = value;
			}
		}

		// Token: 0x17005AF1 RID: 23281
		// (get) Token: 0x06016866 RID: 92262 RVA: 0x0020E37F File Offset: 0x0020C57F
		// (set) Token: 0x06016867 RID: 92263 RVA: 0x0020E38F File Offset: 0x0020C58F
		public unsafe float attenuationPower
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCS_Cloth_Path.__PropertyOffset_attenuationPower);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCS_Cloth_Path.__PropertyOffset_attenuationPower) = value;
			}
		}

		// Token: 0x17005AF2 RID: 23282
		// (get) Token: 0x06016868 RID: 92264 RVA: 0x0020E3A0 File Offset: 0x0020C5A0
		// (set) Token: 0x06016869 RID: 92265 RVA: 0x0020E3B4 File Offset: 0x0020C5B4
		public unsafe FVector actorPos
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCS_Cloth_Path.__PropertyOffset_actorPos);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCS_Cloth_Path.__PropertyOffset_actorPos) = value;
			}
		}

		// Token: 0x17005AF3 RID: 23283
		// (get) Token: 0x0601686A RID: 92266 RVA: 0x0020E3CC File Offset: 0x0020C5CC
		// (set) Token: 0x0601686B RID: 92267 RVA: 0x0020E405 File Offset: 0x0020C605
		[Nullable(1)]
		public TArray<FKuroCSParticle_Cloth_Path> ParticlesArr
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FKuroCSParticle_Cloth_Path> result;
				if ((result = this._ParticlesArr) == null)
				{
					result = (this._ParticlesArr = new TArray<FKuroCSParticle_Cloth_Path>(base.NativePtr + (IntPtr)AKuroCS_Cloth_Path.__PropertyOffset_ParticlesArr, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.ParticlesArr.CopyAssign(value);
			}
		}

		// Token: 0x0601686C RID: 92268 RVA: 0x0020E413 File Offset: 0x0020C613
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void StopSimulation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, AKuroCS_Cloth_Path.__StopSimulation_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0601686D RID: 92269 RVA: 0x0020E428 File Offset: 0x0020C628
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void StartSimulation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, AKuroCS_Cloth_Path.__StartSimulation_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0601686E RID: 92270 RVA: 0x0020E43D File Offset: 0x0020C63D
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void ReleaseShaderManager()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, AKuroCS_Cloth_Path.__ReleaseShaderManager_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0601686F RID: 92271 RVA: 0x0020E452 File Offset: 0x0020C652
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void InitShaderManager()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, AKuroCS_Cloth_Path.__InitShaderManager_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06016870 RID: 92272 RVA: 0x0020E467 File Offset: 0x0020C667
		static AKuroCS_Cloth_Path()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroComputeShader.KuroCS_Cloth_Path");
		}

		// Token: 0x06016871 RID: 92273 RVA: 0x0020E475 File Offset: 0x0020C675
		protected AKuroCS_Cloth_Path(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400C3AD RID: 50093
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroComputeShader.KuroCS_Cloth_Path";

		// Token: 0x0400C3AE RID: 50094
		private static IntPtr _ClassPtr;

		// Token: 0x0400C3AF RID: 50095
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400C3B0 RID: 50096
		internal static int __PropertyOffset_Root;

		// Token: 0x0400C3B1 RID: 50097
		internal static int __PropertyOffset_useExternalRT;

		// Token: 0x0400C3B2 RID: 50098
		internal static int __PropertyOffset_RenderTarget;

		// Token: 0x0400C3B3 RID: 50099
		internal static int __PropertyOffset_RenderTarget_N;

		// Token: 0x0400C3B4 RID: 50100
		internal static int __PropertyOffset_DebugArr;

		// Token: 0x0400C3B5 RID: 50101
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKuroCSParticle_Cloth_Path> _DebugArr;

		// Token: 0x0400C3B6 RID: 50102
		internal static int __PropertyOffset_XCount;

		// Token: 0x0400C3B7 RID: 50103
		internal static int __PropertyOffset_YCount;

		// Token: 0x0400C3B8 RID: 50104
		internal static int __PropertyOffset_DisStiffness;

		// Token: 0x0400C3B9 RID: 50105
		internal static int __PropertyOffset_playerPos;

		// Token: 0x0400C3BA RID: 50106
		internal static int __PropertyOffset_collisionR;

		// Token: 0x0400C3BB RID: 50107
		internal static int __PropertyOffset_upOffset;

		// Token: 0x0400C3BC RID: 50108
		internal static int __PropertyOffset_volDamping;

		// Token: 0x0400C3BD RID: 50109
		internal static int __PropertyOffset_linkDisScale;

		// Token: 0x0400C3BE RID: 50110
		internal static int __PropertyOffset_attenuationPower;

		// Token: 0x0400C3BF RID: 50111
		internal static int __PropertyOffset_actorPos;

		// Token: 0x0400C3C0 RID: 50112
		internal static int __PropertyOffset_ParticlesArr;

		// Token: 0x0400C3C1 RID: 50113
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKuroCSParticle_Cloth_Path> _ParticlesArr;

		// Token: 0x0400C3C2 RID: 50114
		private static IntPtr __StopSimulation_NativeFunctionPtr;

		// Token: 0x0400C3C3 RID: 50115
		private static IntPtr __StartSimulation_NativeFunctionPtr;

		// Token: 0x0400C3C4 RID: 50116
		private static IntPtr __ReleaseShaderManager_NativeFunctionPtr;

		// Token: 0x0400C3C5 RID: 50117
		private static IntPtr __InitShaderManager_NativeFunctionPtr;
	}
}
