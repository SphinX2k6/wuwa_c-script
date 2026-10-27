using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002308 RID: 8968
	[UnrealObjectPath("/Script/MovieSceneCapture.ImageSequenceProtocol")]
	[UnrealStructLayout(224, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 224)]
	public abstract class UImageSequenceProtocol : UFrameGrabberProtocol, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06021F7D RID: 139133 RVA: 0x00323ADA File Offset: 0x00321CDA
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UImageSequenceProtocol._ClassPtr;
		}

		// Token: 0x06021F7E RID: 139134 RVA: 0x00323AE6 File Offset: 0x00321CE6
		static UImageSequenceProtocol()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MovieSceneCapture.ImageSequenceProtocol");
		}

		// Token: 0x06021F7F RID: 139135 RVA: 0x00323AF4 File Offset: 0x00321CF4
		protected UImageSequenceProtocol() : this(BuiltinUtils.AllocNativeUObject(UImageSequenceProtocol.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06021F80 RID: 139136 RVA: 0x00323B1C File Offset: 0x00321D1C
		protected UImageSequenceProtocol(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040121EC RID: 74220
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/MovieSceneCapture.ImageSequenceProtocol";

		// Token: 0x040121ED RID: 74221
		private static IntPtr _ClassPtr;

		// Token: 0x040121EE RID: 74222
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
