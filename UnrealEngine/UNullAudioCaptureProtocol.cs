using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002316 RID: 8982
	[UnrealObjectPath("/Script/MovieSceneCapture.NullAudioCaptureProtocol")]
	[UnrealStructLayout(96, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 96)]
	public class UNullAudioCaptureProtocol : UMovieSceneAudioCaptureProtocolBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602201A RID: 139290 RVA: 0x003247E1 File Offset: 0x003229E1
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UNullAudioCaptureProtocol._ClassPtr;
		}

		// Token: 0x0602201B RID: 139291 RVA: 0x003247F0 File Offset: 0x003229F0
		public UNullAudioCaptureProtocol() : this(BuiltinUtils.AllocNativeUObject(UNullAudioCaptureProtocol.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602201C RID: 139292 RVA: 0x00324818 File Offset: 0x00322A18
		[NullableContext(1)]
		public UNullAudioCaptureProtocol(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UNullAudioCaptureProtocol.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602201D RID: 139293 RVA: 0x0032484B File Offset: 0x00322A4B
		static UNullAudioCaptureProtocol()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MovieSceneCapture.NullAudioCaptureProtocol");
		}

		// Token: 0x0602201E RID: 139294 RVA: 0x00324859 File Offset: 0x00322A59
		protected UNullAudioCaptureProtocol(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401223D RID: 74301
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/MovieSceneCapture.NullAudioCaptureProtocol";

		// Token: 0x0401223E RID: 74302
		private static IntPtr _ClassPtr;

		// Token: 0x0401223F RID: 74303
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
