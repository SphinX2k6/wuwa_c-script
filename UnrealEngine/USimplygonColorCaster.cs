using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020027D6 RID: 10198
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/SimplygonUObjects.SimplygonColorCaster")]
	[UnrealStructLayout(96, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 96)]
	public class USimplygonColorCaster : USimplygonMaterialCaster, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060260A8 RID: 155816 RVA: 0x0039B273 File Offset: 0x00399473
		public new static UClassStackOnlyPtr StaticClass()
		{
			return USimplygonColorCaster._ClassPtr;
		}

		// Token: 0x060260A9 RID: 155817 RVA: 0x0039B280 File Offset: 0x00399480
		public USimplygonColorCaster() : this(BuiltinUtils.AllocNativeUObject(USimplygonColorCaster.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060260AA RID: 155818 RVA: 0x0039B2A8 File Offset: 0x003994A8
		public USimplygonColorCaster(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(USimplygonColorCaster.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170092D3 RID: 37587
		// (get) Token: 0x060260AB RID: 155819 RVA: 0x0039B2DC File Offset: 0x003994DC
		// (set) Token: 0x060260AC RID: 155820 RVA: 0x0039B315 File Offset: 0x00399515
		public FColorCasterSettings ColorCasterSettings
		{
			get
			{
				base.FastCheckIsValid();
				FColorCasterSettings result;
				if ((result = this._ColorCasterSettings) == null)
				{
					result = (this._ColorCasterSettings = new FColorCasterSettings(base.NativePtr + (IntPtr)USimplygonColorCaster.__PropertyOffset_ColorCasterSettings, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FColorCasterSettings.StaticStruct(), base.NativePtr + (IntPtr)USimplygonColorCaster.__PropertyOffset_ColorCasterSettings, value.NativePtr, 1, false);
			}
		}

		// Token: 0x060260AD RID: 155821 RVA: 0x0039B336 File Offset: 0x00399536
		static USimplygonColorCaster()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/SimplygonUObjects.SimplygonColorCaster");
		}

		// Token: 0x060260AE RID: 155822 RVA: 0x0039B344 File Offset: 0x00399544
		protected USimplygonColorCaster(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04014C57 RID: 85079
		public new const string __ObjectPath = "/Script/SimplygonUObjects.SimplygonColorCaster";

		// Token: 0x04014C58 RID: 85080
		private static IntPtr _ClassPtr;

		// Token: 0x04014C59 RID: 85081
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04014C5A RID: 85082
		internal static int __PropertyOffset_ColorCasterSettings;

		// Token: 0x04014C5B RID: 85083
		[Nullable(2)]
		private FColorCasterSettings _ColorCasterSettings;
	}
}
