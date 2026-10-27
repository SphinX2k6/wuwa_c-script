using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200029F RID: 671
	[UnrealObjectPath("/Script/AkAudio.SAkWaapiFieldNamesConv")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class USAkWaapiFieldNamesConv : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600254A RID: 9546 RVA: 0x00037BEA File Offset: 0x00035DEA
		public new static UClassStackOnlyPtr StaticClass()
		{
			return USAkWaapiFieldNamesConv._ClassPtr;
		}

		// Token: 0x0600254B RID: 9547 RVA: 0x00037BF8 File Offset: 0x00035DF8
		public USAkWaapiFieldNamesConv() : this(BuiltinUtils.AllocNativeUObject(USAkWaapiFieldNamesConv.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600254C RID: 9548 RVA: 0x00037C20 File Offset: 0x00035E20
		[NullableContext(1)]
		public USAkWaapiFieldNamesConv(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(USAkWaapiFieldNamesConv.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600254D RID: 9549 RVA: 0x00037C53 File Offset: 0x00035E53
		[NullableContext(1)]
		public static FText Conv_FAkWaapiFieldNamesToText([Nullable(2)] in FAkWaapiFieldNames INAkWaapiFieldNames)
		{
			return new FText(USAkWaapiFieldNamesConv.__Conv_FAkWaapiFieldNamesToText_Internal((INAkWaapiFieldNames ?? new FAkWaapiFieldNames()).NativePtr), null);
		}

		// Token: 0x0600254E RID: 9550 RVA: 0x00037C70 File Offset: 0x00035E70
		[NullableContext(1)]
		public static string Conv_FAkWaapiFieldNamesToString([Nullable(2)] in FAkWaapiFieldNames INAkWaapiFieldNames)
		{
			return FString.ToStringAndDeleteNativePtr(USAkWaapiFieldNamesConv.__Conv_FAkWaapiFieldNamesToString_Internal((INAkWaapiFieldNames ?? new FAkWaapiFieldNames()).NativePtr));
		}

		// Token: 0x0600254F RID: 9551
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __Conv_FAkWaapiFieldNamesToText_Internal(IntPtr INAkWaapiFieldNames);

		// Token: 0x06002550 RID: 9552
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __Conv_FAkWaapiFieldNamesToString_Internal(IntPtr INAkWaapiFieldNames);

		// Token: 0x06002551 RID: 9553 RVA: 0x00037C8C File Offset: 0x00035E8C
		static USAkWaapiFieldNamesConv()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AkAudio.SAkWaapiFieldNamesConv");
		}

		// Token: 0x06002552 RID: 9554 RVA: 0x00037C9A File Offset: 0x00035E9A
		protected USAkWaapiFieldNamesConv(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000E2C RID: 3628
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AkAudio.SAkWaapiFieldNamesConv";

		// Token: 0x04000E2D RID: 3629
		private static IntPtr _ClassPtr;

		// Token: 0x04000E2E RID: 3630
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
