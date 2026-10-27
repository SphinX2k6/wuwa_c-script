using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200174A RID: 5962
	[UnrealObjectPath("/Script/KuroCollision.LevelCollisionActor")]
	[UnrealStructLayout(1064, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1064)]
	public class ALevelCollisionActor : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601573C RID: 87868 RVA: 0x001F869A File Offset: 0x001F689A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ALevelCollisionActor._ClassPtr;
		}

		// Token: 0x0601573D RID: 87869 RVA: 0x001F86A8 File Offset: 0x001F68A8
		public ALevelCollisionActor() : this(BuiltinUtils.AllocNativeUObject(ALevelCollisionActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601573E RID: 87870 RVA: 0x001F86D0 File Offset: 0x001F68D0
		[NullableContext(1)]
		public ALevelCollisionActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ALevelCollisionActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170054AE RID: 21678
		// (get) Token: 0x0601573F RID: 87871 RVA: 0x001F8703 File Offset: 0x001F6903
		// (set) Token: 0x06015740 RID: 87872 RVA: 0x001F8717 File Offset: 0x001F6917
		[Nullable(2)]
		public unsafe UCollisionClusterComponent CollisionClusterComponent
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCollisionClusterComponent>(base.NativePtr / (IntPtr)sizeof(void*) + ALevelCollisionActor.__PropertyOffset_CollisionClusterComponent);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ALevelCollisionActor.__PropertyOffset_CollisionClusterComponent, value);
			}
		}

		// Token: 0x06015741 RID: 87873 RVA: 0x001F872C File Offset: 0x001F692C
		static ALevelCollisionActor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroCollision.LevelCollisionActor");
		}

		// Token: 0x06015742 RID: 87874 RVA: 0x001F873A File Offset: 0x001F693A
		protected ALevelCollisionActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400BB1B RID: 47899
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroCollision.LevelCollisionActor";

		// Token: 0x0400BB1C RID: 47900
		private static IntPtr _ClassPtr;

		// Token: 0x0400BB1D RID: 47901
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400BB1E RID: 47902
		internal static int __PropertyOffset_CollisionClusterComponent;
	}
}
