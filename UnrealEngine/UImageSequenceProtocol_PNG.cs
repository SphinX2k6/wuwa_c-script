using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200230C RID: 8972
	[UnrealObjectPath("/Script/MovieSceneCapture.ImageSequenceProtocol_PNG")]
	[UnrealStructLayout(232, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 232)]
	public class UImageSequenceProtocol_PNG : UCompressedImageSequenceProtocol, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06021F94 RID: 139156 RVA: 0x00323CEE File Offset: 0x00321EEE
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UImageSequenceProtocol_PNG._ClassPtr;
		}

		// Token: 0x06021F95 RID: 139157 RVA: 0x00323CFC File Offset: 0x00321EFC
		public UImageSequenceProtocol_PNG() : this(BuiltinUtils.AllocNativeUObject(UImageSequenceProtocol_PNG.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06021F96 RID: 139158 RVA: 0x00323D24 File Offset: 0x00321F24
		[NullableContext(1)]
		public UImageSequenceProtocol_PNG(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UImageSequenceProtocol_PNG.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06021F97 RID: 139159 RVA: 0x00323D57 File Offset: 0x00321F57
		static UImageSequenceProtocol_PNG()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MovieSceneCapture.ImageSequenceProtocol_PNG");
		}

		// Token: 0x06021F98 RID: 139160 RVA: 0x00323D65 File Offset: 0x00321F65
		protected UImageSequenceProtocol_PNG(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040121FA RID: 74234
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/MovieSceneCapture.ImageSequenceProtocol_PNG";

		// Token: 0x040121FB RID: 74235
		private static IntPtr _ClassPtr;

		// Token: 0x040121FC RID: 74236
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
