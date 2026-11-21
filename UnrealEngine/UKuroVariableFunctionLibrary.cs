using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000628 RID: 1576
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroVariable.KuroVariableFunctionLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UKuroVariableFunctionLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060089A2 RID: 35234 RVA: 0x000CF6BB File Offset: 0x000CD8BB
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroVariableFunctionLibrary._ClassPtr;
		}

		// Token: 0x060089A3 RID: 35235 RVA: 0x000CF6C8 File Offset: 0x000CD8C8
		public UKuroVariableFunctionLibrary() : this(BuiltinUtils.AllocNativeUObject(UKuroVariableFunctionLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060089A4 RID: 35236 RVA: 0x000CF6F0 File Offset: 0x000CD8F0
		public UKuroVariableFunctionLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroVariableFunctionLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060089A5 RID: 35237 RVA: 0x000CF724 File Offset: 0x000CD924
		public unsafe static bool SetStringValue(string Key, string Value)
		{
			FString fstring = FString.AllocTemp(Key);
			FString fstring2 = FString.AllocTemp(Value);
			bool result = UKuroVariableFunctionLibrary.__SetStringValue_Internal(fstring, fstring2);
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
			return result;
		}

		// Token: 0x060089A6 RID: 35238 RVA: 0x000CF75C File Offset: 0x000CD95C
		public unsafe static bool SetObject(string Key, [Nullable(2)] UObject Value)
		{
			FString fstring = FString.AllocTemp(Key);
			bool result = UKuroVariableFunctionLibrary.__SetObject_Internal(fstring, (Value != null) ? Value.NativePtr : IntPtr.Zero);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x060089A7 RID: 35239 RVA: 0x000CF790 File Offset: 0x000CD990
		public unsafe static bool SetIntValue(string Key, int Value)
		{
			FString fstring = FString.AllocTemp(Key);
			bool result = UKuroVariableFunctionLibrary.__SetIntValue_Internal(fstring, Value);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x060089A8 RID: 35240 RVA: 0x000CF7B8 File Offset: 0x000CD9B8
		public unsafe static bool SetFloatValue(string Key, float Value)
		{
			FString fstring = FString.AllocTemp(Key);
			bool result = UKuroVariableFunctionLibrary.__SetFloatValue_Internal(fstring, Value);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x060089A9 RID: 35241 RVA: 0x000CF7E0 File Offset: 0x000CD9E0
		public unsafe static bool SetBoolValue(string Key, bool Value)
		{
			FString fstring = FString.AllocTemp(Key);
			bool result = UKuroVariableFunctionLibrary.__SetBoolValue_Internal(fstring, Value);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x060089AA RID: 35242 RVA: 0x000CF808 File Offset: 0x000CDA08
		public unsafe static bool RemoveStringValue(string Key)
		{
			FString fstring = FString.AllocTemp(Key);
			bool result = UKuroVariableFunctionLibrary.__RemoveStringValue_Internal(fstring);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x060089AB RID: 35243 RVA: 0x000CF82C File Offset: 0x000CDA2C
		public unsafe static bool RemoveObject(string Key)
		{
			FString fstring = FString.AllocTemp(Key);
			bool result = UKuroVariableFunctionLibrary.__RemoveObject_Internal(fstring);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x060089AC RID: 35244 RVA: 0x000CF850 File Offset: 0x000CDA50
		public unsafe static bool RemoveIntValue(string Key)
		{
			FString fstring = FString.AllocTemp(Key);
			bool result = UKuroVariableFunctionLibrary.__RemoveIntValue_Internal(fstring);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x060089AD RID: 35245 RVA: 0x000CF874 File Offset: 0x000CDA74
		public unsafe static bool RemoveFloatValue(string Key)
		{
			FString fstring = FString.AllocTemp(Key);
			bool result = UKuroVariableFunctionLibrary.__RemoveFloatValue_Internal(fstring);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x060089AE RID: 35246 RVA: 0x000CF898 File Offset: 0x000CDA98
		public unsafe static bool RemoveBoolValue(string Key)
		{
			FString fstring = FString.AllocTemp(Key);
			bool result = UKuroVariableFunctionLibrary.__RemoveBoolValue_Internal(fstring);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x060089AF RID: 35247 RVA: 0x000CF8BC File Offset: 0x000CDABC
		public unsafe static bool HasStringValue(string Key)
		{
			FString fstring = FString.AllocTemp(Key);
			bool result = UKuroVariableFunctionLibrary.__HasStringValue_Internal(fstring);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x060089B0 RID: 35248 RVA: 0x000CF8E0 File Offset: 0x000CDAE0
		public unsafe static bool HasObject(string Key)
		{
			FString fstring = FString.AllocTemp(Key);
			bool result = UKuroVariableFunctionLibrary.__HasObject_Internal(fstring);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x060089B1 RID: 35249 RVA: 0x000CF904 File Offset: 0x000CDB04
		public unsafe static bool HasIntValue(string Key)
		{
			FString fstring = FString.AllocTemp(Key);
			bool result = UKuroVariableFunctionLibrary.__HasIntValue_Internal(fstring);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x060089B2 RID: 35250 RVA: 0x000CF928 File Offset: 0x000CDB28
		public unsafe static bool HasFloatValue(string Key)
		{
			FString fstring = FString.AllocTemp(Key);
			bool result = UKuroVariableFunctionLibrary.__HasFloatValue_Internal(fstring);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x060089B3 RID: 35251 RVA: 0x000CF94C File Offset: 0x000CDB4C
		public unsafe static bool HasBoolValue(string Key)
		{
			FString fstring = FString.AllocTemp(Key);
			bool result = UKuroVariableFunctionLibrary.__HasBoolValue_Internal(fstring);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x060089B4 RID: 35252 RVA: 0x000CF970 File Offset: 0x000CDB70
		public unsafe static bool GetStringValue(string Key, ref string Value)
		{
			FString fstring = FString.AllocTemp(Key);
			FString fstring2 = FString.AllocTemp(Value);
			bool result = UKuroVariableFunctionLibrary.__GetStringValue_Internal(fstring, ref fstring2);
			FString.NativeDestruct(&fstring, 1);
			Value = FString.ToString(fstring2);
			FString.NativeDestruct(&fstring2, 1);
			return result;
		}

		// Token: 0x060089B5 RID: 35253 RVA: 0x000CF9B0 File Offset: 0x000CDBB0
		public unsafe static bool GetObject(string Key, [Nullable(2)] ref UObject Value)
		{
			FString fstring = FString.AllocTemp(Key);
			UObject uobject = Value;
			IntPtr nativeObjectPtr = (uobject != null) ? uobject.NativePtr : IntPtr.Zero;
			bool result = UKuroVariableFunctionLibrary.__GetObject_Internal(fstring, ref nativeObjectPtr);
			FString.NativeDestruct(&fstring, 1);
			Value = BuiltinUtils.GetOrCreateUObjectByNativePointer<UObject>(nativeObjectPtr);
			return result;
		}

		// Token: 0x060089B6 RID: 35254 RVA: 0x000CF9F4 File Offset: 0x000CDBF4
		public unsafe static bool GetIntValue(string Key, ref int Value)
		{
			FString fstring = FString.AllocTemp(Key);
			fixed (int* ptr = &Value)
			{
				void* ptr2 = (void*)ptr;
				bool result = UKuroVariableFunctionLibrary.__GetIntValue_Internal(fstring, ref Value);
				FString.NativeDestruct(&fstring, 1);
				return result;
			}
		}

		// Token: 0x060089B7 RID: 35255 RVA: 0x000CFA20 File Offset: 0x000CDC20
		public unsafe static bool GetFloatValue(string Key, ref float Value)
		{
			FString fstring = FString.AllocTemp(Key);
			fixed (float* ptr = &Value)
			{
				void* ptr2 = (void*)ptr;
				bool result = UKuroVariableFunctionLibrary.__GetFloatValue_Internal(fstring, ref Value);
				FString.NativeDestruct(&fstring, 1);
				return result;
			}
		}

		// Token: 0x060089B8 RID: 35256 RVA: 0x000CFA4C File Offset: 0x000CDC4C
		public unsafe static bool GetBoolValue(string Key, ref bool Value)
		{
			FString fstring = FString.AllocTemp(Key);
			fixed (bool* ptr = &Value)
			{
				void* ptr2 = (void*)ptr;
				bool result = UKuroVariableFunctionLibrary.__GetBoolValue_Internal(fstring, ref Value);
				FString.NativeDestruct(&fstring, 1);
				return result;
			}
		}

		// Token: 0x060089B9 RID: 35257
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void Clear();

		// Token: 0x060089BA RID: 35258
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __SetStringValue_Internal(in FString Key, in FString Value);

		// Token: 0x060089BB RID: 35259
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __SetObject_Internal(in FString Key, IntPtr Value);

		// Token: 0x060089BC RID: 35260
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __SetIntValue_Internal(in FString Key, int Value);

		// Token: 0x060089BD RID: 35261
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __SetFloatValue_Internal(in FString Key, float Value);

		// Token: 0x060089BE RID: 35262
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __SetBoolValue_Internal(in FString Key, bool Value);

		// Token: 0x060089BF RID: 35263
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __RemoveStringValue_Internal(in FString Key);

		// Token: 0x060089C0 RID: 35264
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __RemoveObject_Internal(in FString Key);

		// Token: 0x060089C1 RID: 35265
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __RemoveIntValue_Internal(in FString Key);

		// Token: 0x060089C2 RID: 35266
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __RemoveFloatValue_Internal(in FString Key);

		// Token: 0x060089C3 RID: 35267
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __RemoveBoolValue_Internal(in FString Key);

		// Token: 0x060089C4 RID: 35268
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __HasStringValue_Internal(in FString Key);

		// Token: 0x060089C5 RID: 35269
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __HasObject_Internal(in FString Key);

		// Token: 0x060089C6 RID: 35270
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __HasIntValue_Internal(in FString Key);

		// Token: 0x060089C7 RID: 35271
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __HasFloatValue_Internal(in FString Key);

		// Token: 0x060089C8 RID: 35272
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __HasBoolValue_Internal(in FString Key);

		// Token: 0x060089C9 RID: 35273
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetStringValue_Internal(in FString Key, ref FString Value);

		// Token: 0x060089CA RID: 35274
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetObject_Internal(in FString Key, ref IntPtr Value);

		// Token: 0x060089CB RID: 35275
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetIntValue_Internal(in FString Key, ref int Value);

		// Token: 0x060089CC RID: 35276
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetFloatValue_Internal(in FString Key, ref float Value);

		// Token: 0x060089CD RID: 35277
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetBoolValue_Internal(in FString Key, ref bool Value);

		// Token: 0x060089CE RID: 35278 RVA: 0x000CFA76 File Offset: 0x000CDC76
		static UKuroVariableFunctionLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroVariable.KuroVariableFunctionLibrary");
		}

		// Token: 0x060089CF RID: 35279 RVA: 0x000CFA84 File Offset: 0x000CDC84
		protected UKuroVariableFunctionLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04003BB8 RID: 15288
		public new const string __ObjectPath = "/Script/KuroVariable.KuroVariableFunctionLibrary";

		// Token: 0x04003BB9 RID: 15289
		private static IntPtr _ClassPtr;

		// Token: 0x04003BBA RID: 15290
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
