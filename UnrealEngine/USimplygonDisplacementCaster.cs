using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020027D8 RID: 10200
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/SimplygonUObjects.SimplygonDisplacementCaster")]
	[UnrealStructLayout(104, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 104)]
	public class USimplygonDisplacementCaster : USimplygonMaterialCaster, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060260B6 RID: 155830 RVA: 0x0039B429 File Offset: 0x00399629
		public new static UClassStackOnlyPtr StaticClass()
		{
			return USimplygonDisplacementCaster._ClassPtr;
		}

		// Token: 0x060260B7 RID: 155831 RVA: 0x0039B438 File Offset: 0x00399638
		public USimplygonDisplacementCaster() : this(BuiltinUtils.AllocNativeUObject(USimplygonDisplacementCaster.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060260B8 RID: 155832 RVA: 0x0039B460 File Offset: 0x00399660
		public USimplygonDisplacementCaster(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(USimplygonDisplacementCaster.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170092D5 RID: 37589
		// (get) Token: 0x060260B9 RID: 155833 RVA: 0x0039B494 File Offset: 0x00399694
		// (set) Token: 0x060260BA RID: 155834 RVA: 0x0039B4CD File Offset: 0x003996CD
		public FDisplacementCasterSettings DisplacementCasterSettings
		{
			get
			{
				base.FastCheckIsValid();
				FDisplacementCasterSettings result;
				if ((result = this._DisplacementCasterSettings) == null)
				{
					result = (this._DisplacementCasterSettings = new FDisplacementCasterSettings(base.NativePtr + (IntPtr)USimplygonDisplacementCaster.__PropertyOffset_DisplacementCasterSettings, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FDisplacementCasterSettings.StaticStruct(), base.NativePtr + (IntPtr)USimplygonDisplacementCaster.__PropertyOffset_DisplacementCasterSettings, value.NativePtr, 1, false);
			}
		}

		// Token: 0x060260BB RID: 155835 RVA: 0x0039B4EE File Offset: 0x003996EE
		static USimplygonDisplacementCaster()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/SimplygonUObjects.SimplygonDisplacementCaster");
		}

		// Token: 0x060260BC RID: 155836 RVA: 0x0039B4FC File Offset: 0x003996FC
		protected USimplygonDisplacementCaster(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04014C61 RID: 85089
		public new const string __ObjectPath = "/Script/SimplygonUObjects.SimplygonDisplacementCaster";

		// Token: 0x04014C62 RID: 85090
		private static IntPtr _ClassPtr;

		// Token: 0x04014C63 RID: 85091
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04014C64 RID: 85092
		internal static int __PropertyOffset_DisplacementCasterSettings;

		// Token: 0x04014C65 RID: 85093
		[Nullable(2)]
		private FDisplacementCasterSettings _DisplacementCasterSettings;
	}
}
