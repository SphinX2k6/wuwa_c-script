using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001888 RID: 6280
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroGameplayUI.SimpleDamageViewInfo")]
	[UnrealStructLayout(184, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 184)]
	public class USimpleDamageViewInfo : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06017259 RID: 94809 RVA: 0x0021B9B6 File Offset: 0x00219BB6
		public new static UClassStackOnlyPtr StaticClass()
		{
			return USimpleDamageViewInfo._ClassPtr;
		}

		// Token: 0x0601725A RID: 94810 RVA: 0x0021B9C4 File Offset: 0x00219BC4
		public USimpleDamageViewInfo() : this(BuiltinUtils.AllocNativeUObject(USimpleDamageViewInfo.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601725B RID: 94811 RVA: 0x0021B9EC File Offset: 0x00219BEC
		[NullableContext(1)]
		public USimpleDamageViewInfo(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(USimpleDamageViewInfo.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005D27 RID: 23847
		// (get) Token: 0x0601725C RID: 94812 RVA: 0x0021BA1F File Offset: 0x00219C1F
		// (set) Token: 0x0601725D RID: 94813 RVA: 0x0021BA33 File Offset: 0x00219C33
		public unsafe USimpleDamageView SimpleDamageView
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USimpleDamageView>(base.NativePtr / (IntPtr)sizeof(void*) + USimpleDamageViewInfo.__PropertyOffset_SimpleDamageView);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + USimpleDamageViewInfo.__PropertyOffset_SimpleDamageView, value);
			}
		}

		// Token: 0x17005D28 RID: 23848
		// (get) Token: 0x0601725E RID: 94814 RVA: 0x0021BA48 File Offset: 0x00219C48
		// (set) Token: 0x0601725F RID: 94815 RVA: 0x0021BA5C File Offset: 0x00219C5C
		public unsafe UGeometryHandle GeometryHandle
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UGeometryHandle>(base.NativePtr / (IntPtr)sizeof(void*) + USimpleDamageViewInfo.__PropertyOffset_GeometryHandle);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + USimpleDamageViewInfo.__PropertyOffset_GeometryHandle, value);
			}
		}

		// Token: 0x06017260 RID: 94816 RVA: 0x0021BA71 File Offset: 0x00219C71
		static USimpleDamageViewInfo()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroGameplayUI.SimpleDamageViewInfo");
		}

		// Token: 0x06017261 RID: 94817 RVA: 0x0021BA7F File Offset: 0x00219C7F
		protected USimpleDamageViewInfo(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400C8DE RID: 51422
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroGameplayUI.SimpleDamageViewInfo";

		// Token: 0x0400C8DF RID: 51423
		private static IntPtr _ClassPtr;

		// Token: 0x0400C8E0 RID: 51424
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400C8E1 RID: 51425
		internal static int __PropertyOffset_SimpleDamageView;

		// Token: 0x0400C8E2 RID: 51426
		internal static int __PropertyOffset_GeometryHandle;
	}
}
