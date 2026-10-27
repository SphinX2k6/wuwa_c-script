using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200264B RID: 9803
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/PortalRpc.PortalRpcServer")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FPortalRpcServer : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060246E1 RID: 149217 RVA: 0x0035ED7A File Offset: 0x0035CF7A
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FPortalRpcServer._ScriptStructPtr != 0) ? FPortalRpcServer._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/PortalRpc.PortalRpcServer", ref FPortalRpcServer._ScriptStructPtr);
		}

		// Token: 0x17008C66 RID: 35942
		// (get) Token: 0x060246E2 RID: 149218 RVA: 0x0035ED9E File Offset: 0x0035CF9E
		// (set) Token: 0x060246E3 RID: 149219 RVA: 0x0035EDB2 File Offset: 0x0035CFB2
		public unsafe string ServerAddress
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FPortalRpcServer.__PropertyOffset_ServerAddress)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FPortalRpcServer.__PropertyOffset_ServerAddress)), value);
			}
		}

		// Token: 0x060246E4 RID: 149220 RVA: 0x0035EDC7 File Offset: 0x0035CFC7
		public FPortalRpcServer()
		{
		}

		// Token: 0x060246E5 RID: 149221 RVA: 0x0035EDCF File Offset: 0x0035CFCF
		public FPortalRpcServer(string ServerAddress)
		{
			this.ServerAddress = ServerAddress;
		}

		// Token: 0x060246E6 RID: 149222 RVA: 0x0035EDDE File Offset: 0x0035CFDE
		protected override IntPtr GetUStructPtr()
		{
			return FPortalRpcServer.StaticStruct();
		}

		// Token: 0x060246E7 RID: 149223 RVA: 0x0035EDEA File Offset: 0x0035CFEA
		[NullableContext(2)]
		public FPortalRpcServer(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060246E8 RID: 149224 RVA: 0x0035EDF4 File Offset: 0x0035CFF4
		public FPortalRpcServer(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060246E9 RID: 149225 RVA: 0x0035EDFF File Offset: 0x0035CFFF
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FPortalRpcServer(Pointer, false, true);
		}

		// Token: 0x060246EA RID: 149226 RVA: 0x0035EE09 File Offset: 0x0035D009
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FPortalRpcServer(Pointer, MemoryOwner);
		}

		// Token: 0x04013920 RID: 80160
		public const string __ObjectPath = "/Script/PortalRpc.PortalRpcServer";

		// Token: 0x04013921 RID: 80161
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04013922 RID: 80162
		internal static int __PropertyOffset_ServerAddress;
	}
}
