using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001E16 RID: 7702
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_RenderActor")]
	[UnrealStructLayout(1056, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1056)]
	public class AKSC_RenderActor : AActor, IUnrealUObject, IUnrealObject, IKSC_RenderEntityInterface, IUnrealNativeInterface, IUnrealInterface, IKSC_RenderEntityAnimInterface
	{
		// Token: 0x0601D637 RID: 120375 RVA: 0x002B6118 File Offset: 0x002B4318
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AKSC_RenderActor._ClassPtr;
		}

		// Token: 0x0601D638 RID: 120376 RVA: 0x002B6124 File Offset: 0x002B4324
		int IKSC_RenderEntityInterface.InterfaceOffset()
		{
			return AKSC_RenderActor.__InterfaceOffset_IKSC_RenderEntityInterface;
		}

		// Token: 0x0601D639 RID: 120377 RVA: 0x002B612B File Offset: 0x002B432B
		int IKSC_RenderEntityAnimInterface.InterfaceOffset()
		{
			return AKSC_RenderActor.__InterfaceOffset_IKSC_RenderEntityAnimInterface;
		}

		// Token: 0x0601D63A RID: 120378 RVA: 0x002B6134 File Offset: 0x002B4334
		public AKSC_RenderActor() : this(BuiltinUtils.AllocNativeUObject(AKSC_RenderActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601D63B RID: 120379 RVA: 0x002B615C File Offset: 0x002B435C
		[NullableContext(1)]
		public AKSC_RenderActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AKSC_RenderActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601D63C RID: 120380 RVA: 0x002B618F File Offset: 0x002B438F
		static AKSC_RenderActor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_RenderActor");
		}

		// Token: 0x0601D63D RID: 120381 RVA: 0x002B619D File Offset: 0x002B439D
		protected AKSC_RenderActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FF03 RID: 65283
		internal static int __InterfaceOffset_IKSC_RenderEntityInterface;

		// Token: 0x0400FF04 RID: 65284
		internal static int __InterfaceOffset_IKSC_RenderEntityAnimInterface;

		// Token: 0x0400FF05 RID: 65285
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_RenderActor";

		// Token: 0x0400FF06 RID: 65286
		private static IntPtr _ClassPtr;

		// Token: 0x0400FF07 RID: 65287
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
