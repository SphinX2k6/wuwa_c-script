using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200178B RID: 6027
	[UnrealObjectPath("/Script/KuroComputeShader.JacobiChainParticle")]
	[UnrealStructLayout(24, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FJacobiChainParticle : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06015AF1 RID: 88817 RVA: 0x001FDE7F File Offset: 0x001FC07F
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FJacobiChainParticle._ScriptStructPtr != 0) ? FJacobiChainParticle._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroComputeShader.JacobiChainParticle", ref FJacobiChainParticle._ScriptStructPtr);
		}

		// Token: 0x170055BA RID: 21946
		// (get) Token: 0x06015AF2 RID: 88818 RVA: 0x001FDEA3 File Offset: 0x001FC0A3
		// (set) Token: 0x06015AF3 RID: 88819 RVA: 0x001FDEB7 File Offset: 0x001FC0B7
		public unsafe FVector RestPosition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FJacobiChainParticle.__PropertyOffset_RestPosition);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FJacobiChainParticle.__PropertyOffset_RestPosition) = value;
			}
		}

		// Token: 0x170055BB RID: 21947
		// (get) Token: 0x06015AF4 RID: 88820 RVA: 0x001FDECC File Offset: 0x001FC0CC
		// (set) Token: 0x06015AF5 RID: 88821 RVA: 0x001FDEDC File Offset: 0x001FC0DC
		public unsafe float InverseMass
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FJacobiChainParticle.__PropertyOffset_InverseMass);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FJacobiChainParticle.__PropertyOffset_InverseMass) = value;
			}
		}

		// Token: 0x170055BC RID: 21948
		// (get) Token: 0x06015AF6 RID: 88822 RVA: 0x001FDEED File Offset: 0x001FC0ED
		// (set) Token: 0x06015AF7 RID: 88823 RVA: 0x001FDEFD File Offset: 0x001FC0FD
		public unsafe int PropertyIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FJacobiChainParticle.__PropertyOffset_PropertyIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FJacobiChainParticle.__PropertyOffset_PropertyIndex) = value;
			}
		}

		// Token: 0x170055BD RID: 21949
		// (get) Token: 0x06015AF8 RID: 88824 RVA: 0x001FDF0E File Offset: 0x001FC10E
		// (set) Token: 0x06015AF9 RID: 88825 RVA: 0x001FDF1E File Offset: 0x001FC11E
		public unsafe bool bRigid
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FJacobiChainParticle.__PropertyOffset_bRigid) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FJacobiChainParticle.__PropertyOffset_bRigid) = (value ? 1 : 0);
			}
		}

		// Token: 0x06015AFA RID: 88826 RVA: 0x001FDF2F File Offset: 0x001FC12F
		public FJacobiChainParticle()
		{
		}

		// Token: 0x06015AFB RID: 88827 RVA: 0x001FDF37 File Offset: 0x001FC137
		public FJacobiChainParticle(FVector RestPosition, float InverseMass, int PropertyIndex, bool bRigid)
		{
			this.RestPosition = RestPosition;
			this.InverseMass = InverseMass;
			this.PropertyIndex = PropertyIndex;
			this.bRigid = bRigid;
		}

		// Token: 0x06015AFC RID: 88828 RVA: 0x001FDF5C File Offset: 0x001FC15C
		protected override IntPtr GetUStructPtr()
		{
			return FJacobiChainParticle.StaticStruct();
		}

		// Token: 0x06015AFD RID: 88829 RVA: 0x001FDF68 File Offset: 0x001FC168
		[NullableContext(2)]
		public FJacobiChainParticle(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06015AFE RID: 88830 RVA: 0x001FDF72 File Offset: 0x001FC172
		public FJacobiChainParticle(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06015AFF RID: 88831 RVA: 0x001FDF7D File Offset: 0x001FC17D
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FJacobiChainParticle(Pointer, false, true);
		}

		// Token: 0x06015B00 RID: 88832 RVA: 0x001FDF87 File Offset: 0x001FC187
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FJacobiChainParticle(Pointer, MemoryOwner);
		}

		// Token: 0x0400BD68 RID: 48488
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroComputeShader.JacobiChainParticle";

		// Token: 0x0400BD69 RID: 48489
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400BD6A RID: 48490
		internal static int __PropertyOffset_RestPosition;

		// Token: 0x0400BD6B RID: 48491
		internal static int __PropertyOffset_InverseMass;

		// Token: 0x0400BD6C RID: 48492
		internal static int __PropertyOffset_PropertyIndex;

		// Token: 0x0400BD6D RID: 48493
		internal static int __PropertyOffset_bRigid;
	}
}
