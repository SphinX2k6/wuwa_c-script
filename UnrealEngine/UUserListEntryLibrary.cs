using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020029EB RID: 10731
	[UnrealObjectPath("/Script/UMG.UserListEntryLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UUserListEntryLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06027C0B RID: 162827 RVA: 0x003C985A File Offset: 0x003C7A5A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUserListEntryLibrary._ClassPtr;
		}

		// Token: 0x06027C0C RID: 162828 RVA: 0x003C9868 File Offset: 0x003C7A68
		public UUserListEntryLibrary() : this(BuiltinUtils.AllocNativeUObject(UUserListEntryLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06027C0D RID: 162829 RVA: 0x003C9890 File Offset: 0x003C7A90
		[NullableContext(1)]
		public UUserListEntryLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UUserListEntryLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06027C0E RID: 162830 RVA: 0x003C98C4 File Offset: 0x003C7AC4
		[NullableContext(2)]
		public static bool IsListItemSelected(IUserListEntry UserListEntry)
		{
			FScriptInterface fscriptInterface = new FScriptInterface(UserListEntry, (UserListEntry != null) ? UserListEntry.InterfaceOffset() : 0);
			return UUserListEntryLibrary.__IsListItemSelected_Internal(fscriptInterface);
		}

		// Token: 0x06027C0F RID: 162831 RVA: 0x003C98EC File Offset: 0x003C7AEC
		[NullableContext(2)]
		public static bool IsListItemExpanded(IUserListEntry UserListEntry)
		{
			FScriptInterface fscriptInterface = new FScriptInterface(UserListEntry, (UserListEntry != null) ? UserListEntry.InterfaceOffset() : 0);
			return UUserListEntryLibrary.__IsListItemExpanded_Internal(fscriptInterface);
		}

		// Token: 0x06027C10 RID: 162832 RVA: 0x003C9914 File Offset: 0x003C7B14
		[NullableContext(2)]
		public static UListViewBase GetOwningListView(IUserListEntry UserListEntry)
		{
			FScriptInterface fscriptInterface = new FScriptInterface(UserListEntry, (UserListEntry != null) ? UserListEntry.InterfaceOffset() : 0);
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UListViewBase>(UUserListEntryLibrary.__GetOwningListView_Internal(fscriptInterface));
		}

		// Token: 0x06027C11 RID: 162833
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsListItemSelected_Internal(in FScriptInterface UserListEntry);

		// Token: 0x06027C12 RID: 162834
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsListItemExpanded_Internal(in FScriptInterface UserListEntry);

		// Token: 0x06027C13 RID: 162835
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetOwningListView_Internal(in FScriptInterface UserListEntry);

		// Token: 0x06027C14 RID: 162836 RVA: 0x003C9941 File Offset: 0x003C7B41
		static UUserListEntryLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/UMG.UserListEntryLibrary");
		}

		// Token: 0x06027C15 RID: 162837 RVA: 0x003C994F File Offset: 0x003C7B4F
		protected UUserListEntryLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015C32 RID: 89138
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/UMG.UserListEntryLibrary";

		// Token: 0x04015C33 RID: 89139
		private static IntPtr _ClassPtr;

		// Token: 0x04015C34 RID: 89140
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
