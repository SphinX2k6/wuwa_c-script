using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020027DC RID: 10204
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/SimplygonUObjects.SimplygonOpacityCaster")]
	[UnrealStructLayout(96, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 96)]
	public class USimplygonOpacityCaster : USimplygonMaterialCaster, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060260CF RID: 155855 RVA: 0x0039B709 File Offset: 0x00399909
		public new static UClassStackOnlyPtr StaticClass()
		{
			return USimplygonOpacityCaster._ClassPtr;
		}

		// Token: 0x060260D0 RID: 155856 RVA: 0x0039B718 File Offset: 0x00399918
		public USimplygonOpacityCaster() : this(BuiltinUtils.AllocNativeUObject(USimplygonOpacityCaster.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060260D1 RID: 155857 RVA: 0x0039B740 File Offset: 0x00399940
		public USimplygonOpacityCaster(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(USimplygonOpacityCaster.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170092D8 RID: 37592
		// (get) Token: 0x060260D2 RID: 155858 RVA: 0x0039B774 File Offset: 0x00399974
		// (set) Token: 0x060260D3 RID: 155859 RVA: 0x0039B7AD File Offset: 0x003999AD
		public FOpacityCasterSettings OpacityCasterSettings
		{
			get
			{
				base.FastCheckIsValid();
				FOpacityCasterSettings result;
				if ((result = this._OpacityCasterSettings) == null)
				{
					result = (this._OpacityCasterSettings = new FOpacityCasterSettings(base.NativePtr + (IntPtr)USimplygonOpacityCaster.__PropertyOffset_OpacityCasterSettings, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FOpacityCasterSettings.StaticStruct(), base.NativePtr + (IntPtr)USimplygonOpacityCaster.__PropertyOffset_OpacityCasterSettings, value.NativePtr, 1, false);
			}
		}

		// Token: 0x060260D4 RID: 155860 RVA: 0x0039B7CE File Offset: 0x003999CE
		static USimplygonOpacityCaster()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/SimplygonUObjects.SimplygonOpacityCaster");
		}

		// Token: 0x060260D5 RID: 155861 RVA: 0x0039B7DC File Offset: 0x003999DC
		protected USimplygonOpacityCaster(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04014C73 RID: 85107
		public new const string __ObjectPath = "/Script/SimplygonUObjects.SimplygonOpacityCaster";

		// Token: 0x04014C74 RID: 85108
		private static IntPtr _ClassPtr;

		// Token: 0x04014C75 RID: 85109
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04014C76 RID: 85110
		internal static int __PropertyOffset_OpacityCasterSettings;

		// Token: 0x04014C77 RID: 85111
		[Nullable(2)]
		private FOpacityCasterSettings _OpacityCasterSettings;
	}
}
