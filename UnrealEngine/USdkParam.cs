using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020026D9 RID: 9945
	[UnrealObjectPath("/Script/SdkParamExtend.SdkParam")]
	[UnrealStructLayout(104, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 104)]
	public class USdkParam : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06024E8C RID: 151180 RVA: 0x00369793 File Offset: 0x00367993
		public new static UClassStackOnlyPtr StaticClass()
		{
			return USdkParam._ClassPtr;
		}

		// Token: 0x06024E8D RID: 151181 RVA: 0x003697A0 File Offset: 0x003679A0
		public USdkParam() : this(BuiltinUtils.AllocNativeUObject(USdkParam.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06024E8E RID: 151182 RVA: 0x003697C8 File Offset: 0x003679C8
		[NullableContext(1)]
		public USdkParam(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(USdkParam.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06024E8F RID: 151183 RVA: 0x003697FB File Offset: 0x003679FB
		public void GetDeviceInfoAsync()
		{
			USdkParam.__GetDeviceInfoAsync_Internal(base.NativePtr);
		}

		// Token: 0x06024E90 RID: 151184
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetDeviceInfoAsync_Internal(IntPtr @this);

		// Token: 0x06024E91 RID: 151185 RVA: 0x00369808 File Offset: 0x00367A08
		static USdkParam()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/SdkParamExtend.SdkParam");
		}

		// Token: 0x06024E92 RID: 151186 RVA: 0x00369816 File Offset: 0x00367A16
		protected USdkParam(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04013E21 RID: 81441
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/SdkParamExtend.SdkParam";

		// Token: 0x04013E22 RID: 81442
		private static IntPtr _ClassPtr;

		// Token: 0x04013E23 RID: 81443
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
