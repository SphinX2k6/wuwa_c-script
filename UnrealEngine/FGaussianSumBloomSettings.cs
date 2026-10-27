using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000C07 RID: 3079
	[UnrealObjectPath("/Script/Engine.GaussianSumBloomSettings")]
	[UnrealStructLayout(132, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 132)]
	public class FGaussianSumBloomSettings : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06009B10 RID: 39696 RVA: 0x000DC5EA File Offset: 0x000DA7EA
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FGaussianSumBloomSettings._ScriptStructPtr != 0) ? FGaussianSumBloomSettings._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.GaussianSumBloomSettings", ref FGaussianSumBloomSettings._ScriptStructPtr);
		}

		// Token: 0x170024DA RID: 9434
		// (get) Token: 0x06009B11 RID: 39697 RVA: 0x000DC60E File Offset: 0x000DA80E
		// (set) Token: 0x06009B12 RID: 39698 RVA: 0x000DC61E File Offset: 0x000DA81E
		public unsafe float Intensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGaussianSumBloomSettings.__PropertyOffset_Intensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGaussianSumBloomSettings.__PropertyOffset_Intensity) = value;
			}
		}

		// Token: 0x170024DB RID: 9435
		// (get) Token: 0x06009B13 RID: 39699 RVA: 0x000DC62F File Offset: 0x000DA82F
		// (set) Token: 0x06009B14 RID: 39700 RVA: 0x000DC63F File Offset: 0x000DA83F
		public unsafe float Threshold
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGaussianSumBloomSettings.__PropertyOffset_Threshold);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGaussianSumBloomSettings.__PropertyOffset_Threshold) = value;
			}
		}

		// Token: 0x170024DC RID: 9436
		// (get) Token: 0x06009B15 RID: 39701 RVA: 0x000DC650 File Offset: 0x000DA850
		// (set) Token: 0x06009B16 RID: 39702 RVA: 0x000DC660 File Offset: 0x000DA860
		public unsafe float SizeScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGaussianSumBloomSettings.__PropertyOffset_SizeScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGaussianSumBloomSettings.__PropertyOffset_SizeScale) = value;
			}
		}

		// Token: 0x170024DD RID: 9437
		// (get) Token: 0x06009B17 RID: 39703 RVA: 0x000DC671 File Offset: 0x000DA871
		// (set) Token: 0x06009B18 RID: 39704 RVA: 0x000DC681 File Offset: 0x000DA881
		public unsafe float Filter1Size
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGaussianSumBloomSettings.__PropertyOffset_Filter1Size);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGaussianSumBloomSettings.__PropertyOffset_Filter1Size) = value;
			}
		}

		// Token: 0x170024DE RID: 9438
		// (get) Token: 0x06009B19 RID: 39705 RVA: 0x000DC692 File Offset: 0x000DA892
		// (set) Token: 0x06009B1A RID: 39706 RVA: 0x000DC6A2 File Offset: 0x000DA8A2
		public unsafe float Filter2Size
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGaussianSumBloomSettings.__PropertyOffset_Filter2Size);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGaussianSumBloomSettings.__PropertyOffset_Filter2Size) = value;
			}
		}

		// Token: 0x170024DF RID: 9439
		// (get) Token: 0x06009B1B RID: 39707 RVA: 0x000DC6B3 File Offset: 0x000DA8B3
		// (set) Token: 0x06009B1C RID: 39708 RVA: 0x000DC6C3 File Offset: 0x000DA8C3
		public unsafe float Filter3Size
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGaussianSumBloomSettings.__PropertyOffset_Filter3Size);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGaussianSumBloomSettings.__PropertyOffset_Filter3Size) = value;
			}
		}

		// Token: 0x170024E0 RID: 9440
		// (get) Token: 0x06009B1D RID: 39709 RVA: 0x000DC6D4 File Offset: 0x000DA8D4
		// (set) Token: 0x06009B1E RID: 39710 RVA: 0x000DC6E4 File Offset: 0x000DA8E4
		public unsafe float Filter4Size
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGaussianSumBloomSettings.__PropertyOffset_Filter4Size);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGaussianSumBloomSettings.__PropertyOffset_Filter4Size) = value;
			}
		}

		// Token: 0x170024E1 RID: 9441
		// (get) Token: 0x06009B1F RID: 39711 RVA: 0x000DC6F5 File Offset: 0x000DA8F5
		// (set) Token: 0x06009B20 RID: 39712 RVA: 0x000DC705 File Offset: 0x000DA905
		public unsafe float Filter5Size
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGaussianSumBloomSettings.__PropertyOffset_Filter5Size);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGaussianSumBloomSettings.__PropertyOffset_Filter5Size) = value;
			}
		}

		// Token: 0x170024E2 RID: 9442
		// (get) Token: 0x06009B21 RID: 39713 RVA: 0x000DC716 File Offset: 0x000DA916
		// (set) Token: 0x06009B22 RID: 39714 RVA: 0x000DC726 File Offset: 0x000DA926
		public unsafe float Filter6Size
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGaussianSumBloomSettings.__PropertyOffset_Filter6Size);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGaussianSumBloomSettings.__PropertyOffset_Filter6Size) = value;
			}
		}

		// Token: 0x170024E3 RID: 9443
		// (get) Token: 0x06009B23 RID: 39715 RVA: 0x000DC737 File Offset: 0x000DA937
		// (set) Token: 0x06009B24 RID: 39716 RVA: 0x000DC74B File Offset: 0x000DA94B
		public unsafe FLinearColor Filter1Tint
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGaussianSumBloomSettings.__PropertyOffset_Filter1Tint);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGaussianSumBloomSettings.__PropertyOffset_Filter1Tint) = value;
			}
		}

		// Token: 0x170024E4 RID: 9444
		// (get) Token: 0x06009B25 RID: 39717 RVA: 0x000DC760 File Offset: 0x000DA960
		// (set) Token: 0x06009B26 RID: 39718 RVA: 0x000DC774 File Offset: 0x000DA974
		public unsafe FLinearColor Filter2Tint
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGaussianSumBloomSettings.__PropertyOffset_Filter2Tint);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGaussianSumBloomSettings.__PropertyOffset_Filter2Tint) = value;
			}
		}

		// Token: 0x170024E5 RID: 9445
		// (get) Token: 0x06009B27 RID: 39719 RVA: 0x000DC789 File Offset: 0x000DA989
		// (set) Token: 0x06009B28 RID: 39720 RVA: 0x000DC79D File Offset: 0x000DA99D
		public unsafe FLinearColor Filter3Tint
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGaussianSumBloomSettings.__PropertyOffset_Filter3Tint);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGaussianSumBloomSettings.__PropertyOffset_Filter3Tint) = value;
			}
		}

		// Token: 0x170024E6 RID: 9446
		// (get) Token: 0x06009B29 RID: 39721 RVA: 0x000DC7B2 File Offset: 0x000DA9B2
		// (set) Token: 0x06009B2A RID: 39722 RVA: 0x000DC7C6 File Offset: 0x000DA9C6
		public unsafe FLinearColor Filter4Tint
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGaussianSumBloomSettings.__PropertyOffset_Filter4Tint);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGaussianSumBloomSettings.__PropertyOffset_Filter4Tint) = value;
			}
		}

		// Token: 0x170024E7 RID: 9447
		// (get) Token: 0x06009B2B RID: 39723 RVA: 0x000DC7DB File Offset: 0x000DA9DB
		// (set) Token: 0x06009B2C RID: 39724 RVA: 0x000DC7EF File Offset: 0x000DA9EF
		public unsafe FLinearColor Filter5Tint
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGaussianSumBloomSettings.__PropertyOffset_Filter5Tint);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGaussianSumBloomSettings.__PropertyOffset_Filter5Tint) = value;
			}
		}

		// Token: 0x170024E8 RID: 9448
		// (get) Token: 0x06009B2D RID: 39725 RVA: 0x000DC804 File Offset: 0x000DAA04
		// (set) Token: 0x06009B2E RID: 39726 RVA: 0x000DC818 File Offset: 0x000DAA18
		public unsafe FLinearColor Filter6Tint
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGaussianSumBloomSettings.__PropertyOffset_Filter6Tint);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGaussianSumBloomSettings.__PropertyOffset_Filter6Tint) = value;
			}
		}

		// Token: 0x06009B2F RID: 39727 RVA: 0x000DC82D File Offset: 0x000DAA2D
		public FGaussianSumBloomSettings()
		{
		}

		// Token: 0x06009B30 RID: 39728 RVA: 0x000DC838 File Offset: 0x000DAA38
		public FGaussianSumBloomSettings(float Intensity, float Threshold, float SizeScale, float Filter1Size, float Filter2Size, float Filter3Size, float Filter4Size, float Filter5Size, float Filter6Size, FLinearColor Filter1Tint, FLinearColor Filter2Tint, FLinearColor Filter3Tint, FLinearColor Filter4Tint, FLinearColor Filter5Tint, FLinearColor Filter6Tint)
		{
			this.Intensity = Intensity;
			this.Threshold = Threshold;
			this.SizeScale = SizeScale;
			this.Filter1Size = Filter1Size;
			this.Filter2Size = Filter2Size;
			this.Filter3Size = Filter3Size;
			this.Filter4Size = Filter4Size;
			this.Filter5Size = Filter5Size;
			this.Filter6Size = Filter6Size;
			this.Filter1Tint = Filter1Tint;
			this.Filter2Tint = Filter2Tint;
			this.Filter3Tint = Filter3Tint;
			this.Filter4Tint = Filter4Tint;
			this.Filter5Tint = Filter5Tint;
			this.Filter6Tint = Filter6Tint;
		}

		// Token: 0x06009B31 RID: 39729 RVA: 0x000DC8C0 File Offset: 0x000DAAC0
		protected override IntPtr GetUStructPtr()
		{
			return FGaussianSumBloomSettings.StaticStruct();
		}

		// Token: 0x06009B32 RID: 39730 RVA: 0x000DC8CC File Offset: 0x000DAACC
		[NullableContext(2)]
		public FGaussianSumBloomSettings(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06009B33 RID: 39731 RVA: 0x000DC8D6 File Offset: 0x000DAAD6
		public FGaussianSumBloomSettings(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06009B34 RID: 39732 RVA: 0x000DC8E1 File Offset: 0x000DAAE1
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FGaussianSumBloomSettings(Pointer, false, true);
		}

		// Token: 0x06009B35 RID: 39733 RVA: 0x000DC8EB File Offset: 0x000DAAEB
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FGaussianSumBloomSettings(Pointer, MemoryOwner);
		}

		// Token: 0x0400559E RID: 21918
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.GaussianSumBloomSettings";

		// Token: 0x0400559F RID: 21919
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040055A0 RID: 21920
		internal static int __PropertyOffset_Intensity;

		// Token: 0x040055A1 RID: 21921
		internal static int __PropertyOffset_Threshold;

		// Token: 0x040055A2 RID: 21922
		internal static int __PropertyOffset_SizeScale;

		// Token: 0x040055A3 RID: 21923
		internal static int __PropertyOffset_Filter1Size;

		// Token: 0x040055A4 RID: 21924
		internal static int __PropertyOffset_Filter2Size;

		// Token: 0x040055A5 RID: 21925
		internal static int __PropertyOffset_Filter3Size;

		// Token: 0x040055A6 RID: 21926
		internal static int __PropertyOffset_Filter4Size;

		// Token: 0x040055A7 RID: 21927
		internal static int __PropertyOffset_Filter5Size;

		// Token: 0x040055A8 RID: 21928
		internal static int __PropertyOffset_Filter6Size;

		// Token: 0x040055A9 RID: 21929
		internal static int __PropertyOffset_Filter1Tint;

		// Token: 0x040055AA RID: 21930
		internal static int __PropertyOffset_Filter2Tint;

		// Token: 0x040055AB RID: 21931
		internal static int __PropertyOffset_Filter3Tint;

		// Token: 0x040055AC RID: 21932
		internal static int __PropertyOffset_Filter4Tint;

		// Token: 0x040055AD RID: 21933
		internal static int __PropertyOffset_Filter5Tint;

		// Token: 0x040055AE RID: 21934
		internal static int __PropertyOffset_Filter6Tint;
	}
}
