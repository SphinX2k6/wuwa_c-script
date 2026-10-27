using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002A83 RID: 10883
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/WwiseResourceLoader.WwiseEventInfoLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UWwiseEventInfoLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060281E0 RID: 164320 RVA: 0x003D0D67 File Offset: 0x003CEF67
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UWwiseEventInfoLibrary._ClassPtr;
		}

		// Token: 0x060281E1 RID: 164321 RVA: 0x003D0D74 File Offset: 0x003CEF74
		public UWwiseEventInfoLibrary() : this(BuiltinUtils.AllocNativeUObject(UWwiseEventInfoLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060281E2 RID: 164322 RVA: 0x003D0D9C File Offset: 0x003CEF9C
		public UWwiseEventInfoLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UWwiseEventInfoLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060281E3 RID: 164323 RVA: 0x003D0DCF File Offset: 0x003CEFCF
		public static FWwiseEventInfo SetWwiseShortId([Nullable(2)] in FWwiseEventInfo Ref, int WwiseShortId)
		{
			return new FWwiseEventInfo(UWwiseEventInfoLibrary.__SetWwiseShortId_Internal((Ref ?? new FWwiseEventInfo()).NativePtr, WwiseShortId), null);
		}

		// Token: 0x060281E4 RID: 164324 RVA: 0x003D0DF0 File Offset: 0x003CEFF0
		public unsafe static FWwiseEventInfo SetWwiseName([Nullable(2)] in FWwiseEventInfo Ref, string WwiseName)
		{
			FString fstring = FString.AllocTemp(WwiseName);
			FWwiseEventInfo result = new FWwiseEventInfo(UWwiseEventInfoLibrary.__SetWwiseName_Internal((Ref ?? new FWwiseEventInfo()).NativePtr, fstring), null);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x060281E5 RID: 164325 RVA: 0x003D0E2A File Offset: 0x003CF02A
		public static FWwiseEventInfo SetWwiseGuid([Nullable(2)] in FWwiseEventInfo Ref, in FGuid WwiseGuid)
		{
			return new FWwiseEventInfo(UWwiseEventInfoLibrary.__SetWwiseGuid_Internal((Ref ?? new FWwiseEventInfo()).NativePtr, WwiseGuid), null);
		}

		// Token: 0x060281E6 RID: 164326 RVA: 0x003D0E48 File Offset: 0x003CF048
		public unsafe static FWwiseEventInfo SetSwitchContainerLoading([Nullable(2)] in FWwiseEventInfo Ref, in EWwiseEventSwitchContainerLoading SwitchContainerLoading)
		{
			fixed (EWwiseEventSwitchContainerLoading* ptr = &SwitchContainerLoading)
			{
				void* ptr2 = (void*)ptr;
				return new FWwiseEventInfo(UWwiseEventInfoLibrary.__SetSwitchContainerLoading_Internal((Ref ?? new FWwiseEventInfo()).NativePtr, SwitchContainerLoading), null);
			}
		}

		// Token: 0x060281E7 RID: 164327 RVA: 0x003D0E76 File Offset: 0x003CF076
		public static FWwiseEventInfo SetHardCodedSoundBankShortId([Nullable(2)] in FWwiseEventInfo Ref, int HardCodedSoundBankShortId = 0)
		{
			return new FWwiseEventInfo(UWwiseEventInfoLibrary.__SetHardCodedSoundBankShortId_Internal((Ref ?? new FWwiseEventInfo()).NativePtr, HardCodedSoundBankShortId), null);
		}

		// Token: 0x060281E8 RID: 164328 RVA: 0x003D0E94 File Offset: 0x003CF094
		public unsafe static FWwiseEventInfo SetDestroyOptions([Nullable(2)] in FWwiseEventInfo Ref, in EWwiseEventDestroyOptions DestroyOptions)
		{
			fixed (EWwiseEventDestroyOptions* ptr = &DestroyOptions)
			{
				void* ptr2 = (void*)ptr;
				return new FWwiseEventInfo(UWwiseEventInfoLibrary.__SetDestroyOptions_Internal((Ref ?? new FWwiseEventInfo()).NativePtr, DestroyOptions), null);
			}
		}

		// Token: 0x060281E9 RID: 164329 RVA: 0x003D0EC4 File Offset: 0x003CF0C4
		public unsafe static FWwiseEventInfo MakeStruct(in FGuid WwiseGuid, int WwiseShortId, string WwiseName, EWwiseEventSwitchContainerLoading SwitchContainerLoading, EWwiseEventDestroyOptions DestroyOptions, int HardCodedSoundBankShortId = 0)
		{
			FString fstring = FString.AllocTemp(WwiseName);
			FWwiseEventInfo result = new FWwiseEventInfo(UWwiseEventInfoLibrary.__MakeStruct_Internal(WwiseGuid, WwiseShortId, fstring, SwitchContainerLoading, DestroyOptions, HardCodedSoundBankShortId), null);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x060281EA RID: 164330 RVA: 0x003D0EF5 File Offset: 0x003CF0F5
		[NullableContext(2)]
		public static int GetWwiseShortId(in FWwiseEventInfo Ref)
		{
			return UWwiseEventInfoLibrary.__GetWwiseShortId_Internal((Ref ?? new FWwiseEventInfo()).NativePtr);
		}

		// Token: 0x060281EB RID: 164331 RVA: 0x003D0F0C File Offset: 0x003CF10C
		public static string GetWwiseName([Nullable(2)] in FWwiseEventInfo Ref)
		{
			return FString.ToStringAndDeleteNativePtr(UWwiseEventInfoLibrary.__GetWwiseName_Internal((Ref ?? new FWwiseEventInfo()).NativePtr));
		}

		// Token: 0x060281EC RID: 164332 RVA: 0x003D0F28 File Offset: 0x003CF128
		[NullableContext(2)]
		public static FGuid GetWwiseGuid(in FWwiseEventInfo Ref)
		{
			return UWwiseEventInfoLibrary.__GetWwiseGuid_Internal((Ref ?? new FWwiseEventInfo()).NativePtr);
		}

		// Token: 0x060281ED RID: 164333 RVA: 0x003D0F3F File Offset: 0x003CF13F
		[NullableContext(2)]
		public static EWwiseEventSwitchContainerLoading GetSwitchContainerLoading(in FWwiseEventInfo Ref)
		{
			return UWwiseEventInfoLibrary.__GetSwitchContainerLoading_Internal((Ref ?? new FWwiseEventInfo()).NativePtr);
		}

		// Token: 0x060281EE RID: 164334 RVA: 0x003D0F56 File Offset: 0x003CF156
		[NullableContext(2)]
		public static int GetHardCodedSoundBankShortId(in FWwiseEventInfo Ref)
		{
			return UWwiseEventInfoLibrary.__GetHardCodedSoundBankShortId_Internal((Ref ?? new FWwiseEventInfo()).NativePtr);
		}

		// Token: 0x060281EF RID: 164335 RVA: 0x003D0F6D File Offset: 0x003CF16D
		[NullableContext(2)]
		public static EWwiseEventDestroyOptions GetDestroyOptions(in FWwiseEventInfo Ref)
		{
			return UWwiseEventInfoLibrary.__GetDestroyOptions_Internal((Ref ?? new FWwiseEventInfo()).NativePtr);
		}

		// Token: 0x060281F0 RID: 164336 RVA: 0x003D0F84 File Offset: 0x003CF184
		public unsafe static void BreakStruct([Nullable(2)] FWwiseEventInfo Ref, ref FGuid OutWwiseGuid, ref int OutWwiseShortId, ref string OutWwiseName, ref EWwiseEventSwitchContainerLoading OutSwitchContainerLoading, ref EWwiseEventDestroyOptions OutDestroyOptions, ref int OutHardCodedSoundBankShortId)
		{
			FString fstring = FString.AllocTemp(OutWwiseName);
			fixed (FGuid* ptr = &OutWwiseGuid)
			{
				void* ptr2 = (void*)ptr;
				fixed (int* ptr3 = &OutWwiseShortId)
				{
					void* ptr4 = (void*)ptr3;
					fixed (EWwiseEventSwitchContainerLoading* ptr5 = &OutSwitchContainerLoading)
					{
						void* ptr6 = (void*)ptr5;
						fixed (EWwiseEventDestroyOptions* ptr7 = &OutDestroyOptions)
						{
							void* ptr8 = (void*)ptr7;
							fixed (int* ptr9 = &OutHardCodedSoundBankShortId)
							{
								void* ptr10 = (void*)ptr9;
								UWwiseEventInfoLibrary.__BreakStruct_Internal((Ref ?? new FWwiseEventInfo()).NativePtr, ref OutWwiseGuid, ref OutWwiseShortId, ref fstring, ref OutSwitchContainerLoading, ref OutDestroyOptions, ref OutHardCodedSoundBankShortId);
								OutWwiseName = FString.ToString(fstring);
								FString.NativeDestruct(&fstring, 1);
								ptr = null;
								ptr3 = null;
								ptr5 = null;
								ptr7 = null;
							}
						}
					}
				}
			}
		}

		// Token: 0x060281F1 RID: 164337
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __SetWwiseShortId_Internal(IntPtr Ref, int WwiseShortId);

		// Token: 0x060281F2 RID: 164338
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __SetWwiseName_Internal(IntPtr Ref, in FString WwiseName);

		// Token: 0x060281F3 RID: 164339
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __SetWwiseGuid_Internal(IntPtr Ref, in FGuid WwiseGuid);

		// Token: 0x060281F4 RID: 164340
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __SetSwitchContainerLoading_Internal(IntPtr Ref, in EWwiseEventSwitchContainerLoading SwitchContainerLoading);

		// Token: 0x060281F5 RID: 164341
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __SetHardCodedSoundBankShortId_Internal(IntPtr Ref, int HardCodedSoundBankShortId);

		// Token: 0x060281F6 RID: 164342
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __SetDestroyOptions_Internal(IntPtr Ref, in EWwiseEventDestroyOptions DestroyOptions);

		// Token: 0x060281F7 RID: 164343
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __MakeStruct_Internal(in FGuid WwiseGuid, int WwiseShortId, in FString WwiseName, EWwiseEventSwitchContainerLoading SwitchContainerLoading, EWwiseEventDestroyOptions DestroyOptions, int HardCodedSoundBankShortId);

		// Token: 0x060281F8 RID: 164344
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetWwiseShortId_Internal(IntPtr Ref);

		// Token: 0x060281F9 RID: 164345
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetWwiseName_Internal(IntPtr Ref);

		// Token: 0x060281FA RID: 164346
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FGuid __GetWwiseGuid_Internal(IntPtr Ref);

		// Token: 0x060281FB RID: 164347
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern EWwiseEventSwitchContainerLoading __GetSwitchContainerLoading_Internal(IntPtr Ref);

		// Token: 0x060281FC RID: 164348
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetHardCodedSoundBankShortId_Internal(IntPtr Ref);

		// Token: 0x060281FD RID: 164349
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern EWwiseEventDestroyOptions __GetDestroyOptions_Internal(IntPtr Ref);

		// Token: 0x060281FE RID: 164350
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __BreakStruct_Internal(IntPtr Ref, ref FGuid OutWwiseGuid, ref int OutWwiseShortId, ref FString OutWwiseName, ref EWwiseEventSwitchContainerLoading OutSwitchContainerLoading, ref EWwiseEventDestroyOptions OutDestroyOptions, ref int OutHardCodedSoundBankShortId);

		// Token: 0x060281FF RID: 164351 RVA: 0x003D1005 File Offset: 0x003CF205
		static UWwiseEventInfoLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/WwiseResourceLoader.WwiseEventInfoLibrary");
		}

		// Token: 0x06028200 RID: 164352 RVA: 0x003D1013 File Offset: 0x003CF213
		protected UWwiseEventInfoLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401603E RID: 90174
		public new const string __ObjectPath = "/Script/WwiseResourceLoader.WwiseEventInfoLibrary";

		// Token: 0x0401603F RID: 90175
		private static IntPtr _ClassPtr;

		// Token: 0x04016040 RID: 90176
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
