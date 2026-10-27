using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200230B RID: 8971
	[UnrealObjectPath("/Script/MovieSceneCapture.ImageSequenceProtocol_JPG")]
	[UnrealStructLayout(232, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 232)]
	public class UImageSequenceProtocol_JPG : UCompressedImageSequenceProtocol, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06021F8F RID: 139151 RVA: 0x00323C70 File Offset: 0x00321E70
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UImageSequenceProtocol_JPG._ClassPtr;
		}

		// Token: 0x06021F90 RID: 139152 RVA: 0x00323C7C File Offset: 0x00321E7C
		public UImageSequenceProtocol_JPG() : this(BuiltinUtils.AllocNativeUObject(UImageSequenceProtocol_JPG.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06021F91 RID: 139153 RVA: 0x00323CA4 File Offset: 0x00321EA4
		[NullableContext(1)]
		public UImageSequenceProtocol_JPG(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UImageSequenceProtocol_JPG.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06021F92 RID: 139154 RVA: 0x00323CD7 File Offset: 0x00321ED7
		static UImageSequenceProtocol_JPG()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MovieSceneCapture.ImageSequenceProtocol_JPG");
		}

		// Token: 0x06021F93 RID: 139155 RVA: 0x00323CE5 File Offset: 0x00321EE5
		protected UImageSequenceProtocol_JPG(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040121F7 RID: 74231
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/MovieSceneCapture.ImageSequenceProtocol_JPG";

		// Token: 0x040121F8 RID: 74232
		private static IntPtr _ClassPtr;

		// Token: 0x040121F9 RID: 74233
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
