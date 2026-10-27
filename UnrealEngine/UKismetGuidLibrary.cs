using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000CCD RID: 3277
	[UnrealObjectPath("/Script/Engine.KismetGuidLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UKismetGuidLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600A5A7 RID: 42407 RVA: 0x000EC4F9 File Offset: 0x000EA6F9
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKismetGuidLibrary._ClassPtr;
		}

		// Token: 0x0600A5A8 RID: 42408 RVA: 0x000EC508 File Offset: 0x000EA708
		public UKismetGuidLibrary() : this(BuiltinUtils.AllocNativeUObject(UKismetGuidLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600A5A9 RID: 42409 RVA: 0x000EC530 File Offset: 0x000EA730
		[NullableContext(1)]
		public UKismetGuidLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKismetGuidLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600A5AA RID: 42410 RVA: 0x000EC564 File Offset: 0x000EA764
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

		// Token: 0x0600A5AB RID: 42411
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool NotEqual_GuidGuid(in FGuid A, in FGuid B);

		// Token: 0x0600A5AC RID: 42412
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FGuid NewGuid();

		// Token: 0x0600A5AD RID: 42413
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool IsValid_Guid(in FGuid InGuid);

		// Token: 0x0600A5AE RID: 42414
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void Invalidate_Guid(ref FGuid InGuid);

		// Token: 0x0600A5AF RID: 42415
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool EqualEqual_GuidGuid(in FGuid A, in FGuid B);

		// Token: 0x0600A5B0 RID: 42416 RVA: 0x000EC59D File Offset: 0x000EA79D
		[NullableContext(1)]
		public static string Conv_GuidToString(in FGuid InGuid)
		{
			return FString.ToStringAndDeleteNativePtr(UKismetGuidLibrary.__Conv_GuidToString_Internal(InGuid));
		}

		// Token: 0x0600A5B1 RID: 42417
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Parse_StringToGuid_Internal(in FString GuidString, ref FGuid OutGuid, ref bool Success);

		// Token: 0x0600A5B2 RID: 42418
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __Conv_GuidToString_Internal(in FGuid InGuid);

		// Token: 0x0600A5B3 RID: 42419 RVA: 0x000EC5AA File Offset: 0x000EA7AA
		static UKismetGuidLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.KismetGuidLibrary");
		}

		// Token: 0x0600A5B4 RID: 42420 RVA: 0x000EC5B8 File Offset: 0x000EA7B8
		protected UKismetGuidLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04005B2A RID: 23338
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.KismetGuidLibrary";

		// Token: 0x04005B2B RID: 23339
		private static IntPtr _ClassPtr;

		// Token: 0x04005B2C RID: 23340
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
