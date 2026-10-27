using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002303 RID: 8963
	[UnrealObjectPath("/Script/MovieSceneCapture.CompressedImageSequenceProtocol")]
	[UnrealStructLayout(232, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 232)]
	public abstract class UCompressedImageSequenceProtocol : UImageSequenceProtocol, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06021F63 RID: 139107 RVA: 0x00323917 File Offset: 0x00321B17
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UCompressedImageSequenceProtocol._ClassPtr;
		}

		// Token: 0x17008345 RID: 33605
		// (get) Token: 0x06021F64 RID: 139108 RVA: 0x00323923 File Offset: 0x00321B23
		// (set) Token: 0x06021F65 RID: 139109 RVA: 0x00323933 File Offset: 0x00321B33
		public unsafe int CompressionQuality
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UCompressedImageSequenceProtocol.__PropertyOffset_CompressionQuality);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCompressedImageSequenceProtocol.__PropertyOffset_CompressionQuality) = value;
			}
		}

		// Token: 0x06021F66 RID: 139110 RVA: 0x00323944 File Offset: 0x00321B44
		static UCompressedImageSequenceProtocol()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MovieSceneCapture.CompressedImageSequenceProtocol");
		}

		// Token: 0x06021F67 RID: 139111 RVA: 0x00323954 File Offset: 0x00321B54
		protected UCompressedImageSequenceProtocol() : this(BuiltinUtils.AllocNativeUObject(UCompressedImageSequenceProtocol.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06021F68 RID: 139112 RVA: 0x0032397C File Offset: 0x00321B7C
		protected UCompressedImageSequenceProtocol(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040121D1 RID: 74193
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/MovieSceneCapture.CompressedImageSequenceProtocol";

		// Token: 0x040121D2 RID: 74194
		private static IntPtr _ClassPtr;

		// Token: 0x040121D3 RID: 74195
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040121D4 RID: 74196
		internal static int __PropertyOffset_CompressionQuality;
	}
}
