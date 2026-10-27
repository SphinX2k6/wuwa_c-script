using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000D48 RID: 3400
	[UnrealObjectPath("/Script/Engine.LightCullDistanceConfig")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 56)]
	public class FLightCullDistanceConfig : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600B78C RID: 46988 RVA: 0x001051E4 File Offset: 0x001033E4
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FLightCullDistanceConfig._ScriptStructPtr != 0) ? FLightCullDistanceConfig._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.LightCullDistanceConfig", ref FLightCullDistanceConfig._ScriptStructPtr);
		}

		// Token: 0x170029FB RID: 10747
		// (get) Token: 0x0600B78D RID: 46989 RVA: 0x00105208 File Offset: 0x00103408
		// (set) Token: 0x0600B78E RID: 46990 RVA: 0x00105218 File Offset: 0x00103418
		public unsafe float UseCullType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLightCullDistanceConfig.__PropertyOffset_UseCullType);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLightCullDistanceConfig.__PropertyOffset_UseCullType) = value;
			}
		}

		// Token: 0x170029FC RID: 10748
		// (get) Token: 0x0600B78F RID: 46991 RVA: 0x00105229 File Offset: 0x00103429
		// (set) Token: 0x0600B790 RID: 46992 RVA: 0x00105239 File Offset: 0x00103439
		public unsafe int LightCullType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLightCullDistanceConfig.__PropertyOffset_LightCullType);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLightCullDistanceConfig.__PropertyOffset_LightCullType) = value;
			}
		}

		// Token: 0x170029FD RID: 10749
		// (get) Token: 0x0600B791 RID: 46993 RVA: 0x0010524A File Offset: 0x0010344A
		// (set) Token: 0x0600B792 RID: 46994 RVA: 0x0010525A File Offset: 0x0010345A
		public unsafe float MaxDrawDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLightCullDistanceConfig.__PropertyOffset_MaxDrawDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLightCullDistanceConfig.__PropertyOffset_MaxDrawDistance) = value;
			}
		}

		// Token: 0x170029FE RID: 10750
		// (get) Token: 0x0600B793 RID: 46995 RVA: 0x0010526B File Offset: 0x0010346B
		// (set) Token: 0x0600B794 RID: 46996 RVA: 0x0010527B File Offset: 0x0010347B
		public unsafe float MinDrawDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLightCullDistanceConfig.__PropertyOffset_MinDrawDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLightCullDistanceConfig.__PropertyOffset_MinDrawDistance) = value;
			}
		}

		// Token: 0x170029FF RID: 10751
		// (get) Token: 0x0600B795 RID: 46997 RVA: 0x0010528C File Offset: 0x0010348C
		// (set) Token: 0x0600B796 RID: 46998 RVA: 0x0010529C File Offset: 0x0010349C
		public unsafe float MaxDrawFadeRange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLightCullDistanceConfig.__PropertyOffset_MaxDrawFadeRange);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLightCullDistanceConfig.__PropertyOffset_MaxDrawFadeRange) = value;
			}
		}

		// Token: 0x17002A00 RID: 10752
		// (get) Token: 0x0600B797 RID: 46999 RVA: 0x001052AD File Offset: 0x001034AD
		// (set) Token: 0x0600B798 RID: 47000 RVA: 0x001052BD File Offset: 0x001034BD
		public unsafe float MinDrawFadeRange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLightCullDistanceConfig.__PropertyOffset_MinDrawFadeRange);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLightCullDistanceConfig.__PropertyOffset_MinDrawFadeRange) = value;
			}
		}

		// Token: 0x17002A01 RID: 10753
		// (get) Token: 0x0600B799 RID: 47001 RVA: 0x001052CE File Offset: 0x001034CE
		// (set) Token: 0x0600B79A RID: 47002 RVA: 0x001052DE File Offset: 0x001034DE
		public unsafe float HaloMaxDrawDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLightCullDistanceConfig.__PropertyOffset_HaloMaxDrawDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLightCullDistanceConfig.__PropertyOffset_HaloMaxDrawDistance) = value;
			}
		}

		// Token: 0x17002A02 RID: 10754
		// (get) Token: 0x0600B79B RID: 47003 RVA: 0x001052EF File Offset: 0x001034EF
		// (set) Token: 0x0600B79C RID: 47004 RVA: 0x001052FF File Offset: 0x001034FF
		public unsafe float HaloMinDrawDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLightCullDistanceConfig.__PropertyOffset_HaloMinDrawDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLightCullDistanceConfig.__PropertyOffset_HaloMinDrawDistance) = value;
			}
		}

		// Token: 0x17002A03 RID: 10755
		// (get) Token: 0x0600B79D RID: 47005 RVA: 0x00105310 File Offset: 0x00103510
		// (set) Token: 0x0600B79E RID: 47006 RVA: 0x00105320 File Offset: 0x00103520
		public unsafe float HaloMaxDrawFadeRange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLightCullDistanceConfig.__PropertyOffset_HaloMaxDrawFadeRange);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLightCullDistanceConfig.__PropertyOffset_HaloMaxDrawFadeRange) = value;
			}
		}

		// Token: 0x17002A04 RID: 10756
		// (get) Token: 0x0600B79F RID: 47007 RVA: 0x00105331 File Offset: 0x00103531
		// (set) Token: 0x0600B7A0 RID: 47008 RVA: 0x00105341 File Offset: 0x00103541
		public unsafe float HaloMinDrawFadeRange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLightCullDistanceConfig.__PropertyOffset_HaloMinDrawFadeRange);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLightCullDistanceConfig.__PropertyOffset_HaloMinDrawFadeRange) = value;
			}
		}

		// Token: 0x0600B7A1 RID: 47009 RVA: 0x00105352 File Offset: 0x00103552
		public FLightCullDistanceConfig()
		{
		}

		// Token: 0x0600B7A2 RID: 47010 RVA: 0x0010535C File Offset: 0x0010355C
		[NullableContext(1)]
		public FLightCullDistanceConfig(string Folder, float UseCullType, int LightCullType, float MaxDrawDistance, float MinDrawDistance, float MaxDrawFadeRange, float MinDrawFadeRange, float HaloMaxDrawDistance, float HaloMinDrawDistance, float HaloMaxDrawFadeRange, float HaloMinDrawFadeRange)
		{
			this.UseCullType = UseCullType;
			this.LightCullType = LightCullType;
			this.MaxDrawDistance = MaxDrawDistance;
			this.MinDrawDistance = MinDrawDistance;
			this.MaxDrawFadeRange = MaxDrawFadeRange;
			this.MinDrawFadeRange = MinDrawFadeRange;
			this.HaloMaxDrawDistance = HaloMaxDrawDistance;
			this.HaloMinDrawDistance = HaloMinDrawDistance;
			this.HaloMaxDrawFadeRange = HaloMaxDrawFadeRange;
			this.HaloMinDrawFadeRange = HaloMinDrawFadeRange;
		}

		// Token: 0x0600B7A3 RID: 47011 RVA: 0x001053BD File Offset: 0x001035BD
		protected override IntPtr GetUStructPtr()
		{
			return FLightCullDistanceConfig.StaticStruct();
		}

		// Token: 0x0600B7A4 RID: 47012 RVA: 0x001053C9 File Offset: 0x001035C9
		[NullableContext(2)]
		public FLightCullDistanceConfig(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600B7A5 RID: 47013 RVA: 0x001053D3 File Offset: 0x001035D3
		public FLightCullDistanceConfig(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600B7A6 RID: 47014 RVA: 0x001053DE File Offset: 0x001035DE
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FLightCullDistanceConfig(Pointer, false, true);
		}

		// Token: 0x0600B7A7 RID: 47015 RVA: 0x001053E8 File Offset: 0x001035E8
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FLightCullDistanceConfig(Pointer, MemoryOwner);
		}

		// Token: 0x04006024 RID: 24612
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.LightCullDistanceConfig";

		// Token: 0x04006025 RID: 24613
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04006026 RID: 24614
		internal static int __PropertyOffset_UseCullType;

		// Token: 0x04006027 RID: 24615
		internal static int __PropertyOffset_LightCullType;

		// Token: 0x04006028 RID: 24616
		internal static int __PropertyOffset_MaxDrawDistance;

		// Token: 0x04006029 RID: 24617
		internal static int __PropertyOffset_MinDrawDistance;

		// Token: 0x0400602A RID: 24618
		internal static int __PropertyOffset_MaxDrawFadeRange;

		// Token: 0x0400602B RID: 24619
		internal static int __PropertyOffset_MinDrawFadeRange;

		// Token: 0x0400602C RID: 24620
		internal static int __PropertyOffset_HaloMaxDrawDistance;

		// Token: 0x0400602D RID: 24621
		internal static int __PropertyOffset_HaloMinDrawDistance;

		// Token: 0x0400602E RID: 24622
		internal static int __PropertyOffset_HaloMaxDrawFadeRange;

		// Token: 0x0400602F RID: 24623
		internal static int __PropertyOffset_HaloMinDrawFadeRange;
	}
}
