using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020027DB RID: 10203
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/SimplygonUObjects.SimplygonNormalCaster")]
	[UnrealStructLayout(96, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 96)]
	public class USimplygonNormalCaster : USimplygonMaterialCaster, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060260C8 RID: 155848 RVA: 0x0039B62D File Offset: 0x0039982D
		public new static UClassStackOnlyPtr StaticClass()
		{
			return USimplygonNormalCaster._ClassPtr;
		}

		// Token: 0x060260C9 RID: 155849 RVA: 0x0039B63C File Offset: 0x0039983C
		public USimplygonNormalCaster() : this(BuiltinUtils.AllocNativeUObject(USimplygonNormalCaster.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060260CA RID: 155850 RVA: 0x0039B664 File Offset: 0x00399864
		public USimplygonNormalCaster(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(USimplygonNormalCaster.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170092D7 RID: 37591
		// (get) Token: 0x060260CB RID: 155851 RVA: 0x0039B698 File Offset: 0x00399898
		// (set) Token: 0x060260CC RID: 155852 RVA: 0x0039B6D1 File Offset: 0x003998D1
		public FNormalCasterSettings NormalCasterSettings
		{
			get
			{
				base.FastCheckIsValid();
				FNormalCasterSettings result;
				if ((result = this._NormalCasterSettings) == null)
				{
					result = (this._NormalCasterSettings = new FNormalCasterSettings(base.NativePtr + (IntPtr)USimplygonNormalCaster.__PropertyOffset_NormalCasterSettings, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FNormalCasterSettings.StaticStruct(), base.NativePtr + (IntPtr)USimplygonNormalCaster.__PropertyOffset_NormalCasterSettings, value.NativePtr, 1, false);
			}
		}

		// Token: 0x060260CD RID: 155853 RVA: 0x0039B6F2 File Offset: 0x003998F2
		static USimplygonNormalCaster()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/SimplygonUObjects.SimplygonNormalCaster");
		}

		// Token: 0x060260CE RID: 155854 RVA: 0x0039B700 File Offset: 0x00399900
		protected USimplygonNormalCaster(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04014C6E RID: 85102
		public new const string __ObjectPath = "/Script/SimplygonUObjects.SimplygonNormalCaster";

		// Token: 0x04014C6F RID: 85103
		private static IntPtr _ClassPtr;

		// Token: 0x04014C70 RID: 85104
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04014C71 RID: 85105
		internal static int __PropertyOffset_NormalCasterSettings;

		// Token: 0x04014C72 RID: 85106
		[Nullable(2)]
		private FNormalCasterSettings _NormalCasterSettings;
	}
}
