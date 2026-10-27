using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020011B7 RID: 4535
	[UnrealObjectPath("/Script/Engine.SubsurfaceProfileStruct")]
	[UnrealStructLayout(140, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 140)]
	public class FSubsurfaceProfileStruct : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06010B7B RID: 68475 RVA: 0x00188B45 File Offset: 0x00186D45
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSubsurfaceProfileStruct._ScriptStructPtr != 0) ? FSubsurfaceProfileStruct._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.SubsurfaceProfileStruct", ref FSubsurfaceProfileStruct._ScriptStructPtr);
		}

		// Token: 0x17004148 RID: 16712
		// (get) Token: 0x06010B7C RID: 68476 RVA: 0x00188B69 File Offset: 0x00186D69
		// (set) Token: 0x06010B7D RID: 68477 RVA: 0x00188B7D File Offset: 0x00186D7D
		public unsafe FLinearColor SurfaceAlbedo
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSubsurfaceProfileStruct.__PropertyOffset_SurfaceAlbedo);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSubsurfaceProfileStruct.__PropertyOffset_SurfaceAlbedo) = value;
			}
		}

		// Token: 0x17004149 RID: 16713
		// (get) Token: 0x06010B7E RID: 68478 RVA: 0x00188B92 File Offset: 0x00186D92
		// (set) Token: 0x06010B7F RID: 68479 RVA: 0x00188BA6 File Offset: 0x00186DA6
		public unsafe FLinearColor MeanFreePathColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSubsurfaceProfileStruct.__PropertyOffset_MeanFreePathColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSubsurfaceProfileStruct.__PropertyOffset_MeanFreePathColor) = value;
			}
		}

		// Token: 0x1700414A RID: 16714
		// (get) Token: 0x06010B80 RID: 68480 RVA: 0x00188BBB File Offset: 0x00186DBB
		// (set) Token: 0x06010B81 RID: 68481 RVA: 0x00188BCB File Offset: 0x00186DCB
		public unsafe float MeanFreePathDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSubsurfaceProfileStruct.__PropertyOffset_MeanFreePathDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSubsurfaceProfileStruct.__PropertyOffset_MeanFreePathDistance) = value;
			}
		}

		// Token: 0x1700414B RID: 16715
		// (get) Token: 0x06010B82 RID: 68482 RVA: 0x00188BDC File Offset: 0x00186DDC
		// (set) Token: 0x06010B83 RID: 68483 RVA: 0x00188BEC File Offset: 0x00186DEC
		public unsafe float WorldUnitScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSubsurfaceProfileStruct.__PropertyOffset_WorldUnitScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSubsurfaceProfileStruct.__PropertyOffset_WorldUnitScale) = value;
			}
		}

		// Token: 0x1700414C RID: 16716
		// (get) Token: 0x06010B84 RID: 68484 RVA: 0x00188BFD File Offset: 0x00186DFD
		// (set) Token: 0x06010B85 RID: 68485 RVA: 0x00188C0D File Offset: 0x00186E0D
		public unsafe bool bEnableBurley
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSubsurfaceProfileStruct.__PropertyOffset_bEnableBurley) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSubsurfaceProfileStruct.__PropertyOffset_bEnableBurley) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700414D RID: 16717
		// (get) Token: 0x06010B86 RID: 68486 RVA: 0x00188C1E File Offset: 0x00186E1E
		// (set) Token: 0x06010B87 RID: 68487 RVA: 0x00188C2E File Offset: 0x00186E2E
		public unsafe float ScatterRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSubsurfaceProfileStruct.__PropertyOffset_ScatterRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSubsurfaceProfileStruct.__PropertyOffset_ScatterRadius) = value;
			}
		}

		// Token: 0x1700414E RID: 16718
		// (get) Token: 0x06010B88 RID: 68488 RVA: 0x00188C3F File Offset: 0x00186E3F
		// (set) Token: 0x06010B89 RID: 68489 RVA: 0x00188C53 File Offset: 0x00186E53
		public unsafe FLinearColor SubsurfaceColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSubsurfaceProfileStruct.__PropertyOffset_SubsurfaceColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSubsurfaceProfileStruct.__PropertyOffset_SubsurfaceColor) = value;
			}
		}

		// Token: 0x1700414F RID: 16719
		// (get) Token: 0x06010B8A RID: 68490 RVA: 0x00188C68 File Offset: 0x00186E68
		// (set) Token: 0x06010B8B RID: 68491 RVA: 0x00188C7C File Offset: 0x00186E7C
		public unsafe FLinearColor FalloffColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSubsurfaceProfileStruct.__PropertyOffset_FalloffColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSubsurfaceProfileStruct.__PropertyOffset_FalloffColor) = value;
			}
		}

		// Token: 0x17004150 RID: 16720
		// (get) Token: 0x06010B8C RID: 68492 RVA: 0x00188C91 File Offset: 0x00186E91
		// (set) Token: 0x06010B8D RID: 68493 RVA: 0x00188CA5 File Offset: 0x00186EA5
		public unsafe FLinearColor BoundaryColorBleed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSubsurfaceProfileStruct.__PropertyOffset_BoundaryColorBleed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSubsurfaceProfileStruct.__PropertyOffset_BoundaryColorBleed) = value;
			}
		}

		// Token: 0x17004151 RID: 16721
		// (get) Token: 0x06010B8E RID: 68494 RVA: 0x00188CBA File Offset: 0x00186EBA
		// (set) Token: 0x06010B8F RID: 68495 RVA: 0x00188CCA File Offset: 0x00186ECA
		public unsafe float ExtinctionScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSubsurfaceProfileStruct.__PropertyOffset_ExtinctionScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSubsurfaceProfileStruct.__PropertyOffset_ExtinctionScale) = value;
			}
		}

		// Token: 0x17004152 RID: 16722
		// (get) Token: 0x06010B90 RID: 68496 RVA: 0x00188CDB File Offset: 0x00186EDB
		// (set) Token: 0x06010B91 RID: 68497 RVA: 0x00188CEB File Offset: 0x00186EEB
		public unsafe float NormalScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSubsurfaceProfileStruct.__PropertyOffset_NormalScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSubsurfaceProfileStruct.__PropertyOffset_NormalScale) = value;
			}
		}

		// Token: 0x17004153 RID: 16723
		// (get) Token: 0x06010B92 RID: 68498 RVA: 0x00188CFC File Offset: 0x00186EFC
		// (set) Token: 0x06010B93 RID: 68499 RVA: 0x00188D0C File Offset: 0x00186F0C
		public unsafe float ScatteringDistribution
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSubsurfaceProfileStruct.__PropertyOffset_ScatteringDistribution);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSubsurfaceProfileStruct.__PropertyOffset_ScatteringDistribution) = value;
			}
		}

		// Token: 0x17004154 RID: 16724
		// (get) Token: 0x06010B94 RID: 68500 RVA: 0x00188D1D File Offset: 0x00186F1D
		// (set) Token: 0x06010B95 RID: 68501 RVA: 0x00188D2D File Offset: 0x00186F2D
		public unsafe float IOR
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSubsurfaceProfileStruct.__PropertyOffset_IOR);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSubsurfaceProfileStruct.__PropertyOffset_IOR) = value;
			}
		}

		// Token: 0x17004155 RID: 16725
		// (get) Token: 0x06010B96 RID: 68502 RVA: 0x00188D3E File Offset: 0x00186F3E
		// (set) Token: 0x06010B97 RID: 68503 RVA: 0x00188D4E File Offset: 0x00186F4E
		public unsafe float Roughness0
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSubsurfaceProfileStruct.__PropertyOffset_Roughness0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSubsurfaceProfileStruct.__PropertyOffset_Roughness0) = value;
			}
		}

		// Token: 0x17004156 RID: 16726
		// (get) Token: 0x06010B98 RID: 68504 RVA: 0x00188D5F File Offset: 0x00186F5F
		// (set) Token: 0x06010B99 RID: 68505 RVA: 0x00188D6F File Offset: 0x00186F6F
		public unsafe float Roughness1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSubsurfaceProfileStruct.__PropertyOffset_Roughness1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSubsurfaceProfileStruct.__PropertyOffset_Roughness1) = value;
			}
		}

		// Token: 0x17004157 RID: 16727
		// (get) Token: 0x06010B9A RID: 68506 RVA: 0x00188D80 File Offset: 0x00186F80
		// (set) Token: 0x06010B9B RID: 68507 RVA: 0x00188D90 File Offset: 0x00186F90
		public unsafe float LobeMix
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSubsurfaceProfileStruct.__PropertyOffset_LobeMix);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSubsurfaceProfileStruct.__PropertyOffset_LobeMix) = value;
			}
		}

		// Token: 0x17004158 RID: 16728
		// (get) Token: 0x06010B9C RID: 68508 RVA: 0x00188DA1 File Offset: 0x00186FA1
		// (set) Token: 0x06010B9D RID: 68509 RVA: 0x00188DB5 File Offset: 0x00186FB5
		public unsafe FLinearColor TransmissionTintColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSubsurfaceProfileStruct.__PropertyOffset_TransmissionTintColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSubsurfaceProfileStruct.__PropertyOffset_TransmissionTintColor) = value;
			}
		}

		// Token: 0x06010B9E RID: 68510 RVA: 0x00188DCA File Offset: 0x00186FCA
		public FSubsurfaceProfileStruct()
		{
		}

		// Token: 0x06010B9F RID: 68511 RVA: 0x00188DD4 File Offset: 0x00186FD4
		public FSubsurfaceProfileStruct(FLinearColor SurfaceAlbedo, FLinearColor MeanFreePathColor, float MeanFreePathDistance, float WorldUnitScale, bool bEnableBurley, float ScatterRadius, FLinearColor SubsurfaceColor, FLinearColor FalloffColor, FLinearColor BoundaryColorBleed, float ExtinctionScale, float NormalScale, float ScatteringDistribution, float IOR, float Roughness0, float Roughness1, float LobeMix, FLinearColor TransmissionTintColor)
		{
			this.SurfaceAlbedo = SurfaceAlbedo;
			this.MeanFreePathColor = MeanFreePathColor;
			this.MeanFreePathDistance = MeanFreePathDistance;
			this.WorldUnitScale = WorldUnitScale;
			this.bEnableBurley = bEnableBurley;
			this.ScatterRadius = ScatterRadius;
			this.SubsurfaceColor = SubsurfaceColor;
			this.FalloffColor = FalloffColor;
			this.BoundaryColorBleed = BoundaryColorBleed;
			this.ExtinctionScale = ExtinctionScale;
			this.NormalScale = NormalScale;
			this.ScatteringDistribution = ScatteringDistribution;
			this.IOR = IOR;
			this.Roughness0 = Roughness0;
			this.Roughness1 = Roughness1;
			this.LobeMix = LobeMix;
			this.TransmissionTintColor = TransmissionTintColor;
		}

		// Token: 0x06010BA0 RID: 68512 RVA: 0x00188E6C File Offset: 0x0018706C
		protected override IntPtr GetUStructPtr()
		{
			return FSubsurfaceProfileStruct.StaticStruct();
		}

		// Token: 0x06010BA1 RID: 68513 RVA: 0x00188E78 File Offset: 0x00187078
		[NullableContext(2)]
		public FSubsurfaceProfileStruct(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06010BA2 RID: 68514 RVA: 0x00188E82 File Offset: 0x00187082
		public FSubsurfaceProfileStruct(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06010BA3 RID: 68515 RVA: 0x00188E8D File Offset: 0x0018708D
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSubsurfaceProfileStruct(Pointer, false, true);
		}

		// Token: 0x06010BA4 RID: 68516 RVA: 0x00188E97 File Offset: 0x00187097
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSubsurfaceProfileStruct(Pointer, MemoryOwner);
		}

		// Token: 0x04008F02 RID: 36610
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.SubsurfaceProfileStruct";

		// Token: 0x04008F03 RID: 36611
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04008F04 RID: 36612
		internal static int __PropertyOffset_SurfaceAlbedo;

		// Token: 0x04008F05 RID: 36613
		internal static int __PropertyOffset_MeanFreePathColor;

		// Token: 0x04008F06 RID: 36614
		internal static int __PropertyOffset_MeanFreePathDistance;

		// Token: 0x04008F07 RID: 36615
		internal static int __PropertyOffset_WorldUnitScale;

		// Token: 0x04008F08 RID: 36616
		internal static int __PropertyOffset_bEnableBurley;

		// Token: 0x04008F09 RID: 36617
		internal static int __PropertyOffset_ScatterRadius;

		// Token: 0x04008F0A RID: 36618
		internal static int __PropertyOffset_SubsurfaceColor;

		// Token: 0x04008F0B RID: 36619
		internal static int __PropertyOffset_FalloffColor;

		// Token: 0x04008F0C RID: 36620
		internal static int __PropertyOffset_BoundaryColorBleed;

		// Token: 0x04008F0D RID: 36621
		internal static int __PropertyOffset_ExtinctionScale;

		// Token: 0x04008F0E RID: 36622
		internal static int __PropertyOffset_NormalScale;

		// Token: 0x04008F0F RID: 36623
		internal static int __PropertyOffset_ScatteringDistribution;

		// Token: 0x04008F10 RID: 36624
		internal static int __PropertyOffset_IOR;

		// Token: 0x04008F11 RID: 36625
		internal static int __PropertyOffset_Roughness0;

		// Token: 0x04008F12 RID: 36626
		internal static int __PropertyOffset_Roughness1;

		// Token: 0x04008F13 RID: 36627
		internal static int __PropertyOffset_LobeMix;

		// Token: 0x04008F14 RID: 36628
		internal static int __PropertyOffset_TransmissionTintColor;
	}
}
