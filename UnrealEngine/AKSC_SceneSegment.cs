using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000585 RID: 1413
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_SceneSegment")]
	[UnrealStructLayout(1120, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1120)]
	public class AKSC_SceneSegment : AKSC_BaseActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600804B RID: 32843 RVA: 0x000BD9BF File Offset: 0x000BBBBF
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AKSC_SceneSegment._ClassPtr;
		}

		// Token: 0x0600804C RID: 32844 RVA: 0x000BD9CC File Offset: 0x000BBBCC
		public AKSC_SceneSegment() : this(BuiltinUtils.AllocNativeUObject(AKSC_SceneSegment.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600804D RID: 32845 RVA: 0x000BD9F4 File Offset: 0x000BBBF4
		[NullableContext(1)]
		public AKSC_SceneSegment(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AKSC_SceneSegment.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600804E RID: 32846 RVA: 0x000BDA27 File Offset: 0x000BBC27
		static AKSC_SceneSegment()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_SceneSegment");
		}

		// Token: 0x0600804F RID: 32847 RVA: 0x000BDA35 File Offset: 0x000BBC35
		protected AKSC_SceneSegment(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04003806 RID: 14342
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_SceneSegment";

		// Token: 0x04003807 RID: 14343
		private static IntPtr _ClassPtr;

		// Token: 0x04003808 RID: 14344
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
