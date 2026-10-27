using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001796 RID: 6038
	[UnrealObjectPath("/Script/KuroComputeShader.JacobiChainVertexBindingGpu")]
	[UnrealStructLayout(80, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 80)]
	public class FJacobiChainVertexBindingGpu : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06015C00 RID: 89088 RVA: 0x001FF45C File Offset: 0x001FD65C
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FJacobiChainVertexBindingGpu._ScriptStructPtr != 0) ? FJacobiChainVertexBindingGpu._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroComputeShader.JacobiChainVertexBindingGpu", ref FJacobiChainVertexBindingGpu._ScriptStructPtr);
		}

		// Token: 0x17005617 RID: 22039
		// (get) Token: 0x06015C01 RID: 89089 RVA: 0x001FF480 File Offset: 0x001FD680
		// (set) Token: 0x06015C02 RID: 89090 RVA: 0x001FF494 File Offset: 0x001FD694
		public unsafe FVector RestPosition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FJacobiChainVertexBindingGpu.__PropertyOffset_RestPosition);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FJacobiChainVertexBindingGpu.__PropertyOffset_RestPosition) = value;
			}
		}

		// Token: 0x17005618 RID: 22040
		// (get) Token: 0x06015C03 RID: 89091 RVA: 0x001FF4A9 File Offset: 0x001FD6A9
		// (set) Token: 0x06015C04 RID: 89092 RVA: 0x001FF4B9 File Offset: 0x001FD6B9
		public unsafe uint Mode
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FJacobiChainVertexBindingGpu.__PropertyOffset_Mode);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FJacobiChainVertexBindingGpu.__PropertyOffset_Mode) = (int)value;
			}
		}

		// Token: 0x17005619 RID: 22041
		// (get) Token: 0x06015C05 RID: 89093 RVA: 0x001FF4CA File Offset: 0x001FD6CA
		// (set) Token: 0x06015C06 RID: 89094 RVA: 0x001FF4DA File Offset: 0x001FD6DA
		public unsafe uint ParticleA
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FJacobiChainVertexBindingGpu.__PropertyOffset_ParticleA);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FJacobiChainVertexBindingGpu.__PropertyOffset_ParticleA) = (int)value;
			}
		}

		// Token: 0x1700561A RID: 22042
		// (get) Token: 0x06015C07 RID: 89095 RVA: 0x001FF4EB File Offset: 0x001FD6EB
		// (set) Token: 0x06015C08 RID: 89096 RVA: 0x001FF4FB File Offset: 0x001FD6FB
		public unsafe uint ParticleB
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FJacobiChainVertexBindingGpu.__PropertyOffset_ParticleB);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FJacobiChainVertexBindingGpu.__PropertyOffset_ParticleB) = (int)value;
			}
		}

		// Token: 0x1700561B RID: 22043
		// (get) Token: 0x06015C09 RID: 89097 RVA: 0x001FF50C File Offset: 0x001FD70C
		// (set) Token: 0x06015C0A RID: 89098 RVA: 0x001FF51C File Offset: 0x001FD71C
		public unsafe float Blend
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FJacobiChainVertexBindingGpu.__PropertyOffset_Blend);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FJacobiChainVertexBindingGpu.__PropertyOffset_Blend) = value;
			}
		}

		// Token: 0x1700561C RID: 22044
		// (get) Token: 0x06015C0B RID: 89099 RVA: 0x001FF52D File Offset: 0x001FD72D
		// (set) Token: 0x06015C0C RID: 89100 RVA: 0x001FF53D File Offset: 0x001FD73D
		public unsafe uint RigidBodyIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FJacobiChainVertexBindingGpu.__PropertyOffset_RigidBodyIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FJacobiChainVertexBindingGpu.__PropertyOffset_RigidBodyIndex) = (int)value;
			}
		}

		// Token: 0x1700561D RID: 22045
		// (get) Token: 0x06015C0D RID: 89101 RVA: 0x001FF54E File Offset: 0x001FD74E
		// (set) Token: 0x06015C0E RID: 89102 RVA: 0x001FF562 File Offset: 0x001FD762
		public unsafe FVector RestOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FJacobiChainVertexBindingGpu.__PropertyOffset_RestOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FJacobiChainVertexBindingGpu.__PropertyOffset_RestOffset) = value;
			}
		}

		// Token: 0x1700561E RID: 22046
		// (get) Token: 0x06015C0F RID: 89103 RVA: 0x001FF577 File Offset: 0x001FD777
		// (set) Token: 0x06015C10 RID: 89104 RVA: 0x001FF587 File Offset: 0x001FD787
		public unsafe float Padding0
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FJacobiChainVertexBindingGpu.__PropertyOffset_Padding0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FJacobiChainVertexBindingGpu.__PropertyOffset_Padding0) = value;
			}
		}

		// Token: 0x1700561F RID: 22047
		// (get) Token: 0x06015C11 RID: 89105 RVA: 0x001FF598 File Offset: 0x001FD798
		// (set) Token: 0x06015C12 RID: 89106 RVA: 0x001FF5AC File Offset: 0x001FD7AC
		public unsafe FVector RestTangentX
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FJacobiChainVertexBindingGpu.__PropertyOffset_RestTangentX);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FJacobiChainVertexBindingGpu.__PropertyOffset_RestTangentX) = value;
			}
		}

		// Token: 0x17005620 RID: 22048
		// (get) Token: 0x06015C13 RID: 89107 RVA: 0x001FF5C1 File Offset: 0x001FD7C1
		// (set) Token: 0x06015C14 RID: 89108 RVA: 0x001FF5D1 File Offset: 0x001FD7D1
		public unsafe float Padding1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FJacobiChainVertexBindingGpu.__PropertyOffset_Padding1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FJacobiChainVertexBindingGpu.__PropertyOffset_Padding1) = value;
			}
		}

		// Token: 0x17005621 RID: 22049
		// (get) Token: 0x06015C15 RID: 89109 RVA: 0x001FF5E2 File Offset: 0x001FD7E2
		// (set) Token: 0x06015C16 RID: 89110 RVA: 0x001FF5F6 File Offset: 0x001FD7F6
		public unsafe FVector RestNormal
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FJacobiChainVertexBindingGpu.__PropertyOffset_RestNormal);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FJacobiChainVertexBindingGpu.__PropertyOffset_RestNormal) = value;
			}
		}

		// Token: 0x17005622 RID: 22050
		// (get) Token: 0x06015C17 RID: 89111 RVA: 0x001FF60B File Offset: 0x001FD80B
		// (set) Token: 0x06015C18 RID: 89112 RVA: 0x001FF61B File Offset: 0x001FD81B
		public unsafe float TangentSign
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FJacobiChainVertexBindingGpu.__PropertyOffset_TangentSign);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FJacobiChainVertexBindingGpu.__PropertyOffset_TangentSign) = value;
			}
		}

		// Token: 0x06015C19 RID: 89113 RVA: 0x001FF62C File Offset: 0x001FD82C
		public FJacobiChainVertexBindingGpu()
		{
		}

		// Token: 0x06015C1A RID: 89114 RVA: 0x001FF634 File Offset: 0x001FD834
		public FJacobiChainVertexBindingGpu(FVector RestPosition, uint Mode, uint ParticleA, uint ParticleB, float Blend, uint RigidBodyIndex, FVector RestOffset, float Padding0, FVector RestTangentX, float Padding1, FVector RestNormal, float TangentSign)
		{
			this.RestPosition = RestPosition;
			this.Mode = Mode;
			this.ParticleA = ParticleA;
			this.ParticleB = ParticleB;
			this.Blend = Blend;
			this.RigidBodyIndex = RigidBodyIndex;
			this.RestOffset = RestOffset;
			this.Padding0 = Padding0;
			this.RestTangentX = RestTangentX;
			this.Padding1 = Padding1;
			this.RestNormal = RestNormal;
			this.TangentSign = TangentSign;
		}

		// Token: 0x06015C1B RID: 89115 RVA: 0x001FF6A4 File Offset: 0x001FD8A4
		protected override IntPtr GetUStructPtr()
		{
			return FJacobiChainVertexBindingGpu.StaticStruct();
		}

		// Token: 0x06015C1C RID: 89116 RVA: 0x001FF6B0 File Offset: 0x001FD8B0
		[NullableContext(2)]
		public FJacobiChainVertexBindingGpu(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06015C1D RID: 89117 RVA: 0x001FF6BA File Offset: 0x001FD8BA
		public FJacobiChainVertexBindingGpu(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06015C1E RID: 89118 RVA: 0x001FF6C5 File Offset: 0x001FD8C5
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FJacobiChainVertexBindingGpu(Pointer, false, true);
		}

		// Token: 0x06015C1F RID: 89119 RVA: 0x001FF6CF File Offset: 0x001FD8CF
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FJacobiChainVertexBindingGpu(Pointer, MemoryOwner);
		}

		// Token: 0x0400BDEB RID: 48619
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroComputeShader.JacobiChainVertexBindingGpu";

		// Token: 0x0400BDEC RID: 48620
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400BDED RID: 48621
		internal static int __PropertyOffset_RestPosition;

		// Token: 0x0400BDEE RID: 48622
		internal static int __PropertyOffset_Mode;

		// Token: 0x0400BDEF RID: 48623
		internal static int __PropertyOffset_ParticleA;

		// Token: 0x0400BDF0 RID: 48624
		internal static int __PropertyOffset_ParticleB;

		// Token: 0x0400BDF1 RID: 48625
		internal static int __PropertyOffset_Blend;

		// Token: 0x0400BDF2 RID: 48626
		internal static int __PropertyOffset_RigidBodyIndex;

		// Token: 0x0400BDF3 RID: 48627
		internal static int __PropertyOffset_RestOffset;

		// Token: 0x0400BDF4 RID: 48628
		internal static int __PropertyOffset_Padding0;

		// Token: 0x0400BDF5 RID: 48629
		internal static int __PropertyOffset_RestTangentX;

		// Token: 0x0400BDF6 RID: 48630
		internal static int __PropertyOffset_Padding1;

		// Token: 0x0400BDF7 RID: 48631
		internal static int __PropertyOffset_RestNormal;

		// Token: 0x0400BDF8 RID: 48632
		internal static int __PropertyOffset_TangentSign;
	}
}
