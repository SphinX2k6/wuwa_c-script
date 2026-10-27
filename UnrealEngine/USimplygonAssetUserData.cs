using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020027D5 RID: 10197
	[UnrealObjectPath("/Script/SimplygonUObjects.SimplygonAssetUserData")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 56)]
	public class USimplygonAssetUserData : UAssetUserData, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060260A1 RID: 155809 RVA: 0x0039B1D1 File Offset: 0x003993D1
		public new static UClassStackOnlyPtr StaticClass()
		{
			return USimplygonAssetUserData._ClassPtr;
		}

		// Token: 0x060260A2 RID: 155810 RVA: 0x0039B1E0 File Offset: 0x003993E0
		public USimplygonAssetUserData() : this(BuiltinUtils.AllocNativeUObject(USimplygonAssetUserData.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060260A3 RID: 155811 RVA: 0x0039B208 File Offset: 0x00399408
		[NullableContext(1)]
		public USimplygonAssetUserData(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(USimplygonAssetUserData.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170092D2 RID: 37586
		// (get) Token: 0x060260A4 RID: 155812 RVA: 0x0039B23B File Offset: 0x0039943B
		// (set) Token: 0x060260A5 RID: 155813 RVA: 0x0039B24B File Offset: 0x0039944B
		public unsafe ESimplygonMetaTagType MetaTag
		{
			get
			{
				return (ESimplygonMetaTagType)(*(base.NativePtr + (IntPtr)USimplygonAssetUserData.__PropertyOffset_MetaTag));
			}
			set
			{
				*(base.NativePtr + (IntPtr)USimplygonAssetUserData.__PropertyOffset_MetaTag) = (byte)value;
			}
		}

		// Token: 0x060260A6 RID: 155814 RVA: 0x0039B25C File Offset: 0x0039945C
		static USimplygonAssetUserData()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/SimplygonUObjects.SimplygonAssetUserData");
		}

		// Token: 0x060260A7 RID: 155815 RVA: 0x0039B26A File Offset: 0x0039946A
		protected USimplygonAssetUserData(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04014C53 RID: 85075
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/SimplygonUObjects.SimplygonAssetUserData";

		// Token: 0x04014C54 RID: 85076
		private static IntPtr _ClassPtr;

		// Token: 0x04014C55 RID: 85077
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04014C56 RID: 85078
		internal static int __PropertyOffset_MetaTag;
	}
}
