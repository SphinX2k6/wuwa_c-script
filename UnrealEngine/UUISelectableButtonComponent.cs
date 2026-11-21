using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000720 RID: 1824
	[UnrealObjectPath("/Script/LGUI.UISelectableButtonComponent")]
	[UnrealStructLayout(1688, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1688)]
	public class UUISelectableButtonComponent : UUIButtonComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06009D81 RID: 40321 RVA: 0x000EAB34 File Offset: 0x000E8D34
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUISelectableButtonComponent._ClassPtr;
		}

		// Token: 0x06009D82 RID: 40322 RVA: 0x000EAB40 File Offset: 0x000E8D40
		public UUISelectableButtonComponent() : this(BuiltinUtils.AllocNativeUObject(UUISelectableButtonComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06009D83 RID: 40323 RVA: 0x000EAB68 File Offset: 0x000E8D68
		[NullableContext(1)]
		public UUISelectableButtonComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UUISelectableButtonComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06009D84 RID: 40324 RVA: 0x000EAB9B File Offset: 0x000E8D9B
		public void SetForceSelect(bool forceSelect)
		{
			UUISelectableButtonComponent.__SetForceSelect_Internal(base.NativePtr, forceSelect);
		}

		// Token: 0x06009D85 RID: 40325
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetForceSelect_Internal(IntPtr @this, bool forceSelect);

		// Token: 0x06009D86 RID: 40326 RVA: 0x000EABA9 File Offset: 0x000E8DA9
		static UUISelectableButtonComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UISelectableButtonComponent");
		}

		// Token: 0x06009D87 RID: 40327 RVA: 0x000EABB7 File Offset: 0x000E8DB7
		protected UUISelectableButtonComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040043C6 RID: 17350
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.UISelectableButtonComponent";

		// Token: 0x040043C7 RID: 17351
		private static IntPtr _ClassPtr;

		// Token: 0x040043C8 RID: 17352
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
