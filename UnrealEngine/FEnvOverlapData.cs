using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200018B RID: 395
	[UnrealObjectPath("/Script/AIModule.EnvOverlapData")]
	[UnrealStructLayout(32, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FEnvOverlapData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060018B1 RID: 6321 RVA: 0x000244D3 File Offset: 0x000226D3
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FEnvOverlapData._ScriptStructPtr != 0) ? FEnvOverlapData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AIModule.EnvOverlapData", ref FEnvOverlapData._ScriptStructPtr);
		}

		// Token: 0x17000656 RID: 1622
		// (get) Token: 0x060018B2 RID: 6322 RVA: 0x000244F7 File Offset: 0x000226F7
		// (set) Token: 0x060018B3 RID: 6323 RVA: 0x00024507 File Offset: 0x00022707
		public unsafe float ExtentX
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FEnvOverlapData.__PropertyOffset_ExtentX);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FEnvOverlapData.__PropertyOffset_ExtentX) = value;
			}
		}

		// Token: 0x17000657 RID: 1623
		// (get) Token: 0x060018B4 RID: 6324 RVA: 0x00024518 File Offset: 0x00022718
		// (set) Token: 0x060018B5 RID: 6325 RVA: 0x00024528 File Offset: 0x00022728
		public unsafe float ExtentY
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FEnvOverlapData.__PropertyOffset_ExtentY);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FEnvOverlapData.__PropertyOffset_ExtentY) = value;
			}
		}

		// Token: 0x17000658 RID: 1624
		// (get) Token: 0x060018B6 RID: 6326 RVA: 0x00024539 File Offset: 0x00022739
		// (set) Token: 0x060018B7 RID: 6327 RVA: 0x00024549 File Offset: 0x00022749
		public unsafe float ExtentZ
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FEnvOverlapData.__PropertyOffset_ExtentZ);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FEnvOverlapData.__PropertyOffset_ExtentZ) = value;
			}
		}

		// Token: 0x17000659 RID: 1625
		// (get) Token: 0x060018B8 RID: 6328 RVA: 0x0002455A File Offset: 0x0002275A
		// (set) Token: 0x060018B9 RID: 6329 RVA: 0x0002456E File Offset: 0x0002276E
		public unsafe FVector ShapeOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FEnvOverlapData.__PropertyOffset_ShapeOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FEnvOverlapData.__PropertyOffset_ShapeOffset) = value;
			}
		}

		// Token: 0x1700065A RID: 1626
		// (get) Token: 0x060018BA RID: 6330 RVA: 0x00024583 File Offset: 0x00022783
		// (set) Token: 0x060018BB RID: 6331 RVA: 0x00024597 File Offset: 0x00022797
		public unsafe TEnumAsByte<ECollisionChannel> OverlapChannel
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FEnvOverlapData.__PropertyOffset_OverlapChannel);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FEnvOverlapData.__PropertyOffset_OverlapChannel) = value;
			}
		}

		// Token: 0x1700065B RID: 1627
		// (get) Token: 0x060018BC RID: 6332 RVA: 0x000245AC File Offset: 0x000227AC
		// (set) Token: 0x060018BD RID: 6333 RVA: 0x000245C0 File Offset: 0x000227C0
		public unsafe TEnumAsByte<EEnvOverlapShape> OverlapShape
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FEnvOverlapData.__PropertyOffset_OverlapShape);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FEnvOverlapData.__PropertyOffset_OverlapShape) = value;
			}
		}

		// Token: 0x1700065C RID: 1628
		// (get) Token: 0x060018BE RID: 6334 RVA: 0x000245D5 File Offset: 0x000227D5
		// (set) Token: 0x060018BF RID: 6335 RVA: 0x000245EE File Offset: 0x000227EE
		public unsafe bool bOnlyBlockingHits
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FEnvOverlapData.__PropertyOffset_bOnlyBlockingHits) & FEnvOverlapData.__PropertyMask_bOnlyBlockingHits) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FEnvOverlapData.__PropertyOffset_bOnlyBlockingHits) = ((*(base.NativePtr + (IntPtr)FEnvOverlapData.__PropertyOffset_bOnlyBlockingHits) & ~FEnvOverlapData.__PropertyMask_bOnlyBlockingHits) | (value ? FEnvOverlapData.__PropertyMask_bOnlyBlockingHits : 0));
			}
		}

		// Token: 0x1700065D RID: 1629
		// (get) Token: 0x060018C0 RID: 6336 RVA: 0x0002461E File Offset: 0x0002281E
		// (set) Token: 0x060018C1 RID: 6337 RVA: 0x00024637 File Offset: 0x00022837
		public unsafe bool bOverlapComplex
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FEnvOverlapData.__PropertyOffset_bOverlapComplex) & FEnvOverlapData.__PropertyMask_bOverlapComplex) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FEnvOverlapData.__PropertyOffset_bOverlapComplex) = ((*(base.NativePtr + (IntPtr)FEnvOverlapData.__PropertyOffset_bOverlapComplex) & ~FEnvOverlapData.__PropertyMask_bOverlapComplex) | (value ? FEnvOverlapData.__PropertyMask_bOverlapComplex : 0));
			}
		}

		// Token: 0x1700065E RID: 1630
		// (get) Token: 0x060018C2 RID: 6338 RVA: 0x00024667 File Offset: 0x00022867
		// (set) Token: 0x060018C3 RID: 6339 RVA: 0x00024680 File Offset: 0x00022880
		public unsafe bool bSkipOverlapQuerier
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FEnvOverlapData.__PropertyOffset_bSkipOverlapQuerier) & FEnvOverlapData.__PropertyMask_bSkipOverlapQuerier) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FEnvOverlapData.__PropertyOffset_bSkipOverlapQuerier) = ((*(base.NativePtr + (IntPtr)FEnvOverlapData.__PropertyOffset_bSkipOverlapQuerier) & ~FEnvOverlapData.__PropertyMask_bSkipOverlapQuerier) | (value ? FEnvOverlapData.__PropertyMask_bSkipOverlapQuerier : 0));
			}
		}

		// Token: 0x060018C4 RID: 6340 RVA: 0x000246B0 File Offset: 0x000228B0
		public FEnvOverlapData()
		{
		}

		// Token: 0x060018C5 RID: 6341 RVA: 0x000246B8 File Offset: 0x000228B8
		public FEnvOverlapData(float ExtentX, float ExtentY, float ExtentZ, FVector ShapeOffset, TEnumAsByte<ECollisionChannel> OverlapChannel, TEnumAsByte<EEnvOverlapShape> OverlapShape, bool bOnlyBlockingHits, bool bOverlapComplex, bool bSkipOverlapQuerier)
		{
			this.ExtentX = ExtentX;
			this.ExtentY = ExtentY;
			this.ExtentZ = ExtentZ;
			this.ShapeOffset = ShapeOffset;
			this.OverlapChannel = OverlapChannel;
			this.OverlapShape = OverlapShape;
			this.bOnlyBlockingHits = bOnlyBlockingHits;
			this.bOverlapComplex = bOverlapComplex;
			this.bSkipOverlapQuerier = bSkipOverlapQuerier;
		}

		// Token: 0x060018C6 RID: 6342 RVA: 0x00024710 File Offset: 0x00022910
		protected override IntPtr GetUStructPtr()
		{
			return FEnvOverlapData.StaticStruct();
		}

		// Token: 0x060018C7 RID: 6343 RVA: 0x0002471C File Offset: 0x0002291C
		[NullableContext(2)]
		public FEnvOverlapData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060018C8 RID: 6344 RVA: 0x00024726 File Offset: 0x00022926
		public FEnvOverlapData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060018C9 RID: 6345 RVA: 0x00024731 File Offset: 0x00022931
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FEnvOverlapData(Pointer, false, true);
		}

		// Token: 0x060018CA RID: 6346 RVA: 0x0002473B File Offset: 0x0002293B
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FEnvOverlapData(Pointer, MemoryOwner);
		}

		// Token: 0x040006E2 RID: 1762
		[Nullable(1)]
		public const string __ObjectPath = "/Script/AIModule.EnvOverlapData";

		// Token: 0x040006E3 RID: 1763
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040006E4 RID: 1764
		internal static int __PropertyOffset_ExtentX;

		// Token: 0x040006E5 RID: 1765
		internal static int __PropertyOffset_ExtentY;

		// Token: 0x040006E6 RID: 1766
		internal static int __PropertyOffset_ExtentZ;

		// Token: 0x040006E7 RID: 1767
		internal static int __PropertyOffset_ShapeOffset;

		// Token: 0x040006E8 RID: 1768
		internal static int __PropertyOffset_OverlapChannel;

		// Token: 0x040006E9 RID: 1769
		internal static int __PropertyOffset_OverlapShape;

		// Token: 0x040006EA RID: 1770
		internal static int __PropertyOffset_bOnlyBlockingHits;

		// Token: 0x040006EB RID: 1771
		internal static byte __PropertyMask_bOnlyBlockingHits;

		// Token: 0x040006EC RID: 1772
		internal static int __PropertyOffset_bOverlapComplex;

		// Token: 0x040006ED RID: 1773
		internal static byte __PropertyMask_bOverlapComplex;

		// Token: 0x040006EE RID: 1774
		internal static int __PropertyOffset_bSkipOverlapQuerier;

		// Token: 0x040006EF RID: 1775
		internal static byte __PropertyMask_bSkipOverlapQuerier;
	}
}
