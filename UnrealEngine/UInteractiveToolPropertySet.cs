using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200157E RID: 5502
	[UnrealObjectPath("/Script/InteractiveToolsFramework.InteractiveToolPropertySet")]
	[UnrealStructLayout(104, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 104)]
	public class UInteractiveToolPropertySet : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06013E1D RID: 81437 RVA: 0x001D3196 File Offset: 0x001D1396
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UInteractiveToolPropertySet._ClassPtr;
		}

		// Token: 0x06013E1E RID: 81438 RVA: 0x001D31A4 File Offset: 0x001D13A4
		public UInteractiveToolPropertySet() : this(BuiltinUtils.AllocNativeUObject(UInteractiveToolPropertySet.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06013E1F RID: 81439 RVA: 0x001D31CC File Offset: 0x001D13CC
		[NullableContext(1)]
		public UInteractiveToolPropertySet(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UInteractiveToolPropertySet.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004DD8 RID: 19928
		// (get) Token: 0x06013E20 RID: 81440 RVA: 0x001D31FF File Offset: 0x001D13FF
		// (set) Token: 0x06013E21 RID: 81441 RVA: 0x001D3213 File Offset: 0x001D1413
		[Nullable(2)]
		public unsafe UInteractiveToolPropertySet CachedProperties
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UInteractiveToolPropertySet>(base.NativePtr / (IntPtr)sizeof(void*) + UInteractiveToolPropertySet.__PropertyOffset_CachedProperties);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UInteractiveToolPropertySet.__PropertyOffset_CachedProperties, value);
			}
		}

		// Token: 0x17004DD9 RID: 19929
		// (get) Token: 0x06013E22 RID: 81442 RVA: 0x001D3228 File Offset: 0x001D1428
		// (set) Token: 0x06013E23 RID: 81443 RVA: 0x001D3238 File Offset: 0x001D1438
		public unsafe bool bIsPropertySetEnabled
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UInteractiveToolPropertySet.__PropertyOffset_bIsPropertySetEnabled) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UInteractiveToolPropertySet.__PropertyOffset_bIsPropertySetEnabled) = (value ? 1 : 0);
			}
		}

		// Token: 0x06013E24 RID: 81444 RVA: 0x001D3249 File Offset: 0x001D1449
		static UInteractiveToolPropertySet()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/InteractiveToolsFramework.InteractiveToolPropertySet");
		}

		// Token: 0x06013E25 RID: 81445 RVA: 0x001D3257 File Offset: 0x001D1457
		protected UInteractiveToolPropertySet(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400AC23 RID: 44067
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/InteractiveToolsFramework.InteractiveToolPropertySet";

		// Token: 0x0400AC24 RID: 44068
		private static IntPtr _ClassPtr;

		// Token: 0x0400AC25 RID: 44069
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400AC26 RID: 44070
		internal static int __PropertyOffset_CachedProperties;

		// Token: 0x0400AC27 RID: 44071
		internal static int __PropertyOffset_bIsPropertySetEnabled;
	}
}
