using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001169 RID: 4457
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.SpatialHashStreamingGrid")]
	[UnrealStructLayout(216, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 216)]
	public class FSpatialHashStreamingGrid : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601047A RID: 66682 RVA: 0x0017FB99 File Offset: 0x0017DD99
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSpatialHashStreamingGrid._ScriptStructPtr != 0) ? FSpatialHashStreamingGrid._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.SpatialHashStreamingGrid", ref FSpatialHashStreamingGrid._ScriptStructPtr);
		}

		// Token: 0x17003FC2 RID: 16322
		// (get) Token: 0x0601047B RID: 66683 RVA: 0x0017FBBD File Offset: 0x0017DDBD
		// (set) Token: 0x0601047C RID: 66684 RVA: 0x0017FBD1 File Offset: 0x0017DDD1
		public unsafe FName GridName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSpatialHashStreamingGrid.__PropertyOffset_GridName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSpatialHashStreamingGrid.__PropertyOffset_GridName) = value;
			}
		}

		// Token: 0x17003FC3 RID: 16323
		// (get) Token: 0x0601047D RID: 66685 RVA: 0x0017FBE6 File Offset: 0x0017DDE6
		// (set) Token: 0x0601047E RID: 66686 RVA: 0x0017FBFA File Offset: 0x0017DDFA
		public unsafe FVector Origin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSpatialHashStreamingGrid.__PropertyOffset_Origin);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSpatialHashStreamingGrid.__PropertyOffset_Origin) = value;
			}
		}

		// Token: 0x17003FC4 RID: 16324
		// (get) Token: 0x0601047F RID: 66687 RVA: 0x0017FC0F File Offset: 0x0017DE0F
		// (set) Token: 0x06010480 RID: 66688 RVA: 0x0017FC1F File Offset: 0x0017DE1F
		public unsafe int CellSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSpatialHashStreamingGrid.__PropertyOffset_CellSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSpatialHashStreamingGrid.__PropertyOffset_CellSize) = value;
			}
		}

		// Token: 0x17003FC5 RID: 16325
		// (get) Token: 0x06010481 RID: 66689 RVA: 0x0017FC30 File Offset: 0x0017DE30
		// (set) Token: 0x06010482 RID: 66690 RVA: 0x0017FC40 File Offset: 0x0017DE40
		public unsafe float LoadingRange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSpatialHashStreamingGrid.__PropertyOffset_LoadingRange);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSpatialHashStreamingGrid.__PropertyOffset_LoadingRange) = value;
			}
		}

		// Token: 0x17003FC6 RID: 16326
		// (get) Token: 0x06010483 RID: 66691 RVA: 0x0017FC51 File Offset: 0x0017DE51
		// (set) Token: 0x06010484 RID: 66692 RVA: 0x0017FC61 File Offset: 0x0017DE61
		public unsafe bool bBlockOnSlowStreaming
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSpatialHashStreamingGrid.__PropertyOffset_bBlockOnSlowStreaming) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSpatialHashStreamingGrid.__PropertyOffset_bBlockOnSlowStreaming) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003FC7 RID: 16327
		// (get) Token: 0x06010485 RID: 66693 RVA: 0x0017FC72 File Offset: 0x0017DE72
		// (set) Token: 0x06010486 RID: 66694 RVA: 0x0017FC86 File Offset: 0x0017DE86
		public unsafe FLinearColor DebugColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSpatialHashStreamingGrid.__PropertyOffset_DebugColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSpatialHashStreamingGrid.__PropertyOffset_DebugColor) = value;
			}
		}

		// Token: 0x17003FC8 RID: 16328
		// (get) Token: 0x06010487 RID: 66695 RVA: 0x0017FC9C File Offset: 0x0017DE9C
		// (set) Token: 0x06010488 RID: 66696 RVA: 0x0017FCDF File Offset: 0x0017DEDF
		public TArray<FSpatialHashStreamingGridLevel> GridLevels
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FSpatialHashStreamingGridLevel> result;
				if ((result = this._GridLevels) == null)
				{
					result = (this._GridLevels = new TArray<FSpatialHashStreamingGridLevel>(base.NativePtr + (IntPtr)FSpatialHashStreamingGrid.__PropertyOffset_GridLevels, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.GridLevels.CopyAssign(value);
			}
		}

		// Token: 0x17003FC9 RID: 16329
		// (get) Token: 0x06010489 RID: 66697 RVA: 0x0017FCED File Offset: 0x0017DEED
		// (set) Token: 0x0601048A RID: 66698 RVA: 0x0017FD01 File Offset: 0x0017DF01
		public unsafe FBox WorldBounds
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSpatialHashStreamingGrid.__PropertyOffset_WorldBounds);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSpatialHashStreamingGrid.__PropertyOffset_WorldBounds) = value;
			}
		}

		// Token: 0x17003FCA RID: 16330
		// (get) Token: 0x0601048B RID: 66699 RVA: 0x0017FD16 File Offset: 0x0017DF16
		// (set) Token: 0x0601048C RID: 66700 RVA: 0x0017FD26 File Offset: 0x0017DF26
		public unsafe bool bClientOnlyVisible
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSpatialHashStreamingGrid.__PropertyOffset_bClientOnlyVisible) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSpatialHashStreamingGrid.__PropertyOffset_bClientOnlyVisible) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003FCB RID: 16331
		// (get) Token: 0x0601048D RID: 66701 RVA: 0x0017FD37 File Offset: 0x0017DF37
		// (set) Token: 0x0601048E RID: 66702 RVA: 0x0017FD47 File Offset: 0x0017DF47
		public unsafe int GridIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSpatialHashStreamingGrid.__PropertyOffset_GridIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSpatialHashStreamingGrid.__PropertyOffset_GridIndex) = value;
			}
		}

		// Token: 0x17003FCC RID: 16332
		// (get) Token: 0x0601048F RID: 66703 RVA: 0x0017FD58 File Offset: 0x0017DF58
		// (set) Token: 0x06010490 RID: 66704 RVA: 0x0017FD9B File Offset: 0x0017DF9B
		public FSpatialHashSettings Settings
		{
			get
			{
				base.FastCheckIsValid();
				FSpatialHashSettings result;
				if ((result = this._Settings) == null)
				{
					result = (this._Settings = new FSpatialHashSettings(base.NativePtr + (IntPtr)FSpatialHashStreamingGrid.__PropertyOffset_Settings, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSpatialHashSettings.StaticStruct(), base.NativePtr + (IntPtr)FSpatialHashStreamingGrid.__PropertyOffset_Settings, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003FCD RID: 16333
		// (get) Token: 0x06010491 RID: 66705 RVA: 0x0017FDBC File Offset: 0x0017DFBC
		// (set) Token: 0x06010492 RID: 66706 RVA: 0x0017FDCC File Offset: 0x0017DFCC
		public unsafe float PcLoadingRangeScalar
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSpatialHashStreamingGrid.__PropertyOffset_PcLoadingRangeScalar);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSpatialHashStreamingGrid.__PropertyOffset_PcLoadingRangeScalar) = value;
			}
		}

		// Token: 0x17003FCE RID: 16334
		// (get) Token: 0x06010493 RID: 66707 RVA: 0x0017FDDD File Offset: 0x0017DFDD
		// (set) Token: 0x06010494 RID: 66708 RVA: 0x0017FDED File Offset: 0x0017DFED
		public unsafe float MobileLoadingRangeScalar
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSpatialHashStreamingGrid.__PropertyOffset_MobileLoadingRangeScalar);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSpatialHashStreamingGrid.__PropertyOffset_MobileLoadingRangeScalar) = value;
			}
		}

		// Token: 0x17003FCF RID: 16335
		// (get) Token: 0x06010495 RID: 66709 RVA: 0x0017FDFE File Offset: 0x0017DFFE
		// (set) Token: 0x06010496 RID: 66710 RVA: 0x0017FE0E File Offset: 0x0017E00E
		public unsafe float PCLoadingRange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSpatialHashStreamingGrid.__PropertyOffset_PCLoadingRange);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSpatialHashStreamingGrid.__PropertyOffset_PCLoadingRange) = value;
			}
		}

		// Token: 0x17003FD0 RID: 16336
		// (get) Token: 0x06010497 RID: 66711 RVA: 0x0017FE1F File Offset: 0x0017E01F
		// (set) Token: 0x06010498 RID: 66712 RVA: 0x0017FE2F File Offset: 0x0017E02F
		public unsafe float UnLoadingRangeAdditional
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSpatialHashStreamingGrid.__PropertyOffset_UnLoadingRangeAdditional);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSpatialHashStreamingGrid.__PropertyOffset_UnLoadingRangeAdditional) = value;
			}
		}

		// Token: 0x17003FD1 RID: 16337
		// (get) Token: 0x06010499 RID: 66713 RVA: 0x0017FE40 File Offset: 0x0017E040
		// (set) Token: 0x0601049A RID: 66714 RVA: 0x0017FE50 File Offset: 0x0017E050
		public unsafe bool bRangeStreaming
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSpatialHashStreamingGrid.__PropertyOffset_bRangeStreaming) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSpatialHashStreamingGrid.__PropertyOffset_bRangeStreaming) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003FD2 RID: 16338
		// (get) Token: 0x0601049B RID: 66715 RVA: 0x0017FE61 File Offset: 0x0017E061
		// (set) Token: 0x0601049C RID: 66716 RVA: 0x0017FE71 File Offset: 0x0017E071
		public unsafe float StreamingOutStart
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSpatialHashStreamingGrid.__PropertyOffset_StreamingOutStart);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSpatialHashStreamingGrid.__PropertyOffset_StreamingOutStart) = value;
			}
		}

		// Token: 0x17003FD3 RID: 16339
		// (get) Token: 0x0601049D RID: 66717 RVA: 0x0017FE82 File Offset: 0x0017E082
		// (set) Token: 0x0601049E RID: 66718 RVA: 0x0017FE92 File Offset: 0x0017E092
		public unsafe bool bUseZAxis
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSpatialHashStreamingGrid.__PropertyOffset_bUseZAxis) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSpatialHashStreamingGrid.__PropertyOffset_bUseZAxis) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003FD4 RID: 16340
		// (get) Token: 0x0601049F RID: 66719 RVA: 0x0017FEA3 File Offset: 0x0017E0A3
		// (set) Token: 0x060104A0 RID: 66720 RVA: 0x0017FEB3 File Offset: 0x0017E0B3
		public unsafe float ZLoadingRangeCoefficient
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSpatialHashStreamingGrid.__PropertyOffset_ZLoadingRangeCoefficient);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSpatialHashStreamingGrid.__PropertyOffset_ZLoadingRangeCoefficient) = value;
			}
		}

		// Token: 0x17003FD5 RID: 16341
		// (get) Token: 0x060104A1 RID: 66721 RVA: 0x0017FEC4 File Offset: 0x0017E0C4
		// (set) Token: 0x060104A2 RID: 66722 RVA: 0x0017FED4 File Offset: 0x0017E0D4
		public unsafe bool bRegionLoadRangeAdjust
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSpatialHashStreamingGrid.__PropertyOffset_bRegionLoadRangeAdjust) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSpatialHashStreamingGrid.__PropertyOffset_bRegionLoadRangeAdjust) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003FD6 RID: 16342
		// (get) Token: 0x060104A3 RID: 66723 RVA: 0x0017FEE5 File Offset: 0x0017E0E5
		// (set) Token: 0x060104A4 RID: 66724 RVA: 0x0017FEF5 File Offset: 0x0017E0F5
		public unsafe bool bIsHLODGrid
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSpatialHashStreamingGrid.__PropertyOffset_bIsHLODGrid) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSpatialHashStreamingGrid.__PropertyOffset_bIsHLODGrid) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003FD7 RID: 16343
		// (get) Token: 0x060104A5 RID: 66725 RVA: 0x0017FF06 File Offset: 0x0017E106
		// (set) Token: 0x060104A6 RID: 66726 RVA: 0x0017FF16 File Offset: 0x0017E116
		public unsafe bool bIsLandScape
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSpatialHashStreamingGrid.__PropertyOffset_bIsLandScape) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSpatialHashStreamingGrid.__PropertyOffset_bIsLandScape) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003FD8 RID: 16344
		// (get) Token: 0x060104A7 RID: 66727 RVA: 0x0017FF27 File Offset: 0x0017E127
		// (set) Token: 0x060104A8 RID: 66728 RVA: 0x0017FF37 File Offset: 0x0017E137
		public unsafe bool bIsHLODGridVolume
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSpatialHashStreamingGrid.__PropertyOffset_bIsHLODGridVolume) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSpatialHashStreamingGrid.__PropertyOffset_bIsHLODGridVolume) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003FD9 RID: 16345
		// (get) Token: 0x060104A9 RID: 66729 RVA: 0x0017FF48 File Offset: 0x0017E148
		// (set) Token: 0x060104AA RID: 66730 RVA: 0x0017FF58 File Offset: 0x0017E158
		public unsafe bool bIsHLODStreamingGrid
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSpatialHashStreamingGrid.__PropertyOffset_bIsHLODStreamingGrid) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSpatialHashStreamingGrid.__PropertyOffset_bIsHLODStreamingGrid) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003FDA RID: 16346
		// (get) Token: 0x060104AB RID: 66731 RVA: 0x0017FF69 File Offset: 0x0017E169
		// (set) Token: 0x060104AC RID: 66732 RVA: 0x0017FF79 File Offset: 0x0017E179
		public unsafe bool bEnCloseSpaceAlreayOverride
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSpatialHashStreamingGrid.__PropertyOffset_bEnCloseSpaceAlreayOverride) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSpatialHashStreamingGrid.__PropertyOffset_bEnCloseSpaceAlreayOverride) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003FDB RID: 16347
		// (get) Token: 0x060104AD RID: 66733 RVA: 0x0017FF8A File Offset: 0x0017E18A
		// (set) Token: 0x060104AE RID: 66734 RVA: 0x0017FF9A File Offset: 0x0017E19A
		public unsafe bool bSkipQualityLevel
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSpatialHashStreamingGrid.__PropertyOffset_bSkipQualityLevel) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSpatialHashStreamingGrid.__PropertyOffset_bSkipQualityLevel) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003FDC RID: 16348
		// (get) Token: 0x060104AF RID: 66735 RVA: 0x0017FFAB File Offset: 0x0017E1AB
		// (set) Token: 0x060104B0 RID: 66736 RVA: 0x0017FFBB File Offset: 0x0017E1BB
		public unsafe bool bUseExtralSteamingDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSpatialHashStreamingGrid.__PropertyOffset_bUseExtralSteamingDistance) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSpatialHashStreamingGrid.__PropertyOffset_bUseExtralSteamingDistance) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003FDD RID: 16349
		// (get) Token: 0x060104B1 RID: 66737 RVA: 0x0017FFCC File Offset: 0x0017E1CC
		// (set) Token: 0x060104B2 RID: 66738 RVA: 0x0017FFE0 File Offset: 0x0017E1E0
		public unsafe FVector ExtraStreamingDistances
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSpatialHashStreamingGrid.__PropertyOffset_ExtraStreamingDistances);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSpatialHashStreamingGrid.__PropertyOffset_ExtraStreamingDistances) = value;
			}
		}

		// Token: 0x17003FDE RID: 16350
		// (get) Token: 0x060104B3 RID: 66739 RVA: 0x0017FFF5 File Offset: 0x0017E1F5
		// (set) Token: 0x060104B4 RID: 66740 RVA: 0x00180005 File Offset: 0x0017E205
		public unsafe bool bInCludeBounds
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSpatialHashStreamingGrid.__PropertyOffset_bInCludeBounds) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSpatialHashStreamingGrid.__PropertyOffset_bInCludeBounds) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003FDF RID: 16351
		// (get) Token: 0x060104B5 RID: 66741 RVA: 0x00180018 File Offset: 0x0017E218
		// (set) Token: 0x060104B6 RID: 66742 RVA: 0x0018005B File Offset: 0x0017E25B
		public TArray<FSpatialHashStreamingGridLevel> InjectedGridLevels
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FSpatialHashStreamingGridLevel> result;
				if ((result = this._InjectedGridLevels) == null)
				{
					result = (this._InjectedGridLevels = new TArray<FSpatialHashStreamingGridLevel>(base.NativePtr + (IntPtr)FSpatialHashStreamingGrid.__PropertyOffset_InjectedGridLevels, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.InjectedGridLevels.CopyAssign(value);
			}
		}

		// Token: 0x060104B7 RID: 66743 RVA: 0x00180069 File Offset: 0x0017E269
		public FSpatialHashStreamingGrid()
		{
		}

		// Token: 0x060104B8 RID: 66744 RVA: 0x00180074 File Offset: 0x0017E274
		public FSpatialHashStreamingGrid(FName GridName, FVector Origin, int CellSize, float LoadingRange, bool bBlockOnSlowStreaming, FLinearColor DebugColor, TArray<FSpatialHashStreamingGridLevel> GridLevels, FBox WorldBounds, bool bClientOnlyVisible, int GridIndex, FSpatialHashSettings Settings, float PcLoadingRangeScalar, float MobileLoadingRangeScalar, float PCLoadingRange, float UnLoadingRangeAdditional, bool bRangeStreaming, float StreamingOutStart, bool bUseZAxis, float ZLoadingRangeCoefficient, bool bRegionLoadRangeAdjust, bool bIsHLODGrid, bool bIsLandScape, bool bIsHLODGridVolume, bool bIsHLODStreamingGrid, bool bEnCloseSpaceAlreayOverride, bool bSkipQualityLevel, bool bUseExtralSteamingDistance, FVector ExtraStreamingDistances, bool bInCludeBounds, TArray<FSpatialHashStreamingGridLevel> InjectedGridLevels)
		{
			this.GridName = GridName;
			this.Origin = Origin;
			this.CellSize = CellSize;
			this.LoadingRange = LoadingRange;
			this.bBlockOnSlowStreaming = bBlockOnSlowStreaming;
			this.DebugColor = DebugColor;
			this.GridLevels = GridLevels;
			this.WorldBounds = WorldBounds;
			this.bClientOnlyVisible = bClientOnlyVisible;
			this.GridIndex = GridIndex;
			this.Settings = Settings;
			this.PcLoadingRangeScalar = PcLoadingRangeScalar;
			this.MobileLoadingRangeScalar = MobileLoadingRangeScalar;
			this.PCLoadingRange = PCLoadingRange;
			this.UnLoadingRangeAdditional = UnLoadingRangeAdditional;
			this.bRangeStreaming = bRangeStreaming;
			this.StreamingOutStart = StreamingOutStart;
			this.bUseZAxis = bUseZAxis;
			this.ZLoadingRangeCoefficient = ZLoadingRangeCoefficient;
			this.bRegionLoadRangeAdjust = bRegionLoadRangeAdjust;
			this.bIsHLODGrid = bIsHLODGrid;
			this.bIsLandScape = bIsLandScape;
			this.bIsHLODGridVolume = bIsHLODGridVolume;
			this.bIsHLODStreamingGrid = bIsHLODStreamingGrid;
			this.bEnCloseSpaceAlreayOverride = bEnCloseSpaceAlreayOverride;
			this.bSkipQualityLevel = bSkipQualityLevel;
			this.bUseExtralSteamingDistance = bUseExtralSteamingDistance;
			this.ExtraStreamingDistances = ExtraStreamingDistances;
			this.bInCludeBounds = bInCludeBounds;
			this.InjectedGridLevels = InjectedGridLevels;
		}

		// Token: 0x060104B9 RID: 66745 RVA: 0x00180174 File Offset: 0x0017E374
		protected override IntPtr GetUStructPtr()
		{
			return FSpatialHashStreamingGrid.StaticStruct();
		}

		// Token: 0x060104BA RID: 66746 RVA: 0x00180180 File Offset: 0x0017E380
		[NullableContext(2)]
		public FSpatialHashStreamingGrid(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060104BB RID: 66747 RVA: 0x0018018A File Offset: 0x0017E38A
		public FSpatialHashStreamingGrid(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060104BC RID: 66748 RVA: 0x00180195 File Offset: 0x0017E395
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSpatialHashStreamingGrid(Pointer, false, true);
		}

		// Token: 0x060104BD RID: 66749 RVA: 0x0018019F File Offset: 0x0017E39F
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSpatialHashStreamingGrid(Pointer, MemoryOwner);
		}

		// Token: 0x04008C1C RID: 35868
		public const string __ObjectPath = "/Script/Engine.SpatialHashStreamingGrid";

		// Token: 0x04008C1D RID: 35869
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04008C1E RID: 35870
		internal static int __PropertyOffset_GridName;

		// Token: 0x04008C1F RID: 35871
		internal static int __PropertyOffset_Origin;

		// Token: 0x04008C20 RID: 35872
		internal static int __PropertyOffset_CellSize;

		// Token: 0x04008C21 RID: 35873
		internal static int __PropertyOffset_LoadingRange;

		// Token: 0x04008C22 RID: 35874
		internal static int __PropertyOffset_bBlockOnSlowStreaming;

		// Token: 0x04008C23 RID: 35875
		internal static int __PropertyOffset_DebugColor;

		// Token: 0x04008C24 RID: 35876
		internal static int __PropertyOffset_GridLevels;

		// Token: 0x04008C25 RID: 35877
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FSpatialHashStreamingGridLevel> _GridLevels;

		// Token: 0x04008C26 RID: 35878
		internal static int __PropertyOffset_WorldBounds;

		// Token: 0x04008C27 RID: 35879
		internal static int __PropertyOffset_bClientOnlyVisible;

		// Token: 0x04008C28 RID: 35880
		internal static int __PropertyOffset_GridIndex;

		// Token: 0x04008C29 RID: 35881
		internal static int __PropertyOffset_Settings;

		// Token: 0x04008C2A RID: 35882
		[Nullable(2)]
		private FSpatialHashSettings _Settings;

		// Token: 0x04008C2B RID: 35883
		internal static int __PropertyOffset_PcLoadingRangeScalar;

		// Token: 0x04008C2C RID: 35884
		internal static int __PropertyOffset_MobileLoadingRangeScalar;

		// Token: 0x04008C2D RID: 35885
		internal static int __PropertyOffset_PCLoadingRange;

		// Token: 0x04008C2E RID: 35886
		internal static int __PropertyOffset_UnLoadingRangeAdditional;

		// Token: 0x04008C2F RID: 35887
		internal static int __PropertyOffset_bRangeStreaming;

		// Token: 0x04008C30 RID: 35888
		internal static int __PropertyOffset_StreamingOutStart;

		// Token: 0x04008C31 RID: 35889
		internal static int __PropertyOffset_bUseZAxis;

		// Token: 0x04008C32 RID: 35890
		internal static int __PropertyOffset_ZLoadingRangeCoefficient;

		// Token: 0x04008C33 RID: 35891
		internal static int __PropertyOffset_bRegionLoadRangeAdjust;

		// Token: 0x04008C34 RID: 35892
		internal static int __PropertyOffset_bIsHLODGrid;

		// Token: 0x04008C35 RID: 35893
		internal static int __PropertyOffset_bIsLandScape;

		// Token: 0x04008C36 RID: 35894
		internal static int __PropertyOffset_bIsHLODGridVolume;

		// Token: 0x04008C37 RID: 35895
		internal static int __PropertyOffset_bIsHLODStreamingGrid;

		// Token: 0x04008C38 RID: 35896
		internal static int __PropertyOffset_bEnCloseSpaceAlreayOverride;

		// Token: 0x04008C39 RID: 35897
		internal static int __PropertyOffset_bSkipQualityLevel;

		// Token: 0x04008C3A RID: 35898
		internal static int __PropertyOffset_bUseExtralSteamingDistance;

		// Token: 0x04008C3B RID: 35899
		internal static int __PropertyOffset_ExtraStreamingDistances;

		// Token: 0x04008C3C RID: 35900
		internal static int __PropertyOffset_bInCludeBounds;

		// Token: 0x04008C3D RID: 35901
		internal static int __PropertyOffset_InjectedGridLevels;

		// Token: 0x04008C3E RID: 35902
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FSpatialHashStreamingGridLevel> _InjectedGridLevels;
	}
}
