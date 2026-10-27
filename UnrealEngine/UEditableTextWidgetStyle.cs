using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002849 RID: 10313
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Slate.EditableTextWidgetStyle")]
	[UnrealStructLayout(688, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 688)]
	public class UEditableTextWidgetStyle : USlateWidgetStyleContainerBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060264FA RID: 156922 RVA: 0x003A3161 File Offset: 0x003A1361
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UEditableTextWidgetStyle._ClassPtr;
		}

		// Token: 0x060264FB RID: 156923 RVA: 0x003A3170 File Offset: 0x003A1370
		public UEditableTextWidgetStyle() : this(BuiltinUtils.AllocNativeUObject(UEditableTextWidgetStyle.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060264FC RID: 156924 RVA: 0x003A3198 File Offset: 0x003A1398
		public UEditableTextWidgetStyle(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UEditableTextWidgetStyle.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170093E9 RID: 37865
		// (get) Token: 0x060264FD RID: 156925 RVA: 0x003A31CC File Offset: 0x003A13CC
		// (set) Token: 0x060264FE RID: 156926 RVA: 0x003A3205 File Offset: 0x003A1405
		public FEditableTextStyle EditableTextStyle
		{
			get
			{
				base.FastCheckIsValid();
				FEditableTextStyle result;
				if ((result = this._EditableTextStyle) == null)
				{
					result = (this._EditableTextStyle = new FEditableTextStyle(base.NativePtr + (IntPtr)UEditableTextWidgetStyle.__PropertyOffset_EditableTextStyle, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FEditableTextStyle.StaticStruct(), base.NativePtr + (IntPtr)UEditableTextWidgetStyle.__PropertyOffset_EditableTextStyle, value.NativePtr, 1, false);
			}
		}

		// Token: 0x060264FF RID: 156927 RVA: 0x003A3226 File Offset: 0x003A1426
		static UEditableTextWidgetStyle()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Slate.EditableTextWidgetStyle");
		}

		// Token: 0x06026500 RID: 156928 RVA: 0x003A3234 File Offset: 0x003A1434
		protected UEditableTextWidgetStyle(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04014FAB RID: 85931
		public new const string __ObjectPath = "/Script/Slate.EditableTextWidgetStyle";

		// Token: 0x04014FAC RID: 85932
		private static IntPtr _ClassPtr;

		// Token: 0x04014FAD RID: 85933
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04014FAE RID: 85934
		internal static int __PropertyOffset_EditableTextStyle;

		// Token: 0x04014FAF RID: 85935
		[Nullable(2)]
		private FEditableTextStyle _EditableTextStyle;
	}
}
