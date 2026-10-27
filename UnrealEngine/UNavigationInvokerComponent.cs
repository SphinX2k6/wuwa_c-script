using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002491 RID: 9361
	[UnrealObjectPath("/Script/NavigationSystem.NavigationInvokerComponent")]
	[UnrealStructLayout(208, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 208)]
	public class UNavigationInvokerComponent : UActorComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06023023 RID: 143395 RVA: 0x0033C37B File Offset: 0x0033A57B
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UNavigationInvokerComponent._ClassPtr;
		}

		// Token: 0x06023024 RID: 143396 RVA: 0x0033C388 File Offset: 0x0033A588
		public UNavigationInvokerComponent() : this(BuiltinUtils.AllocNativeUObject(UNavigationInvokerComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06023025 RID: 143397 RVA: 0x0033C3B0 File Offset: 0x0033A5B0
		[NullableContext(1)]
		public UNavigationInvokerComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UNavigationInvokerComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17008680 RID: 34432
		// (get) Token: 0x06023026 RID: 143398 RVA: 0x0033C3E3 File Offset: 0x0033A5E3
		// (set) Token: 0x06023027 RID: 143399 RVA: 0x0033C3F3 File Offset: 0x0033A5F3
		public unsafe float TileGenerationRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNavigationInvokerComponent.__PropertyOffset_TileGenerationRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNavigationInvokerComponent.__PropertyOffset_TileGenerationRadius) = value;
			}
		}

		// Token: 0x17008681 RID: 34433
		// (get) Token: 0x06023028 RID: 143400 RVA: 0x0033C404 File Offset: 0x0033A604
		// (set) Token: 0x06023029 RID: 143401 RVA: 0x0033C414 File Offset: 0x0033A614
		public unsafe float TileRemovalRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNavigationInvokerComponent.__PropertyOffset_TileRemovalRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNavigationInvokerComponent.__PropertyOffset_TileRemovalRadius) = value;
			}
		}

		// Token: 0x0602302A RID: 143402 RVA: 0x0033C425 File Offset: 0x0033A625
		static UNavigationInvokerComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/NavigationSystem.NavigationInvokerComponent");
		}

		// Token: 0x0602302B RID: 143403 RVA: 0x0033C433 File Offset: 0x0033A633
		protected UNavigationInvokerComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012B14 RID: 76564
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/NavigationSystem.NavigationInvokerComponent";

		// Token: 0x04012B15 RID: 76565
		private static IntPtr _ClassPtr;

		// Token: 0x04012B16 RID: 76566
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04012B17 RID: 76567
		internal static int __PropertyOffset_TileGenerationRadius;

		// Token: 0x04012B18 RID: 76568
		internal static int __PropertyOffset_TileRemovalRadius;
	}
}
