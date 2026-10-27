using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020028DC RID: 10460
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/TapCommon.TapBoxWrapperWidgetStyle")]
	[UnrealStructLayout(1000, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1000)]
	public class UTapBoxWrapperWidgetStyle : USlateWidgetStyleContainerBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06026CE7 RID: 158951 RVA: 0x003B2E22 File Offset: 0x003B1022
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UTapBoxWrapperWidgetStyle._ClassPtr;
		}

		// Token: 0x06026CE8 RID: 158952 RVA: 0x003B2E30 File Offset: 0x003B1030
		public UTapBoxWrapperWidgetStyle() : this(BuiltinUtils.AllocNativeUObject(UTapBoxWrapperWidgetStyle.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06026CE9 RID: 158953 RVA: 0x003B2E58 File Offset: 0x003B1058
		public UTapBoxWrapperWidgetStyle(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UTapBoxWrapperWidgetStyle.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17009581 RID: 38273
		// (get) Token: 0x06026CEA RID: 158954 RVA: 0x003B2E8C File Offset: 0x003B108C
		// (set) Token: 0x06026CEB RID: 158955 RVA: 0x003B2EC5 File Offset: 0x003B10C5
		public FTapBoxWrapperStyle WidgetStyle
		{
			get
			{
				base.FastCheckIsValid();
				FTapBoxWrapperStyle result;
				if ((result = this._WidgetStyle) == null)
				{
					result = (this._WidgetStyle = new FTapBoxWrapperStyle(base.NativePtr + (IntPtr)UTapBoxWrapperWidgetStyle.__PropertyOffset_WidgetStyle, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FTapBoxWrapperStyle.StaticStruct(), base.NativePtr + (IntPtr)UTapBoxWrapperWidgetStyle.__PropertyOffset_WidgetStyle, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06026CEC RID: 158956 RVA: 0x003B2EE6 File Offset: 0x003B10E6
		static UTapBoxWrapperWidgetStyle()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/TapCommon.TapBoxWrapperWidgetStyle");
		}

		// Token: 0x06026CED RID: 158957 RVA: 0x003B2EF4 File Offset: 0x003B10F4
		protected UTapBoxWrapperWidgetStyle(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040154E2 RID: 87266
		public new const string __ObjectPath = "/Script/TapCommon.TapBoxWrapperWidgetStyle";

		// Token: 0x040154E3 RID: 87267
		private static IntPtr _ClassPtr;

		// Token: 0x040154E4 RID: 87268
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040154E5 RID: 87269
		internal static int __PropertyOffset_WidgetStyle;

		// Token: 0x040154E6 RID: 87270
		[Nullable(2)]
		private FTapBoxWrapperStyle _WidgetStyle;
	}
}
