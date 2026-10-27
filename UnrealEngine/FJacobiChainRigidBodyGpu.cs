using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001792 RID: 6034
	[UnrealObjectPath("/Script/KuroComputeShader.JacobiChainRigidBodyGpu")]
	[UnrealStructLayout(48, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FJacobiChainRigidBodyGpu : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06015BA0 RID: 88992 RVA: 0x001FED16 File Offset: 0x001FCF16
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FJacobiChainRigidBodyGpu._ScriptStructPtr != 0) ? FJacobiChainRigidBodyGpu._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroComputeShader.JacobiChainRigidBodyGpu", ref FJacobiChainRigidBodyGpu._ScriptStructPtr);
		}

		// Token: 0x170055F7 RID: 22007
		// (get) Token: 0x06015BA1 RID: 88993 RVA: 0x001FED3A File Offset: 0x001FCF3A
		// (set) Token: 0x06015BA2 RID: 88994 RVA: 0x001FED4A File Offset: 0x001FCF4A
		public unsafe uint ParticleIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FJacobiChainRigidBodyGpu.__PropertyOffset_ParticleIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FJacobiChainRigidBodyGpu.__PropertyOffset_ParticleIndex) = (int)value;
			}
		}

		// Token: 0x170055F8 RID: 22008
		// (get) Token: 0x06015BA3 RID: 88995 RVA: 0x001FED5B File Offset: 0x001FCF5B
		// (set) Token: 0x06015BA4 RID: 88996 RVA: 0x001FED6B File Offset: 0x001FCF6B
		public unsafe uint UpperAttachmentParticle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FJacobiChainRigidBodyGpu.__PropertyOffset_UpperAttachmentParticle);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FJacobiChainRigidBodyGpu.__PropertyOffset_UpperAttachmentParticle) = (int)value;
			}
		}

		// Token: 0x170055F9 RID: 22009
		// (get) Token: 0x06015BA5 RID: 88997 RVA: 0x001FED7C File Offset: 0x001FCF7C
		// (set) Token: 0x06015BA6 RID: 88998 RVA: 0x001FED8C File Offset: 0x001FCF8C
		public unsafe uint LowerAttachmentParticle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FJacobiChainRigidBodyGpu.__PropertyOffset_LowerAttachmentParticle);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FJacobiChainRigidBodyGpu.__PropertyOffset_LowerAttachmentParticle) = (int)value;
			}
		}

		// Token: 0x170055FA RID: 22010
		// (get) Token: 0x06015BA7 RID: 88999 RVA: 0x001FED9D File Offset: 0x001FCF9D
		// (set) Token: 0x06015BA8 RID: 89000 RVA: 0x001FEDAD File Offset: 0x001FCFAD
		public unsafe uint PropertyIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FJacobiChainRigidBodyGpu.__PropertyOffset_PropertyIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FJacobiChainRigidBodyGpu.__PropertyOffset_PropertyIndex) = (int)value;
			}
		}

		// Token: 0x170055FB RID: 22011
		// (get) Token: 0x06015BA9 RID: 89001 RVA: 0x001FEDBE File Offset: 0x001FCFBE
		// (set) Token: 0x06015BAA RID: 89002 RVA: 0x001FEDD2 File Offset: 0x001FCFD2
		public unsafe FVector RestAxis
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FJacobiChainRigidBodyGpu.__PropertyOffset_RestAxis);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FJacobiChainRigidBodyGpu.__PropertyOffset_RestAxis) = value;
			}
		}

		// Token: 0x170055FC RID: 22012
		// (get) Token: 0x06015BAB RID: 89003 RVA: 0x001FEDE7 File Offset: 0x001FCFE7
		// (set) Token: 0x06015BAC RID: 89004 RVA: 0x001FEDF7 File Offset: 0x001FCFF7
		public unsafe float Padding0
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FJacobiChainRigidBodyGpu.__PropertyOffset_Padding0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FJacobiChainRigidBodyGpu.__PropertyOffset_Padding0) = value;
			}
		}

		// Token: 0x170055FD RID: 22013
		// (get) Token: 0x06015BAD RID: 89005 RVA: 0x001FEE08 File Offset: 0x001FD008
		// (set) Token: 0x06015BAE RID: 89006 RVA: 0x001FEE1C File Offset: 0x001FD01C
		public unsafe FVector CollisionHalfSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FJacobiChainRigidBodyGpu.__PropertyOffset_CollisionHalfSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FJacobiChainRigidBodyGpu.__PropertyOffset_CollisionHalfSize) = value;
			}
		}

		// Token: 0x170055FE RID: 22014
		// (get) Token: 0x06015BAF RID: 89007 RVA: 0x001FEE31 File Offset: 0x001FD031
		// (set) Token: 0x06015BB0 RID: 89008 RVA: 0x001FEE41 File Offset: 0x001FD041
		public unsafe float Padding1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FJacobiChainRigidBodyGpu.__PropertyOffset_Padding1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FJacobiChainRigidBodyGpu.__PropertyOffset_Padding1) = value;
			}
		}

		// Token: 0x06015BB1 RID: 89009 RVA: 0x001FEE52 File Offset: 0x001FD052
		public FJacobiChainRigidBodyGpu()
		{
		}

		// Token: 0x06015BB2 RID: 89010 RVA: 0x001FEE5C File Offset: 0x001FD05C
		public FJacobiChainRigidBodyGpu(uint ParticleIndex, uint UpperAttachmentParticle, uint LowerAttachmentParticle, uint PropertyIndex, FVector RestAxis, float Padding0, FVector CollisionHalfSize, float Padding1)
		{
			this.ParticleIndex = ParticleIndex;
			this.UpperAttachmentParticle = UpperAttachmentParticle;
			this.LowerAttachmentParticle = LowerAttachmentParticle;
			this.PropertyIndex = PropertyIndex;
			this.RestAxis = RestAxis;
			this.Padding0 = Padding0;
			this.CollisionHalfSize = CollisionHalfSize;
			this.Padding1 = Padding1;
		}

		// Token: 0x06015BB3 RID: 89011 RVA: 0x001FEEAC File Offset: 0x001FD0AC
		protected override IntPtr GetUStructPtr()
		{
			return FJacobiChainRigidBodyGpu.StaticStruct();
		}

		// Token: 0x06015BB4 RID: 89012 RVA: 0x001FEEB8 File Offset: 0x001FD0B8
		[NullableContext(2)]
		public FJacobiChainRigidBodyGpu(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06015BB5 RID: 89013 RVA: 0x001FEEC2 File Offset: 0x001FD0C2
		public FJacobiChainRigidBodyGpu(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06015BB6 RID: 89014 RVA: 0x001FEECD File Offset: 0x001FD0CD
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FJacobiChainRigidBodyGpu(Pointer, false, true);
		}

		// Token: 0x06015BB7 RID: 89015 RVA: 0x001FEED7 File Offset: 0x001FD0D7
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FJacobiChainRigidBodyGpu(Pointer, MemoryOwner);
		}

		// Token: 0x0400BDC3 RID: 48579
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroComputeShader.JacobiChainRigidBodyGpu";

		// Token: 0x0400BDC4 RID: 48580
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400BDC5 RID: 48581
		internal static int __PropertyOffset_ParticleIndex;

		// Token: 0x0400BDC6 RID: 48582
		internal static int __PropertyOffset_UpperAttachmentParticle;

		// Token: 0x0400BDC7 RID: 48583
		internal static int __PropertyOffset_LowerAttachmentParticle;

		// Token: 0x0400BDC8 RID: 48584
		internal static int __PropertyOffset_PropertyIndex;

		// Token: 0x0400BDC9 RID: 48585
		internal static int __PropertyOffset_RestAxis;

		// Token: 0x0400BDCA RID: 48586
		internal static int __PropertyOffset_Padding0;

		// Token: 0x0400BDCB RID: 48587
		internal static int __PropertyOffset_CollisionHalfSize;

		// Token: 0x0400BDCC RID: 48588
		internal static int __PropertyOffset_Padding1;
	}
}
