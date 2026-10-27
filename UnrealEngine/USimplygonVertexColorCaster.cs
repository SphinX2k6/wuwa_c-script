using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020027DF RID: 10207
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/SimplygonUObjects.SimplygonVertexColorCaster")]
	[UnrealStructLayout(120, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 120)]
	public class USimplygonVertexColorCaster : USimplygonMaterialCaster, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060260E3 RID: 155875 RVA: 0x0039B8B1 File Offset: 0x00399AB1
		public new static UClassStackOnlyPtr StaticClass()
		{
			return USimplygonVertexColorCaster._ClassPtr;
		}

		// Token: 0x060260E4 RID: 155876 RVA: 0x0039B8C0 File Offset: 0x00399AC0
		public USimplygonVertexColorCaster() : this(BuiltinUtils.AllocNativeUObject(USimplygonVertexColorCaster.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060260E5 RID: 155877 RVA: 0x0039B8E8 File Offset: 0x00399AE8
		public USimplygonVertexColorCaster(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(USimplygonVertexColorCaster.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170092DA RID: 37594
		// (get) Token: 0x060260E6 RID: 155878 RVA: 0x0039B91C File Offset: 0x00399B1C
		// (set) Token: 0x060260E7 RID: 155879 RVA: 0x0039B955 File Offset: 0x00399B55
		public FVertexColorCasterSettings VertexColorCasterSettings
		{
			get
			{
				base.FastCheckIsValid();
				FVertexColorCasterSettings result;
				if ((result = this._VertexColorCasterSettings) == null)
				{
					result = (this._VertexColorCasterSettings = new FVertexColorCasterSettings(base.NativePtr + (IntPtr)USimplygonVertexColorCaster.__PropertyOffset_VertexColorCasterSettings, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FVertexColorCasterSettings.StaticStruct(), base.NativePtr + (IntPtr)USimplygonVertexColorCaster.__PropertyOffset_VertexColorCasterSettings, value.NativePtr, 1, false);
			}
		}

		// Token: 0x060260E8 RID: 155880 RVA: 0x0039B976 File Offset: 0x00399B76
		static USimplygonVertexColorCaster()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/SimplygonUObjects.SimplygonVertexColorCaster");
		}

		// Token: 0x060260E9 RID: 155881 RVA: 0x0039B984 File Offset: 0x00399B84
		protected USimplygonVertexColorCaster(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04014C7E RID: 85118
		public new const string __ObjectPath = "/Script/SimplygonUObjects.SimplygonVertexColorCaster";

		// Token: 0x04014C7F RID: 85119
		private static IntPtr _ClassPtr;

		// Token: 0x04014C80 RID: 85120
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04014C81 RID: 85121
		internal static int __PropertyOffset_VertexColorCasterSettings;

		// Token: 0x04014C82 RID: 85122
		[Nullable(2)]
		private FVertexColorCasterSettings _VertexColorCasterSettings;
	}
}
