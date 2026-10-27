using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020021DE RID: 8670
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.UITransitionBase")]
	[UnrealStructLayout(744, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 744)]
	public abstract class UUITransitionBase : UUISelectableTransitionComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060210CD RID: 135373 RVA: 0x0030BF88 File Offset: 0x0030A188
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUITransitionBase._ClassPtr;
		}

		// Token: 0x17008100 RID: 33024
		// (get) Token: 0x060210CE RID: 135374 RVA: 0x0030BF94 File Offset: 0x0030A194
		// (set) Token: 0x060210CF RID: 135375 RVA: 0x0030BFCD File Offset: 0x0030A1CD
		public FWidgetTransitionInfo WidgetTransitionInfo
		{
			get
			{
				base.FastCheckIsValid();
				FWidgetTransitionInfo result;
				if ((result = this._WidgetTransitionInfo) == null)
				{
					result = (this._WidgetTransitionInfo = new FWidgetTransitionInfo(base.NativePtr + (IntPtr)UUITransitionBase.__PropertyOffset_WidgetTransitionInfo, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FWidgetTransitionInfo.StaticStruct(), base.NativePtr + (IntPtr)UUITransitionBase.__PropertyOffset_WidgetTransitionInfo, value.NativePtr, 1, false);
			}
		}

		// Token: 0x060210D0 RID: 135376 RVA: 0x0030BFEE File Offset: 0x0030A1EE
		static UUITransitionBase()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UITransitionBase");
		}

		// Token: 0x060210D1 RID: 135377 RVA: 0x0030BFFC File Offset: 0x0030A1FC
		protected UUITransitionBase() : this(BuiltinUtils.AllocNativeUObject(UUITransitionBase.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060210D2 RID: 135378 RVA: 0x0030C024 File Offset: 0x0030A224
		protected UUITransitionBase(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011A28 RID: 72232
		public new const string __ObjectPath = "/Script/LGUI.UITransitionBase";

		// Token: 0x04011A29 RID: 72233
		private static IntPtr _ClassPtr;

		// Token: 0x04011A2A RID: 72234
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011A2B RID: 72235
		internal static int __PropertyOffset_WidgetTransitionInfo;

		// Token: 0x04011A2C RID: 72236
		[Nullable(2)]
		private FWidgetTransitionInfo _WidgetTransitionInfo;
	}
}
