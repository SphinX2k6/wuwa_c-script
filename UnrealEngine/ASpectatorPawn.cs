using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001171 RID: 4465
	[UnrealObjectPath("/Script/Engine.SpectatorPawn")]
	[UnrealStructLayout(1176, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1176)]
	public class ASpectatorPawn : ADefaultPawn, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601050B RID: 66827 RVA: 0x001808A4 File Offset: 0x0017EAA4
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ASpectatorPawn._ClassPtr;
		}

		// Token: 0x0601050C RID: 66828 RVA: 0x001808B0 File Offset: 0x0017EAB0
		public ASpectatorPawn() : this(BuiltinUtils.AllocNativeUObject(ASpectatorPawn.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601050D RID: 66829 RVA: 0x001808D8 File Offset: 0x0017EAD8
		[NullableContext(1)]
		public ASpectatorPawn(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ASpectatorPawn.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601050E RID: 66830 RVA: 0x0018090B File Offset: 0x0017EB0B
		static ASpectatorPawn()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.SpectatorPawn");
		}

		// Token: 0x0601050F RID: 66831 RVA: 0x00180919 File Offset: 0x0017EB19
		protected ASpectatorPawn(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04008C65 RID: 35941
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.SpectatorPawn";

		// Token: 0x04008C66 RID: 35942
		private static IntPtr _ClassPtr;

		// Token: 0x04008C67 RID: 35943
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
