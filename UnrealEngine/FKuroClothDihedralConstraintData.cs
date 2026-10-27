using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001798 RID: 6040
	[UnrealObjectPath("/Script/KuroComputeShader.KuroClothDihedralConstraintData")]
	[UnrealStructLayout(20, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 20)]
	public class FKuroClothDihedralConstraintData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06015C47 RID: 89159 RVA: 0x001FFB1E File Offset: 0x001FDD1E
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroClothDihedralConstraintData._ScriptStructPtr != 0) ? FKuroClothDihedralConstraintData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroComputeShader.KuroClothDihedralConstraintData", ref FKuroClothDihedralConstraintData._ScriptStructPtr);
		}

		// Token: 0x17005634 RID: 22068
		// (get) Token: 0x06015C48 RID: 89160 RVA: 0x001FFB42 File Offset: 0x001FDD42
		// (set) Token: 0x06015C49 RID: 89161 RVA: 0x001FFB52 File Offset: 0x001FDD52
		public unsafe int Particle0
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroClothDihedralConstraintData.__PropertyOffset_Particle0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroClothDihedralConstraintData.__PropertyOffset_Particle0) = value;
			}
		}

		// Token: 0x17005635 RID: 22069
		// (get) Token: 0x06015C4A RID: 89162 RVA: 0x001FFB63 File Offset: 0x001FDD63
		// (set) Token: 0x06015C4B RID: 89163 RVA: 0x001FFB73 File Offset: 0x001FDD73
		public unsafe int Particle1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroClothDihedralConstraintData.__PropertyOffset_Particle1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroClothDihedralConstraintData.__PropertyOffset_Particle1) = value;
			}
		}

		// Token: 0x17005636 RID: 22070
		// (get) Token: 0x06015C4C RID: 89164 RVA: 0x001FFB84 File Offset: 0x001FDD84
		// (set) Token: 0x06015C4D RID: 89165 RVA: 0x001FFB94 File Offset: 0x001FDD94
		public unsafe int Particle2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroClothDihedralConstraintData.__PropertyOffset_Particle2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroClothDihedralConstraintData.__PropertyOffset_Particle2) = value;
			}
		}

		// Token: 0x17005637 RID: 22071
		// (get) Token: 0x06015C4E RID: 89166 RVA: 0x001FFBA5 File Offset: 0x001FDDA5
		// (set) Token: 0x06015C4F RID: 89167 RVA: 0x001FFBB5 File Offset: 0x001FDDB5
		public unsafe int Particle3
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroClothDihedralConstraintData.__PropertyOffset_Particle3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroClothDihedralConstraintData.__PropertyOffset_Particle3) = value;
			}
		}

		// Token: 0x17005638 RID: 22072
		// (get) Token: 0x06015C50 RID: 89168 RVA: 0x001FFBC6 File Offset: 0x001FDDC6
		// (set) Token: 0x06015C51 RID: 89169 RVA: 0x001FFBD6 File Offset: 0x001FDDD6
		public unsafe float RestAngle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroClothDihedralConstraintData.__PropertyOffset_RestAngle);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroClothDihedralConstraintData.__PropertyOffset_RestAngle) = value;
			}
		}

		// Token: 0x06015C52 RID: 89170 RVA: 0x001FFBE7 File Offset: 0x001FDDE7
		public FKuroClothDihedralConstraintData()
		{
		}

		// Token: 0x06015C53 RID: 89171 RVA: 0x001FFBEF File Offset: 0x001FDDEF
		public FKuroClothDihedralConstraintData(int Particle0, int Particle1, int Particle2, int Particle3, float RestAngle)
		{
			this.Particle0 = Particle0;
			this.Particle1 = Particle1;
			this.Particle2 = Particle2;
			this.Particle3 = Particle3;
			this.RestAngle = RestAngle;
		}

		// Token: 0x06015C54 RID: 89172 RVA: 0x001FFC1C File Offset: 0x001FDE1C
		protected override IntPtr GetUStructPtr()
		{
			return FKuroClothDihedralConstraintData.StaticStruct();
		}

		// Token: 0x06015C55 RID: 89173 RVA: 0x001FFC28 File Offset: 0x001FDE28
		[NullableContext(2)]
		public FKuroClothDihedralConstraintData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06015C56 RID: 89174 RVA: 0x001FFC32 File Offset: 0x001FDE32
		public FKuroClothDihedralConstraintData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06015C57 RID: 89175 RVA: 0x001FFC3D File Offset: 0x001FDE3D
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroClothDihedralConstraintData(Pointer, false, true);
		}

		// Token: 0x06015C58 RID: 89176 RVA: 0x001FFC47 File Offset: 0x001FDE47
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroClothDihedralConstraintData(Pointer, MemoryOwner);
		}

		// Token: 0x0400BE15 RID: 48661
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroComputeShader.KuroClothDihedralConstraintData";

		// Token: 0x0400BE16 RID: 48662
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400BE17 RID: 48663
		internal static int __PropertyOffset_Particle0;

		// Token: 0x0400BE18 RID: 48664
		internal static int __PropertyOffset_Particle1;

		// Token: 0x0400BE19 RID: 48665
		internal static int __PropertyOffset_Particle2;

		// Token: 0x0400BE1A RID: 48666
		internal static int __PropertyOffset_Particle3;

		// Token: 0x0400BE1B RID: 48667
		internal static int __PropertyOffset_RestAngle;
	}
}
