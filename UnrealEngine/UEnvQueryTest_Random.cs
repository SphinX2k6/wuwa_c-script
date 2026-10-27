using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020001B2 RID: 434
	[UnrealObjectPath("/Script/AIModule.EnvQueryTest_Random")]
	[UnrealStructLayout(608, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 608)]
	public class UEnvQueryTest_Random : UEnvQueryTest, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06001A7C RID: 6780 RVA: 0x0002763D File Offset: 0x0002583D
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UEnvQueryTest_Random._ClassPtr;
		}

		// Token: 0x06001A7D RID: 6781 RVA: 0x0002764C File Offset: 0x0002584C
		public UEnvQueryTest_Random() : this(BuiltinUtils.AllocNativeUObject(UEnvQueryTest_Random.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06001A7E RID: 6782 RVA: 0x00027674 File Offset: 0x00025874
		[NullableContext(1)]
		public UEnvQueryTest_Random(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UEnvQueryTest_Random.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06001A7F RID: 6783 RVA: 0x000276A7 File Offset: 0x000258A7
		static UEnvQueryTest_Random()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AIModule.EnvQueryTest_Random");
		}

		// Token: 0x06001A80 RID: 6784 RVA: 0x000276B5 File Offset: 0x000258B5
		protected UEnvQueryTest_Random(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000809 RID: 2057
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AIModule.EnvQueryTest_Random";

		// Token: 0x0400080A RID: 2058
		private static IntPtr _ClassPtr;

		// Token: 0x0400080B RID: 2059
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
