using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001799 RID: 6041
	[UnrealObjectPath("/Script/KuroComputeShader.KuroClothDistanceConstraintData")]
	[UnrealStructLayout(12, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 12)]
	public class FKuroClothDistanceConstraintData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06015C59 RID: 89177 RVA: 0x001FFC50 File Offset: 0x001FDE50
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroClothDistanceConstraintData._ScriptStructPtr != 0) ? FKuroClothDistanceConstraintData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroComputeShader.KuroClothDistanceConstraintData", ref FKuroClothDistanceConstraintData._ScriptStructPtr);
		}

		// Token: 0x17005639 RID: 22073
		// (get) Token: 0x06015C5A RID: 89178 RVA: 0x001FFC74 File Offset: 0x001FDE74
		// (set) Token: 0x06015C5B RID: 89179 RVA: 0x001FFC84 File Offset: 0x001FDE84
		public unsafe int ParticleA
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroClothDistanceConstraintData.__PropertyOffset_ParticleA);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroClothDistanceConstraintData.__PropertyOffset_ParticleA) = value;
			}
		}

		// Token: 0x1700563A RID: 22074
		// (get) Token: 0x06015C5C RID: 89180 RVA: 0x001FFC95 File Offset: 0x001FDE95
		// (set) Token: 0x06015C5D RID: 89181 RVA: 0x001FFCA5 File Offset: 0x001FDEA5
		public unsafe int ParticleB
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroClothDistanceConstraintData.__PropertyOffset_ParticleB);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroClothDistanceConstraintData.__PropertyOffset_ParticleB) = value;
			}
		}

		// Token: 0x1700563B RID: 22075
		// (get) Token: 0x06015C5E RID: 89182 RVA: 0x001FFCB6 File Offset: 0x001FDEB6
		// (set) Token: 0x06015C5F RID: 89183 RVA: 0x001FFCC6 File Offset: 0x001FDEC6
		public unsafe float RestLength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroClothDistanceConstraintData.__PropertyOffset_RestLength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroClothDistanceConstraintData.__PropertyOffset_RestLength) = value;
			}
		}

		// Token: 0x06015C60 RID: 89184 RVA: 0x001FFCD7 File Offset: 0x001FDED7
		public FKuroClothDistanceConstraintData()
		{
		}

		// Token: 0x06015C61 RID: 89185 RVA: 0x001FFCDF File Offset: 0x001FDEDF
		public FKuroClothDistanceConstraintData(int ParticleA, int ParticleB, float RestLength)
		{
			this.ParticleA = ParticleA;
			this.ParticleB = ParticleB;
			this.RestLength = RestLength;
		}

		// Token: 0x06015C62 RID: 89186 RVA: 0x001FFCFC File Offset: 0x001FDEFC
		protected override IntPtr GetUStructPtr()
		{
			return FKuroClothDistanceConstraintData.StaticStruct();
		}

		// Token: 0x06015C63 RID: 89187 RVA: 0x001FFD08 File Offset: 0x001FDF08
		[NullableContext(2)]
		public FKuroClothDistanceConstraintData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06015C64 RID: 89188 RVA: 0x001FFD12 File Offset: 0x001FDF12
		public FKuroClothDistanceConstraintData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06015C65 RID: 89189 RVA: 0x001FFD1D File Offset: 0x001FDF1D
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroClothDistanceConstraintData(Pointer, false, true);
		}

		// Token: 0x06015C66 RID: 89190 RVA: 0x001FFD27 File Offset: 0x001FDF27
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroClothDistanceConstraintData(Pointer, MemoryOwner);
		}

		// Token: 0x0400BE1C RID: 48668
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroComputeShader.KuroClothDistanceConstraintData";

		// Token: 0x0400BE1D RID: 48669
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400BE1E RID: 48670
		internal static int __PropertyOffset_ParticleA;

		// Token: 0x0400BE1F RID: 48671
		internal static int __PropertyOffset_ParticleB;

		// Token: 0x0400BE20 RID: 48672
		internal static int __PropertyOffset_RestLength;
	}
}
