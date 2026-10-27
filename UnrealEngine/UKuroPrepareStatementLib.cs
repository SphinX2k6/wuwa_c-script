using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001E7E RID: 7806
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroSqliteBpLib.KuroPrepareStatementLib")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UKuroPrepareStatementLib : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601DB6F RID: 121711 RVA: 0x002BE4F4 File Offset: 0x002BC6F4
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroPrepareStatementLib._ClassPtr;
		}

		// Token: 0x0601DB70 RID: 121712 RVA: 0x002BE500 File Offset: 0x002BC700
		public UKuroPrepareStatementLib() : this(BuiltinUtils.AllocNativeUObject(UKuroPrepareStatementLib.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601DB71 RID: 121713 RVA: 0x002BE528 File Offset: 0x002BC728
		public UKuroPrepareStatementLib(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroPrepareStatementLib.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601DB72 RID: 121714
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int Step(int InId);

		// Token: 0x0601DB73 RID: 121715 RVA: 0x002BE55C File Offset: 0x002BC75C
		public unsafe static bool SetBindingValueString(int InId, int InBindingIndex, string InValue)
		{
			FString fstring = FString.AllocTemp(InValue);
			bool result = UKuroPrepareStatementLib.__SetBindingValueString_Internal(InId, InBindingIndex, fstring);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x0601DB74 RID: 121716
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool SetBindingValueInt(int InId, int InBindingIndex, int InValue);

		// Token: 0x0601DB75 RID: 121717
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool SetBindingValueFloat64(int InId, int InBindingIndex, double InValue);

		// Token: 0x0601DB76 RID: 121718
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool SetBindingValueFloat(int InId, int InBindingIndex, float InValue);

		// Token: 0x0601DB77 RID: 121719
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool SetBindingValueBool(int InId, int InBindingIndex, bool InValue);

		// Token: 0x0601DB78 RID: 121720
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool SetBindingValueBigInt(int InId, int InBindingIndex, long InValue);

		// Token: 0x0601DB79 RID: 121721
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool Reset(int InId);

		// Token: 0x0601DB7A RID: 121722 RVA: 0x002BE584 File Offset: 0x002BC784
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

		// Token: 0x0601DB7B RID: 121723
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool GetColumnValueInt32(int InId, int InColumnIndex, ref int OutValue);

		// Token: 0x0601DB7C RID: 121724
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool GetColumnValueBytes(int InId, int InColumnIndex, ref FArrayBuffer OutValue);

		// Token: 0x0601DB7D RID: 121725
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void DestroyStatement(int InId);

		// Token: 0x0601DB7E RID: 121726 RVA: 0x002BE5B0 File Offset: 0x002BC7B0
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

		// Token: 0x0601DB7F RID: 121727
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void CloseConnection(int InId);

		// Token: 0x0601DB80 RID: 121728
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void CloseAllConnection();

		// Token: 0x0601DB81 RID: 121729
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool ClearBindings(int InId);

		// Token: 0x0601DB82 RID: 121730
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __SetBindingValueString_Internal(int InId, int InBindingIndex, in FString InValue);

		// Token: 0x0601DB83 RID: 121731
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetOrCreateStatement_Internal(in FName InDbPath, in FString InCommand);

		// Token: 0x0601DB84 RID: 121732
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __CreateStatement_Internal(in FName InDbPath, in FString InCommand);

		// Token: 0x0601DB85 RID: 121733 RVA: 0x002BE5DA File Offset: 0x002BC7DA
		static UKuroPrepareStatementLib()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSqliteBpLib.KuroPrepareStatementLib");
		}

		// Token: 0x0601DB86 RID: 121734 RVA: 0x002BE5E8 File Offset: 0x002BC7E8
		protected UKuroPrepareStatementLib(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010170 RID: 65904
		public new const string __ObjectPath = "/Script/KuroSqliteBpLib.KuroPrepareStatementLib";

		// Token: 0x04010171 RID: 65905
		private static IntPtr _ClassPtr;

		// Token: 0x04010172 RID: 65906
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
