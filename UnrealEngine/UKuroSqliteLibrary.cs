using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020005AF RID: 1455
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroSqliteBpLib.KuroSqliteLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UKuroSqliteLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060082E0 RID: 33504 RVA: 0x000C174D File Offset: 0x000BF94D
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroSqliteLibrary._ClassPtr;
		}

		// Token: 0x060082E1 RID: 33505 RVA: 0x000C175C File Offset: 0x000BF95C
		public UKuroSqliteLibrary() : this(BuiltinUtils.AllocNativeUObject(UKuroSqliteLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060082E2 RID: 33506 RVA: 0x000C1784 File Offset: 0x000BF984
		public UKuroSqliteLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroSqliteLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060082E3 RID: 33507
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int SqliteStatusGetHighWater(int StatusOp, bool ResetHighWater = false);

		// Token: 0x060082E4 RID: 33508
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int SqliteStatusGetCurrent(int StatusOp);

		// Token: 0x060082E5 RID: 33509 RVA: 0x000C17B8 File Offset: 0x000BF9B8
		public unsafe static void SetDBKey(string DBKey)
		{
			FString fstring = FString.AllocTemp(DBKey);
			UKuroSqliteLibrary.__SetDBKey_Internal(fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x060082E6 RID: 33510 RVA: 0x000C17DC File Offset: 0x000BF9DC
		public unsafe static int QueryValue(string DbPath, string Sql, ref string OutValue)
		{
			FString fstring = FString.AllocTemp(DbPath);
			FString fstring2 = FString.AllocTemp(Sql);
			FString fstring3 = FString.AllocTemp(OutValue);
			int result = UKuroSqliteLibrary.__QueryValue_Internal(fstring, fstring2, ref fstring3);
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
			OutValue = FString.ToString(fstring3);
			FString.NativeDestruct(&fstring3, 1);
			return result;
		}

		// Token: 0x060082E7 RID: 33511 RVA: 0x000C1830 File Offset: 0x000BFA30
		public unsafe static bool Query(string DbPath, string Sql, [Nullable(2)] UKuroSqliteResultSet ResultSet)
		{
			FString fstring = FString.AllocTemp(DbPath);
			FString fstring2 = FString.AllocTemp(Sql);
			bool result = UKuroSqliteLibrary.__Query_Internal(fstring, fstring2, (ResultSet != null) ? ResultSet.NativePtr : IntPtr.Zero);
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
			return result;
		}

		// Token: 0x060082E8 RID: 33512 RVA: 0x000C1878 File Offset: 0x000BFA78
		public unsafe static bool OpenCreateDB(string DbPath, bool bUseThread = false)
		{
			FString fstring = FString.AllocTemp(DbPath);
			bool result = UKuroSqliteLibrary.__OpenCreateDB_Internal(fstring, bUseThread);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x060082E9 RID: 33513 RVA: 0x000C18A0 File Offset: 0x000BFAA0
		public unsafe static void ExecuteAsync(string DbPath, string Sql)
		{
			FString fstring = FString.AllocTemp(DbPath);
			FString fstring2 = FString.AllocTemp(Sql);
			UKuroSqliteLibrary.__ExecuteAsync_Internal(fstring, fstring2);
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
		}

		// Token: 0x060082EA RID: 33514 RVA: 0x000C18D8 File Offset: 0x000BFAD8
		public unsafe static bool Execute(string DbPath, string Sql)
		{
			FString fstring = FString.AllocTemp(DbPath);
			FString fstring2 = FString.AllocTemp(Sql);
			bool result = UKuroSqliteLibrary.__Execute_Internal(fstring, fstring2);
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
			return result;
		}

		// Token: 0x060082EB RID: 33515
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void CloseAllConnections();

		// Token: 0x060082EC RID: 33516
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetDBKey_Internal(in FString DBKey);

		// Token: 0x060082ED RID: 33517
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __QueryValue_Internal(in FString DbPath, in FString Sql, ref FString OutValue);

		// Token: 0x060082EE RID: 33518
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __Query_Internal(in FString DbPath, in FString Sql, IntPtr ResultSet);

		// Token: 0x060082EF RID: 33519
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __OpenCreateDB_Internal(in FString DbPath, bool bUseThread);

		// Token: 0x060082F0 RID: 33520
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ExecuteAsync_Internal(in FString DbPath, in FString Sql);

		// Token: 0x060082F1 RID: 33521
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __Execute_Internal(in FString DbPath, in FString Sql);

		// Token: 0x060082F2 RID: 33522 RVA: 0x000C190E File Offset: 0x000BFB0E
		static UKuroSqliteLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSqliteBpLib.KuroSqliteLibrary");
		}

		// Token: 0x060082F3 RID: 33523 RVA: 0x000C191C File Offset: 0x000BFB1C
		protected UKuroSqliteLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040038F6 RID: 14582
		public new const string __ObjectPath = "/Script/KuroSqliteBpLib.KuroSqliteLibrary";

		// Token: 0x040038F7 RID: 14583
		private static IntPtr _ClassPtr;

		// Token: 0x040038F8 RID: 14584
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
