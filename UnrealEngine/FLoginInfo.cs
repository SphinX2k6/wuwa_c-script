using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200173F RID: 5951
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroCloudGame.LoginInfo")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 72)]
	public class FLoginInfo : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06015693 RID: 87699 RVA: 0x001F7794 File Offset: 0x001F5994
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FLoginInfo._ScriptStructPtr != 0) ? FLoginInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroCloudGame.LoginInfo", ref FLoginInfo._ScriptStructPtr);
		}

		// Token: 0x1700548C RID: 21644
		// (get) Token: 0x06015694 RID: 87700 RVA: 0x001F77B8 File Offset: 0x001F59B8
		// (set) Token: 0x06015695 RID: 87701 RVA: 0x001F77CC File Offset: 0x001F59CC
		public unsafe string DeviceId
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FLoginInfo.__PropertyOffset_DeviceId)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FLoginInfo.__PropertyOffset_DeviceId)), value);
			}
		}

		// Token: 0x1700548D RID: 21645
		// (get) Token: 0x06015696 RID: 87702 RVA: 0x001F77E1 File Offset: 0x001F59E1
		// (set) Token: 0x06015697 RID: 87703 RVA: 0x001F77F1 File Offset: 0x001F59F1
		public unsafe int LoginCode
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLoginInfo.__PropertyOffset_LoginCode);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLoginInfo.__PropertyOffset_LoginCode) = value;
			}
		}

		// Token: 0x1700548E RID: 21646
		// (get) Token: 0x06015698 RID: 87704 RVA: 0x001F7802 File Offset: 0x001F5A02
		// (set) Token: 0x06015699 RID: 87705 RVA: 0x001F7816 File Offset: 0x001F5A16
		public unsafe string Token
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FLoginInfo.__PropertyOffset_Token)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FLoginInfo.__PropertyOffset_Token)), value);
			}
		}

		// Token: 0x1700548F RID: 21647
		// (get) Token: 0x0601569A RID: 87706 RVA: 0x001F782B File Offset: 0x001F5A2B
		// (set) Token: 0x0601569B RID: 87707 RVA: 0x001F783F File Offset: 0x001F5A3F
		public unsafe string Uid
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FLoginInfo.__PropertyOffset_Uid)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FLoginInfo.__PropertyOffset_Uid)), value);
			}
		}

		// Token: 0x17005490 RID: 21648
		// (get) Token: 0x0601569C RID: 87708 RVA: 0x001F7854 File Offset: 0x001F5A54
		// (set) Token: 0x0601569D RID: 87709 RVA: 0x001F7868 File Offset: 0x001F5A68
		public unsafe string UserName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FLoginInfo.__PropertyOffset_UserName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FLoginInfo.__PropertyOffset_UserName)), value);
			}
		}

		// Token: 0x0601569E RID: 87710 RVA: 0x001F787D File Offset: 0x001F5A7D
		public FLoginInfo()
		{
		}

		// Token: 0x0601569F RID: 87711 RVA: 0x001F7885 File Offset: 0x001F5A85
		public FLoginInfo(string DeviceId, int LoginCode, string Token, string Uid, string UserName)
		{
			this.DeviceId = DeviceId;
			this.LoginCode = LoginCode;
			this.Token = Token;
			this.Uid = Uid;
			this.UserName = UserName;
		}

		// Token: 0x060156A0 RID: 87712 RVA: 0x001F78B2 File Offset: 0x001F5AB2
		protected override IntPtr GetUStructPtr()
		{
			return FLoginInfo.StaticStruct();
		}

		// Token: 0x060156A1 RID: 87713 RVA: 0x001F78BE File Offset: 0x001F5ABE
		[NullableContext(2)]
		public FLoginInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060156A2 RID: 87714 RVA: 0x001F78C8 File Offset: 0x001F5AC8
		public FLoginInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060156A3 RID: 87715 RVA: 0x001F78D3 File Offset: 0x001F5AD3
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FLoginInfo(Pointer, false, true);
		}

		// Token: 0x060156A4 RID: 87716 RVA: 0x001F78DD File Offset: 0x001F5ADD
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FLoginInfo(Pointer, MemoryOwner);
		}

		// Token: 0x0400BACB RID: 47819
		public const string __ObjectPath = "/Script/KuroCloudGame.LoginInfo";

		// Token: 0x0400BACC RID: 47820
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400BACD RID: 47821
		internal static int __PropertyOffset_DeviceId;

		// Token: 0x0400BACE RID: 47822
		internal static int __PropertyOffset_LoginCode;

		// Token: 0x0400BACF RID: 47823
		internal static int __PropertyOffset_Token;

		// Token: 0x0400BAD0 RID: 47824
		internal static int __PropertyOffset_Uid;

		// Token: 0x0400BAD1 RID: 47825
		internal static int __PropertyOffset_UserName;
	}
}
