using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200115D RID: 4445
	[UnrealObjectPath("/Script/Engine.SoundWaveProcedural")]
	[UnrealStructLayout(1360, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1360)]
	public class USoundWaveProcedural : USoundWave, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060103FE RID: 66558 RVA: 0x0017F0D0 File Offset: 0x0017D2D0
		public new static UClassStackOnlyPtr StaticClass()
		{
			return USoundWaveProcedural._ClassPtr;
		}

		// Token: 0x060103FF RID: 66559 RVA: 0x0017F0DC File Offset: 0x0017D2DC
		public USoundWaveProcedural() : this(BuiltinUtils.AllocNativeUObject(USoundWaveProcedural.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06010400 RID: 66560 RVA: 0x0017F104 File Offset: 0x0017D304
		[NullableContext(1)]
		public USoundWaveProcedural(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(USoundWaveProcedural.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06010401 RID: 66561 RVA: 0x0017F137 File Offset: 0x0017D337
		static USoundWaveProcedural()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.SoundWaveProcedural");
		}

		// Token: 0x06010402 RID: 66562 RVA: 0x0017F145 File Offset: 0x0017D345
		protected USoundWaveProcedural(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04008BE2 RID: 35810
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.SoundWaveProcedural";

		// Token: 0x04008BE3 RID: 35811
		private static IntPtr _ClassPtr;

		// Token: 0x04008BE4 RID: 35812
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
