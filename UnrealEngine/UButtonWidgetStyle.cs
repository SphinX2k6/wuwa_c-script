using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200283E RID: 10302
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Slate.ButtonWidgetStyle")]
	[UnrealStructLayout(824, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 824)]
	public class UButtonWidgetStyle : USlateWidgetStyleContainerBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060264A7 RID: 156839 RVA: 0x003A2934 File Offset: 0x003A0B34
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UButtonWidgetStyle._ClassPtr;
		}

		// Token: 0x060264A8 RID: 156840 RVA: 0x003A2940 File Offset: 0x003A0B40
		public UButtonWidgetStyle() : this(BuiltinUtils.AllocNativeUObject(UButtonWidgetStyle.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060264A9 RID: 156841 RVA: 0x003A2968 File Offset: 0x003A0B68
		public UButtonWidgetStyle(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UButtonWidgetStyle.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170093DC RID: 37852
		// (get) Token: 0x060264AA RID: 156842 RVA: 0x003A299C File Offset: 0x003A0B9C
		// (set) Token: 0x060264AB RID: 156843 RVA: 0x003A29D5 File Offset: 0x003A0BD5
		public FButtonStyle ButtonStyle
		{
			get
			{
				base.FastCheckIsValid();
				FButtonStyle result;
				if ((result = this._ButtonStyle) == null)
				{
					result = (this._ButtonStyle = new FButtonStyle(base.NativePtr + (IntPtr)UButtonWidgetStyle.__PropertyOffset_ButtonStyle, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FButtonStyle.StaticStruct(), base.NativePtr + (IntPtr)UButtonWidgetStyle.__PropertyOffset_ButtonStyle, value.NativePtr, 1, false);
			}
		}

		// Token: 0x060264AC RID: 156844 RVA: 0x003A29F6 File Offset: 0x003A0BF6
		static UButtonWidgetStyle()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Slate.ButtonWidgetStyle");
		}

		// Token: 0x060264AD RID: 156845 RVA: 0x003A2A04 File Offset: 0x003A0C04
		protected UButtonWidgetStyle(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04014F73 RID: 85875
		public new const string __ObjectPath = "/Script/Slate.ButtonWidgetStyle";

		// Token: 0x04014F74 RID: 85876
		private static IntPtr _ClassPtr;

		// Token: 0x04014F75 RID: 85877
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04014F76 RID: 85878
		internal static int __PropertyOffset_ButtonStyle;

		// Token: 0x04014F77 RID: 85879
		[Nullable(2)]
		private FButtonStyle _ButtonStyle;
	}
}
