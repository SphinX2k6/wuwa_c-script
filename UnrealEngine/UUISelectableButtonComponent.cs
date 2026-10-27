using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020021A8 RID: 8616
	[UnrealObjectPath("/Script/LGUI.UISelectableButtonComponent")]
	[UnrealStructLayout(1688, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1688)]
	public class UUISelectableButtonComponent : UUIButtonComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06020B70 RID: 134000 RVA: 0x0030621D File Offset: 0x0030441D
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUISelectableButtonComponent._ClassPtr;
		}

		// Token: 0x06020B71 RID: 134001 RVA: 0x0030622C File Offset: 0x0030442C
		public UUISelectableButtonComponent() : this(BuiltinUtils.AllocNativeUObject(UUISelectableButtonComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06020B72 RID: 134002 RVA: 0x00306254 File Offset: 0x00304454
		[NullableContext(1)]
		public UUISelectableButtonComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UUISelectableButtonComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06020B73 RID: 134003 RVA: 0x00306287 File Offset: 0x00304487
		public void SetForceSelect(bool forceSelect)
		{
			UUISelectableButtonComponent.__SetForceSelect_Internal(base.NativePtr, forceSelect);
		}

		// Token: 0x06020B74 RID: 134004
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetForceSelect_Internal(IntPtr @this, bool forceSelect);

		// Token: 0x06020B75 RID: 134005 RVA: 0x00306295 File Offset: 0x00304495
		static UUISelectableButtonComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UISelectableButtonComponent");
		}

		// Token: 0x06020B76 RID: 134006 RVA: 0x003062A3 File Offset: 0x003044A3
		protected UUISelectableButtonComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040117DF RID: 71647
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.UISelectableButtonComponent";

		// Token: 0x040117E0 RID: 71648
		private static IntPtr _ClassPtr;

		// Token: 0x040117E1 RID: 71649
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
