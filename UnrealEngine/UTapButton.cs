using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020028DD RID: 10461
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/TapCommon.TapButton")]
	[UnrealStructLayout(720, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 720)]
	public class UTapButton : UContentWidget, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06026CEE RID: 158958 RVA: 0x003B2EFD File Offset: 0x003B10FD
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UTapButton._ClassPtr;
		}

		// Token: 0x06026CEF RID: 158959 RVA: 0x003B2F0C File Offset: 0x003B110C
		public UTapButton() : this(BuiltinUtils.AllocNativeUObject(UTapButton.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06026CF0 RID: 158960 RVA: 0x003B2F34 File Offset: 0x003B1134
		public UTapButton(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UTapButton.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17009582 RID: 38274
		// (get) Token: 0x06026CF1 RID: 158961 RVA: 0x003B2F67 File Offset: 0x003B1167
		// (set) Token: 0x06026CF2 RID: 158962 RVA: 0x003B2F77 File Offset: 0x003B1177
		public unsafe ETapButtonStyleType StyleType
		{
			get
			{
				return (ETapButtonStyleType)(*(base.NativePtr + (IntPtr)UTapButton.__PropertyOffset_StyleType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTapButton.__PropertyOffset_StyleType) = (byte)value;
			}
		}

		// Token: 0x17009583 RID: 38275
		// (get) Token: 0x06026CF3 RID: 158963 RVA: 0x003B2F88 File Offset: 0x003B1188
		// (set) Token: 0x06026CF4 RID: 158964 RVA: 0x003B2FC1 File Offset: 0x003B11C1
		public FOnButtonClickedEvent OnClicked
		{
			get
			{
				base.FastCheckIsValid();
				FOnButtonClickedEvent result;
				if ((result = this._OnClicked) == null)
				{
					result = (this._OnClicked = new FOnButtonClickedEvent(base.NativePtr + (IntPtr)UTapButton.__PropertyOffset_OnClicked, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UTapButton.__PropertyOffset_OnClicked, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x06026CF5 RID: 158965 RVA: 0x003B2FE2 File Offset: 0x003B11E2
		static UTapButton()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/TapCommon.TapButton");
		}

		// Token: 0x06026CF6 RID: 158966 RVA: 0x003B2FF0 File Offset: 0x003B11F0
		protected UTapButton(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040154E7 RID: 87271
		public new const string __ObjectPath = "/Script/TapCommon.TapButton";

		// Token: 0x040154E8 RID: 87272
		private static IntPtr _ClassPtr;

		// Token: 0x040154E9 RID: 87273
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040154EA RID: 87274
		internal static int __PropertyOffset_StyleType;

		// Token: 0x040154EB RID: 87275
		internal static int __PropertyOffset_OnClicked;

		// Token: 0x040154EC RID: 87276
		[Nullable(2)]
		private FOnButtonClickedEvent _OnClicked;
	}
}
