using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200264A RID: 9802
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/PortalRpc.PortalRpcLocateServer")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 64)]
	public class FPortalRpcLocateServer : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060246D1 RID: 149201 RVA: 0x0035EC51 File Offset: 0x0035CE51
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FPortalRpcLocateServer._ScriptStructPtr != 0) ? FPortalRpcLocateServer._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/PortalRpc.PortalRpcLocateServer", ref FPortalRpcLocateServer._ScriptStructPtr);
		}

		// Token: 0x17008C62 RID: 35938
		// (get) Token: 0x060246D2 RID: 149202 RVA: 0x0035EC75 File Offset: 0x0035CE75
		// (set) Token: 0x060246D3 RID: 149203 RVA: 0x0035EC89 File Offset: 0x0035CE89
		public unsafe FGuid ProductId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPortalRpcLocateServer.__PropertyOffset_ProductId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPortalRpcLocateServer.__PropertyOffset_ProductId) = value;
			}
		}

		// Token: 0x17008C63 RID: 35939
		// (get) Token: 0x060246D4 RID: 149204 RVA: 0x0035EC9E File Offset: 0x0035CE9E
		// (set) Token: 0x060246D5 RID: 149205 RVA: 0x0035ECB2 File Offset: 0x0035CEB2
		public unsafe string ProductVersion
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FPortalRpcLocateServer.__PropertyOffset_ProductVersion)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FPortalRpcLocateServer.__PropertyOffset_ProductVersion)), value);
			}
		}

		// Token: 0x17008C64 RID: 35940
		// (get) Token: 0x060246D6 RID: 149206 RVA: 0x0035ECC7 File Offset: 0x0035CEC7
		// (set) Token: 0x060246D7 RID: 149207 RVA: 0x0035ECDB File Offset: 0x0035CEDB
		public unsafe string HostMacAddress
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FPortalRpcLocateServer.__PropertyOffset_HostMacAddress)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FPortalRpcLocateServer.__PropertyOffset_HostMacAddress)), value);
			}
		}

		// Token: 0x17008C65 RID: 35941
		// (get) Token: 0x060246D8 RID: 149208 RVA: 0x0035ECF0 File Offset: 0x0035CEF0
		// (set) Token: 0x060246D9 RID: 149209 RVA: 0x0035ED04 File Offset: 0x0035CF04
		public unsafe string HostUserId
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FPortalRpcLocateServer.__PropertyOffset_HostUserId)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FPortalRpcLocateServer.__PropertyOffset_HostUserId)), value);
			}
		}

		// Token: 0x060246DA RID: 149210 RVA: 0x0035ED19 File Offset: 0x0035CF19
		public FPortalRpcLocateServer()
		{
		}

		// Token: 0x060246DB RID: 149211 RVA: 0x0035ED21 File Offset: 0x0035CF21
		public FPortalRpcLocateServer(FGuid ProductId, string ProductVersion, string HostMacAddress, string HostUserId)
		{
			this.ProductId = ProductId;
			this.ProductVersion = ProductVersion;
			this.HostMacAddress = HostMacAddress;
			this.HostUserId = HostUserId;
		}

		// Token: 0x060246DC RID: 149212 RVA: 0x0035ED46 File Offset: 0x0035CF46
		protected override IntPtr GetUStructPtr()
		{
			return FPortalRpcLocateServer.StaticStruct();
		}

		// Token: 0x060246DD RID: 149213 RVA: 0x0035ED52 File Offset: 0x0035CF52
		[NullableContext(2)]
		public FPortalRpcLocateServer(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060246DE RID: 149214 RVA: 0x0035ED5C File Offset: 0x0035CF5C
		public FPortalRpcLocateServer(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060246DF RID: 149215 RVA: 0x0035ED67 File Offset: 0x0035CF67
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FPortalRpcLocateServer(Pointer, false, true);
		}

		// Token: 0x060246E0 RID: 149216 RVA: 0x0035ED71 File Offset: 0x0035CF71
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FPortalRpcLocateServer(Pointer, MemoryOwner);
		}

		// Token: 0x0401391A RID: 80154
		public const string __ObjectPath = "/Script/PortalRpc.PortalRpcLocateServer";

		// Token: 0x0401391B RID: 80155
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401391C RID: 80156
		internal static int __PropertyOffset_ProductId;

		// Token: 0x0401391D RID: 80157
		internal static int __PropertyOffset_ProductVersion;

		// Token: 0x0401391E RID: 80158
		internal static int __PropertyOffset_HostMacAddress;

		// Token: 0x0401391F RID: 80159
		internal static int __PropertyOffset_HostUserId;
	}
}
