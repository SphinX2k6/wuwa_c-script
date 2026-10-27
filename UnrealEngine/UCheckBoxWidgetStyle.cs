using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200283F RID: 10303
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Slate.CheckBoxWidgetStyle")]
	[UnrealStructLayout(1744, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1744)]
	public class UCheckBoxWidgetStyle : USlateWidgetStyleContainerBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060264AE RID: 156846 RVA: 0x003A2A0D File Offset: 0x003A0C0D
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UCheckBoxWidgetStyle._ClassPtr;
		}

		// Token: 0x060264AF RID: 156847 RVA: 0x003A2A1C File Offset: 0x003A0C1C
		public UCheckBoxWidgetStyle() : this(BuiltinUtils.AllocNativeUObject(UCheckBoxWidgetStyle.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060264B0 RID: 156848 RVA: 0x003A2A44 File Offset: 0x003A0C44
		public UCheckBoxWidgetStyle(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UCheckBoxWidgetStyle.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170093DD RID: 37853
		// (get) Token: 0x060264B1 RID: 156849 RVA: 0x003A2A78 File Offset: 0x003A0C78
		// (set) Token: 0x060264B2 RID: 156850 RVA: 0x003A2AB1 File Offset: 0x003A0CB1
		public FCheckBoxStyle CheckBoxStyle
		{
			get
			{
				base.FastCheckIsValid();
				FCheckBoxStyle result;
				if ((result = this._CheckBoxStyle) == null)
				{
					result = (this._CheckBoxStyle = new FCheckBoxStyle(base.NativePtr + (IntPtr)UCheckBoxWidgetStyle.__PropertyOffset_CheckBoxStyle, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FCheckBoxStyle.StaticStruct(), base.NativePtr + (IntPtr)UCheckBoxWidgetStyle.__PropertyOffset_CheckBoxStyle, value.NativePtr, 1, false);
			}
		}

		// Token: 0x060264B3 RID: 156851 RVA: 0x003A2AD2 File Offset: 0x003A0CD2
		static UCheckBoxWidgetStyle()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Slate.CheckBoxWidgetStyle");
		}

		// Token: 0x060264B4 RID: 156852 RVA: 0x003A2AE0 File Offset: 0x003A0CE0
		protected UCheckBoxWidgetStyle(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04014F78 RID: 85880
		public new const string __ObjectPath = "/Script/Slate.CheckBoxWidgetStyle";

		// Token: 0x04014F79 RID: 85881
		private static IntPtr _ClassPtr;

		// Token: 0x04014F7A RID: 85882
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04014F7B RID: 85883
		internal static int __PropertyOffset_CheckBoxStyle;

		// Token: 0x04014F7C RID: 85884
		[Nullable(2)]
		private FCheckBoxStyle _CheckBoxStyle;
	}
}
