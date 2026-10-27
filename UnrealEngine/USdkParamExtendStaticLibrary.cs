using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020026DA RID: 9946
	[UnrealObjectPath("/Script/SdkParamExtend.SdkParamExtendStaticLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class USdkParamExtendStaticLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06024E93 RID: 151187 RVA: 0x0036981F File Offset: 0x00367A1F
		public new static UClassStackOnlyPtr StaticClass()
		{
			return USdkParamExtendStaticLibrary._ClassPtr;
		}

		// Token: 0x06024E94 RID: 151188 RVA: 0x0036982C File Offset: 0x00367A2C
		public USdkParamExtendStaticLibrary() : this(BuiltinUtils.AllocNativeUObject(USdkParamExtendStaticLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06024E95 RID: 151189 RVA: 0x00369854 File Offset: 0x00367A54
		[NullableContext(1)]
		public USdkParamExtendStaticLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(USdkParamExtendStaticLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06024E96 RID: 151190 RVA: 0x00369887 File Offset: 0x00367A87
		[NullableContext(2)]
		public static USdkParam GetSdkParamInstance()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<USdkParam>(USdkParamExtendStaticLibrary.__GetSdkParamInstance_Internal());
		}

		// Token: 0x06024E97 RID: 151191
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void GetDeviceInfoAsync();

		// Token: 0x06024E98 RID: 151192
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetSdkParamInstance_Internal();

		// Token: 0x06024E99 RID: 151193 RVA: 0x00369893 File Offset: 0x00367A93
		static USdkParamExtendStaticLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/SdkParamExtend.SdkParamExtendStaticLibrary");
		}

		// Token: 0x06024E9A RID: 151194 RVA: 0x003698A1 File Offset: 0x00367AA1
		protected USdkParamExtendStaticLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04013E24 RID: 81444
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/SdkParamExtend.SdkParamExtendStaticLibrary";

		// Token: 0x04013E25 RID: 81445
		private static IntPtr _ClassPtr;

		// Token: 0x04013E26 RID: 81446
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
