using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000832 RID: 2098
	[UnrealObjectPath("/Script/Engine.AnimNotify_ResetClothingSimulation")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 72)]
	public class UAnimNotify_ResetClothingSimulation : UAnimNotify, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060070F6 RID: 28918 RVA: 0x000A1F2F File Offset: 0x000A012F
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAnimNotify_ResetClothingSimulation._ClassPtr;
		}

		// Token: 0x060070F7 RID: 28919 RVA: 0x000A1F3C File Offset: 0x000A013C
		public UAnimNotify_ResetClothingSimulation() : this(BuiltinUtils.AllocNativeUObject(UAnimNotify_ResetClothingSimulation.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060070F8 RID: 28920 RVA: 0x000A1F64 File Offset: 0x000A0164
		[NullableContext(1)]
		public UAnimNotify_ResetClothingSimulation(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAnimNotify_ResetClothingSimulation.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060070F9 RID: 28921 RVA: 0x000A1F97 File Offset: 0x000A0197
		static UAnimNotify_ResetClothingSimulation()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.AnimNotify_ResetClothingSimulation");
		}

		// Token: 0x060070FA RID: 28922 RVA: 0x000A1FA5 File Offset: 0x000A01A5
		protected UAnimNotify_ResetClothingSimulation(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400363B RID: 13883
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.AnimNotify_ResetClothingSimulation";

		// Token: 0x0400363C RID: 13884
		private static IntPtr _ClassPtr;

		// Token: 0x0400363D RID: 13885
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
