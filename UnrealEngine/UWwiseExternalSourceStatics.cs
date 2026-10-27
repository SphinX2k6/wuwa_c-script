using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002A73 RID: 10867
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/WwiseFileHandler.WwiseExternalSourceStatics")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UWwiseExternalSourceStatics : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602811F RID: 164127 RVA: 0x003CFEF3 File Offset: 0x003CE0F3
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UWwiseExternalSourceStatics._ClassPtr;
		}

		// Token: 0x06028120 RID: 164128 RVA: 0x003CFF00 File Offset: 0x003CE100
		public UWwiseExternalSourceStatics() : this(BuiltinUtils.AllocNativeUObject(UWwiseExternalSourceStatics.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06028121 RID: 164129 RVA: 0x003CFF28 File Offset: 0x003CE128
		public UWwiseExternalSourceStatics(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UWwiseExternalSourceStatics.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06028122 RID: 164130 RVA: 0x003CFF5B File Offset: 0x003CE15B
		[NullableContext(2)]
		public static void SetExternalSourceMediaWithIds(FAkUniqueID ExternalSourceCookie, int MediaId)
		{
			UWwiseExternalSourceStatics.__SetExternalSourceMediaWithIds_Internal((ExternalSourceCookie ?? new FAkUniqueID()).NativePtr, MediaId);
		}

		// Token: 0x06028123 RID: 164131 RVA: 0x003CFF74 File Offset: 0x003CE174
		public unsafe static void SetExternalSourceMediaByName(string ExternalSourceName, string MediaName)
		{
			FString fstring = FString.AllocTemp(ExternalSourceName);
			FString fstring2 = FString.AllocTemp(MediaName);
			UWwiseExternalSourceStatics.__SetExternalSourceMediaByName_Internal(fstring, fstring2);
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
		}

		// Token: 0x06028124 RID: 164132 RVA: 0x003CFFAC File Offset: 0x003CE1AC
		public unsafe static void SetExternalSourceMediaById(string ExternalSourceName, int MediaId)
		{
			FString fstring = FString.AllocTemp(ExternalSourceName);
			UWwiseExternalSourceStatics.__SetExternalSourceMediaById_Internal(fstring, MediaId);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06028125 RID: 164133
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void InitExternalSourceConfigs();

		// Token: 0x06028126 RID: 164134
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetExternalSourceMediaWithIds_Internal(IntPtr ExternalSourceCookie, int MediaId);

		// Token: 0x06028127 RID: 164135
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetExternalSourceMediaByName_Internal(in FString ExternalSourceName, in FString MediaName);

		// Token: 0x06028128 RID: 164136
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetExternalSourceMediaById_Internal(in FString ExternalSourceName, int MediaId);

		// Token: 0x06028129 RID: 164137 RVA: 0x003CFFD1 File Offset: 0x003CE1D1
		static UWwiseExternalSourceStatics()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/WwiseFileHandler.WwiseExternalSourceStatics");
		}

		// Token: 0x0602812A RID: 164138 RVA: 0x003CFFDF File Offset: 0x003CE1DF
		protected UWwiseExternalSourceStatics(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015FE3 RID: 90083
		public new const string __ObjectPath = "/Script/WwiseFileHandler.WwiseExternalSourceStatics";

		// Token: 0x04015FE4 RID: 90084
		private static IntPtr _ClassPtr;

		// Token: 0x04015FE5 RID: 90085
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
