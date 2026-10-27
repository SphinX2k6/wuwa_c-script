using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020019ED RID: 6637
	[UnrealObjectPath("/Script/KuroNavMeshCookData.NavMeshEdgesComponent")]
	[UnrealStructLayout(296, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 296)]
	public class UNavMeshEdgesComponent : UActorComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060189DA RID: 100826 RVA: 0x0024456E File Offset: 0x0024276E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UNavMeshEdgesComponent._ClassPtr;
		}

		// Token: 0x060189DB RID: 100827 RVA: 0x0024457C File Offset: 0x0024277C
		public UNavMeshEdgesComponent() : this(BuiltinUtils.AllocNativeUObject(UNavMeshEdgesComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060189DC RID: 100828 RVA: 0x002445A4 File Offset: 0x002427A4
		[NullableContext(1)]
		public UNavMeshEdgesComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UNavMeshEdgesComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170061FB RID: 25083
		// (get) Token: 0x060189DD RID: 100829 RVA: 0x002445D7 File Offset: 0x002427D7
		// (set) Token: 0x060189DE RID: 100830 RVA: 0x002445E7 File Offset: 0x002427E7
		public unsafe float TileSizeUU
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNavMeshEdgesComponent.__PropertyOffset_TileSizeUU);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNavMeshEdgesComponent.__PropertyOffset_TileSizeUU) = value;
			}
		}

		// Token: 0x170061FC RID: 25084
		// (get) Token: 0x060189DF RID: 100831 RVA: 0x002445F8 File Offset: 0x002427F8
		// (set) Token: 0x060189E0 RID: 100832 RVA: 0x0024460C File Offset: 0x0024280C
		public unsafe FVector NavMeshOrig
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNavMeshEdgesComponent.__PropertyOffset_NavMeshOrig);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNavMeshEdgesComponent.__PropertyOffset_NavMeshOrig) = value;
			}
		}

		// Token: 0x060189E1 RID: 100833 RVA: 0x00244621 File Offset: 0x00242821
		static UNavMeshEdgesComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroNavMeshCookData.NavMeshEdgesComponent");
		}

		// Token: 0x060189E2 RID: 100834 RVA: 0x0024462F File Offset: 0x0024282F
		protected UNavMeshEdgesComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400D4E0 RID: 54496
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroNavMeshCookData.NavMeshEdgesComponent";

		// Token: 0x0400D4E1 RID: 54497
		private static IntPtr _ClassPtr;

		// Token: 0x0400D4E2 RID: 54498
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400D4E3 RID: 54499
		internal static int __PropertyOffset_TileSizeUU;

		// Token: 0x0400D4E4 RID: 54500
		internal static int __PropertyOffset_NavMeshOrig;
	}
}
