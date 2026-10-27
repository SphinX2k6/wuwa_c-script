using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020012A8 RID: 4776
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/FFXFSR3Settings.FFXFSR3CookConfig")]
	[UnrealStructLayout(112, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 112)]
	public class UFFXFSR3CookConfig : UDeveloperSettings, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060117C5 RID: 71621 RVA: 0x0019AAF8 File Offset: 0x00198CF8
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UFFXFSR3CookConfig._ClassPtr;
		}

		// Token: 0x060117C6 RID: 71622 RVA: 0x0019AB04 File Offset: 0x00198D04
		public UFFXFSR3CookConfig() : this(BuiltinUtils.AllocNativeUObject(UFFXFSR3CookConfig.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060117C7 RID: 71623 RVA: 0x0019AB2C File Offset: 0x00198D2C
		public UFFXFSR3CookConfig(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UFFXFSR3CookConfig.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004430 RID: 17456
		// (get) Token: 0x060117C8 RID: 71624 RVA: 0x0019AB60 File Offset: 0x00198D60
		// (set) Token: 0x060117C9 RID: 71625 RVA: 0x0019AB99 File Offset: 0x00198D99
		public TArray<string> CookPlatformBlackList
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._CookPlatformBlackList) == null)
				{
					result = (this._CookPlatformBlackList = new TArray<string>(base.NativePtr + (IntPtr)UFFXFSR3CookConfig.__PropertyOffset_CookPlatformBlackList, this));
				}
				return result;
			}
			set
			{
				this.CookPlatformBlackList.CopyAssign(value);
			}
		}

		// Token: 0x060117CA RID: 71626 RVA: 0x0019ABA7 File Offset: 0x00198DA7
		static UFFXFSR3CookConfig()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/FFXFSR3Settings.FFXFSR3CookConfig");
		}

		// Token: 0x060117CB RID: 71627 RVA: 0x0019ABB5 File Offset: 0x00198DB5
		protected UFFXFSR3CookConfig(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040095EC RID: 38380
		public new const string __ObjectPath = "/Script/FFXFSR3Settings.FFXFSR3CookConfig";

		// Token: 0x040095ED RID: 38381
		private static IntPtr _ClassPtr;

		// Token: 0x040095EE RID: 38382
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040095EF RID: 38383
		internal static int __PropertyOffset_CookPlatformBlackList;

		// Token: 0x040095F0 RID: 38384
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _CookPlatformBlackList;
	}
}
