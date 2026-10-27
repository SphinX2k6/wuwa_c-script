using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002848 RID: 10312
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Slate.EditableTextBoxWidgetStyle")]
	[UnrealStructLayout(2424, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2424)]
	public class UEditableTextBoxWidgetStyle : USlateWidgetStyleContainerBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060264F3 RID: 156915 RVA: 0x003A3088 File Offset: 0x003A1288
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UEditableTextBoxWidgetStyle._ClassPtr;
		}

		// Token: 0x060264F4 RID: 156916 RVA: 0x003A3094 File Offset: 0x003A1294
		public UEditableTextBoxWidgetStyle() : this(BuiltinUtils.AllocNativeUObject(UEditableTextBoxWidgetStyle.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060264F5 RID: 156917 RVA: 0x003A30BC File Offset: 0x003A12BC
		public UEditableTextBoxWidgetStyle(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UEditableTextBoxWidgetStyle.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170093E8 RID: 37864
		// (get) Token: 0x060264F6 RID: 156918 RVA: 0x003A30F0 File Offset: 0x003A12F0
		// (set) Token: 0x060264F7 RID: 156919 RVA: 0x003A3129 File Offset: 0x003A1329
		public FEditableTextBoxStyle EditableTextBoxStyle
		{
			get
			{
				base.FastCheckIsValid();
				FEditableTextBoxStyle result;
				if ((result = this._EditableTextBoxStyle) == null)
				{
					result = (this._EditableTextBoxStyle = new FEditableTextBoxStyle(base.NativePtr + (IntPtr)UEditableTextBoxWidgetStyle.__PropertyOffset_EditableTextBoxStyle, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FEditableTextBoxStyle.StaticStruct(), base.NativePtr + (IntPtr)UEditableTextBoxWidgetStyle.__PropertyOffset_EditableTextBoxStyle, value.NativePtr, 1, false);
			}
		}

		// Token: 0x060264F8 RID: 156920 RVA: 0x003A314A File Offset: 0x003A134A
		static UEditableTextBoxWidgetStyle()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Slate.EditableTextBoxWidgetStyle");
		}

		// Token: 0x060264F9 RID: 156921 RVA: 0x003A3158 File Offset: 0x003A1358
		protected UEditableTextBoxWidgetStyle(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04014FA6 RID: 85926
		public new const string __ObjectPath = "/Script/Slate.EditableTextBoxWidgetStyle";

		// Token: 0x04014FA7 RID: 85927
		private static IntPtr _ClassPtr;

		// Token: 0x04014FA8 RID: 85928
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04014FA9 RID: 85929
		internal static int __PropertyOffset_EditableTextBoxStyle;

		// Token: 0x04014FAA RID: 85930
		[Nullable(2)]
		private FEditableTextBoxStyle _EditableTextBoxStyle;
	}
}
