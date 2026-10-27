using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001E2A RID: 7722
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_SceneSegment")]
	[UnrealStructLayout(1120, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1120)]
	public class AKSC_SceneSegment : AKSC_BaseActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601D6FA RID: 120570 RVA: 0x002B7ADB File Offset: 0x002B5CDB
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AKSC_SceneSegment._ClassPtr;
		}

		// Token: 0x0601D6FB RID: 120571 RVA: 0x002B7AE8 File Offset: 0x002B5CE8
		public AKSC_SceneSegment() : this(BuiltinUtils.AllocNativeUObject(AKSC_SceneSegment.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601D6FC RID: 120572 RVA: 0x002B7B10 File Offset: 0x002B5D10
		[NullableContext(1)]
		public AKSC_SceneSegment(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AKSC_SceneSegment.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601D6FD RID: 120573 RVA: 0x002B7B43 File Offset: 0x002B5D43
		static AKSC_SceneSegment()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_SceneSegment");
		}

		// Token: 0x0601D6FE RID: 120574 RVA: 0x002B7B51 File Offset: 0x002B5D51
		protected AKSC_SceneSegment(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FF67 RID: 65383
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_SceneSegment";

		// Token: 0x0400FF68 RID: 65384
		private static IntPtr _ClassPtr;

		// Token: 0x0400FF69 RID: 65385
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
