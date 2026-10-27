using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002306 RID: 8966
	[UnrealObjectPath("/Script/MovieSceneCapture.FrameGrabberProtocol")]
	[UnrealStructLayout(112, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 112)]
	public abstract class UFrameGrabberProtocol : UMovieSceneImageCaptureProtocolBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06021F69 RID: 139113 RVA: 0x00323985 File Offset: 0x00321B85
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UFrameGrabberProtocol._ClassPtr;
		}

		// Token: 0x06021F6A RID: 139114 RVA: 0x00323991 File Offset: 0x00321B91
		static UFrameGrabberProtocol()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MovieSceneCapture.FrameGrabberProtocol");
		}

		// Token: 0x06021F6B RID: 139115 RVA: 0x003239A0 File Offset: 0x00321BA0
		protected UFrameGrabberProtocol() : this(BuiltinUtils.AllocNativeUObject(UFrameGrabberProtocol.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06021F6C RID: 139116 RVA: 0x003239C8 File Offset: 0x00321BC8
		protected UFrameGrabberProtocol(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040121E3 RID: 74211
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/MovieSceneCapture.FrameGrabberProtocol";

		// Token: 0x040121E4 RID: 74212
		private static IntPtr _ClassPtr;

		// Token: 0x040121E5 RID: 74213
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
