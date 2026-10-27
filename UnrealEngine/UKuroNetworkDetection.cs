using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020019FD RID: 6653
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroNetwork.KuroNetworkDetection")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UKuroNetworkDetection : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06018A9E RID: 101022 RVA: 0x00245FCE File Offset: 0x002441CE
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroNetworkDetection._ClassPtr;
		}

		// Token: 0x06018A9F RID: 101023 RVA: 0x00245FDC File Offset: 0x002441DC
		public UKuroNetworkDetection() : this(BuiltinUtils.AllocNativeUObject(UKuroNetworkDetection.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06018AA0 RID: 101024 RVA: 0x00246004 File Offset: 0x00244204
		public UKuroNetworkDetection(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroNetworkDetection.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06018AA1 RID: 101025 RVA: 0x00246038 File Offset: 0x00244238
		[NullableContext(2)]
		public unsafe static void TestUdpReachable([Nullable(1)] string IpAddress, in TArray<int> Ports, FTestUdpResultDelegate ResultDelegate)
		{
			FString fstring = FString.AllocTemp(IpAddress);
			UKuroNetworkDetection.__TestUdpReachable_Internal(fstring, (Ports ?? new TArray<int>()).NativePtr, (ResultDelegate != null) ? ResultDelegate.NativePtr : ((IntPtr)0));
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06018AA2 RID: 101026 RVA: 0x0024607C File Offset: 0x0024427C
		public unsafe static void SetCDNConfig(string CDNConfig)
		{
			FString fstring = FString.AllocTemp(CDNConfig);
			UKuroNetworkDetection.__SetCDNConfig_Internal(fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06018AA3 RID: 101027 RVA: 0x002460A0 File Offset: 0x002442A0
		public unsafe static void ResolveDomainName(string DomainName, [Nullable(2)] FResolveDomainDelegate Callback)
		{
			FString fstring = FString.AllocTemp(DomainName);
			UKuroNetworkDetection.__ResolveDomainName_Internal(fstring, (Callback != null) ? Callback.NativePtr : ((IntPtr)0));
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06018AA4 RID: 101028
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void ResolveDomainFinish();

		// Token: 0x06018AA5 RID: 101029 RVA: 0x002460D4 File Offset: 0x002442D4
		public unsafe static string GetDetectionConfig(string ServerName)
		{
			FString fstring = FString.AllocTemp(ServerName);
			string result = FString.ToStringAndDeleteNativePtr(UKuroNetworkDetection.__GetDetectionConfig_Internal(fstring));
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x06018AA6 RID: 101030 RVA: 0x002460FD File Offset: 0x002442FD
		public static string GetCurrentProxyAddress()
		{
			return FString.ToStringAndDeleteNativePtr(UKuroNetworkDetection.__GetCurrentProxyAddress_Internal());
		}

		// Token: 0x06018AA7 RID: 101031 RVA: 0x0024610C File Offset: 0x0024430C
		public unsafe static void GatewayUdpReachable(string IpAddress, [Nullable(2)] in TArray<int> Ports, string Payload, [Nullable(2)] FTestUdpResultDelegate ResultDelegate)
		{
			FString fstring = FString.AllocTemp(IpAddress);
			FString fstring2 = FString.AllocTemp(Payload);
			UKuroNetworkDetection.__GatewayUdpReachable_Internal(fstring, (Ports ?? new TArray<int>()).NativePtr, fstring2, (ResultDelegate != null) ? ResultDelegate.NativePtr : ((IntPtr)0));
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
		}

		// Token: 0x06018AA8 RID: 101032
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void DetectionFinish(bool bSuccess);

		// Token: 0x06018AA9 RID: 101033
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void AbortGatewayUdpReachable();

		// Token: 0x06018AAA RID: 101034
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __TestUdpReachable_Internal(in FString IpAddress, IntPtr Ports, IntPtr ResultDelegate);

		// Token: 0x06018AAB RID: 101035
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetCDNConfig_Internal(in FString CDNConfig);

		// Token: 0x06018AAC RID: 101036
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ResolveDomainName_Internal(in FString DomainName, IntPtr Callback);

		// Token: 0x06018AAD RID: 101037
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetDetectionConfig_Internal(in FString ServerName);

		// Token: 0x06018AAE RID: 101038
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetCurrentProxyAddress_Internal();

		// Token: 0x06018AAF RID: 101039
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GatewayUdpReachable_Internal(in FString IpAddress, IntPtr Ports, in FString Payload, IntPtr ResultDelegate);

		// Token: 0x06018AB0 RID: 101040 RVA: 0x0024615F File Offset: 0x0024435F
		static UKuroNetworkDetection()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroNetwork.KuroNetworkDetection");
		}

		// Token: 0x06018AB1 RID: 101041 RVA: 0x0024616D File Offset: 0x0024436D
		protected UKuroNetworkDetection(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400D53D RID: 54589
		public new const string __ObjectPath = "/Script/KuroNetwork.KuroNetworkDetection";

		// Token: 0x0400D53E RID: 54590
		private static IntPtr _ClassPtr;

		// Token: 0x0400D53F RID: 54591
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
