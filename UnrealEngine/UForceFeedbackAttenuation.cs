using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200020E RID: 526
	[UnrealObjectPath("/Script/Engine.ForceFeedbackAttenuation")]
	[UnrealStructLayout(224, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 224)]
	public class UForceFeedbackAttenuation : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060021C5 RID: 8645 RVA: 0x000317F0 File Offset: 0x0002F9F0
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UForceFeedbackAttenuation._ClassPtr;
		}

		// Token: 0x060021C6 RID: 8646 RVA: 0x000317FC File Offset: 0x0002F9FC
		public UForceFeedbackAttenuation() : this(BuiltinUtils.AllocNativeUObject(UForceFeedbackAttenuation.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060021C7 RID: 8647 RVA: 0x00031824 File Offset: 0x0002FA24
		[NullableContext(1)]
		public UForceFeedbackAttenuation(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UForceFeedbackAttenuation.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060021C8 RID: 8648 RVA: 0x00031857 File Offset: 0x0002FA57
		static UForceFeedbackAttenuation()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.ForceFeedbackAttenuation");
		}

		// Token: 0x060021C9 RID: 8649 RVA: 0x00031865 File Offset: 0x0002FA65
		protected UForceFeedbackAttenuation(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000D33 RID: 3379
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.ForceFeedbackAttenuation";

		// Token: 0x04000D34 RID: 3380
		private static IntPtr _ClassPtr;

		// Token: 0x04000D35 RID: 3381
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
