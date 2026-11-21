using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000482 RID: 1154
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroNetwork.KuroNetworkDetection")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UKuroNetworkDetection : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06006D10 RID: 27920 RVA: 0x0009F5C2 File Offset: 0x0009D7C2
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroNetworkDetection._ClassPtr;
		}

		// Token: 0x06006D11 RID: 27921 RVA: 0x0009F5D0 File Offset: 0x0009D7D0
		public UKuroNetworkDetection() : this(BuiltinUtils.AllocNativeUObject(UKuroNetworkDetection.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06006D12 RID: 27922 RVA: 0x0009F5F8 File Offset: 0x0009D7F8
		public UKuroNetworkDetection(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroNetworkDetection.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06006D13 RID: 27923 RVA: 0x0009F62C File Offset: 0x0009D82C
		[NullableContext(2)]
		public unsafe static void TestUdpReachable([Nullable(1)] string IpAddress, in TArray<int> Ports, FTestUdpResultDelegate ResultDelegate)
		{
			FString fstring = FString.AllocTemp(IpAddress);
			UKuroNetworkDetection.__TestUdpReachable_Internal(fstring, (Ports ?? new TArray<int>()).NativePtr, (ResultDelegate != null) ? ResultDelegate.NativePtr : ((IntPtr)0));
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06006D14 RID: 27924 RVA: 0x0009F670 File Offset: 0x0009D870
		public unsafe static void SetCDNConfig(string CDNConfig)
		{
			FString fstring = FString.AllocTemp(CDNConfig);
			UKuroNetworkDetection.__SetCDNConfig_Internal(fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06006D15 RID: 27925 RVA: 0x0009F694 File Offset: 0x0009D894
		public unsafe static void ResolveDomainName(string DomainName, [Nullable(2)] FResolveDomainDelegate Callback)
		{
			FString fstring = FString.AllocTemp(DomainName);
			UKuroNetworkDetection.__ResolveDomainName_Internal(fstring, (Callback != null) ? Callback.NativePtr : ((IntPtr)0));
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06006D16 RID: 27926
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void ResolveDomainFinish();

		// Token: 0x06006D17 RID: 27927 RVA: 0x0009F6C8 File Offset: 0x0009D8C8
		public unsafe static string GetDetectionConfig(string ServerName)
		{
			FString fstring = FString.AllocTemp(ServerName);
			string result = FString.ToStringAndDeleteNativePtr(UKuroNetworkDetection.__GetDetectionConfig_Internal(fstring));
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x06006D18 RID: 27928 RVA: 0x0009F6F1 File Offset: 0x0009D8F1
		public static string GetCurrentProxyAddress()
		{
			return FString.ToStringAndDeleteNativePtr(UKuroNetworkDetection.__GetCurrentProxyAddress_Internal());
		}

		// Token: 0x06006D19 RID: 27929 RVA: 0x0009F700 File Offset: 0x0009D900
		public unsafe static void GatewayUdpReachable(string IpAddress, [Nullable(2)] in TArray<int> Ports, string Payload, [Nullable(2)] FTestUdpResultDelegate ResultDelegate)
		{
			FString fstring = FString.AllocTemp(IpAddress);
			FString fstring2 = FString.AllocTemp(Payload);
			UKuroNetworkDetection.__GatewayUdpReachable_Internal(fstring, (Ports ?? new TArray<int>()).NativePtr, fstring2, (ResultDelegate != null) ? ResultDelegate.NativePtr : ((IntPtr)0));
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
		}

		// Token: 0x06006D1A RID: 27930
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void DetectionFinish(bool bSuccess);

		// Token: 0x06006D1B RID: 27931
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void AbortGatewayUdpReachable();

		// Token: 0x06006D1C RID: 27932
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __TestUdpReachable_Internal(in FString IpAddress, IntPtr Ports, IntPtr ResultDelegate);

		// Token: 0x06006D1D RID: 27933
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetCDNConfig_Internal(in FString CDNConfig);

		// Token: 0x06006D1E RID: 27934
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ResolveDomainName_Internal(in FString DomainName, IntPtr Callback);

		// Token: 0x06006D1F RID: 27935
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetDetectionConfig_Internal(in FString ServerName);

		// Token: 0x06006D20 RID: 27936
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetCurrentProxyAddress_Internal();

		// Token: 0x06006D21 RID: 27937
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GatewayUdpReachable_Internal(in FString IpAddress, IntPtr Ports, in FString Payload, IntPtr ResultDelegate);

		// Token: 0x06006D22 RID: 27938 RVA: 0x0009F753 File Offset: 0x0009D953
		static UKuroNetworkDetection()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroNetwork.KuroNetworkDetection");
		}

		// Token: 0x06006D23 RID: 27939 RVA: 0x0009F761 File Offset: 0x0009D961
		protected UKuroNetworkDetection(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04002E97 RID: 11927
		public new const string __ObjectPath = "/Script/KuroNetwork.KuroNetworkDetection";

		// Token: 0x04002E98 RID: 11928
		private static IntPtr _ClassPtr;

		// Token: 0x04002E99 RID: 11929
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
