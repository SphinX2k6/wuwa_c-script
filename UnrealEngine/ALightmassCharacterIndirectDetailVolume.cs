using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000D4E RID: 3406
	[UnrealObjectPath("/Script/Engine.LightmassCharacterIndirectDetailVolume")]
	[UnrealStructLayout(1104, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1104)]
	public class ALightmassCharacterIndirectDetailVolume : AVolume, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600B7D0 RID: 47056 RVA: 0x00105802 File Offset: 0x00103A02
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ALightmassCharacterIndirectDetailVolume._ClassPtr;
		}

		// Token: 0x0600B7D1 RID: 47057 RVA: 0x00105810 File Offset: 0x00103A10
		public ALightmassCharacterIndirectDetailVolume() : this(BuiltinUtils.AllocNativeUObject(ALightmassCharacterIndirectDetailVolume.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600B7D2 RID: 47058 RVA: 0x00105838 File Offset: 0x00103A38
		[NullableContext(1)]
		public ALightmassCharacterIndirectDetailVolume(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ALightmassCharacterIndirectDetailVolume.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600B7D3 RID: 47059 RVA: 0x0010586B File Offset: 0x00103A6B
		static ALightmassCharacterIndirectDetailVolume()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.LightmassCharacterIndirectDetailVolume");
		}

		// Token: 0x0600B7D4 RID: 47060 RVA: 0x00105879 File Offset: 0x00103A79
		protected ALightmassCharacterIndirectDetailVolume(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04006049 RID: 24649
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.LightmassCharacterIndirectDetailVolume";

		// Token: 0x0400604A RID: 24650
		private static IntPtr _ClassPtr;

		// Token: 0x0400604B RID: 24651
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
