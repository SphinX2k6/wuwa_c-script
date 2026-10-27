using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001795 RID: 6037
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroComputeShader.JacobiChainVertexBinding")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 72)]
	public class FJacobiChainVertexBinding : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06015BE4 RID: 89060 RVA: 0x001FF230 File Offset: 0x001FD430
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FJacobiChainVertexBinding._ScriptStructPtr != 0) ? FJacobiChainVertexBinding._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroComputeShader.JacobiChainVertexBinding", ref FJacobiChainVertexBinding._ScriptStructPtr);
		}

		// Token: 0x1700560D RID: 22029
		// (get) Token: 0x06015BE5 RID: 89061 RVA: 0x001FF254 File Offset: 0x001FD454
		// (set) Token: 0x06015BE6 RID: 89062 RVA: 0x001FF268 File Offset: 0x001FD468
		public unsafe string MeshId
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FJacobiChainVertexBinding.__PropertyOffset_MeshId)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FJacobiChainVertexBinding.__PropertyOffset_MeshId)), value);
			}
		}

		// Token: 0x1700560E RID: 22030
		// (get) Token: 0x06015BE7 RID: 89063 RVA: 0x001FF27D File Offset: 0x001FD47D
		// (set) Token: 0x06015BE8 RID: 89064 RVA: 0x001FF28D File Offset: 0x001FD48D
		public unsafe int SourceVertexIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FJacobiChainVertexBinding.__PropertyOffset_SourceVertexIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FJacobiChainVertexBinding.__PropertyOffset_SourceVertexIndex) = value;
			}
		}

		// Token: 0x1700560F RID: 22031
		// (get) Token: 0x06015BE9 RID: 89065 RVA: 0x001FF29E File Offset: 0x001FD49E
		// (set) Token: 0x06015BEA RID: 89066 RVA: 0x001FF2B2 File Offset: 0x001FD4B2
		public unsafe FVector RestPosition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FJacobiChainVertexBinding.__PropertyOffset_RestPosition);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FJacobiChainVertexBinding.__PropertyOffset_RestPosition) = value;
			}
		}

		// Token: 0x17005610 RID: 22032
		// (get) Token: 0x06015BEB RID: 89067 RVA: 0x001FF2C7 File Offset: 0x001FD4C7
		// (set) Token: 0x06015BEC RID: 89068 RVA: 0x001FF2DB File Offset: 0x001FD4DB
		public unsafe FVector RestNormal
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FJacobiChainVertexBinding.__PropertyOffset_RestNormal);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FJacobiChainVertexBinding.__PropertyOffset_RestNormal) = value;
			}
		}

		// Token: 0x17005611 RID: 22033
		// (get) Token: 0x06015BED RID: 89069 RVA: 0x001FF2F0 File Offset: 0x001FD4F0
		// (set) Token: 0x06015BEE RID: 89070 RVA: 0x001FF304 File Offset: 0x001FD504
		public unsafe FVector2D UV
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FJacobiChainVertexBinding.__PropertyOffset_UV);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FJacobiChainVertexBinding.__PropertyOffset_UV) = value;
			}
		}

		// Token: 0x17005612 RID: 22034
		// (get) Token: 0x06015BEF RID: 89071 RVA: 0x001FF319 File Offset: 0x001FD519
		// (set) Token: 0x06015BF0 RID: 89072 RVA: 0x001FF329 File Offset: 0x001FD529
		public unsafe EJacobiChainVertexMode Mode
		{
			get
			{
				return (EJacobiChainVertexMode)(*(base.NativePtr + (IntPtr)FJacobiChainVertexBinding.__PropertyOffset_Mode));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FJacobiChainVertexBinding.__PropertyOffset_Mode) = (byte)value;
			}
		}

		// Token: 0x17005613 RID: 22035
		// (get) Token: 0x06015BF1 RID: 89073 RVA: 0x001FF33A File Offset: 0x001FD53A
		// (set) Token: 0x06015BF2 RID: 89074 RVA: 0x001FF34A File Offset: 0x001FD54A
		public unsafe int ParticleA
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FJacobiChainVertexBinding.__PropertyOffset_ParticleA);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FJacobiChainVertexBinding.__PropertyOffset_ParticleA) = value;
			}
		}

		// Token: 0x17005614 RID: 22036
		// (get) Token: 0x06015BF3 RID: 89075 RVA: 0x001FF35B File Offset: 0x001FD55B
		// (set) Token: 0x06015BF4 RID: 89076 RVA: 0x001FF36B File Offset: 0x001FD56B
		public unsafe int ParticleB
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FJacobiChainVertexBinding.__PropertyOffset_ParticleB);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FJacobiChainVertexBinding.__PropertyOffset_ParticleB) = value;
			}
		}

		// Token: 0x17005615 RID: 22037
		// (get) Token: 0x06015BF5 RID: 89077 RVA: 0x001FF37C File Offset: 0x001FD57C
		// (set) Token: 0x06015BF6 RID: 89078 RVA: 0x001FF38C File Offset: 0x001FD58C
		public unsafe float Blend
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FJacobiChainVertexBinding.__PropertyOffset_Blend);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FJacobiChainVertexBinding.__PropertyOffset_Blend) = value;
			}
		}

		// Token: 0x17005616 RID: 22038
		// (get) Token: 0x06015BF7 RID: 89079 RVA: 0x001FF39D File Offset: 0x001FD59D
		// (set) Token: 0x06015BF8 RID: 89080 RVA: 0x001FF3AD File Offset: 0x001FD5AD
		public unsafe int RigidBodyIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FJacobiChainVertexBinding.__PropertyOffset_RigidBodyIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FJacobiChainVertexBinding.__PropertyOffset_RigidBodyIndex) = value;
			}
		}

		// Token: 0x06015BF9 RID: 89081 RVA: 0x001FF3BE File Offset: 0x001FD5BE
		public FJacobiChainVertexBinding()
		{
		}

		// Token: 0x06015BFA RID: 89082 RVA: 0x001FF3C8 File Offset: 0x001FD5C8
		public FJacobiChainVertexBinding(string MeshId, int SourceVertexIndex, FVector RestPosition, FVector RestNormal, FVector2D UV, EJacobiChainVertexMode Mode, int ParticleA, int ParticleB, float Blend, int RigidBodyIndex)
		{
			this.MeshId = MeshId;
			this.SourceVertexIndex = SourceVertexIndex;
			this.RestPosition = RestPosition;
			this.RestNormal = RestNormal;
			this.UV = UV;
			this.Mode = Mode;
			this.ParticleA = ParticleA;
			this.ParticleB = ParticleB;
			this.Blend = Blend;
			this.RigidBodyIndex = RigidBodyIndex;
		}

		// Token: 0x06015BFB RID: 89083 RVA: 0x001FF428 File Offset: 0x001FD628
		protected override IntPtr GetUStructPtr()
		{
			return FJacobiChainVertexBinding.StaticStruct();
		}

		// Token: 0x06015BFC RID: 89084 RVA: 0x001FF434 File Offset: 0x001FD634
		[NullableContext(2)]
		public FJacobiChainVertexBinding(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06015BFD RID: 89085 RVA: 0x001FF43E File Offset: 0x001FD63E
		public FJacobiChainVertexBinding(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06015BFE RID: 89086 RVA: 0x001FF449 File Offset: 0x001FD649
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FJacobiChainVertexBinding(Pointer, false, true);
		}

		// Token: 0x06015BFF RID: 89087 RVA: 0x001FF453 File Offset: 0x001FD653
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FJacobiChainVertexBinding(Pointer, MemoryOwner);
		}

		// Token: 0x0400BDDF RID: 48607
		public const string __ObjectPath = "/Script/KuroComputeShader.JacobiChainVertexBinding";

		// Token: 0x0400BDE0 RID: 48608
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400BDE1 RID: 48609
		internal static int __PropertyOffset_MeshId;

		// Token: 0x0400BDE2 RID: 48610
		internal static int __PropertyOffset_SourceVertexIndex;

		// Token: 0x0400BDE3 RID: 48611
		internal static int __PropertyOffset_RestPosition;

		// Token: 0x0400BDE4 RID: 48612
		internal static int __PropertyOffset_RestNormal;

		// Token: 0x0400BDE5 RID: 48613
		internal static int __PropertyOffset_UV;

		// Token: 0x0400BDE6 RID: 48614
		internal static int __PropertyOffset_Mode;

		// Token: 0x0400BDE7 RID: 48615
		internal static int __PropertyOffset_ParticleA;

		// Token: 0x0400BDE8 RID: 48616
		internal static int __PropertyOffset_ParticleB;

		// Token: 0x0400BDE9 RID: 48617
		internal static int __PropertyOffset_Blend;

		// Token: 0x0400BDEA RID: 48618
		internal static int __PropertyOffset_RigidBodyIndex;
	}
}
