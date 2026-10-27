using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001831 RID: 6193
	[UnrealObjectPath("/Script/KuroFastCollision.KuroFastCollisionAlgorithm_PhysicalGrid")]
	[UnrealStructLayout(880, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 880)]
	public class UKuroFastCollisionAlgorithm_PhysicalGrid : UKuroFastCollisionAlgorithm_Grid, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06016D5F RID: 93535 RVA: 0x002156C6 File Offset: 0x002138C6
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroFastCollisionAlgorithm_PhysicalGrid._ClassPtr;
		}

		// Token: 0x06016D60 RID: 93536 RVA: 0x002156D4 File Offset: 0x002138D4
		public UKuroFastCollisionAlgorithm_PhysicalGrid() : this(BuiltinUtils.AllocNativeUObject(UKuroFastCollisionAlgorithm_PhysicalGrid.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06016D61 RID: 93537 RVA: 0x002156FC File Offset: 0x002138FC
		[NullableContext(1)]
		public UKuroFastCollisionAlgorithm_PhysicalGrid(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroFastCollisionAlgorithm_PhysicalGrid.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06016D62 RID: 93538 RVA: 0x0021572F File Offset: 0x0021392F
		static UKuroFastCollisionAlgorithm_PhysicalGrid()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroFastCollision.KuroFastCollisionAlgorithm_PhysicalGrid");
		}

		// Token: 0x06016D63 RID: 93539 RVA: 0x0021573D File Offset: 0x0021393D
		protected UKuroFastCollisionAlgorithm_PhysicalGrid(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400C6A1 RID: 50849
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroFastCollision.KuroFastCollisionAlgorithm_PhysicalGrid";

		// Token: 0x0400C6A2 RID: 50850
		private static IntPtr _ClassPtr;

		// Token: 0x0400C6A3 RID: 50851
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
