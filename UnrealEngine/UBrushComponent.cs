using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000197 RID: 407
	[UnrealObjectPath("/Script/Engine.BrushComponent")]
	[UnrealStructLayout(1600, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1600)]
	public class UBrushComponent : UPrimitiveComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06001B53 RID: 6995 RVA: 0x00028B32 File Offset: 0x00026D32
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UBrushComponent._ClassPtr;
		}

		// Token: 0x06001B54 RID: 6996 RVA: 0x00028B40 File Offset: 0x00026D40
		public UBrushComponent() : this(BuiltinUtils.AllocNativeUObject(UBrushComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06001B55 RID: 6997 RVA: 0x00028B68 File Offset: 0x00026D68
		[NullableContext(1)]
		public UBrushComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UBrushComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17000344 RID: 836
		// (get) Token: 0x06001B56 RID: 6998 RVA: 0x00028B9B File Offset: 0x00026D9B
		// (set) Token: 0x06001B57 RID: 6999 RVA: 0x00028BAF File Offset: 0x00026DAF
		[Nullable(2)]
		public unsafe UBodySetup BrushBodySetup
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBodySetup>(base.NativePtr / (IntPtr)sizeof(void*) + UBrushComponent.__PropertyOffset_BrushBodySetup);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UBrushComponent.__PropertyOffset_BrushBodySetup, value);
			}
		}

		// Token: 0x06001B58 RID: 7000 RVA: 0x00028BC4 File Offset: 0x00026DC4
		static UBrushComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.BrushComponent");
		}

		// Token: 0x06001B59 RID: 7001 RVA: 0x00028BD2 File Offset: 0x00026DD2
		protected UBrushComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040008D5 RID: 2261
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.BrushComponent";

		// Token: 0x040008D6 RID: 2262
		private static IntPtr _ClassPtr;

		// Token: 0x040008D7 RID: 2263
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040008D8 RID: 2264
		internal static int __PropertyOffset_BrushBodySetup;
	}
}
