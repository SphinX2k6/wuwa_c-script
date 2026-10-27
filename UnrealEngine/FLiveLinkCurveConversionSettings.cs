using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020021FD RID: 8701
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LiveLinkInterface.LiveLinkCurveConversionSettings")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 80)]
	public class FLiveLinkCurveConversionSettings : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06021294 RID: 135828 RVA: 0x0030E55D File Offset: 0x0030C75D
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FLiveLinkCurveConversionSettings._ScriptStructPtr != 0) ? FLiveLinkCurveConversionSettings._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/LiveLinkInterface.LiveLinkCurveConversionSettings", ref FLiveLinkCurveConversionSettings._ScriptStructPtr);
		}

		// Token: 0x17008178 RID: 33144
		// (get) Token: 0x06021295 RID: 135829 RVA: 0x0030E584 File Offset: 0x0030C784
		// (set) Token: 0x06021296 RID: 135830 RVA: 0x0030E5C7 File Offset: 0x0030C7C7
		public TMap<string, FSoftObjectPath> CurveConversionAssetMap
		{
			get
			{
				base.FastCheckIsValid();
				TMap<string, FSoftObjectPath> result;
				if ((result = this._CurveConversionAssetMap) == null)
				{
					result = (this._CurveConversionAssetMap = new TMap<string, FSoftObjectPath>(base.NativePtr + (IntPtr)FLiveLinkCurveConversionSettings.__PropertyOffset_CurveConversionAssetMap, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.CurveConversionAssetMap.CopyAssign(value);
			}
		}

		// Token: 0x06021297 RID: 135831 RVA: 0x0030E5D5 File Offset: 0x0030C7D5
		public FLiveLinkCurveConversionSettings()
		{
		}

		// Token: 0x06021298 RID: 135832 RVA: 0x0030E5DD File Offset: 0x0030C7DD
		public FLiveLinkCurveConversionSettings(TMap<string, FSoftObjectPath> CurveConversionAssetMap)
		{
			this.CurveConversionAssetMap = CurveConversionAssetMap;
		}

		// Token: 0x06021299 RID: 135833 RVA: 0x0030E5EC File Offset: 0x0030C7EC
		protected override IntPtr GetUStructPtr()
		{
			return FLiveLinkCurveConversionSettings.StaticStruct();
		}

		// Token: 0x0602129A RID: 135834 RVA: 0x0030E5F8 File Offset: 0x0030C7F8
		[NullableContext(2)]
		public FLiveLinkCurveConversionSettings(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602129B RID: 135835 RVA: 0x0030E602 File Offset: 0x0030C802
		public FLiveLinkCurveConversionSettings(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602129C RID: 135836 RVA: 0x0030E60D File Offset: 0x0030C80D
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FLiveLinkCurveConversionSettings(Pointer, false, true);
		}

		// Token: 0x0602129D RID: 135837 RVA: 0x0030E617 File Offset: 0x0030C817
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FLiveLinkCurveConversionSettings(Pointer, MemoryOwner);
		}

		// Token: 0x04011B19 RID: 72473
		public const string __ObjectPath = "/Script/LiveLinkInterface.LiveLinkCurveConversionSettings";

		// Token: 0x04011B1A RID: 72474
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04011B1B RID: 72475
		internal static int __PropertyOffset_CurveConversionAssetMap;

		// Token: 0x04011B1C RID: 72476
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TMap<string, FSoftObjectPath> _CurveConversionAssetMap;
	}
}
