using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000102 RID: 258
	[UnrealObjectPath("/Script/AIModule.AISenseConfig_Prediction")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 80)]
	public class UAISenseConfig_Prediction : UAISenseConfig, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600139E RID: 5022 RVA: 0x0001CF2B File Offset: 0x0001B12B
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAISenseConfig_Prediction._ClassPtr;
		}

		// Token: 0x0600139F RID: 5023 RVA: 0x0001CF38 File Offset: 0x0001B138
		public UAISenseConfig_Prediction() : this(BuiltinUtils.AllocNativeUObject(UAISenseConfig_Prediction.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060013A0 RID: 5024 RVA: 0x0001CF60 File Offset: 0x0001B160
		[NullableContext(1)]
		public UAISenseConfig_Prediction(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAISenseConfig_Prediction.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060013A1 RID: 5025 RVA: 0x0001CF93 File Offset: 0x0001B193
		static UAISenseConfig_Prediction()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AIModule.AISenseConfig_Prediction");
		}

		// Token: 0x060013A2 RID: 5026 RVA: 0x0001CFA1 File Offset: 0x0001B1A1
		protected UAISenseConfig_Prediction(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040003AB RID: 939
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AIModule.AISenseConfig_Prediction";

		// Token: 0x040003AC RID: 940
		private static IntPtr _ClassPtr;

		// Token: 0x040003AD RID: 941
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
