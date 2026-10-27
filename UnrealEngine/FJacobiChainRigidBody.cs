using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001791 RID: 6033
	[UnrealObjectPath("/Script/KuroComputeShader.JacobiChainRigidBody")]
	[UnrealStructLayout(40, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 40)]
	public class FJacobiChainRigidBody : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06015B8C RID: 88972 RVA: 0x001FEBAB File Offset: 0x001FCDAB
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FJacobiChainRigidBody._ScriptStructPtr != 0) ? FJacobiChainRigidBody._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroComputeShader.JacobiChainRigidBody", ref FJacobiChainRigidBody._ScriptStructPtr);
		}

		// Token: 0x170055F1 RID: 22001
		// (get) Token: 0x06015B8D RID: 88973 RVA: 0x001FEBCF File Offset: 0x001FCDCF
		// (set) Token: 0x06015B8E RID: 88974 RVA: 0x001FEBDF File Offset: 0x001FCDDF
		public unsafe int ParticleIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FJacobiChainRigidBody.__PropertyOffset_ParticleIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FJacobiChainRigidBody.__PropertyOffset_ParticleIndex) = value;
			}
		}

		// Token: 0x170055F2 RID: 22002
		// (get) Token: 0x06015B8F RID: 88975 RVA: 0x001FEBF0 File Offset: 0x001FCDF0
		// (set) Token: 0x06015B90 RID: 88976 RVA: 0x001FEC00 File Offset: 0x001FCE00
		public unsafe int PropertyIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FJacobiChainRigidBody.__PropertyOffset_PropertyIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FJacobiChainRigidBody.__PropertyOffset_PropertyIndex) = value;
			}
		}

		// Token: 0x170055F3 RID: 22003
		// (get) Token: 0x06015B91 RID: 88977 RVA: 0x001FEC11 File Offset: 0x001FCE11
		// (set) Token: 0x06015B92 RID: 88978 RVA: 0x001FEC25 File Offset: 0x001FCE25
		public unsafe FVector CollisionBoxSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FJacobiChainRigidBody.__PropertyOffset_CollisionBoxSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FJacobiChainRigidBody.__PropertyOffset_CollisionBoxSize) = value;
			}
		}

		// Token: 0x170055F4 RID: 22004
		// (get) Token: 0x06015B93 RID: 88979 RVA: 0x001FEC3A File Offset: 0x001FCE3A
		// (set) Token: 0x06015B94 RID: 88980 RVA: 0x001FEC4E File Offset: 0x001FCE4E
		public unsafe FVector RestAxis
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FJacobiChainRigidBody.__PropertyOffset_RestAxis);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FJacobiChainRigidBody.__PropertyOffset_RestAxis) = value;
			}
		}

		// Token: 0x170055F5 RID: 22005
		// (get) Token: 0x06015B95 RID: 88981 RVA: 0x001FEC63 File Offset: 0x001FCE63
		// (set) Token: 0x06015B96 RID: 88982 RVA: 0x001FEC73 File Offset: 0x001FCE73
		public unsafe int UpperAttachmentParticle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FJacobiChainRigidBody.__PropertyOffset_UpperAttachmentParticle);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FJacobiChainRigidBody.__PropertyOffset_UpperAttachmentParticle) = value;
			}
		}

		// Token: 0x170055F6 RID: 22006
		// (get) Token: 0x06015B97 RID: 88983 RVA: 0x001FEC84 File Offset: 0x001FCE84
		// (set) Token: 0x06015B98 RID: 88984 RVA: 0x001FEC94 File Offset: 0x001FCE94
		public unsafe int LowerAttachmentParticle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FJacobiChainRigidBody.__PropertyOffset_LowerAttachmentParticle);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FJacobiChainRigidBody.__PropertyOffset_LowerAttachmentParticle) = value;
			}
		}

		// Token: 0x06015B99 RID: 88985 RVA: 0x001FECA5 File Offset: 0x001FCEA5
		public FJacobiChainRigidBody()
		{
		}

		// Token: 0x06015B9A RID: 88986 RVA: 0x001FECAD File Offset: 0x001FCEAD
		public FJacobiChainRigidBody(int ParticleIndex, int PropertyIndex, FVector CollisionBoxSize, FVector RestAxis, int UpperAttachmentParticle, int LowerAttachmentParticle)
		{
			this.ParticleIndex = ParticleIndex;
			this.PropertyIndex = PropertyIndex;
			this.CollisionBoxSize = CollisionBoxSize;
			this.RestAxis = RestAxis;
			this.UpperAttachmentParticle = UpperAttachmentParticle;
			this.LowerAttachmentParticle = LowerAttachmentParticle;
		}

		// Token: 0x06015B9B RID: 88987 RVA: 0x001FECE2 File Offset: 0x001FCEE2
		protected override IntPtr GetUStructPtr()
		{
			return FJacobiChainRigidBody.StaticStruct();
		}

		// Token: 0x06015B9C RID: 88988 RVA: 0x001FECEE File Offset: 0x001FCEEE
		[NullableContext(2)]
		public FJacobiChainRigidBody(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06015B9D RID: 88989 RVA: 0x001FECF8 File Offset: 0x001FCEF8
		public FJacobiChainRigidBody(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06015B9E RID: 88990 RVA: 0x001FED03 File Offset: 0x001FCF03
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FJacobiChainRigidBody(Pointer, false, true);
		}

		// Token: 0x06015B9F RID: 88991 RVA: 0x001FED0D File Offset: 0x001FCF0D
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FJacobiChainRigidBody(Pointer, MemoryOwner);
		}

		// Token: 0x0400BDBB RID: 48571
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroComputeShader.JacobiChainRigidBody";

		// Token: 0x0400BDBC RID: 48572
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400BDBD RID: 48573
		internal static int __PropertyOffset_ParticleIndex;

		// Token: 0x0400BDBE RID: 48574
		internal static int __PropertyOffset_PropertyIndex;

		// Token: 0x0400BDBF RID: 48575
		internal static int __PropertyOffset_CollisionBoxSize;

		// Token: 0x0400BDC0 RID: 48576
		internal static int __PropertyOffset_RestAxis;

		// Token: 0x0400BDC1 RID: 48577
		internal static int __PropertyOffset_UpperAttachmentParticle;

		// Token: 0x0400BDC2 RID: 48578
		internal static int __PropertyOffset_LowerAttachmentParticle;
	}
}
