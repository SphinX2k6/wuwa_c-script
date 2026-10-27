using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001789 RID: 6025
	[UnrealObjectPath("/Script/KuroComputeShader.JacobiChainDistanceConstraint")]
	[UnrealStructLayout(12, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 12)]
	public class FJacobiChainDistanceConstraint : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06015AD7 RID: 88791 RVA: 0x001FDC83 File Offset: 0x001FBE83
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FJacobiChainDistanceConstraint._ScriptStructPtr != 0) ? FJacobiChainDistanceConstraint._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroComputeShader.JacobiChainDistanceConstraint", ref FJacobiChainDistanceConstraint._ScriptStructPtr);
		}

		// Token: 0x170055B5 RID: 21941
		// (get) Token: 0x06015AD8 RID: 88792 RVA: 0x001FDCA7 File Offset: 0x001FBEA7
		// (set) Token: 0x06015AD9 RID: 88793 RVA: 0x001FDCB7 File Offset: 0x001FBEB7
		public unsafe int ParticleA
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FJacobiChainDistanceConstraint.__PropertyOffset_ParticleA);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FJacobiChainDistanceConstraint.__PropertyOffset_ParticleA) = value;
			}
		}

		// Token: 0x170055B6 RID: 21942
		// (get) Token: 0x06015ADA RID: 88794 RVA: 0x001FDCC8 File Offset: 0x001FBEC8
		// (set) Token: 0x06015ADB RID: 88795 RVA: 0x001FDCD8 File Offset: 0x001FBED8
		public unsafe int ParticleB
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FJacobiChainDistanceConstraint.__PropertyOffset_ParticleB);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FJacobiChainDistanceConstraint.__PropertyOffset_ParticleB) = value;
			}
		}

		// Token: 0x170055B7 RID: 21943
		// (get) Token: 0x06015ADC RID: 88796 RVA: 0x001FDCE9 File Offset: 0x001FBEE9
		// (set) Token: 0x06015ADD RID: 88797 RVA: 0x001FDCF9 File Offset: 0x001FBEF9
		public unsafe float RestLength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FJacobiChainDistanceConstraint.__PropertyOffset_RestLength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FJacobiChainDistanceConstraint.__PropertyOffset_RestLength) = value;
			}
		}

		// Token: 0x06015ADE RID: 88798 RVA: 0x001FDD0A File Offset: 0x001FBF0A
		public FJacobiChainDistanceConstraint()
		{
		}

		// Token: 0x06015ADF RID: 88799 RVA: 0x001FDD12 File Offset: 0x001FBF12
		public FJacobiChainDistanceConstraint(int ParticleA, int ParticleB, float RestLength)
		{
			this.ParticleA = ParticleA;
			this.ParticleB = ParticleB;
			this.RestLength = RestLength;
		}

		// Token: 0x06015AE0 RID: 88800 RVA: 0x001FDD2F File Offset: 0x001FBF2F
		protected override IntPtr GetUStructPtr()
		{
			return FJacobiChainDistanceConstraint.StaticStruct();
		}

		// Token: 0x06015AE1 RID: 88801 RVA: 0x001FDD3B File Offset: 0x001FBF3B
		[NullableContext(2)]
		public FJacobiChainDistanceConstraint(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06015AE2 RID: 88802 RVA: 0x001FDD45 File Offset: 0x001FBF45
		public FJacobiChainDistanceConstraint(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06015AE3 RID: 88803 RVA: 0x001FDD50 File Offset: 0x001FBF50
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FJacobiChainDistanceConstraint(Pointer, false, true);
		}

		// Token: 0x06015AE4 RID: 88804 RVA: 0x001FDD5A File Offset: 0x001FBF5A
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FJacobiChainDistanceConstraint(Pointer, MemoryOwner);
		}

		// Token: 0x0400BD5D RID: 48477
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroComputeShader.JacobiChainDistanceConstraint";

		// Token: 0x0400BD5E RID: 48478
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400BD5F RID: 48479
		internal static int __PropertyOffset_ParticleA;

		// Token: 0x0400BD60 RID: 48480
		internal static int __PropertyOffset_ParticleB;

		// Token: 0x0400BD61 RID: 48481
		internal static int __PropertyOffset_RestLength;
	}
}
