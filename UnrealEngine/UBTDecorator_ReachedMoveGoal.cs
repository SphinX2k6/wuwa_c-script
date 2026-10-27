using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000148 RID: 328
	[UnrealObjectPath("/Script/AIModule.BTDecorator_ReachedMoveGoal")]
	[UnrealStructLayout(128, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 128)]
	public class UBTDecorator_ReachedMoveGoal : UBTDecorator, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060016BE RID: 5822 RVA: 0x00021879 File Offset: 0x0001FA79
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UBTDecorator_ReachedMoveGoal._ClassPtr;
		}

		// Token: 0x060016BF RID: 5823 RVA: 0x00021888 File Offset: 0x0001FA88
		public UBTDecorator_ReachedMoveGoal() : this(BuiltinUtils.AllocNativeUObject(UBTDecorator_ReachedMoveGoal.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060016C0 RID: 5824 RVA: 0x000218B0 File Offset: 0x0001FAB0
		[NullableContext(1)]
		public UBTDecorator_ReachedMoveGoal(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UBTDecorator_ReachedMoveGoal.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060016C1 RID: 5825 RVA: 0x000218E3 File Offset: 0x0001FAE3
		static UBTDecorator_ReachedMoveGoal()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AIModule.BTDecorator_ReachedMoveGoal");
		}

		// Token: 0x060016C2 RID: 5826 RVA: 0x000218F1 File Offset: 0x0001FAF1
		protected UBTDecorator_ReachedMoveGoal(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400054B RID: 1355
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AIModule.BTDecorator_ReachedMoveGoal";

		// Token: 0x0400054C RID: 1356
		private static IntPtr _ClassPtr;

		// Token: 0x0400054D RID: 1357
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
