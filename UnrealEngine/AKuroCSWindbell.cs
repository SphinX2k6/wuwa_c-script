using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020017D7 RID: 6103
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroComputeShader.KuroCSWindbell")]
	[UnrealStructLayout(1200, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1200)]
	public class AKuroCSWindbell : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601679C RID: 92060 RVA: 0x0020D463 File Offset: 0x0020B663
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AKuroCSWindbell._ClassPtr;
		}

		// Token: 0x0601679D RID: 92061 RVA: 0x0020D470 File Offset: 0x0020B670
		public AKuroCSWindbell() : this(BuiltinUtils.AllocNativeUObject(AKuroCSWindbell.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601679E RID: 92062 RVA: 0x0020D498 File Offset: 0x0020B698
		[NullableContext(1)]
		public AKuroCSWindbell(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AKuroCSWindbell.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005A9D RID: 23197
		// (get) Token: 0x0601679F RID: 92063 RVA: 0x0020D4CB File Offset: 0x0020B6CB
		// (set) Token: 0x060167A0 RID: 92064 RVA: 0x0020D4DF File Offset: 0x0020B6DF
		public unsafe USceneComponent Root
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroCSWindbell.__PropertyOffset_Root);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroCSWindbell.__PropertyOffset_Root, value);
			}
		}

		// Token: 0x17005A9E RID: 23198
		// (get) Token: 0x060167A1 RID: 92065 RVA: 0x0020D4F4 File Offset: 0x0020B6F4
		// (set) Token: 0x060167A2 RID: 92066 RVA: 0x0020D504 File Offset: 0x0020B704
		public unsafe bool useExternalRT
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSWindbell.__PropertyOffset_useExternalRT) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSWindbell.__PropertyOffset_useExternalRT) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005A9F RID: 23199
		// (get) Token: 0x060167A3 RID: 92067 RVA: 0x0020D515 File Offset: 0x0020B715
		// (set) Token: 0x060167A4 RID: 92068 RVA: 0x0020D529 File Offset: 0x0020B729
		public unsafe UTextureRenderTarget2D RenderTarget
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTarget2D>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroCSWindbell.__PropertyOffset_RenderTarget);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroCSWindbell.__PropertyOffset_RenderTarget, value);
			}
		}

		// Token: 0x17005AA0 RID: 23200
		// (get) Token: 0x060167A5 RID: 92069 RVA: 0x0020D53E File Offset: 0x0020B73E
		// (set) Token: 0x060167A6 RID: 92070 RVA: 0x0020D552 File Offset: 0x0020B752
		public unsafe UTextureRenderTarget2D RenderTarget_N
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTarget2D>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroCSWindbell.__PropertyOffset_RenderTarget_N);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroCSWindbell.__PropertyOffset_RenderTarget_N, value);
			}
		}

		// Token: 0x17005AA1 RID: 23201
		// (get) Token: 0x060167A7 RID: 92071 RVA: 0x0020D568 File Offset: 0x0020B768
		// (set) Token: 0x060167A8 RID: 92072 RVA: 0x0020D5A1 File Offset: 0x0020B7A1
		[Nullable(1)]
		public TArray<FKuroCSParticle_windbell> DebugArr
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FKuroCSParticle_windbell> result;
				if ((result = this._DebugArr) == null)
				{
					result = (this._DebugArr = new TArray<FKuroCSParticle_windbell>(base.NativePtr + (IntPtr)AKuroCSWindbell.__PropertyOffset_DebugArr, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.DebugArr.CopyAssign(value);
			}
		}

		// Token: 0x17005AA2 RID: 23202
		// (get) Token: 0x060167A9 RID: 92073 RVA: 0x0020D5AF File Offset: 0x0020B7AF
		// (set) Token: 0x060167AA RID: 92074 RVA: 0x0020D5BF File Offset: 0x0020B7BF
		public unsafe float DisStiffness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSWindbell.__PropertyOffset_DisStiffness);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSWindbell.__PropertyOffset_DisStiffness) = value;
			}
		}

		// Token: 0x17005AA3 RID: 23203
		// (get) Token: 0x060167AB RID: 92075 RVA: 0x0020D5D0 File Offset: 0x0020B7D0
		// (set) Token: 0x060167AC RID: 92076 RVA: 0x0020D5E0 File Offset: 0x0020B7E0
		public unsafe float bendStiffness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSWindbell.__PropertyOffset_bendStiffness);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSWindbell.__PropertyOffset_bendStiffness) = value;
			}
		}

		// Token: 0x17005AA4 RID: 23204
		// (get) Token: 0x060167AD RID: 92077 RVA: 0x0020D5F1 File Offset: 0x0020B7F1
		// (set) Token: 0x060167AE RID: 92078 RVA: 0x0020D605 File Offset: 0x0020B805
		public unsafe FVector playerPos
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSWindbell.__PropertyOffset_playerPos);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSWindbell.__PropertyOffset_playerPos) = value;
			}
		}

		// Token: 0x17005AA5 RID: 23205
		// (get) Token: 0x060167AF RID: 92079 RVA: 0x0020D61A File Offset: 0x0020B81A
		// (set) Token: 0x060167B0 RID: 92080 RVA: 0x0020D62A File Offset: 0x0020B82A
		public unsafe float collisionR
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSWindbell.__PropertyOffset_collisionR);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSWindbell.__PropertyOffset_collisionR) = value;
			}
		}

		// Token: 0x17005AA6 RID: 23206
		// (get) Token: 0x060167B1 RID: 92081 RVA: 0x0020D63B File Offset: 0x0020B83B
		// (set) Token: 0x060167B2 RID: 92082 RVA: 0x0020D64B File Offset: 0x0020B84B
		public unsafe int ParticleCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSWindbell.__PropertyOffset_ParticleCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSWindbell.__PropertyOffset_ParticleCount) = value;
			}
		}

		// Token: 0x17005AA7 RID: 23207
		// (get) Token: 0x060167B3 RID: 92083 RVA: 0x0020D65C File Offset: 0x0020B85C
		// (set) Token: 0x060167B4 RID: 92084 RVA: 0x0020D66C File Offset: 0x0020B86C
		public unsafe float linkDis
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSWindbell.__PropertyOffset_linkDis);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSWindbell.__PropertyOffset_linkDis) = value;
			}
		}

		// Token: 0x17005AA8 RID: 23208
		// (get) Token: 0x060167B5 RID: 92085 RVA: 0x0020D67D File Offset: 0x0020B87D
		// (set) Token: 0x060167B6 RID: 92086 RVA: 0x0020D68D File Offset: 0x0020B88D
		public unsafe int substepCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSWindbell.__PropertyOffset_substepCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSWindbell.__PropertyOffset_substepCount) = value;
			}
		}

		// Token: 0x17005AA9 RID: 23209
		// (get) Token: 0x060167B7 RID: 92087 RVA: 0x0020D69E File Offset: 0x0020B89E
		// (set) Token: 0x060167B8 RID: 92088 RVA: 0x0020D6B2 File Offset: 0x0020B8B2
		public unsafe FVector accel_ext
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSWindbell.__PropertyOffset_accel_ext);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSWindbell.__PropertyOffset_accel_ext) = value;
			}
		}

		// Token: 0x17005AAA RID: 23210
		// (get) Token: 0x060167B9 RID: 92089 RVA: 0x0020D6C7 File Offset: 0x0020B8C7
		// (set) Token: 0x060167BA RID: 92090 RVA: 0x0020D6DB File Offset: 0x0020B8DB
		public unsafe FVector actorPos
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSWindbell.__PropertyOffset_actorPos);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSWindbell.__PropertyOffset_actorPos) = value;
			}
		}

		// Token: 0x17005AAB RID: 23211
		// (get) Token: 0x060167BB RID: 92091 RVA: 0x0020D6F0 File Offset: 0x0020B8F0
		// (set) Token: 0x060167BC RID: 92092 RVA: 0x0020D700 File Offset: 0x0020B900
		public unsafe bool bEnableCPURead
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSWindbell.__PropertyOffset_bEnableCPURead) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSWindbell.__PropertyOffset_bEnableCPURead) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005AAC RID: 23212
		// (get) Token: 0x060167BD RID: 92093 RVA: 0x0020D711 File Offset: 0x0020B911
		// (set) Token: 0x060167BE RID: 92094 RVA: 0x0020D725 File Offset: 0x0020B925
		public unsafe FVector startPos
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSWindbell.__PropertyOffset_startPos);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSWindbell.__PropertyOffset_startPos) = value;
			}
		}

		// Token: 0x17005AAD RID: 23213
		// (get) Token: 0x060167BF RID: 92095 RVA: 0x0020D73A File Offset: 0x0020B93A
		// (set) Token: 0x060167C0 RID: 92096 RVA: 0x0020D74E File Offset: 0x0020B94E
		public unsafe FVector endPos
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSWindbell.__PropertyOffset_endPos);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSWindbell.__PropertyOffset_endPos) = value;
			}
		}

		// Token: 0x17005AAE RID: 23214
		// (get) Token: 0x060167C1 RID: 92097 RVA: 0x0020D763 File Offset: 0x0020B963
		// (set) Token: 0x060167C2 RID: 92098 RVA: 0x0020D777 File Offset: 0x0020B977
		public unsafe FVector dynamicGravity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSWindbell.__PropertyOffset_dynamicGravity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSWindbell.__PropertyOffset_dynamicGravity) = value;
			}
		}

		// Token: 0x060167C3 RID: 92099 RVA: 0x0020D78C File Offset: 0x0020B98C
		public void StopSimulation()
		{
			AKuroCSWindbell.__StopSimulation_Internal(base.NativePtr);
		}

		// Token: 0x060167C4 RID: 92100 RVA: 0x0020D799 File Offset: 0x0020B999
		public void StartSimulation()
		{
			AKuroCSWindbell.__StartSimulation_Internal(base.NativePtr);
		}

		// Token: 0x060167C5 RID: 92101
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __StopSimulation_Internal(IntPtr @this);

		// Token: 0x060167C6 RID: 92102
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __StartSimulation_Internal(IntPtr @this);

		// Token: 0x060167C7 RID: 92103 RVA: 0x0020D7A6 File Offset: 0x0020B9A6
		static AKuroCSWindbell()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroComputeShader.KuroCSWindbell");
		}

		// Token: 0x060167C8 RID: 92104 RVA: 0x0020D7B4 File Offset: 0x0020B9B4
		protected AKuroCSWindbell(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400C355 RID: 50005
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroComputeShader.KuroCSWindbell";

		// Token: 0x0400C356 RID: 50006
		private static IntPtr _ClassPtr;

		// Token: 0x0400C357 RID: 50007
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400C358 RID: 50008
		internal static int __PropertyOffset_Root;

		// Token: 0x0400C359 RID: 50009
		internal static int __PropertyOffset_useExternalRT;

		// Token: 0x0400C35A RID: 50010
		internal static int __PropertyOffset_RenderTarget;

		// Token: 0x0400C35B RID: 50011
		internal static int __PropertyOffset_RenderTarget_N;

		// Token: 0x0400C35C RID: 50012
		internal static int __PropertyOffset_DebugArr;

		// Token: 0x0400C35D RID: 50013
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKuroCSParticle_windbell> _DebugArr;

		// Token: 0x0400C35E RID: 50014
		internal static int __PropertyOffset_DisStiffness;

		// Token: 0x0400C35F RID: 50015
		internal static int __PropertyOffset_bendStiffness;

		// Token: 0x0400C360 RID: 50016
		internal static int __PropertyOffset_playerPos;

		// Token: 0x0400C361 RID: 50017
		internal static int __PropertyOffset_collisionR;

		// Token: 0x0400C362 RID: 50018
		internal static int __PropertyOffset_ParticleCount;

		// Token: 0x0400C363 RID: 50019
		internal static int __PropertyOffset_linkDis;

		// Token: 0x0400C364 RID: 50020
		internal static int __PropertyOffset_substepCount;

		// Token: 0x0400C365 RID: 50021
		internal static int __PropertyOffset_accel_ext;

		// Token: 0x0400C366 RID: 50022
		internal static int __PropertyOffset_actorPos;

		// Token: 0x0400C367 RID: 50023
		internal static int __PropertyOffset_bEnableCPURead;

		// Token: 0x0400C368 RID: 50024
		internal static int __PropertyOffset_startPos;

		// Token: 0x0400C369 RID: 50025
		internal static int __PropertyOffset_endPos;

		// Token: 0x0400C36A RID: 50026
		internal static int __PropertyOffset_dynamicGravity;
	}
}
