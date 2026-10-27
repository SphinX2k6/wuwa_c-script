using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200174B RID: 5963
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroCollision.LevelLandscapeCollisionActor")]
	[UnrealStructLayout(1072, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1072)]
	public class ALevelLandscapeCollisionActor : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06015743 RID: 87875 RVA: 0x001F8743 File Offset: 0x001F6943
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ALevelLandscapeCollisionActor._ClassPtr;
		}

		// Token: 0x06015744 RID: 87876 RVA: 0x001F8750 File Offset: 0x001F6950
		public ALevelLandscapeCollisionActor() : this(BuiltinUtils.AllocNativeUObject(ALevelLandscapeCollisionActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06015745 RID: 87877 RVA: 0x001F8778 File Offset: 0x001F6978
		[NullableContext(1)]
		public ALevelLandscapeCollisionActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ALevelLandscapeCollisionActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170054AF RID: 21679
		// (get) Token: 0x06015746 RID: 87878 RVA: 0x001F87AB File Offset: 0x001F69AB
		// (set) Token: 0x06015747 RID: 87879 RVA: 0x001F87BF File Offset: 0x001F69BF
		public unsafe UPhysicalMaterial DefaultPhysMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPhysicalMaterial>(base.NativePtr / (IntPtr)sizeof(void*) + ALevelLandscapeCollisionActor.__PropertyOffset_DefaultPhysMaterial);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ALevelLandscapeCollisionActor.__PropertyOffset_DefaultPhysMaterial, value);
			}
		}

		// Token: 0x170054B0 RID: 21680
		// (get) Token: 0x06015748 RID: 87880 RVA: 0x001F87D4 File Offset: 0x001F69D4
		// (set) Token: 0x06015749 RID: 87881 RVA: 0x001F87E8 File Offset: 0x001F69E8
		public unsafe UKuroLandscapeHeightfieldCollisionComponent CollisionComponent
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroLandscapeHeightfieldCollisionComponent>(base.NativePtr / (IntPtr)sizeof(void*) + ALevelLandscapeCollisionActor.__PropertyOffset_CollisionComponent);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ALevelLandscapeCollisionActor.__PropertyOffset_CollisionComponent, value);
			}
		}

		// Token: 0x0601574A RID: 87882 RVA: 0x001F87FD File Offset: 0x001F69FD
		static ALevelLandscapeCollisionActor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroCollision.LevelLandscapeCollisionActor");
		}

		// Token: 0x0601574B RID: 87883 RVA: 0x001F880B File Offset: 0x001F6A0B
		protected ALevelLandscapeCollisionActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400BB1F RID: 47903
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroCollision.LevelLandscapeCollisionActor";

		// Token: 0x0400BB20 RID: 47904
		private static IntPtr _ClassPtr;

		// Token: 0x0400BB21 RID: 47905
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400BB22 RID: 47906
		internal static int __PropertyOffset_DefaultPhysMaterial;

		// Token: 0x0400BB23 RID: 47907
		internal static int __PropertyOffset_CollisionComponent;
	}
}
