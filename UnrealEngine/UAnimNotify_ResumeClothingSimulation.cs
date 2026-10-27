using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000834 RID: 2100
	[UnrealObjectPath("/Script/Engine.AnimNotify_ResumeClothingSimulation")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 72)]
	public class UAnimNotify_ResumeClothingSimulation : UAnimNotify, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06007100 RID: 28928 RVA: 0x000A202E File Offset: 0x000A022E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAnimNotify_ResumeClothingSimulation._ClassPtr;
		}

		// Token: 0x06007101 RID: 28929 RVA: 0x000A203C File Offset: 0x000A023C
		public UAnimNotify_ResumeClothingSimulation() : this(BuiltinUtils.AllocNativeUObject(UAnimNotify_ResumeClothingSimulation.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06007102 RID: 28930 RVA: 0x000A2064 File Offset: 0x000A0264
		[NullableContext(1)]
		public UAnimNotify_ResumeClothingSimulation(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAnimNotify_ResumeClothingSimulation.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06007103 RID: 28931 RVA: 0x000A2097 File Offset: 0x000A0297
		static UAnimNotify_ResumeClothingSimulation()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.AnimNotify_ResumeClothingSimulation");
		}

		// Token: 0x06007104 RID: 28932 RVA: 0x000A20A5 File Offset: 0x000A02A5
		protected UAnimNotify_ResumeClothingSimulation(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04003641 RID: 13889
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.AnimNotify_ResumeClothingSimulation";

		// Token: 0x04003642 RID: 13890
		private static IntPtr _ClassPtr;

		// Token: 0x04003643 RID: 13891
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
