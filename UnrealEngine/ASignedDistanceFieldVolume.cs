using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020010E9 RID: 4329
	[UnrealObjectPath("/Script/Engine.SignedDistanceFieldVolume")]
	[UnrealStructLayout(1352, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1352)]
	public class ASignedDistanceFieldVolume : AVolume, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600F877 RID: 63607 RVA: 0x0016F7EF File Offset: 0x0016D9EF
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ASignedDistanceFieldVolume._ClassPtr;
		}

		// Token: 0x0600F878 RID: 63608 RVA: 0x0016F7FC File Offset: 0x0016D9FC
		public ASignedDistanceFieldVolume() : this(BuiltinUtils.AllocNativeUObject(ASignedDistanceFieldVolume.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600F879 RID: 63609 RVA: 0x0016F824 File Offset: 0x0016DA24
		[NullableContext(1)]
		public ASignedDistanceFieldVolume(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ASignedDistanceFieldVolume.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600F87A RID: 63610 RVA: 0x0016F857 File Offset: 0x0016DA57
		static ASignedDistanceFieldVolume()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.SignedDistanceFieldVolume");
		}

		// Token: 0x0600F87B RID: 63611 RVA: 0x0016F865 File Offset: 0x0016DA65
		protected ASignedDistanceFieldVolume(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400863D RID: 34365
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.SignedDistanceFieldVolume";

		// Token: 0x0400863E RID: 34366
		private static IntPtr _ClassPtr;

		// Token: 0x0400863F RID: 34367
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
