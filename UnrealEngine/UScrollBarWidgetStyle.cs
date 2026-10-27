using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200285B RID: 10331
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Slate.ScrollBarWidgetStyle")]
	[UnrealStructLayout(1504, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1504)]
	public class UScrollBarWidgetStyle : USlateWidgetStyleContainerBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602651A RID: 156954 RVA: 0x003A3531 File Offset: 0x003A1731
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UScrollBarWidgetStyle._ClassPtr;
		}

		// Token: 0x0602651B RID: 156955 RVA: 0x003A3540 File Offset: 0x003A1740
		public UScrollBarWidgetStyle() : this(BuiltinUtils.AllocNativeUObject(UScrollBarWidgetStyle.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602651C RID: 156956 RVA: 0x003A3568 File Offset: 0x003A1768
		public UScrollBarWidgetStyle(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UScrollBarWidgetStyle.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170093F0 RID: 37872
		// (get) Token: 0x0602651D RID: 156957 RVA: 0x003A359C File Offset: 0x003A179C
		// (set) Token: 0x0602651E RID: 156958 RVA: 0x003A35D5 File Offset: 0x003A17D5
		public FScrollBarStyle ScrollBarStyle
		{
			get
			{
				base.FastCheckIsValid();
				FScrollBarStyle result;
				if ((result = this._ScrollBarStyle) == null)
				{
					result = (this._ScrollBarStyle = new FScrollBarStyle(base.NativePtr + (IntPtr)UScrollBarWidgetStyle.__PropertyOffset_ScrollBarStyle, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FScrollBarStyle.StaticStruct(), base.NativePtr + (IntPtr)UScrollBarWidgetStyle.__PropertyOffset_ScrollBarStyle, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0602651F RID: 156959 RVA: 0x003A35F6 File Offset: 0x003A17F6
		static UScrollBarWidgetStyle()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Slate.ScrollBarWidgetStyle");
		}

		// Token: 0x06026520 RID: 156960 RVA: 0x003A3604 File Offset: 0x003A1804
		protected UScrollBarWidgetStyle(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015022 RID: 86050
		public new const string __ObjectPath = "/Script/Slate.ScrollBarWidgetStyle";

		// Token: 0x04015023 RID: 86051
		private static IntPtr _ClassPtr;

		// Token: 0x04015024 RID: 86052
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04015025 RID: 86053
		internal static int __PropertyOffset_ScrollBarStyle;

		// Token: 0x04015026 RID: 86054
		[Nullable(2)]
		private FScrollBarStyle _ScrollBarStyle;
	}
}
