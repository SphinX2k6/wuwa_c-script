using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200171A RID: 5914
	[UnrealObjectPath("/Script/KuroBullet.ActionUpdateCollisionWorldEntity")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 56)]
	public class UActionUpdateCollisionWorldEntity : UActionUpdateCollision, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601552C RID: 87340 RVA: 0x001F575E File Offset: 0x001F395E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UActionUpdateCollisionWorldEntity._ClassPtr;
		}

		// Token: 0x0601552D RID: 87341 RVA: 0x001F576C File Offset: 0x001F396C
		public UActionUpdateCollisionWorldEntity() : this(BuiltinUtils.AllocNativeUObject(UActionUpdateCollisionWorldEntity.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601552E RID: 87342 RVA: 0x001F5794 File Offset: 0x001F3994
		[NullableContext(1)]
		public UActionUpdateCollisionWorldEntity(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UActionUpdateCollisionWorldEntity.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601552F RID: 87343 RVA: 0x001F57C7 File Offset: 0x001F39C7
		static UActionUpdateCollisionWorldEntity()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroBullet.ActionUpdateCollisionWorldEntity");
		}

		// Token: 0x06015530 RID: 87344 RVA: 0x001F57D5 File Offset: 0x001F39D5
		protected UActionUpdateCollisionWorldEntity(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400B9F6 RID: 47606
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroBullet.ActionUpdateCollisionWorldEntity";

		// Token: 0x0400B9F7 RID: 47607
		private static IntPtr _ClassPtr;

		// Token: 0x0400B9F8 RID: 47608
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
