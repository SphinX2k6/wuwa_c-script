using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000CEF RID: 3311
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.KuroFrameStatsSettings")]
	[UnrealStructLayout(160, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 160)]
	public class UKuroFrameStatsSettings : UDeveloperSettings, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600AFB7 RID: 44983 RVA: 0x000F93A0 File Offset: 0x000F75A0
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroFrameStatsSettings._ClassPtr;
		}

		// Token: 0x0600AFB8 RID: 44984 RVA: 0x000F93AC File Offset: 0x000F75AC
		public UKuroFrameStatsSettings() : this(BuiltinUtils.AllocNativeUObject(UKuroFrameStatsSettings.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600AFB9 RID: 44985 RVA: 0x000F93D4 File Offset: 0x000F75D4
		public UKuroFrameStatsSettings(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroFrameStatsSettings.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170027B6 RID: 10166
		// (get) Token: 0x0600AFBA RID: 44986 RVA: 0x000F9407 File Offset: 0x000F7607
		// (set) Token: 0x0600AFBB RID: 44987 RVA: 0x000F9417 File Offset: 0x000F7617
		public unsafe float Frequency
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroFrameStatsSettings.__PropertyOffset_Frequency);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroFrameStatsSettings.__PropertyOffset_Frequency) = value;
			}
		}

		// Token: 0x170027B7 RID: 10167
		// (get) Token: 0x0600AFBC RID: 44988 RVA: 0x000F9428 File Offset: 0x000F7628
		// (set) Token: 0x0600AFBD RID: 44989 RVA: 0x000F9438 File Offset: 0x000F7638
		public unsafe int DetailsDepth
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroFrameStatsSettings.__PropertyOffset_DetailsDepth);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroFrameStatsSettings.__PropertyOffset_DetailsDepth) = value;
			}
		}

		// Token: 0x170027B8 RID: 10168
		// (get) Token: 0x0600AFBE RID: 44990 RVA: 0x000F9449 File Offset: 0x000F7649
		// (set) Token: 0x0600AFBF RID: 44991 RVA: 0x000F9459 File Offset: 0x000F7659
		public unsafe int DetailsDepthMobile
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroFrameStatsSettings.__PropertyOffset_DetailsDepthMobile);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroFrameStatsSettings.__PropertyOffset_DetailsDepthMobile) = value;
			}
		}

		// Token: 0x170027B9 RID: 10169
		// (get) Token: 0x0600AFC0 RID: 44992 RVA: 0x000F946A File Offset: 0x000F766A
		// (set) Token: 0x0600AFC1 RID: 44993 RVA: 0x000F947A File Offset: 0x000F767A
		public unsafe int FilterMode
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroFrameStatsSettings.__PropertyOffset_FilterMode);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroFrameStatsSettings.__PropertyOffset_FilterMode) = value;
			}
		}

		// Token: 0x170027BA RID: 10170
		// (get) Token: 0x0600AFC2 RID: 44994 RVA: 0x000F948B File Offset: 0x000F768B
		// (set) Token: 0x0600AFC3 RID: 44995 RVA: 0x000F949F File Offset: 0x000F769F
		public unsafe string Filter
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UKuroFrameStatsSettings.__PropertyOffset_Filter)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UKuroFrameStatsSettings.__PropertyOffset_Filter)), value);
			}
		}

		// Token: 0x170027BB RID: 10171
		// (get) Token: 0x0600AFC4 RID: 44996 RVA: 0x000F94B4 File Offset: 0x000F76B4
		// (set) Token: 0x0600AFC5 RID: 44997 RVA: 0x000F94C4 File Offset: 0x000F76C4
		public unsafe int FontSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroFrameStatsSettings.__PropertyOffset_FontSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroFrameStatsSettings.__PropertyOffset_FontSize) = value;
			}
		}

		// Token: 0x170027BC RID: 10172
		// (get) Token: 0x0600AFC6 RID: 44998 RVA: 0x000F94D8 File Offset: 0x000F76D8
		// (set) Token: 0x0600AFC7 RID: 44999 RVA: 0x000F9511 File Offset: 0x000F7711
		public TArray<string> Category
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._Category) == null)
				{
					result = (this._Category = new TArray<string>(base.NativePtr + (IntPtr)UKuroFrameStatsSettings.__PropertyOffset_Category, this));
				}
				return result;
			}
			set
			{
				this.Category.CopyAssign(value);
			}
		}

		// Token: 0x170027BD RID: 10173
		// (get) Token: 0x0600AFC8 RID: 45000 RVA: 0x000F951F File Offset: 0x000F771F
		// (set) Token: 0x0600AFC9 RID: 45001 RVA: 0x000F9533 File Offset: 0x000F7733
		[Nullable(2)]
		public unsafe UFont Font
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UFont>(base.NativePtr / (IntPtr)sizeof(void*) + UKuroFrameStatsSettings.__PropertyOffset_Font);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKuroFrameStatsSettings.__PropertyOffset_Font, value);
			}
		}

		// Token: 0x0600AFCA RID: 45002 RVA: 0x000F9548 File Offset: 0x000F7748
		static UKuroFrameStatsSettings()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.KuroFrameStatsSettings");
		}

		// Token: 0x0600AFCB RID: 45003 RVA: 0x000F9556 File Offset: 0x000F7756
		protected UKuroFrameStatsSettings(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04005BFE RID: 23550
		public new const string __ObjectPath = "/Script/Engine.KuroFrameStatsSettings";

		// Token: 0x04005BFF RID: 23551
		private static IntPtr _ClassPtr;

		// Token: 0x04005C00 RID: 23552
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04005C01 RID: 23553
		internal static int __PropertyOffset_Frequency;

		// Token: 0x04005C02 RID: 23554
		internal static int __PropertyOffset_DetailsDepth;

		// Token: 0x04005C03 RID: 23555
		internal static int __PropertyOffset_DetailsDepthMobile;

		// Token: 0x04005C04 RID: 23556
		internal static int __PropertyOffset_FilterMode;

		// Token: 0x04005C05 RID: 23557
		internal static int __PropertyOffset_Filter;

		// Token: 0x04005C06 RID: 23558
		internal static int __PropertyOffset_FontSize;

		// Token: 0x04005C07 RID: 23559
		internal static int __PropertyOffset_Category;

		// Token: 0x04005C08 RID: 23560
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _Category;

		// Token: 0x04005C09 RID: 23561
		internal static int __PropertyOffset_Font;
	}
}
