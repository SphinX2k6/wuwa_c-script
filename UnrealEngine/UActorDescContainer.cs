using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020007BC RID: 1980
	[UnrealObjectPath("/Script/Engine.ActorDescContainer")]
	[UnrealStructLayout(480, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 480)]
	public class UActorDescContainer : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060069F6 RID: 27126 RVA: 0x0009824C File Offset: 0x0009644C
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UActorDescContainer._ClassPtr;
		}

		// Token: 0x060069F7 RID: 27127 RVA: 0x00098258 File Offset: 0x00096458
		public UActorDescContainer() : this(BuiltinUtils.AllocNativeUObject(UActorDescContainer.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060069F8 RID: 27128 RVA: 0x00098280 File Offset: 0x00096480
		[NullableContext(1)]
		public UActorDescContainer(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UActorDescContainer.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060069F9 RID: 27129 RVA: 0x000982B3 File Offset: 0x000964B3
		static UActorDescContainer()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.ActorDescContainer");
		}

		// Token: 0x060069FA RID: 27130 RVA: 0x000982C1 File Offset: 0x000964C1
		protected UActorDescContainer(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04003313 RID: 13075
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.ActorDescContainer";

		// Token: 0x04003314 RID: 13076
		private static IntPtr _ClassPtr;

		// Token: 0x04003315 RID: 13077
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
