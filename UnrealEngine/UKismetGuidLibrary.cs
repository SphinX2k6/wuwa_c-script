using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000220 RID: 544
	[UnrealObjectPath("/Script/Engine.KismetGuidLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UKismetGuidLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600251D RID: 9501 RVA: 0x000357B8 File Offset: 0x000339B8
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKismetGuidLibrary._ClassPtr;
		}

		// Token: 0x0600251E RID: 9502 RVA: 0x000357C4 File Offset: 0x000339C4
		public UKismetGuidLibrary() : this(BuiltinUtils.AllocNativeUObject(UKismetGuidLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600251F RID: 9503 RVA: 0x000357EC File Offset: 0x000339EC
		[NullableContext(1)]
		public UKismetGuidLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKismetGuidLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06002520 RID: 9504 RVA: 0x00035820 File Offset: 0x00033A20
		[NullableContext(1)]
		public unsafe static void Parse_StringToGuid(string GuidString, ref FGuid OutGuid, ref bool Success)
		{
			FString fstring = FString.AllocTemp(GuidString);
			fixed (FGuid* ptr = &OutGuid)
			{
				void* ptr2 = (void*)ptr;
				fixed (bool* ptr3 = &Success)
				{
					void* ptr4 = (void*)ptr3;
					UKismetGuidLibrary.__Parse_StringToGuid_Internal(fstring, ref OutGuid, ref Success);
					FString.NativeDestruct(&fstring, 1);
					ptr = null;
				}
			}
		}

		// Token: 0x06002521 RID: 9505
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool NotEqual_GuidGuid(in FGuid A, in FGuid B);

		// Token: 0x06002522 RID: 9506
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FGuid NewGuid();

		// Token: 0x06002523 RID: 9507
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool IsValid_Guid(in FGuid InGuid);

		// Token: 0x06002524 RID: 9508
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void Invalidate_Guid(ref FGuid InGuid);

		// Token: 0x06002525 RID: 9509
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool EqualEqual_GuidGuid(in FGuid A, in FGuid B);

		// Token: 0x06002526 RID: 9510 RVA: 0x00035859 File Offset: 0x00033A59
		[NullableContext(1)]
		public static string Conv_GuidToString(in FGuid InGuid)
		{
			return FString.ToStringAndDeleteNativePtr(UKismetGuidLibrary.__Conv_GuidToString_Internal(InGuid));
		}

		// Token: 0x06002527 RID: 9511
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Parse_StringToGuid_Internal(in FString GuidString, ref FGuid OutGuid, ref bool Success);

		// Token: 0x06002528 RID: 9512
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __Conv_GuidToString_Internal(in FGuid InGuid);

		// Token: 0x06002529 RID: 9513 RVA: 0x00035866 File Offset: 0x00033A66
		static UKismetGuidLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.KismetGuidLibrary");
		}

		// Token: 0x0600252A RID: 9514 RVA: 0x00035874 File Offset: 0x00033A74
		protected UKismetGuidLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000E04 RID: 3588
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.KismetGuidLibrary";

		// Token: 0x04000E05 RID: 3589
		private static IntPtr _ClassPtr;

		// Token: 0x04000E06 RID: 3590
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
