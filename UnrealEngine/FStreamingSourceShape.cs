using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000293 RID: 659
	[HasGetTypeHash]
	[UnrealObjectPath("/Script/Engine.StreamingSourceShape")]
	[UnrealStructLayout(44, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 44)]
	public class FStreamingSourceShape : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060048E8 RID: 18664 RVA: 0x00066501 File Offset: 0x00064701
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FStreamingSourceShape._ScriptStructPtr != 0) ? FStreamingSourceShape._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.StreamingSourceShape", ref FStreamingSourceShape._ScriptStructPtr);
		}

		// Token: 0x17000DA4 RID: 3492
		// (get) Token: 0x060048E9 RID: 18665 RVA: 0x00066525 File Offset: 0x00064725
		// (set) Token: 0x060048EA RID: 18666 RVA: 0x00066535 File Offset: 0x00064735
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

		// Token: 0x17000DA5 RID: 3493
		// (get) Token: 0x060048EB RID: 18667 RVA: 0x00066546 File Offset: 0x00064746
		// (set) Token: 0x060048EC RID: 18668 RVA: 0x00066556 File Offset: 0x00064756
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

		// Token: 0x17000DA6 RID: 3494
		// (get) Token: 0x060048ED RID: 18669 RVA: 0x00066567 File Offset: 0x00064767
		// (set) Token: 0x060048EE RID: 18670 RVA: 0x00066577 File Offset: 0x00064777
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

		// Token: 0x17000DA7 RID: 3495
		// (get) Token: 0x060048EF RID: 18671 RVA: 0x00066588 File Offset: 0x00064788
		// (set) Token: 0x060048F0 RID: 18672 RVA: 0x00066598 File Offset: 0x00064798
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

		// Token: 0x17000DA8 RID: 3496
		// (get) Token: 0x060048F1 RID: 18673 RVA: 0x000665A9 File Offset: 0x000647A9
		// (set) Token: 0x060048F2 RID: 18674 RVA: 0x000665B9 File Offset: 0x000647B9
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

		// Token: 0x17000DA9 RID: 3497
		// (get) Token: 0x060048F3 RID: 18675 RVA: 0x000665CA File Offset: 0x000647CA
		// (set) Token: 0x060048F4 RID: 18676 RVA: 0x000665DE File Offset: 0x000647DE
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

		// Token: 0x17000DAA RID: 3498
		// (get) Token: 0x060048F5 RID: 18677 RVA: 0x000665F3 File Offset: 0x000647F3
		// (set) Token: 0x060048F6 RID: 18678 RVA: 0x00066607 File Offset: 0x00064807
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

		// Token: 0x060048F7 RID: 18679 RVA: 0x0006661C File Offset: 0x0006481C
		public FStreamingSourceShape()
		{
		}

		// Token: 0x060048F8 RID: 18680 RVA: 0x00066624 File Offset: 0x00064824
		protected override IntPtr GetUStructPtr()
		{
			return FStreamingSourceShape.StaticStruct();
		}

		// Token: 0x060048F9 RID: 18681 RVA: 0x00066630 File Offset: 0x00064830
		[NullableContext(2)]
		public FStreamingSourceShape(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060048FA RID: 18682 RVA: 0x0006663A File Offset: 0x0006483A
		public FStreamingSourceShape(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060048FB RID: 18683 RVA: 0x00066645 File Offset: 0x00064845
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FStreamingSourceShape(Pointer, false, true);
		}

		// Token: 0x060048FC RID: 18684 RVA: 0x0006664F File Offset: 0x0006484F
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FStreamingSourceShape(Pointer, MemoryOwner);
		}

		// Token: 0x04001C56 RID: 7254
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.StreamingSourceShape";

		// Token: 0x04001C57 RID: 7255
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04001C58 RID: 7256
		internal static int __PropertyOffset_bUseGridLoadingRange;

		// Token: 0x04001C59 RID: 7257
		internal static int __PropertyOffset_LoadingRangeScale;

		// Token: 0x04001C5A RID: 7258
		internal static int __PropertyOffset_Radius;

		// Token: 0x04001C5B RID: 7259
		internal static int __PropertyOffset_bIsSector;

		// Token: 0x04001C5C RID: 7260
		internal static int __PropertyOffset_SectorAngle;

		// Token: 0x04001C5D RID: 7261
		internal static int __PropertyOffset_Location;

		// Token: 0x04001C5E RID: 7262
		internal static int __PropertyOffset_Rotation;
	}
}
