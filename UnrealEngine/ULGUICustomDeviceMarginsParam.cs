using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002033 RID: 8243
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.LGUICustomDeviceMarginsParam")]
	[UnrealStructLayout(224, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 224)]
	public class ULGUICustomDeviceMarginsParam : UDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601F2FD RID: 127741 RVA: 0x002E4C64 File Offset: 0x002E2E64
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ULGUICustomDeviceMarginsParam._ClassPtr;
		}

		// Token: 0x0601F2FE RID: 127742 RVA: 0x002E4C70 File Offset: 0x002E2E70
		public ULGUICustomDeviceMarginsParam() : this(BuiltinUtils.AllocNativeUObject(ULGUICustomDeviceMarginsParam.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601F2FF RID: 127743 RVA: 0x002E4C98 File Offset: 0x002E2E98
		public ULGUICustomDeviceMarginsParam(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ULGUICustomDeviceMarginsParam.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007BA9 RID: 31657
		// (get) Token: 0x0601F300 RID: 127744 RVA: 0x002E4CCC File Offset: 0x002E2ECC
		// (set) Token: 0x0601F301 RID: 127745 RVA: 0x002E4D05 File Offset: 0x002E2F05
		public TMap<string, FDeviceMarginSelection> CustomDeviceMargins
		{
			get
			{
				base.FastCheckIsValid();
				TMap<string, FDeviceMarginSelection> result;
				if ((result = this._CustomDeviceMargins) == null)
				{
					result = (this._CustomDeviceMargins = new TMap<string, FDeviceMarginSelection>(base.NativePtr + (IntPtr)ULGUICustomDeviceMarginsParam.__PropertyOffset_CustomDeviceMargins, this));
				}
				return result;
			}
			set
			{
				this.CustomDeviceMargins.CopyAssign(value);
			}
		}

		// Token: 0x17007BAA RID: 31658
		// (get) Token: 0x0601F302 RID: 127746 RVA: 0x002E4D14 File Offset: 0x002E2F14
		// (set) Token: 0x0601F303 RID: 127747 RVA: 0x002E4D4D File Offset: 0x002E2F4D
		public TMap<FName, FMargin> DeviceMarginsOpthions
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FName, FMargin> result;
				if ((result = this._DeviceMarginsOpthions) == null)
				{
					result = (this._DeviceMarginsOpthions = new TMap<FName, FMargin>(base.NativePtr + (IntPtr)ULGUICustomDeviceMarginsParam.__PropertyOffset_DeviceMarginsOpthions, this));
				}
				return result;
			}
			set
			{
				this.DeviceMarginsOpthions.CopyAssign(value);
			}
		}

		// Token: 0x0601F304 RID: 127748 RVA: 0x002E4D5B File Offset: 0x002E2F5B
		public TArray<string> GetMarginOptionNames()
		{
			return new TArray<string>(ULGUICustomDeviceMarginsParam.__GetMarginOptionNames_Internal(base.NativePtr), null);
		}

		// Token: 0x0601F305 RID: 127749
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetMarginOptionNames_Internal(IntPtr @this);

		// Token: 0x0601F306 RID: 127750 RVA: 0x002E4D6E File Offset: 0x002E2F6E
		static ULGUICustomDeviceMarginsParam()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.LGUICustomDeviceMarginsParam");
		}

		// Token: 0x0601F307 RID: 127751 RVA: 0x002E4D7C File Offset: 0x002E2F7C
		protected ULGUICustomDeviceMarginsParam(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010E17 RID: 69143
		public new const string __ObjectPath = "/Script/LGUI.LGUICustomDeviceMarginsParam";

		// Token: 0x04010E18 RID: 69144
		private static IntPtr _ClassPtr;

		// Token: 0x04010E19 RID: 69145
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010E1A RID: 69146
		internal static int __PropertyOffset_CustomDeviceMargins;

		// Token: 0x04010E1B RID: 69147
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TMap<string, FDeviceMarginSelection> _CustomDeviceMargins;

		// Token: 0x04010E1C RID: 69148
		internal static int __PropertyOffset_DeviceMarginsOpthions;

		// Token: 0x04010E1D RID: 69149
		[Nullable(2)]
		private TMap<FName, FMargin> _DeviceMarginsOpthions;
	}
}
