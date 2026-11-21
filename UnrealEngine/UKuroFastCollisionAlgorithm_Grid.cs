using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200037E RID: 894
	[UnrealObjectPath("/Script/KuroFastCollision.KuroFastCollisionAlgorithm_Grid")]
	[UnrealStructLayout(696, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 696)]
	public class UKuroFastCollisionAlgorithm_Grid : UKuroFastCollisionAlgorithm, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06005A0A RID: 23050 RVA: 0x0007F3F6 File Offset: 0x0007D5F6
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroFastCollisionAlgorithm_Grid._ClassPtr;
		}

		// Token: 0x06005A0B RID: 23051 RVA: 0x0007F404 File Offset: 0x0007D604
		public UKuroFastCollisionAlgorithm_Grid() : this(BuiltinUtils.AllocNativeUObject(UKuroFastCollisionAlgorithm_Grid.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06005A0C RID: 23052 RVA: 0x0007F42C File Offset: 0x0007D62C
		[NullableContext(1)]
		public UKuroFastCollisionAlgorithm_Grid(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroFastCollisionAlgorithm_Grid.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06005A0D RID: 23053 RVA: 0x0007F45F File Offset: 0x0007D65F
		static UKuroFastCollisionAlgorithm_Grid()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroFastCollision.KuroFastCollisionAlgorithm_Grid");
		}

		// Token: 0x06005A0E RID: 23054 RVA: 0x0007F46D File Offset: 0x0007D66D
		protected UKuroFastCollisionAlgorithm_Grid(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04002563 RID: 9571
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroFastCollision.KuroFastCollisionAlgorithm_Grid";

		// Token: 0x04002564 RID: 9572
		private static IntPtr _ClassPtr;

		// Token: 0x04002565 RID: 9573
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
