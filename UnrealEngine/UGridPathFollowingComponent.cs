using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020001CA RID: 458
	[UnrealObjectPath("/Script/AIModule.GridPathFollowingComponent")]
	[UnrealStructLayout(696, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 696)]
	public class UGridPathFollowingComponent : UPathFollowingComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06001B1C RID: 6940 RVA: 0x000286EA File Offset: 0x000268EA
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UGridPathFollowingComponent._ClassPtr;
		}

		// Token: 0x06001B1D RID: 6941 RVA: 0x000286F8 File Offset: 0x000268F8
		public UGridPathFollowingComponent() : this(BuiltinUtils.AllocNativeUObject(UGridPathFollowingComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06001B1E RID: 6942 RVA: 0x00028720 File Offset: 0x00026920
		[NullableContext(1)]
		public UGridPathFollowingComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UGridPathFollowingComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170006F9 RID: 1785
		// (get) Token: 0x06001B1F RID: 6943 RVA: 0x00028753 File Offset: 0x00026953
		// (set) Token: 0x06001B20 RID: 6944 RVA: 0x00028767 File Offset: 0x00026967
		[Nullable(2)]
		public unsafe UNavLocalGridManager GridManager
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNavLocalGridManager>(base.NativePtr / (IntPtr)sizeof(void*) + UGridPathFollowingComponent.__PropertyOffset_GridManager);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UGridPathFollowingComponent.__PropertyOffset_GridManager, value);
			}
		}

		// Token: 0x06001B21 RID: 6945 RVA: 0x0002877C File Offset: 0x0002697C
		static UGridPathFollowingComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AIModule.GridPathFollowingComponent");
		}

		// Token: 0x06001B22 RID: 6946 RVA: 0x0002878A File Offset: 0x0002698A
		protected UGridPathFollowingComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040008AC RID: 2220
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AIModule.GridPathFollowingComponent";

		// Token: 0x040008AD RID: 2221
		private static IntPtr _ClassPtr;

		// Token: 0x040008AE RID: 2222
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040008AF RID: 2223
		internal static int __PropertyOffset_GridManager;
	}
}
