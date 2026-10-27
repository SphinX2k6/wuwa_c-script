using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002613 RID: 9747
	[UnrealObjectPath("/Script/OHOSRT.OHOSRTSubsystem")]
	[UnrealStructLayout(360, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 360)]
	public class UOHOSRTSubsystem : UWorldSubsystem, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06024411 RID: 148497 RVA: 0x0035ADC2 File Offset: 0x00358FC2
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UOHOSRTSubsystem._ClassPtr;
		}

		// Token: 0x06024412 RID: 148498 RVA: 0x0035ADD0 File Offset: 0x00358FD0
		public UOHOSRTSubsystem() : this(BuiltinUtils.AllocNativeUObject(UOHOSRTSubsystem.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06024413 RID: 148499 RVA: 0x0035ADF8 File Offset: 0x00358FF8
		[NullableContext(1)]
		public UOHOSRTSubsystem(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UOHOSRTSubsystem.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06024414 RID: 148500 RVA: 0x0035AE2B File Offset: 0x0035902B
		static UOHOSRTSubsystem()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/OHOSRT.OHOSRTSubsystem");
		}

		// Token: 0x06024415 RID: 148501 RVA: 0x0035AE39 File Offset: 0x00359039
		protected UOHOSRTSubsystem(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04013732 RID: 79666
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/OHOSRT.OHOSRTSubsystem";

		// Token: 0x04013733 RID: 79667
		private static IntPtr _ClassPtr;

		// Token: 0x04013734 RID: 79668
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
