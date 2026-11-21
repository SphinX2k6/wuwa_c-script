using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000705 RID: 1797
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.UIExtendToggleTransitionBase")]
	[UnrealStructLayout(360, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 360)]
	public abstract class UUIExtendToggleTransitionBase : ULGUIBehaviour, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06009905 RID: 39173 RVA: 0x000E6811 File Offset: 0x000E4A11
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUIExtendToggleTransitionBase._ClassPtr;
		}

		// Token: 0x17001C72 RID: 7282
		// (get) Token: 0x06009906 RID: 39174 RVA: 0x000E6820 File Offset: 0x000E4A20
		// (set) Token: 0x06009907 RID: 39175 RVA: 0x000E6859 File Offset: 0x000E4A59
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

		// Token: 0x06009908 RID: 39176 RVA: 0x000E687A File Offset: 0x000E4A7A
		static UUIExtendToggleTransitionBase()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UIExtendToggleTransitionBase");
		}

		// Token: 0x06009909 RID: 39177 RVA: 0x000E6888 File Offset: 0x000E4A88
		protected UUIExtendToggleTransitionBase() : this(BuiltinUtils.AllocNativeUObject(UUIExtendToggleTransitionBase.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600990A RID: 39178 RVA: 0x000E68B0 File Offset: 0x000E4AB0
		protected UUIExtendToggleTransitionBase(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04004288 RID: 17032
		public new const string __ObjectPath = "/Script/LGUI.UIExtendToggleTransitionBase";

		// Token: 0x04004289 RID: 17033
		private static IntPtr _ClassPtr;

		// Token: 0x0400428A RID: 17034
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400428B RID: 17035
		internal static int __PropertyOffset_UnCkeckUnHoverWidget;

		// Token: 0x0400428C RID: 17036
		[Nullable(2)]
		private FUIWidget _UnCkeckUnHoverWidget;
	}
}
