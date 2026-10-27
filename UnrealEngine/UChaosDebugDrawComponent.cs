using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200044A RID: 1098
	[UnrealObjectPath("/Script/ChaosSolverEngine.ChaosDebugDrawComponent")]
	[UnrealStructLayout(208, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 208)]
	public class UChaosDebugDrawComponent : UActorComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06003B4E RID: 15182 RVA: 0x000596DD File Offset: 0x000578DD
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UChaosDebugDrawComponent._ClassPtr;
		}

		// Token: 0x06003B4F RID: 15183 RVA: 0x000596EC File Offset: 0x000578EC
		public UChaosDebugDrawComponent() : this(BuiltinUtils.AllocNativeUObject(UChaosDebugDrawComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06003B50 RID: 15184 RVA: 0x00059714 File Offset: 0x00057914
		[NullableContext(1)]
		public UChaosDebugDrawComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UChaosDebugDrawComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06003B51 RID: 15185 RVA: 0x00059747 File Offset: 0x00057947
		static UChaosDebugDrawComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/ChaosSolverEngine.ChaosDebugDrawComponent");
		}

		// Token: 0x06003B52 RID: 15186 RVA: 0x00059755 File Offset: 0x00057955
		protected UChaosDebugDrawComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04001B4A RID: 6986
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ChaosSolverEngine.ChaosDebugDrawComponent";

		// Token: 0x04001B4B RID: 6987
		private static IntPtr _ClassPtr;

		// Token: 0x04001B4C RID: 6988
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
