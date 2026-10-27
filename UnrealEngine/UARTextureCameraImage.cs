using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020003CD RID: 973
	[UnrealObjectPath("/Script/AugmentedReality.ARTextureCameraImage")]
	[UnrealStructLayout(3952, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 3952)]
	public abstract class UARTextureCameraImage : UARTexture, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06003676 RID: 13942 RVA: 0x000529FD File Offset: 0x00050BFD
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UARTextureCameraImage._ClassPtr;
		}

		// Token: 0x06003677 RID: 13943 RVA: 0x00052A09 File Offset: 0x00050C09
		static UARTextureCameraImage()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AugmentedReality.ARTextureCameraImage");
		}

		// Token: 0x06003678 RID: 13944 RVA: 0x00052A18 File Offset: 0x00050C18
		protected UARTextureCameraImage() : this(BuiltinUtils.AllocNativeUObject(UARTextureCameraImage.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06003679 RID: 13945 RVA: 0x00052A40 File Offset: 0x00050C40
		protected UARTextureCameraImage(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400178E RID: 6030
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AugmentedReality.ARTextureCameraImage";

		// Token: 0x0400178F RID: 6031
		private static IntPtr _ClassPtr;

		// Token: 0x04001790 RID: 6032
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
