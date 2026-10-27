using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200230E RID: 8974
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/MovieSceneCapture.MasterAudioSubmixCaptureProtocol")]
	[UnrealStructLayout(152, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 152)]
	public class UMasterAudioSubmixCaptureProtocol : UMovieSceneAudioCaptureProtocolBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06021FA2 RID: 139170 RVA: 0x00323E38 File Offset: 0x00322038
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMasterAudioSubmixCaptureProtocol._ClassPtr;
		}

		// Token: 0x06021FA3 RID: 139171 RVA: 0x00323E44 File Offset: 0x00322044
		public UMasterAudioSubmixCaptureProtocol() : this(BuiltinUtils.AllocNativeUObject(UMasterAudioSubmixCaptureProtocol.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06021FA4 RID: 139172 RVA: 0x00323E6C File Offset: 0x0032206C
		public UMasterAudioSubmixCaptureProtocol(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMasterAudioSubmixCaptureProtocol.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700834E RID: 33614
		// (get) Token: 0x06021FA5 RID: 139173 RVA: 0x00323E9F File Offset: 0x0032209F
		// (set) Token: 0x06021FA6 RID: 139174 RVA: 0x00323EB3 File Offset: 0x003220B3
		public unsafe string FileName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UMasterAudioSubmixCaptureProtocol.__PropertyOffset_FileName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UMasterAudioSubmixCaptureProtocol.__PropertyOffset_FileName)), value);
			}
		}

		// Token: 0x06021FA7 RID: 139175 RVA: 0x00323EC8 File Offset: 0x003220C8
		static UMasterAudioSubmixCaptureProtocol()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MovieSceneCapture.MasterAudioSubmixCaptureProtocol");
		}

		// Token: 0x06021FA8 RID: 139176 RVA: 0x00323ED6 File Offset: 0x003220D6
		protected UMasterAudioSubmixCaptureProtocol(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012202 RID: 74242
		public new const string __ObjectPath = "/Script/MovieSceneCapture.MasterAudioSubmixCaptureProtocol";

		// Token: 0x04012203 RID: 74243
		private static IntPtr _ClassPtr;

		// Token: 0x04012204 RID: 74244
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04012205 RID: 74245
		internal static int __PropertyOffset_FileName;
	}
}
