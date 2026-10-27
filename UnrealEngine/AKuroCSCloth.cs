using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020017A5 RID: 6053
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroComputeShader.KuroCSCloth")]
	[UnrealStructLayout(1216, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1216)]
	public class AKuroCSCloth : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06015DC5 RID: 89541 RVA: 0x00201727 File Offset: 0x001FF927
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AKuroCSCloth._ClassPtr;
		}

		// Token: 0x06015DC6 RID: 89542 RVA: 0x00201734 File Offset: 0x001FF934
		public AKuroCSCloth() : this(BuiltinUtils.AllocNativeUObject(AKuroCSCloth.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06015DC7 RID: 89543 RVA: 0x0020175C File Offset: 0x001FF95C
		[NullableContext(1)]
		public AKuroCSCloth(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AKuroCSCloth.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170056B7 RID: 22199
		// (get) Token: 0x06015DC8 RID: 89544 RVA: 0x0020178F File Offset: 0x001FF98F
		// (set) Token: 0x06015DC9 RID: 89545 RVA: 0x002017A3 File Offset: 0x001FF9A3
		public unsafe USceneComponent Root
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroCSCloth.__PropertyOffset_Root);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroCSCloth.__PropertyOffset_Root, value);
			}
		}

		// Token: 0x170056B8 RID: 22200
		// (get) Token: 0x06015DCA RID: 89546 RVA: 0x002017B8 File Offset: 0x001FF9B8
		// (set) Token: 0x06015DCB RID: 89547 RVA: 0x002017C8 File Offset: 0x001FF9C8
		public unsafe bool useExternalRT
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSCloth.__PropertyOffset_useExternalRT) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSCloth.__PropertyOffset_useExternalRT) = (value ? 1 : 0);
			}
		}

		// Token: 0x170056B9 RID: 22201
		// (get) Token: 0x06015DCC RID: 89548 RVA: 0x002017D9 File Offset: 0x001FF9D9
		// (set) Token: 0x06015DCD RID: 89549 RVA: 0x002017ED File Offset: 0x001FF9ED
		public unsafe UTextureRenderTarget2D RenderTarget
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTarget2D>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroCSCloth.__PropertyOffset_RenderTarget);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroCSCloth.__PropertyOffset_RenderTarget, value);
			}
		}

		// Token: 0x170056BA RID: 22202
		// (get) Token: 0x06015DCE RID: 89550 RVA: 0x00201802 File Offset: 0x001FFA02
		// (set) Token: 0x06015DCF RID: 89551 RVA: 0x00201816 File Offset: 0x001FFA16
		public unsafe UTextureRenderTarget2D RenderTarget_N
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTarget2D>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroCSCloth.__PropertyOffset_RenderTarget_N);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroCSCloth.__PropertyOffset_RenderTarget_N, value);
			}
		}

		// Token: 0x170056BB RID: 22203
		// (get) Token: 0x06015DD0 RID: 89552 RVA: 0x0020182C File Offset: 0x001FFA2C
		// (set) Token: 0x06015DD1 RID: 89553 RVA: 0x00201865 File Offset: 0x001FFA65
		[Nullable(1)]
		public TArray<FKuroCSParticle_cloth> DebugArr
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FKuroCSParticle_cloth> result;
				if ((result = this._DebugArr) == null)
				{
					result = (this._DebugArr = new TArray<FKuroCSParticle_cloth>(base.NativePtr + (IntPtr)AKuroCSCloth.__PropertyOffset_DebugArr, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.DebugArr.CopyAssign(value);
			}
		}

		// Token: 0x170056BC RID: 22204
		// (get) Token: 0x06015DD2 RID: 89554 RVA: 0x00201873 File Offset: 0x001FFA73
		// (set) Token: 0x06015DD3 RID: 89555 RVA: 0x00201883 File Offset: 0x001FFA83
		public unsafe int XCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSCloth.__PropertyOffset_XCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSCloth.__PropertyOffset_XCount) = value;
			}
		}

		// Token: 0x170056BD RID: 22205
		// (get) Token: 0x06015DD4 RID: 89556 RVA: 0x00201894 File Offset: 0x001FFA94
		// (set) Token: 0x06015DD5 RID: 89557 RVA: 0x002018A4 File Offset: 0x001FFAA4
		public unsafe int YCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSCloth.__PropertyOffset_YCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSCloth.__PropertyOffset_YCount) = value;
			}
		}

		// Token: 0x170056BE RID: 22206
		// (get) Token: 0x06015DD6 RID: 89558 RVA: 0x002018B5 File Offset: 0x001FFAB5
		// (set) Token: 0x06015DD7 RID: 89559 RVA: 0x002018C5 File Offset: 0x001FFAC5
		public unsafe float DisStiffness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSCloth.__PropertyOffset_DisStiffness);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSCloth.__PropertyOffset_DisStiffness) = value;
			}
		}

		// Token: 0x170056BF RID: 22207
		// (get) Token: 0x06015DD8 RID: 89560 RVA: 0x002018D6 File Offset: 0x001FFAD6
		// (set) Token: 0x06015DD9 RID: 89561 RVA: 0x002018EA File Offset: 0x001FFAEA
		public unsafe FVector boxCenter
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSCloth.__PropertyOffset_boxCenter);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSCloth.__PropertyOffset_boxCenter) = value;
			}
		}

		// Token: 0x170056C0 RID: 22208
		// (get) Token: 0x06015DDA RID: 89562 RVA: 0x002018FF File Offset: 0x001FFAFF
		// (set) Token: 0x06015DDB RID: 89563 RVA: 0x00201913 File Offset: 0x001FFB13
		public unsafe FVector boxHalfSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSCloth.__PropertyOffset_boxHalfSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSCloth.__PropertyOffset_boxHalfSize) = value;
			}
		}

		// Token: 0x170056C1 RID: 22209
		// (get) Token: 0x06015DDC RID: 89564 RVA: 0x00201928 File Offset: 0x001FFB28
		// (set) Token: 0x06015DDD RID: 89565 RVA: 0x00201938 File Offset: 0x001FFB38
		public unsafe bool bInverseBox
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSCloth.__PropertyOffset_bInverseBox) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSCloth.__PropertyOffset_bInverseBox) = (value ? 1 : 0);
			}
		}

		// Token: 0x170056C2 RID: 22210
		// (get) Token: 0x06015DDE RID: 89566 RVA: 0x00201949 File Offset: 0x001FFB49
		// (set) Token: 0x06015DDF RID: 89567 RVA: 0x00201959 File Offset: 0x001FFB59
		public unsafe float gravityZeroDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSCloth.__PropertyOffset_gravityZeroDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSCloth.__PropertyOffset_gravityZeroDistance) = value;
			}
		}

		// Token: 0x170056C3 RID: 22211
		// (get) Token: 0x06015DE0 RID: 89568 RVA: 0x0020196A File Offset: 0x001FFB6A
		// (set) Token: 0x06015DE1 RID: 89569 RVA: 0x0020197A File Offset: 0x001FFB7A
		public unsafe float collisionFriction
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSCloth.__PropertyOffset_collisionFriction);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSCloth.__PropertyOffset_collisionFriction) = value;
			}
		}

		// Token: 0x170056C4 RID: 22212
		// (get) Token: 0x06015DE2 RID: 89570 RVA: 0x0020198B File Offset: 0x001FFB8B
		// (set) Token: 0x06015DE3 RID: 89571 RVA: 0x0020199B File Offset: 0x001FFB9B
		public unsafe bool bHypotenuseConstraint
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSCloth.__PropertyOffset_bHypotenuseConstraint) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSCloth.__PropertyOffset_bHypotenuseConstraint) = (value ? 1 : 0);
			}
		}

		// Token: 0x170056C5 RID: 22213
		// (get) Token: 0x06015DE4 RID: 89572 RVA: 0x002019AC File Offset: 0x001FFBAC
		// (set) Token: 0x06015DE5 RID: 89573 RVA: 0x002019BC File Offset: 0x001FFBBC
		public unsafe float bendStiffness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSCloth.__PropertyOffset_bendStiffness);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSCloth.__PropertyOffset_bendStiffness) = value;
			}
		}

		// Token: 0x170056C6 RID: 22214
		// (get) Token: 0x06015DE6 RID: 89574 RVA: 0x002019CD File Offset: 0x001FFBCD
		// (set) Token: 0x06015DE7 RID: 89575 RVA: 0x002019E1 File Offset: 0x001FFBE1
		public unsafe FVector playerPos
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSCloth.__PropertyOffset_playerPos);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSCloth.__PropertyOffset_playerPos) = value;
			}
		}

		// Token: 0x170056C7 RID: 22215
		// (get) Token: 0x06015DE8 RID: 89576 RVA: 0x002019F6 File Offset: 0x001FFBF6
		// (set) Token: 0x06015DE9 RID: 89577 RVA: 0x00201A06 File Offset: 0x001FFC06
		public unsafe float collisionR
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSCloth.__PropertyOffset_collisionR);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSCloth.__PropertyOffset_collisionR) = value;
			}
		}

		// Token: 0x170056C8 RID: 22216
		// (get) Token: 0x06015DEA RID: 89578 RVA: 0x00201A17 File Offset: 0x001FFC17
		// (set) Token: 0x06015DEB RID: 89579 RVA: 0x00201A27 File Offset: 0x001FFC27
		public unsafe int ParticleCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSCloth.__PropertyOffset_ParticleCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSCloth.__PropertyOffset_ParticleCount) = value;
			}
		}

		// Token: 0x170056C9 RID: 22217
		// (get) Token: 0x06015DEC RID: 89580 RVA: 0x00201A38 File Offset: 0x001FFC38
		// (set) Token: 0x06015DED RID: 89581 RVA: 0x00201A48 File Offset: 0x001FFC48
		public unsafe float linkDis
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSCloth.__PropertyOffset_linkDis);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSCloth.__PropertyOffset_linkDis) = value;
			}
		}

		// Token: 0x170056CA RID: 22218
		// (get) Token: 0x06015DEE RID: 89582 RVA: 0x00201A59 File Offset: 0x001FFC59
		// (set) Token: 0x06015DEF RID: 89583 RVA: 0x00201A69 File Offset: 0x001FFC69
		public unsafe float linkDisY
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSCloth.__PropertyOffset_linkDisY);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSCloth.__PropertyOffset_linkDisY) = value;
			}
		}

		// Token: 0x170056CB RID: 22219
		// (get) Token: 0x06015DF0 RID: 89584 RVA: 0x00201A7A File Offset: 0x001FFC7A
		// (set) Token: 0x06015DF1 RID: 89585 RVA: 0x00201A8A File Offset: 0x001FFC8A
		public unsafe int substepCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSCloth.__PropertyOffset_substepCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSCloth.__PropertyOffset_substepCount) = value;
			}
		}

		// Token: 0x170056CC RID: 22220
		// (get) Token: 0x06015DF2 RID: 89586 RVA: 0x00201A9B File Offset: 0x001FFC9B
		// (set) Token: 0x06015DF3 RID: 89587 RVA: 0x00201AAF File Offset: 0x001FFCAF
		public unsafe FVector accel_ext
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSCloth.__PropertyOffset_accel_ext);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSCloth.__PropertyOffset_accel_ext) = value;
			}
		}

		// Token: 0x170056CD RID: 22221
		// (get) Token: 0x06015DF4 RID: 89588 RVA: 0x00201AC4 File Offset: 0x001FFCC4
		// (set) Token: 0x06015DF5 RID: 89589 RVA: 0x00201AD8 File Offset: 0x001FFCD8
		public unsafe FVector actorPos
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSCloth.__PropertyOffset_actorPos);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSCloth.__PropertyOffset_actorPos) = value;
			}
		}

		// Token: 0x170056CE RID: 22222
		// (get) Token: 0x06015DF6 RID: 89590 RVA: 0x00201AED File Offset: 0x001FFCED
		// (set) Token: 0x06015DF7 RID: 89591 RVA: 0x00201AFD File Offset: 0x001FFCFD
		public unsafe float deltaTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSCloth.__PropertyOffset_deltaTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSCloth.__PropertyOffset_deltaTime) = value;
			}
		}

		// Token: 0x170056CF RID: 22223
		// (get) Token: 0x06015DF8 RID: 89592 RVA: 0x00201B0E File Offset: 0x001FFD0E
		// (set) Token: 0x06015DF9 RID: 89593 RVA: 0x00201B1E File Offset: 0x001FFD1E
		public unsafe bool bYZPlane
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSCloth.__PropertyOffset_bYZPlane) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSCloth.__PropertyOffset_bYZPlane) = (value ? 1 : 0);
			}
		}

		// Token: 0x06015DFA RID: 89594 RVA: 0x00201B2F File Offset: 0x001FFD2F
		public void StopSimulation()
		{
			AKuroCSCloth.__StopSimulation_Internal(base.NativePtr);
		}

		// Token: 0x06015DFB RID: 89595 RVA: 0x00201B3C File Offset: 0x001FFD3C
		public void StartSimulation()
		{
			AKuroCSCloth.__StartSimulation_Internal(base.NativePtr);
		}

		// Token: 0x06015DFC RID: 89596 RVA: 0x00201B49 File Offset: 0x001FFD49
		public void ReleaseShaderManager()
		{
			AKuroCSCloth.__ReleaseShaderManager_Internal(base.NativePtr);
		}

		// Token: 0x06015DFD RID: 89597 RVA: 0x00201B56 File Offset: 0x001FFD56
		public void InitShaderManager()
		{
			AKuroCSCloth.__InitShaderManager_Internal(base.NativePtr);
		}

		// Token: 0x06015DFE RID: 89598
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __StopSimulation_Internal(IntPtr @this);

		// Token: 0x06015DFF RID: 89599
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __StartSimulation_Internal(IntPtr @this);

		// Token: 0x06015E00 RID: 89600
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ReleaseShaderManager_Internal(IntPtr @this);

		// Token: 0x06015E01 RID: 89601
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __InitShaderManager_Internal(IntPtr @this);

		// Token: 0x06015E02 RID: 89602 RVA: 0x00201B63 File Offset: 0x001FFD63
		static AKuroCSCloth()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroComputeShader.KuroCSCloth");
		}

		// Token: 0x06015E03 RID: 89603 RVA: 0x00201B71 File Offset: 0x001FFD71
		protected AKuroCSCloth(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400BEBD RID: 48829
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroComputeShader.KuroCSCloth";

		// Token: 0x0400BEBE RID: 48830
		private static IntPtr _ClassPtr;

		// Token: 0x0400BEBF RID: 48831
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400BEC0 RID: 48832
		internal static int __PropertyOffset_Root;

		// Token: 0x0400BEC1 RID: 48833
		internal static int __PropertyOffset_useExternalRT;

		// Token: 0x0400BEC2 RID: 48834
		internal static int __PropertyOffset_RenderTarget;

		// Token: 0x0400BEC3 RID: 48835
		internal static int __PropertyOffset_RenderTarget_N;

		// Token: 0x0400BEC4 RID: 48836
		internal static int __PropertyOffset_DebugArr;

		// Token: 0x0400BEC5 RID: 48837
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKuroCSParticle_cloth> _DebugArr;

		// Token: 0x0400BEC6 RID: 48838
		internal static int __PropertyOffset_XCount;

		// Token: 0x0400BEC7 RID: 48839
		internal static int __PropertyOffset_YCount;

		// Token: 0x0400BEC8 RID: 48840
		internal static int __PropertyOffset_DisStiffness;

		// Token: 0x0400BEC9 RID: 48841
		internal static int __PropertyOffset_boxCenter;

		// Token: 0x0400BECA RID: 48842
		internal static int __PropertyOffset_boxHalfSize;

		// Token: 0x0400BECB RID: 48843
		internal static int __PropertyOffset_bInverseBox;

		// Token: 0x0400BECC RID: 48844
		internal static int __PropertyOffset_gravityZeroDistance;

		// Token: 0x0400BECD RID: 48845
		internal static int __PropertyOffset_collisionFriction;

		// Token: 0x0400BECE RID: 48846
		internal static int __PropertyOffset_bHypotenuseConstraint;

		// Token: 0x0400BECF RID: 48847
		internal static int __PropertyOffset_bendStiffness;

		// Token: 0x0400BED0 RID: 48848
		internal static int __PropertyOffset_playerPos;

		// Token: 0x0400BED1 RID: 48849
		internal static int __PropertyOffset_collisionR;

		// Token: 0x0400BED2 RID: 48850
		internal static int __PropertyOffset_ParticleCount;

		// Token: 0x0400BED3 RID: 48851
		internal static int __PropertyOffset_linkDis;

		// Token: 0x0400BED4 RID: 48852
		internal static int __PropertyOffset_linkDisY;

		// Token: 0x0400BED5 RID: 48853
		internal static int __PropertyOffset_substepCount;

		// Token: 0x0400BED6 RID: 48854
		internal static int __PropertyOffset_accel_ext;

		// Token: 0x0400BED7 RID: 48855
		internal static int __PropertyOffset_actorPos;

		// Token: 0x0400BED8 RID: 48856
		internal static int __PropertyOffset_deltaTime;

		// Token: 0x0400BED9 RID: 48857
		internal static int __PropertyOffset_bYZPlane;
	}
}
