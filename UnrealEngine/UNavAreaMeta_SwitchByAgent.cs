using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002478 RID: 9336
	[UnrealObjectPath("/Script/NavigationSystem.NavAreaMeta_SwitchByAgent")]
	[UnrealStructLayout(208, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 208)]
	public abstract class UNavAreaMeta_SwitchByAgent : UNavAreaMeta, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06022F0C RID: 143116 RVA: 0x0033A91D File Offset: 0x00338B1D
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UNavAreaMeta_SwitchByAgent._ClassPtr;
		}

		// Token: 0x1700863C RID: 34364
		// (get) Token: 0x06022F0D RID: 143117 RVA: 0x0033A929 File Offset: 0x00338B29
		// (set) Token: 0x06022F0E RID: 143118 RVA: 0x0033A93D File Offset: 0x00338B3D
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<UNavArea> Agent0Area
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)UNavAreaMeta_SwitchByAgent.__PropertyOffset_Agent0Area);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UNavAreaMeta_SwitchByAgent.__PropertyOffset_Agent0Area) = value;
			}
		}

		// Token: 0x1700863D RID: 34365
		// (get) Token: 0x06022F0F RID: 143119 RVA: 0x0033A952 File Offset: 0x00338B52
		// (set) Token: 0x06022F10 RID: 143120 RVA: 0x0033A966 File Offset: 0x00338B66
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<UNavArea> Agent1Area
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)UNavAreaMeta_SwitchByAgent.__PropertyOffset_Agent1Area);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UNavAreaMeta_SwitchByAgent.__PropertyOffset_Agent1Area) = value;
			}
		}

		// Token: 0x1700863E RID: 34366
		// (get) Token: 0x06022F11 RID: 143121 RVA: 0x0033A97B File Offset: 0x00338B7B
		// (set) Token: 0x06022F12 RID: 143122 RVA: 0x0033A98F File Offset: 0x00338B8F
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<UNavArea> Agent2Area
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)UNavAreaMeta_SwitchByAgent.__PropertyOffset_Agent2Area);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UNavAreaMeta_SwitchByAgent.__PropertyOffset_Agent2Area) = value;
			}
		}

		// Token: 0x1700863F RID: 34367
		// (get) Token: 0x06022F13 RID: 143123 RVA: 0x0033A9A4 File Offset: 0x00338BA4
		// (set) Token: 0x06022F14 RID: 143124 RVA: 0x0033A9B8 File Offset: 0x00338BB8
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<UNavArea> Agent3Area
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)UNavAreaMeta_SwitchByAgent.__PropertyOffset_Agent3Area);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UNavAreaMeta_SwitchByAgent.__PropertyOffset_Agent3Area) = value;
			}
		}

		// Token: 0x17008640 RID: 34368
		// (get) Token: 0x06022F15 RID: 143125 RVA: 0x0033A9CD File Offset: 0x00338BCD
		// (set) Token: 0x06022F16 RID: 143126 RVA: 0x0033A9E1 File Offset: 0x00338BE1
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<UNavArea> Agent4Area
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)UNavAreaMeta_SwitchByAgent.__PropertyOffset_Agent4Area);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UNavAreaMeta_SwitchByAgent.__PropertyOffset_Agent4Area) = value;
			}
		}

		// Token: 0x17008641 RID: 34369
		// (get) Token: 0x06022F17 RID: 143127 RVA: 0x0033A9F6 File Offset: 0x00338BF6
		// (set) Token: 0x06022F18 RID: 143128 RVA: 0x0033AA0A File Offset: 0x00338C0A
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<UNavArea> Agent5Area
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)UNavAreaMeta_SwitchByAgent.__PropertyOffset_Agent5Area);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UNavAreaMeta_SwitchByAgent.__PropertyOffset_Agent5Area) = value;
			}
		}

		// Token: 0x17008642 RID: 34370
		// (get) Token: 0x06022F19 RID: 143129 RVA: 0x0033AA1F File Offset: 0x00338C1F
		// (set) Token: 0x06022F1A RID: 143130 RVA: 0x0033AA33 File Offset: 0x00338C33
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<UNavArea> Agent6Area
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)UNavAreaMeta_SwitchByAgent.__PropertyOffset_Agent6Area);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UNavAreaMeta_SwitchByAgent.__PropertyOffset_Agent6Area) = value;
			}
		}

		// Token: 0x17008643 RID: 34371
		// (get) Token: 0x06022F1B RID: 143131 RVA: 0x0033AA48 File Offset: 0x00338C48
		// (set) Token: 0x06022F1C RID: 143132 RVA: 0x0033AA5C File Offset: 0x00338C5C
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<UNavArea> Agent7Area
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)UNavAreaMeta_SwitchByAgent.__PropertyOffset_Agent7Area);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UNavAreaMeta_SwitchByAgent.__PropertyOffset_Agent7Area) = value;
			}
		}

		// Token: 0x17008644 RID: 34372
		// (get) Token: 0x06022F1D RID: 143133 RVA: 0x0033AA71 File Offset: 0x00338C71
		// (set) Token: 0x06022F1E RID: 143134 RVA: 0x0033AA85 File Offset: 0x00338C85
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<UNavArea> Agent8Area
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)UNavAreaMeta_SwitchByAgent.__PropertyOffset_Agent8Area);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UNavAreaMeta_SwitchByAgent.__PropertyOffset_Agent8Area) = value;
			}
		}

		// Token: 0x17008645 RID: 34373
		// (get) Token: 0x06022F1F RID: 143135 RVA: 0x0033AA9A File Offset: 0x00338C9A
		// (set) Token: 0x06022F20 RID: 143136 RVA: 0x0033AAAE File Offset: 0x00338CAE
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<UNavArea> Agent9Area
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)UNavAreaMeta_SwitchByAgent.__PropertyOffset_Agent9Area);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UNavAreaMeta_SwitchByAgent.__PropertyOffset_Agent9Area) = value;
			}
		}

		// Token: 0x17008646 RID: 34374
		// (get) Token: 0x06022F21 RID: 143137 RVA: 0x0033AAC3 File Offset: 0x00338CC3
		// (set) Token: 0x06022F22 RID: 143138 RVA: 0x0033AAD7 File Offset: 0x00338CD7
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<UNavArea> Agent10Area
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)UNavAreaMeta_SwitchByAgent.__PropertyOffset_Agent10Area);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UNavAreaMeta_SwitchByAgent.__PropertyOffset_Agent10Area) = value;
			}
		}

		// Token: 0x17008647 RID: 34375
		// (get) Token: 0x06022F23 RID: 143139 RVA: 0x0033AAEC File Offset: 0x00338CEC
		// (set) Token: 0x06022F24 RID: 143140 RVA: 0x0033AB00 File Offset: 0x00338D00
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<UNavArea> Agent11Area
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)UNavAreaMeta_SwitchByAgent.__PropertyOffset_Agent11Area);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UNavAreaMeta_SwitchByAgent.__PropertyOffset_Agent11Area) = value;
			}
		}

		// Token: 0x17008648 RID: 34376
		// (get) Token: 0x06022F25 RID: 143141 RVA: 0x0033AB15 File Offset: 0x00338D15
		// (set) Token: 0x06022F26 RID: 143142 RVA: 0x0033AB29 File Offset: 0x00338D29
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<UNavArea> Agent12Area
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)UNavAreaMeta_SwitchByAgent.__PropertyOffset_Agent12Area);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UNavAreaMeta_SwitchByAgent.__PropertyOffset_Agent12Area) = value;
			}
		}

		// Token: 0x17008649 RID: 34377
		// (get) Token: 0x06022F27 RID: 143143 RVA: 0x0033AB3E File Offset: 0x00338D3E
		// (set) Token: 0x06022F28 RID: 143144 RVA: 0x0033AB52 File Offset: 0x00338D52
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<UNavArea> Agent13Area
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)UNavAreaMeta_SwitchByAgent.__PropertyOffset_Agent13Area);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UNavAreaMeta_SwitchByAgent.__PropertyOffset_Agent13Area) = value;
			}
		}

		// Token: 0x1700864A RID: 34378
		// (get) Token: 0x06022F29 RID: 143145 RVA: 0x0033AB67 File Offset: 0x00338D67
		// (set) Token: 0x06022F2A RID: 143146 RVA: 0x0033AB7B File Offset: 0x00338D7B
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<UNavArea> Agent14Area
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)UNavAreaMeta_SwitchByAgent.__PropertyOffset_Agent14Area);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UNavAreaMeta_SwitchByAgent.__PropertyOffset_Agent14Area) = value;
			}
		}

		// Token: 0x1700864B RID: 34379
		// (get) Token: 0x06022F2B RID: 143147 RVA: 0x0033AB90 File Offset: 0x00338D90
		// (set) Token: 0x06022F2C RID: 143148 RVA: 0x0033ABA4 File Offset: 0x00338DA4
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<UNavArea> Agent15Area
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)UNavAreaMeta_SwitchByAgent.__PropertyOffset_Agent15Area);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UNavAreaMeta_SwitchByAgent.__PropertyOffset_Agent15Area) = value;
			}
		}

		// Token: 0x06022F2D RID: 143149 RVA: 0x0033ABB9 File Offset: 0x00338DB9
		static UNavAreaMeta_SwitchByAgent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/NavigationSystem.NavAreaMeta_SwitchByAgent");
		}

		// Token: 0x06022F2E RID: 143150 RVA: 0x0033ABC8 File Offset: 0x00338DC8
		protected UNavAreaMeta_SwitchByAgent() : this(BuiltinUtils.AllocNativeUObject(UNavAreaMeta_SwitchByAgent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06022F2F RID: 143151 RVA: 0x0033ABF0 File Offset: 0x00338DF0
		protected UNavAreaMeta_SwitchByAgent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012A87 RID: 76423
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/NavigationSystem.NavAreaMeta_SwitchByAgent";

		// Token: 0x04012A88 RID: 76424
		private static IntPtr _ClassPtr;

		// Token: 0x04012A89 RID: 76425
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04012A8A RID: 76426
		internal static int __PropertyOffset_Agent0Area;

		// Token: 0x04012A8B RID: 76427
		internal static int __PropertyOffset_Agent1Area;

		// Token: 0x04012A8C RID: 76428
		internal static int __PropertyOffset_Agent2Area;

		// Token: 0x04012A8D RID: 76429
		internal static int __PropertyOffset_Agent3Area;

		// Token: 0x04012A8E RID: 76430
		internal static int __PropertyOffset_Agent4Area;

		// Token: 0x04012A8F RID: 76431
		internal static int __PropertyOffset_Agent5Area;

		// Token: 0x04012A90 RID: 76432
		internal static int __PropertyOffset_Agent6Area;

		// Token: 0x04012A91 RID: 76433
		internal static int __PropertyOffset_Agent7Area;

		// Token: 0x04012A92 RID: 76434
		internal static int __PropertyOffset_Agent8Area;

		// Token: 0x04012A93 RID: 76435
		internal static int __PropertyOffset_Agent9Area;

		// Token: 0x04012A94 RID: 76436
		internal static int __PropertyOffset_Agent10Area;

		// Token: 0x04012A95 RID: 76437
		internal static int __PropertyOffset_Agent11Area;

		// Token: 0x04012A96 RID: 76438
		internal static int __PropertyOffset_Agent12Area;

		// Token: 0x04012A97 RID: 76439
		internal static int __PropertyOffset_Agent13Area;

		// Token: 0x04012A98 RID: 76440
		internal static int __PropertyOffset_Agent14Area;

		// Token: 0x04012A99 RID: 76441
		internal static int __PropertyOffset_Agent15Area;
	}
}
