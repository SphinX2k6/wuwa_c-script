using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001C38 RID: 7224
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.WaterBallInteractor")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 64)]
	public class FWaterBallInteractor : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601C056 RID: 114774 RVA: 0x00293E2C File Offset: 0x0029202C
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FWaterBallInteractor._ScriptStructPtr != 0) ? FWaterBallInteractor._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroRenderingRuntimeBPPlugin.WaterBallInteractor", ref FWaterBallInteractor._ScriptStructPtr);
		}

		// Token: 0x17007148 RID: 29000
		// (get) Token: 0x0601C057 RID: 114775 RVA: 0x00293E50 File Offset: 0x00292050
		// (set) Token: 0x0601C058 RID: 114776 RVA: 0x00293E64 File Offset: 0x00292064
		public unsafe FVectorDouble P0
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FWaterBallInteractor.__PropertyOffset_P0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FWaterBallInteractor.__PropertyOffset_P0) = value;
			}
		}

		// Token: 0x17007149 RID: 29001
		// (get) Token: 0x0601C059 RID: 114777 RVA: 0x00293E79 File Offset: 0x00292079
		// (set) Token: 0x0601C05A RID: 114778 RVA: 0x00293E8D File Offset: 0x0029208D
		public unsafe FVectorDouble P1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FWaterBallInteractor.__PropertyOffset_P1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FWaterBallInteractor.__PropertyOffset_P1) = value;
			}
		}

		// Token: 0x1700714A RID: 29002
		// (get) Token: 0x0601C05B RID: 114779 RVA: 0x00293EA2 File Offset: 0x002920A2
		// (set) Token: 0x0601C05C RID: 114780 RVA: 0x00293EB2 File Offset: 0x002920B2
		public unsafe float Radius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FWaterBallInteractor.__PropertyOffset_Radius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FWaterBallInteractor.__PropertyOffset_Radius) = value;
			}
		}

		// Token: 0x1700714B RID: 29003
		// (get) Token: 0x0601C05D RID: 114781 RVA: 0x00293EC3 File Offset: 0x002920C3
		// (set) Token: 0x0601C05E RID: 114782 RVA: 0x00293ED3 File Offset: 0x002920D3
		public unsafe float Strength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FWaterBallInteractor.__PropertyOffset_Strength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FWaterBallInteractor.__PropertyOffset_Strength) = value;
			}
		}

		// Token: 0x1700714C RID: 29004
		// (get) Token: 0x0601C05F RID: 114783 RVA: 0x00293EE4 File Offset: 0x002920E4
		// (set) Token: 0x0601C060 RID: 114784 RVA: 0x00293EF4 File Offset: 0x002920F4
		public unsafe bool bProjectToShell
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FWaterBallInteractor.__PropertyOffset_bProjectToShell) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FWaterBallInteractor.__PropertyOffset_bProjectToShell) = (value ? 1 : 0);
			}
		}

		// Token: 0x0601C061 RID: 114785 RVA: 0x00293F05 File Offset: 0x00292105
		public FWaterBallInteractor()
		{
		}

		// Token: 0x0601C062 RID: 114786 RVA: 0x00293F0D File Offset: 0x0029210D
		public FWaterBallInteractor(FVectorDouble P0, FVectorDouble P1, float Radius, float Strength, bool bProjectToShell)
		{
			this.P0 = P0;
			this.P1 = P1;
			this.Radius = Radius;
			this.Strength = Strength;
			this.bProjectToShell = bProjectToShell;
		}

		// Token: 0x0601C063 RID: 114787 RVA: 0x00293F3A File Offset: 0x0029213A
		protected override IntPtr GetUStructPtr()
		{
			return FWaterBallInteractor.StaticStruct();
		}

		// Token: 0x0601C064 RID: 114788 RVA: 0x00293F46 File Offset: 0x00292146
		[NullableContext(2)]
		public FWaterBallInteractor(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601C065 RID: 114789 RVA: 0x00293F50 File Offset: 0x00292150
		public FWaterBallInteractor(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601C066 RID: 114790 RVA: 0x00293F5B File Offset: 0x0029215B
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FWaterBallInteractor(Pointer, false, true);
		}

		// Token: 0x0601C067 RID: 114791 RVA: 0x00293F65 File Offset: 0x00292165
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FWaterBallInteractor(Pointer, MemoryOwner);
		}

		// Token: 0x0400F0D3 RID: 61651
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.WaterBallInteractor";

		// Token: 0x0400F0D4 RID: 61652
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400F0D5 RID: 61653
		internal static int __PropertyOffset_P0;

		// Token: 0x0400F0D6 RID: 61654
		internal static int __PropertyOffset_P1;

		// Token: 0x0400F0D7 RID: 61655
		internal static int __PropertyOffset_Radius;

		// Token: 0x0400F0D8 RID: 61656
		internal static int __PropertyOffset_Strength;

		// Token: 0x0400F0D9 RID: 61657
		internal static int __PropertyOffset_bProjectToShell;
	}
}
