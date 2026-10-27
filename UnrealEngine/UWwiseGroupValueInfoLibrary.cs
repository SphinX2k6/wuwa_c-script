using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002A87 RID: 10887
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/WwiseResourceLoader.WwiseGroupValueInfoLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UWwiseGroupValueInfoLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06028227 RID: 164391 RVA: 0x003D129B File Offset: 0x003CF49B
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UWwiseGroupValueInfoLibrary._ClassPtr;
		}

		// Token: 0x06028228 RID: 164392 RVA: 0x003D12A8 File Offset: 0x003CF4A8
		public UWwiseGroupValueInfoLibrary() : this(BuiltinUtils.AllocNativeUObject(UWwiseGroupValueInfoLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06028229 RID: 164393 RVA: 0x003D12D0 File Offset: 0x003CF4D0
		public UWwiseGroupValueInfoLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UWwiseGroupValueInfoLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602822A RID: 164394 RVA: 0x003D1303 File Offset: 0x003CF503
		public static FWwiseGroupValueInfo SetWwiseShortId([Nullable(2)] in FWwiseGroupValueInfo Ref, int WwiseShortId)
		{
			return new FWwiseGroupValueInfo(UWwiseGroupValueInfoLibrary.__SetWwiseShortId_Internal((Ref ?? new FWwiseGroupValueInfo()).NativePtr, WwiseShortId), null);
		}

		// Token: 0x0602822B RID: 164395 RVA: 0x003D1324 File Offset: 0x003CF524
		public unsafe static FWwiseGroupValueInfo SetWwiseName([Nullable(2)] in FWwiseGroupValueInfo Ref, string WwiseName)
		{
			FString fstring = FString.AllocTemp(WwiseName);
			FWwiseGroupValueInfo result = new FWwiseGroupValueInfo(UWwiseGroupValueInfoLibrary.__SetWwiseName_Internal((Ref ?? new FWwiseGroupValueInfo()).NativePtr, fstring), null);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x0602822C RID: 164396 RVA: 0x003D135E File Offset: 0x003CF55E
		public static FWwiseGroupValueInfo SetGroupShortId([Nullable(2)] in FWwiseGroupValueInfo Ref, int GroupShortId)
		{
			return new FWwiseGroupValueInfo(UWwiseGroupValueInfoLibrary.__SetGroupShortId_Internal((Ref ?? new FWwiseGroupValueInfo()).NativePtr, GroupShortId), null);
		}

		// Token: 0x0602822D RID: 164397 RVA: 0x003D137C File Offset: 0x003CF57C
		public static FWwiseGroupValueInfo SetAssetGuid([Nullable(2)] in FWwiseGroupValueInfo Ref, in FGuid AssetGuid)
		{
			return new FWwiseGroupValueInfo(UWwiseGroupValueInfoLibrary.__SetAssetGuid_Internal((Ref ?? new FWwiseGroupValueInfo()).NativePtr, AssetGuid), null);
		}

		// Token: 0x0602822E RID: 164398 RVA: 0x003D139C File Offset: 0x003CF59C
		public unsafe static FWwiseGroupValueInfo MakeStruct(in FGuid AssetGuid, int GroupShortId, int WwiseShortId, string WwiseName)
		{
			FString fstring = FString.AllocTemp(WwiseName);
			FWwiseGroupValueInfo result = new FWwiseGroupValueInfo(UWwiseGroupValueInfoLibrary.__MakeStruct_Internal(AssetGuid, GroupShortId, WwiseShortId, fstring), null);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x0602822F RID: 164399 RVA: 0x003D13C9 File Offset: 0x003CF5C9
		[NullableContext(2)]
		public static int GetWwiseShortId(in FWwiseGroupValueInfo Ref)
		{
			return UWwiseGroupValueInfoLibrary.__GetWwiseShortId_Internal((Ref ?? new FWwiseGroupValueInfo()).NativePtr);
		}

		// Token: 0x06028230 RID: 164400 RVA: 0x003D13E0 File Offset: 0x003CF5E0
		public static string GetWwiseName([Nullable(2)] in FWwiseGroupValueInfo Ref)
		{
			return FString.ToStringAndDeleteNativePtr(UWwiseGroupValueInfoLibrary.__GetWwiseName_Internal((Ref ?? new FWwiseGroupValueInfo()).NativePtr));
		}

		// Token: 0x06028231 RID: 164401 RVA: 0x003D13FC File Offset: 0x003CF5FC
		[NullableContext(2)]
		public static int GetGroupShortId(in FWwiseGroupValueInfo Ref)
		{
			return UWwiseGroupValueInfoLibrary.__GetGroupShortId_Internal((Ref ?? new FWwiseGroupValueInfo()).NativePtr);
		}

		// Token: 0x06028232 RID: 164402 RVA: 0x003D1413 File Offset: 0x003CF613
		[NullableContext(2)]
		public static FGuid GetAssetGuid(in FWwiseGroupValueInfo Ref)
		{
			return UWwiseGroupValueInfoLibrary.__GetAssetGuid_Internal((Ref ?? new FWwiseGroupValueInfo()).NativePtr);
		}

		// Token: 0x06028233 RID: 164403 RVA: 0x003D142C File Offset: 0x003CF62C
		public unsafe static void BreakStruct([Nullable(2)] FWwiseGroupValueInfo Ref, ref FGuid OutAssetGuid, ref int OutGroupShortId, ref int OutWwiseShortId, ref string OutWwiseName)
		{
			FString fstring = FString.AllocTemp(OutWwiseName);
			fixed (FGuid* ptr = &OutAssetGuid)
			{
				void* ptr2 = (void*)ptr;
				fixed (int* ptr3 = &OutGroupShortId)
				{
					void* ptr4 = (void*)ptr3;
					fixed (int* ptr5 = &OutWwiseShortId)
					{
						void* ptr6 = (void*)ptr5;
						UWwiseGroupValueInfoLibrary.__BreakStruct_Internal((Ref ?? new FWwiseGroupValueInfo()).NativePtr, ref OutAssetGuid, ref OutGroupShortId, ref OutWwiseShortId, ref fstring);
						OutWwiseName = FString.ToString(fstring);
						FString.NativeDestruct(&fstring, 1);
						ptr = null;
						ptr3 = null;
					}
				}
			}
		}

		// Token: 0x06028234 RID: 164404
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __SetWwiseShortId_Internal(IntPtr Ref, int WwiseShortId);

		// Token: 0x06028235 RID: 164405
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __SetWwiseName_Internal(IntPtr Ref, in FString WwiseName);

		// Token: 0x06028236 RID: 164406
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __SetGroupShortId_Internal(IntPtr Ref, int GroupShortId);

		// Token: 0x06028237 RID: 164407
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __SetAssetGuid_Internal(IntPtr Ref, in FGuid AssetGuid);

		// Token: 0x06028238 RID: 164408
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __MakeStruct_Internal(in FGuid AssetGuid, int GroupShortId, int WwiseShortId, in FString WwiseName);

		// Token: 0x06028239 RID: 164409
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetWwiseShortId_Internal(IntPtr Ref);

		// Token: 0x0602823A RID: 164410
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetWwiseName_Internal(IntPtr Ref);

		// Token: 0x0602823B RID: 164411
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetGroupShortId_Internal(IntPtr Ref);

		// Token: 0x0602823C RID: 164412
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FGuid __GetAssetGuid_Internal(IntPtr Ref);

		// Token: 0x0602823D RID: 164413
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __BreakStruct_Internal(IntPtr Ref, ref FGuid OutAssetGuid, ref int OutGroupShortId, ref int OutWwiseShortId, ref FString OutWwiseName);

		// Token: 0x0602823E RID: 164414 RVA: 0x003D148F File Offset: 0x003CF68F
		static UWwiseGroupValueInfoLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/WwiseResourceLoader.WwiseGroupValueInfoLibrary");
		}

		// Token: 0x0602823F RID: 164415 RVA: 0x003D149D File Offset: 0x003CF69D
		protected UWwiseGroupValueInfoLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401604E RID: 90190
		public new const string __ObjectPath = "/Script/WwiseResourceLoader.WwiseGroupValueInfoLibrary";

		// Token: 0x0401604F RID: 90191
		private static IntPtr _ClassPtr;

		// Token: 0x04016050 RID: 90192
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
