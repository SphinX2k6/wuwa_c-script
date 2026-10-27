using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002195 RID: 8597
	[UnrealObjectPath("/Script/LGUI.UIPolygonActor")]
	[UnrealStructLayout(1672, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1672)]
	public class AUIPolygonActor : AUIBaseActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060209BB RID: 133563 RVA: 0x00304488 File Offset: 0x00302688
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AUIPolygonActor._ClassPtr;
		}

		// Token: 0x060209BC RID: 133564 RVA: 0x00304494 File Offset: 0x00302694
		public AUIPolygonActor() : this(BuiltinUtils.AllocNativeUObject(AUIPolygonActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060209BD RID: 133565 RVA: 0x003044BC File Offset: 0x003026BC
		[NullableContext(1)]
		public AUIPolygonActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AUIPolygonActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007F7B RID: 32635
		// (get) Token: 0x060209BE RID: 133566 RVA: 0x003044EF File Offset: 0x003026EF
		// (set) Token: 0x060209BF RID: 133567 RVA: 0x00304503 File Offset: 0x00302703
		[Nullable(2)]
		public unsafe UUIPolygon UIPolygon
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UUIPolygon>(base.NativePtr / (IntPtr)sizeof(void*) + AUIPolygonActor.__PropertyOffset_UIPolygon);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AUIPolygonActor.__PropertyOffset_UIPolygon, value);
			}
		}

		// Token: 0x060209C0 RID: 133568 RVA: 0x00304518 File Offset: 0x00302718
		static AUIPolygonActor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UIPolygonActor");
		}

		// Token: 0x060209C1 RID: 133569 RVA: 0x00304526 File Offset: 0x00302726
		protected AUIPolygonActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011738 RID: 71480
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.UIPolygonActor";

		// Token: 0x04011739 RID: 71481
		private static IntPtr _ClassPtr;

		// Token: 0x0401173A RID: 71482
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401173B RID: 71483
		internal static int __PropertyOffset_UIPolygon;
	}
}
