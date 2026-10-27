using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020028E5 RID: 10469
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/TapCommon.TapMessageBoxWidgetStyle")]
	[UnrealStructLayout(792, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 792)]
	public class UTapMessageBoxWidgetStyle : USlateWidgetStyleContainerBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06026D52 RID: 159058 RVA: 0x003B38CB File Offset: 0x003B1ACB
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UTapMessageBoxWidgetStyle._ClassPtr;
		}

		// Token: 0x06026D53 RID: 159059 RVA: 0x003B38D8 File Offset: 0x003B1AD8
		public UTapMessageBoxWidgetStyle() : this(BuiltinUtils.AllocNativeUObject(UTapMessageBoxWidgetStyle.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06026D54 RID: 159060 RVA: 0x003B3900 File Offset: 0x003B1B00
		public UTapMessageBoxWidgetStyle(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UTapMessageBoxWidgetStyle.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17009595 RID: 38293
		// (get) Token: 0x06026D55 RID: 159061 RVA: 0x003B3934 File Offset: 0x003B1B34
		// (set) Token: 0x06026D56 RID: 159062 RVA: 0x003B396D File Offset: 0x003B1B6D
		public FTapMessageBoxStyle WidgetStyle
		{
			get
			{
				base.FastCheckIsValid();
				FTapMessageBoxStyle result;
				if ((result = this._WidgetStyle) == null)
				{
					result = (this._WidgetStyle = new FTapMessageBoxStyle(base.NativePtr + (IntPtr)UTapMessageBoxWidgetStyle.__PropertyOffset_WidgetStyle, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FTapMessageBoxStyle.StaticStruct(), base.NativePtr + (IntPtr)UTapMessageBoxWidgetStyle.__PropertyOffset_WidgetStyle, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06026D57 RID: 159063 RVA: 0x003B398E File Offset: 0x003B1B8E
		static UTapMessageBoxWidgetStyle()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/TapCommon.TapMessageBoxWidgetStyle");
		}

		// Token: 0x06026D58 RID: 159064 RVA: 0x003B399C File Offset: 0x003B1B9C
		protected UTapMessageBoxWidgetStyle(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015516 RID: 87318
		public new const string __ObjectPath = "/Script/TapCommon.TapMessageBoxWidgetStyle";

		// Token: 0x04015517 RID: 87319
		private static IntPtr _ClassPtr;

		// Token: 0x04015518 RID: 87320
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04015519 RID: 87321
		internal static int __PropertyOffset_WidgetStyle;

		// Token: 0x0401551A RID: 87322
		[Nullable(2)]
		private FTapMessageBoxStyle _WidgetStyle;
	}
}
