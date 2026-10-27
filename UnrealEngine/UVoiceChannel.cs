using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200123A RID: 4666
	[UnrealObjectPath("/Script/Engine.VoiceChannel")]
	[UnrealStructLayout(136, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 136)]
	public class UVoiceChannel : UChannel, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601125C RID: 70236 RVA: 0x00192C91 File Offset: 0x00190E91
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UVoiceChannel._ClassPtr;
		}

		// Token: 0x0601125D RID: 70237 RVA: 0x00192CA0 File Offset: 0x00190EA0
		public UVoiceChannel() : this(BuiltinUtils.AllocNativeUObject(UVoiceChannel.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601125E RID: 70238 RVA: 0x00192CC8 File Offset: 0x00190EC8
		[NullableContext(1)]
		public UVoiceChannel(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UVoiceChannel.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601125F RID: 70239 RVA: 0x00192CFB File Offset: 0x00190EFB
		static UVoiceChannel()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.VoiceChannel");
		}

		// Token: 0x06011260 RID: 70240 RVA: 0x00192D09 File Offset: 0x00190F09
		protected UVoiceChannel(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040092D5 RID: 37589
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.VoiceChannel";

		// Token: 0x040092D6 RID: 37590
		private static IntPtr _ClassPtr;

		// Token: 0x040092D7 RID: 37591
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
