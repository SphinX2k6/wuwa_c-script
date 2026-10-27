using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001B8A RID: 7050
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroPDFloatingBillboardCloudPrefab")]
	[UnrealStructLayout(112, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 112)]
	public class UKuroPDFloatingBillboardCloudPrefab : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601AC0B RID: 109579 RVA: 0x00276CC9 File Offset: 0x00274EC9
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroPDFloatingBillboardCloudPrefab._ClassPtr;
		}

		// Token: 0x0601AC0C RID: 109580 RVA: 0x00276CD8 File Offset: 0x00274ED8
		public UKuroPDFloatingBillboardCloudPrefab() : this(BuiltinUtils.AllocNativeUObject(UKuroPDFloatingBillboardCloudPrefab.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601AC0D RID: 109581 RVA: 0x00276D00 File Offset: 0x00274F00
		public UKuroPDFloatingBillboardCloudPrefab(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroPDFloatingBillboardCloudPrefab.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006B9F RID: 27551
		// (get) Token: 0x0601AC0E RID: 109582 RVA: 0x00276D34 File Offset: 0x00274F34
		// (set) Token: 0x0601AC0F RID: 109583 RVA: 0x00276D6D File Offset: 0x00274F6D
		public FFloatingBillboardCloudParameters FloatingBillboardCloudParameters
		{
			get
			{
				base.FastCheckIsValid();
				FFloatingBillboardCloudParameters result;
				if ((result = this._FloatingBillboardCloudParameters) == null)
				{
					result = (this._FloatingBillboardCloudParameters = new FFloatingBillboardCloudParameters(base.NativePtr + (IntPtr)UKuroPDFloatingBillboardCloudPrefab.__PropertyOffset_FloatingBillboardCloudParameters, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FFloatingBillboardCloudParameters.StaticStruct(), base.NativePtr + (IntPtr)UKuroPDFloatingBillboardCloudPrefab.__PropertyOffset_FloatingBillboardCloudParameters, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0601AC10 RID: 109584 RVA: 0x00276D8E File Offset: 0x00274F8E
		static UKuroPDFloatingBillboardCloudPrefab()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroPDFloatingBillboardCloudPrefab");
		}

		// Token: 0x0601AC11 RID: 109585 RVA: 0x00276D9C File Offset: 0x00274F9C
		protected UKuroPDFloatingBillboardCloudPrefab(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400E795 RID: 59285
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroPDFloatingBillboardCloudPrefab";

		// Token: 0x0400E796 RID: 59286
		private static IntPtr _ClassPtr;

		// Token: 0x0400E797 RID: 59287
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400E798 RID: 59288
		internal static int __PropertyOffset_FloatingBillboardCloudParameters;

		// Token: 0x0400E799 RID: 59289
		[Nullable(2)]
		private FFloatingBillboardCloudParameters _FloatingBillboardCloudParameters;
	}
}
