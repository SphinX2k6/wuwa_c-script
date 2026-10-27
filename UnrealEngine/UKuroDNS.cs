using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020019F3 RID: 6643
	[UnrealObjectPath("/Script/KuroNetwork.KuroDNS")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UKuroDNS : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060189FF RID: 100863 RVA: 0x00244AA2 File Offset: 0x00242CA2
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroDNS._ClassPtr;
		}

		// Token: 0x06018A00 RID: 100864 RVA: 0x00244AB0 File Offset: 0x00242CB0
		public UKuroDNS() : this(BuiltinUtils.AllocNativeUObject(UKuroDNS.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06018A01 RID: 100865 RVA: 0x00244AD8 File Offset: 0x00242CD8
		[NullableContext(1)]
		public UKuroDNS(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroDNS.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06018A02 RID: 100866 RVA: 0x00244B0C File Offset: 0x00242D0C
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

		// Token: 0x06018A03 RID: 100867
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __DNSResolution_Internal(in FString DomainName, in FName Protocol, IntPtr Callback);

		// Token: 0x06018A04 RID: 100868 RVA: 0x00244B46 File Offset: 0x00242D46
		static UKuroDNS()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroNetwork.KuroDNS");
		}

		// Token: 0x06018A05 RID: 100869 RVA: 0x00244B54 File Offset: 0x00242D54
		protected UKuroDNS(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400D4F7 RID: 54519
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroNetwork.KuroDNS";

		// Token: 0x0400D4F8 RID: 54520
		private static IntPtr _ClassPtr;

		// Token: 0x0400D4F9 RID: 54521
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
