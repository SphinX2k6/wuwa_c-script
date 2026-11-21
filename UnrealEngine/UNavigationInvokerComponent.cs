using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000797 RID: 1943
	[UnrealObjectPath("/Script/NavigationSystem.NavigationInvokerComponent")]
	[UnrealStructLayout(208, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 208)]
	public class UNavigationInvokerComponent : UActorComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600A7B8 RID: 42936 RVA: 0x000F794D File Offset: 0x000F5B4D
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UNavigationInvokerComponent._ClassPtr;
		}

		// Token: 0x0600A7B9 RID: 42937 RVA: 0x000F795C File Offset: 0x000F5B5C
		public UNavigationInvokerComponent() : this(BuiltinUtils.AllocNativeUObject(UNavigationInvokerComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600A7BA RID: 42938 RVA: 0x000F7984 File Offset: 0x000F5B84
		[NullableContext(1)]
		public UNavigationInvokerComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UNavigationInvokerComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001F33 RID: 7987
		// (get) Token: 0x0600A7BB RID: 42939 RVA: 0x000F79B7 File Offset: 0x000F5BB7
		// (set) Token: 0x0600A7BC RID: 42940 RVA: 0x000F79C7 File Offset: 0x000F5BC7
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

		// Token: 0x17001F34 RID: 7988
		// (get) Token: 0x0600A7BD RID: 42941 RVA: 0x000F79D8 File Offset: 0x000F5BD8
		// (set) Token: 0x0600A7BE RID: 42942 RVA: 0x000F79E8 File Offset: 0x000F5BE8
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

		// Token: 0x0600A7BF RID: 42943 RVA: 0x000F79F9 File Offset: 0x000F5BF9
		static UNavigationInvokerComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/NavigationSystem.NavigationInvokerComponent");
		}

		// Token: 0x0600A7C0 RID: 42944 RVA: 0x000F7A07 File Offset: 0x000F5C07
		protected UNavigationInvokerComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040047E4 RID: 18404
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/NavigationSystem.NavigationInvokerComponent";

		// Token: 0x040047E5 RID: 18405
		private static IntPtr _ClassPtr;

		// Token: 0x040047E6 RID: 18406
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040047E7 RID: 18407
		internal static int __PropertyOffset_TileGenerationRadius;

		// Token: 0x040047E8 RID: 18408
		internal static int __PropertyOffset_TileRemovalRadius;
	}
}
