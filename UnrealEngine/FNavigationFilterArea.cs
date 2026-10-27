using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200248C RID: 9356
	[UnrealObjectPath("/Script/NavigationSystem.NavigationFilterArea")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FNavigationFilterArea : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06022FD5 RID: 143317 RVA: 0x0033BB09 File Offset: 0x00339D09
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FNavigationFilterArea._ScriptStructPtr != 0) ? FNavigationFilterArea._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/NavigationSystem.NavigationFilterArea", ref FNavigationFilterArea._ScriptStructPtr);
		}

		// Token: 0x17008667 RID: 34407
		// (get) Token: 0x06022FD6 RID: 143318 RVA: 0x0033BB2D File Offset: 0x00339D2D
		// (set) Token: 0x06022FD7 RID: 143319 RVA: 0x0033BB41 File Offset: 0x00339D41
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<UNavArea> AreaClass
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)FNavigationFilterArea.__PropertyOffset_AreaClass);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)FNavigationFilterArea.__PropertyOffset_AreaClass) = value;
			}
		}

		// Token: 0x17008668 RID: 34408
		// (get) Token: 0x06022FD8 RID: 143320 RVA: 0x0033BB56 File Offset: 0x00339D56
		// (set) Token: 0x06022FD9 RID: 143321 RVA: 0x0033BB66 File Offset: 0x00339D66
		public unsafe float TravelCostOverride
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNavigationFilterArea.__PropertyOffset_TravelCostOverride);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNavigationFilterArea.__PropertyOffset_TravelCostOverride) = value;
			}
		}

		// Token: 0x17008669 RID: 34409
		// (get) Token: 0x06022FDA RID: 143322 RVA: 0x0033BB77 File Offset: 0x00339D77
		// (set) Token: 0x06022FDB RID: 143323 RVA: 0x0033BB87 File Offset: 0x00339D87
		public unsafe float EnteringCostOverride
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNavigationFilterArea.__PropertyOffset_EnteringCostOverride);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNavigationFilterArea.__PropertyOffset_EnteringCostOverride) = value;
			}
		}

		// Token: 0x1700866A RID: 34410
		// (get) Token: 0x06022FDC RID: 143324 RVA: 0x0033BB98 File Offset: 0x00339D98
		// (set) Token: 0x06022FDD RID: 143325 RVA: 0x0033BBB1 File Offset: 0x00339DB1
		public unsafe bool bIsExcluded
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FNavigationFilterArea.__PropertyOffset_bIsExcluded) & FNavigationFilterArea.__PropertyMask_bIsExcluded) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FNavigationFilterArea.__PropertyOffset_bIsExcluded) = ((*(base.NativePtr + (IntPtr)FNavigationFilterArea.__PropertyOffset_bIsExcluded) & ~FNavigationFilterArea.__PropertyMask_bIsExcluded) | (value ? FNavigationFilterArea.__PropertyMask_bIsExcluded : 0));
			}
		}

		// Token: 0x1700866B RID: 34411
		// (get) Token: 0x06022FDE RID: 143326 RVA: 0x0033BBE1 File Offset: 0x00339DE1
		// (set) Token: 0x06022FDF RID: 143327 RVA: 0x0033BBFA File Offset: 0x00339DFA
		public unsafe bool bOverrideTravelCost
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FNavigationFilterArea.__PropertyOffset_bOverrideTravelCost) & FNavigationFilterArea.__PropertyMask_bOverrideTravelCost) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FNavigationFilterArea.__PropertyOffset_bOverrideTravelCost) = ((*(base.NativePtr + (IntPtr)FNavigationFilterArea.__PropertyOffset_bOverrideTravelCost) & ~FNavigationFilterArea.__PropertyMask_bOverrideTravelCost) | (value ? FNavigationFilterArea.__PropertyMask_bOverrideTravelCost : 0));
			}
		}

		// Token: 0x1700866C RID: 34412
		// (get) Token: 0x06022FE0 RID: 143328 RVA: 0x0033BC2A File Offset: 0x00339E2A
		// (set) Token: 0x06022FE1 RID: 143329 RVA: 0x0033BC43 File Offset: 0x00339E43
		public unsafe bool bOverrideEnteringCost
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FNavigationFilterArea.__PropertyOffset_bOverrideEnteringCost) & FNavigationFilterArea.__PropertyMask_bOverrideEnteringCost) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FNavigationFilterArea.__PropertyOffset_bOverrideEnteringCost) = ((*(base.NativePtr + (IntPtr)FNavigationFilterArea.__PropertyOffset_bOverrideEnteringCost) & ~FNavigationFilterArea.__PropertyMask_bOverrideEnteringCost) | (value ? FNavigationFilterArea.__PropertyMask_bOverrideEnteringCost : 0));
			}
		}

		// Token: 0x06022FE2 RID: 143330 RVA: 0x0033BC73 File Offset: 0x00339E73
		public FNavigationFilterArea()
		{
		}

		// Token: 0x06022FE3 RID: 143331 RVA: 0x0033BC7B File Offset: 0x00339E7B
		public FNavigationFilterArea([Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UNavArea> AreaClass, float TravelCostOverride, float EnteringCostOverride, bool bIsExcluded, bool bOverrideTravelCost, bool bOverrideEnteringCost)
		{
			this.AreaClass = AreaClass;
			this.TravelCostOverride = TravelCostOverride;
			this.EnteringCostOverride = EnteringCostOverride;
			this.bIsExcluded = bIsExcluded;
			this.bOverrideTravelCost = bOverrideTravelCost;
			this.bOverrideEnteringCost = bOverrideEnteringCost;
		}

		// Token: 0x06022FE4 RID: 143332 RVA: 0x0033BCB0 File Offset: 0x00339EB0
		protected override IntPtr GetUStructPtr()
		{
			return FNavigationFilterArea.StaticStruct();
		}

		// Token: 0x06022FE5 RID: 143333 RVA: 0x0033BCBC File Offset: 0x00339EBC
		[NullableContext(2)]
		public FNavigationFilterArea(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06022FE6 RID: 143334 RVA: 0x0033BCC6 File Offset: 0x00339EC6
		public FNavigationFilterArea(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06022FE7 RID: 143335 RVA: 0x0033BCD1 File Offset: 0x00339ED1
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FNavigationFilterArea(Pointer, false, true);
		}

		// Token: 0x06022FE8 RID: 143336 RVA: 0x0033BCDB File Offset: 0x00339EDB
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FNavigationFilterArea(Pointer, MemoryOwner);
		}

		// Token: 0x04012AF8 RID: 76536
		[Nullable(1)]
		public const string __ObjectPath = "/Script/NavigationSystem.NavigationFilterArea";

		// Token: 0x04012AF9 RID: 76537
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04012AFA RID: 76538
		internal static int __PropertyOffset_AreaClass;

		// Token: 0x04012AFB RID: 76539
		internal static int __PropertyOffset_TravelCostOverride;

		// Token: 0x04012AFC RID: 76540
		internal static int __PropertyOffset_EnteringCostOverride;

		// Token: 0x04012AFD RID: 76541
		internal static int __PropertyOffset_bIsExcluded;

		// Token: 0x04012AFE RID: 76542
		internal static byte __PropertyMask_bIsExcluded;

		// Token: 0x04012AFF RID: 76543
		internal static int __PropertyOffset_bOverrideTravelCost;

		// Token: 0x04012B00 RID: 76544
		internal static byte __PropertyMask_bOverrideTravelCost;

		// Token: 0x04012B01 RID: 76545
		internal static int __PropertyOffset_bOverrideEnteringCost;

		// Token: 0x04012B02 RID: 76546
		internal static byte __PropertyMask_bOverrideEnteringCost;
	}
}
