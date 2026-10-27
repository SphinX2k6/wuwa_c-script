using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020008F7 RID: 2295
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.BrushComponent")]
	[UnrealStructLayout(1600, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1600)]
	public class UBrushComponent : UPrimitiveComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06007DF8 RID: 32248 RVA: 0x000B48C9 File Offset: 0x000B2AC9
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UBrushComponent._ClassPtr;
		}

		// Token: 0x06007DF9 RID: 32249 RVA: 0x000B48D8 File Offset: 0x000B2AD8
		public UBrushComponent() : this(BuiltinUtils.AllocNativeUObject(UBrushComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06007DFA RID: 32250 RVA: 0x000B4900 File Offset: 0x000B2B00
		[NullableContext(1)]
		public UBrushComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UBrushComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001D9C RID: 7580
		// (get) Token: 0x06007DFB RID: 32251 RVA: 0x000B4933 File Offset: 0x000B2B33
		// (set) Token: 0x06007DFC RID: 32252 RVA: 0x000B4947 File Offset: 0x000B2B47
		public unsafe UModel Brush
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UModel>(base.NativePtr / (IntPtr)sizeof(void*) + UBrushComponent.__PropertyOffset_Brush);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UBrushComponent.__PropertyOffset_Brush, value);
			}
		}

		// Token: 0x17001D9D RID: 7581
		// (get) Token: 0x06007DFD RID: 32253 RVA: 0x000B495C File Offset: 0x000B2B5C
		// (set) Token: 0x06007DFE RID: 32254 RVA: 0x000B4970 File Offset: 0x000B2B70
		public unsafe UBodySetup BrushBodySetup
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBodySetup>(base.NativePtr / (IntPtr)sizeof(void*) + UBrushComponent.__PropertyOffset_BrushBodySetup);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UBrushComponent.__PropertyOffset_BrushBodySetup, value);
			}
		}

		// Token: 0x06007DFF RID: 32255 RVA: 0x000B4985 File Offset: 0x000B2B85
		static UBrushComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.BrushComponent");
		}

		// Token: 0x06007E00 RID: 32256 RVA: 0x000B4993 File Offset: 0x000B2B93
		protected UBrushComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04003C65 RID: 15461
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.BrushComponent";

		// Token: 0x04003C66 RID: 15462
		private static IntPtr _ClassPtr;

		// Token: 0x04003C67 RID: 15463
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04003C68 RID: 15464
		internal static int __PropertyOffset_Brush;

		// Token: 0x04003C69 RID: 15465
		internal static int __PropertyOffset_BrushBodySetup;
	}
}
