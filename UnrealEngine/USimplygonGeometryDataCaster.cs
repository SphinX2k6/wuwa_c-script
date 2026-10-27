using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020027D9 RID: 10201
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/SimplygonUObjects.SimplygonGeometryDataCaster")]
	[UnrealStructLayout(144, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 144)]
	public class USimplygonGeometryDataCaster : USimplygonMaterialCaster, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060260BD RID: 155837 RVA: 0x0039B505 File Offset: 0x00399705
		public new static UClassStackOnlyPtr StaticClass()
		{
			return USimplygonGeometryDataCaster._ClassPtr;
		}

		// Token: 0x060260BE RID: 155838 RVA: 0x0039B514 File Offset: 0x00399714
		public USimplygonGeometryDataCaster() : this(BuiltinUtils.AllocNativeUObject(USimplygonGeometryDataCaster.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060260BF RID: 155839 RVA: 0x0039B53C File Offset: 0x0039973C
		public USimplygonGeometryDataCaster(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(USimplygonGeometryDataCaster.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170092D6 RID: 37590
		// (get) Token: 0x060260C0 RID: 155840 RVA: 0x0039B570 File Offset: 0x00399770
		// (set) Token: 0x060260C1 RID: 155841 RVA: 0x0039B5A9 File Offset: 0x003997A9
		public FGeometryDataCasterSettings GeometryDataCasterSettings
		{
			get
			{
				base.FastCheckIsValid();
				FGeometryDataCasterSettings result;
				if ((result = this._GeometryDataCasterSettings) == null)
				{
					result = (this._GeometryDataCasterSettings = new FGeometryDataCasterSettings(base.NativePtr + (IntPtr)USimplygonGeometryDataCaster.__PropertyOffset_GeometryDataCasterSettings, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGeometryDataCasterSettings.StaticStruct(), base.NativePtr + (IntPtr)USimplygonGeometryDataCaster.__PropertyOffset_GeometryDataCasterSettings, value.NativePtr, 1, false);
			}
		}

		// Token: 0x060260C2 RID: 155842 RVA: 0x0039B5CA File Offset: 0x003997CA
		static USimplygonGeometryDataCaster()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/SimplygonUObjects.SimplygonGeometryDataCaster");
		}

		// Token: 0x060260C3 RID: 155843 RVA: 0x0039B5D8 File Offset: 0x003997D8
		protected USimplygonGeometryDataCaster(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04014C66 RID: 85094
		public new const string __ObjectPath = "/Script/SimplygonUObjects.SimplygonGeometryDataCaster";

		// Token: 0x04014C67 RID: 85095
		private static IntPtr _ClassPtr;

		// Token: 0x04014C68 RID: 85096
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04014C69 RID: 85097
		internal static int __PropertyOffset_GeometryDataCasterSettings;

		// Token: 0x04014C6A RID: 85098
		[Nullable(2)]
		private FGeometryDataCasterSettings _GeometryDataCasterSettings;
	}
}
