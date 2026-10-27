using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020022F6 RID: 8950
	[UnrealObjectPath("/Script/MobilePatchingUtils.MobileInstalledContent")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 80)]
	public class UMobileInstalledContent : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06021ED0 RID: 138960 RVA: 0x00322B59 File Offset: 0x00320D59
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMobileInstalledContent._ClassPtr;
		}

		// Token: 0x06021ED1 RID: 138961 RVA: 0x00322B68 File Offset: 0x00320D68
		public UMobileInstalledContent() : this(BuiltinUtils.AllocNativeUObject(UMobileInstalledContent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06021ED2 RID: 138962 RVA: 0x00322B90 File Offset: 0x00320D90
		[NullableContext(1)]
		public UMobileInstalledContent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMobileInstalledContent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06021ED3 RID: 138963 RVA: 0x00322BC4 File Offset: 0x00320DC4
		[NullableContext(1)]
		public unsafe bool Mount(int PakOrder, string MountPoint)
		{
			FString fstring = FString.AllocTemp(MountPoint);
			bool result = UMobileInstalledContent.__Mount_Internal(base.NativePtr, PakOrder, fstring);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x06021ED4 RID: 138964 RVA: 0x00322BEF File Offset: 0x00320DEF
		public float GetInstalledContentSize()
		{
			return UMobileInstalledContent.__GetInstalledContentSize_Internal(base.NativePtr);
		}

		// Token: 0x06021ED5 RID: 138965
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __Mount_Internal(IntPtr @this, int PakOrder, in FString MountPoint);

		// Token: 0x06021ED6 RID: 138966
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetInstalledContentSize_Internal(IntPtr @this);

		// Token: 0x06021ED7 RID: 138967 RVA: 0x00322BFC File Offset: 0x00320DFC
		static UMobileInstalledContent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MobilePatchingUtils.MobileInstalledContent");
		}

		// Token: 0x06021ED8 RID: 138968 RVA: 0x00322C0A File Offset: 0x00320E0A
		protected UMobileInstalledContent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401219B RID: 74139
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/MobilePatchingUtils.MobileInstalledContent";

		// Token: 0x0401219C RID: 74140
		private static IntPtr _ClassPtr;

		// Token: 0x0401219D RID: 74141
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
