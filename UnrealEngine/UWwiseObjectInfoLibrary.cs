using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002A8F RID: 10895
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/WwiseResourceLoader.WwiseObjectInfoLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UWwiseObjectInfoLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060282A0 RID: 164512 RVA: 0x003D1C41 File Offset: 0x003CFE41
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UWwiseObjectInfoLibrary._ClassPtr;
		}

		// Token: 0x060282A1 RID: 164513 RVA: 0x003D1C50 File Offset: 0x003CFE50
		public UWwiseObjectInfoLibrary() : this(BuiltinUtils.AllocNativeUObject(UWwiseObjectInfoLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060282A2 RID: 164514 RVA: 0x003D1C78 File Offset: 0x003CFE78
		public UWwiseObjectInfoLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UWwiseObjectInfoLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060282A3 RID: 164515 RVA: 0x003D1CAB File Offset: 0x003CFEAB
		public static FWwiseObjectInfo SetWwiseShortId([Nullable(2)] in FWwiseObjectInfo Ref, int WwiseShortId)
		{
			return new FWwiseObjectInfo(UWwiseObjectInfoLibrary.__SetWwiseShortId_Internal((Ref ?? new FWwiseObjectInfo()).NativePtr, WwiseShortId), null);
		}

		// Token: 0x060282A4 RID: 164516 RVA: 0x003D1CCC File Offset: 0x003CFECC
		public unsafe static FWwiseObjectInfo SetWwiseName([Nullable(2)] in FWwiseObjectInfo Ref, string WwiseName)
		{
			FString fstring = FString.AllocTemp(WwiseName);
			FWwiseObjectInfo result = new FWwiseObjectInfo(UWwiseObjectInfoLibrary.__SetWwiseName_Internal((Ref ?? new FWwiseObjectInfo()).NativePtr, fstring), null);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x060282A5 RID: 164517 RVA: 0x003D1D06 File Offset: 0x003CFF06
		public static FWwiseObjectInfo SetWwiseGuid([Nullable(2)] in FWwiseObjectInfo Ref, in FGuid WwiseGuid)
		{
			return new FWwiseObjectInfo(UWwiseObjectInfoLibrary.__SetWwiseGuid_Internal((Ref ?? new FWwiseObjectInfo()).NativePtr, WwiseGuid), null);
		}

		// Token: 0x060282A6 RID: 164518 RVA: 0x003D1D24 File Offset: 0x003CFF24
		public static FWwiseObjectInfo SetHardCodedSoundBankShortId([Nullable(2)] in FWwiseObjectInfo Ref, int HardCodedSoundBankShortId = 0)
		{
			return new FWwiseObjectInfo(UWwiseObjectInfoLibrary.__SetHardCodedSoundBankShortId_Internal((Ref ?? new FWwiseObjectInfo()).NativePtr, HardCodedSoundBankShortId), null);
		}

		// Token: 0x060282A7 RID: 164519 RVA: 0x003D1D44 File Offset: 0x003CFF44
		public unsafe static FWwiseObjectInfo MakeStruct(in FGuid WwiseGuid, int WwiseShortId, string WwiseName, int HardCodedSoundBankShortId = 0)
		{
			FString fstring = FString.AllocTemp(WwiseName);
			FWwiseObjectInfo result = new FWwiseObjectInfo(UWwiseObjectInfoLibrary.__MakeStruct_Internal(WwiseGuid, WwiseShortId, fstring, HardCodedSoundBankShortId), null);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x060282A8 RID: 164520 RVA: 0x003D1D71 File Offset: 0x003CFF71
		[NullableContext(2)]
		public static int GetWwiseShortId(in FWwiseObjectInfo Ref)
		{
			return UWwiseObjectInfoLibrary.__GetWwiseShortId_Internal((Ref ?? new FWwiseObjectInfo()).NativePtr);
		}

		// Token: 0x060282A9 RID: 164521 RVA: 0x003D1D88 File Offset: 0x003CFF88
		public static string GetWwiseName([Nullable(2)] in FWwiseObjectInfo Ref)
		{
			return FString.ToStringAndDeleteNativePtr(UWwiseObjectInfoLibrary.__GetWwiseName_Internal((Ref ?? new FWwiseObjectInfo()).NativePtr));
		}

		// Token: 0x060282AA RID: 164522 RVA: 0x003D1DA4 File Offset: 0x003CFFA4
		[NullableContext(2)]
		public static FGuid GetWwiseGuid(in FWwiseObjectInfo Ref)
		{
			return UWwiseObjectInfoLibrary.__GetWwiseGuid_Internal((Ref ?? new FWwiseObjectInfo()).NativePtr);
		}

		// Token: 0x060282AB RID: 164523 RVA: 0x003D1DBB File Offset: 0x003CFFBB
		[NullableContext(2)]
		public static int GetHardCodedSoundBankShortId(in FWwiseObjectInfo Ref)
		{
			return UWwiseObjectInfoLibrary.__GetHardCodedSoundBankShortId_Internal((Ref ?? new FWwiseObjectInfo()).NativePtr);
		}

		// Token: 0x060282AC RID: 164524 RVA: 0x003D1DD4 File Offset: 0x003CFFD4
		public unsafe static void BreakStruct([Nullable(2)] FWwiseObjectInfo Ref, ref FGuid OutWwiseGuid, ref int OutWwiseShortId, ref string OutWwiseName, ref int OutHardCodedSoundBankShortId)
		{
			FString fstring = FString.AllocTemp(OutWwiseName);
			fixed (FGuid* ptr = &OutWwiseGuid)
			{
				void* ptr2 = (void*)ptr;
				fixed (int* ptr3 = &OutWwiseShortId)
				{
					void* ptr4 = (void*)ptr3;
					fixed (int* ptr5 = &OutHardCodedSoundBankShortId)
					{
						void* ptr6 = (void*)ptr5;
						UWwiseObjectInfoLibrary.__BreakStruct_Internal((Ref ?? new FWwiseObjectInfo()).NativePtr, ref OutWwiseGuid, ref OutWwiseShortId, ref fstring, ref OutHardCodedSoundBankShortId);
						OutWwiseName = FString.ToString(fstring);
						FString.NativeDestruct(&fstring, 1);
						ptr = null;
						ptr3 = null;
					}
				}
			}
		}

		// Token: 0x060282AD RID: 164525
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __SetWwiseShortId_Internal(IntPtr Ref, int WwiseShortId);

		// Token: 0x060282AE RID: 164526
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __SetWwiseName_Internal(IntPtr Ref, in FString WwiseName);

		// Token: 0x060282AF RID: 164527
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __SetWwiseGuid_Internal(IntPtr Ref, in FGuid WwiseGuid);

		// Token: 0x060282B0 RID: 164528
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __SetHardCodedSoundBankShortId_Internal(IntPtr Ref, int HardCodedSoundBankShortId);

		// Token: 0x060282B1 RID: 164529
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __MakeStruct_Internal(in FGuid WwiseGuid, int WwiseShortId, in FString WwiseName, int HardCodedSoundBankShortId);

		// Token: 0x060282B2 RID: 164530
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetWwiseShortId_Internal(IntPtr Ref);

		// Token: 0x060282B3 RID: 164531
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetWwiseName_Internal(IntPtr Ref);

		// Token: 0x060282B4 RID: 164532
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FGuid __GetWwiseGuid_Internal(IntPtr Ref);

		// Token: 0x060282B5 RID: 164533
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetHardCodedSoundBankShortId_Internal(IntPtr Ref);

		// Token: 0x060282B6 RID: 164534
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __BreakStruct_Internal(IntPtr Ref, ref FGuid OutWwiseGuid, ref int OutWwiseShortId, ref FString OutWwiseName, ref int OutHardCodedSoundBankShortId);

		// Token: 0x060282B7 RID: 164535 RVA: 0x003D1E37 File Offset: 0x003D0037
		static UWwiseObjectInfoLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/WwiseResourceLoader.WwiseObjectInfoLibrary");
		}

		// Token: 0x060282B8 RID: 164536 RVA: 0x003D1E45 File Offset: 0x003D0045
		protected UWwiseObjectInfoLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016079 RID: 90233
		public new const string __ObjectPath = "/Script/WwiseResourceLoader.WwiseObjectInfoLibrary";

		// Token: 0x0401607A RID: 90234
		private static IntPtr _ClassPtr;

		// Token: 0x0401607B RID: 90235
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
