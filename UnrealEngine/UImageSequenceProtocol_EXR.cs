using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200230A RID: 8970
	[UnrealObjectPath("/Script/MovieSceneCapture.ImageSequenceProtocol_EXR")]
	[UnrealStructLayout(240, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 240)]
	public class UImageSequenceProtocol_EXR : UImageSequenceProtocol, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06021F86 RID: 139142 RVA: 0x00323BA6 File Offset: 0x00321DA6
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UImageSequenceProtocol_EXR._ClassPtr;
		}

		// Token: 0x06021F87 RID: 139143 RVA: 0x00323BB4 File Offset: 0x00321DB4
		public UImageSequenceProtocol_EXR() : this(BuiltinUtils.AllocNativeUObject(UImageSequenceProtocol_EXR.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06021F88 RID: 139144 RVA: 0x00323BDC File Offset: 0x00321DDC
		[NullableContext(1)]
		public UImageSequenceProtocol_EXR(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UImageSequenceProtocol_EXR.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700834A RID: 33610
		// (get) Token: 0x06021F89 RID: 139145 RVA: 0x00323C0F File Offset: 0x00321E0F
		// (set) Token: 0x06021F8A RID: 139146 RVA: 0x00323C1F File Offset: 0x00321E1F
		public unsafe bool bCompressed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UImageSequenceProtocol_EXR.__PropertyOffset_bCompressed) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UImageSequenceProtocol_EXR.__PropertyOffset_bCompressed) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700834B RID: 33611
		// (get) Token: 0x06021F8B RID: 139147 RVA: 0x00323C30 File Offset: 0x00321E30
		// (set) Token: 0x06021F8C RID: 139148 RVA: 0x00323C44 File Offset: 0x00321E44
		public unsafe TEnumAsByte<EHDRCaptureGamut> CaptureGamut
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UImageSequenceProtocol_EXR.__PropertyOffset_CaptureGamut);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UImageSequenceProtocol_EXR.__PropertyOffset_CaptureGamut) = value;
			}
		}

		// Token: 0x06021F8D RID: 139149 RVA: 0x00323C59 File Offset: 0x00321E59
		static UImageSequenceProtocol_EXR()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MovieSceneCapture.ImageSequenceProtocol_EXR");
		}

		// Token: 0x06021F8E RID: 139150 RVA: 0x00323C67 File Offset: 0x00321E67
		protected UImageSequenceProtocol_EXR(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040121F2 RID: 74226
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/MovieSceneCapture.ImageSequenceProtocol_EXR";

		// Token: 0x040121F3 RID: 74227
		private static IntPtr _ClassPtr;

		// Token: 0x040121F4 RID: 74228
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040121F5 RID: 74229
		internal static int __PropertyOffset_bCompressed;

		// Token: 0x040121F6 RID: 74230
		internal static int __PropertyOffset_CaptureGamut;
	}
}
