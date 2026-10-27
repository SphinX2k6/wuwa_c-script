using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001830 RID: 6192
	[UnrealObjectPath("/Script/KuroFastCollision.KuroFastCollisionAlgorithm_Grid")]
	[UnrealStructLayout(696, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 696)]
	public class UKuroFastCollisionAlgorithm_Grid : UKuroFastCollisionAlgorithm, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06016D5A RID: 93530 RVA: 0x00215646 File Offset: 0x00213846
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroFastCollisionAlgorithm_Grid._ClassPtr;
		}

		// Token: 0x06016D5B RID: 93531 RVA: 0x00215654 File Offset: 0x00213854
		public UKuroFastCollisionAlgorithm_Grid() : this(BuiltinUtils.AllocNativeUObject(UKuroFastCollisionAlgorithm_Grid.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06016D5C RID: 93532 RVA: 0x0021567C File Offset: 0x0021387C
		[NullableContext(1)]
		public UKuroFastCollisionAlgorithm_Grid(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroFastCollisionAlgorithm_Grid.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06016D5D RID: 93533 RVA: 0x002156AF File Offset: 0x002138AF
		static UKuroFastCollisionAlgorithm_Grid()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroFastCollision.KuroFastCollisionAlgorithm_Grid");
		}

		// Token: 0x06016D5E RID: 93534 RVA: 0x002156BD File Offset: 0x002138BD
		protected UKuroFastCollisionAlgorithm_Grid(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400C69E RID: 50846
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroFastCollision.KuroFastCollisionAlgorithm_Grid";

		// Token: 0x0400C69F RID: 50847
		private static IntPtr _ClassPtr;

		// Token: 0x0400C6A0 RID: 50848
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
