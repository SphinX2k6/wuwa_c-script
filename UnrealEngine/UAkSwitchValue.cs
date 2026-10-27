using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200024B RID: 587
	[UnrealObjectPath("/Script/AkAudio.AkSwitchValue")]
	[UnrealStructLayout(184, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 184)]
	public class UAkSwitchValue : UAkGroupValue, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060022BC RID: 8892 RVA: 0x00033698 File Offset: 0x00031898
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAkSwitchValue._ClassPtr;
		}

		// Token: 0x060022BD RID: 8893 RVA: 0x000336A4 File Offset: 0x000318A4
		public UAkSwitchValue() : this(BuiltinUtils.AllocNativeUObject(UAkSwitchValue.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060022BE RID: 8894 RVA: 0x000336CC File Offset: 0x000318CC
		[NullableContext(1)]
		public UAkSwitchValue(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAkSwitchValue.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060022BF RID: 8895 RVA: 0x000336FF File Offset: 0x000318FF
		static UAkSwitchValue()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AkAudio.AkSwitchValue");
		}

		// Token: 0x060022C0 RID: 8896 RVA: 0x0003370D File Offset: 0x0003190D
		protected UAkSwitchValue(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000BFD RID: 3069
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AkAudio.AkSwitchValue";

		// Token: 0x04000BFE RID: 3070
		private static IntPtr _ClassPtr;

		// Token: 0x04000BFF RID: 3071
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
