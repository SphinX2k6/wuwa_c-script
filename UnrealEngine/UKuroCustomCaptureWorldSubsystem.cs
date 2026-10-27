using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001ADA RID: 6874
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroCustomCaptureWorldSubsystem")]
	[UnrealStructLayout(144, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 144)]
	public class UKuroCustomCaptureWorldSubsystem : UWorldSubsystem, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060199CF RID: 104911 RVA: 0x0025DB5A File Offset: 0x0025BD5A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroCustomCaptureWorldSubsystem._ClassPtr;
		}

		// Token: 0x060199D0 RID: 104912 RVA: 0x0025DB68 File Offset: 0x0025BD68
		public UKuroCustomCaptureWorldSubsystem() : this(BuiltinUtils.AllocNativeUObject(UKuroCustomCaptureWorldSubsystem.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060199D1 RID: 104913 RVA: 0x0025DB90 File Offset: 0x0025BD90
		[NullableContext(1)]
		public UKuroCustomCaptureWorldSubsystem(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroCustomCaptureWorldSubsystem.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060199D2 RID: 104914 RVA: 0x0025DBC3 File Offset: 0x0025BDC3
		static UKuroCustomCaptureWorldSubsystem()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroCustomCaptureWorldSubsystem");
		}

		// Token: 0x060199D3 RID: 104915 RVA: 0x0025DBD1 File Offset: 0x0025BDD1
		protected UKuroCustomCaptureWorldSubsystem(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400DF07 RID: 57095
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroCustomCaptureWorldSubsystem";

		// Token: 0x0400DF08 RID: 57096
		private static IntPtr _ClassPtr;

		// Token: 0x0400DF09 RID: 57097
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
