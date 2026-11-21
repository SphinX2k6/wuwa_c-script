using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020004D6 RID: 1238
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroPDCloudPrefab")]
	[UnrealStructLayout(440, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 440)]
	public class UKuroPDCloudPrefab : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060073A1 RID: 29601 RVA: 0x000A9868 File Offset: 0x000A7A68
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroPDCloudPrefab._ClassPtr;
		}

		// Token: 0x060073A2 RID: 29602 RVA: 0x000A9874 File Offset: 0x000A7A74
		public UKuroPDCloudPrefab() : this(BuiltinUtils.AllocNativeUObject(UKuroPDCloudPrefab.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060073A3 RID: 29603 RVA: 0x000A989C File Offset: 0x000A7A9C
		[NullableContext(1)]
		public UKuroPDCloudPrefab(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroPDCloudPrefab.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060073A4 RID: 29604 RVA: 0x000A98CF File Offset: 0x000A7ACF
		static UKuroPDCloudPrefab()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroPDCloudPrefab");
		}

		// Token: 0x060073A5 RID: 29605 RVA: 0x000A98DD File Offset: 0x000A7ADD
		protected UKuroPDCloudPrefab(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400318D RID: 12685
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroPDCloudPrefab";

		// Token: 0x0400318E RID: 12686
		private static IntPtr _ClassPtr;

		// Token: 0x0400318F RID: 12687
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
