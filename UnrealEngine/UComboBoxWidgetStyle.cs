using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002840 RID: 10304
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Slate.ComboBoxWidgetStyle")]
	[UnrealStructLayout(1288, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1288)]
	public class UComboBoxWidgetStyle : USlateWidgetStyleContainerBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060264B5 RID: 156853 RVA: 0x003A2AE9 File Offset: 0x003A0CE9
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UComboBoxWidgetStyle._ClassPtr;
		}

		// Token: 0x060264B6 RID: 156854 RVA: 0x003A2AF8 File Offset: 0x003A0CF8
		public UComboBoxWidgetStyle() : this(BuiltinUtils.AllocNativeUObject(UComboBoxWidgetStyle.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060264B7 RID: 156855 RVA: 0x003A2B20 File Offset: 0x003A0D20
		public UComboBoxWidgetStyle(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UComboBoxWidgetStyle.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170093DE RID: 37854
		// (get) Token: 0x060264B8 RID: 156856 RVA: 0x003A2B54 File Offset: 0x003A0D54
		// (set) Token: 0x060264B9 RID: 156857 RVA: 0x003A2B8D File Offset: 0x003A0D8D
		public FComboBoxStyle ComboBoxStyle
		{
			get
			{
				base.FastCheckIsValid();
				FComboBoxStyle result;
				if ((result = this._ComboBoxStyle) == null)
				{
					result = (this._ComboBoxStyle = new FComboBoxStyle(base.NativePtr + (IntPtr)UComboBoxWidgetStyle.__PropertyOffset_ComboBoxStyle, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FComboBoxStyle.StaticStruct(), base.NativePtr + (IntPtr)UComboBoxWidgetStyle.__PropertyOffset_ComboBoxStyle, value.NativePtr, 1, false);
			}
		}

		// Token: 0x060264BA RID: 156858 RVA: 0x003A2BAE File Offset: 0x003A0DAE
		static UComboBoxWidgetStyle()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Slate.ComboBoxWidgetStyle");
		}

		// Token: 0x060264BB RID: 156859 RVA: 0x003A2BBC File Offset: 0x003A0DBC
		protected UComboBoxWidgetStyle(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04014F7D RID: 85885
		public new const string __ObjectPath = "/Script/Slate.ComboBoxWidgetStyle";

		// Token: 0x04014F7E RID: 85886
		private static IntPtr _ClassPtr;

		// Token: 0x04014F7F RID: 85887
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04014F80 RID: 85888
		internal static int __PropertyOffset_ComboBoxStyle;

		// Token: 0x04014F81 RID: 85889
		[Nullable(2)]
		private FComboBoxStyle _ComboBoxStyle;
	}
}
