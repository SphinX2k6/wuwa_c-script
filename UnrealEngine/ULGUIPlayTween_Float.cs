using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020006AD RID: 1709
	[UnrealObjectPath("/Script/LGUI.LGUIPlayTween_Float")]
	[UnrealStructLayout(224, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 224)]
	public class ULGUIPlayTween_Float : ULGUIPlayTween, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060092CD RID: 37581 RVA: 0x000DD1EB File Offset: 0x000DB3EB
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ULGUIPlayTween_Float._ClassPtr;
		}

		// Token: 0x060092CE RID: 37582 RVA: 0x000DD1F8 File Offset: 0x000DB3F8
		public ULGUIPlayTween_Float() : this(BuiltinUtils.AllocNativeUObject(ULGUIPlayTween_Float.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060092CF RID: 37583 RVA: 0x000DD220 File Offset: 0x000DB420
		[NullableContext(1)]
		public ULGUIPlayTween_Float(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ULGUIPlayTween_Float.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001B5E RID: 7006
		// (get) Token: 0x060092D0 RID: 37584 RVA: 0x000DD253 File Offset: 0x000DB453
		// (set) Token: 0x060092D1 RID: 37585 RVA: 0x000DD263 File Offset: 0x000DB463
		public unsafe float from
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULGUIPlayTween_Float.__PropertyOffset_from);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULGUIPlayTween_Float.__PropertyOffset_from) = value;
			}
		}

		// Token: 0x17001B5F RID: 7007
		// (get) Token: 0x060092D2 RID: 37586 RVA: 0x000DD274 File Offset: 0x000DB474
		// (set) Token: 0x060092D3 RID: 37587 RVA: 0x000DD284 File Offset: 0x000DB484
		public unsafe float to
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULGUIPlayTween_Float.__PropertyOffset_to);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULGUIPlayTween_Float.__PropertyOffset_to) = value;
			}
		}

		// Token: 0x060092D4 RID: 37588 RVA: 0x000DD295 File Offset: 0x000DB495
		static ULGUIPlayTween_Float()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.LGUIPlayTween_Float");
		}

		// Token: 0x060092D5 RID: 37589 RVA: 0x000DD2A3 File Offset: 0x000DB4A3
		protected ULGUIPlayTween_Float(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04003FFA RID: 16378
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.LGUIPlayTween_Float";

		// Token: 0x04003FFB RID: 16379
		private static IntPtr _ClassPtr;

		// Token: 0x04003FFC RID: 16380
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04003FFD RID: 16381
		internal static int __PropertyOffset_from;

		// Token: 0x04003FFE RID: 16382
		internal static int __PropertyOffset_to;
	}
}
