using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200087B RID: 2171
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/WwiseFileHandler.WwiseExternalSourceStatics")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UWwiseExternalSourceStatics : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600BD45 RID: 48453 RVA: 0x0012E087 File Offset: 0x0012C287
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UWwiseExternalSourceStatics._ClassPtr;
		}

		// Token: 0x0600BD46 RID: 48454 RVA: 0x0012E094 File Offset: 0x0012C294
		public UWwiseExternalSourceStatics() : this(BuiltinUtils.AllocNativeUObject(UWwiseExternalSourceStatics.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600BD47 RID: 48455 RVA: 0x0012E0BC File Offset: 0x0012C2BC
		public UWwiseExternalSourceStatics(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UWwiseExternalSourceStatics.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600BD48 RID: 48456 RVA: 0x0012E0F0 File Offset: 0x0012C2F0
		public unsafe static void SetExternalSourceMediaByName(string ExternalSourceName, string MediaName)
		{
			FString fstring = FString.AllocTemp(ExternalSourceName);
			FString fstring2 = FString.AllocTemp(MediaName);
			UWwiseExternalSourceStatics.__SetExternalSourceMediaByName_Internal(fstring, fstring2);
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
		}

		// Token: 0x0600BD49 RID: 48457 RVA: 0x0012E128 File Offset: 0x0012C328
		public unsafe static void SetExternalSourceMediaById(string ExternalSourceName, int MediaId)
		{
			FString fstring = FString.AllocTemp(ExternalSourceName);
			UWwiseExternalSourceStatics.__SetExternalSourceMediaById_Internal(fstring, MediaId);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x0600BD4A RID: 48458
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void InitExternalSourceConfigs();

		// Token: 0x0600BD4B RID: 48459
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetExternalSourceMediaByName_Internal(in FString ExternalSourceName, in FString MediaName);

		// Token: 0x0600BD4C RID: 48460
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetExternalSourceMediaById_Internal(in FString ExternalSourceName, int MediaId);

		// Token: 0x0600BD4D RID: 48461 RVA: 0x0012E14D File Offset: 0x0012C34D
		static UWwiseExternalSourceStatics()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/WwiseFileHandler.WwiseExternalSourceStatics");
		}

		// Token: 0x0600BD4E RID: 48462 RVA: 0x0012E15B File Offset: 0x0012C35B
		protected UWwiseExternalSourceStatics(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04005578 RID: 21880
		public new const string __ObjectPath = "/Script/WwiseFileHandler.WwiseExternalSourceStatics";

		// Token: 0x04005579 RID: 21881
		private static IntPtr _ClassPtr;

		// Token: 0x0400557A RID: 21882
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
