using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002841 RID: 10305
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Slate.ComboButtonWidgetStyle")]
	[UnrealStructLayout(1192, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1192)]
	public class UComboButtonWidgetStyle : USlateWidgetStyleContainerBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060264BC RID: 156860 RVA: 0x003A2BC5 File Offset: 0x003A0DC5
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UComboButtonWidgetStyle._ClassPtr;
		}

		// Token: 0x060264BD RID: 156861 RVA: 0x003A2BD4 File Offset: 0x003A0DD4
		public UComboButtonWidgetStyle() : this(BuiltinUtils.AllocNativeUObject(UComboButtonWidgetStyle.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060264BE RID: 156862 RVA: 0x003A2BFC File Offset: 0x003A0DFC
		public UComboButtonWidgetStyle(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UComboButtonWidgetStyle.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170093DF RID: 37855
		// (get) Token: 0x060264BF RID: 156863 RVA: 0x003A2C30 File Offset: 0x003A0E30
		// (set) Token: 0x060264C0 RID: 156864 RVA: 0x003A2C69 File Offset: 0x003A0E69
		public FComboButtonStyle ComboButtonStyle
		{
			get
			{
				base.FastCheckIsValid();
				FComboButtonStyle result;
				if ((result = this._ComboButtonStyle) == null)
				{
					result = (this._ComboButtonStyle = new FComboButtonStyle(base.NativePtr + (IntPtr)UComboButtonWidgetStyle.__PropertyOffset_ComboButtonStyle, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FComboButtonStyle.StaticStruct(), base.NativePtr + (IntPtr)UComboButtonWidgetStyle.__PropertyOffset_ComboButtonStyle, value.NativePtr, 1, false);
			}
		}

		// Token: 0x060264C1 RID: 156865 RVA: 0x003A2C8A File Offset: 0x003A0E8A
		static UComboButtonWidgetStyle()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Slate.ComboButtonWidgetStyle");
		}

		// Token: 0x060264C2 RID: 156866 RVA: 0x003A2C98 File Offset: 0x003A0E98
		protected UComboButtonWidgetStyle(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04014F82 RID: 85890
		public new const string __ObjectPath = "/Script/Slate.ComboButtonWidgetStyle";

		// Token: 0x04014F83 RID: 85891
		private static IntPtr _ClassPtr;

		// Token: 0x04014F84 RID: 85892
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04014F85 RID: 85893
		internal static int __PropertyOffset_ComboButtonStyle;

		// Token: 0x04014F86 RID: 85894
		[Nullable(2)]
		private FComboButtonStyle _ComboButtonStyle;
	}
}
