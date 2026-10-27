using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200088E RID: 2190
	[UnrealObjectPath("/Script/Engine.BakedBoneSplitCoordinatorSubSystem")]
	[UnrealStructLayout(136, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 136)]
	public class UBakedBoneSplitCoordinatorSubSystem : UWorldSubsystem, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060077BF RID: 30655 RVA: 0x000AB816 File Offset: 0x000A9A16
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UBakedBoneSplitCoordinatorSubSystem._ClassPtr;
		}

		// Token: 0x060077C0 RID: 30656 RVA: 0x000AB824 File Offset: 0x000A9A24
		public UBakedBoneSplitCoordinatorSubSystem() : this(BuiltinUtils.AllocNativeUObject(UBakedBoneSplitCoordinatorSubSystem.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060077C1 RID: 30657 RVA: 0x000AB84C File Offset: 0x000A9A4C
		[NullableContext(1)]
		public UBakedBoneSplitCoordinatorSubSystem(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UBakedBoneSplitCoordinatorSubSystem.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060077C2 RID: 30658 RVA: 0x000AB87F File Offset: 0x000A9A7F
		static UBakedBoneSplitCoordinatorSubSystem()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.BakedBoneSplitCoordinatorSubSystem");
		}

		// Token: 0x060077C3 RID: 30659 RVA: 0x000AB88D File Offset: 0x000A9A8D
		protected UBakedBoneSplitCoordinatorSubSystem(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04003982 RID: 14722
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.BakedBoneSplitCoordinatorSubSystem";

		// Token: 0x04003983 RID: 14723
		private static IntPtr _ClassPtr;

		// Token: 0x04003984 RID: 14724
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
