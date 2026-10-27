using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200262E RID: 9774
	[UnrealObjectPath("/Script/Overlay.Overlays")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public abstract class UOverlays : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060245A8 RID: 148904 RVA: 0x0035D307 File Offset: 0x0035B507
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UOverlays._ClassPtr;
		}

		// Token: 0x060245A9 RID: 148905 RVA: 0x0035D313 File Offset: 0x0035B513
		static UOverlays()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Overlay.Overlays");
		}

		// Token: 0x060245AA RID: 148906 RVA: 0x0035D324 File Offset: 0x0035B524
		protected UOverlays() : this(BuiltinUtils.AllocNativeUObject(UOverlays.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060245AB RID: 148907 RVA: 0x0035D34C File Offset: 0x0035B54C
		protected UOverlays(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04013811 RID: 79889
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Overlay.Overlays";

		// Token: 0x04013812 RID: 79890
		private static IntPtr _ClassPtr;

		// Token: 0x04013813 RID: 79891
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
