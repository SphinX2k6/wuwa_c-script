using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020028EA RID: 10474
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/TapCommon.TapThrobberWidgetStyle")]
	[UnrealStructLayout(2496, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2496)]
	public class UTapThrobberWidgetStyle : USlateWidgetStyleContainerBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06026D9E RID: 159134 RVA: 0x003B4144 File Offset: 0x003B2344
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UTapThrobberWidgetStyle._ClassPtr;
		}

		// Token: 0x06026D9F RID: 159135 RVA: 0x003B4150 File Offset: 0x003B2350
		public UTapThrobberWidgetStyle() : this(BuiltinUtils.AllocNativeUObject(UTapThrobberWidgetStyle.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06026DA0 RID: 159136 RVA: 0x003B4178 File Offset: 0x003B2378
		public UTapThrobberWidgetStyle(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UTapThrobberWidgetStyle.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170095AA RID: 38314
		// (get) Token: 0x06026DA1 RID: 159137 RVA: 0x003B41AC File Offset: 0x003B23AC
		// (set) Token: 0x06026DA2 RID: 159138 RVA: 0x003B41E5 File Offset: 0x003B23E5
		public FTapThrobberStyle WidgetStyle
		{
			get
			{
				base.FastCheckIsValid();
				FTapThrobberStyle result;
				if ((result = this._WidgetStyle) == null)
				{
					result = (this._WidgetStyle = new FTapThrobberStyle(base.NativePtr + (IntPtr)UTapThrobberWidgetStyle.__PropertyOffset_WidgetStyle, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FTapThrobberStyle.StaticStruct(), base.NativePtr + (IntPtr)UTapThrobberWidgetStyle.__PropertyOffset_WidgetStyle, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06026DA3 RID: 159139 RVA: 0x003B4206 File Offset: 0x003B2406
		static UTapThrobberWidgetStyle()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/TapCommon.TapThrobberWidgetStyle");
		}

		// Token: 0x06026DA4 RID: 159140 RVA: 0x003B4214 File Offset: 0x003B2414
		protected UTapThrobberWidgetStyle(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015542 RID: 87362
		public new const string __ObjectPath = "/Script/TapCommon.TapThrobberWidgetStyle";

		// Token: 0x04015543 RID: 87363
		private static IntPtr _ClassPtr;

		// Token: 0x04015544 RID: 87364
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04015545 RID: 87365
		internal static int __PropertyOffset_WidgetStyle;

		// Token: 0x04015546 RID: 87366
		[Nullable(2)]
		private FTapThrobberStyle _WidgetStyle;
	}
}
