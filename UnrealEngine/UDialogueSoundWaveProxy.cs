using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020009BD RID: 2493
	[UnrealObjectPath("/Script/Engine.DialogueSoundWaveProxy")]
	[UnrealStructLayout(488, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 488)]
	public class UDialogueSoundWaveProxy : USoundBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06008CCA RID: 36042 RVA: 0x000C97C0 File Offset: 0x000C79C0
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UDialogueSoundWaveProxy._ClassPtr;
		}

		// Token: 0x06008CCB RID: 36043 RVA: 0x000C97CC File Offset: 0x000C79CC
		public UDialogueSoundWaveProxy() : this(BuiltinUtils.AllocNativeUObject(UDialogueSoundWaveProxy.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06008CCC RID: 36044 RVA: 0x000C97F4 File Offset: 0x000C79F4
		[NullableContext(1)]
		public UDialogueSoundWaveProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UDialogueSoundWaveProxy.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06008CCD RID: 36045 RVA: 0x000C9827 File Offset: 0x000C7A27
		static UDialogueSoundWaveProxy()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.DialogueSoundWaveProxy");
		}

		// Token: 0x06008CCE RID: 36046 RVA: 0x000C9835 File Offset: 0x000C7A35
		protected UDialogueSoundWaveProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040042D9 RID: 17113
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.DialogueSoundWaveProxy";

		// Token: 0x040042DA RID: 17114
		private static IntPtr _ClassPtr;

		// Token: 0x040042DB RID: 17115
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
