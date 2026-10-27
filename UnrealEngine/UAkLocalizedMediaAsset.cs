using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200021A RID: 538
	[UnrealObjectPath("/Script/AkAudio.AkLocalizedMediaAsset")]
	[UnrealStructLayout(128, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 128)]
	public class UAkLocalizedMediaAsset : UAkMediaAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06001FE0 RID: 8160 RVA: 0x0002F386 File Offset: 0x0002D586
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAkLocalizedMediaAsset._ClassPtr;
		}

		// Token: 0x06001FE1 RID: 8161 RVA: 0x0002F394 File Offset: 0x0002D594
		public UAkLocalizedMediaAsset() : this(BuiltinUtils.AllocNativeUObject(UAkLocalizedMediaAsset.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06001FE2 RID: 8162 RVA: 0x0002F3BC File Offset: 0x0002D5BC
		[NullableContext(1)]
		public UAkLocalizedMediaAsset(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAkLocalizedMediaAsset.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06001FE3 RID: 8163 RVA: 0x0002F3EF File Offset: 0x0002D5EF
		static UAkLocalizedMediaAsset()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AkAudio.AkLocalizedMediaAsset");
		}

		// Token: 0x06001FE4 RID: 8164 RVA: 0x0002F3FD File Offset: 0x0002D5FD
		protected UAkLocalizedMediaAsset(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000A9E RID: 2718
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AkAudio.AkLocalizedMediaAsset";

		// Token: 0x04000A9F RID: 2719
		private static IntPtr _ClassPtr;

		// Token: 0x04000AA0 RID: 2720
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
