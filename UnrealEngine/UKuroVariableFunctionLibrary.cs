using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001F1F RID: 7967
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroVariable.KuroVariableFunctionLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UKuroVariableFunctionLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601E3A6 RID: 123814 RVA: 0x002CED88 File Offset: 0x002CCF88
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroVariableFunctionLibrary._ClassPtr;
		}

		// Token: 0x0601E3A7 RID: 123815 RVA: 0x002CED94 File Offset: 0x002CCF94
		public UKuroVariableFunctionLibrary() : this(BuiltinUtils.AllocNativeUObject(UKuroVariableFunctionLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601E3A8 RID: 123816 RVA: 0x002CEDBC File Offset: 0x002CCFBC
		public UKuroVariableFunctionLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroVariableFunctionLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601E3A9 RID: 123817 RVA: 0x002CEDF0 File Offset: 0x002CCFF0
		public unsafe static bool SetStringValue(string Key, string Value)
		{
			FString fstring = FString.AllocTemp(Key);
			FString fstring2 = FString.AllocTemp(Value);
			bool result = UKuroVariableFunctionLibrary.__SetStringValue_Internal(fstring, fstring2);
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
			return result;
		}

		// Token: 0x0601E3AA RID: 123818 RVA: 0x002CEE28 File Offset: 0x002CD028
		public unsafe static bool SetObject(string Key, [Nullable(2)] UObject Value)
		{
			FString fstring = FString.AllocTemp(Key);
			bool result = UKuroVariableFunctionLibrary.__SetObject_Internal(fstring, (Value != null) ? Value.NativePtr : IntPtr.Zero);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x0601E3AB RID: 123819 RVA: 0x002CEE5C File Offset: 0x002CD05C
		public unsafe static bool SetIntValue(string Key, int Value)
		{
			FString fstring = FString.AllocTemp(Key);
			bool result = UKuroVariableFunctionLibrary.__SetIntValue_Internal(fstring, Value);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x0601E3AC RID: 123820 RVA: 0x002CEE84 File Offset: 0x002CD084
		public unsafe static bool SetFloatValue(string Key, float Value)
		{
			FString fstring = FString.AllocTemp(Key);
			bool result = UKuroVariableFunctionLibrary.__SetFloatValue_Internal(fstring, Value);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x0601E3AD RID: 123821 RVA: 0x002CEEAC File Offset: 0x002CD0AC
		public unsafe static bool SetBoolValue(string Key, bool Value)
		{
			FString fstring = FString.AllocTemp(Key);
			bool result = UKuroVariableFunctionLibrary.__SetBoolValue_Internal(fstring, Value);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x0601E3AE RID: 123822 RVA: 0x002CEED4 File Offset: 0x002CD0D4
		public unsafe static bool RemoveStringValue(string Key)
		{
			FString fstring = FString.AllocTemp(Key);
			bool result = UKuroVariableFunctionLibrary.__RemoveStringValue_Internal(fstring);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x0601E3AF RID: 123823 RVA: 0x002CEEF8 File Offset: 0x002CD0F8
		public unsafe static bool RemoveObject(string Key)
		{
			FString fstring = FString.AllocTemp(Key);
			bool result = UKuroVariableFunctionLibrary.__RemoveObject_Internal(fstring);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x0601E3B0 RID: 123824 RVA: 0x002CEF1C File Offset: 0x002CD11C
		public unsafe static bool RemoveIntValue(string Key)
		{
			FString fstring = FString.AllocTemp(Key);
			bool result = UKuroVariableFunctionLibrary.__RemoveIntValue_Internal(fstring);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x0601E3B1 RID: 123825 RVA: 0x002CEF40 File Offset: 0x002CD140
		public unsafe static bool RemoveFloatValue(string Key)
		{
			FString fstring = FString.AllocTemp(Key);
			bool result = UKuroVariableFunctionLibrary.__RemoveFloatValue_Internal(fstring);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x0601E3B2 RID: 123826 RVA: 0x002CEF64 File Offset: 0x002CD164
		public unsafe static bool RemoveBoolValue(string Key)
		{
			FString fstring = FString.AllocTemp(Key);
			bool result = UKuroVariableFunctionLibrary.__RemoveBoolValue_Internal(fstring);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x0601E3B3 RID: 123827 RVA: 0x002CEF88 File Offset: 0x002CD188
		public unsafe static bool HasStringValue(string Key)
		{
			FString fstring = FString.AllocTemp(Key);
			bool result = UKuroVariableFunctionLibrary.__HasStringValue_Internal(fstring);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x0601E3B4 RID: 123828 RVA: 0x002CEFAC File Offset: 0x002CD1AC
		public unsafe static bool HasObject(string Key)
		{
			FString fstring = FString.AllocTemp(Key);
			bool result = UKuroVariableFunctionLibrary.__HasObject_Internal(fstring);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x0601E3B5 RID: 123829 RVA: 0x002CEFD0 File Offset: 0x002CD1D0
		public unsafe static bool HasIntValue(string Key)
		{
			FString fstring = FString.AllocTemp(Key);
			bool result = UKuroVariableFunctionLibrary.__HasIntValue_Internal(fstring);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x0601E3B6 RID: 123830 RVA: 0x002CEFF4 File Offset: 0x002CD1F4
		public unsafe static bool HasFloatValue(string Key)
		{
			FString fstring = FString.AllocTemp(Key);
			bool result = UKuroVariableFunctionLibrary.__HasFloatValue_Internal(fstring);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x0601E3B7 RID: 123831 RVA: 0x002CF018 File Offset: 0x002CD218
		public unsafe static bool HasBoolValue(string Key)
		{
			FString fstring = FString.AllocTemp(Key);
			bool result = UKuroVariableFunctionLibrary.__HasBoolValue_Internal(fstring);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x0601E3B8 RID: 123832 RVA: 0x002CF03C File Offset: 0x002CD23C
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

		// Token: 0x0601E3B9 RID: 123833 RVA: 0x002CF07C File Offset: 0x002CD27C
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

		// Token: 0x0601E3BA RID: 123834 RVA: 0x002CF0C0 File Offset: 0x002CD2C0
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

		// Token: 0x0601E3BB RID: 123835 RVA: 0x002CF0EC File Offset: 0x002CD2EC
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

		// Token: 0x0601E3BC RID: 123836 RVA: 0x002CF118 File Offset: 0x002CD318
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

		// Token: 0x0601E3BD RID: 123837
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void Clear();

		// Token: 0x0601E3BE RID: 123838
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __SetStringValue_Internal(in FString Key, in FString Value);

		// Token: 0x0601E3BF RID: 123839
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __SetObject_Internal(in FString Key, IntPtr Value);

		// Token: 0x0601E3C0 RID: 123840
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __SetIntValue_Internal(in FString Key, int Value);

		// Token: 0x0601E3C1 RID: 123841
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __SetFloatValue_Internal(in FString Key, float Value);

		// Token: 0x0601E3C2 RID: 123842
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __SetBoolValue_Internal(in FString Key, bool Value);

		// Token: 0x0601E3C3 RID: 123843
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __RemoveStringValue_Internal(in FString Key);

		// Token: 0x0601E3C4 RID: 123844
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __RemoveObject_Internal(in FString Key);

		// Token: 0x0601E3C5 RID: 123845
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __RemoveIntValue_Internal(in FString Key);

		// Token: 0x0601E3C6 RID: 123846
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __RemoveFloatValue_Internal(in FString Key);

		// Token: 0x0601E3C7 RID: 123847
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __RemoveBoolValue_Internal(in FString Key);

		// Token: 0x0601E3C8 RID: 123848
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __HasStringValue_Internal(in FString Key);

		// Token: 0x0601E3C9 RID: 123849
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __HasObject_Internal(in FString Key);

		// Token: 0x0601E3CA RID: 123850
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __HasIntValue_Internal(in FString Key);

		// Token: 0x0601E3CB RID: 123851
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __HasFloatValue_Internal(in FString Key);

		// Token: 0x0601E3CC RID: 123852
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __HasBoolValue_Internal(in FString Key);

		// Token: 0x0601E3CD RID: 123853
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetStringValue_Internal(in FString Key, ref FString Value);

		// Token: 0x0601E3CE RID: 123854
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetObject_Internal(in FString Key, ref IntPtr Value);

		// Token: 0x0601E3CF RID: 123855
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetIntValue_Internal(in FString Key, ref int Value);

		// Token: 0x0601E3D0 RID: 123856
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetFloatValue_Internal(in FString Key, ref float Value);

		// Token: 0x0601E3D1 RID: 123857
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetBoolValue_Internal(in FString Key, ref bool Value);

		// Token: 0x0601E3D2 RID: 123858 RVA: 0x002CF142 File Offset: 0x002CD342
		static UKuroVariableFunctionLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroVariable.KuroVariableFunctionLibrary");
		}

		// Token: 0x0601E3D3 RID: 123859 RVA: 0x002CF150 File Offset: 0x002CD350
		protected UKuroVariableFunctionLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040104F9 RID: 66809
		public new const string __ObjectPath = "/Script/KuroVariable.KuroVariableFunctionLibrary";

		// Token: 0x040104FA RID: 66810
		private static IntPtr _ClassPtr;

		// Token: 0x040104FB RID: 66811
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
