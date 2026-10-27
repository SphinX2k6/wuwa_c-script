using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000EDB RID: 3803
	[UnrealObjectPath("/Script/Engine.NavigationLinkBase")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 72)]
	public class FNavigationLinkBase : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600CDE5 RID: 52709 RVA: 0x0012C37C File Offset: 0x0012A57C
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FNavigationLinkBase._ScriptStructPtr != 0) ? FNavigationLinkBase._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.NavigationLinkBase", ref FNavigationLinkBase._ScriptStructPtr);
		}

		// Token: 0x17003073 RID: 12403
		// (get) Token: 0x0600CDE6 RID: 52710 RVA: 0x0012C3A0 File Offset: 0x0012A5A0
		// (set) Token: 0x0600CDE7 RID: 52711 RVA: 0x0012C3B0 File Offset: 0x0012A5B0
		public unsafe float LeftProjectHeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNavigationLinkBase.__PropertyOffset_LeftProjectHeight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNavigationLinkBase.__PropertyOffset_LeftProjectHeight) = value;
			}
		}

		// Token: 0x17003074 RID: 12404
		// (get) Token: 0x0600CDE8 RID: 52712 RVA: 0x0012C3C1 File Offset: 0x0012A5C1
		// (set) Token: 0x0600CDE9 RID: 52713 RVA: 0x0012C3D1 File Offset: 0x0012A5D1
		public unsafe float MaxFallDownLength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNavigationLinkBase.__PropertyOffset_MaxFallDownLength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNavigationLinkBase.__PropertyOffset_MaxFallDownLength) = value;
			}
		}

		// Token: 0x17003075 RID: 12405
		// (get) Token: 0x0600CDEA RID: 52714 RVA: 0x0012C3E2 File Offset: 0x0012A5E2
		// (set) Token: 0x0600CDEB RID: 52715 RVA: 0x0012C3F2 File Offset: 0x0012A5F2
		public unsafe float SnapRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNavigationLinkBase.__PropertyOffset_SnapRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNavigationLinkBase.__PropertyOffset_SnapRadius) = value;
			}
		}

		// Token: 0x17003076 RID: 12406
		// (get) Token: 0x0600CDEC RID: 52716 RVA: 0x0012C403 File Offset: 0x0012A603
		// (set) Token: 0x0600CDED RID: 52717 RVA: 0x0012C413 File Offset: 0x0012A613
		public unsafe float SnapHeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNavigationLinkBase.__PropertyOffset_SnapHeight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNavigationLinkBase.__PropertyOffset_SnapHeight) = value;
			}
		}

		// Token: 0x17003077 RID: 12407
		// (get) Token: 0x0600CDEE RID: 52718 RVA: 0x0012C424 File Offset: 0x0012A624
		// (set) Token: 0x0600CDEF RID: 52719 RVA: 0x0012C467 File Offset: 0x0012A667
		[Nullable(1)]
		public FNavAgentSelector SupportedAgents
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FNavAgentSelector result;
				if ((result = this._SupportedAgents) == null)
				{
					result = (this._SupportedAgents = new FNavAgentSelector(base.NativePtr + (IntPtr)FNavigationLinkBase.__PropertyOffset_SupportedAgents, base.MemoryOwner ?? this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FNavAgentSelector.StaticStruct(), base.NativePtr + (IntPtr)FNavigationLinkBase.__PropertyOffset_SupportedAgents, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003078 RID: 12408
		// (get) Token: 0x0600CDF0 RID: 52720 RVA: 0x0012C488 File Offset: 0x0012A688
		// (set) Token: 0x0600CDF1 RID: 52721 RVA: 0x0012C4A1 File Offset: 0x0012A6A1
		public unsafe bool bSupportsAgent0
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FNavigationLinkBase.__PropertyOffset_bSupportsAgent0) & FNavigationLinkBase.__PropertyMask_bSupportsAgent0) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FNavigationLinkBase.__PropertyOffset_bSupportsAgent0) = ((*(base.NativePtr + (IntPtr)FNavigationLinkBase.__PropertyOffset_bSupportsAgent0) & ~FNavigationLinkBase.__PropertyMask_bSupportsAgent0) | (value ? FNavigationLinkBase.__PropertyMask_bSupportsAgent0 : 0));
			}
		}

		// Token: 0x17003079 RID: 12409
		// (get) Token: 0x0600CDF2 RID: 52722 RVA: 0x0012C4D1 File Offset: 0x0012A6D1
		// (set) Token: 0x0600CDF3 RID: 52723 RVA: 0x0012C4EA File Offset: 0x0012A6EA
		public unsafe bool bSupportsAgent1
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FNavigationLinkBase.__PropertyOffset_bSupportsAgent1) & FNavigationLinkBase.__PropertyMask_bSupportsAgent1) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FNavigationLinkBase.__PropertyOffset_bSupportsAgent1) = ((*(base.NativePtr + (IntPtr)FNavigationLinkBase.__PropertyOffset_bSupportsAgent1) & ~FNavigationLinkBase.__PropertyMask_bSupportsAgent1) | (value ? FNavigationLinkBase.__PropertyMask_bSupportsAgent1 : 0));
			}
		}

		// Token: 0x1700307A RID: 12410
		// (get) Token: 0x0600CDF4 RID: 52724 RVA: 0x0012C51A File Offset: 0x0012A71A
		// (set) Token: 0x0600CDF5 RID: 52725 RVA: 0x0012C533 File Offset: 0x0012A733
		public unsafe bool bSupportsAgent2
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FNavigationLinkBase.__PropertyOffset_bSupportsAgent2) & FNavigationLinkBase.__PropertyMask_bSupportsAgent2) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FNavigationLinkBase.__PropertyOffset_bSupportsAgent2) = ((*(base.NativePtr + (IntPtr)FNavigationLinkBase.__PropertyOffset_bSupportsAgent2) & ~FNavigationLinkBase.__PropertyMask_bSupportsAgent2) | (value ? FNavigationLinkBase.__PropertyMask_bSupportsAgent2 : 0));
			}
		}

		// Token: 0x1700307B RID: 12411
		// (get) Token: 0x0600CDF6 RID: 52726 RVA: 0x0012C563 File Offset: 0x0012A763
		// (set) Token: 0x0600CDF7 RID: 52727 RVA: 0x0012C57C File Offset: 0x0012A77C
		public unsafe bool bSupportsAgent3
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FNavigationLinkBase.__PropertyOffset_bSupportsAgent3) & FNavigationLinkBase.__PropertyMask_bSupportsAgent3) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FNavigationLinkBase.__PropertyOffset_bSupportsAgent3) = ((*(base.NativePtr + (IntPtr)FNavigationLinkBase.__PropertyOffset_bSupportsAgent3) & ~FNavigationLinkBase.__PropertyMask_bSupportsAgent3) | (value ? FNavigationLinkBase.__PropertyMask_bSupportsAgent3 : 0));
			}
		}

		// Token: 0x1700307C RID: 12412
		// (get) Token: 0x0600CDF8 RID: 52728 RVA: 0x0012C5AC File Offset: 0x0012A7AC
		// (set) Token: 0x0600CDF9 RID: 52729 RVA: 0x0012C5C5 File Offset: 0x0012A7C5
		public unsafe bool bSupportsAgent4
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FNavigationLinkBase.__PropertyOffset_bSupportsAgent4) & FNavigationLinkBase.__PropertyMask_bSupportsAgent4) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FNavigationLinkBase.__PropertyOffset_bSupportsAgent4) = ((*(base.NativePtr + (IntPtr)FNavigationLinkBase.__PropertyOffset_bSupportsAgent4) & ~FNavigationLinkBase.__PropertyMask_bSupportsAgent4) | (value ? FNavigationLinkBase.__PropertyMask_bSupportsAgent4 : 0));
			}
		}

		// Token: 0x1700307D RID: 12413
		// (get) Token: 0x0600CDFA RID: 52730 RVA: 0x0012C5F5 File Offset: 0x0012A7F5
		// (set) Token: 0x0600CDFB RID: 52731 RVA: 0x0012C60E File Offset: 0x0012A80E
		public unsafe bool bSupportsAgent5
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FNavigationLinkBase.__PropertyOffset_bSupportsAgent5) & FNavigationLinkBase.__PropertyMask_bSupportsAgent5) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FNavigationLinkBase.__PropertyOffset_bSupportsAgent5) = ((*(base.NativePtr + (IntPtr)FNavigationLinkBase.__PropertyOffset_bSupportsAgent5) & ~FNavigationLinkBase.__PropertyMask_bSupportsAgent5) | (value ? FNavigationLinkBase.__PropertyMask_bSupportsAgent5 : 0));
			}
		}

		// Token: 0x1700307E RID: 12414
		// (get) Token: 0x0600CDFC RID: 52732 RVA: 0x0012C63E File Offset: 0x0012A83E
		// (set) Token: 0x0600CDFD RID: 52733 RVA: 0x0012C657 File Offset: 0x0012A857
		public unsafe bool bSupportsAgent6
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FNavigationLinkBase.__PropertyOffset_bSupportsAgent6) & FNavigationLinkBase.__PropertyMask_bSupportsAgent6) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FNavigationLinkBase.__PropertyOffset_bSupportsAgent6) = ((*(base.NativePtr + (IntPtr)FNavigationLinkBase.__PropertyOffset_bSupportsAgent6) & ~FNavigationLinkBase.__PropertyMask_bSupportsAgent6) | (value ? FNavigationLinkBase.__PropertyMask_bSupportsAgent6 : 0));
			}
		}

		// Token: 0x1700307F RID: 12415
		// (get) Token: 0x0600CDFE RID: 52734 RVA: 0x0012C687 File Offset: 0x0012A887
		// (set) Token: 0x0600CDFF RID: 52735 RVA: 0x0012C6A0 File Offset: 0x0012A8A0
		public unsafe bool bSupportsAgent7
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FNavigationLinkBase.__PropertyOffset_bSupportsAgent7) & FNavigationLinkBase.__PropertyMask_bSupportsAgent7) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FNavigationLinkBase.__PropertyOffset_bSupportsAgent7) = ((*(base.NativePtr + (IntPtr)FNavigationLinkBase.__PropertyOffset_bSupportsAgent7) & ~FNavigationLinkBase.__PropertyMask_bSupportsAgent7) | (value ? FNavigationLinkBase.__PropertyMask_bSupportsAgent7 : 0));
			}
		}

		// Token: 0x17003080 RID: 12416
		// (get) Token: 0x0600CE00 RID: 52736 RVA: 0x0012C6D0 File Offset: 0x0012A8D0
		// (set) Token: 0x0600CE01 RID: 52737 RVA: 0x0012C6E9 File Offset: 0x0012A8E9
		public unsafe bool bSupportsAgent8
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FNavigationLinkBase.__PropertyOffset_bSupportsAgent8) & FNavigationLinkBase.__PropertyMask_bSupportsAgent8) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FNavigationLinkBase.__PropertyOffset_bSupportsAgent8) = ((*(base.NativePtr + (IntPtr)FNavigationLinkBase.__PropertyOffset_bSupportsAgent8) & ~FNavigationLinkBase.__PropertyMask_bSupportsAgent8) | (value ? FNavigationLinkBase.__PropertyMask_bSupportsAgent8 : 0));
			}
		}

		// Token: 0x17003081 RID: 12417
		// (get) Token: 0x0600CE02 RID: 52738 RVA: 0x0012C719 File Offset: 0x0012A919
		// (set) Token: 0x0600CE03 RID: 52739 RVA: 0x0012C732 File Offset: 0x0012A932
		public unsafe bool bSupportsAgent9
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FNavigationLinkBase.__PropertyOffset_bSupportsAgent9) & FNavigationLinkBase.__PropertyMask_bSupportsAgent9) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FNavigationLinkBase.__PropertyOffset_bSupportsAgent9) = ((*(base.NativePtr + (IntPtr)FNavigationLinkBase.__PropertyOffset_bSupportsAgent9) & ~FNavigationLinkBase.__PropertyMask_bSupportsAgent9) | (value ? FNavigationLinkBase.__PropertyMask_bSupportsAgent9 : 0));
			}
		}

		// Token: 0x17003082 RID: 12418
		// (get) Token: 0x0600CE04 RID: 52740 RVA: 0x0012C762 File Offset: 0x0012A962
		// (set) Token: 0x0600CE05 RID: 52741 RVA: 0x0012C77B File Offset: 0x0012A97B
		public unsafe bool bSupportsAgent10
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FNavigationLinkBase.__PropertyOffset_bSupportsAgent10) & FNavigationLinkBase.__PropertyMask_bSupportsAgent10) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FNavigationLinkBase.__PropertyOffset_bSupportsAgent10) = ((*(base.NativePtr + (IntPtr)FNavigationLinkBase.__PropertyOffset_bSupportsAgent10) & ~FNavigationLinkBase.__PropertyMask_bSupportsAgent10) | (value ? FNavigationLinkBase.__PropertyMask_bSupportsAgent10 : 0));
			}
		}

		// Token: 0x17003083 RID: 12419
		// (get) Token: 0x0600CE06 RID: 52742 RVA: 0x0012C7AB File Offset: 0x0012A9AB
		// (set) Token: 0x0600CE07 RID: 52743 RVA: 0x0012C7C4 File Offset: 0x0012A9C4
		public unsafe bool bSupportsAgent11
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FNavigationLinkBase.__PropertyOffset_bSupportsAgent11) & FNavigationLinkBase.__PropertyMask_bSupportsAgent11) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FNavigationLinkBase.__PropertyOffset_bSupportsAgent11) = ((*(base.NativePtr + (IntPtr)FNavigationLinkBase.__PropertyOffset_bSupportsAgent11) & ~FNavigationLinkBase.__PropertyMask_bSupportsAgent11) | (value ? FNavigationLinkBase.__PropertyMask_bSupportsAgent11 : 0));
			}
		}

		// Token: 0x17003084 RID: 12420
		// (get) Token: 0x0600CE08 RID: 52744 RVA: 0x0012C7F4 File Offset: 0x0012A9F4
		// (set) Token: 0x0600CE09 RID: 52745 RVA: 0x0012C80D File Offset: 0x0012AA0D
		public unsafe bool bSupportsAgent12
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FNavigationLinkBase.__PropertyOffset_bSupportsAgent12) & FNavigationLinkBase.__PropertyMask_bSupportsAgent12) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FNavigationLinkBase.__PropertyOffset_bSupportsAgent12) = ((*(base.NativePtr + (IntPtr)FNavigationLinkBase.__PropertyOffset_bSupportsAgent12) & ~FNavigationLinkBase.__PropertyMask_bSupportsAgent12) | (value ? FNavigationLinkBase.__PropertyMask_bSupportsAgent12 : 0));
			}
		}

		// Token: 0x17003085 RID: 12421
		// (get) Token: 0x0600CE0A RID: 52746 RVA: 0x0012C83D File Offset: 0x0012AA3D
		// (set) Token: 0x0600CE0B RID: 52747 RVA: 0x0012C856 File Offset: 0x0012AA56
		public unsafe bool bSupportsAgent13
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FNavigationLinkBase.__PropertyOffset_bSupportsAgent13) & FNavigationLinkBase.__PropertyMask_bSupportsAgent13) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FNavigationLinkBase.__PropertyOffset_bSupportsAgent13) = ((*(base.NativePtr + (IntPtr)FNavigationLinkBase.__PropertyOffset_bSupportsAgent13) & ~FNavigationLinkBase.__PropertyMask_bSupportsAgent13) | (value ? FNavigationLinkBase.__PropertyMask_bSupportsAgent13 : 0));
			}
		}

		// Token: 0x17003086 RID: 12422
		// (get) Token: 0x0600CE0C RID: 52748 RVA: 0x0012C886 File Offset: 0x0012AA86
		// (set) Token: 0x0600CE0D RID: 52749 RVA: 0x0012C89F File Offset: 0x0012AA9F
		public unsafe bool bSupportsAgent14
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FNavigationLinkBase.__PropertyOffset_bSupportsAgent14) & FNavigationLinkBase.__PropertyMask_bSupportsAgent14) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FNavigationLinkBase.__PropertyOffset_bSupportsAgent14) = ((*(base.NativePtr + (IntPtr)FNavigationLinkBase.__PropertyOffset_bSupportsAgent14) & ~FNavigationLinkBase.__PropertyMask_bSupportsAgent14) | (value ? FNavigationLinkBase.__PropertyMask_bSupportsAgent14 : 0));
			}
		}

		// Token: 0x17003087 RID: 12423
		// (get) Token: 0x0600CE0E RID: 52750 RVA: 0x0012C8CF File Offset: 0x0012AACF
		// (set) Token: 0x0600CE0F RID: 52751 RVA: 0x0012C8E8 File Offset: 0x0012AAE8
		public unsafe bool bSupportsAgent15
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FNavigationLinkBase.__PropertyOffset_bSupportsAgent15) & FNavigationLinkBase.__PropertyMask_bSupportsAgent15) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FNavigationLinkBase.__PropertyOffset_bSupportsAgent15) = ((*(base.NativePtr + (IntPtr)FNavigationLinkBase.__PropertyOffset_bSupportsAgent15) & ~FNavigationLinkBase.__PropertyMask_bSupportsAgent15) | (value ? FNavigationLinkBase.__PropertyMask_bSupportsAgent15 : 0));
			}
		}

		// Token: 0x17003088 RID: 12424
		// (get) Token: 0x0600CE10 RID: 52752 RVA: 0x0012C918 File Offset: 0x0012AB18
		// (set) Token: 0x0600CE11 RID: 52753 RVA: 0x0012C92C File Offset: 0x0012AB2C
		public unsafe TEnumAsByte<ENavLinkDirection> Direction
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNavigationLinkBase.__PropertyOffset_Direction);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNavigationLinkBase.__PropertyOffset_Direction) = value;
			}
		}

		// Token: 0x17003089 RID: 12425
		// (get) Token: 0x0600CE12 RID: 52754 RVA: 0x0012C941 File Offset: 0x0012AB41
		// (set) Token: 0x0600CE13 RID: 52755 RVA: 0x0012C95A File Offset: 0x0012AB5A
		public unsafe bool bUseSnapHeight
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FNavigationLinkBase.__PropertyOffset_bUseSnapHeight) & FNavigationLinkBase.__PropertyMask_bUseSnapHeight) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FNavigationLinkBase.__PropertyOffset_bUseSnapHeight) = ((*(base.NativePtr + (IntPtr)FNavigationLinkBase.__PropertyOffset_bUseSnapHeight) & ~FNavigationLinkBase.__PropertyMask_bUseSnapHeight) | (value ? FNavigationLinkBase.__PropertyMask_bUseSnapHeight : 0));
			}
		}

		// Token: 0x1700308A RID: 12426
		// (get) Token: 0x0600CE14 RID: 52756 RVA: 0x0012C98A File Offset: 0x0012AB8A
		// (set) Token: 0x0600CE15 RID: 52757 RVA: 0x0012C9A3 File Offset: 0x0012ABA3
		public unsafe bool bSnapToCheapestArea
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FNavigationLinkBase.__PropertyOffset_bSnapToCheapestArea) & FNavigationLinkBase.__PropertyMask_bSnapToCheapestArea) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FNavigationLinkBase.__PropertyOffset_bSnapToCheapestArea) = ((*(base.NativePtr + (IntPtr)FNavigationLinkBase.__PropertyOffset_bSnapToCheapestArea) & ~FNavigationLinkBase.__PropertyMask_bSnapToCheapestArea) | (value ? FNavigationLinkBase.__PropertyMask_bSnapToCheapestArea : 0));
			}
		}

		// Token: 0x1700308B RID: 12427
		// (get) Token: 0x0600CE16 RID: 52758 RVA: 0x0012C9D3 File Offset: 0x0012ABD3
		// (set) Token: 0x0600CE17 RID: 52759 RVA: 0x0012C9EC File Offset: 0x0012ABEC
		public unsafe bool bCustomFlag0
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FNavigationLinkBase.__PropertyOffset_bCustomFlag0) & FNavigationLinkBase.__PropertyMask_bCustomFlag0) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FNavigationLinkBase.__PropertyOffset_bCustomFlag0) = ((*(base.NativePtr + (IntPtr)FNavigationLinkBase.__PropertyOffset_bCustomFlag0) & ~FNavigationLinkBase.__PropertyMask_bCustomFlag0) | (value ? FNavigationLinkBase.__PropertyMask_bCustomFlag0 : 0));
			}
		}

		// Token: 0x1700308C RID: 12428
		// (get) Token: 0x0600CE18 RID: 52760 RVA: 0x0012CA1C File Offset: 0x0012AC1C
		// (set) Token: 0x0600CE19 RID: 52761 RVA: 0x0012CA35 File Offset: 0x0012AC35
		public unsafe bool bCustomFlag1
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FNavigationLinkBase.__PropertyOffset_bCustomFlag1) & FNavigationLinkBase.__PropertyMask_bCustomFlag1) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FNavigationLinkBase.__PropertyOffset_bCustomFlag1) = ((*(base.NativePtr + (IntPtr)FNavigationLinkBase.__PropertyOffset_bCustomFlag1) & ~FNavigationLinkBase.__PropertyMask_bCustomFlag1) | (value ? FNavigationLinkBase.__PropertyMask_bCustomFlag1 : 0));
			}
		}

		// Token: 0x1700308D RID: 12429
		// (get) Token: 0x0600CE1A RID: 52762 RVA: 0x0012CA65 File Offset: 0x0012AC65
		// (set) Token: 0x0600CE1B RID: 52763 RVA: 0x0012CA7E File Offset: 0x0012AC7E
		public unsafe bool bCustomFlag2
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FNavigationLinkBase.__PropertyOffset_bCustomFlag2) & FNavigationLinkBase.__PropertyMask_bCustomFlag2) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FNavigationLinkBase.__PropertyOffset_bCustomFlag2) = ((*(base.NativePtr + (IntPtr)FNavigationLinkBase.__PropertyOffset_bCustomFlag2) & ~FNavigationLinkBase.__PropertyMask_bCustomFlag2) | (value ? FNavigationLinkBase.__PropertyMask_bCustomFlag2 : 0));
			}
		}

		// Token: 0x1700308E RID: 12430
		// (get) Token: 0x0600CE1C RID: 52764 RVA: 0x0012CAAE File Offset: 0x0012ACAE
		// (set) Token: 0x0600CE1D RID: 52765 RVA: 0x0012CAC7 File Offset: 0x0012ACC7
		public unsafe bool bCustomFlag3
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FNavigationLinkBase.__PropertyOffset_bCustomFlag3) & FNavigationLinkBase.__PropertyMask_bCustomFlag3) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FNavigationLinkBase.__PropertyOffset_bCustomFlag3) = ((*(base.NativePtr + (IntPtr)FNavigationLinkBase.__PropertyOffset_bCustomFlag3) & ~FNavigationLinkBase.__PropertyMask_bCustomFlag3) | (value ? FNavigationLinkBase.__PropertyMask_bCustomFlag3 : 0));
			}
		}

		// Token: 0x1700308F RID: 12431
		// (get) Token: 0x0600CE1E RID: 52766 RVA: 0x0012CAF7 File Offset: 0x0012ACF7
		// (set) Token: 0x0600CE1F RID: 52767 RVA: 0x0012CB10 File Offset: 0x0012AD10
		public unsafe bool bCustomFlag4
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FNavigationLinkBase.__PropertyOffset_bCustomFlag4) & FNavigationLinkBase.__PropertyMask_bCustomFlag4) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FNavigationLinkBase.__PropertyOffset_bCustomFlag4) = ((*(base.NativePtr + (IntPtr)FNavigationLinkBase.__PropertyOffset_bCustomFlag4) & ~FNavigationLinkBase.__PropertyMask_bCustomFlag4) | (value ? FNavigationLinkBase.__PropertyMask_bCustomFlag4 : 0));
			}
		}

		// Token: 0x17003090 RID: 12432
		// (get) Token: 0x0600CE20 RID: 52768 RVA: 0x0012CB40 File Offset: 0x0012AD40
		// (set) Token: 0x0600CE21 RID: 52769 RVA: 0x0012CB59 File Offset: 0x0012AD59
		public unsafe bool bCustomFlag5
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FNavigationLinkBase.__PropertyOffset_bCustomFlag5) & FNavigationLinkBase.__PropertyMask_bCustomFlag5) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FNavigationLinkBase.__PropertyOffset_bCustomFlag5) = ((*(base.NativePtr + (IntPtr)FNavigationLinkBase.__PropertyOffset_bCustomFlag5) & ~FNavigationLinkBase.__PropertyMask_bCustomFlag5) | (value ? FNavigationLinkBase.__PropertyMask_bCustomFlag5 : 0));
			}
		}

		// Token: 0x17003091 RID: 12433
		// (get) Token: 0x0600CE22 RID: 52770 RVA: 0x0012CB89 File Offset: 0x0012AD89
		// (set) Token: 0x0600CE23 RID: 52771 RVA: 0x0012CBA2 File Offset: 0x0012ADA2
		public unsafe bool bCustomFlag6
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FNavigationLinkBase.__PropertyOffset_bCustomFlag6) & FNavigationLinkBase.__PropertyMask_bCustomFlag6) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FNavigationLinkBase.__PropertyOffset_bCustomFlag6) = ((*(base.NativePtr + (IntPtr)FNavigationLinkBase.__PropertyOffset_bCustomFlag6) & ~FNavigationLinkBase.__PropertyMask_bCustomFlag6) | (value ? FNavigationLinkBase.__PropertyMask_bCustomFlag6 : 0));
			}
		}

		// Token: 0x17003092 RID: 12434
		// (get) Token: 0x0600CE24 RID: 52772 RVA: 0x0012CBD2 File Offset: 0x0012ADD2
		// (set) Token: 0x0600CE25 RID: 52773 RVA: 0x0012CBEB File Offset: 0x0012ADEB
		public unsafe bool bCustomFlag7
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FNavigationLinkBase.__PropertyOffset_bCustomFlag7) & FNavigationLinkBase.__PropertyMask_bCustomFlag7) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FNavigationLinkBase.__PropertyOffset_bCustomFlag7) = ((*(base.NativePtr + (IntPtr)FNavigationLinkBase.__PropertyOffset_bCustomFlag7) & ~FNavigationLinkBase.__PropertyMask_bCustomFlag7) | (value ? FNavigationLinkBase.__PropertyMask_bCustomFlag7 : 0));
			}
		}

		// Token: 0x17003093 RID: 12435
		// (get) Token: 0x0600CE26 RID: 52774 RVA: 0x0012CC1B File Offset: 0x0012AE1B
		// (set) Token: 0x0600CE27 RID: 52775 RVA: 0x0012CC2F File Offset: 0x0012AE2F
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<UNavAreaBase> AreaClass
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)FNavigationLinkBase.__PropertyOffset_AreaClass);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)FNavigationLinkBase.__PropertyOffset_AreaClass) = value;
			}
		}

		// Token: 0x0600CE28 RID: 52776 RVA: 0x0012CC44 File Offset: 0x0012AE44
		public FNavigationLinkBase()
		{
		}

		// Token: 0x0600CE29 RID: 52777 RVA: 0x0012CC4C File Offset: 0x0012AE4C
		[NullableContext(1)]
		public FNavigationLinkBase(float LeftProjectHeight, float MaxFallDownLength, float SnapRadius, float SnapHeight, FNavAgentSelector SupportedAgents, bool bSupportsAgent0, bool bSupportsAgent1, bool bSupportsAgent2, bool bSupportsAgent3, bool bSupportsAgent4, bool bSupportsAgent5, bool bSupportsAgent6, bool bSupportsAgent7, bool bSupportsAgent8, bool bSupportsAgent9, bool bSupportsAgent10, bool bSupportsAgent11, bool bSupportsAgent12, bool bSupportsAgent13, bool bSupportsAgent14, bool bSupportsAgent15, string Description, [Nullable(0)] TEnumAsByte<ENavLinkDirection> Direction, bool bUseSnapHeight, bool bSnapToCheapestArea, bool bCustomFlag0, bool bCustomFlag1, bool bCustomFlag2, bool bCustomFlag3, bool bCustomFlag4, bool bCustomFlag5, bool bCustomFlag6, bool bCustomFlag7, [Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UNavAreaBase> AreaClass)
		{
			this.LeftProjectHeight = LeftProjectHeight;
			this.MaxFallDownLength = MaxFallDownLength;
			this.SnapRadius = SnapRadius;
			this.SnapHeight = SnapHeight;
			this.SupportedAgents = SupportedAgents;
			this.bSupportsAgent0 = bSupportsAgent0;
			this.bSupportsAgent1 = bSupportsAgent1;
			this.bSupportsAgent2 = bSupportsAgent2;
			this.bSupportsAgent3 = bSupportsAgent3;
			this.bSupportsAgent4 = bSupportsAgent4;
			this.bSupportsAgent5 = bSupportsAgent5;
			this.bSupportsAgent6 = bSupportsAgent6;
			this.bSupportsAgent7 = bSupportsAgent7;
			this.bSupportsAgent8 = bSupportsAgent8;
			this.bSupportsAgent9 = bSupportsAgent9;
			this.bSupportsAgent10 = bSupportsAgent10;
			this.bSupportsAgent11 = bSupportsAgent11;
			this.bSupportsAgent12 = bSupportsAgent12;
			this.bSupportsAgent13 = bSupportsAgent13;
			this.bSupportsAgent14 = bSupportsAgent14;
			this.bSupportsAgent15 = bSupportsAgent15;
			this.Direction = Direction;
			this.bUseSnapHeight = bUseSnapHeight;
			this.bSnapToCheapestArea = bSnapToCheapestArea;
			this.bCustomFlag0 = bCustomFlag0;
			this.bCustomFlag1 = bCustomFlag1;
			this.bCustomFlag2 = bCustomFlag2;
			this.bCustomFlag3 = bCustomFlag3;
			this.bCustomFlag4 = bCustomFlag4;
			this.bCustomFlag5 = bCustomFlag5;
			this.bCustomFlag6 = bCustomFlag6;
			this.bCustomFlag7 = bCustomFlag7;
			this.AreaClass = AreaClass;
		}

		// Token: 0x0600CE2A RID: 52778 RVA: 0x0012CD64 File Offset: 0x0012AF64
		protected override IntPtr GetUStructPtr()
		{
			return FNavigationLinkBase.StaticStruct();
		}

		// Token: 0x0600CE2B RID: 52779 RVA: 0x0012CD70 File Offset: 0x0012AF70
		[NullableContext(2)]
		public FNavigationLinkBase(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600CE2C RID: 52780 RVA: 0x0012CD7A File Offset: 0x0012AF7A
		public FNavigationLinkBase(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600CE2D RID: 52781 RVA: 0x0012CD85 File Offset: 0x0012AF85
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FNavigationLinkBase(Pointer, false, true);
		}

		// Token: 0x0600CE2E RID: 52782 RVA: 0x0012CD8F File Offset: 0x0012AF8F
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FNavigationLinkBase(Pointer, MemoryOwner);
		}

		// Token: 0x04006EED RID: 28397
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.NavigationLinkBase";

		// Token: 0x04006EEE RID: 28398
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04006EEF RID: 28399
		internal static int __PropertyOffset_LeftProjectHeight;

		// Token: 0x04006EF0 RID: 28400
		internal static int __PropertyOffset_MaxFallDownLength;

		// Token: 0x04006EF1 RID: 28401
		internal static int __PropertyOffset_SnapRadius;

		// Token: 0x04006EF2 RID: 28402
		internal static int __PropertyOffset_SnapHeight;

		// Token: 0x04006EF3 RID: 28403
		internal static int __PropertyOffset_SupportedAgents;

		// Token: 0x04006EF4 RID: 28404
		[Nullable(2)]
		private FNavAgentSelector _SupportedAgents;

		// Token: 0x04006EF5 RID: 28405
		internal static int __PropertyOffset_bSupportsAgent0;

		// Token: 0x04006EF6 RID: 28406
		internal static byte __PropertyMask_bSupportsAgent0;

		// Token: 0x04006EF7 RID: 28407
		internal static int __PropertyOffset_bSupportsAgent1;

		// Token: 0x04006EF8 RID: 28408
		internal static byte __PropertyMask_bSupportsAgent1;

		// Token: 0x04006EF9 RID: 28409
		internal static int __PropertyOffset_bSupportsAgent2;

		// Token: 0x04006EFA RID: 28410
		internal static byte __PropertyMask_bSupportsAgent2;

		// Token: 0x04006EFB RID: 28411
		internal static int __PropertyOffset_bSupportsAgent3;

		// Token: 0x04006EFC RID: 28412
		internal static byte __PropertyMask_bSupportsAgent3;

		// Token: 0x04006EFD RID: 28413
		internal static int __PropertyOffset_bSupportsAgent4;

		// Token: 0x04006EFE RID: 28414
		internal static byte __PropertyMask_bSupportsAgent4;

		// Token: 0x04006EFF RID: 28415
		internal static int __PropertyOffset_bSupportsAgent5;

		// Token: 0x04006F00 RID: 28416
		internal static byte __PropertyMask_bSupportsAgent5;

		// Token: 0x04006F01 RID: 28417
		internal static int __PropertyOffset_bSupportsAgent6;

		// Token: 0x04006F02 RID: 28418
		internal static byte __PropertyMask_bSupportsAgent6;

		// Token: 0x04006F03 RID: 28419
		internal static int __PropertyOffset_bSupportsAgent7;

		// Token: 0x04006F04 RID: 28420
		internal static byte __PropertyMask_bSupportsAgent7;

		// Token: 0x04006F05 RID: 28421
		internal static int __PropertyOffset_bSupportsAgent8;

		// Token: 0x04006F06 RID: 28422
		internal static byte __PropertyMask_bSupportsAgent8;

		// Token: 0x04006F07 RID: 28423
		internal static int __PropertyOffset_bSupportsAgent9;

		// Token: 0x04006F08 RID: 28424
		internal static byte __PropertyMask_bSupportsAgent9;

		// Token: 0x04006F09 RID: 28425
		internal static int __PropertyOffset_bSupportsAgent10;

		// Token: 0x04006F0A RID: 28426
		internal static byte __PropertyMask_bSupportsAgent10;

		// Token: 0x04006F0B RID: 28427
		internal static int __PropertyOffset_bSupportsAgent11;

		// Token: 0x04006F0C RID: 28428
		internal static byte __PropertyMask_bSupportsAgent11;

		// Token: 0x04006F0D RID: 28429
		internal static int __PropertyOffset_bSupportsAgent12;

		// Token: 0x04006F0E RID: 28430
		internal static byte __PropertyMask_bSupportsAgent12;

		// Token: 0x04006F0F RID: 28431
		internal static int __PropertyOffset_bSupportsAgent13;

		// Token: 0x04006F10 RID: 28432
		internal static byte __PropertyMask_bSupportsAgent13;

		// Token: 0x04006F11 RID: 28433
		internal static int __PropertyOffset_bSupportsAgent14;

		// Token: 0x04006F12 RID: 28434
		internal static byte __PropertyMask_bSupportsAgent14;

		// Token: 0x04006F13 RID: 28435
		internal static int __PropertyOffset_bSupportsAgent15;

		// Token: 0x04006F14 RID: 28436
		internal static byte __PropertyMask_bSupportsAgent15;

		// Token: 0x04006F15 RID: 28437
		internal static int __PropertyOffset_Direction;

		// Token: 0x04006F16 RID: 28438
		internal static int __PropertyOffset_bUseSnapHeight;

		// Token: 0x04006F17 RID: 28439
		internal static byte __PropertyMask_bUseSnapHeight;

		// Token: 0x04006F18 RID: 28440
		internal static int __PropertyOffset_bSnapToCheapestArea;

		// Token: 0x04006F19 RID: 28441
		internal static byte __PropertyMask_bSnapToCheapestArea;

		// Token: 0x04006F1A RID: 28442
		internal static int __PropertyOffset_bCustomFlag0;

		// Token: 0x04006F1B RID: 28443
		internal static byte __PropertyMask_bCustomFlag0;

		// Token: 0x04006F1C RID: 28444
		internal static int __PropertyOffset_bCustomFlag1;

		// Token: 0x04006F1D RID: 28445
		internal static byte __PropertyMask_bCustomFlag1;

		// Token: 0x04006F1E RID: 28446
		internal static int __PropertyOffset_bCustomFlag2;

		// Token: 0x04006F1F RID: 28447
		internal static byte __PropertyMask_bCustomFlag2;

		// Token: 0x04006F20 RID: 28448
		internal static int __PropertyOffset_bCustomFlag3;

		// Token: 0x04006F21 RID: 28449
		internal static byte __PropertyMask_bCustomFlag3;

		// Token: 0x04006F22 RID: 28450
		internal static int __PropertyOffset_bCustomFlag4;

		// Token: 0x04006F23 RID: 28451
		internal static byte __PropertyMask_bCustomFlag4;

		// Token: 0x04006F24 RID: 28452
		internal static int __PropertyOffset_bCustomFlag5;

		// Token: 0x04006F25 RID: 28453
		internal static byte __PropertyMask_bCustomFlag5;

		// Token: 0x04006F26 RID: 28454
		internal static int __PropertyOffset_bCustomFlag6;

		// Token: 0x04006F27 RID: 28455
		internal static byte __PropertyMask_bCustomFlag6;

		// Token: 0x04006F28 RID: 28456
		internal static int __PropertyOffset_bCustomFlag7;

		// Token: 0x04006F29 RID: 28457
		internal static byte __PropertyMask_bCustomFlag7;

		// Token: 0x04006F2A RID: 28458
		internal static int __PropertyOffset_AreaClass;
	}
}
