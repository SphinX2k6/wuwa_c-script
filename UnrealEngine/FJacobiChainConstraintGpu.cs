using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001788 RID: 6024
	[UnrealObjectPath("/Script/KuroComputeShader.JacobiChainConstraintGpu")]
	[UnrealStructLayout(16, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FJacobiChainConstraintGpu : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06015AC7 RID: 88775 RVA: 0x001FDB7A File Offset: 0x001FBD7A
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FJacobiChainConstraintGpu._ScriptStructPtr != 0) ? FJacobiChainConstraintGpu._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroComputeShader.JacobiChainConstraintGpu", ref FJacobiChainConstraintGpu._ScriptStructPtr);
		}

		// Token: 0x170055B1 RID: 21937
		// (get) Token: 0x06015AC8 RID: 88776 RVA: 0x001FDB9E File Offset: 0x001FBD9E
		// (set) Token: 0x06015AC9 RID: 88777 RVA: 0x001FDBAE File Offset: 0x001FBDAE
		public unsafe uint ParticleA
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FJacobiChainConstraintGpu.__PropertyOffset_ParticleA);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FJacobiChainConstraintGpu.__PropertyOffset_ParticleA) = (int)value;
			}
		}

		// Token: 0x170055B2 RID: 21938
		// (get) Token: 0x06015ACA RID: 88778 RVA: 0x001FDBBF File Offset: 0x001FBDBF
		// (set) Token: 0x06015ACB RID: 88779 RVA: 0x001FDBCF File Offset: 0x001FBDCF
		public unsafe uint ParticleB
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FJacobiChainConstraintGpu.__PropertyOffset_ParticleB);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FJacobiChainConstraintGpu.__PropertyOffset_ParticleB) = (int)value;
			}
		}

		// Token: 0x170055B3 RID: 21939
		// (get) Token: 0x06015ACC RID: 88780 RVA: 0x001FDBE0 File Offset: 0x001FBDE0
		// (set) Token: 0x06015ACD RID: 88781 RVA: 0x001FDBF0 File Offset: 0x001FBDF0
		public unsafe float RestLength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FJacobiChainConstraintGpu.__PropertyOffset_RestLength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FJacobiChainConstraintGpu.__PropertyOffset_RestLength) = value;
			}
		}

		// Token: 0x170055B4 RID: 21940
		// (get) Token: 0x06015ACE RID: 88782 RVA: 0x001FDC01 File Offset: 0x001FBE01
		// (set) Token: 0x06015ACF RID: 88783 RVA: 0x001FDC11 File Offset: 0x001FBE11
		public unsafe float Padding
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FJacobiChainConstraintGpu.__PropertyOffset_Padding);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FJacobiChainConstraintGpu.__PropertyOffset_Padding) = value;
			}
		}

		// Token: 0x06015AD0 RID: 88784 RVA: 0x001FDC22 File Offset: 0x001FBE22
		public FJacobiChainConstraintGpu()
		{
		}

		// Token: 0x06015AD1 RID: 88785 RVA: 0x001FDC2A File Offset: 0x001FBE2A
		public FJacobiChainConstraintGpu(uint ParticleA, uint ParticleB, float RestLength, float Padding)
		{
			this.ParticleA = ParticleA;
			this.ParticleB = ParticleB;
			this.RestLength = RestLength;
			this.Padding = Padding;
		}

		// Token: 0x06015AD2 RID: 88786 RVA: 0x001FDC4F File Offset: 0x001FBE4F
		protected override IntPtr GetUStructPtr()
		{
			return FJacobiChainConstraintGpu.StaticStruct();
		}

		// Token: 0x06015AD3 RID: 88787 RVA: 0x001FDC5B File Offset: 0x001FBE5B
		[NullableContext(2)]
		public FJacobiChainConstraintGpu(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06015AD4 RID: 88788 RVA: 0x001FDC65 File Offset: 0x001FBE65
		public FJacobiChainConstraintGpu(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06015AD5 RID: 88789 RVA: 0x001FDC70 File Offset: 0x001FBE70
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FJacobiChainConstraintGpu(Pointer, false, true);
		}

		// Token: 0x06015AD6 RID: 88790 RVA: 0x001FDC7A File Offset: 0x001FBE7A
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FJacobiChainConstraintGpu(Pointer, MemoryOwner);
		}

		// Token: 0x0400BD57 RID: 48471
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroComputeShader.JacobiChainConstraintGpu";

		// Token: 0x0400BD58 RID: 48472
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400BD59 RID: 48473
		internal static int __PropertyOffset_ParticleA;

		// Token: 0x0400BD5A RID: 48474
		internal static int __PropertyOffset_ParticleB;

		// Token: 0x0400BD5B RID: 48475
		internal static int __PropertyOffset_RestLength;

		// Token: 0x0400BD5C RID: 48476
		internal static int __PropertyOffset_Padding;
	}
}
