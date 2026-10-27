using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020012E1 RID: 4833
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/GameMatrix.CGSDKLoginResult")]
	[UnrealStructLayout(296, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 296)]
	public class FCGSDKLoginResult : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06011B4C RID: 72524 RVA: 0x0019FEEC File Offset: 0x0019E0EC
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FCGSDKLoginResult._ScriptStructPtr != 0) ? FCGSDKLoginResult._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/GameMatrix.CGSDKLoginResult", ref FCGSDKLoginResult._ScriptStructPtr);
		}

		// Token: 0x1700454D RID: 17741
		// (get) Token: 0x06011B4D RID: 72525 RVA: 0x0019FF10 File Offset: 0x0019E110
		// (set) Token: 0x06011B4E RID: 72526 RVA: 0x0019FF20 File Offset: 0x0019E120
		public unsafe int methodNameID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCGSDKLoginResult.__PropertyOffset_methodNameID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCGSDKLoginResult.__PropertyOffset_methodNameID) = value;
			}
		}

		// Token: 0x1700454E RID: 17742
		// (get) Token: 0x06011B4F RID: 72527 RVA: 0x0019FF31 File Offset: 0x0019E131
		// (set) Token: 0x06011B50 RID: 72528 RVA: 0x0019FF41 File Offset: 0x0019E141
		public unsafe int retCode
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCGSDKLoginResult.__PropertyOffset_retCode);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCGSDKLoginResult.__PropertyOffset_retCode) = value;
			}
		}

		// Token: 0x1700454F RID: 17743
		// (get) Token: 0x06011B51 RID: 72529 RVA: 0x0019FF52 File Offset: 0x0019E152
		// (set) Token: 0x06011B52 RID: 72530 RVA: 0x0019FF66 File Offset: 0x0019E166
		public unsafe string retMsg
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FCGSDKLoginResult.__PropertyOffset_retMsg)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FCGSDKLoginResult.__PropertyOffset_retMsg)), value);
			}
		}

		// Token: 0x17004550 RID: 17744
		// (get) Token: 0x06011B53 RID: 72531 RVA: 0x0019FF7B File Offset: 0x0019E17B
		// (set) Token: 0x06011B54 RID: 72532 RVA: 0x0019FF8B File Offset: 0x0019E18B
		public unsafe int thirdCode
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCGSDKLoginResult.__PropertyOffset_thirdCode);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCGSDKLoginResult.__PropertyOffset_thirdCode) = value;
			}
		}

		// Token: 0x17004551 RID: 17745
		// (get) Token: 0x06011B55 RID: 72533 RVA: 0x0019FF9C File Offset: 0x0019E19C
		// (set) Token: 0x06011B56 RID: 72534 RVA: 0x0019FFB0 File Offset: 0x0019E1B0
		public unsafe string thirdMsg
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FCGSDKLoginResult.__PropertyOffset_thirdMsg)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FCGSDKLoginResult.__PropertyOffset_thirdMsg)), value);
			}
		}

		// Token: 0x17004552 RID: 17746
		// (get) Token: 0x06011B57 RID: 72535 RVA: 0x0019FFC5 File Offset: 0x0019E1C5
		// (set) Token: 0x06011B58 RID: 72536 RVA: 0x0019FFD9 File Offset: 0x0019E1D9
		public unsafe string extraJson
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FCGSDKLoginResult.__PropertyOffset_extraJson)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FCGSDKLoginResult.__PropertyOffset_extraJson)), value);
			}
		}

		// Token: 0x17004553 RID: 17747
		// (get) Token: 0x06011B59 RID: 72537 RVA: 0x0019FFEE File Offset: 0x0019E1EE
		// (set) Token: 0x06011B5A RID: 72538 RVA: 0x001A0002 File Offset: 0x0019E202
		public unsafe string openID
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FCGSDKLoginResult.__PropertyOffset_openID)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FCGSDKLoginResult.__PropertyOffset_openID)), value);
			}
		}

		// Token: 0x17004554 RID: 17748
		// (get) Token: 0x06011B5B RID: 72539 RVA: 0x001A0017 File Offset: 0x0019E217
		// (set) Token: 0x06011B5C RID: 72540 RVA: 0x001A002B File Offset: 0x0019E22B
		public unsafe string token
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FCGSDKLoginResult.__PropertyOffset_token)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FCGSDKLoginResult.__PropertyOffset_token)), value);
			}
		}

		// Token: 0x17004555 RID: 17749
		// (get) Token: 0x06011B5D RID: 72541 RVA: 0x001A0040 File Offset: 0x0019E240
		// (set) Token: 0x06011B5E RID: 72542 RVA: 0x001A0050 File Offset: 0x0019E250
		public unsafe long tokenExpire
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCGSDKLoginResult.__PropertyOffset_tokenExpire);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCGSDKLoginResult.__PropertyOffset_tokenExpire) = value;
			}
		}

		// Token: 0x17004556 RID: 17750
		// (get) Token: 0x06011B5F RID: 72543 RVA: 0x001A0061 File Offset: 0x0019E261
		// (set) Token: 0x06011B60 RID: 72544 RVA: 0x001A0071 File Offset: 0x0019E271
		public unsafe int firstLogin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCGSDKLoginResult.__PropertyOffset_firstLogin);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCGSDKLoginResult.__PropertyOffset_firstLogin) = value;
			}
		}

		// Token: 0x17004557 RID: 17751
		// (get) Token: 0x06011B61 RID: 72545 RVA: 0x001A0082 File Offset: 0x0019E282
		// (set) Token: 0x06011B62 RID: 72546 RVA: 0x001A0096 File Offset: 0x0019E296
		public unsafe string regChannelDis
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FCGSDKLoginResult.__PropertyOffset_regChannelDis)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FCGSDKLoginResult.__PropertyOffset_regChannelDis)), value);
			}
		}

		// Token: 0x17004558 RID: 17752
		// (get) Token: 0x06011B63 RID: 72547 RVA: 0x001A00AB File Offset: 0x0019E2AB
		// (set) Token: 0x06011B64 RID: 72548 RVA: 0x001A00BF File Offset: 0x0019E2BF
		public unsafe string userName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FCGSDKLoginResult.__PropertyOffset_userName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FCGSDKLoginResult.__PropertyOffset_userName)), value);
			}
		}

		// Token: 0x17004559 RID: 17753
		// (get) Token: 0x06011B65 RID: 72549 RVA: 0x001A00D4 File Offset: 0x0019E2D4
		// (set) Token: 0x06011B66 RID: 72550 RVA: 0x001A00E4 File Offset: 0x0019E2E4
		public unsafe int gender
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCGSDKLoginResult.__PropertyOffset_gender);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCGSDKLoginResult.__PropertyOffset_gender) = value;
			}
		}

		// Token: 0x1700455A RID: 17754
		// (get) Token: 0x06011B67 RID: 72551 RVA: 0x001A00F5 File Offset: 0x0019E2F5
		// (set) Token: 0x06011B68 RID: 72552 RVA: 0x001A0109 File Offset: 0x0019E309
		public unsafe string birthdate
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FCGSDKLoginResult.__PropertyOffset_birthdate)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FCGSDKLoginResult.__PropertyOffset_birthdate)), value);
			}
		}

		// Token: 0x1700455B RID: 17755
		// (get) Token: 0x06011B69 RID: 72553 RVA: 0x001A011E File Offset: 0x0019E31E
		// (set) Token: 0x06011B6A RID: 72554 RVA: 0x001A0132 File Offset: 0x0019E332
		public unsafe string pictureUrl
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FCGSDKLoginResult.__PropertyOffset_pictureUrl)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FCGSDKLoginResult.__PropertyOffset_pictureUrl)), value);
			}
		}

		// Token: 0x1700455C RID: 17756
		// (get) Token: 0x06011B6B RID: 72555 RVA: 0x001A0147 File Offset: 0x0019E347
		// (set) Token: 0x06011B6C RID: 72556 RVA: 0x001A015B File Offset: 0x0019E35B
		public unsafe string pf
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FCGSDKLoginResult.__PropertyOffset_pf)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FCGSDKLoginResult.__PropertyOffset_pf)), value);
			}
		}

		// Token: 0x1700455D RID: 17757
		// (get) Token: 0x06011B6D RID: 72557 RVA: 0x001A0170 File Offset: 0x0019E370
		// (set) Token: 0x06011B6E RID: 72558 RVA: 0x001A0184 File Offset: 0x0019E384
		public unsafe string pfKey
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FCGSDKLoginResult.__PropertyOffset_pfKey)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FCGSDKLoginResult.__PropertyOffset_pfKey)), value);
			}
		}

		// Token: 0x1700455E RID: 17758
		// (get) Token: 0x06011B6F RID: 72559 RVA: 0x001A0199 File Offset: 0x0019E399
		// (set) Token: 0x06011B70 RID: 72560 RVA: 0x001A01A9 File Offset: 0x0019E3A9
		public unsafe bool realNameAuth
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCGSDKLoginResult.__PropertyOffset_realNameAuth) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCGSDKLoginResult.__PropertyOffset_realNameAuth) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700455F RID: 17759
		// (get) Token: 0x06011B71 RID: 72561 RVA: 0x001A01BA File Offset: 0x0019E3BA
		// (set) Token: 0x06011B72 RID: 72562 RVA: 0x001A01CA File Offset: 0x0019E3CA
		public unsafe int channelID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCGSDKLoginResult.__PropertyOffset_channelID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCGSDKLoginResult.__PropertyOffset_channelID) = value;
			}
		}

		// Token: 0x17004560 RID: 17760
		// (get) Token: 0x06011B73 RID: 72563 RVA: 0x001A01DB File Offset: 0x0019E3DB
		// (set) Token: 0x06011B74 RID: 72564 RVA: 0x001A01EF File Offset: 0x0019E3EF
		public unsafe string channel
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FCGSDKLoginResult.__PropertyOffset_channel)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FCGSDKLoginResult.__PropertyOffset_channel)), value);
			}
		}

		// Token: 0x17004561 RID: 17761
		// (get) Token: 0x06011B75 RID: 72565 RVA: 0x001A0204 File Offset: 0x0019E404
		// (set) Token: 0x06011B76 RID: 72566 RVA: 0x001A0218 File Offset: 0x0019E418
		public unsafe string channelInfo
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FCGSDKLoginResult.__PropertyOffset_channelInfo)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FCGSDKLoginResult.__PropertyOffset_channelInfo)), value);
			}
		}

		// Token: 0x17004562 RID: 17762
		// (get) Token: 0x06011B77 RID: 72567 RVA: 0x001A022D File Offset: 0x0019E42D
		// (set) Token: 0x06011B78 RID: 72568 RVA: 0x001A0241 File Offset: 0x0019E441
		public unsafe string confirmCode
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FCGSDKLoginResult.__PropertyOffset_confirmCode)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FCGSDKLoginResult.__PropertyOffset_confirmCode)), value);
			}
		}

		// Token: 0x17004563 RID: 17763
		// (get) Token: 0x06011B79 RID: 72569 RVA: 0x001A0256 File Offset: 0x0019E456
		// (set) Token: 0x06011B7A RID: 72570 RVA: 0x001A0266 File Offset: 0x0019E466
		public unsafe long confirmCodeExpireTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCGSDKLoginResult.__PropertyOffset_confirmCodeExpireTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCGSDKLoginResult.__PropertyOffset_confirmCodeExpireTime) = value;
			}
		}

		// Token: 0x17004564 RID: 17764
		// (get) Token: 0x06011B7B RID: 72571 RVA: 0x001A0277 File Offset: 0x0019E477
		// (set) Token: 0x06011B7C RID: 72572 RVA: 0x001A028B File Offset: 0x0019E48B
		public unsafe string bindList
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FCGSDKLoginResult.__PropertyOffset_bindList)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FCGSDKLoginResult.__PropertyOffset_bindList)), value);
			}
		}

		// Token: 0x06011B7D RID: 72573 RVA: 0x001A02A0 File Offset: 0x0019E4A0
		public FCGSDKLoginResult()
		{
		}

		// Token: 0x06011B7E RID: 72574 RVA: 0x001A02A8 File Offset: 0x0019E4A8
		public FCGSDKLoginResult(int methodNameID, int retCode, string retMsg, int thirdCode, string thirdMsg, string extraJson, string openID, string token, long tokenExpire, int firstLogin, string regChannelDis, string userName, int gender, string birthdate, string pictureUrl, string pf, string pfKey, bool realNameAuth, int channelID, string channel, string channelInfo, string confirmCode, long confirmCodeExpireTime, string bindList)
		{
			this.methodNameID = methodNameID;
			this.retCode = retCode;
			this.retMsg = retMsg;
			this.thirdCode = thirdCode;
			this.thirdMsg = thirdMsg;
			this.extraJson = extraJson;
			this.openID = openID;
			this.token = token;
			this.tokenExpire = tokenExpire;
			this.firstLogin = firstLogin;
			this.regChannelDis = regChannelDis;
			this.userName = userName;
			this.gender = gender;
			this.birthdate = birthdate;
			this.pictureUrl = pictureUrl;
			this.pf = pf;
			this.pfKey = pfKey;
			this.realNameAuth = realNameAuth;
			this.channelID = channelID;
			this.channel = channel;
			this.channelInfo = channelInfo;
			this.confirmCode = confirmCode;
			this.confirmCodeExpireTime = confirmCodeExpireTime;
			this.bindList = bindList;
		}

		// Token: 0x06011B7F RID: 72575 RVA: 0x001A0378 File Offset: 0x0019E578
		protected override IntPtr GetUStructPtr()
		{
			return FCGSDKLoginResult.StaticStruct();
		}

		// Token: 0x06011B80 RID: 72576 RVA: 0x001A0384 File Offset: 0x0019E584
		[NullableContext(2)]
		public FCGSDKLoginResult(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06011B81 RID: 72577 RVA: 0x001A038E File Offset: 0x0019E58E
		public FCGSDKLoginResult(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06011B82 RID: 72578 RVA: 0x001A0399 File Offset: 0x0019E599
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FCGSDKLoginResult(Pointer, false, true);
		}

		// Token: 0x06011B83 RID: 72579 RVA: 0x001A03A3 File Offset: 0x0019E5A3
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FCGSDKLoginResult(Pointer, MemoryOwner);
		}

		// Token: 0x04009813 RID: 38931
		public const string __ObjectPath = "/Script/GameMatrix.CGSDKLoginResult";

		// Token: 0x04009814 RID: 38932
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04009815 RID: 38933
		internal static int __PropertyOffset_methodNameID;

		// Token: 0x04009816 RID: 38934
		internal static int __PropertyOffset_retCode;

		// Token: 0x04009817 RID: 38935
		internal static int __PropertyOffset_retMsg;

		// Token: 0x04009818 RID: 38936
		internal static int __PropertyOffset_thirdCode;

		// Token: 0x04009819 RID: 38937
		internal static int __PropertyOffset_thirdMsg;

		// Token: 0x0400981A RID: 38938
		internal static int __PropertyOffset_extraJson;

		// Token: 0x0400981B RID: 38939
		internal static int __PropertyOffset_openID;

		// Token: 0x0400981C RID: 38940
		internal static int __PropertyOffset_token;

		// Token: 0x0400981D RID: 38941
		internal static int __PropertyOffset_tokenExpire;

		// Token: 0x0400981E RID: 38942
		internal static int __PropertyOffset_firstLogin;

		// Token: 0x0400981F RID: 38943
		internal static int __PropertyOffset_regChannelDis;

		// Token: 0x04009820 RID: 38944
		internal static int __PropertyOffset_userName;

		// Token: 0x04009821 RID: 38945
		internal static int __PropertyOffset_gender;

		// Token: 0x04009822 RID: 38946
		internal static int __PropertyOffset_birthdate;

		// Token: 0x04009823 RID: 38947
		internal static int __PropertyOffset_pictureUrl;

		// Token: 0x04009824 RID: 38948
		internal static int __PropertyOffset_pf;

		// Token: 0x04009825 RID: 38949
		internal static int __PropertyOffset_pfKey;

		// Token: 0x04009826 RID: 38950
		internal static int __PropertyOffset_realNameAuth;

		// Token: 0x04009827 RID: 38951
		internal static int __PropertyOffset_channelID;

		// Token: 0x04009828 RID: 38952
		internal static int __PropertyOffset_channel;

		// Token: 0x04009829 RID: 38953
		internal static int __PropertyOffset_channelInfo;

		// Token: 0x0400982A RID: 38954
		internal static int __PropertyOffset_confirmCode;

		// Token: 0x0400982B RID: 38955
		internal static int __PropertyOffset_confirmCodeExpireTime;

		// Token: 0x0400982C RID: 38956
		internal static int __PropertyOffset_bindList;
	}
}
