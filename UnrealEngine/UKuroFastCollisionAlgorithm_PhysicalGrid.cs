using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200037F RID: 895
	[UnrealObjectPath("/Script/KuroFastCollision.KuroFastCollisionAlgorithm_PhysicalGrid")]
	[UnrealStructLayout(880, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 880)]
	public class UKuroFastCollisionAlgorithm_PhysicalGrid : UKuroFastCollisionAlgorithm_Grid, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06005A0F RID: 23055 RVA: 0x0007F476 File Offset: 0x0007D676
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroFastCollisionAlgorithm_PhysicalGrid._ClassPtr;
		}

		// Token: 0x06005A10 RID: 23056 RVA: 0x0007F484 File Offset: 0x0007D684
		public UKuroFastCollisionAlgorithm_PhysicalGrid() : this(BuiltinUtils.AllocNativeUObject(UKuroFastCollisionAlgorithm_PhysicalGrid.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06005A11 RID: 23057 RVA: 0x0007F4AC File Offset: 0x0007D6AC
		[NullableContext(1)]
		public UKuroFastCollisionAlgorithm_PhysicalGrid(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroFastCollisionAlgorithm_PhysicalGrid.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06005A12 RID: 23058 RVA: 0x0007F4DF File Offset: 0x0007D6DF
		static UKuroFastCollisionAlgorithm_PhysicalGrid()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroFastCollision.KuroFastCollisionAlgorithm_PhysicalGrid");
		}

		// Token: 0x06005A13 RID: 23059 RVA: 0x0007F4ED File Offset: 0x0007D6ED
		protected UKuroFastCollisionAlgorithm_PhysicalGrid(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04002566 RID: 9574
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroFastCollision.KuroFastCollisionAlgorithm_PhysicalGrid";

		// Token: 0x04002567 RID: 9575
		private static IntPtr _ClassPtr;

		// Token: 0x04002568 RID: 9576
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
