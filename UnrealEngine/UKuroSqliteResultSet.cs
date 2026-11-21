using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020005B0 RID: 1456
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroSqliteBpLib.KuroSqliteResultSet")]
	[UnrealStructLayout(120, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 120)]
	public class UKuroSqliteResultSet : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060082F4 RID: 33524 RVA: 0x000C1925 File Offset: 0x000BFB25
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroSqliteResultSet._ClassPtr;
		}

		// Token: 0x060082F5 RID: 33525 RVA: 0x000C1934 File Offset: 0x000BFB34
		public UKuroSqliteResultSet() : this(BuiltinUtils.AllocNativeUObject(UKuroSqliteResultSet.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060082F6 RID: 33526 RVA: 0x000C195C File Offset: 0x000BFB5C
		public UKuroSqliteResultSet(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroSqliteResultSet.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001951 RID: 6481
		// (get) Token: 0x060082F7 RID: 33527 RVA: 0x000C1990 File Offset: 0x000BFB90
		// (set) Token: 0x060082F8 RID: 33528 RVA: 0x000C19C9 File Offset: 0x000BFBC9
		public FQueriedCallback QueriedCallback
		{
			get
			{
				base.FastCheckIsValid();
				FQueriedCallback result;
				if ((result = this._QueriedCallback) == null)
				{
					result = (this._QueriedCallback = new FQueriedCallback(base.NativePtr + (IntPtr)UKuroSqliteResultSet.__PropertyOffset_QueriedCallback, this));
				}
				return result;
			}
			set
			{
				FScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UKuroSqliteResultSet.__PropertyOffset_QueriedCallback, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x060082F9 RID: 33529 RVA: 0x000C19EA File Offset: 0x000BFBEA
		public void Release()
		{
			UKuroSqliteResultSet.__Release_Internal(base.NativePtr);
		}

		// Token: 0x060082FA RID: 33530 RVA: 0x000C19F7 File Offset: 0x000BFBF7
		public bool MoveToNext()
		{
			return UKuroSqliteResultSet.__MoveToNext_Internal(base.NativePtr);
		}

		// Token: 0x060082FB RID: 33531 RVA: 0x000C1A04 File Offset: 0x000BFC04
		public bool HasValue()
		{
			return UKuroSqliteResultSet.__HasValue_Internal(base.NativePtr);
		}

		// Token: 0x060082FC RID: 33532 RVA: 0x000C1A14 File Offset: 0x000BFC14
		public unsafe bool GetString(string Column, ref string Value)
		{
			FString fstring = FString.AllocTemp(Column);
			FString fstring2 = FString.AllocTemp(Value);
			bool result = UKuroSqliteResultSet.__GetString_Internal(base.NativePtr, fstring, ref fstring2);
			FString.NativeDestruct(&fstring, 1);
			Value = FString.ToString(fstring2);
			FString.NativeDestruct(&fstring2, 1);
			return result;
		}

		// Token: 0x060082FD RID: 33533 RVA: 0x000C1A5C File Offset: 0x000BFC5C
		public unsafe bool GetInt(string Column, ref int Value)
		{
			FString fstring = FString.AllocTemp(Column);
			fixed (int* ptr = &Value)
			{
				void* ptr2 = (void*)ptr;
				bool result = UKuroSqliteResultSet.__GetInt_Internal(base.NativePtr, fstring, ref Value);
				FString.NativeDestruct(&fstring, 1);
				return result;
			}
		}

		// Token: 0x060082FE RID: 33534 RVA: 0x000C1A8C File Offset: 0x000BFC8C
		public unsafe bool GetFloat(string Column, ref float Value)
		{
			FString fstring = FString.AllocTemp(Column);
			fixed (float* ptr = &Value)
			{
				void* ptr2 = (void*)ptr;
				bool result = UKuroSqliteResultSet.__GetFloat_Internal(base.NativePtr, fstring, ref Value);
				FString.NativeDestruct(&fstring, 1);
				return result;
			}
		}

		// Token: 0x060082FF RID: 33535 RVA: 0x000C1ABC File Offset: 0x000BFCBC
		public unsafe bool GetBytes(string Column, ref FArrayBuffer Value)
		{
			FString fstring = FString.AllocTemp(Column);
			fixed (FArrayBuffer* ptr = &Value)
			{
				void* ptr2 = (void*)ptr;
				bool result = UKuroSqliteResultSet.__GetBytes_Internal(base.NativePtr, fstring, ref Value);
				FString.NativeDestruct(&fstring, 1);
				return result;
			}
		}

		// Token: 0x06008300 RID: 33536 RVA: 0x000C1AEC File Offset: 0x000BFCEC
		public unsafe bool GetBool(string Column, ref bool Value)
		{
			FString fstring = FString.AllocTemp(Column);
			fixed (bool* ptr = &Value)
			{
				void* ptr2 = (void*)ptr;
				bool result = UKuroSqliteResultSet.__GetBool_Internal(base.NativePtr, fstring, ref Value);
				FString.NativeDestruct(&fstring, 1);
				return result;
			}
		}

		// Token: 0x06008301 RID: 33537 RVA: 0x000C1B1C File Offset: 0x000BFD1C
		public unsafe bool GetBigInt(string Column, ref long Value)
		{
			FString fstring = FString.AllocTemp(Column);
			fixed (long* ptr = &Value)
			{
				void* ptr2 = (void*)ptr;
				bool result = UKuroSqliteResultSet.__GetBigInt_Internal(base.NativePtr, fstring, ref Value);
				FString.NativeDestruct(&fstring, 1);
				return result;
			}
		}

		// Token: 0x06008302 RID: 33538
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Release_Internal(IntPtr @this);

		// Token: 0x06008303 RID: 33539
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __MoveToNext_Internal(IntPtr @this);

		// Token: 0x06008304 RID: 33540
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __HasValue_Internal(IntPtr @this);

		// Token: 0x06008305 RID: 33541
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetString_Internal(IntPtr @this, in FString Column, ref FString Value);

		// Token: 0x06008306 RID: 33542
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetInt_Internal(IntPtr @this, in FString Column, ref int Value);

		// Token: 0x06008307 RID: 33543
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetFloat_Internal(IntPtr @this, in FString Column, ref float Value);

		// Token: 0x06008308 RID: 33544
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetBytes_Internal(IntPtr @this, in FString Column, ref FArrayBuffer Value);

		// Token: 0x06008309 RID: 33545
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetBool_Internal(IntPtr @this, in FString Column, ref bool Value);

		// Token: 0x0600830A RID: 33546
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetBigInt_Internal(IntPtr @this, in FString Column, ref long Value);

		// Token: 0x0600830B RID: 33547 RVA: 0x000C1B4C File Offset: 0x000BFD4C
		static UKuroSqliteResultSet()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSqliteBpLib.KuroSqliteResultSet");
		}

		// Token: 0x0600830C RID: 33548 RVA: 0x000C1B5A File Offset: 0x000BFD5A
		protected UKuroSqliteResultSet(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040038F9 RID: 14585
		public new const string __ObjectPath = "/Script/KuroSqliteBpLib.KuroSqliteResultSet";

		// Token: 0x040038FA RID: 14586
		private static IntPtr _ClassPtr;

		// Token: 0x040038FB RID: 14587
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040038FC RID: 14588
		internal static int __PropertyOffset_QueriedCallback;

		// Token: 0x040038FD RID: 14589
		[Nullable(2)]
		private FQueriedCallback _QueriedCallback;
	}
}
