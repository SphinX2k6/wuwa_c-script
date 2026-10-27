using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000205 RID: 517
	[UnrealObjectPath("/Script/AkAudio.AkFolder")]
	[UnrealStructLayout(104, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 104)]
	public class UAkFolder : UAkAudioType, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06001E5E RID: 7774 RVA: 0x0002D018 File Offset: 0x0002B218
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAkFolder._ClassPtr;
		}

		// Token: 0x06001E5F RID: 7775 RVA: 0x0002D024 File Offset: 0x0002B224
		public UAkFolder() : this(BuiltinUtils.AllocNativeUObject(UAkFolder.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06001E60 RID: 7776 RVA: 0x0002D04C File Offset: 0x0002B24C
		[NullableContext(1)]
		public UAkFolder(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAkFolder.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06001E61 RID: 7777 RVA: 0x0002D07F File Offset: 0x0002B27F
		static UAkFolder()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AkAudio.AkFolder");
		}

		// Token: 0x06001E62 RID: 7778 RVA: 0x0002D08D File Offset: 0x0002B28D
		protected UAkFolder(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000A18 RID: 2584
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AkAudio.AkFolder";

		// Token: 0x04000A19 RID: 2585
		private static IntPtr _ClassPtr;

		// Token: 0x04000A1A RID: 2586
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
