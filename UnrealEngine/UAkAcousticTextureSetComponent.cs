using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020001E6 RID: 486
	[UnrealObjectPath("/Script/AkAudio.AkAcousticTextureSetComponent")]
	[UnrealStructLayout(688, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 688)]
	public abstract class UAkAcousticTextureSetComponent : USceneComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06001C9C RID: 7324 RVA: 0x0002AA7D File Offset: 0x00028C7D
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAkAcousticTextureSetComponent._ClassPtr;
		}

		// Token: 0x06001C9D RID: 7325 RVA: 0x0002AA89 File Offset: 0x00028C89
		static UAkAcousticTextureSetComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AkAudio.AkAcousticTextureSetComponent");
		}

		// Token: 0x06001C9E RID: 7326 RVA: 0x0002AA98 File Offset: 0x00028C98
		protected UAkAcousticTextureSetComponent() : this(BuiltinUtils.AllocNativeUObject(UAkAcousticTextureSetComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06001C9F RID: 7327 RVA: 0x0002AAC0 File Offset: 0x00028CC0
		protected UAkAcousticTextureSetComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000956 RID: 2390
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AkAudio.AkAcousticTextureSetComponent";

		// Token: 0x04000957 RID: 2391
		private static IntPtr _ClassPtr;

		// Token: 0x04000958 RID: 2392
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
