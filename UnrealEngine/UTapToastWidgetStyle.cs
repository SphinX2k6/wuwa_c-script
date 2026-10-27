using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020028EE RID: 10478
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/TapCommon.TapToastWidgetStyle")]
	[UnrealStructLayout(1104, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1104)]
	public class UTapToastWidgetStyle : USlateWidgetStyleContainerBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06026DD8 RID: 159192 RVA: 0x003B4935 File Offset: 0x003B2B35
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UTapToastWidgetStyle._ClassPtr;
		}

		// Token: 0x06026DD9 RID: 159193 RVA: 0x003B4944 File Offset: 0x003B2B44
		public UTapToastWidgetStyle() : this(BuiltinUtils.AllocNativeUObject(UTapToastWidgetStyle.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06026DDA RID: 159194 RVA: 0x003B496C File Offset: 0x003B2B6C
		public UTapToastWidgetStyle(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UTapToastWidgetStyle.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170095BA RID: 38330
		// (get) Token: 0x06026DDB RID: 159195 RVA: 0x003B49A0 File Offset: 0x003B2BA0
		// (set) Token: 0x06026DDC RID: 159196 RVA: 0x003B49D9 File Offset: 0x003B2BD9
		public FTapToastStyle WidgetStyle
		{
			get
			{
				base.FastCheckIsValid();
				FTapToastStyle result;
				if ((result = this._WidgetStyle) == null)
				{
					result = (this._WidgetStyle = new FTapToastStyle(base.NativePtr + (IntPtr)UTapToastWidgetStyle.__PropertyOffset_WidgetStyle, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FTapToastStyle.StaticStruct(), base.NativePtr + (IntPtr)UTapToastWidgetStyle.__PropertyOffset_WidgetStyle, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06026DDD RID: 159197 RVA: 0x003B49FA File Offset: 0x003B2BFA
		static UTapToastWidgetStyle()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/TapCommon.TapToastWidgetStyle");
		}

		// Token: 0x06026DDE RID: 159198 RVA: 0x003B4A08 File Offset: 0x003B2C08
		protected UTapToastWidgetStyle(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401556A RID: 87402
		public new const string __ObjectPath = "/Script/TapCommon.TapToastWidgetStyle";

		// Token: 0x0401556B RID: 87403
		private static IntPtr _ClassPtr;

		// Token: 0x0401556C RID: 87404
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401556D RID: 87405
		internal static int __PropertyOffset_WidgetStyle;

		// Token: 0x0401556E RID: 87406
		[Nullable(2)]
		private FTapToastStyle _WidgetStyle;
	}
}
