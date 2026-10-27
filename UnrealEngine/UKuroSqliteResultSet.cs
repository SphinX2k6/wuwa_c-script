using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001E81 RID: 7809
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroSqliteBpLib.KuroSqliteResultSet")]
	[UnrealStructLayout(120, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 120)]
	public class UKuroSqliteResultSet : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601DBA7 RID: 121767 RVA: 0x002BEA29 File Offset: 0x002BCC29
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroSqliteResultSet._ClassPtr;
		}

		// Token: 0x0601DBA8 RID: 121768 RVA: 0x002BEA38 File Offset: 0x002BCC38
		public UKuroSqliteResultSet() : this(BuiltinUtils.AllocNativeUObject(UKuroSqliteResultSet.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601DBA9 RID: 121769 RVA: 0x002BEA60 File Offset: 0x002BCC60
		public UKuroSqliteResultSet(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroSqliteResultSet.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007778 RID: 30584
		// (get) Token: 0x0601DBAA RID: 121770 RVA: 0x002BEA94 File Offset: 0x002BCC94
		// (set) Token: 0x0601DBAB RID: 121771 RVA: 0x002BEACD File Offset: 0x002BCCCD
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

		// Token: 0x0601DBAC RID: 121772 RVA: 0x002BEAEE File Offset: 0x002BCCEE
		public void Release()
		{
			UKuroSqliteResultSet.__Release_Internal(base.NativePtr);
		}

		// Token: 0x0601DBAD RID: 121773 RVA: 0x002BEAFB File Offset: 0x002BCCFB
		public bool MoveToNext()
		{
			return UKuroSqliteResultSet.__MoveToNext_Internal(base.NativePtr);
		}

		// Token: 0x0601DBAE RID: 121774 RVA: 0x002BEB08 File Offset: 0x002BCD08
		public bool HasValue()
		{
			return UKuroSqliteResultSet.__HasValue_Internal(base.NativePtr);
		}

		// Token: 0x0601DBAF RID: 121775 RVA: 0x002BEB18 File Offset: 0x002BCD18
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

		// Token: 0x0601DBB0 RID: 121776 RVA: 0x002BEB60 File Offset: 0x002BCD60
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

		// Token: 0x0601DBB1 RID: 121777 RVA: 0x002BEB90 File Offset: 0x002BCD90
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

		// Token: 0x0601DBB2 RID: 121778 RVA: 0x002BEBC0 File Offset: 0x002BCDC0
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

		// Token: 0x0601DBB3 RID: 121779 RVA: 0x002BEBF0 File Offset: 0x002BCDF0
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

		// Token: 0x0601DBB4 RID: 121780 RVA: 0x002BEC20 File Offset: 0x002BCE20
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

		// Token: 0x0601DBB5 RID: 121781
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Release_Internal(IntPtr @this);

		// Token: 0x0601DBB6 RID: 121782
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __MoveToNext_Internal(IntPtr @this);

		// Token: 0x0601DBB7 RID: 121783
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __HasValue_Internal(IntPtr @this);

		// Token: 0x0601DBB8 RID: 121784
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetString_Internal(IntPtr @this, in FString Column, ref FString Value);

		// Token: 0x0601DBB9 RID: 121785
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetInt_Internal(IntPtr @this, in FString Column, ref int Value);

		// Token: 0x0601DBBA RID: 121786
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetFloat_Internal(IntPtr @this, in FString Column, ref float Value);

		// Token: 0x0601DBBB RID: 121787
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetBytes_Internal(IntPtr @this, in FString Column, ref FArrayBuffer Value);

		// Token: 0x0601DBBC RID: 121788
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetBool_Internal(IntPtr @this, in FString Column, ref bool Value);

		// Token: 0x0601DBBD RID: 121789
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetBigInt_Internal(IntPtr @this, in FString Column, ref long Value);

		// Token: 0x0601DBBE RID: 121790 RVA: 0x002BEC50 File Offset: 0x002BCE50
		static UKuroSqliteResultSet()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSqliteBpLib.KuroSqliteResultSet");
		}

		// Token: 0x0601DBBF RID: 121791 RVA: 0x002BEC5E File Offset: 0x002BCE5E
		protected UKuroSqliteResultSet(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010180 RID: 65920
		public new const string __ObjectPath = "/Script/KuroSqliteBpLib.KuroSqliteResultSet";

		// Token: 0x04010181 RID: 65921
		private static IntPtr _ClassPtr;

		// Token: 0x04010182 RID: 65922
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010183 RID: 65923
		internal static int __PropertyOffset_QueriedCallback;

		// Token: 0x04010184 RID: 65924
		[Nullable(2)]
		private FQueriedCallback _QueriedCallback;
	}
}
