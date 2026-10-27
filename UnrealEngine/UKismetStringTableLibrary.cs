using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000CD5 RID: 3285
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.KismetStringTableLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UKismetStringTableLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600ABA2 RID: 43938 RVA: 0x000F1479 File Offset: 0x000EF679
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKismetStringTableLibrary._ClassPtr;
		}

		// Token: 0x0600ABA3 RID: 43939 RVA: 0x000F1488 File Offset: 0x000EF688
		public UKismetStringTableLibrary() : this(BuiltinUtils.AllocNativeUObject(UKismetStringTableLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600ABA4 RID: 43940 RVA: 0x000F14B0 File Offset: 0x000EF6B0
		public UKismetStringTableLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKismetStringTableLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600ABA5 RID: 43941
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool IsRegisteredTableId(FName TableId);

		// Token: 0x0600ABA6 RID: 43942 RVA: 0x000F14E4 File Offset: 0x000EF6E4
		public unsafe static bool IsRegisteredTableEntry(FName TableId, string Key)
		{
			FString fstring = FString.AllocTemp(Key);
			bool result = UKismetStringTableLibrary.__IsRegisteredTableEntry_Internal(TableId, fstring);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x0600ABA7 RID: 43943 RVA: 0x000F1509 File Offset: 0x000EF709
		public static string GetTableNamespace(FName TableId)
		{
			return FString.ToStringAndDeleteNativePtr(UKismetStringTableLibrary.__GetTableNamespace_Internal(TableId));
		}

		// Token: 0x0600ABA8 RID: 43944 RVA: 0x000F1518 File Offset: 0x000EF718
		public unsafe static string GetTableEntrySourceString(FName TableId, string Key)
		{
			FString fstring = FString.AllocTemp(Key);
			string result = FString.ToStringAndDeleteNativePtr(UKismetStringTableLibrary.__GetTableEntrySourceString_Internal(TableId, fstring));
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x0600ABA9 RID: 43945 RVA: 0x000F1544 File Offset: 0x000EF744
		public unsafe static string GetTableEntryMetaData(FName TableId, string Key, FName MetaDataId)
		{
			FString fstring = FString.AllocTemp(Key);
			string result = FString.ToStringAndDeleteNativePtr(UKismetStringTableLibrary.__GetTableEntryMetaData_Internal(TableId, fstring, MetaDataId));
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x0600ABAA RID: 43946 RVA: 0x000F156F File Offset: 0x000EF76F
		public static TArray<FName> GetRegisteredStringTables()
		{
			return new TArray<FName>(UKismetStringTableLibrary.__GetRegisteredStringTables_Internal(), null);
		}

		// Token: 0x0600ABAB RID: 43947 RVA: 0x000F157C File Offset: 0x000EF77C
		public unsafe static TArray<FName> GetMetaDataIdsFromStringTableEntry(FName TableId, string Key)
		{
			FString fstring = FString.AllocTemp(Key);
			TArray<FName> result = new TArray<FName>(UKismetStringTableLibrary.__GetMetaDataIdsFromStringTableEntry_Internal(TableId, fstring), null);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x0600ABAC RID: 43948 RVA: 0x000F15A7 File Offset: 0x000EF7A7
		public static TArray<string> GetKeysFromStringTable(FName TableId)
		{
			return new TArray<string>(UKismetStringTableLibrary.__GetKeysFromStringTable_Internal(TableId), null);
		}

		// Token: 0x0600ABAD RID: 43949
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsRegisteredTableEntry_Internal(FName TableId, in FString Key);

		// Token: 0x0600ABAE RID: 43950
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetTableNamespace_Internal(FName TableId);

		// Token: 0x0600ABAF RID: 43951
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetTableEntrySourceString_Internal(FName TableId, in FString Key);

		// Token: 0x0600ABB0 RID: 43952
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetTableEntryMetaData_Internal(FName TableId, in FString Key, FName MetaDataId);

		// Token: 0x0600ABB1 RID: 43953
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetRegisteredStringTables_Internal();

		// Token: 0x0600ABB2 RID: 43954
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetMetaDataIdsFromStringTableEntry_Internal(FName TableId, in FString Key);

		// Token: 0x0600ABB3 RID: 43955
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetKeysFromStringTable_Internal(FName TableId);

		// Token: 0x0600ABB4 RID: 43956 RVA: 0x000F15B5 File Offset: 0x000EF7B5
		static UKismetStringTableLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.KismetStringTableLibrary");
		}

		// Token: 0x0600ABB5 RID: 43957 RVA: 0x000F15C3 File Offset: 0x000EF7C3
		protected UKismetStringTableLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04005B46 RID: 23366
		public new const string __ObjectPath = "/Script/Engine.KismetStringTableLibrary";

		// Token: 0x04005B47 RID: 23367
		private static IntPtr _ClassPtr;

		// Token: 0x04005B48 RID: 23368
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
