using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000954 RID: 2388
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.ComponentDelegateBinding")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 64)]
	public class UComponentDelegateBinding : UDynamicBlueprintBinding, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06008728 RID: 34600 RVA: 0x000C1165 File Offset: 0x000BF365
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UComponentDelegateBinding._ClassPtr;
		}

		// Token: 0x06008729 RID: 34601 RVA: 0x000C1174 File Offset: 0x000BF374
		public UComponentDelegateBinding() : this(BuiltinUtils.AllocNativeUObject(UComponentDelegateBinding.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600872A RID: 34602 RVA: 0x000C119C File Offset: 0x000BF39C
		public UComponentDelegateBinding(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UComponentDelegateBinding.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001FF8 RID: 8184
		// (get) Token: 0x0600872B RID: 34603 RVA: 0x000C11D0 File Offset: 0x000BF3D0
		// (set) Token: 0x0600872C RID: 34604 RVA: 0x000C1209 File Offset: 0x000BF409
		public TArray<FBlueprintComponentDelegateBinding> ComponentDelegateBindings
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FBlueprintComponentDelegateBinding> result;
				if ((result = this._ComponentDelegateBindings) == null)
				{
					result = (this._ComponentDelegateBindings = new TArray<FBlueprintComponentDelegateBinding>(base.NativePtr + (IntPtr)UComponentDelegateBinding.__PropertyOffset_ComponentDelegateBindings, this));
				}
				return result;
			}
			set
			{
				this.ComponentDelegateBindings.CopyAssign(value);
			}
		}

		// Token: 0x0600872D RID: 34605 RVA: 0x000C1217 File Offset: 0x000BF417
		static UComponentDelegateBinding()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.ComponentDelegateBinding");
		}

		// Token: 0x0600872E RID: 34606 RVA: 0x000C1225 File Offset: 0x000BF425
		protected UComponentDelegateBinding(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400404F RID: 16463
		public new const string __ObjectPath = "/Script/Engine.ComponentDelegateBinding";

		// Token: 0x04004050 RID: 16464
		private static IntPtr _ClassPtr;

		// Token: 0x04004051 RID: 16465
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04004052 RID: 16466
		internal static int __PropertyOffset_ComponentDelegateBindings;

		// Token: 0x04004053 RID: 16467
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FBlueprintComponentDelegateBinding> _ComponentDelegateBindings;
	}
}
