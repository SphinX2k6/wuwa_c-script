using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020019FE RID: 6654
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroNetwork.KuroNetworkSetting")]
	[UnrealStructLayout(136, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 136)]
	public class UKuroNetworkSetting : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06018AB2 RID: 101042 RVA: 0x00246176 File Offset: 0x00244376
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroNetworkSetting._ClassPtr;
		}

		// Token: 0x06018AB3 RID: 101043 RVA: 0x00246184 File Offset: 0x00244384
		public UKuroNetworkSetting() : this(BuiltinUtils.AllocNativeUObject(UKuroNetworkSetting.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06018AB4 RID: 101044 RVA: 0x002461AC File Offset: 0x002443AC
		public UKuroNetworkSetting(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroNetworkSetting.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700620D RID: 25101
		// (get) Token: 0x06018AB5 RID: 101045 RVA: 0x002461DF File Offset: 0x002443DF
		// (set) Token: 0x06018AB6 RID: 101046 RVA: 0x002461F3 File Offset: 0x002443F3
		public unsafe string AlAki
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UKuroNetworkSetting.__PropertyOffset_AlAki)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UKuroNetworkSetting.__PropertyOffset_AlAki)), value);
			}
		}

		// Token: 0x1700620E RID: 25102
		// (get) Token: 0x06018AB7 RID: 101047 RVA: 0x00246208 File Offset: 0x00244408
		// (set) Token: 0x06018AB8 RID: 101048 RVA: 0x0024621C File Offset: 0x0024441C
		public unsafe string AlAks
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UKuroNetworkSetting.__PropertyOffset_AlAks)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UKuroNetworkSetting.__PropertyOffset_AlAks)), value);
			}
		}

		// Token: 0x1700620F RID: 25103
		// (get) Token: 0x06018AB9 RID: 101049 RVA: 0x00246231 File Offset: 0x00244431
		// (set) Token: 0x06018ABA RID: 101050 RVA: 0x00246245 File Offset: 0x00244445
		public unsafe string RptPub
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UKuroNetworkSetting.__PropertyOffset_RptPub)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UKuroNetworkSetting.__PropertyOffset_RptPub)), value);
			}
		}

		// Token: 0x17006210 RID: 25104
		// (get) Token: 0x06018ABB RID: 101051 RVA: 0x0024625A File Offset: 0x0024445A
		// (set) Token: 0x06018ABC RID: 101052 RVA: 0x0024626E File Offset: 0x0024446E
		public unsafe string RptUrl
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UKuroNetworkSetting.__PropertyOffset_RptUrl)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UKuroNetworkSetting.__PropertyOffset_RptUrl)), value);
			}
		}

		// Token: 0x17006211 RID: 25105
		// (get) Token: 0x06018ABD RID: 101053 RVA: 0x00246283 File Offset: 0x00244483
		// (set) Token: 0x06018ABE RID: 101054 RVA: 0x00246297 File Offset: 0x00244497
		public unsafe string RptUrlGlobal
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UKuroNetworkSetting.__PropertyOffset_RptUrlGlobal)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UKuroNetworkSetting.__PropertyOffset_RptUrlGlobal)), value);
			}
		}

		// Token: 0x17006212 RID: 25106
		// (get) Token: 0x06018ABF RID: 101055 RVA: 0x002462AC File Offset: 0x002444AC
		// (set) Token: 0x06018AC0 RID: 101056 RVA: 0x002462BC File Offset: 0x002444BC
		public unsafe bool EnableDump
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroNetworkSetting.__PropertyOffset_EnableDump) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroNetworkSetting.__PropertyOffset_EnableDump) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006213 RID: 25107
		// (get) Token: 0x06018AC1 RID: 101057 RVA: 0x002462CD File Offset: 0x002444CD
		// (set) Token: 0x06018AC2 RID: 101058 RVA: 0x002462DD File Offset: 0x002444DD
		public unsafe bool UseNativeMethod
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroNetworkSetting.__PropertyOffset_UseNativeMethod) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroNetworkSetting.__PropertyOffset_UseNativeMethod) = (value ? 1 : 0);
			}
		}

		// Token: 0x06018AC3 RID: 101059 RVA: 0x002462EE File Offset: 0x002444EE
		static UKuroNetworkSetting()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroNetwork.KuroNetworkSetting");
		}

		// Token: 0x06018AC4 RID: 101060 RVA: 0x002462FC File Offset: 0x002444FC
		protected UKuroNetworkSetting(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400D540 RID: 54592
		public new const string __ObjectPath = "/Script/KuroNetwork.KuroNetworkSetting";

		// Token: 0x0400D541 RID: 54593
		private static IntPtr _ClassPtr;

		// Token: 0x0400D542 RID: 54594
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400D543 RID: 54595
		internal static int __PropertyOffset_AlAki;

		// Token: 0x0400D544 RID: 54596
		internal static int __PropertyOffset_AlAks;

		// Token: 0x0400D545 RID: 54597
		internal static int __PropertyOffset_RptPub;

		// Token: 0x0400D546 RID: 54598
		internal static int __PropertyOffset_RptUrl;

		// Token: 0x0400D547 RID: 54599
		internal static int __PropertyOffset_RptUrlGlobal;

		// Token: 0x0400D548 RID: 54600
		internal static int __PropertyOffset_EnableDump;

		// Token: 0x0400D549 RID: 54601
		internal static int __PropertyOffset_UseNativeMethod;
	}
}
