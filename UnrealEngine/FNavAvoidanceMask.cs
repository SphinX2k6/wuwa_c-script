using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000246 RID: 582
	[UnrealObjectPath("/Script/Engine.NavAvoidanceMask")]
	[UnrealStructLayout(4, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 4)]
	public class FNavAvoidanceMask : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06003225 RID: 12837 RVA: 0x00047581 File Offset: 0x00045781
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FNavAvoidanceMask._ScriptStructPtr != 0) ? FNavAvoidanceMask._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.NavAvoidanceMask", ref FNavAvoidanceMask._ScriptStructPtr);
		}

		// Token: 0x170006F6 RID: 1782
		// (get) Token: 0x06003226 RID: 12838 RVA: 0x000475A5 File Offset: 0x000457A5
		// (set) Token: 0x06003227 RID: 12839 RVA: 0x000475BE File Offset: 0x000457BE
		public unsafe bool bGroup0
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FNavAvoidanceMask.__PropertyOffset_bGroup0) & FNavAvoidanceMask.__PropertyMask_bGroup0) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FNavAvoidanceMask.__PropertyOffset_bGroup0) = ((*(base.NativePtr + (IntPtr)FNavAvoidanceMask.__PropertyOffset_bGroup0) & ~FNavAvoidanceMask.__PropertyMask_bGroup0) | (value ? FNavAvoidanceMask.__PropertyMask_bGroup0 : 0));
			}
		}

		// Token: 0x170006F7 RID: 1783
		// (get) Token: 0x06003228 RID: 12840 RVA: 0x000475EE File Offset: 0x000457EE
		// (set) Token: 0x06003229 RID: 12841 RVA: 0x00047607 File Offset: 0x00045807
		public unsafe bool bGroup1
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FNavAvoidanceMask.__PropertyOffset_bGroup1) & FNavAvoidanceMask.__PropertyMask_bGroup1) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FNavAvoidanceMask.__PropertyOffset_bGroup1) = ((*(base.NativePtr + (IntPtr)FNavAvoidanceMask.__PropertyOffset_bGroup1) & ~FNavAvoidanceMask.__PropertyMask_bGroup1) | (value ? FNavAvoidanceMask.__PropertyMask_bGroup1 : 0));
			}
		}

		// Token: 0x170006F8 RID: 1784
		// (get) Token: 0x0600322A RID: 12842 RVA: 0x00047637 File Offset: 0x00045837
		// (set) Token: 0x0600322B RID: 12843 RVA: 0x00047650 File Offset: 0x00045850
		public unsafe bool bGroup2
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FNavAvoidanceMask.__PropertyOffset_bGroup2) & FNavAvoidanceMask.__PropertyMask_bGroup2) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FNavAvoidanceMask.__PropertyOffset_bGroup2) = ((*(base.NativePtr + (IntPtr)FNavAvoidanceMask.__PropertyOffset_bGroup2) & ~FNavAvoidanceMask.__PropertyMask_bGroup2) | (value ? FNavAvoidanceMask.__PropertyMask_bGroup2 : 0));
			}
		}

		// Token: 0x170006F9 RID: 1785
		// (get) Token: 0x0600322C RID: 12844 RVA: 0x00047680 File Offset: 0x00045880
		// (set) Token: 0x0600322D RID: 12845 RVA: 0x00047699 File Offset: 0x00045899
		public unsafe bool bGroup3
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FNavAvoidanceMask.__PropertyOffset_bGroup3) & FNavAvoidanceMask.__PropertyMask_bGroup3) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FNavAvoidanceMask.__PropertyOffset_bGroup3) = ((*(base.NativePtr + (IntPtr)FNavAvoidanceMask.__PropertyOffset_bGroup3) & ~FNavAvoidanceMask.__PropertyMask_bGroup3) | (value ? FNavAvoidanceMask.__PropertyMask_bGroup3 : 0));
			}
		}

		// Token: 0x170006FA RID: 1786
		// (get) Token: 0x0600322E RID: 12846 RVA: 0x000476C9 File Offset: 0x000458C9
		// (set) Token: 0x0600322F RID: 12847 RVA: 0x000476E2 File Offset: 0x000458E2
		public unsafe bool bGroup4
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FNavAvoidanceMask.__PropertyOffset_bGroup4) & FNavAvoidanceMask.__PropertyMask_bGroup4) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FNavAvoidanceMask.__PropertyOffset_bGroup4) = ((*(base.NativePtr + (IntPtr)FNavAvoidanceMask.__PropertyOffset_bGroup4) & ~FNavAvoidanceMask.__PropertyMask_bGroup4) | (value ? FNavAvoidanceMask.__PropertyMask_bGroup4 : 0));
			}
		}

		// Token: 0x170006FB RID: 1787
		// (get) Token: 0x06003230 RID: 12848 RVA: 0x00047712 File Offset: 0x00045912
		// (set) Token: 0x06003231 RID: 12849 RVA: 0x0004772B File Offset: 0x0004592B
		public unsafe bool bGroup5
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FNavAvoidanceMask.__PropertyOffset_bGroup5) & FNavAvoidanceMask.__PropertyMask_bGroup5) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FNavAvoidanceMask.__PropertyOffset_bGroup5) = ((*(base.NativePtr + (IntPtr)FNavAvoidanceMask.__PropertyOffset_bGroup5) & ~FNavAvoidanceMask.__PropertyMask_bGroup5) | (value ? FNavAvoidanceMask.__PropertyMask_bGroup5 : 0));
			}
		}

		// Token: 0x170006FC RID: 1788
		// (get) Token: 0x06003232 RID: 12850 RVA: 0x0004775B File Offset: 0x0004595B
		// (set) Token: 0x06003233 RID: 12851 RVA: 0x00047774 File Offset: 0x00045974
		public unsafe bool bGroup6
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FNavAvoidanceMask.__PropertyOffset_bGroup6) & FNavAvoidanceMask.__PropertyMask_bGroup6) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FNavAvoidanceMask.__PropertyOffset_bGroup6) = ((*(base.NativePtr + (IntPtr)FNavAvoidanceMask.__PropertyOffset_bGroup6) & ~FNavAvoidanceMask.__PropertyMask_bGroup6) | (value ? FNavAvoidanceMask.__PropertyMask_bGroup6 : 0));
			}
		}

		// Token: 0x170006FD RID: 1789
		// (get) Token: 0x06003234 RID: 12852 RVA: 0x000477A4 File Offset: 0x000459A4
		// (set) Token: 0x06003235 RID: 12853 RVA: 0x000477BD File Offset: 0x000459BD
		public unsafe bool bGroup7
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FNavAvoidanceMask.__PropertyOffset_bGroup7) & FNavAvoidanceMask.__PropertyMask_bGroup7) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FNavAvoidanceMask.__PropertyOffset_bGroup7) = ((*(base.NativePtr + (IntPtr)FNavAvoidanceMask.__PropertyOffset_bGroup7) & ~FNavAvoidanceMask.__PropertyMask_bGroup7) | (value ? FNavAvoidanceMask.__PropertyMask_bGroup7 : 0));
			}
		}

		// Token: 0x170006FE RID: 1790
		// (get) Token: 0x06003236 RID: 12854 RVA: 0x000477ED File Offset: 0x000459ED
		// (set) Token: 0x06003237 RID: 12855 RVA: 0x00047806 File Offset: 0x00045A06
		public unsafe bool bGroup8
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FNavAvoidanceMask.__PropertyOffset_bGroup8) & FNavAvoidanceMask.__PropertyMask_bGroup8) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FNavAvoidanceMask.__PropertyOffset_bGroup8) = ((*(base.NativePtr + (IntPtr)FNavAvoidanceMask.__PropertyOffset_bGroup8) & ~FNavAvoidanceMask.__PropertyMask_bGroup8) | (value ? FNavAvoidanceMask.__PropertyMask_bGroup8 : 0));
			}
		}

		// Token: 0x170006FF RID: 1791
		// (get) Token: 0x06003238 RID: 12856 RVA: 0x00047836 File Offset: 0x00045A36
		// (set) Token: 0x06003239 RID: 12857 RVA: 0x0004784F File Offset: 0x00045A4F
		public unsafe bool bGroup9
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FNavAvoidanceMask.__PropertyOffset_bGroup9) & FNavAvoidanceMask.__PropertyMask_bGroup9) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FNavAvoidanceMask.__PropertyOffset_bGroup9) = ((*(base.NativePtr + (IntPtr)FNavAvoidanceMask.__PropertyOffset_bGroup9) & ~FNavAvoidanceMask.__PropertyMask_bGroup9) | (value ? FNavAvoidanceMask.__PropertyMask_bGroup9 : 0));
			}
		}

		// Token: 0x17000700 RID: 1792
		// (get) Token: 0x0600323A RID: 12858 RVA: 0x0004787F File Offset: 0x00045A7F
		// (set) Token: 0x0600323B RID: 12859 RVA: 0x00047898 File Offset: 0x00045A98
		public unsafe bool bGroup10
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FNavAvoidanceMask.__PropertyOffset_bGroup10) & FNavAvoidanceMask.__PropertyMask_bGroup10) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FNavAvoidanceMask.__PropertyOffset_bGroup10) = ((*(base.NativePtr + (IntPtr)FNavAvoidanceMask.__PropertyOffset_bGroup10) & ~FNavAvoidanceMask.__PropertyMask_bGroup10) | (value ? FNavAvoidanceMask.__PropertyMask_bGroup10 : 0));
			}
		}

		// Token: 0x17000701 RID: 1793
		// (get) Token: 0x0600323C RID: 12860 RVA: 0x000478C8 File Offset: 0x00045AC8
		// (set) Token: 0x0600323D RID: 12861 RVA: 0x000478E1 File Offset: 0x00045AE1
		public unsafe bool bGroup11
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FNavAvoidanceMask.__PropertyOffset_bGroup11) & FNavAvoidanceMask.__PropertyMask_bGroup11) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FNavAvoidanceMask.__PropertyOffset_bGroup11) = ((*(base.NativePtr + (IntPtr)FNavAvoidanceMask.__PropertyOffset_bGroup11) & ~FNavAvoidanceMask.__PropertyMask_bGroup11) | (value ? FNavAvoidanceMask.__PropertyMask_bGroup11 : 0));
			}
		}

		// Token: 0x17000702 RID: 1794
		// (get) Token: 0x0600323E RID: 12862 RVA: 0x00047911 File Offset: 0x00045B11
		// (set) Token: 0x0600323F RID: 12863 RVA: 0x0004792A File Offset: 0x00045B2A
		public unsafe bool bGroup12
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FNavAvoidanceMask.__PropertyOffset_bGroup12) & FNavAvoidanceMask.__PropertyMask_bGroup12) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FNavAvoidanceMask.__PropertyOffset_bGroup12) = ((*(base.NativePtr + (IntPtr)FNavAvoidanceMask.__PropertyOffset_bGroup12) & ~FNavAvoidanceMask.__PropertyMask_bGroup12) | (value ? FNavAvoidanceMask.__PropertyMask_bGroup12 : 0));
			}
		}

		// Token: 0x17000703 RID: 1795
		// (get) Token: 0x06003240 RID: 12864 RVA: 0x0004795A File Offset: 0x00045B5A
		// (set) Token: 0x06003241 RID: 12865 RVA: 0x00047973 File Offset: 0x00045B73
		public unsafe bool bGroup13
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FNavAvoidanceMask.__PropertyOffset_bGroup13) & FNavAvoidanceMask.__PropertyMask_bGroup13) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FNavAvoidanceMask.__PropertyOffset_bGroup13) = ((*(base.NativePtr + (IntPtr)FNavAvoidanceMask.__PropertyOffset_bGroup13) & ~FNavAvoidanceMask.__PropertyMask_bGroup13) | (value ? FNavAvoidanceMask.__PropertyMask_bGroup13 : 0));
			}
		}

		// Token: 0x17000704 RID: 1796
		// (get) Token: 0x06003242 RID: 12866 RVA: 0x000479A3 File Offset: 0x00045BA3
		// (set) Token: 0x06003243 RID: 12867 RVA: 0x000479BC File Offset: 0x00045BBC
		public unsafe bool bGroup14
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FNavAvoidanceMask.__PropertyOffset_bGroup14) & FNavAvoidanceMask.__PropertyMask_bGroup14) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FNavAvoidanceMask.__PropertyOffset_bGroup14) = ((*(base.NativePtr + (IntPtr)FNavAvoidanceMask.__PropertyOffset_bGroup14) & ~FNavAvoidanceMask.__PropertyMask_bGroup14) | (value ? FNavAvoidanceMask.__PropertyMask_bGroup14 : 0));
			}
		}

		// Token: 0x17000705 RID: 1797
		// (get) Token: 0x06003244 RID: 12868 RVA: 0x000479EC File Offset: 0x00045BEC
		// (set) Token: 0x06003245 RID: 12869 RVA: 0x00047A05 File Offset: 0x00045C05
		public unsafe bool bGroup15
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FNavAvoidanceMask.__PropertyOffset_bGroup15) & FNavAvoidanceMask.__PropertyMask_bGroup15) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FNavAvoidanceMask.__PropertyOffset_bGroup15) = ((*(base.NativePtr + (IntPtr)FNavAvoidanceMask.__PropertyOffset_bGroup15) & ~FNavAvoidanceMask.__PropertyMask_bGroup15) | (value ? FNavAvoidanceMask.__PropertyMask_bGroup15 : 0));
			}
		}

		// Token: 0x17000706 RID: 1798
		// (get) Token: 0x06003246 RID: 12870 RVA: 0x00047A35 File Offset: 0x00045C35
		// (set) Token: 0x06003247 RID: 12871 RVA: 0x00047A4E File Offset: 0x00045C4E
		public unsafe bool bGroup16
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FNavAvoidanceMask.__PropertyOffset_bGroup16) & FNavAvoidanceMask.__PropertyMask_bGroup16) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FNavAvoidanceMask.__PropertyOffset_bGroup16) = ((*(base.NativePtr + (IntPtr)FNavAvoidanceMask.__PropertyOffset_bGroup16) & ~FNavAvoidanceMask.__PropertyMask_bGroup16) | (value ? FNavAvoidanceMask.__PropertyMask_bGroup16 : 0));
			}
		}

		// Token: 0x17000707 RID: 1799
		// (get) Token: 0x06003248 RID: 12872 RVA: 0x00047A7E File Offset: 0x00045C7E
		// (set) Token: 0x06003249 RID: 12873 RVA: 0x00047A97 File Offset: 0x00045C97
		public unsafe bool bGroup17
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FNavAvoidanceMask.__PropertyOffset_bGroup17) & FNavAvoidanceMask.__PropertyMask_bGroup17) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FNavAvoidanceMask.__PropertyOffset_bGroup17) = ((*(base.NativePtr + (IntPtr)FNavAvoidanceMask.__PropertyOffset_bGroup17) & ~FNavAvoidanceMask.__PropertyMask_bGroup17) | (value ? FNavAvoidanceMask.__PropertyMask_bGroup17 : 0));
			}
		}

		// Token: 0x17000708 RID: 1800
		// (get) Token: 0x0600324A RID: 12874 RVA: 0x00047AC7 File Offset: 0x00045CC7
		// (set) Token: 0x0600324B RID: 12875 RVA: 0x00047AE0 File Offset: 0x00045CE0
		public unsafe bool bGroup18
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FNavAvoidanceMask.__PropertyOffset_bGroup18) & FNavAvoidanceMask.__PropertyMask_bGroup18) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FNavAvoidanceMask.__PropertyOffset_bGroup18) = ((*(base.NativePtr + (IntPtr)FNavAvoidanceMask.__PropertyOffset_bGroup18) & ~FNavAvoidanceMask.__PropertyMask_bGroup18) | (value ? FNavAvoidanceMask.__PropertyMask_bGroup18 : 0));
			}
		}

		// Token: 0x17000709 RID: 1801
		// (get) Token: 0x0600324C RID: 12876 RVA: 0x00047B10 File Offset: 0x00045D10
		// (set) Token: 0x0600324D RID: 12877 RVA: 0x00047B29 File Offset: 0x00045D29
		public unsafe bool bGroup19
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FNavAvoidanceMask.__PropertyOffset_bGroup19) & FNavAvoidanceMask.__PropertyMask_bGroup19) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FNavAvoidanceMask.__PropertyOffset_bGroup19) = ((*(base.NativePtr + (IntPtr)FNavAvoidanceMask.__PropertyOffset_bGroup19) & ~FNavAvoidanceMask.__PropertyMask_bGroup19) | (value ? FNavAvoidanceMask.__PropertyMask_bGroup19 : 0));
			}
		}

		// Token: 0x1700070A RID: 1802
		// (get) Token: 0x0600324E RID: 12878 RVA: 0x00047B59 File Offset: 0x00045D59
		// (set) Token: 0x0600324F RID: 12879 RVA: 0x00047B72 File Offset: 0x00045D72
		public unsafe bool bGroup20
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FNavAvoidanceMask.__PropertyOffset_bGroup20) & FNavAvoidanceMask.__PropertyMask_bGroup20) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FNavAvoidanceMask.__PropertyOffset_bGroup20) = ((*(base.NativePtr + (IntPtr)FNavAvoidanceMask.__PropertyOffset_bGroup20) & ~FNavAvoidanceMask.__PropertyMask_bGroup20) | (value ? FNavAvoidanceMask.__PropertyMask_bGroup20 : 0));
			}
		}

		// Token: 0x1700070B RID: 1803
		// (get) Token: 0x06003250 RID: 12880 RVA: 0x00047BA2 File Offset: 0x00045DA2
		// (set) Token: 0x06003251 RID: 12881 RVA: 0x00047BBB File Offset: 0x00045DBB
		public unsafe bool bGroup21
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FNavAvoidanceMask.__PropertyOffset_bGroup21) & FNavAvoidanceMask.__PropertyMask_bGroup21) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FNavAvoidanceMask.__PropertyOffset_bGroup21) = ((*(base.NativePtr + (IntPtr)FNavAvoidanceMask.__PropertyOffset_bGroup21) & ~FNavAvoidanceMask.__PropertyMask_bGroup21) | (value ? FNavAvoidanceMask.__PropertyMask_bGroup21 : 0));
			}
		}

		// Token: 0x1700070C RID: 1804
		// (get) Token: 0x06003252 RID: 12882 RVA: 0x00047BEB File Offset: 0x00045DEB
		// (set) Token: 0x06003253 RID: 12883 RVA: 0x00047C04 File Offset: 0x00045E04
		public unsafe bool bGroup22
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FNavAvoidanceMask.__PropertyOffset_bGroup22) & FNavAvoidanceMask.__PropertyMask_bGroup22) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FNavAvoidanceMask.__PropertyOffset_bGroup22) = ((*(base.NativePtr + (IntPtr)FNavAvoidanceMask.__PropertyOffset_bGroup22) & ~FNavAvoidanceMask.__PropertyMask_bGroup22) | (value ? FNavAvoidanceMask.__PropertyMask_bGroup22 : 0));
			}
		}

		// Token: 0x1700070D RID: 1805
		// (get) Token: 0x06003254 RID: 12884 RVA: 0x00047C34 File Offset: 0x00045E34
		// (set) Token: 0x06003255 RID: 12885 RVA: 0x00047C4D File Offset: 0x00045E4D
		public unsafe bool bGroup23
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FNavAvoidanceMask.__PropertyOffset_bGroup23) & FNavAvoidanceMask.__PropertyMask_bGroup23) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FNavAvoidanceMask.__PropertyOffset_bGroup23) = ((*(base.NativePtr + (IntPtr)FNavAvoidanceMask.__PropertyOffset_bGroup23) & ~FNavAvoidanceMask.__PropertyMask_bGroup23) | (value ? FNavAvoidanceMask.__PropertyMask_bGroup23 : 0));
			}
		}

		// Token: 0x1700070E RID: 1806
		// (get) Token: 0x06003256 RID: 12886 RVA: 0x00047C7D File Offset: 0x00045E7D
		// (set) Token: 0x06003257 RID: 12887 RVA: 0x00047C96 File Offset: 0x00045E96
		public unsafe bool bGroup24
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FNavAvoidanceMask.__PropertyOffset_bGroup24) & FNavAvoidanceMask.__PropertyMask_bGroup24) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FNavAvoidanceMask.__PropertyOffset_bGroup24) = ((*(base.NativePtr + (IntPtr)FNavAvoidanceMask.__PropertyOffset_bGroup24) & ~FNavAvoidanceMask.__PropertyMask_bGroup24) | (value ? FNavAvoidanceMask.__PropertyMask_bGroup24 : 0));
			}
		}

		// Token: 0x1700070F RID: 1807
		// (get) Token: 0x06003258 RID: 12888 RVA: 0x00047CC6 File Offset: 0x00045EC6
		// (set) Token: 0x06003259 RID: 12889 RVA: 0x00047CDF File Offset: 0x00045EDF
		public unsafe bool bGroup25
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FNavAvoidanceMask.__PropertyOffset_bGroup25) & FNavAvoidanceMask.__PropertyMask_bGroup25) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FNavAvoidanceMask.__PropertyOffset_bGroup25) = ((*(base.NativePtr + (IntPtr)FNavAvoidanceMask.__PropertyOffset_bGroup25) & ~FNavAvoidanceMask.__PropertyMask_bGroup25) | (value ? FNavAvoidanceMask.__PropertyMask_bGroup25 : 0));
			}
		}

		// Token: 0x17000710 RID: 1808
		// (get) Token: 0x0600325A RID: 12890 RVA: 0x00047D0F File Offset: 0x00045F0F
		// (set) Token: 0x0600325B RID: 12891 RVA: 0x00047D28 File Offset: 0x00045F28
		public unsafe bool bGroup26
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FNavAvoidanceMask.__PropertyOffset_bGroup26) & FNavAvoidanceMask.__PropertyMask_bGroup26) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FNavAvoidanceMask.__PropertyOffset_bGroup26) = ((*(base.NativePtr + (IntPtr)FNavAvoidanceMask.__PropertyOffset_bGroup26) & ~FNavAvoidanceMask.__PropertyMask_bGroup26) | (value ? FNavAvoidanceMask.__PropertyMask_bGroup26 : 0));
			}
		}

		// Token: 0x17000711 RID: 1809
		// (get) Token: 0x0600325C RID: 12892 RVA: 0x00047D58 File Offset: 0x00045F58
		// (set) Token: 0x0600325D RID: 12893 RVA: 0x00047D71 File Offset: 0x00045F71
		public unsafe bool bGroup27
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FNavAvoidanceMask.__PropertyOffset_bGroup27) & FNavAvoidanceMask.__PropertyMask_bGroup27) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FNavAvoidanceMask.__PropertyOffset_bGroup27) = ((*(base.NativePtr + (IntPtr)FNavAvoidanceMask.__PropertyOffset_bGroup27) & ~FNavAvoidanceMask.__PropertyMask_bGroup27) | (value ? FNavAvoidanceMask.__PropertyMask_bGroup27 : 0));
			}
		}

		// Token: 0x17000712 RID: 1810
		// (get) Token: 0x0600325E RID: 12894 RVA: 0x00047DA1 File Offset: 0x00045FA1
		// (set) Token: 0x0600325F RID: 12895 RVA: 0x00047DBA File Offset: 0x00045FBA
		public unsafe bool bGroup28
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FNavAvoidanceMask.__PropertyOffset_bGroup28) & FNavAvoidanceMask.__PropertyMask_bGroup28) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FNavAvoidanceMask.__PropertyOffset_bGroup28) = ((*(base.NativePtr + (IntPtr)FNavAvoidanceMask.__PropertyOffset_bGroup28) & ~FNavAvoidanceMask.__PropertyMask_bGroup28) | (value ? FNavAvoidanceMask.__PropertyMask_bGroup28 : 0));
			}
		}

		// Token: 0x17000713 RID: 1811
		// (get) Token: 0x06003260 RID: 12896 RVA: 0x00047DEA File Offset: 0x00045FEA
		// (set) Token: 0x06003261 RID: 12897 RVA: 0x00047E03 File Offset: 0x00046003
		public unsafe bool bGroup29
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FNavAvoidanceMask.__PropertyOffset_bGroup29) & FNavAvoidanceMask.__PropertyMask_bGroup29) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FNavAvoidanceMask.__PropertyOffset_bGroup29) = ((*(base.NativePtr + (IntPtr)FNavAvoidanceMask.__PropertyOffset_bGroup29) & ~FNavAvoidanceMask.__PropertyMask_bGroup29) | (value ? FNavAvoidanceMask.__PropertyMask_bGroup29 : 0));
			}
		}

		// Token: 0x17000714 RID: 1812
		// (get) Token: 0x06003262 RID: 12898 RVA: 0x00047E33 File Offset: 0x00046033
		// (set) Token: 0x06003263 RID: 12899 RVA: 0x00047E4C File Offset: 0x0004604C
		public unsafe bool bGroup30
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FNavAvoidanceMask.__PropertyOffset_bGroup30) & FNavAvoidanceMask.__PropertyMask_bGroup30) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FNavAvoidanceMask.__PropertyOffset_bGroup30) = ((*(base.NativePtr + (IntPtr)FNavAvoidanceMask.__PropertyOffset_bGroup30) & ~FNavAvoidanceMask.__PropertyMask_bGroup30) | (value ? FNavAvoidanceMask.__PropertyMask_bGroup30 : 0));
			}
		}

		// Token: 0x17000715 RID: 1813
		// (get) Token: 0x06003264 RID: 12900 RVA: 0x00047E7C File Offset: 0x0004607C
		// (set) Token: 0x06003265 RID: 12901 RVA: 0x00047E95 File Offset: 0x00046095
		public unsafe bool bGroup31
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FNavAvoidanceMask.__PropertyOffset_bGroup31) & FNavAvoidanceMask.__PropertyMask_bGroup31) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FNavAvoidanceMask.__PropertyOffset_bGroup31) = ((*(base.NativePtr + (IntPtr)FNavAvoidanceMask.__PropertyOffset_bGroup31) & ~FNavAvoidanceMask.__PropertyMask_bGroup31) | (value ? FNavAvoidanceMask.__PropertyMask_bGroup31 : 0));
			}
		}

		// Token: 0x06003266 RID: 12902 RVA: 0x00047EC5 File Offset: 0x000460C5
		public FNavAvoidanceMask()
		{
		}

		// Token: 0x06003267 RID: 12903 RVA: 0x00047ECD File Offset: 0x000460CD
		protected override IntPtr GetUStructPtr()
		{
			return FNavAvoidanceMask.StaticStruct();
		}

		// Token: 0x06003268 RID: 12904 RVA: 0x00047ED9 File Offset: 0x000460D9
		[NullableContext(2)]
		public FNavAvoidanceMask(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06003269 RID: 12905 RVA: 0x00047EE3 File Offset: 0x000460E3
		public FNavAvoidanceMask(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600326A RID: 12906 RVA: 0x00047EEE File Offset: 0x000460EE
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FNavAvoidanceMask(Pointer, false, true);
		}

		// Token: 0x0600326B RID: 12907 RVA: 0x00047EF8 File Offset: 0x000460F8
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FNavAvoidanceMask(Pointer, MemoryOwner);
		}

		// Token: 0x0400114D RID: 4429
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.NavAvoidanceMask";

		// Token: 0x0400114E RID: 4430
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400114F RID: 4431
		internal static int __PropertyOffset_bGroup0;

		// Token: 0x04001150 RID: 4432
		internal static byte __PropertyMask_bGroup0;

		// Token: 0x04001151 RID: 4433
		internal static int __PropertyOffset_bGroup1;

		// Token: 0x04001152 RID: 4434
		internal static byte __PropertyMask_bGroup1;

		// Token: 0x04001153 RID: 4435
		internal static int __PropertyOffset_bGroup2;

		// Token: 0x04001154 RID: 4436
		internal static byte __PropertyMask_bGroup2;

		// Token: 0x04001155 RID: 4437
		internal static int __PropertyOffset_bGroup3;

		// Token: 0x04001156 RID: 4438
		internal static byte __PropertyMask_bGroup3;

		// Token: 0x04001157 RID: 4439
		internal static int __PropertyOffset_bGroup4;

		// Token: 0x04001158 RID: 4440
		internal static byte __PropertyMask_bGroup4;

		// Token: 0x04001159 RID: 4441
		internal static int __PropertyOffset_bGroup5;

		// Token: 0x0400115A RID: 4442
		internal static byte __PropertyMask_bGroup5;

		// Token: 0x0400115B RID: 4443
		internal static int __PropertyOffset_bGroup6;

		// Token: 0x0400115C RID: 4444
		internal static byte __PropertyMask_bGroup6;

		// Token: 0x0400115D RID: 4445
		internal static int __PropertyOffset_bGroup7;

		// Token: 0x0400115E RID: 4446
		internal static byte __PropertyMask_bGroup7;

		// Token: 0x0400115F RID: 4447
		internal static int __PropertyOffset_bGroup8;

		// Token: 0x04001160 RID: 4448
		internal static byte __PropertyMask_bGroup8;

		// Token: 0x04001161 RID: 4449
		internal static int __PropertyOffset_bGroup9;

		// Token: 0x04001162 RID: 4450
		internal static byte __PropertyMask_bGroup9;

		// Token: 0x04001163 RID: 4451
		internal static int __PropertyOffset_bGroup10;

		// Token: 0x04001164 RID: 4452
		internal static byte __PropertyMask_bGroup10;

		// Token: 0x04001165 RID: 4453
		internal static int __PropertyOffset_bGroup11;

		// Token: 0x04001166 RID: 4454
		internal static byte __PropertyMask_bGroup11;

		// Token: 0x04001167 RID: 4455
		internal static int __PropertyOffset_bGroup12;

		// Token: 0x04001168 RID: 4456
		internal static byte __PropertyMask_bGroup12;

		// Token: 0x04001169 RID: 4457
		internal static int __PropertyOffset_bGroup13;

		// Token: 0x0400116A RID: 4458
		internal static byte __PropertyMask_bGroup13;

		// Token: 0x0400116B RID: 4459
		internal static int __PropertyOffset_bGroup14;

		// Token: 0x0400116C RID: 4460
		internal static byte __PropertyMask_bGroup14;

		// Token: 0x0400116D RID: 4461
		internal static int __PropertyOffset_bGroup15;

		// Token: 0x0400116E RID: 4462
		internal static byte __PropertyMask_bGroup15;

		// Token: 0x0400116F RID: 4463
		internal static int __PropertyOffset_bGroup16;

		// Token: 0x04001170 RID: 4464
		internal static byte __PropertyMask_bGroup16;

		// Token: 0x04001171 RID: 4465
		internal static int __PropertyOffset_bGroup17;

		// Token: 0x04001172 RID: 4466
		internal static byte __PropertyMask_bGroup17;

		// Token: 0x04001173 RID: 4467
		internal static int __PropertyOffset_bGroup18;

		// Token: 0x04001174 RID: 4468
		internal static byte __PropertyMask_bGroup18;

		// Token: 0x04001175 RID: 4469
		internal static int __PropertyOffset_bGroup19;

		// Token: 0x04001176 RID: 4470
		internal static byte __PropertyMask_bGroup19;

		// Token: 0x04001177 RID: 4471
		internal static int __PropertyOffset_bGroup20;

		// Token: 0x04001178 RID: 4472
		internal static byte __PropertyMask_bGroup20;

		// Token: 0x04001179 RID: 4473
		internal static int __PropertyOffset_bGroup21;

		// Token: 0x0400117A RID: 4474
		internal static byte __PropertyMask_bGroup21;

		// Token: 0x0400117B RID: 4475
		internal static int __PropertyOffset_bGroup22;

		// Token: 0x0400117C RID: 4476
		internal static byte __PropertyMask_bGroup22;

		// Token: 0x0400117D RID: 4477
		internal static int __PropertyOffset_bGroup23;

		// Token: 0x0400117E RID: 4478
		internal static byte __PropertyMask_bGroup23;

		// Token: 0x0400117F RID: 4479
		internal static int __PropertyOffset_bGroup24;

		// Token: 0x04001180 RID: 4480
		internal static byte __PropertyMask_bGroup24;

		// Token: 0x04001181 RID: 4481
		internal static int __PropertyOffset_bGroup25;

		// Token: 0x04001182 RID: 4482
		internal static byte __PropertyMask_bGroup25;

		// Token: 0x04001183 RID: 4483
		internal static int __PropertyOffset_bGroup26;

		// Token: 0x04001184 RID: 4484
		internal static byte __PropertyMask_bGroup26;

		// Token: 0x04001185 RID: 4485
		internal static int __PropertyOffset_bGroup27;

		// Token: 0x04001186 RID: 4486
		internal static byte __PropertyMask_bGroup27;

		// Token: 0x04001187 RID: 4487
		internal static int __PropertyOffset_bGroup28;

		// Token: 0x04001188 RID: 4488
		internal static byte __PropertyMask_bGroup28;

		// Token: 0x04001189 RID: 4489
		internal static int __PropertyOffset_bGroup29;

		// Token: 0x0400118A RID: 4490
		internal static byte __PropertyMask_bGroup29;

		// Token: 0x0400118B RID: 4491
		internal static int __PropertyOffset_bGroup30;

		// Token: 0x0400118C RID: 4492
		internal static byte __PropertyMask_bGroup30;

		// Token: 0x0400118D RID: 4493
		internal static int __PropertyOffset_bGroup31;

		// Token: 0x0400118E RID: 4494
		internal static byte __PropertyMask_bGroup31;
	}
}
