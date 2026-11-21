using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000479 RID: 1145
	[UnrealObjectPath("/Script/KuroNetwork.KuroDNS")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UKuroDNS : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06006C7C RID: 27772 RVA: 0x0009E2A6 File Offset: 0x0009C4A6
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroDNS._ClassPtr;
		}

		// Token: 0x06006C7D RID: 27773 RVA: 0x0009E2B4 File Offset: 0x0009C4B4
		public UKuroDNS() : this(BuiltinUtils.AllocNativeUObject(UKuroDNS.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06006C7E RID: 27774 RVA: 0x0009E2DC File Offset: 0x0009C4DC
		[NullableContext(1)]
		public UKuroDNS(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroDNS.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06006C7F RID: 27775 RVA: 0x0009E310 File Offset: 0x0009C510
		[NullableContext(1)]
		public unsafe static void DNSResolution(string DomainName, in FName Protocol, [Nullable(2)] FDNSResolutionDelegate Callback)
		{
			FString fstring = FString.AllocTemp(DomainName);
			fixed (FName* ptr = &Protocol)
			{
				void* ptr2 = (void*)ptr;
				UKuroDNS.__DNSResolution_Internal(fstring, Protocol, (Callback != null) ? Callback.NativePtr : ((IntPtr)0));
				FString.NativeDestruct(&fstring, 1);
			}
		}

		// Token: 0x06006C80 RID: 27776
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __DNSResolution_Internal(in FString DomainName, in FName Protocol, IntPtr Callback);

		// Token: 0x06006C81 RID: 27777 RVA: 0x0009E34A File Offset: 0x0009C54A
		static UKuroDNS()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroNetwork.KuroDNS");
		}

		// Token: 0x06006C82 RID: 27778 RVA: 0x0009E358 File Offset: 0x0009C558
		protected UKuroDNS(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04002E59 RID: 11865
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroNetwork.KuroDNS";

		// Token: 0x04002E5A RID: 11866
		private static IntPtr _ClassPtr;

		// Token: 0x04002E5B RID: 11867
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
