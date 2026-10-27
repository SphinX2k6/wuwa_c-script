using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020029ED RID: 10733
	[UnrealObjectPath("/Script/UMG.UserObjectListEntryLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UUserObjectListEntryLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06027C18 RID: 162840 RVA: 0x003C99AD File Offset: 0x003C7BAD
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUserObjectListEntryLibrary._ClassPtr;
		}

		// Token: 0x06027C19 RID: 162841 RVA: 0x003C99BC File Offset: 0x003C7BBC
		public UUserObjectListEntryLibrary() : this(BuiltinUtils.AllocNativeUObject(UUserObjectListEntryLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06027C1A RID: 162842 RVA: 0x003C99E4 File Offset: 0x003C7BE4
		[NullableContext(1)]
		public UUserObjectListEntryLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UUserObjectListEntryLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06027C1B RID: 162843 RVA: 0x003C9A18 File Offset: 0x003C7C18
		[NullableContext(2)]
		public static UObject GetListItemObject(IUserObjectListEntry UserObjectListEntry)
		{
			FScriptInterface fscriptInterface = new FScriptInterface(UserObjectListEntry, (UserObjectListEntry != null) ? UserObjectListEntry.InterfaceOffset() : 0);
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UObject>(UUserObjectListEntryLibrary.__GetListItemObject_Internal(fscriptInterface));
		}

		// Token: 0x06027C1C RID: 162844
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetListItemObject_Internal(in FScriptInterface UserObjectListEntry);

		// Token: 0x06027C1D RID: 162845 RVA: 0x003C9A45 File Offset: 0x003C7C45
		static UUserObjectListEntryLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/UMG.UserObjectListEntryLibrary");
		}

		// Token: 0x06027C1E RID: 162846 RVA: 0x003C9A53 File Offset: 0x003C7C53
		protected UUserObjectListEntryLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015C36 RID: 89142
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/UMG.UserObjectListEntryLibrary";

		// Token: 0x04015C37 RID: 89143
		private static IntPtr _ClassPtr;

		// Token: 0x04015C38 RID: 89144
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
