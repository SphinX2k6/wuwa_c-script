using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002014 RID: 8212
	[UnrealObjectPath("/Script/LGUI.GuideHookRegistry")]
	[UnrealStructLayout(360, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 360)]
	public class UGuideHookRegistry : UActorComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601EF39 RID: 126777 RVA: 0x002E0752 File Offset: 0x002DE952
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UGuideHookRegistry._ClassPtr;
		}

		// Token: 0x0601EF3A RID: 126778 RVA: 0x002E0760 File Offset: 0x002DE960
		public UGuideHookRegistry() : this(BuiltinUtils.AllocNativeUObject(UGuideHookRegistry.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601EF3B RID: 126779 RVA: 0x002E0788 File Offset: 0x002DE988
		[NullableContext(1)]
		public UGuideHookRegistry(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UGuideHookRegistry.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007B3B RID: 31547
		// (get) Token: 0x0601EF3C RID: 126780 RVA: 0x002E07BC File Offset: 0x002DE9BC
		// (set) Token: 0x0601EF3D RID: 126781 RVA: 0x002E07F5 File Offset: 0x002DE9F5
		[Nullable(new byte[]
		{
			1,
			1,
			0,
			1
		})]
		public TMap<string, TWeakObjectPtr<AActor>> GuideHookComponents
		{
			[return: Nullable(new byte[]
			{
				1,
				1,
				0,
				1
			})]
			get
			{
				base.FastCheckIsValid();
				TMap<string, TWeakObjectPtr<AActor>> result;
				if ((result = this._GuideHookComponents) == null)
				{
					result = (this._GuideHookComponents = new TMap<string, TWeakObjectPtr<AActor>>(base.NativePtr + (IntPtr)UGuideHookRegistry.__PropertyOffset_GuideHookComponents, this));
				}
				return result;
			}
			[param: Nullable(new byte[]
			{
				1,
				1,
				0,
				1
			})]
			set
			{
				this.GuideHookComponents.CopyAssign(value);
			}
		}

		// Token: 0x0601EF3E RID: 126782 RVA: 0x002E0803 File Offset: 0x002DEA03
		static UGuideHookRegistry()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.GuideHookRegistry");
		}

		// Token: 0x0601EF3F RID: 126783 RVA: 0x002E0811 File Offset: 0x002DEA11
		protected UGuideHookRegistry(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010D3F RID: 68927
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.GuideHookRegistry";

		// Token: 0x04010D40 RID: 68928
		private static IntPtr _ClassPtr;

		// Token: 0x04010D41 RID: 68929
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010D42 RID: 68930
		internal static int __PropertyOffset_GuideHookComponents;

		// Token: 0x04010D43 RID: 68931
		[Nullable(new byte[]
		{
			2,
			1,
			0,
			1
		})]
		private TMap<string, TWeakObjectPtr<AActor>> _GuideHookComponents;
	}
}
