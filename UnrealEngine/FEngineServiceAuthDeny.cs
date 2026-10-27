using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200078D RID: 1933
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/EngineMessages.EngineServiceAuthDeny")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FEngineServiceAuthDeny : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060064B5 RID: 25781 RVA: 0x0009082D File Offset: 0x0008EA2D
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FEngineServiceAuthDeny._ScriptStructPtr != 0) ? FEngineServiceAuthDeny._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/EngineMessages.EngineServiceAuthDeny", ref FEngineServiceAuthDeny._ScriptStructPtr);
		}

		// Token: 0x170017EA RID: 6122
		// (get) Token: 0x060064B6 RID: 25782 RVA: 0x00090851 File Offset: 0x0008EA51
		// (set) Token: 0x060064B7 RID: 25783 RVA: 0x00090865 File Offset: 0x0008EA65
		public unsafe string UserName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FEngineServiceAuthDeny.__PropertyOffset_UserName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FEngineServiceAuthDeny.__PropertyOffset_UserName)), value);
			}
		}

		// Token: 0x170017EB RID: 6123
		// (get) Token: 0x060064B8 RID: 25784 RVA: 0x0009087A File Offset: 0x0008EA7A
		// (set) Token: 0x060064B9 RID: 25785 RVA: 0x0009088E File Offset: 0x0008EA8E
		public unsafe string UserToDeny
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FEngineServiceAuthDeny.__PropertyOffset_UserToDeny)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FEngineServiceAuthDeny.__PropertyOffset_UserToDeny)), value);
			}
		}

		// Token: 0x060064BA RID: 25786 RVA: 0x000908A3 File Offset: 0x0008EAA3
		public FEngineServiceAuthDeny()
		{
		}

		// Token: 0x060064BB RID: 25787 RVA: 0x000908AB File Offset: 0x0008EAAB
		public FEngineServiceAuthDeny(string UserName, string UserToDeny)
		{
			this.UserName = UserName;
			this.UserToDeny = UserToDeny;
		}

		// Token: 0x060064BC RID: 25788 RVA: 0x000908C1 File Offset: 0x0008EAC1
		protected override IntPtr GetUStructPtr()
		{
			return FEngineServiceAuthDeny.StaticStruct();
		}

		// Token: 0x060064BD RID: 25789 RVA: 0x000908CD File Offset: 0x0008EACD
		[NullableContext(2)]
		public FEngineServiceAuthDeny(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060064BE RID: 25790 RVA: 0x000908D7 File Offset: 0x0008EAD7
		public FEngineServiceAuthDeny(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060064BF RID: 25791 RVA: 0x000908E2 File Offset: 0x0008EAE2
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FEngineServiceAuthDeny(Pointer, false, true);
		}

		// Token: 0x060064C0 RID: 25792 RVA: 0x000908EC File Offset: 0x0008EAEC
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FEngineServiceAuthDeny(Pointer, MemoryOwner);
		}

		// Token: 0x040030D3 RID: 12499
		public const string __ObjectPath = "/Script/EngineMessages.EngineServiceAuthDeny";

		// Token: 0x040030D4 RID: 12500
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040030D5 RID: 12501
		internal static int __PropertyOffset_UserName;

		// Token: 0x040030D6 RID: 12502
		internal static int __PropertyOffset_UserToDeny;
	}
}
