using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000105 RID: 261
	[UnrealObjectPath("/Script/AIModule.AISenseConfig_Touch")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 80)]
	public class UAISenseConfig_Touch : UAISenseConfig, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060013BD RID: 5053 RVA: 0x0001D1C2 File Offset: 0x0001B3C2
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAISenseConfig_Touch._ClassPtr;
		}

		// Token: 0x060013BE RID: 5054 RVA: 0x0001D1D0 File Offset: 0x0001B3D0
		public UAISenseConfig_Touch() : this(BuiltinUtils.AllocNativeUObject(UAISenseConfig_Touch.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060013BF RID: 5055 RVA: 0x0001D1F8 File Offset: 0x0001B3F8
		[NullableContext(1)]
		public UAISenseConfig_Touch(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAISenseConfig_Touch.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060013C0 RID: 5056 RVA: 0x0001D22B File Offset: 0x0001B42B
		static UAISenseConfig_Touch()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AIModule.AISenseConfig_Touch");
		}

		// Token: 0x060013C1 RID: 5057 RVA: 0x0001D239 File Offset: 0x0001B439
		protected UAISenseConfig_Touch(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040003BC RID: 956
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AIModule.AISenseConfig_Touch";

		// Token: 0x040003BD RID: 957
		private static IntPtr _ClassPtr;

		// Token: 0x040003BE RID: 958
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
