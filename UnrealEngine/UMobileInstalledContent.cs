using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000757 RID: 1879
	[UnrealObjectPath("/Script/MobilePatchingUtils.MobileInstalledContent")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 80)]
	public class UMobileInstalledContent : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600A404 RID: 41988 RVA: 0x000F227A File Offset: 0x000F047A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMobileInstalledContent._ClassPtr;
		}

		// Token: 0x0600A405 RID: 41989 RVA: 0x000F2288 File Offset: 0x000F0488
		public UMobileInstalledContent() : this(BuiltinUtils.AllocNativeUObject(UMobileInstalledContent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600A406 RID: 41990 RVA: 0x000F22B0 File Offset: 0x000F04B0
		[NullableContext(1)]
		public UMobileInstalledContent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMobileInstalledContent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600A407 RID: 41991 RVA: 0x000F22E4 File Offset: 0x000F04E4
		[NullableContext(1)]
		public unsafe bool Mount(int PakOrder, string MountPoint)
		{
			FString fstring = FString.AllocTemp(MountPoint);
			bool result = UMobileInstalledContent.__Mount_Internal(base.NativePtr, PakOrder, fstring);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x0600A408 RID: 41992 RVA: 0x000F230F File Offset: 0x000F050F
		public float GetInstalledContentSize()
		{
			return UMobileInstalledContent.__GetInstalledContentSize_Internal(base.NativePtr);
		}

		// Token: 0x0600A409 RID: 41993
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __Mount_Internal(IntPtr @this, int PakOrder, in FString MountPoint);

		// Token: 0x0600A40A RID: 41994
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetInstalledContentSize_Internal(IntPtr @this);

		// Token: 0x0600A40B RID: 41995 RVA: 0x000F231C File Offset: 0x000F051C
		static UMobileInstalledContent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MobilePatchingUtils.MobileInstalledContent");
		}

		// Token: 0x0600A40C RID: 41996 RVA: 0x000F232A File Offset: 0x000F052A
		protected UMobileInstalledContent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040045F6 RID: 17910
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/MobilePatchingUtils.MobileInstalledContent";

		// Token: 0x040045F7 RID: 17911
		private static IntPtr _ClassPtr;

		// Token: 0x040045F8 RID: 17912
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
