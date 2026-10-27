using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002197 RID: 8599
	[UnrealObjectPath("/Script/LGUI.UIPolygonLineActor")]
	[UnrealStructLayout(1672, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1672)]
	public class AUIPolygonLineActor : AUIBaseActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060209E7 RID: 133607 RVA: 0x00304771 File Offset: 0x00302971
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AUIPolygonLineActor._ClassPtr;
		}

		// Token: 0x060209E8 RID: 133608 RVA: 0x00304780 File Offset: 0x00302980
		public AUIPolygonLineActor() : this(BuiltinUtils.AllocNativeUObject(AUIPolygonLineActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060209E9 RID: 133609 RVA: 0x003047A8 File Offset: 0x003029A8
		[NullableContext(1)]
		public AUIPolygonLineActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AUIPolygonLineActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007F82 RID: 32642
		// (get) Token: 0x060209EA RID: 133610 RVA: 0x003047DB File Offset: 0x003029DB
		// (set) Token: 0x060209EB RID: 133611 RVA: 0x003047EF File Offset: 0x003029EF
		[Nullable(2)]
		public unsafe UUIPolygonLine UIPolygonLine
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UUIPolygonLine>(base.NativePtr / (IntPtr)sizeof(void*) + AUIPolygonLineActor.__PropertyOffset_UIPolygonLine);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AUIPolygonLineActor.__PropertyOffset_UIPolygonLine, value);
			}
		}

		// Token: 0x060209EC RID: 133612 RVA: 0x00304804 File Offset: 0x00302A04
		static AUIPolygonLineActor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UIPolygonLineActor");
		}

		// Token: 0x060209ED RID: 133613 RVA: 0x00304812 File Offset: 0x00302A12
		protected AUIPolygonLineActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011747 RID: 71495
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.UIPolygonLineActor";

		// Token: 0x04011748 RID: 71496
		private static IntPtr _ClassPtr;

		// Token: 0x04011749 RID: 71497
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401174A RID: 71498
		internal static int __PropertyOffset_UIPolygonLine;
	}
}
