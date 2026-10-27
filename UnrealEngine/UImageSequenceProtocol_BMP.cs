using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002309 RID: 8969
	[UnrealObjectPath("/Script/MovieSceneCapture.ImageSequenceProtocol_BMP")]
	[UnrealStructLayout(224, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 224)]
	public class UImageSequenceProtocol_BMP : UImageSequenceProtocol, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06021F81 RID: 139137 RVA: 0x00323B25 File Offset: 0x00321D25
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UImageSequenceProtocol_BMP._ClassPtr;
		}

		// Token: 0x06021F82 RID: 139138 RVA: 0x00323B34 File Offset: 0x00321D34
		public UImageSequenceProtocol_BMP() : this(BuiltinUtils.AllocNativeUObject(UImageSequenceProtocol_BMP.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06021F83 RID: 139139 RVA: 0x00323B5C File Offset: 0x00321D5C
		[NullableContext(1)]
		public UImageSequenceProtocol_BMP(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UImageSequenceProtocol_BMP.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06021F84 RID: 139140 RVA: 0x00323B8F File Offset: 0x00321D8F
		static UImageSequenceProtocol_BMP()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MovieSceneCapture.ImageSequenceProtocol_BMP");
		}

		// Token: 0x06021F85 RID: 139141 RVA: 0x00323B9D File Offset: 0x00321D9D
		protected UImageSequenceProtocol_BMP(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040121EF RID: 74223
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/MovieSceneCapture.ImageSequenceProtocol_BMP";

		// Token: 0x040121F0 RID: 74224
		private static IntPtr _ClassPtr;

		// Token: 0x040121F1 RID: 74225
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
