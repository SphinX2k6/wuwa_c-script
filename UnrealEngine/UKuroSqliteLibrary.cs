using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001E80 RID: 7808
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroSqliteBpLib.KuroSqliteLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UKuroSqliteLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601DB93 RID: 121747 RVA: 0x002BE854 File Offset: 0x002BCA54
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroSqliteLibrary._ClassPtr;
		}

		// Token: 0x0601DB94 RID: 121748 RVA: 0x002BE860 File Offset: 0x002BCA60
		public UKuroSqliteLibrary() : this(BuiltinUtils.AllocNativeUObject(UKuroSqliteLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601DB95 RID: 121749 RVA: 0x002BE888 File Offset: 0x002BCA88
		public UKuroSqliteLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroSqliteLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601DB96 RID: 121750
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int SqliteStatusGetHighWater(int StatusOp, bool ResetHighWater = false);

		// Token: 0x0601DB97 RID: 121751
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int SqliteStatusGetCurrent(int StatusOp);

		// Token: 0x0601DB98 RID: 121752 RVA: 0x002BE8BC File Offset: 0x002BCABC
		public unsafe static void SetDBKey(string DBKey)
		{
			FString fstring = FString.AllocTemp(DBKey);
			UKuroSqliteLibrary.__SetDBKey_Internal(fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x0601DB99 RID: 121753 RVA: 0x002BE8E0 File Offset: 0x002BCAE0
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

		// Token: 0x0601DB9A RID: 121754 RVA: 0x002BE934 File Offset: 0x002BCB34
		public unsafe static bool Query(string DbPath, string Sql, [Nullable(2)] UKuroSqliteResultSet ResultSet)
		{
			FString fstring = FString.AllocTemp(DbPath);
			FString fstring2 = FString.AllocTemp(Sql);
			bool result = UKuroSqliteLibrary.__Query_Internal(fstring, fstring2, (ResultSet != null) ? ResultSet.NativePtr : IntPtr.Zero);
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
			return result;
		}

		// Token: 0x0601DB9B RID: 121755 RVA: 0x002BE97C File Offset: 0x002BCB7C
		public unsafe static bool OpenCreateDB(string DbPath, bool bUseThread = false)
		{
			FString fstring = FString.AllocTemp(DbPath);
			bool result = UKuroSqliteLibrary.__OpenCreateDB_Internal(fstring, bUseThread);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x0601DB9C RID: 121756 RVA: 0x002BE9A4 File Offset: 0x002BCBA4
		public unsafe static void ExecuteAsync(string DbPath, string Sql)
		{
			FString fstring = FString.AllocTemp(DbPath);
			FString fstring2 = FString.AllocTemp(Sql);
			UKuroSqliteLibrary.__ExecuteAsync_Internal(fstring, fstring2);
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
		}

		// Token: 0x0601DB9D RID: 121757 RVA: 0x002BE9DC File Offset: 0x002BCBDC
		public unsafe static bool Execute(string DbPath, string Sql)
		{
			FString fstring = FString.AllocTemp(DbPath);
			FString fstring2 = FString.AllocTemp(Sql);
			bool result = UKuroSqliteLibrary.__Execute_Internal(fstring, fstring2);
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
			return result;
		}

		// Token: 0x0601DB9E RID: 121758
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void CloseAllConnections();

		// Token: 0x0601DB9F RID: 121759
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetDBKey_Internal(in FString DBKey);

		// Token: 0x0601DBA0 RID: 121760
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __QueryValue_Internal(in FString DbPath, in FString Sql, ref FString OutValue);

		// Token: 0x0601DBA1 RID: 121761
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __Query_Internal(in FString DbPath, in FString Sql, IntPtr ResultSet);

		// Token: 0x0601DBA2 RID: 121762
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __OpenCreateDB_Internal(in FString DbPath, bool bUseThread);

		// Token: 0x0601DBA3 RID: 121763
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ExecuteAsync_Internal(in FString DbPath, in FString Sql);

		// Token: 0x0601DBA4 RID: 121764
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __Execute_Internal(in FString DbPath, in FString Sql);

		// Token: 0x0601DBA5 RID: 121765 RVA: 0x002BEA12 File Offset: 0x002BCC12
		static UKuroSqliteLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSqliteBpLib.KuroSqliteLibrary");
		}

		// Token: 0x0601DBA6 RID: 121766 RVA: 0x002BEA20 File Offset: 0x002BCC20
		protected UKuroSqliteLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401017D RID: 65917
		public new const string __ObjectPath = "/Script/KuroSqliteBpLib.KuroSqliteLibrary";

		// Token: 0x0401017E RID: 65918
		private static IntPtr _ClassPtr;

		// Token: 0x0401017F RID: 65919
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
