using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200216D RID: 8557
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.UIExtendToggleTransitionBase")]
	[UnrealStructLayout(360, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 360)]
	public abstract class UUIExtendToggleTransitionBase : ULGUIBehaviour, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060204D7 RID: 132311 RVA: 0x002FF961 File Offset: 0x002FDB61
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUIExtendToggleTransitionBase._ClassPtr;
		}

		// Token: 0x17007E9D RID: 32413
		// (get) Token: 0x060204D8 RID: 132312 RVA: 0x002FF970 File Offset: 0x002FDB70
		// (set) Token: 0x060204D9 RID: 132313 RVA: 0x002FF9A9 File Offset: 0x002FDBA9
		public FUIWidget UnCkeckUnHoverWidget
		{
			get
			{
				base.FastCheckIsValid();
				FUIWidget result;
				if ((result = this._UnCkeckUnHoverWidget) == null)
				{
					result = (this._UnCkeckUnHoverWidget = new FUIWidget(base.NativePtr + (IntPtr)UUIExtendToggleTransitionBase.__PropertyOffset_UnCkeckUnHoverWidget, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FUIWidget.StaticStruct(), base.NativePtr + (IntPtr)UUIExtendToggleTransitionBase.__PropertyOffset_UnCkeckUnHoverWidget, value.NativePtr, 1, false);
			}
		}

		// Token: 0x060204DA RID: 132314 RVA: 0x002FF9CA File Offset: 0x002FDBCA
		static UUIExtendToggleTransitionBase()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UIExtendToggleTransitionBase");
		}

		// Token: 0x060204DB RID: 132315 RVA: 0x002FF9D8 File Offset: 0x002FDBD8
		protected UUIExtendToggleTransitionBase() : this(BuiltinUtils.AllocNativeUObject(UUIExtendToggleTransitionBase.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060204DC RID: 132316 RVA: 0x002FFA00 File Offset: 0x002FDC00
		protected UUIExtendToggleTransitionBase(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040115AF RID: 71087
		public new const string __ObjectPath = "/Script/LGUI.UIExtendToggleTransitionBase";

		// Token: 0x040115B0 RID: 71088
		private static IntPtr _ClassPtr;

		// Token: 0x040115B1 RID: 71089
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040115B2 RID: 71090
		internal static int __PropertyOffset_UnCkeckUnHoverWidget;

		// Token: 0x040115B3 RID: 71091
		[Nullable(2)]
		private FUIWidget _UnCkeckUnHoverWidget;
	}
}
