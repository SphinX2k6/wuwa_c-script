using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020024AC RID: 9388
	[UnrealObjectPath("/Script/NavigationSystem.RecastFilter_UseDefaultArea")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 80)]
	public class URecastFilter_UseDefaultArea : UNavigationQueryFilter, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060231F8 RID: 143864 RVA: 0x0033F1D7 File Offset: 0x0033D3D7
		public new static UClassStackOnlyPtr StaticClass()
		{
			return URecastFilter_UseDefaultArea._ClassPtr;
		}

		// Token: 0x060231F9 RID: 143865 RVA: 0x0033F1E4 File Offset: 0x0033D3E4
		public URecastFilter_UseDefaultArea() : this(BuiltinUtils.AllocNativeUObject(URecastFilter_UseDefaultArea.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060231FA RID: 143866 RVA: 0x0033F20C File Offset: 0x0033D40C
		[NullableContext(1)]
		public URecastFilter_UseDefaultArea(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(URecastFilter_UseDefaultArea.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060231FB RID: 143867 RVA: 0x0033F23F File Offset: 0x0033D43F
		static URecastFilter_UseDefaultArea()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/NavigationSystem.RecastFilter_UseDefaultArea");
		}

		// Token: 0x060231FC RID: 143868 RVA: 0x0033F24D File Offset: 0x0033D44D
		protected URecastFilter_UseDefaultArea(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012BFD RID: 76797
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/NavigationSystem.RecastFilter_UseDefaultArea";

		// Token: 0x04012BFE RID: 76798
		private static IntPtr _ClassPtr;

		// Token: 0x04012BFF RID: 76799
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
