using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000373 RID: 883
	[UnrealObjectPath("/Script/AudioMixer.AudioGenerator")]
	[UnrealStructLayout(176, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 176)]
	public class UAudioGenerator : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06003066 RID: 12390 RVA: 0x0004AF6B File Offset: 0x0004916B
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAudioGenerator._ClassPtr;
		}

		// Token: 0x06003067 RID: 12391 RVA: 0x0004AF78 File Offset: 0x00049178
		public UAudioGenerator() : this(BuiltinUtils.AllocNativeUObject(UAudioGenerator.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06003068 RID: 12392 RVA: 0x0004AFA0 File Offset: 0x000491A0
		[NullableContext(1)]
		public UAudioGenerator(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAudioGenerator.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06003069 RID: 12393 RVA: 0x0004AFD3 File Offset: 0x000491D3
		static UAudioGenerator()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AudioMixer.AudioGenerator");
		}

		// Token: 0x0600306A RID: 12394 RVA: 0x0004AFE1 File Offset: 0x000491E1
		protected UAudioGenerator(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400151B RID: 5403
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AudioMixer.AudioGenerator";

		// Token: 0x0400151C RID: 5404
		private static IntPtr _ClassPtr;

		// Token: 0x0400151D RID: 5405
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
