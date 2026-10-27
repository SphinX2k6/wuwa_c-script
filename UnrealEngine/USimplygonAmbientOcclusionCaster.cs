using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020027D4 RID: 10196
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/SimplygonUObjects.SimplygonAmbientOcclusionCaster")]
	[UnrealStructLayout(112, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 112)]
	public class USimplygonAmbientOcclusionCaster : USimplygonMaterialCaster, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602609A RID: 155802 RVA: 0x0039B0F6 File Offset: 0x003992F6
		public new static UClassStackOnlyPtr StaticClass()
		{
			return USimplygonAmbientOcclusionCaster._ClassPtr;
		}

		// Token: 0x0602609B RID: 155803 RVA: 0x0039B104 File Offset: 0x00399304
		public USimplygonAmbientOcclusionCaster() : this(BuiltinUtils.AllocNativeUObject(USimplygonAmbientOcclusionCaster.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602609C RID: 155804 RVA: 0x0039B12C File Offset: 0x0039932C
		public USimplygonAmbientOcclusionCaster(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(USimplygonAmbientOcclusionCaster.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170092D1 RID: 37585
		// (get) Token: 0x0602609D RID: 155805 RVA: 0x0039B160 File Offset: 0x00399360
		// (set) Token: 0x0602609E RID: 155806 RVA: 0x0039B199 File Offset: 0x00399399
		public FAmbientOcclusionCasterSettings AmbientOcclusionCasterSettings
		{
			get
			{
				base.FastCheckIsValid();
				FAmbientOcclusionCasterSettings result;
				if ((result = this._AmbientOcclusionCasterSettings) == null)
				{
					result = (this._AmbientOcclusionCasterSettings = new FAmbientOcclusionCasterSettings(base.NativePtr + (IntPtr)USimplygonAmbientOcclusionCaster.__PropertyOffset_AmbientOcclusionCasterSettings, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FAmbientOcclusionCasterSettings.StaticStruct(), base.NativePtr + (IntPtr)USimplygonAmbientOcclusionCaster.__PropertyOffset_AmbientOcclusionCasterSettings, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0602609F RID: 155807 RVA: 0x0039B1BA File Offset: 0x003993BA
		static USimplygonAmbientOcclusionCaster()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/SimplygonUObjects.SimplygonAmbientOcclusionCaster");
		}

		// Token: 0x060260A0 RID: 155808 RVA: 0x0039B1C8 File Offset: 0x003993C8
		protected USimplygonAmbientOcclusionCaster(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04014C4E RID: 85070
		public new const string __ObjectPath = "/Script/SimplygonUObjects.SimplygonAmbientOcclusionCaster";

		// Token: 0x04014C4F RID: 85071
		private static IntPtr _ClassPtr;

		// Token: 0x04014C50 RID: 85072
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04014C51 RID: 85073
		internal static int __PropertyOffset_AmbientOcclusionCasterSettings;

		// Token: 0x04014C52 RID: 85074
		[Nullable(2)]
		private FAmbientOcclusionCasterSettings _AmbientOcclusionCasterSettings;
	}
}
