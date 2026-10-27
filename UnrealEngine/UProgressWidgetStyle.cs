using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200285A RID: 10330
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Slate.ProgressWidgetStyle")]
	[UnrealStructLayout(704, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 704)]
	public class UProgressWidgetStyle : USlateWidgetStyleContainerBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06026513 RID: 156947 RVA: 0x003A3455 File Offset: 0x003A1655
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UProgressWidgetStyle._ClassPtr;
		}

		// Token: 0x06026514 RID: 156948 RVA: 0x003A3464 File Offset: 0x003A1664
		public UProgressWidgetStyle() : this(BuiltinUtils.AllocNativeUObject(UProgressWidgetStyle.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06026515 RID: 156949 RVA: 0x003A348C File Offset: 0x003A168C
		public UProgressWidgetStyle(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UProgressWidgetStyle.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170093EF RID: 37871
		// (get) Token: 0x06026516 RID: 156950 RVA: 0x003A34C0 File Offset: 0x003A16C0
		// (set) Token: 0x06026517 RID: 156951 RVA: 0x003A34F9 File Offset: 0x003A16F9
		public FProgressBarStyle ProgressBarStyle
		{
			get
			{
				base.FastCheckIsValid();
				FProgressBarStyle result;
				if ((result = this._ProgressBarStyle) == null)
				{
					result = (this._ProgressBarStyle = new FProgressBarStyle(base.NativePtr + (IntPtr)UProgressWidgetStyle.__PropertyOffset_ProgressBarStyle, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FProgressBarStyle.StaticStruct(), base.NativePtr + (IntPtr)UProgressWidgetStyle.__PropertyOffset_ProgressBarStyle, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06026518 RID: 156952 RVA: 0x003A351A File Offset: 0x003A171A
		static UProgressWidgetStyle()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Slate.ProgressWidgetStyle");
		}

		// Token: 0x06026519 RID: 156953 RVA: 0x003A3528 File Offset: 0x003A1728
		protected UProgressWidgetStyle(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401501D RID: 86045
		public new const string __ObjectPath = "/Script/Slate.ProgressWidgetStyle";

		// Token: 0x0401501E RID: 86046
		private static IntPtr _ClassPtr;

		// Token: 0x0401501F RID: 86047
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04015020 RID: 86048
		internal static int __PropertyOffset_ProgressBarStyle;

		// Token: 0x04015021 RID: 86049
		[Nullable(2)]
		private FProgressBarStyle _ProgressBarStyle;
	}
}
