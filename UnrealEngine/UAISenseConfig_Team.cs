using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000104 RID: 260
	[UnrealObjectPath("/Script/AIModule.AISenseConfig_Team")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 80)]
	public class UAISenseConfig_Team : UAISenseConfig, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060013B8 RID: 5048 RVA: 0x0001D142 File Offset: 0x0001B342
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAISenseConfig_Team._ClassPtr;
		}

		// Token: 0x060013B9 RID: 5049 RVA: 0x0001D150 File Offset: 0x0001B350
		public UAISenseConfig_Team() : this(BuiltinUtils.AllocNativeUObject(UAISenseConfig_Team.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060013BA RID: 5050 RVA: 0x0001D178 File Offset: 0x0001B378
		[NullableContext(1)]
		public UAISenseConfig_Team(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAISenseConfig_Team.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060013BB RID: 5051 RVA: 0x0001D1AB File Offset: 0x0001B3AB
		static UAISenseConfig_Team()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AIModule.AISenseConfig_Team");
		}

		// Token: 0x060013BC RID: 5052 RVA: 0x0001D1B9 File Offset: 0x0001B3B9
		protected UAISenseConfig_Team(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040003B9 RID: 953
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AIModule.AISenseConfig_Team";

		// Token: 0x040003BA RID: 954
		private static IntPtr _ClassPtr;

		// Token: 0x040003BB RID: 955
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
