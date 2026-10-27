using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020011AE RID: 4526
	[HasGetTypeHash]
	[UnrealObjectPath("/Script/Engine.StreamingSourceShape")]
	[UnrealStructLayout(44, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 44)]
	public class FStreamingSourceShape : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06010B0F RID: 68367 RVA: 0x0018836E File Offset: 0x0018656E
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FStreamingSourceShape._ScriptStructPtr != 0) ? FStreamingSourceShape._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.StreamingSourceShape", ref FStreamingSourceShape._ScriptStructPtr);
		}

		// Token: 0x17004133 RID: 16691
		// (get) Token: 0x06010B10 RID: 68368 RVA: 0x00188392 File Offset: 0x00186592
		// (set) Token: 0x06010B11 RID: 68369 RVA: 0x001883A2 File Offset: 0x001865A2
		public unsafe bool bUseGridLoadingRange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FStreamingSourceShape.__PropertyOffset_bUseGridLoadingRange) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FStreamingSourceShape.__PropertyOffset_bUseGridLoadingRange) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004134 RID: 16692
		// (get) Token: 0x06010B12 RID: 68370 RVA: 0x001883B3 File Offset: 0x001865B3
		// (set) Token: 0x06010B13 RID: 68371 RVA: 0x001883C3 File Offset: 0x001865C3
		public unsafe float LoadingRangeScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FStreamingSourceShape.__PropertyOffset_LoadingRangeScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FStreamingSourceShape.__PropertyOffset_LoadingRangeScale) = value;
			}
		}

		// Token: 0x17004135 RID: 16693
		// (get) Token: 0x06010B14 RID: 68372 RVA: 0x001883D4 File Offset: 0x001865D4
		// (set) Token: 0x06010B15 RID: 68373 RVA: 0x001883E4 File Offset: 0x001865E4
		public unsafe float Radius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FStreamingSourceShape.__PropertyOffset_Radius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FStreamingSourceShape.__PropertyOffset_Radius) = value;
			}
		}

		// Token: 0x17004136 RID: 16694
		// (get) Token: 0x06010B16 RID: 68374 RVA: 0x001883F5 File Offset: 0x001865F5
		// (set) Token: 0x06010B17 RID: 68375 RVA: 0x00188405 File Offset: 0x00186605
		public unsafe bool bIsSector
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FStreamingSourceShape.__PropertyOffset_bIsSector) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FStreamingSourceShape.__PropertyOffset_bIsSector) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004137 RID: 16695
		// (get) Token: 0x06010B18 RID: 68376 RVA: 0x00188416 File Offset: 0x00186616
		// (set) Token: 0x06010B19 RID: 68377 RVA: 0x00188426 File Offset: 0x00186626
		public unsafe float SectorAngle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FStreamingSourceShape.__PropertyOffset_SectorAngle);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FStreamingSourceShape.__PropertyOffset_SectorAngle) = value;
			}
		}

		// Token: 0x17004138 RID: 16696
		// (get) Token: 0x06010B1A RID: 68378 RVA: 0x00188437 File Offset: 0x00186637
		// (set) Token: 0x06010B1B RID: 68379 RVA: 0x0018844B File Offset: 0x0018664B
		public unsafe FVector Location
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FStreamingSourceShape.__PropertyOffset_Location);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FStreamingSourceShape.__PropertyOffset_Location) = value;
			}
		}

		// Token: 0x17004139 RID: 16697
		// (get) Token: 0x06010B1C RID: 68380 RVA: 0x00188460 File Offset: 0x00186660
		// (set) Token: 0x06010B1D RID: 68381 RVA: 0x00188474 File Offset: 0x00186674
		public unsafe FRotator Rotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FStreamingSourceShape.__PropertyOffset_Rotation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FStreamingSourceShape.__PropertyOffset_Rotation) = value;
			}
		}

		// Token: 0x06010B1E RID: 68382 RVA: 0x00188489 File Offset: 0x00186689
		public FStreamingSourceShape()
		{
		}

		// Token: 0x06010B1F RID: 68383 RVA: 0x00188491 File Offset: 0x00186691
		public FStreamingSourceShape(bool bUseGridLoadingRange, float LoadingRangeScale, float Radius, bool bIsSector, float SectorAngle, FVector Location, FRotator Rotation)
		{
			this.bUseGridLoadingRange = bUseGridLoadingRange;
			this.LoadingRangeScale = LoadingRangeScale;
			this.Radius = Radius;
			this.bIsSector = bIsSector;
			this.SectorAngle = SectorAngle;
			this.Location = Location;
			this.Rotation = Rotation;
		}

		// Token: 0x06010B20 RID: 68384 RVA: 0x001884CE File Offset: 0x001866CE
		protected override IntPtr GetUStructPtr()
		{
			return FStreamingSourceShape.StaticStruct();
		}

		// Token: 0x06010B21 RID: 68385 RVA: 0x001884DA File Offset: 0x001866DA
		[NullableContext(2)]
		public FStreamingSourceShape(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06010B22 RID: 68386 RVA: 0x001884E4 File Offset: 0x001866E4
		public FStreamingSourceShape(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06010B23 RID: 68387 RVA: 0x001884EF File Offset: 0x001866EF
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FStreamingSourceShape(Pointer, false, true);
		}

		// Token: 0x06010B24 RID: 68388 RVA: 0x001884F9 File Offset: 0x001866F9
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FStreamingSourceShape(Pointer, MemoryOwner);
		}

		// Token: 0x04008ED7 RID: 36567
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.StreamingSourceShape";

		// Token: 0x04008ED8 RID: 36568
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04008ED9 RID: 36569
		internal static int __PropertyOffset_bUseGridLoadingRange;

		// Token: 0x04008EDA RID: 36570
		internal static int __PropertyOffset_LoadingRangeScale;

		// Token: 0x04008EDB RID: 36571
		internal static int __PropertyOffset_Radius;

		// Token: 0x04008EDC RID: 36572
		internal static int __PropertyOffset_bIsSector;

		// Token: 0x04008EDD RID: 36573
		internal static int __PropertyOffset_SectorAngle;

		// Token: 0x04008EDE RID: 36574
		internal static int __PropertyOffset_Location;

		// Token: 0x04008EDF RID: 36575
		internal static int __PropertyOffset_Rotation;
	}
}
