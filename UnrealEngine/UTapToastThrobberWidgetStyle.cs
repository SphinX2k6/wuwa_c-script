using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020028ED RID: 10477
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/TapCommon.TapToastThrobberWidgetStyle")]
	[UnrealStructLayout(2496, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2496)]
	public class UTapToastThrobberWidgetStyle : USlateWidgetStyleContainerBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06026DD1 RID: 159185 RVA: 0x003B485C File Offset: 0x003B2A5C
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UTapToastThrobberWidgetStyle._ClassPtr;
		}

		// Token: 0x06026DD2 RID: 159186 RVA: 0x003B4868 File Offset: 0x003B2A68
		public UTapToastThrobberWidgetStyle() : this(BuiltinUtils.AllocNativeUObject(UTapToastThrobberWidgetStyle.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06026DD3 RID: 159187 RVA: 0x003B4890 File Offset: 0x003B2A90
		public UTapToastThrobberWidgetStyle(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UTapToastThrobberWidgetStyle.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170095B9 RID: 38329
		// (get) Token: 0x06026DD4 RID: 159188 RVA: 0x003B48C4 File Offset: 0x003B2AC4
		// (set) Token: 0x06026DD5 RID: 159189 RVA: 0x003B48FD File Offset: 0x003B2AFD
		public FTapToastThrobberStyle WidgetStyle
		{
			get
			{
				base.FastCheckIsValid();
				FTapToastThrobberStyle result;
				if ((result = this._WidgetStyle) == null)
				{
					result = (this._WidgetStyle = new FTapToastThrobberStyle(base.NativePtr + (IntPtr)UTapToastThrobberWidgetStyle.__PropertyOffset_WidgetStyle, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FTapToastThrobberStyle.StaticStruct(), base.NativePtr + (IntPtr)UTapToastThrobberWidgetStyle.__PropertyOffset_WidgetStyle, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06026DD6 RID: 159190 RVA: 0x003B491E File Offset: 0x003B2B1E
		static UTapToastThrobberWidgetStyle()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/TapCommon.TapToastThrobberWidgetStyle");
		}

		// Token: 0x06026DD7 RID: 159191 RVA: 0x003B492C File Offset: 0x003B2B2C
		protected UTapToastThrobberWidgetStyle(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015565 RID: 87397
		public new const string __ObjectPath = "/Script/TapCommon.TapToastThrobberWidgetStyle";

		// Token: 0x04015566 RID: 87398
		private static IntPtr _ClassPtr;

		// Token: 0x04015567 RID: 87399
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04015568 RID: 87400
		internal static int __PropertyOffset_WidgetStyle;

		// Token: 0x04015569 RID: 87401
		[Nullable(2)]
		private FTapToastThrobberStyle _WidgetStyle;
	}
}
