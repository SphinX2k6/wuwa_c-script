using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001B93 RID: 7059
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroPPLensflareData")]
	[UnrealStructLayout(128, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 128)]
	public class UKuroPPLensflareData : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601ADA9 RID: 109993 RVA: 0x002799C1 File Offset: 0x00277BC1
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroPPLensflareData._ClassPtr;
		}

		// Token: 0x0601ADAA RID: 109994 RVA: 0x002799D0 File Offset: 0x00277BD0
		public UKuroPPLensflareData() : this(BuiltinUtils.AllocNativeUObject(UKuroPPLensflareData.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601ADAB RID: 109995 RVA: 0x002799F8 File Offset: 0x00277BF8
		public UKuroPPLensflareData(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroPPLensflareData.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006C3E RID: 27710
		// (get) Token: 0x0601ADAC RID: 109996 RVA: 0x00279A2B File Offset: 0x00277C2B
		// (set) Token: 0x0601ADAD RID: 109997 RVA: 0x00279A3F File Offset: 0x00277C3F
		public unsafe FName ConfigName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroPPLensflareData.__PropertyOffset_ConfigName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroPPLensflareData.__PropertyOffset_ConfigName) = value;
			}
		}

		// Token: 0x17006C3F RID: 27711
		// (get) Token: 0x0601ADAE RID: 109998 RVA: 0x00279A54 File Offset: 0x00277C54
		// (set) Token: 0x0601ADAF RID: 109999 RVA: 0x00279A8D File Offset: 0x00277C8D
		public FKuroLensflareSettings Settings
		{
			get
			{
				base.FastCheckIsValid();
				FKuroLensflareSettings result;
				if ((result = this._Settings) == null)
				{
					result = (this._Settings = new FKuroLensflareSettings(base.NativePtr + (IntPtr)UKuroPPLensflareData.__PropertyOffset_Settings, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroLensflareSettings.StaticStruct(), base.NativePtr + (IntPtr)UKuroPPLensflareData.__PropertyOffset_Settings, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0601ADB0 RID: 110000 RVA: 0x00279AAE File Offset: 0x00277CAE
		static UKuroPPLensflareData()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroPPLensflareData");
		}

		// Token: 0x0601ADB1 RID: 110001 RVA: 0x00279ABC File Offset: 0x00277CBC
		protected UKuroPPLensflareData(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400E89B RID: 59547
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroPPLensflareData";

		// Token: 0x0400E89C RID: 59548
		private static IntPtr _ClassPtr;

		// Token: 0x0400E89D RID: 59549
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400E89E RID: 59550
		internal static int __PropertyOffset_ConfigName;

		// Token: 0x0400E89F RID: 59551
		internal static int __PropertyOffset_Settings;

		// Token: 0x0400E8A0 RID: 59552
		[Nullable(2)]
		private FKuroLensflareSettings _Settings;
	}
}
