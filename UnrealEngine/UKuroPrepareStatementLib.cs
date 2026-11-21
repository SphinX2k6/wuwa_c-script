using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020005AE RID: 1454
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroSqliteBpLib.KuroPrepareStatementLib")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UKuroPrepareStatementLib : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060082C8 RID: 33480 RVA: 0x000C1650 File Offset: 0x000BF850
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroPrepareStatementLib._ClassPtr;
		}

		// Token: 0x060082C9 RID: 33481 RVA: 0x000C165C File Offset: 0x000BF85C
		public UKuroPrepareStatementLib() : this(BuiltinUtils.AllocNativeUObject(UKuroPrepareStatementLib.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060082CA RID: 33482 RVA: 0x000C1684 File Offset: 0x000BF884
		public UKuroPrepareStatementLib(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroPrepareStatementLib.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060082CB RID: 33483
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int Step(int InId);

		// Token: 0x060082CC RID: 33484 RVA: 0x000C16B8 File Offset: 0x000BF8B8
		public unsafe static bool SetBindingValueString(int InId, int InBindingIndex, string InValue)
		{
			FString fstring = FString.AllocTemp(InValue);
			bool result = UKuroPrepareStatementLib.__SetBindingValueString_Internal(InId, InBindingIndex, fstring);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x060082CD RID: 33485
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool SetBindingValueInt(int InId, int InBindingIndex, int InValue);

		// Token: 0x060082CE RID: 33486
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool SetBindingValueFloat64(int InId, int InBindingIndex, double InValue);

		// Token: 0x060082CF RID: 33487
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool SetBindingValueFloat(int InId, int InBindingIndex, float InValue);

		// Token: 0x060082D0 RID: 33488
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool SetBindingValueBool(int InId, int InBindingIndex, bool InValue);

		// Token: 0x060082D1 RID: 33489
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool SetBindingValueBigInt(int InId, int InBindingIndex, long InValue);

		// Token: 0x060082D2 RID: 33490
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool Reset(int InId);

		// Token: 0x060082D3 RID: 33491 RVA: 0x000C16E0 File Offset: 0x000BF8E0
		public unsafe static int GetOrCreateStatement(in FName InDbPath, string InCommand)
		{
			FString fstring = FString.AllocTemp(InCommand);
			fixed (FName* ptr = &InDbPath)
			{
				void* ptr2 = (void*)ptr;
				int result = UKuroPrepareStatementLib.__GetOrCreateStatement_Internal(InDbPath, fstring);
				FString.NativeDestruct(&fstring, 1);
				return result;
			}
		}

		// Token: 0x060082D4 RID: 33492
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool GetColumnValueInt32(int InId, int InColumnIndex, ref int OutValue);

		// Token: 0x060082D5 RID: 33493
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool GetColumnValueBytes(int InId, int InColumnIndex, ref FArrayBuffer OutValue);

		// Token: 0x060082D6 RID: 33494
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void DestroyStatement(int InId);

		// Token: 0x060082D7 RID: 33495 RVA: 0x000C170C File Offset: 0x000BF90C
		public unsafe static int CreateStatement(in FName InDbPath, string InCommand)
		{
			FString fstring = FString.AllocTemp(InCommand);
			fixed (FName* ptr = &InDbPath)
			{
				void* ptr2 = (void*)ptr;
				int result = UKuroPrepareStatementLib.__CreateStatement_Internal(InDbPath, fstring);
				FString.NativeDestruct(&fstring, 1);
				return result;
			}
		}

		// Token: 0x060082D8 RID: 33496
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void CloseConnection(int InId);

		// Token: 0x060082D9 RID: 33497
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void CloseAllConnection();

		// Token: 0x060082DA RID: 33498
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool ClearBindings(int InId);

		// Token: 0x060082DB RID: 33499
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __SetBindingValueString_Internal(int InId, int InBindingIndex, in FString InValue);

		// Token: 0x060082DC RID: 33500
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetOrCreateStatement_Internal(in FName InDbPath, in FString InCommand);

		// Token: 0x060082DD RID: 33501
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __CreateStatement_Internal(in FName InDbPath, in FString InCommand);

		// Token: 0x060082DE RID: 33502 RVA: 0x000C1736 File Offset: 0x000BF936
		static UKuroPrepareStatementLib()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSqliteBpLib.KuroPrepareStatementLib");
		}

		// Token: 0x060082DF RID: 33503 RVA: 0x000C1744 File Offset: 0x000BF944
		protected UKuroPrepareStatementLib(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040038F3 RID: 14579
		public new const string __ObjectPath = "/Script/KuroSqliteBpLib.KuroPrepareStatementLib";

		// Token: 0x040038F4 RID: 14580
		private static IntPtr _ClassPtr;

		// Token: 0x040038F5 RID: 14581
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
