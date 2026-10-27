using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000245 RID: 581
	[UnrealObjectPath("/Script/AkAudio.AkStateValue")]
	[UnrealStructLayout(184, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 184)]
	public class UAkStateValue : UAkGroupValue, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600227B RID: 8827 RVA: 0x0003320A File Offset: 0x0003140A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAkStateValue._ClassPtr;
		}

		// Token: 0x0600227C RID: 8828 RVA: 0x00033218 File Offset: 0x00031418
		public UAkStateValue() : this(BuiltinUtils.AllocNativeUObject(UAkStateValue.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600227D RID: 8829 RVA: 0x00033240 File Offset: 0x00031440
		[NullableContext(1)]
		public UAkStateValue(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAkStateValue.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600227E RID: 8830 RVA: 0x00033273 File Offset: 0x00031473
		static UAkStateValue()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AkAudio.AkStateValue");
		}

		// Token: 0x0600227F RID: 8831 RVA: 0x00033281 File Offset: 0x00031481
		protected UAkStateValue(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000BE3 RID: 3043
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AkAudio.AkStateValue";

		// Token: 0x04000BE4 RID: 3044
		private static IntPtr _ClassPtr;

		// Token: 0x04000BE5 RID: 3045
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
